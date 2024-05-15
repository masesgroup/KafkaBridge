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
    #region FileLogInputStream
    public partial class FileLogInputStream
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/FileLogInputStream.html#nextBatch--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Record.RecordBatch"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Org.Apache.Kafka.Common.Record.RecordBatch NextBatch()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Record.RecordBatch>("nextBatch", "()Lorg/apache/kafka/common/record/RecordBatch;");
        }

        #endregion

        #region Nested classes
        #region FileChannelRecordBatch
        public partial class FileChannelRecordBatch
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/record/FileLogInputStream.FileChannelRecordBatch.html#position--"/>
            /// </summary>

            /// <returns><see cref="int"/></returns>
            public int Position()
            {
                return IExecuteWithSignature<int>("position", "()I");
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