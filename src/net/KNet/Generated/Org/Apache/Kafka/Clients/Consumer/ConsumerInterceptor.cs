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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using kafka-clients-3.9.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Consumer
{
    #region ConsumerInterceptor declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/consumer/ConsumerInterceptor.html"/>
    /// </summary>
    public partial class ConsumerInterceptor : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ConsumerInterceptor() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.knet.generated.org.apache.kafka.clients.consumer.ConsumerInterceptor";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region ConsumerInterceptorDirect declaration
    /// <summary>
    /// Direct override of <see cref="ConsumerInterceptor"/> or its generic type if there is one
    /// </summary>
    public partial class ConsumerInterceptorDirect : ConsumerInterceptor
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "org.apache.kafka.clients.consumer.ConsumerInterceptor";
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

    #region ConsumerInterceptor<K, V> declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/consumer/ConsumerInterceptor.html"/>
    /// </summary>
    /// <typeparam name="K"></typeparam>
    /// <typeparam name="V"></typeparam>
    public partial class ConsumerInterceptor<K, V> : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ConsumerInterceptor() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.knet.generated.org.apache.kafka.clients.consumer.ConsumerInterceptor";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class
    
    }
    #endregion

    #region ConsumerInterceptorDirect<K, V> declaration
    /// <summary>
    /// Direct override of <see cref="ConsumerInterceptor"/> or its generic type if there is one
    /// </summary>
    public partial class ConsumerInterceptorDirect<K, V> : ConsumerInterceptor<K, V>
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "org.apache.kafka.clients.consumer.ConsumerInterceptor";
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

    #region ConsumerInterceptor implementation
    public partial class ConsumerInterceptor
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
        /// Handlers initializer for <see cref="ConsumerInterceptor"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("onConsume", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnConsumeEventHandler));
            AddEventHandler("close", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(CloseEventHandler));
            AddEventHandler("onCommit", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnCommitEventHandler));
            AddEventHandler("configure", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ConfigureEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/consumer/ConsumerInterceptor.html#onConsume-org.apache.kafka.clients.consumer.ConsumerRecords-"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnConsume"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Org.Apache.Kafka.Clients.Consumer.ConsumerRecords, Org.Apache.Kafka.Clients.Consumer.ConsumerRecords> OnOnConsume { get; set; } = null;

        bool hasOverrideOnConsume = true;
        void OnConsumeEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideOnConsume = true;
            var methodToExecute = (OnOnConsume != null) ? OnOnConsume : OnConsume;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Org.Apache.Kafka.Clients.Consumer.ConsumerRecords>(0));
            data.EventData.TypedEventData.SetReturnData(hasOverrideOnConsume, executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/consumer/ConsumerInterceptor.html#onConsume-org.apache.kafka.clients.consumer.ConsumerRecords-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerRecords"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerRecords"/></returns>
        public virtual Org.Apache.Kafka.Clients.Consumer.ConsumerRecords OnConsume(Org.Apache.Kafka.Clients.Consumer.ConsumerRecords arg0)
        {
            hasOverrideOnConsume = false; return default;
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/consumer/ConsumerInterceptor.html#close--"/>
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/consumer/ConsumerInterceptor.html#close--"/>
        /// </summary>
        public virtual void Close()
        {
            hasOverrideClose = false;
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/consumer/ConsumerInterceptor.html#onCommit-java.util.Map-"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnCommit"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Util.Map> OnOnCommit { get; set; } = null;

        bool hasOverrideOnCommit = true;
        void OnCommitEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideOnCommit = true;
            var methodToExecute = (OnOnCommit != null) ? OnOnCommit : OnCommit;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Util.Map>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideOnCommit;
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/consumer/ConsumerInterceptor.html#onCommit-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public virtual void OnCommit(Java.Util.Map arg0)
        {
            hasOverrideOnCommit = false;
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/Configurable.html#configure-java.util.Map-"/>
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/Configurable.html#configure-java.util.Map-"/>
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

    #region ConsumerInterceptorDirect implementation
    public partial class ConsumerInterceptorDirect
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/consumer/ConsumerInterceptor.html#onConsume-org.apache.kafka.clients.consumer.ConsumerRecords-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerRecords"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerRecords"/></returns>
        public override Org.Apache.Kafka.Clients.Consumer.ConsumerRecords OnConsume(Org.Apache.Kafka.Clients.Consumer.ConsumerRecords arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Clients.Consumer.ConsumerRecords>("onConsume", "(Lorg/apache/kafka/clients/consumer/ConsumerRecords;)Lorg/apache/kafka/clients/consumer/ConsumerRecords;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/consumer/ConsumerInterceptor.html#close--"/>
        /// </summary>
        public override void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/consumer/ConsumerInterceptor.html#onCommit-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public override void OnCommit(Java.Util.Map arg0)
        {
            IExecuteWithSignature("onCommit", "(Ljava/util/Map;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/Configurable.html#configure-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public override void Configure(Java.Util.Map arg0)
        {
            IExecuteWithSignature("configure", "(Ljava/util/Map;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IConsumerInterceptor<K, V>
    /// <summary>
    /// .NET interface for org.mases.knet.generated.org.apache.kafka.clients.consumer.ConsumerInterceptor implementing <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/consumer/ConsumerInterceptor.html"/>
    /// </summary>
    public partial interface IConsumerInterceptor<K, V>
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ConsumerInterceptor<K, V> implementation
    public partial class ConsumerInterceptor<K, V> : Org.Apache.Kafka.Clients.Consumer.IConsumerInterceptor<K, V>, Org.Apache.Kafka.Common.IConfigurable, Java.Lang.IAutoCloseable
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
        /// Handlers initializer for <see cref="ConsumerInterceptor"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("onConsume", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnConsumeEventHandler));
            AddEventHandler("close", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(CloseEventHandler));
            AddEventHandler("onCommit", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnCommitEventHandler));
            AddEventHandler("configure", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ConfigureEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/consumer/ConsumerInterceptor.html#onConsume-org.apache.kafka.clients.consumer.ConsumerRecords-"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnConsume"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Org.Apache.Kafka.Clients.Consumer.ConsumerRecords<K, V>, Org.Apache.Kafka.Clients.Consumer.ConsumerRecords<K, V>> OnOnConsume { get; set; } = null;

        bool hasOverrideOnConsume = true;
        void OnConsumeEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideOnConsume = true;
            var methodToExecute = (OnOnConsume != null) ? OnOnConsume : OnConsume;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Org.Apache.Kafka.Clients.Consumer.ConsumerRecords<K, V>>(0));
            data.EventData.TypedEventData.SetReturnData(hasOverrideOnConsume, executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/consumer/ConsumerInterceptor.html#onConsume-org.apache.kafka.clients.consumer.ConsumerRecords-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerRecords"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerRecords"/></returns>
        public virtual Org.Apache.Kafka.Clients.Consumer.ConsumerRecords<K, V> OnConsume(Org.Apache.Kafka.Clients.Consumer.ConsumerRecords<K, V> arg0)
        {
            hasOverrideOnConsume = false; return default;
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/consumer/ConsumerInterceptor.html#close--"/>
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/consumer/ConsumerInterceptor.html#close--"/>
        /// </summary>
        public virtual void Close()
        {
            hasOverrideClose = false;
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/consumer/ConsumerInterceptor.html#onCommit-java.util.Map-"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnCommit"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Clients.Consumer.OffsetAndMetadata>> OnOnCommit { get; set; } = null;

        bool hasOverrideOnCommit = true;
        void OnCommitEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideOnCommit = true;
            var methodToExecute = (OnOnCommit != null) ? OnOnCommit : OnCommit;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Clients.Consumer.OffsetAndMetadata>>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideOnCommit;
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/consumer/ConsumerInterceptor.html#onCommit-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public virtual void OnCommit(Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Clients.Consumer.OffsetAndMetadata> arg0)
        {
            hasOverrideOnCommit = false;
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/Configurable.html#configure-java.util.Map-"/>
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/Configurable.html#configure-java.util.Map-"/>
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

    #region ConsumerInterceptorDirect<K, V> implementation
    public partial class ConsumerInterceptorDirect<K, V> : Org.Apache.Kafka.Clients.Consumer.IConsumerInterceptor<K, V>, Org.Apache.Kafka.Common.IConfigurable, Java.Lang.IAutoCloseable
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/consumer/ConsumerInterceptor.html#onConsume-org.apache.kafka.clients.consumer.ConsumerRecords-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerRecords"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerRecords"/></returns>
        public override Org.Apache.Kafka.Clients.Consumer.ConsumerRecords<K, V> OnConsume(Org.Apache.Kafka.Clients.Consumer.ConsumerRecords<K, V> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Clients.Consumer.ConsumerRecords<K, V>>("onConsume", "(Lorg/apache/kafka/clients/consumer/ConsumerRecords;)Lorg/apache/kafka/clients/consumer/ConsumerRecords;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/consumer/ConsumerInterceptor.html#close--"/>
        /// </summary>
        public override void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/consumer/ConsumerInterceptor.html#onCommit-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public override void OnCommit(Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Clients.Consumer.OffsetAndMetadata> arg0)
        {
            IExecuteWithSignature("onCommit", "(Ljava/util/Map;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/Configurable.html#configure-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public override void Configure(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            IExecuteWithSignature("configure", "(Ljava/util/Map;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}