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
    #region OffsetFetchResponse
    public partial class OffsetFetchResponse
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/OffsetFetchResponse.html#%3Cinit%3E(int,java.util.Map,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <param name="arg2"><see cref="Java.Util.Map"/></param>
        public OffsetFetchResponse(int arg0, Java.Util.Map arg1, Java.Util.Map arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/OffsetFetchResponse.html#%3Cinit%3E(int,org.apache.kafka.common.protocol.Errors,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Protocol.Errors"/></param>
        /// <param name="arg2"><see cref="Java.Util.Map"/></param>
        public OffsetFetchResponse(int arg0, Org.Apache.Kafka.Common.Protocol.Errors arg1, Java.Util.Map arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/OffsetFetchResponse.html#%3Cinit%3E(org.apache.kafka.common.message.OffsetFetchResponseData,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Message.OffsetFetchResponseData"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        public OffsetFetchResponse(Org.Apache.Kafka.Common.Message.OffsetFetchResponseData arg0, short arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/OffsetFetchResponse.html#%3Cinit%3E(org.apache.kafka.common.message.OffsetFetchResponseData)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Message.OffsetFetchResponseData"/></param>
        public OffsetFetchResponse(Org.Apache.Kafka.Common.Message.OffsetFetchResponseData arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/OffsetFetchResponse.html#%3Cinit%3E(org.apache.kafka.common.protocol.Errors,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Protocol.Errors"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        public OffsetFetchResponse(Org.Apache.Kafka.Common.Protocol.Errors arg0, Java.Util.Map arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/OffsetFetchResponse.html#NO_METADATA"/>
        /// </summary>
        public static string NO_METADATA { get { return SGetField<string>(LocalBridgeClazz, "NO_METADATA"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/OffsetFetchResponse.html#INVALID_OFFSET"/>
        /// </summary>
        public static long INVALID_OFFSET { get { return SGetField<long>(LocalBridgeClazz, "INVALID_OFFSET"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/OffsetFetchResponse.html#UNAUTHORIZED_PARTITION"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Requests.OffsetFetchResponse.PartitionData UNAUTHORIZED_PARTITION { get { return SGetField<Org.Apache.Kafka.Common.Requests.OffsetFetchResponse.PartitionData>(LocalBridgeClazz, "UNAUTHORIZED_PARTITION"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/OffsetFetchResponse.html#UNKNOWN_PARTITION"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Requests.OffsetFetchResponse.PartitionData UNKNOWN_PARTITION { get { return SGetField<Org.Apache.Kafka.Common.Requests.OffsetFetchResponse.PartitionData>(LocalBridgeClazz, "UNKNOWN_PARTITION"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/OffsetFetchResponse.html#parse(java.nio.ByteBuffer,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Requests.OffsetFetchResponse"/></returns>
        public static Org.Apache.Kafka.Common.Requests.OffsetFetchResponse Parse(Java.Nio.ByteBuffer arg0, short arg1)
        {
            return SExecute<Org.Apache.Kafka.Common.Requests.OffsetFetchResponse>(LocalBridgeClazz, "parse", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/OffsetFetchResponse.html#error()"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.Protocol.Errors Error
        {
            get { return IExecute<Org.Apache.Kafka.Common.Protocol.Errors>("error"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/OffsetFetchResponse.html#hasError()"/> 
        /// </summary>
        public bool HasError
        {
            get { return IExecute<bool>("hasError"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/OffsetFetchResponse.html#groupHasError(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool GroupHasError(string arg0)
        {
            return IExecute<bool>("groupHasError", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/OffsetFetchResponse.html#partitionDataMap(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Common.Requests.OffsetFetchResponse.PartitionData> PartitionDataMap(string arg0)
        {
            return IExecute<Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Common.Requests.OffsetFetchResponse.PartitionData>>("partitionDataMap", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/OffsetFetchResponse.html#groupLevelError(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Protocol.Errors"/></returns>
        public Org.Apache.Kafka.Common.Protocol.Errors GroupLevelError(string arg0)
        {
            return IExecute<Org.Apache.Kafka.Common.Protocol.Errors>("groupLevelError", arg0);
        }

        #endregion

        #region Nested classes
        #region PartitionData
        public partial class PartitionData
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/OffsetFetchResponse.PartitionData.html#%3Cinit%3E(long,java.util.Optional,java.lang.String,org.apache.kafka.common.protocol.Errors)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <param name="arg1"><see cref="Java.Util.Optional"/></param>
            /// <param name="arg2"><see cref="string"/></param>
            /// <param name="arg3"><see cref="Org.Apache.Kafka.Common.Protocol.Errors"/></param>
            public PartitionData(long arg0, Java.Util.Optional arg1, string arg2, Org.Apache.Kafka.Common.Protocol.Errors arg3)
                : base(arg0, arg1, arg2, arg3)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/OffsetFetchResponse.PartitionData.html#metadata"/>
            /// </summary>
            public string metadata { get { return IGetField<string>("metadata"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/OffsetFetchResponse.PartitionData.html#leaderEpoch"/>
            /// </summary>
            public Java.Util.Optional leaderEpoch { get { return IGetField<Java.Util.Optional>("leaderEpoch"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/OffsetFetchResponse.PartitionData.html#offset"/>
            /// </summary>
            public long offset { get { return IGetField<long>("offset"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/OffsetFetchResponse.PartitionData.html#error"/>
            /// </summary>
            public Org.Apache.Kafka.Common.Protocol.Errors error { get { return IGetField<Org.Apache.Kafka.Common.Protocol.Errors>("error"); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/requests/OffsetFetchResponse.PartitionData.html#hasError()"/> 
            /// </summary>
            public bool HasError
            {
                get { return IExecute<bool>("hasError"); }
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