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
*  This file is generated by MASES.JNetReflector (ver. 2.2.4.0)
*  using connect-mirror-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Mirror
{
    #region MirrorCheckpointConfig
    public partial class MirrorCheckpointConfig
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#org.apache.kafka.connect.mirror.MirrorCheckpointConfig(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public MirrorCheckpointConfig(Java.Util.Map<string, string> arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#org.apache.kafka.connect.mirror.MirrorCheckpointConfig(org.apache.kafka.common.config.ConfigDef,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Config.ConfigDef"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        public MirrorCheckpointConfig(Org.Apache.Kafka.Common.Config.ConfigDef arg0, Java.Util.Map<string, string> arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#EMIT_CHECKPOINTS_ENABLED_DEFAULT"/>
        /// </summary>
        public static bool EMIT_CHECKPOINTS_ENABLED_DEFAULT { get { if (!_EMIT_CHECKPOINTS_ENABLED_DEFAULTReady) { _EMIT_CHECKPOINTS_ENABLED_DEFAULTContent = SGetField<bool>(LocalBridgeClazz, "EMIT_CHECKPOINTS_ENABLED_DEFAULT"); _EMIT_CHECKPOINTS_ENABLED_DEFAULTReady = true; } return _EMIT_CHECKPOINTS_ENABLED_DEFAULTContent; } }
        private static bool _EMIT_CHECKPOINTS_ENABLED_DEFAULTContent = default;
        private static bool _EMIT_CHECKPOINTS_ENABLED_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#REFRESH_GROUPS_ENABLED_DEFAULT"/>
        /// </summary>
        public static bool REFRESH_GROUPS_ENABLED_DEFAULT { get { if (!_REFRESH_GROUPS_ENABLED_DEFAULTReady) { _REFRESH_GROUPS_ENABLED_DEFAULTContent = SGetField<bool>(LocalBridgeClazz, "REFRESH_GROUPS_ENABLED_DEFAULT"); _REFRESH_GROUPS_ENABLED_DEFAULTReady = true; } return _REFRESH_GROUPS_ENABLED_DEFAULTContent; } }
        private static bool _REFRESH_GROUPS_ENABLED_DEFAULTContent = default;
        private static bool _REFRESH_GROUPS_ENABLED_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#SYNC_GROUP_OFFSETS_ENABLED_DEFAULT"/>
        /// </summary>
        public static bool SYNC_GROUP_OFFSETS_ENABLED_DEFAULT { get { if (!_SYNC_GROUP_OFFSETS_ENABLED_DEFAULTReady) { _SYNC_GROUP_OFFSETS_ENABLED_DEFAULTContent = SGetField<bool>(LocalBridgeClazz, "SYNC_GROUP_OFFSETS_ENABLED_DEFAULT"); _SYNC_GROUP_OFFSETS_ENABLED_DEFAULTReady = true; } return _SYNC_GROUP_OFFSETS_ENABLED_DEFAULTContent; } }
        private static bool _SYNC_GROUP_OFFSETS_ENABLED_DEFAULTContent = default;
        private static bool _SYNC_GROUP_OFFSETS_ENABLED_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#GROUP_FILTER_CLASS_DEFAULT"/>
        /// </summary>
        public static Java.Lang.Class GROUP_FILTER_CLASS_DEFAULT { get { if (!_GROUP_FILTER_CLASS_DEFAULTReady) { _GROUP_FILTER_CLASS_DEFAULTContent = SGetField<Java.Lang.Class>(LocalBridgeClazz, "GROUP_FILTER_CLASS_DEFAULT"); _GROUP_FILTER_CLASS_DEFAULTReady = true; } return _GROUP_FILTER_CLASS_DEFAULTContent; } }
        private static Java.Lang.Class _GROUP_FILTER_CLASS_DEFAULTContent = default;
        private static bool _GROUP_FILTER_CLASS_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#CHECKPOINTS_TOPIC_REPLICATION_FACTOR"/>
        /// </summary>
        public static string CHECKPOINTS_TOPIC_REPLICATION_FACTOR { get { if (!_CHECKPOINTS_TOPIC_REPLICATION_FACTORReady) { _CHECKPOINTS_TOPIC_REPLICATION_FACTORContent = SGetField<string>(LocalBridgeClazz, "CHECKPOINTS_TOPIC_REPLICATION_FACTOR"); _CHECKPOINTS_TOPIC_REPLICATION_FACTORReady = true; } return _CHECKPOINTS_TOPIC_REPLICATION_FACTORContent; } }
        private static string _CHECKPOINTS_TOPIC_REPLICATION_FACTORContent = default;
        private static bool _CHECKPOINTS_TOPIC_REPLICATION_FACTORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DOC"/>
        /// </summary>
        public static string CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DOC { get { if (!_CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DOCReady) { _CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DOCContent = SGetField<string>(LocalBridgeClazz, "CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DOC"); _CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DOCReady = true; } return _CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DOCContent; } }
        private static string _CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DOCContent = default;
        private static bool _CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#CONSUMER_POLL_TIMEOUT_MILLIS"/>
        /// </summary>
        public static string CONSUMER_POLL_TIMEOUT_MILLIS { get { if (!_CONSUMER_POLL_TIMEOUT_MILLISReady) { _CONSUMER_POLL_TIMEOUT_MILLISContent = SGetField<string>(LocalBridgeClazz, "CONSUMER_POLL_TIMEOUT_MILLIS"); _CONSUMER_POLL_TIMEOUT_MILLISReady = true; } return _CONSUMER_POLL_TIMEOUT_MILLISContent; } }
        private static string _CONSUMER_POLL_TIMEOUT_MILLISContent = default;
        private static bool _CONSUMER_POLL_TIMEOUT_MILLISReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#EMIT_CHECKPOINTS_ENABLED"/>
        /// </summary>
        public static string EMIT_CHECKPOINTS_ENABLED { get { if (!_EMIT_CHECKPOINTS_ENABLEDReady) { _EMIT_CHECKPOINTS_ENABLEDContent = SGetField<string>(LocalBridgeClazz, "EMIT_CHECKPOINTS_ENABLED"); _EMIT_CHECKPOINTS_ENABLEDReady = true; } return _EMIT_CHECKPOINTS_ENABLEDContent; } }
        private static string _EMIT_CHECKPOINTS_ENABLEDContent = default;
        private static bool _EMIT_CHECKPOINTS_ENABLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#EMIT_CHECKPOINTS_INTERVAL_SECONDS"/>
        /// </summary>
        public static string EMIT_CHECKPOINTS_INTERVAL_SECONDS { get { if (!_EMIT_CHECKPOINTS_INTERVAL_SECONDSReady) { _EMIT_CHECKPOINTS_INTERVAL_SECONDSContent = SGetField<string>(LocalBridgeClazz, "EMIT_CHECKPOINTS_INTERVAL_SECONDS"); _EMIT_CHECKPOINTS_INTERVAL_SECONDSReady = true; } return _EMIT_CHECKPOINTS_INTERVAL_SECONDSContent; } }
        private static string _EMIT_CHECKPOINTS_INTERVAL_SECONDSContent = default;
        private static bool _EMIT_CHECKPOINTS_INTERVAL_SECONDSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#GROUP_FILTER_CLASS"/>
        /// </summary>
        public static string GROUP_FILTER_CLASS { get { if (!_GROUP_FILTER_CLASSReady) { _GROUP_FILTER_CLASSContent = SGetField<string>(LocalBridgeClazz, "GROUP_FILTER_CLASS"); _GROUP_FILTER_CLASSReady = true; } return _GROUP_FILTER_CLASSContent; } }
        private static string _GROUP_FILTER_CLASSContent = default;
        private static bool _GROUP_FILTER_CLASSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#GROUPS"/>
        /// </summary>
        public static string GROUPS { get { if (!_GROUPSReady) { _GROUPSContent = SGetField<string>(LocalBridgeClazz, "GROUPS"); _GROUPSReady = true; } return _GROUPSContent; } }
        private static string _GROUPSContent = default;
        private static bool _GROUPSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#GROUPS_DEFAULT"/>
        /// </summary>
        public static string GROUPS_DEFAULT { get { if (!_GROUPS_DEFAULTReady) { _GROUPS_DEFAULTContent = SGetField<string>(LocalBridgeClazz, "GROUPS_DEFAULT"); _GROUPS_DEFAULTReady = true; } return _GROUPS_DEFAULTContent; } }
        private static string _GROUPS_DEFAULTContent = default;
        private static bool _GROUPS_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#GROUPS_EXCLUDE"/>
        /// </summary>
        public static string GROUPS_EXCLUDE { get { if (!_GROUPS_EXCLUDEReady) { _GROUPS_EXCLUDEContent = SGetField<string>(LocalBridgeClazz, "GROUPS_EXCLUDE"); _GROUPS_EXCLUDEReady = true; } return _GROUPS_EXCLUDEContent; } }
        private static string _GROUPS_EXCLUDEContent = default;
        private static bool _GROUPS_EXCLUDEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#GROUPS_EXCLUDE_ALIAS"/>
        /// </summary>
        public static string GROUPS_EXCLUDE_ALIAS { get { if (!_GROUPS_EXCLUDE_ALIASReady) { _GROUPS_EXCLUDE_ALIASContent = SGetField<string>(LocalBridgeClazz, "GROUPS_EXCLUDE_ALIAS"); _GROUPS_EXCLUDE_ALIASReady = true; } return _GROUPS_EXCLUDE_ALIASContent; } }
        private static string _GROUPS_EXCLUDE_ALIASContent = default;
        private static bool _GROUPS_EXCLUDE_ALIASReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#GROUPS_EXCLUDE_DEFAULT"/>
        /// </summary>
        public static string GROUPS_EXCLUDE_DEFAULT { get { if (!_GROUPS_EXCLUDE_DEFAULTReady) { _GROUPS_EXCLUDE_DEFAULTContent = SGetField<string>(LocalBridgeClazz, "GROUPS_EXCLUDE_DEFAULT"); _GROUPS_EXCLUDE_DEFAULTReady = true; } return _GROUPS_EXCLUDE_DEFAULTContent; } }
        private static string _GROUPS_EXCLUDE_DEFAULTContent = default;
        private static bool _GROUPS_EXCLUDE_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#OFFSET_SYNCS_SOURCE_ADMIN_ROLE"/>
        /// </summary>
        public static string OFFSET_SYNCS_SOURCE_ADMIN_ROLE { get { if (!_OFFSET_SYNCS_SOURCE_ADMIN_ROLEReady) { _OFFSET_SYNCS_SOURCE_ADMIN_ROLEContent = SGetField<string>(LocalBridgeClazz, "OFFSET_SYNCS_SOURCE_ADMIN_ROLE"); _OFFSET_SYNCS_SOURCE_ADMIN_ROLEReady = true; } return _OFFSET_SYNCS_SOURCE_ADMIN_ROLEContent; } }
        private static string _OFFSET_SYNCS_SOURCE_ADMIN_ROLEContent = default;
        private static bool _OFFSET_SYNCS_SOURCE_ADMIN_ROLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#OFFSET_SYNCS_SOURCE_CONSUMER_ROLE"/>
        /// </summary>
        public static string OFFSET_SYNCS_SOURCE_CONSUMER_ROLE { get { if (!_OFFSET_SYNCS_SOURCE_CONSUMER_ROLEReady) { _OFFSET_SYNCS_SOURCE_CONSUMER_ROLEContent = SGetField<string>(LocalBridgeClazz, "OFFSET_SYNCS_SOURCE_CONSUMER_ROLE"); _OFFSET_SYNCS_SOURCE_CONSUMER_ROLEReady = true; } return _OFFSET_SYNCS_SOURCE_CONSUMER_ROLEContent; } }
        private static string _OFFSET_SYNCS_SOURCE_CONSUMER_ROLEContent = default;
        private static bool _OFFSET_SYNCS_SOURCE_CONSUMER_ROLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#OFFSET_SYNCS_TARGET_ADMIN_ROLE"/>
        /// </summary>
        public static string OFFSET_SYNCS_TARGET_ADMIN_ROLE { get { if (!_OFFSET_SYNCS_TARGET_ADMIN_ROLEReady) { _OFFSET_SYNCS_TARGET_ADMIN_ROLEContent = SGetField<string>(LocalBridgeClazz, "OFFSET_SYNCS_TARGET_ADMIN_ROLE"); _OFFSET_SYNCS_TARGET_ADMIN_ROLEReady = true; } return _OFFSET_SYNCS_TARGET_ADMIN_ROLEContent; } }
        private static string _OFFSET_SYNCS_TARGET_ADMIN_ROLEContent = default;
        private static bool _OFFSET_SYNCS_TARGET_ADMIN_ROLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#OFFSET_SYNCS_TARGET_CONSUMER_ROLE"/>
        /// </summary>
        public static string OFFSET_SYNCS_TARGET_CONSUMER_ROLE { get { if (!_OFFSET_SYNCS_TARGET_CONSUMER_ROLEReady) { _OFFSET_SYNCS_TARGET_CONSUMER_ROLEContent = SGetField<string>(LocalBridgeClazz, "OFFSET_SYNCS_TARGET_CONSUMER_ROLE"); _OFFSET_SYNCS_TARGET_CONSUMER_ROLEReady = true; } return _OFFSET_SYNCS_TARGET_CONSUMER_ROLEContent; } }
        private static string _OFFSET_SYNCS_TARGET_CONSUMER_ROLEContent = default;
        private static bool _OFFSET_SYNCS_TARGET_CONSUMER_ROLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#REFRESH_GROUPS_ENABLED"/>
        /// </summary>
        public static string REFRESH_GROUPS_ENABLED { get { if (!_REFRESH_GROUPS_ENABLEDReady) { _REFRESH_GROUPS_ENABLEDContent = SGetField<string>(LocalBridgeClazz, "REFRESH_GROUPS_ENABLED"); _REFRESH_GROUPS_ENABLEDReady = true; } return _REFRESH_GROUPS_ENABLEDContent; } }
        private static string _REFRESH_GROUPS_ENABLEDContent = default;
        private static bool _REFRESH_GROUPS_ENABLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#REFRESH_GROUPS_INTERVAL_SECONDS"/>
        /// </summary>
        public static string REFRESH_GROUPS_INTERVAL_SECONDS { get { if (!_REFRESH_GROUPS_INTERVAL_SECONDSReady) { _REFRESH_GROUPS_INTERVAL_SECONDSContent = SGetField<string>(LocalBridgeClazz, "REFRESH_GROUPS_INTERVAL_SECONDS"); _REFRESH_GROUPS_INTERVAL_SECONDSReady = true; } return _REFRESH_GROUPS_INTERVAL_SECONDSContent; } }
        private static string _REFRESH_GROUPS_INTERVAL_SECONDSContent = default;
        private static bool _REFRESH_GROUPS_INTERVAL_SECONDSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#SYNC_GROUP_OFFSETS_ENABLED"/>
        /// </summary>
        public static string SYNC_GROUP_OFFSETS_ENABLED { get { if (!_SYNC_GROUP_OFFSETS_ENABLEDReady) { _SYNC_GROUP_OFFSETS_ENABLEDContent = SGetField<string>(LocalBridgeClazz, "SYNC_GROUP_OFFSETS_ENABLED"); _SYNC_GROUP_OFFSETS_ENABLEDReady = true; } return _SYNC_GROUP_OFFSETS_ENABLEDContent; } }
        private static string _SYNC_GROUP_OFFSETS_ENABLEDContent = default;
        private static bool _SYNC_GROUP_OFFSETS_ENABLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#SYNC_GROUP_OFFSETS_INTERVAL_SECONDS"/>
        /// </summary>
        public static string SYNC_GROUP_OFFSETS_INTERVAL_SECONDS { get { if (!_SYNC_GROUP_OFFSETS_INTERVAL_SECONDSReady) { _SYNC_GROUP_OFFSETS_INTERVAL_SECONDSContent = SGetField<string>(LocalBridgeClazz, "SYNC_GROUP_OFFSETS_INTERVAL_SECONDS"); _SYNC_GROUP_OFFSETS_INTERVAL_SECONDSReady = true; } return _SYNC_GROUP_OFFSETS_INTERVAL_SECONDSContent; } }
        private static string _SYNC_GROUP_OFFSETS_INTERVAL_SECONDSContent = default;
        private static bool _SYNC_GROUP_OFFSETS_INTERVAL_SECONDSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#CONSUMER_POLL_TIMEOUT_MILLIS_DEFAULT"/>
        /// </summary>
        public static long CONSUMER_POLL_TIMEOUT_MILLIS_DEFAULT { get { if (!_CONSUMER_POLL_TIMEOUT_MILLIS_DEFAULTReady) { _CONSUMER_POLL_TIMEOUT_MILLIS_DEFAULTContent = SGetField<long>(LocalBridgeClazz, "CONSUMER_POLL_TIMEOUT_MILLIS_DEFAULT"); _CONSUMER_POLL_TIMEOUT_MILLIS_DEFAULTReady = true; } return _CONSUMER_POLL_TIMEOUT_MILLIS_DEFAULTContent; } }
        private static long _CONSUMER_POLL_TIMEOUT_MILLIS_DEFAULTContent = default;
        private static bool _CONSUMER_POLL_TIMEOUT_MILLIS_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#EMIT_CHECKPOINTS_INTERVAL_SECONDS_DEFAULT"/>
        /// </summary>
        public static long EMIT_CHECKPOINTS_INTERVAL_SECONDS_DEFAULT { get { if (!_EMIT_CHECKPOINTS_INTERVAL_SECONDS_DEFAULTReady) { _EMIT_CHECKPOINTS_INTERVAL_SECONDS_DEFAULTContent = SGetField<long>(LocalBridgeClazz, "EMIT_CHECKPOINTS_INTERVAL_SECONDS_DEFAULT"); _EMIT_CHECKPOINTS_INTERVAL_SECONDS_DEFAULTReady = true; } return _EMIT_CHECKPOINTS_INTERVAL_SECONDS_DEFAULTContent; } }
        private static long _EMIT_CHECKPOINTS_INTERVAL_SECONDS_DEFAULTContent = default;
        private static bool _EMIT_CHECKPOINTS_INTERVAL_SECONDS_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#REFRESH_GROUPS_INTERVAL_SECONDS_DEFAULT"/>
        /// </summary>
        public static long REFRESH_GROUPS_INTERVAL_SECONDS_DEFAULT { get { if (!_REFRESH_GROUPS_INTERVAL_SECONDS_DEFAULTReady) { _REFRESH_GROUPS_INTERVAL_SECONDS_DEFAULTContent = SGetField<long>(LocalBridgeClazz, "REFRESH_GROUPS_INTERVAL_SECONDS_DEFAULT"); _REFRESH_GROUPS_INTERVAL_SECONDS_DEFAULTReady = true; } return _REFRESH_GROUPS_INTERVAL_SECONDS_DEFAULTContent; } }
        private static long _REFRESH_GROUPS_INTERVAL_SECONDS_DEFAULTContent = default;
        private static bool _REFRESH_GROUPS_INTERVAL_SECONDS_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#SYNC_GROUP_OFFSETS_INTERVAL_SECONDS_DEFAULT"/>
        /// </summary>
        public static long SYNC_GROUP_OFFSETS_INTERVAL_SECONDS_DEFAULT { get { if (!_SYNC_GROUP_OFFSETS_INTERVAL_SECONDS_DEFAULTReady) { _SYNC_GROUP_OFFSETS_INTERVAL_SECONDS_DEFAULTContent = SGetField<long>(LocalBridgeClazz, "SYNC_GROUP_OFFSETS_INTERVAL_SECONDS_DEFAULT"); _SYNC_GROUP_OFFSETS_INTERVAL_SECONDS_DEFAULTReady = true; } return _SYNC_GROUP_OFFSETS_INTERVAL_SECONDS_DEFAULTContent; } }
        private static long _SYNC_GROUP_OFFSETS_INTERVAL_SECONDS_DEFAULTContent = default;
        private static bool _SYNC_GROUP_OFFSETS_INTERVAL_SECONDS_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DEFAULT"/>
        /// </summary>
        public static short CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DEFAULT { get { if (!_CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DEFAULTReady) { _CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DEFAULTContent = SGetField<short>(LocalBridgeClazz, "CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DEFAULT"); _CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DEFAULTReady = true; } return _CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DEFAULTContent; } }
        private static short _CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DEFAULTContent = default;
        private static bool _CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DEFAULTReady = false; // this is used because in case of generics 

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