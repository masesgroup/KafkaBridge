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

namespace Kafka.Server.Metadata
{
    #region BrokerServerMetrics
    public partial class BrokerServerMetrics
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/metadata/BrokerServerMetrics.html#%3Cinit%3E(org.apache.kafka.common.metrics.Metrics)"/>
        /// </summary>
        /// <param name="metrics"><see cref="Org.Apache.Kafka.Common.Metrics.Metrics"/></param>
        public BrokerServerMetrics(Org.Apache.Kafka.Common.Metrics.Metrics metrics)
            : base(metrics)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Kafka.Server.Metadata.BrokerServerMetrics"/> to <see cref="Org.Apache.Kafka.Image.Loader.MetadataLoaderMetrics"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Image.Loader.MetadataLoaderMetrics(Kafka.Server.Metadata.BrokerServerMetrics t) => t.Cast<Org.Apache.Kafka.Image.Loader.MetadataLoaderMetrics>();
        /// <summary>
        /// Converter from <see cref="Kafka.Server.Metadata.BrokerServerMetrics"/> to <see cref="Kafka.Metrics.KafkaMetricsGroup"/>
        /// </summary>
        public static implicit operator Kafka.Metrics.KafkaMetricsGroup(Kafka.Server.Metadata.BrokerServerMetrics t) => t.Cast<Kafka.Metrics.KafkaMetricsGroup>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/metadata/BrokerServerMetrics.html#apply(org.apache.kafka.common.metrics.Metrics)"/>
        /// </summary>
        /// <param name="metrics"><see cref="Org.Apache.Kafka.Common.Metrics.Metrics"/></param>
        /// <returns><see cref="Kafka.Server.Metadata.BrokerServerMetrics"/></returns>
        public static Kafka.Server.Metadata.BrokerServerMetrics Apply(Org.Apache.Kafka.Common.Metrics.Metrics metrics)
        {
            return SExecute<Kafka.Server.Metadata.BrokerServerMetrics>(LocalBridgeClazz, "apply", metrics);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/metadata/BrokerServerMetrics.html#isDebugEnabled()"/> 
        /// </summary>
        public bool IsDebugEnabled
        {
            get { return IExecute<bool>("isDebugEnabled"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/metadata/BrokerServerMetrics.html#isTraceEnabled()"/> 
        /// </summary>
        public bool IsTraceEnabled
        {
            get { return IExecute<bool>("isTraceEnabled"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/metadata/BrokerServerMetrics.html#lastAppliedImageProvenance()"/> 
        /// </summary>
        public Java.Util.Concurrent.Atomic.AtomicReference<Org.Apache.Kafka.Image.MetadataProvenance> LastAppliedImageProvenance
        {
            get { return IExecute<Java.Util.Concurrent.Atomic.AtomicReference<Org.Apache.Kafka.Image.MetadataProvenance>>("lastAppliedImageProvenance"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/metadata/BrokerServerMetrics.html#lastAppliedOffset()"/> 
        /// </summary>
        public long LastAppliedOffset
        {
            get { return IExecute<long>("lastAppliedOffset"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/metadata/BrokerServerMetrics.html#lastAppliedRecordLagMsName()"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.MetricName LastAppliedRecordLagMsName
        {
            get { return IExecute<Org.Apache.Kafka.Common.MetricName>("lastAppliedRecordLagMsName"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/metadata/BrokerServerMetrics.html#lastAppliedRecordOffsetName()"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.MetricName LastAppliedRecordOffsetName
        {
            get { return IExecute<Org.Apache.Kafka.Common.MetricName>("lastAppliedRecordOffsetName"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/metadata/BrokerServerMetrics.html#lastAppliedRecordTimestampName()"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.MetricName LastAppliedRecordTimestampName
        {
            get { return IExecute<Org.Apache.Kafka.Common.MetricName>("lastAppliedRecordTimestampName"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/metadata/BrokerServerMetrics.html#lastAppliedTimestamp()"/> 
        /// </summary>
        public long LastAppliedTimestamp
        {
            get { return IExecute<long>("lastAppliedTimestamp"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/metadata/BrokerServerMetrics.html#logger()"/> 
        /// </summary>
        public Com.Typesafe.Scalalogging.Logger Logger
        {
            get { return IExecute<Com.Typesafe.Scalalogging.Logger>("logger"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/metadata/BrokerServerMetrics.html#loggerName()"/> 
        /// </summary>
        public string LoggerName
        {
            get { return IExecute<string>("loggerName"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/metadata/BrokerServerMetrics.html#logIdent()"/> 
        /// </summary>
        public string LogIdent
        {
            get { return IExecute<string>("logIdent"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/metadata/BrokerServerMetrics.html#metadataApplyErrorCount()"/> 
        /// </summary>
        public Java.Util.Concurrent.Atomic.AtomicLong MetadataApplyErrorCount
        {
            get { return IExecute<Java.Util.Concurrent.Atomic.AtomicLong>("metadataApplyErrorCount"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/metadata/BrokerServerMetrics.html#metadataApplyErrorCountName()"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.MetricName MetadataApplyErrorCountName
        {
            get { return IExecute<Org.Apache.Kafka.Common.MetricName>("metadataApplyErrorCountName"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/metadata/BrokerServerMetrics.html#metadataLoadErrorCount()"/> 
        /// </summary>
        public Java.Util.Concurrent.Atomic.AtomicLong MetadataLoadErrorCount
        {
            get { return IExecute<Java.Util.Concurrent.Atomic.AtomicLong>("metadataLoadErrorCount"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/metadata/BrokerServerMetrics.html#metadataLoadErrorCountName()"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.MetricName MetadataLoadErrorCountName
        {
            get { return IExecute<Org.Apache.Kafka.Common.MetricName>("metadataLoadErrorCountName"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/metadata/BrokerServerMetrics.html#newMeter(com.yammer.metrics.core.MetricName,java.lang.String,java.util.concurrent.TimeUnit)"/>
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
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/metadata/BrokerServerMetrics.html#msgWithLogIdent(java.lang.String)"/>
        /// </summary>
        /// <param name="msg"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string MsgWithLogIdent(string msg)
        {
            return IExecute<string>("msgWithLogIdent", msg);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/metadata/BrokerServerMetrics.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/metadata/BrokerServerMetrics.html#updateBatchProcessingTime(long)"/>
        /// </summary>
        /// <param name="elapsedNs"><see cref="long"/></param>
        public void UpdateBatchProcessingTime(long elapsedNs)
        {
            IExecute("updateBatchProcessingTime", elapsedNs);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/metadata/BrokerServerMetrics.html#updateBatchSize(int)"/>
        /// </summary>
        /// <param name="size"><see cref="int"/></param>
        public void UpdateBatchSize(int size)
        {
            IExecute("updateBatchSize", size);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/metadata/BrokerServerMetrics.html#updateLastAppliedImageProvenance(org.apache.kafka.image.MetadataProvenance)"/>
        /// </summary>
        /// <param name="provenance"><see cref="Org.Apache.Kafka.Image.MetadataProvenance"/></param>
        public void UpdateLastAppliedImageProvenance(Org.Apache.Kafka.Image.MetadataProvenance provenance)
        {
            IExecute("updateLastAppliedImageProvenance", provenance);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}