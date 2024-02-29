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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using kafka-clients-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Config
{
    #region ConfigResource
    public partial class ConfigResource
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/ConfigResource.html#org.apache.kafka.common.config.ConfigResource(org.apache.kafka.common.config.ConfigResource.Type,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Config.ConfigResource.Type"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public ConfigResource(Org.Apache.Kafka.Common.Config.ConfigResource.Type arg0, Java.Lang.String arg1)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/ConfigResource.html#isDefault--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsDefault()
        {
            return IExecuteWithSignature<bool>("isDefault", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/ConfigResource.html#name--"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Name()
        {
            return IExecuteWithSignature<Java.Lang.String>("name", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/ConfigResource.html#type--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Config.ConfigResource.Type"/></returns>
        public Org.Apache.Kafka.Common.Config.ConfigResource.Type TypeMethod()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Config.ConfigResource.Type>("type", "()Lorg/apache/kafka/common/config/ConfigResource$Type;");
        }

        #endregion

        #region Nested classes
        #region Type
        public partial class Type
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/ConfigResource.Type.html#BROKER"/>
            /// </summary>
            public static Org.Apache.Kafka.Common.Config.ConfigResource.Type BROKER { get { if (!_BROKERReady) { _BROKERContent = SGetField<Org.Apache.Kafka.Common.Config.ConfigResource.Type>(LocalBridgeClazz, "BROKER"); _BROKERReady = true; } return _BROKERContent; } }
            private static Org.Apache.Kafka.Common.Config.ConfigResource.Type _BROKERContent = default;
            private static bool _BROKERReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/ConfigResource.Type.html#BROKER_LOGGER"/>
            /// </summary>
            public static Org.Apache.Kafka.Common.Config.ConfigResource.Type BROKER_LOGGER { get { if (!_BROKER_LOGGERReady) { _BROKER_LOGGERContent = SGetField<Org.Apache.Kafka.Common.Config.ConfigResource.Type>(LocalBridgeClazz, "BROKER_LOGGER"); _BROKER_LOGGERReady = true; } return _BROKER_LOGGERContent; } }
            private static Org.Apache.Kafka.Common.Config.ConfigResource.Type _BROKER_LOGGERContent = default;
            private static bool _BROKER_LOGGERReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/ConfigResource.Type.html#TOPIC"/>
            /// </summary>
            public static Org.Apache.Kafka.Common.Config.ConfigResource.Type TOPIC { get { if (!_TOPICReady) { _TOPICContent = SGetField<Org.Apache.Kafka.Common.Config.ConfigResource.Type>(LocalBridgeClazz, "TOPIC"); _TOPICReady = true; } return _TOPICContent; } }
            private static Org.Apache.Kafka.Common.Config.ConfigResource.Type _TOPICContent = default;
            private static bool _TOPICReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/ConfigResource.Type.html#UNKNOWN"/>
            /// </summary>
            public static Org.Apache.Kafka.Common.Config.ConfigResource.Type UNKNOWN { get { if (!_UNKNOWNReady) { _UNKNOWNContent = SGetField<Org.Apache.Kafka.Common.Config.ConfigResource.Type>(LocalBridgeClazz, "UNKNOWN"); _UNKNOWNReady = true; } return _UNKNOWNContent; } }
            private static Org.Apache.Kafka.Common.Config.ConfigResource.Type _UNKNOWNContent = default;
            private static bool _UNKNOWNReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/ConfigResource.Type.html#forId-byte-"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Common.Config.ConfigResource.Type"/></returns>
            public static Org.Apache.Kafka.Common.Config.ConfigResource.Type ForId(byte arg0)
            {
                return SExecuteWithSignature<Org.Apache.Kafka.Common.Config.ConfigResource.Type>(LocalBridgeClazz, "forId", "(B)Lorg/apache/kafka/common/config/ConfigResource$Type;", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/ConfigResource.Type.html#valueOf-java.lang.String-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Common.Config.ConfigResource.Type"/></returns>
            public static Org.Apache.Kafka.Common.Config.ConfigResource.Type ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Org.Apache.Kafka.Common.Config.ConfigResource.Type>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/common/config/ConfigResource$Type;", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/ConfigResource.Type.html#values--"/>
            /// </summary>

            /// <returns><see cref="Org.Apache.Kafka.Common.Config.ConfigResource.Type"/></returns>
            public static Org.Apache.Kafka.Common.Config.ConfigResource.Type[] Values()
            {
                return SExecuteWithSignatureArray<Org.Apache.Kafka.Common.Config.ConfigResource.Type>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/common/config/ConfigResource$Type;");
            }

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/ConfigResource.Type.html#id--"/>
            /// </summary>

            /// <returns><see cref="byte"/></returns>
            public byte Id()
            {
                return IExecuteWithSignature<byte>("id", "()B");
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