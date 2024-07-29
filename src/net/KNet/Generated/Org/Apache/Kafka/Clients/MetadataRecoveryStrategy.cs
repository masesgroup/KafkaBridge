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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using kafka-clients-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients
{
    #region MetadataRecoveryStrategy
    public partial class MetadataRecoveryStrategy
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/MetadataRecoveryStrategy.html#name"/>
        /// </summary>
        public Java.Lang.String name { get { if (!_nameReady) { _nameContent = IGetField<Java.Lang.String>("name"); _nameReady = true; } return _nameContent; } }
        private Java.Lang.String _nameContent = default;
        private bool _nameReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/MetadataRecoveryStrategy.html#NONE"/>
        /// </summary>
        public static Org.Apache.Kafka.Clients.MetadataRecoveryStrategy NONE { get { if (!_NONEReady) { _NONEContent = SGetField<Org.Apache.Kafka.Clients.MetadataRecoveryStrategy>(LocalBridgeClazz, "NONE"); _NONEReady = true; } return _NONEContent; } }
        private static Org.Apache.Kafka.Clients.MetadataRecoveryStrategy _NONEContent = default;
        private static bool _NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/MetadataRecoveryStrategy.html#REBOOTSTRAP"/>
        /// </summary>
        public static Org.Apache.Kafka.Clients.MetadataRecoveryStrategy REBOOTSTRAP { get { if (!_REBOOTSTRAPReady) { _REBOOTSTRAPContent = SGetField<Org.Apache.Kafka.Clients.MetadataRecoveryStrategy>(LocalBridgeClazz, "REBOOTSTRAP"); _REBOOTSTRAPReady = true; } return _REBOOTSTRAPContent; } }
        private static Org.Apache.Kafka.Clients.MetadataRecoveryStrategy _REBOOTSTRAPContent = default;
        private static bool _REBOOTSTRAPReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/MetadataRecoveryStrategy.html#forName-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.MetadataRecoveryStrategy"/></returns>
        public static Org.Apache.Kafka.Clients.MetadataRecoveryStrategy ForName(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Clients.MetadataRecoveryStrategy>(LocalBridgeClazz, "forName", "(Ljava/lang/String;)Lorg/apache/kafka/clients/MetadataRecoveryStrategy;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/MetadataRecoveryStrategy.html#valueOf-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.MetadataRecoveryStrategy"/></returns>
        public static Org.Apache.Kafka.Clients.MetadataRecoveryStrategy ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Clients.MetadataRecoveryStrategy>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/clients/MetadataRecoveryStrategy;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/MetadataRecoveryStrategy.html#values--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Clients.MetadataRecoveryStrategy"/></returns>
        public static Org.Apache.Kafka.Clients.MetadataRecoveryStrategy[] Values()
        {
            return SExecuteWithSignatureArray<Org.Apache.Kafka.Clients.MetadataRecoveryStrategy>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/clients/MetadataRecoveryStrategy;");
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