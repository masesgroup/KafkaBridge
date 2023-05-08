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
    #region BrokerRegistrationRequestData
    public partial class BrokerRegistrationRequestData
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.html#%3Cinit%3E(org.apache.kafka.common.protocol.Readable,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Protocol.Readable"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        public BrokerRegistrationRequestData(Org.Apache.Kafka.Common.Protocol.Readable arg0, short arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData"/> to <see cref="Org.Apache.Kafka.Common.Protocol.ApiMessage"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Protocol.ApiMessage(Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData t) => t.Cast<Org.Apache.Kafka.Common.Protocol.ApiMessage>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.html#SCHEMA_0"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Protocol.Types.Schema SCHEMA_0 { get { return SGetField<Org.Apache.Kafka.Common.Protocol.Types.Schema>(LocalBridgeClazz, "SCHEMA_0"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.html#SCHEMA_1"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Protocol.Types.Schema SCHEMA_1 { get { return SGetField<Org.Apache.Kafka.Common.Protocol.Types.Schema>(LocalBridgeClazz, "SCHEMA_1"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.html#SCHEMAS"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Protocol.Types.Schema[] SCHEMAS { get { return SGetFieldArray<Org.Apache.Kafka.Common.Protocol.Types.Schema>(LocalBridgeClazz, "SCHEMAS"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.html#HIGHEST_SUPPORTED_VERSION"/>
        /// </summary>
        public static short HIGHEST_SUPPORTED_VERSION { get { return SGetField<short>(LocalBridgeClazz, "HIGHEST_SUPPORTED_VERSION"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.html#LOWEST_SUPPORTED_VERSION"/>
        /// </summary>
        public static short LOWEST_SUPPORTED_VERSION { get { return SGetField<short>(LocalBridgeClazz, "LOWEST_SUPPORTED_VERSION"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.html#apiKey()"/> 
        /// </summary>
        public short ApiKey
        {
            get { return IExecute<short>("apiKey"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.html#brokerId()"/> 
        /// </summary>
        public int BrokerId
        {
            get { return IExecute<int>("brokerId"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.html#clusterId()"/> 
        /// </summary>
        public string ClusterId
        {
            get { return IExecute<string>("clusterId"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.html#duplicate()"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.Protocol.Message Duplicate
        {
            get { return IExecute<Org.Apache.Kafka.Common.Protocol.Message>("duplicate"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.html#features()"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData.FeatureCollection Features
        {
            get { return IExecute<Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData.FeatureCollection>("features"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.html#highestSupportedVersion()"/> 
        /// </summary>
        public short HighestSupportedVersion
        {
            get { return IExecute<short>("highestSupportedVersion"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.html#incarnationId()"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.Uuid IncarnationId
        {
            get { return IExecute<Org.Apache.Kafka.Common.Uuid>("incarnationId"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.html#isMigratingZkBroker()"/> 
        /// </summary>
        public bool IsMigratingZkBroker
        {
            get { return IExecute<bool>("isMigratingZkBroker"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.html#listeners()"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData.ListenerCollection Listeners
        {
            get { return IExecute<Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData.ListenerCollection>("listeners"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.html#lowestSupportedVersion()"/> 
        /// </summary>
        public short LowestSupportedVersion
        {
            get { return IExecute<short>("lowestSupportedVersion"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.html#rack()"/> 
        /// </summary>
        public string Rack
        {
            get { return IExecute<string>("rack"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.html#unknownTaggedFields()"/> 
        /// </summary>
        public Java.Util.List<Org.Apache.Kafka.Common.Protocol.Types.RawTaggedField> UnknownTaggedFields
        {
            get { return IExecute<Java.Util.List<Org.Apache.Kafka.Common.Protocol.Types.RawTaggedField>>("unknownTaggedFields"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.html#setBrokerId(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData"/></returns>
        public Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData SetBrokerId(int arg0)
        {
            return IExecute<Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData>("setBrokerId", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.html#setClusterId(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData"/></returns>
        public Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData SetClusterId(string arg0)
        {
            return IExecute<Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData>("setClusterId", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.html#setFeatures(org.apache.kafka.common.message.BrokerRegistrationRequestData.FeatureCollection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData.FeatureCollection"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData"/></returns>
        public Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData SetFeatures(Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData.FeatureCollection arg0)
        {
            return IExecute<Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData>("setFeatures", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.html#setIncarnationId(org.apache.kafka.common.Uuid)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Uuid"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData"/></returns>
        public Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData SetIncarnationId(Org.Apache.Kafka.Common.Uuid arg0)
        {
            return IExecute<Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData>("setIncarnationId", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.html#setIsMigratingZkBroker(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData"/></returns>
        public Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData SetIsMigratingZkBroker(bool arg0)
        {
            return IExecute<Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData>("setIsMigratingZkBroker", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.html#setListeners(org.apache.kafka.common.message.BrokerRegistrationRequestData.ListenerCollection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData.ListenerCollection"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData"/></returns>
        public Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData SetListeners(Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData.ListenerCollection arg0)
        {
            return IExecute<Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData>("setListeners", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.html#setRack(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData"/></returns>
        public Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData SetRack(string arg0)
        {
            return IExecute<Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData>("setRack", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.html#addSize(org.apache.kafka.common.protocol.MessageSizeAccumulator,org.apache.kafka.common.protocol.ObjectSerializationCache,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Protocol.MessageSizeAccumulator"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Protocol.ObjectSerializationCache"/></param>
        /// <param name="arg2"><see cref="short"/></param>
        public void AddSize(Org.Apache.Kafka.Common.Protocol.MessageSizeAccumulator arg0, Org.Apache.Kafka.Common.Protocol.ObjectSerializationCache arg1, short arg2)
        {
            IExecute("addSize", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.html#read(org.apache.kafka.common.protocol.Readable,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Protocol.Readable"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        public void Read(Org.Apache.Kafka.Common.Protocol.Readable arg0, short arg1)
        {
            IExecute("read", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.html#write(org.apache.kafka.common.protocol.Writable,org.apache.kafka.common.protocol.ObjectSerializationCache,short)"/>
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
        #region Feature
        public partial class Feature
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.Feature.html#%3Cinit%3E(org.apache.kafka.common.protocol.Readable,short)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Protocol.Readable"/></param>
            /// <param name="arg1"><see cref="short"/></param>
            public Feature(Org.Apache.Kafka.Common.Protocol.Readable arg0, short arg1)
                : base(arg0, arg1)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData.Feature"/> to <see cref="Org.Apache.Kafka.Common.Protocol.Message"/>
            /// </summary>
            public static implicit operator Org.Apache.Kafka.Common.Protocol.Message(Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData.Feature t) => t.Cast<Org.Apache.Kafka.Common.Protocol.Message>();

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.Feature.html#SCHEMA_0"/>
            /// </summary>
            public static Org.Apache.Kafka.Common.Protocol.Types.Schema SCHEMA_0 { get { return SGetField<Org.Apache.Kafka.Common.Protocol.Types.Schema>(LocalBridgeClazz, "SCHEMA_0"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.Feature.html#SCHEMA_1"/>
            /// </summary>
            public static Org.Apache.Kafka.Common.Protocol.Types.Schema SCHEMA_1 { get { return SGetField<Org.Apache.Kafka.Common.Protocol.Types.Schema>(LocalBridgeClazz, "SCHEMA_1"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.Feature.html#SCHEMAS"/>
            /// </summary>
            public static Org.Apache.Kafka.Common.Protocol.Types.Schema[] SCHEMAS { get { return SGetFieldArray<Org.Apache.Kafka.Common.Protocol.Types.Schema>(LocalBridgeClazz, "SCHEMAS"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.Feature.html#HIGHEST_SUPPORTED_VERSION"/>
            /// </summary>
            public static short HIGHEST_SUPPORTED_VERSION { get { return SGetField<short>(LocalBridgeClazz, "HIGHEST_SUPPORTED_VERSION"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.Feature.html#LOWEST_SUPPORTED_VERSION"/>
            /// </summary>
            public static short LOWEST_SUPPORTED_VERSION { get { return SGetField<short>(LocalBridgeClazz, "LOWEST_SUPPORTED_VERSION"); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.Feature.html#duplicate()"/> 
            /// </summary>
            public Org.Apache.Kafka.Common.Protocol.Message Duplicate
            {
                get { return IExecute<Org.Apache.Kafka.Common.Protocol.Message>("duplicate"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.Feature.html#highestSupportedVersion()"/> 
            /// </summary>
            public short HighestSupportedVersion
            {
                get { return IExecute<short>("highestSupportedVersion"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.Feature.html#lowestSupportedVersion()"/> 
            /// </summary>
            public short LowestSupportedVersion
            {
                get { return IExecute<short>("lowestSupportedVersion"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.Feature.html#maxSupportedVersion()"/> 
            /// </summary>
            public short MaxSupportedVersion
            {
                get { return IExecute<short>("maxSupportedVersion"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.Feature.html#minSupportedVersion()"/> 
            /// </summary>
            public short MinSupportedVersion
            {
                get { return IExecute<short>("minSupportedVersion"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.Feature.html#name()"/> 
            /// </summary>
            public string Name
            {
                get { return IExecute<string>("name"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.Feature.html#next()"/> 
            /// </summary>
            public int Next
            {
                get { return IExecute<int>("next"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.Feature.html#prev()"/> 
            /// </summary>
            public int Prev
            {
                get { return IExecute<int>("prev"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.Feature.html#unknownTaggedFields()"/> 
            /// </summary>
            public Java.Util.List<Org.Apache.Kafka.Common.Protocol.Types.RawTaggedField> UnknownTaggedFields
            {
                get { return IExecute<Java.Util.List<Org.Apache.Kafka.Common.Protocol.Types.RawTaggedField>>("unknownTaggedFields"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.Feature.html#elementKeysAreEqual(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool ElementKeysAreEqual(object arg0)
            {
                return IExecute<bool>("elementKeysAreEqual", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.Feature.html#setMaxSupportedVersion(short)"/>
            /// </summary>
            /// <param name="arg0"><see cref="short"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData.Feature"/></returns>
            public Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData.Feature SetMaxSupportedVersion(short arg0)
            {
                return IExecute<Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData.Feature>("setMaxSupportedVersion", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.Feature.html#setMinSupportedVersion(short)"/>
            /// </summary>
            /// <param name="arg0"><see cref="short"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData.Feature"/></returns>
            public Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData.Feature SetMinSupportedVersion(short arg0)
            {
                return IExecute<Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData.Feature>("setMinSupportedVersion", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.Feature.html#setName(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData.Feature"/></returns>
            public Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData.Feature SetName(string arg0)
            {
                return IExecute<Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData.Feature>("setName", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.Feature.html#addSize(org.apache.kafka.common.protocol.MessageSizeAccumulator,org.apache.kafka.common.protocol.ObjectSerializationCache,short)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Protocol.MessageSizeAccumulator"/></param>
            /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Protocol.ObjectSerializationCache"/></param>
            /// <param name="arg2"><see cref="short"/></param>
            public void AddSize(Org.Apache.Kafka.Common.Protocol.MessageSizeAccumulator arg0, Org.Apache.Kafka.Common.Protocol.ObjectSerializationCache arg1, short arg2)
            {
                IExecute("addSize", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.Feature.html#read(org.apache.kafka.common.protocol.Readable,short)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Protocol.Readable"/></param>
            /// <param name="arg1"><see cref="short"/></param>
            public void Read(Org.Apache.Kafka.Common.Protocol.Readable arg0, short arg1)
            {
                IExecute("read", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.Feature.html#setNext(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public void SetNext(int arg0)
            {
                IExecute("setNext", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.Feature.html#setPrev(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public void SetPrev(int arg0)
            {
                IExecute("setPrev", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.Feature.html#write(org.apache.kafka.common.protocol.Writable,org.apache.kafka.common.protocol.ObjectSerializationCache,short)"/>
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

        #region FeatureCollection
        public partial class FeatureCollection
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.FeatureCollection.html#%3Cinit%3E(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public FeatureCollection(int arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.FeatureCollection.html#%3Cinit%3E(java.util.Iterator)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Iterator"/></param>
            public FeatureCollection(Java.Util.Iterator arg0)
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
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.FeatureCollection.html#duplicate()"/> 
            /// </summary>
            public Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData.FeatureCollection Duplicate
            {
                get { return IExecute<Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData.FeatureCollection>("duplicate"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.FeatureCollection.html#findAll(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Java.Util.List"/></returns>
            public Java.Util.List<Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData.Feature> FindAll(string arg0)
            {
                return IExecute<Java.Util.List<Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData.Feature>>("findAll", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.FeatureCollection.html#find(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData.Feature"/></returns>
            public Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData.Feature Find(string arg0)
            {
                return IExecute<Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData.Feature>("find", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ListenerCollection
        public partial class ListenerCollection
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.ListenerCollection.html#%3Cinit%3E(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public ListenerCollection(int arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.ListenerCollection.html#%3Cinit%3E(java.util.Iterator)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Iterator"/></param>
            public ListenerCollection(Java.Util.Iterator arg0)
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
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.ListenerCollection.html#duplicate()"/> 
            /// </summary>
            public Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData.ListenerCollection Duplicate
            {
                get { return IExecute<Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData.ListenerCollection>("duplicate"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.ListenerCollection.html#findAll(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Java.Util.List"/></returns>
            public Java.Util.List<Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData.Listener> FindAll(string arg0)
            {
                return IExecute<Java.Util.List<Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData.Listener>>("findAll", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/message/BrokerRegistrationRequestData.ListenerCollection.html#find(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData.Listener"/></returns>
            public Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData.Listener Find(string arg0)
            {
                return IExecute<Org.Apache.Kafka.Common.Message.BrokerRegistrationRequestData.Listener>("find", arg0);
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