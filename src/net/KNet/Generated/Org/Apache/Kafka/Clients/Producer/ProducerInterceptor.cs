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
*  using kafka-clients-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Producer
{
    #region ProducerInterceptor declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/ProducerInterceptor.html"/>
    /// </summary>
    public partial class ProducerInterceptor : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ProducerInterceptor() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.knet.generated.org.apache.kafka.clients.producer.ProducerInterceptor";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region ProducerInterceptorDirect declaration
    /// <summary>
    /// Direct override of <see cref="ProducerInterceptor"/> or its generic type if there is one
    /// </summary>
    public partial class ProducerInterceptorDirect : ProducerInterceptor
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "org.apache.kafka.clients.producer.ProducerInterceptor";
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

    #region ProducerInterceptor<K, V> declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/ProducerInterceptor.html"/>
    /// </summary>
    /// <typeparam name="K"></typeparam>
    /// <typeparam name="V"></typeparam>
    public partial class ProducerInterceptor<K, V> : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ProducerInterceptor() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.knet.generated.org.apache.kafka.clients.producer.ProducerInterceptor";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class
    
    }
    #endregion

    #region ProducerInterceptorDirect<K, V> declaration
    /// <summary>
    /// Direct override of <see cref="ProducerInterceptor"/> or its generic type if there is one
    /// </summary>
    public partial class ProducerInterceptorDirect<K, V> : ProducerInterceptor<K, V>
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "org.apache.kafka.clients.producer.ProducerInterceptor";
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

    #region ProducerInterceptor implementation
    public partial class ProducerInterceptor
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
        /// Handlers initializer for <see cref="ProducerInterceptor"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("onSend", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnSendEventHandler));
            AddEventHandler("close", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(CloseEventHandler));
            AddEventHandler("onAcknowledgement", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnAcknowledgementEventHandler));
            AddEventHandler("configure", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ConfigureEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/ProducerInterceptor.html#onSend-org.apache.kafka.clients.producer.ProducerRecord-"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnSend"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Org.Apache.Kafka.Clients.Producer.ProducerRecord, Org.Apache.Kafka.Clients.Producer.ProducerRecord> OnOnSend { get; set; } = null;

        bool hasOverrideOnSend = true;
        void OnSendEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideOnSend = true;
            var methodToExecute = (OnOnSend != null) ? OnOnSend : OnSend;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Org.Apache.Kafka.Clients.Producer.ProducerRecord>(0));
            data.EventData.TypedEventData.SetReturnData(hasOverrideOnSend, executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/ProducerInterceptor.html#onSend-org.apache.kafka.clients.producer.ProducerRecord-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Producer.ProducerRecord"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Producer.ProducerRecord"/></returns>
        public virtual Org.Apache.Kafka.Clients.Producer.ProducerRecord OnSend(Org.Apache.Kafka.Clients.Producer.ProducerRecord arg0)
        {
            hasOverrideOnSend = false; return default;
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/ProducerInterceptor.html#close--"/>
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/ProducerInterceptor.html#close--"/>
        /// </summary>
        public virtual void Close()
        {
            hasOverrideClose = false;
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/ProducerInterceptor.html#onAcknowledgement-org.apache.kafka.clients.producer.RecordMetadata-java.lang.Exception-"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnAcknowledgement"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Org.Apache.Kafka.Clients.Producer.RecordMetadata, MASES.JCOBridge.C2JBridge.JVMBridgeException> OnOnAcknowledgement { get; set; } = null;

        bool hasOverrideOnAcknowledgement = true;
        void OnAcknowledgementEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideOnAcknowledgement = true;
            var methodToExecute = (OnOnAcknowledgement != null) ? OnOnAcknowledgement : OnAcknowledgement;
            methodToExecute.Invoke(data.EventData.GetAt<Org.Apache.Kafka.Clients.Producer.RecordMetadata>(0), JVMBridgeException.New(data.EventData.ExtraData.Get(1) as MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject));
            data.EventData.TypedEventData.HasOverride = hasOverrideOnAcknowledgement;
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/ProducerInterceptor.html#onAcknowledgement-org.apache.kafka.clients.producer.RecordMetadata-java.lang.Exception-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Producer.RecordMetadata"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Exception"/></param>
        public virtual void OnAcknowledgement(Org.Apache.Kafka.Clients.Producer.RecordMetadata arg0, MASES.JCOBridge.C2JBridge.JVMBridgeException arg1)
        {
            hasOverrideOnAcknowledgement = false;
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/Configurable.html#configure-java.util.Map-"/>
        /// </summary>
        /// <remarks>If <see cref="OnConfigure"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Util.Map> OnConfigure { get; set; } = null;

        bool hasOverrideConfigure = true;
        void ConfigureEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideConfigure = true;
            var methodToExecute = (OnConfigure != null) ? OnConfigure : Configure;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Util.Map>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideConfigure;
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/Configurable.html#configure-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public virtual void Configure(Java.Util.Map arg0)
        {
            hasOverrideConfigure = false;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ProducerInterceptorDirect implementation
    public partial class ProducerInterceptorDirect
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/ProducerInterceptor.html#onSend-org.apache.kafka.clients.producer.ProducerRecord-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Producer.ProducerRecord"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Producer.ProducerRecord"/></returns>
        public override Org.Apache.Kafka.Clients.Producer.ProducerRecord OnSend(Org.Apache.Kafka.Clients.Producer.ProducerRecord arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Clients.Producer.ProducerRecord>("onSend", "(Lorg/apache/kafka/clients/producer/ProducerRecord;)Lorg/apache/kafka/clients/producer/ProducerRecord;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/ProducerInterceptor.html#close--"/>
        /// </summary>
        public override void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/ProducerInterceptor.html#onAcknowledgement-org.apache.kafka.clients.producer.RecordMetadata-java.lang.Exception-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Producer.RecordMetadata"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Exception"/></param>
        public override void OnAcknowledgement(Org.Apache.Kafka.Clients.Producer.RecordMetadata arg0, MASES.JCOBridge.C2JBridge.JVMBridgeException arg1)
        {
            IExecute("onAcknowledgement", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/Configurable.html#configure-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public override void Configure(Java.Util.Map arg0)
        {
            IExecute("configure", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IProducerInterceptor<K, V>
    /// <summary>
    /// .NET interface for org.mases.knet.generated.org.apache.kafka.clients.producer.ProducerInterceptor implementing <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/ProducerInterceptor.html"/>
    /// </summary>
    public partial interface IProducerInterceptor<K, V>
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ProducerInterceptor<K, V> implementation
    public partial class ProducerInterceptor<K, V> : Org.Apache.Kafka.Clients.Producer.IProducerInterceptor<K, V>, Org.Apache.Kafka.Common.IConfigurable, Java.Lang.IAutoCloseable
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
        /// Handlers initializer for <see cref="ProducerInterceptor"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("onSend", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnSendEventHandler));
            AddEventHandler("close", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(CloseEventHandler));
            AddEventHandler("onAcknowledgement", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnAcknowledgementEventHandler));
            AddEventHandler("configure", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ConfigureEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/ProducerInterceptor.html#onSend-org.apache.kafka.clients.producer.ProducerRecord-"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnSend"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Org.Apache.Kafka.Clients.Producer.ProducerRecord<K, V>, Org.Apache.Kafka.Clients.Producer.ProducerRecord<K, V>> OnOnSend { get; set; } = null;

        bool hasOverrideOnSend = true;
        void OnSendEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideOnSend = true;
            var methodToExecute = (OnOnSend != null) ? OnOnSend : OnSend;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Org.Apache.Kafka.Clients.Producer.ProducerRecord<K, V>>(0));
            data.EventData.TypedEventData.SetReturnData(hasOverrideOnSend, executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/ProducerInterceptor.html#onSend-org.apache.kafka.clients.producer.ProducerRecord-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Producer.ProducerRecord"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Producer.ProducerRecord"/></returns>
        public virtual Org.Apache.Kafka.Clients.Producer.ProducerRecord<K, V> OnSend(Org.Apache.Kafka.Clients.Producer.ProducerRecord<K, V> arg0)
        {
            hasOverrideOnSend = false; return default;
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/ProducerInterceptor.html#close--"/>
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/ProducerInterceptor.html#close--"/>
        /// </summary>
        public virtual void Close()
        {
            hasOverrideClose = false;
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/ProducerInterceptor.html#onAcknowledgement-org.apache.kafka.clients.producer.RecordMetadata-java.lang.Exception-"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnAcknowledgement"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Org.Apache.Kafka.Clients.Producer.RecordMetadata, MASES.JCOBridge.C2JBridge.JVMBridgeException> OnOnAcknowledgement { get; set; } = null;

        bool hasOverrideOnAcknowledgement = true;
        void OnAcknowledgementEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideOnAcknowledgement = true;
            var methodToExecute = (OnOnAcknowledgement != null) ? OnOnAcknowledgement : OnAcknowledgement;
            methodToExecute.Invoke(data.EventData.GetAt<Org.Apache.Kafka.Clients.Producer.RecordMetadata>(0), JVMBridgeException.New(data.EventData.ExtraData.Get(1) as MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject));
            data.EventData.TypedEventData.HasOverride = hasOverrideOnAcknowledgement;
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/ProducerInterceptor.html#onAcknowledgement-org.apache.kafka.clients.producer.RecordMetadata-java.lang.Exception-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Producer.RecordMetadata"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Exception"/></param>
        public virtual void OnAcknowledgement(Org.Apache.Kafka.Clients.Producer.RecordMetadata arg0, MASES.JCOBridge.C2JBridge.JVMBridgeException arg1)
        {
            hasOverrideOnAcknowledgement = false;
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/Configurable.html#configure-java.util.Map-"/>
        /// </summary>
        /// <remarks>If <see cref="OnConfigure"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Util.Map<Java.Lang.String, object>> OnConfigure { get; set; } = null;

        bool hasOverrideConfigure = true;
        void ConfigureEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideConfigure = true;
            var methodToExecute = (OnConfigure != null) ? OnConfigure : Configure;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Util.Map<Java.Lang.String, object>>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideConfigure;
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/Configurable.html#configure-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public virtual void Configure(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            hasOverrideConfigure = false;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ProducerInterceptorDirect<K, V> implementation
    public partial class ProducerInterceptorDirect<K, V> : Org.Apache.Kafka.Clients.Producer.IProducerInterceptor<K, V>, Org.Apache.Kafka.Common.IConfigurable, Java.Lang.IAutoCloseable
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/ProducerInterceptor.html#onSend-org.apache.kafka.clients.producer.ProducerRecord-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Producer.ProducerRecord"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Producer.ProducerRecord"/></returns>
        public override Org.Apache.Kafka.Clients.Producer.ProducerRecord<K, V> OnSend(Org.Apache.Kafka.Clients.Producer.ProducerRecord<K, V> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Clients.Producer.ProducerRecord<K, V>>("onSend", "(Lorg/apache/kafka/clients/producer/ProducerRecord;)Lorg/apache/kafka/clients/producer/ProducerRecord;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/ProducerInterceptor.html#close--"/>
        /// </summary>
        public override void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/ProducerInterceptor.html#onAcknowledgement-org.apache.kafka.clients.producer.RecordMetadata-java.lang.Exception-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Producer.RecordMetadata"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Exception"/></param>
        public override void OnAcknowledgement(Org.Apache.Kafka.Clients.Producer.RecordMetadata arg0, MASES.JCOBridge.C2JBridge.JVMBridgeException arg1)
        {
            IExecute("onAcknowledgement", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/Configurable.html#configure-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public override void Configure(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            IExecute("configure", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}