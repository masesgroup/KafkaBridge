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
*  using kafka-clients-3.6.2.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Config
{
    #region SslClientAuth declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslClientAuth.html"/>
    /// </summary>
    public partial class SslClientAuth : Java.Lang.Enum<Org.Apache.Kafka.Common.Config.SslClientAuth>
    {
        const string _bridgeClassName = "org.apache.kafka.common.config.SslClientAuth";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SslClientAuth() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SslClientAuth(params object[] args) : base(args) { }

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

    #region SslClientAuth implementation
    public partial class SslClientAuth
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslClientAuth.html#VALUES"/>
        /// </summary>
        public static Java.Util.List VALUES { get { if (!_VALUESReady) { _VALUESContent = SGetField<Java.Util.List>(LocalBridgeClazz, "VALUES"); _VALUESReady = true; } return _VALUESContent; } }
        private static Java.Util.List _VALUESContent = default;
        private static bool _VALUESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslClientAuth.html#NONE"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Config.SslClientAuth NONE { get { if (!_NONEReady) { _NONEContent = SGetField<Org.Apache.Kafka.Common.Config.SslClientAuth>(LocalBridgeClazz, "NONE"); _NONEReady = true; } return _NONEContent; } }
        private static Org.Apache.Kafka.Common.Config.SslClientAuth _NONEContent = default;
        private static bool _NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslClientAuth.html#REQUESTED"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Config.SslClientAuth REQUESTED { get { if (!_REQUESTEDReady) { _REQUESTEDContent = SGetField<Org.Apache.Kafka.Common.Config.SslClientAuth>(LocalBridgeClazz, "REQUESTED"); _REQUESTEDReady = true; } return _REQUESTEDContent; } }
        private static Org.Apache.Kafka.Common.Config.SslClientAuth _REQUESTEDContent = default;
        private static bool _REQUESTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslClientAuth.html#REQUIRED"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Config.SslClientAuth REQUIRED { get { if (!_REQUIREDReady) { _REQUIREDContent = SGetField<Org.Apache.Kafka.Common.Config.SslClientAuth>(LocalBridgeClazz, "REQUIRED"); _REQUIREDReady = true; } return _REQUIREDContent; } }
        private static Org.Apache.Kafka.Common.Config.SslClientAuth _REQUIREDContent = default;
        private static bool _REQUIREDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslClientAuth.html#forConfig-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Config.SslClientAuth"/></returns>
        public static Org.Apache.Kafka.Common.Config.SslClientAuth ForConfig(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.Config.SslClientAuth>(LocalBridgeClazz, "forConfig", "(Ljava/lang/String;)Lorg/apache/kafka/common/config/SslClientAuth;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslClientAuth.html#valueOf-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Config.SslClientAuth"/></returns>
        public static Org.Apache.Kafka.Common.Config.SslClientAuth ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.Config.SslClientAuth>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/common/config/SslClientAuth;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/SslClientAuth.html#values--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Config.SslClientAuth"/></returns>
        public static Org.Apache.Kafka.Common.Config.SslClientAuth[] Values()
        {
            return SExecuteWithSignatureArray<Org.Apache.Kafka.Common.Config.SslClientAuth>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/common/config/SslClientAuth;");
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}