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
*  using kafka-streams-3.6.2.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Processor.Api
{
    #region FixedKeyProcessorContext declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/processor/api/FixedKeyProcessorContext.html"/>
    /// </summary>
    public partial class FixedKeyProcessorContext : Org.Apache.Kafka.Streams.Processor.Api.ProcessingContext
    {
        const string _bridgeClassName = "org.apache.kafka.streams.processor.api.FixedKeyProcessorContext";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("FixedKeyProcessorContext class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public FixedKeyProcessorContext() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("FixedKeyProcessorContext class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public FixedKeyProcessorContext(params object[] args) : base(args) { }

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

    #region FixedKeyProcessorContext<KForward, VForward> declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/processor/api/FixedKeyProcessorContext.html"/>
    /// </summary>
    /// <typeparam name="KForward"></typeparam>
    /// <typeparam name="VForward"></typeparam>
    public partial class FixedKeyProcessorContext<KForward, VForward> : Org.Apache.Kafka.Streams.Processor.Api.ProcessingContext
    {
        const string _bridgeClassName = "org.apache.kafka.streams.processor.api.FixedKeyProcessorContext";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("FixedKeyProcessorContext class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public FixedKeyProcessorContext() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("FixedKeyProcessorContext class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public FixedKeyProcessorContext(params object[] args) : base(args) { }

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

    #region FixedKeyProcessorContext implementation
    public partial class FixedKeyProcessorContext
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/processor/api/FixedKeyProcessorContext.html#forward-org.apache.kafka.streams.processor.api.FixedKeyRecord-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.FixedKeyRecord"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void Forward(Org.Apache.Kafka.Streams.Processor.Api.FixedKeyRecord arg0, Java.Lang.String arg1)
        {
            IExecute("forward", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/processor/api/FixedKeyProcessorContext.html#forward-org.apache.kafka.streams.processor.api.FixedKeyRecord-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.FixedKeyRecord"/></param>
        public void Forward(Org.Apache.Kafka.Streams.Processor.Api.FixedKeyRecord arg0)
        {
            IExecute("forward", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IFixedKeyProcessorContext<KForward, VForward>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IFixedKeyProcessorContext<KForward, VForward> : Org.Apache.Kafka.Streams.Processor.Api.IProcessingContext
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region FixedKeyProcessorContext<KForward, VForward> implementation
    public partial class FixedKeyProcessorContext<KForward, VForward> : Org.Apache.Kafka.Streams.Processor.Api.IFixedKeyProcessorContext<KForward, VForward>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Processor.Api.FixedKeyProcessorContext{KForward, VForward}"/> to <see cref="Org.Apache.Kafka.Streams.Processor.Api.FixedKeyProcessorContext"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Processor.Api.FixedKeyProcessorContext(Org.Apache.Kafka.Streams.Processor.Api.FixedKeyProcessorContext<KForward, VForward> t) => t.Cast<Org.Apache.Kafka.Streams.Processor.Api.FixedKeyProcessorContext>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/processor/api/FixedKeyProcessorContext.html#forward-org.apache.kafka.streams.processor.api.FixedKeyRecord-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.FixedKeyRecord"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <typeparam name="K"><typeparamref name="KForward"/></typeparam>
        /// <typeparam name="V"><typeparamref name="VForward"/></typeparam>
        public void Forward<K, V>(Org.Apache.Kafka.Streams.Processor.Api.FixedKeyRecord<K, V> arg0, Java.Lang.String arg1) where K : KForward where V : VForward
        {
            IExecute("forward", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/processor/api/FixedKeyProcessorContext.html#forward-org.apache.kafka.streams.processor.api.FixedKeyRecord-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.FixedKeyRecord"/></param>
        /// <typeparam name="K"><typeparamref name="KForward"/></typeparam>
        /// <typeparam name="V"><typeparamref name="VForward"/></typeparam>
        public void Forward<K, V>(Org.Apache.Kafka.Streams.Processor.Api.FixedKeyRecord<K, V> arg0) where K : KForward where V : VForward
        {
            IExecute("forward", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}