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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using kafka-clients-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Metrics
{
    #region ICompoundStat
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ICompoundStat : Org.Apache.Kafka.Common.Metrics.IStat
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region CompoundStat
    public partial class CompoundStat : Org.Apache.Kafka.Common.Metrics.ICompoundStat
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/CompoundStat.html#stats--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Org.Apache.Kafka.Common.Metrics.CompoundStat.NamedMeasurable> Stats()
        {
            return IExecuteWithSignature<Java.Util.List<Org.Apache.Kafka.Common.Metrics.CompoundStat.NamedMeasurable>>("stats", "()Ljava/util/List;");
        }

        #endregion

        #region Nested classes
        #region NamedMeasurable
        public partial class NamedMeasurable
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/CompoundStat.NamedMeasurable.html#org.apache.kafka.common.metrics.CompoundStat$NamedMeasurable(org.apache.kafka.common.MetricName,org.apache.kafka.common.metrics.Measurable)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.MetricName"/></param>
            /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Metrics.Measurable"/></param>
            public NamedMeasurable(Org.Apache.Kafka.Common.MetricName arg0, Org.Apache.Kafka.Common.Metrics.Measurable arg1)
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/CompoundStat.NamedMeasurable.html#name--"/>
            /// </summary>
            /// <returns><see cref="Org.Apache.Kafka.Common.MetricName"/></returns>
            public Org.Apache.Kafka.Common.MetricName Name()
            {
                return IExecuteWithSignature<Org.Apache.Kafka.Common.MetricName>("name", "()Lorg/apache/kafka/common/MetricName;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/CompoundStat.NamedMeasurable.html#stat--"/>
            /// </summary>
            /// <returns><see cref="Org.Apache.Kafka.Common.Metrics.Measurable"/></returns>
            public Org.Apache.Kafka.Common.Metrics.Measurable Stat()
            {
                return IExecuteWithSignature<Org.Apache.Kafka.Common.Metrics.Measurable>("stat", "()Lorg/apache/kafka/common/metrics/Measurable;");
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