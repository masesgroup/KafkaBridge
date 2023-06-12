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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using kafka-clients-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Config
{
    #region SslConfigs
    public partial class SslConfigs
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#DEFAULT_SSL_ENABLED_PROTOCOLS"/>
        /// </summary>
        public static string DEFAULT_SSL_ENABLED_PROTOCOLS { get { return SGetField<string>(LocalBridgeClazz, "DEFAULT_SSL_ENABLED_PROTOCOLS"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#DEFAULT_SSL_ENDPOINT_IDENTIFICATION_ALGORITHM"/>
        /// </summary>
        public static string DEFAULT_SSL_ENDPOINT_IDENTIFICATION_ALGORITHM { get { return SGetField<string>(LocalBridgeClazz, "DEFAULT_SSL_ENDPOINT_IDENTIFICATION_ALGORITHM"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#DEFAULT_SSL_KEYMANGER_ALGORITHM"/>
        /// </summary>
        public static string DEFAULT_SSL_KEYMANGER_ALGORITHM { get { return SGetField<string>(LocalBridgeClazz, "DEFAULT_SSL_KEYMANGER_ALGORITHM"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#DEFAULT_SSL_KEYSTORE_TYPE"/>
        /// </summary>
        public static string DEFAULT_SSL_KEYSTORE_TYPE { get { return SGetField<string>(LocalBridgeClazz, "DEFAULT_SSL_KEYSTORE_TYPE"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#DEFAULT_SSL_PROTOCOL"/>
        /// </summary>
        public static string DEFAULT_SSL_PROTOCOL { get { return SGetField<string>(LocalBridgeClazz, "DEFAULT_SSL_PROTOCOL"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#DEFAULT_SSL_TRUSTMANAGER_ALGORITHM"/>
        /// </summary>
        public static string DEFAULT_SSL_TRUSTMANAGER_ALGORITHM { get { return SGetField<string>(LocalBridgeClazz, "DEFAULT_SSL_TRUSTMANAGER_ALGORITHM"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#DEFAULT_SSL_TRUSTSTORE_TYPE"/>
        /// </summary>
        public static string DEFAULT_SSL_TRUSTSTORE_TYPE { get { return SGetField<string>(LocalBridgeClazz, "DEFAULT_SSL_TRUSTSTORE_TYPE"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#SSL_CIPHER_SUITES_CONFIG"/>
        /// </summary>
        public static string SSL_CIPHER_SUITES_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "SSL_CIPHER_SUITES_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#SSL_CIPHER_SUITES_DOC"/>
        /// </summary>
        public static string SSL_CIPHER_SUITES_DOC { get { return SGetField<string>(LocalBridgeClazz, "SSL_CIPHER_SUITES_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#SSL_ENABLED_PROTOCOLS_CONFIG"/>
        /// </summary>
        public static string SSL_ENABLED_PROTOCOLS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "SSL_ENABLED_PROTOCOLS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#SSL_ENABLED_PROTOCOLS_DOC"/>
        /// </summary>
        public static string SSL_ENABLED_PROTOCOLS_DOC { get { return SGetField<string>(LocalBridgeClazz, "SSL_ENABLED_PROTOCOLS_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#SSL_ENDPOINT_IDENTIFICATION_ALGORITHM_CONFIG"/>
        /// </summary>
        public static string SSL_ENDPOINT_IDENTIFICATION_ALGORITHM_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "SSL_ENDPOINT_IDENTIFICATION_ALGORITHM_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#SSL_ENDPOINT_IDENTIFICATION_ALGORITHM_DOC"/>
        /// </summary>
        public static string SSL_ENDPOINT_IDENTIFICATION_ALGORITHM_DOC { get { return SGetField<string>(LocalBridgeClazz, "SSL_ENDPOINT_IDENTIFICATION_ALGORITHM_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#SSL_ENGINE_FACTORY_CLASS_CONFIG"/>
        /// </summary>
        public static string SSL_ENGINE_FACTORY_CLASS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "SSL_ENGINE_FACTORY_CLASS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#SSL_ENGINE_FACTORY_CLASS_DOC"/>
        /// </summary>
        public static string SSL_ENGINE_FACTORY_CLASS_DOC { get { return SGetField<string>(LocalBridgeClazz, "SSL_ENGINE_FACTORY_CLASS_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#SSL_KEY_PASSWORD_CONFIG"/>
        /// </summary>
        public static string SSL_KEY_PASSWORD_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "SSL_KEY_PASSWORD_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#SSL_KEY_PASSWORD_DOC"/>
        /// </summary>
        public static string SSL_KEY_PASSWORD_DOC { get { return SGetField<string>(LocalBridgeClazz, "SSL_KEY_PASSWORD_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#SSL_KEYMANAGER_ALGORITHM_CONFIG"/>
        /// </summary>
        public static string SSL_KEYMANAGER_ALGORITHM_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "SSL_KEYMANAGER_ALGORITHM_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#SSL_KEYMANAGER_ALGORITHM_DOC"/>
        /// </summary>
        public static string SSL_KEYMANAGER_ALGORITHM_DOC { get { return SGetField<string>(LocalBridgeClazz, "SSL_KEYMANAGER_ALGORITHM_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#SSL_KEYSTORE_CERTIFICATE_CHAIN_CONFIG"/>
        /// </summary>
        public static string SSL_KEYSTORE_CERTIFICATE_CHAIN_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "SSL_KEYSTORE_CERTIFICATE_CHAIN_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#SSL_KEYSTORE_CERTIFICATE_CHAIN_DOC"/>
        /// </summary>
        public static string SSL_KEYSTORE_CERTIFICATE_CHAIN_DOC { get { return SGetField<string>(LocalBridgeClazz, "SSL_KEYSTORE_CERTIFICATE_CHAIN_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#SSL_KEYSTORE_KEY_CONFIG"/>
        /// </summary>
        public static string SSL_KEYSTORE_KEY_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "SSL_KEYSTORE_KEY_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#SSL_KEYSTORE_KEY_DOC"/>
        /// </summary>
        public static string SSL_KEYSTORE_KEY_DOC { get { return SGetField<string>(LocalBridgeClazz, "SSL_KEYSTORE_KEY_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#SSL_KEYSTORE_LOCATION_CONFIG"/>
        /// </summary>
        public static string SSL_KEYSTORE_LOCATION_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "SSL_KEYSTORE_LOCATION_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#SSL_KEYSTORE_LOCATION_DOC"/>
        /// </summary>
        public static string SSL_KEYSTORE_LOCATION_DOC { get { return SGetField<string>(LocalBridgeClazz, "SSL_KEYSTORE_LOCATION_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#SSL_KEYSTORE_PASSWORD_CONFIG"/>
        /// </summary>
        public static string SSL_KEYSTORE_PASSWORD_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "SSL_KEYSTORE_PASSWORD_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#SSL_KEYSTORE_PASSWORD_DOC"/>
        /// </summary>
        public static string SSL_KEYSTORE_PASSWORD_DOC { get { return SGetField<string>(LocalBridgeClazz, "SSL_KEYSTORE_PASSWORD_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#SSL_KEYSTORE_TYPE_CONFIG"/>
        /// </summary>
        public static string SSL_KEYSTORE_TYPE_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "SSL_KEYSTORE_TYPE_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#SSL_KEYSTORE_TYPE_DOC"/>
        /// </summary>
        public static string SSL_KEYSTORE_TYPE_DOC { get { return SGetField<string>(LocalBridgeClazz, "SSL_KEYSTORE_TYPE_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#SSL_PROTOCOL_CONFIG"/>
        /// </summary>
        public static string SSL_PROTOCOL_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "SSL_PROTOCOL_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#SSL_PROTOCOL_DOC"/>
        /// </summary>
        public static string SSL_PROTOCOL_DOC { get { return SGetField<string>(LocalBridgeClazz, "SSL_PROTOCOL_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#SSL_PROVIDER_CONFIG"/>
        /// </summary>
        public static string SSL_PROVIDER_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "SSL_PROVIDER_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#SSL_PROVIDER_DOC"/>
        /// </summary>
        public static string SSL_PROVIDER_DOC { get { return SGetField<string>(LocalBridgeClazz, "SSL_PROVIDER_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#SSL_SECURE_RANDOM_IMPLEMENTATION_CONFIG"/>
        /// </summary>
        public static string SSL_SECURE_RANDOM_IMPLEMENTATION_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "SSL_SECURE_RANDOM_IMPLEMENTATION_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#SSL_SECURE_RANDOM_IMPLEMENTATION_DOC"/>
        /// </summary>
        public static string SSL_SECURE_RANDOM_IMPLEMENTATION_DOC { get { return SGetField<string>(LocalBridgeClazz, "SSL_SECURE_RANDOM_IMPLEMENTATION_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#SSL_TRUSTMANAGER_ALGORITHM_CONFIG"/>
        /// </summary>
        public static string SSL_TRUSTMANAGER_ALGORITHM_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "SSL_TRUSTMANAGER_ALGORITHM_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#SSL_TRUSTMANAGER_ALGORITHM_DOC"/>
        /// </summary>
        public static string SSL_TRUSTMANAGER_ALGORITHM_DOC { get { return SGetField<string>(LocalBridgeClazz, "SSL_TRUSTMANAGER_ALGORITHM_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#SSL_TRUSTSTORE_CERTIFICATES_CONFIG"/>
        /// </summary>
        public static string SSL_TRUSTSTORE_CERTIFICATES_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "SSL_TRUSTSTORE_CERTIFICATES_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#SSL_TRUSTSTORE_CERTIFICATES_DOC"/>
        /// </summary>
        public static string SSL_TRUSTSTORE_CERTIFICATES_DOC { get { return SGetField<string>(LocalBridgeClazz, "SSL_TRUSTSTORE_CERTIFICATES_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#SSL_TRUSTSTORE_LOCATION_CONFIG"/>
        /// </summary>
        public static string SSL_TRUSTSTORE_LOCATION_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "SSL_TRUSTSTORE_LOCATION_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#SSL_TRUSTSTORE_LOCATION_DOC"/>
        /// </summary>
        public static string SSL_TRUSTSTORE_LOCATION_DOC { get { return SGetField<string>(LocalBridgeClazz, "SSL_TRUSTSTORE_LOCATION_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#SSL_TRUSTSTORE_PASSWORD_CONFIG"/>
        /// </summary>
        public static string SSL_TRUSTSTORE_PASSWORD_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "SSL_TRUSTSTORE_PASSWORD_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#SSL_TRUSTSTORE_PASSWORD_DOC"/>
        /// </summary>
        public static string SSL_TRUSTSTORE_PASSWORD_DOC { get { return SGetField<string>(LocalBridgeClazz, "SSL_TRUSTSTORE_PASSWORD_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#SSL_TRUSTSTORE_TYPE_CONFIG"/>
        /// </summary>
        public static string SSL_TRUSTSTORE_TYPE_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "SSL_TRUSTSTORE_TYPE_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#SSL_TRUSTSTORE_TYPE_DOC"/>
        /// </summary>
        public static string SSL_TRUSTSTORE_TYPE_DOC { get { return SGetField<string>(LocalBridgeClazz, "SSL_TRUSTSTORE_TYPE_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#NON_RECONFIGURABLE_CONFIGS"/>
        /// </summary>
        public static Java.Util.Set NON_RECONFIGURABLE_CONFIGS { get { return SGetField<Java.Util.Set>(LocalBridgeClazz, "NON_RECONFIGURABLE_CONFIGS"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#RECONFIGURABLE_CONFIGS"/>
        /// </summary>
        public static Java.Util.Set RECONFIGURABLE_CONFIGS { get { return SGetField<Java.Util.Set>(LocalBridgeClazz, "RECONFIGURABLE_CONFIGS"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/config/SslConfigs.html#addClientSslSupport(org.apache.kafka.common.config.ConfigDef)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Config.ConfigDef"/></param>
        public static void AddClientSslSupport(Org.Apache.Kafka.Common.Config.ConfigDef arg0)
        {
            SExecute(LocalBridgeClazz, "addClientSslSupport", arg0);
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