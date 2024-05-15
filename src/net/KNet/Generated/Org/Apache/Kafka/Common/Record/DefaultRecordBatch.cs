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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*  using kafka-clients-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Record
{
    #region DefaultRecordBatch
    public partial class DefaultRecordBatch
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/DefaultRecordBatch.html#CRC_OFFSET"/>
        /// </summary>
        public static int CRC_OFFSET { get { if (!_CRC_OFFSETReady) { _CRC_OFFSETContent = SGetField<int>(LocalBridgeClazz, "CRC_OFFSET"); _CRC_OFFSETReady = true; } return _CRC_OFFSETContent; } }
        private static int _CRC_OFFSETContent = default;
        private static bool _CRC_OFFSETReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/DefaultRecordBatch.html#LAST_OFFSET_DELTA_OFFSET"/>
        /// </summary>
        public static int LAST_OFFSET_DELTA_OFFSET { get { if (!_LAST_OFFSET_DELTA_OFFSETReady) { _LAST_OFFSET_DELTA_OFFSETContent = SGetField<int>(LocalBridgeClazz, "LAST_OFFSET_DELTA_OFFSET"); _LAST_OFFSET_DELTA_OFFSETReady = true; } return _LAST_OFFSET_DELTA_OFFSETContent; } }
        private static int _LAST_OFFSET_DELTA_OFFSETContent = default;
        private static bool _LAST_OFFSET_DELTA_OFFSETReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/DefaultRecordBatch.html#RECORD_BATCH_OVERHEAD"/>
        /// </summary>
        public static int RECORD_BATCH_OVERHEAD { get { if (!_RECORD_BATCH_OVERHEADReady) { _RECORD_BATCH_OVERHEADContent = SGetField<int>(LocalBridgeClazz, "RECORD_BATCH_OVERHEAD"); _RECORD_BATCH_OVERHEADReady = true; } return _RECORD_BATCH_OVERHEADContent; } }
        private static int _RECORD_BATCH_OVERHEADContent = default;
        private static bool _RECORD_BATCH_OVERHEADReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/DefaultRecordBatch.html#RECORDS_COUNT_OFFSET"/>
        /// </summary>
        public static int RECORDS_COUNT_OFFSET { get { if (!_RECORDS_COUNT_OFFSETReady) { _RECORDS_COUNT_OFFSETContent = SGetField<int>(LocalBridgeClazz, "RECORDS_COUNT_OFFSET"); _RECORDS_COUNT_OFFSETReady = true; } return _RECORDS_COUNT_OFFSETContent; } }
        private static int _RECORDS_COUNT_OFFSETContent = default;
        private static bool _RECORDS_COUNT_OFFSETReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/DefaultRecordBatch.html#decrementSequence-int-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int DecrementSequence(int arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "decrementSequence", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/DefaultRecordBatch.html#incrementSequence-int-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int IncrementSequence(int arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "incrementSequence", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/DefaultRecordBatch.html#sizeInBytes-java.lang.Iterable-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <returns><see cref="int"/></returns>
        public static int SizeInBytes(Java.Lang.Iterable<Org.Apache.Kafka.Common.Record.SimpleRecord> arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "sizeInBytes", "(Ljava/lang/Iterable;)I", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/DefaultRecordBatch.html#sizeInBytes-long-java.lang.Iterable-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Iterable"/></param>
        /// <returns><see cref="int"/></returns>
        public static int SizeInBytes(long arg0, Java.Lang.Iterable<Org.Apache.Kafka.Common.Record.Record> arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "sizeInBytes", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/DefaultRecordBatch.html#writeEmptyHeader-java.nio.ByteBuffer-byte-long-short-int-long-long-int-org.apache.kafka.common.record.TimestampType-long-boolean-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="short"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="long"/></param>
        /// <param name="arg6"><see cref="long"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        /// <param name="arg8"><see cref="Org.Apache.Kafka.Common.Record.TimestampType"/></param>
        /// <param name="arg9"><see cref="long"/></param>
        /// <param name="arg10"><see cref="bool"/></param>
        /// <param name="arg11"><see cref="bool"/></param>
        public static void WriteEmptyHeader(Java.Nio.ByteBuffer arg0, byte arg1, long arg2, short arg3, int arg4, long arg5, long arg6, int arg7, Org.Apache.Kafka.Common.Record.TimestampType arg8, long arg9, bool arg10, bool arg11)
        {
            SExecute(LocalBridgeClazz, "writeEmptyHeader", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/DefaultRecordBatch.html#writeHeader-java.nio.ByteBuffer-long-int-int-byte-org.apache.kafka.common.record.CompressionType-org.apache.kafka.common.record.TimestampType-long-long-long-short-int-boolean-boolean-boolean-int-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="byte"/></param>
        /// <param name="arg5"><see cref="Org.Apache.Kafka.Common.Record.CompressionType"/></param>
        /// <param name="arg6"><see cref="Org.Apache.Kafka.Common.Record.TimestampType"/></param>
        /// <param name="arg7"><see cref="long"/></param>
        /// <param name="arg8"><see cref="long"/></param>
        /// <param name="arg9"><see cref="long"/></param>
        /// <param name="arg10"><see cref="short"/></param>
        /// <param name="arg11"><see cref="int"/></param>
        /// <param name="arg12"><see cref="bool"/></param>
        /// <param name="arg13"><see cref="bool"/></param>
        /// <param name="arg14"><see cref="bool"/></param>
        /// <param name="arg15"><see cref="int"/></param>
        /// <param name="arg16"><see cref="int"/></param>
        public static void WriteHeader(Java.Nio.ByteBuffer arg0, long arg1, int arg2, int arg3, byte arg4, Org.Apache.Kafka.Common.Record.CompressionType arg5, Org.Apache.Kafka.Common.Record.TimestampType arg6, long arg7, long arg8, long arg9, short arg10, int arg11, bool arg12, bool arg13, bool arg14, int arg15, int arg16)
        {
            SExecute(LocalBridgeClazz, "writeHeader", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/DefaultRecordBatch.html#recordInputStream-org.apache.kafka.common.utils.BufferSupplier-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Utils.BufferSupplier"/></param>
        /// <returns><see cref="Java.Io.InputStream"/></returns>
        public Java.Io.InputStream RecordInputStream(Org.Apache.Kafka.Common.Utils.BufferSupplier arg0)
        {
            return IExecuteWithSignature<Java.Io.InputStream>("recordInputStream", "(Lorg/apache/kafka/common/utils/BufferSupplier;)Ljava/io/InputStream;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/DefaultRecordBatch.html#baseTimestamp--"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long BaseTimestamp()
        {
            return IExecuteWithSignature<long>("baseTimestamp", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/DefaultRecordBatch.html#skipKeyValueIterator-org.apache.kafka.common.utils.BufferSupplier-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Utils.BufferSupplier"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Utils.CloseableIterator"/></returns>
        public Org.Apache.Kafka.Common.Utils.CloseableIterator<Org.Apache.Kafka.Common.Record.Record> SkipKeyValueIterator(Org.Apache.Kafka.Common.Utils.BufferSupplier arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Utils.CloseableIterator<Org.Apache.Kafka.Common.Record.Record>>("skipKeyValueIterator", "(Lorg/apache/kafka/common/utils/BufferSupplier;)Lorg/apache/kafka/common/utils/CloseableIterator;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/DefaultRecordBatch.html#setLastOffset-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetLastOffset(long arg0)
        {
            IExecuteWithSignature("setLastOffset", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/DefaultRecordBatch.html#setMaxTimestamp-org.apache.kafka.common.record.TimestampType-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Record.TimestampType"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        public void SetMaxTimestamp(Org.Apache.Kafka.Common.Record.TimestampType arg0, long arg1)
        {
            IExecute("setMaxTimestamp", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/DefaultRecordBatch.html#setPartitionLeaderEpoch-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetPartitionLeaderEpoch(int arg0)
        {
            IExecuteWithSignature("setPartitionLeaderEpoch", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/DefaultRecordBatch.html#writeTo-org.apache.kafka.common.utils.ByteBufferOutputStream-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Utils.ByteBufferOutputStream"/></param>
        public void WriteTo(Org.Apache.Kafka.Common.Utils.ByteBufferOutputStream arg0)
        {
            IExecuteWithSignature("writeTo", "(Lorg/apache/kafka/common/utils/ByteBufferOutputStream;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}