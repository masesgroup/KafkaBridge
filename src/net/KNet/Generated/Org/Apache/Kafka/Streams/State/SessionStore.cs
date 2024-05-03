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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using kafka-streams-3.6.2.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.State
{
    #region SessionStore
    public partial class SessionStore
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.State.SessionStore"/> to <see cref="Org.Apache.Kafka.Streams.Processor.StateStore"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Processor.StateStore(Org.Apache.Kafka.Streams.State.SessionStore t) => t.Cast<Org.Apache.Kafka.Streams.Processor.StateStore>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.State.SessionStore"/> to <see cref="Org.Apache.Kafka.Streams.State.ReadOnlySessionStore"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.State.ReadOnlySessionStore(Org.Apache.Kafka.Streams.State.SessionStore t) => t.Cast<Org.Apache.Kafka.Streams.State.ReadOnlySessionStore>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/state/SessionStore.html#put-org.apache.kafka.streams.kstream.Windowed-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Windowed"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void Put(Org.Apache.Kafka.Streams.Kstream.Windowed arg0, object arg1)
        {
            IExecute("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/state/SessionStore.html#remove-org.apache.kafka.streams.kstream.Windowed-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Windowed"/></param>
        public void Remove(Org.Apache.Kafka.Streams.Kstream.Windowed arg0)
        {
            IExecuteWithSignature("remove", "(Lorg/apache/kafka/streams/kstream/Windowed;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/state/SessionStore.html#fetchSession-java.lang.Object-java.time.Instant-java.time.Instant-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Time.Instant"/></param>
        /// <param name="arg2"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="object"/></returns>
        public object FetchSession(object arg0, Java.Time.Instant arg1, Java.Time.Instant arg2)
        {
            return IExecute("fetchSession", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/state/SessionStore.html#backwardFindSessions-java.lang.Object-java.time.Instant-java.time.Instant-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Time.Instant"/></param>
        /// <param name="arg2"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator BackwardFindSessions(object arg0, Java.Time.Instant arg1, Java.Time.Instant arg2)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.KeyValueIterator>("backwardFindSessions", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/state/SessionStore.html#backwardFindSessions-java.lang.Object-java.lang.Object-java.time.Instant-java.time.Instant-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Java.Time.Instant"/></param>
        /// <param name="arg3"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator BackwardFindSessions(object arg0, object arg1, Java.Time.Instant arg2, Java.Time.Instant arg3)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.KeyValueIterator>("backwardFindSessions", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/state/SessionStore.html#findSessions-java.lang.Object-java.time.Instant-java.time.Instant-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Time.Instant"/></param>
        /// <param name="arg2"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator FindSessions(object arg0, Java.Time.Instant arg1, Java.Time.Instant arg2)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.KeyValueIterator>("findSessions", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/state/SessionStore.html#findSessions-java.lang.Object-java.lang.Object-java.time.Instant-java.time.Instant-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Java.Time.Instant"/></param>
        /// <param name="arg3"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator FindSessions(object arg0, object arg1, Java.Time.Instant arg2, Java.Time.Instant arg3)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.KeyValueIterator>("findSessions", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/state/SessionStore.html#findSessions-long-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator FindSessions(long arg0, long arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.KeyValueIterator>("findSessions", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ISessionStore<K, AGG>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ISessionStore<K, AGG>
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SessionStore<K, AGG>
    public partial class SessionStore<K, AGG> : Org.Apache.Kafka.Streams.State.ISessionStore<K, AGG>, Org.Apache.Kafka.Streams.Processor.IStateStore, Org.Apache.Kafka.Streams.State.IReadOnlySessionStore<K, AGG>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.State.SessionStore{K, AGG}"/> to <see cref="Org.Apache.Kafka.Streams.Processor.StateStore"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Processor.StateStore(Org.Apache.Kafka.Streams.State.SessionStore<K, AGG> t) => t.Cast<Org.Apache.Kafka.Streams.Processor.StateStore>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.State.SessionStore{K, AGG}"/> to <see cref="Org.Apache.Kafka.Streams.State.ReadOnlySessionStore{K, AGG}"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.State.ReadOnlySessionStore<K, AGG>(Org.Apache.Kafka.Streams.State.SessionStore<K, AGG> t) => t.Cast<Org.Apache.Kafka.Streams.State.ReadOnlySessionStore<K, AGG>>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.State.SessionStore{K, AGG}"/> to <see cref="Org.Apache.Kafka.Streams.State.SessionStore"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.State.SessionStore(Org.Apache.Kafka.Streams.State.SessionStore<K, AGG> t) => t.Cast<Org.Apache.Kafka.Streams.State.SessionStore>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/state/SessionStore.html#put-org.apache.kafka.streams.kstream.Windowed-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Windowed"/></param>
        /// <param name="arg1"><typeparamref name="AGG"/></param>
        public void Put(Org.Apache.Kafka.Streams.Kstream.Windowed<K> arg0, AGG arg1)
        {
            IExecute("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/state/SessionStore.html#remove-org.apache.kafka.streams.kstream.Windowed-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Windowed"/></param>
        public void Remove(Org.Apache.Kafka.Streams.Kstream.Windowed<K> arg0)
        {
            IExecuteWithSignature("remove", "(Lorg/apache/kafka/streams/kstream/Windowed;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/state/SessionStore.html#fetchSession-java.lang.Object-java.time.Instant-java.time.Instant-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><see cref="Java.Time.Instant"/></param>
        /// <param name="arg2"><see cref="Java.Time.Instant"/></param>
        /// <returns><typeparamref name="AGG"/></returns>
        public AGG FetchSession(K arg0, Java.Time.Instant arg1, Java.Time.Instant arg2)
        {
            return IExecute<AGG>("fetchSession", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/state/SessionStore.html#backwardFindSessions-java.lang.Object-java.time.Instant-java.time.Instant-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><see cref="Java.Time.Instant"/></param>
        /// <param name="arg2"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, AGG> BackwardFindSessions(K arg0, Java.Time.Instant arg1, Java.Time.Instant arg2)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, AGG>>("backwardFindSessions", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/state/SessionStore.html#backwardFindSessions-java.lang.Object-java.lang.Object-java.time.Instant-java.time.Instant-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><typeparamref name="K"/></param>
        /// <param name="arg2"><see cref="Java.Time.Instant"/></param>
        /// <param name="arg3"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, AGG> BackwardFindSessions(K arg0, K arg1, Java.Time.Instant arg2, Java.Time.Instant arg3)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, AGG>>("backwardFindSessions", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/state/SessionStore.html#findSessions-java.lang.Object-java.time.Instant-java.time.Instant-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><see cref="Java.Time.Instant"/></param>
        /// <param name="arg2"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, AGG> FindSessions(K arg0, Java.Time.Instant arg1, Java.Time.Instant arg2)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, AGG>>("findSessions", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/state/SessionStore.html#findSessions-java.lang.Object-java.lang.Object-java.time.Instant-java.time.Instant-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><typeparamref name="K"/></param>
        /// <param name="arg2"><see cref="Java.Time.Instant"/></param>
        /// <param name="arg3"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, AGG> FindSessions(K arg0, K arg1, Java.Time.Instant arg2, Java.Time.Instant arg3)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, AGG>>("findSessions", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/state/SessionStore.html#findSessions-long-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, AGG> FindSessions(long arg0, long arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, AGG>>("findSessions", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}