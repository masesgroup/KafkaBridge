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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using connect-mirror-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Mirror
{
    #region MirrorHeartbeatConfig declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorHeartbeatConfig.html"/>
    /// </summary>
    public partial class MirrorHeartbeatConfig : Org.Apache.Kafka.Connect.Mirror.MirrorConnectorConfig, MASES.JCOBridge.C2JBridge.IJVMBridgeMain
    {
        const string _bridgeClassName = "org.apache.kafka.connect.mirror.MirrorHeartbeatConfig";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public MirrorHeartbeatConfig() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public MirrorHeartbeatConfig(params object[] args) : base(args) { }

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

    #region MirrorHeartbeatConfig implementation
    public partial class MirrorHeartbeatConfig
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorHeartbeatConfig.html#org.apache.kafka.connect.mirror.MirrorHeartbeatConfig(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public MirrorHeartbeatConfig(Java.Util.Map<Java.Lang.String, Java.Lang.String> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorHeartbeatConfig.html#EMIT_HEARTBEATS_ENABLED_DEFAULT"/>
        /// </summary>
        public static bool EMIT_HEARTBEATS_ENABLED_DEFAULT { get { if (!_EMIT_HEARTBEATS_ENABLED_DEFAULTReady) { _EMIT_HEARTBEATS_ENABLED_DEFAULTContent = SGetField<bool>(LocalBridgeClazz, "EMIT_HEARTBEATS_ENABLED_DEFAULT"); _EMIT_HEARTBEATS_ENABLED_DEFAULTReady = true; } return _EMIT_HEARTBEATS_ENABLED_DEFAULTContent; } }
        private static bool _EMIT_HEARTBEATS_ENABLED_DEFAULTContent = default;
        private static bool _EMIT_HEARTBEATS_ENABLED_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorHeartbeatConfig.html#EMIT_HEARTBEATS_ENABLED"/>
        /// </summary>
        public static Java.Lang.String EMIT_HEARTBEATS_ENABLED { get { if (!_EMIT_HEARTBEATS_ENABLEDReady) { _EMIT_HEARTBEATS_ENABLEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EMIT_HEARTBEATS_ENABLED"); _EMIT_HEARTBEATS_ENABLEDReady = true; } return _EMIT_HEARTBEATS_ENABLEDContent; } }
        private static Java.Lang.String _EMIT_HEARTBEATS_ENABLEDContent = default;
        private static bool _EMIT_HEARTBEATS_ENABLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorHeartbeatConfig.html#EMIT_HEARTBEATS_INTERVAL_SECONDS"/>
        /// </summary>
        public static Java.Lang.String EMIT_HEARTBEATS_INTERVAL_SECONDS { get { if (!_EMIT_HEARTBEATS_INTERVAL_SECONDSReady) { _EMIT_HEARTBEATS_INTERVAL_SECONDSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EMIT_HEARTBEATS_INTERVAL_SECONDS"); _EMIT_HEARTBEATS_INTERVAL_SECONDSReady = true; } return _EMIT_HEARTBEATS_INTERVAL_SECONDSContent; } }
        private static Java.Lang.String _EMIT_HEARTBEATS_INTERVAL_SECONDSContent = default;
        private static bool _EMIT_HEARTBEATS_INTERVAL_SECONDSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorHeartbeatConfig.html#HEARTBEATS_TOPIC_REPLICATION_FACTOR"/>
        /// </summary>
        public static Java.Lang.String HEARTBEATS_TOPIC_REPLICATION_FACTOR { get { if (!_HEARTBEATS_TOPIC_REPLICATION_FACTORReady) { _HEARTBEATS_TOPIC_REPLICATION_FACTORContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "HEARTBEATS_TOPIC_REPLICATION_FACTOR"); _HEARTBEATS_TOPIC_REPLICATION_FACTORReady = true; } return _HEARTBEATS_TOPIC_REPLICATION_FACTORContent; } }
        private static Java.Lang.String _HEARTBEATS_TOPIC_REPLICATION_FACTORContent = default;
        private static bool _HEARTBEATS_TOPIC_REPLICATION_FACTORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorHeartbeatConfig.html#HEARTBEATS_TOPIC_REPLICATION_FACTOR_DOC"/>
        /// </summary>
        public static Java.Lang.String HEARTBEATS_TOPIC_REPLICATION_FACTOR_DOC { get { if (!_HEARTBEATS_TOPIC_REPLICATION_FACTOR_DOCReady) { _HEARTBEATS_TOPIC_REPLICATION_FACTOR_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "HEARTBEATS_TOPIC_REPLICATION_FACTOR_DOC"); _HEARTBEATS_TOPIC_REPLICATION_FACTOR_DOCReady = true; } return _HEARTBEATS_TOPIC_REPLICATION_FACTOR_DOCContent; } }
        private static Java.Lang.String _HEARTBEATS_TOPIC_REPLICATION_FACTOR_DOCContent = default;
        private static bool _HEARTBEATS_TOPIC_REPLICATION_FACTOR_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorHeartbeatConfig.html#EMIT_HEARTBEATS_INTERVAL_SECONDS_DEFAULT"/>
        /// </summary>
        public static long EMIT_HEARTBEATS_INTERVAL_SECONDS_DEFAULT { get { if (!_EMIT_HEARTBEATS_INTERVAL_SECONDS_DEFAULTReady) { _EMIT_HEARTBEATS_INTERVAL_SECONDS_DEFAULTContent = SGetField<long>(LocalBridgeClazz, "EMIT_HEARTBEATS_INTERVAL_SECONDS_DEFAULT"); _EMIT_HEARTBEATS_INTERVAL_SECONDS_DEFAULTReady = true; } return _EMIT_HEARTBEATS_INTERVAL_SECONDS_DEFAULTContent; } }
        private static long _EMIT_HEARTBEATS_INTERVAL_SECONDS_DEFAULTContent = default;
        private static bool _EMIT_HEARTBEATS_INTERVAL_SECONDS_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorHeartbeatConfig.html#HEARTBEATS_TOPIC_REPLICATION_FACTOR_DEFAULT"/>
        /// </summary>
        public static short HEARTBEATS_TOPIC_REPLICATION_FACTOR_DEFAULT { get { if (!_HEARTBEATS_TOPIC_REPLICATION_FACTOR_DEFAULTReady) { _HEARTBEATS_TOPIC_REPLICATION_FACTOR_DEFAULTContent = SGetField<short>(LocalBridgeClazz, "HEARTBEATS_TOPIC_REPLICATION_FACTOR_DEFAULT"); _HEARTBEATS_TOPIC_REPLICATION_FACTOR_DEFAULTReady = true; } return _HEARTBEATS_TOPIC_REPLICATION_FACTOR_DEFAULTContent; } }
        private static short _HEARTBEATS_TOPIC_REPLICATION_FACTOR_DEFAULTContent = default;
        private static bool _HEARTBEATS_TOPIC_REPLICATION_FACTOR_DEFAULTReady = false; // this is used because in case of generics 

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