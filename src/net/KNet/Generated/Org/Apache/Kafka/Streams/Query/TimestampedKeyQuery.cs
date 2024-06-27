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

namespace Org.Apache.Kafka.Streams.Query
{
    #region TimestampedKeyQuery
    public partial class TimestampedKeyQuery
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/query/TimestampedKeyQuery.html#withKey-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.TimestampedKeyQuery"/></returns>
        public static Org.Apache.Kafka.Streams.Query.TimestampedKeyQuery WithKey(object arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Query.TimestampedKeyQuery>(LocalBridgeClazz, "withKey", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/query/TimestampedKeyQuery.html#isSkipCache--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSkipCache()
        {
            return IExecuteWithSignature<bool>("isSkipCache", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/query/TimestampedKeyQuery.html#key--"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object Key()
        {
            return IExecuteWithSignature("key", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/query/TimestampedKeyQuery.html#skipCache--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.TimestampedKeyQuery"/></returns>
        public Org.Apache.Kafka.Streams.Query.TimestampedKeyQuery SkipCache()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.TimestampedKeyQuery>("skipCache", "()Lorg/apache/kafka/streams/query/TimestampedKeyQuery;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TimestampedKeyQuery<K, V>
    public partial class TimestampedKeyQuery<K, V>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Query.TimestampedKeyQuery{K, V}"/> to <see cref="Org.Apache.Kafka.Streams.Query.TimestampedKeyQuery"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Query.TimestampedKeyQuery(Org.Apache.Kafka.Streams.Query.TimestampedKeyQuery<K, V> t) => t.Cast<Org.Apache.Kafka.Streams.Query.TimestampedKeyQuery>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/query/TimestampedKeyQuery.html#withKey-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.TimestampedKeyQuery"/></returns>
        public static Org.Apache.Kafka.Streams.Query.TimestampedKeyQuery<K, V> WithKey(K arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Query.TimestampedKeyQuery<K, V>>(LocalBridgeClazz, "withKey", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/query/TimestampedKeyQuery.html#isSkipCache--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSkipCache()
        {
            return IExecuteWithSignature<bool>("isSkipCache", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/query/TimestampedKeyQuery.html#key--"/>
        /// </summary>
        /// <returns><typeparamref name="K"/></returns>
        public K Key()
        {
            return IExecuteWithSignature<K>("key", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/query/TimestampedKeyQuery.html#skipCache--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.TimestampedKeyQuery"/></returns>
        public Org.Apache.Kafka.Streams.Query.TimestampedKeyQuery<K, V> SkipCache()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.TimestampedKeyQuery<K, V>>("skipCache", "()Lorg/apache/kafka/streams/query/TimestampedKeyQuery;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}