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

namespace Org.Apache.Kafka.Common.Security.Auth
{
    #region SslEngineFactory declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/security/auth/SslEngineFactory.html"/>
    /// </summary>
    public partial class SslEngineFactory : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SslEngineFactory>
    {
        const string _bridgeClassName = "org.apache.kafka.common.security.auth.SslEngineFactory";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("SslEngineFactory class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SslEngineFactory() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("SslEngineFactory class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SslEngineFactory(params object[] args) : base(args) { }

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
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region ISslEngineFactory
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ISslEngineFactory
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SslEngineFactory implementation
    public partial class SslEngineFactory : Org.Apache.Kafka.Common.Security.Auth.ISslEngineFactory, Org.Apache.Kafka.Common.IConfigurable, Java.Io.ICloseable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Common.Security.Auth.SslEngineFactory"/> to <see cref="Org.Apache.Kafka.Common.Configurable"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Configurable(Org.Apache.Kafka.Common.Security.Auth.SslEngineFactory t) => t.Cast<Org.Apache.Kafka.Common.Configurable>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Common.Security.Auth.SslEngineFactory"/> to <see cref="Java.Io.Closeable"/>
        /// </summary>
        public static implicit operator Java.Io.Closeable(Org.Apache.Kafka.Common.Security.Auth.SslEngineFactory t) => t.Cast<Java.Io.Closeable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/security/auth/SslEngineFactory.html#shouldBeRebuilt-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ShouldBeRebuilt(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            return IExecuteWithSignature<bool>("shouldBeRebuilt", "(Ljava/util/Map;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/security/auth/SslEngineFactory.html#keystore--"/>
        /// </summary>
        /// <returns><see cref="Java.Security.KeyStore"/></returns>
        public Java.Security.KeyStore Keystore()
        {
            return IExecuteWithSignature<Java.Security.KeyStore>("keystore", "()Ljava/security/KeyStore;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/security/auth/SslEngineFactory.html#truststore--"/>
        /// </summary>
        /// <returns><see cref="Java.Security.KeyStore"/></returns>
        public Java.Security.KeyStore Truststore()
        {
            return IExecuteWithSignature<Java.Security.KeyStore>("truststore", "()Ljava/security/KeyStore;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/security/auth/SslEngineFactory.html#reconfigurableConfigs--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> ReconfigurableConfigs()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("reconfigurableConfigs", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/security/auth/SslEngineFactory.html#createClientSslEngine-java.lang.String-int-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Net.Ssl.SSLEngine"/></returns>
        public Javax.Net.Ssl.SSLEngine CreateClientSslEngine(Java.Lang.String arg0, int arg1, Java.Lang.String arg2)
        {
            return IExecute<Javax.Net.Ssl.SSLEngine>("createClientSslEngine", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/security/auth/SslEngineFactory.html#createServerSslEngine-java.lang.String-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Javax.Net.Ssl.SSLEngine"/></returns>
        public Javax.Net.Ssl.SSLEngine CreateServerSslEngine(Java.Lang.String arg0, int arg1)
        {
            return IExecute<Javax.Net.Ssl.SSLEngine>("createServerSslEngine", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}