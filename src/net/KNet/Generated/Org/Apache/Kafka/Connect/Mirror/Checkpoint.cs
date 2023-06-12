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
*  using connect-mirror-client-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Mirror
{
    #region Checkpoint
    public partial class Checkpoint
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.4.0/org/apache/kafka/connect/mirror/Checkpoint.html#%3Cinit%3E(java.lang.String,org.apache.kafka.common.TopicPartition,long,long,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <param name="arg4"><see cref="string"/></param>
        public Checkpoint(string arg0, Org.Apache.Kafka.Common.TopicPartition arg1, long arg2, long arg3, string arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.4.0/org/apache/kafka/connect/mirror/Checkpoint.html#CONSUMER_GROUP_ID_KEY"/>
        /// </summary>
        public static string CONSUMER_GROUP_ID_KEY { get { return SGetField<string>(LocalBridgeClazz, "CONSUMER_GROUP_ID_KEY"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.4.0/org/apache/kafka/connect/mirror/Checkpoint.html#DOWNSTREAM_OFFSET_KEY"/>
        /// </summary>
        public static string DOWNSTREAM_OFFSET_KEY { get { return SGetField<string>(LocalBridgeClazz, "DOWNSTREAM_OFFSET_KEY"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.4.0/org/apache/kafka/connect/mirror/Checkpoint.html#METADATA_KEY"/>
        /// </summary>
        public static string METADATA_KEY { get { return SGetField<string>(LocalBridgeClazz, "METADATA_KEY"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.4.0/org/apache/kafka/connect/mirror/Checkpoint.html#PARTITION_KEY"/>
        /// </summary>
        public static string PARTITION_KEY { get { return SGetField<string>(LocalBridgeClazz, "PARTITION_KEY"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.4.0/org/apache/kafka/connect/mirror/Checkpoint.html#TOPIC_KEY"/>
        /// </summary>
        public static string TOPIC_KEY { get { return SGetField<string>(LocalBridgeClazz, "TOPIC_KEY"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.4.0/org/apache/kafka/connect/mirror/Checkpoint.html#UPSTREAM_OFFSET_KEY"/>
        /// </summary>
        public static string UPSTREAM_OFFSET_KEY { get { return SGetField<string>(LocalBridgeClazz, "UPSTREAM_OFFSET_KEY"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.4.0/org/apache/kafka/connect/mirror/Checkpoint.html#VERSION_KEY"/>
        /// </summary>
        public static string VERSION_KEY { get { return SGetField<string>(LocalBridgeClazz, "VERSION_KEY"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.4.0/org/apache/kafka/connect/mirror/Checkpoint.html#HEADER_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Protocol.Types.Schema HEADER_SCHEMA { get { return SGetField<Org.Apache.Kafka.Common.Protocol.Types.Schema>(LocalBridgeClazz, "HEADER_SCHEMA"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.4.0/org/apache/kafka/connect/mirror/Checkpoint.html#KEY_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Protocol.Types.Schema KEY_SCHEMA { get { return SGetField<Org.Apache.Kafka.Common.Protocol.Types.Schema>(LocalBridgeClazz, "KEY_SCHEMA"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.4.0/org/apache/kafka/connect/mirror/Checkpoint.html#VALUE_SCHEMA_V0"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Protocol.Types.Schema VALUE_SCHEMA_V0 { get { return SGetField<Org.Apache.Kafka.Common.Protocol.Types.Schema>(LocalBridgeClazz, "VALUE_SCHEMA_V0"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.4.0/org/apache/kafka/connect/mirror/Checkpoint.html#VERSION"/>
        /// </summary>
        public static short VERSION { get { return SGetField<short>(LocalBridgeClazz, "VERSION"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.4.0/org/apache/kafka/connect/mirror/Checkpoint.html#deserializeRecord(org.apache.kafka.clients.consumer.ConsumerRecord)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerRecord"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Mirror.Checkpoint"/></returns>
        public static Org.Apache.Kafka.Connect.Mirror.Checkpoint DeserializeRecord(Org.Apache.Kafka.Clients.Consumer.ConsumerRecord<byte[], byte[]> arg0)
        {
            return SExecute<Org.Apache.Kafka.Connect.Mirror.Checkpoint>(LocalBridgeClazz, "deserializeRecord", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.4.0/org/apache/kafka/connect/mirror/Checkpoint.html#consumerGroupId()"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string ConsumerGroupId()
        {
            return IExecute<string>("consumerGroupId");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.4.0/org/apache/kafka/connect/mirror/Checkpoint.html#metadata()"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string Metadata()
        {
            return IExecute<string>("metadata");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.4.0/org/apache/kafka/connect/mirror/Checkpoint.html#downstreamOffset()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long DownstreamOffset()
        {
            return IExecute<long>("downstreamOffset");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.4.0/org/apache/kafka/connect/mirror/Checkpoint.html#upstreamOffset()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long UpstreamOffset()
        {
            return IExecute<long>("upstreamOffset");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.4.0/org/apache/kafka/connect/mirror/Checkpoint.html#offsetAndMetadata()"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Clients.Consumer.OffsetAndMetadata"/></returns>
        public Org.Apache.Kafka.Clients.Consumer.OffsetAndMetadata OffsetAndMetadata()
        {
            return IExecute<Org.Apache.Kafka.Clients.Consumer.OffsetAndMetadata>("offsetAndMetadata");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.4.0/org/apache/kafka/connect/mirror/Checkpoint.html#topicPartition()"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.TopicPartition"/></returns>
        public Org.Apache.Kafka.Common.TopicPartition TopicPartition()
        {
            return IExecute<Org.Apache.Kafka.Common.TopicPartition>("topicPartition");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}