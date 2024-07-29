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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using kafka-streams-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Processor.Api
{
    #region FixedKeyProcessor
    public partial class FixedKeyProcessor
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
        /// Handlers initializer for <see cref="FixedKeyProcessor"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("process", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Streams.Processor.Api.FixedKeyRecord>>>(ProcessEventHandler));
            AddEventHandler("close", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(CloseEventHandler));
            AddEventHandler("init", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Streams.Processor.Api.FixedKeyProcessorContext>>>(InitEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/api/FixedKeyProcessor.html#process-org.apache.kafka.streams.processor.api.FixedKeyRecord-"/>
        /// </summary>
        /// <remarks>If <see cref="OnProcess"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Org.Apache.Kafka.Streams.Processor.Api.FixedKeyRecord> OnProcess { get; set; } = null;

        void ProcessEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Streams.Processor.Api.FixedKeyRecord>> data)
        {
            var methodToExecute = (OnProcess != null) ? OnProcess : Process;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/api/FixedKeyProcessor.html#process-org.apache.kafka.streams.processor.api.FixedKeyRecord-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.FixedKeyRecord"/></param>
        public virtual void Process(Org.Apache.Kafka.Streams.Processor.Api.FixedKeyRecord arg0)
        {
            
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/api/FixedKeyProcessor.html#close--"/>
        /// </summary>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void CloseDefault()
        {
            IExecuteWithSignature("closeDefault", "()V");
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/api/FixedKeyProcessor.html#close--"/>
        /// </summary>
        /// <remarks>If <see cref="OnClose"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action OnClose { get; set; } = null;

        void CloseEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnClose != null) ? OnClose : Close;
            methodToExecute.Invoke();
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/api/FixedKeyProcessor.html#close--"/>
        /// </summary>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="CloseDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void Close()
        {
            CloseDefault();
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/api/FixedKeyProcessor.html#init-org.apache.kafka.streams.processor.api.FixedKeyProcessorContext-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.FixedKeyProcessorContext"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void InitDefault(Org.Apache.Kafka.Streams.Processor.Api.FixedKeyProcessorContext arg0)
        {
            IExecuteWithSignature("initDefault", "(Lorg/apache/kafka/streams/processor/api/FixedKeyProcessorContext;)V", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/api/FixedKeyProcessor.html#init-org.apache.kafka.streams.processor.api.FixedKeyProcessorContext-"/>
        /// </summary>
        /// <remarks>If <see cref="OnInit"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Org.Apache.Kafka.Streams.Processor.Api.FixedKeyProcessorContext> OnInit { get; set; } = null;

        void InitEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Streams.Processor.Api.FixedKeyProcessorContext>> data)
        {
            var methodToExecute = (OnInit != null) ? OnInit : Init;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/api/FixedKeyProcessor.html#init-org.apache.kafka.streams.processor.api.FixedKeyProcessorContext-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.FixedKeyProcessorContext"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="InitDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void Init(Org.Apache.Kafka.Streams.Processor.Api.FixedKeyProcessorContext arg0)
        {
            InitDefault(arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region FixedKeyProcessorDirect
    public partial class FixedKeyProcessorDirect
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/api/FixedKeyProcessor.html#process-org.apache.kafka.streams.processor.api.FixedKeyRecord-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.FixedKeyRecord"/></param>
        public override void Process(Org.Apache.Kafka.Streams.Processor.Api.FixedKeyRecord arg0)
        {
            IExecuteWithSignature("process", "(Lorg/apache/kafka/streams/processor/api/FixedKeyRecord;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/api/FixedKeyProcessor.html#close--"/>
        /// </summary>
        public override void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/api/FixedKeyProcessor.html#init-org.apache.kafka.streams.processor.api.FixedKeyProcessorContext-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.FixedKeyProcessorContext"/></param>
        public override void Init(Org.Apache.Kafka.Streams.Processor.Api.FixedKeyProcessorContext arg0)
        {
            IExecuteWithSignature("init", "(Lorg/apache/kafka/streams/processor/api/FixedKeyProcessorContext;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IFixedKeyProcessor<KIn, VIn, VOut>
    /// <summary>
    /// .NET interface for org.mases.knet.generated.org.apache.kafka.streams.processor.api.FixedKeyProcessor implementing <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/api/FixedKeyProcessor.html"/>
    /// </summary>
    public partial interface IFixedKeyProcessor<KIn, VIn, VOut>
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region FixedKeyProcessor<KIn, VIn, VOut>
    public partial class FixedKeyProcessor<KIn, VIn, VOut> : Org.Apache.Kafka.Streams.Processor.Api.IFixedKeyProcessor<KIn, VIn, VOut>
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
        /// Handlers initializer for <see cref="FixedKeyProcessor"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("process", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Streams.Processor.Api.FixedKeyRecord<KIn, VIn>>>>(ProcessEventHandler));
            AddEventHandler("close", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(CloseEventHandler));
            AddEventHandler("init", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Streams.Processor.Api.FixedKeyProcessorContext<KIn, VOut>>>>(InitEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/api/FixedKeyProcessor.html#process-org.apache.kafka.streams.processor.api.FixedKeyRecord-"/>
        /// </summary>
        /// <remarks>If <see cref="OnProcess"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Org.Apache.Kafka.Streams.Processor.Api.FixedKeyRecord<KIn, VIn>> OnProcess { get; set; } = null;

        void ProcessEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Streams.Processor.Api.FixedKeyRecord<KIn, VIn>>> data)
        {
            var methodToExecute = (OnProcess != null) ? OnProcess : Process;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/api/FixedKeyProcessor.html#process-org.apache.kafka.streams.processor.api.FixedKeyRecord-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.FixedKeyRecord"/></param>
        public virtual void Process(Org.Apache.Kafka.Streams.Processor.Api.FixedKeyRecord<KIn, VIn> arg0)
        {
            
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/api/FixedKeyProcessor.html#close--"/>
        /// </summary>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void CloseDefault()
        {
            IExecuteWithSignature("closeDefault", "()V");
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/api/FixedKeyProcessor.html#close--"/>
        /// </summary>
        /// <remarks>If <see cref="OnClose"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action OnClose { get; set; } = null;

        void CloseEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnClose != null) ? OnClose : Close;
            methodToExecute.Invoke();
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/api/FixedKeyProcessor.html#close--"/>
        /// </summary>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="CloseDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void Close()
        {
            CloseDefault();
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/api/FixedKeyProcessor.html#init-org.apache.kafka.streams.processor.api.FixedKeyProcessorContext-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.FixedKeyProcessorContext"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void InitDefault(Org.Apache.Kafka.Streams.Processor.Api.FixedKeyProcessorContext<KIn, VOut> arg0)
        {
            IExecuteWithSignature("initDefault", "(Lorg/apache/kafka/streams/processor/api/FixedKeyProcessorContext;)V", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/api/FixedKeyProcessor.html#init-org.apache.kafka.streams.processor.api.FixedKeyProcessorContext-"/>
        /// </summary>
        /// <remarks>If <see cref="OnInit"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Org.Apache.Kafka.Streams.Processor.Api.FixedKeyProcessorContext<KIn, VOut>> OnInit { get; set; } = null;

        void InitEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Streams.Processor.Api.FixedKeyProcessorContext<KIn, VOut>>> data)
        {
            var methodToExecute = (OnInit != null) ? OnInit : Init;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/api/FixedKeyProcessor.html#init-org.apache.kafka.streams.processor.api.FixedKeyProcessorContext-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.FixedKeyProcessorContext"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="InitDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void Init(Org.Apache.Kafka.Streams.Processor.Api.FixedKeyProcessorContext<KIn, VOut> arg0)
        {
            InitDefault(arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region FixedKeyProcessorDirect<KIn, VIn, VOut>
    public partial class FixedKeyProcessorDirect<KIn, VIn, VOut> : Org.Apache.Kafka.Streams.Processor.Api.IFixedKeyProcessor<KIn, VIn, VOut>
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/api/FixedKeyProcessor.html#process-org.apache.kafka.streams.processor.api.FixedKeyRecord-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.FixedKeyRecord"/></param>
        public override void Process(Org.Apache.Kafka.Streams.Processor.Api.FixedKeyRecord<KIn, VIn> arg0)
        {
            IExecuteWithSignature("process", "(Lorg/apache/kafka/streams/processor/api/FixedKeyRecord;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/api/FixedKeyProcessor.html#close--"/>
        /// </summary>
        public override void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/api/FixedKeyProcessor.html#init-org.apache.kafka.streams.processor.api.FixedKeyProcessorContext-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.FixedKeyProcessorContext"/></param>
        public override void Init(Org.Apache.Kafka.Streams.Processor.Api.FixedKeyProcessorContext<KIn, VOut> arg0)
        {
            IExecuteWithSignature("init", "(Lorg/apache/kafka/streams/processor/api/FixedKeyProcessorContext;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}