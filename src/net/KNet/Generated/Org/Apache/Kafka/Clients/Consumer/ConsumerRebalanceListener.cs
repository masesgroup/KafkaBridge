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
*  using kafka-clients-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Consumer
{
    #region IConsumerRebalanceListener
    /// <summary>
    /// .NET interface for org.mases.knet.generated.org.apache.kafka.clients.consumer.ConsumerRebalanceListener implementing <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/consumer/ConsumerRebalanceListener.html"/>
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

    #region ConsumerRebalanceListener
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
            AddEventHandler("onPartitionsAssigned", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartition>>>>(OnPartitionsAssignedEventHandler));
            AddEventHandler("onPartitionsRevoked", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartition>>>>(OnPartitionsRevokedEventHandler));
            AddEventHandler("onPartitionsLost", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartition>>>>(OnPartitionsLostEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/consumer/ConsumerRebalanceListener.html#onPartitionsAssigned-java.util.Collection-"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnPartitionsAssigned"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartition>> OnOnPartitionsAssigned { get; set; } = null;

        void OnPartitionsAssignedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartition>>> data)
        {
            var methodToExecute = (OnOnPartitionsAssigned != null) ? OnOnPartitionsAssigned : OnPartitionsAssigned;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/consumer/ConsumerRebalanceListener.html#onPartitionsAssigned-java.util.Collection-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public virtual void OnPartitionsAssigned(Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartition> arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/consumer/ConsumerRebalanceListener.html#onPartitionsRevoked-java.util.Collection-"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnPartitionsRevoked"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartition>> OnOnPartitionsRevoked { get; set; } = null;

        void OnPartitionsRevokedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartition>>> data)
        {
            var methodToExecute = (OnOnPartitionsRevoked != null) ? OnOnPartitionsRevoked : OnPartitionsRevoked;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/consumer/ConsumerRebalanceListener.html#onPartitionsRevoked-java.util.Collection-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public virtual void OnPartitionsRevoked(Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartition> arg0)
        {
            
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/consumer/ConsumerRebalanceListener.html#onPartitionsLost-java.util.Collection-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void OnPartitionsLostDefault(Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartition> arg0)
        {
            IExecuteWithSignature("onPartitionsLostDefault", "(Ljava/util/Collection;)V", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/consumer/ConsumerRebalanceListener.html#onPartitionsLost-java.util.Collection-"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnPartitionsLost"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartition>> OnOnPartitionsLost { get; set; } = null;

        void OnPartitionsLostEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartition>>> data)
        {
            var methodToExecute = (OnOnPartitionsLost != null) ? OnOnPartitionsLost : OnPartitionsLost;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/consumer/ConsumerRebalanceListener.html#onPartitionsLost-java.util.Collection-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="OnPartitionsLostDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void OnPartitionsLost(Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartition> arg0)
        {
            OnPartitionsLostDefault(arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ConsumerRebalanceListenerDirect
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/consumer/ConsumerRebalanceListener.html#onPartitionsAssigned-java.util.Collection-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public override void OnPartitionsAssigned(Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartition> arg0)
        {
            IExecuteWithSignature("onPartitionsAssigned", "(Ljava/util/Collection;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/consumer/ConsumerRebalanceListener.html#onPartitionsRevoked-java.util.Collection-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public override void OnPartitionsRevoked(Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartition> arg0)
        {
            IExecuteWithSignature("onPartitionsRevoked", "(Ljava/util/Collection;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/consumer/ConsumerRebalanceListener.html#onPartitionsLost-java.util.Collection-"/>
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