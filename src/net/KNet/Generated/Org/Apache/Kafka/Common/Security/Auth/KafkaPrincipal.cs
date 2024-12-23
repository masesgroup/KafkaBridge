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
*  using kafka-clients-3.9.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Security.Auth
{
    #region KafkaPrincipal declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/auth/KafkaPrincipal.html"/>
    /// </summary>
    public partial class KafkaPrincipal : Java.Security.Principal
    {
        const string _bridgeClassName = "org.apache.kafka.common.security.auth.KafkaPrincipal";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public KafkaPrincipal() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public KafkaPrincipal(params object[] args) : base(args) { }

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

    #region KafkaPrincipal implementation
    public partial class KafkaPrincipal
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/auth/KafkaPrincipal.html#org.apache.kafka.common.security.auth.KafkaPrincipal(java.lang.String,java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public KafkaPrincipal(Java.Lang.String arg0, Java.Lang.String arg1, bool arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/auth/KafkaPrincipal.html#org.apache.kafka.common.security.auth.KafkaPrincipal(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public KafkaPrincipal(Java.Lang.String arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/auth/KafkaPrincipal.html#USER_TYPE"/>
        /// </summary>
        public static Java.Lang.String USER_TYPE { get { if (!_USER_TYPEReady) { _USER_TYPEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "USER_TYPE"); _USER_TYPEReady = true; } return _USER_TYPEContent; } }
        private static Java.Lang.String _USER_TYPEContent = default;
        private static bool _USER_TYPEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/auth/KafkaPrincipal.html#ANONYMOUS"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal ANONYMOUS { get { if (!_ANONYMOUSReady) { _ANONYMOUSContent = SGetField<Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal>(LocalBridgeClazz, "ANONYMOUS"); _ANONYMOUSReady = true; } return _ANONYMOUSContent; } }
        private static Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal _ANONYMOUSContent = default;
        private static bool _ANONYMOUSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/auth/KafkaPrincipal.html#getName--"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/auth/KafkaPrincipal.html#getPrincipalType--"/> 
        /// </summary>
        public Java.Lang.String PrincipalType
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getPrincipalType", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/auth/KafkaPrincipal.html#tokenAuthenticated--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool TokenAuthenticated()
        {
            return IExecuteWithSignature<bool>("tokenAuthenticated", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/security/auth/KafkaPrincipal.html#tokenAuthenticated-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void TokenAuthenticated(bool arg0)
        {
            IExecuteWithSignature("tokenAuthenticated", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}