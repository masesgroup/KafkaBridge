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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using kafka-clients-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Record
{
    #region DefaultRecordsSend
    public partial class DefaultRecordsSend
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/record/DefaultRecordsSend.html#%3Cinit%3E(org.apache.kafka.common.record.TransferableRecords,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Record.TransferableRecords"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public DefaultRecordsSend(Org.Apache.Kafka.Common.Record.TransferableRecords arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/record/DefaultRecordsSend.html#%3Cinit%3E(org.apache.kafka.common.record.TransferableRecords)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Record.TransferableRecords"/></param>
        public DefaultRecordsSend(Org.Apache.Kafka.Common.Record.TransferableRecords arg0)
            : base(arg0)
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

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DefaultRecordsSend<T>
    public partial class DefaultRecordsSend<T>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/record/DefaultRecordsSend.html#%3Cinit%3E(org.apache.kafka.common.record.TransferableRecords,int)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public DefaultRecordsSend(T arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/record/DefaultRecordsSend.html#%3Cinit%3E(org.apache.kafka.common.record.TransferableRecords)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        public DefaultRecordsSend(T arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Common.Record.DefaultRecordsSend{T}"/> to <see cref="Org.Apache.Kafka.Common.Record.DefaultRecordsSend"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Record.DefaultRecordsSend(Org.Apache.Kafka.Common.Record.DefaultRecordsSend<T> t) => t.Cast<Org.Apache.Kafka.Common.Record.DefaultRecordsSend>();

        #endregion

        #region Fields

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