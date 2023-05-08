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
*  using kafka_2.13-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Kafka.Message
{
    #region BrokerCompressionCodec
    public partial class BrokerCompressionCodec
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/message/BrokerCompressionCodec.html#isValid(java.lang.String)"/>
        /// </summary>
        /// <param name="compressionType"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsValid(string compressionType)
        {
            return SExecute<bool>(LocalBridgeClazz, "isValid", compressionType);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/message/BrokerCompressionCodec.html#getCompressionCodec(java.lang.String)"/>
        /// </summary>
        /// <param name="compressionType"><see cref="string"/></param>
        /// <returns><see cref="Kafka.Message.CompressionCodec"/></returns>
        public static Kafka.Message.CompressionCodec GetCompressionCodec(string compressionType)
        {
            return SExecute<Kafka.Message.CompressionCodec>(LocalBridgeClazz, "getCompressionCodec", compressionType);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/message/BrokerCompressionCodec.html#getTargetCompressionCodec(java.lang.String,kafka.message.CompressionCodec)"/>
        /// </summary>
        /// <param name="compressionType"><see cref="string"/></param>
        /// <param name="producerCompression"><see cref="Kafka.Message.CompressionCodec"/></param>
        /// <returns><see cref="Kafka.Message.CompressionCodec"/></returns>
        public static Kafka.Message.CompressionCodec GetTargetCompressionCodec(string compressionType, Kafka.Message.CompressionCodec producerCompression)
        {
            return SExecute<Kafka.Message.CompressionCodec>(LocalBridgeClazz, "getTargetCompressionCodec", compressionType, producerCompression);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/message/BrokerCompressionCodec.html#name()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("name"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}