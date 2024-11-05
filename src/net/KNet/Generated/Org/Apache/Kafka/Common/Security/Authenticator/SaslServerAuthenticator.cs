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
*  using kafka-clients-3.8.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Security.Authenticator
{
    #region SaslServerAuthenticator declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/security/authenticator/SaslServerAuthenticator.html"/>
    /// </summary>
    public partial class SaslServerAuthenticator : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SaslServerAuthenticator>
    {
        const string _bridgeClassName = "org.apache.kafka.common.security.authenticator.SaslServerAuthenticator";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SaslServerAuthenticator() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SaslServerAuthenticator(params object[] args) : base(args) { }

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

    #region SaslServerAuthenticator implementation
    public partial class SaslServerAuthenticator
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/security/authenticator/SaslServerAuthenticator.html#complete--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool Complete()
        {
            return IExecuteWithSignature<bool>("complete", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/security/authenticator/SaslServerAuthenticator.html#connectedClientSupportsReauthentication--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool ConnectedClientSupportsReauthentication()
        {
            return IExecuteWithSignature<bool>("connectedClientSupportsReauthentication", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/security/authenticator/SaslServerAuthenticator.html#reauthenticationLatencyMs--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Long"/></returns>
        public Java.Lang.Long ReauthenticationLatencyMs()
        {
            return IExecuteWithSignature<Java.Lang.Long>("reauthenticationLatencyMs", "()Ljava/lang/Long;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/security/authenticator/SaslServerAuthenticator.html#serverSessionExpirationTimeNanos--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Long"/></returns>
        public Java.Lang.Long ServerSessionExpirationTimeNanos()
        {
            return IExecuteWithSignature<Java.Lang.Long>("serverSessionExpirationTimeNanos", "()Ljava/lang/Long;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/security/authenticator/SaslServerAuthenticator.html#principalSerde--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipalSerde> PrincipalSerde()
        {
            return IExecuteWithSignature<Java.Util.Optional<Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipalSerde>>("principalSerde", "()Ljava/util/Optional;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/security/authenticator/SaslServerAuthenticator.html#principal--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal"/></returns>
        public Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal Principal()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal>("principal", "()Lorg/apache/kafka/common/security/auth/KafkaPrincipal;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/security/authenticator/SaslServerAuthenticator.html#authenticate--"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Authenticate()
        {
            IExecuteWithSignature("authenticate", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/security/authenticator/SaslServerAuthenticator.html#close--"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/security/authenticator/SaslServerAuthenticator.html#handleAuthenticationFailure--"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void HandleAuthenticationFailure()
        {
            IExecuteWithSignature("handleAuthenticationFailure", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}