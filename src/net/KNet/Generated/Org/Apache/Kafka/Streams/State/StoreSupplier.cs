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
*  This file is generated by MASES.JNetReflector (ver. 2.1.0.0)
*  using kafka-streams-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.State
{
    #region StoreSupplier
    public partial class StoreSupplier
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/state/StoreSupplier.html#metricsScope--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string MetricsScope()
        {
            return IExecute<string>("metricsScope");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/state/StoreSupplier.html#name--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string Name()
        {
            return IExecute<string>("name");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/state/StoreSupplier.html#get--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.StateStore"/></returns>
        public Org.Apache.Kafka.Streams.Processor.StateStore Get()
        {
            return IExecute<Org.Apache.Kafka.Streams.Processor.StateStore>("get");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IStoreSupplier<T>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IStoreSupplier<T>
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region StoreSupplier<T>
    public partial class StoreSupplier<T> : Org.Apache.Kafka.Streams.State.IStoreSupplier<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.State.StoreSupplier{T}"/> to <see cref="Org.Apache.Kafka.Streams.State.StoreSupplier"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.State.StoreSupplier(Org.Apache.Kafka.Streams.State.StoreSupplier<T> t) => t.Cast<Org.Apache.Kafka.Streams.State.StoreSupplier>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/state/StoreSupplier.html#metricsScope--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string MetricsScope()
        {
            return IExecute<string>("metricsScope");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/state/StoreSupplier.html#name--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string Name()
        {
            return IExecute<string>("name");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/state/StoreSupplier.html#get--"/>
        /// </summary>

        /// <returns><typeparamref name="T"/></returns>
        public T Get()
        {
            return IExecute<T>("get");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}