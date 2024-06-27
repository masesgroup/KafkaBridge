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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using kafka-clients-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Metrics
{
    #region Metrics
    public partial class Metrics
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/metrics/Metrics.html#org.apache.kafka.common.metrics.Metrics(org.apache.kafka.common.metrics.MetricConfig,java.util.List,org.apache.kafka.common.utils.Time,boolean,org.apache.kafka.common.metrics.MetricsContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.MetricConfig"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Utils.Time"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Common.Metrics.MetricsContext"/></param>
        public Metrics(Org.Apache.Kafka.Common.Metrics.MetricConfig arg0, Java.Util.List<Org.Apache.Kafka.Common.Metrics.MetricsReporter> arg1, Org.Apache.Kafka.Common.Utils.Time arg2, bool arg3, Org.Apache.Kafka.Common.Metrics.MetricsContext arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/metrics/Metrics.html#org.apache.kafka.common.metrics.Metrics(org.apache.kafka.common.metrics.MetricConfig,java.util.List,org.apache.kafka.common.utils.Time,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.MetricConfig"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Utils.Time"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        public Metrics(Org.Apache.Kafka.Common.Metrics.MetricConfig arg0, Java.Util.List<Org.Apache.Kafka.Common.Metrics.MetricsReporter> arg1, Org.Apache.Kafka.Common.Utils.Time arg2, bool arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/metrics/Metrics.html#org.apache.kafka.common.metrics.Metrics(org.apache.kafka.common.metrics.MetricConfig,java.util.List,org.apache.kafka.common.utils.Time,org.apache.kafka.common.metrics.MetricsContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.MetricConfig"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Utils.Time"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Common.Metrics.MetricsContext"/></param>
        public Metrics(Org.Apache.Kafka.Common.Metrics.MetricConfig arg0, Java.Util.List<Org.Apache.Kafka.Common.Metrics.MetricsReporter> arg1, Org.Apache.Kafka.Common.Utils.Time arg2, Org.Apache.Kafka.Common.Metrics.MetricsContext arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/metrics/Metrics.html#org.apache.kafka.common.metrics.Metrics(org.apache.kafka.common.metrics.MetricConfig,java.util.List,org.apache.kafka.common.utils.Time)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.MetricConfig"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Utils.Time"/></param>
        public Metrics(Org.Apache.Kafka.Common.Metrics.MetricConfig arg0, Java.Util.List<Org.Apache.Kafka.Common.Metrics.MetricsReporter> arg1, Org.Apache.Kafka.Common.Utils.Time arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/metrics/Metrics.html#org.apache.kafka.common.metrics.Metrics(org.apache.kafka.common.metrics.MetricConfig,org.apache.kafka.common.utils.Time)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.MetricConfig"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Utils.Time"/></param>
        public Metrics(Org.Apache.Kafka.Common.Metrics.MetricConfig arg0, Org.Apache.Kafka.Common.Utils.Time arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/metrics/Metrics.html#org.apache.kafka.common.metrics.Metrics(org.apache.kafka.common.metrics.MetricConfig)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.MetricConfig"/></param>
        public Metrics(Org.Apache.Kafka.Common.Metrics.MetricConfig arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/metrics/Metrics.html#org.apache.kafka.common.metrics.Metrics(org.apache.kafka.common.utils.Time)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Utils.Time"/></param>
        public Metrics(Org.Apache.Kafka.Common.Utils.Time arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/metrics/Metrics.html#toHtmlTable-java.lang.String-java.lang.Iterable-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Iterable"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ToHtmlTable(Java.Lang.String arg0, Java.Lang.Iterable<Org.Apache.Kafka.Common.MetricNameTemplate> arg1)
        {
            return SExecute<Java.Lang.String>(LocalBridgeClazz, "toHtmlTable", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/metrics/Metrics.html#reporters--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Org.Apache.Kafka.Common.Metrics.MetricsReporter> Reporters()
        {
            return IExecuteWithSignature<Java.Util.List<Org.Apache.Kafka.Common.Metrics.MetricsReporter>>("reporters", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/metrics/Metrics.html#metrics--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Org.Apache.Kafka.Common.MetricName, Org.Apache.Kafka.Common.Metrics.KafkaMetric> MetricsMethod()
        {
            return IExecuteWithSignature<Java.Util.Map<Org.Apache.Kafka.Common.MetricName, Org.Apache.Kafka.Common.Metrics.KafkaMetric>>("metrics", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/metrics/Metrics.html#metricInstance-org.apache.kafka.common.MetricNameTemplate-java.lang.String[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.MetricNameTemplate"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.MetricName"/></returns>
        public Org.Apache.Kafka.Common.MetricName MetricInstance(Org.Apache.Kafka.Common.MetricNameTemplate arg0, params Java.Lang.String[] arg1)
        {
            if (arg1.Length == 0) return IExecute<Org.Apache.Kafka.Common.MetricName>("metricInstance", arg0); else return IExecute<Org.Apache.Kafka.Common.MetricName>("metricInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/metrics/Metrics.html#metricInstance-org.apache.kafka.common.MetricNameTemplate-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.MetricNameTemplate"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.MetricName"/></returns>
        public Org.Apache.Kafka.Common.MetricName MetricInstance(Org.Apache.Kafka.Common.MetricNameTemplate arg0, Java.Util.Map<Java.Lang.String, Java.Lang.String> arg1)
        {
            return IExecute<Org.Apache.Kafka.Common.MetricName>("metricInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/metrics/Metrics.html#metricName-java.lang.String-java.lang.String-java.lang.String-java.lang.String[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.MetricName"/></returns>
        public Org.Apache.Kafka.Common.MetricName MetricName(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, params Java.Lang.String[] arg3)
        {
            if (arg3.Length == 0) return IExecute<Org.Apache.Kafka.Common.MetricName>("metricName", arg0, arg1, arg2); else return IExecute<Org.Apache.Kafka.Common.MetricName>("metricName", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/metrics/Metrics.html#metricName-java.lang.String-java.lang.String-java.lang.String-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.MetricName"/></returns>
        public Org.Apache.Kafka.Common.MetricName MetricName(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Util.Map<Java.Lang.String, Java.Lang.String> arg3)
        {
            return IExecute<Org.Apache.Kafka.Common.MetricName>("metricName", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/metrics/Metrics.html#metricName-java.lang.String-java.lang.String-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.MetricName"/></returns>
        public Org.Apache.Kafka.Common.MetricName MetricName(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            return IExecute<Org.Apache.Kafka.Common.MetricName>("metricName", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/metrics/Metrics.html#metricName-java.lang.String-java.lang.String-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.MetricName"/></returns>
        public Org.Apache.Kafka.Common.MetricName MetricName(Java.Lang.String arg0, Java.Lang.String arg1, Java.Util.Map<Java.Lang.String, Java.Lang.String> arg2)
        {
            return IExecute<Org.Apache.Kafka.Common.MetricName>("metricName", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/metrics/Metrics.html#metricName-java.lang.String-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.MetricName"/></returns>
        public Org.Apache.Kafka.Common.MetricName MetricName(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Org.Apache.Kafka.Common.MetricName>("metricName", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/metrics/Metrics.html#addMetricIfAbsent-org.apache.kafka.common.MetricName-org.apache.kafka.common.metrics.MetricConfig-org.apache.kafka.common.metrics.MetricValueProvider-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.MetricName"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Metrics.MetricConfig"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Metrics.MetricValueProvider"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Metrics.KafkaMetric"/></returns>
        public Org.Apache.Kafka.Common.Metrics.KafkaMetric AddMetricIfAbsent(Org.Apache.Kafka.Common.MetricName arg0, Org.Apache.Kafka.Common.Metrics.MetricConfig arg1, Org.Apache.Kafka.Common.Metrics.MetricValueProvider<object> arg2)
        {
            return IExecute<Org.Apache.Kafka.Common.Metrics.KafkaMetric>("addMetricIfAbsent", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/metrics/Metrics.html#metric-org.apache.kafka.common.MetricName-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.MetricName"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Metrics.KafkaMetric"/></returns>
        public Org.Apache.Kafka.Common.Metrics.KafkaMetric Metric(Org.Apache.Kafka.Common.MetricName arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Metrics.KafkaMetric>("metric", "(Lorg/apache/kafka/common/MetricName;)Lorg/apache/kafka/common/metrics/KafkaMetric;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/metrics/Metrics.html#config--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Metrics.MetricConfig"/></returns>
        public Org.Apache.Kafka.Common.Metrics.MetricConfig Config()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Metrics.MetricConfig>("config", "()Lorg/apache/kafka/common/metrics/MetricConfig;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/metrics/Metrics.html#getSensor-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Metrics.Sensor"/></returns>
        public Org.Apache.Kafka.Common.Metrics.Sensor GetSensor(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Metrics.Sensor>("getSensor", "(Ljava/lang/String;)Lorg/apache/kafka/common/metrics/Sensor;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/metrics/Metrics.html#sensor-java.lang.String-org.apache.kafka.common.metrics.Sensor[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Metrics.Sensor"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Metrics.Sensor"/></returns>
        public Org.Apache.Kafka.Common.Metrics.Sensor Sensor(Java.Lang.String arg0, params Org.Apache.Kafka.Common.Metrics.Sensor[] arg1)
        {
            if (arg1.Length == 0) return IExecute<Org.Apache.Kafka.Common.Metrics.Sensor>("sensor", arg0); else return IExecute<Org.Apache.Kafka.Common.Metrics.Sensor>("sensor", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/metrics/Metrics.html#sensor-java.lang.String-org.apache.kafka.common.metrics.Sensor.RecordingLevel-org.apache.kafka.common.metrics.Sensor[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Metrics.Sensor.RecordingLevel"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Metrics.Sensor"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Metrics.Sensor"/></returns>
        public Org.Apache.Kafka.Common.Metrics.Sensor Sensor(Java.Lang.String arg0, Org.Apache.Kafka.Common.Metrics.Sensor.RecordingLevel arg1, params Org.Apache.Kafka.Common.Metrics.Sensor[] arg2)
        {
            if (arg2.Length == 0) return IExecute<Org.Apache.Kafka.Common.Metrics.Sensor>("sensor", arg0, arg1); else return IExecute<Org.Apache.Kafka.Common.Metrics.Sensor>("sensor", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/metrics/Metrics.html#sensor-java.lang.String-org.apache.kafka.common.metrics.Sensor.RecordingLevel-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Metrics.Sensor.RecordingLevel"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Metrics.Sensor"/></returns>
        public Org.Apache.Kafka.Common.Metrics.Sensor Sensor(Java.Lang.String arg0, Org.Apache.Kafka.Common.Metrics.Sensor.RecordingLevel arg1)
        {
            return IExecute<Org.Apache.Kafka.Common.Metrics.Sensor>("sensor", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/metrics/Metrics.html#sensor-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Metrics.Sensor"/></returns>
        public Org.Apache.Kafka.Common.Metrics.Sensor Sensor(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Metrics.Sensor>("sensor", "(Ljava/lang/String;)Lorg/apache/kafka/common/metrics/Sensor;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/metrics/Metrics.html#removeMetric-org.apache.kafka.common.MetricName-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.MetricName"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Metrics.KafkaMetric"/></returns>
        public Org.Apache.Kafka.Common.Metrics.KafkaMetric RemoveMetric(Org.Apache.Kafka.Common.MetricName arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Metrics.KafkaMetric>("removeMetric", "(Lorg/apache/kafka/common/MetricName;)Lorg/apache/kafka/common/metrics/KafkaMetric;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/metrics/Metrics.html#sensor-java.lang.String-org.apache.kafka.common.metrics.MetricConfig-long-org.apache.kafka.common.metrics.Sensor[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Metrics.MetricConfig"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Common.Metrics.Sensor"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Metrics.Sensor"/></returns>
        public Org.Apache.Kafka.Common.Metrics.Sensor Sensor(Java.Lang.String arg0, Org.Apache.Kafka.Common.Metrics.MetricConfig arg1, long arg2, params Org.Apache.Kafka.Common.Metrics.Sensor[] arg3)
        {
            if (arg3.Length == 0) return IExecute<Org.Apache.Kafka.Common.Metrics.Sensor>("sensor", arg0, arg1, arg2); else return IExecute<Org.Apache.Kafka.Common.Metrics.Sensor>("sensor", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/metrics/Metrics.html#sensor-java.lang.String-org.apache.kafka.common.metrics.MetricConfig-long-org.apache.kafka.common.metrics.Sensor.RecordingLevel-org.apache.kafka.common.metrics.Sensor[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Metrics.MetricConfig"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Common.Metrics.Sensor.RecordingLevel"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Common.Metrics.Sensor"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Metrics.Sensor"/></returns>
        public Org.Apache.Kafka.Common.Metrics.Sensor Sensor(Java.Lang.String arg0, Org.Apache.Kafka.Common.Metrics.MetricConfig arg1, long arg2, Org.Apache.Kafka.Common.Metrics.Sensor.RecordingLevel arg3, params Org.Apache.Kafka.Common.Metrics.Sensor[] arg4)
        {
            if (arg4.Length == 0) return IExecute<Org.Apache.Kafka.Common.Metrics.Sensor>("sensor", arg0, arg1, arg2, arg3); else return IExecute<Org.Apache.Kafka.Common.Metrics.Sensor>("sensor", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/metrics/Metrics.html#sensor-java.lang.String-org.apache.kafka.common.metrics.MetricConfig-org.apache.kafka.common.metrics.Sensor[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Metrics.MetricConfig"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Metrics.Sensor"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Metrics.Sensor"/></returns>
        public Org.Apache.Kafka.Common.Metrics.Sensor Sensor(Java.Lang.String arg0, Org.Apache.Kafka.Common.Metrics.MetricConfig arg1, params Org.Apache.Kafka.Common.Metrics.Sensor[] arg2)
        {
            if (arg2.Length == 0) return IExecute<Org.Apache.Kafka.Common.Metrics.Sensor>("sensor", arg0, arg1); else return IExecute<Org.Apache.Kafka.Common.Metrics.Sensor>("sensor", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/metrics/Metrics.html#sensor-java.lang.String-org.apache.kafka.common.metrics.MetricConfig-org.apache.kafka.common.metrics.Sensor.RecordingLevel-org.apache.kafka.common.metrics.Sensor[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Metrics.MetricConfig"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Metrics.Sensor.RecordingLevel"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Common.Metrics.Sensor"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Metrics.Sensor"/></returns>
        public Org.Apache.Kafka.Common.Metrics.Sensor Sensor(Java.Lang.String arg0, Org.Apache.Kafka.Common.Metrics.MetricConfig arg1, Org.Apache.Kafka.Common.Metrics.Sensor.RecordingLevel arg2, params Org.Apache.Kafka.Common.Metrics.Sensor[] arg3)
        {
            if (arg3.Length == 0) return IExecute<Org.Apache.Kafka.Common.Metrics.Sensor>("sensor", arg0, arg1, arg2); else return IExecute<Org.Apache.Kafka.Common.Metrics.Sensor>("sensor", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/metrics/Metrics.html#addReporter-org.apache.kafka.common.metrics.MetricsReporter-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.MetricsReporter"/></param>
        public void AddReporter(Org.Apache.Kafka.Common.Metrics.MetricsReporter arg0)
        {
            IExecuteWithSignature("addReporter", "(Lorg/apache/kafka/common/metrics/MetricsReporter;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/metrics/Metrics.html#removeReporter-org.apache.kafka.common.metrics.MetricsReporter-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.MetricsReporter"/></param>
        public void RemoveReporter(Org.Apache.Kafka.Common.Metrics.MetricsReporter arg0)
        {
            IExecuteWithSignature("removeReporter", "(Lorg/apache/kafka/common/metrics/MetricsReporter;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/metrics/Metrics.html#addMetric-org.apache.kafka.common.MetricName-org.apache.kafka.common.metrics.Measurable-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.MetricName"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Metrics.Measurable"/></param>
        public void AddMetric(Org.Apache.Kafka.Common.MetricName arg0, Org.Apache.Kafka.Common.Metrics.Measurable arg1)
        {
            IExecute("addMetric", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/metrics/Metrics.html#addMetric-org.apache.kafka.common.MetricName-org.apache.kafka.common.metrics.MetricConfig-org.apache.kafka.common.metrics.Measurable-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.MetricName"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Metrics.MetricConfig"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Metrics.Measurable"/></param>
        public void AddMetric(Org.Apache.Kafka.Common.MetricName arg0, Org.Apache.Kafka.Common.Metrics.MetricConfig arg1, Org.Apache.Kafka.Common.Metrics.Measurable arg2)
        {
            IExecute("addMetric", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/metrics/Metrics.html#addMetric-org.apache.kafka.common.MetricName-org.apache.kafka.common.metrics.MetricConfig-org.apache.kafka.common.metrics.MetricValueProvider-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.MetricName"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Metrics.MetricConfig"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Metrics.MetricValueProvider"/></param>
        public void AddMetric(Org.Apache.Kafka.Common.MetricName arg0, Org.Apache.Kafka.Common.Metrics.MetricConfig arg1, Org.Apache.Kafka.Common.Metrics.MetricValueProvider<object> arg2)
        {
            IExecute("addMetric", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/metrics/Metrics.html#addMetric-org.apache.kafka.common.MetricName-org.apache.kafka.common.metrics.MetricValueProvider-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.MetricName"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Metrics.MetricValueProvider"/></param>
        public void AddMetric(Org.Apache.Kafka.Common.MetricName arg0, Org.Apache.Kafka.Common.Metrics.MetricValueProvider<object> arg1)
        {
            IExecute("addMetric", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/metrics/Metrics.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/metrics/Metrics.html#removeSensor-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void RemoveSensor(Java.Lang.String arg0)
        {
            IExecuteWithSignature("removeSensor", "(Ljava/lang/String;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}