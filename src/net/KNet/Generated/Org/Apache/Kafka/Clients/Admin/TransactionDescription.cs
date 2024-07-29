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

namespace Org.Apache.Kafka.Clients.Admin
{
    #region TransactionDescription
    public partial class TransactionDescription
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/TransactionDescription.html#org.apache.kafka.clients.admin.TransactionDescription(int,org.apache.kafka.clients.admin.TransactionState,long,int,long,java.util.OptionalLong,java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Clients.Admin.TransactionState"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        /// <param name="arg5"><see cref="Java.Util.OptionalLong"/></param>
        /// <param name="arg6"><see cref="Java.Util.Set"/></param>
        public TransactionDescription(int arg0, Org.Apache.Kafka.Clients.Admin.TransactionState arg1, long arg2, int arg3, long arg4, Java.Util.OptionalLong arg5, Java.Util.Set<Org.Apache.Kafka.Common.TopicPartition> arg6)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/TransactionDescription.html#coordinatorId--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int CoordinatorId()
        {
            return IExecuteWithSignature<int>("coordinatorId", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/TransactionDescription.html#producerEpoch--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int ProducerEpoch()
        {
            return IExecuteWithSignature<int>("producerEpoch", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/TransactionDescription.html#transactionStartTimeMs--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.OptionalLong"/></returns>
        public Java.Util.OptionalLong TransactionStartTimeMs()
        {
            return IExecuteWithSignature<Java.Util.OptionalLong>("transactionStartTimeMs", "()Ljava/util/OptionalLong;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/TransactionDescription.html#topicPartitions--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Org.Apache.Kafka.Common.TopicPartition> TopicPartitions()
        {
            return IExecuteWithSignature<Java.Util.Set<Org.Apache.Kafka.Common.TopicPartition>>("topicPartitions", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/TransactionDescription.html#producerId--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long ProducerId()
        {
            return IExecuteWithSignature<long>("producerId", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/TransactionDescription.html#transactionTimeoutMs--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long TransactionTimeoutMs()
        {
            return IExecuteWithSignature<long>("transactionTimeoutMs", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/TransactionDescription.html#state--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.TransactionState"/></returns>
        public Org.Apache.Kafka.Clients.Admin.TransactionState State()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Clients.Admin.TransactionState>("state", "()Lorg/apache/kafka/clients/admin/TransactionState;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}