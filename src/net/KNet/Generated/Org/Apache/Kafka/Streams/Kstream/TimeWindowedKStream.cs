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
    #region TimeWindowedKStream declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/TimeWindowedKStream.html"/>
    /// </summary>
    public partial class TimeWindowedKStream : MASES.JCOBridge.C2JBridge.JVMBridgeBase<TimeWindowedKStream>
    {
        const string _bridgeClassName = "org.apache.kafka.streams.kstream.TimeWindowedKStream";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("TimeWindowedKStream class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public TimeWindowedKStream() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("TimeWindowedKStream class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public TimeWindowedKStream(params object[] args) : base(args) { }

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
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region TimeWindowedKStream<K, V> declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/TimeWindowedKStream.html"/>
    /// </summary>
    /// <typeparam name="K"></typeparam>
    /// <typeparam name="V"></typeparam>
    public partial class TimeWindowedKStream<K, V> : MASES.JCOBridge.C2JBridge.JVMBridgeBase<TimeWindowedKStream<K, V>>
    {
        const string _bridgeClassName = "org.apache.kafka.streams.kstream.TimeWindowedKStream";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("TimeWindowedKStream class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public TimeWindowedKStream() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("TimeWindowedKStream class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public TimeWindowedKStream(params object[] args) : base(args) { }

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
        public override bool IsBridgeStatic => false;

        // TODO: complete the class
    
    }
    #endregion

    #region TimeWindowedKStream implementation
    public partial class TimeWindowedKStream
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/TimeWindowedKStream.html#aggregate-org.apache.kafka.streams.kstream.Initializer-org.apache.kafka.streams.kstream.Aggregator-org.apache.kafka.streams.kstream.Materialized-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Initializer"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Aggregator"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Kstream.Materialized"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable Aggregate(Org.Apache.Kafka.Streams.Kstream.Initializer arg0, Org.Apache.Kafka.Streams.Kstream.Aggregator arg1, Org.Apache.Kafka.Streams.Kstream.Materialized arg2)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable>("aggregate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/TimeWindowedKStream.html#aggregate-org.apache.kafka.streams.kstream.Initializer-org.apache.kafka.streams.kstream.Aggregator-org.apache.kafka.streams.kstream.Named-org.apache.kafka.streams.kstream.Materialized-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Initializer"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Aggregator"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Kstream.Named"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Streams.Kstream.Materialized"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable Aggregate(Org.Apache.Kafka.Streams.Kstream.Initializer arg0, Org.Apache.Kafka.Streams.Kstream.Aggregator arg1, Org.Apache.Kafka.Streams.Kstream.Named arg2, Org.Apache.Kafka.Streams.Kstream.Materialized arg3)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable>("aggregate", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/TimeWindowedKStream.html#aggregate-org.apache.kafka.streams.kstream.Initializer-org.apache.kafka.streams.kstream.Aggregator-org.apache.kafka.streams.kstream.Named-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Initializer"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Aggregator"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Kstream.Named"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable Aggregate(Org.Apache.Kafka.Streams.Kstream.Initializer arg0, Org.Apache.Kafka.Streams.Kstream.Aggregator arg1, Org.Apache.Kafka.Streams.Kstream.Named arg2)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable>("aggregate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/TimeWindowedKStream.html#aggregate-org.apache.kafka.streams.kstream.Initializer-org.apache.kafka.streams.kstream.Aggregator-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Initializer"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Aggregator"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable Aggregate(Org.Apache.Kafka.Streams.Kstream.Initializer arg0, Org.Apache.Kafka.Streams.Kstream.Aggregator arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable>("aggregate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/TimeWindowedKStream.html#count--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable Count()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.KTable>("count", "()Lorg/apache/kafka/streams/kstream/KTable;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/TimeWindowedKStream.html#count-org.apache.kafka.streams.kstream.Materialized-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Materialized"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable Count(Org.Apache.Kafka.Streams.Kstream.Materialized arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.KTable>("count", "(Lorg/apache/kafka/streams/kstream/Materialized;)Lorg/apache/kafka/streams/kstream/KTable;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/TimeWindowedKStream.html#count-org.apache.kafka.streams.kstream.Named-org.apache.kafka.streams.kstream.Materialized-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Named"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Materialized"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable Count(Org.Apache.Kafka.Streams.Kstream.Named arg0, Org.Apache.Kafka.Streams.Kstream.Materialized arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable>("count", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/TimeWindowedKStream.html#count-org.apache.kafka.streams.kstream.Named-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Named"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable Count(Org.Apache.Kafka.Streams.Kstream.Named arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.KTable>("count", "(Lorg/apache/kafka/streams/kstream/Named;)Lorg/apache/kafka/streams/kstream/KTable;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/TimeWindowedKStream.html#reduce-org.apache.kafka.streams.kstream.Reducer-org.apache.kafka.streams.kstream.Materialized-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Reducer"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Materialized"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable Reduce(Org.Apache.Kafka.Streams.Kstream.Reducer arg0, Org.Apache.Kafka.Streams.Kstream.Materialized arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable>("reduce", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/TimeWindowedKStream.html#reduce-org.apache.kafka.streams.kstream.Reducer-org.apache.kafka.streams.kstream.Named-org.apache.kafka.streams.kstream.Materialized-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Reducer"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Named"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Kstream.Materialized"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable Reduce(Org.Apache.Kafka.Streams.Kstream.Reducer arg0, Org.Apache.Kafka.Streams.Kstream.Named arg1, Org.Apache.Kafka.Streams.Kstream.Materialized arg2)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable>("reduce", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/TimeWindowedKStream.html#reduce-org.apache.kafka.streams.kstream.Reducer-org.apache.kafka.streams.kstream.Named-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Reducer"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Named"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable Reduce(Org.Apache.Kafka.Streams.Kstream.Reducer arg0, Org.Apache.Kafka.Streams.Kstream.Named arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable>("reduce", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/TimeWindowedKStream.html#reduce-org.apache.kafka.streams.kstream.Reducer-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Reducer"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable Reduce(Org.Apache.Kafka.Streams.Kstream.Reducer arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.KTable>("reduce", "(Lorg/apache/kafka/streams/kstream/Reducer;)Lorg/apache/kafka/streams/kstream/KTable;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/TimeWindowedKStream.html#emitStrategy-org.apache.kafka.streams.kstream.EmitStrategy-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.EmitStrategy"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.TimeWindowedKStream"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.TimeWindowedKStream EmitStrategy(Org.Apache.Kafka.Streams.Kstream.EmitStrategy arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.TimeWindowedKStream>("emitStrategy", "(Lorg/apache/kafka/streams/kstream/EmitStrategy;)Lorg/apache/kafka/streams/kstream/TimeWindowedKStream;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ITimeWindowedKStream<K, V>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ITimeWindowedKStream<K, V>
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TimeWindowedKStream<K, V> implementation
    public partial class TimeWindowedKStream<K, V> : Org.Apache.Kafka.Streams.Kstream.ITimeWindowedKStream<K, V>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Kstream.TimeWindowedKStream{K, V}"/> to <see cref="Org.Apache.Kafka.Streams.Kstream.TimeWindowedKStream"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Kstream.TimeWindowedKStream(Org.Apache.Kafka.Streams.Kstream.TimeWindowedKStream<K, V> t) => t.Cast<Org.Apache.Kafka.Streams.Kstream.TimeWindowedKStream>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/TimeWindowedKStream.html#aggregate-org.apache.kafka.streams.kstream.Initializer-org.apache.kafka.streams.kstream.Aggregator-org.apache.kafka.streams.kstream.Materialized-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Initializer"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Aggregator"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Kstream.Materialized"/></param>
        /// <typeparam name="VR"></typeparam>
        /// <typeparam name="Arg1objectSuperK"><typeparamref name="K"/></typeparam>
        /// <typeparam name="Arg1objectSuperV"><typeparamref name="V"/></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, VR> Aggregate<VR, Arg1objectSuperK, Arg1objectSuperV>(Org.Apache.Kafka.Streams.Kstream.Initializer<VR> arg0, Org.Apache.Kafka.Streams.Kstream.Aggregator<Arg1objectSuperK, Arg1objectSuperV, VR> arg1, Org.Apache.Kafka.Streams.Kstream.Materialized<K, VR, Org.Apache.Kafka.Streams.State.WindowStore<Org.Apache.Kafka.Common.Utils.Bytes, byte[]>> arg2) where Arg1objectSuperK : K where Arg1objectSuperV : V
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, VR>>("aggregate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/TimeWindowedKStream.html#aggregate-org.apache.kafka.streams.kstream.Initializer-org.apache.kafka.streams.kstream.Aggregator-org.apache.kafka.streams.kstream.Named-org.apache.kafka.streams.kstream.Materialized-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Initializer"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Aggregator"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Kstream.Named"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Streams.Kstream.Materialized"/></param>
        /// <typeparam name="VR"></typeparam>
        /// <typeparam name="Arg1objectSuperK"><typeparamref name="K"/></typeparam>
        /// <typeparam name="Arg1objectSuperV"><typeparamref name="V"/></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, VR> Aggregate<VR, Arg1objectSuperK, Arg1objectSuperV>(Org.Apache.Kafka.Streams.Kstream.Initializer<VR> arg0, Org.Apache.Kafka.Streams.Kstream.Aggregator<Arg1objectSuperK, Arg1objectSuperV, VR> arg1, Org.Apache.Kafka.Streams.Kstream.Named arg2, Org.Apache.Kafka.Streams.Kstream.Materialized<K, VR, Org.Apache.Kafka.Streams.State.WindowStore<Org.Apache.Kafka.Common.Utils.Bytes, byte[]>> arg3) where Arg1objectSuperK : K where Arg1objectSuperV : V
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, VR>>("aggregate", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/TimeWindowedKStream.html#aggregate-org.apache.kafka.streams.kstream.Initializer-org.apache.kafka.streams.kstream.Aggregator-org.apache.kafka.streams.kstream.Named-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Initializer"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Aggregator"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Kstream.Named"/></param>
        /// <typeparam name="VR"></typeparam>
        /// <typeparam name="Arg1objectSuperK"><typeparamref name="K"/></typeparam>
        /// <typeparam name="Arg1objectSuperV"><typeparamref name="V"/></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, VR> Aggregate<VR, Arg1objectSuperK, Arg1objectSuperV>(Org.Apache.Kafka.Streams.Kstream.Initializer<VR> arg0, Org.Apache.Kafka.Streams.Kstream.Aggregator<Arg1objectSuperK, Arg1objectSuperV, VR> arg1, Org.Apache.Kafka.Streams.Kstream.Named arg2) where Arg1objectSuperK : K where Arg1objectSuperV : V
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, VR>>("aggregate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/TimeWindowedKStream.html#aggregate-org.apache.kafka.streams.kstream.Initializer-org.apache.kafka.streams.kstream.Aggregator-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Initializer"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Aggregator"/></param>
        /// <typeparam name="VR"></typeparam>
        /// <typeparam name="Arg1objectSuperK"><typeparamref name="K"/></typeparam>
        /// <typeparam name="Arg1objectSuperV"><typeparamref name="V"/></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, VR> Aggregate<VR, Arg1objectSuperK, Arg1objectSuperV>(Org.Apache.Kafka.Streams.Kstream.Initializer<VR> arg0, Org.Apache.Kafka.Streams.Kstream.Aggregator<Arg1objectSuperK, Arg1objectSuperV, VR> arg1) where Arg1objectSuperK : K where Arg1objectSuperV : V
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, VR>>("aggregate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/TimeWindowedKStream.html#count--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, Java.Lang.Long> Count()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.KTable<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, Java.Lang.Long>>("count", "()Lorg/apache/kafka/streams/kstream/KTable;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/TimeWindowedKStream.html#count-org.apache.kafka.streams.kstream.Materialized-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Materialized"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, Java.Lang.Long> Count(Org.Apache.Kafka.Streams.Kstream.Materialized<K, Java.Lang.Long, Org.Apache.Kafka.Streams.State.WindowStore<Org.Apache.Kafka.Common.Utils.Bytes, byte[]>> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.KTable<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, Java.Lang.Long>>("count", "(Lorg/apache/kafka/streams/kstream/Materialized;)Lorg/apache/kafka/streams/kstream/KTable;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/TimeWindowedKStream.html#count-org.apache.kafka.streams.kstream.Named-org.apache.kafka.streams.kstream.Materialized-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Named"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Materialized"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, Java.Lang.Long> Count(Org.Apache.Kafka.Streams.Kstream.Named arg0, Org.Apache.Kafka.Streams.Kstream.Materialized<K, Java.Lang.Long, Org.Apache.Kafka.Streams.State.WindowStore<Org.Apache.Kafka.Common.Utils.Bytes, byte[]>> arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, Java.Lang.Long>>("count", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/TimeWindowedKStream.html#count-org.apache.kafka.streams.kstream.Named-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Named"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, Java.Lang.Long> Count(Org.Apache.Kafka.Streams.Kstream.Named arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.KTable<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, Java.Lang.Long>>("count", "(Lorg/apache/kafka/streams/kstream/Named;)Lorg/apache/kafka/streams/kstream/KTable;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/TimeWindowedKStream.html#reduce-org.apache.kafka.streams.kstream.Reducer-org.apache.kafka.streams.kstream.Materialized-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Reducer"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Materialized"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, V> Reduce(Org.Apache.Kafka.Streams.Kstream.Reducer<V> arg0, Org.Apache.Kafka.Streams.Kstream.Materialized<K, V, Org.Apache.Kafka.Streams.State.WindowStore<Org.Apache.Kafka.Common.Utils.Bytes, byte[]>> arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, V>>("reduce", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/TimeWindowedKStream.html#reduce-org.apache.kafka.streams.kstream.Reducer-org.apache.kafka.streams.kstream.Named-org.apache.kafka.streams.kstream.Materialized-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Reducer"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Named"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Kstream.Materialized"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, V> Reduce(Org.Apache.Kafka.Streams.Kstream.Reducer<V> arg0, Org.Apache.Kafka.Streams.Kstream.Named arg1, Org.Apache.Kafka.Streams.Kstream.Materialized<K, V, Org.Apache.Kafka.Streams.State.WindowStore<Org.Apache.Kafka.Common.Utils.Bytes, byte[]>> arg2)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, V>>("reduce", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/TimeWindowedKStream.html#reduce-org.apache.kafka.streams.kstream.Reducer-org.apache.kafka.streams.kstream.Named-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Reducer"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Named"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, V> Reduce(Org.Apache.Kafka.Streams.Kstream.Reducer<V> arg0, Org.Apache.Kafka.Streams.Kstream.Named arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, V>>("reduce", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/TimeWindowedKStream.html#reduce-org.apache.kafka.streams.kstream.Reducer-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Reducer"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, V> Reduce(Org.Apache.Kafka.Streams.Kstream.Reducer<V> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.KTable<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, V>>("reduce", "(Lorg/apache/kafka/streams/kstream/Reducer;)Lorg/apache/kafka/streams/kstream/KTable;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/TimeWindowedKStream.html#emitStrategy-org.apache.kafka.streams.kstream.EmitStrategy-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.EmitStrategy"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.TimeWindowedKStream"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.TimeWindowedKStream<K, V> EmitStrategy(Org.Apache.Kafka.Streams.Kstream.EmitStrategy arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.TimeWindowedKStream<K, V>>("emitStrategy", "(Lorg/apache/kafka/streams/kstream/EmitStrategy;)Lorg/apache/kafka/streams/kstream/TimeWindowedKStream;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}