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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using kafka-streams-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Kstream
{
    #region CogroupedKStream
    public partial class CogroupedKStream
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/CogroupedKStream.html#cogroup-org.apache.kafka.streams.kstream.KGroupedStream-org.apache.kafka.streams.kstream.Aggregator-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.KGroupedStream"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Aggregator"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.CogroupedKStream"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.CogroupedKStream Cogroup(Org.Apache.Kafka.Streams.Kstream.KGroupedStream arg0, Org.Apache.Kafka.Streams.Kstream.Aggregator arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.CogroupedKStream>("cogroup", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/CogroupedKStream.html#windowedBy-org.apache.kafka.streams.kstream.Windows-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Windows"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.TimeWindowedCogroupedKStream"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.TimeWindowedCogroupedKStream WindowedBy(Org.Apache.Kafka.Streams.Kstream.Windows arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.TimeWindowedCogroupedKStream>("windowedBy", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/CogroupedKStream.html#aggregate-org.apache.kafka.streams.kstream.Initializer-org.apache.kafka.streams.kstream.Materialized-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Initializer"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Materialized"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable Aggregate(Org.Apache.Kafka.Streams.Kstream.Initializer arg0, Org.Apache.Kafka.Streams.Kstream.Materialized arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable>("aggregate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/CogroupedKStream.html#aggregate-org.apache.kafka.streams.kstream.Initializer-org.apache.kafka.streams.kstream.Named-org.apache.kafka.streams.kstream.Materialized-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Initializer"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Named"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Kstream.Materialized"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable Aggregate(Org.Apache.Kafka.Streams.Kstream.Initializer arg0, Org.Apache.Kafka.Streams.Kstream.Named arg1, Org.Apache.Kafka.Streams.Kstream.Materialized arg2)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable>("aggregate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/CogroupedKStream.html#aggregate-org.apache.kafka.streams.kstream.Initializer-org.apache.kafka.streams.kstream.Named-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Initializer"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Named"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable Aggregate(Org.Apache.Kafka.Streams.Kstream.Initializer arg0, Org.Apache.Kafka.Streams.Kstream.Named arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable>("aggregate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/CogroupedKStream.html#aggregate-org.apache.kafka.streams.kstream.Initializer-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Initializer"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable Aggregate(Org.Apache.Kafka.Streams.Kstream.Initializer arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.KTable>("aggregate", "(Lorg/apache/kafka/streams/kstream/Initializer;)Lorg/apache/kafka/streams/kstream/KTable;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/CogroupedKStream.html#windowedBy-org.apache.kafka.streams.kstream.SessionWindows-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.SessionWindows"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.SessionWindowedCogroupedKStream"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.SessionWindowedCogroupedKStream WindowedBy(Org.Apache.Kafka.Streams.Kstream.SessionWindows arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.SessionWindowedCogroupedKStream>("windowedBy", "(Lorg/apache/kafka/streams/kstream/SessionWindows;)Lorg/apache/kafka/streams/kstream/SessionWindowedCogroupedKStream;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/CogroupedKStream.html#windowedBy-org.apache.kafka.streams.kstream.SlidingWindows-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.SlidingWindows"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.TimeWindowedCogroupedKStream"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.TimeWindowedCogroupedKStream WindowedBy(Org.Apache.Kafka.Streams.Kstream.SlidingWindows arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.TimeWindowedCogroupedKStream>("windowedBy", "(Lorg/apache/kafka/streams/kstream/SlidingWindows;)Lorg/apache/kafka/streams/kstream/TimeWindowedCogroupedKStream;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ICogroupedKStream<K, VAgg>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ICogroupedKStream<K, VAgg>
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region CogroupedKStream<K, VAgg>
    public partial class CogroupedKStream<K, VAgg> : Org.Apache.Kafka.Streams.Kstream.ICogroupedKStream<K, VAgg>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Kstream.CogroupedKStream{K, VAgg}"/> to <see cref="Org.Apache.Kafka.Streams.Kstream.CogroupedKStream"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Kstream.CogroupedKStream(Org.Apache.Kafka.Streams.Kstream.CogroupedKStream<K, VAgg> t) => t.Cast<Org.Apache.Kafka.Streams.Kstream.CogroupedKStream>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/CogroupedKStream.html#cogroup-org.apache.kafka.streams.kstream.KGroupedStream-org.apache.kafka.streams.kstream.Aggregator-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.KGroupedStream"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Aggregator"/></param>
        /// <typeparam name="V"></typeparam>
        /// <typeparam name="Arg1objectSuperK"><typeparamref name="K"/></typeparam>
        /// <typeparam name="Arg1objectSuperV"><typeparamref name="V"/></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.CogroupedKStream"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.CogroupedKStream<K, VAgg> Cogroup<V, Arg1objectSuperK, Arg1objectSuperV>(Org.Apache.Kafka.Streams.Kstream.KGroupedStream<K, V> arg0, Org.Apache.Kafka.Streams.Kstream.Aggregator<Arg1objectSuperK, Arg1objectSuperV, VAgg> arg1) where Arg1objectSuperK : K where Arg1objectSuperV : V
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.CogroupedKStream<K, VAgg>>("cogroup", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/CogroupedKStream.html#windowedBy-org.apache.kafka.streams.kstream.Windows-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Windows"/></param>
        /// <typeparam name="W"><see cref="Org.Apache.Kafka.Streams.Kstream.Window"/></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.TimeWindowedCogroupedKStream"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.TimeWindowedCogroupedKStream<K, VAgg> WindowedBy<W>(Org.Apache.Kafka.Streams.Kstream.Windows<W> arg0) where W : Org.Apache.Kafka.Streams.Kstream.Window
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.TimeWindowedCogroupedKStream<K, VAgg>>("windowedBy", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/CogroupedKStream.html#aggregate-org.apache.kafka.streams.kstream.Initializer-org.apache.kafka.streams.kstream.Materialized-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Initializer"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Materialized"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable<K, VAgg> Aggregate(Org.Apache.Kafka.Streams.Kstream.Initializer<VAgg> arg0, Org.Apache.Kafka.Streams.Kstream.Materialized<K, VAgg, Org.Apache.Kafka.Streams.State.KeyValueStore<Org.Apache.Kafka.Common.Utils.Bytes, byte[]>> arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable<K, VAgg>>("aggregate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/CogroupedKStream.html#aggregate-org.apache.kafka.streams.kstream.Initializer-org.apache.kafka.streams.kstream.Named-org.apache.kafka.streams.kstream.Materialized-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Initializer"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Named"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Kstream.Materialized"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable<K, VAgg> Aggregate(Org.Apache.Kafka.Streams.Kstream.Initializer<VAgg> arg0, Org.Apache.Kafka.Streams.Kstream.Named arg1, Org.Apache.Kafka.Streams.Kstream.Materialized<K, VAgg, Org.Apache.Kafka.Streams.State.KeyValueStore<Org.Apache.Kafka.Common.Utils.Bytes, byte[]>> arg2)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable<K, VAgg>>("aggregate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/CogroupedKStream.html#aggregate-org.apache.kafka.streams.kstream.Initializer-org.apache.kafka.streams.kstream.Named-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Initializer"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Named"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable<K, VAgg> Aggregate(Org.Apache.Kafka.Streams.Kstream.Initializer<VAgg> arg0, Org.Apache.Kafka.Streams.Kstream.Named arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.KTable<K, VAgg>>("aggregate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/CogroupedKStream.html#aggregate-org.apache.kafka.streams.kstream.Initializer-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Initializer"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.KTable"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.KTable<K, VAgg> Aggregate(Org.Apache.Kafka.Streams.Kstream.Initializer<VAgg> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.KTable<K, VAgg>>("aggregate", "(Lorg/apache/kafka/streams/kstream/Initializer;)Lorg/apache/kafka/streams/kstream/KTable;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/CogroupedKStream.html#windowedBy-org.apache.kafka.streams.kstream.SessionWindows-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.SessionWindows"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.SessionWindowedCogroupedKStream"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.SessionWindowedCogroupedKStream<K, VAgg> WindowedBy(Org.Apache.Kafka.Streams.Kstream.SessionWindows arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.SessionWindowedCogroupedKStream<K, VAgg>>("windowedBy", "(Lorg/apache/kafka/streams/kstream/SessionWindows;)Lorg/apache/kafka/streams/kstream/SessionWindowedCogroupedKStream;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/kstream/CogroupedKStream.html#windowedBy-org.apache.kafka.streams.kstream.SlidingWindows-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.SlidingWindows"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.TimeWindowedCogroupedKStream"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.TimeWindowedCogroupedKStream<K, VAgg> WindowedBy(Org.Apache.Kafka.Streams.Kstream.SlidingWindows arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.TimeWindowedCogroupedKStream<K, VAgg>>("windowedBy", "(Lorg/apache/kafka/streams/kstream/SlidingWindows;)Lorg/apache/kafka/streams/kstream/TimeWindowedCogroupedKStream;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}