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

namespace Kafka.Cluster
{
    #region Broker
    public partial class Broker
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/cluster/Broker.html#%3Cinit%3E(int,java.lang.String,int,org.apache.kafka.common.network.ListenerName,org.apache.kafka.common.security.auth.SecurityProtocol)"/>
        /// </summary>
        /// <param name="id"><see cref="int"/></param>
        /// <param name="host"><see cref="string"/></param>
        /// <param name="port"><see cref="int"/></param>
        /// <param name="listenerName"><see cref="Org.Apache.Kafka.Common.Network.ListenerName"/></param>
        /// <param name="protocol"><see cref="Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol"/></param>
        public Broker(int id, string host, int port, Org.Apache.Kafka.Common.Network.ListenerName listenerName, Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol protocol)
            : base(id, host, port, listenerName, protocol)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/cluster/Broker.html#%3Cinit%3E(kafka.cluster.BrokerEndPoint,org.apache.kafka.common.network.ListenerName,org.apache.kafka.common.security.auth.SecurityProtocol)"/>
        /// </summary>
        /// <param name="bep"><see cref="Kafka.Cluster.BrokerEndPoint"/></param>
        /// <param name="listenerName"><see cref="Org.Apache.Kafka.Common.Network.ListenerName"/></param>
        /// <param name="protocol"><see cref="Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol"/></param>
        public Broker(Kafka.Cluster.BrokerEndPoint bep, Org.Apache.Kafka.Common.Network.ListenerName listenerName, Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol protocol)
            : base(bep, listenerName, protocol)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Kafka.Cluster.Broker"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Kafka.Cluster.Broker t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/cluster/Broker.html#fromBrokerRegistration(org.apache.kafka.metadata.BrokerRegistration)"/>
        /// </summary>
        /// <param name="registration"><see cref="Org.Apache.Kafka.Metadata.BrokerRegistration"/></param>
        /// <returns><see cref="Kafka.Cluster.Broker"/></returns>
        public static Kafka.Cluster.Broker FromBrokerRegistration(Org.Apache.Kafka.Metadata.BrokerRegistration registration)
        {
            return SExecute<Kafka.Cluster.Broker>(LocalBridgeClazz, "fromBrokerRegistration", registration);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/cluster/Broker.html#features()"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.Feature.Features<Org.Apache.Kafka.Common.Feature.SupportedVersionRange> Features
        {
            get { return IExecute<Org.Apache.Kafka.Common.Feature.Features<Org.Apache.Kafka.Common.Feature.SupportedVersionRange>>("features"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/cluster/Broker.html#id()"/> 
        /// </summary>
        public int Id
        {
            get { return IExecute<int>("id"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/cluster/Broker.html#productArity()"/> 
        /// </summary>
        public int ProductArity
        {
            get { return IExecute<int>("productArity"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/cluster/Broker.html#productPrefix()"/> 
        /// </summary>
        public string ProductPrefix
        {
            get { return IExecute<string>("productPrefix"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/cluster/Broker.html#canEqual(java.lang.Object)"/>
        /// </summary>
        /// <param name="x$1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CanEqual(object x_1)
        {
            return IExecute<bool>("canEqual", x_1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/cluster/Broker.html#productElement(int)"/>
        /// </summary>
        /// <param name="x$1"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object ProductElement(int x_1)
        {
            return IExecute("productElement", x_1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/cluster/Broker.html#productElementName(int)"/>
        /// </summary>
        /// <param name="x$1"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string ProductElementName(int x_1)
        {
            return IExecute<string>("productElementName", x_1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/cluster/Broker.html#brokerEndPoint(org.apache.kafka.common.network.ListenerName)"/>
        /// </summary>
        /// <param name="listenerName"><see cref="Org.Apache.Kafka.Common.Network.ListenerName"/></param>
        /// <returns><see cref="Kafka.Cluster.BrokerEndPoint"/></returns>
        public Kafka.Cluster.BrokerEndPoint BrokerEndPoint(Org.Apache.Kafka.Common.Network.ListenerName listenerName)
        {
            return IExecute<Kafka.Cluster.BrokerEndPoint>("brokerEndPoint", listenerName);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/cluster/Broker.html#endPoint(org.apache.kafka.common.network.ListenerName)"/>
        /// </summary>
        /// <param name="listenerName"><see cref="Org.Apache.Kafka.Common.Network.ListenerName"/></param>
        /// <returns><see cref="Kafka.Cluster.EndPoint"/></returns>
        public Kafka.Cluster.EndPoint EndPoint(Org.Apache.Kafka.Common.Network.ListenerName listenerName)
        {
            return IExecute<Kafka.Cluster.EndPoint>("endPoint", listenerName);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/cluster/Broker.html#node(org.apache.kafka.common.network.ListenerName)"/>
        /// </summary>
        /// <param name="listenerName"><see cref="Org.Apache.Kafka.Common.Network.ListenerName"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Node"/></returns>
        public Org.Apache.Kafka.Common.Node Node(Org.Apache.Kafka.Common.Network.ListenerName listenerName)
        {
            return IExecute<Org.Apache.Kafka.Common.Node>("node", listenerName);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/cluster/Broker.html#toServerInfo(java.lang.String,kafka.server.KafkaConfig)"/>
        /// </summary>
        /// <param name="clusterId"><see cref="string"/></param>
        /// <param name="config"><see cref="Kafka.Server.KafkaConfig"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Server.Authorizer.AuthorizerServerInfo"/></returns>
        public Org.Apache.Kafka.Server.Authorizer.AuthorizerServerInfo ToServerInfo(string clusterId, Kafka.Server.KafkaConfig config)
        {
            return IExecute<Org.Apache.Kafka.Server.Authorizer.AuthorizerServerInfo>("toServerInfo", clusterId, config);
        }

        #endregion

        #region Nested classes
        #region ServerInfo
        public partial class ServerInfo
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/cluster/Broker.ServerInfo.html#%3Cinit%3E(org.apache.kafka.common.ClusterResource,int,java.util.List,org.apache.kafka.common.Endpoint,java.util.Set)"/>
            /// </summary>
            /// <param name="clusterResource"><see cref="Org.Apache.Kafka.Common.ClusterResource"/></param>
            /// <param name="brokerId"><see cref="int"/></param>
            /// <param name="endpoints"><see cref="Java.Util.List"/></param>
            /// <param name="interBrokerEndpoint"><see cref="Org.Apache.Kafka.Common.Endpoint"/></param>
            /// <param name="earlyStartListeners"><see cref="Java.Util.Set"/></param>
            public ServerInfo(Org.Apache.Kafka.Common.ClusterResource clusterResource, int brokerId, Java.Util.List endpoints, Org.Apache.Kafka.Common.Endpoint interBrokerEndpoint, Java.Util.Set earlyStartListeners)
                : base(clusterResource, brokerId, endpoints, interBrokerEndpoint, earlyStartListeners)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Kafka.Cluster.Broker.ServerInfo"/> to <see cref="Org.Apache.Kafka.Server.Authorizer.AuthorizerServerInfo"/>
            /// </summary>
            public static implicit operator Org.Apache.Kafka.Server.Authorizer.AuthorizerServerInfo(Kafka.Cluster.Broker.ServerInfo t) => t.Cast<Org.Apache.Kafka.Server.Authorizer.AuthorizerServerInfo>();
            /// <summary>
            /// Converter from <see cref="Kafka.Cluster.Broker.ServerInfo"/> to <see cref="Java.Io.Serializable"/>
            /// </summary>
            public static implicit operator Java.Io.Serializable(Kafka.Cluster.Broker.ServerInfo t) => t.Cast<Java.Io.Serializable>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/cluster/Broker.ServerInfo.html#brokerId()"/> 
            /// </summary>
            public int BrokerId
            {
                get { return IExecute<int>("brokerId"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/cluster/Broker.ServerInfo.html#clusterResource()"/> 
            /// </summary>
            public Org.Apache.Kafka.Common.ClusterResource ClusterResource
            {
                get { return IExecute<Org.Apache.Kafka.Common.ClusterResource>("clusterResource"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/cluster/Broker.ServerInfo.html#earlyStartListeners()"/> 
            /// </summary>
            public Java.Util.Collection EarlyStartListeners
            {
                get { return IExecute<Java.Util.Collection>("earlyStartListeners"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/cluster/Broker.ServerInfo.html#endpoints()"/> 
            /// </summary>
            public Java.Util.Collection Endpoints
            {
                get { return IExecute<Java.Util.Collection>("endpoints"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/cluster/Broker.ServerInfo.html#interBrokerEndpoint()"/> 
            /// </summary>
            public Org.Apache.Kafka.Common.Endpoint InterBrokerEndpoint
            {
                get { return IExecute<Org.Apache.Kafka.Common.Endpoint>("interBrokerEndpoint"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/cluster/Broker.ServerInfo.html#productArity()"/> 
            /// </summary>
            public int ProductArity
            {
                get { return IExecute<int>("productArity"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/cluster/Broker.ServerInfo.html#productPrefix()"/> 
            /// </summary>
            public string ProductPrefix
            {
                get { return IExecute<string>("productPrefix"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/cluster/Broker.ServerInfo.html#canEqual(java.lang.Object)"/>
            /// </summary>
            /// <param name="x$1"><see cref="object"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool CanEqual(object x_1)
            {
                return IExecute<bool>("canEqual", x_1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/cluster/Broker.ServerInfo.html#productElement(int)"/>
            /// </summary>
            /// <param name="x$1"><see cref="int"/></param>
            /// <returns><see cref="object"/></returns>
            public object ProductElement(int x_1)
            {
                return IExecute("productElement", x_1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/cluster/Broker.ServerInfo.html#productElementName(int)"/>
            /// </summary>
            /// <param name="x$1"><see cref="int"/></param>
            /// <returns><see cref="string"/></returns>
            public string ProductElementName(int x_1)
            {
                return IExecute<string>("productElementName", x_1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/cluster/Broker.ServerInfo.html#copy(org.apache.kafka.common.ClusterResource,int,java.util.List,org.apache.kafka.common.Endpoint,java.util.Set)"/>
            /// </summary>
            /// <param name="clusterResource"><see cref="Org.Apache.Kafka.Common.ClusterResource"/></param>
            /// <param name="brokerId"><see cref="int"/></param>
            /// <param name="endpoints"><see cref="Java.Util.List"/></param>
            /// <param name="interBrokerEndpoint"><see cref="Org.Apache.Kafka.Common.Endpoint"/></param>
            /// <param name="earlyStartListeners"><see cref="Java.Util.Set"/></param>
            /// <returns><see cref="Kafka.Cluster.Broker.ServerInfo"/></returns>
            public Kafka.Cluster.Broker.ServerInfo Copy(Org.Apache.Kafka.Common.ClusterResource clusterResource, int brokerId, Java.Util.List<Org.Apache.Kafka.Common.Endpoint> endpoints, Org.Apache.Kafka.Common.Endpoint interBrokerEndpoint, Java.Util.Set<string> earlyStartListeners)
            {
                return IExecute<Kafka.Cluster.Broker.ServerInfo>("copy", clusterResource, brokerId, endpoints, interBrokerEndpoint, earlyStartListeners);
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