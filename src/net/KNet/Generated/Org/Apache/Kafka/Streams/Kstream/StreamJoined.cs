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
*  using kafka-streams-3.6.2.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Kstream
{
    #region StreamJoined declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/StreamJoined.html"/>
    /// </summary>
    public partial class StreamJoined : MASES.JCOBridge.C2JBridge.JVMBridgeBase<StreamJoined>
    {
        const string _bridgeClassName = "org.apache.kafka.streams.kstream.StreamJoined";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public StreamJoined() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public StreamJoined(params object[] args) : base(args) { }

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

    #region StreamJoined<K, V1, V2> declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/StreamJoined.html"/>
    /// </summary>
    /// <typeparam name="K"></typeparam>
    /// <typeparam name="V1"></typeparam>
    /// <typeparam name="V2"></typeparam>
    public partial class StreamJoined<K, V1, V2> : MASES.JCOBridge.C2JBridge.JVMBridgeBase<StreamJoined<K, V1, V2>>
    {
        const string _bridgeClassName = "org.apache.kafka.streams.kstream.StreamJoined";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public StreamJoined() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public StreamJoined(params object[] args) : base(args) { }

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

    #region StreamJoined implementation
    public partial class StreamJoined
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/StreamJoined.html#as-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.StreamJoined As(Java.Lang.String arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.StreamJoined>(LocalBridgeClazz, "as", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/StreamJoined.html#with-org.apache.kafka.common.serialization.Serde-org.apache.kafka.common.serialization.Serde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.StreamJoined With(Org.Apache.Kafka.Common.Serialization.Serde arg0, Org.Apache.Kafka.Common.Serialization.Serde arg1, Org.Apache.Kafka.Common.Serialization.Serde arg2)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.StreamJoined>(LocalBridgeClazz, "with", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/StreamJoined.html#with-org.apache.kafka.streams.state.WindowBytesStoreSupplier-org.apache.kafka.streams.state.WindowBytesStoreSupplier-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.State.WindowBytesStoreSupplier"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.State.WindowBytesStoreSupplier"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.StreamJoined With(Org.Apache.Kafka.Streams.State.WindowBytesStoreSupplier arg0, Org.Apache.Kafka.Streams.State.WindowBytesStoreSupplier arg1)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.StreamJoined>(LocalBridgeClazz, "with", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/StreamJoined.html#withKeySerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.StreamJoined WithKeySerde(Org.Apache.Kafka.Common.Serialization.Serde arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.StreamJoined>("withKeySerde", "(Lorg/apache/kafka/common/serialization/Serde;)Lorg/apache/kafka/streams/kstream/StreamJoined;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/StreamJoined.html#withLoggingDisabled--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.StreamJoined WithLoggingDisabled()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.StreamJoined>("withLoggingDisabled", "()Lorg/apache/kafka/streams/kstream/StreamJoined;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/StreamJoined.html#withLoggingEnabled-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.StreamJoined WithLoggingEnabled(Java.Util.Map arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.StreamJoined>("withLoggingEnabled", "(Ljava/util/Map;)Lorg/apache/kafka/streams/kstream/StreamJoined;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/StreamJoined.html#withOtherStoreSupplier-org.apache.kafka.streams.state.WindowBytesStoreSupplier-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.State.WindowBytesStoreSupplier"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.StreamJoined WithOtherStoreSupplier(Org.Apache.Kafka.Streams.State.WindowBytesStoreSupplier arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.StreamJoined>("withOtherStoreSupplier", "(Lorg/apache/kafka/streams/state/WindowBytesStoreSupplier;)Lorg/apache/kafka/streams/kstream/StreamJoined;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/StreamJoined.html#withOtherValueSerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.StreamJoined WithOtherValueSerde(Org.Apache.Kafka.Common.Serialization.Serde arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.StreamJoined>("withOtherValueSerde", "(Lorg/apache/kafka/common/serialization/Serde;)Lorg/apache/kafka/streams/kstream/StreamJoined;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/StreamJoined.html#withStoreName-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.StreamJoined WithStoreName(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.StreamJoined>("withStoreName", "(Ljava/lang/String;)Lorg/apache/kafka/streams/kstream/StreamJoined;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/StreamJoined.html#withThisStoreSupplier-org.apache.kafka.streams.state.WindowBytesStoreSupplier-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.State.WindowBytesStoreSupplier"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.StreamJoined WithThisStoreSupplier(Org.Apache.Kafka.Streams.State.WindowBytesStoreSupplier arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.StreamJoined>("withThisStoreSupplier", "(Lorg/apache/kafka/streams/state/WindowBytesStoreSupplier;)Lorg/apache/kafka/streams/kstream/StreamJoined;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/StreamJoined.html#withValueSerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.StreamJoined WithValueSerde(Org.Apache.Kafka.Common.Serialization.Serde arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.StreamJoined>("withValueSerde", "(Lorg/apache/kafka/common/serialization/Serde;)Lorg/apache/kafka/streams/kstream/StreamJoined;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region StreamJoined<K, V1, V2> implementation
    public partial class StreamJoined<K, V1, V2>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined{K, V1, V2}"/> to <see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Kstream.StreamJoined(Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2> t) => t.Cast<Org.Apache.Kafka.Streams.Kstream.StreamJoined>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/StreamJoined.html#as-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2> As(Java.Lang.String arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2>>(LocalBridgeClazz, "as", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/StreamJoined.html#with-org.apache.kafka.common.serialization.Serde-org.apache.kafka.common.serialization.Serde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2> With(Org.Apache.Kafka.Common.Serialization.Serde<K> arg0, Org.Apache.Kafka.Common.Serialization.Serde<V1> arg1, Org.Apache.Kafka.Common.Serialization.Serde<V2> arg2)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2>>(LocalBridgeClazz, "with", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/StreamJoined.html#with-org.apache.kafka.streams.state.WindowBytesStoreSupplier-org.apache.kafka.streams.state.WindowBytesStoreSupplier-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.State.WindowBytesStoreSupplier"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.State.WindowBytesStoreSupplier"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2> With(Org.Apache.Kafka.Streams.State.WindowBytesStoreSupplier arg0, Org.Apache.Kafka.Streams.State.WindowBytesStoreSupplier arg1)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2>>(LocalBridgeClazz, "with", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/StreamJoined.html#withKeySerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2> WithKeySerde(Org.Apache.Kafka.Common.Serialization.Serde<K> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2>>("withKeySerde", "(Lorg/apache/kafka/common/serialization/Serde;)Lorg/apache/kafka/streams/kstream/StreamJoined;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/StreamJoined.html#withLoggingDisabled--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2> WithLoggingDisabled()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2>>("withLoggingDisabled", "()Lorg/apache/kafka/streams/kstream/StreamJoined;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/StreamJoined.html#withLoggingEnabled-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2> WithLoggingEnabled(Java.Util.Map<Java.Lang.String, Java.Lang.String> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2>>("withLoggingEnabled", "(Ljava/util/Map;)Lorg/apache/kafka/streams/kstream/StreamJoined;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/StreamJoined.html#withOtherStoreSupplier-org.apache.kafka.streams.state.WindowBytesStoreSupplier-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.State.WindowBytesStoreSupplier"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2> WithOtherStoreSupplier(Org.Apache.Kafka.Streams.State.WindowBytesStoreSupplier arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2>>("withOtherStoreSupplier", "(Lorg/apache/kafka/streams/state/WindowBytesStoreSupplier;)Lorg/apache/kafka/streams/kstream/StreamJoined;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/StreamJoined.html#withOtherValueSerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2> WithOtherValueSerde(Org.Apache.Kafka.Common.Serialization.Serde<V2> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2>>("withOtherValueSerde", "(Lorg/apache/kafka/common/serialization/Serde;)Lorg/apache/kafka/streams/kstream/StreamJoined;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/StreamJoined.html#withStoreName-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2> WithStoreName(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2>>("withStoreName", "(Ljava/lang/String;)Lorg/apache/kafka/streams/kstream/StreamJoined;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/StreamJoined.html#withThisStoreSupplier-org.apache.kafka.streams.state.WindowBytesStoreSupplier-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.State.WindowBytesStoreSupplier"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2> WithThisStoreSupplier(Org.Apache.Kafka.Streams.State.WindowBytesStoreSupplier arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2>>("withThisStoreSupplier", "(Lorg/apache/kafka/streams/state/WindowBytesStoreSupplier;)Lorg/apache/kafka/streams/kstream/StreamJoined;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/StreamJoined.html#withValueSerde-org.apache.kafka.common.serialization.Serde-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.StreamJoined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2> WithValueSerde(Org.Apache.Kafka.Common.Serialization.Serde<V1> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.StreamJoined<K, V1, V2>>("withValueSerde", "(Lorg/apache/kafka/common/serialization/Serde;)Lorg/apache/kafka/streams/kstream/StreamJoined;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}