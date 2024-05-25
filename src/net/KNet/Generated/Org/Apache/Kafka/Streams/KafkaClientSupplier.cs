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

namespace Org.Apache.Kafka.Streams
{
    #region IKafkaClientSupplier
    /// <summary>
    /// .NET interface for org.mases.knet.generated.org.apache.kafka.streams.KafkaClientSupplier implementing <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/KafkaClientSupplier.html"/>
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

    #region KafkaClientSupplier
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
            AddEventHandler("getConsumer", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Map<Java.Lang.String, object>>>>(GetConsumerEventHandler));
            AddEventHandler("getGlobalConsumer", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Map<Java.Lang.String, object>>>>(GetGlobalConsumerEventHandler));
            AddEventHandler("getRestoreConsumer", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Map<Java.Lang.String, object>>>>(GetRestoreConsumerEventHandler));
            AddEventHandler("getProducer", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Map<Java.Lang.String, object>>>>(GetProducerEventHandler));
            AddEventHandler("getAdmin", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Map<Java.Lang.String, object>>>>(GetAdminEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/KafkaClientSupplier.html#getConsumer-java.util.Map-"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetConsumer"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Java.Util.Map<Java.Lang.String, object>, Org.Apache.Kafka.Clients.Consumer.Consumer<byte[], byte[]>> OnGetConsumer { get; set; } = null;

        void GetConsumerEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Map<Java.Lang.String, object>>> data)
        {
            var methodToExecute = (OnGetConsumer != null) ? OnGetConsumer : GetConsumer;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/KafkaClientSupplier.html#getConsumer-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Consumer.Consumer"/></returns>
        public virtual Org.Apache.Kafka.Clients.Consumer.Consumer<byte[], byte[]> GetConsumer(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/KafkaClientSupplier.html#getGlobalConsumer-java.util.Map-"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetGlobalConsumer"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Java.Util.Map<Java.Lang.String, object>, Org.Apache.Kafka.Clients.Consumer.Consumer<byte[], byte[]>> OnGetGlobalConsumer { get; set; } = null;

        void GetGlobalConsumerEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Map<Java.Lang.String, object>>> data)
        {
            var methodToExecute = (OnGetGlobalConsumer != null) ? OnGetGlobalConsumer : GetGlobalConsumer;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/KafkaClientSupplier.html#getGlobalConsumer-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Consumer.Consumer"/></returns>
        public virtual Org.Apache.Kafka.Clients.Consumer.Consumer<byte[], byte[]> GetGlobalConsumer(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/KafkaClientSupplier.html#getRestoreConsumer-java.util.Map-"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetRestoreConsumer"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Java.Util.Map<Java.Lang.String, object>, Org.Apache.Kafka.Clients.Consumer.Consumer<byte[], byte[]>> OnGetRestoreConsumer { get; set; } = null;

        void GetRestoreConsumerEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Map<Java.Lang.String, object>>> data)
        {
            var methodToExecute = (OnGetRestoreConsumer != null) ? OnGetRestoreConsumer : GetRestoreConsumer;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/KafkaClientSupplier.html#getRestoreConsumer-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Consumer.Consumer"/></returns>
        public virtual Org.Apache.Kafka.Clients.Consumer.Consumer<byte[], byte[]> GetRestoreConsumer(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/KafkaClientSupplier.html#getProducer-java.util.Map-"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetProducer"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Java.Util.Map<Java.Lang.String, object>, Org.Apache.Kafka.Clients.Producer.Producer<byte[], byte[]>> OnGetProducer { get; set; } = null;

        void GetProducerEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Map<Java.Lang.String, object>>> data)
        {
            var methodToExecute = (OnGetProducer != null) ? OnGetProducer : GetProducer;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/KafkaClientSupplier.html#getProducer-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Producer.Producer"/></returns>
        public virtual Org.Apache.Kafka.Clients.Producer.Producer<byte[], byte[]> GetProducer(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            return default;
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/KafkaClientSupplier.html#getAdmin-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.Admin"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Org.Apache.Kafka.Clients.Admin.Admin GetAdminDefault(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Clients.Admin.Admin>("getAdminDefault", "(Ljava/util/Map;)Lorg/apache/kafka/clients/admin/Admin;", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/KafkaClientSupplier.html#getAdmin-java.util.Map-"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetAdmin"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Java.Util.Map<Java.Lang.String, object>, Org.Apache.Kafka.Clients.Admin.Admin> OnGetAdmin { get; set; } = null;

        void GetAdminEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Map<Java.Lang.String, object>>> data)
        {
            var methodToExecute = (OnGetAdmin != null) ? OnGetAdmin : GetAdmin;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/KafkaClientSupplier.html#getAdmin-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.Admin"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="GetAdminDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Org.Apache.Kafka.Clients.Admin.Admin GetAdmin(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            return GetAdminDefault(arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region KafkaClientSupplierDirect
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/KafkaClientSupplier.html#getConsumer-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Consumer.Consumer"/></returns>
        public override Org.Apache.Kafka.Clients.Consumer.Consumer<byte[], byte[]> GetConsumer(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Clients.Consumer.Consumer<byte[], byte[]>>("getConsumer", "(Ljava/util/Map;)Lorg/apache/kafka/clients/consumer/Consumer;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/KafkaClientSupplier.html#getGlobalConsumer-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Consumer.Consumer"/></returns>
        public override Org.Apache.Kafka.Clients.Consumer.Consumer<byte[], byte[]> GetGlobalConsumer(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Clients.Consumer.Consumer<byte[], byte[]>>("getGlobalConsumer", "(Ljava/util/Map;)Lorg/apache/kafka/clients/consumer/Consumer;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/KafkaClientSupplier.html#getRestoreConsumer-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Consumer.Consumer"/></returns>
        public override Org.Apache.Kafka.Clients.Consumer.Consumer<byte[], byte[]> GetRestoreConsumer(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Clients.Consumer.Consumer<byte[], byte[]>>("getRestoreConsumer", "(Ljava/util/Map;)Lorg/apache/kafka/clients/consumer/Consumer;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/KafkaClientSupplier.html#getProducer-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Producer.Producer"/></returns>
        public override Org.Apache.Kafka.Clients.Producer.Producer<byte[], byte[]> GetProducer(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Clients.Producer.Producer<byte[], byte[]>>("getProducer", "(Ljava/util/Map;)Lorg/apache/kafka/clients/producer/Producer;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/KafkaClientSupplier.html#getAdmin-java.util.Map-"/>
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