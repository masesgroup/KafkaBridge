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
*  using kafka-clients-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Metrics.Stats
{
    #region Rate
    public partial class Rate
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/stats/Rate.html#org.apache.kafka.common.metrics.stats.Rate(java.util.concurrent.TimeUnit,org.apache.kafka.common.metrics.stats.SampledStat)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Metrics.Stats.SampledStat"/></param>
        public Rate(Java.Util.Concurrent.TimeUnit arg0, Org.Apache.Kafka.Common.Metrics.Stats.SampledStat arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/stats/Rate.html#org.apache.kafka.common.metrics.stats.Rate(java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        public Rate(Java.Util.Concurrent.TimeUnit arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/stats/Rate.html#org.apache.kafka.common.metrics.stats.Rate(org.apache.kafka.common.metrics.stats.SampledStat)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.Stats.SampledStat"/></param>
        public Rate(Org.Apache.Kafka.Common.Metrics.Stats.SampledStat arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/stats/Rate.html#measure-org.apache.kafka.common.metrics.MetricConfig-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.MetricConfig"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="double"/></returns>
        public double Measure(Org.Apache.Kafka.Common.Metrics.MetricConfig arg0, long arg1)
        {
            return IExecute<double>("measure", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/stats/Rate.html#unitName--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String UnitName()
        {
            return IExecuteWithSignature<Java.Lang.String>("unitName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/stats/Rate.html#windowSize-org.apache.kafka.common.metrics.MetricConfig-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.MetricConfig"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long WindowSize(Org.Apache.Kafka.Common.Metrics.MetricConfig arg0, long arg1)
        {
            return IExecute<long>("windowSize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/stats/Rate.html#record-org.apache.kafka.common.metrics.MetricConfig-double-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.MetricConfig"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public void Record(Org.Apache.Kafka.Common.Metrics.MetricConfig arg0, double arg1, long arg2)
        {
            IExecute("record", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}