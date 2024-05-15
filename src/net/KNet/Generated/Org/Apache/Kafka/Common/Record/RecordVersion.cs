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

namespace Org.Apache.Kafka.Common.Record
{
    #region RecordVersion
    public partial class RecordVersion
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordVersion.html#value"/>
        /// </summary>
        public byte value { get { if (!_valueReady) { _valueContent = IGetField<byte>("value"); _valueReady = true; } return _valueContent; } }
        private byte _valueContent = default;
        private bool _valueReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordVersion.html#V0"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Record.RecordVersion V0 { get { if (!_V0Ready) { _V0Content = SGetField<Org.Apache.Kafka.Common.Record.RecordVersion>(LocalBridgeClazz, "V0"); _V0Ready = true; } return _V0Content; } }
        private static Org.Apache.Kafka.Common.Record.RecordVersion _V0Content = default;
        private static bool _V0Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordVersion.html#V1"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Record.RecordVersion V1 { get { if (!_V1Ready) { _V1Content = SGetField<Org.Apache.Kafka.Common.Record.RecordVersion>(LocalBridgeClazz, "V1"); _V1Ready = true; } return _V1Content; } }
        private static Org.Apache.Kafka.Common.Record.RecordVersion _V1Content = default;
        private static bool _V1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordVersion.html#V2"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Record.RecordVersion V2 { get { if (!_V2Ready) { _V2Content = SGetField<Org.Apache.Kafka.Common.Record.RecordVersion>(LocalBridgeClazz, "V2"); _V2Ready = true; } return _V2Content; } }
        private static Org.Apache.Kafka.Common.Record.RecordVersion _V2Content = default;
        private static bool _V2Ready = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordVersion.html#current--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Record.RecordVersion"/></returns>
        public static Org.Apache.Kafka.Common.Record.RecordVersion Current()
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.Record.RecordVersion>(LocalBridgeClazz, "current", "()Lorg/apache/kafka/common/record/RecordVersion;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordVersion.html#lookup-byte-"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Record.RecordVersion"/></returns>
        public static Org.Apache.Kafka.Common.Record.RecordVersion Lookup(byte arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.Record.RecordVersion>(LocalBridgeClazz, "lookup", "(B)Lorg/apache/kafka/common/record/RecordVersion;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordVersion.html#valueOf-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Record.RecordVersion"/></returns>
        public static Org.Apache.Kafka.Common.Record.RecordVersion ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.Record.RecordVersion>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/common/record/RecordVersion;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordVersion.html#values--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Record.RecordVersion"/></returns>
        public static Org.Apache.Kafka.Common.Record.RecordVersion[] Values()
        {
            return SExecuteWithSignatureArray<Org.Apache.Kafka.Common.Record.RecordVersion>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/common/record/RecordVersion;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/RecordVersion.html#precedes-org.apache.kafka.common.record.RecordVersion-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Record.RecordVersion"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Precedes(Org.Apache.Kafka.Common.Record.RecordVersion arg0)
        {
            return IExecuteWithSignature<bool>("precedes", "(Lorg/apache/kafka/common/record/RecordVersion;)Z", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}