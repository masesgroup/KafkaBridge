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
*  This file is generated by MASES.JNetReflector (ver. 2.2.1.0)
*  using kafka-clients-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Record
{
    #region TimestampType
    public partial class TimestampType
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/record/TimestampType.html#id"/>
        /// </summary>
        public int id { get { return IGetField<int>("id"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/record/TimestampType.html#name"/>
        /// </summary>
        public string name { get { return IGetField<string>("name"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/record/TimestampType.html#CREATE_TIME"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Record.TimestampType CREATE_TIME { get { return SGetField<Org.Apache.Kafka.Common.Record.TimestampType>(LocalBridgeClazz, "CREATE_TIME"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/record/TimestampType.html#LOG_APPEND_TIME"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Record.TimestampType LOG_APPEND_TIME { get { return SGetField<Org.Apache.Kafka.Common.Record.TimestampType>(LocalBridgeClazz, "LOG_APPEND_TIME"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/record/TimestampType.html#NO_TIMESTAMP_TYPE"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Record.TimestampType NO_TIMESTAMP_TYPE { get { return SGetField<Org.Apache.Kafka.Common.Record.TimestampType>(LocalBridgeClazz, "NO_TIMESTAMP_TYPE"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/record/TimestampType.html#forName-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Record.TimestampType"/></returns>
        public static Org.Apache.Kafka.Common.Record.TimestampType ForName(string arg0)
        {
            return SExecute<Org.Apache.Kafka.Common.Record.TimestampType>(LocalBridgeClazz, "forName", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/record/TimestampType.html#valueOf-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Record.TimestampType"/></returns>
        public static Org.Apache.Kafka.Common.Record.TimestampType ValueOf(string arg0)
        {
            return SExecute<Org.Apache.Kafka.Common.Record.TimestampType>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/record/TimestampType.html#values--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Record.TimestampType"/></returns>
        public static Org.Apache.Kafka.Common.Record.TimestampType[] Values()
        {
            return SExecuteArray<Org.Apache.Kafka.Common.Record.TimestampType>(LocalBridgeClazz, "values");
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