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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using kafka-clients-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Producer.Internals
{
    #region TransactionManager
    public partial class TransactionManager
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/internals/TransactionManager.html#%3Cinit%3E(org.apache.kafka.common.utils.LogContext,java.lang.String,int,long,org.apache.kafka.clients.ApiVersions)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Utils.LogContext"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Clients.ApiVersions"/></param>
        public TransactionManager(Org.Apache.Kafka.Common.Utils.LogContext arg0, string arg1, int arg2, long arg3, Org.Apache.Kafka.Clients.ApiVersions arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/internals/TransactionManager.html#beginAbort()"/> 
        /// </summary>
        public Org.Apache.Kafka.Clients.Producer.Internals.TransactionalRequestResult BeginAbort
        {
            get { return IExecute<Org.Apache.Kafka.Clients.Producer.Internals.TransactionalRequestResult>("beginAbort"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/internals/TransactionManager.html#beginCommit()"/> 
        /// </summary>
        public Org.Apache.Kafka.Clients.Producer.Internals.TransactionalRequestResult BeginCommit
        {
            get { return IExecute<Org.Apache.Kafka.Clients.Producer.Internals.TransactionalRequestResult>("beginCommit"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/internals/TransactionManager.html#hasProducerId()"/> 
        /// </summary>
        public bool HasProducerId
        {
            get { return IExecute<bool>("hasProducerId"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/internals/TransactionManager.html#initializeTransactions()"/> 
        /// </summary>
        public Org.Apache.Kafka.Clients.Producer.Internals.TransactionalRequestResult InitializeTransactions
        {
            get { return IExecute<Org.Apache.Kafka.Clients.Producer.Internals.TransactionalRequestResult>("initializeTransactions"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/internals/TransactionManager.html#isTransactional()"/> 
        /// </summary>
        public bool IsTransactional
        {
            get { return IExecute<bool>("isTransactional"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/internals/TransactionManager.html#transactionalId()"/> 
        /// </summary>
        public string TransactionalId
        {
            get { return IExecute<string>("transactionalId"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/internals/TransactionManager.html#sendOffsetsToTransaction(java.util.Map,org.apache.kafka.clients.consumer.ConsumerGroupMetadata)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerGroupMetadata"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Producer.Internals.TransactionalRequestResult"/></returns>
        public Org.Apache.Kafka.Clients.Producer.Internals.TransactionalRequestResult SendOffsetsToTransaction(Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Clients.Consumer.OffsetAndMetadata> arg0, Org.Apache.Kafka.Clients.Consumer.ConsumerGroupMetadata arg1)
        {
            return IExecute<Org.Apache.Kafka.Clients.Producer.Internals.TransactionalRequestResult>("sendOffsetsToTransaction", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/internals/TransactionManager.html#beginTransaction()"/>
        /// </summary>
        public void BeginTransaction()
        {
            IExecute("beginTransaction");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/internals/TransactionManager.html#handleCompletedBatch(org.apache.kafka.clients.producer.internals.ProducerBatch,org.apache.kafka.common.requests.ProduceResponse.PartitionResponse)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Producer.Internals.ProducerBatch"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Requests.ProduceResponse.PartitionResponse"/></param>
        public void HandleCompletedBatch(Org.Apache.Kafka.Clients.Producer.Internals.ProducerBatch arg0, Org.Apache.Kafka.Common.Requests.ProduceResponse.PartitionResponse arg1)
        {
            IExecute("handleCompletedBatch", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/internals/TransactionManager.html#maybeAddPartition(org.apache.kafka.common.TopicPartition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        public void MaybeAddPartition(Org.Apache.Kafka.Common.TopicPartition arg0)
        {
            IExecute("maybeAddPartition", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/internals/TransactionManager.html#maybeTransitionToErrorState(java.lang.RuntimeException)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.RuntimeException"/></param>
        public void MaybeTransitionToErrorState(Java.Lang.RuntimeException arg0)
        {
            IExecute("maybeTransitionToErrorState", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/producer/internals/TransactionManager.html#maybeUpdateProducerIdAndEpoch(org.apache.kafka.common.TopicPartition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        public void MaybeUpdateProducerIdAndEpoch(Org.Apache.Kafka.Common.TopicPartition arg0)
        {
            IExecute("maybeUpdateProducerIdAndEpoch", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}