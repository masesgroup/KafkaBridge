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
*  using kafka-streams-3.9.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Query
{
    #region RangeQuery declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/query/RangeQuery.html"/>
    /// </summary>
    public partial class RangeQuery : Org.Apache.Kafka.Streams.Query.Query
    {
        const string _bridgeClassName = "org.apache.kafka.streams.query.RangeQuery";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public RangeQuery() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public RangeQuery(params object[] args) : base(args) { }

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

    #region RangeQuery<K, V> declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/query/RangeQuery.html"/>
    /// </summary>
    /// <typeparam name="K"></typeparam>
    /// <typeparam name="V"></typeparam>
    public partial class RangeQuery<K, V> : Org.Apache.Kafka.Streams.Query.Query<Org.Apache.Kafka.Streams.State.KeyValueIterator<K, V>>
    {
        const string _bridgeClassName = "org.apache.kafka.streams.query.RangeQuery";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public RangeQuery() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public RangeQuery(params object[] args) : base(args) { }

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

    #region RangeQuery implementation
    public partial class RangeQuery
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/query/RangeQuery.html#withLowerBound-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.RangeQuery"/></returns>
        public static Org.Apache.Kafka.Streams.Query.RangeQuery WithLowerBound(object arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Streams.Query.RangeQuery>(LocalBridgeClazz, "withLowerBound", "(Ljava/lang/Object;)Lorg/apache/kafka/streams/query/RangeQuery;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/query/RangeQuery.html#withNoBounds--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.RangeQuery"/></returns>
        public static Org.Apache.Kafka.Streams.Query.RangeQuery WithNoBounds()
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Streams.Query.RangeQuery>(LocalBridgeClazz, "withNoBounds", "()Lorg/apache/kafka/streams/query/RangeQuery;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/query/RangeQuery.html#withRange-java.lang.Object-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.RangeQuery"/></returns>
        public static Org.Apache.Kafka.Streams.Query.RangeQuery WithRange(object arg0, object arg1)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Streams.Query.RangeQuery>(LocalBridgeClazz, "withRange", "(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/kafka/streams/query/RangeQuery;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/query/RangeQuery.html#withUpperBound-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.RangeQuery"/></returns>
        public static Org.Apache.Kafka.Streams.Query.RangeQuery WithUpperBound(object arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Streams.Query.RangeQuery>(LocalBridgeClazz, "withUpperBound", "(Ljava/lang/Object;)Lorg/apache/kafka/streams/query/RangeQuery;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/query/RangeQuery.html#getLowerBound--"/> 
        /// </summary>
        public Java.Util.Optional LowerBound
        {
            get { return IExecuteWithSignature<Java.Util.Optional>("getLowerBound", "()Ljava/util/Optional;"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/query/RangeQuery.html#getUpperBound--"/> 
        /// </summary>
        public Java.Util.Optional UpperBound
        {
            get { return IExecuteWithSignature<Java.Util.Optional>("getUpperBound", "()Ljava/util/Optional;"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/query/RangeQuery.html#withAscendingKeys--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.RangeQuery"/></returns>
        public Org.Apache.Kafka.Streams.Query.RangeQuery WithAscendingKeys()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.RangeQuery>("withAscendingKeys", "()Lorg/apache/kafka/streams/query/RangeQuery;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/query/RangeQuery.html#withDescendingKeys--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.RangeQuery"/></returns>
        public Org.Apache.Kafka.Streams.Query.RangeQuery WithDescendingKeys()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.RangeQuery>("withDescendingKeys", "()Lorg/apache/kafka/streams/query/RangeQuery;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/query/RangeQuery.html#resultOrder--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.ResultOrder"/></returns>
        public Org.Apache.Kafka.Streams.Query.ResultOrder ResultOrder()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.ResultOrder>("resultOrder", "()Lorg/apache/kafka/streams/query/ResultOrder;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region RangeQuery<K, V> implementation
    public partial class RangeQuery<K, V>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Query.RangeQuery{K, V}"/> to <see cref="Org.Apache.Kafka.Streams.Query.RangeQuery"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Query.RangeQuery(Org.Apache.Kafka.Streams.Query.RangeQuery<K, V> t) => t.Cast<Org.Apache.Kafka.Streams.Query.RangeQuery>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/query/RangeQuery.html#withLowerBound-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.RangeQuery"/></returns>
        public static Org.Apache.Kafka.Streams.Query.RangeQuery<K, V> WithLowerBound(K arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Streams.Query.RangeQuery<K, V>>(LocalBridgeClazz, "withLowerBound", "(Ljava/lang/Object;)Lorg/apache/kafka/streams/query/RangeQuery;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/query/RangeQuery.html#withNoBounds--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.RangeQuery"/></returns>
        public static Org.Apache.Kafka.Streams.Query.RangeQuery<K, V> WithNoBounds()
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Streams.Query.RangeQuery<K, V>>(LocalBridgeClazz, "withNoBounds", "()Lorg/apache/kafka/streams/query/RangeQuery;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/query/RangeQuery.html#withRange-java.lang.Object-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><typeparamref name="K"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.RangeQuery"/></returns>
        public static Org.Apache.Kafka.Streams.Query.RangeQuery<K, V> WithRange(K arg0, K arg1)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Streams.Query.RangeQuery<K, V>>(LocalBridgeClazz, "withRange", "(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/kafka/streams/query/RangeQuery;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/query/RangeQuery.html#withUpperBound-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.RangeQuery"/></returns>
        public static Org.Apache.Kafka.Streams.Query.RangeQuery<K, V> WithUpperBound(K arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Streams.Query.RangeQuery<K, V>>(LocalBridgeClazz, "withUpperBound", "(Ljava/lang/Object;)Lorg/apache/kafka/streams/query/RangeQuery;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/query/RangeQuery.html#getLowerBound--"/> 
        /// </summary>
        public Java.Util.Optional<K> LowerBound
        {
            get { return IExecuteWithSignature<Java.Util.Optional<K>>("getLowerBound", "()Ljava/util/Optional;"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/query/RangeQuery.html#getUpperBound--"/> 
        /// </summary>
        public Java.Util.Optional<K> UpperBound
        {
            get { return IExecuteWithSignature<Java.Util.Optional<K>>("getUpperBound", "()Ljava/util/Optional;"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/query/RangeQuery.html#withAscendingKeys--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.RangeQuery"/></returns>
        public Org.Apache.Kafka.Streams.Query.RangeQuery<K, V> WithAscendingKeys()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.RangeQuery<K, V>>("withAscendingKeys", "()Lorg/apache/kafka/streams/query/RangeQuery;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/query/RangeQuery.html#withDescendingKeys--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.RangeQuery"/></returns>
        public Org.Apache.Kafka.Streams.Query.RangeQuery<K, V> WithDescendingKeys()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.RangeQuery<K, V>>("withDescendingKeys", "()Lorg/apache/kafka/streams/query/RangeQuery;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/query/RangeQuery.html#resultOrder--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.ResultOrder"/></returns>
        public Org.Apache.Kafka.Streams.Query.ResultOrder ResultOrder()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.ResultOrder>("resultOrder", "()Lorg/apache/kafka/streams/query/ResultOrder;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}