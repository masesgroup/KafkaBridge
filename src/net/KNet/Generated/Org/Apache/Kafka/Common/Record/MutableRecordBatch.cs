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
*  using kafka-clients-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Record
{
    #region IMutableRecordBatch
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IMutableRecordBatch : Org.Apache.Kafka.Common.Record.IRecordBatch
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region MutableRecordBatch
    public partial class MutableRecordBatch : Org.Apache.Kafka.Common.Record.IMutableRecordBatch
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/record/MutableRecordBatch.html#skipKeyValueIterator-org.apache.kafka.common.utils.BufferSupplier-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Utils.BufferSupplier"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Utils.CloseableIterator"/></returns>
        public Org.Apache.Kafka.Common.Utils.CloseableIterator<Org.Apache.Kafka.Common.Record.Record> SkipKeyValueIterator(Org.Apache.Kafka.Common.Utils.BufferSupplier arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Utils.CloseableIterator<Org.Apache.Kafka.Common.Record.Record>>("skipKeyValueIterator", "(Lorg/apache/kafka/common/utils/BufferSupplier;)Lorg/apache/kafka/common/utils/CloseableIterator;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/record/MutableRecordBatch.html#setLastOffset-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetLastOffset(long arg0)
        {
            IExecuteWithSignature("setLastOffset", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/record/MutableRecordBatch.html#setMaxTimestamp-org.apache.kafka.common.record.TimestampType-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Record.TimestampType"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        public void SetMaxTimestamp(Org.Apache.Kafka.Common.Record.TimestampType arg0, long arg1)
        {
            IExecute("setMaxTimestamp", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/record/MutableRecordBatch.html#setPartitionLeaderEpoch-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetPartitionLeaderEpoch(int arg0)
        {
            IExecuteWithSignature("setPartitionLeaderEpoch", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/record/MutableRecordBatch.html#writeTo-org.apache.kafka.common.utils.ByteBufferOutputStream-"/>
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