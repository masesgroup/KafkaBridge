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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using kafka-streams-3.8.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Processor
{
    #region StateStore declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/processor/StateStore.html"/>
    /// </summary>
    public partial class StateStore : MASES.JCOBridge.C2JBridge.JVMBridgeBase<StateStore>
    {
        const string _bridgeClassName = "org.apache.kafka.streams.processor.StateStore";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("StateStore class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public StateStore() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("StateStore class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public StateStore(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

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

    #region StateStore implementation
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/processor/StateStore.html#getPosition--"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.Query.Position Position
        {
            get { return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.Position>("getPosition", "()Lorg/apache/kafka/streams/query/Position;"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/processor/StateStore.html#isOpen--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsOpen()
        {
            return IExecuteWithSignature<bool>("isOpen", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/processor/StateStore.html#persistent--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool Persistent()
        {
            return IExecuteWithSignature<bool>("persistent", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/processor/StateStore.html#name--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Name()
        {
            return IExecuteWithSignature<Java.Lang.String>("name", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/processor/StateStore.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/processor/StateStore.html#flush--"/>
        /// </summary>
        public void Flush()
        {
            IExecuteWithSignature("flush", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/processor/StateStore.html#query-org.apache.kafka.streams.query.Query-org.apache.kafka.streams.query.PositionBound-org.apache.kafka.streams.query.QueryConfig-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Query.Query"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Query.PositionBound"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Query.QueryConfig"/></param>
        /// <typeparam name="R"></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.QueryResult"/></returns>
        public Org.Apache.Kafka.Streams.Query.QueryResult<R> Query<R>(Org.Apache.Kafka.Streams.Query.Query<R> arg0, Org.Apache.Kafka.Streams.Query.PositionBound arg1, Org.Apache.Kafka.Streams.Query.QueryConfig arg2)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.QueryResult<R>>("query", "(Lorg/apache/kafka/streams/query/Query;Lorg/apache/kafka/streams/query/PositionBound;Lorg/apache/kafka/streams/query/QueryConfig;)Lorg/apache/kafka/streams/query/QueryResult;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/processor/StateStore.html#init-org.apache.kafka.streams.processor.StateStoreContext-org.apache.kafka.streams.processor.StateStore-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.StateStoreContext"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Processor.StateStore"/></param>
        public void Init(Org.Apache.Kafka.Streams.Processor.StateStoreContext arg0, Org.Apache.Kafka.Streams.Processor.StateStore arg1)
        {
            IExecuteWithSignature("init", "(Lorg/apache/kafka/streams/processor/StateStoreContext;Lorg/apache/kafka/streams/processor/StateStore;)V", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}