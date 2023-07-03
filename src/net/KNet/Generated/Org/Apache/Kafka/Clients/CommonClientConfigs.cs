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
*  using kafka-clients-3.5.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients
{
    #region CommonClientConfigs
    public partial class CommonClientConfigs
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#RECEIVE_BUFFER_LOWER_BOUND"/>
        /// </summary>
        public static int RECEIVE_BUFFER_LOWER_BOUND { get { return SGetField<int>(LocalBridgeClazz, "RECEIVE_BUFFER_LOWER_BOUND"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#SEND_BUFFER_LOWER_BOUND"/>
        /// </summary>
        public static int SEND_BUFFER_LOWER_BOUND { get { return SGetField<int>(LocalBridgeClazz, "SEND_BUFFER_LOWER_BOUND"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#DEFAULT_SOCKET_CONNECTION_SETUP_TIMEOUT_MAX_MS"/>
        /// </summary>
        public static long? DEFAULT_SOCKET_CONNECTION_SETUP_TIMEOUT_MAX_MS { get { return SGetField<long?>(LocalBridgeClazz, "DEFAULT_SOCKET_CONNECTION_SETUP_TIMEOUT_MAX_MS"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#DEFAULT_SOCKET_CONNECTION_SETUP_TIMEOUT_MS"/>
        /// </summary>
        public static long? DEFAULT_SOCKET_CONNECTION_SETUP_TIMEOUT_MS { get { return SGetField<long?>(LocalBridgeClazz, "DEFAULT_SOCKET_CONNECTION_SETUP_TIMEOUT_MS"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#AUTO_INCLUDE_JMX_REPORTER_DOC"/>
        /// </summary>
        public static string AUTO_INCLUDE_JMX_REPORTER_DOC { get { return SGetField<string>(LocalBridgeClazz, "AUTO_INCLUDE_JMX_REPORTER_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#BOOTSTRAP_SERVERS_CONFIG"/>
        /// </summary>
        public static string BOOTSTRAP_SERVERS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "BOOTSTRAP_SERVERS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#BOOTSTRAP_SERVERS_DOC"/>
        /// </summary>
        public static string BOOTSTRAP_SERVERS_DOC { get { return SGetField<string>(LocalBridgeClazz, "BOOTSTRAP_SERVERS_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#CLIENT_DNS_LOOKUP_CONFIG"/>
        /// </summary>
        public static string CLIENT_DNS_LOOKUP_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "CLIENT_DNS_LOOKUP_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#CLIENT_DNS_LOOKUP_DOC"/>
        /// </summary>
        public static string CLIENT_DNS_LOOKUP_DOC { get { return SGetField<string>(LocalBridgeClazz, "CLIENT_DNS_LOOKUP_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#CLIENT_ID_CONFIG"/>
        /// </summary>
        public static string CLIENT_ID_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "CLIENT_ID_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#CLIENT_ID_DOC"/>
        /// </summary>
        public static string CLIENT_ID_DOC { get { return SGetField<string>(LocalBridgeClazz, "CLIENT_ID_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#CLIENT_RACK_CONFIG"/>
        /// </summary>
        public static string CLIENT_RACK_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "CLIENT_RACK_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#CLIENT_RACK_DOC"/>
        /// </summary>
        public static string CLIENT_RACK_DOC { get { return SGetField<string>(LocalBridgeClazz, "CLIENT_RACK_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#CONNECTIONS_MAX_IDLE_MS_CONFIG"/>
        /// </summary>
        public static string CONNECTIONS_MAX_IDLE_MS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "CONNECTIONS_MAX_IDLE_MS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#CONNECTIONS_MAX_IDLE_MS_DOC"/>
        /// </summary>
        public static string CONNECTIONS_MAX_IDLE_MS_DOC { get { return SGetField<string>(LocalBridgeClazz, "CONNECTIONS_MAX_IDLE_MS_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#DEFAULT_API_TIMEOUT_MS_CONFIG"/>
        /// </summary>
        public static string DEFAULT_API_TIMEOUT_MS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "DEFAULT_API_TIMEOUT_MS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#DEFAULT_API_TIMEOUT_MS_DOC"/>
        /// </summary>
        public static string DEFAULT_API_TIMEOUT_MS_DOC { get { return SGetField<string>(LocalBridgeClazz, "DEFAULT_API_TIMEOUT_MS_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#DEFAULT_CLIENT_RACK"/>
        /// </summary>
        public static string DEFAULT_CLIENT_RACK { get { return SGetField<string>(LocalBridgeClazz, "DEFAULT_CLIENT_RACK"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#DEFAULT_LIST_KEY_SERDE_INNER_CLASS"/>
        /// </summary>
        public static string DEFAULT_LIST_KEY_SERDE_INNER_CLASS { get { return SGetField<string>(LocalBridgeClazz, "DEFAULT_LIST_KEY_SERDE_INNER_CLASS"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#DEFAULT_LIST_KEY_SERDE_INNER_CLASS_DOC"/>
        /// </summary>
        public static string DEFAULT_LIST_KEY_SERDE_INNER_CLASS_DOC { get { return SGetField<string>(LocalBridgeClazz, "DEFAULT_LIST_KEY_SERDE_INNER_CLASS_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#DEFAULT_LIST_KEY_SERDE_TYPE_CLASS"/>
        /// </summary>
        public static string DEFAULT_LIST_KEY_SERDE_TYPE_CLASS { get { return SGetField<string>(LocalBridgeClazz, "DEFAULT_LIST_KEY_SERDE_TYPE_CLASS"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#DEFAULT_LIST_KEY_SERDE_TYPE_CLASS_DOC"/>
        /// </summary>
        public static string DEFAULT_LIST_KEY_SERDE_TYPE_CLASS_DOC { get { return SGetField<string>(LocalBridgeClazz, "DEFAULT_LIST_KEY_SERDE_TYPE_CLASS_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#DEFAULT_LIST_VALUE_SERDE_INNER_CLASS"/>
        /// </summary>
        public static string DEFAULT_LIST_VALUE_SERDE_INNER_CLASS { get { return SGetField<string>(LocalBridgeClazz, "DEFAULT_LIST_VALUE_SERDE_INNER_CLASS"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#DEFAULT_LIST_VALUE_SERDE_INNER_CLASS_DOC"/>
        /// </summary>
        public static string DEFAULT_LIST_VALUE_SERDE_INNER_CLASS_DOC { get { return SGetField<string>(LocalBridgeClazz, "DEFAULT_LIST_VALUE_SERDE_INNER_CLASS_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#DEFAULT_LIST_VALUE_SERDE_TYPE_CLASS"/>
        /// </summary>
        public static string DEFAULT_LIST_VALUE_SERDE_TYPE_CLASS { get { return SGetField<string>(LocalBridgeClazz, "DEFAULT_LIST_VALUE_SERDE_TYPE_CLASS"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#DEFAULT_LIST_VALUE_SERDE_TYPE_CLASS_DOC"/>
        /// </summary>
        public static string DEFAULT_LIST_VALUE_SERDE_TYPE_CLASS_DOC { get { return SGetField<string>(LocalBridgeClazz, "DEFAULT_LIST_VALUE_SERDE_TYPE_CLASS_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#DEFAULT_SECURITY_PROTOCOL"/>
        /// </summary>
        public static string DEFAULT_SECURITY_PROTOCOL { get { return SGetField<string>(LocalBridgeClazz, "DEFAULT_SECURITY_PROTOCOL"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#GROUP_ID_CONFIG"/>
        /// </summary>
        public static string GROUP_ID_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "GROUP_ID_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#GROUP_ID_DOC"/>
        /// </summary>
        public static string GROUP_ID_DOC { get { return SGetField<string>(LocalBridgeClazz, "GROUP_ID_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#GROUP_INSTANCE_ID_CONFIG"/>
        /// </summary>
        public static string GROUP_INSTANCE_ID_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "GROUP_INSTANCE_ID_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#GROUP_INSTANCE_ID_DOC"/>
        /// </summary>
        public static string GROUP_INSTANCE_ID_DOC { get { return SGetField<string>(LocalBridgeClazz, "GROUP_INSTANCE_ID_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#HEARTBEAT_INTERVAL_MS_CONFIG"/>
        /// </summary>
        public static string HEARTBEAT_INTERVAL_MS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "HEARTBEAT_INTERVAL_MS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#HEARTBEAT_INTERVAL_MS_DOC"/>
        /// </summary>
        public static string HEARTBEAT_INTERVAL_MS_DOC { get { return SGetField<string>(LocalBridgeClazz, "HEARTBEAT_INTERVAL_MS_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#MAX_POLL_INTERVAL_MS_CONFIG"/>
        /// </summary>
        public static string MAX_POLL_INTERVAL_MS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "MAX_POLL_INTERVAL_MS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#MAX_POLL_INTERVAL_MS_DOC"/>
        /// </summary>
        public static string MAX_POLL_INTERVAL_MS_DOC { get { return SGetField<string>(LocalBridgeClazz, "MAX_POLL_INTERVAL_MS_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#METADATA_MAX_AGE_CONFIG"/>
        /// </summary>
        public static string METADATA_MAX_AGE_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "METADATA_MAX_AGE_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#METADATA_MAX_AGE_DOC"/>
        /// </summary>
        public static string METADATA_MAX_AGE_DOC { get { return SGetField<string>(LocalBridgeClazz, "METADATA_MAX_AGE_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#METRIC_REPORTER_CLASSES_CONFIG"/>
        /// </summary>
        public static string METRIC_REPORTER_CLASSES_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "METRIC_REPORTER_CLASSES_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#METRIC_REPORTER_CLASSES_DOC"/>
        /// </summary>
        public static string METRIC_REPORTER_CLASSES_DOC { get { return SGetField<string>(LocalBridgeClazz, "METRIC_REPORTER_CLASSES_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#METRICS_CONTEXT_PREFIX"/>
        /// </summary>
        public static string METRICS_CONTEXT_PREFIX { get { return SGetField<string>(LocalBridgeClazz, "METRICS_CONTEXT_PREFIX"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#METRICS_NUM_SAMPLES_CONFIG"/>
        /// </summary>
        public static string METRICS_NUM_SAMPLES_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "METRICS_NUM_SAMPLES_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#METRICS_NUM_SAMPLES_DOC"/>
        /// </summary>
        public static string METRICS_NUM_SAMPLES_DOC { get { return SGetField<string>(LocalBridgeClazz, "METRICS_NUM_SAMPLES_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#METRICS_RECORDING_LEVEL_CONFIG"/>
        /// </summary>
        public static string METRICS_RECORDING_LEVEL_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "METRICS_RECORDING_LEVEL_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#METRICS_RECORDING_LEVEL_DOC"/>
        /// </summary>
        public static string METRICS_RECORDING_LEVEL_DOC { get { return SGetField<string>(LocalBridgeClazz, "METRICS_RECORDING_LEVEL_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#METRICS_SAMPLE_WINDOW_MS_CONFIG"/>
        /// </summary>
        public static string METRICS_SAMPLE_WINDOW_MS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "METRICS_SAMPLE_WINDOW_MS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#METRICS_SAMPLE_WINDOW_MS_DOC"/>
        /// </summary>
        public static string METRICS_SAMPLE_WINDOW_MS_DOC { get { return SGetField<string>(LocalBridgeClazz, "METRICS_SAMPLE_WINDOW_MS_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#REBALANCE_TIMEOUT_MS_CONFIG"/>
        /// </summary>
        public static string REBALANCE_TIMEOUT_MS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "REBALANCE_TIMEOUT_MS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#REBALANCE_TIMEOUT_MS_DOC"/>
        /// </summary>
        public static string REBALANCE_TIMEOUT_MS_DOC { get { return SGetField<string>(LocalBridgeClazz, "REBALANCE_TIMEOUT_MS_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#RECEIVE_BUFFER_CONFIG"/>
        /// </summary>
        public static string RECEIVE_BUFFER_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "RECEIVE_BUFFER_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#RECEIVE_BUFFER_DOC"/>
        /// </summary>
        public static string RECEIVE_BUFFER_DOC { get { return SGetField<string>(LocalBridgeClazz, "RECEIVE_BUFFER_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#RECONNECT_BACKOFF_MAX_MS_CONFIG"/>
        /// </summary>
        public static string RECONNECT_BACKOFF_MAX_MS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "RECONNECT_BACKOFF_MAX_MS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#RECONNECT_BACKOFF_MAX_MS_DOC"/>
        /// </summary>
        public static string RECONNECT_BACKOFF_MAX_MS_DOC { get { return SGetField<string>(LocalBridgeClazz, "RECONNECT_BACKOFF_MAX_MS_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#RECONNECT_BACKOFF_MS_CONFIG"/>
        /// </summary>
        public static string RECONNECT_BACKOFF_MS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "RECONNECT_BACKOFF_MS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#RECONNECT_BACKOFF_MS_DOC"/>
        /// </summary>
        public static string RECONNECT_BACKOFF_MS_DOC { get { return SGetField<string>(LocalBridgeClazz, "RECONNECT_BACKOFF_MS_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#REQUEST_TIMEOUT_MS_CONFIG"/>
        /// </summary>
        public static string REQUEST_TIMEOUT_MS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "REQUEST_TIMEOUT_MS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#REQUEST_TIMEOUT_MS_DOC"/>
        /// </summary>
        public static string REQUEST_TIMEOUT_MS_DOC { get { return SGetField<string>(LocalBridgeClazz, "REQUEST_TIMEOUT_MS_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#RETRIES_CONFIG"/>
        /// </summary>
        public static string RETRIES_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "RETRIES_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#RETRIES_DOC"/>
        /// </summary>
        public static string RETRIES_DOC { get { return SGetField<string>(LocalBridgeClazz, "RETRIES_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#RETRY_BACKOFF_MS_CONFIG"/>
        /// </summary>
        public static string RETRY_BACKOFF_MS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "RETRY_BACKOFF_MS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#RETRY_BACKOFF_MS_DOC"/>
        /// </summary>
        public static string RETRY_BACKOFF_MS_DOC { get { return SGetField<string>(LocalBridgeClazz, "RETRY_BACKOFF_MS_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#SECURITY_PROTOCOL_CONFIG"/>
        /// </summary>
        public static string SECURITY_PROTOCOL_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "SECURITY_PROTOCOL_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#SECURITY_PROTOCOL_DOC"/>
        /// </summary>
        public static string SECURITY_PROTOCOL_DOC { get { return SGetField<string>(LocalBridgeClazz, "SECURITY_PROTOCOL_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#SEND_BUFFER_CONFIG"/>
        /// </summary>
        public static string SEND_BUFFER_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "SEND_BUFFER_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#SEND_BUFFER_DOC"/>
        /// </summary>
        public static string SEND_BUFFER_DOC { get { return SGetField<string>(LocalBridgeClazz, "SEND_BUFFER_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#SESSION_TIMEOUT_MS_CONFIG"/>
        /// </summary>
        public static string SESSION_TIMEOUT_MS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "SESSION_TIMEOUT_MS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#SESSION_TIMEOUT_MS_DOC"/>
        /// </summary>
        public static string SESSION_TIMEOUT_MS_DOC { get { return SGetField<string>(LocalBridgeClazz, "SESSION_TIMEOUT_MS_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#SOCKET_CONNECTION_SETUP_TIMEOUT_MAX_MS_CONFIG"/>
        /// </summary>
        public static string SOCKET_CONNECTION_SETUP_TIMEOUT_MAX_MS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "SOCKET_CONNECTION_SETUP_TIMEOUT_MAX_MS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#SOCKET_CONNECTION_SETUP_TIMEOUT_MAX_MS_DOC"/>
        /// </summary>
        public static string SOCKET_CONNECTION_SETUP_TIMEOUT_MAX_MS_DOC { get { return SGetField<string>(LocalBridgeClazz, "SOCKET_CONNECTION_SETUP_TIMEOUT_MAX_MS_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#SOCKET_CONNECTION_SETUP_TIMEOUT_MS_CONFIG"/>
        /// </summary>
        public static string SOCKET_CONNECTION_SETUP_TIMEOUT_MS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "SOCKET_CONNECTION_SETUP_TIMEOUT_MS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#SOCKET_CONNECTION_SETUP_TIMEOUT_MS_DOC"/>
        /// </summary>
        public static string SOCKET_CONNECTION_SETUP_TIMEOUT_MS_DOC { get { return SGetField<string>(LocalBridgeClazz, "SOCKET_CONNECTION_SETUP_TIMEOUT_MS_DOC"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#metricsReporters-java.lang.String-org.apache.kafka.common.config.AbstractConfig-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Config.AbstractConfig"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List<Org.Apache.Kafka.Common.Metrics.MetricsReporter> MetricsReporters(string arg0, Org.Apache.Kafka.Common.Config.AbstractConfig arg1)
        {
            return SExecute<Java.Util.List<Org.Apache.Kafka.Common.Metrics.MetricsReporter>>(LocalBridgeClazz, "metricsReporters", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#metricsReporters-java.util.Map-org.apache.kafka.common.config.AbstractConfig-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Config.AbstractConfig"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List<Org.Apache.Kafka.Common.Metrics.MetricsReporter> MetricsReporters(Java.Util.Map<string, object> arg0, Org.Apache.Kafka.Common.Config.AbstractConfig arg1)
        {
            return SExecute<Java.Util.List<Org.Apache.Kafka.Common.Metrics.MetricsReporter>>(LocalBridgeClazz, "metricsReporters", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#metricsReporters-org.apache.kafka.common.config.AbstractConfig-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Config.AbstractConfig"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List<Org.Apache.Kafka.Common.Metrics.MetricsReporter> MetricsReporters(Org.Apache.Kafka.Common.Config.AbstractConfig arg0)
        {
            return SExecute<Java.Util.List<Org.Apache.Kafka.Common.Metrics.MetricsReporter>>(LocalBridgeClazz, "metricsReporters", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#postProcessReconnectBackoffConfigs-org.apache.kafka.common.config.AbstractConfig-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Config.AbstractConfig"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public static Java.Util.Map<string, object> PostProcessReconnectBackoffConfigs(Org.Apache.Kafka.Common.Config.AbstractConfig arg0, Java.Util.Map<string, object> arg1)
        {
            return SExecute<Java.Util.Map<string, object>>(LocalBridgeClazz, "postProcessReconnectBackoffConfigs", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/CommonClientConfigs.html#postValidateSaslMechanismConfig-org.apache.kafka.common.config.AbstractConfig-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Config.AbstractConfig"/></param>
        public static void PostValidateSaslMechanismConfig(Org.Apache.Kafka.Common.Config.AbstractConfig arg0)
        {
            SExecute(LocalBridgeClazz, "postValidateSaslMechanismConfig", arg0);
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