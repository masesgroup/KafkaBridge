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
*  This file is generated by MASES.JNetReflector (ver. 2.1.0.0)
*  using kafka-streams-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Query
{
    #region FailureReason
    public partial class FailureReason
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/FailureReason.html#DOES_NOT_EXIST"/>
        /// </summary>
        public static Org.Apache.Kafka.Streams.Query.FailureReason DOES_NOT_EXIST { get { return SGetField<Org.Apache.Kafka.Streams.Query.FailureReason>(LocalBridgeClazz, "DOES_NOT_EXIST"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/FailureReason.html#NOT_ACTIVE"/>
        /// </summary>
        public static Org.Apache.Kafka.Streams.Query.FailureReason NOT_ACTIVE { get { return SGetField<Org.Apache.Kafka.Streams.Query.FailureReason>(LocalBridgeClazz, "NOT_ACTIVE"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/FailureReason.html#NOT_PRESENT"/>
        /// </summary>
        public static Org.Apache.Kafka.Streams.Query.FailureReason NOT_PRESENT { get { return SGetField<Org.Apache.Kafka.Streams.Query.FailureReason>(LocalBridgeClazz, "NOT_PRESENT"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/FailureReason.html#NOT_UP_TO_BOUND"/>
        /// </summary>
        public static Org.Apache.Kafka.Streams.Query.FailureReason NOT_UP_TO_BOUND { get { return SGetField<Org.Apache.Kafka.Streams.Query.FailureReason>(LocalBridgeClazz, "NOT_UP_TO_BOUND"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/FailureReason.html#STORE_EXCEPTION"/>
        /// </summary>
        public static Org.Apache.Kafka.Streams.Query.FailureReason STORE_EXCEPTION { get { return SGetField<Org.Apache.Kafka.Streams.Query.FailureReason>(LocalBridgeClazz, "STORE_EXCEPTION"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/FailureReason.html#UNKNOWN_QUERY_TYPE"/>
        /// </summary>
        public static Org.Apache.Kafka.Streams.Query.FailureReason UNKNOWN_QUERY_TYPE { get { return SGetField<Org.Apache.Kafka.Streams.Query.FailureReason>(LocalBridgeClazz, "UNKNOWN_QUERY_TYPE"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/FailureReason.html#valueOf-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.FailureReason"/></returns>
        public static Org.Apache.Kafka.Streams.Query.FailureReason ValueOf(string arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Query.FailureReason>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/FailureReason.html#values--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.FailureReason"/></returns>
        public static Org.Apache.Kafka.Streams.Query.FailureReason[] Values()
        {
            return SExecuteArray<Org.Apache.Kafka.Streams.Query.FailureReason>(LocalBridgeClazz, "values");
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}