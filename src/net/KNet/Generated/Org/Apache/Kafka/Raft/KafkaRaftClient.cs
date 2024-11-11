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
*  using kafka-raft-3.9.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Raft
{
    #region KafkaRaftClient declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html"/>
    /// </summary>
    public partial class KafkaRaftClient : Org.Apache.Kafka.Raft.RaftClient
    {
        const string _bridgeClassName = "org.apache.kafka.raft.KafkaRaftClient";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public KafkaRaftClient() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public KafkaRaftClient(params object[] args) : base(args) { }

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

    #region KafkaRaftClient<T> declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public partial class KafkaRaftClient<T> : Org.Apache.Kafka.Raft.RaftClient<T>
    {
        const string _bridgeClassName = "org.apache.kafka.raft.KafkaRaftClient";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public KafkaRaftClient() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public KafkaRaftClient(params object[] args) : base(args) { }

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

    #region KafkaRaftClient implementation
    public partial class KafkaRaftClient
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#MAX_BATCH_SIZE_BYTES"/>
        /// </summary>
        public static int MAX_BATCH_SIZE_BYTES { get { if (!_MAX_BATCH_SIZE_BYTESReady) { _MAX_BATCH_SIZE_BYTESContent = SGetField<int>(LocalBridgeClazz, "MAX_BATCH_SIZE_BYTES"); _MAX_BATCH_SIZE_BYTESReady = true; } return _MAX_BATCH_SIZE_BYTESContent; } }
        private static int _MAX_BATCH_SIZE_BYTESContent = default;
        private static bool _MAX_BATCH_SIZE_BYTESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#MAX_FETCH_SIZE_BYTES"/>
        /// </summary>
        public static int MAX_FETCH_SIZE_BYTES { get { if (!_MAX_FETCH_SIZE_BYTESReady) { _MAX_FETCH_SIZE_BYTESContent = SGetField<int>(LocalBridgeClazz, "MAX_FETCH_SIZE_BYTES"); _MAX_FETCH_SIZE_BYTESReady = true; } return _MAX_FETCH_SIZE_BYTESContent; } }
        private static int _MAX_FETCH_SIZE_BYTESContent = default;
        private static bool _MAX_FETCH_SIZE_BYTESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#MAX_FETCH_WAIT_MS"/>
        /// </summary>
        public static int MAX_FETCH_WAIT_MS { get { if (!_MAX_FETCH_WAIT_MSReady) { _MAX_FETCH_WAIT_MSContent = SGetField<int>(LocalBridgeClazz, "MAX_FETCH_WAIT_MS"); _MAX_FETCH_WAIT_MSReady = true; } return _MAX_FETCH_WAIT_MSContent; } }
        private static int _MAX_FETCH_WAIT_MSContent = default;
        private static bool _MAX_FETCH_WAIT_MSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#isRunning--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRunning()
        {
            return IExecuteWithSignature<bool>("isRunning", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#isShuttingDown--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsShuttingDown()
        {
            return IExecuteWithSignature<bool>("isShuttingDown", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#shutdown-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletableFuture"/></returns>
        public Java.Util.Concurrent.CompletableFuture Shutdown(int arg0)
        {
            return IExecuteWithSignature<Java.Util.Concurrent.CompletableFuture>("shutdown", "(I)Ljava/util/concurrent/CompletableFuture;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#latestSnapshotId--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional LatestSnapshotId()
        {
            return IExecuteWithSignature<Java.Util.Optional>("latestSnapshotId", "()Ljava/util/Optional;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#createSnapshot-org.apache.kafka.raft.OffsetAndEpoch-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Raft.OffsetAndEpoch"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional CreateSnapshot(Org.Apache.Kafka.Raft.OffsetAndEpoch arg0, long arg1)
        {
            return IExecuteWithSignature<Java.Util.Optional>("createSnapshot", "(Lorg/apache/kafka/raft/OffsetAndEpoch;J)Ljava/util/Optional;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#nodeId--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.OptionalInt"/></returns>
        public Java.Util.OptionalInt NodeId()
        {
            return IExecuteWithSignature<Java.Util.OptionalInt>("nodeId", "()Ljava/util/OptionalInt;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#highWatermark--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.OptionalLong"/></returns>
        public Java.Util.OptionalLong HighWatermark()
        {
            return IExecuteWithSignature<Java.Util.OptionalLong>("highWatermark", "()Ljava/util/OptionalLong;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#logEndOffset--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long LogEndOffset()
        {
            return IExecuteWithSignature<long>("logEndOffset", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#prepareAppend-int-java.util.List-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="long"/></returns>
        public long PrepareAppend(int arg0, Java.Util.List arg1)
        {
            return IExecuteWithSignature<long>("prepareAppend", "(ILjava/util/List;)J", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#leaderAndEpoch--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Raft.LeaderAndEpoch"/></returns>
        public Org.Apache.Kafka.Raft.LeaderAndEpoch LeaderAndEpoch()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.LeaderAndEpoch>("leaderAndEpoch", "()Lorg/apache/kafka/raft/LeaderAndEpoch;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#handle-org.apache.kafka.raft.RaftRequest.Inbound-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Raft.RaftRequest.Inbound"/></param>
        public void Handle(Org.Apache.Kafka.Raft.RaftRequest.Inbound arg0)
        {
            IExecuteWithSignature("handle", "(Lorg/apache/kafka/raft/RaftRequest$Inbound;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#initialize-java.util.Map-org.apache.kafka.raft.QuorumStateStore-org.apache.kafka.common.metrics.Metrics-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Raft.QuorumStateStore"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Metrics.Metrics"/></param>
        public void Initialize(Java.Util.Map arg0, Org.Apache.Kafka.Raft.QuorumStateStore arg1, Org.Apache.Kafka.Common.Metrics.Metrics arg2)
        {
            IExecuteWithSignature("initialize", "(Ljava/util/Map;Lorg/apache/kafka/raft/QuorumStateStore;Lorg/apache/kafka/common/metrics/Metrics;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#poll--"/>
        /// </summary>
        public void Poll()
        {
            IExecuteWithSignature("poll", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#register-org.apache.kafka.raft.RaftClient.Listener-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Raft.RaftClient.Listener"/></param>
        public void Register(Org.Apache.Kafka.Raft.RaftClient.Listener arg0)
        {
            IExecuteWithSignature("register", "(Lorg/apache/kafka/raft/RaftClient$Listener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#resign-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Resign(int arg0)
        {
            IExecuteWithSignature("resign", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#schedulePreparedAppend--"/>
        /// </summary>
        public void SchedulePreparedAppend()
        {
            IExecuteWithSignature("schedulePreparedAppend", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#unregister-org.apache.kafka.raft.RaftClient.Listener-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Raft.RaftClient.Listener"/></param>
        public void Unregister(Org.Apache.Kafka.Raft.RaftClient.Listener arg0)
        {
            IExecuteWithSignature("unregister", "(Lorg/apache/kafka/raft/RaftClient$Listener;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region KafkaRaftClient<T> implementation
    public partial class KafkaRaftClient<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Raft.KafkaRaftClient{T}"/> to <see cref="Org.Apache.Kafka.Raft.KafkaRaftClient"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Raft.KafkaRaftClient(Org.Apache.Kafka.Raft.KafkaRaftClient<T> t) => t.Cast<Org.Apache.Kafka.Raft.KafkaRaftClient>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#MAX_BATCH_SIZE_BYTES"/>
        /// </summary>
        public static int MAX_BATCH_SIZE_BYTES { get { if (!_MAX_BATCH_SIZE_BYTESReady) { _MAX_BATCH_SIZE_BYTESContent = SGetField<int>(LocalBridgeClazz, "MAX_BATCH_SIZE_BYTES"); _MAX_BATCH_SIZE_BYTESReady = true; } return _MAX_BATCH_SIZE_BYTESContent; } }
        private static int _MAX_BATCH_SIZE_BYTESContent = default;
        private static bool _MAX_BATCH_SIZE_BYTESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#MAX_FETCH_SIZE_BYTES"/>
        /// </summary>
        public static int MAX_FETCH_SIZE_BYTES { get { if (!_MAX_FETCH_SIZE_BYTESReady) { _MAX_FETCH_SIZE_BYTESContent = SGetField<int>(LocalBridgeClazz, "MAX_FETCH_SIZE_BYTES"); _MAX_FETCH_SIZE_BYTESReady = true; } return _MAX_FETCH_SIZE_BYTESContent; } }
        private static int _MAX_FETCH_SIZE_BYTESContent = default;
        private static bool _MAX_FETCH_SIZE_BYTESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#MAX_FETCH_WAIT_MS"/>
        /// </summary>
        public static int MAX_FETCH_WAIT_MS { get { if (!_MAX_FETCH_WAIT_MSReady) { _MAX_FETCH_WAIT_MSContent = SGetField<int>(LocalBridgeClazz, "MAX_FETCH_WAIT_MS"); _MAX_FETCH_WAIT_MSReady = true; } return _MAX_FETCH_WAIT_MSContent; } }
        private static int _MAX_FETCH_WAIT_MSContent = default;
        private static bool _MAX_FETCH_WAIT_MSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#isRunning--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRunning()
        {
            return IExecuteWithSignature<bool>("isRunning", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#isShuttingDown--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsShuttingDown()
        {
            return IExecuteWithSignature<bool>("isShuttingDown", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#shutdown-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletableFuture"/></returns>
        public Java.Util.Concurrent.CompletableFuture<Java.Lang.Void> Shutdown(int arg0)
        {
            return IExecuteWithSignature<Java.Util.Concurrent.CompletableFuture<Java.Lang.Void>>("shutdown", "(I)Ljava/util/concurrent/CompletableFuture;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#latestSnapshotId--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Org.Apache.Kafka.Raft.OffsetAndEpoch> LatestSnapshotId()
        {
            return IExecuteWithSignature<Java.Util.Optional<Org.Apache.Kafka.Raft.OffsetAndEpoch>>("latestSnapshotId", "()Ljava/util/Optional;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#createSnapshot-org.apache.kafka.raft.OffsetAndEpoch-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Raft.OffsetAndEpoch"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Org.Apache.Kafka.Snapshot.SnapshotWriter<T>> CreateSnapshot(Org.Apache.Kafka.Raft.OffsetAndEpoch arg0, long arg1)
        {
            return IExecuteWithSignature<Java.Util.Optional<Org.Apache.Kafka.Snapshot.SnapshotWriter<T>>>("createSnapshot", "(Lorg/apache/kafka/raft/OffsetAndEpoch;J)Ljava/util/Optional;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#nodeId--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.OptionalInt"/></returns>
        public Java.Util.OptionalInt NodeId()
        {
            return IExecuteWithSignature<Java.Util.OptionalInt>("nodeId", "()Ljava/util/OptionalInt;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#highWatermark--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.OptionalLong"/></returns>
        public Java.Util.OptionalLong HighWatermark()
        {
            return IExecuteWithSignature<Java.Util.OptionalLong>("highWatermark", "()Ljava/util/OptionalLong;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#logEndOffset--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long LogEndOffset()
        {
            return IExecuteWithSignature<long>("logEndOffset", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#prepareAppend-int-java.util.List-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="long"/></returns>
        public long PrepareAppend(int arg0, Java.Util.List<T> arg1)
        {
            return IExecuteWithSignature<long>("prepareAppend", "(ILjava/util/List;)J", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#leaderAndEpoch--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Raft.LeaderAndEpoch"/></returns>
        public Org.Apache.Kafka.Raft.LeaderAndEpoch LeaderAndEpoch()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.LeaderAndEpoch>("leaderAndEpoch", "()Lorg/apache/kafka/raft/LeaderAndEpoch;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#handle-org.apache.kafka.raft.RaftRequest.Inbound-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Raft.RaftRequest.Inbound"/></param>
        public void Handle(Org.Apache.Kafka.Raft.RaftRequest.Inbound arg0)
        {
            IExecuteWithSignature("handle", "(Lorg/apache/kafka/raft/RaftRequest$Inbound;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#initialize-java.util.Map-org.apache.kafka.raft.QuorumStateStore-org.apache.kafka.common.metrics.Metrics-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Raft.QuorumStateStore"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Metrics.Metrics"/></param>
        public void Initialize(Java.Util.Map<Java.Lang.Integer, Java.Net.InetSocketAddress> arg0, Org.Apache.Kafka.Raft.QuorumStateStore arg1, Org.Apache.Kafka.Common.Metrics.Metrics arg2)
        {
            IExecuteWithSignature("initialize", "(Ljava/util/Map;Lorg/apache/kafka/raft/QuorumStateStore;Lorg/apache/kafka/common/metrics/Metrics;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#poll--"/>
        /// </summary>
        public void Poll()
        {
            IExecuteWithSignature("poll", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#register-org.apache.kafka.raft.RaftClient.Listener-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Raft.RaftClient.Listener"/></param>
        public void Register(Org.Apache.Kafka.Raft.RaftClient.Listener<T> arg0)
        {
            IExecuteWithSignature("register", "(Lorg/apache/kafka/raft/RaftClient$Listener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#resign-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Resign(int arg0)
        {
            IExecuteWithSignature("resign", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#schedulePreparedAppend--"/>
        /// </summary>
        public void SchedulePreparedAppend()
        {
            IExecuteWithSignature("schedulePreparedAppend", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/KafkaRaftClient.html#unregister-org.apache.kafka.raft.RaftClient.Listener-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Raft.RaftClient.Listener"/></param>
        public void Unregister(Org.Apache.Kafka.Raft.RaftClient.Listener<T> arg0)
        {
            IExecuteWithSignature("unregister", "(Lorg/apache/kafka/raft/RaftClient$Listener;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}