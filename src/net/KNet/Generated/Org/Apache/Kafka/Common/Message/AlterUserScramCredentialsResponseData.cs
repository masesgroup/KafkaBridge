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
    #region AlterUserScramCredentialsResponseData
    public partial class AlterUserScramCredentialsResponseData
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/AlterUserScramCredentialsResponseData.html#%3Cinit%3E(org.apache.kafka.common.protocol.Readable,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Protocol.Readable"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        public AlterUserScramCredentialsResponseData(Org.Apache.Kafka.Common.Protocol.Readable arg0, short arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Common.Message.AlterUserScramCredentialsResponseData"/> to <see cref="Org.Apache.Kafka.Common.Protocol.ApiMessage"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Protocol.ApiMessage(Org.Apache.Kafka.Common.Message.AlterUserScramCredentialsResponseData t) => t.Cast<Org.Apache.Kafka.Common.Protocol.ApiMessage>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/AlterUserScramCredentialsResponseData.html#SCHEMA_0"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Protocol.Types.Schema SCHEMA_0 { get { return SGetField<Org.Apache.Kafka.Common.Protocol.Types.Schema>(LocalBridgeClazz, "SCHEMA_0"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/AlterUserScramCredentialsResponseData.html#SCHEMAS"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Protocol.Types.Schema[] SCHEMAS { get { return SGetFieldArray<Org.Apache.Kafka.Common.Protocol.Types.Schema>(LocalBridgeClazz, "SCHEMAS"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/AlterUserScramCredentialsResponseData.html#HIGHEST_SUPPORTED_VERSION"/>
        /// </summary>
        public static short HIGHEST_SUPPORTED_VERSION { get { return SGetField<short>(LocalBridgeClazz, "HIGHEST_SUPPORTED_VERSION"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/AlterUserScramCredentialsResponseData.html#LOWEST_SUPPORTED_VERSION"/>
        /// </summary>
        public static short LOWEST_SUPPORTED_VERSION { get { return SGetField<short>(LocalBridgeClazz, "LOWEST_SUPPORTED_VERSION"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/AlterUserScramCredentialsResponseData.html#apiKey()"/> 
        /// </summary>
        public short ApiKey
        {
            get { return IExecute<short>("apiKey"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/AlterUserScramCredentialsResponseData.html#duplicate()"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.Protocol.Message Duplicate
        {
            get { return IExecute<Org.Apache.Kafka.Common.Protocol.Message>("duplicate"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/AlterUserScramCredentialsResponseData.html#highestSupportedVersion()"/> 
        /// </summary>
        public short HighestSupportedVersion
        {
            get { return IExecute<short>("highestSupportedVersion"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/AlterUserScramCredentialsResponseData.html#lowestSupportedVersion()"/> 
        /// </summary>
        public short LowestSupportedVersion
        {
            get { return IExecute<short>("lowestSupportedVersion"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/AlterUserScramCredentialsResponseData.html#results()"/> 
        /// </summary>
        public Java.Util.List<Org.Apache.Kafka.Common.Message.AlterUserScramCredentialsResponseData.AlterUserScramCredentialsResult> Results
        {
            get { return IExecute<Java.Util.List<Org.Apache.Kafka.Common.Message.AlterUserScramCredentialsResponseData.AlterUserScramCredentialsResult>>("results"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/AlterUserScramCredentialsResponseData.html#throttleTimeMs()"/> 
        /// </summary>
        public int ThrottleTimeMs
        {
            get { return IExecute<int>("throttleTimeMs"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/AlterUserScramCredentialsResponseData.html#unknownTaggedFields()"/> 
        /// </summary>
        public Java.Util.List<Org.Apache.Kafka.Common.Protocol.Types.RawTaggedField> UnknownTaggedFields
        {
            get { return IExecute<Java.Util.List<Org.Apache.Kafka.Common.Protocol.Types.RawTaggedField>>("unknownTaggedFields"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/AlterUserScramCredentialsResponseData.html#setResults(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Message.AlterUserScramCredentialsResponseData"/></returns>
        public Org.Apache.Kafka.Common.Message.AlterUserScramCredentialsResponseData SetResults(Java.Util.List<Org.Apache.Kafka.Common.Message.AlterUserScramCredentialsResponseData.AlterUserScramCredentialsResult> arg0)
        {
            return IExecute<Org.Apache.Kafka.Common.Message.AlterUserScramCredentialsResponseData>("setResults", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/AlterUserScramCredentialsResponseData.html#setThrottleTimeMs(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Message.AlterUserScramCredentialsResponseData"/></returns>
        public Org.Apache.Kafka.Common.Message.AlterUserScramCredentialsResponseData SetThrottleTimeMs(int arg0)
        {
            return IExecute<Org.Apache.Kafka.Common.Message.AlterUserScramCredentialsResponseData>("setThrottleTimeMs", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/AlterUserScramCredentialsResponseData.html#addSize(org.apache.kafka.common.protocol.MessageSizeAccumulator,org.apache.kafka.common.protocol.ObjectSerializationCache,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Protocol.MessageSizeAccumulator"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Protocol.ObjectSerializationCache"/></param>
        /// <param name="arg2"><see cref="short"/></param>
        public void AddSize(Org.Apache.Kafka.Common.Protocol.MessageSizeAccumulator arg0, Org.Apache.Kafka.Common.Protocol.ObjectSerializationCache arg1, short arg2)
        {
            IExecute("addSize", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/AlterUserScramCredentialsResponseData.html#read(org.apache.kafka.common.protocol.Readable,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Protocol.Readable"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        public void Read(Org.Apache.Kafka.Common.Protocol.Readable arg0, short arg1)
        {
            IExecute("read", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/AlterUserScramCredentialsResponseData.html#write(org.apache.kafka.common.protocol.Writable,org.apache.kafka.common.protocol.ObjectSerializationCache,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Protocol.Writable"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Protocol.ObjectSerializationCache"/></param>
        /// <param name="arg2"><see cref="short"/></param>
        public void Write(Org.Apache.Kafka.Common.Protocol.Writable arg0, Org.Apache.Kafka.Common.Protocol.ObjectSerializationCache arg1, short arg2)
        {
            IExecute("write", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes
        #region AlterUserScramCredentialsResult
        public partial class AlterUserScramCredentialsResult
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/AlterUserScramCredentialsResponseData.AlterUserScramCredentialsResult.html#%3Cinit%3E(org.apache.kafka.common.protocol.Readable,short)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Protocol.Readable"/></param>
            /// <param name="arg1"><see cref="short"/></param>
            public AlterUserScramCredentialsResult(Org.Apache.Kafka.Common.Protocol.Readable arg0, short arg1)
                : base(arg0, arg1)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Org.Apache.Kafka.Common.Message.AlterUserScramCredentialsResponseData.AlterUserScramCredentialsResult"/> to <see cref="Org.Apache.Kafka.Common.Protocol.Message"/>
            /// </summary>
            public static implicit operator Org.Apache.Kafka.Common.Protocol.Message(Org.Apache.Kafka.Common.Message.AlterUserScramCredentialsResponseData.AlterUserScramCredentialsResult t) => t.Cast<Org.Apache.Kafka.Common.Protocol.Message>();

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/AlterUserScramCredentialsResponseData.AlterUserScramCredentialsResult.html#SCHEMA_0"/>
            /// </summary>
            public static Org.Apache.Kafka.Common.Protocol.Types.Schema SCHEMA_0 { get { return SGetField<Org.Apache.Kafka.Common.Protocol.Types.Schema>(LocalBridgeClazz, "SCHEMA_0"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/AlterUserScramCredentialsResponseData.AlterUserScramCredentialsResult.html#SCHEMAS"/>
            /// </summary>
            public static Org.Apache.Kafka.Common.Protocol.Types.Schema[] SCHEMAS { get { return SGetFieldArray<Org.Apache.Kafka.Common.Protocol.Types.Schema>(LocalBridgeClazz, "SCHEMAS"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/AlterUserScramCredentialsResponseData.AlterUserScramCredentialsResult.html#HIGHEST_SUPPORTED_VERSION"/>
            /// </summary>
            public static short HIGHEST_SUPPORTED_VERSION { get { return SGetField<short>(LocalBridgeClazz, "HIGHEST_SUPPORTED_VERSION"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/AlterUserScramCredentialsResponseData.AlterUserScramCredentialsResult.html#LOWEST_SUPPORTED_VERSION"/>
            /// </summary>
            public static short LOWEST_SUPPORTED_VERSION { get { return SGetField<short>(LocalBridgeClazz, "LOWEST_SUPPORTED_VERSION"); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/AlterUserScramCredentialsResponseData.AlterUserScramCredentialsResult.html#duplicate()"/> 
            /// </summary>
            public Org.Apache.Kafka.Common.Protocol.Message Duplicate
            {
                get { return IExecute<Org.Apache.Kafka.Common.Protocol.Message>("duplicate"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/AlterUserScramCredentialsResponseData.AlterUserScramCredentialsResult.html#errorCode()"/> 
            /// </summary>
            public short ErrorCode
            {
                get { return IExecute<short>("errorCode"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/AlterUserScramCredentialsResponseData.AlterUserScramCredentialsResult.html#errorMessage()"/> 
            /// </summary>
            public string ErrorMessage
            {
                get { return IExecute<string>("errorMessage"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/AlterUserScramCredentialsResponseData.AlterUserScramCredentialsResult.html#highestSupportedVersion()"/> 
            /// </summary>
            public short HighestSupportedVersion
            {
                get { return IExecute<short>("highestSupportedVersion"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/AlterUserScramCredentialsResponseData.AlterUserScramCredentialsResult.html#lowestSupportedVersion()"/> 
            /// </summary>
            public short LowestSupportedVersion
            {
                get { return IExecute<short>("lowestSupportedVersion"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/AlterUserScramCredentialsResponseData.AlterUserScramCredentialsResult.html#unknownTaggedFields()"/> 
            /// </summary>
            public Java.Util.List<Org.Apache.Kafka.Common.Protocol.Types.RawTaggedField> UnknownTaggedFields
            {
                get { return IExecute<Java.Util.List<Org.Apache.Kafka.Common.Protocol.Types.RawTaggedField>>("unknownTaggedFields"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/AlterUserScramCredentialsResponseData.AlterUserScramCredentialsResult.html#user()"/> 
            /// </summary>
            public string User
            {
                get { return IExecute<string>("user"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/AlterUserScramCredentialsResponseData.AlterUserScramCredentialsResult.html#setErrorCode(short)"/>
            /// </summary>
            /// <param name="arg0"><see cref="short"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Common.Message.AlterUserScramCredentialsResponseData.AlterUserScramCredentialsResult"/></returns>
            public Org.Apache.Kafka.Common.Message.AlterUserScramCredentialsResponseData.AlterUserScramCredentialsResult SetErrorCode(short arg0)
            {
                return IExecute<Org.Apache.Kafka.Common.Message.AlterUserScramCredentialsResponseData.AlterUserScramCredentialsResult>("setErrorCode", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/AlterUserScramCredentialsResponseData.AlterUserScramCredentialsResult.html#setErrorMessage(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Common.Message.AlterUserScramCredentialsResponseData.AlterUserScramCredentialsResult"/></returns>
            public Org.Apache.Kafka.Common.Message.AlterUserScramCredentialsResponseData.AlterUserScramCredentialsResult SetErrorMessage(string arg0)
            {
                return IExecute<Org.Apache.Kafka.Common.Message.AlterUserScramCredentialsResponseData.AlterUserScramCredentialsResult>("setErrorMessage", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/AlterUserScramCredentialsResponseData.AlterUserScramCredentialsResult.html#setUser(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Common.Message.AlterUserScramCredentialsResponseData.AlterUserScramCredentialsResult"/></returns>
            public Org.Apache.Kafka.Common.Message.AlterUserScramCredentialsResponseData.AlterUserScramCredentialsResult SetUser(string arg0)
            {
                return IExecute<Org.Apache.Kafka.Common.Message.AlterUserScramCredentialsResponseData.AlterUserScramCredentialsResult>("setUser", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/AlterUserScramCredentialsResponseData.AlterUserScramCredentialsResult.html#addSize(org.apache.kafka.common.protocol.MessageSizeAccumulator,org.apache.kafka.common.protocol.ObjectSerializationCache,short)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Protocol.MessageSizeAccumulator"/></param>
            /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Protocol.ObjectSerializationCache"/></param>
            /// <param name="arg2"><see cref="short"/></param>
            public void AddSize(Org.Apache.Kafka.Common.Protocol.MessageSizeAccumulator arg0, Org.Apache.Kafka.Common.Protocol.ObjectSerializationCache arg1, short arg2)
            {
                IExecute("addSize", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/AlterUserScramCredentialsResponseData.AlterUserScramCredentialsResult.html#read(org.apache.kafka.common.protocol.Readable,short)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Protocol.Readable"/></param>
            /// <param name="arg1"><see cref="short"/></param>
            public void Read(Org.Apache.Kafka.Common.Protocol.Readable arg0, short arg1)
            {
                IExecute("read", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/AlterUserScramCredentialsResponseData.AlterUserScramCredentialsResult.html#write(org.apache.kafka.common.protocol.Writable,org.apache.kafka.common.protocol.ObjectSerializationCache,short)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Protocol.Writable"/></param>
            /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Protocol.ObjectSerializationCache"/></param>
            /// <param name="arg2"><see cref="short"/></param>
            public void Write(Org.Apache.Kafka.Common.Protocol.Writable arg0, Org.Apache.Kafka.Common.Protocol.ObjectSerializationCache arg1, short arg2)
            {
                IExecute("write", arg0, arg1, arg2);
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