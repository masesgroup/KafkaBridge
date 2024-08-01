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
*  using connect-api-3.8.0.jar as reference
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.0/org/apache/kafka/connect/health/ConnectClusterState.html#connectors--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        public Java.Util.Collection<Java.Lang.String> Connectors()
        {
            return IExecuteWithSignature<Java.Util.Collection<Java.Lang.String>>("connectors", "()Ljava/util/Collection;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.0/org/apache/kafka/connect/health/ConnectClusterState.html#connectorHealth-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Health.ConnectorHealth"/></returns>
        public Org.Apache.Kafka.Connect.Health.ConnectorHealth ConnectorHealth(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Health.ConnectorHealth>("connectorHealth", "(Ljava/lang/String;)Lorg/apache/kafka/connect/health/ConnectorHealth;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.0/org/apache/kafka/connect/health/ConnectClusterState.html#connectorConfig-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, Java.Lang.String> ConnectorConfig(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Lang.String>>("connectorConfig", "(Ljava/lang/String;)Ljava/util/Map;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.0/org/apache/kafka/connect/health/ConnectClusterState.html#clusterDetails--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Health.ConnectClusterDetails"/></returns>
        public Org.Apache.Kafka.Connect.Health.ConnectClusterDetails ClusterDetails()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Health.ConnectClusterDetails>("clusterDetails", "()Lorg/apache/kafka/connect/health/ConnectClusterDetails;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}