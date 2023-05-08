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

namespace Org.Apache.Kafka.Common.Message
{
    #region OffsetFetchResponseDataJsonConverter
    public partial class OffsetFetchResponseDataJsonConverter
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/OffsetFetchResponseDataJsonConverter.html#write(org.apache.kafka.common.message.OffsetFetchResponseData,short,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Message.OffsetFetchResponseData"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="Com.Fasterxml.Jackson.Databind.JsonNode"/></returns>
        public static Com.Fasterxml.Jackson.Databind.JsonNode Write(Org.Apache.Kafka.Common.Message.OffsetFetchResponseData arg0, short arg1, bool arg2)
        {
            return SExecute<Com.Fasterxml.Jackson.Databind.JsonNode>(LocalBridgeClazz, "write", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/OffsetFetchResponseDataJsonConverter.html#write(org.apache.kafka.common.message.OffsetFetchResponseData,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Message.OffsetFetchResponseData"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        /// <returns><see cref="Com.Fasterxml.Jackson.Databind.JsonNode"/></returns>
        public static Com.Fasterxml.Jackson.Databind.JsonNode Write(Org.Apache.Kafka.Common.Message.OffsetFetchResponseData arg0, short arg1)
        {
            return SExecute<Com.Fasterxml.Jackson.Databind.JsonNode>(LocalBridgeClazz, "write", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/OffsetFetchResponseDataJsonConverter.html#read(com.fasterxml.jackson.databind.JsonNode,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Com.Fasterxml.Jackson.Databind.JsonNode"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Message.OffsetFetchResponseData"/></returns>
        public static Org.Apache.Kafka.Common.Message.OffsetFetchResponseData Read(Com.Fasterxml.Jackson.Databind.JsonNode arg0, short arg1)
        {
            return SExecute<Org.Apache.Kafka.Common.Message.OffsetFetchResponseData>(LocalBridgeClazz, "read", arg0, arg1);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region OffsetFetchResponseGroupJsonConverter
        public partial class OffsetFetchResponseGroupJsonConverter
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/OffsetFetchResponseDataJsonConverter.OffsetFetchResponseGroupJsonConverter.html#write(org.apache.kafka.common.message.OffsetFetchResponseData.OffsetFetchResponseGroup,short,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Message.OffsetFetchResponseData.OffsetFetchResponseGroup"/></param>
            /// <param name="arg1"><see cref="short"/></param>
            /// <param name="arg2"><see cref="bool"/></param>
            /// <returns><see cref="Com.Fasterxml.Jackson.Databind.JsonNode"/></returns>
            public static Com.Fasterxml.Jackson.Databind.JsonNode Write(Org.Apache.Kafka.Common.Message.OffsetFetchResponseData.OffsetFetchResponseGroup arg0, short arg1, bool arg2)
            {
                return SExecute<Com.Fasterxml.Jackson.Databind.JsonNode>(LocalBridgeClazz, "write", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/OffsetFetchResponseDataJsonConverter.OffsetFetchResponseGroupJsonConverter.html#write(org.apache.kafka.common.message.OffsetFetchResponseData.OffsetFetchResponseGroup,short)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Message.OffsetFetchResponseData.OffsetFetchResponseGroup"/></param>
            /// <param name="arg1"><see cref="short"/></param>
            /// <returns><see cref="Com.Fasterxml.Jackson.Databind.JsonNode"/></returns>
            public static Com.Fasterxml.Jackson.Databind.JsonNode Write(Org.Apache.Kafka.Common.Message.OffsetFetchResponseData.OffsetFetchResponseGroup arg0, short arg1)
            {
                return SExecute<Com.Fasterxml.Jackson.Databind.JsonNode>(LocalBridgeClazz, "write", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/OffsetFetchResponseDataJsonConverter.OffsetFetchResponseGroupJsonConverter.html#read(com.fasterxml.jackson.databind.JsonNode,short)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Com.Fasterxml.Jackson.Databind.JsonNode"/></param>
            /// <param name="arg1"><see cref="short"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Common.Message.OffsetFetchResponseData.OffsetFetchResponseGroup"/></returns>
            public static Org.Apache.Kafka.Common.Message.OffsetFetchResponseData.OffsetFetchResponseGroup Read(Com.Fasterxml.Jackson.Databind.JsonNode arg0, short arg1)
            {
                return SExecute<Org.Apache.Kafka.Common.Message.OffsetFetchResponseData.OffsetFetchResponseGroup>(LocalBridgeClazz, "read", arg0, arg1);
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OffsetFetchResponsePartitionJsonConverter
        public partial class OffsetFetchResponsePartitionJsonConverter
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/OffsetFetchResponseDataJsonConverter.OffsetFetchResponsePartitionJsonConverter.html#write(org.apache.kafka.common.message.OffsetFetchResponseData.OffsetFetchResponsePartition,short,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Message.OffsetFetchResponseData.OffsetFetchResponsePartition"/></param>
            /// <param name="arg1"><see cref="short"/></param>
            /// <param name="arg2"><see cref="bool"/></param>
            /// <returns><see cref="Com.Fasterxml.Jackson.Databind.JsonNode"/></returns>
            public static Com.Fasterxml.Jackson.Databind.JsonNode Write(Org.Apache.Kafka.Common.Message.OffsetFetchResponseData.OffsetFetchResponsePartition arg0, short arg1, bool arg2)
            {
                return SExecute<Com.Fasterxml.Jackson.Databind.JsonNode>(LocalBridgeClazz, "write", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/OffsetFetchResponseDataJsonConverter.OffsetFetchResponsePartitionJsonConverter.html#write(org.apache.kafka.common.message.OffsetFetchResponseData.OffsetFetchResponsePartition,short)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Message.OffsetFetchResponseData.OffsetFetchResponsePartition"/></param>
            /// <param name="arg1"><see cref="short"/></param>
            /// <returns><see cref="Com.Fasterxml.Jackson.Databind.JsonNode"/></returns>
            public static Com.Fasterxml.Jackson.Databind.JsonNode Write(Org.Apache.Kafka.Common.Message.OffsetFetchResponseData.OffsetFetchResponsePartition arg0, short arg1)
            {
                return SExecute<Com.Fasterxml.Jackson.Databind.JsonNode>(LocalBridgeClazz, "write", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/OffsetFetchResponseDataJsonConverter.OffsetFetchResponsePartitionJsonConverter.html#read(com.fasterxml.jackson.databind.JsonNode,short)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Com.Fasterxml.Jackson.Databind.JsonNode"/></param>
            /// <param name="arg1"><see cref="short"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Common.Message.OffsetFetchResponseData.OffsetFetchResponsePartition"/></returns>
            public static Org.Apache.Kafka.Common.Message.OffsetFetchResponseData.OffsetFetchResponsePartition Read(Com.Fasterxml.Jackson.Databind.JsonNode arg0, short arg1)
            {
                return SExecute<Org.Apache.Kafka.Common.Message.OffsetFetchResponseData.OffsetFetchResponsePartition>(LocalBridgeClazz, "read", arg0, arg1);
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OffsetFetchResponsePartitionsJsonConverter
        public partial class OffsetFetchResponsePartitionsJsonConverter
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/OffsetFetchResponseDataJsonConverter.OffsetFetchResponsePartitionsJsonConverter.html#write(org.apache.kafka.common.message.OffsetFetchResponseData.OffsetFetchResponsePartitions,short,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Message.OffsetFetchResponseData.OffsetFetchResponsePartitions"/></param>
            /// <param name="arg1"><see cref="short"/></param>
            /// <param name="arg2"><see cref="bool"/></param>
            /// <returns><see cref="Com.Fasterxml.Jackson.Databind.JsonNode"/></returns>
            public static Com.Fasterxml.Jackson.Databind.JsonNode Write(Org.Apache.Kafka.Common.Message.OffsetFetchResponseData.OffsetFetchResponsePartitions arg0, short arg1, bool arg2)
            {
                return SExecute<Com.Fasterxml.Jackson.Databind.JsonNode>(LocalBridgeClazz, "write", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/OffsetFetchResponseDataJsonConverter.OffsetFetchResponsePartitionsJsonConverter.html#write(org.apache.kafka.common.message.OffsetFetchResponseData.OffsetFetchResponsePartitions,short)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Message.OffsetFetchResponseData.OffsetFetchResponsePartitions"/></param>
            /// <param name="arg1"><see cref="short"/></param>
            /// <returns><see cref="Com.Fasterxml.Jackson.Databind.JsonNode"/></returns>
            public static Com.Fasterxml.Jackson.Databind.JsonNode Write(Org.Apache.Kafka.Common.Message.OffsetFetchResponseData.OffsetFetchResponsePartitions arg0, short arg1)
            {
                return SExecute<Com.Fasterxml.Jackson.Databind.JsonNode>(LocalBridgeClazz, "write", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/OffsetFetchResponseDataJsonConverter.OffsetFetchResponsePartitionsJsonConverter.html#read(com.fasterxml.jackson.databind.JsonNode,short)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Com.Fasterxml.Jackson.Databind.JsonNode"/></param>
            /// <param name="arg1"><see cref="short"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Common.Message.OffsetFetchResponseData.OffsetFetchResponsePartitions"/></returns>
            public static Org.Apache.Kafka.Common.Message.OffsetFetchResponseData.OffsetFetchResponsePartitions Read(Com.Fasterxml.Jackson.Databind.JsonNode arg0, short arg1)
            {
                return SExecute<Org.Apache.Kafka.Common.Message.OffsetFetchResponseData.OffsetFetchResponsePartitions>(LocalBridgeClazz, "read", arg0, arg1);
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OffsetFetchResponseTopicJsonConverter
        public partial class OffsetFetchResponseTopicJsonConverter
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/OffsetFetchResponseDataJsonConverter.OffsetFetchResponseTopicJsonConverter.html#write(org.apache.kafka.common.message.OffsetFetchResponseData.OffsetFetchResponseTopic,short,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Message.OffsetFetchResponseData.OffsetFetchResponseTopic"/></param>
            /// <param name="arg1"><see cref="short"/></param>
            /// <param name="arg2"><see cref="bool"/></param>
            /// <returns><see cref="Com.Fasterxml.Jackson.Databind.JsonNode"/></returns>
            public static Com.Fasterxml.Jackson.Databind.JsonNode Write(Org.Apache.Kafka.Common.Message.OffsetFetchResponseData.OffsetFetchResponseTopic arg0, short arg1, bool arg2)
            {
                return SExecute<Com.Fasterxml.Jackson.Databind.JsonNode>(LocalBridgeClazz, "write", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/OffsetFetchResponseDataJsonConverter.OffsetFetchResponseTopicJsonConverter.html#write(org.apache.kafka.common.message.OffsetFetchResponseData.OffsetFetchResponseTopic,short)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Message.OffsetFetchResponseData.OffsetFetchResponseTopic"/></param>
            /// <param name="arg1"><see cref="short"/></param>
            /// <returns><see cref="Com.Fasterxml.Jackson.Databind.JsonNode"/></returns>
            public static Com.Fasterxml.Jackson.Databind.JsonNode Write(Org.Apache.Kafka.Common.Message.OffsetFetchResponseData.OffsetFetchResponseTopic arg0, short arg1)
            {
                return SExecute<Com.Fasterxml.Jackson.Databind.JsonNode>(LocalBridgeClazz, "write", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/OffsetFetchResponseDataJsonConverter.OffsetFetchResponseTopicJsonConverter.html#read(com.fasterxml.jackson.databind.JsonNode,short)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Com.Fasterxml.Jackson.Databind.JsonNode"/></param>
            /// <param name="arg1"><see cref="short"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Common.Message.OffsetFetchResponseData.OffsetFetchResponseTopic"/></returns>
            public static Org.Apache.Kafka.Common.Message.OffsetFetchResponseData.OffsetFetchResponseTopic Read(Com.Fasterxml.Jackson.Databind.JsonNode arg0, short arg1)
            {
                return SExecute<Org.Apache.Kafka.Common.Message.OffsetFetchResponseData.OffsetFetchResponseTopic>(LocalBridgeClazz, "read", arg0, arg1);
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OffsetFetchResponseTopicsJsonConverter
        public partial class OffsetFetchResponseTopicsJsonConverter
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/OffsetFetchResponseDataJsonConverter.OffsetFetchResponseTopicsJsonConverter.html#write(org.apache.kafka.common.message.OffsetFetchResponseData.OffsetFetchResponseTopics,short,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Message.OffsetFetchResponseData.OffsetFetchResponseTopics"/></param>
            /// <param name="arg1"><see cref="short"/></param>
            /// <param name="arg2"><see cref="bool"/></param>
            /// <returns><see cref="Com.Fasterxml.Jackson.Databind.JsonNode"/></returns>
            public static Com.Fasterxml.Jackson.Databind.JsonNode Write(Org.Apache.Kafka.Common.Message.OffsetFetchResponseData.OffsetFetchResponseTopics arg0, short arg1, bool arg2)
            {
                return SExecute<Com.Fasterxml.Jackson.Databind.JsonNode>(LocalBridgeClazz, "write", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/OffsetFetchResponseDataJsonConverter.OffsetFetchResponseTopicsJsonConverter.html#write(org.apache.kafka.common.message.OffsetFetchResponseData.OffsetFetchResponseTopics,short)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Message.OffsetFetchResponseData.OffsetFetchResponseTopics"/></param>
            /// <param name="arg1"><see cref="short"/></param>
            /// <returns><see cref="Com.Fasterxml.Jackson.Databind.JsonNode"/></returns>
            public static Com.Fasterxml.Jackson.Databind.JsonNode Write(Org.Apache.Kafka.Common.Message.OffsetFetchResponseData.OffsetFetchResponseTopics arg0, short arg1)
            {
                return SExecute<Com.Fasterxml.Jackson.Databind.JsonNode>(LocalBridgeClazz, "write", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/OffsetFetchResponseDataJsonConverter.OffsetFetchResponseTopicsJsonConverter.html#read(com.fasterxml.jackson.databind.JsonNode,short)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Com.Fasterxml.Jackson.Databind.JsonNode"/></param>
            /// <param name="arg1"><see cref="short"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Common.Message.OffsetFetchResponseData.OffsetFetchResponseTopics"/></returns>
            public static Org.Apache.Kafka.Common.Message.OffsetFetchResponseData.OffsetFetchResponseTopics Read(Com.Fasterxml.Jackson.Databind.JsonNode arg0, short arg1)
            {
                return SExecute<Org.Apache.Kafka.Common.Message.OffsetFetchResponseData.OffsetFetchResponseTopics>(LocalBridgeClazz, "read", arg0, arg1);
            }

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