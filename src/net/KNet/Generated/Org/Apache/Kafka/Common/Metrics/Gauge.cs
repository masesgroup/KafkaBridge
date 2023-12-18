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
*  This file is generated by MASES.JNetReflector (ver. 2.1.1.0)
*  using kafka-clients-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Metrics
{
    #region Gauge
    public partial class Gauge
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/metrics/Gauge.html#value-org.apache.kafka.common.metrics.MetricConfig-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.MetricConfig"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="object"/></returns>
        public object Value(Org.Apache.Kafka.Common.Metrics.MetricConfig arg0, long arg1)
        {
            return IExecute("value", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IGauge<T>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IGauge<T> : Org.Apache.Kafka.Common.Metrics.IMetricValueProvider<T>
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Gauge<T>
    public partial class Gauge<T> : Org.Apache.Kafka.Common.Metrics.IGauge<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Common.Metrics.Gauge{T}"/> to <see cref="Org.Apache.Kafka.Common.Metrics.Gauge"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Metrics.Gauge(Org.Apache.Kafka.Common.Metrics.Gauge<T> t) => t.Cast<Org.Apache.Kafka.Common.Metrics.Gauge>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/metrics/Gauge.html#value-org.apache.kafka.common.metrics.MetricConfig-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.MetricConfig"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><typeparamref name="T"/></returns>
        public T Value(Org.Apache.Kafka.Common.Metrics.MetricConfig arg0, long arg1)
        {
            return IExecute<T>("value", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}