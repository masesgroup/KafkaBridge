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
*  using kafka-streams-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams
{
    #region KafkaClientSupplier declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/KafkaClientSupplier.html"/>
    /// </summary>
    public partial class KafkaClientSupplier : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public KafkaClientSupplier() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.knet.generated.org.apache.kafka.streams.KafkaClientSupplier";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region KafkaClientSupplierDirect declaration
    /// <summary>
    /// Direct override of <see cref="KafkaClientSupplier"/> or its generic type if there is one
    /// </summary>
    public partial class KafkaClientSupplierDirect : KafkaClientSupplier
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "org.apache.kafka.streams.KafkaClientSupplier";
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

    #region IKafkaClientSupplier
    /// <summary>
    /// .NET interface for org.mases.knet.generated.org.apache.kafka.streams.KafkaClientSupplier implementing <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/KafkaClientSupplier.html"/>
    /// </summary>
    public partial interface IKafkaClientSupplier
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region KafkaClientSupplier implementation
    public partial class KafkaClientSupplier : Org.Apache.Kafka.Streams.IKafkaClientSupplier
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
        /// Handlers initializer for <see cref="KafkaClientSupplier"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("getConsumer", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(GetConsumerEventHandler));
            AddEventHandler("getGlobalConsumer", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(GetGlobalConsumerEventHandler));
            AddEventHandler("getRestoreConsumer", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(GetRestoreConsumerEventHandler));
            AddEventHandler("getProducer", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(GetProducerEventHandler));
            AddEventHandler("getAdmin", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(GetAdminEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/KafkaClientSupplier.html#getConsumer-java.util.Map-"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetConsumer"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Map<Java.Lang.String, object>, Org.Apache.Kafka.Clients.Consumer.Consumer<byte[], byte[]>> OnGetConsumer { get; set; } = null;

        bool hasOverrideGetConsumer = true;
        void GetConsumerEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideGetConsumer = true;
            var methodToExecute = (OnGetConsumer != null) ? OnGetConsumer : GetConsumer;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Java.Util.Map<Java.Lang.String, object>>(0));
            data.EventData.TypedEventData.SetReturnData(hasOverrideGetConsumer, executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/KafkaClientSupplier.html#getConsumer-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Consumer.Consumer"/></returns>
        public virtual Org.Apache.Kafka.Clients.Consumer.Consumer<byte[], byte[]> GetConsumer(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            hasOverrideGetConsumer = false; return default;
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/KafkaClientSupplier.html#getGlobalConsumer-java.util.Map-"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetGlobalConsumer"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Map<Java.Lang.String, object>, Org.Apache.Kafka.Clients.Consumer.Consumer<byte[], byte[]>> OnGetGlobalConsumer { get; set; } = null;

        bool hasOverrideGetGlobalConsumer = true;
        void GetGlobalConsumerEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideGetGlobalConsumer = true;
            var methodToExecute = (OnGetGlobalConsumer != null) ? OnGetGlobalConsumer : GetGlobalConsumer;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Java.Util.Map<Java.Lang.String, object>>(0));
            data.EventData.TypedEventData.SetReturnData(hasOverrideGetGlobalConsumer, executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/KafkaClientSupplier.html#getGlobalConsumer-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Consumer.Consumer"/></returns>
        public virtual Org.Apache.Kafka.Clients.Consumer.Consumer<byte[], byte[]> GetGlobalConsumer(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            hasOverrideGetGlobalConsumer = false; return default;
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/KafkaClientSupplier.html#getRestoreConsumer-java.util.Map-"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetRestoreConsumer"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Map<Java.Lang.String, object>, Org.Apache.Kafka.Clients.Consumer.Consumer<byte[], byte[]>> OnGetRestoreConsumer { get; set; } = null;

        bool hasOverrideGetRestoreConsumer = true;
        void GetRestoreConsumerEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideGetRestoreConsumer = true;
            var methodToExecute = (OnGetRestoreConsumer != null) ? OnGetRestoreConsumer : GetRestoreConsumer;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Java.Util.Map<Java.Lang.String, object>>(0));
            data.EventData.TypedEventData.SetReturnData(hasOverrideGetRestoreConsumer, executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/KafkaClientSupplier.html#getRestoreConsumer-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Consumer.Consumer"/></returns>
        public virtual Org.Apache.Kafka.Clients.Consumer.Consumer<byte[], byte[]> GetRestoreConsumer(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            hasOverrideGetRestoreConsumer = false; return default;
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/KafkaClientSupplier.html#getProducer-java.util.Map-"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetProducer"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Map<Java.Lang.String, object>, Org.Apache.Kafka.Clients.Producer.Producer<byte[], byte[]>> OnGetProducer { get; set; } = null;

        bool hasOverrideGetProducer = true;
        void GetProducerEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideGetProducer = true;
            var methodToExecute = (OnGetProducer != null) ? OnGetProducer : GetProducer;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Java.Util.Map<Java.Lang.String, object>>(0));
            data.EventData.TypedEventData.SetReturnData(hasOverrideGetProducer, executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/KafkaClientSupplier.html#getProducer-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Producer.Producer"/></returns>
        public virtual Org.Apache.Kafka.Clients.Producer.Producer<byte[], byte[]> GetProducer(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            hasOverrideGetProducer = false; return default;
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/KafkaClientSupplier.html#getAdmin-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.Admin"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Org.Apache.Kafka.Clients.Admin.Admin GetAdminDefault(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Clients.Admin.Admin>("getAdminDefault", "(Ljava/util/Map;)Lorg/apache/kafka/clients/admin/Admin;", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/KafkaClientSupplier.html#getAdmin-java.util.Map-"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetAdmin"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Map<Java.Lang.String, object>, Org.Apache.Kafka.Clients.Admin.Admin> OnGetAdmin { get; set; } = null;

        bool hasOverrideGetAdmin = true;
        void GetAdminEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideGetAdmin = true;
            var methodToExecute = (OnGetAdmin != null) ? OnGetAdmin : GetAdmin;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Java.Util.Map<Java.Lang.String, object>>(0));
            data.EventData.TypedEventData.SetReturnData(hasOverrideGetAdmin, executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/KafkaClientSupplier.html#getAdmin-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.Admin"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="GetAdminDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Org.Apache.Kafka.Clients.Admin.Admin GetAdmin(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            hasOverrideGetAdmin = false; return default;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region KafkaClientSupplierDirect implementation
    public partial class KafkaClientSupplierDirect : Org.Apache.Kafka.Streams.IKafkaClientSupplier
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/KafkaClientSupplier.html#getConsumer-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Consumer.Consumer"/></returns>
        public override Org.Apache.Kafka.Clients.Consumer.Consumer<byte[], byte[]> GetConsumer(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Clients.Consumer.Consumer<byte[], byte[]>>("getConsumer", "(Ljava/util/Map;)Lorg/apache/kafka/clients/consumer/Consumer;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/KafkaClientSupplier.html#getGlobalConsumer-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Consumer.Consumer"/></returns>
        public override Org.Apache.Kafka.Clients.Consumer.Consumer<byte[], byte[]> GetGlobalConsumer(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Clients.Consumer.Consumer<byte[], byte[]>>("getGlobalConsumer", "(Ljava/util/Map;)Lorg/apache/kafka/clients/consumer/Consumer;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/KafkaClientSupplier.html#getRestoreConsumer-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Consumer.Consumer"/></returns>
        public override Org.Apache.Kafka.Clients.Consumer.Consumer<byte[], byte[]> GetRestoreConsumer(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Clients.Consumer.Consumer<byte[], byte[]>>("getRestoreConsumer", "(Ljava/util/Map;)Lorg/apache/kafka/clients/consumer/Consumer;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/KafkaClientSupplier.html#getProducer-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Producer.Producer"/></returns>
        public override Org.Apache.Kafka.Clients.Producer.Producer<byte[], byte[]> GetProducer(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Clients.Producer.Producer<byte[], byte[]>>("getProducer", "(Ljava/util/Map;)Lorg/apache/kafka/clients/producer/Producer;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/KafkaClientSupplier.html#getAdmin-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.Admin"/></returns>
        public override Org.Apache.Kafka.Clients.Admin.Admin GetAdmin(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Clients.Admin.Admin>("getAdmin", "(Ljava/util/Map;)Lorg/apache/kafka/clients/admin/Admin;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}