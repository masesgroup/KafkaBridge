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
    #region ZkAdminManager
    public partial class ZkAdminManager
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ZkAdminManager.html#%3Cinit%3E(kafka.server.KafkaConfig,org.apache.kafka.common.metrics.Metrics,kafka.server.MetadataCache,kafka.zk.KafkaZkClient)"/>
        /// </summary>
        /// <param name="config"><see cref="Kafka.Server.KafkaConfig"/></param>
        /// <param name="metrics"><see cref="Org.Apache.Kafka.Common.Metrics.Metrics"/></param>
        /// <param name="metadataCache"><see cref="Kafka.Server.MetadataCache"/></param>
        /// <param name="zkClient"><see cref="Kafka.Zk.KafkaZkClient"/></param>
        public ZkAdminManager(Kafka.Server.KafkaConfig config, Org.Apache.Kafka.Common.Metrics.Metrics metrics, Kafka.Server.MetadataCache metadataCache, Kafka.Zk.KafkaZkClient zkClient)
            : base(config, metrics, metadataCache, zkClient)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Kafka.Server.ZkAdminManager"/> to <see cref="Kafka.Metrics.KafkaMetricsGroup"/>
        /// </summary>
        public static implicit operator Kafka.Metrics.KafkaMetricsGroup(Kafka.Server.ZkAdminManager t) => t.Cast<Kafka.Metrics.KafkaMetricsGroup>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ZkAdminManager.html#config()"/> 
        /// </summary>
        public Kafka.Server.KafkaConfig Config
        {
            get { return IExecute<Kafka.Server.KafkaConfig>("config"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ZkAdminManager.html#hasDelayedTopicOperations()"/> 
        /// </summary>
        public bool HasDelayedTopicOperations
        {
            get { return IExecute<bool>("hasDelayedTopicOperations"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ZkAdminManager.html#isDebugEnabled()"/> 
        /// </summary>
        public bool IsDebugEnabled
        {
            get { return IExecute<bool>("isDebugEnabled"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ZkAdminManager.html#isTraceEnabled()"/> 
        /// </summary>
        public bool IsTraceEnabled
        {
            get { return IExecute<bool>("isTraceEnabled"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ZkAdminManager.html#logger()"/> 
        /// </summary>
        public Com.Typesafe.Scalalogging.Logger Logger
        {
            get { return IExecute<Com.Typesafe.Scalalogging.Logger>("logger"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ZkAdminManager.html#loggerName()"/> 
        /// </summary>
        public string LoggerName
        {
            get { return IExecute<string>("loggerName"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ZkAdminManager.html#logIdent()"/> 
        /// </summary>
        public string LogIdent
        {
            get { return IExecute<string>("logIdent"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ZkAdminManager.html#metadataCache()"/> 
        /// </summary>
        public Kafka.Server.MetadataCache MetadataCache
        {
            get { return IExecute<Kafka.Server.MetadataCache>("metadataCache"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ZkAdminManager.html#metrics()"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.Metrics.Metrics Metrics
        {
            get { return IExecute<Org.Apache.Kafka.Common.Metrics.Metrics>("metrics"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ZkAdminManager.html#requestStatus()"/> 
        /// </summary>
        public Kafka.Server.ZkAdminManager.requestStatus. RequestStatus
        {
            get { return IExecute<Kafka.Server.ZkAdminManager.requestStatus.>("requestStatus"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ZkAdminManager.html#zkClient()"/> 
        /// </summary>
        public Kafka.Zk.KafkaZkClient ZkClient
        {
            get { return IExecute<Kafka.Zk.KafkaZkClient>("zkClient"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ZkAdminManager.html#newMeter(com.yammer.metrics.core.MetricName,java.lang.String,java.util.concurrent.TimeUnit)"/>
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
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ZkAdminManager.html#msgWithLogIdent(java.lang.String)"/>
        /// </summary>
        /// <param name="msg"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string MsgWithLogIdent(string msg)
        {
            return IExecute<string>("msgWithLogIdent", msg);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ZkAdminManager.html#apiErrorFrom(java.lang.Exception,java.lang.String)"/>
        /// </summary>
        /// <param name="e"><see cref="Java.Lang.Exception"/></param>
        /// <param name="message"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Requests.ApiError"/></returns>
        public Org.Apache.Kafka.Common.Requests.ApiError ApiErrorFrom(Java.Lang.Exception e, string message)
        {
            return IExecute<Org.Apache.Kafka.Common.Requests.ApiError>("apiErrorFrom", e, message);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ZkAdminManager.html#shutdown()"/>
        /// </summary>
        public void Shutdown()
        {
            IExecute("shutdown");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ZkAdminManager.html#tryCompleteDelayedTopicOperations(java.lang.String)"/>
        /// </summary>
        /// <param name="topic"><see cref="string"/></param>
        public void TryCompleteDelayedTopicOperations(string topic)
        {
            IExecute("tryCompleteDelayedTopicOperations", topic);
        }

        #endregion

        #region Nested classes
        #region requestStatus
        public partial class requestStatus
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Kafka.Server.ZkAdminManager.requestStatus"/> to <see cref="Java.Io.Serializable"/>
            /// </summary>
            public static implicit operator Java.Io.Serializable(Kafka.Server.ZkAdminManager.requestStatus t) => t.Cast<Java.Io.Serializable>();

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ZkAdminManager.requestStatus.html#$outer"/>
            /// </summary>
            public Kafka.Server.ZkAdminManager $outer { get { return IGetField<Kafka.Server.ZkAdminManager>("$outer"); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ZkAdminManager.requestStatus.html#iterations()"/> 
            /// </summary>
            public int Iterations
            {
                get { return IExecute<int>("iterations"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ZkAdminManager.requestStatus.html#legalRequest()"/> 
            /// </summary>
            public bool LegalRequest
            {
                get { return IExecute<bool>("legalRequest"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ZkAdminManager.requestStatus.html#productArity()"/> 
            /// </summary>
            public int ProductArity
            {
                get { return IExecute<int>("productArity"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ZkAdminManager.requestStatus.html#productPrefix()"/> 
            /// </summary>
            public string ProductPrefix
            {
                get { return IExecute<string>("productPrefix"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ZkAdminManager.requestStatus.html#user()"/> 
            /// </summary>
            public string User
            {
                get { return IExecute<string>("user"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ZkAdminManager.requestStatus.html#canEqual(java.lang.Object)"/>
            /// </summary>
            /// <param name="x$1"><see cref="object"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool CanEqual(object x_1)
            {
                return IExecute<bool>("canEqual", x_1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ZkAdminManager.requestStatus.html#productElement(int)"/>
            /// </summary>
            /// <param name="x$1"><see cref="int"/></param>
            /// <returns><see cref="object"/></returns>
            public object ProductElement(int x_1)
            {
                return IExecute("productElement", x_1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ZkAdminManager.requestStatus.html#productElementName(int)"/>
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

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}