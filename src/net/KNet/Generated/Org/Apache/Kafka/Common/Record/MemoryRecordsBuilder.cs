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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using kafka-clients-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Record
{
    #region MemoryRecordsBuilder declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html"/>
    /// </summary>
    public partial class MemoryRecordsBuilder : Java.Lang.AutoCloseable
    {
        const string _bridgeClassName = "org.apache.kafka.common.record.MemoryRecordsBuilder";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public MemoryRecordsBuilder() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public MemoryRecordsBuilder(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class
        #region RecordsInfo declaration
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.RecordsInfo.html"/>
        /// </summary>
        public partial class RecordsInfo : MASES.JCOBridge.C2JBridge.JVMBridgeBase<RecordsInfo>
        {
            const string _bridgeClassName = "org.apache.kafka.common.record.MemoryRecordsBuilder$RecordsInfo";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public RecordsInfo() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public RecordsInfo(params object[] args) : base(args) { }

            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
            /// </summary>
            public override bool IsBridgeCloseable => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
            /// </summary>
            public override bool IsBridgeInterface => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region MemoryRecordsBuilder implementation
    public partial class MemoryRecordsBuilder
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#hasRoomFor-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasRoomFor(int arg0)
        {
            return IExecuteWithSignature<bool>("hasRoomFor", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#hasRoomFor-long-byte[]-byte[]-org.apache.kafka.common.header.Header[]-"/>
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#hasRoomFor-long-java.nio.ByteBuffer-java.nio.ByteBuffer-org.apache.kafka.common.header.Header[]-"/>
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#isClosed--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsClosed()
        {
            return IExecuteWithSignature<bool>("isClosed", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#isControlBatch--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsControlBatch()
        {
            return IExecuteWithSignature<bool>("isControlBatch", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#isFull--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsFull()
        {
            return IExecuteWithSignature<bool>("isFull", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#isTransactional--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsTransactional()
        {
            return IExecuteWithSignature<bool>("isTransactional", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#magic--"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte Magic()
        {
            return IExecuteWithSignature<byte>("magic", "()B");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#compressionRatio--"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        public double CompressionRatio()
        {
            return IExecuteWithSignature<double>("compressionRatio", "()D");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#hasDeleteHorizonMs--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasDeleteHorizonMs()
        {
            return IExecuteWithSignature<bool>("hasDeleteHorizonMs", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#baseSequence--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int BaseSequence()
        {
            return IExecuteWithSignature<int>("baseSequence", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#estimatedSizeInBytes--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int EstimatedSizeInBytes()
        {
            return IExecuteWithSignature<int>("estimatedSizeInBytes", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#initialCapacity--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int InitialCapacity()
        {
            return IExecuteWithSignature<int>("initialCapacity", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#maxAllowedBytes--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int MaxAllowedBytes()
        {
            return IExecuteWithSignature<int>("maxAllowedBytes", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#numRecords--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int NumRecords()
        {
            return IExecuteWithSignature<int>("numRecords", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#uncompressedBytesWritten--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int UncompressedBytesWritten()
        {
            return IExecuteWithSignature<int>("uncompressedBytesWritten", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#buffer--"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer Buffer()
        {
            return IExecuteWithSignature<Java.Nio.ByteBuffer>("buffer", "()Ljava/nio/ByteBuffer;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#producerId--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long ProducerId()
        {
            return IExecuteWithSignature<long>("producerId", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#info--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Record.MemoryRecordsBuilder.RecordsInfo"/></returns>
        public Org.Apache.Kafka.Common.Record.MemoryRecordsBuilder.RecordsInfo Info()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Record.MemoryRecordsBuilder.RecordsInfo>("info", "()Lorg/apache/kafka/common/record/MemoryRecordsBuilder$RecordsInfo;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#producerEpoch--"/>
        /// </summary>
        /// <returns><see cref="short"/></returns>
        public short ProducerEpoch()
        {
            return IExecuteWithSignature<short>("producerEpoch", "()S");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#abort--"/>
        /// </summary>
        public void Abort()
        {
            IExecuteWithSignature("abort", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#append-long-byte[]-byte[]-org.apache.kafka.common.header.Header[]-"/>
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#append-long-byte[]-byte[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        public void Append(long arg0, byte[] arg1, byte[] arg2)
        {
            IExecute("append", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#append-long-java.nio.ByteBuffer-java.nio.ByteBuffer-org.apache.kafka.common.header.Header[]-"/>
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#append-long-java.nio.ByteBuffer-java.nio.ByteBuffer-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg2"><see cref="Java.Nio.ByteBuffer"/></param>
        public void Append(long arg0, Java.Nio.ByteBuffer arg1, Java.Nio.ByteBuffer arg2)
        {
            IExecute("append", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#append-org.apache.kafka.common.record.LegacyRecord-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Record.LegacyRecord"/></param>
        public void Append(Org.Apache.Kafka.Common.Record.LegacyRecord arg0)
        {
            IExecuteWithSignature("append", "(Lorg/apache/kafka/common/record/LegacyRecord;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#append-org.apache.kafka.common.record.Record-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Record.Record"/></param>
        public void Append(Org.Apache.Kafka.Common.Record.Record arg0)
        {
            IExecuteWithSignature("append", "(Lorg/apache/kafka/common/record/Record;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#append-org.apache.kafka.common.record.SimpleRecord-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Record.SimpleRecord"/></param>
        public void Append(Org.Apache.Kafka.Common.Record.SimpleRecord arg0)
        {
            IExecuteWithSignature("append", "(Lorg/apache/kafka/common/record/SimpleRecord;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#appendControlRecord-long-org.apache.kafka.common.record.ControlRecordType-java.nio.ByteBuffer-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Record.ControlRecordType"/></param>
        /// <param name="arg2"><see cref="Java.Nio.ByteBuffer"/></param>
        public void AppendControlRecord(long arg0, Org.Apache.Kafka.Common.Record.ControlRecordType arg1, Java.Nio.ByteBuffer arg2)
        {
            IExecute("appendControlRecord", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#appendControlRecordWithOffset-long-org.apache.kafka.common.record.SimpleRecord-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Record.SimpleRecord"/></param>
        public void AppendControlRecordWithOffset(long arg0, Org.Apache.Kafka.Common.Record.SimpleRecord arg1)
        {
            IExecute("appendControlRecordWithOffset", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#appendUncheckedWithOffset-long-org.apache.kafka.common.record.LegacyRecord-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Record.LegacyRecord"/></param>
        public void AppendUncheckedWithOffset(long arg0, Org.Apache.Kafka.Common.Record.LegacyRecord arg1)
        {
            IExecute("appendUncheckedWithOffset", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#appendUncheckedWithOffset-long-org.apache.kafka.common.record.SimpleRecord-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Record.SimpleRecord"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void AppendUncheckedWithOffset(long arg0, Org.Apache.Kafka.Common.Record.SimpleRecord arg1)
        {
            IExecute("appendUncheckedWithOffset", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#appendWithOffset-long-long-byte[]-byte[]-org.apache.kafka.common.header.Header[]-"/>
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#appendWithOffset-long-long-byte[]-byte[]-"/>
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#appendWithOffset-long-long-java.nio.ByteBuffer-java.nio.ByteBuffer-org.apache.kafka.common.header.Header[]-"/>
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#appendWithOffset-long-long-java.nio.ByteBuffer-java.nio.ByteBuffer-"/>
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#appendWithOffset-long-org.apache.kafka.common.record.LegacyRecord-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Record.LegacyRecord"/></param>
        public void AppendWithOffset(long arg0, Org.Apache.Kafka.Common.Record.LegacyRecord arg1)
        {
            IExecute("appendWithOffset", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#appendWithOffset-long-org.apache.kafka.common.record.Record-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Record.Record"/></param>
        public void AppendWithOffset(long arg0, Org.Apache.Kafka.Common.Record.Record arg1)
        {
            IExecute("appendWithOffset", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#appendWithOffset-long-org.apache.kafka.common.record.SimpleRecord-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Record.SimpleRecord"/></param>
        public void AppendWithOffset(long arg0, Org.Apache.Kafka.Common.Record.SimpleRecord arg1)
        {
            IExecute("appendWithOffset", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#closeForRecordAppends--"/>
        /// </summary>
        public void CloseForRecordAppends()
        {
            IExecuteWithSignature("closeForRecordAppends", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#overrideLastOffset-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void OverrideLastOffset(long arg0)
        {
            IExecuteWithSignature("overrideLastOffset", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#reopenAndRewriteProducerState-long-short-int-boolean-"/>
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#setEstimatedCompressionRatio-float-"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void SetEstimatedCompressionRatio(float arg0)
        {
            IExecuteWithSignature("setEstimatedCompressionRatio", "(F)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.html#setProducerState-long-short-int-boolean-"/>
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
        #region RecordsInfo implementation
        public partial class RecordsInfo
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.RecordsInfo.html#org.apache.kafka.common.record.MemoryRecordsBuilder$RecordsInfo(long,long)"/>
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.RecordsInfo.html#maxTimestamp"/>
            /// </summary>
            public long maxTimestamp { get { if (!_maxTimestampReady) { _maxTimestampContent = IGetField<long>("maxTimestamp"); _maxTimestampReady = true; } return _maxTimestampContent; } }
            private long _maxTimestampContent = default;
            private bool _maxTimestampReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/MemoryRecordsBuilder.RecordsInfo.html#shallowOffsetOfMaxTimestamp"/>
            /// </summary>
            public long shallowOffsetOfMaxTimestamp { get { if (!_shallowOffsetOfMaxTimestampReady) { _shallowOffsetOfMaxTimestampContent = IGetField<long>("shallowOffsetOfMaxTimestamp"); _shallowOffsetOfMaxTimestampReady = true; } return _shallowOffsetOfMaxTimestampContent; } }
            private long _shallowOffsetOfMaxTimestampContent = default;
            private bool _shallowOffsetOfMaxTimestampReady = false; // this is used because in case of generics 

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