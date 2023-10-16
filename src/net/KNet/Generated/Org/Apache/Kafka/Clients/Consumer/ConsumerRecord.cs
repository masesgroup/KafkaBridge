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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using kafka-clients-3.6.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Consumer
{
    #region ConsumerRecord
    public partial class ConsumerRecord
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerRecord.html#org.apache.kafka.clients.consumer.ConsumerRecord(java.lang.String,int,long,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <param name="arg4"><see cref="object"/></param>
        public ConsumerRecord(string arg0, int arg1, long arg2, object arg3, object arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerRecord.html#org.apache.kafka.clients.consumer.ConsumerRecord(java.lang.String,int,long,long,org.apache.kafka.common.record.TimestampType,int,int,java.lang.Object,java.lang.Object,org.apache.kafka.common.header.Headers,java.util.Optional)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Common.Record.TimestampType"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="object"/></param>
        /// <param name="arg8"><see cref="object"/></param>
        /// <param name="arg9"><see cref="Org.Apache.Kafka.Common.Header.Headers"/></param>
        /// <param name="arg10"><see cref="Java.Util.Optional"/></param>
        public ConsumerRecord(string arg0, int arg1, long arg2, long arg3, Org.Apache.Kafka.Common.Record.TimestampType arg4, int arg5, int arg6, object arg7, object arg8, Org.Apache.Kafka.Common.Header.Headers arg9, Java.Util.Optional arg10)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerRecord.html#NULL_SIZE"/>
        /// </summary>
        public static int NULL_SIZE { get { return SGetField<int>(LocalBridgeClazz, "NULL_SIZE"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerRecord.html#NO_TIMESTAMP"/>
        /// </summary>
        public static long NO_TIMESTAMP { get { return SGetField<long>(LocalBridgeClazz, "NO_TIMESTAMP"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerRecord.html#partition--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Partition()
        {
            return IExecute<int>("partition");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerRecord.html#serializedKeySize--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int SerializedKeySize()
        {
            return IExecute<int>("serializedKeySize");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerRecord.html#serializedValueSize--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int SerializedValueSize()
        {
            return IExecute<int>("serializedValueSize");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerRecord.html#topic--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string Topic()
        {
            return IExecute<string>("topic");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerRecord.html#leaderEpoch--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional LeaderEpoch()
        {
            return IExecute<Java.Util.Optional>("leaderEpoch");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerRecord.html#key--"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object Key()
        {
            return IExecute("key");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerRecord.html#offset--"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long Offset()
        {
            return IExecute<long>("offset");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerRecord.html#timestamp--"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long Timestamp()
        {
            return IExecute<long>("timestamp");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerRecord.html#headers--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Header.Headers"/></returns>
        public Org.Apache.Kafka.Common.Header.Headers Headers()
        {
            return IExecute<Org.Apache.Kafka.Common.Header.Headers>("headers");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerRecord.html#timestampType--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Record.TimestampType"/></returns>
        public Org.Apache.Kafka.Common.Record.TimestampType TimestampType()
        {
            return IExecute<Org.Apache.Kafka.Common.Record.TimestampType>("timestampType");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerRecord.html#value--"/>
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

    #region ConsumerRecord<K, V>
    public partial class ConsumerRecord<K, V>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerRecord.html#org.apache.kafka.clients.consumer.ConsumerRecord(java.lang.String,int,long,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><typeparamref name="K"/></param>
        /// <param name="arg4"><typeparamref name="V"/></param>
        public ConsumerRecord(string arg0, int arg1, long arg2, K arg3, V arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerRecord.html#org.apache.kafka.clients.consumer.ConsumerRecord(java.lang.String,int,long,long,org.apache.kafka.common.record.TimestampType,int,int,java.lang.Object,java.lang.Object,org.apache.kafka.common.header.Headers,java.util.Optional)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Common.Record.TimestampType"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><typeparamref name="K"/></param>
        /// <param name="arg8"><typeparamref name="V"/></param>
        /// <param name="arg9"><see cref="Org.Apache.Kafka.Common.Header.Headers"/></param>
        /// <param name="arg10"><see cref="Java.Util.Optional"/></param>
        public ConsumerRecord(string arg0, int arg1, long arg2, long arg3, Org.Apache.Kafka.Common.Record.TimestampType arg4, int arg5, int arg6, K arg7, V arg8, Org.Apache.Kafka.Common.Header.Headers arg9, Java.Util.Optional<Java.Lang.Integer> arg10)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerRecord{K, V}"/> to <see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerRecord"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Clients.Consumer.ConsumerRecord(Org.Apache.Kafka.Clients.Consumer.ConsumerRecord<K, V> t) => t.Cast<Org.Apache.Kafka.Clients.Consumer.ConsumerRecord>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerRecord.html#NULL_SIZE"/>
        /// </summary>
        public static int NULL_SIZE { get { return SGetField<int>(LocalBridgeClazz, "NULL_SIZE"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerRecord.html#NO_TIMESTAMP"/>
        /// </summary>
        public static long NO_TIMESTAMP { get { return SGetField<long>(LocalBridgeClazz, "NO_TIMESTAMP"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerRecord.html#partition--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Partition()
        {
            return IExecute<int>("partition");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerRecord.html#serializedKeySize--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int SerializedKeySize()
        {
            return IExecute<int>("serializedKeySize");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerRecord.html#serializedValueSize--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int SerializedValueSize()
        {
            return IExecute<int>("serializedValueSize");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerRecord.html#topic--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string Topic()
        {
            return IExecute<string>("topic");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerRecord.html#leaderEpoch--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Java.Lang.Integer> LeaderEpoch()
        {
            return IExecute<Java.Util.Optional<Java.Lang.Integer>>("leaderEpoch");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerRecord.html#key--"/>
        /// </summary>

        /// <returns><typeparamref name="K"/></returns>
        public K Key()
        {
            return IExecute<K>("key");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerRecord.html#offset--"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long Offset()
        {
            return IExecute<long>("offset");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerRecord.html#timestamp--"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long Timestamp()
        {
            return IExecute<long>("timestamp");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerRecord.html#headers--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Header.Headers"/></returns>
        public Org.Apache.Kafka.Common.Header.Headers Headers()
        {
            return IExecute<Org.Apache.Kafka.Common.Header.Headers>("headers");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerRecord.html#timestampType--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Record.TimestampType"/></returns>
        public Org.Apache.Kafka.Common.Record.TimestampType TimestampType()
        {
            return IExecute<Org.Apache.Kafka.Common.Record.TimestampType>("timestampType");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerRecord.html#value--"/>
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