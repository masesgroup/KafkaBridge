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
*  using kafka-streams-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams
{
    #region TopologyConfig
    public partial class TopologyConfig
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/TopologyConfig.html#org.apache.kafka.streams.TopologyConfig(java.lang.String,org.apache.kafka.streams.StreamsConfig,java.util.Properties)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.StreamsConfig"/></param>
        /// <param name="arg2"><see cref="Java.Util.Properties"/></param>
        public TopologyConfig(Java.Lang.String arg0, Org.Apache.Kafka.Streams.StreamsConfig arg1, Java.Util.Properties arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/TopologyConfig.html#org.apache.kafka.streams.TopologyConfig(org.apache.kafka.streams.StreamsConfig)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.StreamsConfig"/></param>
        public TopologyConfig(Org.Apache.Kafka.Streams.StreamsConfig arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/TopologyConfig.html#eosEnabled"/>
        /// </summary>
        public bool eosEnabled { get { if (!_eosEnabledReady) { _eosEnabledContent = IGetField<bool>("eosEnabled"); _eosEnabledReady = true; } return _eosEnabledContent; } }
        private bool _eosEnabledContent = default;
        private bool _eosEnabledReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/TopologyConfig.html#maxBufferedSize"/>
        /// </summary>
        public int maxBufferedSize { get { if (!_maxBufferedSizeReady) { _maxBufferedSizeContent = IGetField<int>("maxBufferedSize"); _maxBufferedSizeReady = true; } return _maxBufferedSizeContent; } }
        private int _maxBufferedSizeContent = default;
        private bool _maxBufferedSizeReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/TopologyConfig.html#storeType"/>
        /// </summary>
        public Java.Lang.String storeType { get { if (!_storeTypeReady) { _storeTypeContent = IGetField<Java.Lang.String>("storeType"); _storeTypeReady = true; } return _storeTypeContent; } }
        private Java.Lang.String _storeTypeContent = default;
        private bool _storeTypeReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/TopologyConfig.html#topologyName"/>
        /// </summary>
        public Java.Lang.String topologyName { get { if (!_topologyNameReady) { _topologyNameContent = IGetField<Java.Lang.String>("topologyName"); _topologyNameReady = true; } return _topologyNameContent; } }
        private Java.Lang.String _topologyNameContent = default;
        private bool _topologyNameReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/TopologyConfig.html#deserializationExceptionHandlerSupplier"/>
        /// </summary>
        public Java.Util.Function.Supplier deserializationExceptionHandlerSupplier { get { if (!_deserializationExceptionHandlerSupplierReady) { _deserializationExceptionHandlerSupplierContent = IGetField<Java.Util.Function.Supplier>("deserializationExceptionHandlerSupplier"); _deserializationExceptionHandlerSupplierReady = true; } return _deserializationExceptionHandlerSupplierContent; } }
        private Java.Util.Function.Supplier _deserializationExceptionHandlerSupplierContent = default;
        private bool _deserializationExceptionHandlerSupplierReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/TopologyConfig.html#timestampExtractorSupplier"/>
        /// </summary>
        public Java.Util.Function.Supplier timestampExtractorSupplier { get { if (!_timestampExtractorSupplierReady) { _timestampExtractorSupplierContent = IGetField<Java.Util.Function.Supplier>("timestampExtractorSupplier"); _timestampExtractorSupplierReady = true; } return _timestampExtractorSupplierContent; } }
        private Java.Util.Function.Supplier _timestampExtractorSupplierContent = default;
        private bool _timestampExtractorSupplierReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/TopologyConfig.html#topologyOverrides"/>
        /// </summary>
        public Java.Util.Properties topologyOverrides { get { if (!_topologyOverridesReady) { _topologyOverridesContent = IGetField<Java.Util.Properties>("topologyOverrides"); _topologyOverridesReady = true; } return _topologyOverridesContent; } }
        private Java.Util.Properties _topologyOverridesContent = default;
        private bool _topologyOverridesReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/TopologyConfig.html#cacheSize"/>
        /// </summary>
        public long cacheSize { get { if (!_cacheSizeReady) { _cacheSizeContent = IGetField<long>("cacheSize"); _cacheSizeReady = true; } return _cacheSizeContent; } }
        private long _cacheSizeContent = default;
        private bool _cacheSizeReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/TopologyConfig.html#maxTaskIdleMs"/>
        /// </summary>
        public long maxTaskIdleMs { get { if (!_maxTaskIdleMsReady) { _maxTaskIdleMsContent = IGetField<long>("maxTaskIdleMs"); _maxTaskIdleMsReady = true; } return _maxTaskIdleMsContent; } }
        private long _maxTaskIdleMsContent = default;
        private bool _maxTaskIdleMsReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/TopologyConfig.html#taskTimeoutMs"/>
        /// </summary>
        public long taskTimeoutMs { get { if (!_taskTimeoutMsReady) { _taskTimeoutMsContent = IGetField<long>("taskTimeoutMs"); _taskTimeoutMsReady = true; } return _taskTimeoutMsContent; } }
        private long _taskTimeoutMsContent = default;
        private bool _taskTimeoutMsReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/TopologyConfig.html#applicationConfigs"/>
        /// </summary>
        public Org.Apache.Kafka.Streams.StreamsConfig applicationConfigs { get { if (!_applicationConfigsReady) { _applicationConfigsContent = IGetField<Org.Apache.Kafka.Streams.StreamsConfig>("applicationConfigs"); _applicationConfigsReady = true; } return _applicationConfigsContent; } }
        private Org.Apache.Kafka.Streams.StreamsConfig _applicationConfigsContent = default;
        private bool _applicationConfigsReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/TopologyConfig.html#getTaskConfig--"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.TopologyConfig.TaskConfig GetTaskConfig
        {
            get { return IExecuteWithSignature<Org.Apache.Kafka.Streams.TopologyConfig.TaskConfig>("getTaskConfig", "()Lorg/apache/kafka/streams/TopologyConfig$TaskConfig;"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/TopologyConfig.html#isNamedTopology--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsNamedTopology()
        {
            return IExecuteWithSignature<bool>("isNamedTopology", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/TopologyConfig.html#parseStoreType--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Materialized.StoreType"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.Materialized.StoreType ParseStoreType()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.Materialized.StoreType>("parseStoreType", "()Lorg/apache/kafka/streams/kstream/Materialized$StoreType;");
        }

        #endregion

        #region Nested classes
        #region TaskConfig
        public partial class TaskConfig
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/TopologyConfig.TaskConfig.html#eosEnabled"/>
            /// </summary>
            public bool eosEnabled { get { if (!_eosEnabledReady) { _eosEnabledContent = IGetField<bool>("eosEnabled"); _eosEnabledReady = true; } return _eosEnabledContent; } }
            private bool _eosEnabledContent = default;
            private bool _eosEnabledReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/TopologyConfig.TaskConfig.html#maxBufferedSize"/>
            /// </summary>
            public int maxBufferedSize { get { if (!_maxBufferedSizeReady) { _maxBufferedSizeContent = IGetField<int>("maxBufferedSize"); _maxBufferedSizeReady = true; } return _maxBufferedSizeContent; } }
            private int _maxBufferedSizeContent = default;
            private bool _maxBufferedSizeReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/TopologyConfig.TaskConfig.html#maxTaskIdleMs"/>
            /// </summary>
            public long maxTaskIdleMs { get { if (!_maxTaskIdleMsReady) { _maxTaskIdleMsContent = IGetField<long>("maxTaskIdleMs"); _maxTaskIdleMsReady = true; } return _maxTaskIdleMsContent; } }
            private long _maxTaskIdleMsContent = default;
            private bool _maxTaskIdleMsReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/TopologyConfig.TaskConfig.html#taskTimeoutMs"/>
            /// </summary>
            public long taskTimeoutMs { get { if (!_taskTimeoutMsReady) { _taskTimeoutMsContent = IGetField<long>("taskTimeoutMs"); _taskTimeoutMsReady = true; } return _taskTimeoutMsContent; } }
            private long _taskTimeoutMsContent = default;
            private bool _taskTimeoutMsReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/TopologyConfig.TaskConfig.html#deserializationExceptionHandler"/>
            /// </summary>
            public Org.Apache.Kafka.Streams.Errors.DeserializationExceptionHandler deserializationExceptionHandler { get { if (!_deserializationExceptionHandlerReady) { _deserializationExceptionHandlerContent = IGetField<Org.Apache.Kafka.Streams.Errors.DeserializationExceptionHandler>("deserializationExceptionHandler"); _deserializationExceptionHandlerReady = true; } return _deserializationExceptionHandlerContent; } }
            private Org.Apache.Kafka.Streams.Errors.DeserializationExceptionHandler _deserializationExceptionHandlerContent = default;
            private bool _deserializationExceptionHandlerReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/TopologyConfig.TaskConfig.html#timestampExtractor"/>
            /// </summary>
            public Org.Apache.Kafka.Streams.Processor.TimestampExtractor timestampExtractor { get { if (!_timestampExtractorReady) { _timestampExtractorContent = IGetField<Org.Apache.Kafka.Streams.Processor.TimestampExtractor>("timestampExtractor"); _timestampExtractorReady = true; } return _timestampExtractorContent; } }
            private Org.Apache.Kafka.Streams.Processor.TimestampExtractor _timestampExtractorContent = default;
            private bool _timestampExtractorReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

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