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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using kafka-streams-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Processor.Internals.Namedtopology
{
    #region KafkaStreamsNamedTopologyWrapper
    public partial class KafkaStreamsNamedTopologyWrapper
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/namedtopology/KafkaStreamsNamedTopologyWrapper.html#%3Cinit%3E(java.util.Properties,org.apache.kafka.streams.KafkaClientSupplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Properties"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.KafkaClientSupplier"/></param>
        public KafkaStreamsNamedTopologyWrapper(Java.Util.Properties arg0, Org.Apache.Kafka.Streams.KafkaClientSupplier arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/namedtopology/KafkaStreamsNamedTopologyWrapper.html#%3Cinit%3E(java.util.Properties)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Properties"/></param>
        public KafkaStreamsNamedTopologyWrapper(Java.Util.Properties arg0)
            : base(arg0)
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
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/namedtopology/KafkaStreamsNamedTopologyWrapper.html#getAllTopologies()"/> 
        /// </summary>
        public Java.Util.Collection<Org.Apache.Kafka.Streams.Processor.Internals.Namedtopology.NamedTopology> AllTopologies
        {
            get { return IExecute<Java.Util.Collection<Org.Apache.Kafka.Streams.Processor.Internals.Namedtopology.NamedTopology>>("getAllTopologies"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/namedtopology/KafkaStreamsNamedTopologyWrapper.html#getFullTopologyDescription()"/> 
        /// </summary>
        public string FullTopologyDescription
        {
            get { return IExecute<string>("getFullTopologyDescription"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/namedtopology/KafkaStreamsNamedTopologyWrapper.html#queryMetadataForKey(java.lang.String,java.lang.Object,org.apache.kafka.common.serialization.Serializer,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><typeparamref name="K"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Serialization.Serializer"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        /// <typeparam name="K"></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Streams.KeyQueryMetadata"/></returns>
        public Org.Apache.Kafka.Streams.KeyQueryMetadata QueryMetadataForKey<K>(string arg0, K arg1, Org.Apache.Kafka.Common.Serialization.Serializer<K> arg2, string arg3)
        {
            return IExecute<Org.Apache.Kafka.Streams.KeyQueryMetadata>("queryMetadataForKey", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/namedtopology/KafkaStreamsNamedTopologyWrapper.html#store(org.apache.kafka.streams.processor.internals.namedtopology.NamedTopologyStoreQueryParameters)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Internals.Namedtopology.NamedTopologyStoreQueryParameters"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T Store<T>(Org.Apache.Kafka.Streams.Processor.Internals.Namedtopology.NamedTopologyStoreQueryParameters<T> arg0)
        {
            return IExecute<T>("store", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/namedtopology/KafkaStreamsNamedTopologyWrapper.html#isNamedTopologyPaused(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsNamedTopologyPaused(string arg0)
        {
            return IExecute<bool>("isNamedTopologyPaused", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/namedtopology/KafkaStreamsNamedTopologyWrapper.html#allStreamsClientsMetadataForTopology(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        public Java.Util.Collection<Org.Apache.Kafka.Streams.StreamsMetadata> AllStreamsClientsMetadataForTopology(string arg0)
        {
            return IExecute<Java.Util.Collection<Org.Apache.Kafka.Streams.StreamsMetadata>>("allStreamsClientsMetadataForTopology", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/namedtopology/KafkaStreamsNamedTopologyWrapper.html#streamsMetadataForStore(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        public Java.Util.Collection<Org.Apache.Kafka.Streams.StreamsMetadata> StreamsMetadataForStore(string arg0, string arg1)
        {
            return IExecute<Java.Util.Collection<Org.Apache.Kafka.Streams.StreamsMetadata>>("streamsMetadataForStore", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/namedtopology/KafkaStreamsNamedTopologyWrapper.html#allLocalStorePartitionLagsForTopology(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<string, Java.Util.Map<int?, Org.Apache.Kafka.Streams.LagInfo>> AllLocalStorePartitionLagsForTopology(string arg0)
        {
            return IExecute<Java.Util.Map<string, Java.Util.Map<int?, Org.Apache.Kafka.Streams.LagInfo>>>("allLocalStorePartitionLagsForTopology", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/namedtopology/KafkaStreamsNamedTopologyWrapper.html#addNamedTopology(org.apache.kafka.streams.processor.internals.namedtopology.NamedTopology)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Internals.Namedtopology.NamedTopology"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.Internals.Namedtopology.AddNamedTopologyResult"/></returns>
        public Org.Apache.Kafka.Streams.Processor.Internals.Namedtopology.AddNamedTopologyResult AddNamedTopology(Org.Apache.Kafka.Streams.Processor.Internals.Namedtopology.NamedTopology arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Processor.Internals.Namedtopology.AddNamedTopologyResult>("addNamedTopology", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/namedtopology/KafkaStreamsNamedTopologyWrapper.html#newNamedTopologyBuilder(java.lang.String,java.util.Properties)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.Properties"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.Internals.Namedtopology.NamedTopologyBuilder"/></returns>
        public Org.Apache.Kafka.Streams.Processor.Internals.Namedtopology.NamedTopologyBuilder NewNamedTopologyBuilder(string arg0, Java.Util.Properties arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.Processor.Internals.Namedtopology.NamedTopologyBuilder>("newNamedTopologyBuilder", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/namedtopology/KafkaStreamsNamedTopologyWrapper.html#newNamedTopologyBuilder(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.Internals.Namedtopology.NamedTopologyBuilder"/></returns>
        public Org.Apache.Kafka.Streams.Processor.Internals.Namedtopology.NamedTopologyBuilder NewNamedTopologyBuilder(string arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Processor.Internals.Namedtopology.NamedTopologyBuilder>("newNamedTopologyBuilder", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/namedtopology/KafkaStreamsNamedTopologyWrapper.html#removeNamedTopology(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.Internals.Namedtopology.RemoveNamedTopologyResult"/></returns>
        public Org.Apache.Kafka.Streams.Processor.Internals.Namedtopology.RemoveNamedTopologyResult RemoveNamedTopology(string arg0, bool arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.Processor.Internals.Namedtopology.RemoveNamedTopologyResult>("removeNamedTopology", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/namedtopology/KafkaStreamsNamedTopologyWrapper.html#removeNamedTopology(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.Internals.Namedtopology.RemoveNamedTopologyResult"/></returns>
        public Org.Apache.Kafka.Streams.Processor.Internals.Namedtopology.RemoveNamedTopologyResult RemoveNamedTopology(string arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Processor.Internals.Namedtopology.RemoveNamedTopologyResult>("removeNamedTopology", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/namedtopology/KafkaStreamsNamedTopologyWrapper.html#getTopologyByName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Org.Apache.Kafka.Streams.Processor.Internals.Namedtopology.NamedTopology> GetTopologyByName(string arg0)
        {
            return IExecute<Java.Util.Optional<Org.Apache.Kafka.Streams.Processor.Internals.Namedtopology.NamedTopology>>("getTopologyByName", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/namedtopology/KafkaStreamsNamedTopologyWrapper.html#start(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public void Start(Java.Util.Collection<Org.Apache.Kafka.Streams.Processor.Internals.Namedtopology.NamedTopology> arg0)
        {
            IExecute("start", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/namedtopology/KafkaStreamsNamedTopologyWrapper.html#cleanUpNamedTopology(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public void CleanUpNamedTopology(string arg0)
        {
            IExecute("cleanUpNamedTopology", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/namedtopology/KafkaStreamsNamedTopologyWrapper.html#pauseNamedTopology(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public void PauseNamedTopology(string arg0)
        {
            IExecute("pauseNamedTopology", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/namedtopology/KafkaStreamsNamedTopologyWrapper.html#resumeNamedTopology(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public void ResumeNamedTopology(string arg0)
        {
            IExecute("resumeNamedTopology", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/namedtopology/KafkaStreamsNamedTopologyWrapper.html#start(org.apache.kafka.streams.processor.internals.namedtopology.NamedTopology)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Internals.Namedtopology.NamedTopology"/></param>
        public void Start(Org.Apache.Kafka.Streams.Processor.Internals.Namedtopology.NamedTopology arg0)
        {
            IExecute("start", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}