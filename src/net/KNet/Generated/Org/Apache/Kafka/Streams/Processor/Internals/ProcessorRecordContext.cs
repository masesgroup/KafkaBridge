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
*  using kafka-streams-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Processor.Internals
{
    #region ProcessorRecordContext
    public partial class ProcessorRecordContext
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/ProcessorRecordContext.html#%3Cinit%3E(long,long,int,java.lang.String,org.apache.kafka.common.header.Headers)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Common.Header.Headers"/></param>
        public ProcessorRecordContext(long arg0, long arg1, int arg2, string arg3, Org.Apache.Kafka.Common.Header.Headers arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Processor.Internals.ProcessorRecordContext"/> to <see cref="Org.Apache.Kafka.Streams.Processor.RecordContext"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Processor.RecordContext(Org.Apache.Kafka.Streams.Processor.Internals.ProcessorRecordContext t) => t.Cast<Org.Apache.Kafka.Streams.Processor.RecordContext>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Processor.Internals.ProcessorRecordContext"/> to <see cref="Org.Apache.Kafka.Streams.Processor.Api.RecordMetadata"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Processor.Api.RecordMetadata(Org.Apache.Kafka.Streams.Processor.Internals.ProcessorRecordContext t) => t.Cast<Org.Apache.Kafka.Streams.Processor.Api.RecordMetadata>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/ProcessorRecordContext.html#deserialize(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.Internals.ProcessorRecordContext"/></returns>
        public static Org.Apache.Kafka.Streams.Processor.Internals.ProcessorRecordContext Deserialize(Java.Nio.ByteBuffer arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Processor.Internals.ProcessorRecordContext>(LocalBridgeClazz, "deserialize", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/ProcessorRecordContext.html#headers()"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.Header.Headers Headers
        {
            get { return IExecute<Org.Apache.Kafka.Common.Header.Headers>("headers"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/ProcessorRecordContext.html#offset()"/> 
        /// </summary>
        public long Offset
        {
            get { return IExecute<long>("offset"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/ProcessorRecordContext.html#partition()"/> 
        /// </summary>
        public int Partition
        {
            get { return IExecute<int>("partition"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/ProcessorRecordContext.html#residentMemorySizeEstimate()"/> 
        /// </summary>
        public long ResidentMemorySizeEstimate
        {
            get { return IExecute<long>("residentMemorySizeEstimate"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/ProcessorRecordContext.html#serialize()"/> 
        /// </summary>
        public byte[] Serialize
        {
            get { return IExecuteArray<byte>("serialize"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/ProcessorRecordContext.html#timestamp()"/> 
        /// </summary>
        public long Timestamp
        {
            get { return IExecute<long>("timestamp"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/ProcessorRecordContext.html#topic()"/> 
        /// </summary>
        public string Topic
        {
            get { return IExecute<string>("topic"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}