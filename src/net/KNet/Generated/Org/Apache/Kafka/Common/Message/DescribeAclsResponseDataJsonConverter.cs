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
    #region DescribeAclsResponseDataJsonConverter
    public partial class DescribeAclsResponseDataJsonConverter
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeAclsResponseDataJsonConverter.html#write(org.apache.kafka.common.message.DescribeAclsResponseData,short,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Message.DescribeAclsResponseData"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="Com.Fasterxml.Jackson.Databind.JsonNode"/></returns>
        public static Com.Fasterxml.Jackson.Databind.JsonNode Write(Org.Apache.Kafka.Common.Message.DescribeAclsResponseData arg0, short arg1, bool arg2)
        {
            return SExecute<Com.Fasterxml.Jackson.Databind.JsonNode>(LocalBridgeClazz, "write", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeAclsResponseDataJsonConverter.html#write(org.apache.kafka.common.message.DescribeAclsResponseData,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Message.DescribeAclsResponseData"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        /// <returns><see cref="Com.Fasterxml.Jackson.Databind.JsonNode"/></returns>
        public static Com.Fasterxml.Jackson.Databind.JsonNode Write(Org.Apache.Kafka.Common.Message.DescribeAclsResponseData arg0, short arg1)
        {
            return SExecute<Com.Fasterxml.Jackson.Databind.JsonNode>(LocalBridgeClazz, "write", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeAclsResponseDataJsonConverter.html#read(com.fasterxml.jackson.databind.JsonNode,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Com.Fasterxml.Jackson.Databind.JsonNode"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Message.DescribeAclsResponseData"/></returns>
        public static Org.Apache.Kafka.Common.Message.DescribeAclsResponseData Read(Com.Fasterxml.Jackson.Databind.JsonNode arg0, short arg1)
        {
            return SExecute<Org.Apache.Kafka.Common.Message.DescribeAclsResponseData>(LocalBridgeClazz, "read", arg0, arg1);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region AclDescriptionJsonConverter
        public partial class AclDescriptionJsonConverter
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeAclsResponseDataJsonConverter.AclDescriptionJsonConverter.html#write(org.apache.kafka.common.message.DescribeAclsResponseData.AclDescription,short,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Message.DescribeAclsResponseData.AclDescription"/></param>
            /// <param name="arg1"><see cref="short"/></param>
            /// <param name="arg2"><see cref="bool"/></param>
            /// <returns><see cref="Com.Fasterxml.Jackson.Databind.JsonNode"/></returns>
            public static Com.Fasterxml.Jackson.Databind.JsonNode Write(Org.Apache.Kafka.Common.Message.DescribeAclsResponseData.AclDescription arg0, short arg1, bool arg2)
            {
                return SExecute<Com.Fasterxml.Jackson.Databind.JsonNode>(LocalBridgeClazz, "write", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeAclsResponseDataJsonConverter.AclDescriptionJsonConverter.html#write(org.apache.kafka.common.message.DescribeAclsResponseData.AclDescription,short)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Message.DescribeAclsResponseData.AclDescription"/></param>
            /// <param name="arg1"><see cref="short"/></param>
            /// <returns><see cref="Com.Fasterxml.Jackson.Databind.JsonNode"/></returns>
            public static Com.Fasterxml.Jackson.Databind.JsonNode Write(Org.Apache.Kafka.Common.Message.DescribeAclsResponseData.AclDescription arg0, short arg1)
            {
                return SExecute<Com.Fasterxml.Jackson.Databind.JsonNode>(LocalBridgeClazz, "write", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeAclsResponseDataJsonConverter.AclDescriptionJsonConverter.html#read(com.fasterxml.jackson.databind.JsonNode,short)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Com.Fasterxml.Jackson.Databind.JsonNode"/></param>
            /// <param name="arg1"><see cref="short"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Common.Message.DescribeAclsResponseData.AclDescription"/></returns>
            public static Org.Apache.Kafka.Common.Message.DescribeAclsResponseData.AclDescription Read(Com.Fasterxml.Jackson.Databind.JsonNode arg0, short arg1)
            {
                return SExecute<Org.Apache.Kafka.Common.Message.DescribeAclsResponseData.AclDescription>(LocalBridgeClazz, "read", arg0, arg1);
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region DescribeAclsResourceJsonConverter
        public partial class DescribeAclsResourceJsonConverter
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeAclsResponseDataJsonConverter.DescribeAclsResourceJsonConverter.html#write(org.apache.kafka.common.message.DescribeAclsResponseData.DescribeAclsResource,short,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Message.DescribeAclsResponseData.DescribeAclsResource"/></param>
            /// <param name="arg1"><see cref="short"/></param>
            /// <param name="arg2"><see cref="bool"/></param>
            /// <returns><see cref="Com.Fasterxml.Jackson.Databind.JsonNode"/></returns>
            public static Com.Fasterxml.Jackson.Databind.JsonNode Write(Org.Apache.Kafka.Common.Message.DescribeAclsResponseData.DescribeAclsResource arg0, short arg1, bool arg2)
            {
                return SExecute<Com.Fasterxml.Jackson.Databind.JsonNode>(LocalBridgeClazz, "write", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeAclsResponseDataJsonConverter.DescribeAclsResourceJsonConverter.html#write(org.apache.kafka.common.message.DescribeAclsResponseData.DescribeAclsResource,short)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Message.DescribeAclsResponseData.DescribeAclsResource"/></param>
            /// <param name="arg1"><see cref="short"/></param>
            /// <returns><see cref="Com.Fasterxml.Jackson.Databind.JsonNode"/></returns>
            public static Com.Fasterxml.Jackson.Databind.JsonNode Write(Org.Apache.Kafka.Common.Message.DescribeAclsResponseData.DescribeAclsResource arg0, short arg1)
            {
                return SExecute<Com.Fasterxml.Jackson.Databind.JsonNode>(LocalBridgeClazz, "write", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeAclsResponseDataJsonConverter.DescribeAclsResourceJsonConverter.html#read(com.fasterxml.jackson.databind.JsonNode,short)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Com.Fasterxml.Jackson.Databind.JsonNode"/></param>
            /// <param name="arg1"><see cref="short"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Common.Message.DescribeAclsResponseData.DescribeAclsResource"/></returns>
            public static Org.Apache.Kafka.Common.Message.DescribeAclsResponseData.DescribeAclsResource Read(Com.Fasterxml.Jackson.Databind.JsonNode arg0, short arg1)
            {
                return SExecute<Org.Apache.Kafka.Common.Message.DescribeAclsResponseData.DescribeAclsResource>(LocalBridgeClazz, "read", arg0, arg1);
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