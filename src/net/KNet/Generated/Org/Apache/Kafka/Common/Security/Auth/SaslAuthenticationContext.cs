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

namespace Org.Apache.Kafka.Common.Security.Auth
{
    #region SaslAuthenticationContext declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/auth/SaslAuthenticationContext.html"/>
    /// </summary>
    public partial class SaslAuthenticationContext : Org.Apache.Kafka.Common.Security.Auth.AuthenticationContext
    {
        const string _bridgeClassName = "org.apache.kafka.common.security.auth.SaslAuthenticationContext";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SaslAuthenticationContext() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SaslAuthenticationContext(params object[] args) : base(args) { }

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

    #region SaslAuthenticationContext implementation
    public partial class SaslAuthenticationContext
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/auth/SaslAuthenticationContext.html#org.apache.kafka.common.security.auth.SaslAuthenticationContext(javax.security.sasl.SaslServer,org.apache.kafka.common.security.auth.SecurityProtocol,java.net.InetAddress,java.lang.String,java.util.Optional)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Security.Sasl.SaslServer"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol"/></param>
        /// <param name="arg2"><see cref="Java.Net.InetAddress"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Java.Util.Optional"/></param>
        public SaslAuthenticationContext(Javax.Security.Sasl.SaslServer arg0, Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol arg1, Java.Net.InetAddress arg2, Java.Lang.String arg3, Java.Util.Optional<Javax.Net.Ssl.SSLSession> arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/auth/SaslAuthenticationContext.html#org.apache.kafka.common.security.auth.SaslAuthenticationContext(javax.security.sasl.SaslServer,org.apache.kafka.common.security.auth.SecurityProtocol,java.net.InetAddress,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Security.Sasl.SaslServer"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol"/></param>
        /// <param name="arg2"><see cref="Java.Net.InetAddress"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        public SaslAuthenticationContext(Javax.Security.Sasl.SaslServer arg0, Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol arg1, Java.Net.InetAddress arg2, Java.Lang.String arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/auth/SaslAuthenticationContext.html#listenerName--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ListenerName()
        {
            return IExecuteWithSignature<Java.Lang.String>("listenerName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/auth/SaslAuthenticationContext.html#clientAddress--"/>
        /// </summary>
        /// <returns><see cref="Java.Net.InetAddress"/></returns>
        public Java.Net.InetAddress ClientAddress()
        {
            return IExecuteWithSignature<Java.Net.InetAddress>("clientAddress", "()Ljava/net/InetAddress;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/auth/SaslAuthenticationContext.html#sslSession--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Javax.Net.Ssl.SSLSession> SslSession()
        {
            return IExecuteWithSignature<Java.Util.Optional<Javax.Net.Ssl.SSLSession>>("sslSession", "()Ljava/util/Optional;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/auth/SaslAuthenticationContext.html#server--"/>
        /// </summary>
        /// <returns><see cref="Javax.Security.Sasl.SaslServer"/></returns>
        public Javax.Security.Sasl.SaslServer Server()
        {
            return IExecuteWithSignature<Javax.Security.Sasl.SaslServer>("server", "()Ljavax/security/sasl/SaslServer;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/auth/SaslAuthenticationContext.html#securityProtocol--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol"/></returns>
        public Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol SecurityProtocol()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol>("securityProtocol", "()Lorg/apache/kafka/common/security/auth/SecurityProtocol;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}