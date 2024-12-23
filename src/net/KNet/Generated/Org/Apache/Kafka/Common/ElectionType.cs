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

namespace Org.Apache.Kafka.Common
{
    #region ElectionType declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/ElectionType.html"/>
    /// </summary>
    public partial class ElectionType : Java.Lang.Enum<Org.Apache.Kafka.Common.ElectionType>
    {
        const string _bridgeClassName = "org.apache.kafka.common.ElectionType";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ElectionType() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ElectionType(params object[] args) : base(args) { }

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

    #region ElectionType implementation
    public partial class ElectionType
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/ElectionType.html#value"/>
        /// </summary>
        public byte value { get { if (!_valueReady) { _valueContent = IGetField<byte>("value"); _valueReady = true; } return _valueContent; } }
        private byte _valueContent = default;
        private bool _valueReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/ElectionType.html#PREFERRED"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.ElectionType PREFERRED { get { if (!_PREFERREDReady) { _PREFERREDContent = SGetField<Org.Apache.Kafka.Common.ElectionType>(LocalBridgeClazz, "PREFERRED"); _PREFERREDReady = true; } return _PREFERREDContent; } }
        private static Org.Apache.Kafka.Common.ElectionType _PREFERREDContent = default;
        private static bool _PREFERREDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/ElectionType.html#UNCLEAN"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.ElectionType UNCLEAN { get { if (!_UNCLEANReady) { _UNCLEANContent = SGetField<Org.Apache.Kafka.Common.ElectionType>(LocalBridgeClazz, "UNCLEAN"); _UNCLEANReady = true; } return _UNCLEANContent; } }
        private static Org.Apache.Kafka.Common.ElectionType _UNCLEANContent = default;
        private static bool _UNCLEANReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/ElectionType.html#valueOf-byte-"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.ElectionType"/></returns>
        public static Org.Apache.Kafka.Common.ElectionType ValueOf(byte arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.ElectionType>(LocalBridgeClazz, "valueOf", "(B)Lorg/apache/kafka/common/ElectionType;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/ElectionType.html#valueOf-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.ElectionType"/></returns>
        public static Org.Apache.Kafka.Common.ElectionType ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.ElectionType>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/common/ElectionType;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/ElectionType.html#values--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.ElectionType"/></returns>
        public static Org.Apache.Kafka.Common.ElectionType[] Values()
        {
            return SExecuteWithSignatureArray<Org.Apache.Kafka.Common.ElectionType>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/common/ElectionType;");
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