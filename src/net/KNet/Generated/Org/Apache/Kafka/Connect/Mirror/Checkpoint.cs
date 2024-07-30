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
*  using connect-mirror-client-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Mirror
{
    #region Checkpoint
    public partial class Checkpoint
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.8.0/org/apache/kafka/connect/mirror/Checkpoint.html#org.apache.kafka.connect.mirror.Checkpoint(java.lang.String,org.apache.kafka.common.TopicPartition,long,long,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <param name="arg4"><see cref="Java.Lang.String"/></param>
        public Checkpoint(Java.Lang.String arg0, Org.Apache.Kafka.Common.TopicPartition arg1, long arg2, long arg3, Java.Lang.String arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.8.0/org/apache/kafka/connect/mirror/Checkpoint.html#CONSUMER_GROUP_ID_KEY"/>
        /// </summary>
        public static Java.Lang.String CONSUMER_GROUP_ID_KEY { get { if (!_CONSUMER_GROUP_ID_KEYReady) { _CONSUMER_GROUP_ID_KEYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CONSUMER_GROUP_ID_KEY"); _CONSUMER_GROUP_ID_KEYReady = true; } return _CONSUMER_GROUP_ID_KEYContent; } }
        private static Java.Lang.String _CONSUMER_GROUP_ID_KEYContent = default;
        private static bool _CONSUMER_GROUP_ID_KEYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.8.0/org/apache/kafka/connect/mirror/Checkpoint.html#DOWNSTREAM_OFFSET_KEY"/>
        /// </summary>
        public static Java.Lang.String DOWNSTREAM_OFFSET_KEY { get { if (!_DOWNSTREAM_OFFSET_KEYReady) { _DOWNSTREAM_OFFSET_KEYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DOWNSTREAM_OFFSET_KEY"); _DOWNSTREAM_OFFSET_KEYReady = true; } return _DOWNSTREAM_OFFSET_KEYContent; } }
        private static Java.Lang.String _DOWNSTREAM_OFFSET_KEYContent = default;
        private static bool _DOWNSTREAM_OFFSET_KEYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.8.0/org/apache/kafka/connect/mirror/Checkpoint.html#METADATA_KEY"/>
        /// </summary>
        public static Java.Lang.String METADATA_KEY { get { if (!_METADATA_KEYReady) { _METADATA_KEYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "METADATA_KEY"); _METADATA_KEYReady = true; } return _METADATA_KEYContent; } }
        private static Java.Lang.String _METADATA_KEYContent = default;
        private static bool _METADATA_KEYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.8.0/org/apache/kafka/connect/mirror/Checkpoint.html#PARTITION_KEY"/>
        /// </summary>
        public static Java.Lang.String PARTITION_KEY { get { if (!_PARTITION_KEYReady) { _PARTITION_KEYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "PARTITION_KEY"); _PARTITION_KEYReady = true; } return _PARTITION_KEYContent; } }
        private static Java.Lang.String _PARTITION_KEYContent = default;
        private static bool _PARTITION_KEYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.8.0/org/apache/kafka/connect/mirror/Checkpoint.html#TOPIC_KEY"/>
        /// </summary>
        public static Java.Lang.String TOPIC_KEY { get { if (!_TOPIC_KEYReady) { _TOPIC_KEYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TOPIC_KEY"); _TOPIC_KEYReady = true; } return _TOPIC_KEYContent; } }
        private static Java.Lang.String _TOPIC_KEYContent = default;
        private static bool _TOPIC_KEYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.8.0/org/apache/kafka/connect/mirror/Checkpoint.html#UPSTREAM_OFFSET_KEY"/>
        /// </summary>
        public static Java.Lang.String UPSTREAM_OFFSET_KEY { get { if (!_UPSTREAM_OFFSET_KEYReady) { _UPSTREAM_OFFSET_KEYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "UPSTREAM_OFFSET_KEY"); _UPSTREAM_OFFSET_KEYReady = true; } return _UPSTREAM_OFFSET_KEYContent; } }
        private static Java.Lang.String _UPSTREAM_OFFSET_KEYContent = default;
        private static bool _UPSTREAM_OFFSET_KEYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.8.0/org/apache/kafka/connect/mirror/Checkpoint.html#VERSION_KEY"/>
        /// </summary>
        public static Java.Lang.String VERSION_KEY { get { if (!_VERSION_KEYReady) { _VERSION_KEYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "VERSION_KEY"); _VERSION_KEYReady = true; } return _VERSION_KEYContent; } }
        private static Java.Lang.String _VERSION_KEYContent = default;
        private static bool _VERSION_KEYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.8.0/org/apache/kafka/connect/mirror/Checkpoint.html#VERSION"/>
        /// </summary>
        public static short VERSION { get { if (!_VERSIONReady) { _VERSIONContent = SGetField<short>(LocalBridgeClazz, "VERSION"); _VERSIONReady = true; } return _VERSIONContent; } }
        private static short _VERSIONContent = default;
        private static bool _VERSIONReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.8.0/org/apache/kafka/connect/mirror/Checkpoint.html#deserializeRecord-org.apache.kafka.clients.consumer.ConsumerRecord-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerRecord"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Mirror.Checkpoint"/></returns>
        public static Org.Apache.Kafka.Connect.Mirror.Checkpoint DeserializeRecord(Org.Apache.Kafka.Clients.Consumer.ConsumerRecord<byte[], byte[]> arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Connect.Mirror.Checkpoint>(LocalBridgeClazz, "deserializeRecord", "(Lorg/apache/kafka/clients/consumer/ConsumerRecord;)Lorg/apache/kafka/connect/mirror/Checkpoint;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.8.0/org/apache/kafka/connect/mirror/Checkpoint.html#consumerGroupId--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ConsumerGroupId()
        {
            return IExecuteWithSignature<Java.Lang.String>("consumerGroupId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.8.0/org/apache/kafka/connect/mirror/Checkpoint.html#metadata--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Metadata()
        {
            return IExecuteWithSignature<Java.Lang.String>("metadata", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.8.0/org/apache/kafka/connect/mirror/Checkpoint.html#downstreamOffset--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long DownstreamOffset()
        {
            return IExecuteWithSignature<long>("downstreamOffset", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.8.0/org/apache/kafka/connect/mirror/Checkpoint.html#upstreamOffset--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long UpstreamOffset()
        {
            return IExecuteWithSignature<long>("upstreamOffset", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.8.0/org/apache/kafka/connect/mirror/Checkpoint.html#offsetAndMetadata--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Consumer.OffsetAndMetadata"/></returns>
        public Org.Apache.Kafka.Clients.Consumer.OffsetAndMetadata OffsetAndMetadata()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Clients.Consumer.OffsetAndMetadata>("offsetAndMetadata", "()Lorg/apache/kafka/clients/consumer/OffsetAndMetadata;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.8.0/org/apache/kafka/connect/mirror/Checkpoint.html#topicPartition--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.TopicPartition"/></returns>
        public Org.Apache.Kafka.Common.TopicPartition TopicPartition()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.TopicPartition>("topicPartition", "()Lorg/apache/kafka/common/TopicPartition;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}