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
*  This file is generated by MASES.JNetReflector (ver. 2.5.4.0)
*  using kafka-streams-3.7.0.jar as reference
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/query/FailureReason.html#DOES_NOT_EXIST"/>
        /// </summary>
        public static Org.Apache.Kafka.Streams.Query.FailureReason DOES_NOT_EXIST { get { if (!_DOES_NOT_EXISTReady) { _DOES_NOT_EXISTContent = SGetField<Org.Apache.Kafka.Streams.Query.FailureReason>(LocalBridgeClazz, "DOES_NOT_EXIST"); _DOES_NOT_EXISTReady = true; } return _DOES_NOT_EXISTContent; } }
        private static Org.Apache.Kafka.Streams.Query.FailureReason _DOES_NOT_EXISTContent = default;
        private static bool _DOES_NOT_EXISTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/query/FailureReason.html#NOT_ACTIVE"/>
        /// </summary>
        public static Org.Apache.Kafka.Streams.Query.FailureReason NOT_ACTIVE { get { if (!_NOT_ACTIVEReady) { _NOT_ACTIVEContent = SGetField<Org.Apache.Kafka.Streams.Query.FailureReason>(LocalBridgeClazz, "NOT_ACTIVE"); _NOT_ACTIVEReady = true; } return _NOT_ACTIVEContent; } }
        private static Org.Apache.Kafka.Streams.Query.FailureReason _NOT_ACTIVEContent = default;
        private static bool _NOT_ACTIVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/query/FailureReason.html#NOT_PRESENT"/>
        /// </summary>
        public static Org.Apache.Kafka.Streams.Query.FailureReason NOT_PRESENT { get { if (!_NOT_PRESENTReady) { _NOT_PRESENTContent = SGetField<Org.Apache.Kafka.Streams.Query.FailureReason>(LocalBridgeClazz, "NOT_PRESENT"); _NOT_PRESENTReady = true; } return _NOT_PRESENTContent; } }
        private static Org.Apache.Kafka.Streams.Query.FailureReason _NOT_PRESENTContent = default;
        private static bool _NOT_PRESENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/query/FailureReason.html#NOT_UP_TO_BOUND"/>
        /// </summary>
        public static Org.Apache.Kafka.Streams.Query.FailureReason NOT_UP_TO_BOUND { get { if (!_NOT_UP_TO_BOUNDReady) { _NOT_UP_TO_BOUNDContent = SGetField<Org.Apache.Kafka.Streams.Query.FailureReason>(LocalBridgeClazz, "NOT_UP_TO_BOUND"); _NOT_UP_TO_BOUNDReady = true; } return _NOT_UP_TO_BOUNDContent; } }
        private static Org.Apache.Kafka.Streams.Query.FailureReason _NOT_UP_TO_BOUNDContent = default;
        private static bool _NOT_UP_TO_BOUNDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/query/FailureReason.html#STORE_EXCEPTION"/>
        /// </summary>
        public static Org.Apache.Kafka.Streams.Query.FailureReason STORE_EXCEPTION { get { if (!_STORE_EXCEPTIONReady) { _STORE_EXCEPTIONContent = SGetField<Org.Apache.Kafka.Streams.Query.FailureReason>(LocalBridgeClazz, "STORE_EXCEPTION"); _STORE_EXCEPTIONReady = true; } return _STORE_EXCEPTIONContent; } }
        private static Org.Apache.Kafka.Streams.Query.FailureReason _STORE_EXCEPTIONContent = default;
        private static bool _STORE_EXCEPTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/query/FailureReason.html#UNKNOWN_QUERY_TYPE"/>
        /// </summary>
        public static Org.Apache.Kafka.Streams.Query.FailureReason UNKNOWN_QUERY_TYPE { get { if (!_UNKNOWN_QUERY_TYPEReady) { _UNKNOWN_QUERY_TYPEContent = SGetField<Org.Apache.Kafka.Streams.Query.FailureReason>(LocalBridgeClazz, "UNKNOWN_QUERY_TYPE"); _UNKNOWN_QUERY_TYPEReady = true; } return _UNKNOWN_QUERY_TYPEContent; } }
        private static Org.Apache.Kafka.Streams.Query.FailureReason _UNKNOWN_QUERY_TYPEContent = default;
        private static bool _UNKNOWN_QUERY_TYPEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/query/FailureReason.html#valueOf-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.FailureReason"/></returns>
        public static Org.Apache.Kafka.Streams.Query.FailureReason ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Streams.Query.FailureReason>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/streams/query/FailureReason;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/query/FailureReason.html#values--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.FailureReason"/></returns>
        public static Org.Apache.Kafka.Streams.Query.FailureReason[] Values()
        {
            return SExecuteWithSignatureArray<Org.Apache.Kafka.Streams.Query.FailureReason>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/streams/query/FailureReason;");
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