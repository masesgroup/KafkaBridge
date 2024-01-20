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
*  This file is generated by MASES.JNetReflector (ver. 2.2.1.0)
*  using kafka-streams-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Kstream
{
    #region StreamJoined
    public partial class StreamJoined
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/StreamJoined.html#as-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.StreamJoined As(string arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.StreamJoined>(LocalBridgeClazz, "as", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/StreamJoined.html#with-org.apache.kafka.common.serialization.Serde-org.apache.kafka.common.serialization.Serde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.StreamJoined With(Org.Apache.Kafka.Common.Serialization.Serde arg0, Org.Apache.Kafka.Common.Serialization.Serde arg1, Org.Apache.Kafka.Common.Serialization.Serde arg2)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.StreamJoined>(LocalBridgeClazz, "with", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/StreamJoined.html#with-org.apache.kafka.streams.state.WindowBytesStoreSupplier-org.apache.kafka.streams.state.WindowBytesStoreSupplier-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.State.WindowBytesStoreSupplier"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.State.WindowBytesStoreSupplier"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.StreamJoined With(Org.Apache.Kafka.Streams.State.WindowBytesStoreSupplier arg0, Org.Apache.Kafka.Streams.State.WindowBytesStoreSupplier arg1)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.StreamJoined>(LocalBridgeClazz, "with", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/StreamJoined.html#withKeySerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.StreamJoined WithKeySerde(Org.Apache.Kafka.Common.Serialization.Serde arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.StreamJoined>("withKeySerde", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/StreamJoined.html#withLoggingDisabled--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.StreamJoined WithLoggingDisabled()
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.StreamJoined>("withLoggingDisabled");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/StreamJoined.html#withLoggingEnabled-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.StreamJoined WithLoggingEnabled(Java.Util.Map arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.StreamJoined>("withLoggingEnabled", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/StreamJoined.html#withOtherStoreSupplier-org.apache.kafka.streams.state.WindowBytesStoreSupplier-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.State.WindowBytesStoreSupplier"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.StreamJoined WithOtherStoreSupplier(Org.Apache.Kafka.Streams.State.WindowBytesStoreSupplier arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.StreamJoined>("withOtherStoreSupplier", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/StreamJoined.html#withOtherValueSerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.StreamJoined WithOtherValueSerde(Org.Apache.Kafka.Common.Serialization.Serde arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.StreamJoined>("withOtherValueSerde", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/StreamJoined.html#withStoreName-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.StreamJoined WithStoreName(string arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.StreamJoined>("withStoreName", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/StreamJoined.html#withThisStoreSupplier-org.apache.kafka.streams.state.WindowBytesStoreSupplier-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.State.WindowBytesStoreSupplier"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.StreamJoined WithThisStoreSupplier(Org.Apache.Kafka.Streams.State.WindowBytesStoreSupplier arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.StreamJoined>("withThisStoreSupplier", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/StreamJoined.html#withValueSerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.StreamJoined WithValueSerde(Org.Apache.Kafka.Common.Serialization.Serde arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.StreamJoined>("withValueSerde", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region StreamJoined<K, V1, V2>
    public partial class StreamJoined<K, V1, V2>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined{K, V1, V2}"/> to <see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Kstream.StreamJoined(Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2> t) => t.Cast<Org.Apache.Kafka.Streams.Kstream.StreamJoined>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/StreamJoined.html#as-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2> As(string arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2>>(LocalBridgeClazz, "as", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/StreamJoined.html#with-org.apache.kafka.common.serialization.Serde-org.apache.kafka.common.serialization.Serde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2> With(Org.Apache.Kafka.Common.Serialization.Serde<K> arg0, Org.Apache.Kafka.Common.Serialization.Serde<V1> arg1, Org.Apache.Kafka.Common.Serialization.Serde<V2> arg2)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2>>(LocalBridgeClazz, "with", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/StreamJoined.html#with-org.apache.kafka.streams.state.WindowBytesStoreSupplier-org.apache.kafka.streams.state.WindowBytesStoreSupplier-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.State.WindowBytesStoreSupplier"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.State.WindowBytesStoreSupplier"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2> With(Org.Apache.Kafka.Streams.State.WindowBytesStoreSupplier arg0, Org.Apache.Kafka.Streams.State.WindowBytesStoreSupplier arg1)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2>>(LocalBridgeClazz, "with", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/StreamJoined.html#withKeySerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2> WithKeySerde(Org.Apache.Kafka.Common.Serialization.Serde<K> arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2>>("withKeySerde", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/StreamJoined.html#withLoggingDisabled--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2> WithLoggingDisabled()
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2>>("withLoggingDisabled");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/StreamJoined.html#withLoggingEnabled-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2> WithLoggingEnabled(Java.Util.Map<string, string> arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2>>("withLoggingEnabled", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/StreamJoined.html#withOtherStoreSupplier-org.apache.kafka.streams.state.WindowBytesStoreSupplier-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.State.WindowBytesStoreSupplier"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2> WithOtherStoreSupplier(Org.Apache.Kafka.Streams.State.WindowBytesStoreSupplier arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2>>("withOtherStoreSupplier", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/StreamJoined.html#withOtherValueSerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2> WithOtherValueSerde(Org.Apache.Kafka.Common.Serialization.Serde<V2> arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2>>("withOtherValueSerde", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/StreamJoined.html#withStoreName-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2> WithStoreName(string arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2>>("withStoreName", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/StreamJoined.html#withThisStoreSupplier-org.apache.kafka.streams.state.WindowBytesStoreSupplier-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.State.WindowBytesStoreSupplier"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2> WithThisStoreSupplier(Org.Apache.Kafka.Streams.State.WindowBytesStoreSupplier arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2>>("withThisStoreSupplier", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/StreamJoined.html#withValueSerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2> WithValueSerde(Org.Apache.Kafka.Common.Serialization.Serde<V1> arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2>>("withValueSerde", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}