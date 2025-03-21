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
*  using kafka-streams-3.9.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Kstream
{
    #region EmitStrategy declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/kstream/EmitStrategy.html"/>
    /// </summary>
    public partial class EmitStrategy : MASES.JCOBridge.C2JBridge.JVMBridgeBase<EmitStrategy>
    {
        const string _bridgeClassName = "org.apache.kafka.streams.kstream.EmitStrategy";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("EmitStrategy class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public EmitStrategy() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("EmitStrategy class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public EmitStrategy(params object[] args) : base(args) { }

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
        #region StrategyType declaration
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/kstream/EmitStrategy.StrategyType.html"/>
        /// </summary>
        public partial class StrategyType : Java.Lang.Enum<Org.Apache.Kafka.Streams.Kstream.EmitStrategy.StrategyType>
        {
            const string _bridgeClassName = "org.apache.kafka.streams.kstream.EmitStrategy$StrategyType";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public StrategyType() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public StrategyType(params object[] args) : base(args) { }

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

    #region IEmitStrategy
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IEmitStrategy
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region EmitStrategy implementation
    public partial class EmitStrategy : Org.Apache.Kafka.Streams.Kstream.IEmitStrategy
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/kstream/EmitStrategy.html#onWindowClose--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.EmitStrategy"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.EmitStrategy OnWindowClose()
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.EmitStrategy>(LocalBridgeClazz, "onWindowClose", "()Lorg/apache/kafka/streams/kstream/EmitStrategy;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/kstream/EmitStrategy.html#onWindowUpdate--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.EmitStrategy"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.EmitStrategy OnWindowUpdate()
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.EmitStrategy>(LocalBridgeClazz, "onWindowUpdate", "()Lorg/apache/kafka/streams/kstream/EmitStrategy;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/kstream/EmitStrategy.html#type--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.EmitStrategy.StrategyType"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.EmitStrategy.StrategyType Type()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.EmitStrategy.StrategyType>("type", "()Lorg/apache/kafka/streams/kstream/EmitStrategy$StrategyType;");
        }

        #endregion

        #region Nested classes
        #region StrategyType implementation
        public partial class StrategyType
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/kstream/EmitStrategy.StrategyType.html#ON_WINDOW_CLOSE"/>
            /// </summary>
            public static Org.Apache.Kafka.Streams.Kstream.EmitStrategy.StrategyType ON_WINDOW_CLOSE { get { if (!_ON_WINDOW_CLOSEReady) { _ON_WINDOW_CLOSEContent = SGetField<Org.Apache.Kafka.Streams.Kstream.EmitStrategy.StrategyType>(LocalBridgeClazz, "ON_WINDOW_CLOSE"); _ON_WINDOW_CLOSEReady = true; } return _ON_WINDOW_CLOSEContent; } }
            private static Org.Apache.Kafka.Streams.Kstream.EmitStrategy.StrategyType _ON_WINDOW_CLOSEContent = default;
            private static bool _ON_WINDOW_CLOSEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/kstream/EmitStrategy.StrategyType.html#ON_WINDOW_UPDATE"/>
            /// </summary>
            public static Org.Apache.Kafka.Streams.Kstream.EmitStrategy.StrategyType ON_WINDOW_UPDATE { get { if (!_ON_WINDOW_UPDATEReady) { _ON_WINDOW_UPDATEContent = SGetField<Org.Apache.Kafka.Streams.Kstream.EmitStrategy.StrategyType>(LocalBridgeClazz, "ON_WINDOW_UPDATE"); _ON_WINDOW_UPDATEReady = true; } return _ON_WINDOW_UPDATEContent; } }
            private static Org.Apache.Kafka.Streams.Kstream.EmitStrategy.StrategyType _ON_WINDOW_UPDATEContent = default;
            private static bool _ON_WINDOW_UPDATEReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/kstream/EmitStrategy.StrategyType.html#forType-org.apache.kafka.streams.kstream.EmitStrategy.StrategyType-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.EmitStrategy.StrategyType"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.EmitStrategy"/></returns>
            public static Org.Apache.Kafka.Streams.Kstream.EmitStrategy ForType(Org.Apache.Kafka.Streams.Kstream.EmitStrategy.StrategyType arg0)
            {
                return SExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.EmitStrategy>(LocalBridgeClazz, "forType", "(Lorg/apache/kafka/streams/kstream/EmitStrategy$StrategyType;)Lorg/apache/kafka/streams/kstream/EmitStrategy;", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/kstream/EmitStrategy.StrategyType.html#valueOf-java.lang.String-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.EmitStrategy.StrategyType"/></returns>
            public static Org.Apache.Kafka.Streams.Kstream.EmitStrategy.StrategyType ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.EmitStrategy.StrategyType>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/streams/kstream/EmitStrategy$StrategyType;", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/kstream/EmitStrategy.StrategyType.html#values--"/>
            /// </summary>
            /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.EmitStrategy.StrategyType"/></returns>
            public static Org.Apache.Kafka.Streams.Kstream.EmitStrategy.StrategyType[] Values()
            {
                return SExecuteWithSignatureArray<Org.Apache.Kafka.Streams.Kstream.EmitStrategy.StrategyType>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/streams/kstream/EmitStrategy$StrategyType;");
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