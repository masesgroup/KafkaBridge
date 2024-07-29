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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using kafka-streams-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Query
{
    #region ResultOrder
    public partial class ResultOrder
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/ResultOrder.html#ANY"/>
        /// </summary>
        public static Org.Apache.Kafka.Streams.Query.ResultOrder ANY { get { if (!_ANYReady) { _ANYContent = SGetField<Org.Apache.Kafka.Streams.Query.ResultOrder>(LocalBridgeClazz, "ANY"); _ANYReady = true; } return _ANYContent; } }
        private static Org.Apache.Kafka.Streams.Query.ResultOrder _ANYContent = default;
        private static bool _ANYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/ResultOrder.html#ASCENDING"/>
        /// </summary>
        public static Org.Apache.Kafka.Streams.Query.ResultOrder ASCENDING { get { if (!_ASCENDINGReady) { _ASCENDINGContent = SGetField<Org.Apache.Kafka.Streams.Query.ResultOrder>(LocalBridgeClazz, "ASCENDING"); _ASCENDINGReady = true; } return _ASCENDINGContent; } }
        private static Org.Apache.Kafka.Streams.Query.ResultOrder _ASCENDINGContent = default;
        private static bool _ASCENDINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/ResultOrder.html#DESCENDING"/>
        /// </summary>
        public static Org.Apache.Kafka.Streams.Query.ResultOrder DESCENDING { get { if (!_DESCENDINGReady) { _DESCENDINGContent = SGetField<Org.Apache.Kafka.Streams.Query.ResultOrder>(LocalBridgeClazz, "DESCENDING"); _DESCENDINGReady = true; } return _DESCENDINGContent; } }
        private static Org.Apache.Kafka.Streams.Query.ResultOrder _DESCENDINGContent = default;
        private static bool _DESCENDINGReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/ResultOrder.html#valueOf-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.ResultOrder"/></returns>
        public static Org.Apache.Kafka.Streams.Query.ResultOrder ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Streams.Query.ResultOrder>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/streams/query/ResultOrder;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/ResultOrder.html#values--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.ResultOrder"/></returns>
        public static Org.Apache.Kafka.Streams.Query.ResultOrder[] Values()
        {
            return SExecuteWithSignatureArray<Org.Apache.Kafka.Streams.Query.ResultOrder>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/streams/query/ResultOrder;");
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