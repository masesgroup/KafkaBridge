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

namespace Org.Apache.Kafka.Streams.State
{
    #region WindowStoreIterator
    public partial class WindowStoreIterator
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.State.WindowStoreIterator"/> to <see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.State.KeyValueIterator(Org.Apache.Kafka.Streams.State.WindowStoreIterator t) => t.Cast<Org.Apache.Kafka.Streams.State.KeyValueIterator>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.State.WindowStoreIterator"/> to <see cref="Java.Io.Closeable"/>
        /// </summary>
        public static implicit operator Java.Io.Closeable(Org.Apache.Kafka.Streams.State.WindowStoreIterator t) => t.Cast<Java.Io.Closeable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/WindowStoreIterator.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IWindowStoreIterator<V>
    /// <summary>
    /// .NET interface for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/WindowStoreIterator.html"/>
    /// </summary>
    public partial interface IWindowStoreIterator<V>
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region WindowStoreIterator<V>
    public partial class WindowStoreIterator<V> : Org.Apache.Kafka.Streams.State.IWindowStoreIterator<V>, Org.Apache.Kafka.Streams.State.IKeyValueIterator<long?, V>, Java.Io.ICloseable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.State.WindowStoreIterator{V}"/> to <see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.State.KeyValueIterator(Org.Apache.Kafka.Streams.State.WindowStoreIterator<V> t) => t.Cast<Org.Apache.Kafka.Streams.State.KeyValueIterator>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.State.WindowStoreIterator{V}"/> to <see cref="Java.Io.Closeable"/>
        /// </summary>
        public static implicit operator Java.Io.Closeable(Org.Apache.Kafka.Streams.State.WindowStoreIterator<V> t) => t.Cast<Java.Io.Closeable>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.State.WindowStoreIterator{V}"/> to <see cref="Org.Apache.Kafka.Streams.State.WindowStoreIterator"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.State.WindowStoreIterator(Org.Apache.Kafka.Streams.State.WindowStoreIterator<V> t) => t.Cast<Org.Apache.Kafka.Streams.State.WindowStoreIterator>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/WindowStoreIterator.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}