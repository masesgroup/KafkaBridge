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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using kafka-tools-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Tools
{
    #region PushHttpMetricsReporter
    public partial class PushHttpMetricsReporter
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Tools.PushHttpMetricsReporter"/> to <see cref="Org.Apache.Kafka.Common.Metrics.MetricsReporter"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Metrics.MetricsReporter(Org.Apache.Kafka.Tools.PushHttpMetricsReporter t) => t.Cast<Org.Apache.Kafka.Common.Metrics.MetricsReporter>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/PushHttpMetricsReporter.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/PushHttpMetricsReporter.html#configure-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public void Configure(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            IExecuteWithSignature("configure", "(Ljava/util/Map;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/PushHttpMetricsReporter.html#init-java.util.List-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        public void Init(Java.Util.List<Org.Apache.Kafka.Common.Metrics.KafkaMetric> arg0)
        {
            IExecuteWithSignature("init", "(Ljava/util/List;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/PushHttpMetricsReporter.html#metricChange-org.apache.kafka.common.metrics.KafkaMetric-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.KafkaMetric"/></param>
        public void MetricChange(Org.Apache.Kafka.Common.Metrics.KafkaMetric arg0)
        {
            IExecuteWithSignature("metricChange", "(Lorg/apache/kafka/common/metrics/KafkaMetric;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/PushHttpMetricsReporter.html#metricRemoval-org.apache.kafka.common.metrics.KafkaMetric-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.KafkaMetric"/></param>
        public void MetricRemoval(Org.Apache.Kafka.Common.Metrics.KafkaMetric arg0)
        {
            IExecuteWithSignature("metricRemoval", "(Lorg/apache/kafka/common/metrics/KafkaMetric;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}