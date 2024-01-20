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
*  This file is generated by MASES.JNetReflector (ver. 2.2.1.0)
*  using kafka-streams-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Query
{
    #region StateQueryRequest
    public partial class StateQueryRequest
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/StateQueryRequest.html#inStore-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.StateQueryRequest.InStore"/></returns>
        public static Org.Apache.Kafka.Streams.Query.StateQueryRequest.InStore InStoreMethod(string arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Query.StateQueryRequest.InStore>(LocalBridgeClazz, "inStore", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/StateQueryRequest.html#getPartitions--"/> 
        /// </summary>
        public Java.Util.Set Partitions
        {
            get { return IExecute<Java.Util.Set>("getPartitions"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/StateQueryRequest.html#getPositionBound--"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.Query.PositionBound PositionBound
        {
            get { return IExecute<Org.Apache.Kafka.Streams.Query.PositionBound>("getPositionBound"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/StateQueryRequest.html#getQuery--"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.Query.Query Query
        {
            get { return IExecute<Org.Apache.Kafka.Streams.Query.Query>("getQuery"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/StateQueryRequest.html#getStoreName--"/> 
        /// </summary>
        public string StoreName
        {
            get { return IExecute<string>("getStoreName"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/StateQueryRequest.html#executionInfoEnabled--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool ExecutionInfoEnabled()
        {
            return IExecute<bool>("executionInfoEnabled");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/StateQueryRequest.html#isAllPartitions--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsAllPartitions()
        {
            return IExecute<bool>("isAllPartitions");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/StateQueryRequest.html#isRequireActive--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsRequireActive()
        {
            return IExecute<bool>("isRequireActive");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/StateQueryRequest.html#enableExecutionInfo--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.StateQueryRequest"/></returns>
        public Org.Apache.Kafka.Streams.Query.StateQueryRequest EnableExecutionInfo()
        {
            return IExecute<Org.Apache.Kafka.Streams.Query.StateQueryRequest>("enableExecutionInfo");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/StateQueryRequest.html#requireActive--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.StateQueryRequest"/></returns>
        public Org.Apache.Kafka.Streams.Query.StateQueryRequest RequireActive()
        {
            return IExecute<Org.Apache.Kafka.Streams.Query.StateQueryRequest>("requireActive");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/StateQueryRequest.html#withAllPartitions--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.StateQueryRequest"/></returns>
        public Org.Apache.Kafka.Streams.Query.StateQueryRequest WithAllPartitions()
        {
            return IExecute<Org.Apache.Kafka.Streams.Query.StateQueryRequest>("withAllPartitions");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/StateQueryRequest.html#withPartitions-java.util.Set-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.StateQueryRequest"/></returns>
        public Org.Apache.Kafka.Streams.Query.StateQueryRequest WithPartitions(Java.Util.Set arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Query.StateQueryRequest>("withPartitions", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/StateQueryRequest.html#withPositionBound-org.apache.kafka.streams.query.PositionBound-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Query.PositionBound"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.StateQueryRequest"/></returns>
        public Org.Apache.Kafka.Streams.Query.StateQueryRequest WithPositionBound(Org.Apache.Kafka.Streams.Query.PositionBound arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Query.StateQueryRequest>("withPositionBound", arg0);
        }

        #endregion

        #region Nested classes
        #region InStore
        public partial class InStore
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/StateQueryRequest.InStore.html#withQuery-org.apache.kafka.streams.query.Query-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Query.Query"/></param>
            /// <typeparam name="R"></typeparam>
            /// <returns><see cref="Org.Apache.Kafka.Streams.Query.StateQueryRequest"/></returns>
            public Org.Apache.Kafka.Streams.Query.StateQueryRequest<R> WithQuery<R>(Org.Apache.Kafka.Streams.Query.Query<R> arg0)
            {
                return IExecute<Org.Apache.Kafka.Streams.Query.StateQueryRequest<R>>("withQuery", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion

    #region StateQueryRequest<R>
    public partial class StateQueryRequest<R>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Query.StateQueryRequest{R}"/> to <see cref="Org.Apache.Kafka.Streams.Query.StateQueryRequest"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Query.StateQueryRequest(Org.Apache.Kafka.Streams.Query.StateQueryRequest<R> t) => t.Cast<Org.Apache.Kafka.Streams.Query.StateQueryRequest>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/StateQueryRequest.html#inStore-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.StateQueryRequest.InStore"/></returns>
        public static Org.Apache.Kafka.Streams.Query.StateQueryRequest.InStore InStoreMethod(string arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Query.StateQueryRequest.InStore>(LocalBridgeClazz, "inStore", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/StateQueryRequest.html#getPartitions--"/> 
        /// </summary>
        public Java.Util.Set<Java.Lang.Integer> Partitions
        {
            get { return IExecute<Java.Util.Set<Java.Lang.Integer>>("getPartitions"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/StateQueryRequest.html#getPositionBound--"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.Query.PositionBound PositionBound
        {
            get { return IExecute<Org.Apache.Kafka.Streams.Query.PositionBound>("getPositionBound"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/StateQueryRequest.html#getQuery--"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.Query.Query<R> Query
        {
            get { return IExecute<Org.Apache.Kafka.Streams.Query.Query<R>>("getQuery"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/StateQueryRequest.html#getStoreName--"/> 
        /// </summary>
        public string StoreName
        {
            get { return IExecute<string>("getStoreName"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/StateQueryRequest.html#executionInfoEnabled--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool ExecutionInfoEnabled()
        {
            return IExecute<bool>("executionInfoEnabled");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/StateQueryRequest.html#isAllPartitions--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsAllPartitions()
        {
            return IExecute<bool>("isAllPartitions");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/StateQueryRequest.html#isRequireActive--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsRequireActive()
        {
            return IExecute<bool>("isRequireActive");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/StateQueryRequest.html#enableExecutionInfo--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.StateQueryRequest"/></returns>
        public Org.Apache.Kafka.Streams.Query.StateQueryRequest<R> EnableExecutionInfo()
        {
            return IExecute<Org.Apache.Kafka.Streams.Query.StateQueryRequest<R>>("enableExecutionInfo");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/StateQueryRequest.html#requireActive--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.StateQueryRequest"/></returns>
        public Org.Apache.Kafka.Streams.Query.StateQueryRequest<R> RequireActive()
        {
            return IExecute<Org.Apache.Kafka.Streams.Query.StateQueryRequest<R>>("requireActive");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/StateQueryRequest.html#withAllPartitions--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.StateQueryRequest"/></returns>
        public Org.Apache.Kafka.Streams.Query.StateQueryRequest<R> WithAllPartitions()
        {
            return IExecute<Org.Apache.Kafka.Streams.Query.StateQueryRequest<R>>("withAllPartitions");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/StateQueryRequest.html#withPartitions-java.util.Set-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.StateQueryRequest"/></returns>
        public Org.Apache.Kafka.Streams.Query.StateQueryRequest<R> WithPartitions(Java.Util.Set<Java.Lang.Integer> arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Query.StateQueryRequest<R>>("withPartitions", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/StateQueryRequest.html#withPositionBound-org.apache.kafka.streams.query.PositionBound-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Query.PositionBound"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.StateQueryRequest"/></returns>
        public Org.Apache.Kafka.Streams.Query.StateQueryRequest<R> WithPositionBound(Org.Apache.Kafka.Streams.Query.PositionBound arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Query.StateQueryRequest<R>>("withPositionBound", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}