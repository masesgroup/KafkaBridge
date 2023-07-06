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

namespace Org.Apache.Kafka.Clients.Admin
{
    public partial class ForwardingAdmin : Org.Apache.Kafka.Clients.Admin.IAdmin
    {

        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#abortTransaction(org.apache.kafka.clients.admin.AbortTransactionSpec)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Admin.AbortTransactionSpec"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.AbortTransactionResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.AbortTransactionResult AbortTransaction(Org.Apache.Kafka.Clients.Admin.AbortTransactionSpec arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.AbortTransactionResult>("abortTransaction", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#alterClientQuotas(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.AlterClientQuotasResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.AlterClientQuotasResult AlterClientQuotas(Java.Util.Collection<Org.Apache.Kafka.Common.Quota.ClientQuotaAlteration> arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.AlterClientQuotasResult>("alterClientQuotas", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#incrementalAlterConfigs(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.AlterConfigsResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.AlterConfigsResult IncrementalAlterConfigs(Java.Util.Map<Org.Apache.Kafka.Common.Config.ConfigResource, Java.Util.Collection<Org.Apache.Kafka.Clients.Admin.AlterConfigOp>> arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.AlterConfigsResult>("incrementalAlterConfigs", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#alterConsumerGroupOffsets(java.lang.String,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.AlterConsumerGroupOffsetsResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.AlterConsumerGroupOffsetsResult AlterConsumerGroupOffsets(string arg0, Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Clients.Consumer.OffsetAndMetadata> arg1)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.AlterConsumerGroupOffsetsResult>("alterConsumerGroupOffsets", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#alterPartitionReassignments(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.AlterPartitionReassignmentsResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.AlterPartitionReassignmentsResult AlterPartitionReassignments(Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Java.Util.Optional<Org.Apache.Kafka.Clients.Admin.NewPartitionReassignment>> arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.AlterPartitionReassignmentsResult>("alterPartitionReassignments", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#alterReplicaLogDirs(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.AlterReplicaLogDirsResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.AlterReplicaLogDirsResult AlterReplicaLogDirs(Java.Util.Map<Org.Apache.Kafka.Common.TopicPartitionReplica, string> arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.AlterReplicaLogDirsResult>("alterReplicaLogDirs", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#alterUserScramCredentials(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.AlterUserScramCredentialsResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.AlterUserScramCredentialsResult AlterUserScramCredentials(Java.Util.List<Org.Apache.Kafka.Clients.Admin.UserScramCredentialAlteration> arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.AlterUserScramCredentialsResult>("alterUserScramCredentials", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#createAcls(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.CreateAclsResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.CreateAclsResult CreateAcls(Java.Util.Collection<Org.Apache.Kafka.Common.Acl.AclBinding> arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.CreateAclsResult>("createAcls", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#createDelegationToken()"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.CreateDelegationTokenResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.CreateDelegationTokenResult CreateDelegationToken()
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.CreateDelegationTokenResult>("createDelegationToken");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#createPartitions(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.CreatePartitionsResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.CreatePartitionsResult CreatePartitions(Java.Util.Map<string, Org.Apache.Kafka.Clients.Admin.NewPartitions> arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.CreatePartitionsResult>("createPartitions", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#createTopics(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.CreateTopicsResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.CreateTopicsResult CreateTopics(Java.Util.Collection<Org.Apache.Kafka.Clients.Admin.NewTopic> arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.CreateTopicsResult>("createTopics", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#deleteAcls(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.DeleteAclsResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.DeleteAclsResult DeleteAcls(Java.Util.Collection<Org.Apache.Kafka.Common.Acl.AclBindingFilter> arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.DeleteAclsResult>("deleteAcls", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#deleteConsumerGroupOffsets(java.lang.String,java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.DeleteConsumerGroupOffsetsResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.DeleteConsumerGroupOffsetsResult DeleteConsumerGroupOffsets(string arg0, Java.Util.Set<Org.Apache.Kafka.Common.TopicPartition> arg1)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.DeleteConsumerGroupOffsetsResult>("deleteConsumerGroupOffsets", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#deleteConsumerGroups(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.DeleteConsumerGroupsResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.DeleteConsumerGroupsResult DeleteConsumerGroups(Java.Util.Collection<string> arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.DeleteConsumerGroupsResult>("deleteConsumerGroups", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#deleteRecords(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.DeleteRecordsResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.DeleteRecordsResult DeleteRecords(Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Clients.Admin.RecordsToDelete> arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.DeleteRecordsResult>("deleteRecords", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#deleteTopics(java.util.Collection,org.apache.kafka.clients.admin.DeleteTopicsOptions)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Clients.Admin.DeleteTopicsOptions"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.DeleteTopicsResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.DeleteTopicsResult DeleteTopics(Java.Util.Collection<string> arg0, Org.Apache.Kafka.Clients.Admin.DeleteTopicsOptions arg1)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.DeleteTopicsResult>("deleteTopics", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#deleteTopics(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.DeleteTopicsResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.DeleteTopicsResult DeleteTopics(Java.Util.Collection<string> arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.DeleteTopicsResult>("deleteTopics", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#deleteTopics(org.apache.kafka.common.TopicCollection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicCollection"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.DeleteTopicsResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.DeleteTopicsResult DeleteTopics(Org.Apache.Kafka.Common.TopicCollection arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.DeleteTopicsResult>("deleteTopics", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#describeAcls(org.apache.kafka.common.acl.AclBindingFilter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Acl.AclBindingFilter"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.DescribeAclsResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.DescribeAclsResult DescribeAcls(Org.Apache.Kafka.Common.Acl.AclBindingFilter arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.DescribeAclsResult>("describeAcls", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#describeClientQuotas(org.apache.kafka.common.quota.ClientQuotaFilter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Quota.ClientQuotaFilter"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.DescribeClientQuotasResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.DescribeClientQuotasResult DescribeClientQuotas(Org.Apache.Kafka.Common.Quota.ClientQuotaFilter arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.DescribeClientQuotasResult>("describeClientQuotas", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#describeCluster()"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.DescribeClusterResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.DescribeClusterResult DescribeCluster()
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.DescribeClusterResult>("describeCluster");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#describeConfigs(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.DescribeConfigsResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.DescribeConfigsResult DescribeConfigs(Java.Util.Collection<Org.Apache.Kafka.Common.Config.ConfigResource> arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.DescribeConfigsResult>("describeConfigs", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#describeConsumerGroups(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.DescribeConsumerGroupsResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.DescribeConsumerGroupsResult DescribeConsumerGroups(Java.Util.Collection<string> arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.DescribeConsumerGroupsResult>("describeConsumerGroups", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#describeDelegationToken()"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.DescribeDelegationTokenResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.DescribeDelegationTokenResult DescribeDelegationToken()
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.DescribeDelegationTokenResult>("describeDelegationToken");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#describeFeatures()"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.DescribeFeaturesResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.DescribeFeaturesResult DescribeFeatures()
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.DescribeFeaturesResult>("describeFeatures");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#describeLogDirs(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.DescribeLogDirsResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.DescribeLogDirsResult DescribeLogDirs(Java.Util.Collection<int?> arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.DescribeLogDirsResult>("describeLogDirs", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#describeMetadataQuorum()"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.DescribeMetadataQuorumResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.DescribeMetadataQuorumResult DescribeMetadataQuorum()
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.DescribeMetadataQuorumResult>("describeMetadataQuorum");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#describeProducers(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.DescribeProducersResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.DescribeProducersResult DescribeProducers(Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartition> arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.DescribeProducersResult>("describeProducers", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#describeReplicaLogDirs(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.DescribeReplicaLogDirsResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.DescribeReplicaLogDirsResult DescribeReplicaLogDirs(Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartitionReplica> arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.DescribeReplicaLogDirsResult>("describeReplicaLogDirs", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#describeTopics(java.util.Collection,org.apache.kafka.clients.admin.DescribeTopicsOptions)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Clients.Admin.DescribeTopicsOptions"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.DescribeTopicsResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.DescribeTopicsResult DescribeTopics(Java.Util.Collection<string> arg0, Org.Apache.Kafka.Clients.Admin.DescribeTopicsOptions arg1)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.DescribeTopicsResult>("describeTopics", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#describeTopics(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.DescribeTopicsResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.DescribeTopicsResult DescribeTopics(Java.Util.Collection<string> arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.DescribeTopicsResult>("describeTopics", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#describeTopics(org.apache.kafka.common.TopicCollection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicCollection"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.DescribeTopicsResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.DescribeTopicsResult DescribeTopics(Org.Apache.Kafka.Common.TopicCollection arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.DescribeTopicsResult>("describeTopics", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#describeTransactions(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.DescribeTransactionsResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.DescribeTransactionsResult DescribeTransactions(Java.Util.Collection<string> arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.DescribeTransactionsResult>("describeTransactions", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#describeUserScramCredentials()"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.DescribeUserScramCredentialsResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.DescribeUserScramCredentialsResult DescribeUserScramCredentials()
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.DescribeUserScramCredentialsResult>("describeUserScramCredentials");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#describeUserScramCredentials(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.DescribeUserScramCredentialsResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.DescribeUserScramCredentialsResult DescribeUserScramCredentials(Java.Util.List<string> arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.DescribeUserScramCredentialsResult>("describeUserScramCredentials", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#electLeaders(org.apache.kafka.common.ElectionType,java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.ElectionType"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.ElectLeadersResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.ElectLeadersResult ElectLeaders(Org.Apache.Kafka.Common.ElectionType arg0, Java.Util.Set<Org.Apache.Kafka.Common.TopicPartition> arg1)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.ElectLeadersResult>("electLeaders", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#expireDelegationToken(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.ExpireDelegationTokenResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.ExpireDelegationTokenResult ExpireDelegationToken(byte[] arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.ExpireDelegationTokenResult>("expireDelegationToken", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#fenceProducers(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.FenceProducersResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.FenceProducersResult FenceProducers(Java.Util.Collection<string> arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.FenceProducersResult>("fenceProducers", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#listConsumerGroupOffsets(java.lang.String,org.apache.kafka.clients.admin.ListConsumerGroupOffsetsOptions)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Clients.Admin.ListConsumerGroupOffsetsOptions"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.ListConsumerGroupOffsetsResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.ListConsumerGroupOffsetsResult ListConsumerGroupOffsets(string arg0, Org.Apache.Kafka.Clients.Admin.ListConsumerGroupOffsetsOptions arg1)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.ListConsumerGroupOffsetsResult>("listConsumerGroupOffsets", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#listConsumerGroupOffsets(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.ListConsumerGroupOffsetsResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.ListConsumerGroupOffsetsResult ListConsumerGroupOffsets(string arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.ListConsumerGroupOffsetsResult>("listConsumerGroupOffsets", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#listConsumerGroupOffsets(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.ListConsumerGroupOffsetsResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.ListConsumerGroupOffsetsResult ListConsumerGroupOffsets(Java.Util.Map<string, Org.Apache.Kafka.Clients.Admin.ListConsumerGroupOffsetsSpec> arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.ListConsumerGroupOffsetsResult>("listConsumerGroupOffsets", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#listConsumerGroups()"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.ListConsumerGroupsResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.ListConsumerGroupsResult ListConsumerGroups()
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.ListConsumerGroupsResult>("listConsumerGroups");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#listOffsets(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.ListOffsetsResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.ListOffsetsResult ListOffsets(Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Clients.Admin.OffsetSpec> arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.ListOffsetsResult>("listOffsets", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#listPartitionReassignments()"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.ListPartitionReassignmentsResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.ListPartitionReassignmentsResult ListPartitionReassignments()
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.ListPartitionReassignmentsResult>("listPartitionReassignments");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#listPartitionReassignments(java.util.Set,org.apache.kafka.clients.admin.ListPartitionReassignmentsOptions)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Clients.Admin.ListPartitionReassignmentsOptions"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.ListPartitionReassignmentsResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.ListPartitionReassignmentsResult ListPartitionReassignments(Java.Util.Set<Org.Apache.Kafka.Common.TopicPartition> arg0, Org.Apache.Kafka.Clients.Admin.ListPartitionReassignmentsOptions arg1)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.ListPartitionReassignmentsResult>("listPartitionReassignments", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#listPartitionReassignments(java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.ListPartitionReassignmentsResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.ListPartitionReassignmentsResult ListPartitionReassignments(Java.Util.Set<Org.Apache.Kafka.Common.TopicPartition> arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.ListPartitionReassignmentsResult>("listPartitionReassignments", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#listPartitionReassignments(org.apache.kafka.clients.admin.ListPartitionReassignmentsOptions)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Admin.ListPartitionReassignmentsOptions"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.ListPartitionReassignmentsResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.ListPartitionReassignmentsResult ListPartitionReassignments(Org.Apache.Kafka.Clients.Admin.ListPartitionReassignmentsOptions arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.ListPartitionReassignmentsResult>("listPartitionReassignments", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#listTopics()"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.ListTopicsResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.ListTopicsResult ListTopics()
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.ListTopicsResult>("listTopics");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#listTransactions()"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.ListTransactionsResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.ListTransactionsResult ListTransactions()
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.ListTransactionsResult>("listTransactions");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#renewDelegationToken(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.RenewDelegationTokenResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.RenewDelegationTokenResult RenewDelegationToken(byte[] arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.RenewDelegationTokenResult>("renewDelegationToken", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#unregisterBroker(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.UnregisterBrokerResult"/></returns>
        public Org.Apache.Kafka.Clients.Admin.UnregisterBrokerResult UnregisterBroker(int arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.UnregisterBrokerResult>("unregisterBroker", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/Admin.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
    }
}