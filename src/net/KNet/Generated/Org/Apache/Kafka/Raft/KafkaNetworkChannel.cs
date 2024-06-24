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
*  This file is generated by MASES.JNetReflector (ver. 2.5.4.0)
*  using kafka-raft-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Raft
{
    #region KafkaNetworkChannel
    public partial class KafkaNetworkChannel
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/KafkaNetworkChannel.html#newCorrelationId--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int NewCorrelationId()
        {
            return IExecuteWithSignature<int>("newCorrelationId", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/KafkaNetworkChannel.html#close--"/>
        /// </summary>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/KafkaNetworkChannel.html#pollOnce--"/>
        /// </summary>
        public void PollOnce()
        {
            IExecuteWithSignature("pollOnce", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/KafkaNetworkChannel.html#send-org.apache.kafka.raft.RaftRequest.Outbound-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Raft.RaftRequest.Outbound"/></param>
        public void Send(Org.Apache.Kafka.Raft.RaftRequest.Outbound arg0)
        {
            IExecuteWithSignature("send", "(Lorg/apache/kafka/raft/RaftRequest$Outbound;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/KafkaNetworkChannel.html#start--"/>
        /// </summary>
        public void Start()
        {
            IExecuteWithSignature("start", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/KafkaNetworkChannel.html#updateEndpoint-int-org.apache.kafka.raft.RaftConfig.InetAddressSpec-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Raft.RaftConfig.InetAddressSpec"/></param>
        public void UpdateEndpoint(int arg0, Org.Apache.Kafka.Raft.RaftConfig.InetAddressSpec arg1)
        {
            IExecute("updateEndpoint", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}