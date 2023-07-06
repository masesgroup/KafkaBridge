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

namespace Org.Apache.Kafka.Common.Config
{
    #region TopicConfig
    public partial class TopicConfig
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#CLEANUP_POLICY_COMPACT"/>
        /// </summary>
        public static string CLEANUP_POLICY_COMPACT { get { return SGetField<string>(LocalBridgeClazz, "CLEANUP_POLICY_COMPACT"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#CLEANUP_POLICY_CONFIG"/>
        /// </summary>
        public static string CLEANUP_POLICY_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "CLEANUP_POLICY_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#CLEANUP_POLICY_DELETE"/>
        /// </summary>
        public static string CLEANUP_POLICY_DELETE { get { return SGetField<string>(LocalBridgeClazz, "CLEANUP_POLICY_DELETE"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#CLEANUP_POLICY_DOC"/>
        /// </summary>
        public static string CLEANUP_POLICY_DOC { get { return SGetField<string>(LocalBridgeClazz, "CLEANUP_POLICY_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#COMPRESSION_TYPE_CONFIG"/>
        /// </summary>
        public static string COMPRESSION_TYPE_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "COMPRESSION_TYPE_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#COMPRESSION_TYPE_DOC"/>
        /// </summary>
        public static string COMPRESSION_TYPE_DOC { get { return SGetField<string>(LocalBridgeClazz, "COMPRESSION_TYPE_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#DELETE_RETENTION_MS_CONFIG"/>
        /// </summary>
        public static string DELETE_RETENTION_MS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "DELETE_RETENTION_MS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#DELETE_RETENTION_MS_DOC"/>
        /// </summary>
        public static string DELETE_RETENTION_MS_DOC { get { return SGetField<string>(LocalBridgeClazz, "DELETE_RETENTION_MS_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#FILE_DELETE_DELAY_MS_CONFIG"/>
        /// </summary>
        public static string FILE_DELETE_DELAY_MS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "FILE_DELETE_DELAY_MS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#FILE_DELETE_DELAY_MS_DOC"/>
        /// </summary>
        public static string FILE_DELETE_DELAY_MS_DOC { get { return SGetField<string>(LocalBridgeClazz, "FILE_DELETE_DELAY_MS_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#FLUSH_MESSAGES_INTERVAL_CONFIG"/>
        /// </summary>
        public static string FLUSH_MESSAGES_INTERVAL_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "FLUSH_MESSAGES_INTERVAL_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#FLUSH_MESSAGES_INTERVAL_DOC"/>
        /// </summary>
        public static string FLUSH_MESSAGES_INTERVAL_DOC { get { return SGetField<string>(LocalBridgeClazz, "FLUSH_MESSAGES_INTERVAL_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#FLUSH_MS_CONFIG"/>
        /// </summary>
        public static string FLUSH_MS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "FLUSH_MS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#FLUSH_MS_DOC"/>
        /// </summary>
        public static string FLUSH_MS_DOC { get { return SGetField<string>(LocalBridgeClazz, "FLUSH_MS_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#INDEX_INTERVAL_BYTES_CONFIG"/>
        /// </summary>
        public static string INDEX_INTERVAL_BYTES_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "INDEX_INTERVAL_BYTES_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#INDEX_INTERVAL_BYTES_DOC"/>
        /// </summary>
        public static string INDEX_INTERVAL_BYTES_DOC { get { return SGetField<string>(LocalBridgeClazz, "INDEX_INTERVAL_BYTES_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#LOCAL_LOG_RETENTION_BYTES_CONFIG"/>
        /// </summary>
        public static string LOCAL_LOG_RETENTION_BYTES_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "LOCAL_LOG_RETENTION_BYTES_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#LOCAL_LOG_RETENTION_BYTES_DOC"/>
        /// </summary>
        public static string LOCAL_LOG_RETENTION_BYTES_DOC { get { return SGetField<string>(LocalBridgeClazz, "LOCAL_LOG_RETENTION_BYTES_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#LOCAL_LOG_RETENTION_MS_CONFIG"/>
        /// </summary>
        public static string LOCAL_LOG_RETENTION_MS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "LOCAL_LOG_RETENTION_MS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#LOCAL_LOG_RETENTION_MS_DOC"/>
        /// </summary>
        public static string LOCAL_LOG_RETENTION_MS_DOC { get { return SGetField<string>(LocalBridgeClazz, "LOCAL_LOG_RETENTION_MS_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#MAX_COMPACTION_LAG_MS_CONFIG"/>
        /// </summary>
        public static string MAX_COMPACTION_LAG_MS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "MAX_COMPACTION_LAG_MS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#MAX_COMPACTION_LAG_MS_DOC"/>
        /// </summary>
        public static string MAX_COMPACTION_LAG_MS_DOC { get { return SGetField<string>(LocalBridgeClazz, "MAX_COMPACTION_LAG_MS_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#MAX_MESSAGE_BYTES_CONFIG"/>
        /// </summary>
        public static string MAX_MESSAGE_BYTES_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "MAX_MESSAGE_BYTES_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#MAX_MESSAGE_BYTES_DOC"/>
        /// </summary>
        public static string MAX_MESSAGE_BYTES_DOC { get { return SGetField<string>(LocalBridgeClazz, "MAX_MESSAGE_BYTES_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#MESSAGE_DOWNCONVERSION_ENABLE_CONFIG"/>
        /// </summary>
        public static string MESSAGE_DOWNCONVERSION_ENABLE_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "MESSAGE_DOWNCONVERSION_ENABLE_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#MESSAGE_DOWNCONVERSION_ENABLE_DOC"/>
        /// </summary>
        public static string MESSAGE_DOWNCONVERSION_ENABLE_DOC { get { return SGetField<string>(LocalBridgeClazz, "MESSAGE_DOWNCONVERSION_ENABLE_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#MESSAGE_TIMESTAMP_DIFFERENCE_MAX_MS_CONFIG"/>
        /// </summary>
        public static string MESSAGE_TIMESTAMP_DIFFERENCE_MAX_MS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "MESSAGE_TIMESTAMP_DIFFERENCE_MAX_MS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#MESSAGE_TIMESTAMP_DIFFERENCE_MAX_MS_DOC"/>
        /// </summary>
        public static string MESSAGE_TIMESTAMP_DIFFERENCE_MAX_MS_DOC { get { return SGetField<string>(LocalBridgeClazz, "MESSAGE_TIMESTAMP_DIFFERENCE_MAX_MS_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#MESSAGE_TIMESTAMP_TYPE_CONFIG"/>
        /// </summary>
        public static string MESSAGE_TIMESTAMP_TYPE_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "MESSAGE_TIMESTAMP_TYPE_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#MESSAGE_TIMESTAMP_TYPE_DOC"/>
        /// </summary>
        public static string MESSAGE_TIMESTAMP_TYPE_DOC { get { return SGetField<string>(LocalBridgeClazz, "MESSAGE_TIMESTAMP_TYPE_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#MIN_CLEANABLE_DIRTY_RATIO_CONFIG"/>
        /// </summary>
        public static string MIN_CLEANABLE_DIRTY_RATIO_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "MIN_CLEANABLE_DIRTY_RATIO_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#MIN_CLEANABLE_DIRTY_RATIO_DOC"/>
        /// </summary>
        public static string MIN_CLEANABLE_DIRTY_RATIO_DOC { get { return SGetField<string>(LocalBridgeClazz, "MIN_CLEANABLE_DIRTY_RATIO_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#MIN_COMPACTION_LAG_MS_CONFIG"/>
        /// </summary>
        public static string MIN_COMPACTION_LAG_MS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "MIN_COMPACTION_LAG_MS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#MIN_COMPACTION_LAG_MS_DOC"/>
        /// </summary>
        public static string MIN_COMPACTION_LAG_MS_DOC { get { return SGetField<string>(LocalBridgeClazz, "MIN_COMPACTION_LAG_MS_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#MIN_IN_SYNC_REPLICAS_CONFIG"/>
        /// </summary>
        public static string MIN_IN_SYNC_REPLICAS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "MIN_IN_SYNC_REPLICAS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#MIN_IN_SYNC_REPLICAS_DOC"/>
        /// </summary>
        public static string MIN_IN_SYNC_REPLICAS_DOC { get { return SGetField<string>(LocalBridgeClazz, "MIN_IN_SYNC_REPLICAS_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#PREALLOCATE_CONFIG"/>
        /// </summary>
        public static string PREALLOCATE_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "PREALLOCATE_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#PREALLOCATE_DOC"/>
        /// </summary>
        public static string PREALLOCATE_DOC { get { return SGetField<string>(LocalBridgeClazz, "PREALLOCATE_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#REMOTE_LOG_STORAGE_ENABLE_CONFIG"/>
        /// </summary>
        public static string REMOTE_LOG_STORAGE_ENABLE_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "REMOTE_LOG_STORAGE_ENABLE_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#REMOTE_LOG_STORAGE_ENABLE_DOC"/>
        /// </summary>
        public static string REMOTE_LOG_STORAGE_ENABLE_DOC { get { return SGetField<string>(LocalBridgeClazz, "REMOTE_LOG_STORAGE_ENABLE_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#RETENTION_BYTES_CONFIG"/>
        /// </summary>
        public static string RETENTION_BYTES_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "RETENTION_BYTES_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#RETENTION_BYTES_DOC"/>
        /// </summary>
        public static string RETENTION_BYTES_DOC { get { return SGetField<string>(LocalBridgeClazz, "RETENTION_BYTES_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#RETENTION_MS_CONFIG"/>
        /// </summary>
        public static string RETENTION_MS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "RETENTION_MS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#RETENTION_MS_DOC"/>
        /// </summary>
        public static string RETENTION_MS_DOC { get { return SGetField<string>(LocalBridgeClazz, "RETENTION_MS_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#SEGMENT_BYTES_CONFIG"/>
        /// </summary>
        public static string SEGMENT_BYTES_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "SEGMENT_BYTES_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#SEGMENT_BYTES_DOC"/>
        /// </summary>
        public static string SEGMENT_BYTES_DOC { get { return SGetField<string>(LocalBridgeClazz, "SEGMENT_BYTES_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#SEGMENT_INDEX_BYTES_CONFIG"/>
        /// </summary>
        public static string SEGMENT_INDEX_BYTES_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "SEGMENT_INDEX_BYTES_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#SEGMENT_INDEX_BYTES_DOC"/>
        /// </summary>
        public static string SEGMENT_INDEX_BYTES_DOC { get { return SGetField<string>(LocalBridgeClazz, "SEGMENT_INDEX_BYTES_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#SEGMENT_JITTER_MS_CONFIG"/>
        /// </summary>
        public static string SEGMENT_JITTER_MS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "SEGMENT_JITTER_MS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#SEGMENT_JITTER_MS_DOC"/>
        /// </summary>
        public static string SEGMENT_JITTER_MS_DOC { get { return SGetField<string>(LocalBridgeClazz, "SEGMENT_JITTER_MS_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#SEGMENT_MS_CONFIG"/>
        /// </summary>
        public static string SEGMENT_MS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "SEGMENT_MS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#SEGMENT_MS_DOC"/>
        /// </summary>
        public static string SEGMENT_MS_DOC { get { return SGetField<string>(LocalBridgeClazz, "SEGMENT_MS_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#UNCLEAN_LEADER_ELECTION_ENABLE_CONFIG"/>
        /// </summary>
        public static string UNCLEAN_LEADER_ELECTION_ENABLE_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "UNCLEAN_LEADER_ELECTION_ENABLE_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/config/TopicConfig.html#UNCLEAN_LEADER_ELECTION_ENABLE_DOC"/>
        /// </summary>
        public static string UNCLEAN_LEADER_ELECTION_ENABLE_DOC { get { return SGetField<string>(LocalBridgeClazz, "UNCLEAN_LEADER_ELECTION_ENABLE_DOC"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}