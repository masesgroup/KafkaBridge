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
*  This file is generated by MASES.JNetReflector (ver. 2.2.1.0)
*  using kafka-streams-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Kstream
{
    #region KGroupedTable
    public partial class KGroupedTable
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/KGroupedTable.html#aggregate-org.apache.kafka.streams.kstream.Initializer-org.apache.kafka.streams.kstream.Aggregator-org.apache.kafka.streams.kstream.Aggregator-org.apache.kafka.streams.kstream.Materialized-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Initializer"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Aggregator"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Kstream.Aggregator"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Streams.Kstream.Materialized"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable Aggregate(Org.Apache.Kafka.Streams.Kstream.Initializer arg0, Org.Apache.Kafka.Streams.Kstream.Aggregator arg1, Org.Apache.Kafka.Streams.Kstream.Aggregator arg2, Org.Apache.Kafka.Streams.Kstream.Materialized arg3)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable>("aggregate", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/KGroupedTable.html#aggregate-org.apache.kafka.streams.kstream.Initializer-org.apache.kafka.streams.kstream.Aggregator-org.apache.kafka.streams.kstream.Aggregator-org.apache.kafka.streams.kstream.Named-org.apache.kafka.streams.kstream.Materialized-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Initializer"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Aggregator"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Kstream.Aggregator"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Streams.Kstream.Named"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Streams.Kstream.Materialized"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable Aggregate(Org.Apache.Kafka.Streams.Kstream.Initializer arg0, Org.Apache.Kafka.Streams.Kstream.Aggregator arg1, Org.Apache.Kafka.Streams.Kstream.Aggregator arg2, Org.Apache.Kafka.Streams.Kstream.Named arg3, Org.Apache.Kafka.Streams.Kstream.Materialized arg4)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable>("aggregate", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/KGroupedTable.html#aggregate-org.apache.kafka.streams.kstream.Initializer-org.apache.kafka.streams.kstream.Aggregator-org.apache.kafka.streams.kstream.Aggregator-org.apache.kafka.streams.kstream.Named-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Initializer"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Aggregator"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Kstream.Aggregator"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Streams.Kstream.Named"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable Aggregate(Org.Apache.Kafka.Streams.Kstream.Initializer arg0, Org.Apache.Kafka.Streams.Kstream.Aggregator arg1, Org.Apache.Kafka.Streams.Kstream.Aggregator arg2, Org.Apache.Kafka.Streams.Kstream.Named arg3)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable>("aggregate", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/KGroupedTable.html#aggregate-org.apache.kafka.streams.kstream.Initializer-org.apache.kafka.streams.kstream.Aggregator-org.apache.kafka.streams.kstream.Aggregator-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Initializer"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Aggregator"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Kstream.Aggregator"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable Aggregate(Org.Apache.Kafka.Streams.Kstream.Initializer arg0, Org.Apache.Kafka.Streams.Kstream.Aggregator arg1, Org.Apache.Kafka.Streams.Kstream.Aggregator arg2)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable>("aggregate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/KGroupedTable.html#count--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable Count()
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable>("count");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/KGroupedTable.html#count-org.apache.kafka.streams.kstream.Materialized-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Materialized"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable Count(Org.Apache.Kafka.Streams.Kstream.Materialized arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable>("count", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/KGroupedTable.html#count-org.apache.kafka.streams.kstream.Named-org.apache.kafka.streams.kstream.Materialized-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Named"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Materialized"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable Count(Org.Apache.Kafka.Streams.Kstream.Named arg0, Org.Apache.Kafka.Streams.Kstream.Materialized arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable>("count", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/KGroupedTable.html#count-org.apache.kafka.streams.kstream.Named-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Named"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable Count(Org.Apache.Kafka.Streams.Kstream.Named arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable>("count", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/KGroupedTable.html#reduce-org.apache.kafka.streams.kstream.Reducer-org.apache.kafka.streams.kstream.Reducer-org.apache.kafka.streams.kstream.Materialized-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Reducer"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Reducer"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Kstream.Materialized"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable Reduce(Org.Apache.Kafka.Streams.Kstream.Reducer arg0, Org.Apache.Kafka.Streams.Kstream.Reducer arg1, Org.Apache.Kafka.Streams.Kstream.Materialized arg2)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable>("reduce", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/KGroupedTable.html#reduce-org.apache.kafka.streams.kstream.Reducer-org.apache.kafka.streams.kstream.Reducer-org.apache.kafka.streams.kstream.Named-org.apache.kafka.streams.kstream.Materialized-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Reducer"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Reducer"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Kstream.Named"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Streams.Kstream.Materialized"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable Reduce(Org.Apache.Kafka.Streams.Kstream.Reducer arg0, Org.Apache.Kafka.Streams.Kstream.Reducer arg1, Org.Apache.Kafka.Streams.Kstream.Named arg2, Org.Apache.Kafka.Streams.Kstream.Materialized arg3)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable>("reduce", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/KGroupedTable.html#reduce-org.apache.kafka.streams.kstream.Reducer-org.apache.kafka.streams.kstream.Reducer-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Reducer"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Reducer"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable Reduce(Org.Apache.Kafka.Streams.Kstream.Reducer arg0, Org.Apache.Kafka.Streams.Kstream.Reducer arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable>("reduce", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IKGroupedTable<K, V>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IKGroupedTable<K, V>
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region KGroupedTable<K, V>
    public partial class KGroupedTable<K, V> : Org.Apache.Kafka.Streams.Kstream.IKGroupedTable<K, V>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Kstream.KGroupedTable{K, V}"/> to <see cref="Org.Apache.Kafka.Streams.Kstream.KGroupedTable"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Kstream.KGroupedTable(Org.Apache.Kafka.Streams.Kstream.KGroupedTable<K, V> t) => t.Cast<Org.Apache.Kafka.Streams.Kstream.KGroupedTable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/KGroupedTable.html#aggregate-org.apache.kafka.streams.kstream.Initializer-org.apache.kafka.streams.kstream.Aggregator-org.apache.kafka.streams.kstream.Aggregator-org.apache.kafka.streams.kstream.Materialized-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Initializer"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Aggregator"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Kstream.Aggregator"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Streams.Kstream.Materialized"/></param>
        /// <typeparam name="VR"></typeparam>
        /// <typeparam name="Arg1objectSuperK"><typeparamref name="K"/></typeparam>
        /// <typeparam name="Arg1objectSuperV"><typeparamref name="V"/></typeparam>
        /// <typeparam name="Arg2objectSuperK"><typeparamref name="K"/></typeparam>
        /// <typeparam name="Arg2objectSuperV"><typeparamref name="V"/></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable<K, VR> Aggregate<VR, Arg1objectSuperK, Arg1objectSuperV, Arg2objectSuperK, Arg2objectSuperV>(Org.Apache.Kafka.Streams.Kstream.Initializer<VR> arg0, Org.Apache.Kafka.Streams.Kstream.Aggregator<Arg1objectSuperK, Arg1objectSuperV, VR> arg1, Org.Apache.Kafka.Streams.Kstream.Aggregator<Arg2objectSuperK, Arg2objectSuperV, VR> arg2, Org.Apache.Kafka.Streams.Kstream.Materialized<K, VR, Org.Apache.Kafka.Streams.State.KeyValueStore<Org.Apache.Kafka.Common.Utils.Bytes, byte[]>> arg3) where Arg1objectSuperK: K where Arg1objectSuperV: V where Arg2objectSuperK: K where Arg2objectSuperV: V
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable<K, VR>>("aggregate", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/KGroupedTable.html#aggregate-org.apache.kafka.streams.kstream.Initializer-org.apache.kafka.streams.kstream.Aggregator-org.apache.kafka.streams.kstream.Aggregator-org.apache.kafka.streams.kstream.Named-org.apache.kafka.streams.kstream.Materialized-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Initializer"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Aggregator"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Kstream.Aggregator"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Streams.Kstream.Named"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Streams.Kstream.Materialized"/></param>
        /// <typeparam name="VR"></typeparam>
        /// <typeparam name="Arg1objectSuperK"><typeparamref name="K"/></typeparam>
        /// <typeparam name="Arg1objectSuperV"><typeparamref name="V"/></typeparam>
        /// <typeparam name="Arg2objectSuperK"><typeparamref name="K"/></typeparam>
        /// <typeparam name="Arg2objectSuperV"><typeparamref name="V"/></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable<K, VR> Aggregate<VR, Arg1objectSuperK, Arg1objectSuperV, Arg2objectSuperK, Arg2objectSuperV>(Org.Apache.Kafka.Streams.Kstream.Initializer<VR> arg0, Org.Apache.Kafka.Streams.Kstream.Aggregator<Arg1objectSuperK, Arg1objectSuperV, VR> arg1, Org.Apache.Kafka.Streams.Kstream.Aggregator<Arg2objectSuperK, Arg2objectSuperV, VR> arg2, Org.Apache.Kafka.Streams.Kstream.Named arg3, Org.Apache.Kafka.Streams.Kstream.Materialized<K, VR, Org.Apache.Kafka.Streams.State.KeyValueStore<Org.Apache.Kafka.Common.Utils.Bytes, byte[]>> arg4) where Arg1objectSuperK: K where Arg1objectSuperV: V where Arg2objectSuperK: K where Arg2objectSuperV: V
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable<K, VR>>("aggregate", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/KGroupedTable.html#aggregate-org.apache.kafka.streams.kstream.Initializer-org.apache.kafka.streams.kstream.Aggregator-org.apache.kafka.streams.kstream.Aggregator-org.apache.kafka.streams.kstream.Named-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Initializer"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Aggregator"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Kstream.Aggregator"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Streams.Kstream.Named"/></param>
        /// <typeparam name="VR"></typeparam>
        /// <typeparam name="Arg1objectSuperK"><typeparamref name="K"/></typeparam>
        /// <typeparam name="Arg1objectSuperV"><typeparamref name="V"/></typeparam>
        /// <typeparam name="Arg2objectSuperK"><typeparamref name="K"/></typeparam>
        /// <typeparam name="Arg2objectSuperV"><typeparamref name="V"/></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable<K, VR> Aggregate<VR, Arg1objectSuperK, Arg1objectSuperV, Arg2objectSuperK, Arg2objectSuperV>(Org.Apache.Kafka.Streams.Kstream.Initializer<VR> arg0, Org.Apache.Kafka.Streams.Kstream.Aggregator<Arg1objectSuperK, Arg1objectSuperV, VR> arg1, Org.Apache.Kafka.Streams.Kstream.Aggregator<Arg2objectSuperK, Arg2objectSuperV, VR> arg2, Org.Apache.Kafka.Streams.Kstream.Named arg3) where Arg1objectSuperK: K where Arg1objectSuperV: V where Arg2objectSuperK: K where Arg2objectSuperV: V
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable<K, VR>>("aggregate", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/KGroupedTable.html#aggregate-org.apache.kafka.streams.kstream.Initializer-org.apache.kafka.streams.kstream.Aggregator-org.apache.kafka.streams.kstream.Aggregator-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Initializer"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Aggregator"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Kstream.Aggregator"/></param>
        /// <typeparam name="VR"></typeparam>
        /// <typeparam name="Arg1objectSuperK"><typeparamref name="K"/></typeparam>
        /// <typeparam name="Arg1objectSuperV"><typeparamref name="V"/></typeparam>
        /// <typeparam name="Arg2objectSuperK"><typeparamref name="K"/></typeparam>
        /// <typeparam name="Arg2objectSuperV"><typeparamref name="V"/></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable<K, VR> Aggregate<VR, Arg1objectSuperK, Arg1objectSuperV, Arg2objectSuperK, Arg2objectSuperV>(Org.Apache.Kafka.Streams.Kstream.Initializer<VR> arg0, Org.Apache.Kafka.Streams.Kstream.Aggregator<Arg1objectSuperK, Arg1objectSuperV, VR> arg1, Org.Apache.Kafka.Streams.Kstream.Aggregator<Arg2objectSuperK, Arg2objectSuperV, VR> arg2) where Arg1objectSuperK: K where Arg1objectSuperV: V where Arg2objectSuperK: K where Arg2objectSuperV: V
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable<K, VR>>("aggregate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/KGroupedTable.html#count--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable<K, Java.Lang.Long> Count()
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable<K, Java.Lang.Long>>("count");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/KGroupedTable.html#count-org.apache.kafka.streams.kstream.Materialized-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Materialized"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable<K, Java.Lang.Long> Count(Org.Apache.Kafka.Streams.Kstream.Materialized<K, Java.Lang.Long, Org.Apache.Kafka.Streams.State.KeyValueStore<Org.Apache.Kafka.Common.Utils.Bytes, byte[]>> arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable<K, Java.Lang.Long>>("count", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/KGroupedTable.html#count-org.apache.kafka.streams.kstream.Named-org.apache.kafka.streams.kstream.Materialized-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Named"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Materialized"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable<K, Java.Lang.Long> Count(Org.Apache.Kafka.Streams.Kstream.Named arg0, Org.Apache.Kafka.Streams.Kstream.Materialized<K, Java.Lang.Long, Org.Apache.Kafka.Streams.State.KeyValueStore<Org.Apache.Kafka.Common.Utils.Bytes, byte[]>> arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable<K, Java.Lang.Long>>("count", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/KGroupedTable.html#count-org.apache.kafka.streams.kstream.Named-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Named"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable<K, Java.Lang.Long> Count(Org.Apache.Kafka.Streams.Kstream.Named arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable<K, Java.Lang.Long>>("count", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/KGroupedTable.html#reduce-org.apache.kafka.streams.kstream.Reducer-org.apache.kafka.streams.kstream.Reducer-org.apache.kafka.streams.kstream.Materialized-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Reducer"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Reducer"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Kstream.Materialized"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable<K, V> Reduce(Org.Apache.Kafka.Streams.Kstream.Reducer<V> arg0, Org.Apache.Kafka.Streams.Kstream.Reducer<V> arg1, Org.Apache.Kafka.Streams.Kstream.Materialized<K, V, Org.Apache.Kafka.Streams.State.KeyValueStore<Org.Apache.Kafka.Common.Utils.Bytes, byte[]>> arg2)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable<K, V>>("reduce", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/KGroupedTable.html#reduce-org.apache.kafka.streams.kstream.Reducer-org.apache.kafka.streams.kstream.Reducer-org.apache.kafka.streams.kstream.Named-org.apache.kafka.streams.kstream.Materialized-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Reducer"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Reducer"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Kstream.Named"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Streams.Kstream.Materialized"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable<K, V> Reduce(Org.Apache.Kafka.Streams.Kstream.Reducer<V> arg0, Org.Apache.Kafka.Streams.Kstream.Reducer<V> arg1, Org.Apache.Kafka.Streams.Kstream.Named arg2, Org.Apache.Kafka.Streams.Kstream.Materialized<K, V, Org.Apache.Kafka.Streams.State.KeyValueStore<Org.Apache.Kafka.Common.Utils.Bytes, byte[]>> arg3)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable<K, V>>("reduce", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/KGroupedTable.html#reduce-org.apache.kafka.streams.kstream.Reducer-org.apache.kafka.streams.kstream.Reducer-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Reducer"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Reducer"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable<K, V> Reduce(Org.Apache.Kafka.Streams.Kstream.Reducer<V> arg0, Org.Apache.Kafka.Streams.Kstream.Reducer<V> arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable<K, V>>("reduce", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}