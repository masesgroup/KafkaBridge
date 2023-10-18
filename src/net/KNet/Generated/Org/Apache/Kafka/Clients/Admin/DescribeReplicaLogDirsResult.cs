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
*  This file is generated by MASES.JNetReflector (ver. 2.0.2.0)
*  using kafka-clients-3.6.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Admin
{
    #region DescribeReplicaLogDirsResult
    public partial class DescribeReplicaLogDirsResult
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/admin/DescribeReplicaLogDirsResult.html#values--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Org.Apache.Kafka.Common.TopicPartitionReplica, Org.Apache.Kafka.Common.KafkaFuture<Org.Apache.Kafka.Clients.Admin.DescribeReplicaLogDirsResult.ReplicaLogDirInfo>> Values()
        {
            return IExecute<Java.Util.Map<Org.Apache.Kafka.Common.TopicPartitionReplica, Org.Apache.Kafka.Common.KafkaFuture<Org.Apache.Kafka.Clients.Admin.DescribeReplicaLogDirsResult.ReplicaLogDirInfo>>>("values");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/admin/DescribeReplicaLogDirsResult.html#all--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.KafkaFuture"/></returns>
        public Org.Apache.Kafka.Common.KafkaFuture<Java.Util.Map<Org.Apache.Kafka.Common.TopicPartitionReplica, Org.Apache.Kafka.Clients.Admin.DescribeReplicaLogDirsResult.ReplicaLogDirInfo>> All()
        {
            return IExecute<Org.Apache.Kafka.Common.KafkaFuture<Java.Util.Map<Org.Apache.Kafka.Common.TopicPartitionReplica, Org.Apache.Kafka.Clients.Admin.DescribeReplicaLogDirsResult.ReplicaLogDirInfo>>>("all");
        }

        #endregion

        #region Nested classes
        #region ReplicaLogDirInfo
        public partial class ReplicaLogDirInfo
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/admin/DescribeReplicaLogDirsResult.ReplicaLogDirInfo.html#getCurrentReplicaLogDir--"/> 
            /// </summary>
            public string CurrentReplicaLogDir
            {
                get { return IExecute<string>("getCurrentReplicaLogDir"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/admin/DescribeReplicaLogDirsResult.ReplicaLogDirInfo.html#getCurrentReplicaOffsetLag--"/> 
            /// </summary>
            public long CurrentReplicaOffsetLag
            {
                get { return IExecute<long>("getCurrentReplicaOffsetLag"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/admin/DescribeReplicaLogDirsResult.ReplicaLogDirInfo.html#getFutureReplicaLogDir--"/> 
            /// </summary>
            public string FutureReplicaLogDir
            {
                get { return IExecute<string>("getFutureReplicaLogDir"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/admin/DescribeReplicaLogDirsResult.ReplicaLogDirInfo.html#getFutureReplicaOffsetLag--"/> 
            /// </summary>
            public long FutureReplicaOffsetLag
            {
                get { return IExecute<long>("getFutureReplicaOffsetLag"); }
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}