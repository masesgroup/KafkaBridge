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
    #region MetricConfig declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricConfig.html"/>
    /// </summary>
    public partial class MetricConfig : MASES.JCOBridge.C2JBridge.JVMBridgeBase<MetricConfig>
    {
        const string _bridgeClassName = "org.apache.kafka.common.metrics.MetricConfig";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public MetricConfig() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public MetricConfig(params object[] args) : base(args) { }

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

    #region MetricConfig implementation
    public partial class MetricConfig
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricConfig.html#DEFAULT_NUM_SAMPLES"/>
        /// </summary>
        public static int DEFAULT_NUM_SAMPLES { get { if (!_DEFAULT_NUM_SAMPLESReady) { _DEFAULT_NUM_SAMPLESContent = SGetField<int>(LocalBridgeClazz, "DEFAULT_NUM_SAMPLES"); _DEFAULT_NUM_SAMPLESReady = true; } return _DEFAULT_NUM_SAMPLESContent; } }
        private static int _DEFAULT_NUM_SAMPLESContent = default;
        private static bool _DEFAULT_NUM_SAMPLESReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricConfig.html#samples--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Samples()
        {
            return IExecuteWithSignature<int>("samples", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricConfig.html#tags--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, Java.Lang.String> Tags()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Lang.String>>("tags", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricConfig.html#eventWindow--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long EventWindow()
        {
            return IExecuteWithSignature<long>("eventWindow", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricConfig.html#timeWindowMs--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long TimeWindowMs()
        {
            return IExecuteWithSignature<long>("timeWindowMs", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricConfig.html#eventWindow-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Metrics.MetricConfig"/></returns>
        public Org.Apache.Kafka.Common.Metrics.MetricConfig EventWindow(long arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Metrics.MetricConfig>("eventWindow", "(J)Lorg/apache/kafka/common/metrics/MetricConfig;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricConfig.html#quota-org.apache.kafka.common.metrics.Quota-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.Quota"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Metrics.MetricConfig"/></returns>
        public Org.Apache.Kafka.Common.Metrics.MetricConfig Quota(Org.Apache.Kafka.Common.Metrics.Quota arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Metrics.MetricConfig>("quota", "(Lorg/apache/kafka/common/metrics/Quota;)Lorg/apache/kafka/common/metrics/MetricConfig;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricConfig.html#recordLevel-org.apache.kafka.common.metrics.Sensor.RecordingLevel-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.Sensor.RecordingLevel"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Metrics.MetricConfig"/></returns>
        public Org.Apache.Kafka.Common.Metrics.MetricConfig RecordLevel(Org.Apache.Kafka.Common.Metrics.Sensor.RecordingLevel arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Metrics.MetricConfig>("recordLevel", "(Lorg/apache/kafka/common/metrics/Sensor$RecordingLevel;)Lorg/apache/kafka/common/metrics/MetricConfig;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricConfig.html#samples-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Metrics.MetricConfig"/></returns>
        public Org.Apache.Kafka.Common.Metrics.MetricConfig Samples(int arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Metrics.MetricConfig>("samples", "(I)Lorg/apache/kafka/common/metrics/MetricConfig;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricConfig.html#tags-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Metrics.MetricConfig"/></returns>
        public Org.Apache.Kafka.Common.Metrics.MetricConfig Tags(Java.Util.Map<Java.Lang.String, Java.Lang.String> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Metrics.MetricConfig>("tags", "(Ljava/util/Map;)Lorg/apache/kafka/common/metrics/MetricConfig;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricConfig.html#timeWindow-long-java.util.concurrent.TimeUnit-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Metrics.MetricConfig"/></returns>
        public Org.Apache.Kafka.Common.Metrics.MetricConfig TimeWindow(long arg0, Java.Util.Concurrent.TimeUnit arg1)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Metrics.MetricConfig>("timeWindow", "(JLjava/util/concurrent/TimeUnit;)Lorg/apache/kafka/common/metrics/MetricConfig;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricConfig.html#quota--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Metrics.Quota"/></returns>
        public Org.Apache.Kafka.Common.Metrics.Quota Quota()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Metrics.Quota>("quota", "()Lorg/apache/kafka/common/metrics/Quota;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricConfig.html#recordLevel--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Metrics.Sensor.RecordingLevel"/></returns>
        public Org.Apache.Kafka.Common.Metrics.Sensor.RecordingLevel RecordLevel()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Metrics.Sensor.RecordingLevel>("recordLevel", "()Lorg/apache/kafka/common/metrics/Sensor$RecordingLevel;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}