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
    #region Sensor declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/Sensor.html"/>
    /// </summary>
    public partial class Sensor : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Sensor>
    {
        const string _bridgeClassName = "org.apache.kafka.common.metrics.Sensor";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Sensor() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Sensor(params object[] args) : base(args) { }

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
        #region RecordingLevel declaration
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/Sensor.RecordingLevel.html"/>
        /// </summary>
        public partial class RecordingLevel : Java.Lang.Enum<Org.Apache.Kafka.Common.Metrics.Sensor.RecordingLevel>
        {
            const string _bridgeClassName = "org.apache.kafka.common.metrics.Sensor$RecordingLevel";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public RecordingLevel() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public RecordingLevel(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region Sensor implementation
    public partial class Sensor
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/Sensor.html#add-org.apache.kafka.common.MetricName-org.apache.kafka.common.metrics.MeasurableStat-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.MetricName"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Metrics.MeasurableStat"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Add(Org.Apache.Kafka.Common.MetricName arg0, Org.Apache.Kafka.Common.Metrics.MeasurableStat arg1)
        {
            return IExecute<bool>("add", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/Sensor.html#add-org.apache.kafka.common.metrics.CompoundStat-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.CompoundStat"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Add(Org.Apache.Kafka.Common.Metrics.CompoundStat arg0)
        {
            return IExecuteWithSignature<bool>("add", "(Lorg/apache/kafka/common/metrics/CompoundStat;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/Sensor.html#hasExpired--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasExpired()
        {
            return IExecuteWithSignature<bool>("hasExpired", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/Sensor.html#shouldRecord--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool ShouldRecord()
        {
            return IExecuteWithSignature<bool>("shouldRecord", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/Sensor.html#name--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Name()
        {
            return IExecuteWithSignature<Java.Lang.String>("name", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/Sensor.html#add-org.apache.kafka.common.MetricName-org.apache.kafka.common.metrics.MeasurableStat-org.apache.kafka.common.metrics.MetricConfig-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.MetricName"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Metrics.MeasurableStat"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Metrics.MetricConfig"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Add(Org.Apache.Kafka.Common.MetricName arg0, Org.Apache.Kafka.Common.Metrics.MeasurableStat arg1, Org.Apache.Kafka.Common.Metrics.MetricConfig arg2)
        {
            return IExecute<bool>("add", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/Sensor.html#add-org.apache.kafka.common.metrics.CompoundStat-org.apache.kafka.common.metrics.MetricConfig-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.CompoundStat"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Metrics.MetricConfig"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Add(Org.Apache.Kafka.Common.Metrics.CompoundStat arg0, Org.Apache.Kafka.Common.Metrics.MetricConfig arg1)
        {
            return IExecute<bool>("add", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/Sensor.html#hasMetrics--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasMetrics()
        {
            return IExecuteWithSignature<bool>("hasMetrics", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/Sensor.html#checkQuotas--"/>
        /// </summary>
        public void CheckQuotas()
        {
            IExecuteWithSignature("checkQuotas", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/Sensor.html#checkQuotas-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void CheckQuotas(long arg0)
        {
            IExecuteWithSignature("checkQuotas", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/Sensor.html#record--"/>
        /// </summary>
        public void Record()
        {
            IExecuteWithSignature("record", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/Sensor.html#record-double-long-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public void Record(double arg0, long arg1, bool arg2)
        {
            IExecute("record", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/Sensor.html#record-double-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        public void Record(double arg0, long arg1)
        {
            IExecute("record", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/Sensor.html#record-double-"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        public void Record(double arg0)
        {
            IExecuteWithSignature("record", "(D)V", arg0);
        }

        #endregion

        #region Nested classes
        #region RecordingLevel implementation
        public partial class RecordingLevel
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/Sensor.RecordingLevel.html#name"/>
            /// </summary>
            public Java.Lang.String name { get { if (!_nameReady) { _nameContent = IGetField<Java.Lang.String>("name"); _nameReady = true; } return _nameContent; } }
            private Java.Lang.String _nameContent = default;
            private bool _nameReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/Sensor.RecordingLevel.html#id"/>
            /// </summary>
            public short id { get { if (!_idReady) { _idContent = IGetField<short>("id"); _idReady = true; } return _idContent; } }
            private short _idContent = default;
            private bool _idReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/Sensor.RecordingLevel.html#MAX_RECORDING_LEVEL_KEY"/>
            /// </summary>
            public static int MAX_RECORDING_LEVEL_KEY { get { if (!_MAX_RECORDING_LEVEL_KEYReady) { _MAX_RECORDING_LEVEL_KEYContent = SGetField<int>(LocalBridgeClazz, "MAX_RECORDING_LEVEL_KEY"); _MAX_RECORDING_LEVEL_KEYReady = true; } return _MAX_RECORDING_LEVEL_KEYContent; } }
            private static int _MAX_RECORDING_LEVEL_KEYContent = default;
            private static bool _MAX_RECORDING_LEVEL_KEYReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/Sensor.RecordingLevel.html#DEBUG"/>
            /// </summary>
            public static Org.Apache.Kafka.Common.Metrics.Sensor.RecordingLevel DEBUG { get { if (!_DEBUGReady) { _DEBUGContent = SGetField<Org.Apache.Kafka.Common.Metrics.Sensor.RecordingLevel>(LocalBridgeClazz, "DEBUG"); _DEBUGReady = true; } return _DEBUGContent; } }
            private static Org.Apache.Kafka.Common.Metrics.Sensor.RecordingLevel _DEBUGContent = default;
            private static bool _DEBUGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/Sensor.RecordingLevel.html#INFO"/>
            /// </summary>
            public static Org.Apache.Kafka.Common.Metrics.Sensor.RecordingLevel INFO { get { if (!_INFOReady) { _INFOContent = SGetField<Org.Apache.Kafka.Common.Metrics.Sensor.RecordingLevel>(LocalBridgeClazz, "INFO"); _INFOReady = true; } return _INFOContent; } }
            private static Org.Apache.Kafka.Common.Metrics.Sensor.RecordingLevel _INFOContent = default;
            private static bool _INFOReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/Sensor.RecordingLevel.html#TRACE"/>
            /// </summary>
            public static Org.Apache.Kafka.Common.Metrics.Sensor.RecordingLevel TRACE { get { if (!_TRACEReady) { _TRACEContent = SGetField<Org.Apache.Kafka.Common.Metrics.Sensor.RecordingLevel>(LocalBridgeClazz, "TRACE"); _TRACEReady = true; } return _TRACEContent; } }
            private static Org.Apache.Kafka.Common.Metrics.Sensor.RecordingLevel _TRACEContent = default;
            private static bool _TRACEReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/Sensor.RecordingLevel.html#forId-int-"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Common.Metrics.Sensor.RecordingLevel"/></returns>
            public static Org.Apache.Kafka.Common.Metrics.Sensor.RecordingLevel ForId(int arg0)
            {
                return SExecuteWithSignature<Org.Apache.Kafka.Common.Metrics.Sensor.RecordingLevel>(LocalBridgeClazz, "forId", "(I)Lorg/apache/kafka/common/metrics/Sensor$RecordingLevel;", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/Sensor.RecordingLevel.html#forName-java.lang.String-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Common.Metrics.Sensor.RecordingLevel"/></returns>
            public static Org.Apache.Kafka.Common.Metrics.Sensor.RecordingLevel ForName(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Org.Apache.Kafka.Common.Metrics.Sensor.RecordingLevel>(LocalBridgeClazz, "forName", "(Ljava/lang/String;)Lorg/apache/kafka/common/metrics/Sensor$RecordingLevel;", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/Sensor.RecordingLevel.html#valueOf-java.lang.String-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Common.Metrics.Sensor.RecordingLevel"/></returns>
            public static Org.Apache.Kafka.Common.Metrics.Sensor.RecordingLevel ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Org.Apache.Kafka.Common.Metrics.Sensor.RecordingLevel>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/common/metrics/Sensor$RecordingLevel;", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/Sensor.RecordingLevel.html#values--"/>
            /// </summary>
            /// <returns><see cref="Org.Apache.Kafka.Common.Metrics.Sensor.RecordingLevel"/></returns>
            public static Org.Apache.Kafka.Common.Metrics.Sensor.RecordingLevel[] Values()
            {
                return SExecuteWithSignatureArray<Org.Apache.Kafka.Common.Metrics.Sensor.RecordingLevel>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/common/metrics/Sensor$RecordingLevel;");
            }

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/metrics/Sensor.RecordingLevel.html#shouldRecord-int-"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool ShouldRecord(int arg0)
            {
                return IExecuteWithSignature<bool>("shouldRecord", "(I)Z", arg0);
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