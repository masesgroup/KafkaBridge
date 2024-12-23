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
*  using kafka-raft-3.9.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Raft
{
    #region QuorumConfig declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.html"/>
    /// </summary>
    public partial class QuorumConfig : MASES.JCOBridge.C2JBridge.JVMBridgeBase<QuorumConfig>
    {
        const string _bridgeClassName = "org.apache.kafka.raft.QuorumConfig";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public QuorumConfig() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public QuorumConfig(params object[] args) : base(args) { }

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
        #region ControllerQuorumBootstrapServersValidator declaration
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.ControllerQuorumBootstrapServersValidator.html"/>
        /// </summary>
        public partial class ControllerQuorumBootstrapServersValidator : Org.Apache.Kafka.Common.Config.ConfigDef.Validator
        {
            const string _bridgeClassName = "org.apache.kafka.raft.QuorumConfig$ControllerQuorumBootstrapServersValidator";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public ControllerQuorumBootstrapServersValidator() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public ControllerQuorumBootstrapServersValidator(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

        #region ControllerQuorumVotersValidator declaration
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.ControllerQuorumVotersValidator.html"/>
        /// </summary>
        public partial class ControllerQuorumVotersValidator : Org.Apache.Kafka.Common.Config.ConfigDef.Validator
        {
            const string _bridgeClassName = "org.apache.kafka.raft.QuorumConfig$ControllerQuorumVotersValidator";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public ControllerQuorumVotersValidator() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public ControllerQuorumVotersValidator(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region QuorumConfig implementation
    public partial class QuorumConfig
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.html#org.apache.kafka.raft.QuorumConfig(int,int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        public QuorumConfig(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.html#org.apache.kafka.raft.QuorumConfig(org.apache.kafka.common.config.AbstractConfig)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Config.AbstractConfig"/></param>
        public QuorumConfig(Org.Apache.Kafka.Common.Config.AbstractConfig arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.html#DEFAULT_QUORUM_ELECTION_BACKOFF_MAX_MS"/>
        /// </summary>
        public static int DEFAULT_QUORUM_ELECTION_BACKOFF_MAX_MS { get { if (!_DEFAULT_QUORUM_ELECTION_BACKOFF_MAX_MSReady) { _DEFAULT_QUORUM_ELECTION_BACKOFF_MAX_MSContent = SGetField<int>(LocalBridgeClazz, "DEFAULT_QUORUM_ELECTION_BACKOFF_MAX_MS"); _DEFAULT_QUORUM_ELECTION_BACKOFF_MAX_MSReady = true; } return _DEFAULT_QUORUM_ELECTION_BACKOFF_MAX_MSContent; } }
        private static int _DEFAULT_QUORUM_ELECTION_BACKOFF_MAX_MSContent = default;
        private static bool _DEFAULT_QUORUM_ELECTION_BACKOFF_MAX_MSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.html#DEFAULT_QUORUM_ELECTION_TIMEOUT_MS"/>
        /// </summary>
        public static int DEFAULT_QUORUM_ELECTION_TIMEOUT_MS { get { if (!_DEFAULT_QUORUM_ELECTION_TIMEOUT_MSReady) { _DEFAULT_QUORUM_ELECTION_TIMEOUT_MSContent = SGetField<int>(LocalBridgeClazz, "DEFAULT_QUORUM_ELECTION_TIMEOUT_MS"); _DEFAULT_QUORUM_ELECTION_TIMEOUT_MSReady = true; } return _DEFAULT_QUORUM_ELECTION_TIMEOUT_MSContent; } }
        private static int _DEFAULT_QUORUM_ELECTION_TIMEOUT_MSContent = default;
        private static bool _DEFAULT_QUORUM_ELECTION_TIMEOUT_MSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.html#DEFAULT_QUORUM_FETCH_TIMEOUT_MS"/>
        /// </summary>
        public static int DEFAULT_QUORUM_FETCH_TIMEOUT_MS { get { if (!_DEFAULT_QUORUM_FETCH_TIMEOUT_MSReady) { _DEFAULT_QUORUM_FETCH_TIMEOUT_MSContent = SGetField<int>(LocalBridgeClazz, "DEFAULT_QUORUM_FETCH_TIMEOUT_MS"); _DEFAULT_QUORUM_FETCH_TIMEOUT_MSReady = true; } return _DEFAULT_QUORUM_FETCH_TIMEOUT_MSContent; } }
        private static int _DEFAULT_QUORUM_FETCH_TIMEOUT_MSContent = default;
        private static bool _DEFAULT_QUORUM_FETCH_TIMEOUT_MSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.html#DEFAULT_QUORUM_LINGER_MS"/>
        /// </summary>
        public static int DEFAULT_QUORUM_LINGER_MS { get { if (!_DEFAULT_QUORUM_LINGER_MSReady) { _DEFAULT_QUORUM_LINGER_MSContent = SGetField<int>(LocalBridgeClazz, "DEFAULT_QUORUM_LINGER_MS"); _DEFAULT_QUORUM_LINGER_MSReady = true; } return _DEFAULT_QUORUM_LINGER_MSContent; } }
        private static int _DEFAULT_QUORUM_LINGER_MSContent = default;
        private static bool _DEFAULT_QUORUM_LINGER_MSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.html#DEFAULT_QUORUM_REQUEST_TIMEOUT_MS"/>
        /// </summary>
        public static int DEFAULT_QUORUM_REQUEST_TIMEOUT_MS { get { if (!_DEFAULT_QUORUM_REQUEST_TIMEOUT_MSReady) { _DEFAULT_QUORUM_REQUEST_TIMEOUT_MSContent = SGetField<int>(LocalBridgeClazz, "DEFAULT_QUORUM_REQUEST_TIMEOUT_MS"); _DEFAULT_QUORUM_REQUEST_TIMEOUT_MSReady = true; } return _DEFAULT_QUORUM_REQUEST_TIMEOUT_MSContent; } }
        private static int _DEFAULT_QUORUM_REQUEST_TIMEOUT_MSContent = default;
        private static bool _DEFAULT_QUORUM_REQUEST_TIMEOUT_MSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.html#DEFAULT_QUORUM_RETRY_BACKOFF_MS"/>
        /// </summary>
        public static int DEFAULT_QUORUM_RETRY_BACKOFF_MS { get { if (!_DEFAULT_QUORUM_RETRY_BACKOFF_MSReady) { _DEFAULT_QUORUM_RETRY_BACKOFF_MSContent = SGetField<int>(LocalBridgeClazz, "DEFAULT_QUORUM_RETRY_BACKOFF_MS"); _DEFAULT_QUORUM_RETRY_BACKOFF_MSReady = true; } return _DEFAULT_QUORUM_RETRY_BACKOFF_MSContent; } }
        private static int _DEFAULT_QUORUM_RETRY_BACKOFF_MSContent = default;
        private static bool _DEFAULT_QUORUM_RETRY_BACKOFF_MSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.html#NON_ROUTABLE_HOST"/>
        /// </summary>
        public static Java.Lang.String NON_ROUTABLE_HOST { get { if (!_NON_ROUTABLE_HOSTReady) { _NON_ROUTABLE_HOSTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "NON_ROUTABLE_HOST"); _NON_ROUTABLE_HOSTReady = true; } return _NON_ROUTABLE_HOSTContent; } }
        private static Java.Lang.String _NON_ROUTABLE_HOSTContent = default;
        private static bool _NON_ROUTABLE_HOSTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.html#QUORUM_BOOTSTRAP_SERVERS_CONFIG"/>
        /// </summary>
        public static Java.Lang.String QUORUM_BOOTSTRAP_SERVERS_CONFIG { get { if (!_QUORUM_BOOTSTRAP_SERVERS_CONFIGReady) { _QUORUM_BOOTSTRAP_SERVERS_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "QUORUM_BOOTSTRAP_SERVERS_CONFIG"); _QUORUM_BOOTSTRAP_SERVERS_CONFIGReady = true; } return _QUORUM_BOOTSTRAP_SERVERS_CONFIGContent; } }
        private static Java.Lang.String _QUORUM_BOOTSTRAP_SERVERS_CONFIGContent = default;
        private static bool _QUORUM_BOOTSTRAP_SERVERS_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.html#QUORUM_BOOTSTRAP_SERVERS_DOC"/>
        /// </summary>
        public static Java.Lang.String QUORUM_BOOTSTRAP_SERVERS_DOC { get { if (!_QUORUM_BOOTSTRAP_SERVERS_DOCReady) { _QUORUM_BOOTSTRAP_SERVERS_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "QUORUM_BOOTSTRAP_SERVERS_DOC"); _QUORUM_BOOTSTRAP_SERVERS_DOCReady = true; } return _QUORUM_BOOTSTRAP_SERVERS_DOCContent; } }
        private static Java.Lang.String _QUORUM_BOOTSTRAP_SERVERS_DOCContent = default;
        private static bool _QUORUM_BOOTSTRAP_SERVERS_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.html#QUORUM_ELECTION_BACKOFF_MAX_MS_CONFIG"/>
        /// </summary>
        public static Java.Lang.String QUORUM_ELECTION_BACKOFF_MAX_MS_CONFIG { get { if (!_QUORUM_ELECTION_BACKOFF_MAX_MS_CONFIGReady) { _QUORUM_ELECTION_BACKOFF_MAX_MS_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "QUORUM_ELECTION_BACKOFF_MAX_MS_CONFIG"); _QUORUM_ELECTION_BACKOFF_MAX_MS_CONFIGReady = true; } return _QUORUM_ELECTION_BACKOFF_MAX_MS_CONFIGContent; } }
        private static Java.Lang.String _QUORUM_ELECTION_BACKOFF_MAX_MS_CONFIGContent = default;
        private static bool _QUORUM_ELECTION_BACKOFF_MAX_MS_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.html#QUORUM_ELECTION_BACKOFF_MAX_MS_DOC"/>
        /// </summary>
        public static Java.Lang.String QUORUM_ELECTION_BACKOFF_MAX_MS_DOC { get { if (!_QUORUM_ELECTION_BACKOFF_MAX_MS_DOCReady) { _QUORUM_ELECTION_BACKOFF_MAX_MS_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "QUORUM_ELECTION_BACKOFF_MAX_MS_DOC"); _QUORUM_ELECTION_BACKOFF_MAX_MS_DOCReady = true; } return _QUORUM_ELECTION_BACKOFF_MAX_MS_DOCContent; } }
        private static Java.Lang.String _QUORUM_ELECTION_BACKOFF_MAX_MS_DOCContent = default;
        private static bool _QUORUM_ELECTION_BACKOFF_MAX_MS_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.html#QUORUM_ELECTION_TIMEOUT_MS_CONFIG"/>
        /// </summary>
        public static Java.Lang.String QUORUM_ELECTION_TIMEOUT_MS_CONFIG { get { if (!_QUORUM_ELECTION_TIMEOUT_MS_CONFIGReady) { _QUORUM_ELECTION_TIMEOUT_MS_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "QUORUM_ELECTION_TIMEOUT_MS_CONFIG"); _QUORUM_ELECTION_TIMEOUT_MS_CONFIGReady = true; } return _QUORUM_ELECTION_TIMEOUT_MS_CONFIGContent; } }
        private static Java.Lang.String _QUORUM_ELECTION_TIMEOUT_MS_CONFIGContent = default;
        private static bool _QUORUM_ELECTION_TIMEOUT_MS_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.html#QUORUM_ELECTION_TIMEOUT_MS_DOC"/>
        /// </summary>
        public static Java.Lang.String QUORUM_ELECTION_TIMEOUT_MS_DOC { get { if (!_QUORUM_ELECTION_TIMEOUT_MS_DOCReady) { _QUORUM_ELECTION_TIMEOUT_MS_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "QUORUM_ELECTION_TIMEOUT_MS_DOC"); _QUORUM_ELECTION_TIMEOUT_MS_DOCReady = true; } return _QUORUM_ELECTION_TIMEOUT_MS_DOCContent; } }
        private static Java.Lang.String _QUORUM_ELECTION_TIMEOUT_MS_DOCContent = default;
        private static bool _QUORUM_ELECTION_TIMEOUT_MS_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.html#QUORUM_FETCH_TIMEOUT_MS_CONFIG"/>
        /// </summary>
        public static Java.Lang.String QUORUM_FETCH_TIMEOUT_MS_CONFIG { get { if (!_QUORUM_FETCH_TIMEOUT_MS_CONFIGReady) { _QUORUM_FETCH_TIMEOUT_MS_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "QUORUM_FETCH_TIMEOUT_MS_CONFIG"); _QUORUM_FETCH_TIMEOUT_MS_CONFIGReady = true; } return _QUORUM_FETCH_TIMEOUT_MS_CONFIGContent; } }
        private static Java.Lang.String _QUORUM_FETCH_TIMEOUT_MS_CONFIGContent = default;
        private static bool _QUORUM_FETCH_TIMEOUT_MS_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.html#QUORUM_FETCH_TIMEOUT_MS_DOC"/>
        /// </summary>
        public static Java.Lang.String QUORUM_FETCH_TIMEOUT_MS_DOC { get { if (!_QUORUM_FETCH_TIMEOUT_MS_DOCReady) { _QUORUM_FETCH_TIMEOUT_MS_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "QUORUM_FETCH_TIMEOUT_MS_DOC"); _QUORUM_FETCH_TIMEOUT_MS_DOCReady = true; } return _QUORUM_FETCH_TIMEOUT_MS_DOCContent; } }
        private static Java.Lang.String _QUORUM_FETCH_TIMEOUT_MS_DOCContent = default;
        private static bool _QUORUM_FETCH_TIMEOUT_MS_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.html#QUORUM_LINGER_MS_CONFIG"/>
        /// </summary>
        public static Java.Lang.String QUORUM_LINGER_MS_CONFIG { get { if (!_QUORUM_LINGER_MS_CONFIGReady) { _QUORUM_LINGER_MS_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "QUORUM_LINGER_MS_CONFIG"); _QUORUM_LINGER_MS_CONFIGReady = true; } return _QUORUM_LINGER_MS_CONFIGContent; } }
        private static Java.Lang.String _QUORUM_LINGER_MS_CONFIGContent = default;
        private static bool _QUORUM_LINGER_MS_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.html#QUORUM_LINGER_MS_DOC"/>
        /// </summary>
        public static Java.Lang.String QUORUM_LINGER_MS_DOC { get { if (!_QUORUM_LINGER_MS_DOCReady) { _QUORUM_LINGER_MS_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "QUORUM_LINGER_MS_DOC"); _QUORUM_LINGER_MS_DOCReady = true; } return _QUORUM_LINGER_MS_DOCContent; } }
        private static Java.Lang.String _QUORUM_LINGER_MS_DOCContent = default;
        private static bool _QUORUM_LINGER_MS_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.html#QUORUM_REQUEST_TIMEOUT_MS_CONFIG"/>
        /// </summary>
        public static Java.Lang.String QUORUM_REQUEST_TIMEOUT_MS_CONFIG { get { if (!_QUORUM_REQUEST_TIMEOUT_MS_CONFIGReady) { _QUORUM_REQUEST_TIMEOUT_MS_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "QUORUM_REQUEST_TIMEOUT_MS_CONFIG"); _QUORUM_REQUEST_TIMEOUT_MS_CONFIGReady = true; } return _QUORUM_REQUEST_TIMEOUT_MS_CONFIGContent; } }
        private static Java.Lang.String _QUORUM_REQUEST_TIMEOUT_MS_CONFIGContent = default;
        private static bool _QUORUM_REQUEST_TIMEOUT_MS_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.html#QUORUM_REQUEST_TIMEOUT_MS_DOC"/>
        /// </summary>
        public static Java.Lang.String QUORUM_REQUEST_TIMEOUT_MS_DOC { get { if (!_QUORUM_REQUEST_TIMEOUT_MS_DOCReady) { _QUORUM_REQUEST_TIMEOUT_MS_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "QUORUM_REQUEST_TIMEOUT_MS_DOC"); _QUORUM_REQUEST_TIMEOUT_MS_DOCReady = true; } return _QUORUM_REQUEST_TIMEOUT_MS_DOCContent; } }
        private static Java.Lang.String _QUORUM_REQUEST_TIMEOUT_MS_DOCContent = default;
        private static bool _QUORUM_REQUEST_TIMEOUT_MS_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.html#QUORUM_RETRY_BACKOFF_MS_CONFIG"/>
        /// </summary>
        public static Java.Lang.String QUORUM_RETRY_BACKOFF_MS_CONFIG { get { if (!_QUORUM_RETRY_BACKOFF_MS_CONFIGReady) { _QUORUM_RETRY_BACKOFF_MS_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "QUORUM_RETRY_BACKOFF_MS_CONFIG"); _QUORUM_RETRY_BACKOFF_MS_CONFIGReady = true; } return _QUORUM_RETRY_BACKOFF_MS_CONFIGContent; } }
        private static Java.Lang.String _QUORUM_RETRY_BACKOFF_MS_CONFIGContent = default;
        private static bool _QUORUM_RETRY_BACKOFF_MS_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.html#QUORUM_RETRY_BACKOFF_MS_DOC"/>
        /// </summary>
        public static Java.Lang.String QUORUM_RETRY_BACKOFF_MS_DOC { get { if (!_QUORUM_RETRY_BACKOFF_MS_DOCReady) { _QUORUM_RETRY_BACKOFF_MS_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "QUORUM_RETRY_BACKOFF_MS_DOC"); _QUORUM_RETRY_BACKOFF_MS_DOCReady = true; } return _QUORUM_RETRY_BACKOFF_MS_DOCContent; } }
        private static Java.Lang.String _QUORUM_RETRY_BACKOFF_MS_DOCContent = default;
        private static bool _QUORUM_RETRY_BACKOFF_MS_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.html#QUORUM_VOTERS_CONFIG"/>
        /// </summary>
        public static Java.Lang.String QUORUM_VOTERS_CONFIG { get { if (!_QUORUM_VOTERS_CONFIGReady) { _QUORUM_VOTERS_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "QUORUM_VOTERS_CONFIG"); _QUORUM_VOTERS_CONFIGReady = true; } return _QUORUM_VOTERS_CONFIGContent; } }
        private static Java.Lang.String _QUORUM_VOTERS_CONFIGContent = default;
        private static bool _QUORUM_VOTERS_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.html#QUORUM_VOTERS_DOC"/>
        /// </summary>
        public static Java.Lang.String QUORUM_VOTERS_DOC { get { if (!_QUORUM_VOTERS_DOCReady) { _QUORUM_VOTERS_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "QUORUM_VOTERS_DOC"); _QUORUM_VOTERS_DOCReady = true; } return _QUORUM_VOTERS_DOCContent; } }
        private static Java.Lang.String _QUORUM_VOTERS_DOCContent = default;
        private static bool _QUORUM_VOTERS_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.html#DEFAULT_QUORUM_BOOTSTRAP_SERVERS"/>
        /// </summary>
        public static Java.Util.List DEFAULT_QUORUM_BOOTSTRAP_SERVERS { get { if (!_DEFAULT_QUORUM_BOOTSTRAP_SERVERSReady) { _DEFAULT_QUORUM_BOOTSTRAP_SERVERSContent = SGetField<Java.Util.List>(LocalBridgeClazz, "DEFAULT_QUORUM_BOOTSTRAP_SERVERS"); _DEFAULT_QUORUM_BOOTSTRAP_SERVERSReady = true; } return _DEFAULT_QUORUM_BOOTSTRAP_SERVERSContent; } }
        private static Java.Util.List _DEFAULT_QUORUM_BOOTSTRAP_SERVERSContent = default;
        private static bool _DEFAULT_QUORUM_BOOTSTRAP_SERVERSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.html#DEFAULT_QUORUM_VOTERS"/>
        /// </summary>
        public static Java.Util.List DEFAULT_QUORUM_VOTERS { get { if (!_DEFAULT_QUORUM_VOTERSReady) { _DEFAULT_QUORUM_VOTERSContent = SGetField<Java.Util.List>(LocalBridgeClazz, "DEFAULT_QUORUM_VOTERS"); _DEFAULT_QUORUM_VOTERSReady = true; } return _DEFAULT_QUORUM_VOTERSContent; } }
        private static Java.Util.List _DEFAULT_QUORUM_VOTERSContent = default;
        private static bool _DEFAULT_QUORUM_VOTERSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.html#CONFIG_DEF"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Config.ConfigDef CONFIG_DEF { get { if (!_CONFIG_DEFReady) { _CONFIG_DEFContent = SGetField<Org.Apache.Kafka.Common.Config.ConfigDef>(LocalBridgeClazz, "CONFIG_DEF"); _CONFIG_DEFReady = true; } return _CONFIG_DEFContent; } }
        private static Org.Apache.Kafka.Common.Config.ConfigDef _CONFIG_DEFContent = default;
        private static bool _CONFIG_DEFReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.html#parseBootstrapServers-java.util.List-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List<Java.Net.InetSocketAddress> ParseBootstrapServers(Java.Util.List<Java.Lang.String> arg0)
        {
            return SExecuteWithSignature<Java.Util.List<Java.Net.InetSocketAddress>>(LocalBridgeClazz, "parseBootstrapServers", "(Ljava/util/List;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.html#quorumVoterStringsToNodes-java.util.List-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List<Org.Apache.Kafka.Common.Node> QuorumVoterStringsToNodes(Java.Util.List<Java.Lang.String> arg0)
        {
            return SExecuteWithSignature<Java.Util.List<Org.Apache.Kafka.Common.Node>>(LocalBridgeClazz, "quorumVoterStringsToNodes", "(Ljava/util/List;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.html#voterConnectionsToNodes-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List<Org.Apache.Kafka.Common.Node> VoterConnectionsToNodes(Java.Util.Map<Java.Lang.Integer, Java.Net.InetSocketAddress> arg0)
        {
            return SExecuteWithSignature<Java.Util.List<Org.Apache.Kafka.Common.Node>>(LocalBridgeClazz, "voterConnectionsToNodes", "(Ljava/util/Map;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.html#parseVoterConnections-java.util.List-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public static Java.Util.Map<Java.Lang.Integer, Java.Net.InetSocketAddress> ParseVoterConnections(Java.Util.List<Java.Lang.String> arg0)
        {
            return SExecuteWithSignature<Java.Util.Map<Java.Lang.Integer, Java.Net.InetSocketAddress>>(LocalBridgeClazz, "parseVoterConnections", "(Ljava/util/List;)Ljava/util/Map;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.html#parseVoterIds-java.util.List-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set<Java.Lang.Integer> ParseVoterIds(Java.Util.List<Java.Lang.String> arg0)
        {
            return SExecuteWithSignature<Java.Util.Set<Java.Lang.Integer>>(LocalBridgeClazz, "parseVoterIds", "(Ljava/util/List;)Ljava/util/Set;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.html#appendLingerMs--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int AppendLingerMs()
        {
            return IExecuteWithSignature<int>("appendLingerMs", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.html#electionBackoffMaxMs--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int ElectionBackoffMaxMs()
        {
            return IExecuteWithSignature<int>("electionBackoffMaxMs", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.html#electionTimeoutMs--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int ElectionTimeoutMs()
        {
            return IExecuteWithSignature<int>("electionTimeoutMs", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.html#fetchTimeoutMs--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int FetchTimeoutMs()
        {
            return IExecuteWithSignature<int>("fetchTimeoutMs", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.html#requestTimeoutMs--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int RequestTimeoutMs()
        {
            return IExecuteWithSignature<int>("requestTimeoutMs", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.html#retryBackoffMs--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int RetryBackoffMs()
        {
            return IExecuteWithSignature<int>("retryBackoffMs", "()I");
        }

        #endregion

        #region Nested classes
        #region ControllerQuorumBootstrapServersValidator implementation
        public partial class ControllerQuorumBootstrapServersValidator
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.ControllerQuorumBootstrapServersValidator.html#ensureValid-java.lang.String-java.lang.Object-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="object"/></param>
            public void EnsureValid(Java.Lang.String arg0, object arg1)
            {
                IExecuteWithSignature("ensureValid", "(Ljava/lang/String;Ljava/lang/Object;)V", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ControllerQuorumVotersValidator implementation
        public partial class ControllerQuorumVotersValidator
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumConfig.ControllerQuorumVotersValidator.html#ensureValid-java.lang.String-java.lang.Object-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="object"/></param>
            public void EnsureValid(Java.Lang.String arg0, object arg1)
            {
                IExecuteWithSignature("ensureValid", "(Ljava/lang/String;Ljava/lang/Object;)V", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}