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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*  using kafka-streams-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Query
{
    #region KeyQuery
    public partial class KeyQuery
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/query/KeyQuery.html#withKey-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.KeyQuery"/></returns>
        public static Org.Apache.Kafka.Streams.Query.KeyQuery WithKey(object arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Query.KeyQuery>(LocalBridgeClazz, "withKey", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/query/KeyQuery.html#getKey--"/> 
        /// </summary>
        public object Key
        {
            get { return IExecuteWithSignature("getKey", "()Ljava/lang/Object;"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/query/KeyQuery.html#isSkipCache--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsSkipCache()
        {
            return IExecuteWithSignature<bool>("isSkipCache", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/query/KeyQuery.html#skipCache--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.KeyQuery"/></returns>
        public Org.Apache.Kafka.Streams.Query.KeyQuery SkipCache()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.KeyQuery>("skipCache", "()Lorg/apache/kafka/streams/query/KeyQuery;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region KeyQuery<K, V>
    public partial class KeyQuery<K, V>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Query.KeyQuery{K, V}"/> to <see cref="Org.Apache.Kafka.Streams.Query.KeyQuery"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Query.KeyQuery(Org.Apache.Kafka.Streams.Query.KeyQuery<K, V> t) => t.Cast<Org.Apache.Kafka.Streams.Query.KeyQuery>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/query/KeyQuery.html#withKey-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.KeyQuery"/></returns>
        public static Org.Apache.Kafka.Streams.Query.KeyQuery<K, V> WithKey(K arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Query.KeyQuery<K, V>>(LocalBridgeClazz, "withKey", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/query/KeyQuery.html#getKey--"/> 
        /// </summary>
        public K Key
        {
            get { return IExecuteWithSignature<K>("getKey", "()Ljava/lang/Object;"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/query/KeyQuery.html#isSkipCache--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsSkipCache()
        {
            return IExecuteWithSignature<bool>("isSkipCache", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/query/KeyQuery.html#skipCache--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.KeyQuery"/></returns>
        public Org.Apache.Kafka.Streams.Query.KeyQuery<K, V> SkipCache()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.KeyQuery<K, V>>("skipCache", "()Lorg/apache/kafka/streams/query/KeyQuery;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}