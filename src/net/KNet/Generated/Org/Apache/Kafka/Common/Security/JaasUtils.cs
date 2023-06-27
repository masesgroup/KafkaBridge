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
*  This file is generated by MASES.JNetReflector (ver. 2.0.0.0)
*  using kafka-clients-3.4.0.jar as reference
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/JaasUtils.html#DISALLOWED_LOGIN_MODULES_CONFIG"/>
        /// </summary>
        public static string DISALLOWED_LOGIN_MODULES_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "DISALLOWED_LOGIN_MODULES_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/JaasUtils.html#DISALLOWED_LOGIN_MODULES_DEFAULT"/>
        /// </summary>
        public static string DISALLOWED_LOGIN_MODULES_DEFAULT { get { return SGetField<string>(LocalBridgeClazz, "DISALLOWED_LOGIN_MODULES_DEFAULT"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/JaasUtils.html#JAVA_LOGIN_CONFIG_PARAM"/>
        /// </summary>
        public static string JAVA_LOGIN_CONFIG_PARAM { get { return SGetField<string>(LocalBridgeClazz, "JAVA_LOGIN_CONFIG_PARAM"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/JaasUtils.html#SERVICE_NAME"/>
        /// </summary>
        public static string SERVICE_NAME { get { return SGetField<string>(LocalBridgeClazz, "SERVICE_NAME"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/JaasUtils.html#ZK_LOGIN_CONTEXT_NAME_KEY"/>
        /// </summary>
        public static string ZK_LOGIN_CONTEXT_NAME_KEY { get { return SGetField<string>(LocalBridgeClazz, "ZK_LOGIN_CONTEXT_NAME_KEY"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/JaasUtils.html#ZK_SASL_CLIENT"/>
        /// </summary>
        public static string ZK_SASL_CLIENT { get { return SGetField<string>(LocalBridgeClazz, "ZK_SASL_CLIENT"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/JaasUtils.html#isZkSaslEnabled()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public static bool IsZkSaslEnabled()
        {
            return SExecute<bool>(LocalBridgeClazz, "isZkSaslEnabled");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/JaasUtils.html#zkSecuritySysConfigString()"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public static string ZkSecuritySysConfigString()
        {
            return SExecute<string>(LocalBridgeClazz, "zkSecuritySysConfigString");
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