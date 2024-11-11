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
    #region TimestampedRangeQuery declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/query/TimestampedRangeQuery.html"/>
    /// </summary>
    public partial class TimestampedRangeQuery : Org.Apache.Kafka.Streams.Query.Query
    {
        const string _bridgeClassName = "org.apache.kafka.streams.query.TimestampedRangeQuery";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TimestampedRangeQuery() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TimestampedRangeQuery(params object[] args) : base(args) { }

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

    #region TimestampedRangeQuery<K, V> declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/query/TimestampedRangeQuery.html"/>
    /// </summary>
    /// <typeparam name="K"></typeparam>
    /// <typeparam name="V"></typeparam>
    public partial class TimestampedRangeQuery<K, V> : Org.Apache.Kafka.Streams.Query.Query<Org.Apache.Kafka.Streams.State.KeyValueIterator<K, Org.Apache.Kafka.Streams.State.ValueAndTimestamp<V>>>
    {
        const string _bridgeClassName = "org.apache.kafka.streams.query.TimestampedRangeQuery";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TimestampedRangeQuery() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TimestampedRangeQuery(params object[] args) : base(args) { }

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

    #region TimestampedRangeQuery implementation
    public partial class TimestampedRangeQuery
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/query/TimestampedRangeQuery.html#withLowerBound-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.TimestampedRangeQuery"/></returns>
        public static Org.Apache.Kafka.Streams.Query.TimestampedRangeQuery WithLowerBound(object arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Streams.Query.TimestampedRangeQuery>(LocalBridgeClazz, "withLowerBound", "(Ljava/lang/Object;)Lorg/apache/kafka/streams/query/TimestampedRangeQuery;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/query/TimestampedRangeQuery.html#withNoBounds--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.TimestampedRangeQuery"/></returns>
        public static Org.Apache.Kafka.Streams.Query.TimestampedRangeQuery WithNoBounds()
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Streams.Query.TimestampedRangeQuery>(LocalBridgeClazz, "withNoBounds", "()Lorg/apache/kafka/streams/query/TimestampedRangeQuery;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/query/TimestampedRangeQuery.html#withRange-java.lang.Object-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.TimestampedRangeQuery"/></returns>
        public static Org.Apache.Kafka.Streams.Query.TimestampedRangeQuery WithRange(object arg0, object arg1)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Streams.Query.TimestampedRangeQuery>(LocalBridgeClazz, "withRange", "(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/kafka/streams/query/TimestampedRangeQuery;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/query/TimestampedRangeQuery.html#withUpperBound-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.TimestampedRangeQuery"/></returns>
        public static Org.Apache.Kafka.Streams.Query.TimestampedRangeQuery WithUpperBound(object arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Streams.Query.TimestampedRangeQuery>(LocalBridgeClazz, "withUpperBound", "(Ljava/lang/Object;)Lorg/apache/kafka/streams/query/TimestampedRangeQuery;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/query/TimestampedRangeQuery.html#lowerBound--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional LowerBound()
        {
            return IExecuteWithSignature<Java.Util.Optional>("lowerBound", "()Ljava/util/Optional;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/query/TimestampedRangeQuery.html#upperBound--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional UpperBound()
        {
            return IExecuteWithSignature<Java.Util.Optional>("upperBound", "()Ljava/util/Optional;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/query/TimestampedRangeQuery.html#resultOrder--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.ResultOrder"/></returns>
        public Org.Apache.Kafka.Streams.Query.ResultOrder ResultOrder()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.ResultOrder>("resultOrder", "()Lorg/apache/kafka/streams/query/ResultOrder;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/query/TimestampedRangeQuery.html#withAscendingKeys--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.TimestampedRangeQuery"/></returns>
        public Org.Apache.Kafka.Streams.Query.TimestampedRangeQuery WithAscendingKeys()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.TimestampedRangeQuery>("withAscendingKeys", "()Lorg/apache/kafka/streams/query/TimestampedRangeQuery;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/query/TimestampedRangeQuery.html#withDescendingKeys--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.TimestampedRangeQuery"/></returns>
        public Org.Apache.Kafka.Streams.Query.TimestampedRangeQuery WithDescendingKeys()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.TimestampedRangeQuery>("withDescendingKeys", "()Lorg/apache/kafka/streams/query/TimestampedRangeQuery;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TimestampedRangeQuery<K, V> implementation
    public partial class TimestampedRangeQuery<K, V>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Query.TimestampedRangeQuery{K, V}"/> to <see cref="Org.Apache.Kafka.Streams.Query.TimestampedRangeQuery"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Query.TimestampedRangeQuery(Org.Apache.Kafka.Streams.Query.TimestampedRangeQuery<K, V> t) => t.Cast<Org.Apache.Kafka.Streams.Query.TimestampedRangeQuery>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/query/TimestampedRangeQuery.html#withLowerBound-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.TimestampedRangeQuery"/></returns>
        public static Org.Apache.Kafka.Streams.Query.TimestampedRangeQuery<K, V> WithLowerBound(K arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Streams.Query.TimestampedRangeQuery<K, V>>(LocalBridgeClazz, "withLowerBound", "(Ljava/lang/Object;)Lorg/apache/kafka/streams/query/TimestampedRangeQuery;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/query/TimestampedRangeQuery.html#withNoBounds--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.TimestampedRangeQuery"/></returns>
        public static Org.Apache.Kafka.Streams.Query.TimestampedRangeQuery<K, V> WithNoBounds()
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Streams.Query.TimestampedRangeQuery<K, V>>(LocalBridgeClazz, "withNoBounds", "()Lorg/apache/kafka/streams/query/TimestampedRangeQuery;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/query/TimestampedRangeQuery.html#withRange-java.lang.Object-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><typeparamref name="K"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.TimestampedRangeQuery"/></returns>
        public static Org.Apache.Kafka.Streams.Query.TimestampedRangeQuery<K, V> WithRange(K arg0, K arg1)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Streams.Query.TimestampedRangeQuery<K, V>>(LocalBridgeClazz, "withRange", "(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/kafka/streams/query/TimestampedRangeQuery;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/query/TimestampedRangeQuery.html#withUpperBound-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.TimestampedRangeQuery"/></returns>
        public static Org.Apache.Kafka.Streams.Query.TimestampedRangeQuery<K, V> WithUpperBound(K arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Streams.Query.TimestampedRangeQuery<K, V>>(LocalBridgeClazz, "withUpperBound", "(Ljava/lang/Object;)Lorg/apache/kafka/streams/query/TimestampedRangeQuery;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/query/TimestampedRangeQuery.html#lowerBound--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<K> LowerBound()
        {
            return IExecuteWithSignature<Java.Util.Optional<K>>("lowerBound", "()Ljava/util/Optional;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/query/TimestampedRangeQuery.html#upperBound--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<K> UpperBound()
        {
            return IExecuteWithSignature<Java.Util.Optional<K>>("upperBound", "()Ljava/util/Optional;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/query/TimestampedRangeQuery.html#resultOrder--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.ResultOrder"/></returns>
        public Org.Apache.Kafka.Streams.Query.ResultOrder ResultOrder()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.ResultOrder>("resultOrder", "()Lorg/apache/kafka/streams/query/ResultOrder;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/query/TimestampedRangeQuery.html#withAscendingKeys--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.TimestampedRangeQuery"/></returns>
        public Org.Apache.Kafka.Streams.Query.TimestampedRangeQuery<K, V> WithAscendingKeys()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.TimestampedRangeQuery<K, V>>("withAscendingKeys", "()Lorg/apache/kafka/streams/query/TimestampedRangeQuery;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/query/TimestampedRangeQuery.html#withDescendingKeys--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.TimestampedRangeQuery"/></returns>
        public Org.Apache.Kafka.Streams.Query.TimestampedRangeQuery<K, V> WithDescendingKeys()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.TimestampedRangeQuery<K, V>>("withDescendingKeys", "()Lorg/apache/kafka/streams/query/TimestampedRangeQuery;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}