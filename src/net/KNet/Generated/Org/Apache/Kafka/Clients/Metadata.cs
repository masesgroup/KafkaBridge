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

namespace Org.Apache.Kafka.Clients
{
    #region Metadata
    public partial class Metadata
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/Metadata.html#lastSeenLeaderEpoch-org.apache.kafka.common.TopicPartition-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Java.Lang.Integer> LastSeenLeaderEpoch(Org.Apache.Kafka.Common.TopicPartition arg0)
        {
            return IExecute<Java.Util.Optional<Java.Lang.Integer>>("lastSeenLeaderEpoch", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/Metadata.html#metadataExpireMs--"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long MetadataExpireMs()
        {
            return IExecute<long>("metadataExpireMs");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/Metadata.html#isClosed--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsClosed()
        {
            return IExecute<bool>("isClosed");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/Metadata.html#updateLastSeenEpochIfNewer-org.apache.kafka.common.TopicPartition-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool UpdateLastSeenEpochIfNewer(Org.Apache.Kafka.Common.TopicPartition arg0, int arg1)
        {
            return IExecute<bool>("updateLastSeenEpochIfNewer", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/Metadata.html#updateRequested--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool UpdateRequested()
        {
            return IExecute<bool>("updateRequested");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/Metadata.html#requestUpdate--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int RequestUpdate()
        {
            return IExecute<int>("requestUpdate");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/Metadata.html#requestUpdateForNewTopics--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int RequestUpdateForNewTopics()
        {
            return IExecute<int>("requestUpdateForNewTopics");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/Metadata.html#updateVersion--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int UpdateVersion()
        {
            return IExecute<int>("updateVersion");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/Metadata.html#topicIds--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<string, Org.Apache.Kafka.Common.Uuid> TopicIds()
        {
            return IExecute<Java.Util.Map<string, Org.Apache.Kafka.Common.Uuid>>("topicIds");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/Metadata.html#lastSuccessfulUpdate--"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long LastSuccessfulUpdate()
        {
            return IExecute<long>("lastSuccessfulUpdate");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/Metadata.html#timeToAllowUpdate-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long TimeToAllowUpdate(long arg0)
        {
            return IExecute<long>("timeToAllowUpdate", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/Metadata.html#timeToNextUpdate-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long TimeToNextUpdate(long arg0)
        {
            return IExecute<long>("timeToNextUpdate", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/Metadata.html#currentLeader-org.apache.kafka.common.TopicPartition-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Metadata.LeaderAndEpoch"/></returns>
        public Org.Apache.Kafka.Clients.Metadata.LeaderAndEpoch CurrentLeader(Org.Apache.Kafka.Common.TopicPartition arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Metadata.LeaderAndEpoch>("currentLeader", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/Metadata.html#newMetadataRequestAndVersion-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Metadata.MetadataRequestAndVersion"/></returns>
        public Org.Apache.Kafka.Clients.Metadata.MetadataRequestAndVersion NewMetadataRequestAndVersion(long arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Metadata.MetadataRequestAndVersion>("newMetadataRequestAndVersion", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/Metadata.html#fetch--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Cluster"/></returns>
        public Org.Apache.Kafka.Common.Cluster Fetch()
        {
            return IExecute<Org.Apache.Kafka.Common.Cluster>("fetch");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/Metadata.html#bootstrap-java.util.List-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        public void Bootstrap(Java.Util.List<Java.Net.InetSocketAddress> arg0)
        {
            IExecute("bootstrap", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/Metadata.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/Metadata.html#failedUpdate-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void FailedUpdate(long arg0)
        {
            IExecute("failedUpdate", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/Metadata.html#fatalError-org.apache.kafka.common.KafkaException-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.KafkaException"/></param>
        public void FatalError(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0)
        {
            IExecute("fatalError", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/Metadata.html#maybeThrowAnyException--"/>
        /// </summary>
        public void MaybeThrowAnyException()
        {
            IExecute("maybeThrowAnyException");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/Metadata.html#maybeThrowExceptionForTopic-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public void MaybeThrowExceptionForTopic(string arg0)
        {
            IExecute("maybeThrowExceptionForTopic", arg0);
        }

        #endregion

        #region Nested classes
        #region LeaderAndEpoch
        public partial class LeaderAndEpoch
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/Metadata.LeaderAndEpoch.html#org.apache.kafka.clients.Metadata$LeaderAndEpoch(java.util.Optional,java.util.Optional)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Optional"/></param>
            /// <param name="arg1"><see cref="Java.Util.Optional"/></param>
            public LeaderAndEpoch(Java.Util.Optional<Org.Apache.Kafka.Common.Node> arg0, Java.Util.Optional<Java.Lang.Integer> arg1)
                : base(arg0, arg1)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/Metadata.LeaderAndEpoch.html#epoch"/>
            /// </summary>
            public Java.Util.Optional epoch { get { return IGetField<Java.Util.Optional>("epoch"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/Metadata.LeaderAndEpoch.html#leader"/>
            /// </summary>
            public Java.Util.Optional leader { get { return IGetField<Java.Util.Optional>("leader"); } }

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/Metadata.LeaderAndEpoch.html#noLeaderOrEpoch--"/>
            /// </summary>

            /// <returns><see cref="Org.Apache.Kafka.Clients.Metadata.LeaderAndEpoch"/></returns>
            public static Org.Apache.Kafka.Clients.Metadata.LeaderAndEpoch NoLeaderOrEpoch()
            {
                return SExecute<Org.Apache.Kafka.Clients.Metadata.LeaderAndEpoch>(LocalBridgeClazz, "noLeaderOrEpoch");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region MetadataRequestAndVersion
        public partial class MetadataRequestAndVersion
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/Metadata.MetadataRequestAndVersion.html#isPartialUpdate"/>
            /// </summary>
            public bool isPartialUpdate { get { return IGetField<bool>("isPartialUpdate"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/Metadata.MetadataRequestAndVersion.html#requestVersion"/>
            /// </summary>
            public int requestVersion { get { return IGetField<int>("requestVersion"); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

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