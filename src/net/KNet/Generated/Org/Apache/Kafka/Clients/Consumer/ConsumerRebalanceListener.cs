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
*  using kafka-clients-3.9.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Consumer
{
    #region ConsumerRebalanceListener declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/consumer/ConsumerRebalanceListener.html"/>
    /// </summary>
    public partial class ConsumerRebalanceListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ConsumerRebalanceListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.knet.generated.org.apache.kafka.clients.consumer.ConsumerRebalanceListener";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region ConsumerRebalanceListenerDirect declaration
    /// <summary>
    /// Direct override of <see cref="ConsumerRebalanceListener"/> or its generic type if there is one
    /// </summary>
    public partial class ConsumerRebalanceListenerDirect : ConsumerRebalanceListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "org.apache.kafka.clients.consumer.ConsumerRebalanceListener";
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

    #region IConsumerRebalanceListener
    /// <summary>
    /// .NET interface for org.mases.knet.generated.org.apache.kafka.clients.consumer.ConsumerRebalanceListener implementing <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/consumer/ConsumerRebalanceListener.html"/>
    /// </summary>
    public partial interface IConsumerRebalanceListener
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ConsumerRebalanceListener implementation
    public partial class ConsumerRebalanceListener : Org.Apache.Kafka.Clients.Consumer.IConsumerRebalanceListener
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
        /// Handlers initializer for <see cref="ConsumerRebalanceListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("onPartitionsAssigned", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnPartitionsAssignedEventHandler));
            AddEventHandler("onPartitionsRevoked", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnPartitionsRevokedEventHandler));
            AddEventHandler("onPartitionsLost", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnPartitionsLostEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/consumer/ConsumerRebalanceListener.html#onPartitionsAssigned-java.util.Collection-"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnPartitionsAssigned"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartition>> OnOnPartitionsAssigned { get; set; } = null;

        bool hasOverrideOnPartitionsAssigned = true;
        void OnPartitionsAssignedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideOnPartitionsAssigned = true;
            var methodToExecute = (OnOnPartitionsAssigned != null) ? OnOnPartitionsAssigned : OnPartitionsAssigned;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartition>>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideOnPartitionsAssigned;
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/consumer/ConsumerRebalanceListener.html#onPartitionsAssigned-java.util.Collection-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public virtual void OnPartitionsAssigned(Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartition> arg0)
        {
            hasOverrideOnPartitionsAssigned = false;
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/consumer/ConsumerRebalanceListener.html#onPartitionsRevoked-java.util.Collection-"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnPartitionsRevoked"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartition>> OnOnPartitionsRevoked { get; set; } = null;

        bool hasOverrideOnPartitionsRevoked = true;
        void OnPartitionsRevokedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideOnPartitionsRevoked = true;
            var methodToExecute = (OnOnPartitionsRevoked != null) ? OnOnPartitionsRevoked : OnPartitionsRevoked;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartition>>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideOnPartitionsRevoked;
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/consumer/ConsumerRebalanceListener.html#onPartitionsRevoked-java.util.Collection-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public virtual void OnPartitionsRevoked(Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartition> arg0)
        {
            hasOverrideOnPartitionsRevoked = false;
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/consumer/ConsumerRebalanceListener.html#onPartitionsLost-java.util.Collection-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void OnPartitionsLostDefault(Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartition> arg0)
        {
            IExecuteWithSignature("onPartitionsLostDefault", "(Ljava/util/Collection;)V", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/consumer/ConsumerRebalanceListener.html#onPartitionsLost-java.util.Collection-"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnPartitionsLost"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartition>> OnOnPartitionsLost { get; set; } = null;

        bool hasOverrideOnPartitionsLost = true;
        void OnPartitionsLostEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideOnPartitionsLost = true;
            var methodToExecute = (OnOnPartitionsLost != null) ? OnOnPartitionsLost : OnPartitionsLost;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartition>>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideOnPartitionsLost;
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/consumer/ConsumerRebalanceListener.html#onPartitionsLost-java.util.Collection-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="OnPartitionsLostDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void OnPartitionsLost(Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartition> arg0)
        {
            hasOverrideOnPartitionsLost = false;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ConsumerRebalanceListenerDirect implementation
    public partial class ConsumerRebalanceListenerDirect : Org.Apache.Kafka.Clients.Consumer.IConsumerRebalanceListener
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/consumer/ConsumerRebalanceListener.html#onPartitionsAssigned-java.util.Collection-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public override void OnPartitionsAssigned(Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartition> arg0)
        {
            IExecuteWithSignature("onPartitionsAssigned", "(Ljava/util/Collection;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/consumer/ConsumerRebalanceListener.html#onPartitionsRevoked-java.util.Collection-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public override void OnPartitionsRevoked(Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartition> arg0)
        {
            IExecuteWithSignature("onPartitionsRevoked", "(Ljava/util/Collection;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/consumer/ConsumerRebalanceListener.html#onPartitionsLost-java.util.Collection-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public override void OnPartitionsLost(Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartition> arg0)
        {
            IExecuteWithSignature("onPartitionsLost", "(Ljava/util/Collection;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}