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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using connect-mirror-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Mirror
{
    #region OffsetSync
    public partial class OffsetSync
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/OffsetSync.html#org.apache.kafka.connect.mirror.OffsetSync(org.apache.kafka.common.TopicPartition,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public OffsetSync(Org.Apache.Kafka.Common.TopicPartition arg0, long arg1, long arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/OffsetSync.html#DOWNSTREAM_OFFSET_KEY"/>
        /// </summary>
        public static Java.Lang.String DOWNSTREAM_OFFSET_KEY { get { if (!_DOWNSTREAM_OFFSET_KEYReady) { _DOWNSTREAM_OFFSET_KEYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DOWNSTREAM_OFFSET_KEY"); _DOWNSTREAM_OFFSET_KEYReady = true; } return _DOWNSTREAM_OFFSET_KEYContent; } }
        private static Java.Lang.String _DOWNSTREAM_OFFSET_KEYContent = default;
        private static bool _DOWNSTREAM_OFFSET_KEYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/OffsetSync.html#PARTITION_KEY"/>
        /// </summary>
        public static Java.Lang.String PARTITION_KEY { get { if (!_PARTITION_KEYReady) { _PARTITION_KEYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "PARTITION_KEY"); _PARTITION_KEYReady = true; } return _PARTITION_KEYContent; } }
        private static Java.Lang.String _PARTITION_KEYContent = default;
        private static bool _PARTITION_KEYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/OffsetSync.html#TOPIC_KEY"/>
        /// </summary>
        public static Java.Lang.String TOPIC_KEY { get { if (!_TOPIC_KEYReady) { _TOPIC_KEYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TOPIC_KEY"); _TOPIC_KEYReady = true; } return _TOPIC_KEYContent; } }
        private static Java.Lang.String _TOPIC_KEYContent = default;
        private static bool _TOPIC_KEYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/OffsetSync.html#UPSTREAM_OFFSET_KEY"/>
        /// </summary>
        public static Java.Lang.String UPSTREAM_OFFSET_KEY { get { if (!_UPSTREAM_OFFSET_KEYReady) { _UPSTREAM_OFFSET_KEYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "UPSTREAM_OFFSET_KEY"); _UPSTREAM_OFFSET_KEYReady = true; } return _UPSTREAM_OFFSET_KEYContent; } }
        private static Java.Lang.String _UPSTREAM_OFFSET_KEYContent = default;
        private static bool _UPSTREAM_OFFSET_KEYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/OffsetSync.html#deserializeRecord-org.apache.kafka.clients.consumer.ConsumerRecord-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerRecord"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Mirror.OffsetSync"/></returns>
        public static Org.Apache.Kafka.Connect.Mirror.OffsetSync DeserializeRecord(Org.Apache.Kafka.Clients.Consumer.ConsumerRecord<byte[], byte[]> arg0)
        {
            return SExecute<Org.Apache.Kafka.Connect.Mirror.OffsetSync>(LocalBridgeClazz, "deserializeRecord", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/OffsetSync.html#downstreamOffset--"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long DownstreamOffset()
        {
            return IExecute<long>("downstreamOffset");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/OffsetSync.html#upstreamOffset--"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long UpstreamOffset()
        {
            return IExecute<long>("upstreamOffset");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/OffsetSync.html#topicPartition--"/>
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