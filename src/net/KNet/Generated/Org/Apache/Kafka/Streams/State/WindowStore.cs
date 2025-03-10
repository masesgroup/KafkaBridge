/*
*  Copyright 2025 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.5.12.0)
*  using kafka-streams-3.9.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.State
{
    #region WindowStore declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/state/WindowStore.html"/>
    /// </summary>
    public partial class WindowStore : MASES.JCOBridge.C2JBridge.JVMBridgeBase<WindowStore>
    {
        const string _bridgeClassName = "org.apache.kafka.streams.state.WindowStore";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("WindowStore class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public WindowStore() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("WindowStore class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public WindowStore(params object[] args) : base(args) { }

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

    #region WindowStore<K, V> declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/state/WindowStore.html"/>
    /// </summary>
    /// <typeparam name="K"></typeparam>
    /// <typeparam name="V"></typeparam>
    public partial class WindowStore<K, V> : MASES.JCOBridge.C2JBridge.JVMBridgeBase<WindowStore<K, V>>
    {
        const string _bridgeClassName = "org.apache.kafka.streams.state.WindowStore";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("WindowStore class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public WindowStore() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("WindowStore class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public WindowStore(params object[] args) : base(args) { }

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

    #region WindowStore implementation
    public partial class WindowStore
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.State.WindowStore"/> to <see cref="Org.Apache.Kafka.Streams.Processor.StateStore"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Processor.StateStore(Org.Apache.Kafka.Streams.State.WindowStore t) => t.Cast<Org.Apache.Kafka.Streams.Processor.StateStore>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.State.WindowStore"/> to <see cref="Org.Apache.Kafka.Streams.State.ReadOnlyWindowStore"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.State.ReadOnlyWindowStore(Org.Apache.Kafka.Streams.State.WindowStore t) => t.Cast<Org.Apache.Kafka.Streams.State.ReadOnlyWindowStore>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/state/WindowStore.html#fetch-java.lang.Object-java.lang.Object-long-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator Fetch(object arg0, object arg1, long arg2, long arg3)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.State.KeyValueIterator>("fetch", "(Ljava/lang/Object;Ljava/lang/Object;JJ)Lorg/apache/kafka/streams/state/KeyValueIterator;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/state/WindowStore.html#fetchAll-long-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator FetchAll(long arg0, long arg1)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.State.KeyValueIterator>("fetchAll", "(JJ)Lorg/apache/kafka/streams/state/KeyValueIterator;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/state/WindowStore.html#fetch-java.lang.Object-long-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.WindowStoreIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.WindowStoreIterator Fetch(object arg0, long arg1, long arg2)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.State.WindowStoreIterator>("fetch", "(Ljava/lang/Object;JJ)Lorg/apache/kafka/streams/state/WindowStoreIterator;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/state/WindowStore.html#put-java.lang.Object-java.lang.Object-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public void Put(object arg0, object arg1, long arg2)
        {
            IExecuteWithSignature("put", "(Ljava/lang/Object;Ljava/lang/Object;J)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/state/WindowStore.html#backwardFetch-java.lang.Object-java.lang.Object-java.time.Instant-java.time.Instant-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Java.Time.Instant"/></param>
        /// <param name="arg3"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator BackwardFetch(object arg0, object arg1, Java.Time.Instant arg2, Java.Time.Instant arg3)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.State.KeyValueIterator>("backwardFetch", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/time/Instant;Ljava/time/Instant;)Lorg/apache/kafka/streams/state/KeyValueIterator;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/state/WindowStore.html#backwardFetch-java.lang.Object-java.lang.Object-long-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator BackwardFetch(object arg0, object arg1, long arg2, long arg3)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.State.KeyValueIterator>("backwardFetch", "(Ljava/lang/Object;Ljava/lang/Object;JJ)Lorg/apache/kafka/streams/state/KeyValueIterator;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/state/WindowStore.html#backwardFetchAll-java.time.Instant-java.time.Instant-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <param name="arg1"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator BackwardFetchAll(Java.Time.Instant arg0, Java.Time.Instant arg1)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.State.KeyValueIterator>("backwardFetchAll", "(Ljava/time/Instant;Ljava/time/Instant;)Lorg/apache/kafka/streams/state/KeyValueIterator;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/state/WindowStore.html#backwardFetchAll-long-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator BackwardFetchAll(long arg0, long arg1)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.State.KeyValueIterator>("backwardFetchAll", "(JJ)Lorg/apache/kafka/streams/state/KeyValueIterator;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/state/WindowStore.html#fetch-java.lang.Object-java.lang.Object-java.time.Instant-java.time.Instant-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Java.Time.Instant"/></param>
        /// <param name="arg3"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator Fetch(object arg0, object arg1, Java.Time.Instant arg2, Java.Time.Instant arg3)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.State.KeyValueIterator>("fetch", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/time/Instant;Ljava/time/Instant;)Lorg/apache/kafka/streams/state/KeyValueIterator;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/state/WindowStore.html#fetchAll-java.time.Instant-java.time.Instant-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <param name="arg1"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator FetchAll(Java.Time.Instant arg0, Java.Time.Instant arg1)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.State.KeyValueIterator>("fetchAll", "(Ljava/time/Instant;Ljava/time/Instant;)Lorg/apache/kafka/streams/state/KeyValueIterator;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/state/WindowStore.html#backwardFetch-java.lang.Object-java.time.Instant-java.time.Instant-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Time.Instant"/></param>
        /// <param name="arg2"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.WindowStoreIterator"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public Org.Apache.Kafka.Streams.State.WindowStoreIterator BackwardFetch(object arg0, Java.Time.Instant arg1, Java.Time.Instant arg2)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.State.WindowStoreIterator>("backwardFetch", "(Ljava/lang/Object;Ljava/time/Instant;Ljava/time/Instant;)Lorg/apache/kafka/streams/state/WindowStoreIterator;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/state/WindowStore.html#backwardFetch-java.lang.Object-long-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.WindowStoreIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.WindowStoreIterator BackwardFetch(object arg0, long arg1, long arg2)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.State.WindowStoreIterator>("backwardFetch", "(Ljava/lang/Object;JJ)Lorg/apache/kafka/streams/state/WindowStoreIterator;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/state/WindowStore.html#fetch-java.lang.Object-java.time.Instant-java.time.Instant-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Time.Instant"/></param>
        /// <param name="arg2"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.WindowStoreIterator"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public Org.Apache.Kafka.Streams.State.WindowStoreIterator Fetch(object arg0, Java.Time.Instant arg1, Java.Time.Instant arg2)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.State.WindowStoreIterator>("fetch", "(Ljava/lang/Object;Ljava/time/Instant;Ljava/time/Instant;)Lorg/apache/kafka/streams/state/WindowStoreIterator;", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IWindowStore<K, V>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IWindowStore<K, V>
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region WindowStore<K, V> implementation
    public partial class WindowStore<K, V> : Org.Apache.Kafka.Streams.State.IWindowStore<K, V>, Org.Apache.Kafka.Streams.Processor.IStateStore, Org.Apache.Kafka.Streams.State.IReadOnlyWindowStore<K, V>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.State.WindowStore{K, V}"/> to <see cref="Org.Apache.Kafka.Streams.Processor.StateStore"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Processor.StateStore(Org.Apache.Kafka.Streams.State.WindowStore<K, V> t) => t.Cast<Org.Apache.Kafka.Streams.Processor.StateStore>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.State.WindowStore{K, V}"/> to <see cref="Org.Apache.Kafka.Streams.State.ReadOnlyWindowStore{K, V}"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.State.ReadOnlyWindowStore<K, V>(Org.Apache.Kafka.Streams.State.WindowStore<K, V> t) => t.Cast<Org.Apache.Kafka.Streams.State.ReadOnlyWindowStore<K, V>>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.State.WindowStore{K, V}"/> to <see cref="Org.Apache.Kafka.Streams.State.WindowStore"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.State.WindowStore(Org.Apache.Kafka.Streams.State.WindowStore<K, V> t) => t.Cast<Org.Apache.Kafka.Streams.State.WindowStore>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/state/WindowStore.html#fetch-java.lang.Object-java.lang.Object-long-long-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><typeparamref name="K"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, V> Fetch(K arg0, K arg1, long arg2, long arg3)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, V>>("fetch", "(Ljava/lang/Object;Ljava/lang/Object;JJ)Lorg/apache/kafka/streams/state/KeyValueIterator;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/state/WindowStore.html#fetchAll-long-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, V> FetchAll(long arg0, long arg1)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, V>>("fetchAll", "(JJ)Lorg/apache/kafka/streams/state/KeyValueIterator;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/state/WindowStore.html#fetch-java.lang.Object-long-long-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.WindowStoreIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.WindowStoreIterator<V> Fetch(K arg0, long arg1, long arg2)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.State.WindowStoreIterator<V>>("fetch", "(Ljava/lang/Object;JJ)Lorg/apache/kafka/streams/state/WindowStoreIterator;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/state/WindowStore.html#put-java.lang.Object-java.lang.Object-long-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public void Put(K arg0, V arg1, long arg2)
        {
            IExecuteWithSignature("put", "(Ljava/lang/Object;Ljava/lang/Object;J)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/state/WindowStore.html#backwardFetch-java.lang.Object-java.lang.Object-java.time.Instant-java.time.Instant-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><typeparamref name="K"/></param>
        /// <param name="arg2"><see cref="Java.Time.Instant"/></param>
        /// <param name="arg3"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, V> BackwardFetch(K arg0, K arg1, Java.Time.Instant arg2, Java.Time.Instant arg3)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, V>>("backwardFetch", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/time/Instant;Ljava/time/Instant;)Lorg/apache/kafka/streams/state/KeyValueIterator;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/state/WindowStore.html#backwardFetch-java.lang.Object-java.lang.Object-long-long-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><typeparamref name="K"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, V> BackwardFetch(K arg0, K arg1, long arg2, long arg3)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, V>>("backwardFetch", "(Ljava/lang/Object;Ljava/lang/Object;JJ)Lorg/apache/kafka/streams/state/KeyValueIterator;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/state/WindowStore.html#backwardFetchAll-java.time.Instant-java.time.Instant-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <param name="arg1"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, V> BackwardFetchAll(Java.Time.Instant arg0, Java.Time.Instant arg1)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, V>>("backwardFetchAll", "(Ljava/time/Instant;Ljava/time/Instant;)Lorg/apache/kafka/streams/state/KeyValueIterator;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/state/WindowStore.html#backwardFetchAll-long-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, V> BackwardFetchAll(long arg0, long arg1)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, V>>("backwardFetchAll", "(JJ)Lorg/apache/kafka/streams/state/KeyValueIterator;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/state/WindowStore.html#fetch-java.lang.Object-java.lang.Object-java.time.Instant-java.time.Instant-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><typeparamref name="K"/></param>
        /// <param name="arg2"><see cref="Java.Time.Instant"/></param>
        /// <param name="arg3"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, V> Fetch(K arg0, K arg1, Java.Time.Instant arg2, Java.Time.Instant arg3)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, V>>("fetch", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/time/Instant;Ljava/time/Instant;)Lorg/apache/kafka/streams/state/KeyValueIterator;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/state/WindowStore.html#fetchAll-java.time.Instant-java.time.Instant-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <param name="arg1"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueIterator"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, V> FetchAll(Java.Time.Instant arg0, Java.Time.Instant arg1)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.State.KeyValueIterator<Org.Apache.Kafka.Streams.Kstream.Windowed<K>, V>>("fetchAll", "(Ljava/time/Instant;Ljava/time/Instant;)Lorg/apache/kafka/streams/state/KeyValueIterator;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/state/WindowStore.html#backwardFetch-java.lang.Object-java.time.Instant-java.time.Instant-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><see cref="Java.Time.Instant"/></param>
        /// <param name="arg2"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.WindowStoreIterator"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public Org.Apache.Kafka.Streams.State.WindowStoreIterator<V> BackwardFetch(K arg0, Java.Time.Instant arg1, Java.Time.Instant arg2)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.State.WindowStoreIterator<V>>("backwardFetch", "(Ljava/lang/Object;Ljava/time/Instant;Ljava/time/Instant;)Lorg/apache/kafka/streams/state/WindowStoreIterator;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/state/WindowStore.html#backwardFetch-java.lang.Object-long-long-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.WindowStoreIterator"/></returns>
        public Org.Apache.Kafka.Streams.State.WindowStoreIterator<V> BackwardFetch(K arg0, long arg1, long arg2)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.State.WindowStoreIterator<V>>("backwardFetch", "(Ljava/lang/Object;JJ)Lorg/apache/kafka/streams/state/WindowStoreIterator;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/state/WindowStore.html#fetch-java.lang.Object-java.time.Instant-java.time.Instant-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><see cref="Java.Time.Instant"/></param>
        /// <param name="arg2"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.WindowStoreIterator"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public Org.Apache.Kafka.Streams.State.WindowStoreIterator<V> Fetch(K arg0, Java.Time.Instant arg1, Java.Time.Instant arg2)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.State.WindowStoreIterator<V>>("fetch", "(Ljava/lang/Object;Ljava/time/Instant;Ljava/time/Instant;)Lorg/apache/kafka/streams/state/WindowStoreIterator;", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}