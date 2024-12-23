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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*  using kafka-clients-3.9.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Admin
{
    #region AdminClientConfig declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/AdminClientConfig.html"/>
    /// </summary>
    public partial class AdminClientConfig : Org.Apache.Kafka.Common.Config.AbstractConfig, MASES.JCOBridge.C2JBridge.IJVMBridgeMain
    {
        const string _bridgeClassName = "org.apache.kafka.clients.admin.AdminClientConfig";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AdminClientConfig() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AdminClientConfig(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region AdminClientConfig implementation
    public partial class AdminClientConfig
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/AdminClientConfig.html#org.apache.kafka.clients.admin.AdminClientConfig(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public AdminClientConfig(Java.Util.Map<object, object> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/AdminClientConfig.html#AUTO_INCLUDE_JMX_REPORTER_DOC"/>
        /// </summary>
        public static Java.Lang.String AUTO_INCLUDE_JMX_REPORTER_DOC { get { if (!_AUTO_INCLUDE_JMX_REPORTER_DOCReady) { _AUTO_INCLUDE_JMX_REPORTER_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "AUTO_INCLUDE_JMX_REPORTER_DOC"); _AUTO_INCLUDE_JMX_REPORTER_DOCReady = true; } return _AUTO_INCLUDE_JMX_REPORTER_DOCContent; } }
        private static Java.Lang.String _AUTO_INCLUDE_JMX_REPORTER_DOCContent = default;
        private static bool _AUTO_INCLUDE_JMX_REPORTER_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/AdminClientConfig.html#BOOTSTRAP_CONTROLLERS_CONFIG"/>
        /// </summary>
        public static Java.Lang.String BOOTSTRAP_CONTROLLERS_CONFIG { get { if (!_BOOTSTRAP_CONTROLLERS_CONFIGReady) { _BOOTSTRAP_CONTROLLERS_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "BOOTSTRAP_CONTROLLERS_CONFIG"); _BOOTSTRAP_CONTROLLERS_CONFIGReady = true; } return _BOOTSTRAP_CONTROLLERS_CONFIGContent; } }
        private static Java.Lang.String _BOOTSTRAP_CONTROLLERS_CONFIGContent = default;
        private static bool _BOOTSTRAP_CONTROLLERS_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/AdminClientConfig.html#BOOTSTRAP_CONTROLLERS_DOC"/>
        /// </summary>
        public static Java.Lang.String BOOTSTRAP_CONTROLLERS_DOC { get { if (!_BOOTSTRAP_CONTROLLERS_DOCReady) { _BOOTSTRAP_CONTROLLERS_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "BOOTSTRAP_CONTROLLERS_DOC"); _BOOTSTRAP_CONTROLLERS_DOCReady = true; } return _BOOTSTRAP_CONTROLLERS_DOCContent; } }
        private static Java.Lang.String _BOOTSTRAP_CONTROLLERS_DOCContent = default;
        private static bool _BOOTSTRAP_CONTROLLERS_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/AdminClientConfig.html#BOOTSTRAP_SERVERS_CONFIG"/>
        /// </summary>
        public static Java.Lang.String BOOTSTRAP_SERVERS_CONFIG { get { if (!_BOOTSTRAP_SERVERS_CONFIGReady) { _BOOTSTRAP_SERVERS_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "BOOTSTRAP_SERVERS_CONFIG"); _BOOTSTRAP_SERVERS_CONFIGReady = true; } return _BOOTSTRAP_SERVERS_CONFIGContent; } }
        private static Java.Lang.String _BOOTSTRAP_SERVERS_CONFIGContent = default;
        private static bool _BOOTSTRAP_SERVERS_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/AdminClientConfig.html#CLIENT_DNS_LOOKUP_CONFIG"/>
        /// </summary>
        public static Java.Lang.String CLIENT_DNS_LOOKUP_CONFIG { get { if (!_CLIENT_DNS_LOOKUP_CONFIGReady) { _CLIENT_DNS_LOOKUP_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CLIENT_DNS_LOOKUP_CONFIG"); _CLIENT_DNS_LOOKUP_CONFIGReady = true; } return _CLIENT_DNS_LOOKUP_CONFIGContent; } }
        private static Java.Lang.String _CLIENT_DNS_LOOKUP_CONFIGContent = default;
        private static bool _CLIENT_DNS_LOOKUP_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/AdminClientConfig.html#CLIENT_ID_CONFIG"/>
        /// </summary>
        public static Java.Lang.String CLIENT_ID_CONFIG { get { if (!_CLIENT_ID_CONFIGReady) { _CLIENT_ID_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CLIENT_ID_CONFIG"); _CLIENT_ID_CONFIGReady = true; } return _CLIENT_ID_CONFIGContent; } }
        private static Java.Lang.String _CLIENT_ID_CONFIGContent = default;
        private static bool _CLIENT_ID_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/AdminClientConfig.html#CONNECTIONS_MAX_IDLE_MS_CONFIG"/>
        /// </summary>
        public static Java.Lang.String CONNECTIONS_MAX_IDLE_MS_CONFIG { get { if (!_CONNECTIONS_MAX_IDLE_MS_CONFIGReady) { _CONNECTIONS_MAX_IDLE_MS_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CONNECTIONS_MAX_IDLE_MS_CONFIG"); _CONNECTIONS_MAX_IDLE_MS_CONFIGReady = true; } return _CONNECTIONS_MAX_IDLE_MS_CONFIGContent; } }
        private static Java.Lang.String _CONNECTIONS_MAX_IDLE_MS_CONFIGContent = default;
        private static bool _CONNECTIONS_MAX_IDLE_MS_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/AdminClientConfig.html#DEFAULT_API_TIMEOUT_MS_CONFIG"/>
        /// </summary>
        public static Java.Lang.String DEFAULT_API_TIMEOUT_MS_CONFIG { get { if (!_DEFAULT_API_TIMEOUT_MS_CONFIGReady) { _DEFAULT_API_TIMEOUT_MS_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DEFAULT_API_TIMEOUT_MS_CONFIG"); _DEFAULT_API_TIMEOUT_MS_CONFIGReady = true; } return _DEFAULT_API_TIMEOUT_MS_CONFIGContent; } }
        private static Java.Lang.String _DEFAULT_API_TIMEOUT_MS_CONFIGContent = default;
        private static bool _DEFAULT_API_TIMEOUT_MS_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/AdminClientConfig.html#DEFAULT_METADATA_RECOVERY_STRATEGY"/>
        /// </summary>
        public static Java.Lang.String DEFAULT_METADATA_RECOVERY_STRATEGY { get { if (!_DEFAULT_METADATA_RECOVERY_STRATEGYReady) { _DEFAULT_METADATA_RECOVERY_STRATEGYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DEFAULT_METADATA_RECOVERY_STRATEGY"); _DEFAULT_METADATA_RECOVERY_STRATEGYReady = true; } return _DEFAULT_METADATA_RECOVERY_STRATEGYContent; } }
        private static Java.Lang.String _DEFAULT_METADATA_RECOVERY_STRATEGYContent = default;
        private static bool _DEFAULT_METADATA_RECOVERY_STRATEGYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/AdminClientConfig.html#DEFAULT_SECURITY_PROTOCOL"/>
        /// </summary>
        public static Java.Lang.String DEFAULT_SECURITY_PROTOCOL { get { if (!_DEFAULT_SECURITY_PROTOCOLReady) { _DEFAULT_SECURITY_PROTOCOLContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DEFAULT_SECURITY_PROTOCOL"); _DEFAULT_SECURITY_PROTOCOLReady = true; } return _DEFAULT_SECURITY_PROTOCOLContent; } }
        private static Java.Lang.String _DEFAULT_SECURITY_PROTOCOLContent = default;
        private static bool _DEFAULT_SECURITY_PROTOCOLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/AdminClientConfig.html#ENABLE_METRICS_PUSH_CONFIG"/>
        /// </summary>
        public static Java.Lang.String ENABLE_METRICS_PUSH_CONFIG { get { if (!_ENABLE_METRICS_PUSH_CONFIGReady) { _ENABLE_METRICS_PUSH_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ENABLE_METRICS_PUSH_CONFIG"); _ENABLE_METRICS_PUSH_CONFIGReady = true; } return _ENABLE_METRICS_PUSH_CONFIGContent; } }
        private static Java.Lang.String _ENABLE_METRICS_PUSH_CONFIGContent = default;
        private static bool _ENABLE_METRICS_PUSH_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/AdminClientConfig.html#ENABLE_METRICS_PUSH_DOC"/>
        /// </summary>
        public static Java.Lang.String ENABLE_METRICS_PUSH_DOC { get { if (!_ENABLE_METRICS_PUSH_DOCReady) { _ENABLE_METRICS_PUSH_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ENABLE_METRICS_PUSH_DOC"); _ENABLE_METRICS_PUSH_DOCReady = true; } return _ENABLE_METRICS_PUSH_DOCContent; } }
        private static Java.Lang.String _ENABLE_METRICS_PUSH_DOCContent = default;
        private static bool _ENABLE_METRICS_PUSH_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/AdminClientConfig.html#METADATA_MAX_AGE_CONFIG"/>
        /// </summary>
        public static Java.Lang.String METADATA_MAX_AGE_CONFIG { get { if (!_METADATA_MAX_AGE_CONFIGReady) { _METADATA_MAX_AGE_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "METADATA_MAX_AGE_CONFIG"); _METADATA_MAX_AGE_CONFIGReady = true; } return _METADATA_MAX_AGE_CONFIGContent; } }
        private static Java.Lang.String _METADATA_MAX_AGE_CONFIGContent = default;
        private static bool _METADATA_MAX_AGE_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/AdminClientConfig.html#METADATA_RECOVERY_STRATEGY_CONFIG"/>
        /// </summary>
        public static Java.Lang.String METADATA_RECOVERY_STRATEGY_CONFIG { get { if (!_METADATA_RECOVERY_STRATEGY_CONFIGReady) { _METADATA_RECOVERY_STRATEGY_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "METADATA_RECOVERY_STRATEGY_CONFIG"); _METADATA_RECOVERY_STRATEGY_CONFIGReady = true; } return _METADATA_RECOVERY_STRATEGY_CONFIGContent; } }
        private static Java.Lang.String _METADATA_RECOVERY_STRATEGY_CONFIGContent = default;
        private static bool _METADATA_RECOVERY_STRATEGY_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/AdminClientConfig.html#METADATA_RECOVERY_STRATEGY_DOC"/>
        /// </summary>
        public static Java.Lang.String METADATA_RECOVERY_STRATEGY_DOC { get { if (!_METADATA_RECOVERY_STRATEGY_DOCReady) { _METADATA_RECOVERY_STRATEGY_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "METADATA_RECOVERY_STRATEGY_DOC"); _METADATA_RECOVERY_STRATEGY_DOCReady = true; } return _METADATA_RECOVERY_STRATEGY_DOCContent; } }
        private static Java.Lang.String _METADATA_RECOVERY_STRATEGY_DOCContent = default;
        private static bool _METADATA_RECOVERY_STRATEGY_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/AdminClientConfig.html#METRIC_REPORTER_CLASSES_CONFIG"/>
        /// </summary>
        public static Java.Lang.String METRIC_REPORTER_CLASSES_CONFIG { get { if (!_METRIC_REPORTER_CLASSES_CONFIGReady) { _METRIC_REPORTER_CLASSES_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "METRIC_REPORTER_CLASSES_CONFIG"); _METRIC_REPORTER_CLASSES_CONFIGReady = true; } return _METRIC_REPORTER_CLASSES_CONFIGContent; } }
        private static Java.Lang.String _METRIC_REPORTER_CLASSES_CONFIGContent = default;
        private static bool _METRIC_REPORTER_CLASSES_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/AdminClientConfig.html#METRICS_NUM_SAMPLES_CONFIG"/>
        /// </summary>
        public static Java.Lang.String METRICS_NUM_SAMPLES_CONFIG { get { if (!_METRICS_NUM_SAMPLES_CONFIGReady) { _METRICS_NUM_SAMPLES_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "METRICS_NUM_SAMPLES_CONFIG"); _METRICS_NUM_SAMPLES_CONFIGReady = true; } return _METRICS_NUM_SAMPLES_CONFIGContent; } }
        private static Java.Lang.String _METRICS_NUM_SAMPLES_CONFIGContent = default;
        private static bool _METRICS_NUM_SAMPLES_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/AdminClientConfig.html#METRICS_RECORDING_LEVEL_CONFIG"/>
        /// </summary>
        public static Java.Lang.String METRICS_RECORDING_LEVEL_CONFIG { get { if (!_METRICS_RECORDING_LEVEL_CONFIGReady) { _METRICS_RECORDING_LEVEL_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "METRICS_RECORDING_LEVEL_CONFIG"); _METRICS_RECORDING_LEVEL_CONFIGReady = true; } return _METRICS_RECORDING_LEVEL_CONFIGContent; } }
        private static Java.Lang.String _METRICS_RECORDING_LEVEL_CONFIGContent = default;
        private static bool _METRICS_RECORDING_LEVEL_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/AdminClientConfig.html#METRICS_SAMPLE_WINDOW_MS_CONFIG"/>
        /// </summary>
        public static Java.Lang.String METRICS_SAMPLE_WINDOW_MS_CONFIG { get { if (!_METRICS_SAMPLE_WINDOW_MS_CONFIGReady) { _METRICS_SAMPLE_WINDOW_MS_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "METRICS_SAMPLE_WINDOW_MS_CONFIG"); _METRICS_SAMPLE_WINDOW_MS_CONFIGReady = true; } return _METRICS_SAMPLE_WINDOW_MS_CONFIGContent; } }
        private static Java.Lang.String _METRICS_SAMPLE_WINDOW_MS_CONFIGContent = default;
        private static bool _METRICS_SAMPLE_WINDOW_MS_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/AdminClientConfig.html#RECEIVE_BUFFER_CONFIG"/>
        /// </summary>
        public static Java.Lang.String RECEIVE_BUFFER_CONFIG { get { if (!_RECEIVE_BUFFER_CONFIGReady) { _RECEIVE_BUFFER_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "RECEIVE_BUFFER_CONFIG"); _RECEIVE_BUFFER_CONFIGReady = true; } return _RECEIVE_BUFFER_CONFIGContent; } }
        private static Java.Lang.String _RECEIVE_BUFFER_CONFIGContent = default;
        private static bool _RECEIVE_BUFFER_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/AdminClientConfig.html#RECONNECT_BACKOFF_MAX_MS_CONFIG"/>
        /// </summary>
        public static Java.Lang.String RECONNECT_BACKOFF_MAX_MS_CONFIG { get { if (!_RECONNECT_BACKOFF_MAX_MS_CONFIGReady) { _RECONNECT_BACKOFF_MAX_MS_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "RECONNECT_BACKOFF_MAX_MS_CONFIG"); _RECONNECT_BACKOFF_MAX_MS_CONFIGReady = true; } return _RECONNECT_BACKOFF_MAX_MS_CONFIGContent; } }
        private static Java.Lang.String _RECONNECT_BACKOFF_MAX_MS_CONFIGContent = default;
        private static bool _RECONNECT_BACKOFF_MAX_MS_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/AdminClientConfig.html#RECONNECT_BACKOFF_MS_CONFIG"/>
        /// </summary>
        public static Java.Lang.String RECONNECT_BACKOFF_MS_CONFIG { get { if (!_RECONNECT_BACKOFF_MS_CONFIGReady) { _RECONNECT_BACKOFF_MS_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "RECONNECT_BACKOFF_MS_CONFIG"); _RECONNECT_BACKOFF_MS_CONFIGReady = true; } return _RECONNECT_BACKOFF_MS_CONFIGContent; } }
        private static Java.Lang.String _RECONNECT_BACKOFF_MS_CONFIGContent = default;
        private static bool _RECONNECT_BACKOFF_MS_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/AdminClientConfig.html#REQUEST_TIMEOUT_MS_CONFIG"/>
        /// </summary>
        public static Java.Lang.String REQUEST_TIMEOUT_MS_CONFIG { get { if (!_REQUEST_TIMEOUT_MS_CONFIGReady) { _REQUEST_TIMEOUT_MS_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "REQUEST_TIMEOUT_MS_CONFIG"); _REQUEST_TIMEOUT_MS_CONFIGReady = true; } return _REQUEST_TIMEOUT_MS_CONFIGContent; } }
        private static Java.Lang.String _REQUEST_TIMEOUT_MS_CONFIGContent = default;
        private static bool _REQUEST_TIMEOUT_MS_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/AdminClientConfig.html#RETRIES_CONFIG"/>
        /// </summary>
        public static Java.Lang.String RETRIES_CONFIG { get { if (!_RETRIES_CONFIGReady) { _RETRIES_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "RETRIES_CONFIG"); _RETRIES_CONFIGReady = true; } return _RETRIES_CONFIGContent; } }
        private static Java.Lang.String _RETRIES_CONFIGContent = default;
        private static bool _RETRIES_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/AdminClientConfig.html#RETRY_BACKOFF_MAX_MS_CONFIG"/>
        /// </summary>
        public static Java.Lang.String RETRY_BACKOFF_MAX_MS_CONFIG { get { if (!_RETRY_BACKOFF_MAX_MS_CONFIGReady) { _RETRY_BACKOFF_MAX_MS_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "RETRY_BACKOFF_MAX_MS_CONFIG"); _RETRY_BACKOFF_MAX_MS_CONFIGReady = true; } return _RETRY_BACKOFF_MAX_MS_CONFIGContent; } }
        private static Java.Lang.String _RETRY_BACKOFF_MAX_MS_CONFIGContent = default;
        private static bool _RETRY_BACKOFF_MAX_MS_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/AdminClientConfig.html#RETRY_BACKOFF_MS_CONFIG"/>
        /// </summary>
        public static Java.Lang.String RETRY_BACKOFF_MS_CONFIG { get { if (!_RETRY_BACKOFF_MS_CONFIGReady) { _RETRY_BACKOFF_MS_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "RETRY_BACKOFF_MS_CONFIG"); _RETRY_BACKOFF_MS_CONFIGReady = true; } return _RETRY_BACKOFF_MS_CONFIGContent; } }
        private static Java.Lang.String _RETRY_BACKOFF_MS_CONFIGContent = default;
        private static bool _RETRY_BACKOFF_MS_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/AdminClientConfig.html#SECURITY_PROTOCOL_CONFIG"/>
        /// </summary>
        public static Java.Lang.String SECURITY_PROTOCOL_CONFIG { get { if (!_SECURITY_PROTOCOL_CONFIGReady) { _SECURITY_PROTOCOL_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SECURITY_PROTOCOL_CONFIG"); _SECURITY_PROTOCOL_CONFIGReady = true; } return _SECURITY_PROTOCOL_CONFIGContent; } }
        private static Java.Lang.String _SECURITY_PROTOCOL_CONFIGContent = default;
        private static bool _SECURITY_PROTOCOL_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/AdminClientConfig.html#SECURITY_PROVIDERS_CONFIG"/>
        /// </summary>
        public static Java.Lang.String SECURITY_PROVIDERS_CONFIG { get { if (!_SECURITY_PROVIDERS_CONFIGReady) { _SECURITY_PROVIDERS_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SECURITY_PROVIDERS_CONFIG"); _SECURITY_PROVIDERS_CONFIGReady = true; } return _SECURITY_PROVIDERS_CONFIGContent; } }
        private static Java.Lang.String _SECURITY_PROVIDERS_CONFIGContent = default;
        private static bool _SECURITY_PROVIDERS_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/AdminClientConfig.html#SEND_BUFFER_CONFIG"/>
        /// </summary>
        public static Java.Lang.String SEND_BUFFER_CONFIG { get { if (!_SEND_BUFFER_CONFIGReady) { _SEND_BUFFER_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SEND_BUFFER_CONFIG"); _SEND_BUFFER_CONFIGReady = true; } return _SEND_BUFFER_CONFIGContent; } }
        private static Java.Lang.String _SEND_BUFFER_CONFIGContent = default;
        private static bool _SEND_BUFFER_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/AdminClientConfig.html#SOCKET_CONNECTION_SETUP_TIMEOUT_MAX_MS_CONFIG"/>
        /// </summary>
        public static Java.Lang.String SOCKET_CONNECTION_SETUP_TIMEOUT_MAX_MS_CONFIG { get { if (!_SOCKET_CONNECTION_SETUP_TIMEOUT_MAX_MS_CONFIGReady) { _SOCKET_CONNECTION_SETUP_TIMEOUT_MAX_MS_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SOCKET_CONNECTION_SETUP_TIMEOUT_MAX_MS_CONFIG"); _SOCKET_CONNECTION_SETUP_TIMEOUT_MAX_MS_CONFIGReady = true; } return _SOCKET_CONNECTION_SETUP_TIMEOUT_MAX_MS_CONFIGContent; } }
        private static Java.Lang.String _SOCKET_CONNECTION_SETUP_TIMEOUT_MAX_MS_CONFIGContent = default;
        private static bool _SOCKET_CONNECTION_SETUP_TIMEOUT_MAX_MS_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/AdminClientConfig.html#SOCKET_CONNECTION_SETUP_TIMEOUT_MS_CONFIG"/>
        /// </summary>
        public static Java.Lang.String SOCKET_CONNECTION_SETUP_TIMEOUT_MS_CONFIG { get { if (!_SOCKET_CONNECTION_SETUP_TIMEOUT_MS_CONFIGReady) { _SOCKET_CONNECTION_SETUP_TIMEOUT_MS_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SOCKET_CONNECTION_SETUP_TIMEOUT_MS_CONFIG"); _SOCKET_CONNECTION_SETUP_TIMEOUT_MS_CONFIGReady = true; } return _SOCKET_CONNECTION_SETUP_TIMEOUT_MS_CONFIGContent; } }
        private static Java.Lang.String _SOCKET_CONNECTION_SETUP_TIMEOUT_MS_CONFIGContent = default;
        private static bool _SOCKET_CONNECTION_SETUP_TIMEOUT_MS_CONFIGReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/AdminClientConfig.html#configNames--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set<Java.Lang.String> ConfigNames()
        {
            return SExecuteWithSignature<Java.Util.Set<Java.Lang.String>>(LocalBridgeClazz, "configNames", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/AdminClientConfig.html#configDef--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Config.ConfigDef"/></returns>
        public static Org.Apache.Kafka.Common.Config.ConfigDef ConfigDef()
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.Config.ConfigDef>(LocalBridgeClazz, "configDef", "()Lorg/apache/kafka/common/config/ConfigDef;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/AdminClientConfig.html#main-java.lang.String[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public static void Main(Java.Lang.String[] arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "main", "([Ljava/lang/String;)V", new object[] { arg0 });
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