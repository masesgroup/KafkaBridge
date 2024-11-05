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

namespace Org.Apache.Kafka.Streams.Query
{
    #region MultiVersionedKeyQuery declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/query/MultiVersionedKeyQuery.html"/>
    /// </summary>
    public partial class MultiVersionedKeyQuery : Org.Apache.Kafka.Streams.Query.Query
    {
        const string _bridgeClassName = "org.apache.kafka.streams.query.MultiVersionedKeyQuery";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public MultiVersionedKeyQuery() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public MultiVersionedKeyQuery(params object[] args) : base(args) { }

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

    #region MultiVersionedKeyQuery<K, V> declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/query/MultiVersionedKeyQuery.html"/>
    /// </summary>
    /// <typeparam name="K"></typeparam>
    /// <typeparam name="V"></typeparam>
    public partial class MultiVersionedKeyQuery<K, V> : Org.Apache.Kafka.Streams.Query.Query<Org.Apache.Kafka.Streams.State.VersionedRecordIterator<V>>
    {
        const string _bridgeClassName = "org.apache.kafka.streams.query.MultiVersionedKeyQuery";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public MultiVersionedKeyQuery() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public MultiVersionedKeyQuery(params object[] args) : base(args) { }

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

    #region MultiVersionedKeyQuery implementation
    public partial class MultiVersionedKeyQuery
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/query/MultiVersionedKeyQuery.html#withKey-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.MultiVersionedKeyQuery"/></returns>
        public static Org.Apache.Kafka.Streams.Query.MultiVersionedKeyQuery WithKey(object arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Streams.Query.MultiVersionedKeyQuery>(LocalBridgeClazz, "withKey", "(Ljava/lang/Object;)Lorg/apache/kafka/streams/query/MultiVersionedKeyQuery;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/query/MultiVersionedKeyQuery.html#fromTime--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional FromTime()
        {
            return IExecuteWithSignature<Java.Util.Optional>("fromTime", "()Ljava/util/Optional;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/query/MultiVersionedKeyQuery.html#toTime--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional ToTime()
        {
            return IExecuteWithSignature<Java.Util.Optional>("toTime", "()Ljava/util/Optional;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/query/MultiVersionedKeyQuery.html#key--"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object Key()
        {
            return IExecuteWithSignature("key", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/query/MultiVersionedKeyQuery.html#fromTime-java.time.Instant-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.MultiVersionedKeyQuery"/></returns>
        public Org.Apache.Kafka.Streams.Query.MultiVersionedKeyQuery FromTime(Java.Time.Instant arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.MultiVersionedKeyQuery>("fromTime", "(Ljava/time/Instant;)Lorg/apache/kafka/streams/query/MultiVersionedKeyQuery;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/query/MultiVersionedKeyQuery.html#toTime-java.time.Instant-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.MultiVersionedKeyQuery"/></returns>
        public Org.Apache.Kafka.Streams.Query.MultiVersionedKeyQuery ToTime(Java.Time.Instant arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.MultiVersionedKeyQuery>("toTime", "(Ljava/time/Instant;)Lorg/apache/kafka/streams/query/MultiVersionedKeyQuery;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/query/MultiVersionedKeyQuery.html#withAscendingTimestamps--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.MultiVersionedKeyQuery"/></returns>
        public Org.Apache.Kafka.Streams.Query.MultiVersionedKeyQuery WithAscendingTimestamps()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.MultiVersionedKeyQuery>("withAscendingTimestamps", "()Lorg/apache/kafka/streams/query/MultiVersionedKeyQuery;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/query/MultiVersionedKeyQuery.html#withDescendingTimestamps--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.MultiVersionedKeyQuery"/></returns>
        public Org.Apache.Kafka.Streams.Query.MultiVersionedKeyQuery WithDescendingTimestamps()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.MultiVersionedKeyQuery>("withDescendingTimestamps", "()Lorg/apache/kafka/streams/query/MultiVersionedKeyQuery;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/query/MultiVersionedKeyQuery.html#resultOrder--"/>
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

    #region MultiVersionedKeyQuery<K, V> implementation
    public partial class MultiVersionedKeyQuery<K, V>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Query.MultiVersionedKeyQuery{K, V}"/> to <see cref="Org.Apache.Kafka.Streams.Query.MultiVersionedKeyQuery"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Query.MultiVersionedKeyQuery(Org.Apache.Kafka.Streams.Query.MultiVersionedKeyQuery<K, V> t) => t.Cast<Org.Apache.Kafka.Streams.Query.MultiVersionedKeyQuery>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/query/MultiVersionedKeyQuery.html#withKey-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.MultiVersionedKeyQuery"/></returns>
        public static Org.Apache.Kafka.Streams.Query.MultiVersionedKeyQuery<K, V> WithKey(K arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Streams.Query.MultiVersionedKeyQuery<K, V>>(LocalBridgeClazz, "withKey", "(Ljava/lang/Object;)Lorg/apache/kafka/streams/query/MultiVersionedKeyQuery;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/query/MultiVersionedKeyQuery.html#fromTime--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Java.Time.Instant> FromTime()
        {
            return IExecuteWithSignature<Java.Util.Optional<Java.Time.Instant>>("fromTime", "()Ljava/util/Optional;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/query/MultiVersionedKeyQuery.html#toTime--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Java.Time.Instant> ToTime()
        {
            return IExecuteWithSignature<Java.Util.Optional<Java.Time.Instant>>("toTime", "()Ljava/util/Optional;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/query/MultiVersionedKeyQuery.html#key--"/>
        /// </summary>
        /// <returns><typeparamref name="K"/></returns>
        public K Key()
        {
            return IExecuteWithSignature<K>("key", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/query/MultiVersionedKeyQuery.html#fromTime-java.time.Instant-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.MultiVersionedKeyQuery"/></returns>
        public Org.Apache.Kafka.Streams.Query.MultiVersionedKeyQuery<K, V> FromTime(Java.Time.Instant arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.MultiVersionedKeyQuery<K, V>>("fromTime", "(Ljava/time/Instant;)Lorg/apache/kafka/streams/query/MultiVersionedKeyQuery;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/query/MultiVersionedKeyQuery.html#toTime-java.time.Instant-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.MultiVersionedKeyQuery"/></returns>
        public Org.Apache.Kafka.Streams.Query.MultiVersionedKeyQuery<K, V> ToTime(Java.Time.Instant arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.MultiVersionedKeyQuery<K, V>>("toTime", "(Ljava/time/Instant;)Lorg/apache/kafka/streams/query/MultiVersionedKeyQuery;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/query/MultiVersionedKeyQuery.html#withAscendingTimestamps--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.MultiVersionedKeyQuery"/></returns>
        public Org.Apache.Kafka.Streams.Query.MultiVersionedKeyQuery<K, V> WithAscendingTimestamps()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.MultiVersionedKeyQuery<K, V>>("withAscendingTimestamps", "()Lorg/apache/kafka/streams/query/MultiVersionedKeyQuery;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/query/MultiVersionedKeyQuery.html#withDescendingTimestamps--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.MultiVersionedKeyQuery"/></returns>
        public Org.Apache.Kafka.Streams.Query.MultiVersionedKeyQuery<K, V> WithDescendingTimestamps()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.MultiVersionedKeyQuery<K, V>>("withDescendingTimestamps", "()Lorg/apache/kafka/streams/query/MultiVersionedKeyQuery;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/query/MultiVersionedKeyQuery.html#resultOrder--"/>
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