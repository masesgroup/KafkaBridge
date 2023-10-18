/*
*  Copyright 2023 MASES s.r.l.
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

/*
*  This file is generated by MASES.JNetReflector (ver. 2.0.2.0)
*  using kafka-streams-3.6.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Processor.Api
{
    #region Record
    public partial class Record
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/processor/api/Record.html#org.apache.kafka.streams.processor.api.Record(java.lang.Object,java.lang.Object,long,org.apache.kafka.common.header.Headers)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Common.Header.Headers"/></param>
        public Record(object arg0, object arg1, long arg2, Org.Apache.Kafka.Common.Header.Headers arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/processor/api/Record.html#org.apache.kafka.streams.processor.api.Record(java.lang.Object,java.lang.Object,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public Record(object arg0, object arg1, long arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/processor/api/Record.html#withKey-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.Api.Record"/></returns>
        public Org.Apache.Kafka.Streams.Processor.Api.Record WithKey(object arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Processor.Api.Record>("withKey", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/processor/api/Record.html#withValue-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.Api.Record"/></returns>
        public Org.Apache.Kafka.Streams.Processor.Api.Record WithValue(object arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Processor.Api.Record>("withValue", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/processor/api/Record.html#key--"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object Key()
        {
            return IExecute("key");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/processor/api/Record.html#timestamp--"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long Timestamp()
        {
            return IExecute<long>("timestamp");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/processor/api/Record.html#headers--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Header.Headers"/></returns>
        public Org.Apache.Kafka.Common.Header.Headers Headers()
        {
            return IExecute<Org.Apache.Kafka.Common.Header.Headers>("headers");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/processor/api/Record.html#withHeaders-org.apache.kafka.common.header.Headers-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Header.Headers"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.Api.Record"/></returns>
        public Org.Apache.Kafka.Streams.Processor.Api.Record WithHeaders(Org.Apache.Kafka.Common.Header.Headers arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Processor.Api.Record>("withHeaders", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/processor/api/Record.html#withTimestamp-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.Api.Record"/></returns>
        public Org.Apache.Kafka.Streams.Processor.Api.Record WithTimestamp(long arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Processor.Api.Record>("withTimestamp", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/processor/api/Record.html#value--"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object Value()
        {
            return IExecute("value");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Record<K, V>
    public partial class Record<K, V>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/processor/api/Record.html#org.apache.kafka.streams.processor.api.Record(java.lang.Object,java.lang.Object,long,org.apache.kafka.common.header.Headers)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Common.Header.Headers"/></param>
        public Record(K arg0, V arg1, long arg2, Org.Apache.Kafka.Common.Header.Headers arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/processor/api/Record.html#org.apache.kafka.streams.processor.api.Record(java.lang.Object,java.lang.Object,long)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public Record(K arg0, V arg1, long arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Processor.Api.Record{K, V}"/> to <see cref="Org.Apache.Kafka.Streams.Processor.Api.Record"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Processor.Api.Record(Org.Apache.Kafka.Streams.Processor.Api.Record<K, V> t) => t.Cast<Org.Apache.Kafka.Streams.Processor.Api.Record>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/processor/api/Record.html#withKey-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="NewK"/></param>
        /// <typeparam name="NewK"></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.Api.Record"/></returns>
        public Org.Apache.Kafka.Streams.Processor.Api.Record<NewK, V> WithKey<NewK>(NewK arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Processor.Api.Record<NewK, V>>("withKey", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/processor/api/Record.html#withValue-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="NewV"/></param>
        /// <typeparam name="NewV"></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.Api.Record"/></returns>
        public Org.Apache.Kafka.Streams.Processor.Api.Record<K, NewV> WithValue<NewV>(NewV arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Processor.Api.Record<K, NewV>>("withValue", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/processor/api/Record.html#key--"/>
        /// </summary>

        /// <returns><typeparamref name="K"/></returns>
        public K Key()
        {
            return IExecute<K>("key");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/processor/api/Record.html#timestamp--"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long Timestamp()
        {
            return IExecute<long>("timestamp");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/processor/api/Record.html#headers--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Header.Headers"/></returns>
        public Org.Apache.Kafka.Common.Header.Headers Headers()
        {
            return IExecute<Org.Apache.Kafka.Common.Header.Headers>("headers");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/processor/api/Record.html#withHeaders-org.apache.kafka.common.header.Headers-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Header.Headers"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.Api.Record"/></returns>
        public Org.Apache.Kafka.Streams.Processor.Api.Record<K, V> WithHeaders(Org.Apache.Kafka.Common.Header.Headers arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Processor.Api.Record<K, V>>("withHeaders", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/processor/api/Record.html#withTimestamp-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.Api.Record"/></returns>
        public Org.Apache.Kafka.Streams.Processor.Api.Record<K, V> WithTimestamp(long arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Processor.Api.Record<K, V>>("withTimestamp", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/processor/api/Record.html#value--"/>
        /// </summary>

        /// <returns><typeparamref name="V"/></returns>
        public V Value()
        {
            return IExecute<V>("value");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}