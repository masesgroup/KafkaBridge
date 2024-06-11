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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using kafka-streams-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Kstream
{
    #region Joined
    public partial class Joined
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Joined.html#as-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Joined"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Joined As(Java.Lang.String arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Joined>(LocalBridgeClazz, "as", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Joined.html#keySerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Joined"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Joined KeySerde(Org.Apache.Kafka.Common.Serialization.Serde arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Joined>(LocalBridgeClazz, "keySerde", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Joined.html#otherValueSerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Joined"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Joined OtherValueSerde(Org.Apache.Kafka.Common.Serialization.Serde arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Joined>(LocalBridgeClazz, "otherValueSerde", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Joined.html#valueSerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Joined"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Joined ValueSerde(Org.Apache.Kafka.Common.Serialization.Serde arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Joined>(LocalBridgeClazz, "valueSerde", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Joined.html#with-org.apache.kafka.common.serialization.Serde-org.apache.kafka.common.serialization.Serde-org.apache.kafka.common.serialization.Serde-java.lang.String-java.time.Duration-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Java.Time.Duration"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Joined"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Joined With(Org.Apache.Kafka.Common.Serialization.Serde arg0, Org.Apache.Kafka.Common.Serialization.Serde arg1, Org.Apache.Kafka.Common.Serialization.Serde arg2, Java.Lang.String arg3, Java.Time.Duration arg4)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Joined>(LocalBridgeClazz, "with", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Joined.html#with-org.apache.kafka.common.serialization.Serde-org.apache.kafka.common.serialization.Serde-org.apache.kafka.common.serialization.Serde-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Joined"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Joined With(Org.Apache.Kafka.Common.Serialization.Serde arg0, Org.Apache.Kafka.Common.Serialization.Serde arg1, Org.Apache.Kafka.Common.Serialization.Serde arg2, Java.Lang.String arg3)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Joined>(LocalBridgeClazz, "with", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Joined.html#with-org.apache.kafka.common.serialization.Serde-org.apache.kafka.common.serialization.Serde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Joined"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Joined With(Org.Apache.Kafka.Common.Serialization.Serde arg0, Org.Apache.Kafka.Common.Serialization.Serde arg1, Org.Apache.Kafka.Common.Serialization.Serde arg2)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Joined>(LocalBridgeClazz, "with", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Joined.html#gracePeriod--"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public Java.Time.Duration GracePeriod()
        {
            return IExecuteWithSignature<Java.Time.Duration>("gracePeriod", "()Ljava/time/Duration;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Joined.html#keySerde--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Serde KeySerde()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.Serde>("keySerde", "()Lorg/apache/kafka/common/serialization/Serde;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Joined.html#keySerde--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Serde KeySerdeDirect()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.SerdeDirect, Org.Apache.Kafka.Common.Serialization.Serde>("keySerde", "()Lorg/apache/kafka/common/serialization/Serde;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Joined.html#valueSerde--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Serde ValueSerde()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.Serde>("valueSerde", "()Lorg/apache/kafka/common/serialization/Serde;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Joined.html#valueSerde--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Serde ValueSerdeDirect()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.SerdeDirect, Org.Apache.Kafka.Common.Serialization.Serde>("valueSerde", "()Lorg/apache/kafka/common/serialization/Serde;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Joined.html#otherValueSerde--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Serde OtherValueSerde()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.Serde>("otherValueSerde", "()Lorg/apache/kafka/common/serialization/Serde;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Joined.html#otherValueSerde--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Serde OtherValueSerdeDirect()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.SerdeDirect, Org.Apache.Kafka.Common.Serialization.Serde>("otherValueSerde", "()Lorg/apache/kafka/common/serialization/Serde;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Joined.html#withGracePeriod-java.time.Duration-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Duration"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Joined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.Joined WithGracePeriod(Java.Time.Duration arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.Joined>("withGracePeriod", "(Ljava/time/Duration;)Lorg/apache/kafka/streams/kstream/Joined;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Joined.html#withKeySerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Joined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.Joined WithKeySerde(Org.Apache.Kafka.Common.Serialization.Serde arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.Joined>("withKeySerde", "(Lorg/apache/kafka/common/serialization/Serde;)Lorg/apache/kafka/streams/kstream/Joined;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Joined.html#withOtherValueSerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Joined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.Joined WithOtherValueSerde(Org.Apache.Kafka.Common.Serialization.Serde arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.Joined>("withOtherValueSerde", "(Lorg/apache/kafka/common/serialization/Serde;)Lorg/apache/kafka/streams/kstream/Joined;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Joined.html#withValueSerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Joined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.Joined WithValueSerde(Org.Apache.Kafka.Common.Serialization.Serde arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.Joined>("withValueSerde", "(Lorg/apache/kafka/common/serialization/Serde;)Lorg/apache/kafka/streams/kstream/Joined;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Joined<K, V, VO>
    public partial class Joined<K, V, VO>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Kstream.Joined{K, V, VO}"/> to <see cref="Org.Apache.Kafka.Streams.Kstream.Joined"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Kstream.Joined(Org.Apache.Kafka.Streams.Kstream.Joined<K, V, VO> t) => t.Cast<Org.Apache.Kafka.Streams.Kstream.Joined>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Joined.html#as-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Joined"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Joined<K, V, VO> As(Java.Lang.String arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Joined<K, V, VO>>(LocalBridgeClazz, "as", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Joined.html#keySerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Joined"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Joined<K, V, VO> KeySerde(Org.Apache.Kafka.Common.Serialization.Serde<K> arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Joined<K, V, VO>>(LocalBridgeClazz, "keySerde", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Joined.html#otherValueSerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Joined"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Joined<K, V, VO> OtherValueSerde(Org.Apache.Kafka.Common.Serialization.Serde<VO> arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Joined<K, V, VO>>(LocalBridgeClazz, "otherValueSerde", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Joined.html#valueSerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Joined"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Joined<K, V, VO> ValueSerde(Org.Apache.Kafka.Common.Serialization.Serde<V> arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Joined<K, V, VO>>(LocalBridgeClazz, "valueSerde", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Joined.html#with-org.apache.kafka.common.serialization.Serde-org.apache.kafka.common.serialization.Serde-org.apache.kafka.common.serialization.Serde-java.lang.String-java.time.Duration-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Java.Time.Duration"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Joined"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Joined<K, V, VO> With(Org.Apache.Kafka.Common.Serialization.Serde<K> arg0, Org.Apache.Kafka.Common.Serialization.Serde<V> arg1, Org.Apache.Kafka.Common.Serialization.Serde<VO> arg2, Java.Lang.String arg3, Java.Time.Duration arg4)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Joined<K, V, VO>>(LocalBridgeClazz, "with", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Joined.html#with-org.apache.kafka.common.serialization.Serde-org.apache.kafka.common.serialization.Serde-org.apache.kafka.common.serialization.Serde-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Joined"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Joined<K, V, VO> With(Org.Apache.Kafka.Common.Serialization.Serde<K> arg0, Org.Apache.Kafka.Common.Serialization.Serde<V> arg1, Org.Apache.Kafka.Common.Serialization.Serde<VO> arg2, Java.Lang.String arg3)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Joined<K, V, VO>>(LocalBridgeClazz, "with", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Joined.html#with-org.apache.kafka.common.serialization.Serde-org.apache.kafka.common.serialization.Serde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Joined"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Joined<K, V, VO> With(Org.Apache.Kafka.Common.Serialization.Serde<K> arg0, Org.Apache.Kafka.Common.Serialization.Serde<V> arg1, Org.Apache.Kafka.Common.Serialization.Serde<VO> arg2)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Joined<K, V, VO>>(LocalBridgeClazz, "with", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Joined.html#gracePeriod--"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public Java.Time.Duration GracePeriod()
        {
            return IExecuteWithSignature<Java.Time.Duration>("gracePeriod", "()Ljava/time/Duration;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Joined.html#keySerde--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Serde<K> KeySerde()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.Serde<K>>("keySerde", "()Lorg/apache/kafka/common/serialization/Serde;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Joined.html#keySerde--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Serde<K> KeySerdeDirect()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.SerdeDirect<K>, Org.Apache.Kafka.Common.Serialization.Serde<K>>("keySerde", "()Lorg/apache/kafka/common/serialization/Serde;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Joined.html#valueSerde--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Serde<V> ValueSerde()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.Serde<V>>("valueSerde", "()Lorg/apache/kafka/common/serialization/Serde;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Joined.html#valueSerde--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Serde<V> ValueSerdeDirect()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.SerdeDirect<V>, Org.Apache.Kafka.Common.Serialization.Serde<V>>("valueSerde", "()Lorg/apache/kafka/common/serialization/Serde;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Joined.html#otherValueSerde--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Serde<VO> OtherValueSerde()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.Serde<VO>>("otherValueSerde", "()Lorg/apache/kafka/common/serialization/Serde;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Joined.html#otherValueSerde--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Serde<VO> OtherValueSerdeDirect()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.SerdeDirect<VO>, Org.Apache.Kafka.Common.Serialization.Serde<VO>>("otherValueSerde", "()Lorg/apache/kafka/common/serialization/Serde;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Joined.html#withGracePeriod-java.time.Duration-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Duration"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Joined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.Joined<K, V, VO> WithGracePeriod(Java.Time.Duration arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.Joined<K, V, VO>>("withGracePeriod", "(Ljava/time/Duration;)Lorg/apache/kafka/streams/kstream/Joined;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Joined.html#withKeySerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Joined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.Joined<K, V, VO> WithKeySerde(Org.Apache.Kafka.Common.Serialization.Serde<K> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.Joined<K, V, VO>>("withKeySerde", "(Lorg/apache/kafka/common/serialization/Serde;)Lorg/apache/kafka/streams/kstream/Joined;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Joined.html#withOtherValueSerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Joined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.Joined<K, V, VO> WithOtherValueSerde(Org.Apache.Kafka.Common.Serialization.Serde<VO> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.Joined<K, V, VO>>("withOtherValueSerde", "(Lorg/apache/kafka/common/serialization/Serde;)Lorg/apache/kafka/streams/kstream/Joined;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/Joined.html#withValueSerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Joined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.Joined<K, V, VO> WithValueSerde(Org.Apache.Kafka.Common.Serialization.Serde<V> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.Joined<K, V, VO>>("withValueSerde", "(Lorg/apache/kafka/common/serialization/Serde;)Lorg/apache/kafka/streams/kstream/Joined;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}