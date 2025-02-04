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

namespace Org.Apache.Kafka.Common.Security.Authenticator
{
    #region AbstractLogin declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/authenticator/AbstractLogin.html"/>
    /// </summary>
    public partial class AbstractLogin : Org.Apache.Kafka.Common.Security.Auth.Login
    {
        const string _bridgeClassName = "org.apache.kafka.common.security.authenticator.AbstractLogin";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("AbstractLogin class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AbstractLogin() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("AbstractLogin class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AbstractLogin(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
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
        #region DefaultLoginCallbackHandler declaration
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/authenticator/AbstractLogin.DefaultLoginCallbackHandler.html"/>
        /// </summary>
        public partial class DefaultLoginCallbackHandler : Org.Apache.Kafka.Common.Security.Auth.AuthenticateCallbackHandler
        {
            const string _bridgeClassName = "org.apache.kafka.common.security.authenticator.AbstractLogin$DefaultLoginCallbackHandler";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public DefaultLoginCallbackHandler() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public DefaultLoginCallbackHandler(params object[] args) : base(args) { }

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

    #region AbstractLogin implementation
    public partial class AbstractLogin
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/authenticator/AbstractLogin.html#login--"/>
        /// </summary>
        /// <returns><see cref="Javax.Security.Auth.Login.LoginContext"/></returns>
        /// <exception cref="Javax.Security.Auth.Login.LoginException"/>
        public Javax.Security.Auth.Login.LoginContext Login()
        {
            return IExecuteWithSignature<Javax.Security.Auth.Login.LoginContext>("login", "()Ljavax/security/auth/login/LoginContext;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/authenticator/AbstractLogin.html#subject--"/>
        /// </summary>
        /// <returns><see cref="Javax.Security.Auth.Subject"/></returns>
        public Javax.Security.Auth.Subject Subject()
        {
            return IExecuteWithSignature<Javax.Security.Auth.Subject>("subject", "()Ljavax/security/auth/Subject;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/authenticator/AbstractLogin.html#configure-java.util.Map-java.lang.String-javax.security.auth.login.Configuration-org.apache.kafka.common.security.auth.AuthenticateCallbackHandler-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Javax.Security.Auth.Login.Configuration"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Common.Security.Auth.AuthenticateCallbackHandler"/></param>
        public void Configure(Java.Util.Map<Java.Lang.String, object> arg0, Java.Lang.String arg1, Javax.Security.Auth.Login.Configuration arg2, Org.Apache.Kafka.Common.Security.Auth.AuthenticateCallbackHandler arg3)
        {
            IExecuteWithSignature("configure", "(Ljava/util/Map;Ljava/lang/String;Ljavax/security/auth/login/Configuration;Lorg/apache/kafka/common/security/auth/AuthenticateCallbackHandler;)V", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Nested classes
        #region DefaultLoginCallbackHandler implementation
        public partial class DefaultLoginCallbackHandler
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/authenticator/AbstractLogin.DefaultLoginCallbackHandler.html#close--"/>
            /// </summary>
            public void Close()
            {
                IExecuteWithSignature("close", "()V");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/authenticator/AbstractLogin.DefaultLoginCallbackHandler.html#configure-java.util.Map-java.lang.String-java.util.List-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Map"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <param name="arg2"><see cref="Java.Util.List"/></param>
            public void Configure(Java.Util.Map<Java.Lang.String, object> arg0, Java.Lang.String arg1, Java.Util.List<Javax.Security.Auth.Login.AppConfigurationEntry> arg2)
            {
                IExecuteWithSignature("configure", "(Ljava/util/Map;Ljava/lang/String;Ljava/util/List;)V", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/authenticator/AbstractLogin.DefaultLoginCallbackHandler.html#handle-javax.security.auth.callback.Callback[]-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Security.Auth.Callback.Callback"/></param>
            /// <exception cref="Javax.Security.Auth.Callback.UnsupportedCallbackException"/>
            public void Handle(Javax.Security.Auth.Callback.Callback[] arg0)
            {
                IExecuteWithSignature("handle", "([Ljavax/security/auth/callback/Callback;)V", new object[] { arg0 });
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