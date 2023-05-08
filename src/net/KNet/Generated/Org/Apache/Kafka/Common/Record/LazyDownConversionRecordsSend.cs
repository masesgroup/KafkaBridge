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

namespace Org.Apache.Kafka.Common.Record
{
    #region LazyDownConversionRecordsSend
    public partial class LazyDownConversionRecordsSend
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/record/LazyDownConversionRecordsSend.html#%3Cinit%3E(org.apache.kafka.common.record.LazyDownConversionRecords)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Record.LazyDownConversionRecords"/></param>
        public LazyDownConversionRecordsSend(Org.Apache.Kafka.Common.Record.LazyDownConversionRecords arg0)
            : base(arg0)
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
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/record/LazyDownConversionRecordsSend.html#recordConversionStats()"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.Record.RecordConversionStats RecordConversionStats
        {
            get { return IExecute<Org.Apache.Kafka.Common.Record.RecordConversionStats>("recordConversionStats"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/record/LazyDownConversionRecordsSend.html#topicPartition()"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.TopicPartition TopicPartition
        {
            get { return IExecute<Org.Apache.Kafka.Common.TopicPartition>("topicPartition"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/record/LazyDownConversionRecordsSend.html#writeTo(org.apache.kafka.common.network.TransferableChannel,long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Network.TransferableChannel"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long WriteTo(Org.Apache.Kafka.Common.Network.TransferableChannel arg0, long arg1, int arg2)
        {
            return IExecute<long>("writeTo", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}