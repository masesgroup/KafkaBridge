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
*  using kafka-streams-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Kstream
{
    #region WindowedSerdes declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/WindowedSerdes.html"/>
    /// </summary>
    public partial class WindowedSerdes : MASES.JCOBridge.C2JBridge.JVMBridgeBase<WindowedSerdes>
    {
        const string _bridgeClassName = "org.apache.kafka.streams.kstream.WindowedSerdes";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public WindowedSerdes() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public WindowedSerdes(params object[] args) : base(args) { }

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
        #region SessionWindowedSerde declaration
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/WindowedSerdes.SessionWindowedSerde.html"/>
        /// </summary>
        public partial class SessionWindowedSerde : Org.Apache.Kafka.Common.Serialization.Serdes.WrapperSerde
        {
            const string _bridgeClassName = "org.apache.kafka.streams.kstream.WindowedSerdes$SessionWindowedSerde";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public SessionWindowedSerde() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public SessionWindowedSerde(params object[] args) : base(args) { }

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

        #region SessionWindowedSerde<T> declaration
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/WindowedSerdes.SessionWindowedSerde.html"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public partial class SessionWindowedSerde<T> : Org.Apache.Kafka.Common.Serialization.Serdes.WrapperSerde<Org.Apache.Kafka.Streams.Kstream.Windowed<T>>
        {
            const string _bridgeClassName = "org.apache.kafka.streams.kstream.WindowedSerdes$SessionWindowedSerde";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public SessionWindowedSerde() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public SessionWindowedSerde(params object[] args) : base(args) { }

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

        #region TimeWindowedSerde declaration
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/WindowedSerdes.TimeWindowedSerde.html"/>
        /// </summary>
        public partial class TimeWindowedSerde : Org.Apache.Kafka.Common.Serialization.Serdes.WrapperSerde
        {
            const string _bridgeClassName = "org.apache.kafka.streams.kstream.WindowedSerdes$TimeWindowedSerde";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public TimeWindowedSerde() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public TimeWindowedSerde(params object[] args) : base(args) { }

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

        #region TimeWindowedSerde<T> declaration
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/WindowedSerdes.TimeWindowedSerde.html"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public partial class TimeWindowedSerde<T> : Org.Apache.Kafka.Common.Serialization.Serdes.WrapperSerde<Org.Apache.Kafka.Streams.Kstream.Windowed<T>>
        {
            const string _bridgeClassName = "org.apache.kafka.streams.kstream.WindowedSerdes$TimeWindowedSerde";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public TimeWindowedSerde() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public TimeWindowedSerde(params object[] args) : base(args) { }

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

    #region WindowedSerdes implementation
    public partial class WindowedSerdes
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/WindowedSerdes.html#sessionWindowedSerdeFrom-java.lang.Class-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></returns>
        public static Org.Apache.Kafka.Common.Serialization.Serde<Org.Apache.Kafka.Streams.Kstream.Windowed<T>> SessionWindowedSerdeFrom<T>(Java.Lang.Class arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.Serde<Org.Apache.Kafka.Streams.Kstream.Windowed<T>>>(LocalBridgeClazz, "sessionWindowedSerdeFrom", "(Ljava/lang/Class;)Lorg/apache/kafka/common/serialization/Serde;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/WindowedSerdes.html#sessionWindowedSerdeFrom-java.lang.Class-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></returns>
        public static Org.Apache.Kafka.Common.Serialization.Serde<Org.Apache.Kafka.Streams.Kstream.Windowed<T>> SessionWindowedSerdeFromDirect<T>(Java.Lang.Class arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.SerdeDirect<Org.Apache.Kafka.Streams.Kstream.Windowed<T>>, Org.Apache.Kafka.Common.Serialization.Serde<Org.Apache.Kafka.Streams.Kstream.Windowed<T>>>(LocalBridgeClazz, "sessionWindowedSerdeFrom", "(Ljava/lang/Class;)Lorg/apache/kafka/common/serialization/Serde;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/WindowedSerdes.html#timeWindowedSerdeFrom-java.lang.Class-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></returns>
        public static Org.Apache.Kafka.Common.Serialization.Serde<Org.Apache.Kafka.Streams.Kstream.Windowed<T>> TimeWindowedSerdeFrom<T>(Java.Lang.Class arg0, long arg1)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.Serde<Org.Apache.Kafka.Streams.Kstream.Windowed<T>>>(LocalBridgeClazz, "timeWindowedSerdeFrom", "(Ljava/lang/Class;J)Lorg/apache/kafka/common/serialization/Serde;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/WindowedSerdes.html#timeWindowedSerdeFrom-java.lang.Class-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></returns>
        public static Org.Apache.Kafka.Common.Serialization.Serde<Org.Apache.Kafka.Streams.Kstream.Windowed<T>> TimeWindowedSerdeFromDirect<T>(Java.Lang.Class arg0, long arg1)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.SerdeDirect<Org.Apache.Kafka.Streams.Kstream.Windowed<T>>, Org.Apache.Kafka.Common.Serialization.Serde<Org.Apache.Kafka.Streams.Kstream.Windowed<T>>>(LocalBridgeClazz, "timeWindowedSerdeFrom", "(Ljava/lang/Class;J)Lorg/apache/kafka/common/serialization/Serde;", arg0, arg1);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region SessionWindowedSerde implementation
        public partial class SessionWindowedSerde
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/WindowedSerdes.SessionWindowedSerde.html#org.apache.kafka.streams.kstream.WindowedSerdes$SessionWindowedSerde(org.apache.kafka.common.serialization.Serde)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
            public SessionWindowedSerde(Org.Apache.Kafka.Common.Serialization.Serde arg0)
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

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region SessionWindowedSerde<T> implementation
        public partial class SessionWindowedSerde<T>
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/WindowedSerdes.SessionWindowedSerde.html#org.apache.kafka.streams.kstream.WindowedSerdes$SessionWindowedSerde(org.apache.kafka.common.serialization.Serde)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
            public SessionWindowedSerde(Org.Apache.Kafka.Common.Serialization.Serde<T> arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Org.Apache.Kafka.Streams.Kstream.WindowedSerdes.SessionWindowedSerde{T}"/> to <see cref="Org.Apache.Kafka.Streams.Kstream.WindowedSerdes.SessionWindowedSerde"/>
            /// </summary>
            public static implicit operator Org.Apache.Kafka.Streams.Kstream.WindowedSerdes.SessionWindowedSerde(Org.Apache.Kafka.Streams.Kstream.WindowedSerdes.SessionWindowedSerde<T> t) => t.Cast<Org.Apache.Kafka.Streams.Kstream.WindowedSerdes.SessionWindowedSerde>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region TimeWindowedSerde implementation
        public partial class TimeWindowedSerde
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/WindowedSerdes.TimeWindowedSerde.html#org.apache.kafka.streams.kstream.WindowedSerdes$TimeWindowedSerde(org.apache.kafka.common.serialization.Serde,long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
            /// <param name="arg1"><see cref="long"/></param>
            public TimeWindowedSerde(Org.Apache.Kafka.Common.Serialization.Serde arg0, long arg1)
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/WindowedSerdes.TimeWindowedSerde.html#forChangelog-boolean-"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.WindowedSerdes.TimeWindowedSerde"/></returns>
            public Org.Apache.Kafka.Streams.Kstream.WindowedSerdes.TimeWindowedSerde ForChangelog(bool arg0)
            {
                return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.WindowedSerdes.TimeWindowedSerde>("forChangelog", "(Z)Lorg/apache/kafka/streams/kstream/WindowedSerdes$TimeWindowedSerde;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region TimeWindowedSerde<T> implementation
        public partial class TimeWindowedSerde<T>
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/WindowedSerdes.TimeWindowedSerde.html#org.apache.kafka.streams.kstream.WindowedSerdes$TimeWindowedSerde(org.apache.kafka.common.serialization.Serde,long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
            /// <param name="arg1"><see cref="long"/></param>
            public TimeWindowedSerde(Org.Apache.Kafka.Common.Serialization.Serde<T> arg0, long arg1)
                : base(arg0, arg1)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Org.Apache.Kafka.Streams.Kstream.WindowedSerdes.TimeWindowedSerde{T}"/> to <see cref="Org.Apache.Kafka.Streams.Kstream.WindowedSerdes.TimeWindowedSerde"/>
            /// </summary>
            public static implicit operator Org.Apache.Kafka.Streams.Kstream.WindowedSerdes.TimeWindowedSerde(Org.Apache.Kafka.Streams.Kstream.WindowedSerdes.TimeWindowedSerde<T> t) => t.Cast<Org.Apache.Kafka.Streams.Kstream.WindowedSerdes.TimeWindowedSerde>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/WindowedSerdes.TimeWindowedSerde.html#forChangelog-boolean-"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.WindowedSerdes.TimeWindowedSerde"/></returns>
            public Org.Apache.Kafka.Streams.Kstream.WindowedSerdes.TimeWindowedSerde<T> ForChangelog(bool arg0)
            {
                return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.WindowedSerdes.TimeWindowedSerde<T>>("forChangelog", "(Z)Lorg/apache/kafka/streams/kstream/WindowedSerdes$TimeWindowedSerde;", arg0);
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