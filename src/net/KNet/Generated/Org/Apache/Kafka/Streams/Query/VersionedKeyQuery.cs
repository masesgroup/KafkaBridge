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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using kafka-streams-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Query
{
    #region VersionedKeyQuery
    public partial class VersionedKeyQuery
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/VersionedKeyQuery.html#withKey-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.VersionedKeyQuery"/></returns>
        public static Org.Apache.Kafka.Streams.Query.VersionedKeyQuery WithKey(object arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Query.VersionedKeyQuery>(LocalBridgeClazz, "withKey", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/VersionedKeyQuery.html#asOfTimestamp--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional AsOfTimestamp()
        {
            return IExecuteWithSignature<Java.Util.Optional>("asOfTimestamp", "()Ljava/util/Optional;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/VersionedKeyQuery.html#key--"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object Key()
        {
            return IExecuteWithSignature("key", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/VersionedKeyQuery.html#asOf-java.time.Instant-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.VersionedKeyQuery"/></returns>
        public Org.Apache.Kafka.Streams.Query.VersionedKeyQuery AsOf(Java.Time.Instant arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.VersionedKeyQuery>("asOf", "(Ljava/time/Instant;)Lorg/apache/kafka/streams/query/VersionedKeyQuery;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region VersionedKeyQuery<K, V>
    public partial class VersionedKeyQuery<K, V>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Query.VersionedKeyQuery{K, V}"/> to <see cref="Org.Apache.Kafka.Streams.Query.VersionedKeyQuery"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Query.VersionedKeyQuery(Org.Apache.Kafka.Streams.Query.VersionedKeyQuery<K, V> t) => t.Cast<Org.Apache.Kafka.Streams.Query.VersionedKeyQuery>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/VersionedKeyQuery.html#withKey-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.VersionedKeyQuery"/></returns>
        public static Org.Apache.Kafka.Streams.Query.VersionedKeyQuery<K, V> WithKey(K arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Query.VersionedKeyQuery<K, V>>(LocalBridgeClazz, "withKey", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/VersionedKeyQuery.html#asOfTimestamp--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Java.Time.Instant> AsOfTimestamp()
        {
            return IExecuteWithSignature<Java.Util.Optional<Java.Time.Instant>>("asOfTimestamp", "()Ljava/util/Optional;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/VersionedKeyQuery.html#key--"/>
        /// </summary>

        /// <returns><typeparamref name="K"/></returns>
        public K Key()
        {
            return IExecuteWithSignature<K>("key", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/VersionedKeyQuery.html#asOf-java.time.Instant-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.VersionedKeyQuery"/></returns>
        public Org.Apache.Kafka.Streams.Query.VersionedKeyQuery<K, V> AsOf(Java.Time.Instant arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.VersionedKeyQuery<K, V>>("asOf", "(Ljava/time/Instant;)Lorg/apache/kafka/streams/query/VersionedKeyQuery;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}