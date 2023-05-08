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
    #region FetchResponse
    public partial class FetchResponse
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/FetchResponse.html#%3Cinit%3E(org.apache.kafka.common.message.FetchResponseData)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Message.FetchResponseData"/></param>
        public FetchResponse(Org.Apache.Kafka.Common.Message.FetchResponseData arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/FetchResponse.html#INVALID_PREFERRED_REPLICA_ID"/>
        /// </summary>
        public static int INVALID_PREFERRED_REPLICA_ID { get { return SGetField<int>(LocalBridgeClazz, "INVALID_PREFERRED_REPLICA_ID"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/FetchResponse.html#INVALID_HIGH_WATERMARK"/>
        /// </summary>
        public static long INVALID_HIGH_WATERMARK { get { return SGetField<long>(LocalBridgeClazz, "INVALID_HIGH_WATERMARK"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/FetchResponse.html#INVALID_LAST_STABLE_OFFSET"/>
        /// </summary>
        public static long INVALID_LAST_STABLE_OFFSET { get { return SGetField<long>(LocalBridgeClazz, "INVALID_LAST_STABLE_OFFSET"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/FetchResponse.html#INVALID_LOG_START_OFFSET"/>
        /// </summary>
        public static long INVALID_LOG_START_OFFSET { get { return SGetField<long>(LocalBridgeClazz, "INVALID_LOG_START_OFFSET"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/FetchResponse.html#isDivergingEpoch(org.apache.kafka.common.message.FetchResponseData.PartitionData)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Message.FetchResponseData.PartitionData"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsDivergingEpoch(Org.Apache.Kafka.Common.Message.FetchResponseData.PartitionData arg0)
        {
            return SExecute<bool>(LocalBridgeClazz, "isDivergingEpoch", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/FetchResponse.html#isPreferredReplica(org.apache.kafka.common.message.FetchResponseData.PartitionData)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Message.FetchResponseData.PartitionData"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsPreferredReplica(Org.Apache.Kafka.Common.Message.FetchResponseData.PartitionData arg0)
        {
            return SExecute<bool>(LocalBridgeClazz, "isPreferredReplica", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/FetchResponse.html#recordsSize(org.apache.kafka.common.message.FetchResponseData.PartitionData)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Message.FetchResponseData.PartitionData"/></param>
        /// <returns><see cref="int"/></returns>
        public static int RecordsSize(Org.Apache.Kafka.Common.Message.FetchResponseData.PartitionData arg0)
        {
            return SExecute<int>(LocalBridgeClazz, "recordsSize", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/FetchResponse.html#sizeOf(short,java.util.Iterator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="Java.Util.Iterator"/></param>
        /// <returns><see cref="int"/></returns>
        public static int SizeOf(short arg0, Java.Util.Iterator<Java.Util.Map.Entry<Org.Apache.Kafka.Common.TopicIdPartition, Org.Apache.Kafka.Common.Message.FetchResponseData.PartitionData>> arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "sizeOf", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/FetchResponse.html#preferredReadReplica(org.apache.kafka.common.message.FetchResponseData.PartitionData)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Message.FetchResponseData.PartitionData"/></param>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public static Java.Util.Optional<int?> PreferredReadReplica(Org.Apache.Kafka.Common.Message.FetchResponseData.PartitionData arg0)
        {
            return SExecute<Java.Util.Optional<int?>>(LocalBridgeClazz, "preferredReadReplica", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/FetchResponse.html#divergingEpoch(org.apache.kafka.common.message.FetchResponseData.PartitionData)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Message.FetchResponseData.PartitionData"/></param>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public static Java.Util.Optional<Org.Apache.Kafka.Common.Message.FetchResponseData.EpochEndOffset> DivergingEpoch(Org.Apache.Kafka.Common.Message.FetchResponseData.PartitionData arg0)
        {
            return SExecute<Java.Util.Optional<Org.Apache.Kafka.Common.Message.FetchResponseData.EpochEndOffset>>(LocalBridgeClazz, "divergingEpoch", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/FetchResponse.html#partitionResponse(int,org.apache.kafka.common.protocol.Errors)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Protocol.Errors"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Message.FetchResponseData.PartitionData"/></returns>
        public static Org.Apache.Kafka.Common.Message.FetchResponseData.PartitionData PartitionResponse(int arg0, Org.Apache.Kafka.Common.Protocol.Errors arg1)
        {
            return SExecute<Org.Apache.Kafka.Common.Message.FetchResponseData.PartitionData>(LocalBridgeClazz, "partitionResponse", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/FetchResponse.html#partitionResponse(org.apache.kafka.common.TopicIdPartition,org.apache.kafka.common.protocol.Errors)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicIdPartition"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Protocol.Errors"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Message.FetchResponseData.PartitionData"/></returns>
        public static Org.Apache.Kafka.Common.Message.FetchResponseData.PartitionData PartitionResponse(Org.Apache.Kafka.Common.TopicIdPartition arg0, Org.Apache.Kafka.Common.Protocol.Errors arg1)
        {
            return SExecute<Org.Apache.Kafka.Common.Message.FetchResponseData.PartitionData>(LocalBridgeClazz, "partitionResponse", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/FetchResponse.html#recordsOrFail(org.apache.kafka.common.message.FetchResponseData.PartitionData)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Message.FetchResponseData.PartitionData"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Record.Records"/></returns>
        public static Org.Apache.Kafka.Common.Record.Records RecordsOrFail(Org.Apache.Kafka.Common.Message.FetchResponseData.PartitionData arg0)
        {
            return SExecute<Org.Apache.Kafka.Common.Record.Records>(LocalBridgeClazz, "recordsOrFail", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/FetchResponse.html#of(org.apache.kafka.common.protocol.Errors,int,int,java.util.LinkedHashMap)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Protocol.Errors"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Util.LinkedHashMap"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Requests.FetchResponse"/></returns>
        public static Org.Apache.Kafka.Common.Requests.FetchResponse Of(Org.Apache.Kafka.Common.Protocol.Errors arg0, int arg1, int arg2, Java.Util.LinkedHashMap<Org.Apache.Kafka.Common.TopicIdPartition, Org.Apache.Kafka.Common.Message.FetchResponseData.PartitionData> arg3)
        {
            return SExecute<Org.Apache.Kafka.Common.Requests.FetchResponse>(LocalBridgeClazz, "of", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/FetchResponse.html#parse(java.nio.ByteBuffer,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Requests.FetchResponse"/></returns>
        public static Org.Apache.Kafka.Common.Requests.FetchResponse Parse(Java.Nio.ByteBuffer arg0, short arg1)
        {
            return SExecute<Org.Apache.Kafka.Common.Requests.FetchResponse>(LocalBridgeClazz, "parse", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/FetchResponse.html#error()"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.Protocol.Errors Error
        {
            get { return IExecute<Org.Apache.Kafka.Common.Protocol.Errors>("error"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/FetchResponse.html#sessionId()"/> 
        /// </summary>
        public int SessionId
        {
            get { return IExecute<int>("sessionId"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/FetchResponse.html#topicIds()"/> 
        /// </summary>
        public Java.Util.Set<Org.Apache.Kafka.Common.Uuid> TopicIds
        {
            get { return IExecute<Java.Util.Set<Org.Apache.Kafka.Common.Uuid>>("topicIds"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/FetchResponse.html#responseData(java.util.Map,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        /// <returns><see cref="Java.Util.LinkedHashMap"/></returns>
        public Java.Util.LinkedHashMap<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Common.Message.FetchResponseData.PartitionData> ResponseData(Java.Util.Map<Org.Apache.Kafka.Common.Uuid, string> arg0, short arg1)
        {
            return IExecute<Java.Util.LinkedHashMap<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Common.Message.FetchResponseData.PartitionData>>("responseData", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}