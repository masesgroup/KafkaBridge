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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using kafka-streams-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams
{
    #region IStreamsMetadata
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IStreamsMetadata
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region StreamsMetadata
    public partial class StreamsMetadata : Org.Apache.Kafka.Streams.IStreamsMetadata
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StreamsMetadata.html#port--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Port()
        {
            return IExecuteWithSignature<int>("port", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StreamsMetadata.html#host--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Host()
        {
            return IExecuteWithSignature<Java.Lang.String>("host", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StreamsMetadata.html#standbyStateStoreNames--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> StandbyStateStoreNames()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("standbyStateStoreNames", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StreamsMetadata.html#stateStoreNames--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> StateStoreNames()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("stateStoreNames", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StreamsMetadata.html#standbyTopicPartitions--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Org.Apache.Kafka.Common.TopicPartition> StandbyTopicPartitions()
        {
            return IExecuteWithSignature<Java.Util.Set<Org.Apache.Kafka.Common.TopicPartition>>("standbyTopicPartitions", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StreamsMetadata.html#topicPartitions--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Org.Apache.Kafka.Common.TopicPartition> TopicPartitions()
        {
            return IExecuteWithSignature<Java.Util.Set<Org.Apache.Kafka.Common.TopicPartition>>("topicPartitions", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StreamsMetadata.html#hostInfo--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.HostInfo"/></returns>
        public Org.Apache.Kafka.Streams.State.HostInfo HostInfo()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.State.HostInfo>("hostInfo", "()Lorg/apache/kafka/streams/state/HostInfo;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}