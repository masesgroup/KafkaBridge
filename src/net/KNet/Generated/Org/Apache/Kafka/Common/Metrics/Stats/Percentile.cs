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
    #region Percentile
    public partial class Percentile
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/metrics/stats/Percentile.html#org.apache.kafka.common.metrics.stats.Percentile(org.apache.kafka.common.MetricName,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.MetricName"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        public Percentile(Org.Apache.Kafka.Common.MetricName arg0, double arg1)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/metrics/stats/Percentile.html#percentile--"/>
        /// </summary>

        /// <returns><see cref="double"/></returns>
        public double PercentileMethod()
        {
            return IExecute<double>("percentile");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/metrics/stats/Percentile.html#name--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.MetricName"/></returns>
        public Org.Apache.Kafka.Common.MetricName Name()
        {
            return IExecute<Org.Apache.Kafka.Common.MetricName>("name");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}