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

namespace Org.Apache.Kafka.Common.Resource
{
    #region PatternType declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/resource/PatternType.html"/>
    /// </summary>
    public partial class PatternType : Java.Lang.Enum<Org.Apache.Kafka.Common.Resource.PatternType>
    {
        const string _bridgeClassName = "org.apache.kafka.common.resource.PatternType";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public PatternType() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public PatternType(params object[] args) : base(args) { }

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

    #region PatternType implementation
    public partial class PatternType
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/resource/PatternType.html#ANY"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Resource.PatternType ANY { get { if (!_ANYReady) { _ANYContent = SGetField<Org.Apache.Kafka.Common.Resource.PatternType>(LocalBridgeClazz, "ANY"); _ANYReady = true; } return _ANYContent; } }
        private static Org.Apache.Kafka.Common.Resource.PatternType _ANYContent = default;
        private static bool _ANYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/resource/PatternType.html#LITERAL"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Resource.PatternType LITERAL { get { if (!_LITERALReady) { _LITERALContent = SGetField<Org.Apache.Kafka.Common.Resource.PatternType>(LocalBridgeClazz, "LITERAL"); _LITERALReady = true; } return _LITERALContent; } }
        private static Org.Apache.Kafka.Common.Resource.PatternType _LITERALContent = default;
        private static bool _LITERALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/resource/PatternType.html#MATCH"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Resource.PatternType MATCH { get { if (!_MATCHReady) { _MATCHContent = SGetField<Org.Apache.Kafka.Common.Resource.PatternType>(LocalBridgeClazz, "MATCH"); _MATCHReady = true; } return _MATCHContent; } }
        private static Org.Apache.Kafka.Common.Resource.PatternType _MATCHContent = default;
        private static bool _MATCHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/resource/PatternType.html#PREFIXED"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Resource.PatternType PREFIXED { get { if (!_PREFIXEDReady) { _PREFIXEDContent = SGetField<Org.Apache.Kafka.Common.Resource.PatternType>(LocalBridgeClazz, "PREFIXED"); _PREFIXEDReady = true; } return _PREFIXEDContent; } }
        private static Org.Apache.Kafka.Common.Resource.PatternType _PREFIXEDContent = default;
        private static bool _PREFIXEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/resource/PatternType.html#UNKNOWN"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Resource.PatternType UNKNOWN { get { if (!_UNKNOWNReady) { _UNKNOWNContent = SGetField<Org.Apache.Kafka.Common.Resource.PatternType>(LocalBridgeClazz, "UNKNOWN"); _UNKNOWNReady = true; } return _UNKNOWNContent; } }
        private static Org.Apache.Kafka.Common.Resource.PatternType _UNKNOWNContent = default;
        private static bool _UNKNOWNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/resource/PatternType.html#fromCode-byte-"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Resource.PatternType"/></returns>
        public static Org.Apache.Kafka.Common.Resource.PatternType FromCode(byte arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.Resource.PatternType>(LocalBridgeClazz, "fromCode", "(B)Lorg/apache/kafka/common/resource/PatternType;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/resource/PatternType.html#fromString-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Resource.PatternType"/></returns>
        public static Org.Apache.Kafka.Common.Resource.PatternType FromString(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.Resource.PatternType>(LocalBridgeClazz, "fromString", "(Ljava/lang/String;)Lorg/apache/kafka/common/resource/PatternType;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/resource/PatternType.html#valueOf-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Resource.PatternType"/></returns>
        public static Org.Apache.Kafka.Common.Resource.PatternType ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.Resource.PatternType>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/common/resource/PatternType;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/resource/PatternType.html#values--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Resource.PatternType"/></returns>
        public static Org.Apache.Kafka.Common.Resource.PatternType[] Values()
        {
            return SExecuteWithSignatureArray<Org.Apache.Kafka.Common.Resource.PatternType>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/common/resource/PatternType;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/resource/PatternType.html#isSpecific--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSpecific()
        {
            return IExecuteWithSignature<bool>("isSpecific", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/resource/PatternType.html#isUnknown--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsUnknown()
        {
            return IExecuteWithSignature<bool>("isUnknown", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/resource/PatternType.html#code--"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte Code()
        {
            return IExecuteWithSignature<byte>("code", "()B");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}