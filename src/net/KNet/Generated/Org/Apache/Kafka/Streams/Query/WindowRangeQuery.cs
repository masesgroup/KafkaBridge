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
*  using kafka-streams-3.6.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Query
{
    #region WindowRangeQuery
    public partial class WindowRangeQuery
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/query/WindowRangeQuery.html#withKey-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.WindowRangeQuery"/></returns>
        public static Org.Apache.Kafka.Streams.Query.WindowRangeQuery WithKey(object arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Query.WindowRangeQuery>(LocalBridgeClazz, "withKey", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/query/WindowRangeQuery.html#withWindowStartRange-java.time.Instant-java.time.Instant-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <param name="arg1"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.WindowRangeQuery"/></returns>
        public static Org.Apache.Kafka.Streams.Query.WindowRangeQuery WithWindowStartRange(Java.Time.Instant arg0, Java.Time.Instant arg1)
        {
            return SExecute<Org.Apache.Kafka.Streams.Query.WindowRangeQuery>(LocalBridgeClazz, "withWindowStartRange", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/query/WindowRangeQuery.html#getKey--"/> 
        /// </summary>
        public Java.Util.Optional Key
        {
            get { return IExecute<Java.Util.Optional>("getKey"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/query/WindowRangeQuery.html#getTimeFrom--"/> 
        /// </summary>
        public Java.Util.Optional TimeFrom
        {
            get { return IExecute<Java.Util.Optional>("getTimeFrom"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/query/WindowRangeQuery.html#getTimeTo--"/> 
        /// </summary>
        public Java.Util.Optional TimeTo
        {
            get { return IExecute<Java.Util.Optional>("getTimeTo"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region WindowRangeQuery<K, V>
    public partial class WindowRangeQuery<K, V>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Query.WindowRangeQuery{K, V}"/> to <see cref="Org.Apache.Kafka.Streams.Query.WindowRangeQuery"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Query.WindowRangeQuery(Org.Apache.Kafka.Streams.Query.WindowRangeQuery<K, V> t) => t.Cast<Org.Apache.Kafka.Streams.Query.WindowRangeQuery>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/query/WindowRangeQuery.html#withKey-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.WindowRangeQuery"/></returns>
        public static Org.Apache.Kafka.Streams.Query.WindowRangeQuery<K, V> WithKey(K arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Query.WindowRangeQuery<K, V>>(LocalBridgeClazz, "withKey", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/query/WindowRangeQuery.html#withWindowStartRange-java.time.Instant-java.time.Instant-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <param name="arg1"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.WindowRangeQuery"/></returns>
        public static Org.Apache.Kafka.Streams.Query.WindowRangeQuery<K, V> WithWindowStartRange(Java.Time.Instant arg0, Java.Time.Instant arg1)
        {
            return SExecute<Org.Apache.Kafka.Streams.Query.WindowRangeQuery<K, V>>(LocalBridgeClazz, "withWindowStartRange", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/query/WindowRangeQuery.html#getKey--"/> 
        /// </summary>
        public Java.Util.Optional<K> Key
        {
            get { return IExecute<Java.Util.Optional<K>>("getKey"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/query/WindowRangeQuery.html#getTimeFrom--"/> 
        /// </summary>
        public Java.Util.Optional<Java.Time.Instant> TimeFrom
        {
            get { return IExecute<Java.Util.Optional<Java.Time.Instant>>("getTimeFrom"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/query/WindowRangeQuery.html#getTimeTo--"/> 
        /// </summary>
        public Java.Util.Optional<Java.Time.Instant> TimeTo
        {
            get { return IExecute<Java.Util.Optional<Java.Time.Instant>>("getTimeTo"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}