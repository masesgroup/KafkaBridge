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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using connect-api-3.5.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Health
{
    #region IConnectClusterState
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IConnectClusterState
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ConnectClusterState
    public partial class ConnectClusterState : Org.Apache.Kafka.Connect.Health.IConnectClusterState
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.5.0/org/apache/kafka/connect/health/ConnectClusterState.html#connectors--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Collection"/></returns>
        public Java.Util.Collection<string> Connectors()
        {
            return IExecute<Java.Util.Collection<string>>("connectors");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.5.0/org/apache/kafka/connect/health/ConnectClusterState.html#connectorHealth-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Health.ConnectorHealth"/></returns>
        public Org.Apache.Kafka.Connect.Health.ConnectorHealth ConnectorHealth(string arg0)
        {
            return IExecute<Org.Apache.Kafka.Connect.Health.ConnectorHealth>("connectorHealth", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.5.0/org/apache/kafka/connect/health/ConnectClusterState.html#connectorConfig-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<string, string> ConnectorConfig(string arg0)
        {
            return IExecute<Java.Util.Map<string, string>>("connectorConfig", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.5.0/org/apache/kafka/connect/health/ConnectClusterState.html#clusterDetails--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Connect.Health.ConnectClusterDetails"/></returns>
        public Org.Apache.Kafka.Connect.Health.ConnectClusterDetails ClusterDetails()
        {
            return IExecute<Org.Apache.Kafka.Connect.Health.ConnectClusterDetails>("clusterDetails");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}