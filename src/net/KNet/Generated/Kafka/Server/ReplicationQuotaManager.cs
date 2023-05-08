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
    #region ReplicationQuotaManager
    public partial class ReplicationQuotaManager
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ReplicationQuotaManager.html#%3Cinit%3E(kafka.server.ReplicationQuotaManagerConfig,org.apache.kafka.common.metrics.Metrics,kafka.server.QuotaType,org.apache.kafka.common.utils.Time)"/>
        /// </summary>
        /// <param name="config"><see cref="Kafka.Server.ReplicationQuotaManagerConfig"/></param>
        /// <param name="metrics"><see cref="Org.Apache.Kafka.Common.Metrics.Metrics"/></param>
        /// <param name="replicationType"><see cref="Kafka.Server.QuotaType"/></param>
        /// <param name="time"><see cref="Org.Apache.Kafka.Common.Utils.Time"/></param>
        public ReplicationQuotaManager(Kafka.Server.ReplicationQuotaManagerConfig config, Org.Apache.Kafka.Common.Metrics.Metrics metrics, Kafka.Server.QuotaType replicationType, Org.Apache.Kafka.Common.Utils.Time time)
            : base(config, metrics, replicationType, time)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Kafka.Server.ReplicationQuotaManager"/> to <see cref="Kafka.Utils.Logging"/>
        /// </summary>
        public static implicit operator Kafka.Utils.Logging(Kafka.Server.ReplicationQuotaManager t) => t.Cast<Kafka.Utils.Logging>();
        /// <summary>
        /// Converter from <see cref="Kafka.Server.ReplicationQuotaManager"/> to <see cref="Kafka.Server.ReplicaQuota"/>
        /// </summary>
        public static implicit operator Kafka.Server.ReplicaQuota(Kafka.Server.ReplicationQuotaManager t) => t.Cast<Kafka.Server.ReplicaQuota>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ReplicationQuotaManager.html#config()"/> 
        /// </summary>
        public Kafka.Server.ReplicationQuotaManagerConfig Config
        {
            get { return IExecute<Kafka.Server.ReplicationQuotaManagerConfig>("config"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ReplicationQuotaManager.html#isDebugEnabled()"/> 
        /// </summary>
        public bool IsDebugEnabled
        {
            get { return IExecute<bool>("isDebugEnabled"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ReplicationQuotaManager.html#isQuotaExceeded()"/> 
        /// </summary>
        public bool IsQuotaExceeded
        {
            get { return IExecute<bool>("isQuotaExceeded"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ReplicationQuotaManager.html#isTraceEnabled()"/> 
        /// </summary>
        public bool IsTraceEnabled
        {
            get { return IExecute<bool>("isTraceEnabled"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ReplicationQuotaManager.html#logger()"/> 
        /// </summary>
        public Com.Typesafe.Scalalogging.Logger Logger
        {
            get { return IExecute<Com.Typesafe.Scalalogging.Logger>("logger"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ReplicationQuotaManager.html#loggerName()"/> 
        /// </summary>
        public string LoggerName
        {
            get { return IExecute<string>("loggerName"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ReplicationQuotaManager.html#logIdent()"/> 
        /// </summary>
        public string LogIdent
        {
            get { return IExecute<string>("logIdent"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ReplicationQuotaManager.html#upperBound()"/> 
        /// </summary>
        public long UpperBound
        {
            get { return IExecute<long>("upperBound"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ReplicationQuotaManager.html#isThrottled(org.apache.kafka.common.TopicPartition)"/>
        /// </summary>
        /// <param name="topicPartition"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsThrottled(Org.Apache.Kafka.Common.TopicPartition topicPartition)
        {
            return IExecute<bool>("isThrottled", topicPartition);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ReplicationQuotaManager.html#msgWithLogIdent(java.lang.String)"/>
        /// </summary>
        /// <param name="msg"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string MsgWithLogIdent(string msg)
        {
            return IExecute<string>("msgWithLogIdent", msg);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ReplicationQuotaManager.html#markThrottled(java.lang.String)"/>
        /// </summary>
        /// <param name="topic"><see cref="string"/></param>
        public void MarkThrottled(string topic)
        {
            IExecute("markThrottled", topic);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ReplicationQuotaManager.html#record(long)"/>
        /// </summary>
        /// <param name="value"><see cref="long"/></param>
        public void Record(long value)
        {
            IExecute("record", value);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ReplicationQuotaManager.html#removeThrottle(java.lang.String)"/>
        /// </summary>
        /// <param name="topic"><see cref="string"/></param>
        public void RemoveThrottle(string topic)
        {
            IExecute("removeThrottle", topic);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ReplicationQuotaManager.html#updateQuota(org.apache.kafka.common.metrics.Quota)"/>
        /// </summary>
        /// <param name="quota"><see cref="Org.Apache.Kafka.Common.Metrics.Quota"/></param>
        public void UpdateQuota(Org.Apache.Kafka.Common.Metrics.Quota quota)
        {
            IExecute("updateQuota", quota);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}