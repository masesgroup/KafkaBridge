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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using kafka-clients-3.5.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Metrics.Stats
{
    #region Histogram
    public partial class Histogram
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/metrics/stats/Histogram.html#org.apache.kafka.common.metrics.stats.Histogram(org.apache.kafka.common.metrics.stats.Histogram.BinScheme)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.Stats.Histogram.BinScheme"/></param>
        public Histogram(Org.Apache.Kafka.Common.Metrics.Stats.Histogram.BinScheme arg0)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/metrics/stats/Histogram.html#value-double-"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public double Value(double arg0)
        {
            return IExecute<double>("value", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/metrics/stats/Histogram.html#counts--"/>
        /// </summary>

        /// <returns><see cref="float"/></returns>
        public float[] Counts()
        {
            return IExecuteArray<float>("counts");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/metrics/stats/Histogram.html#clear--"/>
        /// </summary>
        public void Clear()
        {
            IExecute("clear");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/metrics/stats/Histogram.html#record-double-"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        public void Record(double arg0)
        {
            IExecute("record", arg0);
        }

        #endregion

        #region Nested classes
        #region BinScheme
        public partial class BinScheme
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
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/metrics/stats/Histogram.BinScheme.html#fromBin-int-"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="double"/></returns>
            public double FromBin(int arg0)
            {
                return IExecute<double>("fromBin", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/metrics/stats/Histogram.BinScheme.html#bins--"/>
            /// </summary>

            /// <returns><see cref="int"/></returns>
            public int Bins()
            {
                return IExecute<int>("bins");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/metrics/stats/Histogram.BinScheme.html#toBin-double-"/>
            /// </summary>
            /// <param name="arg0"><see cref="double"/></param>
            /// <returns><see cref="int"/></returns>
            public int ToBin(double arg0)
            {
                return IExecute<int>("toBin", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ConstantBinScheme
        public partial class ConstantBinScheme
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/metrics/stats/Histogram.ConstantBinScheme.html#org.apache.kafka.common.metrics.stats.Histogram$ConstantBinScheme(int,double,double)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="double"/></param>
            /// <param name="arg2"><see cref="double"/></param>
            public ConstantBinScheme(int arg0, double arg1, double arg2)
                : base(arg0, arg1, arg2)
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/metrics/stats/Histogram.ConstantBinScheme.html#fromBin-int-"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="double"/></returns>
            public double FromBin(int arg0)
            {
                return IExecute<double>("fromBin", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/metrics/stats/Histogram.ConstantBinScheme.html#bins--"/>
            /// </summary>

            /// <returns><see cref="int"/></returns>
            public int Bins()
            {
                return IExecute<int>("bins");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/metrics/stats/Histogram.ConstantBinScheme.html#toBin-double-"/>
            /// </summary>
            /// <param name="arg0"><see cref="double"/></param>
            /// <returns><see cref="int"/></returns>
            public int ToBin(double arg0)
            {
                return IExecute<int>("toBin", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region LinearBinScheme
        public partial class LinearBinScheme
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/metrics/stats/Histogram.LinearBinScheme.html#org.apache.kafka.common.metrics.stats.Histogram$LinearBinScheme(int,double)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="double"/></param>
            public LinearBinScheme(int arg0, double arg1)
                : base(arg0, arg1)
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/metrics/stats/Histogram.LinearBinScheme.html#fromBin-int-"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="double"/></returns>
            public double FromBin(int arg0)
            {
                return IExecute<double>("fromBin", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/metrics/stats/Histogram.LinearBinScheme.html#bins--"/>
            /// </summary>

            /// <returns><see cref="int"/></returns>
            public int Bins()
            {
                return IExecute<int>("bins");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/metrics/stats/Histogram.LinearBinScheme.html#toBin-double-"/>
            /// </summary>
            /// <param name="arg0"><see cref="double"/></param>
            /// <returns><see cref="int"/></returns>
            public int ToBin(double arg0)
            {
                return IExecute<int>("toBin", arg0);
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