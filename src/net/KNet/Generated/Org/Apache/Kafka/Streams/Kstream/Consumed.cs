/*
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

/*
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using kafka-streams-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Kstream
{
    #region Consumed
    public partial class Consumed
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Consumed.html#as-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Consumed"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Consumed As(Java.Lang.String arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Consumed>(LocalBridgeClazz, "as", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Consumed.html#with-org.apache.kafka.common.serialization.Serde-org.apache.kafka.common.serialization.Serde-org.apache.kafka.streams.processor.TimestampExtractor-org.apache.kafka.streams.Topology.AutoOffsetReset-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Processor.TimestampExtractor"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Streams.Topology.AutoOffsetReset"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Consumed"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Consumed With(Org.Apache.Kafka.Common.Serialization.Serde arg0, Org.Apache.Kafka.Common.Serialization.Serde arg1, Org.Apache.Kafka.Streams.Processor.TimestampExtractor arg2, Org.Apache.Kafka.Streams.Topology.AutoOffsetReset arg3)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Consumed>(LocalBridgeClazz, "with", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Consumed.html#with-org.apache.kafka.common.serialization.Serde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Consumed"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Consumed With(Org.Apache.Kafka.Common.Serialization.Serde arg0, Org.Apache.Kafka.Common.Serialization.Serde arg1)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Consumed>(LocalBridgeClazz, "with", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Consumed.html#with-org.apache.kafka.streams.processor.TimestampExtractor-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.TimestampExtractor"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Consumed"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Consumed With(Org.Apache.Kafka.Streams.Processor.TimestampExtractor arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Consumed>(LocalBridgeClazz, "with", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Consumed.html#with-org.apache.kafka.streams.Topology.AutoOffsetReset-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Topology.AutoOffsetReset"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Consumed"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Consumed With(Org.Apache.Kafka.Streams.Topology.AutoOffsetReset arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Consumed>(LocalBridgeClazz, "with", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Consumed.html#withKeySerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Consumed"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.Consumed WithKeySerde(Org.Apache.Kafka.Common.Serialization.Serde arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.Consumed>("withKeySerde", "(Lorg/apache/kafka/common/serialization/Serde;)Lorg/apache/kafka/streams/kstream/Consumed;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Consumed.html#withOffsetResetPolicy-org.apache.kafka.streams.Topology.AutoOffsetReset-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Topology.AutoOffsetReset"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Consumed"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.Consumed WithOffsetResetPolicy(Org.Apache.Kafka.Streams.Topology.AutoOffsetReset arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.Consumed>("withOffsetResetPolicy", "(Lorg/apache/kafka/streams/Topology$AutoOffsetReset;)Lorg/apache/kafka/streams/kstream/Consumed;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Consumed.html#withTimestampExtractor-org.apache.kafka.streams.processor.TimestampExtractor-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.TimestampExtractor"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Consumed"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.Consumed WithTimestampExtractor(Org.Apache.Kafka.Streams.Processor.TimestampExtractor arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.Consumed>("withTimestampExtractor", "(Lorg/apache/kafka/streams/processor/TimestampExtractor;)Lorg/apache/kafka/streams/kstream/Consumed;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Consumed.html#withValueSerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Consumed"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.Consumed WithValueSerde(Org.Apache.Kafka.Common.Serialization.Serde arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.Consumed>("withValueSerde", "(Lorg/apache/kafka/common/serialization/Serde;)Lorg/apache/kafka/streams/kstream/Consumed;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Consumed<K, V>
    public partial class Consumed<K, V>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Kstream.Consumed{K, V}"/> to <see cref="Org.Apache.Kafka.Streams.Kstream.Consumed"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Kstream.Consumed(Org.Apache.Kafka.Streams.Kstream.Consumed<K, V> t) => t.Cast<Org.Apache.Kafka.Streams.Kstream.Consumed>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Consumed.html#as-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Consumed"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Consumed<K, V> As(Java.Lang.String arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Consumed<K, V>>(LocalBridgeClazz, "as", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Consumed.html#with-org.apache.kafka.common.serialization.Serde-org.apache.kafka.common.serialization.Serde-org.apache.kafka.streams.processor.TimestampExtractor-org.apache.kafka.streams.Topology.AutoOffsetReset-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Processor.TimestampExtractor"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Streams.Topology.AutoOffsetReset"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Consumed"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Consumed<K, V> With(Org.Apache.Kafka.Common.Serialization.Serde<K> arg0, Org.Apache.Kafka.Common.Serialization.Serde<V> arg1, Org.Apache.Kafka.Streams.Processor.TimestampExtractor arg2, Org.Apache.Kafka.Streams.Topology.AutoOffsetReset arg3)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Consumed<K, V>>(LocalBridgeClazz, "with", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Consumed.html#with-org.apache.kafka.common.serialization.Serde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Consumed"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Consumed<K, V> With(Org.Apache.Kafka.Common.Serialization.Serde<K> arg0, Org.Apache.Kafka.Common.Serialization.Serde<V> arg1)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Consumed<K, V>>(LocalBridgeClazz, "with", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Consumed.html#with-org.apache.kafka.streams.processor.TimestampExtractor-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.TimestampExtractor"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Consumed"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Consumed<K, V> With(Org.Apache.Kafka.Streams.Processor.TimestampExtractor arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Consumed<K, V>>(LocalBridgeClazz, "with", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Consumed.html#with-org.apache.kafka.streams.Topology.AutoOffsetReset-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Topology.AutoOffsetReset"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Consumed"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Consumed<K, V> With(Org.Apache.Kafka.Streams.Topology.AutoOffsetReset arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Consumed<K, V>>(LocalBridgeClazz, "with", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Consumed.html#withKeySerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Consumed"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.Consumed<K, V> WithKeySerde(Org.Apache.Kafka.Common.Serialization.Serde<K> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.Consumed<K, V>>("withKeySerde", "(Lorg/apache/kafka/common/serialization/Serde;)Lorg/apache/kafka/streams/kstream/Consumed;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Consumed.html#withOffsetResetPolicy-org.apache.kafka.streams.Topology.AutoOffsetReset-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Topology.AutoOffsetReset"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Consumed"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.Consumed<K, V> WithOffsetResetPolicy(Org.Apache.Kafka.Streams.Topology.AutoOffsetReset arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.Consumed<K, V>>("withOffsetResetPolicy", "(Lorg/apache/kafka/streams/Topology$AutoOffsetReset;)Lorg/apache/kafka/streams/kstream/Consumed;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Consumed.html#withTimestampExtractor-org.apache.kafka.streams.processor.TimestampExtractor-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.TimestampExtractor"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Consumed"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.Consumed<K, V> WithTimestampExtractor(Org.Apache.Kafka.Streams.Processor.TimestampExtractor arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.Consumed<K, V>>("withTimestampExtractor", "(Lorg/apache/kafka/streams/processor/TimestampExtractor;)Lorg/apache/kafka/streams/kstream/Consumed;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Consumed.html#withValueSerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Consumed"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.Consumed<K, V> WithValueSerde(Org.Apache.Kafka.Common.Serialization.Serde<V> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.Consumed<K, V>>("withValueSerde", "(Lorg/apache/kafka/common/serialization/Serde;)Lorg/apache/kafka/streams/kstream/Consumed;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}