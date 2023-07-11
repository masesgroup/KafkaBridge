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
*  using kafka-clients-3.5.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Record
{
    #region MemoryRecordsBuilder
    public partial class MemoryRecordsBuilder
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#org.apache.kafka.common.record.MemoryRecordsBuilder(java.nio.ByteBuffer,byte,org.apache.kafka.common.record.CompressionType,org.apache.kafka.common.record.TimestampType,long,long,long,short,int,boolean,boolean,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Record.CompressionType"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Common.Record.TimestampType"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        /// <param name="arg5"><see cref="long"/></param>
        /// <param name="arg6"><see cref="long"/></param>
        /// <param name="arg7"><see cref="short"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        /// <param name="arg9"><see cref="bool"/></param>
        /// <param name="arg10"><see cref="bool"/></param>
        /// <param name="arg11"><see cref="int"/></param>
        /// <param name="arg12"><see cref="int"/></param>
        public MemoryRecordsBuilder(Java.Nio.ByteBuffer arg0, byte arg1, Org.Apache.Kafka.Common.Record.CompressionType arg2, Org.Apache.Kafka.Common.Record.TimestampType arg3, long arg4, long arg5, long arg6, short arg7, int arg8, bool arg9, bool arg10, int arg11, int arg12)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#org.apache.kafka.common.record.MemoryRecordsBuilder(org.apache.kafka.common.utils.ByteBufferOutputStream,byte,org.apache.kafka.common.record.CompressionType,org.apache.kafka.common.record.TimestampType,long,long,long,short,int,boolean,boolean,int,int,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Utils.ByteBufferOutputStream"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Record.CompressionType"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Common.Record.TimestampType"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        /// <param name="arg5"><see cref="long"/></param>
        /// <param name="arg6"><see cref="long"/></param>
        /// <param name="arg7"><see cref="short"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        /// <param name="arg9"><see cref="bool"/></param>
        /// <param name="arg10"><see cref="bool"/></param>
        /// <param name="arg11"><see cref="int"/></param>
        /// <param name="arg12"><see cref="int"/></param>
        /// <param name="arg13"><see cref="long"/></param>
        public MemoryRecordsBuilder(Org.Apache.Kafka.Common.Utils.ByteBufferOutputStream arg0, byte arg1, Org.Apache.Kafka.Common.Record.CompressionType arg2, Org.Apache.Kafka.Common.Record.TimestampType arg3, long arg4, long arg5, long arg6, short arg7, int arg8, bool arg9, bool arg10, int arg11, int arg12, long arg13)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#org.apache.kafka.common.record.MemoryRecordsBuilder(org.apache.kafka.common.utils.ByteBufferOutputStream,byte,org.apache.kafka.common.record.CompressionType,org.apache.kafka.common.record.TimestampType,long,long,long,short,int,boolean,boolean,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Utils.ByteBufferOutputStream"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Record.CompressionType"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Common.Record.TimestampType"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        /// <param name="arg5"><see cref="long"/></param>
        /// <param name="arg6"><see cref="long"/></param>
        /// <param name="arg7"><see cref="short"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        /// <param name="arg9"><see cref="bool"/></param>
        /// <param name="arg10"><see cref="bool"/></param>
        /// <param name="arg11"><see cref="int"/></param>
        /// <param name="arg12"><see cref="int"/></param>
        public MemoryRecordsBuilder(Org.Apache.Kafka.Common.Utils.ByteBufferOutputStream arg0, byte arg1, Org.Apache.Kafka.Common.Record.CompressionType arg2, Org.Apache.Kafka.Common.Record.TimestampType arg3, long arg4, long arg5, long arg6, short arg7, int arg8, bool arg9, bool arg10, int arg11, int arg12)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#hasDeleteHorizonMs--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HasDeleteHorizonMs()
        {
            return IExecute<bool>("hasDeleteHorizonMs");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#hasRoomFor-long-byte[]-byte[]-org.apache.kafka.common.header.Header[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Common.Header.Header"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasRoomFor(long arg0, byte[] arg1, byte[] arg2, Org.Apache.Kafka.Common.Header.Header[] arg3)
        {
            return IExecute<bool>("hasRoomFor", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#hasRoomFor-long-java.nio.ByteBuffer-java.nio.ByteBuffer-org.apache.kafka.common.header.Header[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg2"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Common.Header.Header"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasRoomFor(long arg0, Java.Nio.ByteBuffer arg1, Java.Nio.ByteBuffer arg2, Org.Apache.Kafka.Common.Header.Header[] arg3)
        {
            return IExecute<bool>("hasRoomFor", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#isClosed--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsClosed()
        {
            return IExecute<bool>("isClosed");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#isControlBatch--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsControlBatch()
        {
            return IExecute<bool>("isControlBatch");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#isFull--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsFull()
        {
            return IExecute<bool>("isFull");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#isTransactional--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsTransactional()
        {
            return IExecute<bool>("isTransactional");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#magic--"/>
        /// </summary>

        /// <returns><see cref="byte"/></returns>
        public byte Magic()
        {
            return IExecute<byte>("magic");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#compressionRatio--"/>
        /// </summary>

        /// <returns><see cref="double"/></returns>
        public double CompressionRatio()
        {
            return IExecute<double>("compressionRatio");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#baseSequence--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int BaseSequence()
        {
            return IExecute<int>("baseSequence");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#estimatedSizeInBytes--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int EstimatedSizeInBytes()
        {
            return IExecute<int>("estimatedSizeInBytes");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#initialCapacity--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int InitialCapacity()
        {
            return IExecute<int>("initialCapacity");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#numRecords--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int NumRecords()
        {
            return IExecute<int>("numRecords");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#uncompressedBytesWritten--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int UncompressedBytesWritten()
        {
            return IExecute<int>("uncompressedBytesWritten");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#buffer--"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer Buffer()
        {
            return IExecute<Java.Nio.ByteBuffer>("buffer");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#producerId--"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long ProducerId()
        {
            return IExecute<long>("producerId");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#compressionType--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Record.CompressionType"/></returns>
        public Org.Apache.Kafka.Common.Record.CompressionType CompressionType()
        {
            return IExecute<Org.Apache.Kafka.Common.Record.CompressionType>("compressionType");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#info--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Record.MemoryRecordsBuilder.RecordsInfo"/></returns>
        public Org.Apache.Kafka.Common.Record.MemoryRecordsBuilder.RecordsInfo Info()
        {
            return IExecute<Org.Apache.Kafka.Common.Record.MemoryRecordsBuilder.RecordsInfo>("info");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#producerEpoch--"/>
        /// </summary>

        /// <returns><see cref="short"/></returns>
        public short ProducerEpoch()
        {
            return IExecute<short>("producerEpoch");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#abort--"/>
        /// </summary>
        public void Abort()
        {
            IExecute("abort");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#append-long-byte[]-byte[]-org.apache.kafka.common.header.Header[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Common.Header.Header"/></param>
        public void Append(long arg0, byte[] arg1, byte[] arg2, Org.Apache.Kafka.Common.Header.Header[] arg3)
        {
            IExecute("append", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#append-long-byte[]-byte[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        public void Append(long arg0, byte[] arg1, byte[] arg2)
        {
            IExecute("append", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#append-long-java.nio.ByteBuffer-java.nio.ByteBuffer-org.apache.kafka.common.header.Header[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg2"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Common.Header.Header"/></param>
        public void Append(long arg0, Java.Nio.ByteBuffer arg1, Java.Nio.ByteBuffer arg2, Org.Apache.Kafka.Common.Header.Header[] arg3)
        {
            IExecute("append", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#append-long-java.nio.ByteBuffer-java.nio.ByteBuffer-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg2"><see cref="Java.Nio.ByteBuffer"/></param>
        public void Append(long arg0, Java.Nio.ByteBuffer arg1, Java.Nio.ByteBuffer arg2)
        {
            IExecute("append", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#append-org.apache.kafka.common.record.LegacyRecord-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Record.LegacyRecord"/></param>
        public void Append(Org.Apache.Kafka.Common.Record.LegacyRecord arg0)
        {
            IExecute("append", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#append-org.apache.kafka.common.record.Record-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Record.Record"/></param>
        public void Append(Org.Apache.Kafka.Common.Record.Record arg0)
        {
            IExecute("append", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#append-org.apache.kafka.common.record.SimpleRecord-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Record.SimpleRecord"/></param>
        public void Append(Org.Apache.Kafka.Common.Record.SimpleRecord arg0)
        {
            IExecute("append", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#appendControlRecordWithOffset-long-org.apache.kafka.common.record.SimpleRecord-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Record.SimpleRecord"/></param>
        public void AppendControlRecordWithOffset(long arg0, Org.Apache.Kafka.Common.Record.SimpleRecord arg1)
        {
            IExecute("appendControlRecordWithOffset", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#appendUncheckedWithOffset-long-org.apache.kafka.common.record.LegacyRecord-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Record.LegacyRecord"/></param>
        public void AppendUncheckedWithOffset(long arg0, Org.Apache.Kafka.Common.Record.LegacyRecord arg1)
        {
            IExecute("appendUncheckedWithOffset", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#appendUncheckedWithOffset-long-org.apache.kafka.common.record.SimpleRecord-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Record.SimpleRecord"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void AppendUncheckedWithOffset(long arg0, Org.Apache.Kafka.Common.Record.SimpleRecord arg1)
        {
            IExecute("appendUncheckedWithOffset", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#appendWithOffset-long-long-byte[]-byte[]-org.apache.kafka.common.header.Header[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        /// <param name="arg3"><see cref="byte"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Common.Header.Header"/></param>
        public void AppendWithOffset(long arg0, long arg1, byte[] arg2, byte[] arg3, Org.Apache.Kafka.Common.Header.Header[] arg4)
        {
            IExecute("appendWithOffset", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#appendWithOffset-long-long-byte[]-byte[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        /// <param name="arg3"><see cref="byte"/></param>
        public void AppendWithOffset(long arg0, long arg1, byte[] arg2, byte[] arg3)
        {
            IExecute("appendWithOffset", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#appendWithOffset-long-long-java.nio.ByteBuffer-java.nio.ByteBuffer-org.apache.kafka.common.header.Header[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg3"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Common.Header.Header"/></param>
        public void AppendWithOffset(long arg0, long arg1, Java.Nio.ByteBuffer arg2, Java.Nio.ByteBuffer arg3, Org.Apache.Kafka.Common.Header.Header[] arg4)
        {
            IExecute("appendWithOffset", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#appendWithOffset-long-long-java.nio.ByteBuffer-java.nio.ByteBuffer-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg3"><see cref="Java.Nio.ByteBuffer"/></param>
        public void AppendWithOffset(long arg0, long arg1, Java.Nio.ByteBuffer arg2, Java.Nio.ByteBuffer arg3)
        {
            IExecute("appendWithOffset", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#appendWithOffset-long-org.apache.kafka.common.record.LegacyRecord-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Record.LegacyRecord"/></param>
        public void AppendWithOffset(long arg0, Org.Apache.Kafka.Common.Record.LegacyRecord arg1)
        {
            IExecute("appendWithOffset", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#appendWithOffset-long-org.apache.kafka.common.record.Record-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Record.Record"/></param>
        public void AppendWithOffset(long arg0, Org.Apache.Kafka.Common.Record.Record arg1)
        {
            IExecute("appendWithOffset", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#appendWithOffset-long-org.apache.kafka.common.record.SimpleRecord-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Record.SimpleRecord"/></param>
        public void AppendWithOffset(long arg0, Org.Apache.Kafka.Common.Record.SimpleRecord arg1)
        {
            IExecute("appendWithOffset", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#closeForRecordAppends--"/>
        /// </summary>
        public void CloseForRecordAppends()
        {
            IExecute("closeForRecordAppends");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#overrideLastOffset-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void OverrideLastOffset(long arg0)
        {
            IExecute("overrideLastOffset", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#reopenAndRewriteProducerState-long-short-int-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        public void ReopenAndRewriteProducerState(long arg0, short arg1, int arg2, bool arg3)
        {
            IExecute("reopenAndRewriteProducerState", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#setEstimatedCompressionRatio-float-"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void SetEstimatedCompressionRatio(float arg0)
        {
            IExecute("setEstimatedCompressionRatio", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#setProducerState-long-short-int-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        public void SetProducerState(long arg0, short arg1, int arg2, bool arg3)
        {
            IExecute("setProducerState", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Nested classes
        #region RecordsInfo
        public partial class RecordsInfo
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.RecordsInfo.html#org.apache.kafka.common.record.MemoryRecordsBuilder$RecordsInfo(long,long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <param name="arg1"><see cref="long"/></param>
            public RecordsInfo(long arg0, long arg1)
                : base(arg0, arg1)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.RecordsInfo.html#maxTimestamp"/>
            /// </summary>
            public long maxTimestamp { get { return IGetField<long>("maxTimestamp"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/record/MemoryRecordsBuilder.RecordsInfo.html#shallowOffsetOfMaxTimestamp"/>
            /// </summary>
            public long shallowOffsetOfMaxTimestamp { get { return IGetField<long>("shallowOffsetOfMaxTimestamp"); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

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