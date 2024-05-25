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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using kafka-streams-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams
{
    #region ITopologyDescription
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ITopologyDescription
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TopologyDescription
    public partial class TopologyDescription : Org.Apache.Kafka.Streams.ITopologyDescription
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/TopologyDescription.html#globalStores--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Org.Apache.Kafka.Streams.TopologyDescription.GlobalStore> GlobalStores()
        {
            return IExecuteWithSignature<Java.Util.Set<Org.Apache.Kafka.Streams.TopologyDescription.GlobalStore>>("globalStores", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/TopologyDescription.html#subtopologies--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Org.Apache.Kafka.Streams.TopologyDescription.Subtopology> Subtopologies()
        {
            return IExecuteWithSignature<Java.Util.Set<Org.Apache.Kafka.Streams.TopologyDescription.Subtopology>>("subtopologies", "()Ljava/util/Set;");
        }

        #endregion

        #region Nested classes
        #region GlobalStore
        public partial class GlobalStore
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/TopologyDescription.GlobalStore.html#id--"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int Id()
            {
                return IExecuteWithSignature<int>("id", "()I");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/TopologyDescription.GlobalStore.html#processor--"/>
            /// </summary>
            /// <returns><see cref="Org.Apache.Kafka.Streams.TopologyDescription.Processor"/></returns>
            public Org.Apache.Kafka.Streams.TopologyDescription.Processor ProcessorMethod()
            {
                return IExecuteWithSignature<Org.Apache.Kafka.Streams.TopologyDescription.Processor>("processor", "()Lorg/apache/kafka/streams/TopologyDescription$Processor;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/TopologyDescription.GlobalStore.html#source--"/>
            /// </summary>
            /// <returns><see cref="Org.Apache.Kafka.Streams.TopologyDescription.Source"/></returns>
            public Org.Apache.Kafka.Streams.TopologyDescription.Source SourceMethod()
            {
                return IExecuteWithSignature<Org.Apache.Kafka.Streams.TopologyDescription.Source>("source", "()Lorg/apache/kafka/streams/TopologyDescription$Source;");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Node
        public partial class Node
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/TopologyDescription.Node.html#name--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String Name()
            {
                return IExecuteWithSignature<Java.Lang.String>("name", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/TopologyDescription.Node.html#predecessors--"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Set"/></returns>
            public Java.Util.Set<Org.Apache.Kafka.Streams.TopologyDescription.Node> Predecessors()
            {
                return IExecuteWithSignature<Java.Util.Set<Org.Apache.Kafka.Streams.TopologyDescription.Node>>("predecessors", "()Ljava/util/Set;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/TopologyDescription.Node.html#successors--"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Set"/></returns>
            public Java.Util.Set<Org.Apache.Kafka.Streams.TopologyDescription.Node> Successors()
            {
                return IExecuteWithSignature<Java.Util.Set<Org.Apache.Kafka.Streams.TopologyDescription.Node>>("successors", "()Ljava/util/Set;");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Processor
        public partial class Processor
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/TopologyDescription.Processor.html#stores--"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Set"/></returns>
            public Java.Util.Set<Java.Lang.String> Stores()
            {
                return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("stores", "()Ljava/util/Set;");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Sink
        public partial class Sink
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/TopologyDescription.Sink.html#topic--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String Topic()
            {
                return IExecuteWithSignature<Java.Lang.String>("topic", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/TopologyDescription.Sink.html#topicNameExtractor--"/>
            /// </summary>
            /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.TopicNameExtractor"/></returns>
            public Org.Apache.Kafka.Streams.Processor.TopicNameExtractor<object, object> TopicNameExtractor()
            {
                return IExecuteWithSignature<Org.Apache.Kafka.Streams.Processor.TopicNameExtractor<object, object>>("topicNameExtractor", "()Lorg/apache/kafka/streams/processor/TopicNameExtractor;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/TopologyDescription.Sink.html#topicNameExtractor--"/>
            /// </summary>
            /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.TopicNameExtractor"/></returns>
            public Org.Apache.Kafka.Streams.Processor.TopicNameExtractor<object, object> TopicNameExtractorDirect()
            {
                return IExecuteWithSignature<Org.Apache.Kafka.Streams.Processor.TopicNameExtractorDirect<object, object>, Org.Apache.Kafka.Streams.Processor.TopicNameExtractor<object, object>>("topicNameExtractor", "()Lorg/apache/kafka/streams/processor/TopicNameExtractor;");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Source
        public partial class Source
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/TopologyDescription.Source.html#topicPattern--"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Regex.Pattern"/></returns>
            public Java.Util.Regex.Pattern TopicPattern()
            {
                return IExecuteWithSignature<Java.Util.Regex.Pattern>("topicPattern", "()Ljava/util/regex/Pattern;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/TopologyDescription.Source.html#topicSet--"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Set"/></returns>
            public Java.Util.Set<Java.Lang.String> TopicSet()
            {
                return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("topicSet", "()Ljava/util/Set;");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Subtopology
        public partial class Subtopology
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/TopologyDescription.Subtopology.html#id--"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int Id()
            {
                return IExecuteWithSignature<int>("id", "()I");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/TopologyDescription.Subtopology.html#nodes--"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Set"/></returns>
            public Java.Util.Set<Org.Apache.Kafka.Streams.TopologyDescription.Node> Nodes()
            {
                return IExecuteWithSignature<Java.Util.Set<Org.Apache.Kafka.Streams.TopologyDescription.Node>>("nodes", "()Ljava/util/Set;");
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