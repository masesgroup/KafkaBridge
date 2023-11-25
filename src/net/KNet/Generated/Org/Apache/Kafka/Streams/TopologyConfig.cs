/*
*  Copyright 2023 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.1.0.0)
*  using kafka-streams-3.6.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams
{
    #region TopologyConfig
    public partial class TopologyConfig
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/TopologyConfig.html#org.apache.kafka.streams.TopologyConfig(java.lang.String,org.apache.kafka.streams.StreamsConfig,java.util.Properties)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.StreamsConfig"/></param>
        /// <param name="arg2"><see cref="Java.Util.Properties"/></param>
        public TopologyConfig(string arg0, Org.Apache.Kafka.Streams.StreamsConfig arg1, Java.Util.Properties arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/TopologyConfig.html#org.apache.kafka.streams.TopologyConfig(org.apache.kafka.streams.StreamsConfig)"/>
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/TopologyConfig.html#eosEnabled"/>
        /// </summary>
        public bool eosEnabled { get { return IGetField<bool>("eosEnabled"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/TopologyConfig.html#maxBufferedSize"/>
        /// </summary>
        public int maxBufferedSize { get { return IGetField<int>("maxBufferedSize"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/TopologyConfig.html#storeType"/>
        /// </summary>
        public string storeType { get { return IGetField<string>("storeType"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/TopologyConfig.html#topologyName"/>
        /// </summary>
        public string topologyName { get { return IGetField<string>("topologyName"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/TopologyConfig.html#deserializationExceptionHandlerSupplier"/>
        /// </summary>
        public Java.Util.Function.Supplier deserializationExceptionHandlerSupplier { get { return IGetField<Java.Util.Function.Supplier>("deserializationExceptionHandlerSupplier"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/TopologyConfig.html#timestampExtractorSupplier"/>
        /// </summary>
        public Java.Util.Function.Supplier timestampExtractorSupplier { get { return IGetField<Java.Util.Function.Supplier>("timestampExtractorSupplier"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/TopologyConfig.html#topologyOverrides"/>
        /// </summary>
        public Java.Util.Properties topologyOverrides { get { return IGetField<Java.Util.Properties>("topologyOverrides"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/TopologyConfig.html#cacheSize"/>
        /// </summary>
        public long cacheSize { get { return IGetField<long>("cacheSize"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/TopologyConfig.html#maxTaskIdleMs"/>
        /// </summary>
        public long maxTaskIdleMs { get { return IGetField<long>("maxTaskIdleMs"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/TopologyConfig.html#taskTimeoutMs"/>
        /// </summary>
        public long taskTimeoutMs { get { return IGetField<long>("taskTimeoutMs"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/TopologyConfig.html#applicationConfigs"/>
        /// </summary>
        public Org.Apache.Kafka.Streams.StreamsConfig applicationConfigs { get { return IGetField<Org.Apache.Kafka.Streams.StreamsConfig>("applicationConfigs"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/TopologyConfig.html#getTaskConfig--"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.TopologyConfig.TaskConfig GetTaskConfig
        {
            get { return IExecute<Org.Apache.Kafka.Streams.TopologyConfig.TaskConfig>("getTaskConfig"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/TopologyConfig.html#isNamedTopology--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsNamedTopology()
        {
            return IExecute<bool>("isNamedTopology");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/TopologyConfig.html#parseStoreType--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Materialized.StoreType"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.Materialized.StoreType ParseStoreType()
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.Materialized.StoreType>("parseStoreType");
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/TopologyConfig.TaskConfig.html#eosEnabled"/>
            /// </summary>
            public bool eosEnabled { get { return IGetField<bool>("eosEnabled"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/TopologyConfig.TaskConfig.html#maxBufferedSize"/>
            /// </summary>
            public int maxBufferedSize { get { return IGetField<int>("maxBufferedSize"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/TopologyConfig.TaskConfig.html#maxTaskIdleMs"/>
            /// </summary>
            public long maxTaskIdleMs { get { return IGetField<long>("maxTaskIdleMs"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/TopologyConfig.TaskConfig.html#taskTimeoutMs"/>
            /// </summary>
            public long taskTimeoutMs { get { return IGetField<long>("taskTimeoutMs"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/TopologyConfig.TaskConfig.html#deserializationExceptionHandler"/>
            /// </summary>
            public Org.Apache.Kafka.Streams.Errors.DeserializationExceptionHandler deserializationExceptionHandler { get { return IGetField<Org.Apache.Kafka.Streams.Errors.DeserializationExceptionHandler>("deserializationExceptionHandler"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.0/org/apache/kafka/streams/TopologyConfig.TaskConfig.html#timestampExtractor"/>
            /// </summary>
            public Org.Apache.Kafka.Streams.Processor.TimestampExtractor timestampExtractor { get { return IGetField<Org.Apache.Kafka.Streams.Processor.TimestampExtractor>("timestampExtractor"); } }

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