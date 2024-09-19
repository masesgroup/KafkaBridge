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
*  using kafka-clients-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients
{
    #region ConnectionState declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/ConnectionState.html"/>
    /// </summary>
    public partial class ConnectionState : Java.Lang.Enum<Org.Apache.Kafka.Clients.ConnectionState>
    {
        const string _bridgeClassName = "org.apache.kafka.clients.ConnectionState";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ConnectionState() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ConnectionState(params object[] args) : base(args) { }

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

    #region ConnectionState implementation
    public partial class ConnectionState
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/ConnectionState.html#AUTHENTICATION_FAILED"/>
        /// </summary>
        public static Org.Apache.Kafka.Clients.ConnectionState AUTHENTICATION_FAILED { get { if (!_AUTHENTICATION_FAILEDReady) { _AUTHENTICATION_FAILEDContent = SGetField<Org.Apache.Kafka.Clients.ConnectionState>(LocalBridgeClazz, "AUTHENTICATION_FAILED"); _AUTHENTICATION_FAILEDReady = true; } return _AUTHENTICATION_FAILEDContent; } }
        private static Org.Apache.Kafka.Clients.ConnectionState _AUTHENTICATION_FAILEDContent = default;
        private static bool _AUTHENTICATION_FAILEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/ConnectionState.html#CHECKING_API_VERSIONS"/>
        /// </summary>
        public static Org.Apache.Kafka.Clients.ConnectionState CHECKING_API_VERSIONS { get { if (!_CHECKING_API_VERSIONSReady) { _CHECKING_API_VERSIONSContent = SGetField<Org.Apache.Kafka.Clients.ConnectionState>(LocalBridgeClazz, "CHECKING_API_VERSIONS"); _CHECKING_API_VERSIONSReady = true; } return _CHECKING_API_VERSIONSContent; } }
        private static Org.Apache.Kafka.Clients.ConnectionState _CHECKING_API_VERSIONSContent = default;
        private static bool _CHECKING_API_VERSIONSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/ConnectionState.html#CONNECTING"/>
        /// </summary>
        public static Org.Apache.Kafka.Clients.ConnectionState CONNECTING { get { if (!_CONNECTINGReady) { _CONNECTINGContent = SGetField<Org.Apache.Kafka.Clients.ConnectionState>(LocalBridgeClazz, "CONNECTING"); _CONNECTINGReady = true; } return _CONNECTINGContent; } }
        private static Org.Apache.Kafka.Clients.ConnectionState _CONNECTINGContent = default;
        private static bool _CONNECTINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/ConnectionState.html#DISCONNECTED"/>
        /// </summary>
        public static Org.Apache.Kafka.Clients.ConnectionState DISCONNECTED { get { if (!_DISCONNECTEDReady) { _DISCONNECTEDContent = SGetField<Org.Apache.Kafka.Clients.ConnectionState>(LocalBridgeClazz, "DISCONNECTED"); _DISCONNECTEDReady = true; } return _DISCONNECTEDContent; } }
        private static Org.Apache.Kafka.Clients.ConnectionState _DISCONNECTEDContent = default;
        private static bool _DISCONNECTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/ConnectionState.html#READY"/>
        /// </summary>
        public static Org.Apache.Kafka.Clients.ConnectionState READY { get { if (!_READYReady) { _READYContent = SGetField<Org.Apache.Kafka.Clients.ConnectionState>(LocalBridgeClazz, "READY"); _READYReady = true; } return _READYContent; } }
        private static Org.Apache.Kafka.Clients.ConnectionState _READYContent = default;
        private static bool _READYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/ConnectionState.html#valueOf-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.ConnectionState"/></returns>
        public static Org.Apache.Kafka.Clients.ConnectionState ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Clients.ConnectionState>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/clients/ConnectionState;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/ConnectionState.html#values--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Clients.ConnectionState"/></returns>
        public static Org.Apache.Kafka.Clients.ConnectionState[] Values()
        {
            return SExecuteWithSignatureArray<Org.Apache.Kafka.Clients.ConnectionState>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/clients/ConnectionState;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/ConnectionState.html#isConnected--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsConnected()
        {
            return IExecuteWithSignature<bool>("isConnected", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/ConnectionState.html#isDisconnected--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDisconnected()
        {
            return IExecuteWithSignature<bool>("isDisconnected", "()Z");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}