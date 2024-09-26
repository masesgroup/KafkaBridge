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
    #region Producer declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/Producer.html"/>
    /// </summary>
    public partial class Producer : Java.Io.Closeable
    {
        const string _bridgeClassName = "org.apache.kafka.clients.producer.Producer";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("Producer class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Producer() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("Producer class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Producer(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
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

        // TODO: complete the class

    }
    #endregion

    #region Producer<K, V> declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/Producer.html"/>
    /// </summary>
    /// <typeparam name="K"></typeparam>
    /// <typeparam name="V"></typeparam>
    public partial class Producer<K, V> : Java.Io.Closeable
    {
        const string _bridgeClassName = "org.apache.kafka.clients.producer.Producer";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("Producer class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Producer() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("Producer class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Producer(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
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

        // TODO: complete the class
    
    }
    #endregion

    #region Producer implementation
    public partial class Producer
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/Producer.html#send-org.apache.kafka.clients.producer.ProducerRecord-org.apache.kafka.clients.producer.Callback-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Producer.ProducerRecord"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Clients.Producer.Callback"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        public Java.Util.Concurrent.Future Send(Org.Apache.Kafka.Clients.Producer.ProducerRecord arg0, Org.Apache.Kafka.Clients.Producer.Callback arg1)
        {
            return IExecuteWithSignature<Java.Util.Concurrent.Future>("send", "(Lorg/apache/kafka/clients/producer/ProducerRecord;Lorg/apache/kafka/clients/producer/Callback;)Ljava/util/concurrent/Future;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/Producer.html#send-org.apache.kafka.clients.producer.ProducerRecord-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Producer.ProducerRecord"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        public Java.Util.Concurrent.Future Send(Org.Apache.Kafka.Clients.Producer.ProducerRecord arg0)
        {
            return IExecuteWithSignature<Java.Util.Concurrent.Future>("send", "(Lorg/apache/kafka/clients/producer/ProducerRecord;)Ljava/util/concurrent/Future;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/Producer.html#partitionsFor-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List PartitionsFor(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.List>("partitionsFor", "(Ljava/lang/String;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/Producer.html#metrics--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map Metrics()
        {
            return IExecuteWithSignature<Java.Util.Map>("metrics", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/Producer.html#clientInstanceId-java.time.Duration-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Duration"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Uuid"/></returns>
        public Org.Apache.Kafka.Common.Uuid ClientInstanceId(Java.Time.Duration arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Uuid>("clientInstanceId", "(Ljava/time/Duration;)Lorg/apache/kafka/common/Uuid;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/Producer.html#abortTransaction--"/>
        /// </summary>
        /// <exception cref="Org.Apache.Kafka.Common.Errors.ProducerFencedException"/>
        public void AbortTransaction()
        {
            IExecuteWithSignature("abortTransaction", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/Producer.html#beginTransaction--"/>
        /// </summary>
        /// <exception cref="Org.Apache.Kafka.Common.Errors.ProducerFencedException"/>
        public void BeginTransaction()
        {
            IExecuteWithSignature("beginTransaction", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/Producer.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/Producer.html#close-java.time.Duration-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Duration"/></param>
        public void Close(Java.Time.Duration arg0)
        {
            IExecuteWithSignature("close", "(Ljava/time/Duration;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/Producer.html#commitTransaction--"/>
        /// </summary>
        /// <exception cref="Org.Apache.Kafka.Common.Errors.ProducerFencedException"/>
        public void CommitTransaction()
        {
            IExecuteWithSignature("commitTransaction", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/Producer.html#flush--"/>
        /// </summary>
        public void Flush()
        {
            IExecuteWithSignature("flush", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/Producer.html#initTransactions--"/>
        /// </summary>
        public void InitTransactions()
        {
            IExecuteWithSignature("initTransactions", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/Producer.html#sendOffsetsToTransaction-java.util.Map-org.apache.kafka.clients.consumer.ConsumerGroupMetadata-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerGroupMetadata"/></param>
        /// <exception cref="Org.Apache.Kafka.Common.Errors.ProducerFencedException"/>
        public void SendOffsetsToTransaction(Java.Util.Map arg0, Org.Apache.Kafka.Clients.Consumer.ConsumerGroupMetadata arg1)
        {
            IExecuteWithSignature("sendOffsetsToTransaction", "(Ljava/util/Map;Lorg/apache/kafka/clients/consumer/ConsumerGroupMetadata;)V", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IProducer<K, V>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IProducer<K, V> : Java.Io.ICloseable
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Producer<K, V> implementation
    public partial class Producer<K, V> : Org.Apache.Kafka.Clients.Producer.IProducer<K, V>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Clients.Producer.Producer{K, V}"/> to <see cref="Org.Apache.Kafka.Clients.Producer.Producer"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Clients.Producer.Producer(Org.Apache.Kafka.Clients.Producer.Producer<K, V> t) => t.Cast<Org.Apache.Kafka.Clients.Producer.Producer>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/Producer.html#send-org.apache.kafka.clients.producer.ProducerRecord-org.apache.kafka.clients.producer.Callback-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Producer.ProducerRecord"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Clients.Producer.Callback"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        public Java.Util.Concurrent.Future<Org.Apache.Kafka.Clients.Producer.RecordMetadata> Send(Org.Apache.Kafka.Clients.Producer.ProducerRecord<K, V> arg0, Org.Apache.Kafka.Clients.Producer.Callback arg1)
        {
            return IExecuteWithSignature<Java.Util.Concurrent.Future<Org.Apache.Kafka.Clients.Producer.RecordMetadata>>("send", "(Lorg/apache/kafka/clients/producer/ProducerRecord;Lorg/apache/kafka/clients/producer/Callback;)Ljava/util/concurrent/Future;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/Producer.html#send-org.apache.kafka.clients.producer.ProducerRecord-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Producer.ProducerRecord"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        public Java.Util.Concurrent.Future<Org.Apache.Kafka.Clients.Producer.RecordMetadata> Send(Org.Apache.Kafka.Clients.Producer.ProducerRecord<K, V> arg0)
        {
            return IExecuteWithSignature<Java.Util.Concurrent.Future<Org.Apache.Kafka.Clients.Producer.RecordMetadata>>("send", "(Lorg/apache/kafka/clients/producer/ProducerRecord;)Ljava/util/concurrent/Future;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/Producer.html#partitionsFor-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Org.Apache.Kafka.Common.PartitionInfo> PartitionsFor(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.List<Org.Apache.Kafka.Common.PartitionInfo>>("partitionsFor", "(Ljava/lang/String;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/Producer.html#metrics--"/>
        /// </summary>
        /// <typeparam name="ReturnExtendsOrg_Apache_Kafka_Common_Metric"><see cref="Org.Apache.Kafka.Common.Metric"/></typeparam>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Org.Apache.Kafka.Common.MetricName, ReturnExtendsOrg_Apache_Kafka_Common_Metric> Metrics<ReturnExtendsOrg_Apache_Kafka_Common_Metric>() where ReturnExtendsOrg_Apache_Kafka_Common_Metric : Org.Apache.Kafka.Common.Metric
        {
            return IExecuteWithSignature<Java.Util.Map<Org.Apache.Kafka.Common.MetricName, ReturnExtendsOrg_Apache_Kafka_Common_Metric>>("metrics", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/Producer.html#clientInstanceId-java.time.Duration-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Duration"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Uuid"/></returns>
        public Org.Apache.Kafka.Common.Uuid ClientInstanceId(Java.Time.Duration arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Uuid>("clientInstanceId", "(Ljava/time/Duration;)Lorg/apache/kafka/common/Uuid;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/Producer.html#abortTransaction--"/>
        /// </summary>
        /// <exception cref="Org.Apache.Kafka.Common.Errors.ProducerFencedException"/>
        public void AbortTransaction()
        {
            IExecuteWithSignature("abortTransaction", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/Producer.html#beginTransaction--"/>
        /// </summary>
        /// <exception cref="Org.Apache.Kafka.Common.Errors.ProducerFencedException"/>
        public void BeginTransaction()
        {
            IExecuteWithSignature("beginTransaction", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/Producer.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/Producer.html#close-java.time.Duration-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Duration"/></param>
        public void Close(Java.Time.Duration arg0)
        {
            IExecuteWithSignature("close", "(Ljava/time/Duration;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/Producer.html#commitTransaction--"/>
        /// </summary>
        /// <exception cref="Org.Apache.Kafka.Common.Errors.ProducerFencedException"/>
        public void CommitTransaction()
        {
            IExecuteWithSignature("commitTransaction", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/Producer.html#flush--"/>
        /// </summary>
        public void Flush()
        {
            IExecuteWithSignature("flush", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/Producer.html#initTransactions--"/>
        /// </summary>
        public void InitTransactions()
        {
            IExecuteWithSignature("initTransactions", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/Producer.html#sendOffsetsToTransaction-java.util.Map-org.apache.kafka.clients.consumer.ConsumerGroupMetadata-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerGroupMetadata"/></param>
        /// <exception cref="Org.Apache.Kafka.Common.Errors.ProducerFencedException"/>
        public void SendOffsetsToTransaction(Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Clients.Consumer.OffsetAndMetadata> arg0, Org.Apache.Kafka.Clients.Consumer.ConsumerGroupMetadata arg1)
        {
            IExecuteWithSignature("sendOffsetsToTransaction", "(Ljava/util/Map;Lorg/apache/kafka/clients/consumer/ConsumerGroupMetadata;)V", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}