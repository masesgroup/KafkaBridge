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
*  using kafka-streams-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Query
{
    #region QueryResult
    public partial class QueryResult
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/QueryResult.html#forFailure-org.apache.kafka.streams.query.FailureReason-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Query.FailureReason"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.QueryResult"/></returns>
        public static Org.Apache.Kafka.Streams.Query.QueryResult ForFailure(Org.Apache.Kafka.Streams.Query.FailureReason arg0, Java.Lang.String arg1)
        {
            return SExecute<Org.Apache.Kafka.Streams.Query.QueryResult>(LocalBridgeClazz, "forFailure", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/QueryResult.html#forResult-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.QueryResult"/></returns>
        public static Org.Apache.Kafka.Streams.Query.QueryResult ForResult(object arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Streams.Query.QueryResult>(LocalBridgeClazz, "forResult", "(Ljava/lang/Object;)Lorg/apache/kafka/streams/query/QueryResult;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/QueryResult.html#forUnknownQueryType-org.apache.kafka.streams.query.Query-org.apache.kafka.streams.processor.StateStore-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Query.Query"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Processor.StateStore"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.QueryResult"/></returns>
        public static Org.Apache.Kafka.Streams.Query.QueryResult ForUnknownQueryType(Org.Apache.Kafka.Streams.Query.Query arg0, Org.Apache.Kafka.Streams.Processor.StateStore arg1)
        {
            return SExecute<Org.Apache.Kafka.Streams.Query.QueryResult>(LocalBridgeClazz, "forUnknownQueryType", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/QueryResult.html#notUpToBound-org.apache.kafka.streams.query.Position-org.apache.kafka.streams.query.PositionBound-java.lang.Integer-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Query.Position"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Query.PositionBound"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Integer"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.QueryResult"/></returns>
        public static Org.Apache.Kafka.Streams.Query.QueryResult NotUpToBound(Org.Apache.Kafka.Streams.Query.Position arg0, Org.Apache.Kafka.Streams.Query.PositionBound arg1, Java.Lang.Integer arg2)
        {
            return SExecute<Org.Apache.Kafka.Streams.Query.QueryResult>(LocalBridgeClazz, "notUpToBound", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/QueryResult.html#getExecutionInfo--"/> 
        /// </summary>
        public Java.Util.List ExecutionInfo
        {
            get { return IExecuteWithSignature<Java.Util.List>("getExecutionInfo", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/QueryResult.html#getFailureMessage--"/> 
        /// </summary>
        public Java.Lang.String FailureMessage
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getFailureMessage", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/QueryResult.html#getFailureReason--"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.Query.FailureReason FailureReason
        {
            get { return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.FailureReason>("getFailureReason", "()Lorg/apache/kafka/streams/query/FailureReason;"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/QueryResult.html#getPosition--"/> <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/QueryResult.html#setPosition-org.apache.kafka.streams.query.Position-"/>
        /// </summary>
        public Org.Apache.Kafka.Streams.Query.Position Position
        {
            get { return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.Position>("getPosition", "()Lorg/apache/kafka/streams/query/Position;"); } set { IExecuteWithSignature("setPosition", "(Lorg/apache/kafka/streams/query/Position;)V", value); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/QueryResult.html#getResult--"/> 
        /// </summary>
        public object Result
        {
            get { return IExecuteWithSignature("getResult", "()Ljava/lang/Object;"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/QueryResult.html#isFailure--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsFailure()
        {
            return IExecuteWithSignature<bool>("isFailure", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/QueryResult.html#isSuccess--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsSuccess()
        {
            return IExecuteWithSignature<bool>("isSuccess", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/QueryResult.html#addExecutionInfo-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void AddExecutionInfo(Java.Lang.String arg0)
        {
            IExecuteWithSignature("addExecutionInfo", "(Ljava/lang/String;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IQueryResult<R>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IQueryResult<R>
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region QueryResult<R>
    public partial class QueryResult<R> : Org.Apache.Kafka.Streams.Query.IQueryResult<R>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Query.QueryResult{R}"/> to <see cref="Org.Apache.Kafka.Streams.Query.QueryResult"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Query.QueryResult(Org.Apache.Kafka.Streams.Query.QueryResult<R> t) => t.Cast<Org.Apache.Kafka.Streams.Query.QueryResult>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/QueryResult.html#forFailure-org.apache.kafka.streams.query.FailureReason-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Query.FailureReason"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.QueryResult"/></returns>
        public static Org.Apache.Kafka.Streams.Query.QueryResult<R> ForFailure(Org.Apache.Kafka.Streams.Query.FailureReason arg0, Java.Lang.String arg1)
        {
            return SExecute<Org.Apache.Kafka.Streams.Query.QueryResult<R>>(LocalBridgeClazz, "forFailure", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/QueryResult.html#forResult-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="R"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.QueryResult"/></returns>
        public static Org.Apache.Kafka.Streams.Query.QueryResult<R> ForResult(R arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Streams.Query.QueryResult<R>>(LocalBridgeClazz, "forResult", "(Ljava/lang/Object;)Lorg/apache/kafka/streams/query/QueryResult;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/QueryResult.html#forUnknownQueryType-org.apache.kafka.streams.query.Query-org.apache.kafka.streams.processor.StateStore-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Query.Query"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Processor.StateStore"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.QueryResult"/></returns>
        public static Org.Apache.Kafka.Streams.Query.QueryResult<R> ForUnknownQueryType(Org.Apache.Kafka.Streams.Query.Query<R> arg0, Org.Apache.Kafka.Streams.Processor.StateStore arg1)
        {
            return SExecute<Org.Apache.Kafka.Streams.Query.QueryResult<R>>(LocalBridgeClazz, "forUnknownQueryType", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/QueryResult.html#notUpToBound-org.apache.kafka.streams.query.Position-org.apache.kafka.streams.query.PositionBound-java.lang.Integer-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Query.Position"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Query.PositionBound"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Integer"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.QueryResult"/></returns>
        public static Org.Apache.Kafka.Streams.Query.QueryResult<R> NotUpToBound(Org.Apache.Kafka.Streams.Query.Position arg0, Org.Apache.Kafka.Streams.Query.PositionBound arg1, Java.Lang.Integer arg2)
        {
            return SExecute<Org.Apache.Kafka.Streams.Query.QueryResult<R>>(LocalBridgeClazz, "notUpToBound", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/QueryResult.html#getExecutionInfo--"/> 
        /// </summary>
        public Java.Util.List<Java.Lang.String> ExecutionInfo
        {
            get { return IExecuteWithSignature<Java.Util.List<Java.Lang.String>>("getExecutionInfo", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/QueryResult.html#getFailureMessage--"/> 
        /// </summary>
        public Java.Lang.String FailureMessage
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getFailureMessage", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/QueryResult.html#getFailureReason--"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.Query.FailureReason FailureReason
        {
            get { return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.FailureReason>("getFailureReason", "()Lorg/apache/kafka/streams/query/FailureReason;"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/QueryResult.html#getPosition--"/> <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/QueryResult.html#setPosition-org.apache.kafka.streams.query.Position-"/>
        /// </summary>
        public Org.Apache.Kafka.Streams.Query.Position Position
        {
            get { return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.Position>("getPosition", "()Lorg/apache/kafka/streams/query/Position;"); } set { IExecuteWithSignature("setPosition", "(Lorg/apache/kafka/streams/query/Position;)V", value); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/QueryResult.html#getResult--"/> 
        /// </summary>
        public R Result
        {
            get { return IExecuteWithSignature<R>("getResult", "()Ljava/lang/Object;"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/QueryResult.html#isFailure--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsFailure()
        {
            return IExecuteWithSignature<bool>("isFailure", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/QueryResult.html#isSuccess--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsSuccess()
        {
            return IExecuteWithSignature<bool>("isSuccess", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/query/QueryResult.html#addExecutionInfo-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void AddExecutionInfo(Java.Lang.String arg0)
        {
            IExecuteWithSignature("addExecutionInfo", "(Ljava/lang/String;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}