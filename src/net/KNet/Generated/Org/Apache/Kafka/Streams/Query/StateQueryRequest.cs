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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using kafka-streams-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Query
{
    #region StateQueryRequest declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/StateQueryRequest.html"/>
    /// </summary>
    public partial class StateQueryRequest : MASES.JCOBridge.C2JBridge.JVMBridgeBase<StateQueryRequest>
    {
        const string _bridgeClassName = "org.apache.kafka.streams.query.StateQueryRequest";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public StateQueryRequest() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public StateQueryRequest(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class
        #region InStore declaration
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/StateQueryRequest.InStore.html"/>
        /// </summary>
        public partial class InStore : MASES.JCOBridge.C2JBridge.JVMBridgeBase<InStore>
        {
            const string _bridgeClassName = "org.apache.kafka.streams.query.StateQueryRequest$InStore";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public InStore() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public InStore(params object[] args) : base(args) { }

            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
            /// </summary>
            public override bool IsBridgeCloseable => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
            /// </summary>
            public override bool IsBridgeInterface => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region StateQueryRequest<R> declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/StateQueryRequest.html"/>
    /// </summary>
    /// <typeparam name="R"></typeparam>
    public partial class StateQueryRequest<R> : MASES.JCOBridge.C2JBridge.JVMBridgeBase<StateQueryRequest<R>>
    {
        const string _bridgeClassName = "org.apache.kafka.streams.query.StateQueryRequest";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public StateQueryRequest() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public StateQueryRequest(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class
    
    }
    #endregion

    #region StateQueryRequest implementation
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/StateQueryRequest.html#inStore-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.StateQueryRequest.InStore"/></returns>
        public static Org.Apache.Kafka.Streams.Query.StateQueryRequest.InStore InStoreMethod(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Streams.Query.StateQueryRequest.InStore>(LocalBridgeClazz, "inStore", "(Ljava/lang/String;)Lorg/apache/kafka/streams/query/StateQueryRequest$InStore;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/StateQueryRequest.html#getPartitions--"/> 
        /// </summary>
        public Java.Util.Set Partitions
        {
            get { return IExecuteWithSignature<Java.Util.Set>("getPartitions", "()Ljava/util/Set;"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/StateQueryRequest.html#getPositionBound--"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.Query.PositionBound PositionBound
        {
            get { return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.PositionBound>("getPositionBound", "()Lorg/apache/kafka/streams/query/PositionBound;"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/StateQueryRequest.html#getQuery--"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.Query.Query Query
        {
            get { return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.Query>("getQuery", "()Lorg/apache/kafka/streams/query/Query;"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/StateQueryRequest.html#getStoreName--"/> 
        /// </summary>
        public Java.Lang.String StoreName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getStoreName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/StateQueryRequest.html#executionInfoEnabled--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool ExecutionInfoEnabled()
        {
            return IExecuteWithSignature<bool>("executionInfoEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/StateQueryRequest.html#isAllPartitions--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAllPartitions()
        {
            return IExecuteWithSignature<bool>("isAllPartitions", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/StateQueryRequest.html#isRequireActive--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRequireActive()
        {
            return IExecuteWithSignature<bool>("isRequireActive", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/StateQueryRequest.html#enableExecutionInfo--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.StateQueryRequest"/></returns>
        public Org.Apache.Kafka.Streams.Query.StateQueryRequest EnableExecutionInfo()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.StateQueryRequest>("enableExecutionInfo", "()Lorg/apache/kafka/streams/query/StateQueryRequest;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/StateQueryRequest.html#requireActive--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.StateQueryRequest"/></returns>
        public Org.Apache.Kafka.Streams.Query.StateQueryRequest RequireActive()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.StateQueryRequest>("requireActive", "()Lorg/apache/kafka/streams/query/StateQueryRequest;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/StateQueryRequest.html#withAllPartitions--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.StateQueryRequest"/></returns>
        public Org.Apache.Kafka.Streams.Query.StateQueryRequest WithAllPartitions()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.StateQueryRequest>("withAllPartitions", "()Lorg/apache/kafka/streams/query/StateQueryRequest;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/StateQueryRequest.html#withPartitions-java.util.Set-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.StateQueryRequest"/></returns>
        public Org.Apache.Kafka.Streams.Query.StateQueryRequest WithPartitions(Java.Util.Set arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.StateQueryRequest>("withPartitions", "(Ljava/util/Set;)Lorg/apache/kafka/streams/query/StateQueryRequest;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/StateQueryRequest.html#withPositionBound-org.apache.kafka.streams.query.PositionBound-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Query.PositionBound"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.StateQueryRequest"/></returns>
        public Org.Apache.Kafka.Streams.Query.StateQueryRequest WithPositionBound(Org.Apache.Kafka.Streams.Query.PositionBound arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.StateQueryRequest>("withPositionBound", "(Lorg/apache/kafka/streams/query/PositionBound;)Lorg/apache/kafka/streams/query/StateQueryRequest;", arg0);
        }

        #endregion

        #region Nested classes
        #region InStore implementation
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/StateQueryRequest.InStore.html#withQuery-org.apache.kafka.streams.query.Query-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Query.Query"/></param>
            /// <typeparam name="R"></typeparam>
            /// <returns><see cref="Org.Apache.Kafka.Streams.Query.StateQueryRequest"/></returns>
            public Org.Apache.Kafka.Streams.Query.StateQueryRequest<R> WithQuery<R>(Org.Apache.Kafka.Streams.Query.Query<R> arg0)
            {
                return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.StateQueryRequest<R>>("withQuery", "(Lorg/apache/kafka/streams/query/Query;)Lorg/apache/kafka/streams/query/StateQueryRequest;", arg0);
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

    #region StateQueryRequest<R> implementation
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/StateQueryRequest.html#inStore-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.StateQueryRequest.InStore"/></returns>
        public static Org.Apache.Kafka.Streams.Query.StateQueryRequest.InStore InStoreMethod(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Streams.Query.StateQueryRequest.InStore>(LocalBridgeClazz, "inStore", "(Ljava/lang/String;)Lorg/apache/kafka/streams/query/StateQueryRequest$InStore;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/StateQueryRequest.html#getPartitions--"/> 
        /// </summary>
        public Java.Util.Set<Java.Lang.Integer> Partitions
        {
            get { return IExecuteWithSignature<Java.Util.Set<Java.Lang.Integer>>("getPartitions", "()Ljava/util/Set;"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/StateQueryRequest.html#getPositionBound--"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.Query.PositionBound PositionBound
        {
            get { return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.PositionBound>("getPositionBound", "()Lorg/apache/kafka/streams/query/PositionBound;"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/StateQueryRequest.html#getQuery--"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.Query.Query<R> Query
        {
            get { return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.Query<R>>("getQuery", "()Lorg/apache/kafka/streams/query/Query;"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/StateQueryRequest.html#getStoreName--"/> 
        /// </summary>
        public Java.Lang.String StoreName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getStoreName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/StateQueryRequest.html#executionInfoEnabled--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool ExecutionInfoEnabled()
        {
            return IExecuteWithSignature<bool>("executionInfoEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/StateQueryRequest.html#isAllPartitions--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAllPartitions()
        {
            return IExecuteWithSignature<bool>("isAllPartitions", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/StateQueryRequest.html#isRequireActive--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRequireActive()
        {
            return IExecuteWithSignature<bool>("isRequireActive", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/StateQueryRequest.html#enableExecutionInfo--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.StateQueryRequest"/></returns>
        public Org.Apache.Kafka.Streams.Query.StateQueryRequest<R> EnableExecutionInfo()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.StateQueryRequest<R>>("enableExecutionInfo", "()Lorg/apache/kafka/streams/query/StateQueryRequest;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/StateQueryRequest.html#requireActive--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.StateQueryRequest"/></returns>
        public Org.Apache.Kafka.Streams.Query.StateQueryRequest<R> RequireActive()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.StateQueryRequest<R>>("requireActive", "()Lorg/apache/kafka/streams/query/StateQueryRequest;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/StateQueryRequest.html#withAllPartitions--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.StateQueryRequest"/></returns>
        public Org.Apache.Kafka.Streams.Query.StateQueryRequest<R> WithAllPartitions()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.StateQueryRequest<R>>("withAllPartitions", "()Lorg/apache/kafka/streams/query/StateQueryRequest;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/StateQueryRequest.html#withPartitions-java.util.Set-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.StateQueryRequest"/></returns>
        public Org.Apache.Kafka.Streams.Query.StateQueryRequest<R> WithPartitions(Java.Util.Set<Java.Lang.Integer> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.StateQueryRequest<R>>("withPartitions", "(Ljava/util/Set;)Lorg/apache/kafka/streams/query/StateQueryRequest;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/StateQueryRequest.html#withPositionBound-org.apache.kafka.streams.query.PositionBound-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Query.PositionBound"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.StateQueryRequest"/></returns>
        public Org.Apache.Kafka.Streams.Query.StateQueryRequest<R> WithPositionBound(Org.Apache.Kafka.Streams.Query.PositionBound arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.StateQueryRequest<R>>("withPositionBound", "(Lorg/apache/kafka/streams/query/PositionBound;)Lorg/apache/kafka/streams/query/StateQueryRequest;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}