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
*  using kafka-streams-3.6.2.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Kstream
{
    #region ForeachProcessor
    public partial class ForeachProcessor
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/ForeachProcessor.html#org.apache.kafka.streams.kstream.ForeachProcessor(org.apache.kafka.streams.kstream.ForeachAction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.ForeachAction"/></param>
        public ForeachProcessor(Org.Apache.Kafka.Streams.Kstream.ForeachAction arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Kstream.ForeachProcessor"/> to <see cref="Org.Apache.Kafka.Streams.Processor.Api.Processor"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Processor.Api.Processor(Org.Apache.Kafka.Streams.Kstream.ForeachProcessor t) => t.Cast<Org.Apache.Kafka.Streams.Processor.Api.Processor>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/ForeachProcessor.html#process-org.apache.kafka.streams.processor.api.Record-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.Record"/></param>
        public void Process(Org.Apache.Kafka.Streams.Processor.Api.Record arg0)
        {
            IExecuteWithSignature("process", "(Lorg/apache/kafka/streams/processor/api/Record;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ForeachProcessor<K, V>
    public partial class ForeachProcessor<K, V>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/ForeachProcessor.html#org.apache.kafka.streams.kstream.ForeachProcessor(org.apache.kafka.streams.kstream.ForeachAction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.ForeachAction"/></param>
        public ForeachProcessor(Org.Apache.Kafka.Streams.Kstream.ForeachAction<K, V> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Kstream.ForeachProcessor{K, V}"/> to <see cref="Org.Apache.Kafka.Streams.Processor.Api.Processor"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Processor.Api.Processor(Org.Apache.Kafka.Streams.Kstream.ForeachProcessor<K, V> t) => t.Cast<Org.Apache.Kafka.Streams.Processor.Api.Processor>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Kstream.ForeachProcessor{K, V}"/> to <see cref="Org.Apache.Kafka.Streams.Kstream.ForeachProcessor"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Kstream.ForeachProcessor(Org.Apache.Kafka.Streams.Kstream.ForeachProcessor<K, V> t) => t.Cast<Org.Apache.Kafka.Streams.Kstream.ForeachProcessor>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/ForeachProcessor.html#process-org.apache.kafka.streams.processor.api.Record-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.Record"/></param>
        public void Process(Org.Apache.Kafka.Streams.Processor.Api.Record<K, V> arg0)
        {
            IExecuteWithSignature("process", "(Lorg/apache/kafka/streams/processor/api/Record;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}