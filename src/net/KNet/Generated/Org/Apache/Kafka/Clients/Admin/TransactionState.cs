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
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
*  using kafka-clients-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Admin
{
    #region TransactionState
    public partial class TransactionState
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/admin/TransactionState.html#COMPLETE_ABORT"/>
        /// </summary>
        public static Org.Apache.Kafka.Clients.Admin.TransactionState COMPLETE_ABORT { get { if (!_COMPLETE_ABORTReady) { _COMPLETE_ABORTContent = SGetField<Org.Apache.Kafka.Clients.Admin.TransactionState>(LocalBridgeClazz, "COMPLETE_ABORT"); _COMPLETE_ABORTReady = true; } return _COMPLETE_ABORTContent; } }
        private static Org.Apache.Kafka.Clients.Admin.TransactionState _COMPLETE_ABORTContent = default;
        private static bool _COMPLETE_ABORTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/admin/TransactionState.html#COMPLETE_COMMIT"/>
        /// </summary>
        public static Org.Apache.Kafka.Clients.Admin.TransactionState COMPLETE_COMMIT { get { if (!_COMPLETE_COMMITReady) { _COMPLETE_COMMITContent = SGetField<Org.Apache.Kafka.Clients.Admin.TransactionState>(LocalBridgeClazz, "COMPLETE_COMMIT"); _COMPLETE_COMMITReady = true; } return _COMPLETE_COMMITContent; } }
        private static Org.Apache.Kafka.Clients.Admin.TransactionState _COMPLETE_COMMITContent = default;
        private static bool _COMPLETE_COMMITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/admin/TransactionState.html#EMPTY"/>
        /// </summary>
        public static Org.Apache.Kafka.Clients.Admin.TransactionState EMPTY { get { if (!_EMPTYReady) { _EMPTYContent = SGetField<Org.Apache.Kafka.Clients.Admin.TransactionState>(LocalBridgeClazz, "EMPTY"); _EMPTYReady = true; } return _EMPTYContent; } }
        private static Org.Apache.Kafka.Clients.Admin.TransactionState _EMPTYContent = default;
        private static bool _EMPTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/admin/TransactionState.html#ONGOING"/>
        /// </summary>
        public static Org.Apache.Kafka.Clients.Admin.TransactionState ONGOING { get { if (!_ONGOINGReady) { _ONGOINGContent = SGetField<Org.Apache.Kafka.Clients.Admin.TransactionState>(LocalBridgeClazz, "ONGOING"); _ONGOINGReady = true; } return _ONGOINGContent; } }
        private static Org.Apache.Kafka.Clients.Admin.TransactionState _ONGOINGContent = default;
        private static bool _ONGOINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/admin/TransactionState.html#PREPARE_ABORT"/>
        /// </summary>
        public static Org.Apache.Kafka.Clients.Admin.TransactionState PREPARE_ABORT { get { if (!_PREPARE_ABORTReady) { _PREPARE_ABORTContent = SGetField<Org.Apache.Kafka.Clients.Admin.TransactionState>(LocalBridgeClazz, "PREPARE_ABORT"); _PREPARE_ABORTReady = true; } return _PREPARE_ABORTContent; } }
        private static Org.Apache.Kafka.Clients.Admin.TransactionState _PREPARE_ABORTContent = default;
        private static bool _PREPARE_ABORTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/admin/TransactionState.html#PREPARE_COMMIT"/>
        /// </summary>
        public static Org.Apache.Kafka.Clients.Admin.TransactionState PREPARE_COMMIT { get { if (!_PREPARE_COMMITReady) { _PREPARE_COMMITContent = SGetField<Org.Apache.Kafka.Clients.Admin.TransactionState>(LocalBridgeClazz, "PREPARE_COMMIT"); _PREPARE_COMMITReady = true; } return _PREPARE_COMMITContent; } }
        private static Org.Apache.Kafka.Clients.Admin.TransactionState _PREPARE_COMMITContent = default;
        private static bool _PREPARE_COMMITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/admin/TransactionState.html#PREPARE_EPOCH_FENCE"/>
        /// </summary>
        public static Org.Apache.Kafka.Clients.Admin.TransactionState PREPARE_EPOCH_FENCE { get { if (!_PREPARE_EPOCH_FENCEReady) { _PREPARE_EPOCH_FENCEContent = SGetField<Org.Apache.Kafka.Clients.Admin.TransactionState>(LocalBridgeClazz, "PREPARE_EPOCH_FENCE"); _PREPARE_EPOCH_FENCEReady = true; } return _PREPARE_EPOCH_FENCEContent; } }
        private static Org.Apache.Kafka.Clients.Admin.TransactionState _PREPARE_EPOCH_FENCEContent = default;
        private static bool _PREPARE_EPOCH_FENCEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/admin/TransactionState.html#UNKNOWN"/>
        /// </summary>
        public static Org.Apache.Kafka.Clients.Admin.TransactionState UNKNOWN { get { if (!_UNKNOWNReady) { _UNKNOWNContent = SGetField<Org.Apache.Kafka.Clients.Admin.TransactionState>(LocalBridgeClazz, "UNKNOWN"); _UNKNOWNReady = true; } return _UNKNOWNContent; } }
        private static Org.Apache.Kafka.Clients.Admin.TransactionState _UNKNOWNContent = default;
        private static bool _UNKNOWNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/admin/TransactionState.html#parse-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.TransactionState"/></returns>
        public static Org.Apache.Kafka.Clients.Admin.TransactionState Parse(Java.Lang.String arg0)
        {
            return SExecute<Org.Apache.Kafka.Clients.Admin.TransactionState>(LocalBridgeClazz, "parse", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/admin/TransactionState.html#valueOf-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.TransactionState"/></returns>
        public static Org.Apache.Kafka.Clients.Admin.TransactionState ValueOf(Java.Lang.String arg0)
        {
            return SExecute<Org.Apache.Kafka.Clients.Admin.TransactionState>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/admin/TransactionState.html#values--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.TransactionState"/></returns>
        public static Org.Apache.Kafka.Clients.Admin.TransactionState[] Values()
        {
            return SExecuteArray<Org.Apache.Kafka.Clients.Admin.TransactionState>(LocalBridgeClazz, "values");
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