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
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
*  using kafka-clients-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Resource
{
    #region ResourceType
    public partial class ResourceType
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/resource/ResourceType.html#ANY"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Resource.ResourceType ANY { get { if (!_ANYReady) { _ANYContent = SGetField<Org.Apache.Kafka.Common.Resource.ResourceType>(LocalBridgeClazz, "ANY"); _ANYReady = true; } return _ANYContent; } }
        private static Org.Apache.Kafka.Common.Resource.ResourceType _ANYContent = default;
        private static bool _ANYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/resource/ResourceType.html#CLUSTER"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Resource.ResourceType CLUSTER { get { if (!_CLUSTERReady) { _CLUSTERContent = SGetField<Org.Apache.Kafka.Common.Resource.ResourceType>(LocalBridgeClazz, "CLUSTER"); _CLUSTERReady = true; } return _CLUSTERContent; } }
        private static Org.Apache.Kafka.Common.Resource.ResourceType _CLUSTERContent = default;
        private static bool _CLUSTERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/resource/ResourceType.html#DELEGATION_TOKEN"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Resource.ResourceType DELEGATION_TOKEN { get { if (!_DELEGATION_TOKENReady) { _DELEGATION_TOKENContent = SGetField<Org.Apache.Kafka.Common.Resource.ResourceType>(LocalBridgeClazz, "DELEGATION_TOKEN"); _DELEGATION_TOKENReady = true; } return _DELEGATION_TOKENContent; } }
        private static Org.Apache.Kafka.Common.Resource.ResourceType _DELEGATION_TOKENContent = default;
        private static bool _DELEGATION_TOKENReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/resource/ResourceType.html#GROUP"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Resource.ResourceType GROUP { get { if (!_GROUPReady) { _GROUPContent = SGetField<Org.Apache.Kafka.Common.Resource.ResourceType>(LocalBridgeClazz, "GROUP"); _GROUPReady = true; } return _GROUPContent; } }
        private static Org.Apache.Kafka.Common.Resource.ResourceType _GROUPContent = default;
        private static bool _GROUPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/resource/ResourceType.html#TOPIC"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Resource.ResourceType TOPIC { get { if (!_TOPICReady) { _TOPICContent = SGetField<Org.Apache.Kafka.Common.Resource.ResourceType>(LocalBridgeClazz, "TOPIC"); _TOPICReady = true; } return _TOPICContent; } }
        private static Org.Apache.Kafka.Common.Resource.ResourceType _TOPICContent = default;
        private static bool _TOPICReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/resource/ResourceType.html#TRANSACTIONAL_ID"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Resource.ResourceType TRANSACTIONAL_ID { get { if (!_TRANSACTIONAL_IDReady) { _TRANSACTIONAL_IDContent = SGetField<Org.Apache.Kafka.Common.Resource.ResourceType>(LocalBridgeClazz, "TRANSACTIONAL_ID"); _TRANSACTIONAL_IDReady = true; } return _TRANSACTIONAL_IDContent; } }
        private static Org.Apache.Kafka.Common.Resource.ResourceType _TRANSACTIONAL_IDContent = default;
        private static bool _TRANSACTIONAL_IDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/resource/ResourceType.html#UNKNOWN"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Resource.ResourceType UNKNOWN { get { if (!_UNKNOWNReady) { _UNKNOWNContent = SGetField<Org.Apache.Kafka.Common.Resource.ResourceType>(LocalBridgeClazz, "UNKNOWN"); _UNKNOWNReady = true; } return _UNKNOWNContent; } }
        private static Org.Apache.Kafka.Common.Resource.ResourceType _UNKNOWNContent = default;
        private static bool _UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/resource/ResourceType.html#USER"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Resource.ResourceType USER { get { if (!_USERReady) { _USERContent = SGetField<Org.Apache.Kafka.Common.Resource.ResourceType>(LocalBridgeClazz, "USER"); _USERReady = true; } return _USERContent; } }
        private static Org.Apache.Kafka.Common.Resource.ResourceType _USERContent = default;
        private static bool _USERReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/resource/ResourceType.html#fromCode-byte-"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Resource.ResourceType"/></returns>
        public static Org.Apache.Kafka.Common.Resource.ResourceType FromCode(byte arg0)
        {
            return SExecute<Org.Apache.Kafka.Common.Resource.ResourceType>(LocalBridgeClazz, "fromCode", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/resource/ResourceType.html#fromString-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Resource.ResourceType"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public static Org.Apache.Kafka.Common.Resource.ResourceType FromString(string arg0)
        {
            return SExecute<Org.Apache.Kafka.Common.Resource.ResourceType>(LocalBridgeClazz, "fromString", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/resource/ResourceType.html#valueOf-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Resource.ResourceType"/></returns>
        public static Org.Apache.Kafka.Common.Resource.ResourceType ValueOf(string arg0)
        {
            return SExecute<Org.Apache.Kafka.Common.Resource.ResourceType>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/resource/ResourceType.html#values--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Resource.ResourceType"/></returns>
        public static Org.Apache.Kafka.Common.Resource.ResourceType[] Values()
        {
            return SExecuteArray<Org.Apache.Kafka.Common.Resource.ResourceType>(LocalBridgeClazz, "values");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/resource/ResourceType.html#isUnknown--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsUnknown()
        {
            return IExecute<bool>("isUnknown");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/resource/ResourceType.html#code--"/>
        /// </summary>

        /// <returns><see cref="byte"/></returns>
        public byte Code()
        {
            return IExecute<byte>("code");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}