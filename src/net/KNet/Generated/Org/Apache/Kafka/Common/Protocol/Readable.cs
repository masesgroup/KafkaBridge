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
    #region IReadable
    /// <summary>
    /// .NET interface for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/Readable.html"/>
    /// </summary>
    public partial interface IReadable
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Readable
    public partial class Readable : Org.Apache.Kafka.Common.Protocol.IReadable
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/Readable.html#readByte()"/>
        /// </summary>

        /// <returns><see cref="byte"/></returns>
        public byte ReadByte()
        {
            return IExecute<byte>("readByte");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/Readable.html#readArray(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] ReadArray(int arg0)
        {
            return IExecuteArray<byte>("readArray", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/Readable.html#readDouble()"/>
        /// </summary>

        /// <returns><see cref="double"/></returns>
        public double ReadDouble()
        {
            return IExecute<double>("readDouble");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/Readable.html#readInt()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int ReadInt()
        {
            return IExecute<int>("readInt");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/Readable.html#readUnsignedVarint()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int ReadUnsignedVarint()
        {
            return IExecute<int>("readUnsignedVarint");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/Readable.html#readVarint()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int ReadVarint()
        {
            return IExecute<int>("readVarint");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/Readable.html#remaining()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Remaining()
        {
            return IExecute<int>("remaining");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/Readable.html#readByteBuffer(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer ReadByteBuffer(int arg0)
        {
            return IExecute<Java.Nio.ByteBuffer>("readByteBuffer", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/Readable.html#readLong()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long ReadLong()
        {
            return IExecute<long>("readLong");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/Readable.html#readVarlong()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long ReadVarlong()
        {
            return IExecute<long>("readVarlong");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/Readable.html#readShort()"/>
        /// </summary>

        /// <returns><see cref="short"/></returns>
        public short ReadShort()
        {
            return IExecute<short>("readShort");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/Readable.html#readUnsignedShort()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int ReadUnsignedShort()
        {
            return IExecute<int>("readUnsignedShort");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/Readable.html#readString(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string ReadString(int arg0)
        {
            return IExecute<string>("readString", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/Readable.html#readUnknownTaggedField(java.util.List,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Org.Apache.Kafka.Common.Protocol.Types.RawTaggedField> ReadUnknownTaggedField(Java.Util.List<Org.Apache.Kafka.Common.Protocol.Types.RawTaggedField> arg0, int arg1, int arg2)
        {
            return IExecute<Java.Util.List<Org.Apache.Kafka.Common.Protocol.Types.RawTaggedField>>("readUnknownTaggedField", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/Readable.html#readUnsignedInt()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long ReadUnsignedInt()
        {
            return IExecute<long>("readUnsignedInt");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/Readable.html#readRecords(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Record.MemoryRecords"/></returns>
        public Org.Apache.Kafka.Common.Record.MemoryRecords ReadRecords(int arg0)
        {
            return IExecute<Org.Apache.Kafka.Common.Record.MemoryRecords>("readRecords", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/Readable.html#readUuid()"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Uuid"/></returns>
        public Org.Apache.Kafka.Common.Uuid ReadUuid()
        {
            return IExecute<Org.Apache.Kafka.Common.Uuid>("readUuid");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}