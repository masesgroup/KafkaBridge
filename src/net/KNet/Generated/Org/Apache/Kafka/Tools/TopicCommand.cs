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
*  This file is generated by MASES.JNetReflector (ver. 2.5.3.0)
*  using kafka-tools-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Tools
{
    #region TopicCommand
    public partial class TopicCommand
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/TopicCommand.html#isReassignmentInProgress-org.apache.kafka.common.TopicPartitionInfo-org.apache.kafka.clients.admin.PartitionReassignment-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicPartitionInfo"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Clients.Admin.PartitionReassignment"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsReassignmentInProgress(Org.Apache.Kafka.Common.TopicPartitionInfo arg0, Org.Apache.Kafka.Clients.Admin.PartitionReassignment arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "isReassignmentInProgress", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/TopicCommand.html#main-java.lang.String[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public static void Main(params Java.Lang.String[] arg0)
        {
            if (arg0.Length == 0) SExecuteWithSignature(LocalBridgeClazz, "main", "([Ljava/lang/String;)V"); else SExecuteWithSignature(LocalBridgeClazz, "main", "([Ljava/lang/String;)V", arg0);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region TopicCommandOptions
        public partial class TopicCommandOptions
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/TopicCommand.TopicCommandOptions.html#org.apache.kafka.tools.TopicCommand$TopicCommandOptions(java.lang.String[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            public TopicCommandOptions(Java.Lang.String[] arg0)
                : base(arg0)
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/TopicCommand.TopicCommandOptions.html#excludeInternalTopics--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.Boolean"/></returns>
            public Java.Lang.Boolean ExcludeInternalTopics()
            {
                return IExecuteWithSignature<Java.Lang.Boolean>("excludeInternalTopics", "()Ljava/lang/Boolean;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/TopicCommand.TopicCommandOptions.html#hasAlterOption--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.Boolean"/></returns>
            public Java.Lang.Boolean HasAlterOption()
            {
                return IExecuteWithSignature<Java.Lang.Boolean>("hasAlterOption", "()Ljava/lang/Boolean;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/TopicCommand.TopicCommandOptions.html#hasCreateOption--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.Boolean"/></returns>
            public Java.Lang.Boolean HasCreateOption()
            {
                return IExecuteWithSignature<Java.Lang.Boolean>("hasCreateOption", "()Ljava/lang/Boolean;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/TopicCommand.TopicCommandOptions.html#hasDeleteOption--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.Boolean"/></returns>
            public Java.Lang.Boolean HasDeleteOption()
            {
                return IExecuteWithSignature<Java.Lang.Boolean>("hasDeleteOption", "()Ljava/lang/Boolean;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/TopicCommand.TopicCommandOptions.html#hasDescribeOption--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.Boolean"/></returns>
            public Java.Lang.Boolean HasDescribeOption()
            {
                return IExecuteWithSignature<Java.Lang.Boolean>("hasDescribeOption", "()Ljava/lang/Boolean;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/TopicCommand.TopicCommandOptions.html#hasListOption--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.Boolean"/></returns>
            public Java.Lang.Boolean HasListOption()
            {
                return IExecuteWithSignature<Java.Lang.Boolean>("hasListOption", "()Ljava/lang/Boolean;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/TopicCommand.TopicCommandOptions.html#ifExists--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.Boolean"/></returns>
            public Java.Lang.Boolean IfExists()
            {
                return IExecuteWithSignature<Java.Lang.Boolean>("ifExists", "()Ljava/lang/Boolean;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/TopicCommand.TopicCommandOptions.html#ifNotExists--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.Boolean"/></returns>
            public Java.Lang.Boolean IfNotExists()
            {
                return IExecuteWithSignature<Java.Lang.Boolean>("ifNotExists", "()Ljava/lang/Boolean;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/TopicCommand.TopicCommandOptions.html#reportAtMinIsrPartitions--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.Boolean"/></returns>
            public Java.Lang.Boolean ReportAtMinIsrPartitions()
            {
                return IExecuteWithSignature<Java.Lang.Boolean>("reportAtMinIsrPartitions", "()Ljava/lang/Boolean;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/TopicCommand.TopicCommandOptions.html#reportOverriddenConfigs--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.Boolean"/></returns>
            public Java.Lang.Boolean ReportOverriddenConfigs()
            {
                return IExecuteWithSignature<Java.Lang.Boolean>("reportOverriddenConfigs", "()Ljava/lang/Boolean;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/TopicCommand.TopicCommandOptions.html#reportUnavailablePartitions--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.Boolean"/></returns>
            public Java.Lang.Boolean ReportUnavailablePartitions()
            {
                return IExecuteWithSignature<Java.Lang.Boolean>("reportUnavailablePartitions", "()Ljava/lang/Boolean;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/TopicCommand.TopicCommandOptions.html#reportUnderMinIsrPartitions--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.Boolean"/></returns>
            public Java.Lang.Boolean ReportUnderMinIsrPartitions()
            {
                return IExecuteWithSignature<Java.Lang.Boolean>("reportUnderMinIsrPartitions", "()Ljava/lang/Boolean;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/TopicCommand.TopicCommandOptions.html#reportUnderReplicatedPartitions--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.Boolean"/></returns>
            public Java.Lang.Boolean ReportUnderReplicatedPartitions()
            {
                return IExecuteWithSignature<Java.Lang.Boolean>("reportUnderReplicatedPartitions", "()Ljava/lang/Boolean;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/TopicCommand.TopicCommandOptions.html#partitions--"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Optional"/></returns>
            public Java.Util.Optional<Java.Lang.Integer> Partitions()
            {
                return IExecuteWithSignature<Java.Util.Optional<Java.Lang.Integer>>("partitions", "()Ljava/util/Optional;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/TopicCommand.TopicCommandOptions.html#replicationFactor--"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Optional"/></returns>
            public Java.Util.Optional<Java.Lang.Integer> ReplicationFactor()
            {
                return IExecuteWithSignature<Java.Util.Optional<Java.Lang.Integer>>("replicationFactor", "()Ljava/util/Optional;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/TopicCommand.TopicCommandOptions.html#bootstrapServer--"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Optional"/></returns>
            public Java.Util.Optional<Java.Lang.String> BootstrapServer()
            {
                return IExecuteWithSignature<Java.Util.Optional<Java.Lang.String>>("bootstrapServer", "()Ljava/util/Optional;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/TopicCommand.TopicCommandOptions.html#topic--"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Optional"/></returns>
            public Java.Util.Optional<Java.Lang.String> Topic()
            {
                return IExecuteWithSignature<Java.Util.Optional<Java.Lang.String>>("topic", "()Ljava/util/Optional;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/TopicCommand.TopicCommandOptions.html#topicId--"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Optional"/></returns>
            public Java.Util.Optional<Java.Lang.String> TopicId()
            {
                return IExecuteWithSignature<Java.Util.Optional<Java.Lang.String>>("topicId", "()Ljava/util/Optional;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/TopicCommand.TopicCommandOptions.html#topicConfig--"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Optional"/></returns>
            public Java.Util.Optional<Java.Util.List<Java.Lang.String>> TopicConfig()
            {
                return IExecuteWithSignature<Java.Util.Optional<Java.Util.List<Java.Lang.String>>>("topicConfig", "()Ljava/util/Optional;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/TopicCommand.TopicCommandOptions.html#replicaAssignment--"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Optional"/></returns>
            public Java.Util.Optional<Java.Util.Map<Java.Lang.Integer, Java.Util.List<Java.Lang.Integer>>> ReplicaAssignment()
            {
                return IExecuteWithSignature<Java.Util.Optional<Java.Util.Map<Java.Lang.Integer, Java.Util.List<Java.Lang.Integer>>>>("replicaAssignment", "()Ljava/util/Optional;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/TopicCommand.TopicCommandOptions.html#commandConfig--"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Properties"/></returns>
            /// <exception cref="Java.Io.IOException"/>
            public Java.Util.Properties CommandConfig()
            {
                return IExecuteWithSignature<Java.Util.Properties>("commandConfig", "()Ljava/util/Properties;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/TopicCommand.TopicCommandOptions.html#checkArgs--"/>
            /// </summary>
            public void CheckArgs()
            {
                IExecuteWithSignature("checkArgs", "()V");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region TopicService
        public partial class TopicService
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/TopicCommand.TopicService.html#org.apache.kafka.tools.TopicCommand$TopicService(java.util.Properties,java.util.Optional)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Properties"/></param>
            /// <param name="arg1"><see cref="Java.Util.Optional"/></param>
            public TopicService(Java.Util.Properties arg0, Java.Util.Optional<Java.Lang.String> arg1)
                : base(arg0, arg1)
            {
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/TopicCommand.TopicService.html#org.apache.kafka.tools.TopicCommand$TopicService(org.apache.kafka.clients.admin.Admin)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Admin.Admin"/></param>
            public TopicService(Org.Apache.Kafka.Clients.Admin.Admin arg0)
                : base(arg0)
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/TopicCommand.TopicService.html#getTopics-java.util.Optional-boolean-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Optional"/></param>
            /// <param name="arg1"><see cref="bool"/></param>
            /// <returns><see cref="Java.Util.List"/></returns>
            /// <exception cref="Java.Util.Concurrent.ExecutionException"/>
            /// <exception cref="Java.Lang.InterruptedException"/>
            public Java.Util.List<Java.Lang.String> GetTopics(Java.Util.Optional<Java.Lang.String> arg0, bool arg1)
            {
                return IExecute<Java.Util.List<Java.Lang.String>>("getTopics", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/TopicCommand.TopicService.html#getTopicIds-org.apache.kafka.common.Uuid-boolean-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Uuid"/></param>
            /// <param name="arg1"><see cref="bool"/></param>
            /// <returns><see cref="Java.Util.List"/></returns>
            /// <exception cref="Java.Util.Concurrent.ExecutionException"/>
            /// <exception cref="Java.Lang.InterruptedException"/>
            public Java.Util.List<Org.Apache.Kafka.Common.Uuid> GetTopicIds(Org.Apache.Kafka.Common.Uuid arg0, bool arg1)
            {
                return IExecute<Java.Util.List<Org.Apache.Kafka.Common.Uuid>>("getTopicIds", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/TopicCommand.TopicService.html#listAllReassignments-java.util.Set-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Set"/></param>
            /// <returns><see cref="Java.Util.Map"/></returns>
            public Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Clients.Admin.PartitionReassignment> ListAllReassignments(Java.Util.Set<Org.Apache.Kafka.Common.TopicPartition> arg0)
            {
                return IExecuteWithSignature<Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Clients.Admin.PartitionReassignment>>("listAllReassignments", "(Ljava/util/Set;)Ljava/util/Map;", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/TopicCommand.TopicService.html#alterTopic-org.apache.kafka.tools.TopicCommand.TopicCommandOptions-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Tools.TopicCommand.TopicCommandOptions"/></param>
            /// <exception cref="Java.Util.Concurrent.ExecutionException"/>
            /// <exception cref="Java.Lang.InterruptedException"/>
            public void AlterTopic(Org.Apache.Kafka.Tools.TopicCommand.TopicCommandOptions arg0)
            {
                IExecuteWithSignature("alterTopic", "(Lorg/apache/kafka/tools/TopicCommand$TopicCommandOptions;)V", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/TopicCommand.TopicService.html#close--"/>
            /// </summary>
            /// <exception cref="Java.Lang.Exception"/>
            public void Close()
            {
                IExecuteWithSignature("close", "()V");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/TopicCommand.TopicService.html#createTopic-org.apache.kafka.tools.TopicCommand.TopicCommandOptions-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Tools.TopicCommand.TopicCommandOptions"/></param>
            /// <exception cref="Java.Lang.Exception"/>
            public void CreateTopic(Org.Apache.Kafka.Tools.TopicCommand.TopicCommandOptions arg0)
            {
                IExecuteWithSignature("createTopic", "(Lorg/apache/kafka/tools/TopicCommand$TopicCommandOptions;)V", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/TopicCommand.TopicService.html#deleteTopic-org.apache.kafka.tools.TopicCommand.TopicCommandOptions-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Tools.TopicCommand.TopicCommandOptions"/></param>
            /// <exception cref="Java.Util.Concurrent.ExecutionException"/>
            /// <exception cref="Java.Lang.InterruptedException"/>
            public void DeleteTopic(Org.Apache.Kafka.Tools.TopicCommand.TopicCommandOptions arg0)
            {
                IExecuteWithSignature("deleteTopic", "(Lorg/apache/kafka/tools/TopicCommand$TopicCommandOptions;)V", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/TopicCommand.TopicService.html#describeTopic-org.apache.kafka.tools.TopicCommand.TopicCommandOptions-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Tools.TopicCommand.TopicCommandOptions"/></param>
            /// <exception cref="Java.Util.Concurrent.ExecutionException"/>
            /// <exception cref="Java.Lang.InterruptedException"/>
            public void DescribeTopic(Org.Apache.Kafka.Tools.TopicCommand.TopicCommandOptions arg0)
            {
                IExecuteWithSignature("describeTopic", "(Lorg/apache/kafka/tools/TopicCommand$TopicCommandOptions;)V", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/TopicCommand.TopicService.html#listTopics-org.apache.kafka.tools.TopicCommand.TopicCommandOptions-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Tools.TopicCommand.TopicCommandOptions"/></param>
            /// <exception cref="Java.Util.Concurrent.ExecutionException"/>
            /// <exception cref="Java.Lang.InterruptedException"/>
            public void ListTopics(Org.Apache.Kafka.Tools.TopicCommand.TopicCommandOptions arg0)
            {
                IExecuteWithSignature("listTopics", "(Lorg/apache/kafka/tools/TopicCommand$TopicCommandOptions;)V", arg0);
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