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
*  using kafka-clients-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Record
{
    #region IRecordBatch
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IRecordBatch
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region RecordBatch
    public partial class RecordBatch : Org.Apache.Kafka.Common.Record.IRecordBatch
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordBatch.html#CURRENT_MAGIC_VALUE"/>
        /// </summary>
        public static byte CURRENT_MAGIC_VALUE { get { if (!_CURRENT_MAGIC_VALUEReady) { _CURRENT_MAGIC_VALUEContent = SGetField<byte>(LocalBridgeClazz, "CURRENT_MAGIC_VALUE"); _CURRENT_MAGIC_VALUEReady = true; } return _CURRENT_MAGIC_VALUEContent; } }
        private static byte _CURRENT_MAGIC_VALUEContent = default;
        private static bool _CURRENT_MAGIC_VALUEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordBatch.html#MAGIC_VALUE_V0"/>
        /// </summary>
        public static byte MAGIC_VALUE_V0 { get { if (!_MAGIC_VALUE_V0Ready) { _MAGIC_VALUE_V0Content = SGetField<byte>(LocalBridgeClazz, "MAGIC_VALUE_V0"); _MAGIC_VALUE_V0Ready = true; } return _MAGIC_VALUE_V0Content; } }
        private static byte _MAGIC_VALUE_V0Content = default;
        private static bool _MAGIC_VALUE_V0Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordBatch.html#MAGIC_VALUE_V1"/>
        /// </summary>
        public static byte MAGIC_VALUE_V1 { get { if (!_MAGIC_VALUE_V1Ready) { _MAGIC_VALUE_V1Content = SGetField<byte>(LocalBridgeClazz, "MAGIC_VALUE_V1"); _MAGIC_VALUE_V1Ready = true; } return _MAGIC_VALUE_V1Content; } }
        private static byte _MAGIC_VALUE_V1Content = default;
        private static bool _MAGIC_VALUE_V1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordBatch.html#MAGIC_VALUE_V2"/>
        /// </summary>
        public static byte MAGIC_VALUE_V2 { get { if (!_MAGIC_VALUE_V2Ready) { _MAGIC_VALUE_V2Content = SGetField<byte>(LocalBridgeClazz, "MAGIC_VALUE_V2"); _MAGIC_VALUE_V2Ready = true; } return _MAGIC_VALUE_V2Content; } }
        private static byte _MAGIC_VALUE_V2Content = default;
        private static bool _MAGIC_VALUE_V2Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordBatch.html#NO_PARTITION_LEADER_EPOCH"/>
        /// </summary>
        public static int NO_PARTITION_LEADER_EPOCH { get { if (!_NO_PARTITION_LEADER_EPOCHReady) { _NO_PARTITION_LEADER_EPOCHContent = SGetField<int>(LocalBridgeClazz, "NO_PARTITION_LEADER_EPOCH"); _NO_PARTITION_LEADER_EPOCHReady = true; } return _NO_PARTITION_LEADER_EPOCHContent; } }
        private static int _NO_PARTITION_LEADER_EPOCHContent = default;
        private static bool _NO_PARTITION_LEADER_EPOCHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordBatch.html#NO_SEQUENCE"/>
        /// </summary>
        public static int NO_SEQUENCE { get { if (!_NO_SEQUENCEReady) { _NO_SEQUENCEContent = SGetField<int>(LocalBridgeClazz, "NO_SEQUENCE"); _NO_SEQUENCEReady = true; } return _NO_SEQUENCEContent; } }
        private static int _NO_SEQUENCEContent = default;
        private static bool _NO_SEQUENCEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordBatch.html#NO_PRODUCER_ID"/>
        /// </summary>
        public static long NO_PRODUCER_ID { get { if (!_NO_PRODUCER_IDReady) { _NO_PRODUCER_IDContent = SGetField<long>(LocalBridgeClazz, "NO_PRODUCER_ID"); _NO_PRODUCER_IDReady = true; } return _NO_PRODUCER_IDContent; } }
        private static long _NO_PRODUCER_IDContent = default;
        private static bool _NO_PRODUCER_IDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordBatch.html#NO_TIMESTAMP"/>
        /// </summary>
        public static long NO_TIMESTAMP { get { if (!_NO_TIMESTAMPReady) { _NO_TIMESTAMPContent = SGetField<long>(LocalBridgeClazz, "NO_TIMESTAMP"); _NO_TIMESTAMPReady = true; } return _NO_TIMESTAMPContent; } }
        private static long _NO_TIMESTAMPContent = default;
        private static bool _NO_TIMESTAMPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordBatch.html#NO_PRODUCER_EPOCH"/>
        /// </summary>
        public static short NO_PRODUCER_EPOCH { get { if (!_NO_PRODUCER_EPOCHReady) { _NO_PRODUCER_EPOCHContent = SGetField<short>(LocalBridgeClazz, "NO_PRODUCER_EPOCH"); _NO_PRODUCER_EPOCHReady = true; } return _NO_PRODUCER_EPOCHContent; } }
        private static short _NO_PRODUCER_EPOCHContent = default;
        private static bool _NO_PRODUCER_EPOCHReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordBatch.html#hasProducerId--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasProducerId()
        {
            return IExecuteWithSignature<bool>("hasProducerId", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordBatch.html#isCompressed--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCompressed()
        {
            return IExecuteWithSignature<bool>("isCompressed", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordBatch.html#isControlBatch--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsControlBatch()
        {
            return IExecuteWithSignature<bool>("isControlBatch", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordBatch.html#isTransactional--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsTransactional()
        {
            return IExecuteWithSignature<bool>("isTransactional", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordBatch.html#isValid--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsValid()
        {
            return IExecuteWithSignature<bool>("isValid", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordBatch.html#magic--"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte Magic()
        {
            return IExecuteWithSignature<byte>("magic", "()B");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordBatch.html#baseSequence--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int BaseSequence()
        {
            return IExecuteWithSignature<int>("baseSequence", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordBatch.html#lastSequence--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int LastSequence()
        {
            return IExecuteWithSignature<int>("lastSequence", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordBatch.html#partitionLeaderEpoch--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int PartitionLeaderEpoch()
        {
            return IExecuteWithSignature<int>("partitionLeaderEpoch", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordBatch.html#sizeInBytes--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int SizeInBytes()
        {
            return IExecuteWithSignature<int>("sizeInBytes", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordBatch.html#countOrNull--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        public Java.Lang.Integer CountOrNull()
        {
            return IExecuteWithSignature<Java.Lang.Integer>("countOrNull", "()Ljava/lang/Integer;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordBatch.html#deleteHorizonMs--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.OptionalLong"/></returns>
        public Java.Util.OptionalLong DeleteHorizonMs()
        {
            return IExecuteWithSignature<Java.Util.OptionalLong>("deleteHorizonMs", "()Ljava/util/OptionalLong;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordBatch.html#baseOffset--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long BaseOffset()
        {
            return IExecuteWithSignature<long>("baseOffset", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordBatch.html#checksum--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long Checksum()
        {
            return IExecuteWithSignature<long>("checksum", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordBatch.html#lastOffset--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long LastOffset()
        {
            return IExecuteWithSignature<long>("lastOffset", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordBatch.html#maxTimestamp--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long MaxTimestamp()
        {
            return IExecuteWithSignature<long>("maxTimestamp", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordBatch.html#nextOffset--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long NextOffset()
        {
            return IExecuteWithSignature<long>("nextOffset", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordBatch.html#producerId--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long ProducerId()
        {
            return IExecuteWithSignature<long>("producerId", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordBatch.html#compressionType--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Record.CompressionType"/></returns>
        public Org.Apache.Kafka.Common.Record.CompressionType CompressionType()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Record.CompressionType>("compressionType", "()Lorg/apache/kafka/common/record/CompressionType;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordBatch.html#timestampType--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Record.TimestampType"/></returns>
        public Org.Apache.Kafka.Common.Record.TimestampType TimestampType()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Record.TimestampType>("timestampType", "()Lorg/apache/kafka/common/record/TimestampType;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordBatch.html#streamingIterator-org.apache.kafka.common.utils.BufferSupplier-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Utils.BufferSupplier"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Utils.CloseableIterator"/></returns>
        public Org.Apache.Kafka.Common.Utils.CloseableIterator<Org.Apache.Kafka.Common.Record.Record> StreamingIterator(Org.Apache.Kafka.Common.Utils.BufferSupplier arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Utils.CloseableIterator<Org.Apache.Kafka.Common.Record.Record>>("streamingIterator", "(Lorg/apache/kafka/common/utils/BufferSupplier;)Lorg/apache/kafka/common/utils/CloseableIterator;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordBatch.html#producerEpoch--"/>
        /// </summary>
        /// <returns><see cref="short"/></returns>
        public short ProducerEpoch()
        {
            return IExecuteWithSignature<short>("producerEpoch", "()S");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordBatch.html#ensureValid--"/>
        /// </summary>
        public void EnsureValid()
        {
            IExecuteWithSignature("ensureValid", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordBatch.html#writeTo-java.nio.ByteBuffer-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        public void WriteTo(Java.Nio.ByteBuffer arg0)
        {
            IExecuteWithSignature("writeTo", "(Ljava/nio/ByteBuffer;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}