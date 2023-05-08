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

namespace Org.Apache.Kafka.Streams.Kstream.Internals.Graph
{
    #region KTableKTableJoinNode
    public partial class KTableKTableJoinNode
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/KTableKTableJoinNode.html#kTableKTableJoinNodeBuilder()"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder KTableKTableJoinNodeBuilderMethod()
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder>(LocalBridgeClazz, "kTableKTableJoinNodeBuilder");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/KTableKTableJoinNode.html#joinMerger()"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.Kstream.Internals.KTableKTableJoinMerger JoinMerger
        {
            get { return IExecute<Org.Apache.Kafka.Streams.Kstream.Internals.KTableKTableJoinMerger>("joinMerger"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/KTableKTableJoinNode.html#joinOtherStoreNames()"/> 
        /// </summary>
        public string[] JoinOtherStoreNames
        {
            get { return IExecuteArray<string>("joinOtherStoreNames"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/KTableKTableJoinNode.html#joinThisStoreNames()"/> 
        /// </summary>
        public string[] JoinThisStoreNames
        {
            get { return IExecuteArray<string>("joinThisStoreNames"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/KTableKTableJoinNode.html#keySerde()"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.Serialization.Serde KeySerde
        {
            get { return IExecute<Org.Apache.Kafka.Common.Serialization.Serde>("keySerde"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/KTableKTableJoinNode.html#queryableStoreName()"/> 
        /// </summary>
        public string QueryableStoreName
        {
            get { return IExecute<string>("queryableStoreName"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/KTableKTableJoinNode.html#valueSerde()"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.Serialization.Serde ValueSerde
        {
            get { return IExecute<Org.Apache.Kafka.Common.Serialization.Serde>("valueSerde"); }
        }

        #endregion

        #region Nested classes
        #region KTableKTableJoinNodeBuilder
        public partial class KTableKTableJoinNodeBuilder
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
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/KTableKTableJoinNode.KTableKTableJoinNodeBuilder.html#build()"/> 
            /// </summary>
            public Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode Build
            {
                get { return IExecute<Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode>("build"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/KTableKTableJoinNode.KTableKTableJoinNodeBuilder.html#withJoinOtherProcessorParameters(org.apache.kafka.streams.kstream.internals.graph.ProcessorParameters)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Internals.Graph.ProcessorParameters"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder"/></returns>
            public Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder WithJoinOtherProcessorParameters(Org.Apache.Kafka.Streams.Kstream.Internals.Graph.ProcessorParameters arg0)
            {
                return IExecute<Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder>("withJoinOtherProcessorParameters", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/KTableKTableJoinNode.KTableKTableJoinNodeBuilder.html#withJoinOtherStoreNames(java.lang.String[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder"/></returns>
            public Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder WithJoinOtherStoreNames(string[] arg0)
            {
                return IExecute<Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder>("withJoinOtherStoreNames", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/KTableKTableJoinNode.KTableKTableJoinNodeBuilder.html#withJoinThisProcessorParameters(org.apache.kafka.streams.kstream.internals.graph.ProcessorParameters)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Internals.Graph.ProcessorParameters"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder"/></returns>
            public Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder WithJoinThisProcessorParameters(Org.Apache.Kafka.Streams.Kstream.Internals.Graph.ProcessorParameters arg0)
            {
                return IExecute<Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder>("withJoinThisProcessorParameters", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/KTableKTableJoinNode.KTableKTableJoinNodeBuilder.html#withJoinThisStoreNames(java.lang.String[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder"/></returns>
            public Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder WithJoinThisStoreNames(string[] arg0)
            {
                return IExecute<Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder>("withJoinThisStoreNames", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/KTableKTableJoinNode.KTableKTableJoinNodeBuilder.html#withKeySerde(org.apache.kafka.common.serialization.Serde)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder"/></returns>
            public Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder WithKeySerde(Org.Apache.Kafka.Common.Serialization.Serde arg0)
            {
                return IExecute<Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder>("withKeySerde", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/KTableKTableJoinNode.KTableKTableJoinNodeBuilder.html#withNodeName(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder"/></returns>
            public Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder WithNodeName(string arg0)
            {
                return IExecute<Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder>("withNodeName", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/KTableKTableJoinNode.KTableKTableJoinNodeBuilder.html#withOtherJoinSideNodeName(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder"/></returns>
            public Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder WithOtherJoinSideNodeName(string arg0)
            {
                return IExecute<Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder>("withOtherJoinSideNodeName", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/KTableKTableJoinNode.KTableKTableJoinNodeBuilder.html#withQueryableStoreName(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder"/></returns>
            public Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder WithQueryableStoreName(string arg0)
            {
                return IExecute<Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder>("withQueryableStoreName", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/KTableKTableJoinNode.KTableKTableJoinNodeBuilder.html#withStoreBuilder(org.apache.kafka.streams.state.StoreBuilder)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.State.StoreBuilder"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder"/></returns>
            public Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder WithStoreBuilder(Org.Apache.Kafka.Streams.State.StoreBuilder arg0)
            {
                return IExecute<Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder>("withStoreBuilder", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/KTableKTableJoinNode.KTableKTableJoinNodeBuilder.html#withThisJoinSideNodeName(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder"/></returns>
            public Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder WithThisJoinSideNodeName(string arg0)
            {
                return IExecute<Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder>("withThisJoinSideNodeName", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/KTableKTableJoinNode.KTableKTableJoinNodeBuilder.html#withValueSerde(org.apache.kafka.common.serialization.Serde)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder"/></returns>
            public Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder WithValueSerde(Org.Apache.Kafka.Common.Serialization.Serde arg0)
            {
                return IExecute<Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder>("withValueSerde", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region KTableKTableJoinNodeBuilder<K, V1, V2, VR>
        public partial class KTableKTableJoinNodeBuilder<K, V1, V2, VR>
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder{K, V1, V2, VR}"/> to <see cref="Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder"/>
            /// </summary>
            public static implicit operator Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder(Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder<K, V1, V2, VR> t) => t.Cast<Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/KTableKTableJoinNode.KTableKTableJoinNodeBuilder.html#build()"/> 
            /// </summary>
            public Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode<K, V1, V2, VR> Build
            {
                get { return IExecute<Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode<K, V1, V2, VR>>("build"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/KTableKTableJoinNode.KTableKTableJoinNodeBuilder.html#withJoinOtherProcessorParameters(org.apache.kafka.streams.kstream.internals.graph.ProcessorParameters)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Internals.Graph.ProcessorParameters"/></param>
            /// <typeparam name="Arg0Extendsobject"></typeparam>
            /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder"/></returns>
            public Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder<K, V1, V2, VR> WithJoinOtherProcessorParameters<Arg0Extendsobject>(Org.Apache.Kafka.Streams.Kstream.Internals.Graph.ProcessorParameters<K, Org.Apache.Kafka.Streams.Kstream.Internals.Change<V2>, Arg0Extendsobject, Arg0Extendsobject> arg0)
            {
                return IExecute<Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder<K, V1, V2, VR>>("withJoinOtherProcessorParameters", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/KTableKTableJoinNode.KTableKTableJoinNodeBuilder.html#withJoinOtherStoreNames(java.lang.String[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder"/></returns>
            public Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder<K, V1, V2, VR> WithJoinOtherStoreNames(string[] arg0)
            {
                return IExecute<Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder<K, V1, V2, VR>>("withJoinOtherStoreNames", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/KTableKTableJoinNode.KTableKTableJoinNodeBuilder.html#withJoinThisProcessorParameters(org.apache.kafka.streams.kstream.internals.graph.ProcessorParameters)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Internals.Graph.ProcessorParameters"/></param>
            /// <typeparam name="Arg0Extendsobject"></typeparam>
            /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder"/></returns>
            public Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder<K, V1, V2, VR> WithJoinThisProcessorParameters<Arg0Extendsobject>(Org.Apache.Kafka.Streams.Kstream.Internals.Graph.ProcessorParameters<K, Org.Apache.Kafka.Streams.Kstream.Internals.Change<V1>, Arg0Extendsobject, Arg0Extendsobject> arg0)
            {
                return IExecute<Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder<K, V1, V2, VR>>("withJoinThisProcessorParameters", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/KTableKTableJoinNode.KTableKTableJoinNodeBuilder.html#withJoinThisStoreNames(java.lang.String[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder"/></returns>
            public Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder<K, V1, V2, VR> WithJoinThisStoreNames(string[] arg0)
            {
                return IExecute<Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder<K, V1, V2, VR>>("withJoinThisStoreNames", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/KTableKTableJoinNode.KTableKTableJoinNodeBuilder.html#withKeySerde(org.apache.kafka.common.serialization.Serde)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder"/></returns>
            public Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder<K, V1, V2, VR> WithKeySerde(Org.Apache.Kafka.Common.Serialization.Serde<K> arg0)
            {
                return IExecute<Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder<K, V1, V2, VR>>("withKeySerde", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/KTableKTableJoinNode.KTableKTableJoinNodeBuilder.html#withNodeName(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder"/></returns>
            public Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder<K, V1, V2, VR> WithNodeName(string arg0)
            {
                return IExecute<Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder<K, V1, V2, VR>>("withNodeName", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/KTableKTableJoinNode.KTableKTableJoinNodeBuilder.html#withOtherJoinSideNodeName(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder"/></returns>
            public Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder<K, V1, V2, VR> WithOtherJoinSideNodeName(string arg0)
            {
                return IExecute<Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder<K, V1, V2, VR>>("withOtherJoinSideNodeName", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/KTableKTableJoinNode.KTableKTableJoinNodeBuilder.html#withQueryableStoreName(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder"/></returns>
            public Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder<K, V1, V2, VR> WithQueryableStoreName(string arg0)
            {
                return IExecute<Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder<K, V1, V2, VR>>("withQueryableStoreName", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/KTableKTableJoinNode.KTableKTableJoinNodeBuilder.html#withStoreBuilder(org.apache.kafka.streams.state.StoreBuilder)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.State.StoreBuilder"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder"/></returns>
            public Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder<K, V1, V2, VR> WithStoreBuilder(Org.Apache.Kafka.Streams.State.StoreBuilder arg0)
            {
                return IExecute<Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder<K, V1, V2, VR>>("withStoreBuilder", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/KTableKTableJoinNode.KTableKTableJoinNodeBuilder.html#withThisJoinSideNodeName(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder"/></returns>
            public Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder<K, V1, V2, VR> WithThisJoinSideNodeName(string arg0)
            {
                return IExecute<Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder<K, V1, V2, VR>>("withThisJoinSideNodeName", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/KTableKTableJoinNode.KTableKTableJoinNodeBuilder.html#withValueSerde(org.apache.kafka.common.serialization.Serde)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder"/></returns>
            public Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder<K, V1, V2, VR> WithValueSerde(Org.Apache.Kafka.Common.Serialization.Serde<VR> arg0)
            {
                return IExecute<Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder<K, V1, V2, VR>>("withValueSerde", arg0);
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

    #region KTableKTableJoinNode<K, V1, V2, VR>
    public partial class KTableKTableJoinNode<K, V1, V2, VR>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode{K, V1, V2, VR}"/> to <see cref="Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode(Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode<K, V1, V2, VR> t) => t.Cast<Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/KTableKTableJoinNode.html#kTableKTableJoinNodeBuilder()"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder<K, V1, V2, VR> KTableKTableJoinNodeBuilderMethod()
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Internals.Graph.KTableKTableJoinNode.KTableKTableJoinNodeBuilder<K, V1, V2, VR>>(LocalBridgeClazz, "kTableKTableJoinNodeBuilder");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/KTableKTableJoinNode.html#joinMerger()"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.Kstream.Internals.KTableKTableJoinMerger<K, VR> JoinMerger
        {
            get { return IExecute<Org.Apache.Kafka.Streams.Kstream.Internals.KTableKTableJoinMerger<K, VR>>("joinMerger"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/KTableKTableJoinNode.html#joinOtherStoreNames()"/> 
        /// </summary>
        public string[] JoinOtherStoreNames
        {
            get { return IExecuteArray<string>("joinOtherStoreNames"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/KTableKTableJoinNode.html#joinThisStoreNames()"/> 
        /// </summary>
        public string[] JoinThisStoreNames
        {
            get { return IExecuteArray<string>("joinThisStoreNames"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/KTableKTableJoinNode.html#keySerde()"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.Serialization.Serde<K> KeySerde
        {
            get { return IExecute<Org.Apache.Kafka.Common.Serialization.Serde<K>>("keySerde"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/KTableKTableJoinNode.html#queryableStoreName()"/> 
        /// </summary>
        public string QueryableStoreName
        {
            get { return IExecute<string>("queryableStoreName"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/KTableKTableJoinNode.html#valueSerde()"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.Serialization.Serde<VR> ValueSerde
        {
            get { return IExecute<Org.Apache.Kafka.Common.Serialization.Serde<VR>>("valueSerde"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}