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
    #region ClientQuotaManager
    public partial class ClientQuotaManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Kafka.Server.ClientQuotaManager"/> to <see cref="Kafka.Utils.Logging"/>
        /// </summary>
        public static implicit operator Kafka.Utils.Logging(Kafka.Server.ClientQuotaManager t) => t.Cast<Kafka.Utils.Logging>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.html#DefaultClientIdQuotaEntity()"/> 
        /// </summary>
        public static Kafka.Server.ClientQuotaManager.KafkaQuotaEntity DefaultClientIdQuotaEntity
        {
            get { return SExecute<Kafka.Server.ClientQuotaManager.KafkaQuotaEntity>(LocalBridgeClazz, "DefaultClientIdQuotaEntity"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.html#DefaultUserClientIdQuotaEntity()"/> 
        /// </summary>
        public static Kafka.Server.ClientQuotaManager.KafkaQuotaEntity DefaultUserClientIdQuotaEntity
        {
            get { return SExecute<Kafka.Server.ClientQuotaManager.KafkaQuotaEntity>(LocalBridgeClazz, "DefaultUserClientIdQuotaEntity"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.html#DefaultUserQuotaEntity()"/> 
        /// </summary>
        public static Kafka.Server.ClientQuotaManager.KafkaQuotaEntity DefaultUserQuotaEntity
        {
            get { return SExecute<Kafka.Server.ClientQuotaManager.KafkaQuotaEntity>(LocalBridgeClazz, "DefaultUserQuotaEntity"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.html#InactiveSensorExpirationTimeSeconds()"/> 
        /// </summary>
        public static int InactiveSensorExpirationTimeSeconds
        {
            get { return SExecute<int>(LocalBridgeClazz, "InactiveSensorExpirationTimeSeconds"); }
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.html#isDebugEnabled()"/> 
        /// </summary>
        public bool IsDebugEnabled
        {
            get { return IExecute<bool>("isDebugEnabled"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.html#isTraceEnabled()"/> 
        /// </summary>
        public bool IsTraceEnabled
        {
            get { return IExecute<bool>("isTraceEnabled"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.html#logger()"/> 
        /// </summary>
        public Com.Typesafe.Scalalogging.Logger Logger
        {
            get { return IExecute<Com.Typesafe.Scalalogging.Logger>("logger"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.html#loggerName()"/> 
        /// </summary>
        public string LoggerName
        {
            get { return IExecute<string>("loggerName"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.html#logIdent()"/> 
        /// </summary>
        public string LogIdent
        {
            get { return IExecute<string>("logIdent"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.html#quotasEnabled()"/> 
        /// </summary>
        public bool QuotasEnabled
        {
            get { return IExecute<bool>("quotasEnabled"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.html#getMaxValueInQuotaWindow(kafka.network.RequestChannel.Session,java.lang.String)"/>
        /// </summary>
        /// <param name="session"><see cref="Kafka.Network.RequestChannel.Session"/></param>
        /// <param name="clientId"><see cref="string"/></param>
        /// <returns><see cref="double"/></returns>
        public double GetMaxValueInQuotaWindow(Kafka.Network.RequestChannel.Session session, string clientId)
        {
            return IExecute<double>("getMaxValueInQuotaWindow", session, clientId);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.html#maybeRecordAndGetThrottleTimeMs(kafka.network.RequestChannel.Request,double,long)"/>
        /// </summary>
        /// <param name="request"><see cref="Kafka.Network.RequestChannel.Request"/></param>
        /// <param name="value"><see cref="double"/></param>
        /// <param name="timeMs"><see cref="long"/></param>
        /// <returns><see cref="int"/></returns>
        public int MaybeRecordAndGetThrottleTimeMs(Kafka.Network.RequestChannel.Request request, double value, long timeMs)
        {
            return IExecute<int>("maybeRecordAndGetThrottleTimeMs", request, value, timeMs);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.html#maybeRecordAndGetThrottleTimeMs(kafka.network.RequestChannel.Session,java.lang.String,double,long)"/>
        /// </summary>
        /// <param name="session"><see cref="Kafka.Network.RequestChannel.Session"/></param>
        /// <param name="clientId"><see cref="string"/></param>
        /// <param name="value"><see cref="double"/></param>
        /// <param name="timeMs"><see cref="long"/></param>
        /// <returns><see cref="int"/></returns>
        public int MaybeRecordAndGetThrottleTimeMs(Kafka.Network.RequestChannel.Session session, string clientId, double value, long timeMs)
        {
            return IExecute<int>("maybeRecordAndGetThrottleTimeMs", session, clientId, value, timeMs);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.html#recordAndGetThrottleTimeMs(kafka.network.RequestChannel.Session,java.lang.String,double,long)"/>
        /// </summary>
        /// <param name="session"><see cref="Kafka.Network.RequestChannel.Session"/></param>
        /// <param name="clientId"><see cref="string"/></param>
        /// <param name="value"><see cref="double"/></param>
        /// <param name="timeMs"><see cref="long"/></param>
        /// <returns><see cref="int"/></returns>
        public int RecordAndGetThrottleTimeMs(Kafka.Network.RequestChannel.Session session, string clientId, double value, long timeMs)
        {
            return IExecute<int>("recordAndGetThrottleTimeMs", session, clientId, value, timeMs);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.html#msgWithLogIdent(java.lang.String)"/>
        /// </summary>
        /// <param name="msg"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string MsgWithLogIdent(string msg)
        {
            return IExecute<string>("msgWithLogIdent", msg);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.html#throttledChannelReaper()"/>
        /// </summary>

        /// <returns><see cref="Kafka.Server.ClientQuotaManager.ThrottledChannelReaper"/></returns>
        public Kafka.Server.ClientQuotaManager.ThrottledChannelReaper ThrottledChannelReaperMethod()
        {
            return IExecute<Kafka.Server.ClientQuotaManager.ThrottledChannelReaper>("throttledChannelReaper");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.html#getOrCreateQuotaSensors(kafka.network.RequestChannel.Session,java.lang.String)"/>
        /// </summary>
        /// <param name="session"><see cref="Kafka.Network.RequestChannel.Session"/></param>
        /// <param name="clientId"><see cref="string"/></param>
        /// <returns><see cref="Kafka.Server.ClientSensors"/></returns>
        public Kafka.Server.ClientSensors GetOrCreateQuotaSensors(Kafka.Network.RequestChannel.Session session, string clientId)
        {
            return IExecute<Kafka.Server.ClientSensors>("getOrCreateQuotaSensors", session, clientId);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.html#throttleTime(org.apache.kafka.common.metrics.QuotaViolationException,long)"/>
        /// </summary>
        /// <param name="e"><see cref="Org.Apache.Kafka.Common.Metrics.QuotaViolationException"/></param>
        /// <param name="timeMs"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long ThrottleTime(Org.Apache.Kafka.Common.Metrics.QuotaViolationException e, long timeMs)
        {
            return IExecute<long>("throttleTime", e, timeMs);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.html#quota(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="user"><see cref="string"/></param>
        /// <param name="clientId"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Metrics.Quota"/></returns>
        public Org.Apache.Kafka.Common.Metrics.Quota Quota(string user, string clientId)
        {
            return IExecute<Org.Apache.Kafka.Common.Metrics.Quota>("quota", user, clientId);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.html#quota(org.apache.kafka.common.security.auth.KafkaPrincipal,java.lang.String)"/>
        /// </summary>
        /// <param name="userPrincipal"><see cref="Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal"/></param>
        /// <param name="clientId"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Metrics.Quota"/></returns>
        public Org.Apache.Kafka.Common.Metrics.Quota Quota(Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal userPrincipal, string clientId)
        {
            return IExecute<Org.Apache.Kafka.Common.Metrics.Quota>("quota", userPrincipal, clientId);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.html#initiateShutdown()"/>
        /// </summary>
        public void InitiateShutdown()
        {
            IExecute("initiateShutdown");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.html#recordNoThrottle(kafka.network.RequestChannel.Session,java.lang.String,double)"/>
        /// </summary>
        /// <param name="session"><see cref="Kafka.Network.RequestChannel.Session"/></param>
        /// <param name="clientId"><see cref="string"/></param>
        /// <param name="value"><see cref="double"/></param>
        public void RecordNoThrottle(Kafka.Network.RequestChannel.Session session, string clientId, double value)
        {
            IExecute("recordNoThrottle", session, clientId, value);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.html#shutdown()"/>
        /// </summary>
        public void Shutdown()
        {
            IExecute("shutdown");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.html#throttle(kafka.network.RequestChannel.Request,kafka.server.ThrottleCallback,int)"/>
        /// </summary>
        /// <param name="request"><see cref="Kafka.Network.RequestChannel.Request"/></param>
        /// <param name="throttleCallback"><see cref="Kafka.Server.ThrottleCallback"/></param>
        /// <param name="throttleTimeMs"><see cref="int"/></param>
        public void Throttle(Kafka.Network.RequestChannel.Request request, Kafka.Server.ThrottleCallback throttleCallback, int throttleTimeMs)
        {
            IExecute("throttle", request, throttleCallback, throttleTimeMs);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.html#unrecordQuotaSensor(kafka.network.RequestChannel.Request,double,long)"/>
        /// </summary>
        /// <param name="request"><see cref="Kafka.Network.RequestChannel.Request"/></param>
        /// <param name="value"><see cref="double"/></param>
        /// <param name="timeMs"><see cref="long"/></param>
        public void UnrecordQuotaSensor(Kafka.Network.RequestChannel.Request request, double value, long timeMs)
        {
            IExecute("unrecordQuotaSensor", request, value, timeMs);
        }

        #endregion

        #region Nested classes
        #region BaseUserEntity
        public partial class BaseUserEntity
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

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ClientIdEntity
        public partial class ClientIdEntity
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.ClientIdEntity.html#%3Cinit%3E(java.lang.String)"/>
            /// </summary>
            /// <param name="clientId"><see cref="string"/></param>
            public ClientIdEntity(string clientId)
                : base(clientId)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Kafka.Server.ClientQuotaManager.ClientIdEntity"/> to <see cref="Java.Io.Serializable"/>
            /// </summary>
            public static implicit operator Java.Io.Serializable(Kafka.Server.ClientQuotaManager.ClientIdEntity t) => t.Cast<Java.Io.Serializable>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.ClientIdEntity.html#clientId()"/> 
            /// </summary>
            public string ClientId
            {
                get { return IExecute<string>("clientId"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.ClientIdEntity.html#entityType()"/> 
            /// </summary>
            public Org.Apache.Kafka.Server.Quota.ClientQuotaEntity.ConfigEntityType EntityType
            {
                get { return IExecute<Org.Apache.Kafka.Server.Quota.ClientQuotaEntity.ConfigEntityType>("entityType"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.ClientIdEntity.html#name()"/> 
            /// </summary>
            public string Name
            {
                get { return IExecute<string>("name"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.ClientIdEntity.html#productArity()"/> 
            /// </summary>
            public int ProductArity
            {
                get { return IExecute<int>("productArity"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.ClientIdEntity.html#productPrefix()"/> 
            /// </summary>
            public string ProductPrefix
            {
                get { return IExecute<string>("productPrefix"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.ClientIdEntity.html#canEqual(java.lang.Object)"/>
            /// </summary>
            /// <param name="x$1"><see cref="object"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool CanEqual(object x_1)
            {
                return IExecute<bool>("canEqual", x_1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.ClientIdEntity.html#productElement(int)"/>
            /// </summary>
            /// <param name="x$1"><see cref="int"/></param>
            /// <returns><see cref="object"/></returns>
            public object ProductElement(int x_1)
            {
                return IExecute("productElement", x_1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.ClientIdEntity.html#productElementName(int)"/>
            /// </summary>
            /// <param name="x$1"><see cref="int"/></param>
            /// <returns><see cref="string"/></returns>
            public string ProductElementName(int x_1)
            {
                return IExecute<string>("productElementName", x_1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.ClientIdEntity.html#copy(java.lang.String)"/>
            /// </summary>
            /// <param name="clientId"><see cref="string"/></param>
            /// <returns><see cref="Kafka.Server.ClientQuotaManager.ClientIdEntity"/></returns>
            public Kafka.Server.ClientQuotaManager.ClientIdEntity Copy(string clientId)
            {
                return IExecute<Kafka.Server.ClientQuotaManager.ClientIdEntity>("copy", clientId);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region DefaultQuotaCallback
        public partial class DefaultQuotaCallback
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.DefaultQuotaCallback.html#%3Cinit%3E(kafka.server.ClientQuotaManager)"/>
            /// </summary>
            /// <param name="$outer"><see cref="Kafka.Server.ClientQuotaManager"/></param>
            public DefaultQuotaCallback(Kafka.Server.ClientQuotaManager _outer)
                : base(_outer)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Kafka.Server.ClientQuotaManager.DefaultQuotaCallback"/> to <see cref="Org.Apache.Kafka.Server.Quota.ClientQuotaCallback"/>
            /// </summary>
            public static implicit operator Org.Apache.Kafka.Server.Quota.ClientQuotaCallback(Kafka.Server.ClientQuotaManager.DefaultQuotaCallback t) => t.Cast<Org.Apache.Kafka.Server.Quota.ClientQuotaCallback>();

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.DefaultQuotaCallback.html#$outer"/>
            /// </summary>
            public Kafka.Server.ClientQuotaManager $outer { get { return IGetField<Kafka.Server.ClientQuotaManager>("$outer"); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.DefaultQuotaCallback.html#quotaResetRequired(org.apache.kafka.server.quota.ClientQuotaType)"/>
            /// </summary>
            /// <param name="quotaType"><see cref="Org.Apache.Kafka.Server.Quota.ClientQuotaType"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool QuotaResetRequired(Org.Apache.Kafka.Server.Quota.ClientQuotaType quotaType)
            {
                return IExecute<bool>("quotaResetRequired", quotaType);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.DefaultQuotaCallback.html#updateClusterMetadata(org.apache.kafka.common.Cluster)"/>
            /// </summary>
            /// <param name="cluster"><see cref="Org.Apache.Kafka.Common.Cluster"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool UpdateClusterMetadata(Org.Apache.Kafka.Common.Cluster cluster)
            {
                return IExecute<bool>("updateClusterMetadata", cluster);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.DefaultQuotaCallback.html#quotaLimit(org.apache.kafka.server.quota.ClientQuotaType,java.util.Map)"/>
            /// </summary>
            /// <param name="quotaType"><see cref="Org.Apache.Kafka.Server.Quota.ClientQuotaType"/></param>
            /// <param name="metricTags"><see cref="Java.Util.Map"/></param>
            /// <returns><see cref="double"/></returns>
            public double? QuotaLimit(Org.Apache.Kafka.Server.Quota.ClientQuotaType quotaType, Java.Util.Map<string, string> metricTags)
            {
                return IExecute<double?>("quotaLimit", quotaType, metricTags);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.DefaultQuotaCallback.html#quotaMetricTags(org.apache.kafka.server.quota.ClientQuotaType,org.apache.kafka.common.security.auth.KafkaPrincipal,java.lang.String)"/>
            /// </summary>
            /// <param name="quotaType"><see cref="Org.Apache.Kafka.Server.Quota.ClientQuotaType"/></param>
            /// <param name="principal"><see cref="Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal"/></param>
            /// <param name="clientId"><see cref="string"/></param>
            /// <returns><see cref="Java.Util.Map"/></returns>
            public Java.Util.Map<string, string> QuotaMetricTags(Org.Apache.Kafka.Server.Quota.ClientQuotaType quotaType, Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal principal, string clientId)
            {
                return IExecute<Java.Util.Map<string, string>>("quotaMetricTags", quotaType, principal, clientId);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.DefaultQuotaCallback.html#close()"/>
            /// </summary>
            public void Close()
            {
                IExecute("close");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.DefaultQuotaCallback.html#configure(java.util.Map)"/>
            /// </summary>
            /// <param name="configs"><see cref="Java.Util.Map"/></param>
            /// <typeparam name="ConfigsExtendsobject"></typeparam>
            public void Configure<ConfigsExtendsobject>(Java.Util.Map<string, ConfigsExtendsobject> configs)
            {
                IExecute("configure", configs);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.DefaultQuotaCallback.html#removeQuota(org.apache.kafka.server.quota.ClientQuotaType,org.apache.kafka.server.quota.ClientQuotaEntity)"/>
            /// </summary>
            /// <param name="quotaType"><see cref="Org.Apache.Kafka.Server.Quota.ClientQuotaType"/></param>
            /// <param name="entity"><see cref="Org.Apache.Kafka.Server.Quota.ClientQuotaEntity"/></param>
            public void RemoveQuota(Org.Apache.Kafka.Server.Quota.ClientQuotaType quotaType, Org.Apache.Kafka.Server.Quota.ClientQuotaEntity entity)
            {
                IExecute("removeQuota", quotaType, entity);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.DefaultQuotaCallback.html#updateQuota(org.apache.kafka.server.quota.ClientQuotaType,org.apache.kafka.server.quota.ClientQuotaEntity,double)"/>
            /// </summary>
            /// <param name="quotaType"><see cref="Org.Apache.Kafka.Server.Quota.ClientQuotaType"/></param>
            /// <param name="entity"><see cref="Org.Apache.Kafka.Server.Quota.ClientQuotaEntity"/></param>
            /// <param name="newValue"><see cref="double"/></param>
            public void UpdateQuota(Org.Apache.Kafka.Server.Quota.ClientQuotaType quotaType, Org.Apache.Kafka.Server.Quota.ClientQuotaEntity entity, double newValue)
            {
                IExecute("updateQuota", quotaType, entity, newValue);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region KafkaQuotaEntity
        public partial class KafkaQuotaEntity
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Kafka.Server.ClientQuotaManager.KafkaQuotaEntity"/> to <see cref="Org.Apache.Kafka.Server.Quota.ClientQuotaEntity"/>
            /// </summary>
            public static implicit operator Org.Apache.Kafka.Server.Quota.ClientQuotaEntity(Kafka.Server.ClientQuotaManager.KafkaQuotaEntity t) => t.Cast<Org.Apache.Kafka.Server.Quota.ClientQuotaEntity>();
            /// <summary>
            /// Converter from <see cref="Kafka.Server.ClientQuotaManager.KafkaQuotaEntity"/> to <see cref="Java.Io.Serializable"/>
            /// </summary>
            public static implicit operator Java.Io.Serializable(Kafka.Server.ClientQuotaManager.KafkaQuotaEntity t) => t.Cast<Java.Io.Serializable>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.KafkaQuotaEntity.html#clientId()"/> 
            /// </summary>
            public string ClientId
            {
                get { return IExecute<string>("clientId"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.KafkaQuotaEntity.html#configEntities()"/> 
            /// </summary>
            public Java.Util.List<Org.Apache.Kafka.Server.Quota.ClientQuotaEntity.ConfigEntity> ConfigEntities
            {
                get { return IExecute<Java.Util.List<Org.Apache.Kafka.Server.Quota.ClientQuotaEntity.ConfigEntity>>("configEntities"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.KafkaQuotaEntity.html#productArity()"/> 
            /// </summary>
            public int ProductArity
            {
                get { return IExecute<int>("productArity"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.KafkaQuotaEntity.html#productPrefix()"/> 
            /// </summary>
            public string ProductPrefix
            {
                get { return IExecute<string>("productPrefix"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.KafkaQuotaEntity.html#sanitizedUser()"/> 
            /// </summary>
            public string SanitizedUser
            {
                get { return IExecute<string>("sanitizedUser"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.KafkaQuotaEntity.html#canEqual(java.lang.Object)"/>
            /// </summary>
            /// <param name="x$1"><see cref="object"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool CanEqual(object x_1)
            {
                return IExecute<bool>("canEqual", x_1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.KafkaQuotaEntity.html#productElement(int)"/>
            /// </summary>
            /// <param name="x$1"><see cref="int"/></param>
            /// <returns><see cref="object"/></returns>
            public object ProductElement(int x_1)
            {
                return IExecute("productElement", x_1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.KafkaQuotaEntity.html#productElementName(int)"/>
            /// </summary>
            /// <param name="x$1"><see cref="int"/></param>
            /// <returns><see cref="string"/></returns>
            public string ProductElementName(int x_1)
            {
                return IExecute<string>("productElementName", x_1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ThrottledChannelReaper
        public partial class ThrottledChannelReaper
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.ThrottledChannelReaper.html#%3Cinit%3E(kafka.server.ClientQuotaManager,java.util.concurrent.DelayQueue,java.lang.String)"/>
            /// </summary>
            /// <param name="$outer"><see cref="Kafka.Server.ClientQuotaManager"/></param>
            /// <param name="delayQueue"><see cref="Java.Util.Concurrent.DelayQueue"/></param>
            /// <param name="prefix"><see cref="string"/></param>
            public ThrottledChannelReaper(Kafka.Server.ClientQuotaManager _outer, Java.Util.Concurrent.DelayQueue delayQueue, string prefix)
                : base(_outer, delayQueue, prefix)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.ThrottledChannelReaper.html#$outer"/>
            /// </summary>
            public Kafka.Server.ClientQuotaManager $outer { get { return IGetField<Kafka.Server.ClientQuotaManager>("$outer"); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region UserEntity
        public partial class UserEntity
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.UserEntity.html#%3Cinit%3E(java.lang.String)"/>
            /// </summary>
            /// <param name="sanitizedUser"><see cref="string"/></param>
            public UserEntity(string sanitizedUser)
                : base(sanitizedUser)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Kafka.Server.ClientQuotaManager.UserEntity"/> to <see cref="Java.Io.Serializable"/>
            /// </summary>
            public static implicit operator Java.Io.Serializable(Kafka.Server.ClientQuotaManager.UserEntity t) => t.Cast<Java.Io.Serializable>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.UserEntity.html#entityType()"/> 
            /// </summary>
            public Org.Apache.Kafka.Server.Quota.ClientQuotaEntity.ConfigEntityType EntityType
            {
                get { return IExecute<Org.Apache.Kafka.Server.Quota.ClientQuotaEntity.ConfigEntityType>("entityType"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.UserEntity.html#name()"/> 
            /// </summary>
            public string Name
            {
                get { return IExecute<string>("name"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.UserEntity.html#productArity()"/> 
            /// </summary>
            public int ProductArity
            {
                get { return IExecute<int>("productArity"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.UserEntity.html#productPrefix()"/> 
            /// </summary>
            public string ProductPrefix
            {
                get { return IExecute<string>("productPrefix"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.UserEntity.html#sanitizedUser()"/> 
            /// </summary>
            public string SanitizedUser
            {
                get { return IExecute<string>("sanitizedUser"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.UserEntity.html#canEqual(java.lang.Object)"/>
            /// </summary>
            /// <param name="x$1"><see cref="object"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool CanEqual(object x_1)
            {
                return IExecute<bool>("canEqual", x_1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.UserEntity.html#productElement(int)"/>
            /// </summary>
            /// <param name="x$1"><see cref="int"/></param>
            /// <returns><see cref="object"/></returns>
            public object ProductElement(int x_1)
            {
                return IExecute("productElement", x_1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.UserEntity.html#productElementName(int)"/>
            /// </summary>
            /// <param name="x$1"><see cref="int"/></param>
            /// <returns><see cref="string"/></returns>
            public string ProductElementName(int x_1)
            {
                return IExecute<string>("productElementName", x_1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ClientQuotaManager.UserEntity.html#copy(java.lang.String)"/>
            /// </summary>
            /// <param name="sanitizedUser"><see cref="string"/></param>
            /// <returns><see cref="Kafka.Server.ClientQuotaManager.UserEntity"/></returns>
            public Kafka.Server.ClientQuotaManager.UserEntity Copy(string sanitizedUser)
            {
                return IExecute<Kafka.Server.ClientQuotaManager.UserEntity>("copy", sanitizedUser);
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