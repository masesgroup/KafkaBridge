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

namespace Org.Apache.Kafka.Streams.Query
{
    #region StateQueryResult
    public partial class StateQueryResult
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/query/StateQueryResult.html#getGlobalResult--"/> <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/query/StateQueryResult.html#setGlobalResult-org.apache.kafka.streams.query.QueryResult-"/>
        /// </summary>
        public Org.Apache.Kafka.Streams.Query.QueryResult GlobalResult
        {
            get { return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.QueryResult>("getGlobalResult", "()Lorg/apache/kafka/streams/query/QueryResult;"); } set { IExecuteWithSignature("setGlobalResult", "(Lorg/apache/kafka/streams/query/QueryResult;)V", value); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/query/StateQueryResult.html#getOnlyPartitionResult--"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.Query.QueryResult OnlyPartitionResult
        {
            get { return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.QueryResult>("getOnlyPartitionResult", "()Lorg/apache/kafka/streams/query/QueryResult;"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/query/StateQueryResult.html#getPartitionResults--"/> 
        /// </summary>
        public Java.Util.Map PartitionResults
        {
            get { return IExecuteWithSignature<Java.Util.Map>("getPartitionResults", "()Ljava/util/Map;"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/query/StateQueryResult.html#getPosition--"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.Query.Position Position
        {
            get { return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.Position>("getPosition", "()Lorg/apache/kafka/streams/query/Position;"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/query/StateQueryResult.html#addResult-int-org.apache.kafka.streams.query.QueryResult-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Query.QueryResult"/></param>
        public void AddResult(int arg0, Org.Apache.Kafka.Streams.Query.QueryResult arg1)
        {
            IExecute("addResult", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region StateQueryResult<R>
    public partial class StateQueryResult<R>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Query.StateQueryResult{R}"/> to <see cref="Org.Apache.Kafka.Streams.Query.StateQueryResult"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Query.StateQueryResult(Org.Apache.Kafka.Streams.Query.StateQueryResult<R> t) => t.Cast<Org.Apache.Kafka.Streams.Query.StateQueryResult>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/query/StateQueryResult.html#getGlobalResult--"/> <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/query/StateQueryResult.html#setGlobalResult-org.apache.kafka.streams.query.QueryResult-"/>
        /// </summary>
        public Org.Apache.Kafka.Streams.Query.QueryResult<R> GlobalResult
        {
            get { return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.QueryResult<R>>("getGlobalResult", "()Lorg/apache/kafka/streams/query/QueryResult;"); } set { IExecuteWithSignature("setGlobalResult", "(Lorg/apache/kafka/streams/query/QueryResult;)V", value); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/query/StateQueryResult.html#getOnlyPartitionResult--"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.Query.QueryResult<R> OnlyPartitionResult
        {
            get { return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.QueryResult<R>>("getOnlyPartitionResult", "()Lorg/apache/kafka/streams/query/QueryResult;"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/query/StateQueryResult.html#getPartitionResults--"/> 
        /// </summary>
        public Java.Util.Map<Java.Lang.Integer, Org.Apache.Kafka.Streams.Query.QueryResult<R>> PartitionResults
        {
            get { return IExecuteWithSignature<Java.Util.Map<Java.Lang.Integer, Org.Apache.Kafka.Streams.Query.QueryResult<R>>>("getPartitionResults", "()Ljava/util/Map;"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/query/StateQueryResult.html#getPosition--"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.Query.Position Position
        {
            get { return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.Position>("getPosition", "()Lorg/apache/kafka/streams/query/Position;"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/query/StateQueryResult.html#addResult-int-org.apache.kafka.streams.query.QueryResult-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Query.QueryResult"/></param>
        public void AddResult(int arg0, Org.Apache.Kafka.Streams.Query.QueryResult<R> arg1)
        {
            IExecute("addResult", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}