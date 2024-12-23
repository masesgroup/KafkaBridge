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
*  using kafka-streams-3.9.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Processor.Api
{
    #region Processor declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/api/Processor.html"/>
    /// </summary>
    public partial class Processor : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Processor() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.knet.generated.org.apache.kafka.streams.processor.api.Processor";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region ProcessorDirect declaration
    /// <summary>
    /// Direct override of <see cref="Processor"/> or its generic type if there is one
    /// </summary>
    public partial class ProcessorDirect : Processor
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "org.apache.kafka.streams.processor.api.Processor";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
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
    }
    #endregion

    #region Processor<KIn, VIn, KOut, VOut> declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/api/Processor.html"/>
    /// </summary>
    /// <typeparam name="KIn"></typeparam>
    /// <typeparam name="VIn"></typeparam>
    /// <typeparam name="KOut"></typeparam>
    /// <typeparam name="VOut"></typeparam>
    public partial class Processor<KIn, VIn, KOut, VOut> : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Processor() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.knet.generated.org.apache.kafka.streams.processor.api.Processor";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class
    
    }
    #endregion

    #region ProcessorDirect<KIn, VIn, KOut, VOut> declaration
    /// <summary>
    /// Direct override of <see cref="Processor"/> or its generic type if there is one
    /// </summary>
    public partial class ProcessorDirect<KIn, VIn, KOut, VOut> : Processor<KIn, VIn, KOut, VOut>
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "org.apache.kafka.streams.processor.api.Processor";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
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
    }
    #endregion

    #region Processor implementation
    public partial class Processor
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
        /// Handlers initializer for <see cref="Processor"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("process", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ProcessEventHandler));
            AddEventHandler("close", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(CloseEventHandler));
            AddEventHandler("init", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(InitEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/api/Processor.html#process-org.apache.kafka.streams.processor.api.Record-"/>
        /// </summary>
        /// <remarks>If <see cref="OnProcess"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Org.Apache.Kafka.Streams.Processor.Api.Record> OnProcess { get; set; } = null;

        bool hasOverrideProcess = true;
        void ProcessEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideProcess = true;
            var methodToExecute = (OnProcess != null) ? OnProcess : Process;
            methodToExecute.Invoke(data.EventData.GetAt<Org.Apache.Kafka.Streams.Processor.Api.Record>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideProcess;
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/api/Processor.html#process-org.apache.kafka.streams.processor.api.Record-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.Record"/></param>
        public virtual void Process(Org.Apache.Kafka.Streams.Processor.Api.Record arg0)
        {
            hasOverrideProcess = false;
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/api/Processor.html#close--"/>
        /// </summary>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void CloseDefault()
        {
            IExecuteWithSignature("closeDefault", "()V");
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/api/Processor.html#close--"/>
        /// </summary>
        /// <remarks>If <see cref="OnClose"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action OnClose { get; set; } = null;

        bool hasOverrideClose = true;
        void CloseEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideClose = true;
            var methodToExecute = (OnClose != null) ? OnClose : Close;
            methodToExecute.Invoke();
            data.EventData.TypedEventData.HasOverride = hasOverrideClose;
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/api/Processor.html#close--"/>
        /// </summary>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="CloseDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void Close()
        {
            hasOverrideClose = false;
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/api/Processor.html#init-org.apache.kafka.streams.processor.api.ProcessorContext-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.ProcessorContext"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void InitDefault(Org.Apache.Kafka.Streams.Processor.Api.ProcessorContext arg0)
        {
            IExecuteWithSignature("initDefault", "(Lorg/apache/kafka/streams/processor/api/ProcessorContext;)V", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/api/Processor.html#init-org.apache.kafka.streams.processor.api.ProcessorContext-"/>
        /// </summary>
        /// <remarks>If <see cref="OnInit"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Org.Apache.Kafka.Streams.Processor.Api.ProcessorContext> OnInit { get; set; } = null;

        bool hasOverrideInit = true;
        void InitEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideInit = true;
            var methodToExecute = (OnInit != null) ? OnInit : Init;
            methodToExecute.Invoke(data.EventData.GetAt<Org.Apache.Kafka.Streams.Processor.Api.ProcessorContext>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideInit;
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/api/Processor.html#init-org.apache.kafka.streams.processor.api.ProcessorContext-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.ProcessorContext"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="InitDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void Init(Org.Apache.Kafka.Streams.Processor.Api.ProcessorContext arg0)
        {
            hasOverrideInit = false;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ProcessorDirect implementation
    public partial class ProcessorDirect
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/api/Processor.html#process-org.apache.kafka.streams.processor.api.Record-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.Record"/></param>
        public override void Process(Org.Apache.Kafka.Streams.Processor.Api.Record arg0)
        {
            IExecuteWithSignature("process", "(Lorg/apache/kafka/streams/processor/api/Record;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/api/Processor.html#close--"/>
        /// </summary>
        public override void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/api/Processor.html#init-org.apache.kafka.streams.processor.api.ProcessorContext-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.ProcessorContext"/></param>
        public override void Init(Org.Apache.Kafka.Streams.Processor.Api.ProcessorContext arg0)
        {
            IExecuteWithSignature("init", "(Lorg/apache/kafka/streams/processor/api/ProcessorContext;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IProcessor<KIn, VIn, KOut, VOut>
    /// <summary>
    /// .NET interface for org.mases.knet.generated.org.apache.kafka.streams.processor.api.Processor implementing <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/api/Processor.html"/>
    /// </summary>
    public partial interface IProcessor<KIn, VIn, KOut, VOut>
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Processor<KIn, VIn, KOut, VOut> implementation
    public partial class Processor<KIn, VIn, KOut, VOut> : Org.Apache.Kafka.Streams.Processor.Api.IProcessor<KIn, VIn, KOut, VOut>
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
        /// Handlers initializer for <see cref="Processor"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("process", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ProcessEventHandler));
            AddEventHandler("close", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(CloseEventHandler));
            AddEventHandler("init", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(InitEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/api/Processor.html#process-org.apache.kafka.streams.processor.api.Record-"/>
        /// </summary>
        /// <remarks>If <see cref="OnProcess"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Org.Apache.Kafka.Streams.Processor.Api.Record<KIn, VIn>> OnProcess { get; set; } = null;

        bool hasOverrideProcess = true;
        void ProcessEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideProcess = true;
            var methodToExecute = (OnProcess != null) ? OnProcess : Process;
            methodToExecute.Invoke(data.EventData.GetAt<Org.Apache.Kafka.Streams.Processor.Api.Record<KIn, VIn>>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideProcess;
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/api/Processor.html#process-org.apache.kafka.streams.processor.api.Record-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.Record"/></param>
        public virtual void Process(Org.Apache.Kafka.Streams.Processor.Api.Record<KIn, VIn> arg0)
        {
            hasOverrideProcess = false;
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/api/Processor.html#close--"/>
        /// </summary>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void CloseDefault()
        {
            IExecuteWithSignature("closeDefault", "()V");
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/api/Processor.html#close--"/>
        /// </summary>
        /// <remarks>If <see cref="OnClose"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action OnClose { get; set; } = null;

        bool hasOverrideClose = true;
        void CloseEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideClose = true;
            var methodToExecute = (OnClose != null) ? OnClose : Close;
            methodToExecute.Invoke();
            data.EventData.TypedEventData.HasOverride = hasOverrideClose;
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/api/Processor.html#close--"/>
        /// </summary>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="CloseDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void Close()
        {
            hasOverrideClose = false;
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/api/Processor.html#init-org.apache.kafka.streams.processor.api.ProcessorContext-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.ProcessorContext"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void InitDefault(Org.Apache.Kafka.Streams.Processor.Api.ProcessorContext<KOut, VOut> arg0)
        {
            IExecuteWithSignature("initDefault", "(Lorg/apache/kafka/streams/processor/api/ProcessorContext;)V", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/api/Processor.html#init-org.apache.kafka.streams.processor.api.ProcessorContext-"/>
        /// </summary>
        /// <remarks>If <see cref="OnInit"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Org.Apache.Kafka.Streams.Processor.Api.ProcessorContext<KOut, VOut>> OnInit { get; set; } = null;

        bool hasOverrideInit = true;
        void InitEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideInit = true;
            var methodToExecute = (OnInit != null) ? OnInit : Init;
            methodToExecute.Invoke(data.EventData.GetAt<Org.Apache.Kafka.Streams.Processor.Api.ProcessorContext<KOut, VOut>>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideInit;
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/api/Processor.html#init-org.apache.kafka.streams.processor.api.ProcessorContext-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.ProcessorContext"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="InitDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void Init(Org.Apache.Kafka.Streams.Processor.Api.ProcessorContext<KOut, VOut> arg0)
        {
            hasOverrideInit = false;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ProcessorDirect<KIn, VIn, KOut, VOut> implementation
    public partial class ProcessorDirect<KIn, VIn, KOut, VOut> : Org.Apache.Kafka.Streams.Processor.Api.IProcessor<KIn, VIn, KOut, VOut>
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/api/Processor.html#process-org.apache.kafka.streams.processor.api.Record-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.Record"/></param>
        public override void Process(Org.Apache.Kafka.Streams.Processor.Api.Record<KIn, VIn> arg0)
        {
            IExecuteWithSignature("process", "(Lorg/apache/kafka/streams/processor/api/Record;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/api/Processor.html#close--"/>
        /// </summary>
        public override void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/api/Processor.html#init-org.apache.kafka.streams.processor.api.ProcessorContext-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.ProcessorContext"/></param>
        public override void Init(Org.Apache.Kafka.Streams.Processor.Api.ProcessorContext<KOut, VOut> arg0)
        {
            IExecuteWithSignature("init", "(Lorg/apache/kafka/streams/processor/api/ProcessorContext;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}