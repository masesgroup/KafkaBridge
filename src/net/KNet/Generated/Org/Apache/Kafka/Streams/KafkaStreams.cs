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

namespace Org.Apache.Kafka.Streams
{
    #region KafkaStreams
    public partial class KafkaStreams
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.html#org.apache.kafka.streams.KafkaStreams(org.apache.kafka.streams.Topology,java.util.Properties,org.apache.kafka.common.utils.Time)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Topology"/></param>
        /// <param name="arg1"><see cref="Java.Util.Properties"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Utils.Time"/></param>
        public KafkaStreams(Org.Apache.Kafka.Streams.Topology arg0, Java.Util.Properties arg1, Org.Apache.Kafka.Common.Utils.Time arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.html#org.apache.kafka.streams.KafkaStreams(org.apache.kafka.streams.Topology,java.util.Properties,org.apache.kafka.streams.KafkaClientSupplier,org.apache.kafka.common.utils.Time)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Topology"/></param>
        /// <param name="arg1"><see cref="Java.Util.Properties"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.KafkaClientSupplier"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Common.Utils.Time"/></param>
        public KafkaStreams(Org.Apache.Kafka.Streams.Topology arg0, Java.Util.Properties arg1, Org.Apache.Kafka.Streams.KafkaClientSupplier arg2, Org.Apache.Kafka.Common.Utils.Time arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.html#org.apache.kafka.streams.KafkaStreams(org.apache.kafka.streams.Topology,java.util.Properties,org.apache.kafka.streams.KafkaClientSupplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Topology"/></param>
        /// <param name="arg1"><see cref="Java.Util.Properties"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.KafkaClientSupplier"/></param>
        public KafkaStreams(Org.Apache.Kafka.Streams.Topology arg0, Java.Util.Properties arg1, Org.Apache.Kafka.Streams.KafkaClientSupplier arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.html#org.apache.kafka.streams.KafkaStreams(org.apache.kafka.streams.Topology,java.util.Properties)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Topology"/></param>
        /// <param name="arg1"><see cref="Java.Util.Properties"/></param>
        public KafkaStreams(Org.Apache.Kafka.Streams.Topology arg0, Java.Util.Properties arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.html#org.apache.kafka.streams.KafkaStreams(org.apache.kafka.streams.Topology,org.apache.kafka.streams.StreamsConfig,org.apache.kafka.common.utils.Time)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Topology"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.StreamsConfig"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Utils.Time"/></param>
        public KafkaStreams(Org.Apache.Kafka.Streams.Topology arg0, Org.Apache.Kafka.Streams.StreamsConfig arg1, Org.Apache.Kafka.Common.Utils.Time arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.html#org.apache.kafka.streams.KafkaStreams(org.apache.kafka.streams.Topology,org.apache.kafka.streams.StreamsConfig,org.apache.kafka.streams.KafkaClientSupplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Topology"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.StreamsConfig"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.KafkaClientSupplier"/></param>
        public KafkaStreams(Org.Apache.Kafka.Streams.Topology arg0, Org.Apache.Kafka.Streams.StreamsConfig arg1, Org.Apache.Kafka.Streams.KafkaClientSupplier arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.html#org.apache.kafka.streams.KafkaStreams(org.apache.kafka.streams.Topology,org.apache.kafka.streams.StreamsConfig)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Topology"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.StreamsConfig"/></param>
        public KafkaStreams(Org.Apache.Kafka.Streams.Topology arg0, Org.Apache.Kafka.Streams.StreamsConfig arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.html#queryMetadataForKey-java.lang.String-java.lang.Object-org.apache.kafka.common.serialization.Serializer-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><typeparamref name="K"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Serialization.Serializer"/></param>
        /// <typeparam name="K"></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Streams.KeyQueryMetadata"/></returns>
        public Org.Apache.Kafka.Streams.KeyQueryMetadata QueryMetadataForKey<K>(string arg0, K arg1, Org.Apache.Kafka.Common.Serialization.Serializer<K> arg2)
        {
            return IExecute<Org.Apache.Kafka.Streams.KeyQueryMetadata>("queryMetadataForKey", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.html#queryMetadataForKey-java.lang.String-java.lang.Object-org.apache.kafka.streams.processor.StreamPartitioner-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><typeparamref name="K"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Processor.StreamPartitioner"/></param>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="Arg2objectSuperK"><typeparamref name="K"/></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Streams.KeyQueryMetadata"/></returns>
        public Org.Apache.Kafka.Streams.KeyQueryMetadata QueryMetadataForKey<K, Arg2objectSuperK>(string arg0, K arg1, Org.Apache.Kafka.Streams.Processor.StreamPartitioner<Arg2objectSuperK, object> arg2) where Arg2objectSuperK: K
        {
            return IExecute<Org.Apache.Kafka.Streams.KeyQueryMetadata>("queryMetadataForKey", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.html#query-org.apache.kafka.streams.query.StateQueryRequest-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Query.StateQueryRequest"/></param>
        /// <typeparam name="R"></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.StateQueryResult"/></returns>
        public Org.Apache.Kafka.Streams.Query.StateQueryResult<R> Query<R>(Org.Apache.Kafka.Streams.Query.StateQueryRequest<R> arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Query.StateQueryResult<R>>("query", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.html#store-org.apache.kafka.streams.StoreQueryParameters-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.StoreQueryParameters"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T Store<T>(Org.Apache.Kafka.Streams.StoreQueryParameters<T> arg0)
        {
            return IExecute<T>("store", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.html#isPaused--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsPaused()
        {
            return IExecute<bool>("isPaused");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.html#metadataForAllStreamsClients--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Collection"/></returns>
        public Java.Util.Collection<Org.Apache.Kafka.Streams.StreamsMetadata> MetadataForAllStreamsClients()
        {
            return IExecute<Java.Util.Collection<Org.Apache.Kafka.Streams.StreamsMetadata>>("metadataForAllStreamsClients");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.html#streamsMetadataForStore-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        public Java.Util.Collection<Org.Apache.Kafka.Streams.StreamsMetadata> StreamsMetadataForStore(string arg0)
        {
            return IExecute<Java.Util.Collection<Org.Apache.Kafka.Streams.StreamsMetadata>>("streamsMetadataForStore", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.html#allLocalStorePartitionLags--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<string, Java.Util.Map<Java.Lang.Integer, Org.Apache.Kafka.Streams.LagInfo>> AllLocalStorePartitionLags()
        {
            return IExecute<Java.Util.Map<string, Java.Util.Map<Java.Lang.Integer, Org.Apache.Kafka.Streams.LagInfo>>>("allLocalStorePartitionLags");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.html#metrics--"/>
        /// </summary>

        /// <typeparam name="ReturnExtendsOrg_Apache_Kafka_Common_Metric"><see cref="Org.Apache.Kafka.Common.Metric"/></typeparam>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Org.Apache.Kafka.Common.MetricName, ReturnExtendsOrg_Apache_Kafka_Common_Metric> Metrics<ReturnExtendsOrg_Apache_Kafka_Common_Metric>() where ReturnExtendsOrg_Apache_Kafka_Common_Metric: Org.Apache.Kafka.Common.Metric
        {
            return IExecute<Java.Util.Map<Org.Apache.Kafka.Common.MetricName, ReturnExtendsOrg_Apache_Kafka_Common_Metric>>("metrics");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.html#addStreamThread--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<string> AddStreamThread()
        {
            return IExecute<Java.Util.Optional<string>>("addStreamThread");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.html#removeStreamThread--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<string> RemoveStreamThread()
        {
            return IExecute<Java.Util.Optional<string>>("removeStreamThread");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.html#removeStreamThread-java.time.Duration-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Duration"/></param>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<string> RemoveStreamThread(Java.Time.Duration arg0)
        {
            return IExecute<Java.Util.Optional<string>>("removeStreamThread", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.html#metadataForLocalThreads--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Org.Apache.Kafka.Streams.ThreadMetadata> MetadataForLocalThreads()
        {
            return IExecute<Java.Util.Set<Org.Apache.Kafka.Streams.ThreadMetadata>>("metadataForLocalThreads");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.html#state--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.KafkaStreams.State"/></returns>
        public Org.Apache.Kafka.Streams.KafkaStreams.State StateMethod()
        {
            return IExecute<Org.Apache.Kafka.Streams.KafkaStreams.State>("state");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.html#close-java.time.Duration-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Duration"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public bool Close(Java.Time.Duration arg0)
        {
            return IExecute<bool>("close", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.html#close-org.apache.kafka.streams.KafkaStreams.CloseOptions-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.KafkaStreams.CloseOptions"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public bool Close(Org.Apache.Kafka.Streams.KafkaStreams.CloseOptions arg0)
        {
            return IExecute<bool>("close", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.html#start--"/>
        /// </summary>

        /// <exception cref="Java.Lang.IllegalStateException"/>
        /// <exception cref="Org.Apache.Kafka.Streams.Errors.StreamsException"/>
        public void Start()
        {
            IExecute("start");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.html#cleanUp--"/>
        /// </summary>
        public void CleanUp()
        {
            IExecute("cleanUp");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.html#pause--"/>
        /// </summary>
        public void Pause()
        {
            IExecute("pause");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.html#resume--"/>
        /// </summary>
        public void Resume()
        {
            IExecute("resume");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.html#setGlobalStateRestoreListener-org.apache.kafka.streams.processor.StateRestoreListener-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.StateRestoreListener"/></param>
        public void SetGlobalStateRestoreListener(Org.Apache.Kafka.Streams.Processor.StateRestoreListener arg0)
        {
            IExecute("setGlobalStateRestoreListener", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.html#setStateListener-org.apache.kafka.streams.KafkaStreams.StateListener-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.KafkaStreams.StateListener"/></param>
        public void SetStateListener(Org.Apache.Kafka.Streams.KafkaStreams.StateListener arg0)
        {
            IExecute("setStateListener", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.html#setUncaughtExceptionHandler-org.apache.kafka.streams.errors.StreamsUncaughtExceptionHandler-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Errors.StreamsUncaughtExceptionHandler"/></param>
        public void SetUncaughtExceptionHandler(Org.Apache.Kafka.Streams.Errors.StreamsUncaughtExceptionHandler arg0)
        {
            IExecute("setUncaughtExceptionHandler", arg0);
        }

        #endregion

        #region Nested classes
        #region CloseOptions
        public partial class CloseOptions
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.CloseOptions.html#leaveGroup-boolean-"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Streams.KafkaStreams.CloseOptions"/></returns>
            public Org.Apache.Kafka.Streams.KafkaStreams.CloseOptions LeaveGroup(bool arg0)
            {
                return IExecute<Org.Apache.Kafka.Streams.KafkaStreams.CloseOptions>("leaveGroup", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.CloseOptions.html#timeout-java.time.Duration-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Time.Duration"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Streams.KafkaStreams.CloseOptions"/></returns>
            public Org.Apache.Kafka.Streams.KafkaStreams.CloseOptions Timeout(Java.Time.Duration arg0)
            {
                return IExecute<Org.Apache.Kafka.Streams.KafkaStreams.CloseOptions>("timeout", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region State
        public partial class State
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.State.html#CREATED"/>
            /// </summary>
            public static Org.Apache.Kafka.Streams.KafkaStreams.State CREATED { get { return SGetField<Org.Apache.Kafka.Streams.KafkaStreams.State>(LocalBridgeClazz, "CREATED"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.State.html#ERROR"/>
            /// </summary>
            public static Org.Apache.Kafka.Streams.KafkaStreams.State ERROR { get { return SGetField<Org.Apache.Kafka.Streams.KafkaStreams.State>(LocalBridgeClazz, "ERROR"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.State.html#NOT_RUNNING"/>
            /// </summary>
            public static Org.Apache.Kafka.Streams.KafkaStreams.State NOT_RUNNING { get { return SGetField<Org.Apache.Kafka.Streams.KafkaStreams.State>(LocalBridgeClazz, "NOT_RUNNING"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.State.html#PENDING_ERROR"/>
            /// </summary>
            public static Org.Apache.Kafka.Streams.KafkaStreams.State PENDING_ERROR { get { return SGetField<Org.Apache.Kafka.Streams.KafkaStreams.State>(LocalBridgeClazz, "PENDING_ERROR"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.State.html#PENDING_SHUTDOWN"/>
            /// </summary>
            public static Org.Apache.Kafka.Streams.KafkaStreams.State PENDING_SHUTDOWN { get { return SGetField<Org.Apache.Kafka.Streams.KafkaStreams.State>(LocalBridgeClazz, "PENDING_SHUTDOWN"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.State.html#REBALANCING"/>
            /// </summary>
            public static Org.Apache.Kafka.Streams.KafkaStreams.State REBALANCING { get { return SGetField<Org.Apache.Kafka.Streams.KafkaStreams.State>(LocalBridgeClazz, "REBALANCING"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.State.html#RUNNING"/>
            /// </summary>
            public static Org.Apache.Kafka.Streams.KafkaStreams.State RUNNING { get { return SGetField<Org.Apache.Kafka.Streams.KafkaStreams.State>(LocalBridgeClazz, "RUNNING"); } }

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.State.html#valueOf-java.lang.String-"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Streams.KafkaStreams.State"/></returns>
            public static Org.Apache.Kafka.Streams.KafkaStreams.State ValueOf(string arg0)
            {
                return SExecute<Org.Apache.Kafka.Streams.KafkaStreams.State>(LocalBridgeClazz, "valueOf", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.State.html#values--"/>
            /// </summary>

            /// <returns><see cref="Org.Apache.Kafka.Streams.KafkaStreams.State"/></returns>
            public static Org.Apache.Kafka.Streams.KafkaStreams.State[] Values()
            {
                return SExecuteArray<Org.Apache.Kafka.Streams.KafkaStreams.State>(LocalBridgeClazz, "values");
            }

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.State.html#hasCompletedShutdown--"/>
            /// </summary>

            /// <returns><see cref="bool"/></returns>
            public bool HasCompletedShutdown()
            {
                return IExecute<bool>("hasCompletedShutdown");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.State.html#hasNotStarted--"/>
            /// </summary>

            /// <returns><see cref="bool"/></returns>
            public bool HasNotStarted()
            {
                return IExecute<bool>("hasNotStarted");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.State.html#hasStartedOrFinishedShuttingDown--"/>
            /// </summary>

            /// <returns><see cref="bool"/></returns>
            public bool HasStartedOrFinishedShuttingDown()
            {
                return IExecute<bool>("hasStartedOrFinishedShuttingDown");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.State.html#isRunningOrRebalancing--"/>
            /// </summary>

            /// <returns><see cref="bool"/></returns>
            public bool IsRunningOrRebalancing()
            {
                return IExecute<bool>("isRunningOrRebalancing");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.State.html#isShuttingDown--"/>
            /// </summary>

            /// <returns><see cref="bool"/></returns>
            public bool IsShuttingDown()
            {
                return IExecute<bool>("isShuttingDown");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.State.html#isValidTransition-org.apache.kafka.streams.KafkaStreams.State-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.KafkaStreams.State"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool IsValidTransition(Org.Apache.Kafka.Streams.KafkaStreams.State arg0)
            {
                return IExecute<bool>("isValidTransition", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region StateListener
        public partial class StateListener
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
            /// Handlers initializer for <see cref="StateListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onChange", new System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Streams.KafkaStreams.State>>>(OnChangeEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.StateListener.html#onChange-org.apache.kafka.streams.KafkaStreams.State-org.apache.kafka.streams.KafkaStreams.State-"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnChange"/> has a value it takes precedence over corresponding class method</remarks>
            public System.Action<Org.Apache.Kafka.Streams.KafkaStreams.State, Org.Apache.Kafka.Streams.KafkaStreams.State> OnOnChange { get; set; } = null;

            void OnChangeEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Streams.KafkaStreams.State>> data)
            {
                var methodToExecute = (OnOnChange != null) ? OnOnChange : OnChange;
                methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Org.Apache.Kafka.Streams.KafkaStreams.State>(0));
            }

            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/KafkaStreams.StateListener.html#onChange-org.apache.kafka.streams.KafkaStreams.State-org.apache.kafka.streams.KafkaStreams.State-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.KafkaStreams.State"/></param>
            /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.KafkaStreams.State"/></param>
            public virtual void OnChange(Org.Apache.Kafka.Streams.KafkaStreams.State arg0, Org.Apache.Kafka.Streams.KafkaStreams.State arg1)
            {
                
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
}