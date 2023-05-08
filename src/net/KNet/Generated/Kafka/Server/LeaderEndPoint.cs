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
*  using kafka_2.13-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Kafka.Server
{
    #region LeaderEndPoint
    public partial class LeaderEndPoint
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
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/LeaderEndPoint.html#brokerEndPoint()"/> 
        /// </summary>
        public Kafka.Cluster.BrokerEndPoint BrokerEndPoint
        {
            get { return IExecute<Kafka.Cluster.BrokerEndPoint>("brokerEndPoint"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/LeaderEndPoint.html#isTruncationOnFetchSupported()"/> 
        /// </summary>
        public bool IsTruncationOnFetchSupported
        {
            get { return IExecute<bool>("isTruncationOnFetchSupported"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/LeaderEndPoint.html#fetchEarliestOffset(org.apache.kafka.common.TopicPartition,int)"/>
        /// </summary>
        /// <param name="topicPartition"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <param name="currentLeaderEpoch"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public long FetchEarliestOffset(Org.Apache.Kafka.Common.TopicPartition topicPartition, int currentLeaderEpoch)
        {
            return IExecute<long>("fetchEarliestOffset", topicPartition, currentLeaderEpoch);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/LeaderEndPoint.html#fetchLatestOffset(org.apache.kafka.common.TopicPartition,int)"/>
        /// </summary>
        /// <param name="topicPartition"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <param name="currentLeaderEpoch"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public long FetchLatestOffset(Org.Apache.Kafka.Common.TopicPartition topicPartition, int currentLeaderEpoch)
        {
            return IExecute<long>("fetchLatestOffset", topicPartition, currentLeaderEpoch);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/LeaderEndPoint.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/LeaderEndPoint.html#initiateClose()"/>
        /// </summary>
        public void InitiateClose()
        {
            IExecute("initiateClose");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}