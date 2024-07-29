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
*  using kafka-clients-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common
{
    #region Cluster
    public partial class Cluster
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/Cluster.html#org.apache.kafka.common.Cluster(java.lang.String,java.util.Collection,java.util.Collection,java.util.Set,java.util.Set,java.util.Set,org.apache.kafka.common.Node,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg2"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg3"><see cref="Java.Util.Set"/></param>
        /// <param name="arg4"><see cref="Java.Util.Set"/></param>
        /// <param name="arg5"><see cref="Java.Util.Set"/></param>
        /// <param name="arg6"><see cref="Org.Apache.Kafka.Common.Node"/></param>
        /// <param name="arg7"><see cref="Java.Util.Map"/></param>
        public Cluster(Java.Lang.String arg0, Java.Util.Collection<Org.Apache.Kafka.Common.Node> arg1, Java.Util.Collection<Org.Apache.Kafka.Common.PartitionInfo> arg2, Java.Util.Set<Java.Lang.String> arg3, Java.Util.Set<Java.Lang.String> arg4, Java.Util.Set<Java.Lang.String> arg5, Org.Apache.Kafka.Common.Node arg6, Java.Util.Map<Java.Lang.String, Org.Apache.Kafka.Common.Uuid> arg7)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/Cluster.html#org.apache.kafka.common.Cluster(java.lang.String,java.util.Collection,java.util.Collection,java.util.Set,java.util.Set,java.util.Set,org.apache.kafka.common.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg2"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg3"><see cref="Java.Util.Set"/></param>
        /// <param name="arg4"><see cref="Java.Util.Set"/></param>
        /// <param name="arg5"><see cref="Java.Util.Set"/></param>
        /// <param name="arg6"><see cref="Org.Apache.Kafka.Common.Node"/></param>
        public Cluster(Java.Lang.String arg0, Java.Util.Collection<Org.Apache.Kafka.Common.Node> arg1, Java.Util.Collection<Org.Apache.Kafka.Common.PartitionInfo> arg2, Java.Util.Set<Java.Lang.String> arg3, Java.Util.Set<Java.Lang.String> arg4, Java.Util.Set<Java.Lang.String> arg5, Org.Apache.Kafka.Common.Node arg6)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/Cluster.html#org.apache.kafka.common.Cluster(java.lang.String,java.util.Collection,java.util.Collection,java.util.Set,java.util.Set,org.apache.kafka.common.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg2"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg3"><see cref="Java.Util.Set"/></param>
        /// <param name="arg4"><see cref="Java.Util.Set"/></param>
        /// <param name="arg5"><see cref="Org.Apache.Kafka.Common.Node"/></param>
        public Cluster(Java.Lang.String arg0, Java.Util.Collection<Org.Apache.Kafka.Common.Node> arg1, Java.Util.Collection<Org.Apache.Kafka.Common.PartitionInfo> arg2, Java.Util.Set<Java.Lang.String> arg3, Java.Util.Set<Java.Lang.String> arg4, Org.Apache.Kafka.Common.Node arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/Cluster.html#org.apache.kafka.common.Cluster(java.lang.String,java.util.Collection,java.util.Collection,java.util.Set,java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg2"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg3"><see cref="Java.Util.Set"/></param>
        /// <param name="arg4"><see cref="Java.Util.Set"/></param>
        public Cluster(Java.Lang.String arg0, Java.Util.Collection<Org.Apache.Kafka.Common.Node> arg1, Java.Util.Collection<Org.Apache.Kafka.Common.PartitionInfo> arg2, Java.Util.Set<Java.Lang.String> arg3, Java.Util.Set<Java.Lang.String> arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/Cluster.html#bootstrap-java.util.List-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Cluster"/></returns>
        public static Org.Apache.Kafka.Common.Cluster Bootstrap(Java.Util.List<Java.Net.InetSocketAddress> arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.Cluster>(LocalBridgeClazz, "bootstrap", "(Ljava/util/List;)Lorg/apache/kafka/common/Cluster;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/Cluster.html#empty--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Cluster"/></returns>
        public static Org.Apache.Kafka.Common.Cluster Empty()
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.Cluster>(LocalBridgeClazz, "empty", "()Lorg/apache/kafka/common/Cluster;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/Cluster.html#isBootstrapConfigured--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsBootstrapConfigured()
        {
            return IExecuteWithSignature<bool>("isBootstrapConfigured", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/Cluster.html#partitionCountForTopic-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        public Java.Lang.Integer PartitionCountForTopic(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.Integer>("partitionCountForTopic", "(Ljava/lang/String;)Ljava/lang/Integer;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/Cluster.html#topicName-org.apache.kafka.common.Uuid-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Uuid"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String TopicName(Org.Apache.Kafka.Common.Uuid arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("topicName", "(Lorg/apache/kafka/common/Uuid;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/Cluster.html#topicIds--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        public Java.Util.Collection<Org.Apache.Kafka.Common.Uuid> TopicIds()
        {
            return IExecuteWithSignature<Java.Util.Collection<Org.Apache.Kafka.Common.Uuid>>("topicIds", "()Ljava/util/Collection;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/Cluster.html#nodes--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Org.Apache.Kafka.Common.Node> Nodes()
        {
            return IExecuteWithSignature<Java.Util.List<Org.Apache.Kafka.Common.Node>>("nodes", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/Cluster.html#availablePartitionsForTopic-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Org.Apache.Kafka.Common.PartitionInfo> AvailablePartitionsForTopic(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.List<Org.Apache.Kafka.Common.PartitionInfo>>("availablePartitionsForTopic", "(Ljava/lang/String;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/Cluster.html#partitionsForNode-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Org.Apache.Kafka.Common.PartitionInfo> PartitionsForNode(int arg0)
        {
            return IExecuteWithSignature<Java.Util.List<Org.Apache.Kafka.Common.PartitionInfo>>("partitionsForNode", "(I)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/Cluster.html#partitionsForTopic-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Org.Apache.Kafka.Common.PartitionInfo> PartitionsForTopic(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.List<Org.Apache.Kafka.Common.PartitionInfo>>("partitionsForTopic", "(Ljava/lang/String;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/Cluster.html#nodeIfOnline-org.apache.kafka.common.TopicPartition-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Org.Apache.Kafka.Common.Node> NodeIfOnline(Org.Apache.Kafka.Common.TopicPartition arg0, int arg1)
        {
            return IExecute<Java.Util.Optional<Org.Apache.Kafka.Common.Node>>("nodeIfOnline", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/Cluster.html#internalTopics--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> InternalTopics()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("internalTopics", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/Cluster.html#invalidTopics--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> InvalidTopics()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("invalidTopics", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/Cluster.html#topics--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> Topics()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("topics", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/Cluster.html#unauthorizedTopics--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> UnauthorizedTopics()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("unauthorizedTopics", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/Cluster.html#withPartitions-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Cluster"/></returns>
        public Org.Apache.Kafka.Common.Cluster WithPartitions(Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Common.PartitionInfo> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Cluster>("withPartitions", "(Ljava/util/Map;)Lorg/apache/kafka/common/Cluster;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/Cluster.html#clusterResource--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.ClusterResource"/></returns>
        public Org.Apache.Kafka.Common.ClusterResource ClusterResource()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.ClusterResource>("clusterResource", "()Lorg/apache/kafka/common/ClusterResource;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/Cluster.html#controller--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Node"/></returns>
        public Org.Apache.Kafka.Common.Node Controller()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Node>("controller", "()Lorg/apache/kafka/common/Node;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/Cluster.html#leaderFor-org.apache.kafka.common.TopicPartition-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Node"/></returns>
        public Org.Apache.Kafka.Common.Node LeaderFor(Org.Apache.Kafka.Common.TopicPartition arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Node>("leaderFor", "(Lorg/apache/kafka/common/TopicPartition;)Lorg/apache/kafka/common/Node;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/Cluster.html#nodeById-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Node"/></returns>
        public Org.Apache.Kafka.Common.Node NodeById(int arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Node>("nodeById", "(I)Lorg/apache/kafka/common/Node;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/Cluster.html#partition-org.apache.kafka.common.TopicPartition-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.PartitionInfo"/></returns>
        public Org.Apache.Kafka.Common.PartitionInfo Partition(Org.Apache.Kafka.Common.TopicPartition arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.PartitionInfo>("partition", "(Lorg/apache/kafka/common/TopicPartition;)Lorg/apache/kafka/common/PartitionInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/Cluster.html#topicId-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Uuid"/></returns>
        public Org.Apache.Kafka.Common.Uuid TopicId(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Uuid>("topicId", "(Ljava/lang/String;)Lorg/apache/kafka/common/Uuid;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}