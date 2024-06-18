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
*  This file is generated by MASES.JNetReflector (ver. 2.5.3.0)
*  using kafka-clients-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Admin
{
    #region ScramMechanism
    public partial class ScramMechanism
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/admin/ScramMechanism.html#SCRAM_SHA_256"/>
        /// </summary>
        public static Org.Apache.Kafka.Clients.Admin.ScramMechanism SCRAM_SHA_256 { get { if (!_SCRAM_SHA_256Ready) { _SCRAM_SHA_256Content = SGetField<Org.Apache.Kafka.Clients.Admin.ScramMechanism>(LocalBridgeClazz, "SCRAM_SHA_256"); _SCRAM_SHA_256Ready = true; } return _SCRAM_SHA_256Content; } }
        private static Org.Apache.Kafka.Clients.Admin.ScramMechanism _SCRAM_SHA_256Content = default;
        private static bool _SCRAM_SHA_256Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/admin/ScramMechanism.html#SCRAM_SHA_512"/>
        /// </summary>
        public static Org.Apache.Kafka.Clients.Admin.ScramMechanism SCRAM_SHA_512 { get { if (!_SCRAM_SHA_512Ready) { _SCRAM_SHA_512Content = SGetField<Org.Apache.Kafka.Clients.Admin.ScramMechanism>(LocalBridgeClazz, "SCRAM_SHA_512"); _SCRAM_SHA_512Ready = true; } return _SCRAM_SHA_512Content; } }
        private static Org.Apache.Kafka.Clients.Admin.ScramMechanism _SCRAM_SHA_512Content = default;
        private static bool _SCRAM_SHA_512Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/admin/ScramMechanism.html#UNKNOWN"/>
        /// </summary>
        public static Org.Apache.Kafka.Clients.Admin.ScramMechanism UNKNOWN { get { if (!_UNKNOWNReady) { _UNKNOWNContent = SGetField<Org.Apache.Kafka.Clients.Admin.ScramMechanism>(LocalBridgeClazz, "UNKNOWN"); _UNKNOWNReady = true; } return _UNKNOWNContent; } }
        private static Org.Apache.Kafka.Clients.Admin.ScramMechanism _UNKNOWNContent = default;
        private static bool _UNKNOWNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/admin/ScramMechanism.html#fromMechanismName-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.ScramMechanism"/></returns>
        public static Org.Apache.Kafka.Clients.Admin.ScramMechanism FromMechanismName(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Clients.Admin.ScramMechanism>(LocalBridgeClazz, "fromMechanismName", "(Ljava/lang/String;)Lorg/apache/kafka/clients/admin/ScramMechanism;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/admin/ScramMechanism.html#fromType-byte-"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.ScramMechanism"/></returns>
        public static Org.Apache.Kafka.Clients.Admin.ScramMechanism FromType(byte arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Clients.Admin.ScramMechanism>(LocalBridgeClazz, "fromType", "(B)Lorg/apache/kafka/clients/admin/ScramMechanism;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/admin/ScramMechanism.html#valueOf-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.ScramMechanism"/></returns>
        public static Org.Apache.Kafka.Clients.Admin.ScramMechanism ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Clients.Admin.ScramMechanism>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/clients/admin/ScramMechanism;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/admin/ScramMechanism.html#values--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.ScramMechanism"/></returns>
        public static Org.Apache.Kafka.Clients.Admin.ScramMechanism[] Values()
        {
            return SExecuteWithSignatureArray<Org.Apache.Kafka.Clients.Admin.ScramMechanism>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/clients/admin/ScramMechanism;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/admin/ScramMechanism.html#type--"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte Type()
        {
            return IExecuteWithSignature<byte>("type", "()B");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/admin/ScramMechanism.html#mechanismName--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String MechanismName()
        {
            return IExecuteWithSignature<Java.Lang.String>("mechanismName", "()Ljava/lang/String;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}