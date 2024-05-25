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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using kafka-streams-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Kstream
{
    #region Produced
    public partial class Produced
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Produced.html#as-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Produced"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Produced As(Java.Lang.String arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Produced>(LocalBridgeClazz, "as", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Produced.html#keySerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Produced"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Produced KeySerde(Org.Apache.Kafka.Common.Serialization.Serde arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Produced>(LocalBridgeClazz, "keySerde", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Produced.html#streamPartitioner-org.apache.kafka.streams.processor.StreamPartitioner-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.StreamPartitioner"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Produced"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Produced StreamPartitioner(Org.Apache.Kafka.Streams.Processor.StreamPartitioner arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Produced>(LocalBridgeClazz, "streamPartitioner", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Produced.html#valueSerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Produced"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Produced ValueSerde(Org.Apache.Kafka.Common.Serialization.Serde arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Produced>(LocalBridgeClazz, "valueSerde", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Produced.html#with-org.apache.kafka.common.serialization.Serde-org.apache.kafka.common.serialization.Serde-org.apache.kafka.streams.processor.StreamPartitioner-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Processor.StreamPartitioner"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Produced"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Produced With(Org.Apache.Kafka.Common.Serialization.Serde arg0, Org.Apache.Kafka.Common.Serialization.Serde arg1, Org.Apache.Kafka.Streams.Processor.StreamPartitioner arg2)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Produced>(LocalBridgeClazz, "with", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Produced.html#with-org.apache.kafka.common.serialization.Serde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Produced"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Produced With(Org.Apache.Kafka.Common.Serialization.Serde arg0, Org.Apache.Kafka.Common.Serialization.Serde arg1)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Produced>(LocalBridgeClazz, "with", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Produced.html#withKeySerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Produced"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.Produced WithKeySerde(Org.Apache.Kafka.Common.Serialization.Serde arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.Produced>("withKeySerde", "(Lorg/apache/kafka/common/serialization/Serde;)Lorg/apache/kafka/streams/kstream/Produced;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Produced.html#withStreamPartitioner-org.apache.kafka.streams.processor.StreamPartitioner-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.StreamPartitioner"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Produced"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.Produced WithStreamPartitioner(Org.Apache.Kafka.Streams.Processor.StreamPartitioner arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.Produced>("withStreamPartitioner", "(Lorg/apache/kafka/streams/processor/StreamPartitioner;)Lorg/apache/kafka/streams/kstream/Produced;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Produced.html#withValueSerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Produced"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.Produced WithValueSerde(Org.Apache.Kafka.Common.Serialization.Serde arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.Produced>("withValueSerde", "(Lorg/apache/kafka/common/serialization/Serde;)Lorg/apache/kafka/streams/kstream/Produced;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Produced<K, V>
    public partial class Produced<K, V>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Kstream.Produced{K, V}"/> to <see cref="Org.Apache.Kafka.Streams.Kstream.Produced"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Kstream.Produced(Org.Apache.Kafka.Streams.Kstream.Produced<K, V> t) => t.Cast<Org.Apache.Kafka.Streams.Kstream.Produced>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Produced.html#as-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Produced"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Produced<K, V> As(Java.Lang.String arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Produced<K, V>>(LocalBridgeClazz, "as", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Produced.html#keySerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Produced"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Produced<K, V> KeySerde(Org.Apache.Kafka.Common.Serialization.Serde<K> arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Produced<K, V>>(LocalBridgeClazz, "keySerde", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Produced.html#streamPartitioner-org.apache.kafka.streams.processor.StreamPartitioner-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.StreamPartitioner"/></param>
        /// <typeparam name="Arg0objectSuperK"><typeparamref name="K"/></typeparam>
        /// <typeparam name="Arg0objectSuperV"><typeparamref name="V"/></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Produced"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Produced<K, V> StreamPartitioner<Arg0objectSuperK, Arg0objectSuperV>(Org.Apache.Kafka.Streams.Processor.StreamPartitioner<Arg0objectSuperK, Arg0objectSuperV> arg0) where Arg0objectSuperK: K where Arg0objectSuperV: V
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Produced<K, V>>(LocalBridgeClazz, "streamPartitioner", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Produced.html#valueSerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Produced"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Produced<K, V> ValueSerde(Org.Apache.Kafka.Common.Serialization.Serde<V> arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Produced<K, V>>(LocalBridgeClazz, "valueSerde", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Produced.html#with-org.apache.kafka.common.serialization.Serde-org.apache.kafka.common.serialization.Serde-org.apache.kafka.streams.processor.StreamPartitioner-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Processor.StreamPartitioner"/></param>
        /// <typeparam name="Arg2objectSuperK"><typeparamref name="K"/></typeparam>
        /// <typeparam name="Arg2objectSuperV"><typeparamref name="V"/></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Produced"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Produced<K, V> With<Arg2objectSuperK, Arg2objectSuperV>(Org.Apache.Kafka.Common.Serialization.Serde<K> arg0, Org.Apache.Kafka.Common.Serialization.Serde<V> arg1, Org.Apache.Kafka.Streams.Processor.StreamPartitioner<Arg2objectSuperK, Arg2objectSuperV> arg2) where Arg2objectSuperK: K where Arg2objectSuperV: V
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Produced<K, V>>(LocalBridgeClazz, "with", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Produced.html#with-org.apache.kafka.common.serialization.Serde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Produced"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Produced<K, V> With(Org.Apache.Kafka.Common.Serialization.Serde<K> arg0, Org.Apache.Kafka.Common.Serialization.Serde<V> arg1)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Produced<K, V>>(LocalBridgeClazz, "with", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Produced.html#withKeySerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Produced"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.Produced<K, V> WithKeySerde(Org.Apache.Kafka.Common.Serialization.Serde<K> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.Produced<K, V>>("withKeySerde", "(Lorg/apache/kafka/common/serialization/Serde;)Lorg/apache/kafka/streams/kstream/Produced;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Produced.html#withStreamPartitioner-org.apache.kafka.streams.processor.StreamPartitioner-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.StreamPartitioner"/></param>
        /// <typeparam name="Arg0objectSuperK"><typeparamref name="K"/></typeparam>
        /// <typeparam name="Arg0objectSuperV"><typeparamref name="V"/></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Produced"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.Produced<K, V> WithStreamPartitioner<Arg0objectSuperK, Arg0objectSuperV>(Org.Apache.Kafka.Streams.Processor.StreamPartitioner<Arg0objectSuperK, Arg0objectSuperV> arg0) where Arg0objectSuperK: K where Arg0objectSuperV: V
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.Produced<K, V>>("withStreamPartitioner", "(Lorg/apache/kafka/streams/processor/StreamPartitioner;)Lorg/apache/kafka/streams/kstream/Produced;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Produced.html#withValueSerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Produced"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.Produced<K, V> WithValueSerde(Org.Apache.Kafka.Common.Serialization.Serde<V> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.Produced<K, V>>("withValueSerde", "(Lorg/apache/kafka/common/serialization/Serde;)Lorg/apache/kafka/streams/kstream/Produced;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}