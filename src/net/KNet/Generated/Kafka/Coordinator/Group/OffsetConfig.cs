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
*  using kafka_2.13-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Kafka.Coordinator.Group
{
    #region OffsetConfig
    public partial class OffsetConfig
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/group/OffsetConfig.html#%3Cinit%3E(int,int,long,long,int,int,short,kafka.message.CompressionCodec,int,short)"/>
        /// </summary>
        /// <param name="maxMetadataSize"><see cref="int"/></param>
        /// <param name="loadBufferSize"><see cref="int"/></param>
        /// <param name="offsetsRetentionMs"><see cref="long"/></param>
        /// <param name="offsetsRetentionCheckIntervalMs"><see cref="long"/></param>
        /// <param name="offsetsTopicNumPartitions"><see cref="int"/></param>
        /// <param name="offsetsTopicSegmentBytes"><see cref="int"/></param>
        /// <param name="offsetsTopicReplicationFactor"><see cref="short"/></param>
        /// <param name="offsetsTopicCompressionCodec"><see cref="Kafka.Message.CompressionCodec"/></param>
        /// <param name="offsetCommitTimeoutMs"><see cref="int"/></param>
        /// <param name="offsetCommitRequiredAcks"><see cref="short"/></param>
        public OffsetConfig(int maxMetadataSize, int loadBufferSize, long offsetsRetentionMs, long offsetsRetentionCheckIntervalMs, int offsetsTopicNumPartitions, int offsetsTopicSegmentBytes, short offsetsTopicReplicationFactor, Kafka.Message.CompressionCodec offsetsTopicCompressionCodec, int offsetCommitTimeoutMs, short offsetCommitRequiredAcks)
            : base(maxMetadataSize, loadBufferSize, offsetsRetentionMs, offsetsRetentionCheckIntervalMs, offsetsTopicNumPartitions, offsetsTopicSegmentBytes, offsetsTopicReplicationFactor, offsetsTopicCompressionCodec, offsetCommitTimeoutMs, offsetCommitRequiredAcks)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Kafka.Coordinator.Group.OffsetConfig"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Kafka.Coordinator.Group.OffsetConfig t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/group/OffsetConfig.html#DefaultLoadBufferSize()"/> 
        /// </summary>
        public static int DefaultLoadBufferSize
        {
            get { return SExecute<int>(LocalBridgeClazz, "DefaultLoadBufferSize"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/group/OffsetConfig.html#DefaultMaxMetadataSize()"/> 
        /// </summary>
        public static int DefaultMaxMetadataSize
        {
            get { return SExecute<int>(LocalBridgeClazz, "DefaultMaxMetadataSize"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/group/OffsetConfig.html#DefaultOffsetCommitRequiredAcks()"/> 
        /// </summary>
        public static short DefaultOffsetCommitRequiredAcks
        {
            get { return SExecute<short>(LocalBridgeClazz, "DefaultOffsetCommitRequiredAcks"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/group/OffsetConfig.html#DefaultOffsetCommitTimeoutMs()"/> 
        /// </summary>
        public static int DefaultOffsetCommitTimeoutMs
        {
            get { return SExecute<int>(LocalBridgeClazz, "DefaultOffsetCommitTimeoutMs"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/group/OffsetConfig.html#DefaultOffsetRetentionMs()"/> 
        /// </summary>
        public static long DefaultOffsetRetentionMs
        {
            get { return SExecute<long>(LocalBridgeClazz, "DefaultOffsetRetentionMs"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/group/OffsetConfig.html#DefaultOffsetsRetentionCheckIntervalMs()"/> 
        /// </summary>
        public static long DefaultOffsetsRetentionCheckIntervalMs
        {
            get { return SExecute<long>(LocalBridgeClazz, "DefaultOffsetsRetentionCheckIntervalMs"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/group/OffsetConfig.html#DefaultOffsetsTopicCompressionCodec()"/> 
        /// </summary>
        public static Kafka.Message.NoCompressionCodec. DefaultOffsetsTopicCompressionCodec
        {
            get { return SExecute<Kafka.Message.NoCompressionCodec.>(LocalBridgeClazz, "DefaultOffsetsTopicCompressionCodec"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/group/OffsetConfig.html#DefaultOffsetsTopicNumPartitions()"/> 
        /// </summary>
        public static int DefaultOffsetsTopicNumPartitions
        {
            get { return SExecute<int>(LocalBridgeClazz, "DefaultOffsetsTopicNumPartitions"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/group/OffsetConfig.html#DefaultOffsetsTopicReplicationFactor()"/> 
        /// </summary>
        public static short DefaultOffsetsTopicReplicationFactor
        {
            get { return SExecute<short>(LocalBridgeClazz, "DefaultOffsetsTopicReplicationFactor"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/group/OffsetConfig.html#DefaultOffsetsTopicSegmentBytes()"/> 
        /// </summary>
        public static int DefaultOffsetsTopicSegmentBytes
        {
            get { return SExecute<int>(LocalBridgeClazz, "DefaultOffsetsTopicSegmentBytes"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/group/OffsetConfig.html#apply(int,int,long,long,int,int,short,kafka.message.CompressionCodec,int,short)"/>
        /// </summary>
        /// <param name="maxMetadataSize"><see cref="int"/></param>
        /// <param name="loadBufferSize"><see cref="int"/></param>
        /// <param name="offsetsRetentionMs"><see cref="long"/></param>
        /// <param name="offsetsRetentionCheckIntervalMs"><see cref="long"/></param>
        /// <param name="offsetsTopicNumPartitions"><see cref="int"/></param>
        /// <param name="offsetsTopicSegmentBytes"><see cref="int"/></param>
        /// <param name="offsetsTopicReplicationFactor"><see cref="short"/></param>
        /// <param name="offsetsTopicCompressionCodec"><see cref="Kafka.Message.CompressionCodec"/></param>
        /// <param name="offsetCommitTimeoutMs"><see cref="int"/></param>
        /// <param name="offsetCommitRequiredAcks"><see cref="short"/></param>
        /// <returns><see cref="Kafka.Coordinator.Group.OffsetConfig"/></returns>
        public static Kafka.Coordinator.Group.OffsetConfig Apply(int maxMetadataSize, int loadBufferSize, long offsetsRetentionMs, long offsetsRetentionCheckIntervalMs, int offsetsTopicNumPartitions, int offsetsTopicSegmentBytes, short offsetsTopicReplicationFactor, Kafka.Message.CompressionCodec offsetsTopicCompressionCodec, int offsetCommitTimeoutMs, short offsetCommitRequiredAcks)
        {
            return SExecute<Kafka.Coordinator.Group.OffsetConfig>(LocalBridgeClazz, "apply", maxMetadataSize, loadBufferSize, offsetsRetentionMs, offsetsRetentionCheckIntervalMs, offsetsTopicNumPartitions, offsetsTopicSegmentBytes, offsetsTopicReplicationFactor, offsetsTopicCompressionCodec, offsetCommitTimeoutMs, offsetCommitRequiredAcks);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/group/OffsetConfig.html#loadBufferSize()"/> 
        /// </summary>
        public int LoadBufferSize
        {
            get { return IExecute<int>("loadBufferSize"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/group/OffsetConfig.html#maxMetadataSize()"/> 
        /// </summary>
        public int MaxMetadataSize
        {
            get { return IExecute<int>("maxMetadataSize"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/group/OffsetConfig.html#offsetCommitRequiredAcks()"/> 
        /// </summary>
        public short OffsetCommitRequiredAcks
        {
            get { return IExecute<short>("offsetCommitRequiredAcks"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/group/OffsetConfig.html#offsetCommitTimeoutMs()"/> 
        /// </summary>
        public int OffsetCommitTimeoutMs
        {
            get { return IExecute<int>("offsetCommitTimeoutMs"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/group/OffsetConfig.html#offsetsRetentionCheckIntervalMs()"/> 
        /// </summary>
        public long OffsetsRetentionCheckIntervalMs
        {
            get { return IExecute<long>("offsetsRetentionCheckIntervalMs"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/group/OffsetConfig.html#offsetsRetentionMs()"/> 
        /// </summary>
        public long OffsetsRetentionMs
        {
            get { return IExecute<long>("offsetsRetentionMs"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/group/OffsetConfig.html#offsetsTopicCompressionCodec()"/> 
        /// </summary>
        public Kafka.Message.CompressionCodec OffsetsTopicCompressionCodec
        {
            get { return IExecute<Kafka.Message.CompressionCodec>("offsetsTopicCompressionCodec"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/group/OffsetConfig.html#offsetsTopicNumPartitions()"/> 
        /// </summary>
        public int OffsetsTopicNumPartitions
        {
            get { return IExecute<int>("offsetsTopicNumPartitions"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/group/OffsetConfig.html#offsetsTopicReplicationFactor()"/> 
        /// </summary>
        public short OffsetsTopicReplicationFactor
        {
            get { return IExecute<short>("offsetsTopicReplicationFactor"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/group/OffsetConfig.html#offsetsTopicSegmentBytes()"/> 
        /// </summary>
        public int OffsetsTopicSegmentBytes
        {
            get { return IExecute<int>("offsetsTopicSegmentBytes"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/group/OffsetConfig.html#productArity()"/> 
        /// </summary>
        public int ProductArity
        {
            get { return IExecute<int>("productArity"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/group/OffsetConfig.html#productPrefix()"/> 
        /// </summary>
        public string ProductPrefix
        {
            get { return IExecute<string>("productPrefix"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/group/OffsetConfig.html#canEqual(java.lang.Object)"/>
        /// </summary>
        /// <param name="x$1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CanEqual(object x_1)
        {
            return IExecute<bool>("canEqual", x_1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/group/OffsetConfig.html#productElement(int)"/>
        /// </summary>
        /// <param name="x$1"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object ProductElement(int x_1)
        {
            return IExecute("productElement", x_1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/group/OffsetConfig.html#productElementName(int)"/>
        /// </summary>
        /// <param name="x$1"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string ProductElementName(int x_1)
        {
            return IExecute<string>("productElementName", x_1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/group/OffsetConfig.html#copy(int,int,long,long,int,int,short,kafka.message.CompressionCodec,int,short)"/>
        /// </summary>
        /// <param name="maxMetadataSize"><see cref="int"/></param>
        /// <param name="loadBufferSize"><see cref="int"/></param>
        /// <param name="offsetsRetentionMs"><see cref="long"/></param>
        /// <param name="offsetsRetentionCheckIntervalMs"><see cref="long"/></param>
        /// <param name="offsetsTopicNumPartitions"><see cref="int"/></param>
        /// <param name="offsetsTopicSegmentBytes"><see cref="int"/></param>
        /// <param name="offsetsTopicReplicationFactor"><see cref="short"/></param>
        /// <param name="offsetsTopicCompressionCodec"><see cref="Kafka.Message.CompressionCodec"/></param>
        /// <param name="offsetCommitTimeoutMs"><see cref="int"/></param>
        /// <param name="offsetCommitRequiredAcks"><see cref="short"/></param>
        /// <returns><see cref="Kafka.Coordinator.Group.OffsetConfig"/></returns>
        public Kafka.Coordinator.Group.OffsetConfig Copy(int maxMetadataSize, int loadBufferSize, long offsetsRetentionMs, long offsetsRetentionCheckIntervalMs, int offsetsTopicNumPartitions, int offsetsTopicSegmentBytes, short offsetsTopicReplicationFactor, Kafka.Message.CompressionCodec offsetsTopicCompressionCodec, int offsetCommitTimeoutMs, short offsetCommitRequiredAcks)
        {
            return IExecute<Kafka.Coordinator.Group.OffsetConfig>("copy", maxMetadataSize, loadBufferSize, offsetsRetentionMs, offsetsRetentionCheckIntervalMs, offsetsTopicNumPartitions, offsetsTopicSegmentBytes, offsetsTopicReplicationFactor, offsetsTopicCompressionCodec, offsetCommitTimeoutMs, offsetCommitRequiredAcks);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}