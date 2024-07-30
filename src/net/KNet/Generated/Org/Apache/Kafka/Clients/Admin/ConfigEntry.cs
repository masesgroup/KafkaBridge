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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using kafka-clients-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Admin
{
    #region ConfigEntry
    public partial class ConfigEntry
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/ConfigEntry.html#org.apache.kafka.clients.admin.ConfigEntry(java.lang.String,java.lang.String,org.apache.kafka.clients.admin.ConfigEntry.ConfigSource,boolean,boolean,java.util.List,org.apache.kafka.clients.admin.ConfigEntry.ConfigType,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigSource"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        /// <param name="arg5"><see cref="Java.Util.List"/></param>
        /// <param name="arg6"><see cref="Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigType"/></param>
        /// <param name="arg7"><see cref="Java.Lang.String"/></param>
        public ConfigEntry(Java.Lang.String arg0, Java.Lang.String arg1, Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigSource arg2, bool arg3, bool arg4, Java.Util.List<Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigSynonym> arg5, Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigType arg6, Java.Lang.String arg7)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/ConfigEntry.html#org.apache.kafka.clients.admin.ConfigEntry(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public ConfigEntry(Java.Lang.String arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/ConfigEntry.html#isDefault--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDefault()
        {
            return IExecuteWithSignature<bool>("isDefault", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/ConfigEntry.html#isReadOnly--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsReadOnly()
        {
            return IExecuteWithSignature<bool>("isReadOnly", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/ConfigEntry.html#isSensitive--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSensitive()
        {
            return IExecuteWithSignature<bool>("isSensitive", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/ConfigEntry.html#documentation--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Documentation()
        {
            return IExecuteWithSignature<Java.Lang.String>("documentation", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/ConfigEntry.html#name--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Name()
        {
            return IExecuteWithSignature<Java.Lang.String>("name", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/ConfigEntry.html#value--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Value()
        {
            return IExecuteWithSignature<Java.Lang.String>("value", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/ConfigEntry.html#synonyms--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigSynonym> Synonyms()
        {
            return IExecuteWithSignature<Java.Util.List<Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigSynonym>>("synonyms", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/ConfigEntry.html#source--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigSource"/></returns>
        public Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigSource Source()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigSource>("source", "()Lorg/apache/kafka/clients/admin/ConfigEntry$ConfigSource;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/ConfigEntry.html#type--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigType"/></returns>
        public Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigType Type()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigType>("type", "()Lorg/apache/kafka/clients/admin/ConfigEntry$ConfigType;");
        }

        #endregion

        #region Nested classes
        #region ConfigSource
        public partial class ConfigSource
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/ConfigEntry.ConfigSource.html#DEFAULT_CONFIG"/>
            /// </summary>
            public static Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigSource DEFAULT_CONFIG { get { if (!_DEFAULT_CONFIGReady) { _DEFAULT_CONFIGContent = SGetField<Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigSource>(LocalBridgeClazz, "DEFAULT_CONFIG"); _DEFAULT_CONFIGReady = true; } return _DEFAULT_CONFIGContent; } }
            private static Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigSource _DEFAULT_CONFIGContent = default;
            private static bool _DEFAULT_CONFIGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/ConfigEntry.ConfigSource.html#DYNAMIC_BROKER_CONFIG"/>
            /// </summary>
            public static Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigSource DYNAMIC_BROKER_CONFIG { get { if (!_DYNAMIC_BROKER_CONFIGReady) { _DYNAMIC_BROKER_CONFIGContent = SGetField<Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigSource>(LocalBridgeClazz, "DYNAMIC_BROKER_CONFIG"); _DYNAMIC_BROKER_CONFIGReady = true; } return _DYNAMIC_BROKER_CONFIGContent; } }
            private static Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigSource _DYNAMIC_BROKER_CONFIGContent = default;
            private static bool _DYNAMIC_BROKER_CONFIGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/ConfigEntry.ConfigSource.html#DYNAMIC_BROKER_LOGGER_CONFIG"/>
            /// </summary>
            public static Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigSource DYNAMIC_BROKER_LOGGER_CONFIG { get { if (!_DYNAMIC_BROKER_LOGGER_CONFIGReady) { _DYNAMIC_BROKER_LOGGER_CONFIGContent = SGetField<Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigSource>(LocalBridgeClazz, "DYNAMIC_BROKER_LOGGER_CONFIG"); _DYNAMIC_BROKER_LOGGER_CONFIGReady = true; } return _DYNAMIC_BROKER_LOGGER_CONFIGContent; } }
            private static Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigSource _DYNAMIC_BROKER_LOGGER_CONFIGContent = default;
            private static bool _DYNAMIC_BROKER_LOGGER_CONFIGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/ConfigEntry.ConfigSource.html#DYNAMIC_CLIENT_METRICS_CONFIG"/>
            /// </summary>
            public static Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigSource DYNAMIC_CLIENT_METRICS_CONFIG { get { if (!_DYNAMIC_CLIENT_METRICS_CONFIGReady) { _DYNAMIC_CLIENT_METRICS_CONFIGContent = SGetField<Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigSource>(LocalBridgeClazz, "DYNAMIC_CLIENT_METRICS_CONFIG"); _DYNAMIC_CLIENT_METRICS_CONFIGReady = true; } return _DYNAMIC_CLIENT_METRICS_CONFIGContent; } }
            private static Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigSource _DYNAMIC_CLIENT_METRICS_CONFIGContent = default;
            private static bool _DYNAMIC_CLIENT_METRICS_CONFIGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/ConfigEntry.ConfigSource.html#DYNAMIC_DEFAULT_BROKER_CONFIG"/>
            /// </summary>
            public static Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigSource DYNAMIC_DEFAULT_BROKER_CONFIG { get { if (!_DYNAMIC_DEFAULT_BROKER_CONFIGReady) { _DYNAMIC_DEFAULT_BROKER_CONFIGContent = SGetField<Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigSource>(LocalBridgeClazz, "DYNAMIC_DEFAULT_BROKER_CONFIG"); _DYNAMIC_DEFAULT_BROKER_CONFIGReady = true; } return _DYNAMIC_DEFAULT_BROKER_CONFIGContent; } }
            private static Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigSource _DYNAMIC_DEFAULT_BROKER_CONFIGContent = default;
            private static bool _DYNAMIC_DEFAULT_BROKER_CONFIGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/ConfigEntry.ConfigSource.html#DYNAMIC_TOPIC_CONFIG"/>
            /// </summary>
            public static Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigSource DYNAMIC_TOPIC_CONFIG { get { if (!_DYNAMIC_TOPIC_CONFIGReady) { _DYNAMIC_TOPIC_CONFIGContent = SGetField<Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigSource>(LocalBridgeClazz, "DYNAMIC_TOPIC_CONFIG"); _DYNAMIC_TOPIC_CONFIGReady = true; } return _DYNAMIC_TOPIC_CONFIGContent; } }
            private static Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigSource _DYNAMIC_TOPIC_CONFIGContent = default;
            private static bool _DYNAMIC_TOPIC_CONFIGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/ConfigEntry.ConfigSource.html#STATIC_BROKER_CONFIG"/>
            /// </summary>
            public static Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigSource STATIC_BROKER_CONFIG { get { if (!_STATIC_BROKER_CONFIGReady) { _STATIC_BROKER_CONFIGContent = SGetField<Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigSource>(LocalBridgeClazz, "STATIC_BROKER_CONFIG"); _STATIC_BROKER_CONFIGReady = true; } return _STATIC_BROKER_CONFIGContent; } }
            private static Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigSource _STATIC_BROKER_CONFIGContent = default;
            private static bool _STATIC_BROKER_CONFIGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/ConfigEntry.ConfigSource.html#UNKNOWN"/>
            /// </summary>
            public static Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigSource UNKNOWN { get { if (!_UNKNOWNReady) { _UNKNOWNContent = SGetField<Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigSource>(LocalBridgeClazz, "UNKNOWN"); _UNKNOWNReady = true; } return _UNKNOWNContent; } }
            private static Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigSource _UNKNOWNContent = default;
            private static bool _UNKNOWNReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/ConfigEntry.ConfigSource.html#valueOf-java.lang.String-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigSource"/></returns>
            public static Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigSource ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigSource>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/clients/admin/ConfigEntry$ConfigSource;", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/ConfigEntry.ConfigSource.html#values--"/>
            /// </summary>
            /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigSource"/></returns>
            public static Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigSource[] Values()
            {
                return SExecuteWithSignatureArray<Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigSource>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/clients/admin/ConfigEntry$ConfigSource;");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ConfigSynonym
        public partial class ConfigSynonym
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/ConfigEntry.ConfigSynonym.html#name--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String Name()
            {
                return IExecuteWithSignature<Java.Lang.String>("name", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/ConfigEntry.ConfigSynonym.html#value--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String Value()
            {
                return IExecuteWithSignature<Java.Lang.String>("value", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/ConfigEntry.ConfigSynonym.html#source--"/>
            /// </summary>
            /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigSource"/></returns>
            public Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigSource Source()
            {
                return IExecuteWithSignature<Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigSource>("source", "()Lorg/apache/kafka/clients/admin/ConfigEntry$ConfigSource;");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ConfigType
        public partial class ConfigType
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/ConfigEntry.ConfigType.html#BOOLEAN"/>
            /// </summary>
            public static Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigType BOOLEAN { get { if (!_BOOLEANReady) { _BOOLEANContent = SGetField<Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigType>(LocalBridgeClazz, "BOOLEAN"); _BOOLEANReady = true; } return _BOOLEANContent; } }
            private static Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigType _BOOLEANContent = default;
            private static bool _BOOLEANReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/ConfigEntry.ConfigType.html#CLASS"/>
            /// </summary>
            public static Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigType CLASS { get { if (!_CLASSReady) { _CLASSContent = SGetField<Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigType>(LocalBridgeClazz, "CLASS"); _CLASSReady = true; } return _CLASSContent; } }
            private static Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigType _CLASSContent = default;
            private static bool _CLASSReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/ConfigEntry.ConfigType.html#DOUBLE"/>
            /// </summary>
            public static Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigType DOUBLE { get { if (!_DOUBLEReady) { _DOUBLEContent = SGetField<Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigType>(LocalBridgeClazz, "DOUBLE"); _DOUBLEReady = true; } return _DOUBLEContent; } }
            private static Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigType _DOUBLEContent = default;
            private static bool _DOUBLEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/ConfigEntry.ConfigType.html#INT"/>
            /// </summary>
            public static Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigType INT { get { if (!_INTReady) { _INTContent = SGetField<Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigType>(LocalBridgeClazz, "INT"); _INTReady = true; } return _INTContent; } }
            private static Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigType _INTContent = default;
            private static bool _INTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/ConfigEntry.ConfigType.html#LIST"/>
            /// </summary>
            public static Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigType LIST { get { if (!_LISTReady) { _LISTContent = SGetField<Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigType>(LocalBridgeClazz, "LIST"); _LISTReady = true; } return _LISTContent; } }
            private static Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigType _LISTContent = default;
            private static bool _LISTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/ConfigEntry.ConfigType.html#LONG"/>
            /// </summary>
            public static Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigType LONG { get { if (!_LONGReady) { _LONGContent = SGetField<Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigType>(LocalBridgeClazz, "LONG"); _LONGReady = true; } return _LONGContent; } }
            private static Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigType _LONGContent = default;
            private static bool _LONGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/ConfigEntry.ConfigType.html#PASSWORD"/>
            /// </summary>
            public static Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigType PASSWORD { get { if (!_PASSWORDReady) { _PASSWORDContent = SGetField<Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigType>(LocalBridgeClazz, "PASSWORD"); _PASSWORDReady = true; } return _PASSWORDContent; } }
            private static Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigType _PASSWORDContent = default;
            private static bool _PASSWORDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/ConfigEntry.ConfigType.html#SHORT"/>
            /// </summary>
            public static Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigType SHORT { get { if (!_SHORTReady) { _SHORTContent = SGetField<Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigType>(LocalBridgeClazz, "SHORT"); _SHORTReady = true; } return _SHORTContent; } }
            private static Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigType _SHORTContent = default;
            private static bool _SHORTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/ConfigEntry.ConfigType.html#STRING"/>
            /// </summary>
            public static Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigType STRING { get { if (!_STRINGReady) { _STRINGContent = SGetField<Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigType>(LocalBridgeClazz, "STRING"); _STRINGReady = true; } return _STRINGContent; } }
            private static Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigType _STRINGContent = default;
            private static bool _STRINGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/ConfigEntry.ConfigType.html#UNKNOWN"/>
            /// </summary>
            public static Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigType UNKNOWN { get { if (!_UNKNOWNReady) { _UNKNOWNContent = SGetField<Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigType>(LocalBridgeClazz, "UNKNOWN"); _UNKNOWNReady = true; } return _UNKNOWNContent; } }
            private static Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigType _UNKNOWNContent = default;
            private static bool _UNKNOWNReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/ConfigEntry.ConfigType.html#valueOf-java.lang.String-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigType"/></returns>
            public static Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigType ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigType>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/clients/admin/ConfigEntry$ConfigType;", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/ConfigEntry.ConfigType.html#values--"/>
            /// </summary>
            /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigType"/></returns>
            public static Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigType[] Values()
            {
                return SExecuteWithSignatureArray<Org.Apache.Kafka.Clients.Admin.ConfigEntry.ConfigType>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/clients/admin/ConfigEntry$ConfigType;");
            }

            #endregion

            #region Instance methods

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