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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using kafka-clients-3.6.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Resource
{
    #region PatternType
    public partial class PatternType
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/resource/PatternType.html#ANY"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Resource.PatternType ANY { get { return SGetField<Org.Apache.Kafka.Common.Resource.PatternType>(LocalBridgeClazz, "ANY"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/resource/PatternType.html#LITERAL"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Resource.PatternType LITERAL { get { return SGetField<Org.Apache.Kafka.Common.Resource.PatternType>(LocalBridgeClazz, "LITERAL"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/resource/PatternType.html#MATCH"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Resource.PatternType MATCH { get { return SGetField<Org.Apache.Kafka.Common.Resource.PatternType>(LocalBridgeClazz, "MATCH"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/resource/PatternType.html#PREFIXED"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Resource.PatternType PREFIXED { get { return SGetField<Org.Apache.Kafka.Common.Resource.PatternType>(LocalBridgeClazz, "PREFIXED"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/resource/PatternType.html#UNKNOWN"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Resource.PatternType UNKNOWN { get { return SGetField<Org.Apache.Kafka.Common.Resource.PatternType>(LocalBridgeClazz, "UNKNOWN"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/resource/PatternType.html#fromCode-byte-"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Resource.PatternType"/></returns>
        public static Org.Apache.Kafka.Common.Resource.PatternType FromCode(byte arg0)
        {
            return SExecute<Org.Apache.Kafka.Common.Resource.PatternType>(LocalBridgeClazz, "fromCode", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/resource/PatternType.html#fromString-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Resource.PatternType"/></returns>
        public static Org.Apache.Kafka.Common.Resource.PatternType FromString(string arg0)
        {
            return SExecute<Org.Apache.Kafka.Common.Resource.PatternType>(LocalBridgeClazz, "fromString", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/resource/PatternType.html#valueOf-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Resource.PatternType"/></returns>
        public static Org.Apache.Kafka.Common.Resource.PatternType ValueOf(string arg0)
        {
            return SExecute<Org.Apache.Kafka.Common.Resource.PatternType>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/resource/PatternType.html#values--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Resource.PatternType"/></returns>
        public static Org.Apache.Kafka.Common.Resource.PatternType[] Values()
        {
            return SExecuteArray<Org.Apache.Kafka.Common.Resource.PatternType>(LocalBridgeClazz, "values");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/resource/PatternType.html#isSpecific--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsSpecific()
        {
            return IExecute<bool>("isSpecific");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/resource/PatternType.html#isUnknown--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsUnknown()
        {
            return IExecute<bool>("isUnknown");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/resource/PatternType.html#code--"/>
        /// </summary>

        /// <returns><see cref="byte"/></returns>
        public byte Code()
        {
            return IExecute<byte>("code");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}