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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using kafka-clients-3.9.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Metrics.Stats
{
    #region Meter declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/stats/Meter.html"/>
    /// </summary>
    public partial class Meter : Org.Apache.Kafka.Common.Metrics.CompoundStat
    {
        const string _bridgeClassName = "org.apache.kafka.common.metrics.stats.Meter";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Meter() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Meter(params object[] args) : base(args) { }

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

    #region Meter implementation
    public partial class Meter
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/stats/Meter.html#org.apache.kafka.common.metrics.stats.Meter(java.util.concurrent.TimeUnit,org.apache.kafka.common.MetricName,org.apache.kafka.common.MetricName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.MetricName"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.MetricName"/></param>
        public Meter(Java.Util.Concurrent.TimeUnit arg0, Org.Apache.Kafka.Common.MetricName arg1, Org.Apache.Kafka.Common.MetricName arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/stats/Meter.html#org.apache.kafka.common.metrics.stats.Meter(java.util.concurrent.TimeUnit,org.apache.kafka.common.metrics.stats.SampledStat,org.apache.kafka.common.MetricName,org.apache.kafka.common.MetricName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Metrics.Stats.SampledStat"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.MetricName"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Common.MetricName"/></param>
        public Meter(Java.Util.Concurrent.TimeUnit arg0, Org.Apache.Kafka.Common.Metrics.Stats.SampledStat arg1, Org.Apache.Kafka.Common.MetricName arg2, Org.Apache.Kafka.Common.MetricName arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/stats/Meter.html#org.apache.kafka.common.metrics.stats.Meter(org.apache.kafka.common.MetricName,org.apache.kafka.common.MetricName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.MetricName"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.MetricName"/></param>
        public Meter(Org.Apache.Kafka.Common.MetricName arg0, Org.Apache.Kafka.Common.MetricName arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/stats/Meter.html#org.apache.kafka.common.metrics.stats.Meter(org.apache.kafka.common.metrics.stats.SampledStat,org.apache.kafka.common.MetricName,org.apache.kafka.common.MetricName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.Stats.SampledStat"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.MetricName"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.MetricName"/></param>
        public Meter(Org.Apache.Kafka.Common.Metrics.Stats.SampledStat arg0, Org.Apache.Kafka.Common.MetricName arg1, Org.Apache.Kafka.Common.MetricName arg2)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/stats/Meter.html#stats--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Org.Apache.Kafka.Common.Metrics.CompoundStat.NamedMeasurable> Stats()
        {
            return IExecuteWithSignature<Java.Util.List<Org.Apache.Kafka.Common.Metrics.CompoundStat.NamedMeasurable>>("stats", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/stats/Meter.html#record-org.apache.kafka.common.metrics.MetricConfig-double-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.MetricConfig"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public void Record(Org.Apache.Kafka.Common.Metrics.MetricConfig arg0, double arg1, long arg2)
        {
            IExecuteWithSignature("record", "(Lorg/apache/kafka/common/metrics/MetricConfig;DJ)V", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}