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
*  This file is generated by MASES.JNetReflector (ver. 2.2.3.0)
*  using kafka-clients-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Consumer
{
    #region ConsumerInterceptor
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
            AddEventHandler("onConsume", new System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Clients.Consumer.ConsumerRecords>>>(OnConsumeEventHandler));
            AddEventHandler("close", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(CloseEventHandler));
            AddEventHandler("onCommit", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Map>>>(OnCommitEventHandler));
            AddEventHandler("configure", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Map>>>(ConfigureEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerInterceptor.html#onConsume-org.apache.kafka.clients.consumer.ConsumerRecords-"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnConsume"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Org.Apache.Kafka.Clients.Consumer.ConsumerRecords, Org.Apache.Kafka.Clients.Consumer.ConsumerRecords> OnOnConsume { get; set; } = null;

        void OnConsumeEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Clients.Consumer.ConsumerRecords>> data)
        {
            var methodToExecute = (OnOnConsume != null) ? OnOnConsume : OnConsume;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerInterceptor.html#onConsume-org.apache.kafka.clients.consumer.ConsumerRecords-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerRecords"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerRecords"/></returns>
        public virtual Org.Apache.Kafka.Clients.Consumer.ConsumerRecords OnConsume(Org.Apache.Kafka.Clients.Consumer.ConsumerRecords arg0)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerInterceptor.html#close--"/>
        /// </summary>
        /// <remarks>If <see cref="OnClose"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action OnClose { get; set; } = null;

        void CloseEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnClose != null) ? OnClose : Close;
            methodToExecute.Invoke();
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerInterceptor.html#close--"/>
        /// </summary>
        public virtual void Close()
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerInterceptor.html#onCommit-java.util.Map-"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnCommit"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Util.Map> OnOnCommit { get; set; } = null;

        void OnCommitEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Map>> data)
        {
            var methodToExecute = (OnOnCommit != null) ? OnOnCommit : OnCommit;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerInterceptor.html#onCommit-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public virtual void OnCommit(Java.Util.Map arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/Configurable.html#configure-java.util.Map-"/>
        /// </summary>
        /// <remarks>If <see cref="OnConfigure"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Util.Map> OnConfigure { get; set; } = null;

        void ConfigureEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Map>> data)
        {
            var methodToExecute = (OnConfigure != null) ? OnConfigure : Configure;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/Configurable.html#configure-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public virtual void Configure(Java.Util.Map arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IConsumerInterceptor<K, V>
    /// <summary>
    /// .NET interface for org.mases.knet.generated.org.apache.kafka.clients.consumer.ConsumerInterceptor implementing <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerInterceptor.html"/>
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

    #region ConsumerInterceptor<K, V>
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
            AddEventHandler("onConsume", new System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Clients.Consumer.ConsumerRecords<K, V>>>>(OnConsumeEventHandler));
            AddEventHandler("close", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(CloseEventHandler));
            AddEventHandler("onCommit", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Clients.Consumer.OffsetAndMetadata>>>>(OnCommitEventHandler));
            AddEventHandler("configure", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Map<string, object>>>>(ConfigureEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerInterceptor.html#onConsume-org.apache.kafka.clients.consumer.ConsumerRecords-"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnConsume"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Org.Apache.Kafka.Clients.Consumer.ConsumerRecords<K, V>, Org.Apache.Kafka.Clients.Consumer.ConsumerRecords<K, V>> OnOnConsume { get; set; } = null;

        void OnConsumeEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Clients.Consumer.ConsumerRecords<K, V>>> data)
        {
            var methodToExecute = (OnOnConsume != null) ? OnOnConsume : OnConsume;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerInterceptor.html#onConsume-org.apache.kafka.clients.consumer.ConsumerRecords-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerRecords"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerRecords"/></returns>
        public virtual Org.Apache.Kafka.Clients.Consumer.ConsumerRecords<K, V> OnConsume(Org.Apache.Kafka.Clients.Consumer.ConsumerRecords<K, V> arg0)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerInterceptor.html#close--"/>
        /// </summary>
        /// <remarks>If <see cref="OnClose"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action OnClose { get; set; } = null;

        void CloseEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnClose != null) ? OnClose : Close;
            methodToExecute.Invoke();
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerInterceptor.html#close--"/>
        /// </summary>
        public virtual void Close()
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerInterceptor.html#onCommit-java.util.Map-"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnCommit"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Clients.Consumer.OffsetAndMetadata>> OnOnCommit { get; set; } = null;

        void OnCommitEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Clients.Consumer.OffsetAndMetadata>>> data)
        {
            var methodToExecute = (OnOnCommit != null) ? OnOnCommit : OnCommit;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/consumer/ConsumerInterceptor.html#onCommit-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public virtual void OnCommit(Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Clients.Consumer.OffsetAndMetadata> arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/Configurable.html#configure-java.util.Map-"/>
        /// </summary>
        /// <remarks>If <see cref="OnConfigure"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Util.Map<string, object>> OnConfigure { get; set; } = null;

        void ConfigureEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Map<string, object>>> data)
        {
            var methodToExecute = (OnConfigure != null) ? OnConfigure : Configure;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/Configurable.html#configure-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public virtual void Configure(Java.Util.Map<string, object> arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}