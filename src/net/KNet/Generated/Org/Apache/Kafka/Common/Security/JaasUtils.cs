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
*  using kafka-clients-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Security
{
    #region JaasUtils
    public partial class JaasUtils
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/security/JaasUtils.html#DISALLOWED_LOGIN_MODULES_CONFIG"/>
        /// </summary>
        public static Java.Lang.String DISALLOWED_LOGIN_MODULES_CONFIG { get { if (!_DISALLOWED_LOGIN_MODULES_CONFIGReady) { _DISALLOWED_LOGIN_MODULES_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DISALLOWED_LOGIN_MODULES_CONFIG"); _DISALLOWED_LOGIN_MODULES_CONFIGReady = true; } return _DISALLOWED_LOGIN_MODULES_CONFIGContent; } }
        private static Java.Lang.String _DISALLOWED_LOGIN_MODULES_CONFIGContent = default;
        private static bool _DISALLOWED_LOGIN_MODULES_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/security/JaasUtils.html#DISALLOWED_LOGIN_MODULES_DEFAULT"/>
        /// </summary>
        public static Java.Lang.String DISALLOWED_LOGIN_MODULES_DEFAULT { get { if (!_DISALLOWED_LOGIN_MODULES_DEFAULTReady) { _DISALLOWED_LOGIN_MODULES_DEFAULTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DISALLOWED_LOGIN_MODULES_DEFAULT"); _DISALLOWED_LOGIN_MODULES_DEFAULTReady = true; } return _DISALLOWED_LOGIN_MODULES_DEFAULTContent; } }
        private static Java.Lang.String _DISALLOWED_LOGIN_MODULES_DEFAULTContent = default;
        private static bool _DISALLOWED_LOGIN_MODULES_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/security/JaasUtils.html#JAVA_LOGIN_CONFIG_PARAM"/>
        /// </summary>
        public static Java.Lang.String JAVA_LOGIN_CONFIG_PARAM { get { if (!_JAVA_LOGIN_CONFIG_PARAMReady) { _JAVA_LOGIN_CONFIG_PARAMContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "JAVA_LOGIN_CONFIG_PARAM"); _JAVA_LOGIN_CONFIG_PARAMReady = true; } return _JAVA_LOGIN_CONFIG_PARAMContent; } }
        private static Java.Lang.String _JAVA_LOGIN_CONFIG_PARAMContent = default;
        private static bool _JAVA_LOGIN_CONFIG_PARAMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/security/JaasUtils.html#SERVICE_NAME"/>
        /// </summary>
        public static Java.Lang.String SERVICE_NAME { get { if (!_SERVICE_NAMEReady) { _SERVICE_NAMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SERVICE_NAME"); _SERVICE_NAMEReady = true; } return _SERVICE_NAMEContent; } }
        private static Java.Lang.String _SERVICE_NAMEContent = default;
        private static bool _SERVICE_NAMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/security/JaasUtils.html#ZK_LOGIN_CONTEXT_NAME_KEY"/>
        /// </summary>
        public static Java.Lang.String ZK_LOGIN_CONTEXT_NAME_KEY { get { if (!_ZK_LOGIN_CONTEXT_NAME_KEYReady) { _ZK_LOGIN_CONTEXT_NAME_KEYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ZK_LOGIN_CONTEXT_NAME_KEY"); _ZK_LOGIN_CONTEXT_NAME_KEYReady = true; } return _ZK_LOGIN_CONTEXT_NAME_KEYContent; } }
        private static Java.Lang.String _ZK_LOGIN_CONTEXT_NAME_KEYContent = default;
        private static bool _ZK_LOGIN_CONTEXT_NAME_KEYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/security/JaasUtils.html#ZK_SASL_CLIENT"/>
        /// </summary>
        public static Java.Lang.String ZK_SASL_CLIENT { get { if (!_ZK_SASL_CLIENTReady) { _ZK_SASL_CLIENTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ZK_SASL_CLIENT"); _ZK_SASL_CLIENTReady = true; } return _ZK_SASL_CLIENTContent; } }
        private static Java.Lang.String _ZK_SASL_CLIENTContent = default;
        private static bool _ZK_SASL_CLIENTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/security/JaasUtils.html#isZkSaslEnabled--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public static bool IsZkSaslEnabled()
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isZkSaslEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/security/JaasUtils.html#zkSecuritySysConfigString--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ZkSecuritySysConfigString()
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "zkSecuritySysConfigString", "()Ljava/lang/String;");
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