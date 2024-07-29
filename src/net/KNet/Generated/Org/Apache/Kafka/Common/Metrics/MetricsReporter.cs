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
*  using kafka-clients-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Metrics
{
    #region IMetricsReporter
    /// <summary>
    /// .NET interface for org.mases.knet.generated.org.apache.kafka.common.metrics.MetricsReporter implementing <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/metrics/MetricsReporter.html"/>
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

    #region MetricsReporter
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
            AddEventHandler("configure", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Map<Java.Lang.String, object>>>>(ConfigureEventHandler));
            AddEventHandler("close", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(CloseEventHandler));
            AddEventHandler("init", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.List<Org.Apache.Kafka.Common.Metrics.KafkaMetric>>>>(InitEventHandler));
            AddEventHandler("metricChange", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Common.Metrics.KafkaMetric>>>(MetricChangeEventHandler));
            AddEventHandler("metricRemoval", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Common.Metrics.KafkaMetric>>>(MetricRemovalEventHandler));
            AddEventHandler("reconfigurableConfigs", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(ReconfigurableConfigsEventHandler));
            AddEventHandler("contextChange", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Common.Metrics.MetricsContext>>>(ContextChangeEventHandler));
            AddEventHandler("reconfigure", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Map<Java.Lang.String, object>>>>(ReconfigureEventHandler));
            AddEventHandler("validateReconfiguration", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Map<Java.Lang.String, object>>>>(ValidateReconfigurationEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/Configurable.html#configure-java.util.Map-"/>
        /// </summary>
        /// <remarks>If <see cref="OnConfigure"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Util.Map<Java.Lang.String, object>> OnConfigure { get; set; } = null;

        void ConfigureEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Map<Java.Lang.String, object>>> data)
        {
            var methodToExecute = (OnConfigure != null) ? OnConfigure : Configure;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/Configurable.html#configure-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public virtual void Configure(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/metrics/MetricsReporter.html#close--"/>
        /// </summary>
        /// <remarks>If <see cref="OnClose"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action OnClose { get; set; } = null;

        void CloseEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnClose != null) ? OnClose : Close;
            methodToExecute.Invoke();
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/metrics/MetricsReporter.html#close--"/>
        /// </summary>
        public virtual void Close()
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/metrics/MetricsReporter.html#init-java.util.List-"/>
        /// </summary>
        /// <remarks>If <see cref="OnInit"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Util.List<Org.Apache.Kafka.Common.Metrics.KafkaMetric>> OnInit { get; set; } = null;

        void InitEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.List<Org.Apache.Kafka.Common.Metrics.KafkaMetric>>> data)
        {
            var methodToExecute = (OnInit != null) ? OnInit : Init;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/metrics/MetricsReporter.html#init-java.util.List-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        public virtual void Init(Java.Util.List<Org.Apache.Kafka.Common.Metrics.KafkaMetric> arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/metrics/MetricsReporter.html#metricChange-org.apache.kafka.common.metrics.KafkaMetric-"/>
        /// </summary>
        /// <remarks>If <see cref="OnMetricChange"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Org.Apache.Kafka.Common.Metrics.KafkaMetric> OnMetricChange { get; set; } = null;

        void MetricChangeEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Common.Metrics.KafkaMetric>> data)
        {
            var methodToExecute = (OnMetricChange != null) ? OnMetricChange : MetricChange;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/metrics/MetricsReporter.html#metricChange-org.apache.kafka.common.metrics.KafkaMetric-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.KafkaMetric"/></param>
        public virtual void MetricChange(Org.Apache.Kafka.Common.Metrics.KafkaMetric arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/metrics/MetricsReporter.html#metricRemoval-org.apache.kafka.common.metrics.KafkaMetric-"/>
        /// </summary>
        /// <remarks>If <see cref="OnMetricRemoval"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Org.Apache.Kafka.Common.Metrics.KafkaMetric> OnMetricRemoval { get; set; } = null;

        void MetricRemovalEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Common.Metrics.KafkaMetric>> data)
        {
            var methodToExecute = (OnMetricRemoval != null) ? OnMetricRemoval : MetricRemoval;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/metrics/MetricsReporter.html#metricRemoval-org.apache.kafka.common.metrics.KafkaMetric-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.KafkaMetric"/></param>
        public virtual void MetricRemoval(Org.Apache.Kafka.Common.Metrics.KafkaMetric arg0)
        {
            
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/metrics/MetricsReporter.html#reconfigurableConfigs--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Set<Java.Lang.String> ReconfigurableConfigsDefault()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("reconfigurableConfigsDefault", "()Ljava/util/Set;");
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/metrics/MetricsReporter.html#reconfigurableConfigs--"/>
        /// </summary>
        /// <remarks>If <see cref="OnReconfigurableConfigs"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Set<Java.Lang.String>> OnReconfigurableConfigs { get; set; } = null;

        void ReconfigurableConfigsEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnReconfigurableConfigs != null) ? OnReconfigurableConfigs : ReconfigurableConfigs;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/metrics/MetricsReporter.html#reconfigurableConfigs--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="ReconfigurableConfigsDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Set<Java.Lang.String> ReconfigurableConfigs()
        {
            return ReconfigurableConfigsDefault();
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/metrics/MetricsReporter.html#contextChange-org.apache.kafka.common.metrics.MetricsContext-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.MetricsContext"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void ContextChangeDefault(Org.Apache.Kafka.Common.Metrics.MetricsContext arg0)
        {
            IExecuteWithSignature("contextChangeDefault", "(Lorg/apache/kafka/common/metrics/MetricsContext;)V", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/metrics/MetricsReporter.html#contextChange-org.apache.kafka.common.metrics.MetricsContext-"/>
        /// </summary>
        /// <remarks>If <see cref="OnContextChange"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Org.Apache.Kafka.Common.Metrics.MetricsContext> OnContextChange { get; set; } = null;

        void ContextChangeEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Common.Metrics.MetricsContext>> data)
        {
            var methodToExecute = (OnContextChange != null) ? OnContextChange : ContextChange;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/metrics/MetricsReporter.html#contextChange-org.apache.kafka.common.metrics.MetricsContext-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.MetricsContext"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="ContextChangeDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void ContextChange(Org.Apache.Kafka.Common.Metrics.MetricsContext arg0)
        {
            ContextChangeDefault(arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/metrics/MetricsReporter.html#reconfigure-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void ReconfigureDefault(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            IExecuteWithSignature("reconfigureDefault", "(Ljava/util/Map;)V", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/metrics/MetricsReporter.html#reconfigure-java.util.Map-"/>
        /// </summary>
        /// <remarks>If <see cref="OnReconfigure"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Util.Map<Java.Lang.String, object>> OnReconfigure { get; set; } = null;

        void ReconfigureEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Map<Java.Lang.String, object>>> data)
        {
            var methodToExecute = (OnReconfigure != null) ? OnReconfigure : Reconfigure;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/metrics/MetricsReporter.html#reconfigure-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="ReconfigureDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void Reconfigure(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            ReconfigureDefault(arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/metrics/MetricsReporter.html#validateReconfiguration-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <exception cref="Org.Apache.Kafka.Common.Config.ConfigException"/>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void ValidateReconfigurationDefault(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            IExecuteWithSignature("validateReconfigurationDefault", "(Ljava/util/Map;)V", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/metrics/MetricsReporter.html#validateReconfiguration-java.util.Map-"/>
        /// </summary>
        /// <remarks>If <see cref="OnValidateReconfiguration"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Util.Map<Java.Lang.String, object>> OnValidateReconfiguration { get; set; } = null;

        void ValidateReconfigurationEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Map<Java.Lang.String, object>>> data)
        {
            var methodToExecute = (OnValidateReconfiguration != null) ? OnValidateReconfiguration : ValidateReconfiguration;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/metrics/MetricsReporter.html#validateReconfiguration-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <exception cref="Org.Apache.Kafka.Common.Config.ConfigException"/>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="ValidateReconfigurationDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void ValidateReconfiguration(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            ValidateReconfigurationDefault(arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region MetricsReporterDirect
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/Configurable.html#configure-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public override void Configure(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            IExecute("configure", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/metrics/MetricsReporter.html#close--"/>
        /// </summary>
        public override void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/metrics/MetricsReporter.html#init-java.util.List-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        public override void Init(Java.Util.List<Org.Apache.Kafka.Common.Metrics.KafkaMetric> arg0)
        {
            IExecuteWithSignature("init", "(Ljava/util/List;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/metrics/MetricsReporter.html#metricChange-org.apache.kafka.common.metrics.KafkaMetric-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.KafkaMetric"/></param>
        public override void MetricChange(Org.Apache.Kafka.Common.Metrics.KafkaMetric arg0)
        {
            IExecuteWithSignature("metricChange", "(Lorg/apache/kafka/common/metrics/KafkaMetric;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/metrics/MetricsReporter.html#metricRemoval-org.apache.kafka.common.metrics.KafkaMetric-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.KafkaMetric"/></param>
        public override void MetricRemoval(Org.Apache.Kafka.Common.Metrics.KafkaMetric arg0)
        {
            IExecuteWithSignature("metricRemoval", "(Lorg/apache/kafka/common/metrics/KafkaMetric;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/metrics/MetricsReporter.html#reconfigurableConfigs--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public override Java.Util.Set<Java.Lang.String> ReconfigurableConfigs()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("reconfigurableConfigs", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/metrics/MetricsReporter.html#contextChange-org.apache.kafka.common.metrics.MetricsContext-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.MetricsContext"/></param>
        public override void ContextChange(Org.Apache.Kafka.Common.Metrics.MetricsContext arg0)
        {
            IExecuteWithSignature("contextChange", "(Lorg/apache/kafka/common/metrics/MetricsContext;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/metrics/MetricsReporter.html#reconfigure-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public override void Reconfigure(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            IExecuteWithSignature("reconfigure", "(Ljava/util/Map;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/metrics/MetricsReporter.html#validateReconfiguration-java.util.Map-"/>
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