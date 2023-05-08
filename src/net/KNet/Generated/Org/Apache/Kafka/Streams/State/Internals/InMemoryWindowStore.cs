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
    #region InMemoryWindowStore
    public partial class InMemoryWindowStore
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/InMemoryWindowStore.html#%3Cinit%3E(java.lang.String,long,long,boolean,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <param name="arg4"><see cref="string"/></param>
        public InMemoryWindowStore(string arg0, long arg1, long arg2, bool arg3, string arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.State.Internals.InMemoryWindowStore"/> to <see cref="Org.Apache.Kafka.Streams.State.WindowStore"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.State.WindowStore(Org.Apache.Kafka.Streams.State.Internals.InMemoryWindowStore t) => t.Cast<Org.Apache.Kafka.Streams.State.WindowStore>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/InMemoryWindowStore.html#all()"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<Org.Apache.Kafka.Common.Utils.Bytes>, byte[]> All
        {
            get { return IExecute<Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<Org.Apache.Kafka.Common.Utils.Bytes>, byte[]>>("all"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/InMemoryWindowStore.html#backwardAll()"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<Org.Apache.Kafka.Common.Utils.Bytes>, byte[]> BackwardAll
        {
            get { return IExecute<Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<Org.Apache.Kafka.Common.Utils.Bytes>, byte[]>>("backwardAll"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/InMemoryWindowStore.html#isOpen()"/> 
        /// </summary>
        public bool IsOpen
        {
            get { return IExecute<bool>("isOpen"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/InMemoryWindowStore.html#name()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("name"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/InMemoryWindowStore.html#persistent()"/> 
        /// </summary>
        public bool Persistent
        {
            get { return IExecute<bool>("persistent"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/InMemoryWindowStore.html#getPosition()"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.Query.Position Position
        {
            get { return IExecute<Org.Apache.Kafka.Streams.Query.Position>("getPosition"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/InMemoryWindowStore.html#query(org.apache.kafka.streams.query.Query,org.apache.kafka.streams.query.PositionBound,org.apache.kafka.streams.query.QueryConfig)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Query.Query"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Query.PositionBound"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Query.QueryConfig"/></param>
        /// <typeparam name="R"></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.QueryResult"/></returns>
        public Org.Apache.Kafka.Streams.Query.QueryResult<R> Query<R>(Org.Apache.Kafka.Streams.Query.Query<R> arg0, Org.Apache.Kafka.Streams.Query.PositionBound arg1, Org.Apache.Kafka.Streams.Query.QueryConfig arg2)
        {
            return IExecute<Org.Apache.Kafka.Streams.Query.QueryResult<R>>("query", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/InMemoryWindowStore.html#fetch(org.apache.kafka.common.utils.Bytes,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Utils.Bytes"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] Fetch(Org.Apache.Kafka.Common.Utils.Bytes arg0, long arg1)
        {
            return IExecuteArray<byte>("fetch", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/InMemoryWindowStore.html#fetch(java.lang.Object,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="object"/></returns>
        public object Fetch(object arg0, long arg1)
        {
            return IExecute("fetch", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/InMemoryWindowStore.html#backwardFetch(java.lang.Object,java.lang.Object,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator BackwardFetch(object arg0, object arg1, long arg2, long arg3)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.KeyValueIterator>("backwardFetch", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/InMemoryWindowStore.html#backwardFetch(org.apache.kafka.common.utils.Bytes,org.apache.kafka.common.utils.Bytes,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Utils.Bytes"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Utils.Bytes"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<Org.Apache.Kafka.Common.Utils.Bytes>, byte[]> BackwardFetch(Org.Apache.Kafka.Common.Utils.Bytes arg0, Org.Apache.Kafka.Common.Utils.Bytes arg1, long arg2, long arg3)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<Org.Apache.Kafka.Common.Utils.Bytes>, byte[]>>("backwardFetch", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/InMemoryWindowStore.html#backwardFetchAll(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<Org.Apache.Kafka.Common.Utils.Bytes>, byte[]> BackwardFetchAll(long arg0, long arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<Org.Apache.Kafka.Common.Utils.Bytes>, byte[]>>("backwardFetchAll", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/InMemoryWindowStore.html#backwardFetch(java.lang.Object,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.WindowStoreIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.WindowStoreIterator BackwardFetch(object arg0, long arg1, long arg2)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.WindowStoreIterator>("backwardFetch", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/InMemoryWindowStore.html#backwardFetch(org.apache.kafka.common.utils.Bytes,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Utils.Bytes"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.WindowStoreIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.WindowStoreIterator<byte[]> BackwardFetch(Org.Apache.Kafka.Common.Utils.Bytes arg0, long arg1, long arg2)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.WindowStoreIterator<byte[]>>("backwardFetch", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/InMemoryWindowStore.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/InMemoryWindowStore.html#flush()"/>
        /// </summary>
        public void Flush()
        {
            IExecute("flush");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/InMemoryWindowStore.html#init(org.apache.kafka.streams.processor.StateStoreContext,org.apache.kafka.streams.processor.StateStore)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.StateStoreContext"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Processor.StateStore"/></param>
        public void Init(Org.Apache.Kafka.Streams.Processor.StateStoreContext arg0, Org.Apache.Kafka.Streams.Processor.StateStore arg1)
        {
            IExecute("init", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/InMemoryWindowStore.html#put(java.lang.Object,java.lang.Object,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public void Put(object arg0, object arg1, long arg2)
        {
            IExecute("put", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/InMemoryWindowStore.html#put(org.apache.kafka.common.utils.Bytes,byte[],long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Utils.Bytes"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public void Put(Org.Apache.Kafka.Common.Utils.Bytes arg0, byte[] arg1, long arg2)
        {
            IExecute("put", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}