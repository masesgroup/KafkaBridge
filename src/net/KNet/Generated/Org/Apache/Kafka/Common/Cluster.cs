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
*  This file is generated by MASES.JNetReflector (ver. 2.2.1.0)
*  using kafka-clients-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common
{
    #region Cluster
    public partial class Cluster
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/Cluster.html#org.apache.kafka.common.Cluster(java.lang.String,java.util.Collection,java.util.Collection,java.util.Set,java.util.Set,java.util.Set,org.apache.kafka.common.Node,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg2"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg3"><see cref="Java.Util.Set"/></param>
        /// <param name="arg4"><see cref="Java.Util.Set"/></param>
        /// <param name="arg5"><see cref="Java.Util.Set"/></param>
        /// <param name="arg6"><see cref="Org.Apache.Kafka.Common.Node"/></param>
        /// <param name="arg7"><see cref="Java.Util.Map"/></param>
        public Cluster(string arg0, Java.Util.Collection<Org.Apache.Kafka.Common.Node> arg1, Java.Util.Collection<Org.Apache.Kafka.Common.PartitionInfo> arg2, Java.Util.Set<string> arg3, Java.Util.Set<string> arg4, Java.Util.Set<string> arg5, Org.Apache.Kafka.Common.Node arg6, Java.Util.Map<string, Org.Apache.Kafka.Common.Uuid> arg7)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/Cluster.html#org.apache.kafka.common.Cluster(java.lang.String,java.util.Collection,java.util.Collection,java.util.Set,java.util.Set,java.util.Set,org.apache.kafka.common.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg2"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg3"><see cref="Java.Util.Set"/></param>
        /// <param name="arg4"><see cref="Java.Util.Set"/></param>
        /// <param name="arg5"><see cref="Java.Util.Set"/></param>
        /// <param name="arg6"><see cref="Org.Apache.Kafka.Common.Node"/></param>
        public Cluster(string arg0, Java.Util.Collection<Org.Apache.Kafka.Common.Node> arg1, Java.Util.Collection<Org.Apache.Kafka.Common.PartitionInfo> arg2, Java.Util.Set<string> arg3, Java.Util.Set<string> arg4, Java.Util.Set<string> arg5, Org.Apache.Kafka.Common.Node arg6)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/Cluster.html#org.apache.kafka.common.Cluster(java.lang.String,java.util.Collection,java.util.Collection,java.util.Set,java.util.Set,org.apache.kafka.common.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg2"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg3"><see cref="Java.Util.Set"/></param>
        /// <param name="arg4"><see cref="Java.Util.Set"/></param>
        /// <param name="arg5"><see cref="Org.Apache.Kafka.Common.Node"/></param>
        public Cluster(string arg0, Java.Util.Collection<Org.Apache.Kafka.Common.Node> arg1, Java.Util.Collection<Org.Apache.Kafka.Common.PartitionInfo> arg2, Java.Util.Set<string> arg3, Java.Util.Set<string> arg4, Org.Apache.Kafka.Common.Node arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/Cluster.html#org.apache.kafka.common.Cluster(java.lang.String,java.util.Collection,java.util.Collection,java.util.Set,java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg2"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg3"><see cref="Java.Util.Set"/></param>
        /// <param name="arg4"><see cref="Java.Util.Set"/></param>
        public Cluster(string arg0, Java.Util.Collection<Org.Apache.Kafka.Common.Node> arg1, Java.Util.Collection<Org.Apache.Kafka.Common.PartitionInfo> arg2, Java.Util.Set<string> arg3, Java.Util.Set<string> arg4)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/Cluster.html#bootstrap-java.util.List-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Cluster"/></returns>
        public static Org.Apache.Kafka.Common.Cluster Bootstrap(Java.Util.List<Java.Net.InetSocketAddress> arg0)
        {
            return SExecute<Org.Apache.Kafka.Common.Cluster>(LocalBridgeClazz, "bootstrap", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/Cluster.html#empty--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Cluster"/></returns>
        public static Org.Apache.Kafka.Common.Cluster Empty()
        {
            return SExecute<Org.Apache.Kafka.Common.Cluster>(LocalBridgeClazz, "empty");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/Cluster.html#isBootstrapConfigured--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsBootstrapConfigured()
        {
            return IExecute<bool>("isBootstrapConfigured");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/Cluster.html#partitionCountForTopic-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        public Java.Lang.Integer PartitionCountForTopic(string arg0)
        {
            return IExecute<Java.Lang.Integer>("partitionCountForTopic", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/Cluster.html#topicName-org.apache.kafka.common.Uuid-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Uuid"/></param>
        /// <returns><see cref="string"/></returns>
        public string TopicName(Org.Apache.Kafka.Common.Uuid arg0)
        {
            return IExecute<string>("topicName", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/Cluster.html#topicIds--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Collection"/></returns>
        public Java.Util.Collection<Org.Apache.Kafka.Common.Uuid> TopicIds()
        {
            return IExecute<Java.Util.Collection<Org.Apache.Kafka.Common.Uuid>>("topicIds");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/Cluster.html#nodes--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Org.Apache.Kafka.Common.Node> Nodes()
        {
            return IExecute<Java.Util.List<Org.Apache.Kafka.Common.Node>>("nodes");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/Cluster.html#availablePartitionsForTopic-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Org.Apache.Kafka.Common.PartitionInfo> AvailablePartitionsForTopic(string arg0)
        {
            return IExecute<Java.Util.List<Org.Apache.Kafka.Common.PartitionInfo>>("availablePartitionsForTopic", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/Cluster.html#partitionsForNode-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Org.Apache.Kafka.Common.PartitionInfo> PartitionsForNode(int arg0)
        {
            return IExecute<Java.Util.List<Org.Apache.Kafka.Common.PartitionInfo>>("partitionsForNode", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/Cluster.html#partitionsForTopic-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Org.Apache.Kafka.Common.PartitionInfo> PartitionsForTopic(string arg0)
        {
            return IExecute<Java.Util.List<Org.Apache.Kafka.Common.PartitionInfo>>("partitionsForTopic", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/Cluster.html#nodeIfOnline-org.apache.kafka.common.TopicPartition-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Org.Apache.Kafka.Common.Node> NodeIfOnline(Org.Apache.Kafka.Common.TopicPartition arg0, int arg1)
        {
            return IExecute<Java.Util.Optional<Org.Apache.Kafka.Common.Node>>("nodeIfOnline", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/Cluster.html#internalTopics--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<string> InternalTopics()
        {
            return IExecute<Java.Util.Set<string>>("internalTopics");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/Cluster.html#invalidTopics--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<string> InvalidTopics()
        {
            return IExecute<Java.Util.Set<string>>("invalidTopics");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/Cluster.html#topics--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<string> Topics()
        {
            return IExecute<Java.Util.Set<string>>("topics");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/Cluster.html#unauthorizedTopics--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<string> UnauthorizedTopics()
        {
            return IExecute<Java.Util.Set<string>>("unauthorizedTopics");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/Cluster.html#withPartitions-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Cluster"/></returns>
        public Org.Apache.Kafka.Common.Cluster WithPartitions(Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Common.PartitionInfo> arg0)
        {
            return IExecute<Org.Apache.Kafka.Common.Cluster>("withPartitions", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/Cluster.html#clusterResource--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.ClusterResource"/></returns>
        public Org.Apache.Kafka.Common.ClusterResource ClusterResource()
        {
            return IExecute<Org.Apache.Kafka.Common.ClusterResource>("clusterResource");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/Cluster.html#controller--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Node"/></returns>
        public Org.Apache.Kafka.Common.Node Controller()
        {
            return IExecute<Org.Apache.Kafka.Common.Node>("controller");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/Cluster.html#leaderFor-org.apache.kafka.common.TopicPartition-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Node"/></returns>
        public Org.Apache.Kafka.Common.Node LeaderFor(Org.Apache.Kafka.Common.TopicPartition arg0)
        {
            return IExecute<Org.Apache.Kafka.Common.Node>("leaderFor", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/Cluster.html#nodeById-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Node"/></returns>
        public Org.Apache.Kafka.Common.Node NodeById(int arg0)
        {
            return IExecute<Org.Apache.Kafka.Common.Node>("nodeById", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/Cluster.html#partition-org.apache.kafka.common.TopicPartition-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.PartitionInfo"/></returns>
        public Org.Apache.Kafka.Common.PartitionInfo Partition(Org.Apache.Kafka.Common.TopicPartition arg0)
        {
            return IExecute<Org.Apache.Kafka.Common.PartitionInfo>("partition", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/Cluster.html#topicId-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Uuid"/></returns>
        public Org.Apache.Kafka.Common.Uuid TopicId(string arg0)
        {
            return IExecute<Org.Apache.Kafka.Common.Uuid>("topicId", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}