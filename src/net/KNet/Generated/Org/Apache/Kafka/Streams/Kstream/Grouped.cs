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
*  This file is generated by MASES.JNetReflector (ver. 2.2.4.0)
*  using kafka-streams-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Kstream
{
    #region Grouped
    public partial class Grouped
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/Grouped.html#as-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Grouped"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Grouped As(string arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Grouped>(LocalBridgeClazz, "as", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/Grouped.html#keySerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Grouped"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Grouped KeySerde(Org.Apache.Kafka.Common.Serialization.Serde arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Grouped>(LocalBridgeClazz, "keySerde", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/Grouped.html#valueSerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Grouped"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Grouped ValueSerde(Org.Apache.Kafka.Common.Serialization.Serde arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Grouped>(LocalBridgeClazz, "valueSerde", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/Grouped.html#with-java.lang.String-org.apache.kafka.common.serialization.Serde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Grouped"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Grouped With(string arg0, Org.Apache.Kafka.Common.Serialization.Serde arg1, Org.Apache.Kafka.Common.Serialization.Serde arg2)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Grouped>(LocalBridgeClazz, "with", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/Grouped.html#with-org.apache.kafka.common.serialization.Serde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Grouped"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Grouped With(Org.Apache.Kafka.Common.Serialization.Serde arg0, Org.Apache.Kafka.Common.Serialization.Serde arg1)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Grouped>(LocalBridgeClazz, "with", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/Grouped.html#withKeySerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Grouped"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.Grouped WithKeySerde(Org.Apache.Kafka.Common.Serialization.Serde arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.Grouped>("withKeySerde", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/Grouped.html#withValueSerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Grouped"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.Grouped WithValueSerde(Org.Apache.Kafka.Common.Serialization.Serde arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.Grouped>("withValueSerde", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Grouped<K, V>
    public partial class Grouped<K, V>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Kstream.Grouped{K, V}"/> to <see cref="Org.Apache.Kafka.Streams.Kstream.Grouped"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Kstream.Grouped(Org.Apache.Kafka.Streams.Kstream.Grouped<K, V> t) => t.Cast<Org.Apache.Kafka.Streams.Kstream.Grouped>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/Grouped.html#as-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Grouped"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Grouped<K, V> As(string arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Grouped<K, V>>(LocalBridgeClazz, "as", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/Grouped.html#keySerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Grouped"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Grouped<K, V> KeySerde(Org.Apache.Kafka.Common.Serialization.Serde<K> arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Grouped<K, V>>(LocalBridgeClazz, "keySerde", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/Grouped.html#valueSerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Grouped"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Grouped<K, V> ValueSerde(Org.Apache.Kafka.Common.Serialization.Serde<V> arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Grouped<K, V>>(LocalBridgeClazz, "valueSerde", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/Grouped.html#with-java.lang.String-org.apache.kafka.common.serialization.Serde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Grouped"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Grouped<K, V> With(string arg0, Org.Apache.Kafka.Common.Serialization.Serde<K> arg1, Org.Apache.Kafka.Common.Serialization.Serde<V> arg2)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Grouped<K, V>>(LocalBridgeClazz, "with", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/Grouped.html#with-org.apache.kafka.common.serialization.Serde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Grouped"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Grouped<K, V> With(Org.Apache.Kafka.Common.Serialization.Serde<K> arg0, Org.Apache.Kafka.Common.Serialization.Serde<V> arg1)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Grouped<K, V>>(LocalBridgeClazz, "with", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/Grouped.html#withKeySerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Grouped"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.Grouped<K, V> WithKeySerde(Org.Apache.Kafka.Common.Serialization.Serde<K> arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.Grouped<K, V>>("withKeySerde", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/Grouped.html#withValueSerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Grouped"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.Grouped<K, V> WithValueSerde(Org.Apache.Kafka.Common.Serialization.Serde<V> arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.Grouped<K, V>>("withValueSerde", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}