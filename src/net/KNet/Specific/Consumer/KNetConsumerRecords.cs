﻿/*
*  Copyright 2024 MASES s.r.l.
*
*  Licensed under the Apache License, Version 2.0 (the "License");
*  you may not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
*  http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing, software
*  distributed under the License is distributed on an "AS IS" BASIS,
*  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
*  See the License for the specific language governing permissions and
*  limitations under the License.
*
*  Refer to LICENSE for more information.
*/

using MASES.KNet.Serialization;
using System.Collections.Generic;
using System.Threading;
using System;

namespace MASES.KNet.Consumer
{
    /// <summary>
    /// KNet extension of <see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerRecords{K, V}"/>
    /// </summary>
    /// <typeparam name="K">The key type</typeparam>
    /// <typeparam name="V">The value type</typeparam>
    public class KNetConsumerRecords<K, V> : IEnumerable<KNetConsumerRecord<K, V>>, IAsyncEnumerable<KNetConsumerRecord<K, V>>
    {
        readonly IKNetSerDes<K> _keyDeserializer;
        readonly IKNetSerDes<V> _valueDeserializer;
        readonly Org.Apache.Kafka.Clients.Consumer.ConsumerRecords<byte[], byte[]> _records;
        /// <summary>
        /// Initialize a new <see cref="KNetConsumerRecord{K, V}"/>
        /// </summary>
        /// <param name="records">The <see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerRecords{K, V}"/> to use for initialization</param>
        /// <param name="keyDeserializer">Key serializer base on <see cref="KNetSerDes{K}"/></param>
        /// <param name="valueDeserializer">Value serializer base on <see cref="KNetSerDes{K}"/></param>
        internal KNetConsumerRecords(Org.Apache.Kafka.Clients.Consumer.ConsumerRecords<byte[], byte[]> records, IKNetSerDes<K> keyDeserializer, IKNetSerDes<V> valueDeserializer)
        {
            _records = records;
            _keyDeserializer = keyDeserializer;
            _valueDeserializer = valueDeserializer;
            IsPrefecth = !(typeof(K).IsValueType && typeof(V).IsValueType);
        }
        /// <summary>
        /// <see langword="true"/> if enumeration will use prefetch and the number of records is more than <see cref="PrefetchThreshold"/>, i.e. the preparation of <see cref="KNetConsumerRecord{K, V}"/> happens in an external thread
        /// </summary>
        /// <remarks>It is <see langword="true"/> by default if one of <typeparamref name="K"/> or <typeparamref name="V"/> are not <see cref="ValueType"/>, override the value using <see cref="ApplyPrefetch(bool, int)"/></remarks>
        public bool IsPrefecth { get; private set; }
        /// <summary>
        /// The minimum threshold to activate pretech, i.e. the preparation of <see cref="KNetConsumerRecord{K, V}"/> happens in external thread if <see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerRecords{K, V}"/> contains more than <see cref="PrefetchThreshold"/> elements
        /// </summary>
        /// <remarks>The default value is 10, however it shall be chosen by the developer and in the decision shall be verified if external thread activation costs more than inline execution</remarks>
        public int PrefetchThreshold { get; private set; } = 10;
        /// <summary>
        /// <see langword="true"/> if the <see cref="KNetConsumerRecords{K, V}"/> is empty
        /// </summary>
        public bool IsEmpty => _records.IsEmpty();
        /// <summary>
        /// The number of elements in <see cref="KNetConsumerRecords{K, V}"/>
        /// </summary>
        public int Count => _records.Count();
        /// <summary>
        /// Set to <see langword="true"/> to enable enumeration with prefetch over <paramref name="prefetchThreshold"/> threshold, i.e. preparation of <see cref="KNetConsumerRecord{K, V}"/> in external thread 
        /// </summary>
        /// <param name="enablePrefetch"><see langword="true"/> to enable prefetch. See <see cref="IsPrefecth"/></param>
        /// <param name="prefetchThreshold">The minimum threshold to activate pretech, default is 10. See <see cref="PrefetchThreshold"/></param>
        /// <returns>This instance with <paramref name="enablePrefetch"/> and <paramref name="prefetchThreshold"/> set</returns>
        /// <remarks>Setting <paramref name="prefetchThreshold"/> to a value less, or equal, to 0 and <paramref name="enablePrefetch"/> to <see langword="true"/>, the prefetch is always actived</remarks>
        public KNetConsumerRecords<K, V> ApplyPrefetch(bool enablePrefetch = true, int prefetchThreshold = 10)
        {
            IsPrefecth = enablePrefetch;
            PrefetchThreshold = IsPrefecth ? prefetchThreshold : -1;
            return this;
        }

        bool UsePrefetch()
        {
            return IsPrefecth &&
                (PrefetchThreshold <= 0 || _records.Count() > PrefetchThreshold);
        }

        IEnumerator<KNetConsumerRecord<K, V>> IEnumerable<KNetConsumerRecord<K, V>>.GetEnumerator()
        {
            if (UsePrefetch())
                return new KNetConsumerRecordsPrefetchableEnumerator<K, V>(_records.Iterator(), _keyDeserializer, _valueDeserializer, false);
            else
                return new KNetConsumerRecordsEnumerator<K, V>(_records, _keyDeserializer, _valueDeserializer);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            if (UsePrefetch())
                return new KNetConsumerRecordsPrefetchableEnumerator<K, V>(_records.Iterator(), _keyDeserializer, _valueDeserializer, false);
            else
                return new KNetConsumerRecordsEnumerator<K, V>(_records, _keyDeserializer, _valueDeserializer);
        }

        IAsyncEnumerator<KNetConsumerRecord<K, V>> IAsyncEnumerable<KNetConsumerRecord<K, V>>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            if (UsePrefetch())
                return new KNetConsumerRecordsPrefetchableEnumerator<K, V>(_records.Iterator(), _keyDeserializer, _valueDeserializer, true, cancellationToken);
            else
                return new KNetConsumerRecordsEnumerator<K, V>(_records, _keyDeserializer, _valueDeserializer, cancellationToken);
        }
    }
}
