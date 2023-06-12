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
*  using kafka-clients-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Protocol
{
    #region ByteBufferAccessor
    public partial class ByteBufferAccessor : Org.Apache.Kafka.Common.Protocol.IReadable, Org.Apache.Kafka.Common.Protocol.IWritable
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/ByteBufferAccessor.html#%3Cinit%3E(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        public ByteBufferAccessor(Java.Nio.ByteBuffer arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Common.Protocol.ByteBufferAccessor"/> to <see cref="Org.Apache.Kafka.Common.Protocol.Readable"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Protocol.Readable(Org.Apache.Kafka.Common.Protocol.ByteBufferAccessor t) => t.Cast<Org.Apache.Kafka.Common.Protocol.Readable>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Common.Protocol.ByteBufferAccessor"/> to <see cref="Org.Apache.Kafka.Common.Protocol.Writable"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Protocol.Writable(Org.Apache.Kafka.Common.Protocol.ByteBufferAccessor t) => t.Cast<Org.Apache.Kafka.Common.Protocol.Writable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/ByteBufferAccessor.html#readByte()"/>
        /// </summary>

        /// <returns><see cref="byte"/></returns>
        public byte ReadByte()
        {
            return IExecute<byte>("readByte");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/ByteBufferAccessor.html#readArray(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] ReadArray(int arg0)
        {
            return IExecuteArray<byte>("readArray", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/ByteBufferAccessor.html#readDouble()"/>
        /// </summary>

        /// <returns><see cref="double"/></returns>
        public double ReadDouble()
        {
            return IExecute<double>("readDouble");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/ByteBufferAccessor.html#readInt()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int ReadInt()
        {
            return IExecute<int>("readInt");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/ByteBufferAccessor.html#readUnsignedVarint()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int ReadUnsignedVarint()
        {
            return IExecute<int>("readUnsignedVarint");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/ByteBufferAccessor.html#readVarint()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int ReadVarint()
        {
            return IExecute<int>("readVarint");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/ByteBufferAccessor.html#remaining()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Remaining()
        {
            return IExecute<int>("remaining");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/ByteBufferAccessor.html#buffer()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer Buffer()
        {
            return IExecute<Java.Nio.ByteBuffer>("buffer");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/ByteBufferAccessor.html#readByteBuffer(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer ReadByteBuffer(int arg0)
        {
            return IExecute<Java.Nio.ByteBuffer>("readByteBuffer", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/ByteBufferAccessor.html#readLong()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long ReadLong()
        {
            return IExecute<long>("readLong");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/ByteBufferAccessor.html#readVarlong()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long ReadVarlong()
        {
            return IExecute<long>("readVarlong");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/ByteBufferAccessor.html#readShort()"/>
        /// </summary>

        /// <returns><see cref="short"/></returns>
        public short ReadShort()
        {
            return IExecute<short>("readShort");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/ByteBufferAccessor.html#flip()"/>
        /// </summary>
        public void Flip()
        {
            IExecute("flip");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/ByteBufferAccessor.html#writeByte(byte)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        public void WriteByte(byte arg0)
        {
            IExecute("writeByte", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/ByteBufferAccessor.html#writeByteArray(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        public void WriteByteArray(byte[] arg0)
        {
            IExecute("writeByteArray", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/ByteBufferAccessor.html#writeByteBuffer(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        public void WriteByteBuffer(Java.Nio.ByteBuffer arg0)
        {
            IExecute("writeByteBuffer", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/ByteBufferAccessor.html#writeDouble(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        public void WriteDouble(double arg0)
        {
            IExecute("writeDouble", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/ByteBufferAccessor.html#writeInt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void WriteInt(int arg0)
        {
            IExecute("writeInt", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/ByteBufferAccessor.html#writeLong(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void WriteLong(long arg0)
        {
            IExecute("writeLong", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/ByteBufferAccessor.html#writeShort(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        public void WriteShort(short arg0)
        {
            IExecute("writeShort", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/ByteBufferAccessor.html#writeUnsignedVarint(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void WriteUnsignedVarint(int arg0)
        {
            IExecute("writeUnsignedVarint", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/ByteBufferAccessor.html#writeVarint(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void WriteVarint(int arg0)
        {
            IExecute("writeVarint", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/ByteBufferAccessor.html#writeVarlong(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void WriteVarlong(long arg0)
        {
            IExecute("writeVarlong", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}