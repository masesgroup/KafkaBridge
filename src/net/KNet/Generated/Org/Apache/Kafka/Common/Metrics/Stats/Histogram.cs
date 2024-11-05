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
*  using kafka-clients-3.8.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Metrics.Stats
{
    #region Histogram declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/metrics/stats/Histogram.html"/>
    /// </summary>
    public partial class Histogram : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Histogram>
    {
        const string _bridgeClassName = "org.apache.kafka.common.metrics.stats.Histogram";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Histogram() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Histogram(params object[] args) : base(args) { }

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
        #region BinScheme declaration
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/metrics/stats/Histogram.BinScheme.html"/>
        /// </summary>
        public partial class BinScheme : MASES.JCOBridge.C2JBridge.JVMBridgeBase<BinScheme>
        {
            const string _bridgeClassName = "org.apache.kafka.common.metrics.stats.Histogram$BinScheme";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("BinScheme class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public BinScheme() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("BinScheme class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public BinScheme(params object[] args) : base(args) { }

            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
            /// </summary>
            public override bool IsBridgeCloseable => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
            /// </summary>
            public override bool IsBridgeInterface => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

        #region ConstantBinScheme declaration
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/metrics/stats/Histogram.ConstantBinScheme.html"/>
        /// </summary>
        public partial class ConstantBinScheme : Org.Apache.Kafka.Common.Metrics.Stats.Histogram.BinScheme
        {
            const string _bridgeClassName = "org.apache.kafka.common.metrics.stats.Histogram$ConstantBinScheme";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public ConstantBinScheme() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public ConstantBinScheme(params object[] args) : base(args) { }

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

        #region LinearBinScheme declaration
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/metrics/stats/Histogram.LinearBinScheme.html"/>
        /// </summary>
        public partial class LinearBinScheme : Org.Apache.Kafka.Common.Metrics.Stats.Histogram.BinScheme
        {
            const string _bridgeClassName = "org.apache.kafka.common.metrics.stats.Histogram$LinearBinScheme";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public LinearBinScheme() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public LinearBinScheme(params object[] args) : base(args) { }

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

    #region Histogram implementation
    public partial class Histogram
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/metrics/stats/Histogram.html#org.apache.kafka.common.metrics.stats.Histogram(org.apache.kafka.common.metrics.stats.Histogram.BinScheme)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Metrics.Stats.Histogram.BinScheme"/></param>
        public Histogram(Org.Apache.Kafka.Common.Metrics.Stats.Histogram.BinScheme arg0)
            : base(arg0)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/metrics/stats/Histogram.html#value-double-"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public double Value(double arg0)
        {
            return IExecuteWithSignature<double>("value", "(D)D", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/metrics/stats/Histogram.html#counts--"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float[] Counts()
        {
            return IExecuteWithSignatureArray<float>("counts", "()[F");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/metrics/stats/Histogram.html#clear--"/>
        /// </summary>
        public void Clear()
        {
            IExecuteWithSignature("clear", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/metrics/stats/Histogram.html#record-double-"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        public void Record(double arg0)
        {
            IExecuteWithSignature("record", "(D)V", arg0);
        }

        #endregion

        #region Nested classes
        #region BinScheme implementation
        public partial class BinScheme
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/metrics/stats/Histogram.BinScheme.html#fromBin-int-"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="double"/></returns>
            public double FromBin(int arg0)
            {
                return IExecuteWithSignature<double>("fromBin", "(I)D", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/metrics/stats/Histogram.BinScheme.html#bins--"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int Bins()
            {
                return IExecuteWithSignature<int>("bins", "()I");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/metrics/stats/Histogram.BinScheme.html#toBin-double-"/>
            /// </summary>
            /// <param name="arg0"><see cref="double"/></param>
            /// <returns><see cref="int"/></returns>
            public int ToBin(double arg0)
            {
                return IExecuteWithSignature<int>("toBin", "(D)I", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ConstantBinScheme implementation
        public partial class ConstantBinScheme
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/metrics/stats/Histogram.ConstantBinScheme.html#org.apache.kafka.common.metrics.stats.Histogram$ConstantBinScheme(int,double,double)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="double"/></param>
            /// <param name="arg2"><see cref="double"/></param>
            public ConstantBinScheme(int arg0, double arg1, double arg2)
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/metrics/stats/Histogram.ConstantBinScheme.html#fromBin-int-"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="double"/></returns>
            public double FromBin(int arg0)
            {
                return IExecuteWithSignature<double>("fromBin", "(I)D", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/metrics/stats/Histogram.ConstantBinScheme.html#bins--"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int Bins()
            {
                return IExecuteWithSignature<int>("bins", "()I");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/metrics/stats/Histogram.ConstantBinScheme.html#toBin-double-"/>
            /// </summary>
            /// <param name="arg0"><see cref="double"/></param>
            /// <returns><see cref="int"/></returns>
            public int ToBin(double arg0)
            {
                return IExecuteWithSignature<int>("toBin", "(D)I", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region LinearBinScheme implementation
        public partial class LinearBinScheme
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/metrics/stats/Histogram.LinearBinScheme.html#org.apache.kafka.common.metrics.stats.Histogram$LinearBinScheme(int,double)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="double"/></param>
            public LinearBinScheme(int arg0, double arg1)
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/metrics/stats/Histogram.LinearBinScheme.html#fromBin-int-"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="double"/></returns>
            public double FromBin(int arg0)
            {
                return IExecuteWithSignature<double>("fromBin", "(I)D", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/metrics/stats/Histogram.LinearBinScheme.html#bins--"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int Bins()
            {
                return IExecuteWithSignature<int>("bins", "()I");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/metrics/stats/Histogram.LinearBinScheme.html#toBin-double-"/>
            /// </summary>
            /// <param name="arg0"><see cref="double"/></param>
            /// <returns><see cref="int"/></returns>
            public int ToBin(double arg0)
            {
                return IExecuteWithSignature<int>("toBin", "(D)I", arg0);
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