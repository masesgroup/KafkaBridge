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
*  using kafka-clients-3.6.2.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Record
{
    #region ControlRecordType
    public partial class ControlRecordType
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/record/ControlRecordType.html#ABORT"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Record.ControlRecordType ABORT { get { if (!_ABORTReady) { _ABORTContent = SGetField<Org.Apache.Kafka.Common.Record.ControlRecordType>(LocalBridgeClazz, "ABORT"); _ABORTReady = true; } return _ABORTContent; } }
        private static Org.Apache.Kafka.Common.Record.ControlRecordType _ABORTContent = default;
        private static bool _ABORTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/record/ControlRecordType.html#COMMIT"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Record.ControlRecordType COMMIT { get { if (!_COMMITReady) { _COMMITContent = SGetField<Org.Apache.Kafka.Common.Record.ControlRecordType>(LocalBridgeClazz, "COMMIT"); _COMMITReady = true; } return _COMMITContent; } }
        private static Org.Apache.Kafka.Common.Record.ControlRecordType _COMMITContent = default;
        private static bool _COMMITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/record/ControlRecordType.html#LEADER_CHANGE"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Record.ControlRecordType LEADER_CHANGE { get { if (!_LEADER_CHANGEReady) { _LEADER_CHANGEContent = SGetField<Org.Apache.Kafka.Common.Record.ControlRecordType>(LocalBridgeClazz, "LEADER_CHANGE"); _LEADER_CHANGEReady = true; } return _LEADER_CHANGEContent; } }
        private static Org.Apache.Kafka.Common.Record.ControlRecordType _LEADER_CHANGEContent = default;
        private static bool _LEADER_CHANGEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/record/ControlRecordType.html#SNAPSHOT_FOOTER"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Record.ControlRecordType SNAPSHOT_FOOTER { get { if (!_SNAPSHOT_FOOTERReady) { _SNAPSHOT_FOOTERContent = SGetField<Org.Apache.Kafka.Common.Record.ControlRecordType>(LocalBridgeClazz, "SNAPSHOT_FOOTER"); _SNAPSHOT_FOOTERReady = true; } return _SNAPSHOT_FOOTERContent; } }
        private static Org.Apache.Kafka.Common.Record.ControlRecordType _SNAPSHOT_FOOTERContent = default;
        private static bool _SNAPSHOT_FOOTERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/record/ControlRecordType.html#SNAPSHOT_HEADER"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Record.ControlRecordType SNAPSHOT_HEADER { get { if (!_SNAPSHOT_HEADERReady) { _SNAPSHOT_HEADERContent = SGetField<Org.Apache.Kafka.Common.Record.ControlRecordType>(LocalBridgeClazz, "SNAPSHOT_HEADER"); _SNAPSHOT_HEADERReady = true; } return _SNAPSHOT_HEADERContent; } }
        private static Org.Apache.Kafka.Common.Record.ControlRecordType _SNAPSHOT_HEADERContent = default;
        private static bool _SNAPSHOT_HEADERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/record/ControlRecordType.html#UNKNOWN"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Record.ControlRecordType UNKNOWN { get { if (!_UNKNOWNReady) { _UNKNOWNContent = SGetField<Org.Apache.Kafka.Common.Record.ControlRecordType>(LocalBridgeClazz, "UNKNOWN"); _UNKNOWNReady = true; } return _UNKNOWNContent; } }
        private static Org.Apache.Kafka.Common.Record.ControlRecordType _UNKNOWNContent = default;
        private static bool _UNKNOWNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/record/ControlRecordType.html#fromTypeId-short-"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Record.ControlRecordType"/></returns>
        public static Org.Apache.Kafka.Common.Record.ControlRecordType FromTypeId(short arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.Record.ControlRecordType>(LocalBridgeClazz, "fromTypeId", "(S)Lorg/apache/kafka/common/record/ControlRecordType;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/record/ControlRecordType.html#parse-java.nio.ByteBuffer-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Record.ControlRecordType"/></returns>
        public static Org.Apache.Kafka.Common.Record.ControlRecordType Parse(Java.Nio.ByteBuffer arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.Record.ControlRecordType>(LocalBridgeClazz, "parse", "(Ljava/nio/ByteBuffer;)Lorg/apache/kafka/common/record/ControlRecordType;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/record/ControlRecordType.html#valueOf-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Record.ControlRecordType"/></returns>
        public static Org.Apache.Kafka.Common.Record.ControlRecordType ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.Record.ControlRecordType>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/common/record/ControlRecordType;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/record/ControlRecordType.html#values--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Record.ControlRecordType"/></returns>
        public static Org.Apache.Kafka.Common.Record.ControlRecordType[] Values()
        {
            return SExecuteWithSignatureArray<Org.Apache.Kafka.Common.Record.ControlRecordType>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/common/record/ControlRecordType;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/record/ControlRecordType.html#parseTypeId-java.nio.ByteBuffer-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="short"/></returns>
        public static short ParseTypeId(Java.Nio.ByteBuffer arg0)
        {
            return SExecuteWithSignature<short>(LocalBridgeClazz, "parseTypeId", "(Ljava/nio/ByteBuffer;)S", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/record/ControlRecordType.html#type--"/>
        /// </summary>

        /// <returns><see cref="short"/></returns>
        public short Type()
        {
            return IExecuteWithSignature<short>("type", "()S");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}