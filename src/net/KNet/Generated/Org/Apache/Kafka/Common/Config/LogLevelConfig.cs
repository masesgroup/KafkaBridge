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
*  This file is generated by MASES.JNetReflector (ver. 2.1.0.0)
*  using kafka-clients-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Config
{
    #region LogLevelConfig
    public partial class LogLevelConfig
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/LogLevelConfig.html#DEBUG_LOG_LEVEL"/>
        /// </summary>
        public static string DEBUG_LOG_LEVEL { get { return SGetField<string>(LocalBridgeClazz, "DEBUG_LOG_LEVEL"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/LogLevelConfig.html#ERROR_LOG_LEVEL"/>
        /// </summary>
        public static string ERROR_LOG_LEVEL { get { return SGetField<string>(LocalBridgeClazz, "ERROR_LOG_LEVEL"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/LogLevelConfig.html#FATAL_LOG_LEVEL"/>
        /// </summary>
        public static string FATAL_LOG_LEVEL { get { return SGetField<string>(LocalBridgeClazz, "FATAL_LOG_LEVEL"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/LogLevelConfig.html#INFO_LOG_LEVEL"/>
        /// </summary>
        public static string INFO_LOG_LEVEL { get { return SGetField<string>(LocalBridgeClazz, "INFO_LOG_LEVEL"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/LogLevelConfig.html#TRACE_LOG_LEVEL"/>
        /// </summary>
        public static string TRACE_LOG_LEVEL { get { return SGetField<string>(LocalBridgeClazz, "TRACE_LOG_LEVEL"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/LogLevelConfig.html#WARN_LOG_LEVEL"/>
        /// </summary>
        public static string WARN_LOG_LEVEL { get { return SGetField<string>(LocalBridgeClazz, "WARN_LOG_LEVEL"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/LogLevelConfig.html#VALID_LOG_LEVELS"/>
        /// </summary>
        public static Java.Util.Set VALID_LOG_LEVELS { get { return SGetField<Java.Util.Set>(LocalBridgeClazz, "VALID_LOG_LEVELS"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}