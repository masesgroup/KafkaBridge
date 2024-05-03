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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using kafka-clients-3.6.2.jar as reference
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#DEFAULT_SSL_ENABLED_PROTOCOLS"/>
        /// </summary>
        public static Java.Lang.String DEFAULT_SSL_ENABLED_PROTOCOLS { get { if (!_DEFAULT_SSL_ENABLED_PROTOCOLSReady) { _DEFAULT_SSL_ENABLED_PROTOCOLSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DEFAULT_SSL_ENABLED_PROTOCOLS"); _DEFAULT_SSL_ENABLED_PROTOCOLSReady = true; } return _DEFAULT_SSL_ENABLED_PROTOCOLSContent; } }
        private static Java.Lang.String _DEFAULT_SSL_ENABLED_PROTOCOLSContent = default;
        private static bool _DEFAULT_SSL_ENABLED_PROTOCOLSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#DEFAULT_SSL_ENDPOINT_IDENTIFICATION_ALGORITHM"/>
        /// </summary>
        public static Java.Lang.String DEFAULT_SSL_ENDPOINT_IDENTIFICATION_ALGORITHM { get { if (!_DEFAULT_SSL_ENDPOINT_IDENTIFICATION_ALGORITHMReady) { _DEFAULT_SSL_ENDPOINT_IDENTIFICATION_ALGORITHMContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DEFAULT_SSL_ENDPOINT_IDENTIFICATION_ALGORITHM"); _DEFAULT_SSL_ENDPOINT_IDENTIFICATION_ALGORITHMReady = true; } return _DEFAULT_SSL_ENDPOINT_IDENTIFICATION_ALGORITHMContent; } }
        private static Java.Lang.String _DEFAULT_SSL_ENDPOINT_IDENTIFICATION_ALGORITHMContent = default;
        private static bool _DEFAULT_SSL_ENDPOINT_IDENTIFICATION_ALGORITHMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#DEFAULT_SSL_KEYMANGER_ALGORITHM"/>
        /// </summary>
        public static Java.Lang.String DEFAULT_SSL_KEYMANGER_ALGORITHM { get { if (!_DEFAULT_SSL_KEYMANGER_ALGORITHMReady) { _DEFAULT_SSL_KEYMANGER_ALGORITHMContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DEFAULT_SSL_KEYMANGER_ALGORITHM"); _DEFAULT_SSL_KEYMANGER_ALGORITHMReady = true; } return _DEFAULT_SSL_KEYMANGER_ALGORITHMContent; } }
        private static Java.Lang.String _DEFAULT_SSL_KEYMANGER_ALGORITHMContent = default;
        private static bool _DEFAULT_SSL_KEYMANGER_ALGORITHMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#DEFAULT_SSL_KEYSTORE_TYPE"/>
        /// </summary>
        public static Java.Lang.String DEFAULT_SSL_KEYSTORE_TYPE { get { if (!_DEFAULT_SSL_KEYSTORE_TYPEReady) { _DEFAULT_SSL_KEYSTORE_TYPEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DEFAULT_SSL_KEYSTORE_TYPE"); _DEFAULT_SSL_KEYSTORE_TYPEReady = true; } return _DEFAULT_SSL_KEYSTORE_TYPEContent; } }
        private static Java.Lang.String _DEFAULT_SSL_KEYSTORE_TYPEContent = default;
        private static bool _DEFAULT_SSL_KEYSTORE_TYPEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#DEFAULT_SSL_PROTOCOL"/>
        /// </summary>
        public static Java.Lang.String DEFAULT_SSL_PROTOCOL { get { if (!_DEFAULT_SSL_PROTOCOLReady) { _DEFAULT_SSL_PROTOCOLContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DEFAULT_SSL_PROTOCOL"); _DEFAULT_SSL_PROTOCOLReady = true; } return _DEFAULT_SSL_PROTOCOLContent; } }
        private static Java.Lang.String _DEFAULT_SSL_PROTOCOLContent = default;
        private static bool _DEFAULT_SSL_PROTOCOLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#DEFAULT_SSL_TRUSTMANAGER_ALGORITHM"/>
        /// </summary>
        public static Java.Lang.String DEFAULT_SSL_TRUSTMANAGER_ALGORITHM { get { if (!_DEFAULT_SSL_TRUSTMANAGER_ALGORITHMReady) { _DEFAULT_SSL_TRUSTMANAGER_ALGORITHMContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DEFAULT_SSL_TRUSTMANAGER_ALGORITHM"); _DEFAULT_SSL_TRUSTMANAGER_ALGORITHMReady = true; } return _DEFAULT_SSL_TRUSTMANAGER_ALGORITHMContent; } }
        private static Java.Lang.String _DEFAULT_SSL_TRUSTMANAGER_ALGORITHMContent = default;
        private static bool _DEFAULT_SSL_TRUSTMANAGER_ALGORITHMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#DEFAULT_SSL_TRUSTSTORE_TYPE"/>
        /// </summary>
        public static Java.Lang.String DEFAULT_SSL_TRUSTSTORE_TYPE { get { if (!_DEFAULT_SSL_TRUSTSTORE_TYPEReady) { _DEFAULT_SSL_TRUSTSTORE_TYPEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DEFAULT_SSL_TRUSTSTORE_TYPE"); _DEFAULT_SSL_TRUSTSTORE_TYPEReady = true; } return _DEFAULT_SSL_TRUSTSTORE_TYPEContent; } }
        private static Java.Lang.String _DEFAULT_SSL_TRUSTSTORE_TYPEContent = default;
        private static bool _DEFAULT_SSL_TRUSTSTORE_TYPEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#SSL_CIPHER_SUITES_CONFIG"/>
        /// </summary>
        public static Java.Lang.String SSL_CIPHER_SUITES_CONFIG { get { if (!_SSL_CIPHER_SUITES_CONFIGReady) { _SSL_CIPHER_SUITES_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SSL_CIPHER_SUITES_CONFIG"); _SSL_CIPHER_SUITES_CONFIGReady = true; } return _SSL_CIPHER_SUITES_CONFIGContent; } }
        private static Java.Lang.String _SSL_CIPHER_SUITES_CONFIGContent = default;
        private static bool _SSL_CIPHER_SUITES_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#SSL_CIPHER_SUITES_DOC"/>
        /// </summary>
        public static Java.Lang.String SSL_CIPHER_SUITES_DOC { get { if (!_SSL_CIPHER_SUITES_DOCReady) { _SSL_CIPHER_SUITES_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SSL_CIPHER_SUITES_DOC"); _SSL_CIPHER_SUITES_DOCReady = true; } return _SSL_CIPHER_SUITES_DOCContent; } }
        private static Java.Lang.String _SSL_CIPHER_SUITES_DOCContent = default;
        private static bool _SSL_CIPHER_SUITES_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#SSL_ENABLED_PROTOCOLS_CONFIG"/>
        /// </summary>
        public static Java.Lang.String SSL_ENABLED_PROTOCOLS_CONFIG { get { if (!_SSL_ENABLED_PROTOCOLS_CONFIGReady) { _SSL_ENABLED_PROTOCOLS_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SSL_ENABLED_PROTOCOLS_CONFIG"); _SSL_ENABLED_PROTOCOLS_CONFIGReady = true; } return _SSL_ENABLED_PROTOCOLS_CONFIGContent; } }
        private static Java.Lang.String _SSL_ENABLED_PROTOCOLS_CONFIGContent = default;
        private static bool _SSL_ENABLED_PROTOCOLS_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#SSL_ENABLED_PROTOCOLS_DOC"/>
        /// </summary>
        public static Java.Lang.String SSL_ENABLED_PROTOCOLS_DOC { get { if (!_SSL_ENABLED_PROTOCOLS_DOCReady) { _SSL_ENABLED_PROTOCOLS_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SSL_ENABLED_PROTOCOLS_DOC"); _SSL_ENABLED_PROTOCOLS_DOCReady = true; } return _SSL_ENABLED_PROTOCOLS_DOCContent; } }
        private static Java.Lang.String _SSL_ENABLED_PROTOCOLS_DOCContent = default;
        private static bool _SSL_ENABLED_PROTOCOLS_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#SSL_ENDPOINT_IDENTIFICATION_ALGORITHM_CONFIG"/>
        /// </summary>
        public static Java.Lang.String SSL_ENDPOINT_IDENTIFICATION_ALGORITHM_CONFIG { get { if (!_SSL_ENDPOINT_IDENTIFICATION_ALGORITHM_CONFIGReady) { _SSL_ENDPOINT_IDENTIFICATION_ALGORITHM_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SSL_ENDPOINT_IDENTIFICATION_ALGORITHM_CONFIG"); _SSL_ENDPOINT_IDENTIFICATION_ALGORITHM_CONFIGReady = true; } return _SSL_ENDPOINT_IDENTIFICATION_ALGORITHM_CONFIGContent; } }
        private static Java.Lang.String _SSL_ENDPOINT_IDENTIFICATION_ALGORITHM_CONFIGContent = default;
        private static bool _SSL_ENDPOINT_IDENTIFICATION_ALGORITHM_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#SSL_ENDPOINT_IDENTIFICATION_ALGORITHM_DOC"/>
        /// </summary>
        public static Java.Lang.String SSL_ENDPOINT_IDENTIFICATION_ALGORITHM_DOC { get { if (!_SSL_ENDPOINT_IDENTIFICATION_ALGORITHM_DOCReady) { _SSL_ENDPOINT_IDENTIFICATION_ALGORITHM_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SSL_ENDPOINT_IDENTIFICATION_ALGORITHM_DOC"); _SSL_ENDPOINT_IDENTIFICATION_ALGORITHM_DOCReady = true; } return _SSL_ENDPOINT_IDENTIFICATION_ALGORITHM_DOCContent; } }
        private static Java.Lang.String _SSL_ENDPOINT_IDENTIFICATION_ALGORITHM_DOCContent = default;
        private static bool _SSL_ENDPOINT_IDENTIFICATION_ALGORITHM_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#SSL_ENGINE_FACTORY_CLASS_CONFIG"/>
        /// </summary>
        public static Java.Lang.String SSL_ENGINE_FACTORY_CLASS_CONFIG { get { if (!_SSL_ENGINE_FACTORY_CLASS_CONFIGReady) { _SSL_ENGINE_FACTORY_CLASS_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SSL_ENGINE_FACTORY_CLASS_CONFIG"); _SSL_ENGINE_FACTORY_CLASS_CONFIGReady = true; } return _SSL_ENGINE_FACTORY_CLASS_CONFIGContent; } }
        private static Java.Lang.String _SSL_ENGINE_FACTORY_CLASS_CONFIGContent = default;
        private static bool _SSL_ENGINE_FACTORY_CLASS_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#SSL_ENGINE_FACTORY_CLASS_DOC"/>
        /// </summary>
        public static Java.Lang.String SSL_ENGINE_FACTORY_CLASS_DOC { get { if (!_SSL_ENGINE_FACTORY_CLASS_DOCReady) { _SSL_ENGINE_FACTORY_CLASS_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SSL_ENGINE_FACTORY_CLASS_DOC"); _SSL_ENGINE_FACTORY_CLASS_DOCReady = true; } return _SSL_ENGINE_FACTORY_CLASS_DOCContent; } }
        private static Java.Lang.String _SSL_ENGINE_FACTORY_CLASS_DOCContent = default;
        private static bool _SSL_ENGINE_FACTORY_CLASS_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#SSL_KEY_PASSWORD_CONFIG"/>
        /// </summary>
        public static Java.Lang.String SSL_KEY_PASSWORD_CONFIG { get { if (!_SSL_KEY_PASSWORD_CONFIGReady) { _SSL_KEY_PASSWORD_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SSL_KEY_PASSWORD_CONFIG"); _SSL_KEY_PASSWORD_CONFIGReady = true; } return _SSL_KEY_PASSWORD_CONFIGContent; } }
        private static Java.Lang.String _SSL_KEY_PASSWORD_CONFIGContent = default;
        private static bool _SSL_KEY_PASSWORD_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#SSL_KEY_PASSWORD_DOC"/>
        /// </summary>
        public static Java.Lang.String SSL_KEY_PASSWORD_DOC { get { if (!_SSL_KEY_PASSWORD_DOCReady) { _SSL_KEY_PASSWORD_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SSL_KEY_PASSWORD_DOC"); _SSL_KEY_PASSWORD_DOCReady = true; } return _SSL_KEY_PASSWORD_DOCContent; } }
        private static Java.Lang.String _SSL_KEY_PASSWORD_DOCContent = default;
        private static bool _SSL_KEY_PASSWORD_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#SSL_KEYMANAGER_ALGORITHM_CONFIG"/>
        /// </summary>
        public static Java.Lang.String SSL_KEYMANAGER_ALGORITHM_CONFIG { get { if (!_SSL_KEYMANAGER_ALGORITHM_CONFIGReady) { _SSL_KEYMANAGER_ALGORITHM_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SSL_KEYMANAGER_ALGORITHM_CONFIG"); _SSL_KEYMANAGER_ALGORITHM_CONFIGReady = true; } return _SSL_KEYMANAGER_ALGORITHM_CONFIGContent; } }
        private static Java.Lang.String _SSL_KEYMANAGER_ALGORITHM_CONFIGContent = default;
        private static bool _SSL_KEYMANAGER_ALGORITHM_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#SSL_KEYMANAGER_ALGORITHM_DOC"/>
        /// </summary>
        public static Java.Lang.String SSL_KEYMANAGER_ALGORITHM_DOC { get { if (!_SSL_KEYMANAGER_ALGORITHM_DOCReady) { _SSL_KEYMANAGER_ALGORITHM_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SSL_KEYMANAGER_ALGORITHM_DOC"); _SSL_KEYMANAGER_ALGORITHM_DOCReady = true; } return _SSL_KEYMANAGER_ALGORITHM_DOCContent; } }
        private static Java.Lang.String _SSL_KEYMANAGER_ALGORITHM_DOCContent = default;
        private static bool _SSL_KEYMANAGER_ALGORITHM_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#SSL_KEYSTORE_CERTIFICATE_CHAIN_CONFIG"/>
        /// </summary>
        public static Java.Lang.String SSL_KEYSTORE_CERTIFICATE_CHAIN_CONFIG { get { if (!_SSL_KEYSTORE_CERTIFICATE_CHAIN_CONFIGReady) { _SSL_KEYSTORE_CERTIFICATE_CHAIN_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SSL_KEYSTORE_CERTIFICATE_CHAIN_CONFIG"); _SSL_KEYSTORE_CERTIFICATE_CHAIN_CONFIGReady = true; } return _SSL_KEYSTORE_CERTIFICATE_CHAIN_CONFIGContent; } }
        private static Java.Lang.String _SSL_KEYSTORE_CERTIFICATE_CHAIN_CONFIGContent = default;
        private static bool _SSL_KEYSTORE_CERTIFICATE_CHAIN_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#SSL_KEYSTORE_CERTIFICATE_CHAIN_DOC"/>
        /// </summary>
        public static Java.Lang.String SSL_KEYSTORE_CERTIFICATE_CHAIN_DOC { get { if (!_SSL_KEYSTORE_CERTIFICATE_CHAIN_DOCReady) { _SSL_KEYSTORE_CERTIFICATE_CHAIN_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SSL_KEYSTORE_CERTIFICATE_CHAIN_DOC"); _SSL_KEYSTORE_CERTIFICATE_CHAIN_DOCReady = true; } return _SSL_KEYSTORE_CERTIFICATE_CHAIN_DOCContent; } }
        private static Java.Lang.String _SSL_KEYSTORE_CERTIFICATE_CHAIN_DOCContent = default;
        private static bool _SSL_KEYSTORE_CERTIFICATE_CHAIN_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#SSL_KEYSTORE_KEY_CONFIG"/>
        /// </summary>
        public static Java.Lang.String SSL_KEYSTORE_KEY_CONFIG { get { if (!_SSL_KEYSTORE_KEY_CONFIGReady) { _SSL_KEYSTORE_KEY_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SSL_KEYSTORE_KEY_CONFIG"); _SSL_KEYSTORE_KEY_CONFIGReady = true; } return _SSL_KEYSTORE_KEY_CONFIGContent; } }
        private static Java.Lang.String _SSL_KEYSTORE_KEY_CONFIGContent = default;
        private static bool _SSL_KEYSTORE_KEY_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#SSL_KEYSTORE_KEY_DOC"/>
        /// </summary>
        public static Java.Lang.String SSL_KEYSTORE_KEY_DOC { get { if (!_SSL_KEYSTORE_KEY_DOCReady) { _SSL_KEYSTORE_KEY_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SSL_KEYSTORE_KEY_DOC"); _SSL_KEYSTORE_KEY_DOCReady = true; } return _SSL_KEYSTORE_KEY_DOCContent; } }
        private static Java.Lang.String _SSL_KEYSTORE_KEY_DOCContent = default;
        private static bool _SSL_KEYSTORE_KEY_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#SSL_KEYSTORE_LOCATION_CONFIG"/>
        /// </summary>
        public static Java.Lang.String SSL_KEYSTORE_LOCATION_CONFIG { get { if (!_SSL_KEYSTORE_LOCATION_CONFIGReady) { _SSL_KEYSTORE_LOCATION_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SSL_KEYSTORE_LOCATION_CONFIG"); _SSL_KEYSTORE_LOCATION_CONFIGReady = true; } return _SSL_KEYSTORE_LOCATION_CONFIGContent; } }
        private static Java.Lang.String _SSL_KEYSTORE_LOCATION_CONFIGContent = default;
        private static bool _SSL_KEYSTORE_LOCATION_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#SSL_KEYSTORE_LOCATION_DOC"/>
        /// </summary>
        public static Java.Lang.String SSL_KEYSTORE_LOCATION_DOC { get { if (!_SSL_KEYSTORE_LOCATION_DOCReady) { _SSL_KEYSTORE_LOCATION_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SSL_KEYSTORE_LOCATION_DOC"); _SSL_KEYSTORE_LOCATION_DOCReady = true; } return _SSL_KEYSTORE_LOCATION_DOCContent; } }
        private static Java.Lang.String _SSL_KEYSTORE_LOCATION_DOCContent = default;
        private static bool _SSL_KEYSTORE_LOCATION_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#SSL_KEYSTORE_PASSWORD_CONFIG"/>
        /// </summary>
        public static Java.Lang.String SSL_KEYSTORE_PASSWORD_CONFIG { get { if (!_SSL_KEYSTORE_PASSWORD_CONFIGReady) { _SSL_KEYSTORE_PASSWORD_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SSL_KEYSTORE_PASSWORD_CONFIG"); _SSL_KEYSTORE_PASSWORD_CONFIGReady = true; } return _SSL_KEYSTORE_PASSWORD_CONFIGContent; } }
        private static Java.Lang.String _SSL_KEYSTORE_PASSWORD_CONFIGContent = default;
        private static bool _SSL_KEYSTORE_PASSWORD_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#SSL_KEYSTORE_PASSWORD_DOC"/>
        /// </summary>
        public static Java.Lang.String SSL_KEYSTORE_PASSWORD_DOC { get { if (!_SSL_KEYSTORE_PASSWORD_DOCReady) { _SSL_KEYSTORE_PASSWORD_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SSL_KEYSTORE_PASSWORD_DOC"); _SSL_KEYSTORE_PASSWORD_DOCReady = true; } return _SSL_KEYSTORE_PASSWORD_DOCContent; } }
        private static Java.Lang.String _SSL_KEYSTORE_PASSWORD_DOCContent = default;
        private static bool _SSL_KEYSTORE_PASSWORD_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#SSL_KEYSTORE_TYPE_CONFIG"/>
        /// </summary>
        public static Java.Lang.String SSL_KEYSTORE_TYPE_CONFIG { get { if (!_SSL_KEYSTORE_TYPE_CONFIGReady) { _SSL_KEYSTORE_TYPE_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SSL_KEYSTORE_TYPE_CONFIG"); _SSL_KEYSTORE_TYPE_CONFIGReady = true; } return _SSL_KEYSTORE_TYPE_CONFIGContent; } }
        private static Java.Lang.String _SSL_KEYSTORE_TYPE_CONFIGContent = default;
        private static bool _SSL_KEYSTORE_TYPE_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#SSL_KEYSTORE_TYPE_DOC"/>
        /// </summary>
        public static Java.Lang.String SSL_KEYSTORE_TYPE_DOC { get { if (!_SSL_KEYSTORE_TYPE_DOCReady) { _SSL_KEYSTORE_TYPE_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SSL_KEYSTORE_TYPE_DOC"); _SSL_KEYSTORE_TYPE_DOCReady = true; } return _SSL_KEYSTORE_TYPE_DOCContent; } }
        private static Java.Lang.String _SSL_KEYSTORE_TYPE_DOCContent = default;
        private static bool _SSL_KEYSTORE_TYPE_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#SSL_PROTOCOL_CONFIG"/>
        /// </summary>
        public static Java.Lang.String SSL_PROTOCOL_CONFIG { get { if (!_SSL_PROTOCOL_CONFIGReady) { _SSL_PROTOCOL_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SSL_PROTOCOL_CONFIG"); _SSL_PROTOCOL_CONFIGReady = true; } return _SSL_PROTOCOL_CONFIGContent; } }
        private static Java.Lang.String _SSL_PROTOCOL_CONFIGContent = default;
        private static bool _SSL_PROTOCOL_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#SSL_PROTOCOL_DOC"/>
        /// </summary>
        public static Java.Lang.String SSL_PROTOCOL_DOC { get { if (!_SSL_PROTOCOL_DOCReady) { _SSL_PROTOCOL_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SSL_PROTOCOL_DOC"); _SSL_PROTOCOL_DOCReady = true; } return _SSL_PROTOCOL_DOCContent; } }
        private static Java.Lang.String _SSL_PROTOCOL_DOCContent = default;
        private static bool _SSL_PROTOCOL_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#SSL_PROVIDER_CONFIG"/>
        /// </summary>
        public static Java.Lang.String SSL_PROVIDER_CONFIG { get { if (!_SSL_PROVIDER_CONFIGReady) { _SSL_PROVIDER_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SSL_PROVIDER_CONFIG"); _SSL_PROVIDER_CONFIGReady = true; } return _SSL_PROVIDER_CONFIGContent; } }
        private static Java.Lang.String _SSL_PROVIDER_CONFIGContent = default;
        private static bool _SSL_PROVIDER_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#SSL_PROVIDER_DOC"/>
        /// </summary>
        public static Java.Lang.String SSL_PROVIDER_DOC { get { if (!_SSL_PROVIDER_DOCReady) { _SSL_PROVIDER_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SSL_PROVIDER_DOC"); _SSL_PROVIDER_DOCReady = true; } return _SSL_PROVIDER_DOCContent; } }
        private static Java.Lang.String _SSL_PROVIDER_DOCContent = default;
        private static bool _SSL_PROVIDER_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#SSL_SECURE_RANDOM_IMPLEMENTATION_CONFIG"/>
        /// </summary>
        public static Java.Lang.String SSL_SECURE_RANDOM_IMPLEMENTATION_CONFIG { get { if (!_SSL_SECURE_RANDOM_IMPLEMENTATION_CONFIGReady) { _SSL_SECURE_RANDOM_IMPLEMENTATION_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SSL_SECURE_RANDOM_IMPLEMENTATION_CONFIG"); _SSL_SECURE_RANDOM_IMPLEMENTATION_CONFIGReady = true; } return _SSL_SECURE_RANDOM_IMPLEMENTATION_CONFIGContent; } }
        private static Java.Lang.String _SSL_SECURE_RANDOM_IMPLEMENTATION_CONFIGContent = default;
        private static bool _SSL_SECURE_RANDOM_IMPLEMENTATION_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#SSL_SECURE_RANDOM_IMPLEMENTATION_DOC"/>
        /// </summary>
        public static Java.Lang.String SSL_SECURE_RANDOM_IMPLEMENTATION_DOC { get { if (!_SSL_SECURE_RANDOM_IMPLEMENTATION_DOCReady) { _SSL_SECURE_RANDOM_IMPLEMENTATION_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SSL_SECURE_RANDOM_IMPLEMENTATION_DOC"); _SSL_SECURE_RANDOM_IMPLEMENTATION_DOCReady = true; } return _SSL_SECURE_RANDOM_IMPLEMENTATION_DOCContent; } }
        private static Java.Lang.String _SSL_SECURE_RANDOM_IMPLEMENTATION_DOCContent = default;
        private static bool _SSL_SECURE_RANDOM_IMPLEMENTATION_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#SSL_TRUSTMANAGER_ALGORITHM_CONFIG"/>
        /// </summary>
        public static Java.Lang.String SSL_TRUSTMANAGER_ALGORITHM_CONFIG { get { if (!_SSL_TRUSTMANAGER_ALGORITHM_CONFIGReady) { _SSL_TRUSTMANAGER_ALGORITHM_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SSL_TRUSTMANAGER_ALGORITHM_CONFIG"); _SSL_TRUSTMANAGER_ALGORITHM_CONFIGReady = true; } return _SSL_TRUSTMANAGER_ALGORITHM_CONFIGContent; } }
        private static Java.Lang.String _SSL_TRUSTMANAGER_ALGORITHM_CONFIGContent = default;
        private static bool _SSL_TRUSTMANAGER_ALGORITHM_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#SSL_TRUSTMANAGER_ALGORITHM_DOC"/>
        /// </summary>
        public static Java.Lang.String SSL_TRUSTMANAGER_ALGORITHM_DOC { get { if (!_SSL_TRUSTMANAGER_ALGORITHM_DOCReady) { _SSL_TRUSTMANAGER_ALGORITHM_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SSL_TRUSTMANAGER_ALGORITHM_DOC"); _SSL_TRUSTMANAGER_ALGORITHM_DOCReady = true; } return _SSL_TRUSTMANAGER_ALGORITHM_DOCContent; } }
        private static Java.Lang.String _SSL_TRUSTMANAGER_ALGORITHM_DOCContent = default;
        private static bool _SSL_TRUSTMANAGER_ALGORITHM_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#SSL_TRUSTSTORE_CERTIFICATES_CONFIG"/>
        /// </summary>
        public static Java.Lang.String SSL_TRUSTSTORE_CERTIFICATES_CONFIG { get { if (!_SSL_TRUSTSTORE_CERTIFICATES_CONFIGReady) { _SSL_TRUSTSTORE_CERTIFICATES_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SSL_TRUSTSTORE_CERTIFICATES_CONFIG"); _SSL_TRUSTSTORE_CERTIFICATES_CONFIGReady = true; } return _SSL_TRUSTSTORE_CERTIFICATES_CONFIGContent; } }
        private static Java.Lang.String _SSL_TRUSTSTORE_CERTIFICATES_CONFIGContent = default;
        private static bool _SSL_TRUSTSTORE_CERTIFICATES_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#SSL_TRUSTSTORE_CERTIFICATES_DOC"/>
        /// </summary>
        public static Java.Lang.String SSL_TRUSTSTORE_CERTIFICATES_DOC { get { if (!_SSL_TRUSTSTORE_CERTIFICATES_DOCReady) { _SSL_TRUSTSTORE_CERTIFICATES_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SSL_TRUSTSTORE_CERTIFICATES_DOC"); _SSL_TRUSTSTORE_CERTIFICATES_DOCReady = true; } return _SSL_TRUSTSTORE_CERTIFICATES_DOCContent; } }
        private static Java.Lang.String _SSL_TRUSTSTORE_CERTIFICATES_DOCContent = default;
        private static bool _SSL_TRUSTSTORE_CERTIFICATES_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#SSL_TRUSTSTORE_LOCATION_CONFIG"/>
        /// </summary>
        public static Java.Lang.String SSL_TRUSTSTORE_LOCATION_CONFIG { get { if (!_SSL_TRUSTSTORE_LOCATION_CONFIGReady) { _SSL_TRUSTSTORE_LOCATION_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SSL_TRUSTSTORE_LOCATION_CONFIG"); _SSL_TRUSTSTORE_LOCATION_CONFIGReady = true; } return _SSL_TRUSTSTORE_LOCATION_CONFIGContent; } }
        private static Java.Lang.String _SSL_TRUSTSTORE_LOCATION_CONFIGContent = default;
        private static bool _SSL_TRUSTSTORE_LOCATION_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#SSL_TRUSTSTORE_LOCATION_DOC"/>
        /// </summary>
        public static Java.Lang.String SSL_TRUSTSTORE_LOCATION_DOC { get { if (!_SSL_TRUSTSTORE_LOCATION_DOCReady) { _SSL_TRUSTSTORE_LOCATION_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SSL_TRUSTSTORE_LOCATION_DOC"); _SSL_TRUSTSTORE_LOCATION_DOCReady = true; } return _SSL_TRUSTSTORE_LOCATION_DOCContent; } }
        private static Java.Lang.String _SSL_TRUSTSTORE_LOCATION_DOCContent = default;
        private static bool _SSL_TRUSTSTORE_LOCATION_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#SSL_TRUSTSTORE_PASSWORD_CONFIG"/>
        /// </summary>
        public static Java.Lang.String SSL_TRUSTSTORE_PASSWORD_CONFIG { get { if (!_SSL_TRUSTSTORE_PASSWORD_CONFIGReady) { _SSL_TRUSTSTORE_PASSWORD_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SSL_TRUSTSTORE_PASSWORD_CONFIG"); _SSL_TRUSTSTORE_PASSWORD_CONFIGReady = true; } return _SSL_TRUSTSTORE_PASSWORD_CONFIGContent; } }
        private static Java.Lang.String _SSL_TRUSTSTORE_PASSWORD_CONFIGContent = default;
        private static bool _SSL_TRUSTSTORE_PASSWORD_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#SSL_TRUSTSTORE_PASSWORD_DOC"/>
        /// </summary>
        public static Java.Lang.String SSL_TRUSTSTORE_PASSWORD_DOC { get { if (!_SSL_TRUSTSTORE_PASSWORD_DOCReady) { _SSL_TRUSTSTORE_PASSWORD_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SSL_TRUSTSTORE_PASSWORD_DOC"); _SSL_TRUSTSTORE_PASSWORD_DOCReady = true; } return _SSL_TRUSTSTORE_PASSWORD_DOCContent; } }
        private static Java.Lang.String _SSL_TRUSTSTORE_PASSWORD_DOCContent = default;
        private static bool _SSL_TRUSTSTORE_PASSWORD_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#SSL_TRUSTSTORE_TYPE_CONFIG"/>
        /// </summary>
        public static Java.Lang.String SSL_TRUSTSTORE_TYPE_CONFIG { get { if (!_SSL_TRUSTSTORE_TYPE_CONFIGReady) { _SSL_TRUSTSTORE_TYPE_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SSL_TRUSTSTORE_TYPE_CONFIG"); _SSL_TRUSTSTORE_TYPE_CONFIGReady = true; } return _SSL_TRUSTSTORE_TYPE_CONFIGContent; } }
        private static Java.Lang.String _SSL_TRUSTSTORE_TYPE_CONFIGContent = default;
        private static bool _SSL_TRUSTSTORE_TYPE_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#SSL_TRUSTSTORE_TYPE_DOC"/>
        /// </summary>
        public static Java.Lang.String SSL_TRUSTSTORE_TYPE_DOC { get { if (!_SSL_TRUSTSTORE_TYPE_DOCReady) { _SSL_TRUSTSTORE_TYPE_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SSL_TRUSTSTORE_TYPE_DOC"); _SSL_TRUSTSTORE_TYPE_DOCReady = true; } return _SSL_TRUSTSTORE_TYPE_DOCContent; } }
        private static Java.Lang.String _SSL_TRUSTSTORE_TYPE_DOCContent = default;
        private static bool _SSL_TRUSTSTORE_TYPE_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#NON_RECONFIGURABLE_CONFIGS"/>
        /// </summary>
        public static Java.Util.Set NON_RECONFIGURABLE_CONFIGS { get { if (!_NON_RECONFIGURABLE_CONFIGSReady) { _NON_RECONFIGURABLE_CONFIGSContent = SGetField<Java.Util.Set>(LocalBridgeClazz, "NON_RECONFIGURABLE_CONFIGS"); _NON_RECONFIGURABLE_CONFIGSReady = true; } return _NON_RECONFIGURABLE_CONFIGSContent; } }
        private static Java.Util.Set _NON_RECONFIGURABLE_CONFIGSContent = default;
        private static bool _NON_RECONFIGURABLE_CONFIGSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#RECONFIGURABLE_CONFIGS"/>
        /// </summary>
        public static Java.Util.Set RECONFIGURABLE_CONFIGS { get { if (!_RECONFIGURABLE_CONFIGSReady) { _RECONFIGURABLE_CONFIGSContent = SGetField<Java.Util.Set>(LocalBridgeClazz, "RECONFIGURABLE_CONFIGS"); _RECONFIGURABLE_CONFIGSReady = true; } return _RECONFIGURABLE_CONFIGSContent; } }
        private static Java.Util.Set _RECONFIGURABLE_CONFIGSContent = default;
        private static bool _RECONFIGURABLE_CONFIGSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslConfigs.html#addClientSslSupport-org.apache.kafka.common.config.ConfigDef-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Config.ConfigDef"/></param>
        public static void AddClientSslSupport(Org.Apache.Kafka.Common.Config.ConfigDef arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "addClientSslSupport", "(Lorg/apache/kafka/common/config/ConfigDef;)V", arg0);
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