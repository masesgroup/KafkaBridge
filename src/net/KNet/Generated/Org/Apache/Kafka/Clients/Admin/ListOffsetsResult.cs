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
*  This file is generated by MASES.JNetReflector (ver. 2.0.0.0)
*  using kafka-clients-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Admin
{
    #region ListOffsetsResult
    public partial class ListOffsetsResult
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/ListOffsetsResult.html#%3Cinit%3E(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public ListOffsetsResult(Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Common.KafkaFuture<Org.Apache.Kafka.Clients.Admin.ListOffsetsResult.ListOffsetsResultInfo>> arg0)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/ListOffsetsResult.html#all()"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.KafkaFuture"/></returns>
        public Org.Apache.Kafka.Common.KafkaFuture<Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Clients.Admin.ListOffsetsResult.ListOffsetsResultInfo>> All()
        {
            return IExecute<Org.Apache.Kafka.Common.KafkaFuture<Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Clients.Admin.ListOffsetsResult.ListOffsetsResultInfo>>>("all");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/ListOffsetsResult.html#partitionResult(org.apache.kafka.common.TopicPartition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.KafkaFuture"/></returns>
        public Org.Apache.Kafka.Common.KafkaFuture<Org.Apache.Kafka.Clients.Admin.ListOffsetsResult.ListOffsetsResultInfo> PartitionResult(Org.Apache.Kafka.Common.TopicPartition arg0)
        {
            return IExecute<Org.Apache.Kafka.Common.KafkaFuture<Org.Apache.Kafka.Clients.Admin.ListOffsetsResult.ListOffsetsResultInfo>>("partitionResult", arg0);
        }

        #endregion

        #region Nested classes
        #region ListOffsetsResultInfo
        public partial class ListOffsetsResultInfo
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/ListOffsetsResult.ListOffsetsResultInfo.html#%3Cinit%3E(long,long,java.util.Optional)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <param name="arg1"><see cref="long"/></param>
            /// <param name="arg2"><see cref="Java.Util.Optional"/></param>
            public ListOffsetsResultInfo(long arg0, long arg1, Java.Util.Optional<int?> arg2)
                : base(arg0, arg1, arg2)
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/ListOffsetsResult.ListOffsetsResultInfo.html#leaderEpoch()"/>
            /// </summary>

            /// <returns><see cref="Java.Util.Optional"/></returns>
            public Java.Util.Optional<int?> LeaderEpoch()
            {
                return IExecute<Java.Util.Optional<int?>>("leaderEpoch");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/ListOffsetsResult.ListOffsetsResultInfo.html#offset()"/>
            /// </summary>

            /// <returns><see cref="long"/></returns>
            public long Offset()
            {
                return IExecute<long>("offset");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/ListOffsetsResult.ListOffsetsResultInfo.html#timestamp()"/>
            /// </summary>

            /// <returns><see cref="long"/></returns>
            public long Timestamp()
            {
                return IExecute<long>("timestamp");
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