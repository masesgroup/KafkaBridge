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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using kafka-streams-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Processor.Api
{
    #region ContextualFixedKeyProcessor
    public partial class ContextualFixedKeyProcessor
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Processor.Api.ContextualFixedKeyProcessor"/> to <see cref="Org.Apache.Kafka.Streams.Processor.Api.FixedKeyProcessor"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Processor.Api.FixedKeyProcessor(Org.Apache.Kafka.Streams.Processor.Api.ContextualFixedKeyProcessor t) => t.Cast<Org.Apache.Kafka.Streams.Processor.Api.FixedKeyProcessor>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/processor/api/ContextualFixedKeyProcessor.html#init-org.apache.kafka.streams.processor.api.FixedKeyProcessorContext-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.FixedKeyProcessorContext"/></param>
        public void Init(Org.Apache.Kafka.Streams.Processor.Api.FixedKeyProcessorContext arg0)
        {
            IExecute("init", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ContextualFixedKeyProcessor<KIn, VIn, VOut>
    public partial class ContextualFixedKeyProcessor<KIn, VIn, VOut>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Processor.Api.ContextualFixedKeyProcessor{KIn, VIn, VOut}"/> to <see cref="Org.Apache.Kafka.Streams.Processor.Api.FixedKeyProcessor{KIn, VIn, VOut}"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Processor.Api.FixedKeyProcessor<KIn, VIn, VOut>(Org.Apache.Kafka.Streams.Processor.Api.ContextualFixedKeyProcessor<KIn, VIn, VOut> t) => t.Cast<Org.Apache.Kafka.Streams.Processor.Api.FixedKeyProcessor<KIn, VIn, VOut>>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Processor.Api.ContextualFixedKeyProcessor{KIn, VIn, VOut}"/> to <see cref="Org.Apache.Kafka.Streams.Processor.Api.ContextualFixedKeyProcessor"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Processor.Api.ContextualFixedKeyProcessor(Org.Apache.Kafka.Streams.Processor.Api.ContextualFixedKeyProcessor<KIn, VIn, VOut> t) => t.Cast<Org.Apache.Kafka.Streams.Processor.Api.ContextualFixedKeyProcessor>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/processor/api/ContextualFixedKeyProcessor.html#init-org.apache.kafka.streams.processor.api.FixedKeyProcessorContext-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.FixedKeyProcessorContext"/></param>
        public void Init(Org.Apache.Kafka.Streams.Processor.Api.FixedKeyProcessorContext<KIn, VOut> arg0)
        {
            IExecute("init", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}