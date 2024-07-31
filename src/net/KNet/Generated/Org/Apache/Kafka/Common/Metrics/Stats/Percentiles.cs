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
    #region Percentiles
    public partial class Percentiles
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/stats/Percentiles.html#org.apache.kafka.common.metrics.stats.Percentiles(int,double,double,org.apache.kafka.common.metrics.stats.Percentiles.BucketSizing,org.apache.kafka.common.metrics.stats.Percentile[])"/>
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/stats/Percentiles.html#org.apache.kafka.common.metrics.stats.Percentiles(int,double,org.apache.kafka.common.metrics.stats.Percentiles.BucketSizing,org.apache.kafka.common.metrics.stats.Percentile[])"/>
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/stats/Percentiles.html#value-org.apache.kafka.common.metrics.MetricConfig-long-double-"/>
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/stats/Percentiles.html#stats--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Org.Apache.Kafka.Common.Metrics.CompoundStat.NamedMeasurable> Stats()
        {
            return IExecuteWithSignature<Java.Util.List<Org.Apache.Kafka.Common.Metrics.CompoundStat.NamedMeasurable>>("stats", "()Ljava/util/List;");
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/stats/Percentiles.BucketSizing.html#CONSTANT"/>
            /// </summary>
            public static Org.Apache.Kafka.Common.Metrics.Stats.Percentiles.BucketSizing CONSTANT { get { if (!_CONSTANTReady) { _CONSTANTContent = SGetField<Org.Apache.Kafka.Common.Metrics.Stats.Percentiles.BucketSizing>(LocalBridgeClazz, "CONSTANT"); _CONSTANTReady = true; } return _CONSTANTContent; } }
            private static Org.Apache.Kafka.Common.Metrics.Stats.Percentiles.BucketSizing _CONSTANTContent = default;
            private static bool _CONSTANTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/stats/Percentiles.BucketSizing.html#LINEAR"/>
            /// </summary>
            public static Org.Apache.Kafka.Common.Metrics.Stats.Percentiles.BucketSizing LINEAR { get { if (!_LINEARReady) { _LINEARContent = SGetField<Org.Apache.Kafka.Common.Metrics.Stats.Percentiles.BucketSizing>(LocalBridgeClazz, "LINEAR"); _LINEARReady = true; } return _LINEARContent; } }
            private static Org.Apache.Kafka.Common.Metrics.Stats.Percentiles.BucketSizing _LINEARContent = default;
            private static bool _LINEARReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/stats/Percentiles.BucketSizing.html#valueOf-java.lang.String-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Common.Metrics.Stats.Percentiles.BucketSizing"/></returns>
            public static Org.Apache.Kafka.Common.Metrics.Stats.Percentiles.BucketSizing ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Org.Apache.Kafka.Common.Metrics.Stats.Percentiles.BucketSizing>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/common/metrics/stats/Percentiles$BucketSizing;", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/stats/Percentiles.BucketSizing.html#values--"/>
            /// </summary>
            /// <returns><see cref="Org.Apache.Kafka.Common.Metrics.Stats.Percentiles.BucketSizing"/></returns>
            public static Org.Apache.Kafka.Common.Metrics.Stats.Percentiles.BucketSizing[] Values()
            {
                return SExecuteWithSignatureArray<Org.Apache.Kafka.Common.Metrics.Stats.Percentiles.BucketSizing>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/common/metrics/stats/Percentiles$BucketSizing;");
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