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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using kafka-streams-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Processor
{
    #region IStateStore
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IStateStore
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region StateStore
    public partial class StateStore : Org.Apache.Kafka.Streams.Processor.IStateStore
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/StateStore.html#getPosition--"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.Query.Position Position
        {
            get { return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.Position>("getPosition", "()Lorg/apache/kafka/streams/query/Position;"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/StateStore.html#isOpen--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsOpen()
        {
            return IExecuteWithSignature<bool>("isOpen", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/StateStore.html#persistent--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool Persistent()
        {
            return IExecuteWithSignature<bool>("persistent", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/StateStore.html#name--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Name()
        {
            return IExecuteWithSignature<Java.Lang.String>("name", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/StateStore.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/StateStore.html#flush--"/>
        /// </summary>
        public void Flush()
        {
            IExecuteWithSignature("flush", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/StateStore.html#query-org.apache.kafka.streams.query.Query-org.apache.kafka.streams.query.PositionBound-org.apache.kafka.streams.query.QueryConfig-"/>
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/StateStore.html#init-org.apache.kafka.streams.processor.StateStoreContext-org.apache.kafka.streams.processor.StateStore-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.StateStoreContext"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Processor.StateStore"/></param>
        public void Init(Org.Apache.Kafka.Streams.Processor.StateStoreContext arg0, Org.Apache.Kafka.Streams.Processor.StateStore arg1)
        {
            IExecute("init", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}