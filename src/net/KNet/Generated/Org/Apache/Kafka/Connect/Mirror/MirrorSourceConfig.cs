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
*  using connect-mirror-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Mirror
{
    #region MirrorSourceConfig
    public partial class MirrorSourceConfig
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#org.apache.kafka.connect.mirror.MirrorSourceConfig(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public MirrorSourceConfig(Java.Util.Map<Java.Lang.String, Java.Lang.String> arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#org.apache.kafka.connect.mirror.MirrorSourceConfig(org.apache.kafka.common.config.ConfigDef,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Config.ConfigDef"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        public MirrorSourceConfig(Org.Apache.Kafka.Common.Config.ConfigDef arg0, Java.Util.Map<Java.Lang.String, Java.Lang.String> arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#ADD_SOURCE_ALIAS_TO_METRICS_DEFAULT"/>
        /// </summary>
        public static bool ADD_SOURCE_ALIAS_TO_METRICS_DEFAULT { get { if (!_ADD_SOURCE_ALIAS_TO_METRICS_DEFAULTReady) { _ADD_SOURCE_ALIAS_TO_METRICS_DEFAULTContent = SGetField<bool>(LocalBridgeClazz, "ADD_SOURCE_ALIAS_TO_METRICS_DEFAULT"); _ADD_SOURCE_ALIAS_TO_METRICS_DEFAULTReady = true; } return _ADD_SOURCE_ALIAS_TO_METRICS_DEFAULTContent; } }
        private static bool _ADD_SOURCE_ALIAS_TO_METRICS_DEFAULTContent = default;
        private static bool _ADD_SOURCE_ALIAS_TO_METRICS_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#REFRESH_TOPICS_ENABLED_DEFAULT"/>
        /// </summary>
        public static bool REFRESH_TOPICS_ENABLED_DEFAULT { get { if (!_REFRESH_TOPICS_ENABLED_DEFAULTReady) { _REFRESH_TOPICS_ENABLED_DEFAULTContent = SGetField<bool>(LocalBridgeClazz, "REFRESH_TOPICS_ENABLED_DEFAULT"); _REFRESH_TOPICS_ENABLED_DEFAULTReady = true; } return _REFRESH_TOPICS_ENABLED_DEFAULTContent; } }
        private static bool _REFRESH_TOPICS_ENABLED_DEFAULTContent = default;
        private static bool _REFRESH_TOPICS_ENABLED_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#SYNC_TOPIC_ACLS_ENABLED_DEFAULT"/>
        /// </summary>
        public static bool SYNC_TOPIC_ACLS_ENABLED_DEFAULT { get { if (!_SYNC_TOPIC_ACLS_ENABLED_DEFAULTReady) { _SYNC_TOPIC_ACLS_ENABLED_DEFAULTContent = SGetField<bool>(LocalBridgeClazz, "SYNC_TOPIC_ACLS_ENABLED_DEFAULT"); _SYNC_TOPIC_ACLS_ENABLED_DEFAULTReady = true; } return _SYNC_TOPIC_ACLS_ENABLED_DEFAULTContent; } }
        private static bool _SYNC_TOPIC_ACLS_ENABLED_DEFAULTContent = default;
        private static bool _SYNC_TOPIC_ACLS_ENABLED_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#SYNC_TOPIC_CONFIGS_ENABLED_DEFAULT"/>
        /// </summary>
        public static bool SYNC_TOPIC_CONFIGS_ENABLED_DEFAULT { get { if (!_SYNC_TOPIC_CONFIGS_ENABLED_DEFAULTReady) { _SYNC_TOPIC_CONFIGS_ENABLED_DEFAULTContent = SGetField<bool>(LocalBridgeClazz, "SYNC_TOPIC_CONFIGS_ENABLED_DEFAULT"); _SYNC_TOPIC_CONFIGS_ENABLED_DEFAULTReady = true; } return _SYNC_TOPIC_CONFIGS_ENABLED_DEFAULTContent; } }
        private static bool _SYNC_TOPIC_CONFIGS_ENABLED_DEFAULTContent = default;
        private static bool _SYNC_TOPIC_CONFIGS_ENABLED_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#REPLICATION_FACTOR_DEFAULT"/>
        /// </summary>
        public static int REPLICATION_FACTOR_DEFAULT { get { if (!_REPLICATION_FACTOR_DEFAULTReady) { _REPLICATION_FACTOR_DEFAULTContent = SGetField<int>(LocalBridgeClazz, "REPLICATION_FACTOR_DEFAULT"); _REPLICATION_FACTOR_DEFAULTReady = true; } return _REPLICATION_FACTOR_DEFAULTContent; } }
        private static int _REPLICATION_FACTOR_DEFAULTContent = default;
        private static bool _REPLICATION_FACTOR_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#CONFIG_PROPERTY_FILTER_CLASS_DEFAULT"/>
        /// </summary>
        public static Java.Lang.Class CONFIG_PROPERTY_FILTER_CLASS_DEFAULT { get { if (!_CONFIG_PROPERTY_FILTER_CLASS_DEFAULTReady) { _CONFIG_PROPERTY_FILTER_CLASS_DEFAULTContent = SGetField<Java.Lang.Class>(LocalBridgeClazz, "CONFIG_PROPERTY_FILTER_CLASS_DEFAULT"); _CONFIG_PROPERTY_FILTER_CLASS_DEFAULTReady = true; } return _CONFIG_PROPERTY_FILTER_CLASS_DEFAULTContent; } }
        private static Java.Lang.Class _CONFIG_PROPERTY_FILTER_CLASS_DEFAULTContent = default;
        private static bool _CONFIG_PROPERTY_FILTER_CLASS_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#ADD_SOURCE_ALIAS_TO_METRICS"/>
        /// </summary>
        public static Java.Lang.String ADD_SOURCE_ALIAS_TO_METRICS { get { if (!_ADD_SOURCE_ALIAS_TO_METRICSReady) { _ADD_SOURCE_ALIAS_TO_METRICSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ADD_SOURCE_ALIAS_TO_METRICS"); _ADD_SOURCE_ALIAS_TO_METRICSReady = true; } return _ADD_SOURCE_ALIAS_TO_METRICSContent; } }
        private static Java.Lang.String _ADD_SOURCE_ALIAS_TO_METRICSContent = default;
        private static bool _ADD_SOURCE_ALIAS_TO_METRICSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#CONFIG_PROPERTIES_EXCLUDE"/>
        /// </summary>
        public static Java.Lang.String CONFIG_PROPERTIES_EXCLUDE { get { if (!_CONFIG_PROPERTIES_EXCLUDEReady) { _CONFIG_PROPERTIES_EXCLUDEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CONFIG_PROPERTIES_EXCLUDE"); _CONFIG_PROPERTIES_EXCLUDEReady = true; } return _CONFIG_PROPERTIES_EXCLUDEContent; } }
        private static Java.Lang.String _CONFIG_PROPERTIES_EXCLUDEContent = default;
        private static bool _CONFIG_PROPERTIES_EXCLUDEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#CONFIG_PROPERTIES_EXCLUDE_ALIAS"/>
        /// </summary>
        public static Java.Lang.String CONFIG_PROPERTIES_EXCLUDE_ALIAS { get { if (!_CONFIG_PROPERTIES_EXCLUDE_ALIASReady) { _CONFIG_PROPERTIES_EXCLUDE_ALIASContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CONFIG_PROPERTIES_EXCLUDE_ALIAS"); _CONFIG_PROPERTIES_EXCLUDE_ALIASReady = true; } return _CONFIG_PROPERTIES_EXCLUDE_ALIASContent; } }
        private static Java.Lang.String _CONFIG_PROPERTIES_EXCLUDE_ALIASContent = default;
        private static bool _CONFIG_PROPERTIES_EXCLUDE_ALIASReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#CONFIG_PROPERTIES_EXCLUDE_DEFAULT"/>
        /// </summary>
        public static Java.Lang.String CONFIG_PROPERTIES_EXCLUDE_DEFAULT { get { if (!_CONFIG_PROPERTIES_EXCLUDE_DEFAULTReady) { _CONFIG_PROPERTIES_EXCLUDE_DEFAULTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CONFIG_PROPERTIES_EXCLUDE_DEFAULT"); _CONFIG_PROPERTIES_EXCLUDE_DEFAULTReady = true; } return _CONFIG_PROPERTIES_EXCLUDE_DEFAULTContent; } }
        private static Java.Lang.String _CONFIG_PROPERTIES_EXCLUDE_DEFAULTContent = default;
        private static bool _CONFIG_PROPERTIES_EXCLUDE_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#CONFIG_PROPERTY_FILTER_CLASS"/>
        /// </summary>
        public static Java.Lang.String CONFIG_PROPERTY_FILTER_CLASS { get { if (!_CONFIG_PROPERTY_FILTER_CLASSReady) { _CONFIG_PROPERTY_FILTER_CLASSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CONFIG_PROPERTY_FILTER_CLASS"); _CONFIG_PROPERTY_FILTER_CLASSReady = true; } return _CONFIG_PROPERTY_FILTER_CLASSContent; } }
        private static Java.Lang.String _CONFIG_PROPERTY_FILTER_CLASSContent = default;
        private static bool _CONFIG_PROPERTY_FILTER_CLASSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#CONSUMER_POLL_TIMEOUT_MILLIS"/>
        /// </summary>
        public static Java.Lang.String CONSUMER_POLL_TIMEOUT_MILLIS { get { if (!_CONSUMER_POLL_TIMEOUT_MILLISReady) { _CONSUMER_POLL_TIMEOUT_MILLISContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CONSUMER_POLL_TIMEOUT_MILLIS"); _CONSUMER_POLL_TIMEOUT_MILLISReady = true; } return _CONSUMER_POLL_TIMEOUT_MILLISContent; } }
        private static Java.Lang.String _CONSUMER_POLL_TIMEOUT_MILLISContent = default;
        private static bool _CONSUMER_POLL_TIMEOUT_MILLISReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#NEVER_USE_INCREMENTAL_ALTER_CONFIGS"/>
        /// </summary>
        public static Java.Lang.String NEVER_USE_INCREMENTAL_ALTER_CONFIGS { get { if (!_NEVER_USE_INCREMENTAL_ALTER_CONFIGSReady) { _NEVER_USE_INCREMENTAL_ALTER_CONFIGSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "NEVER_USE_INCREMENTAL_ALTER_CONFIGS"); _NEVER_USE_INCREMENTAL_ALTER_CONFIGSReady = true; } return _NEVER_USE_INCREMENTAL_ALTER_CONFIGSContent; } }
        private static Java.Lang.String _NEVER_USE_INCREMENTAL_ALTER_CONFIGSContent = default;
        private static bool _NEVER_USE_INCREMENTAL_ALTER_CONFIGSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#OFFSET_LAG_MAX"/>
        /// </summary>
        public static Java.Lang.String OFFSET_LAG_MAX { get { if (!_OFFSET_LAG_MAXReady) { _OFFSET_LAG_MAXContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "OFFSET_LAG_MAX"); _OFFSET_LAG_MAXReady = true; } return _OFFSET_LAG_MAXContent; } }
        private static Java.Lang.String _OFFSET_LAG_MAXContent = default;
        private static bool _OFFSET_LAG_MAXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#OFFSET_SYNCS_SOURCE_ADMIN_ROLE"/>
        /// </summary>
        public static Java.Lang.String OFFSET_SYNCS_SOURCE_ADMIN_ROLE { get { if (!_OFFSET_SYNCS_SOURCE_ADMIN_ROLEReady) { _OFFSET_SYNCS_SOURCE_ADMIN_ROLEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "OFFSET_SYNCS_SOURCE_ADMIN_ROLE"); _OFFSET_SYNCS_SOURCE_ADMIN_ROLEReady = true; } return _OFFSET_SYNCS_SOURCE_ADMIN_ROLEContent; } }
        private static Java.Lang.String _OFFSET_SYNCS_SOURCE_ADMIN_ROLEContent = default;
        private static bool _OFFSET_SYNCS_SOURCE_ADMIN_ROLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#OFFSET_SYNCS_SOURCE_PRODUCER_ROLE"/>
        /// </summary>
        public static Java.Lang.String OFFSET_SYNCS_SOURCE_PRODUCER_ROLE { get { if (!_OFFSET_SYNCS_SOURCE_PRODUCER_ROLEReady) { _OFFSET_SYNCS_SOURCE_PRODUCER_ROLEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "OFFSET_SYNCS_SOURCE_PRODUCER_ROLE"); _OFFSET_SYNCS_SOURCE_PRODUCER_ROLEReady = true; } return _OFFSET_SYNCS_SOURCE_PRODUCER_ROLEContent; } }
        private static Java.Lang.String _OFFSET_SYNCS_SOURCE_PRODUCER_ROLEContent = default;
        private static bool _OFFSET_SYNCS_SOURCE_PRODUCER_ROLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#OFFSET_SYNCS_TARGET_ADMIN_ROLE"/>
        /// </summary>
        public static Java.Lang.String OFFSET_SYNCS_TARGET_ADMIN_ROLE { get { if (!_OFFSET_SYNCS_TARGET_ADMIN_ROLEReady) { _OFFSET_SYNCS_TARGET_ADMIN_ROLEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "OFFSET_SYNCS_TARGET_ADMIN_ROLE"); _OFFSET_SYNCS_TARGET_ADMIN_ROLEReady = true; } return _OFFSET_SYNCS_TARGET_ADMIN_ROLEContent; } }
        private static Java.Lang.String _OFFSET_SYNCS_TARGET_ADMIN_ROLEContent = default;
        private static bool _OFFSET_SYNCS_TARGET_ADMIN_ROLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#OFFSET_SYNCS_TARGET_PRODUCER_ROLE"/>
        /// </summary>
        public static Java.Lang.String OFFSET_SYNCS_TARGET_PRODUCER_ROLE { get { if (!_OFFSET_SYNCS_TARGET_PRODUCER_ROLEReady) { _OFFSET_SYNCS_TARGET_PRODUCER_ROLEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "OFFSET_SYNCS_TARGET_PRODUCER_ROLE"); _OFFSET_SYNCS_TARGET_PRODUCER_ROLEReady = true; } return _OFFSET_SYNCS_TARGET_PRODUCER_ROLEContent; } }
        private static Java.Lang.String _OFFSET_SYNCS_TARGET_PRODUCER_ROLEContent = default;
        private static bool _OFFSET_SYNCS_TARGET_PRODUCER_ROLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#OFFSET_SYNCS_TOPIC_REPLICATION_FACTOR"/>
        /// </summary>
        public static Java.Lang.String OFFSET_SYNCS_TOPIC_REPLICATION_FACTOR { get { if (!_OFFSET_SYNCS_TOPIC_REPLICATION_FACTORReady) { _OFFSET_SYNCS_TOPIC_REPLICATION_FACTORContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "OFFSET_SYNCS_TOPIC_REPLICATION_FACTOR"); _OFFSET_SYNCS_TOPIC_REPLICATION_FACTORReady = true; } return _OFFSET_SYNCS_TOPIC_REPLICATION_FACTORContent; } }
        private static Java.Lang.String _OFFSET_SYNCS_TOPIC_REPLICATION_FACTORContent = default;
        private static bool _OFFSET_SYNCS_TOPIC_REPLICATION_FACTORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#OFFSET_SYNCS_TOPIC_REPLICATION_FACTOR_DOC"/>
        /// </summary>
        public static Java.Lang.String OFFSET_SYNCS_TOPIC_REPLICATION_FACTOR_DOC { get { if (!_OFFSET_SYNCS_TOPIC_REPLICATION_FACTOR_DOCReady) { _OFFSET_SYNCS_TOPIC_REPLICATION_FACTOR_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "OFFSET_SYNCS_TOPIC_REPLICATION_FACTOR_DOC"); _OFFSET_SYNCS_TOPIC_REPLICATION_FACTOR_DOCReady = true; } return _OFFSET_SYNCS_TOPIC_REPLICATION_FACTOR_DOCContent; } }
        private static Java.Lang.String _OFFSET_SYNCS_TOPIC_REPLICATION_FACTOR_DOCContent = default;
        private static bool _OFFSET_SYNCS_TOPIC_REPLICATION_FACTOR_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#REFRESH_TOPICS_ENABLED"/>
        /// </summary>
        public static Java.Lang.String REFRESH_TOPICS_ENABLED { get { if (!_REFRESH_TOPICS_ENABLEDReady) { _REFRESH_TOPICS_ENABLEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "REFRESH_TOPICS_ENABLED"); _REFRESH_TOPICS_ENABLEDReady = true; } return _REFRESH_TOPICS_ENABLEDContent; } }
        private static Java.Lang.String _REFRESH_TOPICS_ENABLEDContent = default;
        private static bool _REFRESH_TOPICS_ENABLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#REFRESH_TOPICS_INTERVAL_SECONDS"/>
        /// </summary>
        public static Java.Lang.String REFRESH_TOPICS_INTERVAL_SECONDS { get { if (!_REFRESH_TOPICS_INTERVAL_SECONDSReady) { _REFRESH_TOPICS_INTERVAL_SECONDSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "REFRESH_TOPICS_INTERVAL_SECONDS"); _REFRESH_TOPICS_INTERVAL_SECONDSReady = true; } return _REFRESH_TOPICS_INTERVAL_SECONDSContent; } }
        private static Java.Lang.String _REFRESH_TOPICS_INTERVAL_SECONDSContent = default;
        private static bool _REFRESH_TOPICS_INTERVAL_SECONDSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#REPLICATION_FACTOR"/>
        /// </summary>
        public static Java.Lang.String REPLICATION_FACTOR { get { if (!_REPLICATION_FACTORReady) { _REPLICATION_FACTORContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "REPLICATION_FACTOR"); _REPLICATION_FACTORReady = true; } return _REPLICATION_FACTORContent; } }
        private static Java.Lang.String _REPLICATION_FACTORContent = default;
        private static bool _REPLICATION_FACTORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#REQUEST_INCREMENTAL_ALTER_CONFIGS"/>
        /// </summary>
        public static Java.Lang.String REQUEST_INCREMENTAL_ALTER_CONFIGS { get { if (!_REQUEST_INCREMENTAL_ALTER_CONFIGSReady) { _REQUEST_INCREMENTAL_ALTER_CONFIGSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "REQUEST_INCREMENTAL_ALTER_CONFIGS"); _REQUEST_INCREMENTAL_ALTER_CONFIGSReady = true; } return _REQUEST_INCREMENTAL_ALTER_CONFIGSContent; } }
        private static Java.Lang.String _REQUEST_INCREMENTAL_ALTER_CONFIGSContent = default;
        private static bool _REQUEST_INCREMENTAL_ALTER_CONFIGSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#REQUIRE_INCREMENTAL_ALTER_CONFIGS"/>
        /// </summary>
        public static Java.Lang.String REQUIRE_INCREMENTAL_ALTER_CONFIGS { get { if (!_REQUIRE_INCREMENTAL_ALTER_CONFIGSReady) { _REQUIRE_INCREMENTAL_ALTER_CONFIGSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "REQUIRE_INCREMENTAL_ALTER_CONFIGS"); _REQUIRE_INCREMENTAL_ALTER_CONFIGSReady = true; } return _REQUIRE_INCREMENTAL_ALTER_CONFIGSContent; } }
        private static Java.Lang.String _REQUIRE_INCREMENTAL_ALTER_CONFIGSContent = default;
        private static bool _REQUIRE_INCREMENTAL_ALTER_CONFIGSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#SYNC_TOPIC_ACLS_ENABLED"/>
        /// </summary>
        public static Java.Lang.String SYNC_TOPIC_ACLS_ENABLED { get { if (!_SYNC_TOPIC_ACLS_ENABLEDReady) { _SYNC_TOPIC_ACLS_ENABLEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SYNC_TOPIC_ACLS_ENABLED"); _SYNC_TOPIC_ACLS_ENABLEDReady = true; } return _SYNC_TOPIC_ACLS_ENABLEDContent; } }
        private static Java.Lang.String _SYNC_TOPIC_ACLS_ENABLEDContent = default;
        private static bool _SYNC_TOPIC_ACLS_ENABLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#SYNC_TOPIC_ACLS_INTERVAL_SECONDS"/>
        /// </summary>
        public static Java.Lang.String SYNC_TOPIC_ACLS_INTERVAL_SECONDS { get { if (!_SYNC_TOPIC_ACLS_INTERVAL_SECONDSReady) { _SYNC_TOPIC_ACLS_INTERVAL_SECONDSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SYNC_TOPIC_ACLS_INTERVAL_SECONDS"); _SYNC_TOPIC_ACLS_INTERVAL_SECONDSReady = true; } return _SYNC_TOPIC_ACLS_INTERVAL_SECONDSContent; } }
        private static Java.Lang.String _SYNC_TOPIC_ACLS_INTERVAL_SECONDSContent = default;
        private static bool _SYNC_TOPIC_ACLS_INTERVAL_SECONDSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#SYNC_TOPIC_CONFIGS_ENABLED"/>
        /// </summary>
        public static Java.Lang.String SYNC_TOPIC_CONFIGS_ENABLED { get { if (!_SYNC_TOPIC_CONFIGS_ENABLEDReady) { _SYNC_TOPIC_CONFIGS_ENABLEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SYNC_TOPIC_CONFIGS_ENABLED"); _SYNC_TOPIC_CONFIGS_ENABLEDReady = true; } return _SYNC_TOPIC_CONFIGS_ENABLEDContent; } }
        private static Java.Lang.String _SYNC_TOPIC_CONFIGS_ENABLEDContent = default;
        private static bool _SYNC_TOPIC_CONFIGS_ENABLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#SYNC_TOPIC_CONFIGS_INTERVAL_SECONDS"/>
        /// </summary>
        public static Java.Lang.String SYNC_TOPIC_CONFIGS_INTERVAL_SECONDS { get { if (!_SYNC_TOPIC_CONFIGS_INTERVAL_SECONDSReady) { _SYNC_TOPIC_CONFIGS_INTERVAL_SECONDSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SYNC_TOPIC_CONFIGS_INTERVAL_SECONDS"); _SYNC_TOPIC_CONFIGS_INTERVAL_SECONDSReady = true; } return _SYNC_TOPIC_CONFIGS_INTERVAL_SECONDSContent; } }
        private static Java.Lang.String _SYNC_TOPIC_CONFIGS_INTERVAL_SECONDSContent = default;
        private static bool _SYNC_TOPIC_CONFIGS_INTERVAL_SECONDSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#TOPICS"/>
        /// </summary>
        public static Java.Lang.String TOPICS { get { if (!_TOPICSReady) { _TOPICSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TOPICS"); _TOPICSReady = true; } return _TOPICSContent; } }
        private static Java.Lang.String _TOPICSContent = default;
        private static bool _TOPICSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#TOPICS_DEFAULT"/>
        /// </summary>
        public static Java.Lang.String TOPICS_DEFAULT { get { if (!_TOPICS_DEFAULTReady) { _TOPICS_DEFAULTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TOPICS_DEFAULT"); _TOPICS_DEFAULTReady = true; } return _TOPICS_DEFAULTContent; } }
        private static Java.Lang.String _TOPICS_DEFAULTContent = default;
        private static bool _TOPICS_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#TOPICS_EXCLUDE"/>
        /// </summary>
        public static Java.Lang.String TOPICS_EXCLUDE { get { if (!_TOPICS_EXCLUDEReady) { _TOPICS_EXCLUDEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TOPICS_EXCLUDE"); _TOPICS_EXCLUDEReady = true; } return _TOPICS_EXCLUDEContent; } }
        private static Java.Lang.String _TOPICS_EXCLUDEContent = default;
        private static bool _TOPICS_EXCLUDEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#TOPICS_EXCLUDE_ALIAS"/>
        /// </summary>
        public static Java.Lang.String TOPICS_EXCLUDE_ALIAS { get { if (!_TOPICS_EXCLUDE_ALIASReady) { _TOPICS_EXCLUDE_ALIASContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TOPICS_EXCLUDE_ALIAS"); _TOPICS_EXCLUDE_ALIASReady = true; } return _TOPICS_EXCLUDE_ALIASContent; } }
        private static Java.Lang.String _TOPICS_EXCLUDE_ALIASContent = default;
        private static bool _TOPICS_EXCLUDE_ALIASReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#TOPICS_EXCLUDE_DEFAULT"/>
        /// </summary>
        public static Java.Lang.String TOPICS_EXCLUDE_DEFAULT { get { if (!_TOPICS_EXCLUDE_DEFAULTReady) { _TOPICS_EXCLUDE_DEFAULTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TOPICS_EXCLUDE_DEFAULT"); _TOPICS_EXCLUDE_DEFAULTReady = true; } return _TOPICS_EXCLUDE_DEFAULTContent; } }
        private static Java.Lang.String _TOPICS_EXCLUDE_DEFAULTContent = default;
        private static bool _TOPICS_EXCLUDE_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#CONSUMER_POLL_TIMEOUT_MILLIS_DEFAULT"/>
        /// </summary>
        public static long CONSUMER_POLL_TIMEOUT_MILLIS_DEFAULT { get { if (!_CONSUMER_POLL_TIMEOUT_MILLIS_DEFAULTReady) { _CONSUMER_POLL_TIMEOUT_MILLIS_DEFAULTContent = SGetField<long>(LocalBridgeClazz, "CONSUMER_POLL_TIMEOUT_MILLIS_DEFAULT"); _CONSUMER_POLL_TIMEOUT_MILLIS_DEFAULTReady = true; } return _CONSUMER_POLL_TIMEOUT_MILLIS_DEFAULTContent; } }
        private static long _CONSUMER_POLL_TIMEOUT_MILLIS_DEFAULTContent = default;
        private static bool _CONSUMER_POLL_TIMEOUT_MILLIS_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#OFFSET_LAG_MAX_DEFAULT"/>
        /// </summary>
        public static long OFFSET_LAG_MAX_DEFAULT { get { if (!_OFFSET_LAG_MAX_DEFAULTReady) { _OFFSET_LAG_MAX_DEFAULTContent = SGetField<long>(LocalBridgeClazz, "OFFSET_LAG_MAX_DEFAULT"); _OFFSET_LAG_MAX_DEFAULTReady = true; } return _OFFSET_LAG_MAX_DEFAULTContent; } }
        private static long _OFFSET_LAG_MAX_DEFAULTContent = default;
        private static bool _OFFSET_LAG_MAX_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#REFRESH_TOPICS_INTERVAL_SECONDS_DEFAULT"/>
        /// </summary>
        public static long REFRESH_TOPICS_INTERVAL_SECONDS_DEFAULT { get { if (!_REFRESH_TOPICS_INTERVAL_SECONDS_DEFAULTReady) { _REFRESH_TOPICS_INTERVAL_SECONDS_DEFAULTContent = SGetField<long>(LocalBridgeClazz, "REFRESH_TOPICS_INTERVAL_SECONDS_DEFAULT"); _REFRESH_TOPICS_INTERVAL_SECONDS_DEFAULTReady = true; } return _REFRESH_TOPICS_INTERVAL_SECONDS_DEFAULTContent; } }
        private static long _REFRESH_TOPICS_INTERVAL_SECONDS_DEFAULTContent = default;
        private static bool _REFRESH_TOPICS_INTERVAL_SECONDS_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#SYNC_TOPIC_ACLS_INTERVAL_SECONDS_DEFAULT"/>
        /// </summary>
        public static long SYNC_TOPIC_ACLS_INTERVAL_SECONDS_DEFAULT { get { if (!_SYNC_TOPIC_ACLS_INTERVAL_SECONDS_DEFAULTReady) { _SYNC_TOPIC_ACLS_INTERVAL_SECONDS_DEFAULTContent = SGetField<long>(LocalBridgeClazz, "SYNC_TOPIC_ACLS_INTERVAL_SECONDS_DEFAULT"); _SYNC_TOPIC_ACLS_INTERVAL_SECONDS_DEFAULTReady = true; } return _SYNC_TOPIC_ACLS_INTERVAL_SECONDS_DEFAULTContent; } }
        private static long _SYNC_TOPIC_ACLS_INTERVAL_SECONDS_DEFAULTContent = default;
        private static bool _SYNC_TOPIC_ACLS_INTERVAL_SECONDS_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#SYNC_TOPIC_CONFIGS_INTERVAL_SECONDS_DEFAULT"/>
        /// </summary>
        public static long SYNC_TOPIC_CONFIGS_INTERVAL_SECONDS_DEFAULT { get { if (!_SYNC_TOPIC_CONFIGS_INTERVAL_SECONDS_DEFAULTReady) { _SYNC_TOPIC_CONFIGS_INTERVAL_SECONDS_DEFAULTContent = SGetField<long>(LocalBridgeClazz, "SYNC_TOPIC_CONFIGS_INTERVAL_SECONDS_DEFAULT"); _SYNC_TOPIC_CONFIGS_INTERVAL_SECONDS_DEFAULTReady = true; } return _SYNC_TOPIC_CONFIGS_INTERVAL_SECONDS_DEFAULTContent; } }
        private static long _SYNC_TOPIC_CONFIGS_INTERVAL_SECONDS_DEFAULTContent = default;
        private static bool _SYNC_TOPIC_CONFIGS_INTERVAL_SECONDS_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorSourceConfig.html#OFFSET_SYNCS_TOPIC_REPLICATION_FACTOR_DEFAULT"/>
        /// </summary>
        public static short OFFSET_SYNCS_TOPIC_REPLICATION_FACTOR_DEFAULT { get { if (!_OFFSET_SYNCS_TOPIC_REPLICATION_FACTOR_DEFAULTReady) { _OFFSET_SYNCS_TOPIC_REPLICATION_FACTOR_DEFAULTContent = SGetField<short>(LocalBridgeClazz, "OFFSET_SYNCS_TOPIC_REPLICATION_FACTOR_DEFAULT"); _OFFSET_SYNCS_TOPIC_REPLICATION_FACTOR_DEFAULTReady = true; } return _OFFSET_SYNCS_TOPIC_REPLICATION_FACTOR_DEFAULTContent; } }
        private static short _OFFSET_SYNCS_TOPIC_REPLICATION_FACTOR_DEFAULTContent = default;
        private static bool _OFFSET_SYNCS_TOPIC_REPLICATION_FACTOR_DEFAULTReady = false; // this is used because in case of generics 

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