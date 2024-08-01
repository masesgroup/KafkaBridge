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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using kafka-streams-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.State
{
    #region QueryableStoreType
    public partial class QueryableStoreType
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/QueryableStoreType.html#accepts-org.apache.kafka.streams.processor.StateStore-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.StateStore"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Accepts(Org.Apache.Kafka.Streams.Processor.StateStore arg0)
        {
            return IExecuteWithSignature<bool>("accepts", "(Lorg/apache/kafka/streams/processor/StateStore;)Z", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IQueryableStoreType<T>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IQueryableStoreType<T>
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region QueryableStoreType<T>
    public partial class QueryableStoreType<T> : Org.Apache.Kafka.Streams.State.IQueryableStoreType<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.State.QueryableStoreType{T}"/> to <see cref="Org.Apache.Kafka.Streams.State.QueryableStoreType"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.State.QueryableStoreType(Org.Apache.Kafka.Streams.State.QueryableStoreType<T> t) => t.Cast<Org.Apache.Kafka.Streams.State.QueryableStoreType>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/QueryableStoreType.html#accepts-org.apache.kafka.streams.processor.StateStore-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.StateStore"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Accepts(Org.Apache.Kafka.Streams.Processor.StateStore arg0)
        {
            return IExecuteWithSignature<bool>("accepts", "(Lorg/apache/kafka/streams/processor/StateStore;)Z", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}