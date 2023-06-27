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
*  This file is generated by MASES.JNetReflector (ver. 2.0.0.0)
*  using kafka-clients-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Producer
{
    #region KafkaProducer
    public partial class KafkaProducer
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/KafkaProducer.html#%3Cinit%3E(java.util.Map,org.apache.kafka.common.serialization.Serializer,org.apache.kafka.common.serialization.Serializer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Serialization.Serializer"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Serialization.Serializer"/></param>
        public KafkaProducer(Java.Util.Map arg0, Org.Apache.Kafka.Common.Serialization.Serializer arg1, Org.Apache.Kafka.Common.Serialization.Serializer arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/KafkaProducer.html#%3Cinit%3E(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public KafkaProducer(Java.Util.Map arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/KafkaProducer.html#%3Cinit%3E(java.util.Properties,org.apache.kafka.common.serialization.Serializer,org.apache.kafka.common.serialization.Serializer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Properties"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Serialization.Serializer"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Serialization.Serializer"/></param>
        public KafkaProducer(Java.Util.Properties arg0, Org.Apache.Kafka.Common.Serialization.Serializer arg1, Org.Apache.Kafka.Common.Serialization.Serializer arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/KafkaProducer.html#%3Cinit%3E(java.util.Properties)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Properties"/></param>
        public KafkaProducer(Java.Util.Properties arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/KafkaProducer.html#NETWORK_THREAD_PREFIX"/>
        /// </summary>
        public static string NETWORK_THREAD_PREFIX { get { return SGetField<string>(LocalBridgeClazz, "NETWORK_THREAD_PREFIX"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/KafkaProducer.html#PRODUCER_METRIC_GROUP_NAME"/>
        /// </summary>
        public static string PRODUCER_METRIC_GROUP_NAME { get { return SGetField<string>(LocalBridgeClazz, "PRODUCER_METRIC_GROUP_NAME"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/KafkaProducer.html#send(org.apache.kafka.clients.producer.ProducerRecord,org.apache.kafka.clients.producer.Callback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Producer.ProducerRecord"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Clients.Producer.Callback"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        public Java.Util.Concurrent.Future Send(Org.Apache.Kafka.Clients.Producer.ProducerRecord arg0, Org.Apache.Kafka.Clients.Producer.Callback arg1)
        {
            return IExecute<Java.Util.Concurrent.Future>("send", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/KafkaProducer.html#send(org.apache.kafka.clients.producer.ProducerRecord)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Producer.ProducerRecord"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        public Java.Util.Concurrent.Future Send(Org.Apache.Kafka.Clients.Producer.ProducerRecord arg0)
        {
            return IExecute<Java.Util.Concurrent.Future>("send", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/KafkaProducer.html#partitionsFor(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List PartitionsFor(string arg0)
        {
            return IExecute<Java.Util.List>("partitionsFor", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/KafkaProducer.html#metrics()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map Metrics()
        {
            return IExecute<Java.Util.Map>("metrics");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/KafkaProducer.html#abortTransaction()"/>
        /// </summary>

        /// <exception cref="Org.Apache.Kafka.Common.Errors.ProducerFencedException"/>
        public void AbortTransaction()
        {
            IExecute("abortTransaction");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/KafkaProducer.html#beginTransaction()"/>
        /// </summary>

        /// <exception cref="Org.Apache.Kafka.Common.Errors.ProducerFencedException"/>
        public void BeginTransaction()
        {
            IExecute("beginTransaction");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/KafkaProducer.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/KafkaProducer.html#close(java.time.Duration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Duration"/></param>
        public void Close(Java.Time.Duration arg0)
        {
            IExecute("close", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/KafkaProducer.html#commitTransaction()"/>
        /// </summary>

        /// <exception cref="Org.Apache.Kafka.Common.Errors.ProducerFencedException"/>
        public void CommitTransaction()
        {
            IExecute("commitTransaction");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/KafkaProducer.html#flush()"/>
        /// </summary>
        public void Flush()
        {
            IExecute("flush");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/KafkaProducer.html#initTransactions()"/>
        /// </summary>
        public void InitTransactions()
        {
            IExecute("initTransactions");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/KafkaProducer.html#sendOffsetsToTransaction(java.util.Map,org.apache.kafka.clients.consumer.ConsumerGroupMetadata)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerGroupMetadata"/></param>
        /// <exception cref="Org.Apache.Kafka.Common.Errors.ProducerFencedException"/>
        public void SendOffsetsToTransaction(Java.Util.Map arg0, Org.Apache.Kafka.Clients.Consumer.ConsumerGroupMetadata arg1)
        {
            IExecute("sendOffsetsToTransaction", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region KafkaProducer<K, V>
    public partial class KafkaProducer<K, V>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/KafkaProducer.html#%3Cinit%3E(java.util.Map,org.apache.kafka.common.serialization.Serializer,org.apache.kafka.common.serialization.Serializer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Serialization.Serializer"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Serialization.Serializer"/></param>
        public KafkaProducer(Java.Util.Map<string, object> arg0, Org.Apache.Kafka.Common.Serialization.Serializer<K> arg1, Org.Apache.Kafka.Common.Serialization.Serializer<V> arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/KafkaProducer.html#%3Cinit%3E(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public KafkaProducer(Java.Util.Map<string, object> arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/KafkaProducer.html#%3Cinit%3E(java.util.Properties,org.apache.kafka.common.serialization.Serializer,org.apache.kafka.common.serialization.Serializer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Properties"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Serialization.Serializer"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Serialization.Serializer"/></param>
        public KafkaProducer(Java.Util.Properties arg0, Org.Apache.Kafka.Common.Serialization.Serializer<K> arg1, Org.Apache.Kafka.Common.Serialization.Serializer<V> arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/KafkaProducer.html#%3Cinit%3E(java.util.Properties)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Properties"/></param>
        public KafkaProducer(Java.Util.Properties arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Clients.Producer.KafkaProducer{K, V}"/> to <see cref="Org.Apache.Kafka.Clients.Producer.KafkaProducer"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Clients.Producer.KafkaProducer(Org.Apache.Kafka.Clients.Producer.KafkaProducer<K, V> t) => t.Cast<Org.Apache.Kafka.Clients.Producer.KafkaProducer>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/KafkaProducer.html#NETWORK_THREAD_PREFIX"/>
        /// </summary>
        public static string NETWORK_THREAD_PREFIX { get { return SGetField<string>(LocalBridgeClazz, "NETWORK_THREAD_PREFIX"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/KafkaProducer.html#PRODUCER_METRIC_GROUP_NAME"/>
        /// </summary>
        public static string PRODUCER_METRIC_GROUP_NAME { get { return SGetField<string>(LocalBridgeClazz, "PRODUCER_METRIC_GROUP_NAME"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/KafkaProducer.html#send(org.apache.kafka.clients.producer.ProducerRecord,org.apache.kafka.clients.producer.Callback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Producer.ProducerRecord"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Clients.Producer.Callback"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        public Java.Util.Concurrent.Future<Org.Apache.Kafka.Clients.Producer.RecordMetadata> Send(Org.Apache.Kafka.Clients.Producer.ProducerRecord<K, V> arg0, Org.Apache.Kafka.Clients.Producer.Callback arg1)
        {
            return IExecute<Java.Util.Concurrent.Future<Org.Apache.Kafka.Clients.Producer.RecordMetadata>>("send", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/KafkaProducer.html#send(org.apache.kafka.clients.producer.ProducerRecord)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Producer.ProducerRecord"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        public Java.Util.Concurrent.Future<Org.Apache.Kafka.Clients.Producer.RecordMetadata> Send(Org.Apache.Kafka.Clients.Producer.ProducerRecord<K, V> arg0)
        {
            return IExecute<Java.Util.Concurrent.Future<Org.Apache.Kafka.Clients.Producer.RecordMetadata>>("send", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/KafkaProducer.html#partitionsFor(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Org.Apache.Kafka.Common.PartitionInfo> PartitionsFor(string arg0)
        {
            return IExecute<Java.Util.List<Org.Apache.Kafka.Common.PartitionInfo>>("partitionsFor", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/KafkaProducer.html#metrics()"/>
        /// </summary>

        /// <typeparam name="ReturnExtendsOrg_Apache_Kafka_Common_Metric"><see cref="Org.Apache.Kafka.Common.Metric"/></typeparam>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Org.Apache.Kafka.Common.MetricName, ReturnExtendsOrg_Apache_Kafka_Common_Metric> Metrics<ReturnExtendsOrg_Apache_Kafka_Common_Metric>() where ReturnExtendsOrg_Apache_Kafka_Common_Metric: Org.Apache.Kafka.Common.Metric
        {
            return IExecute<Java.Util.Map<Org.Apache.Kafka.Common.MetricName, ReturnExtendsOrg_Apache_Kafka_Common_Metric>>("metrics");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/KafkaProducer.html#abortTransaction()"/>
        /// </summary>

        /// <exception cref="Org.Apache.Kafka.Common.Errors.ProducerFencedException"/>
        public void AbortTransaction()
        {
            IExecute("abortTransaction");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/KafkaProducer.html#beginTransaction()"/>
        /// </summary>

        /// <exception cref="Org.Apache.Kafka.Common.Errors.ProducerFencedException"/>
        public void BeginTransaction()
        {
            IExecute("beginTransaction");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/KafkaProducer.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/KafkaProducer.html#close(java.time.Duration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Duration"/></param>
        public void Close(Java.Time.Duration arg0)
        {
            IExecute("close", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/KafkaProducer.html#commitTransaction()"/>
        /// </summary>

        /// <exception cref="Org.Apache.Kafka.Common.Errors.ProducerFencedException"/>
        public void CommitTransaction()
        {
            IExecute("commitTransaction");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/KafkaProducer.html#flush()"/>
        /// </summary>
        public void Flush()
        {
            IExecute("flush");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/KafkaProducer.html#initTransactions()"/>
        /// </summary>
        public void InitTransactions()
        {
            IExecute("initTransactions");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/KafkaProducer.html#sendOffsetsToTransaction(java.util.Map,org.apache.kafka.clients.consumer.ConsumerGroupMetadata)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerGroupMetadata"/></param>
        /// <exception cref="Org.Apache.Kafka.Common.Errors.ProducerFencedException"/>
        public void SendOffsetsToTransaction(Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Clients.Consumer.OffsetAndMetadata> arg0, Org.Apache.Kafka.Clients.Consumer.ConsumerGroupMetadata arg1)
        {
            IExecute("sendOffsetsToTransaction", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}