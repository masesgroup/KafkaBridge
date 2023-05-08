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
    #region KafkaServer
    public partial class KafkaServer
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Kafka.Server.KafkaServer"/> to <see cref="Kafka.Server.KafkaBroker"/>
        /// </summary>
        public static implicit operator Kafka.Server.KafkaBroker(Kafka.Server.KafkaServer t) => t.Cast<Kafka.Server.KafkaBroker>();
        /// <summary>
        /// Converter from <see cref="Kafka.Server.KafkaServer"/> to <see cref="Kafka.Server.Server"/>
        /// </summary>
        public static implicit operator Kafka.Server.Server(Kafka.Server.KafkaServer t) => t.Cast<Kafka.Server.Server>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#MIN_INCREMENTAL_FETCH_SESSION_EVICTION_MS()"/> 
        /// </summary>
        public static long MIN_INCREMENTAL_FETCH_SESSION_EVICTION_MS
        {
            get { return SExecute<long>(LocalBridgeClazz, "MIN_INCREMENTAL_FETCH_SESSION_EVICTION_MS"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#zkClientConfigFromKafkaConfig(kafka.server.KafkaConfig,boolean)"/>
        /// </summary>
        /// <param name="config"><see cref="Kafka.Server.KafkaConfig"/></param>
        /// <param name="forceZkSslClientEnable"><see cref="bool"/></param>
        /// <returns><see cref="Org.Apache.Zookeeper.Client.ZKClientConfig"/></returns>
        public static Org.Apache.Zookeeper.Client.ZKClientConfig ZkClientConfigFromKafkaConfig(Kafka.Server.KafkaConfig config, bool forceZkSslClientEnable)
        {
            return SExecute<Org.Apache.Zookeeper.Client.ZKClientConfig>(LocalBridgeClazz, "zkClientConfigFromKafkaConfig", config, forceZkSslClientEnable);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#_brokerTopicStats()"/> 
        /// </summary>
        public Kafka.Server.BrokerTopicStats _brokerTopicStats
        {
            get { return IExecute<Kafka.Server.BrokerTopicStats>("_brokerTopicStats"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#adminManager()"/> 
        /// </summary>
        public Kafka.Server.ZkAdminManager AdminManager
        {
            get { return IExecute<Kafka.Server.ZkAdminManager>("adminManager"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#alterPartitionManager()"/> 
        /// </summary>
        public Kafka.Server.AlterPartitionManager AlterPartitionManager
        {
            get { return IExecute<Kafka.Server.AlterPartitionManager>("alterPartitionManager"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#autoTopicCreationManager()"/> 
        /// </summary>
        public Kafka.Server.AutoTopicCreationManager AutoTopicCreationManager
        {
            get { return IExecute<Kafka.Server.AutoTopicCreationManager>("autoTopicCreationManager"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#brokerEpochManager()"/> 
        /// </summary>
        public Kafka.Server.ZkBrokerEpochManager BrokerEpochManager
        {
            get { return IExecute<Kafka.Server.ZkBrokerEpochManager>("brokerEpochManager"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#brokerEpochSupplier()"/> 
        /// </summary>
        public long BrokerEpochSupplier
        {
            get { return IExecute<long>("brokerEpochSupplier"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#brokerFeatures()"/> 
        /// </summary>
        public Kafka.Server.BrokerFeatures BrokerFeatures
        {
            get { return IExecute<Kafka.Server.BrokerFeatures>("brokerFeatures"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#brokerMetaPropsFile()"/> 
        /// </summary>
        public string BrokerMetaPropsFile
        {
            get { return IExecute<string>("brokerMetaPropsFile"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#brokerState()"/> 
        /// </summary>
        public Org.Apache.Kafka.Metadata.BrokerState BrokerState
        {
            get { return IExecute<Org.Apache.Kafka.Metadata.BrokerState>("brokerState"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#brokerTopicStats()"/> 
        /// </summary>
        public Kafka.Server.BrokerTopicStats BrokerTopicStats
        {
            get { return IExecute<Kafka.Server.BrokerTopicStats>("brokerTopicStats"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#clientToControllerChannelManager()"/> 
        /// </summary>
        public Kafka.Server.BrokerToControllerChannelManager ClientToControllerChannelManager
        {
            get { return IExecute<Kafka.Server.BrokerToControllerChannelManager>("clientToControllerChannelManager"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#clusterId()"/> 
        /// </summary>
        public string ClusterId
        {
            get { return IExecute<string>("clusterId"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#config()"/> 
        /// </summary>
        public Kafka.Server.KafkaConfig Config
        {
            get { return IExecute<Kafka.Server.KafkaConfig>("config"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#controlPlaneRequestHandlerPool()"/> 
        /// </summary>
        public Kafka.Server.KafkaRequestHandlerPool ControlPlaneRequestHandlerPool
        {
            get { return IExecute<Kafka.Server.KafkaRequestHandlerPool>("controlPlaneRequestHandlerPool"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#controlPlaneRequestProcessor()"/> 
        /// </summary>
        public Kafka.Server.KafkaApis ControlPlaneRequestProcessor
        {
            get { return IExecute<Kafka.Server.KafkaApis>("controlPlaneRequestProcessor"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#correlationId()"/> 
        /// </summary>
        public Java.Util.Concurrent.Atomic.AtomicInteger CorrelationId
        {
            get { return IExecute<Java.Util.Concurrent.Atomic.AtomicInteger>("correlationId"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#createBrokerInfo()"/> 
        /// </summary>
        public Kafka.Zk.BrokerInfo CreateBrokerInfo
        {
            get { return IExecute<Kafka.Zk.BrokerInfo>("createBrokerInfo"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#credentialProvider()"/> 
        /// </summary>
        public Kafka.Security.CredentialProvider CredentialProvider
        {
            get { return IExecute<Kafka.Security.CredentialProvider>("credentialProvider"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#dataPlaneRequestHandlerPool()"/> 
        /// </summary>
        public Kafka.Server.KafkaRequestHandlerPool DataPlaneRequestHandlerPool
        {
            get { return IExecute<Kafka.Server.KafkaRequestHandlerPool>("dataPlaneRequestHandlerPool"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#dataPlaneRequestProcessor()"/> 
        /// </summary>
        public Kafka.Server.KafkaApis DataPlaneRequestProcessor
        {
            get { return IExecute<Kafka.Server.KafkaApis>("dataPlaneRequestProcessor"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#dynamicConfigManager()"/> 
        /// </summary>
        public Kafka.Server.ZkConfigManager DynamicConfigManager
        {
            get { return IExecute<Kafka.Server.ZkConfigManager>("dynamicConfigManager"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#featureChangeListener()"/> 
        /// </summary>
        public Kafka.Server.FinalizedFeatureChangeListener FeatureChangeListener
        {
            get { return IExecute<Kafka.Server.FinalizedFeatureChangeListener>("featureChangeListener"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#groupCoordinator()"/> 
        /// </summary>
        public Kafka.Coordinator.Group.GroupCoordinator GroupCoordinator
        {
            get { return IExecute<Kafka.Coordinator.Group.GroupCoordinator>("groupCoordinator"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#isDebugEnabled()"/> 
        /// </summary>
        public bool IsDebugEnabled
        {
            get { return IExecute<bool>("isDebugEnabled"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#isTraceEnabled()"/> 
        /// </summary>
        public bool IsTraceEnabled
        {
            get { return IExecute<bool>("isTraceEnabled"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#kafkaController()"/> 
        /// </summary>
        public Kafka.Controller.KafkaController KafkaController
        {
            get { return IExecute<Kafka.Controller.KafkaController>("kafkaController"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#kafkaScheduler()"/> 
        /// </summary>
        public Kafka.Utils.KafkaScheduler KafkaScheduler
        {
            get { return IExecute<Kafka.Utils.KafkaScheduler>("kafkaScheduler"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#kafkaYammerMetrics()"/> 
        /// </summary>
        public Org.Apache.Kafka.Server.Metrics.KafkaYammerMetrics KafkaYammerMetrics
        {
            get { return IExecute<Org.Apache.Kafka.Server.Metrics.KafkaYammerMetrics>("kafkaYammerMetrics"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#lifecycleManager()"/> 
        /// </summary>
        public Kafka.Server.BrokerLifecycleManager LifecycleManager
        {
            get { return IExecute<Kafka.Server.BrokerLifecycleManager>("lifecycleManager"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#logDirFailureChannel()"/> 
        /// </summary>
        public Kafka.Server.LogDirFailureChannel LogDirFailureChannel
        {
            get { return IExecute<Kafka.Server.LogDirFailureChannel>("logDirFailureChannel"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#logger()"/> 
        /// </summary>
        public Com.Typesafe.Scalalogging.Logger Logger
        {
            get { return IExecute<Com.Typesafe.Scalalogging.Logger>("logger"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#loggerName()"/> 
        /// </summary>
        public string LoggerName
        {
            get { return IExecute<string>("loggerName"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#logIdent()"/> 
        /// </summary>
        public string LogIdent
        {
            get { return IExecute<string>("logIdent"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#logManager()"/> 
        /// </summary>
        public Kafka.Log.LogManager LogManager
        {
            get { return IExecute<Kafka.Log.LogManager>("logManager"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#metadataCache()"/> 
        /// </summary>
        public Kafka.Server.MetadataCache MetadataCache
        {
            get { return IExecute<Kafka.Server.MetadataCache>("metadataCache"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#metrics()"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.Metrics.Metrics Metrics
        {
            get { return IExecute<Org.Apache.Kafka.Common.Metrics.Metrics>("metrics"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#quotaManagers()"/> 
        /// </summary>
        public Kafka.Server.QuotaFactory.QuotaManagers QuotaManagers
        {
            get { return IExecute<Kafka.Server.QuotaFactory.QuotaManagers>("quotaManagers"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#replicaManager()"/> 
        /// </summary>
        public Kafka.Server.ReplicaManager ReplicaManager
        {
            get { return IExecute<Kafka.Server.ReplicaManager>("replicaManager"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#socketServer()"/> 
        /// </summary>
        public Kafka.Network.SocketServer SocketServer
        {
            get { return IExecute<Kafka.Network.SocketServer>("socketServer"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#tokenCache()"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.Security.Token.Delegation.Internals.DelegationTokenCache TokenCache
        {
            get { return IExecute<Org.Apache.Kafka.Common.Security.Token.Delegation.Internals.DelegationTokenCache>("tokenCache"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#tokenManager()"/> 
        /// </summary>
        public Kafka.Server.DelegationTokenManager TokenManager
        {
            get { return IExecute<Kafka.Server.DelegationTokenManager>("tokenManager"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#transactionCoordinator()"/> 
        /// </summary>
        public Kafka.Coordinator.Transaction.TransactionCoordinator TransactionCoordinator
        {
            get { return IExecute<Kafka.Coordinator.Transaction.TransactionCoordinator>("transactionCoordinator"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#zkClient()"/> 
        /// </summary>
        public Kafka.Zk.KafkaZkClient ZkClient
        {
            get { return IExecute<Kafka.Zk.KafkaZkClient>("zkClient"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#zkClientConfig()"/> 
        /// </summary>
        public Org.Apache.Zookeeper.Client.ZKClientConfig ZkClientConfig
        {
            get { return IExecute<Org.Apache.Zookeeper.Client.ZKClientConfig>("zkClientConfig"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#newMeter(com.yammer.metrics.core.MetricName,java.lang.String,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="metricName"><see cref="Com.Yammer.Metrics.Core.MetricName"/></param>
        /// <param name="eventType"><see cref="string"/></param>
        /// <param name="timeUnit"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="Com.Yammer.Metrics.Core.Meter"/></returns>
        public Com.Yammer.Metrics.Core.Meter NewMeter(Com.Yammer.Metrics.Core.MetricName metricName, string eventType, Java.Util.Concurrent.TimeUnit timeUnit)
        {
            return IExecute<Com.Yammer.Metrics.Core.Meter>("newMeter", metricName, eventType, timeUnit);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#boundPort(org.apache.kafka.common.network.ListenerName)"/>
        /// </summary>
        /// <param name="listenerName"><see cref="Org.Apache.Kafka.Common.Network.ListenerName"/></param>
        /// <returns><see cref="int"/></returns>
        public int BoundPort(Org.Apache.Kafka.Common.Network.ListenerName listenerName)
        {
            return IExecute<int>("boundPort", listenerName);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#msgWithLogIdent(java.lang.String)"/>
        /// </summary>
        /// <param name="msg"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string MsgWithLogIdent(string msg)
        {
            return IExecute<string>("msgWithLogIdent", msg);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#getLogManager()"/>
        /// </summary>

        /// <returns><see cref="Kafka.Log.LogManager"/></returns>
        public Kafka.Log.LogManager GetLogManager()
        {
            return IExecute<Kafka.Log.LogManager>("getLogManager");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#createReplicaManager(java.util.concurrent.atomic.AtomicBoolean)"/>
        /// </summary>
        /// <param name="isShuttingDown"><see cref="Java.Util.Concurrent.Atomic.AtomicBoolean"/></param>
        /// <returns><see cref="Kafka.Server.ReplicaManager"/></returns>
        public Kafka.Server.ReplicaManager CreateReplicaManager(Java.Util.Concurrent.Atomic.AtomicBoolean isShuttingDown)
        {
            return IExecute<Kafka.Server.ReplicaManager>("createReplicaManager", isShuttingDown);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#awaitShutdown()"/>
        /// </summary>
        public void AwaitShutdown()
        {
            IExecute("awaitShutdown");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#shutdown()"/>
        /// </summary>
        public void Shutdown()
        {
            IExecute("shutdown");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaServer.html#startup()"/>
        /// </summary>
        public void Startup()
        {
            IExecute("startup");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}