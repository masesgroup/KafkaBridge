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

namespace Kafka.Tools
{
    #region ReplicaFetcherBlockingSend
    public partial class ReplicaFetcherBlockingSend
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/tools/ReplicaFetcherBlockingSend.html#%3Cinit%3E(org.apache.kafka.common.Node,org.apache.kafka.clients.consumer.ConsumerConfig,org.apache.kafka.common.metrics.Metrics,org.apache.kafka.common.utils.Time,int,java.lang.String)"/>
        /// </summary>
        /// <param name="sourceNode"><see cref="Org.Apache.Kafka.Common.Node"/></param>
        /// <param name="consumerConfig"><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerConfig"/></param>
        /// <param name="metrics"><see cref="Org.Apache.Kafka.Common.Metrics.Metrics"/></param>
        /// <param name="time"><see cref="Org.Apache.Kafka.Common.Utils.Time"/></param>
        /// <param name="fetcherId"><see cref="int"/></param>
        /// <param name="clientId"><see cref="string"/></param>
        public ReplicaFetcherBlockingSend(Org.Apache.Kafka.Common.Node sourceNode, Org.Apache.Kafka.Clients.Consumer.ConsumerConfig consumerConfig, Org.Apache.Kafka.Common.Metrics.Metrics metrics, Org.Apache.Kafka.Common.Utils.Time time, int fetcherId, string clientId)
            : base(sourceNode, consumerConfig, metrics, time, fetcherId, clientId)
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
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/tools/ReplicaFetcherBlockingSend.html#sendRequest(org.apache.kafka.common.requests.AbstractRequest.Builder)"/>
        /// </summary>
        /// <param name="requestBuilder"><see cref="Org.Apache.Kafka.Common.Requests.AbstractRequest.Builder"/></param>
        /// <typeparam name="RequestBuilderExtendsOrg_Apache_Kafka_Common_Requests_AbstractRequest"><see cref="Org.Apache.Kafka.Common.Requests.AbstractRequest"/></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Clients.ClientResponse"/></returns>
        public Org.Apache.Kafka.Clients.ClientResponse SendRequest<RequestBuilderExtendsOrg_Apache_Kafka_Common_Requests_AbstractRequest>(Org.Apache.Kafka.Common.Requests.AbstractRequest.Builder<RequestBuilderExtendsOrg_Apache_Kafka_Common_Requests_AbstractRequest> requestBuilder) where RequestBuilderExtendsOrg_Apache_Kafka_Common_Requests_AbstractRequest: Org.Apache.Kafka.Common.Requests.AbstractRequest
        {
            return IExecute<Org.Apache.Kafka.Clients.ClientResponse>("sendRequest", requestBuilder);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/tools/ReplicaFetcherBlockingSend.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}