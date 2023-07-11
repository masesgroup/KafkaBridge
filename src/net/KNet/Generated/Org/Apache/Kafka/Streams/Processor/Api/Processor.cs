/*
*  Copyright 2023 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using kafka-streams-3.5.0.jar as reference
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
            AddEventHandler("process", new System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Streams.Processor.Api.Record>>>(ProcessEventHandler)); OnProcess = Process;
            AddEventHandler("close", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(CloseEventHandler)); OnClose = Close;
            AddEventHandler("init", new System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Streams.Processor.Api.ProcessorContext>>>(InitEventHandler)); OnInit = Init;

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/processor/api/Processor.html#process-org.apache.kafka.streams.processor.api.Record-"/>
        /// </summary>
        public System.Action<Org.Apache.Kafka.Streams.Processor.Api.Record> OnProcess { get; set; }

        void ProcessEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Streams.Processor.Api.Record>> data)
        {
            if (OnProcess != null) OnProcess.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/processor/api/Processor.html#process-org.apache.kafka.streams.processor.api.Record-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.Record"/></param>
        public virtual void Process(Org.Apache.Kafka.Streams.Processor.Api.Record arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/processor/api/Processor.html#close--"/>
        /// </summary>
        public System.Action OnClose { get; set; }

        void CloseEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            if (OnClose != null) OnClose.Invoke();
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/processor/api/Processor.html#close--"/>
        /// </summary>
        public virtual void Close()
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/processor/api/Processor.html#init-org.apache.kafka.streams.processor.api.ProcessorContext-"/>
        /// </summary>
        public System.Action<Org.Apache.Kafka.Streams.Processor.Api.ProcessorContext> OnInit { get; set; }

        void InitEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Streams.Processor.Api.ProcessorContext>> data)
        {
            if (OnInit != null) OnInit.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/processor/api/Processor.html#init-org.apache.kafka.streams.processor.api.ProcessorContext-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.ProcessorContext"/></param>
        public virtual void Init(Org.Apache.Kafka.Streams.Processor.Api.ProcessorContext arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IProcessor<KIn, VIn, KOut, VOut>
    /// <summary>
    /// .NET interface for org.mases.knet.generated.org.apache.kafka.streams.processor.api.Processor implementing <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/processor/api/Processor.html"/>
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
            AddEventHandler("process", new System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Streams.Processor.Api.Record<KIn, VIn>>>>(ProcessEventHandler)); OnProcess = Process;
            AddEventHandler("close", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(CloseEventHandler)); OnClose = Close;
            AddEventHandler("init", new System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Streams.Processor.Api.ProcessorContext<KOut, VOut>>>>(InitEventHandler)); OnInit = Init;

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/processor/api/Processor.html#process-org.apache.kafka.streams.processor.api.Record-"/>
        /// </summary>
        public System.Action<Org.Apache.Kafka.Streams.Processor.Api.Record<KIn, VIn>> OnProcess { get; set; }

        void ProcessEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Streams.Processor.Api.Record<KIn, VIn>>> data)
        {
            if (OnProcess != null) OnProcess.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/processor/api/Processor.html#process-org.apache.kafka.streams.processor.api.Record-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.Record"/></param>
        public virtual void Process(Org.Apache.Kafka.Streams.Processor.Api.Record<KIn, VIn> arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/processor/api/Processor.html#close--"/>
        /// </summary>
        public System.Action OnClose { get; set; }

        void CloseEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            if (OnClose != null) OnClose.Invoke();
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/processor/api/Processor.html#close--"/>
        /// </summary>
        public virtual void Close()
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/processor/api/Processor.html#init-org.apache.kafka.streams.processor.api.ProcessorContext-"/>
        /// </summary>
        public System.Action<Org.Apache.Kafka.Streams.Processor.Api.ProcessorContext<KOut, VOut>> OnInit { get; set; }

        void InitEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Streams.Processor.Api.ProcessorContext<KOut, VOut>>> data)
        {
            if (OnInit != null) OnInit.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/processor/api/Processor.html#init-org.apache.kafka.streams.processor.api.ProcessorContext-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.ProcessorContext"/></param>
        public virtual void Init(Org.Apache.Kafka.Streams.Processor.Api.ProcessorContext<KOut, VOut> arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}