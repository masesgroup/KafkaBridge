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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using kafka-streams-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Processor.Api
{
    #region Processor
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
            AddEventHandler("process", new System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Streams.Processor.Api.Record>>>(ProcessEventHandler));
            AddEventHandler("close", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(CloseEventHandler));
            AddEventHandler("init", new System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Streams.Processor.Api.ProcessorContext>>>(InitEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/api/Processor.html#process-org.apache.kafka.streams.processor.api.Record-"/>
        /// </summary>
        /// <remarks>If <see cref="OnProcess"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Org.Apache.Kafka.Streams.Processor.Api.Record> OnProcess { get; set; } = null;

        void ProcessEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Streams.Processor.Api.Record>> data)
        {
            var methodToExecute = (OnProcess != null) ? OnProcess : Process;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/api/Processor.html#process-org.apache.kafka.streams.processor.api.Record-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.Record"/></param>
        public virtual void Process(Org.Apache.Kafka.Streams.Processor.Api.Record arg0)
        {
            
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/api/Processor.html#close--"/>
        /// </summary>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void CloseDefault()
        {
            IExecuteWithSignature("closeDefault", "()V");
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/api/Processor.html#close--"/>
        /// </summary>
        /// <remarks>If <see cref="OnClose"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action OnClose { get; set; } = null;

        void CloseEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnClose != null) ? OnClose : Close;
            methodToExecute.Invoke();
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/api/Processor.html#close--"/>
        /// </summary>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="CloseDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void Close()
        {
            CloseDefault();
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/api/Processor.html#init-org.apache.kafka.streams.processor.api.ProcessorContext-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.ProcessorContext"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void InitDefault(Org.Apache.Kafka.Streams.Processor.Api.ProcessorContext arg0)
        {
            IExecuteWithSignature("initDefault", "(Lorg/apache/kafka/streams/processor/api/ProcessorContext;)V", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/api/Processor.html#init-org.apache.kafka.streams.processor.api.ProcessorContext-"/>
        /// </summary>
        /// <remarks>If <see cref="OnInit"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Org.Apache.Kafka.Streams.Processor.Api.ProcessorContext> OnInit { get; set; } = null;

        void InitEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Streams.Processor.Api.ProcessorContext>> data)
        {
            var methodToExecute = (OnInit != null) ? OnInit : Init;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/api/Processor.html#init-org.apache.kafka.streams.processor.api.ProcessorContext-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.ProcessorContext"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="InitDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void Init(Org.Apache.Kafka.Streams.Processor.Api.ProcessorContext arg0)
        {
            InitDefault(arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ProcessorDirect
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/api/Processor.html#process-org.apache.kafka.streams.processor.api.Record-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.Record"/></param>
        public override void Process(Org.Apache.Kafka.Streams.Processor.Api.Record arg0)
        {
            IExecuteWithSignature("process", "(Lorg/apache/kafka/streams/processor/api/Record;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/api/Processor.html#close--"/>
        /// </summary>
        public override void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/api/Processor.html#init-org.apache.kafka.streams.processor.api.ProcessorContext-"/>
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
    /// .NET interface for org.mases.knet.generated.org.apache.kafka.streams.processor.api.Processor implementing <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/api/Processor.html"/>
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

    #region Processor<KIn, VIn, KOut, VOut>
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
            AddEventHandler("process", new System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Streams.Processor.Api.Record<KIn, VIn>>>>(ProcessEventHandler));
            AddEventHandler("close", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(CloseEventHandler));
            AddEventHandler("init", new System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Streams.Processor.Api.ProcessorContext<KOut, VOut>>>>(InitEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/api/Processor.html#process-org.apache.kafka.streams.processor.api.Record-"/>
        /// </summary>
        /// <remarks>If <see cref="OnProcess"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Org.Apache.Kafka.Streams.Processor.Api.Record<KIn, VIn>> OnProcess { get; set; } = null;

        void ProcessEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Streams.Processor.Api.Record<KIn, VIn>>> data)
        {
            var methodToExecute = (OnProcess != null) ? OnProcess : Process;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/api/Processor.html#process-org.apache.kafka.streams.processor.api.Record-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.Record"/></param>
        public virtual void Process(Org.Apache.Kafka.Streams.Processor.Api.Record<KIn, VIn> arg0)
        {
            
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/api/Processor.html#close--"/>
        /// </summary>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void CloseDefault()
        {
            IExecuteWithSignature("closeDefault", "()V");
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/api/Processor.html#close--"/>
        /// </summary>
        /// <remarks>If <see cref="OnClose"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action OnClose { get; set; } = null;

        void CloseEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnClose != null) ? OnClose : Close;
            methodToExecute.Invoke();
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/api/Processor.html#close--"/>
        /// </summary>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="CloseDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void Close()
        {
            CloseDefault();
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/api/Processor.html#init-org.apache.kafka.streams.processor.api.ProcessorContext-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.ProcessorContext"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void InitDefault(Org.Apache.Kafka.Streams.Processor.Api.ProcessorContext<KOut, VOut> arg0)
        {
            IExecuteWithSignature("initDefault", "(Lorg/apache/kafka/streams/processor/api/ProcessorContext;)V", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/api/Processor.html#init-org.apache.kafka.streams.processor.api.ProcessorContext-"/>
        /// </summary>
        /// <remarks>If <see cref="OnInit"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Org.Apache.Kafka.Streams.Processor.Api.ProcessorContext<KOut, VOut>> OnInit { get; set; } = null;

        void InitEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Streams.Processor.Api.ProcessorContext<KOut, VOut>>> data)
        {
            var methodToExecute = (OnInit != null) ? OnInit : Init;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/api/Processor.html#init-org.apache.kafka.streams.processor.api.ProcessorContext-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.ProcessorContext"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="InitDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void Init(Org.Apache.Kafka.Streams.Processor.Api.ProcessorContext<KOut, VOut> arg0)
        {
            InitDefault(arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ProcessorDirect<KIn, VIn, KOut, VOut>
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/api/Processor.html#process-org.apache.kafka.streams.processor.api.Record-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.Record"/></param>
        public override void Process(Org.Apache.Kafka.Streams.Processor.Api.Record<KIn, VIn> arg0)
        {
            IExecuteWithSignature("process", "(Lorg/apache/kafka/streams/processor/api/Record;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/api/Processor.html#close--"/>
        /// </summary>
        public override void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/api/Processor.html#init-org.apache.kafka.streams.processor.api.ProcessorContext-"/>
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