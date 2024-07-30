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
*  using kafka-clients-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Record
{
    #region AbstractLegacyRecordBatch
    public partial class AbstractLegacyRecordBatch
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/AbstractLegacyRecordBatch.html#outerRecord--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Record.LegacyRecord"/></returns>
        public Org.Apache.Kafka.Common.Record.LegacyRecord OuterRecord()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Record.LegacyRecord>("outerRecord", "()Lorg/apache/kafka/common/record/LegacyRecord;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/AbstractLegacyRecordBatch.html#hasKey--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasKey()
        {
            return IExecuteWithSignature<bool>("hasKey", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/AbstractLegacyRecordBatch.html#hasMagic-byte-"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasMagic(byte arg0)
        {
            return IExecuteWithSignature<bool>("hasMagic", "(B)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/AbstractLegacyRecordBatch.html#hasTimestampType-org.apache.kafka.common.record.TimestampType-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Record.TimestampType"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasTimestampType(Org.Apache.Kafka.Common.Record.TimestampType arg0)
        {
            return IExecuteWithSignature<bool>("hasTimestampType", "(Lorg/apache/kafka/common/record/TimestampType;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/AbstractLegacyRecordBatch.html#hasValue--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasValue()
        {
            return IExecuteWithSignature<bool>("hasValue", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/AbstractLegacyRecordBatch.html#keySize--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int KeySize()
        {
            return IExecuteWithSignature<int>("keySize", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/AbstractLegacyRecordBatch.html#sequence--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Sequence()
        {
            return IExecuteWithSignature<int>("sequence", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/AbstractLegacyRecordBatch.html#valueSize--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int ValueSize()
        {
            return IExecuteWithSignature<int>("valueSize", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/AbstractLegacyRecordBatch.html#key--"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer Key()
        {
            return IExecuteWithSignature<Java.Nio.ByteBuffer>("key", "()Ljava/nio/ByteBuffer;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/AbstractLegacyRecordBatch.html#value--"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer Value()
        {
            return IExecuteWithSignature<Java.Nio.ByteBuffer>("value", "()Ljava/nio/ByteBuffer;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/AbstractLegacyRecordBatch.html#timestamp--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long Timestamp()
        {
            return IExecuteWithSignature<long>("timestamp", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/record/AbstractLegacyRecordBatch.html#headers--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Header.Header"/></returns>
        public Org.Apache.Kafka.Common.Header.Header[] Headers()
        {
            return IExecuteWithSignatureArray<Org.Apache.Kafka.Common.Header.Header>("headers", "()[Lorg/apache/kafka/common/header/Header;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}