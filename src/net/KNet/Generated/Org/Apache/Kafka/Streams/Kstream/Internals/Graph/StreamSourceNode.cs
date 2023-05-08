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
    #region StreamSourceNode
    public partial class StreamSourceNode
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/StreamSourceNode.html#%3Cinit%3E(java.lang.String,java.util.Collection,org.apache.kafka.streams.kstream.internals.ConsumedInternal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Kstream.Internals.ConsumedInternal"/></param>
        public StreamSourceNode(string arg0, Java.Util.Collection arg1, Org.Apache.Kafka.Streams.Kstream.Internals.ConsumedInternal arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/StreamSourceNode.html#%3Cinit%3E(java.lang.String,java.util.regex.Pattern,org.apache.kafka.streams.kstream.internals.ConsumedInternal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.Regex.Pattern"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Kstream.Internals.ConsumedInternal"/></param>
        public StreamSourceNode(string arg0, Java.Util.Regex.Pattern arg1, Org.Apache.Kafka.Streams.Kstream.Internals.ConsumedInternal arg2)
            : base(arg0, arg1, arg2)
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
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/StreamSourceNode.html#merge(org.apache.kafka.streams.kstream.internals.graph.StreamSourceNode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Internals.Graph.StreamSourceNode"/></param>
        public void Merge(Org.Apache.Kafka.Streams.Kstream.Internals.Graph.StreamSourceNode arg0)
        {
            IExecute("merge", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region StreamSourceNode<K, V>
    public partial class StreamSourceNode<K, V>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/StreamSourceNode.html#%3Cinit%3E(java.lang.String,java.util.Collection,org.apache.kafka.streams.kstream.internals.ConsumedInternal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Kstream.Internals.ConsumedInternal"/></param>
        public StreamSourceNode(string arg0, Java.Util.Collection<string> arg1, Org.Apache.Kafka.Streams.Kstream.Internals.ConsumedInternal<K, V> arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/StreamSourceNode.html#%3Cinit%3E(java.lang.String,java.util.regex.Pattern,org.apache.kafka.streams.kstream.internals.ConsumedInternal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.Regex.Pattern"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Kstream.Internals.ConsumedInternal"/></param>
        public StreamSourceNode(string arg0, Java.Util.Regex.Pattern arg1, Org.Apache.Kafka.Streams.Kstream.Internals.ConsumedInternal<K, V> arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Kstream.Internals.Graph.StreamSourceNode{K, V}"/> to <see cref="Org.Apache.Kafka.Streams.Kstream.Internals.Graph.StreamSourceNode"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Kstream.Internals.Graph.StreamSourceNode(Org.Apache.Kafka.Streams.Kstream.Internals.Graph.StreamSourceNode<K, V> t) => t.Cast<Org.Apache.Kafka.Streams.Kstream.Internals.Graph.StreamSourceNode>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/graph/StreamSourceNode.html#merge(org.apache.kafka.streams.kstream.internals.graph.StreamSourceNode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Internals.Graph.StreamSourceNode"/></param>
        /// <typeparam name="Arg0Extendsobject"></typeparam>
        public void Merge<Arg0Extendsobject>(Org.Apache.Kafka.Streams.Kstream.Internals.Graph.StreamSourceNode<Arg0Extendsobject, Arg0Extendsobject> arg0)
        {
            IExecute("merge", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}