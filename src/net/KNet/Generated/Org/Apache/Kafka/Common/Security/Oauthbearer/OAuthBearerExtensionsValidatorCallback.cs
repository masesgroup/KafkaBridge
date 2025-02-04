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

namespace Org.Apache.Kafka.Common.Security.Oauthbearer
{
    #region OAuthBearerExtensionsValidatorCallback declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/oauthbearer/OAuthBearerExtensionsValidatorCallback.html"/>
    /// </summary>
    public partial class OAuthBearerExtensionsValidatorCallback : Javax.Security.Auth.Callback.Callback
    {
        const string _bridgeClassName = "org.apache.kafka.common.security.oauthbearer.OAuthBearerExtensionsValidatorCallback";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public OAuthBearerExtensionsValidatorCallback() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public OAuthBearerExtensionsValidatorCallback(params object[] args) : base(args) { }

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

    #region OAuthBearerExtensionsValidatorCallback implementation
    public partial class OAuthBearerExtensionsValidatorCallback
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/oauthbearer/OAuthBearerExtensionsValidatorCallback.html#org.apache.kafka.common.security.oauthbearer.OAuthBearerExtensionsValidatorCallback(org.apache.kafka.common.security.oauthbearer.OAuthBearerToken,org.apache.kafka.common.security.auth.SaslExtensions)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Security.Oauthbearer.OAuthBearerToken"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Security.Auth.SaslExtensions"/></param>
        public OAuthBearerExtensionsValidatorCallback(Org.Apache.Kafka.Common.Security.Oauthbearer.OAuthBearerToken arg0, Org.Apache.Kafka.Common.Security.Auth.SaslExtensions arg1)
            : base(arg0, arg1)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/oauthbearer/OAuthBearerExtensionsValidatorCallback.html#ignoredExtensions--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, Java.Lang.String> IgnoredExtensions()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Lang.String>>("ignoredExtensions", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/oauthbearer/OAuthBearerExtensionsValidatorCallback.html#invalidExtensions--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, Java.Lang.String> InvalidExtensions()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Lang.String>>("invalidExtensions", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/oauthbearer/OAuthBearerExtensionsValidatorCallback.html#validatedExtensions--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, Java.Lang.String> ValidatedExtensions()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Lang.String>>("validatedExtensions", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/oauthbearer/OAuthBearerExtensionsValidatorCallback.html#inputExtensions--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Security.Auth.SaslExtensions"/></returns>
        public Org.Apache.Kafka.Common.Security.Auth.SaslExtensions InputExtensions()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Security.Auth.SaslExtensions>("inputExtensions", "()Lorg/apache/kafka/common/security/auth/SaslExtensions;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/oauthbearer/OAuthBearerExtensionsValidatorCallback.html#token--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Security.Oauthbearer.OAuthBearerToken"/></returns>
        public Org.Apache.Kafka.Common.Security.Oauthbearer.OAuthBearerToken Token()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Security.Oauthbearer.OAuthBearerToken>("token", "()Lorg/apache/kafka/common/security/oauthbearer/OAuthBearerToken;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/oauthbearer/OAuthBearerExtensionsValidatorCallback.html#error-java.lang.String-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void Error(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecuteWithSignature("error", "(Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/oauthbearer/OAuthBearerExtensionsValidatorCallback.html#valid-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void Valid(Java.Lang.String arg0)
        {
            IExecuteWithSignature("valid", "(Ljava/lang/String;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}