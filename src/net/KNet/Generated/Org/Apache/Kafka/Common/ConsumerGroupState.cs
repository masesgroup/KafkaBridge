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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using kafka-clients-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common
{
    #region ConsumerGroupState
    public partial class ConsumerGroupState
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/ConsumerGroupState.html#ASSIGNING"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.ConsumerGroupState ASSIGNING { get { if (!_ASSIGNINGReady) { _ASSIGNINGContent = SGetField<Org.Apache.Kafka.Common.ConsumerGroupState>(LocalBridgeClazz, "ASSIGNING"); _ASSIGNINGReady = true; } return _ASSIGNINGContent; } }
        private static Org.Apache.Kafka.Common.ConsumerGroupState _ASSIGNINGContent = default;
        private static bool _ASSIGNINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/ConsumerGroupState.html#COMPLETING_REBALANCE"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.ConsumerGroupState COMPLETING_REBALANCE { get { if (!_COMPLETING_REBALANCEReady) { _COMPLETING_REBALANCEContent = SGetField<Org.Apache.Kafka.Common.ConsumerGroupState>(LocalBridgeClazz, "COMPLETING_REBALANCE"); _COMPLETING_REBALANCEReady = true; } return _COMPLETING_REBALANCEContent; } }
        private static Org.Apache.Kafka.Common.ConsumerGroupState _COMPLETING_REBALANCEContent = default;
        private static bool _COMPLETING_REBALANCEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/ConsumerGroupState.html#DEAD"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.ConsumerGroupState DEAD { get { if (!_DEADReady) { _DEADContent = SGetField<Org.Apache.Kafka.Common.ConsumerGroupState>(LocalBridgeClazz, "DEAD"); _DEADReady = true; } return _DEADContent; } }
        private static Org.Apache.Kafka.Common.ConsumerGroupState _DEADContent = default;
        private static bool _DEADReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/ConsumerGroupState.html#EMPTY"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.ConsumerGroupState EMPTY { get { if (!_EMPTYReady) { _EMPTYContent = SGetField<Org.Apache.Kafka.Common.ConsumerGroupState>(LocalBridgeClazz, "EMPTY"); _EMPTYReady = true; } return _EMPTYContent; } }
        private static Org.Apache.Kafka.Common.ConsumerGroupState _EMPTYContent = default;
        private static bool _EMPTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/ConsumerGroupState.html#PREPARING_REBALANCE"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.ConsumerGroupState PREPARING_REBALANCE { get { if (!_PREPARING_REBALANCEReady) { _PREPARING_REBALANCEContent = SGetField<Org.Apache.Kafka.Common.ConsumerGroupState>(LocalBridgeClazz, "PREPARING_REBALANCE"); _PREPARING_REBALANCEReady = true; } return _PREPARING_REBALANCEContent; } }
        private static Org.Apache.Kafka.Common.ConsumerGroupState _PREPARING_REBALANCEContent = default;
        private static bool _PREPARING_REBALANCEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/ConsumerGroupState.html#RECONCILING"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.ConsumerGroupState RECONCILING { get { if (!_RECONCILINGReady) { _RECONCILINGContent = SGetField<Org.Apache.Kafka.Common.ConsumerGroupState>(LocalBridgeClazz, "RECONCILING"); _RECONCILINGReady = true; } return _RECONCILINGContent; } }
        private static Org.Apache.Kafka.Common.ConsumerGroupState _RECONCILINGContent = default;
        private static bool _RECONCILINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/ConsumerGroupState.html#STABLE"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.ConsumerGroupState STABLE { get { if (!_STABLEReady) { _STABLEContent = SGetField<Org.Apache.Kafka.Common.ConsumerGroupState>(LocalBridgeClazz, "STABLE"); _STABLEReady = true; } return _STABLEContent; } }
        private static Org.Apache.Kafka.Common.ConsumerGroupState _STABLEContent = default;
        private static bool _STABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/ConsumerGroupState.html#UNKNOWN"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.ConsumerGroupState UNKNOWN { get { if (!_UNKNOWNReady) { _UNKNOWNContent = SGetField<Org.Apache.Kafka.Common.ConsumerGroupState>(LocalBridgeClazz, "UNKNOWN"); _UNKNOWNReady = true; } return _UNKNOWNContent; } }
        private static Org.Apache.Kafka.Common.ConsumerGroupState _UNKNOWNContent = default;
        private static bool _UNKNOWNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/ConsumerGroupState.html#parse-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.ConsumerGroupState"/></returns>
        public static Org.Apache.Kafka.Common.ConsumerGroupState Parse(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.ConsumerGroupState>(LocalBridgeClazz, "parse", "(Ljava/lang/String;)Lorg/apache/kafka/common/ConsumerGroupState;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/ConsumerGroupState.html#valueOf-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.ConsumerGroupState"/></returns>
        public static Org.Apache.Kafka.Common.ConsumerGroupState ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.ConsumerGroupState>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/common/ConsumerGroupState;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/ConsumerGroupState.html#values--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.ConsumerGroupState"/></returns>
        public static Org.Apache.Kafka.Common.ConsumerGroupState[] Values()
        {
            return SExecuteWithSignatureArray<Org.Apache.Kafka.Common.ConsumerGroupState>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/common/ConsumerGroupState;");
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