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

namespace Org.Apache.Kafka.Common.Requests
{
    #region DescribeQuorumResponse
    public partial class DescribeQuorumResponse
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/DescribeQuorumResponse.html#%3Cinit%3E(org.apache.kafka.common.message.DescribeQuorumResponseData)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Message.DescribeQuorumResponseData"/></param>
        public DescribeQuorumResponse(Org.Apache.Kafka.Common.Message.DescribeQuorumResponseData arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/DescribeQuorumResponse.html#singletonErrorResponse(org.apache.kafka.common.TopicPartition,org.apache.kafka.common.protocol.Errors)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Protocol.Errors"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Message.DescribeQuorumResponseData"/></returns>
        public static Org.Apache.Kafka.Common.Message.DescribeQuorumResponseData SingletonErrorResponse(Org.Apache.Kafka.Common.TopicPartition arg0, Org.Apache.Kafka.Common.Protocol.Errors arg1)
        {
            return SExecute<Org.Apache.Kafka.Common.Message.DescribeQuorumResponseData>(LocalBridgeClazz, "singletonErrorResponse", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/DescribeQuorumResponse.html#singletonResponse(org.apache.kafka.common.TopicPartition,org.apache.kafka.common.message.DescribeQuorumResponseData.PartitionData)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Message.DescribeQuorumResponseData.PartitionData"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Message.DescribeQuorumResponseData"/></returns>
        public static Org.Apache.Kafka.Common.Message.DescribeQuorumResponseData SingletonResponse(Org.Apache.Kafka.Common.TopicPartition arg0, Org.Apache.Kafka.Common.Message.DescribeQuorumResponseData.PartitionData arg1)
        {
            return SExecute<Org.Apache.Kafka.Common.Message.DescribeQuorumResponseData>(LocalBridgeClazz, "singletonResponse", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/DescribeQuorumResponse.html#parse(java.nio.ByteBuffer,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Requests.DescribeQuorumResponse"/></returns>
        public static Org.Apache.Kafka.Common.Requests.DescribeQuorumResponse Parse(Java.Nio.ByteBuffer arg0, short arg1)
        {
            return SExecute<Org.Apache.Kafka.Common.Requests.DescribeQuorumResponse>(LocalBridgeClazz, "parse", arg0, arg1);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}