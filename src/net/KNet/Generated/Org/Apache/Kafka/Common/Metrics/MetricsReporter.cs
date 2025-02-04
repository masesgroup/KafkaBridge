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
    #region MetricsReporter declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricsReporter.html"/>
    /// </summary>
    public partial class MetricsReporter : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public MetricsReporter() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.knet.generated.org.apache.kafka.common.metrics.MetricsReporter";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region MetricsReporterDirect declaration
    /// <summary>
    /// Direct override of <see cref="MetricsReporter"/> or its generic type if there is one
    /// </summary>
    public partial class MetricsReporterDirect : MetricsReporter
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "org.apache.kafka.common.metrics.MetricsReporter";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    }
    #endregion

    #region IMetricsReporter
    /// <summary>
    /// .NET interface for org.mases.knet.generated.org.apache.kafka.common.metrics.MetricsReporter implementing <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricsReporter.html"/>
    /// </summary>
    public partial interface IMetricsReporter
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region MetricsReporter implementation
    public partial class MetricsReporter : Org.Apache.Kafka.Common.Metrics.IMetricsReporter, Org.Apache.Kafka.Common.IReconfigurable, Java.Lang.IAutoCloseable
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
        /// Handlers initializer for <see cref="MetricsReporter"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("configure", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ConfigureEventHandler));
            AddEventHandler("close", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(CloseEventHandler));
            AddEventHandler("init", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(InitEventHandler));
            AddEventHandler("metricChange", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(MetricChangeEventHandler));
            AddEventHandler("metricRemoval", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(MetricRemovalEventHandler));
            AddEventHandler("reconfigurableConfigs", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ReconfigurableConfigsEventHandler));
            AddEventHandler("contextChange", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ContextChangeEventHandler));
            AddEventHandler("reconfigure", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ReconfigureEventHandler));
            AddEventHandler("validateReconfiguration", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ValidateReconfigurationEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/Configurable.html#configure-java.util.Map-"/>
        /// </summary>
        /// <remarks>If <see cref="OnConfigure"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Util.Map<Java.Lang.String, object>> OnConfigure { get; set; } = null;

        bool hasOverrideConfigure = true;
        void ConfigureEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideConfigure = true;
            var methodToExecute = (OnConfigure != null) ? OnConfigure : Configure;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Util.Map<Java.Lang.String, object>>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideConfigure;
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/Configurable.html#configure-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public virtual void Configure(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            hasOverrideConfigure = false;
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricsReporter.html#close--"/>
        /// </summary>
        /// <remarks>If <see cref="OnClose"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action OnClose { get; set; } = null;

        bool hasOverrideClose = true;
        void CloseEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideClose = true;
            var methodToExecute = (OnClose != null) ? OnClose : Close;
            methodToExecute.Invoke();
            data.EventData.TypedEventData.HasOverride = hasOverrideClose;
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricsReporter.html#close--"/>
        /// </summary>
        public virtual void Close()
        {
            hasOverrideClose = false;
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricsReporter.html#init-java.util.List-"/>
        /// </summary>
        /// <remarks>If <see cref="OnInit"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Util.List<Org.Apache.Kafka.Common.Metrics.KafkaMetric>> OnInit { get; set; } = null;

        bool hasOverrideInit = true;
        void InitEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideInit = true;
            var methodToExecute = (OnInit != null) ? OnInit : Init;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Util.List<Org.Apache.Kafka.Common.Metrics.KafkaMetric>>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideInit;
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricsReporter.html#init-java.util.List-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        public virtual void Init(Java.Util.List<Org.Apache.Kafka.Common.Metrics.KafkaMetric> arg0)
        {
            hasOverrideInit = false;
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricsReporter.html#metricChange-org.apache.kafka.common.metrics.KafkaMetric-"/>
        /// </summary>
        /// <remarks>If <see cref="OnMetricChange"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Org.Apache.Kafka.Common.Metrics.KafkaMetric> OnMetricChange { get; set; } = null;

        bool hasOverrideMetricChange = true;
        void MetricChangeEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideMetricChange = true;
            var methodToExecute = (OnMetricChange != null) ? OnMetricChange : MetricChange;
            methodToExecute.Invoke(data.EventData.GetAt<Org.Apache.Kafka.Common.Metrics.KafkaMetric>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideMetricChange;
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricsReporter.html#metricChange-org.apache.kafka.common.metrics.KafkaMetric-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.KafkaMetric"/></param>
        public virtual void MetricChange(Org.Apache.Kafka.Common.Metrics.KafkaMetric arg0)
        {
            hasOverrideMetricChange = false;
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricsReporter.html#metricRemoval-org.apache.kafka.common.metrics.KafkaMetric-"/>
        /// </summary>
        /// <remarks>If <see cref="OnMetricRemoval"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Org.Apache.Kafka.Common.Metrics.KafkaMetric> OnMetricRemoval { get; set; } = null;

        bool hasOverrideMetricRemoval = true;
        void MetricRemovalEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideMetricRemoval = true;
            var methodToExecute = (OnMetricRemoval != null) ? OnMetricRemoval : MetricRemoval;
            methodToExecute.Invoke(data.EventData.GetAt<Org.Apache.Kafka.Common.Metrics.KafkaMetric>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideMetricRemoval;
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricsReporter.html#metricRemoval-org.apache.kafka.common.metrics.KafkaMetric-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.KafkaMetric"/></param>
        public virtual void MetricRemoval(Org.Apache.Kafka.Common.Metrics.KafkaMetric arg0)
        {
            hasOverrideMetricRemoval = false;
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricsReporter.html#reconfigurableConfigs--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Set<Java.Lang.String> ReconfigurableConfigsDefault()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("reconfigurableConfigsDefault", "()Ljava/util/Set;");
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricsReporter.html#reconfigurableConfigs--"/>
        /// </summary>
        /// <remarks>If <see cref="OnReconfigurableConfigs"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Set<Java.Lang.String>> OnReconfigurableConfigs { get; set; } = null;

        bool hasOverrideReconfigurableConfigs = true;
        void ReconfigurableConfigsEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideReconfigurableConfigs = true;
            var methodToExecute = (OnReconfigurableConfigs != null) ? OnReconfigurableConfigs : ReconfigurableConfigs;
            var executionResult = methodToExecute.Invoke();
            data.EventData.TypedEventData.SetReturnData(hasOverrideReconfigurableConfigs, executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricsReporter.html#reconfigurableConfigs--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="ReconfigurableConfigsDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Set<Java.Lang.String> ReconfigurableConfigs()
        {
            hasOverrideReconfigurableConfigs = false; return default;
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricsReporter.html#contextChange-org.apache.kafka.common.metrics.MetricsContext-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.MetricsContext"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void ContextChangeDefault(Org.Apache.Kafka.Common.Metrics.MetricsContext arg0)
        {
            IExecuteWithSignature("contextChangeDefault", "(Lorg/apache/kafka/common/metrics/MetricsContext;)V", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricsReporter.html#contextChange-org.apache.kafka.common.metrics.MetricsContext-"/>
        /// </summary>
        /// <remarks>If <see cref="OnContextChange"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Org.Apache.Kafka.Common.Metrics.MetricsContext> OnContextChange { get; set; } = null;

        bool hasOverrideContextChange = true;
        void ContextChangeEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideContextChange = true;
            var methodToExecute = (OnContextChange != null) ? OnContextChange : ContextChange;
            methodToExecute.Invoke(data.EventData.GetAt<Org.Apache.Kafka.Common.Metrics.MetricsContext>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideContextChange;
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricsReporter.html#contextChange-org.apache.kafka.common.metrics.MetricsContext-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.MetricsContext"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="ContextChangeDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void ContextChange(Org.Apache.Kafka.Common.Metrics.MetricsContext arg0)
        {
            hasOverrideContextChange = false;
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricsReporter.html#reconfigure-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void ReconfigureDefault(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            IExecuteWithSignature("reconfigureDefault", "(Ljava/util/Map;)V", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricsReporter.html#reconfigure-java.util.Map-"/>
        /// </summary>
        /// <remarks>If <see cref="OnReconfigure"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Util.Map<Java.Lang.String, object>> OnReconfigure { get; set; } = null;

        bool hasOverrideReconfigure = true;
        void ReconfigureEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideReconfigure = true;
            var methodToExecute = (OnReconfigure != null) ? OnReconfigure : Reconfigure;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Util.Map<Java.Lang.String, object>>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideReconfigure;
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricsReporter.html#reconfigure-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="ReconfigureDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void Reconfigure(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            hasOverrideReconfigure = false;
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricsReporter.html#validateReconfiguration-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <exception cref="Org.Apache.Kafka.Common.Config.ConfigException"/>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void ValidateReconfigurationDefault(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            IExecuteWithSignature("validateReconfigurationDefault", "(Ljava/util/Map;)V", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricsReporter.html#validateReconfiguration-java.util.Map-"/>
        /// </summary>
        /// <remarks>If <see cref="OnValidateReconfiguration"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Util.Map<Java.Lang.String, object>> OnValidateReconfiguration { get; set; } = null;

        bool hasOverrideValidateReconfiguration = true;
        void ValidateReconfigurationEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideValidateReconfiguration = true;
            var methodToExecute = (OnValidateReconfiguration != null) ? OnValidateReconfiguration : ValidateReconfiguration;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Util.Map<Java.Lang.String, object>>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideValidateReconfiguration;
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricsReporter.html#validateReconfiguration-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <exception cref="Org.Apache.Kafka.Common.Config.ConfigException"/>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="ValidateReconfigurationDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void ValidateReconfiguration(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            hasOverrideValidateReconfiguration = false;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region MetricsReporterDirect implementation
    public partial class MetricsReporterDirect : Org.Apache.Kafka.Common.Metrics.IMetricsReporter, Org.Apache.Kafka.Common.IReconfigurable, Java.Lang.IAutoCloseable
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/Configurable.html#configure-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public override void Configure(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            IExecuteWithSignature("configure", "(Ljava/util/Map;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricsReporter.html#close--"/>
        /// </summary>
        public override void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricsReporter.html#init-java.util.List-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        public override void Init(Java.Util.List<Org.Apache.Kafka.Common.Metrics.KafkaMetric> arg0)
        {
            IExecuteWithSignature("init", "(Ljava/util/List;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricsReporter.html#metricChange-org.apache.kafka.common.metrics.KafkaMetric-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.KafkaMetric"/></param>
        public override void MetricChange(Org.Apache.Kafka.Common.Metrics.KafkaMetric arg0)
        {
            IExecuteWithSignature("metricChange", "(Lorg/apache/kafka/common/metrics/KafkaMetric;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricsReporter.html#metricRemoval-org.apache.kafka.common.metrics.KafkaMetric-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.KafkaMetric"/></param>
        public override void MetricRemoval(Org.Apache.Kafka.Common.Metrics.KafkaMetric arg0)
        {
            IExecuteWithSignature("metricRemoval", "(Lorg/apache/kafka/common/metrics/KafkaMetric;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricsReporter.html#reconfigurableConfigs--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public override Java.Util.Set<Java.Lang.String> ReconfigurableConfigs()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("reconfigurableConfigs", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricsReporter.html#contextChange-org.apache.kafka.common.metrics.MetricsContext-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.MetricsContext"/></param>
        public override void ContextChange(Org.Apache.Kafka.Common.Metrics.MetricsContext arg0)
        {
            IExecuteWithSignature("contextChange", "(Lorg/apache/kafka/common/metrics/MetricsContext;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricsReporter.html#reconfigure-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public override void Reconfigure(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            IExecuteWithSignature("reconfigure", "(Ljava/util/Map;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/metrics/MetricsReporter.html#validateReconfiguration-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <exception cref="Org.Apache.Kafka.Common.Config.ConfigException"/>
        public override void ValidateReconfiguration(Java.Util.Map<Java.Lang.String, object> arg0)
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