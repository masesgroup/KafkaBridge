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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using kafka-clients-3.6.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Record
{
    #region LegacyRecord
    public partial class LegacyRecord
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#org.apache.kafka.common.record.LegacyRecord(java.nio.ByteBuffer,java.lang.Long,org.apache.kafka.common.record.TimestampType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Long"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Record.TimestampType"/></param>
        public LegacyRecord(Java.Nio.ByteBuffer arg0, Java.Lang.Long arg1, Org.Apache.Kafka.Common.Record.TimestampType arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#org.apache.kafka.common.record.LegacyRecord(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        public LegacyRecord(Java.Nio.ByteBuffer arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#ATTRIBUTES_LENGTH"/>
        /// </summary>
        public static int ATTRIBUTES_LENGTH { get { return SGetField<int>(LocalBridgeClazz, "ATTRIBUTES_LENGTH"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#ATTRIBUTES_OFFSET"/>
        /// </summary>
        public static int ATTRIBUTES_OFFSET { get { return SGetField<int>(LocalBridgeClazz, "ATTRIBUTES_OFFSET"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#CRC_LENGTH"/>
        /// </summary>
        public static int CRC_LENGTH { get { return SGetField<int>(LocalBridgeClazz, "CRC_LENGTH"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#CRC_OFFSET"/>
        /// </summary>
        public static int CRC_OFFSET { get { return SGetField<int>(LocalBridgeClazz, "CRC_OFFSET"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#HEADER_SIZE_V0"/>
        /// </summary>
        public static int HEADER_SIZE_V0 { get { return SGetField<int>(LocalBridgeClazz, "HEADER_SIZE_V0"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#HEADER_SIZE_V1"/>
        /// </summary>
        public static int HEADER_SIZE_V1 { get { return SGetField<int>(LocalBridgeClazz, "HEADER_SIZE_V1"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#KEY_OFFSET_V0"/>
        /// </summary>
        public static int KEY_OFFSET_V0 { get { return SGetField<int>(LocalBridgeClazz, "KEY_OFFSET_V0"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#KEY_OFFSET_V1"/>
        /// </summary>
        public static int KEY_OFFSET_V1 { get { return SGetField<int>(LocalBridgeClazz, "KEY_OFFSET_V1"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#KEY_SIZE_LENGTH"/>
        /// </summary>
        public static int KEY_SIZE_LENGTH { get { return SGetField<int>(LocalBridgeClazz, "KEY_SIZE_LENGTH"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#KEY_SIZE_OFFSET_V0"/>
        /// </summary>
        public static int KEY_SIZE_OFFSET_V0 { get { return SGetField<int>(LocalBridgeClazz, "KEY_SIZE_OFFSET_V0"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#KEY_SIZE_OFFSET_V1"/>
        /// </summary>
        public static int KEY_SIZE_OFFSET_V1 { get { return SGetField<int>(LocalBridgeClazz, "KEY_SIZE_OFFSET_V1"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#MAGIC_LENGTH"/>
        /// </summary>
        public static int MAGIC_LENGTH { get { return SGetField<int>(LocalBridgeClazz, "MAGIC_LENGTH"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#MAGIC_OFFSET"/>
        /// </summary>
        public static int MAGIC_OFFSET { get { return SGetField<int>(LocalBridgeClazz, "MAGIC_OFFSET"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#RECORD_OVERHEAD_V0"/>
        /// </summary>
        public static int RECORD_OVERHEAD_V0 { get { return SGetField<int>(LocalBridgeClazz, "RECORD_OVERHEAD_V0"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#RECORD_OVERHEAD_V1"/>
        /// </summary>
        public static int RECORD_OVERHEAD_V1 { get { return SGetField<int>(LocalBridgeClazz, "RECORD_OVERHEAD_V1"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#TIMESTAMP_LENGTH"/>
        /// </summary>
        public static int TIMESTAMP_LENGTH { get { return SGetField<int>(LocalBridgeClazz, "TIMESTAMP_LENGTH"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#TIMESTAMP_OFFSET"/>
        /// </summary>
        public static int TIMESTAMP_OFFSET { get { return SGetField<int>(LocalBridgeClazz, "TIMESTAMP_OFFSET"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#VALUE_SIZE_LENGTH"/>
        /// </summary>
        public static int VALUE_SIZE_LENGTH { get { return SGetField<int>(LocalBridgeClazz, "VALUE_SIZE_LENGTH"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#NO_TIMESTAMP"/>
        /// </summary>
        public static long NO_TIMESTAMP { get { return SGetField<long>(LocalBridgeClazz, "NO_TIMESTAMP"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#computeAttributes-byte-org.apache.kafka.common.record.CompressionType-org.apache.kafka.common.record.TimestampType-"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Record.CompressionType"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Record.TimestampType"/></param>
        /// <returns><see cref="byte"/></returns>
        public static byte ComputeAttributes(byte arg0, Org.Apache.Kafka.Common.Record.CompressionType arg1, Org.Apache.Kafka.Common.Record.TimestampType arg2)
        {
            return SExecute<byte>(LocalBridgeClazz, "computeAttributes", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#recordSize-byte-int-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int RecordSize(byte arg0, int arg1, int arg2)
        {
            return SExecute<int>(LocalBridgeClazz, "recordSize", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#computeChecksum-byte-byte-long-byte[]-byte[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="byte"/></param>
        /// <param name="arg4"><see cref="byte"/></param>
        /// <returns><see cref="long"/></returns>
        public static long ComputeChecksum(byte arg0, byte arg1, long arg2, byte[] arg3, byte[] arg4)
        {
            return SExecute<long>(LocalBridgeClazz, "computeChecksum", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#write-java.io.DataOutputStream-byte-long-byte[]-byte[]-org.apache.kafka.common.record.CompressionType-org.apache.kafka.common.record.TimestampType-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.DataOutputStream"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="byte"/></param>
        /// <param name="arg4"><see cref="byte"/></param>
        /// <param name="arg5"><see cref="Org.Apache.Kafka.Common.Record.CompressionType"/></param>
        /// <param name="arg6"><see cref="Org.Apache.Kafka.Common.Record.TimestampType"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static long Write(Java.Io.DataOutputStream arg0, byte arg1, long arg2, byte[] arg3, byte[] arg4, Org.Apache.Kafka.Common.Record.CompressionType arg5, Org.Apache.Kafka.Common.Record.TimestampType arg6)
        {
            return SExecute<long>(LocalBridgeClazz, "write", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#write-java.io.DataOutputStream-byte-long-java.nio.ByteBuffer-java.nio.ByteBuffer-org.apache.kafka.common.record.CompressionType-org.apache.kafka.common.record.TimestampType-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.DataOutputStream"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg4"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg5"><see cref="Org.Apache.Kafka.Common.Record.CompressionType"/></param>
        /// <param name="arg6"><see cref="Org.Apache.Kafka.Common.Record.TimestampType"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static long Write(Java.Io.DataOutputStream arg0, byte arg1, long arg2, Java.Nio.ByteBuffer arg3, Java.Nio.ByteBuffer arg4, Org.Apache.Kafka.Common.Record.CompressionType arg5, Org.Apache.Kafka.Common.Record.TimestampType arg6)
        {
            return SExecute<long>(LocalBridgeClazz, "write", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#create-byte-long-byte[]-byte[]-org.apache.kafka.common.record.CompressionType-org.apache.kafka.common.record.TimestampType-"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        /// <param name="arg3"><see cref="byte"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Common.Record.CompressionType"/></param>
        /// <param name="arg5"><see cref="Org.Apache.Kafka.Common.Record.TimestampType"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Record.LegacyRecord"/></returns>
        public static Org.Apache.Kafka.Common.Record.LegacyRecord Create(byte arg0, long arg1, byte[] arg2, byte[] arg3, Org.Apache.Kafka.Common.Record.CompressionType arg4, Org.Apache.Kafka.Common.Record.TimestampType arg5)
        {
            return SExecute<Org.Apache.Kafka.Common.Record.LegacyRecord>(LocalBridgeClazz, "create", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#create-byte-long-byte[]-byte[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        /// <param name="arg3"><see cref="byte"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Record.LegacyRecord"/></returns>
        public static Org.Apache.Kafka.Common.Record.LegacyRecord Create(byte arg0, long arg1, byte[] arg2, byte[] arg3)
        {
            return SExecute<Org.Apache.Kafka.Common.Record.LegacyRecord>(LocalBridgeClazz, "create", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#timestampType-byte-org.apache.kafka.common.record.TimestampType-byte-"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Record.TimestampType"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Record.TimestampType"/></returns>
        public static Org.Apache.Kafka.Common.Record.TimestampType TimestampType(byte arg0, Org.Apache.Kafka.Common.Record.TimestampType arg1, byte arg2)
        {
            return SExecute<Org.Apache.Kafka.Common.Record.TimestampType>(LocalBridgeClazz, "timestampType", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#write-java.io.DataOutputStream-byte-long-byte-long-byte[]-byte[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.DataOutputStream"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="byte"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        /// <param name="arg5"><see cref="byte"/></param>
        /// <param name="arg6"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public static void Write(Java.Io.DataOutputStream arg0, byte arg1, long arg2, byte arg3, long arg4, byte[] arg5, byte[] arg6)
        {
            SExecute(LocalBridgeClazz, "write", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#writeCompressedRecordHeader-java.nio.ByteBuffer-byte-int-long-org.apache.kafka.common.record.CompressionType-org.apache.kafka.common.record.TimestampType-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Common.Record.CompressionType"/></param>
        /// <param name="arg5"><see cref="Org.Apache.Kafka.Common.Record.TimestampType"/></param>
        public static void WriteCompressedRecordHeader(Java.Nio.ByteBuffer arg0, byte arg1, int arg2, long arg3, Org.Apache.Kafka.Common.Record.CompressionType arg4, Org.Apache.Kafka.Common.Record.TimestampType arg5)
        {
            SExecute(LocalBridgeClazz, "writeCompressedRecordHeader", arg0, arg1, arg2, arg3, arg4, arg5);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#hasKey--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HasKey()
        {
            return IExecute<bool>("hasKey");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#hasNullValue--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HasNullValue()
        {
            return IExecute<bool>("hasNullValue");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#isValid--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsValid()
        {
            return IExecute<bool>("isValid");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#attributes--"/>
        /// </summary>

        /// <returns><see cref="byte"/></returns>
        public byte Attributes()
        {
            return IExecute<byte>("attributes");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#magic--"/>
        /// </summary>

        /// <returns><see cref="byte"/></returns>
        public byte Magic()
        {
            return IExecute<byte>("magic");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#keySize--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int KeySize()
        {
            return IExecute<int>("keySize");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#sizeInBytes--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int SizeInBytes()
        {
            return IExecute<int>("sizeInBytes");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#valueSize--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int ValueSize()
        {
            return IExecute<int>("valueSize");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#wrapperRecordTimestamp--"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.Long"/></returns>
        public Java.Lang.Long WrapperRecordTimestamp()
        {
            return IExecute<Java.Lang.Long>("wrapperRecordTimestamp");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#buffer--"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer Buffer()
        {
            return IExecute<Java.Nio.ByteBuffer>("buffer");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#key--"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer Key()
        {
            return IExecute<Java.Nio.ByteBuffer>("key");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#value--"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer Value()
        {
            return IExecute<Java.Nio.ByteBuffer>("value");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#checksum--"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long Checksum()
        {
            return IExecute<long>("checksum");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#computeChecksum--"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long ComputeChecksum()
        {
            return IExecute<long>("computeChecksum");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#timestamp--"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long Timestamp()
        {
            return IExecute<long>("timestamp");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#compressionType--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Record.CompressionType"/></returns>
        public Org.Apache.Kafka.Common.Record.CompressionType CompressionType()
        {
            return IExecute<Org.Apache.Kafka.Common.Record.CompressionType>("compressionType");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#timestampType--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Record.TimestampType"/></returns>
        public Org.Apache.Kafka.Common.Record.TimestampType TimestampType()
        {
            return IExecute<Org.Apache.Kafka.Common.Record.TimestampType>("timestampType");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#wrapperRecordTimestampType--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Record.TimestampType"/></returns>
        public Org.Apache.Kafka.Common.Record.TimestampType WrapperRecordTimestampType()
        {
            return IExecute<Org.Apache.Kafka.Common.Record.TimestampType>("wrapperRecordTimestampType");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/record/LegacyRecord.html#ensureValid--"/>
        /// </summary>
        public void EnsureValid()
        {
            IExecute("ensureValid");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}