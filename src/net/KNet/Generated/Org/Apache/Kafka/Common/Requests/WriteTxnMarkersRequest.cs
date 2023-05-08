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

namespace Org.Apache.Kafka.Common.Requests
{
    #region WriteTxnMarkersRequest
    public partial class WriteTxnMarkersRequest
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/WriteTxnMarkersRequest.html#parse(java.nio.ByteBuffer,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Requests.WriteTxnMarkersRequest"/></returns>
        public static Org.Apache.Kafka.Common.Requests.WriteTxnMarkersRequest Parse(Java.Nio.ByteBuffer arg0, short arg1)
        {
            return SExecute<Org.Apache.Kafka.Common.Requests.WriteTxnMarkersRequest>(LocalBridgeClazz, "parse", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/WriteTxnMarkersRequest.html#markers()"/> 
        /// </summary>
        public Java.Util.List<Org.Apache.Kafka.Common.Requests.WriteTxnMarkersRequest.TxnMarkerEntry> Markers
        {
            get { return IExecute<Java.Util.List<Org.Apache.Kafka.Common.Requests.WriteTxnMarkersRequest.TxnMarkerEntry>>("markers"); }
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/WriteTxnMarkersRequest.Builder.html#%3Cinit%3E(org.apache.kafka.common.message.WriteTxnMarkersRequestData)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Message.WriteTxnMarkersRequestData"/></param>
            public Builder(Org.Apache.Kafka.Common.Message.WriteTxnMarkersRequestData arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/WriteTxnMarkersRequest.Builder.html#%3Cinit%3E(short,java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="short"/></param>
            /// <param name="arg1"><see cref="Java.Util.List"/></param>
            public Builder(short arg0, Java.Util.List arg1)
                : base(arg0, arg1)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/WriteTxnMarkersRequest.Builder.html#data"/>
            /// </summary>
            public Org.Apache.Kafka.Common.Message.WriteTxnMarkersRequestData data { get { return IGetField<Org.Apache.Kafka.Common.Message.WriteTxnMarkersRequestData>("data"); } }

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

        #region TxnMarkerEntry
        public partial class TxnMarkerEntry
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/WriteTxnMarkersRequest.TxnMarkerEntry.html#%3Cinit%3E(long,short,int,org.apache.kafka.common.requests.TransactionResult,java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <param name="arg1"><see cref="short"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="Org.Apache.Kafka.Common.Requests.TransactionResult"/></param>
            /// <param name="arg4"><see cref="Java.Util.List"/></param>
            public TxnMarkerEntry(long arg0, short arg1, int arg2, Org.Apache.Kafka.Common.Requests.TransactionResult arg3, Java.Util.List arg4)
                : base(arg0, arg1, arg2, arg3, arg4)
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
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/WriteTxnMarkersRequest.TxnMarkerEntry.html#coordinatorEpoch()"/> 
            /// </summary>
            public int CoordinatorEpoch
            {
                get { return IExecute<int>("coordinatorEpoch"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/WriteTxnMarkersRequest.TxnMarkerEntry.html#partitions()"/> 
            /// </summary>
            public Java.Util.List<Org.Apache.Kafka.Common.TopicPartition> Partitions
            {
                get { return IExecute<Java.Util.List<Org.Apache.Kafka.Common.TopicPartition>>("partitions"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/WriteTxnMarkersRequest.TxnMarkerEntry.html#producerEpoch()"/> 
            /// </summary>
            public short ProducerEpoch
            {
                get { return IExecute<short>("producerEpoch"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/WriteTxnMarkersRequest.TxnMarkerEntry.html#producerId()"/> 
            /// </summary>
            public long ProducerId
            {
                get { return IExecute<long>("producerId"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/WriteTxnMarkersRequest.TxnMarkerEntry.html#transactionResult()"/> 
            /// </summary>
            public Org.Apache.Kafka.Common.Requests.TransactionResult TransactionResult
            {
                get { return IExecute<Org.Apache.Kafka.Common.Requests.TransactionResult>("transactionResult"); }
            }

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