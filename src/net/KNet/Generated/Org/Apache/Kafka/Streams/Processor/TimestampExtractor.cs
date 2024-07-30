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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using kafka-streams-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Processor
{
    #region ITimestampExtractor
    /// <summary>
    /// .NET interface for org.mases.knet.generated.org.apache.kafka.streams.processor.TimestampExtractor implementing <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/TimestampExtractor.html"/>
    /// </summary>
    public partial interface ITimestampExtractor
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TimestampExtractor
    public partial class TimestampExtractor : Org.Apache.Kafka.Streams.Processor.ITimestampExtractor
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
        /// Handlers initializer for <see cref="TimestampExtractor"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("extract", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Clients.Consumer.ConsumerRecord<object, object>>>>(ExtractEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/TimestampExtractor.html#extract-org.apache.kafka.clients.consumer.ConsumerRecord-long-"/>
        /// </summary>
        /// <remarks>If <see cref="OnExtract"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Org.Apache.Kafka.Clients.Consumer.ConsumerRecord<object, object>, long, long> OnExtract { get; set; } = null;

        void ExtractEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Clients.Consumer.ConsumerRecord<object, object>>> data)
        {
            var methodToExecute = (OnExtract != null) ? OnExtract : Extract;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<long>(0));
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/TimestampExtractor.html#extract-org.apache.kafka.clients.consumer.ConsumerRecord-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerRecord"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public virtual long Extract(Org.Apache.Kafka.Clients.Consumer.ConsumerRecord<object, object> arg0, long arg1)
        {
            return default;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TimestampExtractorDirect
    public partial class TimestampExtractorDirect : Org.Apache.Kafka.Streams.Processor.ITimestampExtractor
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/TimestampExtractor.html#extract-org.apache.kafka.clients.consumer.ConsumerRecord-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerRecord"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public override long Extract(Org.Apache.Kafka.Clients.Consumer.ConsumerRecord<object, object> arg0, long arg1)
        {
            return IExecute<long>("extract", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}