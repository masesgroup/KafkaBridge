/*
*  Copyright 2023 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using kafka-streams-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.State.Internals
{
    #region CompositeReadOnlyKeyValueStore
    public partial class CompositeReadOnlyKeyValueStore
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/CompositeReadOnlyKeyValueStore.html#%3Cinit%3E(org.apache.kafka.streams.state.internals.StateStoreProvider,org.apache.kafka.streams.state.QueryableStoreType,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.State.Internals.StateStoreProvider"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.State.QueryableStoreType"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        public CompositeReadOnlyKeyValueStore(Org.Apache.Kafka.Streams.State.Internals.StateStoreProvider arg0, Org.Apache.Kafka.Streams.State.QueryableStoreType arg1, string arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.State.Internals.CompositeReadOnlyKeyValueStore"/> to <see cref="Org.Apache.Kafka.Streams.State.ReadOnlyKeyValueStore"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.State.ReadOnlyKeyValueStore(Org.Apache.Kafka.Streams.State.Internals.CompositeReadOnlyKeyValueStore t) => t.Cast<Org.Apache.Kafka.Streams.State.ReadOnlyKeyValueStore>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/CompositeReadOnlyKeyValueStore.html#all()"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator All
        {
            get { return IExecute<Org.Apache.Kafka.Streams.State.KeyValueIterator>("all"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/CompositeReadOnlyKeyValueStore.html#approximateNumEntries()"/> 
        /// </summary>
        public long ApproximateNumEntries
        {
            get { return IExecute<long>("approximateNumEntries"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/CompositeReadOnlyKeyValueStore.html#reverseAll()"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator ReverseAll
        {
            get { return IExecute<Org.Apache.Kafka.Streams.State.KeyValueIterator>("reverseAll"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/CompositeReadOnlyKeyValueStore.html#prefixScan(java.lang.Object,org.apache.kafka.common.serialization.Serializer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Serialization.Serializer"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator PrefixScan(object arg0, Org.Apache.Kafka.Common.Serialization.Serializer arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.KeyValueIterator>("prefixScan", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/CompositeReadOnlyKeyValueStore.html#range(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator Range(object arg0, object arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.KeyValueIterator>("range", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/CompositeReadOnlyKeyValueStore.html#reverseRange(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator ReverseRange(object arg0, object arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.KeyValueIterator>("reverseRange", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/CompositeReadOnlyKeyValueStore.html#get(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Get(object arg0)
        {
            return IExecute("get", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region CompositeReadOnlyKeyValueStore<K, V>
    public partial class CompositeReadOnlyKeyValueStore<K, V>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/CompositeReadOnlyKeyValueStore.html#%3Cinit%3E(org.apache.kafka.streams.state.internals.StateStoreProvider,org.apache.kafka.streams.state.QueryableStoreType,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.State.Internals.StateStoreProvider"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.State.QueryableStoreType"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        public CompositeReadOnlyKeyValueStore(Org.Apache.Kafka.Streams.State.Internals.StateStoreProvider arg0, Org.Apache.Kafka.Streams.State.QueryableStoreType<Org.Apache.Kafka.Streams.State.ReadOnlyKeyValueStore<K, V>> arg1, string arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.State.Internals.CompositeReadOnlyKeyValueStore{K, V}"/> to <see cref="Org.Apache.Kafka.Streams.State.ReadOnlyKeyValueStore{K, V}"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.State.ReadOnlyKeyValueStore<K, V>(Org.Apache.Kafka.Streams.State.Internals.CompositeReadOnlyKeyValueStore<K, V> t) => t.Cast<Org.Apache.Kafka.Streams.State.ReadOnlyKeyValueStore<K, V>>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.State.Internals.CompositeReadOnlyKeyValueStore{K, V}"/> to <see cref="Org.Apache.Kafka.Streams.State.Internals.CompositeReadOnlyKeyValueStore"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.State.Internals.CompositeReadOnlyKeyValueStore(Org.Apache.Kafka.Streams.State.Internals.CompositeReadOnlyKeyValueStore<K, V> t) => t.Cast<Org.Apache.Kafka.Streams.State.Internals.CompositeReadOnlyKeyValueStore>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/CompositeReadOnlyKeyValueStore.html#all()"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator<K, V> All
        {
            get { return IExecute<Org.Apache.Kafka.Streams.State.KeyValueIterator<K, V>>("all"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/CompositeReadOnlyKeyValueStore.html#approximateNumEntries()"/> 
        /// </summary>
        public long ApproximateNumEntries
        {
            get { return IExecute<long>("approximateNumEntries"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/CompositeReadOnlyKeyValueStore.html#reverseAll()"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator<K, V> ReverseAll
        {
            get { return IExecute<Org.Apache.Kafka.Streams.State.KeyValueIterator<K, V>>("reverseAll"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/CompositeReadOnlyKeyValueStore.html#prefixScan(java.lang.Object,org.apache.kafka.common.serialization.Serializer)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="P"/></param>
        /// <param name="arg1"><typeparamref name="PS"/></param>
        /// <typeparam name="P"></typeparam>
        /// <typeparam name="PS"><see cref="Org.Apache.Kafka.Common.Serialization.Serializer{P}"/></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator<K, V> PrefixScan<P, PS>(P arg0, PS arg1) where PS: Org.Apache.Kafka.Common.Serialization.Serializer<P>
        {
            return IExecute<Org.Apache.Kafka.Streams.State.KeyValueIterator<K, V>>("prefixScan", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/CompositeReadOnlyKeyValueStore.html#range(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><typeparamref name="K"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator<K, V> Range(K arg0, K arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.KeyValueIterator<K, V>>("range", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/CompositeReadOnlyKeyValueStore.html#reverseRange(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><typeparamref name="K"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator<K, V> ReverseRange(K arg0, K arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.KeyValueIterator<K, V>>("reverseRange", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/CompositeReadOnlyKeyValueStore.html#get(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><typeparamref name="V"/></returns>
        public V Get(K arg0)
        {
            return IExecute<V>("get", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}