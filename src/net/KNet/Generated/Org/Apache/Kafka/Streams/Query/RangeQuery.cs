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
*  This file is generated by MASES.JNetReflector (ver. 2.2.3.0)
*  using kafka-streams-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Query
{
    #region RangeQuery
    public partial class RangeQuery
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/RangeQuery.html#withLowerBound-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.RangeQuery"/></returns>
        public static Org.Apache.Kafka.Streams.Query.RangeQuery WithLowerBound(object arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Query.RangeQuery>(LocalBridgeClazz, "withLowerBound", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/RangeQuery.html#withNoBounds--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.RangeQuery"/></returns>
        public static Org.Apache.Kafka.Streams.Query.RangeQuery WithNoBounds()
        {
            return SExecute<Org.Apache.Kafka.Streams.Query.RangeQuery>(LocalBridgeClazz, "withNoBounds");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/RangeQuery.html#withRange-java.lang.Object-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.RangeQuery"/></returns>
        public static Org.Apache.Kafka.Streams.Query.RangeQuery WithRange(object arg0, object arg1)
        {
            return SExecute<Org.Apache.Kafka.Streams.Query.RangeQuery>(LocalBridgeClazz, "withRange", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/RangeQuery.html#withUpperBound-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.RangeQuery"/></returns>
        public static Org.Apache.Kafka.Streams.Query.RangeQuery WithUpperBound(object arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Query.RangeQuery>(LocalBridgeClazz, "withUpperBound", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/RangeQuery.html#getLowerBound--"/> 
        /// </summary>
        public Java.Util.Optional LowerBound
        {
            get { return IExecute<Java.Util.Optional>("getLowerBound"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/RangeQuery.html#getUpperBound--"/> 
        /// </summary>
        public Java.Util.Optional UpperBound
        {
            get { return IExecute<Java.Util.Optional>("getUpperBound"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region RangeQuery<K, V>
    public partial class RangeQuery<K, V>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Query.RangeQuery{K, V}"/> to <see cref="Org.Apache.Kafka.Streams.Query.RangeQuery"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Query.RangeQuery(Org.Apache.Kafka.Streams.Query.RangeQuery<K, V> t) => t.Cast<Org.Apache.Kafka.Streams.Query.RangeQuery>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/RangeQuery.html#withLowerBound-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.RangeQuery"/></returns>
        public static Org.Apache.Kafka.Streams.Query.RangeQuery<K, V> WithLowerBound(K arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Query.RangeQuery<K, V>>(LocalBridgeClazz, "withLowerBound", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/RangeQuery.html#withNoBounds--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.RangeQuery"/></returns>
        public static Org.Apache.Kafka.Streams.Query.RangeQuery<K, V> WithNoBounds()
        {
            return SExecute<Org.Apache.Kafka.Streams.Query.RangeQuery<K, V>>(LocalBridgeClazz, "withNoBounds");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/RangeQuery.html#withRange-java.lang.Object-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><typeparamref name="K"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.RangeQuery"/></returns>
        public static Org.Apache.Kafka.Streams.Query.RangeQuery<K, V> WithRange(K arg0, K arg1)
        {
            return SExecute<Org.Apache.Kafka.Streams.Query.RangeQuery<K, V>>(LocalBridgeClazz, "withRange", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/RangeQuery.html#withUpperBound-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.RangeQuery"/></returns>
        public static Org.Apache.Kafka.Streams.Query.RangeQuery<K, V> WithUpperBound(K arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Query.RangeQuery<K, V>>(LocalBridgeClazz, "withUpperBound", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/RangeQuery.html#getLowerBound--"/> 
        /// </summary>
        public Java.Util.Optional<K> LowerBound
        {
            get { return IExecute<Java.Util.Optional<K>>("getLowerBound"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/RangeQuery.html#getUpperBound--"/> 
        /// </summary>
        public Java.Util.Optional<K> UpperBound
        {
            get { return IExecute<Java.Util.Optional<K>>("getUpperBound"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}