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
    #region SimpleRecord
    public partial class SimpleRecord
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/record/SimpleRecord.html#%3Cinit%3E(byte[],byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        public SimpleRecord(byte[] arg0, byte[] arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/record/SimpleRecord.html#%3Cinit%3E(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        public SimpleRecord(byte[] arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/record/SimpleRecord.html#%3Cinit%3E(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        public SimpleRecord(Java.Nio.ByteBuffer arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/record/SimpleRecord.html#%3Cinit%3E(long,byte[],byte[],org.apache.kafka.common.header.Header[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Common.Header.Header"/></param>
        public SimpleRecord(long arg0, byte[] arg1, byte[] arg2, Org.Apache.Kafka.Common.Header.Header[] arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/record/SimpleRecord.html#%3Cinit%3E(long,byte[],byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        public SimpleRecord(long arg0, byte[] arg1, byte[] arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/record/SimpleRecord.html#%3Cinit%3E(long,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        public SimpleRecord(long arg0, byte[] arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/record/SimpleRecord.html#%3Cinit%3E(long,java.nio.ByteBuffer,java.nio.ByteBuffer,org.apache.kafka.common.header.Header[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg2"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Common.Header.Header"/></param>
        public SimpleRecord(long arg0, Java.Nio.ByteBuffer arg1, Java.Nio.ByteBuffer arg2, Org.Apache.Kafka.Common.Header.Header[] arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/record/SimpleRecord.html#%3Cinit%3E(long,java.nio.ByteBuffer,java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg2"><see cref="Java.Nio.ByteBuffer"/></param>
        public SimpleRecord(long arg0, Java.Nio.ByteBuffer arg1, Java.Nio.ByteBuffer arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/record/SimpleRecord.html#%3Cinit%3E(org.apache.kafka.common.record.Record)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Record.Record"/></param>
        public SimpleRecord(Org.Apache.Kafka.Common.Record.Record arg0)
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
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/record/SimpleRecord.html#headers()"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.Header.Header[] Headers
        {
            get { return IExecuteArray<Org.Apache.Kafka.Common.Header.Header>("headers"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/record/SimpleRecord.html#key()"/> 
        /// </summary>
        public Java.Nio.ByteBuffer Key
        {
            get { return IExecute<Java.Nio.ByteBuffer>("key"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/record/SimpleRecord.html#timestamp()"/> 
        /// </summary>
        public long Timestamp
        {
            get { return IExecute<long>("timestamp"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/record/SimpleRecord.html#value()"/> 
        /// </summary>
        public Java.Nio.ByteBuffer Value
        {
            get { return IExecute<Java.Nio.ByteBuffer>("value"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}