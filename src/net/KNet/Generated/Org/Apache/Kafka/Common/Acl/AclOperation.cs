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

namespace Org.Apache.Kafka.Common.Acl
{
    #region AclOperation
    public partial class AclOperation
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/acl/AclOperation.html#ALL"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Acl.AclOperation ALL { get { if (!_ALLReady) { _ALLContent = SGetField<Org.Apache.Kafka.Common.Acl.AclOperation>(LocalBridgeClazz, "ALL"); _ALLReady = true; } return _ALLContent; } }
        private static Org.Apache.Kafka.Common.Acl.AclOperation _ALLContent = default;
        private static bool _ALLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/acl/AclOperation.html#ALTER"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Acl.AclOperation ALTER { get { if (!_ALTERReady) { _ALTERContent = SGetField<Org.Apache.Kafka.Common.Acl.AclOperation>(LocalBridgeClazz, "ALTER"); _ALTERReady = true; } return _ALTERContent; } }
        private static Org.Apache.Kafka.Common.Acl.AclOperation _ALTERContent = default;
        private static bool _ALTERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/acl/AclOperation.html#ALTER_CONFIGS"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Acl.AclOperation ALTER_CONFIGS { get { if (!_ALTER_CONFIGSReady) { _ALTER_CONFIGSContent = SGetField<Org.Apache.Kafka.Common.Acl.AclOperation>(LocalBridgeClazz, "ALTER_CONFIGS"); _ALTER_CONFIGSReady = true; } return _ALTER_CONFIGSContent; } }
        private static Org.Apache.Kafka.Common.Acl.AclOperation _ALTER_CONFIGSContent = default;
        private static bool _ALTER_CONFIGSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/acl/AclOperation.html#ANY"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Acl.AclOperation ANY { get { if (!_ANYReady) { _ANYContent = SGetField<Org.Apache.Kafka.Common.Acl.AclOperation>(LocalBridgeClazz, "ANY"); _ANYReady = true; } return _ANYContent; } }
        private static Org.Apache.Kafka.Common.Acl.AclOperation _ANYContent = default;
        private static bool _ANYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/acl/AclOperation.html#CLUSTER_ACTION"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Acl.AclOperation CLUSTER_ACTION { get { if (!_CLUSTER_ACTIONReady) { _CLUSTER_ACTIONContent = SGetField<Org.Apache.Kafka.Common.Acl.AclOperation>(LocalBridgeClazz, "CLUSTER_ACTION"); _CLUSTER_ACTIONReady = true; } return _CLUSTER_ACTIONContent; } }
        private static Org.Apache.Kafka.Common.Acl.AclOperation _CLUSTER_ACTIONContent = default;
        private static bool _CLUSTER_ACTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/acl/AclOperation.html#CREATE"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Acl.AclOperation CREATE { get { if (!_CREATEReady) { _CREATEContent = SGetField<Org.Apache.Kafka.Common.Acl.AclOperation>(LocalBridgeClazz, "CREATE"); _CREATEReady = true; } return _CREATEContent; } }
        private static Org.Apache.Kafka.Common.Acl.AclOperation _CREATEContent = default;
        private static bool _CREATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/acl/AclOperation.html#CREATE_TOKENS"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Acl.AclOperation CREATE_TOKENS { get { if (!_CREATE_TOKENSReady) { _CREATE_TOKENSContent = SGetField<Org.Apache.Kafka.Common.Acl.AclOperation>(LocalBridgeClazz, "CREATE_TOKENS"); _CREATE_TOKENSReady = true; } return _CREATE_TOKENSContent; } }
        private static Org.Apache.Kafka.Common.Acl.AclOperation _CREATE_TOKENSContent = default;
        private static bool _CREATE_TOKENSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/acl/AclOperation.html#DELETE"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Acl.AclOperation DELETE { get { if (!_DELETEReady) { _DELETEContent = SGetField<Org.Apache.Kafka.Common.Acl.AclOperation>(LocalBridgeClazz, "DELETE"); _DELETEReady = true; } return _DELETEContent; } }
        private static Org.Apache.Kafka.Common.Acl.AclOperation _DELETEContent = default;
        private static bool _DELETEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/acl/AclOperation.html#DESCRIBE"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Acl.AclOperation DESCRIBE { get { if (!_DESCRIBEReady) { _DESCRIBEContent = SGetField<Org.Apache.Kafka.Common.Acl.AclOperation>(LocalBridgeClazz, "DESCRIBE"); _DESCRIBEReady = true; } return _DESCRIBEContent; } }
        private static Org.Apache.Kafka.Common.Acl.AclOperation _DESCRIBEContent = default;
        private static bool _DESCRIBEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/acl/AclOperation.html#DESCRIBE_CONFIGS"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Acl.AclOperation DESCRIBE_CONFIGS { get { if (!_DESCRIBE_CONFIGSReady) { _DESCRIBE_CONFIGSContent = SGetField<Org.Apache.Kafka.Common.Acl.AclOperation>(LocalBridgeClazz, "DESCRIBE_CONFIGS"); _DESCRIBE_CONFIGSReady = true; } return _DESCRIBE_CONFIGSContent; } }
        private static Org.Apache.Kafka.Common.Acl.AclOperation _DESCRIBE_CONFIGSContent = default;
        private static bool _DESCRIBE_CONFIGSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/acl/AclOperation.html#DESCRIBE_TOKENS"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Acl.AclOperation DESCRIBE_TOKENS { get { if (!_DESCRIBE_TOKENSReady) { _DESCRIBE_TOKENSContent = SGetField<Org.Apache.Kafka.Common.Acl.AclOperation>(LocalBridgeClazz, "DESCRIBE_TOKENS"); _DESCRIBE_TOKENSReady = true; } return _DESCRIBE_TOKENSContent; } }
        private static Org.Apache.Kafka.Common.Acl.AclOperation _DESCRIBE_TOKENSContent = default;
        private static bool _DESCRIBE_TOKENSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/acl/AclOperation.html#IDEMPOTENT_WRITE"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Acl.AclOperation IDEMPOTENT_WRITE { get { if (!_IDEMPOTENT_WRITEReady) { _IDEMPOTENT_WRITEContent = SGetField<Org.Apache.Kafka.Common.Acl.AclOperation>(LocalBridgeClazz, "IDEMPOTENT_WRITE"); _IDEMPOTENT_WRITEReady = true; } return _IDEMPOTENT_WRITEContent; } }
        private static Org.Apache.Kafka.Common.Acl.AclOperation _IDEMPOTENT_WRITEContent = default;
        private static bool _IDEMPOTENT_WRITEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/acl/AclOperation.html#READ"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Acl.AclOperation READ { get { if (!_READReady) { _READContent = SGetField<Org.Apache.Kafka.Common.Acl.AclOperation>(LocalBridgeClazz, "READ"); _READReady = true; } return _READContent; } }
        private static Org.Apache.Kafka.Common.Acl.AclOperation _READContent = default;
        private static bool _READReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/acl/AclOperation.html#UNKNOWN"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Acl.AclOperation UNKNOWN { get { if (!_UNKNOWNReady) { _UNKNOWNContent = SGetField<Org.Apache.Kafka.Common.Acl.AclOperation>(LocalBridgeClazz, "UNKNOWN"); _UNKNOWNReady = true; } return _UNKNOWNContent; } }
        private static Org.Apache.Kafka.Common.Acl.AclOperation _UNKNOWNContent = default;
        private static bool _UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/acl/AclOperation.html#WRITE"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Acl.AclOperation WRITE { get { if (!_WRITEReady) { _WRITEContent = SGetField<Org.Apache.Kafka.Common.Acl.AclOperation>(LocalBridgeClazz, "WRITE"); _WRITEReady = true; } return _WRITEContent; } }
        private static Org.Apache.Kafka.Common.Acl.AclOperation _WRITEContent = default;
        private static bool _WRITEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/acl/AclOperation.html#fromCode-byte-"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Acl.AclOperation"/></returns>
        public static Org.Apache.Kafka.Common.Acl.AclOperation FromCode(byte arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.Acl.AclOperation>(LocalBridgeClazz, "fromCode", "(B)Lorg/apache/kafka/common/acl/AclOperation;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/acl/AclOperation.html#fromString-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Acl.AclOperation"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public static Org.Apache.Kafka.Common.Acl.AclOperation FromString(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.Acl.AclOperation>(LocalBridgeClazz, "fromString", "(Ljava/lang/String;)Lorg/apache/kafka/common/acl/AclOperation;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/acl/AclOperation.html#valueOf-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Acl.AclOperation"/></returns>
        public static Org.Apache.Kafka.Common.Acl.AclOperation ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.Acl.AclOperation>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/common/acl/AclOperation;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/acl/AclOperation.html#values--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Acl.AclOperation"/></returns>
        public static Org.Apache.Kafka.Common.Acl.AclOperation[] Values()
        {
            return SExecuteWithSignatureArray<Org.Apache.Kafka.Common.Acl.AclOperation>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/common/acl/AclOperation;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/acl/AclOperation.html#isUnknown--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsUnknown()
        {
            return IExecuteWithSignature<bool>("isUnknown", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/acl/AclOperation.html#code--"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte Code()
        {
            return IExecuteWithSignature<byte>("code", "()B");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}