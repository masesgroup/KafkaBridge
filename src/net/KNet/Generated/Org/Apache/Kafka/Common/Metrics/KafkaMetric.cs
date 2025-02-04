/*
*  Copyright 2025 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.5.12.0)
*  using kafka-clients-3.9.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Metrics
{
    #region KafkaMetric declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/KafkaMetric.html"/>
    /// </summary>
    public partial class KafkaMetric : Org.Apache.Kafka.Common.Metric
    {
        const string _bridgeClassName = "org.apache.kafka.common.metrics.KafkaMetric";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public KafkaMetric() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public KafkaMetric(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region KafkaMetric implementation
    public partial class KafkaMetric
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/KafkaMetric.html#org.apache.kafka.common.metrics.KafkaMetric(java.lang.Object,org.apache.kafka.common.MetricName,org.apache.kafka.common.metrics.MetricValueProvider,org.apache.kafka.common.metrics.MetricConfig,org.apache.kafka.common.utils.Time)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.MetricName"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Metrics.MetricValueProvider"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Common.Metrics.MetricConfig"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Common.Utils.Time"/></param>
        public KafkaMetric(object arg0, Org.Apache.Kafka.Common.MetricName arg1, Org.Apache.Kafka.Common.Metrics.MetricValueProvider<object> arg2, Org.Apache.Kafka.Common.Metrics.MetricConfig arg3, Org.Apache.Kafka.Common.Utils.Time arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/KafkaMetric.html#isMeasurable--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsMeasurable()
        {
            return IExecuteWithSignature<bool>("isMeasurable", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/KafkaMetric.html#metricValue--"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object MetricValue()
        {
            return IExecuteWithSignature("metricValue", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/KafkaMetric.html#metricName--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.MetricName"/></returns>
        public Org.Apache.Kafka.Common.MetricName MetricName()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.MetricName>("metricName", "()Lorg/apache/kafka/common/MetricName;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/KafkaMetric.html#measurable--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Metrics.Measurable"/></returns>
        public Org.Apache.Kafka.Common.Metrics.Measurable Measurable()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Metrics.Measurable>("measurable", "()Lorg/apache/kafka/common/metrics/Measurable;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/KafkaMetric.html#config--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Metrics.MetricConfig"/></returns>
        public Org.Apache.Kafka.Common.Metrics.MetricConfig Config()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Metrics.MetricConfig>("config", "()Lorg/apache/kafka/common/metrics/MetricConfig;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/KafkaMetric.html#config-org.apache.kafka.common.metrics.MetricConfig-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.MetricConfig"/></param>
        public void Config(Org.Apache.Kafka.Common.Metrics.MetricConfig arg0)
        {
            IExecuteWithSignature("config", "(Lorg/apache/kafka/common/metrics/MetricConfig;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}