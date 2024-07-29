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

namespace Org.Apache.Kafka.Clients.Admin
{
    #region CreateTopicsResult
    public partial class CreateTopicsResult
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/CreateTopicsResult.html#values--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, Org.Apache.Kafka.Common.KafkaFuture<Java.Lang.Void>> Values()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Org.Apache.Kafka.Common.KafkaFuture<Java.Lang.Void>>>("values", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/CreateTopicsResult.html#numPartitions-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.KafkaFuture"/></returns>
        public Org.Apache.Kafka.Common.KafkaFuture<Java.Lang.Integer> NumPartitions(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.KafkaFuture<Java.Lang.Integer>>("numPartitions", "(Ljava/lang/String;)Lorg/apache/kafka/common/KafkaFuture;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/CreateTopicsResult.html#replicationFactor-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.KafkaFuture"/></returns>
        public Org.Apache.Kafka.Common.KafkaFuture<Java.Lang.Integer> ReplicationFactor(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.KafkaFuture<Java.Lang.Integer>>("replicationFactor", "(Ljava/lang/String;)Lorg/apache/kafka/common/KafkaFuture;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/CreateTopicsResult.html#all--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.KafkaFuture"/></returns>
        public Org.Apache.Kafka.Common.KafkaFuture<Java.Lang.Void> All()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.KafkaFuture<Java.Lang.Void>>("all", "()Lorg/apache/kafka/common/KafkaFuture;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/CreateTopicsResult.html#config-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.KafkaFuture"/></returns>
        public Org.Apache.Kafka.Common.KafkaFuture<Org.Apache.Kafka.Clients.Admin.Config> Config(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.KafkaFuture<Org.Apache.Kafka.Clients.Admin.Config>>("config", "(Ljava/lang/String;)Lorg/apache/kafka/common/KafkaFuture;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/CreateTopicsResult.html#topicId-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.KafkaFuture"/></returns>
        public Org.Apache.Kafka.Common.KafkaFuture<Org.Apache.Kafka.Common.Uuid> TopicId(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.KafkaFuture<Org.Apache.Kafka.Common.Uuid>>("topicId", "(Ljava/lang/String;)Lorg/apache/kafka/common/KafkaFuture;", arg0);
        }

        #endregion

        #region Nested classes
        #region TopicMetadataAndConfig
        public partial class TopicMetadataAndConfig
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/CreateTopicsResult.TopicMetadataAndConfig.html#org.apache.kafka.clients.admin.CreateTopicsResult$TopicMetadataAndConfig(org.apache.kafka.common.errors.ApiException)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Errors.ApiException"/></param>
            public TopicMetadataAndConfig(Org.Apache.Kafka.Common.Errors.ApiException arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/CreateTopicsResult.TopicMetadataAndConfig.html#org.apache.kafka.clients.admin.CreateTopicsResult$TopicMetadataAndConfig(org.apache.kafka.common.Uuid,int,int,org.apache.kafka.clients.admin.Config)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Uuid"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="Org.Apache.Kafka.Clients.Admin.Config"/></param>
            public TopicMetadataAndConfig(Org.Apache.Kafka.Common.Uuid arg0, int arg1, int arg2, Org.Apache.Kafka.Clients.Admin.Config arg3)
                : base(arg0, arg1, arg2, arg3)
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/CreateTopicsResult.TopicMetadataAndConfig.html#numPartitions--"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int NumPartitions()
            {
                return IExecuteWithSignature<int>("numPartitions", "()I");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/CreateTopicsResult.TopicMetadataAndConfig.html#replicationFactor--"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int ReplicationFactor()
            {
                return IExecuteWithSignature<int>("replicationFactor", "()I");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/CreateTopicsResult.TopicMetadataAndConfig.html#config--"/>
            /// </summary>
            /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.Config"/></returns>
            public Org.Apache.Kafka.Clients.Admin.Config Config()
            {
                return IExecuteWithSignature<Org.Apache.Kafka.Clients.Admin.Config>("config", "()Lorg/apache/kafka/clients/admin/Config;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/CreateTopicsResult.TopicMetadataAndConfig.html#topicId--"/>
            /// </summary>
            /// <returns><see cref="Org.Apache.Kafka.Common.Uuid"/></returns>
            public Org.Apache.Kafka.Common.Uuid TopicId()
            {
                return IExecuteWithSignature<Org.Apache.Kafka.Common.Uuid>("topicId", "()Lorg/apache/kafka/common/Uuid;");
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