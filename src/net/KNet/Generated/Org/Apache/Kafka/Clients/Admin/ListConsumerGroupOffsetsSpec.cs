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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using kafka-clients-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Admin
{
    #region ListConsumerGroupOffsetsSpec
    public partial class ListConsumerGroupOffsetsSpec
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/ListConsumerGroupOffsetsSpec.html#topicPartitions--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        public Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartition> TopicPartitions()
        {
            return IExecuteWithSignature<Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartition>>("topicPartitions", "()Ljava/util/Collection;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/ListConsumerGroupOffsetsSpec.html#topicPartitions-java.util.Collection-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.ListConsumerGroupOffsetsSpec"/></returns>
        public Org.Apache.Kafka.Clients.Admin.ListConsumerGroupOffsetsSpec TopicPartitions(Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartition> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Clients.Admin.ListConsumerGroupOffsetsSpec>("topicPartitions", "(Ljava/util/Collection;)Lorg/apache/kafka/clients/admin/ListConsumerGroupOffsetsSpec;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}