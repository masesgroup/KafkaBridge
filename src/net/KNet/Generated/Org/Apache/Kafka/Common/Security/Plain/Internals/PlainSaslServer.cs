/*
*  Copyright 2025 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.5.12.0)
*  using kafka-clients-3.9.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Security.Plain.Internals
{
    #region PlainSaslServer declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/plain/internals/PlainSaslServer.html"/>
    /// </summary>
    public partial class PlainSaslServer : Javax.Security.Sasl.SaslServer
    {
        const string _bridgeClassName = "org.apache.kafka.common.security.plain.internals.PlainSaslServer";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public PlainSaslServer() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public PlainSaslServer(params object[] args) : base(args) { }

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
        #region PlainSaslServerFactory declaration
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/plain/internals/PlainSaslServer.PlainSaslServerFactory.html"/>
        /// </summary>
        public partial class PlainSaslServerFactory : Javax.Security.Sasl.SaslServerFactory
        {
            const string _bridgeClassName = "org.apache.kafka.common.security.plain.internals.PlainSaslServer$PlainSaslServerFactory";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public PlainSaslServerFactory() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public PlainSaslServerFactory(params object[] args) : base(args) { }

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

    #region PlainSaslServer implementation
    public partial class PlainSaslServer
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/plain/internals/PlainSaslServer.html#org.apache.kafka.common.security.plain.internals.PlainSaslServer(javax.security.auth.callback.CallbackHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Security.Auth.Callback.CallbackHandler"/></param>
        public PlainSaslServer(Javax.Security.Auth.Callback.CallbackHandler arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/plain/internals/PlainSaslServer.html#PLAIN_MECHANISM"/>
        /// </summary>
        public static Java.Lang.String PLAIN_MECHANISM { get { if (!_PLAIN_MECHANISMReady) { _PLAIN_MECHANISMContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "PLAIN_MECHANISM"); _PLAIN_MECHANISMReady = true; } return _PLAIN_MECHANISMContent; } }
        private static Java.Lang.String _PLAIN_MECHANISMContent = default;
        private static bool _PLAIN_MECHANISMReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/plain/internals/PlainSaslServer.html#getAuthorizationID--"/> 
        /// </summary>
        public Java.Lang.String AuthorizationID
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getAuthorizationID", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/plain/internals/PlainSaslServer.html#getMechanismName--"/> 
        /// </summary>
        public Java.Lang.String MechanismName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getMechanismName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/plain/internals/PlainSaslServer.html#isComplete--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsComplete()
        {
            return IExecuteWithSignature<bool>("isComplete", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/plain/internals/PlainSaslServer.html#evaluateResponse-byte[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Org.Apache.Kafka.Common.Errors.SaslAuthenticationException"/>
        public byte[] EvaluateResponse(byte[] arg0)
        {
            return IExecuteWithSignatureArray<byte>("evaluateResponse", "([B)[B", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/plain/internals/PlainSaslServer.html#unwrap-byte[]-int-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] Unwrap(byte[] arg0, int arg1, int arg2)
        {
            return IExecuteWithSignatureArray<byte>("unwrap", "([BII)[B", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/plain/internals/PlainSaslServer.html#wrap-byte[]-int-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] Wrap(byte[] arg0, int arg1, int arg2)
        {
            return IExecuteWithSignatureArray<byte>("wrap", "([BII)[B", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/plain/internals/PlainSaslServer.html#getNegotiatedProperty-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetNegotiatedProperty(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("getNegotiatedProperty", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/plain/internals/PlainSaslServer.html#dispose--"/>
        /// </summary>
        public new void Dispose()
        {
            IExecuteWithSignature("dispose", "()V");
        }

        #endregion

        #region Nested classes
        #region PlainSaslServerFactory implementation
        public partial class PlainSaslServerFactory
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/plain/internals/PlainSaslServer.PlainSaslServerFactory.html#getMechanismNames-java.util.Map-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Map"/></param>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String[] GetMechanismNames(Java.Util.Map<Java.Lang.String, object> arg0)
            {
                return IExecuteWithSignatureArray<Java.Lang.String>("getMechanismNames", "(Ljava/util/Map;)[Ljava/lang/String;", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/plain/internals/PlainSaslServer.PlainSaslServerFactory.html#createSaslServer-java.lang.String-java.lang.String-java.lang.String-java.util.Map-javax.security.auth.callback.CallbackHandler-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <param name="arg2"><see cref="Java.Lang.String"/></param>
            /// <param name="arg3"><see cref="Java.Util.Map"/></param>
            /// <param name="arg4"><see cref="Javax.Security.Auth.Callback.CallbackHandler"/></param>
            /// <returns><see cref="Javax.Security.Sasl.SaslServer"/></returns>
            /// <exception cref="Javax.Security.Sasl.SaslException"/>
            public Javax.Security.Sasl.SaslServer CreateSaslServer(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Util.Map<Java.Lang.String, object> arg3, Javax.Security.Auth.Callback.CallbackHandler arg4)
            {
                return IExecuteWithSignature<Javax.Security.Sasl.SaslServer>("createSaslServer", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;Ljavax/security/auth/callback/CallbackHandler;)Ljavax/security/sasl/SaslServer;", arg0, arg1, arg2, arg3, arg4);
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