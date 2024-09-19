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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using kafka-clients-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Metrics
{
    #region JmxReporter declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/JmxReporter.html"/>
    /// </summary>
    public partial class JmxReporter : MASES.JCOBridge.C2JBridge.JVMBridgeBase<JmxReporter>
    {
        const string _bridgeClassName = "org.apache.kafka.common.metrics.JmxReporter";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public JmxReporter() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public JmxReporter(params object[] args) : base(args) { }

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

    #region JmxReporter implementation
    public partial class JmxReporter
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Common.Metrics.JmxReporter"/> to <see cref="Org.Apache.Kafka.Common.Metrics.MetricsReporter"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Metrics.MetricsReporter(Org.Apache.Kafka.Common.Metrics.JmxReporter t) => t.Cast<Org.Apache.Kafka.Common.Metrics.MetricsReporter>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/JmxReporter.html#DEFAULT_EXCLUDE"/>
        /// </summary>
        public static Java.Lang.String DEFAULT_EXCLUDE { get { if (!_DEFAULT_EXCLUDEReady) { _DEFAULT_EXCLUDEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DEFAULT_EXCLUDE"); _DEFAULT_EXCLUDEReady = true; } return _DEFAULT_EXCLUDEContent; } }
        private static Java.Lang.String _DEFAULT_EXCLUDEContent = default;
        private static bool _DEFAULT_EXCLUDEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/JmxReporter.html#DEFAULT_INCLUDE"/>
        /// </summary>
        public static Java.Lang.String DEFAULT_INCLUDE { get { if (!_DEFAULT_INCLUDEReady) { _DEFAULT_INCLUDEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DEFAULT_INCLUDE"); _DEFAULT_INCLUDEReady = true; } return _DEFAULT_INCLUDEContent; } }
        private static Java.Lang.String _DEFAULT_INCLUDEContent = default;
        private static bool _DEFAULT_INCLUDEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/JmxReporter.html#EXCLUDE_CONFIG"/>
        /// </summary>
        public static Java.Lang.String EXCLUDE_CONFIG { get { if (!_EXCLUDE_CONFIGReady) { _EXCLUDE_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXCLUDE_CONFIG"); _EXCLUDE_CONFIGReady = true; } return _EXCLUDE_CONFIGContent; } }
        private static Java.Lang.String _EXCLUDE_CONFIGContent = default;
        private static bool _EXCLUDE_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/JmxReporter.html#EXCLUDE_CONFIG_ALIAS"/>
        /// </summary>
        public static Java.Lang.String EXCLUDE_CONFIG_ALIAS { get { if (!_EXCLUDE_CONFIG_ALIASReady) { _EXCLUDE_CONFIG_ALIASContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXCLUDE_CONFIG_ALIAS"); _EXCLUDE_CONFIG_ALIASReady = true; } return _EXCLUDE_CONFIG_ALIASContent; } }
        private static Java.Lang.String _EXCLUDE_CONFIG_ALIASContent = default;
        private static bool _EXCLUDE_CONFIG_ALIASReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/JmxReporter.html#INCLUDE_CONFIG"/>
        /// </summary>
        public static Java.Lang.String INCLUDE_CONFIG { get { if (!_INCLUDE_CONFIGReady) { _INCLUDE_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "INCLUDE_CONFIG"); _INCLUDE_CONFIGReady = true; } return _INCLUDE_CONFIGContent; } }
        private static Java.Lang.String _INCLUDE_CONFIGContent = default;
        private static bool _INCLUDE_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/JmxReporter.html#INCLUDE_CONFIG_ALIAS"/>
        /// </summary>
        public static Java.Lang.String INCLUDE_CONFIG_ALIAS { get { if (!_INCLUDE_CONFIG_ALIASReady) { _INCLUDE_CONFIG_ALIASContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "INCLUDE_CONFIG_ALIAS"); _INCLUDE_CONFIG_ALIASReady = true; } return _INCLUDE_CONFIG_ALIASContent; } }
        private static Java.Lang.String _INCLUDE_CONFIG_ALIASContent = default;
        private static bool _INCLUDE_CONFIG_ALIASReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/JmxReporter.html#METRICS_CONFIG_PREFIX"/>
        /// </summary>
        public static Java.Lang.String METRICS_CONFIG_PREFIX { get { if (!_METRICS_CONFIG_PREFIXReady) { _METRICS_CONFIG_PREFIXContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "METRICS_CONFIG_PREFIX"); _METRICS_CONFIG_PREFIXReady = true; } return _METRICS_CONFIG_PREFIXContent; } }
        private static Java.Lang.String _METRICS_CONFIG_PREFIXContent = default;
        private static bool _METRICS_CONFIG_PREFIXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/JmxReporter.html#RECONFIGURABLE_CONFIGS"/>
        /// </summary>
        public static Java.Util.Set RECONFIGURABLE_CONFIGS { get { if (!_RECONFIGURABLE_CONFIGSReady) { _RECONFIGURABLE_CONFIGSContent = SGetField<Java.Util.Set>(LocalBridgeClazz, "RECONFIGURABLE_CONFIGS"); _RECONFIGURABLE_CONFIGSReady = true; } return _RECONFIGURABLE_CONFIGSContent; } }
        private static Java.Util.Set _RECONFIGURABLE_CONFIGSContent = default;
        private static bool _RECONFIGURABLE_CONFIGSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/JmxReporter.html#compilePredicate-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Java.Util.Function.Predicate"/></returns>
        public static Java.Util.Function.Predicate<Java.Lang.String> CompilePredicate(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            return SExecuteWithSignature<Java.Util.Function.Predicate<Java.Lang.String>>(LocalBridgeClazz, "compilePredicate", "(Ljava/util/Map;)Ljava/util/function/Predicate;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/JmxReporter.html#compilePredicate-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Java.Util.Function.Predicate"/></returns>
        public static Java.Util.Function.Predicate<Java.Lang.String> CompilePredicateDirect(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            return SExecuteWithSignature<Java.Util.Function.PredicateDirect<Java.Lang.String>, Java.Util.Function.Predicate<Java.Lang.String>>(LocalBridgeClazz, "compilePredicate", "(Ljava/util/Map;)Ljava/util/function/Predicate;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/JmxReporter.html#containsMbean-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsMbean(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("containsMbean", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/JmxReporter.html#reconfigurableConfigs--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> ReconfigurableConfigs()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("reconfigurableConfigs", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/JmxReporter.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/JmxReporter.html#configure-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public void Configure(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            IExecuteWithSignature("configure", "(Ljava/util/Map;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/JmxReporter.html#contextChange-org.apache.kafka.common.metrics.MetricsContext-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.MetricsContext"/></param>
        public void ContextChange(Org.Apache.Kafka.Common.Metrics.MetricsContext arg0)
        {
            IExecuteWithSignature("contextChange", "(Lorg/apache/kafka/common/metrics/MetricsContext;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/JmxReporter.html#init-java.util.List-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        public void Init(Java.Util.List<Org.Apache.Kafka.Common.Metrics.KafkaMetric> arg0)
        {
            IExecuteWithSignature("init", "(Ljava/util/List;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/JmxReporter.html#metricChange-org.apache.kafka.common.metrics.KafkaMetric-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.KafkaMetric"/></param>
        public void MetricChange(Org.Apache.Kafka.Common.Metrics.KafkaMetric arg0)
        {
            IExecuteWithSignature("metricChange", "(Lorg/apache/kafka/common/metrics/KafkaMetric;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/JmxReporter.html#metricRemoval-org.apache.kafka.common.metrics.KafkaMetric-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.KafkaMetric"/></param>
        public void MetricRemoval(Org.Apache.Kafka.Common.Metrics.KafkaMetric arg0)
        {
            IExecuteWithSignature("metricRemoval", "(Lorg/apache/kafka/common/metrics/KafkaMetric;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/JmxReporter.html#reconfigure-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public void Reconfigure(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            IExecuteWithSignature("reconfigure", "(Ljava/util/Map;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/JmxReporter.html#validateReconfiguration-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <exception cref="Org.Apache.Kafka.Common.Config.ConfigException"/>
        public void ValidateReconfiguration(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            IExecuteWithSignature("validateReconfiguration", "(Ljava/util/Map;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}