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
*  using connect-mirror-3.5.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Mirror
{
    #region MirrorCheckpointConfig
    public partial class MirrorCheckpointConfig
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.5.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#org.apache.kafka.connect.mirror.MirrorCheckpointConfig(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public MirrorCheckpointConfig(Java.Util.Map<string, string> arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.5.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#org.apache.kafka.connect.mirror.MirrorCheckpointConfig(org.apache.kafka.common.config.ConfigDef,java.util.Map)"/>
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.5.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#EMIT_CHECKPOINTS_ENABLED_DEFAULT"/>
        /// </summary>
        public static bool EMIT_CHECKPOINTS_ENABLED_DEFAULT { get { return SGetField<bool>(LocalBridgeClazz, "EMIT_CHECKPOINTS_ENABLED_DEFAULT"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.5.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#REFRESH_GROUPS_ENABLED_DEFAULT"/>
        /// </summary>
        public static bool REFRESH_GROUPS_ENABLED_DEFAULT { get { return SGetField<bool>(LocalBridgeClazz, "REFRESH_GROUPS_ENABLED_DEFAULT"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.5.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#SYNC_GROUP_OFFSETS_ENABLED_DEFAULT"/>
        /// </summary>
        public static bool SYNC_GROUP_OFFSETS_ENABLED_DEFAULT { get { return SGetField<bool>(LocalBridgeClazz, "SYNC_GROUP_OFFSETS_ENABLED_DEFAULT"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.5.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#GROUP_FILTER_CLASS_DEFAULT"/>
        /// </summary>
        public static Java.Lang.Class GROUP_FILTER_CLASS_DEFAULT { get { return SGetField<Java.Lang.Class>(LocalBridgeClazz, "GROUP_FILTER_CLASS_DEFAULT"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.5.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#CHECKPOINTS_TOPIC_REPLICATION_FACTOR"/>
        /// </summary>
        public static string CHECKPOINTS_TOPIC_REPLICATION_FACTOR { get { return SGetField<string>(LocalBridgeClazz, "CHECKPOINTS_TOPIC_REPLICATION_FACTOR"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.5.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DOC"/>
        /// </summary>
        public static string CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DOC { get { return SGetField<string>(LocalBridgeClazz, "CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.5.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#CONSUMER_POLL_TIMEOUT_MILLIS"/>
        /// </summary>
        public static string CONSUMER_POLL_TIMEOUT_MILLIS { get { return SGetField<string>(LocalBridgeClazz, "CONSUMER_POLL_TIMEOUT_MILLIS"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.5.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#EMIT_CHECKPOINTS_ENABLED"/>
        /// </summary>
        public static string EMIT_CHECKPOINTS_ENABLED { get { return SGetField<string>(LocalBridgeClazz, "EMIT_CHECKPOINTS_ENABLED"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.5.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#EMIT_CHECKPOINTS_INTERVAL_SECONDS"/>
        /// </summary>
        public static string EMIT_CHECKPOINTS_INTERVAL_SECONDS { get { return SGetField<string>(LocalBridgeClazz, "EMIT_CHECKPOINTS_INTERVAL_SECONDS"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.5.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#GROUP_FILTER_CLASS"/>
        /// </summary>
        public static string GROUP_FILTER_CLASS { get { return SGetField<string>(LocalBridgeClazz, "GROUP_FILTER_CLASS"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.5.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#GROUPS"/>
        /// </summary>
        public static string GROUPS { get { return SGetField<string>(LocalBridgeClazz, "GROUPS"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.5.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#GROUPS_DEFAULT"/>
        /// </summary>
        public static string GROUPS_DEFAULT { get { return SGetField<string>(LocalBridgeClazz, "GROUPS_DEFAULT"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.5.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#GROUPS_EXCLUDE"/>
        /// </summary>
        public static string GROUPS_EXCLUDE { get { return SGetField<string>(LocalBridgeClazz, "GROUPS_EXCLUDE"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.5.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#GROUPS_EXCLUDE_ALIAS"/>
        /// </summary>
        public static string GROUPS_EXCLUDE_ALIAS { get { return SGetField<string>(LocalBridgeClazz, "GROUPS_EXCLUDE_ALIAS"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.5.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#GROUPS_EXCLUDE_DEFAULT"/>
        /// </summary>
        public static string GROUPS_EXCLUDE_DEFAULT { get { return SGetField<string>(LocalBridgeClazz, "GROUPS_EXCLUDE_DEFAULT"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.5.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#OFFSET_SYNCS_SOURCE_ADMIN_ROLE"/>
        /// </summary>
        public static string OFFSET_SYNCS_SOURCE_ADMIN_ROLE { get { return SGetField<string>(LocalBridgeClazz, "OFFSET_SYNCS_SOURCE_ADMIN_ROLE"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.5.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#OFFSET_SYNCS_SOURCE_CONSUMER_ROLE"/>
        /// </summary>
        public static string OFFSET_SYNCS_SOURCE_CONSUMER_ROLE { get { return SGetField<string>(LocalBridgeClazz, "OFFSET_SYNCS_SOURCE_CONSUMER_ROLE"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.5.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#OFFSET_SYNCS_TARGET_ADMIN_ROLE"/>
        /// </summary>
        public static string OFFSET_SYNCS_TARGET_ADMIN_ROLE { get { return SGetField<string>(LocalBridgeClazz, "OFFSET_SYNCS_TARGET_ADMIN_ROLE"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.5.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#OFFSET_SYNCS_TARGET_CONSUMER_ROLE"/>
        /// </summary>
        public static string OFFSET_SYNCS_TARGET_CONSUMER_ROLE { get { return SGetField<string>(LocalBridgeClazz, "OFFSET_SYNCS_TARGET_CONSUMER_ROLE"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.5.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#REFRESH_GROUPS_ENABLED"/>
        /// </summary>
        public static string REFRESH_GROUPS_ENABLED { get { return SGetField<string>(LocalBridgeClazz, "REFRESH_GROUPS_ENABLED"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.5.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#REFRESH_GROUPS_INTERVAL_SECONDS"/>
        /// </summary>
        public static string REFRESH_GROUPS_INTERVAL_SECONDS { get { return SGetField<string>(LocalBridgeClazz, "REFRESH_GROUPS_INTERVAL_SECONDS"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.5.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#SYNC_GROUP_OFFSETS_ENABLED"/>
        /// </summary>
        public static string SYNC_GROUP_OFFSETS_ENABLED { get { return SGetField<string>(LocalBridgeClazz, "SYNC_GROUP_OFFSETS_ENABLED"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.5.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#SYNC_GROUP_OFFSETS_INTERVAL_SECONDS"/>
        /// </summary>
        public static string SYNC_GROUP_OFFSETS_INTERVAL_SECONDS { get { return SGetField<string>(LocalBridgeClazz, "SYNC_GROUP_OFFSETS_INTERVAL_SECONDS"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.5.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#CONSUMER_POLL_TIMEOUT_MILLIS_DEFAULT"/>
        /// </summary>
        public static long CONSUMER_POLL_TIMEOUT_MILLIS_DEFAULT { get { return SGetField<long>(LocalBridgeClazz, "CONSUMER_POLL_TIMEOUT_MILLIS_DEFAULT"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.5.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#EMIT_CHECKPOINTS_INTERVAL_SECONDS_DEFAULT"/>
        /// </summary>
        public static long EMIT_CHECKPOINTS_INTERVAL_SECONDS_DEFAULT { get { return SGetField<long>(LocalBridgeClazz, "EMIT_CHECKPOINTS_INTERVAL_SECONDS_DEFAULT"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.5.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#REFRESH_GROUPS_INTERVAL_SECONDS_DEFAULT"/>
        /// </summary>
        public static long REFRESH_GROUPS_INTERVAL_SECONDS_DEFAULT { get { return SGetField<long>(LocalBridgeClazz, "REFRESH_GROUPS_INTERVAL_SECONDS_DEFAULT"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.5.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#SYNC_GROUP_OFFSETS_INTERVAL_SECONDS_DEFAULT"/>
        /// </summary>
        public static long SYNC_GROUP_OFFSETS_INTERVAL_SECONDS_DEFAULT { get { return SGetField<long>(LocalBridgeClazz, "SYNC_GROUP_OFFSETS_INTERVAL_SECONDS_DEFAULT"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.5.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DEFAULT"/>
        /// </summary>
        public static short CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DEFAULT { get { return SGetField<short>(LocalBridgeClazz, "CHECKPOINTS_TOPIC_REPLICATION_FACTOR_DEFAULT"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.5.0/org/apache/kafka/connect/mirror/MirrorCheckpointConfig.html#main-java.lang.String[]-"/>
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