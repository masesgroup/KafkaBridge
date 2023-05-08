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

namespace Kafka.Network
{
    #region ControlPlaneAcceptor
    public partial class ControlPlaneAcceptor
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/ControlPlaneAcceptor.html#%3Cinit%3E(kafka.network.SocketServer,kafka.cluster.EndPoint,kafka.server.KafkaConfig,int,kafka.network.ConnectionQuotas,org.apache.kafka.common.utils.Time,kafka.network.RequestChannel,org.apache.kafka.common.metrics.Metrics,kafka.security.CredentialProvider,org.apache.kafka.common.utils.LogContext,org.apache.kafka.common.memory.MemoryPool,kafka.server.ApiVersionManager)"/>
        /// </summary>
        /// <param name="socketServer"><see cref="Kafka.Network.SocketServer"/></param>
        /// <param name="endPoint"><see cref="Kafka.Cluster.EndPoint"/></param>
        /// <param name="config"><see cref="Kafka.Server.KafkaConfig"/></param>
        /// <param name="nodeId"><see cref="int"/></param>
        /// <param name="connectionQuotas"><see cref="Kafka.Network.ConnectionQuotas"/></param>
        /// <param name="time"><see cref="Org.Apache.Kafka.Common.Utils.Time"/></param>
        /// <param name="requestChannel"><see cref="Kafka.Network.RequestChannel"/></param>
        /// <param name="metrics"><see cref="Org.Apache.Kafka.Common.Metrics.Metrics"/></param>
        /// <param name="credentialProvider"><see cref="Kafka.Security.CredentialProvider"/></param>
        /// <param name="logContext"><see cref="Org.Apache.Kafka.Common.Utils.LogContext"/></param>
        /// <param name="memoryPool"><see cref="Org.Apache.Kafka.Common.Memory.MemoryPool"/></param>
        /// <param name="apiVersionManager"><see cref="Kafka.Server.ApiVersionManager"/></param>
        public ControlPlaneAcceptor(Kafka.Network.SocketServer socketServer, Kafka.Cluster.EndPoint endPoint, Kafka.Server.KafkaConfig config, int nodeId, Kafka.Network.ConnectionQuotas connectionQuotas, Org.Apache.Kafka.Common.Utils.Time time, Kafka.Network.RequestChannel requestChannel, Org.Apache.Kafka.Common.Metrics.Metrics metrics, Kafka.Security.CredentialProvider credentialProvider, Org.Apache.Kafka.Common.Utils.LogContext logContext, Org.Apache.Kafka.Common.Memory.MemoryPool memoryPool, Kafka.Server.ApiVersionManager apiVersionManager)
            : base(socketServer, endPoint, config, nodeId, connectionQuotas, time, requestChannel, metrics, credentialProvider, logContext, memoryPool, apiVersionManager)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/ControlPlaneAcceptor.html#MetricPrefix()"/> 
        /// </summary>
        public static string MetricPrefix
        {
            get { return SExecute<string>(LocalBridgeClazz, "MetricPrefix"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/ControlPlaneAcceptor.html#ThreadPrefix()"/> 
        /// </summary>
        public static string ThreadPrefix
        {
            get { return SExecute<string>(LocalBridgeClazz, "ThreadPrefix"); }
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