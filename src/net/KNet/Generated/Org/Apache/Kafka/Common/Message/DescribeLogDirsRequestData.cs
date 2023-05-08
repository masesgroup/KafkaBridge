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
    #region DescribeLogDirsRequestData
    public partial class DescribeLogDirsRequestData
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.html#%3Cinit%3E(org.apache.kafka.common.protocol.Readable,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Protocol.Readable"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        public DescribeLogDirsRequestData(Org.Apache.Kafka.Common.Protocol.Readable arg0, short arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Common.Message.DescribeLogDirsRequestData"/> to <see cref="Org.Apache.Kafka.Common.Protocol.ApiMessage"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Protocol.ApiMessage(Org.Apache.Kafka.Common.Message.DescribeLogDirsRequestData t) => t.Cast<Org.Apache.Kafka.Common.Protocol.ApiMessage>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.html#SCHEMA_0"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Protocol.Types.Schema SCHEMA_0 { get { return SGetField<Org.Apache.Kafka.Common.Protocol.Types.Schema>(LocalBridgeClazz, "SCHEMA_0"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.html#SCHEMA_1"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Protocol.Types.Schema SCHEMA_1 { get { return SGetField<Org.Apache.Kafka.Common.Protocol.Types.Schema>(LocalBridgeClazz, "SCHEMA_1"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.html#SCHEMA_2"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Protocol.Types.Schema SCHEMA_2 { get { return SGetField<Org.Apache.Kafka.Common.Protocol.Types.Schema>(LocalBridgeClazz, "SCHEMA_2"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.html#SCHEMA_3"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Protocol.Types.Schema SCHEMA_3 { get { return SGetField<Org.Apache.Kafka.Common.Protocol.Types.Schema>(LocalBridgeClazz, "SCHEMA_3"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.html#SCHEMA_4"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Protocol.Types.Schema SCHEMA_4 { get { return SGetField<Org.Apache.Kafka.Common.Protocol.Types.Schema>(LocalBridgeClazz, "SCHEMA_4"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.html#SCHEMAS"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Protocol.Types.Schema[] SCHEMAS { get { return SGetFieldArray<Org.Apache.Kafka.Common.Protocol.Types.Schema>(LocalBridgeClazz, "SCHEMAS"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.html#HIGHEST_SUPPORTED_VERSION"/>
        /// </summary>
        public static short HIGHEST_SUPPORTED_VERSION { get { return SGetField<short>(LocalBridgeClazz, "HIGHEST_SUPPORTED_VERSION"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.html#LOWEST_SUPPORTED_VERSION"/>
        /// </summary>
        public static short LOWEST_SUPPORTED_VERSION { get { return SGetField<short>(LocalBridgeClazz, "LOWEST_SUPPORTED_VERSION"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.html#apiKey()"/> 
        /// </summary>
        public short ApiKey
        {
            get { return IExecute<short>("apiKey"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.html#duplicate()"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.Protocol.Message Duplicate
        {
            get { return IExecute<Org.Apache.Kafka.Common.Protocol.Message>("duplicate"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.html#highestSupportedVersion()"/> 
        /// </summary>
        public short HighestSupportedVersion
        {
            get { return IExecute<short>("highestSupportedVersion"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.html#lowestSupportedVersion()"/> 
        /// </summary>
        public short LowestSupportedVersion
        {
            get { return IExecute<short>("lowestSupportedVersion"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.html#topics()"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.Message.DescribeLogDirsRequestData.DescribableLogDirTopicCollection Topics
        {
            get { return IExecute<Org.Apache.Kafka.Common.Message.DescribeLogDirsRequestData.DescribableLogDirTopicCollection>("topics"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.html#unknownTaggedFields()"/> 
        /// </summary>
        public Java.Util.List<Org.Apache.Kafka.Common.Protocol.Types.RawTaggedField> UnknownTaggedFields
        {
            get { return IExecute<Java.Util.List<Org.Apache.Kafka.Common.Protocol.Types.RawTaggedField>>("unknownTaggedFields"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.html#setTopics(org.apache.kafka.common.message.DescribeLogDirsRequestData.DescribableLogDirTopicCollection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Message.DescribeLogDirsRequestData.DescribableLogDirTopicCollection"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Message.DescribeLogDirsRequestData"/></returns>
        public Org.Apache.Kafka.Common.Message.DescribeLogDirsRequestData SetTopics(Org.Apache.Kafka.Common.Message.DescribeLogDirsRequestData.DescribableLogDirTopicCollection arg0)
        {
            return IExecute<Org.Apache.Kafka.Common.Message.DescribeLogDirsRequestData>("setTopics", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.html#addSize(org.apache.kafka.common.protocol.MessageSizeAccumulator,org.apache.kafka.common.protocol.ObjectSerializationCache,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Protocol.MessageSizeAccumulator"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Protocol.ObjectSerializationCache"/></param>
        /// <param name="arg2"><see cref="short"/></param>
        public void AddSize(Org.Apache.Kafka.Common.Protocol.MessageSizeAccumulator arg0, Org.Apache.Kafka.Common.Protocol.ObjectSerializationCache arg1, short arg2)
        {
            IExecute("addSize", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.html#read(org.apache.kafka.common.protocol.Readable,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Protocol.Readable"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        public void Read(Org.Apache.Kafka.Common.Protocol.Readable arg0, short arg1)
        {
            IExecute("read", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.html#write(org.apache.kafka.common.protocol.Writable,org.apache.kafka.common.protocol.ObjectSerializationCache,short)"/>
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
        #region DescribableLogDirTopic
        public partial class DescribableLogDirTopic
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.DescribableLogDirTopic.html#%3Cinit%3E(org.apache.kafka.common.protocol.Readable,short)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Protocol.Readable"/></param>
            /// <param name="arg1"><see cref="short"/></param>
            public DescribableLogDirTopic(Org.Apache.Kafka.Common.Protocol.Readable arg0, short arg1)
                : base(arg0, arg1)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Org.Apache.Kafka.Common.Message.DescribeLogDirsRequestData.DescribableLogDirTopic"/> to <see cref="Org.Apache.Kafka.Common.Protocol.Message"/>
            /// </summary>
            public static implicit operator Org.Apache.Kafka.Common.Protocol.Message(Org.Apache.Kafka.Common.Message.DescribeLogDirsRequestData.DescribableLogDirTopic t) => t.Cast<Org.Apache.Kafka.Common.Protocol.Message>();

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.DescribableLogDirTopic.html#SCHEMA_0"/>
            /// </summary>
            public static Org.Apache.Kafka.Common.Protocol.Types.Schema SCHEMA_0 { get { return SGetField<Org.Apache.Kafka.Common.Protocol.Types.Schema>(LocalBridgeClazz, "SCHEMA_0"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.DescribableLogDirTopic.html#SCHEMA_1"/>
            /// </summary>
            public static Org.Apache.Kafka.Common.Protocol.Types.Schema SCHEMA_1 { get { return SGetField<Org.Apache.Kafka.Common.Protocol.Types.Schema>(LocalBridgeClazz, "SCHEMA_1"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.DescribableLogDirTopic.html#SCHEMA_2"/>
            /// </summary>
            public static Org.Apache.Kafka.Common.Protocol.Types.Schema SCHEMA_2 { get { return SGetField<Org.Apache.Kafka.Common.Protocol.Types.Schema>(LocalBridgeClazz, "SCHEMA_2"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.DescribableLogDirTopic.html#SCHEMA_3"/>
            /// </summary>
            public static Org.Apache.Kafka.Common.Protocol.Types.Schema SCHEMA_3 { get { return SGetField<Org.Apache.Kafka.Common.Protocol.Types.Schema>(LocalBridgeClazz, "SCHEMA_3"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.DescribableLogDirTopic.html#SCHEMA_4"/>
            /// </summary>
            public static Org.Apache.Kafka.Common.Protocol.Types.Schema SCHEMA_4 { get { return SGetField<Org.Apache.Kafka.Common.Protocol.Types.Schema>(LocalBridgeClazz, "SCHEMA_4"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.DescribableLogDirTopic.html#SCHEMAS"/>
            /// </summary>
            public static Org.Apache.Kafka.Common.Protocol.Types.Schema[] SCHEMAS { get { return SGetFieldArray<Org.Apache.Kafka.Common.Protocol.Types.Schema>(LocalBridgeClazz, "SCHEMAS"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.DescribableLogDirTopic.html#HIGHEST_SUPPORTED_VERSION"/>
            /// </summary>
            public static short HIGHEST_SUPPORTED_VERSION { get { return SGetField<short>(LocalBridgeClazz, "HIGHEST_SUPPORTED_VERSION"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.DescribableLogDirTopic.html#LOWEST_SUPPORTED_VERSION"/>
            /// </summary>
            public static short LOWEST_SUPPORTED_VERSION { get { return SGetField<short>(LocalBridgeClazz, "LOWEST_SUPPORTED_VERSION"); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.DescribableLogDirTopic.html#duplicate()"/> 
            /// </summary>
            public Org.Apache.Kafka.Common.Protocol.Message Duplicate
            {
                get { return IExecute<Org.Apache.Kafka.Common.Protocol.Message>("duplicate"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.DescribableLogDirTopic.html#highestSupportedVersion()"/> 
            /// </summary>
            public short HighestSupportedVersion
            {
                get { return IExecute<short>("highestSupportedVersion"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.DescribableLogDirTopic.html#lowestSupportedVersion()"/> 
            /// </summary>
            public short LowestSupportedVersion
            {
                get { return IExecute<short>("lowestSupportedVersion"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.DescribableLogDirTopic.html#next()"/> 
            /// </summary>
            public int Next
            {
                get { return IExecute<int>("next"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.DescribableLogDirTopic.html#partitions()"/> 
            /// </summary>
            public Java.Util.List<int?> Partitions
            {
                get { return IExecute<Java.Util.List<int?>>("partitions"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.DescribableLogDirTopic.html#prev()"/> 
            /// </summary>
            public int Prev
            {
                get { return IExecute<int>("prev"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.DescribableLogDirTopic.html#topic()"/> 
            /// </summary>
            public string Topic
            {
                get { return IExecute<string>("topic"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.DescribableLogDirTopic.html#unknownTaggedFields()"/> 
            /// </summary>
            public Java.Util.List<Org.Apache.Kafka.Common.Protocol.Types.RawTaggedField> UnknownTaggedFields
            {
                get { return IExecute<Java.Util.List<Org.Apache.Kafka.Common.Protocol.Types.RawTaggedField>>("unknownTaggedFields"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.DescribableLogDirTopic.html#elementKeysAreEqual(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool ElementKeysAreEqual(object arg0)
            {
                return IExecute<bool>("elementKeysAreEqual", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.DescribableLogDirTopic.html#setPartitions(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Common.Message.DescribeLogDirsRequestData.DescribableLogDirTopic"/></returns>
            public Org.Apache.Kafka.Common.Message.DescribeLogDirsRequestData.DescribableLogDirTopic SetPartitions(Java.Util.List<int?> arg0)
            {
                return IExecute<Org.Apache.Kafka.Common.Message.DescribeLogDirsRequestData.DescribableLogDirTopic>("setPartitions", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.DescribableLogDirTopic.html#setTopic(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Common.Message.DescribeLogDirsRequestData.DescribableLogDirTopic"/></returns>
            public Org.Apache.Kafka.Common.Message.DescribeLogDirsRequestData.DescribableLogDirTopic SetTopic(string arg0)
            {
                return IExecute<Org.Apache.Kafka.Common.Message.DescribeLogDirsRequestData.DescribableLogDirTopic>("setTopic", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.DescribableLogDirTopic.html#addSize(org.apache.kafka.common.protocol.MessageSizeAccumulator,org.apache.kafka.common.protocol.ObjectSerializationCache,short)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Protocol.MessageSizeAccumulator"/></param>
            /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Protocol.ObjectSerializationCache"/></param>
            /// <param name="arg2"><see cref="short"/></param>
            public void AddSize(Org.Apache.Kafka.Common.Protocol.MessageSizeAccumulator arg0, Org.Apache.Kafka.Common.Protocol.ObjectSerializationCache arg1, short arg2)
            {
                IExecute("addSize", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.DescribableLogDirTopic.html#read(org.apache.kafka.common.protocol.Readable,short)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Protocol.Readable"/></param>
            /// <param name="arg1"><see cref="short"/></param>
            public void Read(Org.Apache.Kafka.Common.Protocol.Readable arg0, short arg1)
            {
                IExecute("read", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.DescribableLogDirTopic.html#setNext(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public void SetNext(int arg0)
            {
                IExecute("setNext", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.DescribableLogDirTopic.html#setPrev(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public void SetPrev(int arg0)
            {
                IExecute("setPrev", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.DescribableLogDirTopic.html#write(org.apache.kafka.common.protocol.Writable,org.apache.kafka.common.protocol.ObjectSerializationCache,short)"/>
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

        #region DescribableLogDirTopicCollection
        public partial class DescribableLogDirTopicCollection
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.DescribableLogDirTopicCollection.html#%3Cinit%3E(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public DescribableLogDirTopicCollection(int arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.DescribableLogDirTopicCollection.html#%3Cinit%3E(java.util.Iterator)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Iterator"/></param>
            public DescribableLogDirTopicCollection(Java.Util.Iterator arg0)
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
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.DescribableLogDirTopicCollection.html#duplicate()"/> 
            /// </summary>
            public Org.Apache.Kafka.Common.Message.DescribeLogDirsRequestData.DescribableLogDirTopicCollection Duplicate
            {
                get { return IExecute<Org.Apache.Kafka.Common.Message.DescribeLogDirsRequestData.DescribableLogDirTopicCollection>("duplicate"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.DescribableLogDirTopicCollection.html#findAll(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Java.Util.List"/></returns>
            public Java.Util.List<Org.Apache.Kafka.Common.Message.DescribeLogDirsRequestData.DescribableLogDirTopic> FindAll(string arg0)
            {
                return IExecute<Java.Util.List<Org.Apache.Kafka.Common.Message.DescribeLogDirsRequestData.DescribableLogDirTopic>>("findAll", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/DescribeLogDirsRequestData.DescribableLogDirTopicCollection.html#find(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Common.Message.DescribeLogDirsRequestData.DescribableLogDirTopic"/></returns>
            public Org.Apache.Kafka.Common.Message.DescribeLogDirsRequestData.DescribableLogDirTopic Find(string arg0)
            {
                return IExecute<Org.Apache.Kafka.Common.Message.DescribeLogDirsRequestData.DescribableLogDirTopic>("find", arg0);
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