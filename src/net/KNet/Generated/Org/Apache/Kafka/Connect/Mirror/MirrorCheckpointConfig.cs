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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using connect-mirror-3.9.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Mirror
{
    #region MirrorCheckpointConfig declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html"/>
    /// </summary>
    public partial class MirrorCheckpointConfig : Org.Apache.Kafka.Connect.Mirror.MirrorConnectorConfig, MASES.JCOBridge.C2JBridge.IJVMBridgeMain
    {
        const string _bridgeClassName = "org.apache.kafka.connect.mirror.MirrorCheckpointConfig";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public MirrorCheckpointConfig() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public MirrorCheckpointConfig(params object[] args) : base(args) { }

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

    #region MirrorCheckpointConfig implementation
    public partial class MirrorCheckpointConfig
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#org.apache.kafka.connect.mirror.MirrorCheckpointConfig(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public MirrorCheckpointConfig(Java.Util.Map<Java.Lang.String, Java.Lang.String> arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#org.apache.kafka.connect.mirror.MirrorCheckpointConfig(org.apache.kafka.common.config.ConfigDef,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Config.ConfigDef"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        public MirrorCheckpointConfig(Org.Apache.Kafka.Common.Config.ConfigDef arg0, Java.Util.Map<Java.Lang.String, Java.Lang.String> arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#EMIT_CHECKPOINTS_ENABLED_DEFAULT"/>
        /// </summary>
        public static bool EMIT_CHECKPOINTS_ENABLED_DEFAULT { get { if (!_EMIT_CHECKPOINTS_ENABLED_DEFAULTReady) { _EMIT_CHECKPOINTS_ENABLED_DEFAULTContent = SGetField<bool>(LocalBridgeClazz, "EMIT_CHECKPOINTS_ENABLED_DEFAULT"); _EMIT_CHECKPOINTS_ENABLED_DEFAULTReady = true; } return _EMIT_CHECKPOINTS_ENABLED_DEFAULTContent; } }
        private static bool _EMIT_CHECKPOINTS_ENABLED_DEFAULTContent = default;
        private static bool _EMIT_CHECKPOINTS_ENABLED_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#REFRESH_GROUPS_ENABLED_DEFAULT"/>
        /// </summary>
        public static bool REFRESH_GROUPS_ENABLED_DEFAULT { get { if (!_REFRESH_GROUPS_ENABLED_DEFAULTReady) { _REFRESH_GROUPS_ENABLED_DEFAULTContent = SGetField<bool>(LocalBridgeClazz, "REFRESH_GROUPS_ENABLED_DEFAULT"); _REFRESH_GROUPS_ENABLED_DEFAULTReady = true; } return _REFRESH_GROUPS_ENABLED_DEFAULTContent; } }
        private static bool _REFRESH_GROUPS_ENABLED_DEFAULTContent = default;
        private static bool _REFRESH_GROUPS_ENABLED_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#SYNC_GROUP_OFFSETS_ENABLED_DEFAULT"/>
        /// </summary>
        public static bool SYNC_GROUP_OFFSETS_ENABLED_DEFAULT { get { if (!_SYNC_GROUP_OFFSETS_ENABLED_DEFAULTReady) { _SYNC_GROUP_OFFSETS_ENABLED_DEFAULTContent = SGetField<bool>(LocalBridgeClazz, "SYNC_GROUP_OFFSETS_ENABLED_DEFAULT"); _SYNC_GROUP_OFFSETS_ENABLED_DEFAULTReady = true; } return _SYNC_GROUP_OFFSETS_ENABLED_DEFAULTContent; } }
        private static bool _SYNC_GROUP_OFFSETS_ENABLED_DEFAULTContent = default;
        private static bool _SYNC_GROUP_OFFSETS_ENABLED_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#GROUP_FILTER_CLASS_DEFAULT"/>
        /// </summary>
        public static Java.Lang.Class GROUP_FILTER_CLASS_DEFAULT { get { if (!_GROUP_FILTER_CLASS_DEFAULTReady) { _GROUP_FILTER_CLASS_DEFAULTContent = SGetField<Java.Lang.Class>(LocalBridgeClazz, "GROUP_FILTER_CLASS_DEFAULT"); _GROUP_FILTER_CLASS_DEFAULTReady = true; } return _GROUP_FILTER_CLASS_DEFAULTContent; } }
        private static Java.Lang.Class _GROUP_FILTER_CLASS_DEFAULTContent = default;
        private static bool _GROUP_FILTER_CLASS_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#CHECKPOINTS_TARGET_CONSUMER_ROLE"/>
        /// </summary>
        public static Java.Lang.String CHECKPOINTS_TARGET_CONSUMER_ROLE { get { if (!_CHECKPOINTS_TARGET_CONSUMER_ROLEReady) { _CHECKPOINTS_TARGET_CONSUMER_ROLEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CHECKPOINTS_TARGET_CONSUMER_ROLE"); _CHECKPOINTS_TARGET_CONSUMER_ROLEReady = true; } return _CHECKPOINTS_TARGET_CONSUMER_ROLEContent; } }
        private static Java.Lang.String _CHECKPOINTS_TARGET_CONSUMER_ROLEContent = default;
        private static bool _CHECKPOINTS_TARGET_CONSUMER_ROLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#CHECKPOINTS_TOPIC_REPLICATION_FACTOR"/>
        /// </summary>
        public static Java.Lang.String CHECKPOINTS_TOPIC_REPLICATION_FACTOR { get { if (!_CHECKPOINTS_TOPIC_REPLICATION_FACTORReady) { _CHECKPOINTS_TOPIC_REPLICATION_FACTORContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CHECKPOINTS_TOPIC_REPLICATION_FACTOR"); _CHECKPOINTS_TOPIC_REPLICATION_FACTORReady = true; } return _CHECKPOINTS_TOPIC_REPLICATION_FACTORContent; } }
        private static Java.Lang.String _CHECKPOINTS_TOPIC_REPLICATION_FACTORContent = default;
        private static bool _CHECKPOINTS_TOPIC_REPLICATION_FACTORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DOC"/>
        /// </summary>
        public static Java.Lang.String CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DOC { get { if (!_CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DOCReady) { _CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DOC"); _CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DOCReady = true; } return _CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DOCContent; } }
        private static Java.Lang.String _CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DOCContent = default;
        private static bool _CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#CONSUMER_POLL_TIMEOUT_MILLIS"/>
        /// </summary>
        public static Java.Lang.String CONSUMER_POLL_TIMEOUT_MILLIS { get { if (!_CONSUMER_POLL_TIMEOUT_MILLISReady) { _CONSUMER_POLL_TIMEOUT_MILLISContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CONSUMER_POLL_TIMEOUT_MILLIS"); _CONSUMER_POLL_TIMEOUT_MILLISReady = true; } return _CONSUMER_POLL_TIMEOUT_MILLISContent; } }
        private static Java.Lang.String _CONSUMER_POLL_TIMEOUT_MILLISContent = default;
        private static bool _CONSUMER_POLL_TIMEOUT_MILLISReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#EMIT_CHECKPOINTS_ENABLED"/>
        /// </summary>
        public static Java.Lang.String EMIT_CHECKPOINTS_ENABLED { get { if (!_EMIT_CHECKPOINTS_ENABLEDReady) { _EMIT_CHECKPOINTS_ENABLEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EMIT_CHECKPOINTS_ENABLED"); _EMIT_CHECKPOINTS_ENABLEDReady = true; } return _EMIT_CHECKPOINTS_ENABLEDContent; } }
        private static Java.Lang.String _EMIT_CHECKPOINTS_ENABLEDContent = default;
        private static bool _EMIT_CHECKPOINTS_ENABLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#EMIT_CHECKPOINTS_INTERVAL_SECONDS"/>
        /// </summary>
        public static Java.Lang.String EMIT_CHECKPOINTS_INTERVAL_SECONDS { get { if (!_EMIT_CHECKPOINTS_INTERVAL_SECONDSReady) { _EMIT_CHECKPOINTS_INTERVAL_SECONDSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EMIT_CHECKPOINTS_INTERVAL_SECONDS"); _EMIT_CHECKPOINTS_INTERVAL_SECONDSReady = true; } return _EMIT_CHECKPOINTS_INTERVAL_SECONDSContent; } }
        private static Java.Lang.String _EMIT_CHECKPOINTS_INTERVAL_SECONDSContent = default;
        private static bool _EMIT_CHECKPOINTS_INTERVAL_SECONDSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#GROUP_FILTER_CLASS"/>
        /// </summary>
        public static Java.Lang.String GROUP_FILTER_CLASS { get { if (!_GROUP_FILTER_CLASSReady) { _GROUP_FILTER_CLASSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "GROUP_FILTER_CLASS"); _GROUP_FILTER_CLASSReady = true; } return _GROUP_FILTER_CLASSContent; } }
        private static Java.Lang.String _GROUP_FILTER_CLASSContent = default;
        private static bool _GROUP_FILTER_CLASSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#GROUPS"/>
        /// </summary>
        public static Java.Lang.String GROUPS { get { if (!_GROUPSReady) { _GROUPSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "GROUPS"); _GROUPSReady = true; } return _GROUPSContent; } }
        private static Java.Lang.String _GROUPSContent = default;
        private static bool _GROUPSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#GROUPS_DEFAULT"/>
        /// </summary>
        public static Java.Lang.String GROUPS_DEFAULT { get { if (!_GROUPS_DEFAULTReady) { _GROUPS_DEFAULTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "GROUPS_DEFAULT"); _GROUPS_DEFAULTReady = true; } return _GROUPS_DEFAULTContent; } }
        private static Java.Lang.String _GROUPS_DEFAULTContent = default;
        private static bool _GROUPS_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#GROUPS_EXCLUDE"/>
        /// </summary>
        public static Java.Lang.String GROUPS_EXCLUDE { get { if (!_GROUPS_EXCLUDEReady) { _GROUPS_EXCLUDEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "GROUPS_EXCLUDE"); _GROUPS_EXCLUDEReady = true; } return _GROUPS_EXCLUDEContent; } }
        private static Java.Lang.String _GROUPS_EXCLUDEContent = default;
        private static bool _GROUPS_EXCLUDEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#GROUPS_EXCLUDE_ALIAS"/>
        /// </summary>
        public static Java.Lang.String GROUPS_EXCLUDE_ALIAS { get { if (!_GROUPS_EXCLUDE_ALIASReady) { _GROUPS_EXCLUDE_ALIASContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "GROUPS_EXCLUDE_ALIAS"); _GROUPS_EXCLUDE_ALIASReady = true; } return _GROUPS_EXCLUDE_ALIASContent; } }
        private static Java.Lang.String _GROUPS_EXCLUDE_ALIASContent = default;
        private static bool _GROUPS_EXCLUDE_ALIASReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#GROUPS_EXCLUDE_DEFAULT"/>
        /// </summary>
        public static Java.Lang.String GROUPS_EXCLUDE_DEFAULT { get { if (!_GROUPS_EXCLUDE_DEFAULTReady) { _GROUPS_EXCLUDE_DEFAULTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "GROUPS_EXCLUDE_DEFAULT"); _GROUPS_EXCLUDE_DEFAULTReady = true; } return _GROUPS_EXCLUDE_DEFAULTContent; } }
        private static Java.Lang.String _GROUPS_EXCLUDE_DEFAULTContent = default;
        private static bool _GROUPS_EXCLUDE_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#OFFSET_SYNCS_SOURCE_ADMIN_ROLE"/>
        /// </summary>
        public static Java.Lang.String OFFSET_SYNCS_SOURCE_ADMIN_ROLE { get { if (!_OFFSET_SYNCS_SOURCE_ADMIN_ROLEReady) { _OFFSET_SYNCS_SOURCE_ADMIN_ROLEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "OFFSET_SYNCS_SOURCE_ADMIN_ROLE"); _OFFSET_SYNCS_SOURCE_ADMIN_ROLEReady = true; } return _OFFSET_SYNCS_SOURCE_ADMIN_ROLEContent; } }
        private static Java.Lang.String _OFFSET_SYNCS_SOURCE_ADMIN_ROLEContent = default;
        private static bool _OFFSET_SYNCS_SOURCE_ADMIN_ROLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#OFFSET_SYNCS_SOURCE_CONSUMER_ROLE"/>
        /// </summary>
        public static Java.Lang.String OFFSET_SYNCS_SOURCE_CONSUMER_ROLE { get { if (!_OFFSET_SYNCS_SOURCE_CONSUMER_ROLEReady) { _OFFSET_SYNCS_SOURCE_CONSUMER_ROLEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "OFFSET_SYNCS_SOURCE_CONSUMER_ROLE"); _OFFSET_SYNCS_SOURCE_CONSUMER_ROLEReady = true; } return _OFFSET_SYNCS_SOURCE_CONSUMER_ROLEContent; } }
        private static Java.Lang.String _OFFSET_SYNCS_SOURCE_CONSUMER_ROLEContent = default;
        private static bool _OFFSET_SYNCS_SOURCE_CONSUMER_ROLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#OFFSET_SYNCS_TARGET_ADMIN_ROLE"/>
        /// </summary>
        public static Java.Lang.String OFFSET_SYNCS_TARGET_ADMIN_ROLE { get { if (!_OFFSET_SYNCS_TARGET_ADMIN_ROLEReady) { _OFFSET_SYNCS_TARGET_ADMIN_ROLEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "OFFSET_SYNCS_TARGET_ADMIN_ROLE"); _OFFSET_SYNCS_TARGET_ADMIN_ROLEReady = true; } return _OFFSET_SYNCS_TARGET_ADMIN_ROLEContent; } }
        private static Java.Lang.String _OFFSET_SYNCS_TARGET_ADMIN_ROLEContent = default;
        private static bool _OFFSET_SYNCS_TARGET_ADMIN_ROLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#OFFSET_SYNCS_TARGET_CONSUMER_ROLE"/>
        /// </summary>
        public static Java.Lang.String OFFSET_SYNCS_TARGET_CONSUMER_ROLE { get { if (!_OFFSET_SYNCS_TARGET_CONSUMER_ROLEReady) { _OFFSET_SYNCS_TARGET_CONSUMER_ROLEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "OFFSET_SYNCS_TARGET_CONSUMER_ROLE"); _OFFSET_SYNCS_TARGET_CONSUMER_ROLEReady = true; } return _OFFSET_SYNCS_TARGET_CONSUMER_ROLEContent; } }
        private static Java.Lang.String _OFFSET_SYNCS_TARGET_CONSUMER_ROLEContent = default;
        private static bool _OFFSET_SYNCS_TARGET_CONSUMER_ROLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#REFRESH_GROUPS_ENABLED"/>
        /// </summary>
        public static Java.Lang.String REFRESH_GROUPS_ENABLED { get { if (!_REFRESH_GROUPS_ENABLEDReady) { _REFRESH_GROUPS_ENABLEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "REFRESH_GROUPS_ENABLED"); _REFRESH_GROUPS_ENABLEDReady = true; } return _REFRESH_GROUPS_ENABLEDContent; } }
        private static Java.Lang.String _REFRESH_GROUPS_ENABLEDContent = default;
        private static bool _REFRESH_GROUPS_ENABLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#REFRESH_GROUPS_INTERVAL_SECONDS"/>
        /// </summary>
        public static Java.Lang.String REFRESH_GROUPS_INTERVAL_SECONDS { get { if (!_REFRESH_GROUPS_INTERVAL_SECONDSReady) { _REFRESH_GROUPS_INTERVAL_SECONDSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "REFRESH_GROUPS_INTERVAL_SECONDS"); _REFRESH_GROUPS_INTERVAL_SECONDSReady = true; } return _REFRESH_GROUPS_INTERVAL_SECONDSContent; } }
        private static Java.Lang.String _REFRESH_GROUPS_INTERVAL_SECONDSContent = default;
        private static bool _REFRESH_GROUPS_INTERVAL_SECONDSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#SYNC_GROUP_OFFSETS_ENABLED"/>
        /// </summary>
        public static Java.Lang.String SYNC_GROUP_OFFSETS_ENABLED { get { if (!_SYNC_GROUP_OFFSETS_ENABLEDReady) { _SYNC_GROUP_OFFSETS_ENABLEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SYNC_GROUP_OFFSETS_ENABLED"); _SYNC_GROUP_OFFSETS_ENABLEDReady = true; } return _SYNC_GROUP_OFFSETS_ENABLEDContent; } }
        private static Java.Lang.String _SYNC_GROUP_OFFSETS_ENABLEDContent = default;
        private static bool _SYNC_GROUP_OFFSETS_ENABLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#SYNC_GROUP_OFFSETS_INTERVAL_SECONDS"/>
        /// </summary>
        public static Java.Lang.String SYNC_GROUP_OFFSETS_INTERVAL_SECONDS { get { if (!_SYNC_GROUP_OFFSETS_INTERVAL_SECONDSReady) { _SYNC_GROUP_OFFSETS_INTERVAL_SECONDSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SYNC_GROUP_OFFSETS_INTERVAL_SECONDS"); _SYNC_GROUP_OFFSETS_INTERVAL_SECONDSReady = true; } return _SYNC_GROUP_OFFSETS_INTERVAL_SECONDSContent; } }
        private static Java.Lang.String _SYNC_GROUP_OFFSETS_INTERVAL_SECONDSContent = default;
        private static bool _SYNC_GROUP_OFFSETS_INTERVAL_SECONDSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#CONSUMER_POLL_TIMEOUT_MILLIS_DEFAULT"/>
        /// </summary>
        public static long CONSUMER_POLL_TIMEOUT_MILLIS_DEFAULT { get { if (!_CONSUMER_POLL_TIMEOUT_MILLIS_DEFAULTReady) { _CONSUMER_POLL_TIMEOUT_MILLIS_DEFAULTContent = SGetField<long>(LocalBridgeClazz, "CONSUMER_POLL_TIMEOUT_MILLIS_DEFAULT"); _CONSUMER_POLL_TIMEOUT_MILLIS_DEFAULTReady = true; } return _CONSUMER_POLL_TIMEOUT_MILLIS_DEFAULTContent; } }
        private static long _CONSUMER_POLL_TIMEOUT_MILLIS_DEFAULTContent = default;
        private static bool _CONSUMER_POLL_TIMEOUT_MILLIS_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#EMIT_CHECKPOINTS_INTERVAL_SECONDS_DEFAULT"/>
        /// </summary>
        public static long EMIT_CHECKPOINTS_INTERVAL_SECONDS_DEFAULT { get { if (!_EMIT_CHECKPOINTS_INTERVAL_SECONDS_DEFAULTReady) { _EMIT_CHECKPOINTS_INTERVAL_SECONDS_DEFAULTContent = SGetField<long>(LocalBridgeClazz, "EMIT_CHECKPOINTS_INTERVAL_SECONDS_DEFAULT"); _EMIT_CHECKPOINTS_INTERVAL_SECONDS_DEFAULTReady = true; } return _EMIT_CHECKPOINTS_INTERVAL_SECONDS_DEFAULTContent; } }
        private static long _EMIT_CHECKPOINTS_INTERVAL_SECONDS_DEFAULTContent = default;
        private static bool _EMIT_CHECKPOINTS_INTERVAL_SECONDS_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#REFRESH_GROUPS_INTERVAL_SECONDS_DEFAULT"/>
        /// </summary>
        public static long REFRESH_GROUPS_INTERVAL_SECONDS_DEFAULT { get { if (!_REFRESH_GROUPS_INTERVAL_SECONDS_DEFAULTReady) { _REFRESH_GROUPS_INTERVAL_SECONDS_DEFAULTContent = SGetField<long>(LocalBridgeClazz, "REFRESH_GROUPS_INTERVAL_SECONDS_DEFAULT"); _REFRESH_GROUPS_INTERVAL_SECONDS_DEFAULTReady = true; } return _REFRESH_GROUPS_INTERVAL_SECONDS_DEFAULTContent; } }
        private static long _REFRESH_GROUPS_INTERVAL_SECONDS_DEFAULTContent = default;
        private static bool _REFRESH_GROUPS_INTERVAL_SECONDS_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#SYNC_GROUP_OFFSETS_INTERVAL_SECONDS_DEFAULT"/>
        /// </summary>
        public static long SYNC_GROUP_OFFSETS_INTERVAL_SECONDS_DEFAULT { get { if (!_SYNC_GROUP_OFFSETS_INTERVAL_SECONDS_DEFAULTReady) { _SYNC_GROUP_OFFSETS_INTERVAL_SECONDS_DEFAULTContent = SGetField<long>(LocalBridgeClazz, "SYNC_GROUP_OFFSETS_INTERVAL_SECONDS_DEFAULT"); _SYNC_GROUP_OFFSETS_INTERVAL_SECONDS_DEFAULTReady = true; } return _SYNC_GROUP_OFFSETS_INTERVAL_SECONDS_DEFAULTContent; } }
        private static long _SYNC_GROUP_OFFSETS_INTERVAL_SECONDS_DEFAULTContent = default;
        private static bool _SYNC_GROUP_OFFSETS_INTERVAL_SECONDS_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DEFAULT"/>
        /// </summary>
        public static short CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DEFAULT { get { if (!_CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DEFAULTReady) { _CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DEFAULTContent = SGetField<short>(LocalBridgeClazz, "CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DEFAULT"); _CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DEFAULTReady = true; } return _CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DEFAULTContent; } }
        private static short _CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DEFAULTContent = default;
        private static bool _CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DEFAULTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#validate-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public static Java.Util.Map<Java.Lang.String, Java.Lang.String> Validate(Java.Util.Map<Java.Lang.String, Java.Lang.String> arg0)
        {
            return SExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Lang.String>>(LocalBridgeClazz, "validate", "(Ljava/util/Map;)Ljava/util/Map;", arg0);
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