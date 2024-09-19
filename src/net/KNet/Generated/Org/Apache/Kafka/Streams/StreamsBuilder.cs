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

namespace Org.Apache.Kafka.Streams
{
    #region StreamsBuilder declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StreamsBuilder.html"/>
    /// </summary>
    public partial class StreamsBuilder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<StreamsBuilder>
    {
        const string _bridgeClassName = "org.apache.kafka.streams.StreamsBuilder";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public StreamsBuilder() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public StreamsBuilder(params object[] args) : base(args) { }

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

    #region StreamsBuilder implementation
    public partial class StreamsBuilder
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StreamsBuilder.html#org.apache.kafka.streams.StreamsBuilder(org.apache.kafka.streams.TopologyConfig)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.TopologyConfig"/></param>
        public StreamsBuilder(Org.Apache.Kafka.Streams.TopologyConfig arg0)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StreamsBuilder.html#globalTable-java.lang.String-org.apache.kafka.streams.kstream.Consumed-org.apache.kafka.streams.kstream.Materialized-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Consumed"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Kstream.Materialized"/></param>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="V"></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.GlobalKTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.GlobalKTable<K, V> GlobalTable<K, V>(Java.Lang.String arg0, Org.Apache.Kafka.Streams.Kstream.Consumed<K, V> arg1, Org.Apache.Kafka.Streams.Kstream.Materialized<K, V, Org.Apache.Kafka.Streams.State.KeyValueStore<Org.Apache.Kafka.Common.Utils.Bytes, byte[]>> arg2)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.GlobalKTable<K, V>>("globalTable", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StreamsBuilder.html#globalTable-java.lang.String-org.apache.kafka.streams.kstream.Consumed-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Consumed"/></param>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="V"></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.GlobalKTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.GlobalKTable<K, V> GlobalTable<K, V>(Java.Lang.String arg0, Org.Apache.Kafka.Streams.Kstream.Consumed<K, V> arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.GlobalKTable<K, V>>("globalTable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StreamsBuilder.html#globalTable-java.lang.String-org.apache.kafka.streams.kstream.Materialized-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Materialized"/></param>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="V"></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.GlobalKTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.GlobalKTable<K, V> GlobalTable<K, V>(Java.Lang.String arg0, Org.Apache.Kafka.Streams.Kstream.Materialized<K, V, Org.Apache.Kafka.Streams.State.KeyValueStore<Org.Apache.Kafka.Common.Utils.Bytes, byte[]>> arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.GlobalKTable<K, V>>("globalTable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StreamsBuilder.html#globalTable-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="V"></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.GlobalKTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.GlobalKTable<K, V> GlobalTable<K, V>(Java.Lang.String arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.GlobalKTable<K, V>>("globalTable", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StreamsBuilder.html#stream-java.lang.String-org.apache.kafka.streams.kstream.Consumed-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Consumed"/></param>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="V"></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KStream"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KStream<K, V> Stream<K, V>(Java.Lang.String arg0, Org.Apache.Kafka.Streams.Kstream.Consumed<K, V> arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KStream<K, V>>("stream", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StreamsBuilder.html#stream-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="V"></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KStream"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KStream<K, V> Stream<K, V>(Java.Lang.String arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KStream<K, V>>("stream", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StreamsBuilder.html#stream-java.util.Collection-org.apache.kafka.streams.kstream.Consumed-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Consumed"/></param>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="V"></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KStream"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KStream<K, V> Stream<K, V>(Java.Util.Collection<Java.Lang.String> arg0, Org.Apache.Kafka.Streams.Kstream.Consumed<K, V> arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KStream<K, V>>("stream", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StreamsBuilder.html#stream-java.util.Collection-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="V"></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KStream"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KStream<K, V> Stream<K, V>(Java.Util.Collection<Java.Lang.String> arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KStream<K, V>>("stream", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StreamsBuilder.html#stream-java.util.regex.Pattern-org.apache.kafka.streams.kstream.Consumed-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Regex.Pattern"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Consumed"/></param>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="V"></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KStream"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KStream<K, V> Stream<K, V>(Java.Util.Regex.Pattern arg0, Org.Apache.Kafka.Streams.Kstream.Consumed<K, V> arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KStream<K, V>>("stream", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StreamsBuilder.html#stream-java.util.regex.Pattern-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Regex.Pattern"/></param>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="V"></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KStream"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KStream<K, V> Stream<K, V>(Java.Util.Regex.Pattern arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KStream<K, V>>("stream", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StreamsBuilder.html#table-java.lang.String-org.apache.kafka.streams.kstream.Consumed-org.apache.kafka.streams.kstream.Materialized-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Consumed"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Kstream.Materialized"/></param>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="V"></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable<K, V> Table<K, V>(Java.Lang.String arg0, Org.Apache.Kafka.Streams.Kstream.Consumed<K, V> arg1, Org.Apache.Kafka.Streams.Kstream.Materialized<K, V, Org.Apache.Kafka.Streams.State.KeyValueStore<Org.Apache.Kafka.Common.Utils.Bytes, byte[]>> arg2)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable<K, V>>("table", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StreamsBuilder.html#table-java.lang.String-org.apache.kafka.streams.kstream.Consumed-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Consumed"/></param>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="V"></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable<K, V> Table<K, V>(Java.Lang.String arg0, Org.Apache.Kafka.Streams.Kstream.Consumed<K, V> arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable<K, V>>("table", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StreamsBuilder.html#table-java.lang.String-org.apache.kafka.streams.kstream.Materialized-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Materialized"/></param>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="V"></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable<K, V> Table<K, V>(Java.Lang.String arg0, Org.Apache.Kafka.Streams.Kstream.Materialized<K, V, Org.Apache.Kafka.Streams.State.KeyValueStore<Org.Apache.Kafka.Common.Utils.Bytes, byte[]>> arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable<K, V>>("table", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StreamsBuilder.html#table-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="V"></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable<K, V> Table<K, V>(Java.Lang.String arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable<K, V>>("table", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StreamsBuilder.html#addStateStore-org.apache.kafka.streams.state.StoreBuilder-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.State.StoreBuilder"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.StreamsBuilder"/></returns>
        public Org.Apache.Kafka.Streams.StreamsBuilder AddStateStore(Org.Apache.Kafka.Streams.State.StoreBuilder arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.StreamsBuilder>("addStateStore", "(Lorg/apache/kafka/streams/state/StoreBuilder;)Lorg/apache/kafka/streams/StreamsBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StreamsBuilder.html#build--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Topology"/></returns>
        public Org.Apache.Kafka.Streams.Topology Build()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Topology>("build", "()Lorg/apache/kafka/streams/Topology;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StreamsBuilder.html#build-java.util.Properties-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Properties"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Topology"/></returns>
        public Org.Apache.Kafka.Streams.Topology Build(Java.Util.Properties arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Topology>("build", "(Ljava/util/Properties;)Lorg/apache/kafka/streams/Topology;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}