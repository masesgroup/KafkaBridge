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
*  using kafka-clients-3.6.2.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Security
{
    #region JaasContext declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/JaasContext.html"/>
    /// </summary>
    public partial class JaasContext : MASES.JCOBridge.C2JBridge.JVMBridgeBase<JaasContext>
    {
        const string _bridgeClassName = "org.apache.kafka.common.security.JaasContext";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public JaasContext() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public JaasContext(params object[] args) : base(args) { }

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
        #region Type declaration
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/JaasContext.Type.html"/>
        /// </summary>
        public partial class Type : Java.Lang.Enum<Org.Apache.Kafka.Common.Security.JaasContext.Type>
        {
            const string _bridgeClassName = "org.apache.kafka.common.security.JaasContext$Type";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Type() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Type(params object[] args) : base(args) { }

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

    #region JaasContext implementation
    public partial class JaasContext
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/JaasContext.html#org.apache.kafka.common.security.JaasContext(java.lang.String,org.apache.kafka.common.security.JaasContext.Type,javax.security.auth.login.Configuration,org.apache.kafka.common.config.types.Password)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Security.JaasContext.Type"/></param>
        /// <param name="arg2"><see cref="Javax.Security.Auth.Login.Configuration"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Common.Config.Types.Password"/></param>
        public JaasContext(Java.Lang.String arg0, Org.Apache.Kafka.Common.Security.JaasContext.Type arg1, Javax.Security.Auth.Login.Configuration arg2, Org.Apache.Kafka.Common.Config.Types.Password arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/JaasContext.html#configEntryOption-java.util.List-java.lang.String-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ConfigEntryOption(Java.Util.List<Javax.Security.Auth.Login.AppConfigurationEntry> arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            return SExecute<Java.Lang.String>(LocalBridgeClazz, "configEntryOption", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/JaasContext.html#loadClientContext-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Security.JaasContext"/></returns>
        public static Org.Apache.Kafka.Common.Security.JaasContext LoadClientContext(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.Security.JaasContext>(LocalBridgeClazz, "loadClientContext", "(Ljava/util/Map;)Lorg/apache/kafka/common/security/JaasContext;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/JaasContext.html#name--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Name()
        {
            return IExecuteWithSignature<Java.Lang.String>("name", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/JaasContext.html#configurationEntries--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Javax.Security.Auth.Login.AppConfigurationEntry> ConfigurationEntries()
        {
            return IExecuteWithSignature<Java.Util.List<Javax.Security.Auth.Login.AppConfigurationEntry>>("configurationEntries", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/JaasContext.html#configuration--"/>
        /// </summary>
        /// <returns><see cref="Javax.Security.Auth.Login.Configuration"/></returns>
        public Javax.Security.Auth.Login.Configuration Configuration()
        {
            return IExecuteWithSignature<Javax.Security.Auth.Login.Configuration>("configuration", "()Ljavax/security/auth/login/Configuration;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/JaasContext.html#dynamicJaasConfig--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Config.Types.Password"/></returns>
        public Org.Apache.Kafka.Common.Config.Types.Password DynamicJaasConfig()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Config.Types.Password>("dynamicJaasConfig", "()Lorg/apache/kafka/common/config/types/Password;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/JaasContext.html#type--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Security.JaasContext.Type"/></returns>
        public Org.Apache.Kafka.Common.Security.JaasContext.Type TypeMethod()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Security.JaasContext.Type>("type", "()Lorg/apache/kafka/common/security/JaasContext$Type;");
        }

        #endregion

        #region Nested classes
        #region Type implementation
        public partial class Type
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/JaasContext.Type.html#CLIENT"/>
            /// </summary>
            public static Org.Apache.Kafka.Common.Security.JaasContext.Type CLIENT { get { if (!_CLIENTReady) { _CLIENTContent = SGetField<Org.Apache.Kafka.Common.Security.JaasContext.Type>(LocalBridgeClazz, "CLIENT"); _CLIENTReady = true; } return _CLIENTContent; } }
            private static Org.Apache.Kafka.Common.Security.JaasContext.Type _CLIENTContent = default;
            private static bool _CLIENTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/JaasContext.Type.html#SERVER"/>
            /// </summary>
            public static Org.Apache.Kafka.Common.Security.JaasContext.Type SERVER { get { if (!_SERVERReady) { _SERVERContent = SGetField<Org.Apache.Kafka.Common.Security.JaasContext.Type>(LocalBridgeClazz, "SERVER"); _SERVERReady = true; } return _SERVERContent; } }
            private static Org.Apache.Kafka.Common.Security.JaasContext.Type _SERVERContent = default;
            private static bool _SERVERReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/JaasContext.Type.html#valueOf-java.lang.String-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Common.Security.JaasContext.Type"/></returns>
            public static Org.Apache.Kafka.Common.Security.JaasContext.Type ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Org.Apache.Kafka.Common.Security.JaasContext.Type>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/common/security/JaasContext$Type;", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/JaasContext.Type.html#values--"/>
            /// </summary>
            /// <returns><see cref="Org.Apache.Kafka.Common.Security.JaasContext.Type"/></returns>
            public static Org.Apache.Kafka.Common.Security.JaasContext.Type[] Values()
            {
                return SExecuteWithSignatureArray<Org.Apache.Kafka.Common.Security.JaasContext.Type>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/common/security/JaasContext$Type;");
            }

            #endregion

            #region Instance methods

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