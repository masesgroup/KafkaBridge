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
    #region CompositeReadOnlySessionStore
    public partial class CompositeReadOnlySessionStore
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/CompositeReadOnlySessionStore.html#%3Cinit%3E(org.apache.kafka.streams.state.internals.StateStoreProvider,org.apache.kafka.streams.state.QueryableStoreType,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.State.Internals.StateStoreProvider"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.State.QueryableStoreType"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        public CompositeReadOnlySessionStore(Org.Apache.Kafka.Streams.State.Internals.StateStoreProvider arg0, Org.Apache.Kafka.Streams.State.QueryableStoreType arg1, string arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.State.Internals.CompositeReadOnlySessionStore"/> to <see cref="Org.Apache.Kafka.Streams.State.ReadOnlySessionStore"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.State.ReadOnlySessionStore(Org.Apache.Kafka.Streams.State.Internals.CompositeReadOnlySessionStore t) => t.Cast<Org.Apache.Kafka.Streams.State.ReadOnlySessionStore>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/CompositeReadOnlySessionStore.html#backwardFetch(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator BackwardFetch(object arg0, object arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.KeyValueIterator>("backwardFetch", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/CompositeReadOnlySessionStore.html#backwardFetch(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator BackwardFetch(object arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.KeyValueIterator>("backwardFetch", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/CompositeReadOnlySessionStore.html#backwardFindSessions(java.lang.Object,java.lang.Object,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator BackwardFindSessions(object arg0, object arg1, long arg2, long arg3)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.KeyValueIterator>("backwardFindSessions", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/CompositeReadOnlySessionStore.html#backwardFindSessions(java.lang.Object,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator BackwardFindSessions(object arg0, long arg1, long arg2)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.KeyValueIterator>("backwardFindSessions", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/CompositeReadOnlySessionStore.html#fetch(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator Fetch(object arg0, object arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.KeyValueIterator>("fetch", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/CompositeReadOnlySessionStore.html#fetch(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator Fetch(object arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.KeyValueIterator>("fetch", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/CompositeReadOnlySessionStore.html#findSessions(java.lang.Object,java.lang.Object,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator FindSessions(object arg0, object arg1, long arg2, long arg3)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.KeyValueIterator>("findSessions", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/CompositeReadOnlySessionStore.html#findSessions(java.lang.Object,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator FindSessions(object arg0, long arg1, long arg2)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.KeyValueIterator>("findSessions", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/CompositeReadOnlySessionStore.html#fetchSession(java.lang.Object,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <returns><see cref="object"/></returns>
        public object FetchSession(object arg0, long arg1, long arg2)
        {
            return IExecute("fetchSession", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region CompositeReadOnlySessionStore<K, V>
    public partial class CompositeReadOnlySessionStore<K, V>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/CompositeReadOnlySessionStore.html#%3Cinit%3E(org.apache.kafka.streams.state.internals.StateStoreProvider,org.apache.kafka.streams.state.QueryableStoreType,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.State.Internals.StateStoreProvider"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.State.QueryableStoreType"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        public CompositeReadOnlySessionStore(Org.Apache.Kafka.Streams.State.Internals.StateStoreProvider arg0, Org.Apache.Kafka.Streams.State.QueryableStoreType<Org.Apache.Kafka.Streams.State.ReadOnlySessionStore<K, V>> arg1, string arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.State.Internals.CompositeReadOnlySessionStore{K, V}"/> to <see cref="Org.Apache.Kafka.Streams.State.ReadOnlySessionStore"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.State.ReadOnlySessionStore(Org.Apache.Kafka.Streams.State.Internals.CompositeReadOnlySessionStore<K, V> t) => t.Cast<Org.Apache.Kafka.Streams.State.ReadOnlySessionStore>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.State.Internals.CompositeReadOnlySessionStore{K, V}"/> to <see cref="Org.Apache.Kafka.Streams.State.Internals.CompositeReadOnlySessionStore"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.State.Internals.CompositeReadOnlySessionStore(Org.Apache.Kafka.Streams.State.Internals.CompositeReadOnlySessionStore<K, V> t) => t.Cast<Org.Apache.Kafka.Streams.State.Internals.CompositeReadOnlySessionStore>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/CompositeReadOnlySessionStore.html#backwardFetch(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><typeparamref name="K"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, V> BackwardFetch(K arg0, K arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, V>>("backwardFetch", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/CompositeReadOnlySessionStore.html#backwardFetch(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, V> BackwardFetch(K arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, V>>("backwardFetch", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/CompositeReadOnlySessionStore.html#backwardFindSessions(java.lang.Object,java.lang.Object,long,long)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><typeparamref name="K"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, V> BackwardFindSessions(K arg0, K arg1, long arg2, long arg3)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, V>>("backwardFindSessions", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/CompositeReadOnlySessionStore.html#backwardFindSessions(java.lang.Object,long,long)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, V> BackwardFindSessions(K arg0, long arg1, long arg2)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, V>>("backwardFindSessions", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/CompositeReadOnlySessionStore.html#fetch(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><typeparamref name="K"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, V> Fetch(K arg0, K arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, V>>("fetch", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/CompositeReadOnlySessionStore.html#fetch(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, V> Fetch(K arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, V>>("fetch", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/CompositeReadOnlySessionStore.html#findSessions(java.lang.Object,java.lang.Object,long,long)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><typeparamref name="K"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, V> FindSessions(K arg0, K arg1, long arg2, long arg3)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, V>>("findSessions", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/CompositeReadOnlySessionStore.html#findSessions(java.lang.Object,long,long)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, V> FindSessions(K arg0, long arg1, long arg2)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, V>>("findSessions", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/CompositeReadOnlySessionStore.html#fetchSession(java.lang.Object,long,long)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <returns><typeparamref name="V"/></returns>
        public V FetchSession(K arg0, long arg1, long arg2)
        {
            return IExecute<V>("fetchSession", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}