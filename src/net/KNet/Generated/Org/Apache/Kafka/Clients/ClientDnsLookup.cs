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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using kafka-clients-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients
{
    #region ClientDnsLookup
    public partial class ClientDnsLookup
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/ClientDnsLookup.html#RESOLVE_CANONICAL_BOOTSTRAP_SERVERS_ONLY"/>
        /// </summary>
        public static Org.Apache.Kafka.Clients.ClientDnsLookup RESOLVE_CANONICAL_BOOTSTRAP_SERVERS_ONLY { get { if (!_RESOLVE_CANONICAL_BOOTSTRAP_SERVERS_ONLYReady) { _RESOLVE_CANONICAL_BOOTSTRAP_SERVERS_ONLYContent = SGetField<Org.Apache.Kafka.Clients.ClientDnsLookup>(LocalBridgeClazz, "RESOLVE_CANONICAL_BOOTSTRAP_SERVERS_ONLY"); _RESOLVE_CANONICAL_BOOTSTRAP_SERVERS_ONLYReady = true; } return _RESOLVE_CANONICAL_BOOTSTRAP_SERVERS_ONLYContent; } }
        private static Org.Apache.Kafka.Clients.ClientDnsLookup _RESOLVE_CANONICAL_BOOTSTRAP_SERVERS_ONLYContent = default;
        private static bool _RESOLVE_CANONICAL_BOOTSTRAP_SERVERS_ONLYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/ClientDnsLookup.html#USE_ALL_DNS_IPS"/>
        /// </summary>
        public static Org.Apache.Kafka.Clients.ClientDnsLookup USE_ALL_DNS_IPS { get { if (!_USE_ALL_DNS_IPSReady) { _USE_ALL_DNS_IPSContent = SGetField<Org.Apache.Kafka.Clients.ClientDnsLookup>(LocalBridgeClazz, "USE_ALL_DNS_IPS"); _USE_ALL_DNS_IPSReady = true; } return _USE_ALL_DNS_IPSContent; } }
        private static Org.Apache.Kafka.Clients.ClientDnsLookup _USE_ALL_DNS_IPSContent = default;
        private static bool _USE_ALL_DNS_IPSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/ClientDnsLookup.html#forConfig-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.ClientDnsLookup"/></returns>
        public static Org.Apache.Kafka.Clients.ClientDnsLookup ForConfig(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Clients.ClientDnsLookup>(LocalBridgeClazz, "forConfig", "(Ljava/lang/String;)Lorg/apache/kafka/clients/ClientDnsLookup;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/ClientDnsLookup.html#valueOf-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.ClientDnsLookup"/></returns>
        public static Org.Apache.Kafka.Clients.ClientDnsLookup ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Clients.ClientDnsLookup>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/clients/ClientDnsLookup;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/ClientDnsLookup.html#values--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Clients.ClientDnsLookup"/></returns>
        public static Org.Apache.Kafka.Clients.ClientDnsLookup[] Values()
        {
            return SExecuteWithSignatureArray<Org.Apache.Kafka.Clients.ClientDnsLookup>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/clients/ClientDnsLookup;");
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