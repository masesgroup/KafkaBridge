﻿/*
*  Copyright 2025 MASES s.r.l.
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

using MASES.JCOBridge.C2JBridge;
using MASES.JCOBridge.C2JBridge.JVMInterop;
using MASES.KNet.Serialization;
using MASES.KNet.Streams.Kstream;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MASES.KNet.Streams.State
{
    /// <summary>
    /// KNet implementation of <see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator{TJVMK, TJVMV}"/> 
    /// </summary>
    /// <typeparam name="K">The key type</typeparam>
    /// <typeparam name="V">The value type</typeparam>
    /// <typeparam name="TJVMK">The JVM type of <typeparamref name="K"/></typeparam>
    /// <typeparam name="TJVMV">The JVM type of <typeparamref name="V"/></typeparam>
    public sealed class TimestampedWindowedKeyValueIterator<K, V, TJVMK, TJVMV> : CommonIterator<TimestampedWindowedKeyValue<K, V, TJVMK, TJVMV>>
    {
#if NET7_0_OR_GREATER
        sealed class PrefetchableLocalEnumerator(IGenericSerDesFactory factory,
                                                 IJavaObject obj,
                                                 bool isAsync, CancellationToken token = default)
            : JVMBridgeBasePrefetchableEnumerator<TimestampedWindowedKeyValue<K, V, TJVMK, TJVMV>>(obj, new PrefetchableEnumeratorSettings()),
              IGenericSerDesFactoryApplier,
              IAsyncEnumerator<TimestampedWindowedKeyValue<K, V, TJVMK, TJVMV>>
        {
            IGenericSerDesFactory _factory = factory;
            IGenericSerDesFactory IGenericSerDesFactoryApplier.Factory { get => _factory; set { _factory = value; } }

            protected override object ConvertObject(object input)
            {
                if (input is IJavaObject obj)
                {
                    return new TimestampedWindowedKeyValue<K, V, TJVMK, TJVMV>(factory, new KeyValueSupport<Org.Apache.Kafka.Streams.Kstream.Windowed<TJVMK>, Org.Apache.Kafka.Streams.State.ValueAndTimestamp<TJVMV>>(obj));
                }
                throw new InvalidCastException($"input is not a valid IJavaObject");
            }

            protected override bool DoWorkCycle()
            {
                return isAsync ? !token.IsCancellationRequested : base.DoWorkCycle();
            }

            public TimestampedWindowedKeyValue<K, V, TJVMK, TJVMV> Current => (this as IEnumerator<TimestampedWindowedKeyValue<K, V, TJVMK, TJVMV>>).Current;

            public ValueTask<bool> MoveNextAsync()
            {
                return new ValueTask<bool>(MoveNext());
            }

            public ValueTask DisposeAsync()
            {
                Dispose();
                return new ValueTask();
            }
        }
#endif

        sealed class StandardLocalEnumerator : JVMBridgeBaseEnumerator<TimestampedWindowedKeyValue<K, V, TJVMK, TJVMV>>, IGenericSerDesFactoryApplier, IAsyncEnumerator<TimestampedWindowedKeyValue<K, V, TJVMK, TJVMV>>
        {
            IGenericSerDesFactory _factory;
            IGenericSerDesFactory IGenericSerDesFactoryApplier.Factory { get => _factory; set { _factory = value; } }

            public StandardLocalEnumerator(IGenericSerDesFactory factory, IJavaObject obj) : base(obj)
            {
                _factory = factory;
            }

            protected override object ConvertObject(object input)
            {
                if (input is IJavaObject obj)
                {
                    return new TimestampedWindowedKeyValue<K, V, TJVMK, TJVMV>(_factory, new KeyValueSupport<Org.Apache.Kafka.Streams.Kstream.Windowed<TJVMK>, Org.Apache.Kafka.Streams.State.ValueAndTimestamp<TJVMV>>(obj));
                }
                throw new InvalidCastException($"input is not a valid IJavaObject");
            }

            public TimestampedWindowedKeyValue<K, V, TJVMK, TJVMV> Current => (this as IEnumerator<TimestampedWindowedKeyValue<K, V, TJVMK, TJVMV>>).Current;

            public ValueTask<bool> MoveNextAsync()
            {
                return new ValueTask<bool>(MoveNext());
            }

            public ValueTask DisposeAsync()
            {
                Dispose();
                return new ValueTask();
            }
        }

        readonly Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<TJVMK>, Org.Apache.Kafka.Streams.State.ValueAndTimestamp<TJVMV>> _iterator;

        internal TimestampedWindowedKeyValueIterator(IGenericSerDesFactory factory, Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<TJVMK>, Org.Apache.Kafka.Streams.State.ValueAndTimestamp<TJVMV>> iterator)
            : base(factory)
        {
            _iterator = iterator;
        }

        /// <inheritdoc/>
        protected sealed override object GetEnumerator(bool isAsync, bool usePrefetch, CancellationToken cancellationToken = default)
        {
            IGenericSerDesFactory factory = Factory;
#if NET7_0_OR_GREATER
            if (usePrefetch)
            {
                return new PrefetchableLocalEnumerator(factory, _iterator.BridgeInstance, isAsync, cancellationToken);
            }
#endif
            return new StandardLocalEnumerator(factory, _iterator.BridgeInstance);
        }
        /// <summary>
        /// KNet implementation of <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Iterator.html#hasNext()"/> 
        /// </summary>
        public bool HasNext() => _iterator.HasNext();
        /// <summary>
        /// KNet implementation of <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Iterator.html#next()"/> 
        /// </summary>
        public TimestampedWindowedKeyValue<K, V, TJVMK, TJVMV> Next()
        {
            var kv = _iterator.Next();
            var kvs = new KeyValueSupport<Org.Apache.Kafka.Streams.Kstream.Windowed<TJVMK>, Org.Apache.Kafka.Streams.State.ValueAndTimestamp<TJVMV>>(kv.BridgeInstance);
            return new TimestampedWindowedKeyValue<K, V, TJVMK, TJVMV>(Factory, kvs);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Iterator.html#remove()"/>
        /// </summary>
        public void Remove()
        {
            _iterator.Remove();
        }
        /// <summary>
        /// KNet implementation of <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/state/KeyValueIterator.html#peekNextKey--"/>
        /// </summary>
        /// <returns><typeparamref name="K"/></returns>
        public Windowed<K, TJVMK> PeekNextKey()
        {
            var kk = _iterator.PeekNextKey();
            return new Windowed<K, TJVMK>(Factory, kk);
        }
        /// <summary>
        /// KNet implementation of <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/state/KeyValueIterator.html#close--"/>
        /// </summary>
        public void Close()
        {
            _iterator.Close();
        }
    }
}
