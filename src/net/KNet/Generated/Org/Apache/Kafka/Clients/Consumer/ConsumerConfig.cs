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
*  This file is generated by MASES.JNetReflector (ver. 2.2.1.0)
*  using kafka-clients-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Consumer
{
    #region ConsumerConfig
    public partial class ConsumerConfig
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#org.apache.kafka.clients.consumer.ConsumerConfig(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public ConsumerConfig(Java.Util.Map<string, object> arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#org.apache.kafka.clients.consumer.ConsumerConfig(java.util.Properties)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Properties"/></param>
        public ConsumerConfig(Java.Util.Properties arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#DEFAULT_ALLOW_AUTO_CREATE_TOPICS"/>
        /// </summary>
        public static bool DEFAULT_ALLOW_AUTO_CREATE_TOPICS { get { return SGetField<bool>(LocalBridgeClazz, "DEFAULT_ALLOW_AUTO_CREATE_TOPICS"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#DEFAULT_EXCLUDE_INTERNAL_TOPICS"/>
        /// </summary>
        public static bool DEFAULT_EXCLUDE_INTERNAL_TOPICS { get { return SGetField<bool>(LocalBridgeClazz, "DEFAULT_EXCLUDE_INTERNAL_TOPICS"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#DEFAULT_FETCH_MAX_BYTES"/>
        /// </summary>
        public static int DEFAULT_FETCH_MAX_BYTES { get { return SGetField<int>(LocalBridgeClazz, "DEFAULT_FETCH_MAX_BYTES"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#DEFAULT_FETCH_MAX_WAIT_MS"/>
        /// </summary>
        public static int DEFAULT_FETCH_MAX_WAIT_MS { get { return SGetField<int>(LocalBridgeClazz, "DEFAULT_FETCH_MAX_WAIT_MS"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#DEFAULT_FETCH_MIN_BYTES"/>
        /// </summary>
        public static int DEFAULT_FETCH_MIN_BYTES { get { return SGetField<int>(LocalBridgeClazz, "DEFAULT_FETCH_MIN_BYTES"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#DEFAULT_MAX_PARTITION_FETCH_BYTES"/>
        /// </summary>
        public static int DEFAULT_MAX_PARTITION_FETCH_BYTES { get { return SGetField<int>(LocalBridgeClazz, "DEFAULT_MAX_PARTITION_FETCH_BYTES"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#DEFAULT_MAX_POLL_RECORDS"/>
        /// </summary>
        public static int DEFAULT_MAX_POLL_RECORDS { get { return SGetField<int>(LocalBridgeClazz, "DEFAULT_MAX_POLL_RECORDS"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#ALLOW_AUTO_CREATE_TOPICS_CONFIG"/>
        /// </summary>
        public static string ALLOW_AUTO_CREATE_TOPICS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "ALLOW_AUTO_CREATE_TOPICS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#AUTO_COMMIT_INTERVAL_MS_CONFIG"/>
        /// </summary>
        public static string AUTO_COMMIT_INTERVAL_MS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "AUTO_COMMIT_INTERVAL_MS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#AUTO_OFFSET_RESET_CONFIG"/>
        /// </summary>
        public static string AUTO_OFFSET_RESET_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "AUTO_OFFSET_RESET_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#AUTO_OFFSET_RESET_DOC"/>
        /// </summary>
        public static string AUTO_OFFSET_RESET_DOC { get { return SGetField<string>(LocalBridgeClazz, "AUTO_OFFSET_RESET_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#BOOTSTRAP_SERVERS_CONFIG"/>
        /// </summary>
        public static string BOOTSTRAP_SERVERS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "BOOTSTRAP_SERVERS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#CHECK_CRCS_CONFIG"/>
        /// </summary>
        public static string CHECK_CRCS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "CHECK_CRCS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#CLIENT_DNS_LOOKUP_CONFIG"/>
        /// </summary>
        public static string CLIENT_DNS_LOOKUP_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "CLIENT_DNS_LOOKUP_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#CLIENT_ID_CONFIG"/>
        /// </summary>
        public static string CLIENT_ID_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "CLIENT_ID_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#CLIENT_RACK_CONFIG"/>
        /// </summary>
        public static string CLIENT_RACK_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "CLIENT_RACK_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#CONNECTIONS_MAX_IDLE_MS_CONFIG"/>
        /// </summary>
        public static string CONNECTIONS_MAX_IDLE_MS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "CONNECTIONS_MAX_IDLE_MS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#DEFAULT_API_TIMEOUT_MS_CONFIG"/>
        /// </summary>
        public static string DEFAULT_API_TIMEOUT_MS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "DEFAULT_API_TIMEOUT_MS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#DEFAULT_CLIENT_RACK"/>
        /// </summary>
        public static string DEFAULT_CLIENT_RACK { get { return SGetField<string>(LocalBridgeClazz, "DEFAULT_CLIENT_RACK"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#DEFAULT_ISOLATION_LEVEL"/>
        /// </summary>
        public static string DEFAULT_ISOLATION_LEVEL { get { return SGetField<string>(LocalBridgeClazz, "DEFAULT_ISOLATION_LEVEL"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#ENABLE_AUTO_COMMIT_CONFIG"/>
        /// </summary>
        public static string ENABLE_AUTO_COMMIT_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "ENABLE_AUTO_COMMIT_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#EXCLUDE_INTERNAL_TOPICS_CONFIG"/>
        /// </summary>
        public static string EXCLUDE_INTERNAL_TOPICS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "EXCLUDE_INTERNAL_TOPICS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#FETCH_MAX_BYTES_CONFIG"/>
        /// </summary>
        public static string FETCH_MAX_BYTES_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "FETCH_MAX_BYTES_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#FETCH_MAX_WAIT_MS_CONFIG"/>
        /// </summary>
        public static string FETCH_MAX_WAIT_MS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "FETCH_MAX_WAIT_MS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#FETCH_MIN_BYTES_CONFIG"/>
        /// </summary>
        public static string FETCH_MIN_BYTES_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "FETCH_MIN_BYTES_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#GROUP_ID_CONFIG"/>
        /// </summary>
        public static string GROUP_ID_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "GROUP_ID_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#GROUP_INSTANCE_ID_CONFIG"/>
        /// </summary>
        public static string GROUP_INSTANCE_ID_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "GROUP_INSTANCE_ID_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#HEARTBEAT_INTERVAL_MS_CONFIG"/>
        /// </summary>
        public static string HEARTBEAT_INTERVAL_MS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "HEARTBEAT_INTERVAL_MS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#INTERCEPTOR_CLASSES_CONFIG"/>
        /// </summary>
        public static string INTERCEPTOR_CLASSES_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "INTERCEPTOR_CLASSES_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#INTERCEPTOR_CLASSES_DOC"/>
        /// </summary>
        public static string INTERCEPTOR_CLASSES_DOC { get { return SGetField<string>(LocalBridgeClazz, "INTERCEPTOR_CLASSES_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#ISOLATION_LEVEL_CONFIG"/>
        /// </summary>
        public static string ISOLATION_LEVEL_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "ISOLATION_LEVEL_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#ISOLATION_LEVEL_DOC"/>
        /// </summary>
        public static string ISOLATION_LEVEL_DOC { get { return SGetField<string>(LocalBridgeClazz, "ISOLATION_LEVEL_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#KEY_DESERIALIZER_CLASS_CONFIG"/>
        /// </summary>
        public static string KEY_DESERIALIZER_CLASS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "KEY_DESERIALIZER_CLASS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#KEY_DESERIALIZER_CLASS_DOC"/>
        /// </summary>
        public static string KEY_DESERIALIZER_CLASS_DOC { get { return SGetField<string>(LocalBridgeClazz, "KEY_DESERIALIZER_CLASS_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#MAX_PARTITION_FETCH_BYTES_CONFIG"/>
        /// </summary>
        public static string MAX_PARTITION_FETCH_BYTES_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "MAX_PARTITION_FETCH_BYTES_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#MAX_POLL_INTERVAL_MS_CONFIG"/>
        /// </summary>
        public static string MAX_POLL_INTERVAL_MS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "MAX_POLL_INTERVAL_MS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#MAX_POLL_RECORDS_CONFIG"/>
        /// </summary>
        public static string MAX_POLL_RECORDS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "MAX_POLL_RECORDS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#METADATA_MAX_AGE_CONFIG"/>
        /// </summary>
        public static string METADATA_MAX_AGE_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "METADATA_MAX_AGE_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#METRIC_REPORTER_CLASSES_CONFIG"/>
        /// </summary>
        public static string METRIC_REPORTER_CLASSES_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "METRIC_REPORTER_CLASSES_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#METRICS_NUM_SAMPLES_CONFIG"/>
        /// </summary>
        public static string METRICS_NUM_SAMPLES_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "METRICS_NUM_SAMPLES_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#METRICS_RECORDING_LEVEL_CONFIG"/>
        /// </summary>
        public static string METRICS_RECORDING_LEVEL_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "METRICS_RECORDING_LEVEL_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#METRICS_SAMPLE_WINDOW_MS_CONFIG"/>
        /// </summary>
        public static string METRICS_SAMPLE_WINDOW_MS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "METRICS_SAMPLE_WINDOW_MS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#PARTITION_ASSIGNMENT_STRATEGY_CONFIG"/>
        /// </summary>
        public static string PARTITION_ASSIGNMENT_STRATEGY_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "PARTITION_ASSIGNMENT_STRATEGY_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#RECEIVE_BUFFER_CONFIG"/>
        /// </summary>
        public static string RECEIVE_BUFFER_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "RECEIVE_BUFFER_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#RECONNECT_BACKOFF_MAX_MS_CONFIG"/>
        /// </summary>
        public static string RECONNECT_BACKOFF_MAX_MS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "RECONNECT_BACKOFF_MAX_MS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#RECONNECT_BACKOFF_MS_CONFIG"/>
        /// </summary>
        public static string RECONNECT_BACKOFF_MS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "RECONNECT_BACKOFF_MS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#REQUEST_TIMEOUT_MS_CONFIG"/>
        /// </summary>
        public static string REQUEST_TIMEOUT_MS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "REQUEST_TIMEOUT_MS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#RETRY_BACKOFF_MS_CONFIG"/>
        /// </summary>
        public static string RETRY_BACKOFF_MS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "RETRY_BACKOFF_MS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#SECURITY_PROVIDERS_CONFIG"/>
        /// </summary>
        public static string SECURITY_PROVIDERS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "SECURITY_PROVIDERS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#SEND_BUFFER_CONFIG"/>
        /// </summary>
        public static string SEND_BUFFER_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "SEND_BUFFER_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#SESSION_TIMEOUT_MS_CONFIG"/>
        /// </summary>
        public static string SESSION_TIMEOUT_MS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "SESSION_TIMEOUT_MS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#SOCKET_CONNECTION_SETUP_TIMEOUT_MAX_MS_CONFIG"/>
        /// </summary>
        public static string SOCKET_CONNECTION_SETUP_TIMEOUT_MAX_MS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "SOCKET_CONNECTION_SETUP_TIMEOUT_MAX_MS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#SOCKET_CONNECTION_SETUP_TIMEOUT_MS_CONFIG"/>
        /// </summary>
        public static string SOCKET_CONNECTION_SETUP_TIMEOUT_MS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "SOCKET_CONNECTION_SETUP_TIMEOUT_MS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#VALUE_DESERIALIZER_CLASS_CONFIG"/>
        /// </summary>
        public static string VALUE_DESERIALIZER_CLASS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "VALUE_DESERIALIZER_CLASS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#VALUE_DESERIALIZER_CLASS_DOC"/>
        /// </summary>
        public static string VALUE_DESERIALIZER_CLASS_DOC { get { return SGetField<string>(LocalBridgeClazz, "VALUE_DESERIALIZER_CLASS_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#ASSIGN_FROM_SUBSCRIBED_ASSIGNORS"/>
        /// </summary>
        public static Java.Util.List ASSIGN_FROM_SUBSCRIBED_ASSIGNORS { get { return SGetField<Java.Util.List>(LocalBridgeClazz, "ASSIGN_FROM_SUBSCRIBED_ASSIGNORS"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#configNames--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set<string> ConfigNames()
        {
            return SExecute<Java.Util.Set<string>>(LocalBridgeClazz, "configNames");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#configDef--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Config.ConfigDef"/></returns>
        public static Org.Apache.Kafka.Common.Config.ConfigDef ConfigDef()
        {
            return SExecute<Org.Apache.Kafka.Common.Config.ConfigDef>(LocalBridgeClazz, "configDef");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerConfig.html#main-java.lang.String[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public static void Main(string[] arg0)
        {
            SExecute(LocalBridgeClazz, "main", new object[] { arg0 });
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