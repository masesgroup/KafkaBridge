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
    #region ConsumerProtocolSubscription
    public partial class ConsumerProtocolSubscription
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.html#%3Cinit%3E(org.apache.kafka.common.protocol.Readable,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Protocol.Readable"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        public ConsumerProtocolSubscription(Org.Apache.Kafka.Common.Protocol.Readable arg0, short arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Common.Message.ConsumerProtocolSubscription"/> to <see cref="Org.Apache.Kafka.Common.Protocol.ApiMessage"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Protocol.ApiMessage(Org.Apache.Kafka.Common.Message.ConsumerProtocolSubscription t) => t.Cast<Org.Apache.Kafka.Common.Protocol.ApiMessage>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.html#SCHEMA_0"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Protocol.Types.Schema SCHEMA_0 { get { return SGetField<Org.Apache.Kafka.Common.Protocol.Types.Schema>(LocalBridgeClazz, "SCHEMA_0"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.html#SCHEMA_1"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Protocol.Types.Schema SCHEMA_1 { get { return SGetField<Org.Apache.Kafka.Common.Protocol.Types.Schema>(LocalBridgeClazz, "SCHEMA_1"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.html#SCHEMA_2"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Protocol.Types.Schema SCHEMA_2 { get { return SGetField<Org.Apache.Kafka.Common.Protocol.Types.Schema>(LocalBridgeClazz, "SCHEMA_2"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.html#SCHEMA_3"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Protocol.Types.Schema SCHEMA_3 { get { return SGetField<Org.Apache.Kafka.Common.Protocol.Types.Schema>(LocalBridgeClazz, "SCHEMA_3"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.html#SCHEMAS"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Protocol.Types.Schema[] SCHEMAS { get { return SGetFieldArray<Org.Apache.Kafka.Common.Protocol.Types.Schema>(LocalBridgeClazz, "SCHEMAS"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.html#HIGHEST_SUPPORTED_VERSION"/>
        /// </summary>
        public static short HIGHEST_SUPPORTED_VERSION { get { return SGetField<short>(LocalBridgeClazz, "HIGHEST_SUPPORTED_VERSION"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.html#LOWEST_SUPPORTED_VERSION"/>
        /// </summary>
        public static short LOWEST_SUPPORTED_VERSION { get { return SGetField<short>(LocalBridgeClazz, "LOWEST_SUPPORTED_VERSION"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.html#apiKey()"/> 
        /// </summary>
        public short ApiKey
        {
            get { return IExecute<short>("apiKey"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.html#duplicate()"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.Protocol.Message Duplicate
        {
            get { return IExecute<Org.Apache.Kafka.Common.Protocol.Message>("duplicate"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.html#generationId()"/> 
        /// </summary>
        public int GenerationId
        {
            get { return IExecute<int>("generationId"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.html#highestSupportedVersion()"/> 
        /// </summary>
        public short HighestSupportedVersion
        {
            get { return IExecute<short>("highestSupportedVersion"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.html#lowestSupportedVersion()"/> 
        /// </summary>
        public short LowestSupportedVersion
        {
            get { return IExecute<short>("lowestSupportedVersion"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.html#ownedPartitions()"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.Message.ConsumerProtocolSubscription.TopicPartitionCollection OwnedPartitions
        {
            get { return IExecute<Org.Apache.Kafka.Common.Message.ConsumerProtocolSubscription.TopicPartitionCollection>("ownedPartitions"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.html#rackId()"/> 
        /// </summary>
        public string RackId
        {
            get { return IExecute<string>("rackId"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.html#topics()"/> 
        /// </summary>
        public Java.Util.List<string> Topics
        {
            get { return IExecute<Java.Util.List<string>>("topics"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.html#unknownTaggedFields()"/> 
        /// </summary>
        public Java.Util.List<Org.Apache.Kafka.Common.Protocol.Types.RawTaggedField> UnknownTaggedFields
        {
            get { return IExecute<Java.Util.List<Org.Apache.Kafka.Common.Protocol.Types.RawTaggedField>>("unknownTaggedFields"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.html#userData()"/> 
        /// </summary>
        public Java.Nio.ByteBuffer UserData
        {
            get { return IExecute<Java.Nio.ByteBuffer>("userData"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.html#setGenerationId(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Message.ConsumerProtocolSubscription"/></returns>
        public Org.Apache.Kafka.Common.Message.ConsumerProtocolSubscription SetGenerationId(int arg0)
        {
            return IExecute<Org.Apache.Kafka.Common.Message.ConsumerProtocolSubscription>("setGenerationId", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.html#setOwnedPartitions(org.apache.kafka.common.message.ConsumerProtocolSubscription.TopicPartitionCollection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Message.ConsumerProtocolSubscription.TopicPartitionCollection"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Message.ConsumerProtocolSubscription"/></returns>
        public Org.Apache.Kafka.Common.Message.ConsumerProtocolSubscription SetOwnedPartitions(Org.Apache.Kafka.Common.Message.ConsumerProtocolSubscription.TopicPartitionCollection arg0)
        {
            return IExecute<Org.Apache.Kafka.Common.Message.ConsumerProtocolSubscription>("setOwnedPartitions", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.html#setRackId(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Message.ConsumerProtocolSubscription"/></returns>
        public Org.Apache.Kafka.Common.Message.ConsumerProtocolSubscription SetRackId(string arg0)
        {
            return IExecute<Org.Apache.Kafka.Common.Message.ConsumerProtocolSubscription>("setRackId", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.html#setTopics(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Message.ConsumerProtocolSubscription"/></returns>
        public Org.Apache.Kafka.Common.Message.ConsumerProtocolSubscription SetTopics(Java.Util.List<string> arg0)
        {
            return IExecute<Org.Apache.Kafka.Common.Message.ConsumerProtocolSubscription>("setTopics", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.html#setUserData(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Message.ConsumerProtocolSubscription"/></returns>
        public Org.Apache.Kafka.Common.Message.ConsumerProtocolSubscription SetUserData(Java.Nio.ByteBuffer arg0)
        {
            return IExecute<Org.Apache.Kafka.Common.Message.ConsumerProtocolSubscription>("setUserData", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.html#addSize(org.apache.kafka.common.protocol.MessageSizeAccumulator,org.apache.kafka.common.protocol.ObjectSerializationCache,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Protocol.MessageSizeAccumulator"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Protocol.ObjectSerializationCache"/></param>
        /// <param name="arg2"><see cref="short"/></param>
        public void AddSize(Org.Apache.Kafka.Common.Protocol.MessageSizeAccumulator arg0, Org.Apache.Kafka.Common.Protocol.ObjectSerializationCache arg1, short arg2)
        {
            IExecute("addSize", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.html#read(org.apache.kafka.common.protocol.Readable,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Protocol.Readable"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        public void Read(Org.Apache.Kafka.Common.Protocol.Readable arg0, short arg1)
        {
            IExecute("read", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.html#write(org.apache.kafka.common.protocol.Writable,org.apache.kafka.common.protocol.ObjectSerializationCache,short)"/>
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
        #region TopicPartition
        public partial class TopicPartition
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.TopicPartition.html#%3Cinit%3E(org.apache.kafka.common.protocol.Readable,short)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Protocol.Readable"/></param>
            /// <param name="arg1"><see cref="short"/></param>
            public TopicPartition(Org.Apache.Kafka.Common.Protocol.Readable arg0, short arg1)
                : base(arg0, arg1)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Org.Apache.Kafka.Common.Message.ConsumerProtocolSubscription.TopicPartition"/> to <see cref="Org.Apache.Kafka.Common.Protocol.Message"/>
            /// </summary>
            public static implicit operator Org.Apache.Kafka.Common.Protocol.Message(Org.Apache.Kafka.Common.Message.ConsumerProtocolSubscription.TopicPartition t) => t.Cast<Org.Apache.Kafka.Common.Protocol.Message>();

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.TopicPartition.html#SCHEMA_1"/>
            /// </summary>
            public static Org.Apache.Kafka.Common.Protocol.Types.Schema SCHEMA_1 { get { return SGetField<Org.Apache.Kafka.Common.Protocol.Types.Schema>(LocalBridgeClazz, "SCHEMA_1"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.TopicPartition.html#SCHEMA_2"/>
            /// </summary>
            public static Org.Apache.Kafka.Common.Protocol.Types.Schema SCHEMA_2 { get { return SGetField<Org.Apache.Kafka.Common.Protocol.Types.Schema>(LocalBridgeClazz, "SCHEMA_2"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.TopicPartition.html#SCHEMA_3"/>
            /// </summary>
            public static Org.Apache.Kafka.Common.Protocol.Types.Schema SCHEMA_3 { get { return SGetField<Org.Apache.Kafka.Common.Protocol.Types.Schema>(LocalBridgeClazz, "SCHEMA_3"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.TopicPartition.html#SCHEMAS"/>
            /// </summary>
            public static Org.Apache.Kafka.Common.Protocol.Types.Schema[] SCHEMAS { get { return SGetFieldArray<Org.Apache.Kafka.Common.Protocol.Types.Schema>(LocalBridgeClazz, "SCHEMAS"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.TopicPartition.html#HIGHEST_SUPPORTED_VERSION"/>
            /// </summary>
            public static short HIGHEST_SUPPORTED_VERSION { get { return SGetField<short>(LocalBridgeClazz, "HIGHEST_SUPPORTED_VERSION"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.TopicPartition.html#LOWEST_SUPPORTED_VERSION"/>
            /// </summary>
            public static short LOWEST_SUPPORTED_VERSION { get { return SGetField<short>(LocalBridgeClazz, "LOWEST_SUPPORTED_VERSION"); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.TopicPartition.html#duplicate()"/> 
            /// </summary>
            public Org.Apache.Kafka.Common.Protocol.Message Duplicate
            {
                get { return IExecute<Org.Apache.Kafka.Common.Protocol.Message>("duplicate"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.TopicPartition.html#highestSupportedVersion()"/> 
            /// </summary>
            public short HighestSupportedVersion
            {
                get { return IExecute<short>("highestSupportedVersion"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.TopicPartition.html#lowestSupportedVersion()"/> 
            /// </summary>
            public short LowestSupportedVersion
            {
                get { return IExecute<short>("lowestSupportedVersion"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.TopicPartition.html#next()"/> 
            /// </summary>
            public int Next
            {
                get { return IExecute<int>("next"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.TopicPartition.html#partitions()"/> 
            /// </summary>
            public Java.Util.List<int?> Partitions
            {
                get { return IExecute<Java.Util.List<int?>>("partitions"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.TopicPartition.html#prev()"/> 
            /// </summary>
            public int Prev
            {
                get { return IExecute<int>("prev"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.TopicPartition.html#topic()"/> 
            /// </summary>
            public string Topic
            {
                get { return IExecute<string>("topic"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.TopicPartition.html#unknownTaggedFields()"/> 
            /// </summary>
            public Java.Util.List<Org.Apache.Kafka.Common.Protocol.Types.RawTaggedField> UnknownTaggedFields
            {
                get { return IExecute<Java.Util.List<Org.Apache.Kafka.Common.Protocol.Types.RawTaggedField>>("unknownTaggedFields"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.TopicPartition.html#elementKeysAreEqual(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool ElementKeysAreEqual(object arg0)
            {
                return IExecute<bool>("elementKeysAreEqual", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.TopicPartition.html#setPartitions(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Common.Message.ConsumerProtocolSubscription.TopicPartition"/></returns>
            public Org.Apache.Kafka.Common.Message.ConsumerProtocolSubscription.TopicPartition SetPartitions(Java.Util.List<int?> arg0)
            {
                return IExecute<Org.Apache.Kafka.Common.Message.ConsumerProtocolSubscription.TopicPartition>("setPartitions", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.TopicPartition.html#setTopic(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Common.Message.ConsumerProtocolSubscription.TopicPartition"/></returns>
            public Org.Apache.Kafka.Common.Message.ConsumerProtocolSubscription.TopicPartition SetTopic(string arg0)
            {
                return IExecute<Org.Apache.Kafka.Common.Message.ConsumerProtocolSubscription.TopicPartition>("setTopic", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.TopicPartition.html#addSize(org.apache.kafka.common.protocol.MessageSizeAccumulator,org.apache.kafka.common.protocol.ObjectSerializationCache,short)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Protocol.MessageSizeAccumulator"/></param>
            /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Protocol.ObjectSerializationCache"/></param>
            /// <param name="arg2"><see cref="short"/></param>
            public void AddSize(Org.Apache.Kafka.Common.Protocol.MessageSizeAccumulator arg0, Org.Apache.Kafka.Common.Protocol.ObjectSerializationCache arg1, short arg2)
            {
                IExecute("addSize", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.TopicPartition.html#read(org.apache.kafka.common.protocol.Readable,short)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Protocol.Readable"/></param>
            /// <param name="arg1"><see cref="short"/></param>
            public void Read(Org.Apache.Kafka.Common.Protocol.Readable arg0, short arg1)
            {
                IExecute("read", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.TopicPartition.html#setNext(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public void SetNext(int arg0)
            {
                IExecute("setNext", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.TopicPartition.html#setPrev(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public void SetPrev(int arg0)
            {
                IExecute("setPrev", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.TopicPartition.html#write(org.apache.kafka.common.protocol.Writable,org.apache.kafka.common.protocol.ObjectSerializationCache,short)"/>
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

        #region TopicPartitionCollection
        public partial class TopicPartitionCollection
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.TopicPartitionCollection.html#%3Cinit%3E(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public TopicPartitionCollection(int arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.TopicPartitionCollection.html#%3Cinit%3E(java.util.Iterator)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Iterator"/></param>
            public TopicPartitionCollection(Java.Util.Iterator arg0)
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
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.TopicPartitionCollection.html#duplicate()"/> 
            /// </summary>
            public Org.Apache.Kafka.Common.Message.ConsumerProtocolSubscription.TopicPartitionCollection Duplicate
            {
                get { return IExecute<Org.Apache.Kafka.Common.Message.ConsumerProtocolSubscription.TopicPartitionCollection>("duplicate"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.TopicPartitionCollection.html#findAll(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Java.Util.List"/></returns>
            public Java.Util.List<Org.Apache.Kafka.Common.Message.ConsumerProtocolSubscription.TopicPartition> FindAll(string arg0)
            {
                return IExecute<Java.Util.List<Org.Apache.Kafka.Common.Message.ConsumerProtocolSubscription.TopicPartition>>("findAll", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/ConsumerProtocolSubscription.TopicPartitionCollection.html#find(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Common.Message.ConsumerProtocolSubscription.TopicPartition"/></returns>
            public Org.Apache.Kafka.Common.Message.ConsumerProtocolSubscription.TopicPartition Find(string arg0)
            {
                return IExecute<Org.Apache.Kafka.Common.Message.ConsumerProtocolSubscription.TopicPartition>("find", arg0);
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