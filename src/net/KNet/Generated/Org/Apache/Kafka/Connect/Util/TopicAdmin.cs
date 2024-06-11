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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using connect-runtime-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Util
{
    #region TopicAdmin
    public partial class TopicAdmin
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.0/org/apache/kafka/connect/util/TopicAdmin.html#org.apache.kafka.connect.util.TopicAdmin(java.util.Map,org.apache.kafka.clients.admin.Admin)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Clients.Admin.Admin"/></param>
        public TopicAdmin(Java.Util.Map<Java.Lang.String, object> arg0, Org.Apache.Kafka.Clients.Admin.Admin arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.0/org/apache/kafka/connect/util/TopicAdmin.html#org.apache.kafka.connect.util.TopicAdmin(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public TopicAdmin(Java.Util.Map<Java.Lang.String, object> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.0/org/apache/kafka/connect/util/TopicAdmin.html#NO_PARTITIONS"/>
        /// </summary>
        public static int NO_PARTITIONS { get { if (!_NO_PARTITIONSReady) { _NO_PARTITIONSContent = SGetField<int>(LocalBridgeClazz, "NO_PARTITIONS"); _NO_PARTITIONSReady = true; } return _NO_PARTITIONSContent; } }
        private static int _NO_PARTITIONSContent = default;
        private static bool _NO_PARTITIONSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.0/org/apache/kafka/connect/util/TopicAdmin.html#EMPTY_CREATION"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Util.TopicAdmin.TopicCreationResponse EMPTY_CREATION { get { if (!_EMPTY_CREATIONReady) { _EMPTY_CREATIONContent = SGetField<Org.Apache.Kafka.Connect.Util.TopicAdmin.TopicCreationResponse>(LocalBridgeClazz, "EMPTY_CREATION"); _EMPTY_CREATIONReady = true; } return _EMPTY_CREATIONContent; } }
        private static Org.Apache.Kafka.Connect.Util.TopicAdmin.TopicCreationResponse _EMPTY_CREATIONContent = default;
        private static bool _EMPTY_CREATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.0/org/apache/kafka/connect/util/TopicAdmin.html#NO_REPLICATION_FACTOR"/>
        /// </summary>
        public static short NO_REPLICATION_FACTOR { get { if (!_NO_REPLICATION_FACTORReady) { _NO_REPLICATION_FACTORContent = SGetField<short>(LocalBridgeClazz, "NO_REPLICATION_FACTOR"); _NO_REPLICATION_FACTORReady = true; } return _NO_REPLICATION_FACTORContent; } }
        private static short _NO_REPLICATION_FACTORContent = default;
        private static bool _NO_REPLICATION_FACTORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.0/org/apache/kafka/connect/util/TopicAdmin.html#defineTopic-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Util.TopicAdmin.NewTopicBuilder"/></returns>
        public static Org.Apache.Kafka.Connect.Util.TopicAdmin.NewTopicBuilder DefineTopic(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Connect.Util.TopicAdmin.NewTopicBuilder>(LocalBridgeClazz, "defineTopic", "(Ljava/lang/String;)Lorg/apache/kafka/connect/util/TopicAdmin$NewTopicBuilder;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.0/org/apache/kafka/connect/util/TopicAdmin.html#createOrFindTopic-org.apache.kafka.clients.admin.NewTopic-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Admin.NewTopic"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CreateOrFindTopic(Org.Apache.Kafka.Clients.Admin.NewTopic arg0)
        {
            return IExecuteWithSignature<bool>("createOrFindTopic", "(Lorg/apache/kafka/clients/admin/NewTopic;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.0/org/apache/kafka/connect/util/TopicAdmin.html#createTopic-org.apache.kafka.clients.admin.NewTopic-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Admin.NewTopic"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CreateTopic(Org.Apache.Kafka.Clients.Admin.NewTopic arg0)
        {
            return IExecuteWithSignature<bool>("createTopic", "(Lorg/apache/kafka/clients/admin/NewTopic;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.0/org/apache/kafka/connect/util/TopicAdmin.html#verifyTopicCleanupPolicyOnlyCompact-java.lang.String-java.lang.String-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool VerifyTopicCleanupPolicyOnlyCompact(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            return IExecute<bool>("verifyTopicCleanupPolicyOnlyCompact", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.0/org/apache/kafka/connect/util/TopicAdmin.html#describeTopicConfigs-java.lang.String[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, Org.Apache.Kafka.Clients.Admin.Config> DescribeTopicConfigs(params Java.Lang.String[] arg0)
        {
            if (arg0.Length == 0) return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Org.Apache.Kafka.Clients.Admin.Config>>("describeTopicConfigs", "([Ljava/lang/String;)Ljava/util/Map;"); else return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Org.Apache.Kafka.Clients.Admin.Config>>("describeTopicConfigs", "([Ljava/lang/String;)Ljava/util/Map;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.0/org/apache/kafka/connect/util/TopicAdmin.html#describeTopics-java.lang.String[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, Org.Apache.Kafka.Clients.Admin.TopicDescription> DescribeTopics(params Java.Lang.String[] arg0)
        {
            if (arg0.Length == 0) return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Org.Apache.Kafka.Clients.Admin.TopicDescription>>("describeTopics", "([Ljava/lang/String;)Ljava/util/Map;"); else return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Org.Apache.Kafka.Clients.Admin.TopicDescription>>("describeTopics", "([Ljava/lang/String;)Ljava/util/Map;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.0/org/apache/kafka/connect/util/TopicAdmin.html#endOffsets-java.util.Set-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Java.Lang.Long> EndOffsets(Java.Util.Set<Org.Apache.Kafka.Common.TopicPartition> arg0)
        {
            return IExecuteWithSignature<Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Java.Lang.Long>>("endOffsets", "(Ljava/util/Set;)Ljava/util/Map;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.0/org/apache/kafka/connect/util/TopicAdmin.html#retryEndOffsets-java.util.Set-java.time.Duration-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <param name="arg1"><see cref="Java.Time.Duration"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Java.Lang.Long> RetryEndOffsets(Java.Util.Set<Org.Apache.Kafka.Common.TopicPartition> arg0, Java.Time.Duration arg1, long arg2)
        {
            return IExecute<Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Java.Lang.Long>>("retryEndOffsets", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.0/org/apache/kafka/connect/util/TopicAdmin.html#createTopics-org.apache.kafka.clients.admin.NewTopic[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Admin.NewTopic"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> CreateTopics(params Org.Apache.Kafka.Clients.Admin.NewTopic[] arg0)
        {
            if (arg0.Length == 0) return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("createTopics", "([Lorg/apache/kafka/clients/admin/NewTopic;)Ljava/util/Set;"); else return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("createTopics", "([Lorg/apache/kafka/clients/admin/NewTopic;)Ljava/util/Set;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.0/org/apache/kafka/connect/util/TopicAdmin.html#createTopicsWithRetry-org.apache.kafka.clients.admin.NewTopic-long-long-org.apache.kafka.common.utils.Time-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Admin.NewTopic"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Common.Utils.Time"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> CreateTopicsWithRetry(Org.Apache.Kafka.Clients.Admin.NewTopic arg0, long arg1, long arg2, Org.Apache.Kafka.Common.Utils.Time arg3)
        {
            return IExecute<Java.Util.Set<Java.Lang.String>>("createTopicsWithRetry", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.0/org/apache/kafka/connect/util/TopicAdmin.html#topicCleanupPolicy-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> TopicCleanupPolicy(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("topicCleanupPolicy", "(Ljava/lang/String;)Ljava/util/Set;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.0/org/apache/kafka/connect/util/TopicAdmin.html#describeTopicConfig-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.Config"/></returns>
        public Org.Apache.Kafka.Clients.Admin.Config DescribeTopicConfig(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Clients.Admin.Config>("describeTopicConfig", "(Ljava/lang/String;)Lorg/apache/kafka/clients/admin/Config;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.0/org/apache/kafka/connect/util/TopicAdmin.html#createOrFindTopics-org.apache.kafka.clients.admin.NewTopic[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Admin.NewTopic"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Util.TopicAdmin.TopicCreationResponse"/></returns>
        public Org.Apache.Kafka.Connect.Util.TopicAdmin.TopicCreationResponse CreateOrFindTopics(params Org.Apache.Kafka.Clients.Admin.NewTopic[] arg0)
        {
            if (arg0.Length == 0) return IExecuteWithSignature<Org.Apache.Kafka.Connect.Util.TopicAdmin.TopicCreationResponse>("createOrFindTopics", "([Lorg/apache/kafka/clients/admin/NewTopic;)Lorg/apache/kafka/connect/util/TopicAdmin$TopicCreationResponse;"); else return IExecuteWithSignature<Org.Apache.Kafka.Connect.Util.TopicAdmin.TopicCreationResponse>("createOrFindTopics", "([Lorg/apache/kafka/clients/admin/NewTopic;)Lorg/apache/kafka/connect/util/TopicAdmin$TopicCreationResponse;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.0/org/apache/kafka/connect/util/TopicAdmin.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.0/org/apache/kafka/connect/util/TopicAdmin.html#close-java.time.Duration-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Duration"/></param>
        public void Close(Java.Time.Duration arg0)
        {
            IExecuteWithSignature("close", "(Ljava/time/Duration;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region NewTopicBuilder
        public partial class NewTopicBuilder
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.0/org/apache/kafka/connect/util/TopicAdmin.NewTopicBuilder.html#build--"/>
            /// </summary>
            /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.NewTopic"/></returns>
            public Org.Apache.Kafka.Clients.Admin.NewTopic Build()
            {
                return IExecuteWithSignature<Org.Apache.Kafka.Clients.Admin.NewTopic>("build", "()Lorg/apache/kafka/clients/admin/NewTopic;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.0/org/apache/kafka/connect/util/TopicAdmin.NewTopicBuilder.html#compacted--"/>
            /// </summary>
            /// <returns><see cref="Org.Apache.Kafka.Connect.Util.TopicAdmin.NewTopicBuilder"/></returns>
            public Org.Apache.Kafka.Connect.Util.TopicAdmin.NewTopicBuilder Compacted()
            {
                return IExecuteWithSignature<Org.Apache.Kafka.Connect.Util.TopicAdmin.NewTopicBuilder>("compacted", "()Lorg/apache/kafka/connect/util/TopicAdmin$NewTopicBuilder;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.0/org/apache/kafka/connect/util/TopicAdmin.NewTopicBuilder.html#config-java.util.Map-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Map"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Connect.Util.TopicAdmin.NewTopicBuilder"/></returns>
            public Org.Apache.Kafka.Connect.Util.TopicAdmin.NewTopicBuilder Config(Java.Util.Map<Java.Lang.String, object> arg0)
            {
                return IExecuteWithSignature<Org.Apache.Kafka.Connect.Util.TopicAdmin.NewTopicBuilder>("config", "(Ljava/util/Map;)Lorg/apache/kafka/connect/util/TopicAdmin$NewTopicBuilder;", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.0/org/apache/kafka/connect/util/TopicAdmin.NewTopicBuilder.html#defaultPartitions--"/>
            /// </summary>
            /// <returns><see cref="Org.Apache.Kafka.Connect.Util.TopicAdmin.NewTopicBuilder"/></returns>
            public Org.Apache.Kafka.Connect.Util.TopicAdmin.NewTopicBuilder DefaultPartitions()
            {
                return IExecuteWithSignature<Org.Apache.Kafka.Connect.Util.TopicAdmin.NewTopicBuilder>("defaultPartitions", "()Lorg/apache/kafka/connect/util/TopicAdmin$NewTopicBuilder;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.0/org/apache/kafka/connect/util/TopicAdmin.NewTopicBuilder.html#defaultReplicationFactor--"/>
            /// </summary>
            /// <returns><see cref="Org.Apache.Kafka.Connect.Util.TopicAdmin.NewTopicBuilder"/></returns>
            public Org.Apache.Kafka.Connect.Util.TopicAdmin.NewTopicBuilder DefaultReplicationFactor()
            {
                return IExecuteWithSignature<Org.Apache.Kafka.Connect.Util.TopicAdmin.NewTopicBuilder>("defaultReplicationFactor", "()Lorg/apache/kafka/connect/util/TopicAdmin$NewTopicBuilder;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.0/org/apache/kafka/connect/util/TopicAdmin.NewTopicBuilder.html#minInSyncReplicas-short-"/>
            /// </summary>
            /// <param name="arg0"><see cref="short"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Connect.Util.TopicAdmin.NewTopicBuilder"/></returns>
            public Org.Apache.Kafka.Connect.Util.TopicAdmin.NewTopicBuilder MinInSyncReplicas(short arg0)
            {
                return IExecuteWithSignature<Org.Apache.Kafka.Connect.Util.TopicAdmin.NewTopicBuilder>("minInSyncReplicas", "(S)Lorg/apache/kafka/connect/util/TopicAdmin$NewTopicBuilder;", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.0/org/apache/kafka/connect/util/TopicAdmin.NewTopicBuilder.html#partitions-int-"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Connect.Util.TopicAdmin.NewTopicBuilder"/></returns>
            public Org.Apache.Kafka.Connect.Util.TopicAdmin.NewTopicBuilder Partitions(int arg0)
            {
                return IExecuteWithSignature<Org.Apache.Kafka.Connect.Util.TopicAdmin.NewTopicBuilder>("partitions", "(I)Lorg/apache/kafka/connect/util/TopicAdmin$NewTopicBuilder;", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.0/org/apache/kafka/connect/util/TopicAdmin.NewTopicBuilder.html#replicationFactor-short-"/>
            /// </summary>
            /// <param name="arg0"><see cref="short"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Connect.Util.TopicAdmin.NewTopicBuilder"/></returns>
            public Org.Apache.Kafka.Connect.Util.TopicAdmin.NewTopicBuilder ReplicationFactor(short arg0)
            {
                return IExecuteWithSignature<Org.Apache.Kafka.Connect.Util.TopicAdmin.NewTopicBuilder>("replicationFactor", "(S)Lorg/apache/kafka/connect/util/TopicAdmin$NewTopicBuilder;", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.0/org/apache/kafka/connect/util/TopicAdmin.NewTopicBuilder.html#uncleanLeaderElection-boolean-"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Connect.Util.TopicAdmin.NewTopicBuilder"/></returns>
            public Org.Apache.Kafka.Connect.Util.TopicAdmin.NewTopicBuilder UncleanLeaderElection(bool arg0)
            {
                return IExecuteWithSignature<Org.Apache.Kafka.Connect.Util.TopicAdmin.NewTopicBuilder>("uncleanLeaderElection", "(Z)Lorg/apache/kafka/connect/util/TopicAdmin$NewTopicBuilder;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region TopicCreationResponse
        public partial class TopicCreationResponse
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.0/org/apache/kafka/connect/util/TopicAdmin.TopicCreationResponse.html#org.apache.kafka.connect.util.TopicAdmin$TopicCreationResponse(java.util.Set,java.util.Set)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Set"/></param>
            /// <param name="arg1"><see cref="Java.Util.Set"/></param>
            public TopicCreationResponse(Java.Util.Set<Java.Lang.String> arg0, Java.Util.Set<Java.Lang.String> arg1)
                : base(arg0, arg1)
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.0/org/apache/kafka/connect/util/TopicAdmin.TopicCreationResponse.html#isCreated-java.lang.String-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool IsCreated(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<bool>("isCreated", "(Ljava/lang/String;)Z", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.0/org/apache/kafka/connect/util/TopicAdmin.TopicCreationResponse.html#isCreatedOrExisting-java.lang.String-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool IsCreatedOrExisting(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<bool>("isCreatedOrExisting", "(Ljava/lang/String;)Z", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.0/org/apache/kafka/connect/util/TopicAdmin.TopicCreationResponse.html#isEmpty--"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsEmpty()
            {
                return IExecuteWithSignature<bool>("isEmpty", "()Z");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.0/org/apache/kafka/connect/util/TopicAdmin.TopicCreationResponse.html#isExisting-java.lang.String-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool IsExisting(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<bool>("isExisting", "(Ljava/lang/String;)Z", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.0/org/apache/kafka/connect/util/TopicAdmin.TopicCreationResponse.html#createdOrExistingTopicsCount--"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int CreatedOrExistingTopicsCount()
            {
                return IExecuteWithSignature<int>("createdOrExistingTopicsCount", "()I");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.0/org/apache/kafka/connect/util/TopicAdmin.TopicCreationResponse.html#createdTopicsCount--"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int CreatedTopicsCount()
            {
                return IExecuteWithSignature<int>("createdTopicsCount", "()I");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.0/org/apache/kafka/connect/util/TopicAdmin.TopicCreationResponse.html#existingTopicsCount--"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int ExistingTopicsCount()
            {
                return IExecuteWithSignature<int>("existingTopicsCount", "()I");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.0/org/apache/kafka/connect/util/TopicAdmin.TopicCreationResponse.html#createdTopics--"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Set"/></returns>
            public Java.Util.Set<Java.Lang.String> CreatedTopics()
            {
                return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("createdTopics", "()Ljava/util/Set;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.0/org/apache/kafka/connect/util/TopicAdmin.TopicCreationResponse.html#existingTopics--"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Set"/></returns>
            public Java.Util.Set<Java.Lang.String> ExistingTopics()
            {
                return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("existingTopics", "()Ljava/util/Set;");
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