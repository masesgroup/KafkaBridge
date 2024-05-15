/*
*  Copyright 2024 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*  using kafka-clients-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Consumer
{
    #region OffsetResetStrategy
    public partial class OffsetResetStrategy
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/consumer/OffsetResetStrategy.html#EARLIEST"/>
        /// </summary>
        public static Org.Apache.Kafka.Clients.Consumer.OffsetResetStrategy EARLIEST { get { if (!_EARLIESTReady) { _EARLIESTContent = SGetField<Org.Apache.Kafka.Clients.Consumer.OffsetResetStrategy>(LocalBridgeClazz, "EARLIEST"); _EARLIESTReady = true; } return _EARLIESTContent; } }
        private static Org.Apache.Kafka.Clients.Consumer.OffsetResetStrategy _EARLIESTContent = default;
        private static bool _EARLIESTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/consumer/OffsetResetStrategy.html#LATEST"/>
        /// </summary>
        public static Org.Apache.Kafka.Clients.Consumer.OffsetResetStrategy LATEST { get { if (!_LATESTReady) { _LATESTContent = SGetField<Org.Apache.Kafka.Clients.Consumer.OffsetResetStrategy>(LocalBridgeClazz, "LATEST"); _LATESTReady = true; } return _LATESTContent; } }
        private static Org.Apache.Kafka.Clients.Consumer.OffsetResetStrategy _LATESTContent = default;
        private static bool _LATESTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/consumer/OffsetResetStrategy.html#NONE"/>
        /// </summary>
        public static Org.Apache.Kafka.Clients.Consumer.OffsetResetStrategy NONE { get { if (!_NONEReady) { _NONEContent = SGetField<Org.Apache.Kafka.Clients.Consumer.OffsetResetStrategy>(LocalBridgeClazz, "NONE"); _NONEReady = true; } return _NONEContent; } }
        private static Org.Apache.Kafka.Clients.Consumer.OffsetResetStrategy _NONEContent = default;
        private static bool _NONEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/consumer/OffsetResetStrategy.html#valueOf-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Consumer.OffsetResetStrategy"/></returns>
        public static Org.Apache.Kafka.Clients.Consumer.OffsetResetStrategy ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Clients.Consumer.OffsetResetStrategy>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/clients/consumer/OffsetResetStrategy;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/consumer/OffsetResetStrategy.html#values--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Clients.Consumer.OffsetResetStrategy"/></returns>
        public static Org.Apache.Kafka.Clients.Consumer.OffsetResetStrategy[] Values()
        {
            return SExecuteWithSignatureArray<Org.Apache.Kafka.Clients.Consumer.OffsetResetStrategy>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/clients/consumer/OffsetResetStrategy;");
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}