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

namespace Org.Apache.Kafka.Common
{
    #region IsolationLevel declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/IsolationLevel.html"/>
    /// </summary>
    public partial class IsolationLevel : Java.Lang.Enum<Org.Apache.Kafka.Common.IsolationLevel>
    {
        const string _bridgeClassName = "org.apache.kafka.common.IsolationLevel";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public IsolationLevel() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public IsolationLevel(params object[] args) : base(args) { }

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

    #region IsolationLevel implementation
    public partial class IsolationLevel
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/IsolationLevel.html#READ_COMMITTED"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.IsolationLevel READ_COMMITTED { get { if (!_READ_COMMITTEDReady) { _READ_COMMITTEDContent = SGetField<Org.Apache.Kafka.Common.IsolationLevel>(LocalBridgeClazz, "READ_COMMITTED"); _READ_COMMITTEDReady = true; } return _READ_COMMITTEDContent; } }
        private static Org.Apache.Kafka.Common.IsolationLevel _READ_COMMITTEDContent = default;
        private static bool _READ_COMMITTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/IsolationLevel.html#READ_UNCOMMITTED"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.IsolationLevel READ_UNCOMMITTED { get { if (!_READ_UNCOMMITTEDReady) { _READ_UNCOMMITTEDContent = SGetField<Org.Apache.Kafka.Common.IsolationLevel>(LocalBridgeClazz, "READ_UNCOMMITTED"); _READ_UNCOMMITTEDReady = true; } return _READ_UNCOMMITTEDContent; } }
        private static Org.Apache.Kafka.Common.IsolationLevel _READ_UNCOMMITTEDContent = default;
        private static bool _READ_UNCOMMITTEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/IsolationLevel.html#forId-byte-"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.IsolationLevel"/></returns>
        public static Org.Apache.Kafka.Common.IsolationLevel ForId(byte arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.IsolationLevel>(LocalBridgeClazz, "forId", "(B)Lorg/apache/kafka/common/IsolationLevel;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/IsolationLevel.html#valueOf-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.IsolationLevel"/></returns>
        public static Org.Apache.Kafka.Common.IsolationLevel ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.IsolationLevel>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/common/IsolationLevel;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/IsolationLevel.html#values--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.IsolationLevel"/></returns>
        public static Org.Apache.Kafka.Common.IsolationLevel[] Values()
        {
            return SExecuteWithSignatureArray<Org.Apache.Kafka.Common.IsolationLevel>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/common/IsolationLevel;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/IsolationLevel.html#id--"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte Id()
        {
            return IExecuteWithSignature<byte>("id", "()B");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}