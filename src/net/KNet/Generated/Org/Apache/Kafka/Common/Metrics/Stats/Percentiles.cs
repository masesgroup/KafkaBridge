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
*  This file is generated by MASES.JNetReflector (ver. 2.0.0.0)
*  using kafka-clients-3.5.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Metrics.Stats
{
    #region Percentiles
    public partial class Percentiles
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/metrics/stats/Percentiles.html#org.apache.kafka.common.metrics.stats.Percentiles(int,double,double,org.apache.kafka.common.metrics.stats.Percentiles.BucketSizing,org.apache.kafka.common.metrics.stats.Percentile[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Common.Metrics.Stats.Percentiles.BucketSizing"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Common.Metrics.Stats.Percentile"/></param>
        public Percentiles(int arg0, double arg1, double arg2, Org.Apache.Kafka.Common.Metrics.Stats.Percentiles.BucketSizing arg3, params Org.Apache.Kafka.Common.Metrics.Stats.Percentile[] arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/metrics/stats/Percentiles.html#org.apache.kafka.common.metrics.stats.Percentiles(int,double,org.apache.kafka.common.metrics.stats.Percentiles.BucketSizing,org.apache.kafka.common.metrics.stats.Percentile[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Metrics.Stats.Percentiles.BucketSizing"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Common.Metrics.Stats.Percentile"/></param>
        public Percentiles(int arg0, double arg1, Org.Apache.Kafka.Common.Metrics.Stats.Percentiles.BucketSizing arg2, params Org.Apache.Kafka.Common.Metrics.Stats.Percentile[] arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Common.Metrics.Stats.Percentiles"/> to <see cref="Org.Apache.Kafka.Common.Metrics.CompoundStat"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Metrics.CompoundStat(Org.Apache.Kafka.Common.Metrics.Stats.Percentiles t) => t.Cast<Org.Apache.Kafka.Common.Metrics.CompoundStat>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/metrics/stats/Percentiles.html#value-org.apache.kafka.common.metrics.MetricConfig-long-double-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.MetricConfig"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public double Value(Org.Apache.Kafka.Common.Metrics.MetricConfig arg0, long arg1, double arg2)
        {
            return IExecute<double>("value", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/metrics/stats/Percentiles.html#stats--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Org.Apache.Kafka.Common.Metrics.CompoundStat.NamedMeasurable> Stats()
        {
            return IExecute<Java.Util.List<Org.Apache.Kafka.Common.Metrics.CompoundStat.NamedMeasurable>>("stats");
        }

        #endregion

        #region Nested classes
        #region BucketSizing
        public partial class BucketSizing
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/metrics/stats/Percentiles.BucketSizing.html#CONSTANT"/>
            /// </summary>
            public static Org.Apache.Kafka.Common.Metrics.Stats.Percentiles.BucketSizing CONSTANT { get { return SGetField<Org.Apache.Kafka.Common.Metrics.Stats.Percentiles.BucketSizing>(LocalBridgeClazz, "CONSTANT"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/metrics/stats/Percentiles.BucketSizing.html#LINEAR"/>
            /// </summary>
            public static Org.Apache.Kafka.Common.Metrics.Stats.Percentiles.BucketSizing LINEAR { get { return SGetField<Org.Apache.Kafka.Common.Metrics.Stats.Percentiles.BucketSizing>(LocalBridgeClazz, "LINEAR"); } }

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/metrics/stats/Percentiles.BucketSizing.html#valueOf-java.lang.String-"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Common.Metrics.Stats.Percentiles.BucketSizing"/></returns>
            public static Org.Apache.Kafka.Common.Metrics.Stats.Percentiles.BucketSizing ValueOf(string arg0)
            {
                return SExecute<Org.Apache.Kafka.Common.Metrics.Stats.Percentiles.BucketSizing>(LocalBridgeClazz, "valueOf", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/metrics/stats/Percentiles.BucketSizing.html#values--"/>
            /// </summary>

            /// <returns><see cref="Org.Apache.Kafka.Common.Metrics.Stats.Percentiles.BucketSizing"/></returns>
            public static Org.Apache.Kafka.Common.Metrics.Stats.Percentiles.BucketSizing[] Values()
            {
                return SExecuteArray<Org.Apache.Kafka.Common.Metrics.Stats.Percentiles.BucketSizing>(LocalBridgeClazz, "values");
            }

            #endregion

            #region Instance methods

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