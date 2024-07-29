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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using kafka-clients-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Record
{
    #region RecordValidationStats
    public partial class RecordValidationStats
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/record/RecordValidationStats.html#org.apache.kafka.common.record.RecordValidationStats(long,int,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public RecordValidationStats(long arg0, int arg1, long arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/record/RecordValidationStats.html#EMPTY"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Record.RecordValidationStats EMPTY { get { if (!_EMPTYReady) { _EMPTYContent = SGetField<Org.Apache.Kafka.Common.Record.RecordValidationStats>(LocalBridgeClazz, "EMPTY"); _EMPTYReady = true; } return _EMPTYContent; } }
        private static Org.Apache.Kafka.Common.Record.RecordValidationStats _EMPTYContent = default;
        private static bool _EMPTYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/record/RecordValidationStats.html#numRecordsConverted--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int NumRecordsConverted()
        {
            return IExecuteWithSignature<int>("numRecordsConverted", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/record/RecordValidationStats.html#conversionTimeNanos--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long ConversionTimeNanos()
        {
            return IExecuteWithSignature<long>("conversionTimeNanos", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/record/RecordValidationStats.html#temporaryMemoryBytes--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long TemporaryMemoryBytes()
        {
            return IExecuteWithSignature<long>("temporaryMemoryBytes", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/record/RecordValidationStats.html#add-org.apache.kafka.common.record.RecordValidationStats-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Record.RecordValidationStats"/></param>
        public void Add(Org.Apache.Kafka.Common.Record.RecordValidationStats arg0)
        {
            IExecuteWithSignature("add", "(Lorg/apache/kafka/common/record/RecordValidationStats;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}