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
*  This file is generated by MASES.JNetReflector (ver. 2.5.3.0)
*  using kafka-streams-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Processor
{
    #region TopicNameExtractor
    public partial class TopicNameExtractor
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
        /// Handlers initializer for <see cref="TopicNameExtractor"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("extract", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<object>>>(ExtractEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/TopicNameExtractor.html#extract-java.lang.Object-java.lang.Object-org.apache.kafka.streams.processor.RecordContext-"/>
        /// </summary>
        /// <remarks>If <see cref="OnExtract"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<object, object, Org.Apache.Kafka.Streams.Processor.RecordContext, Java.Lang.String> OnExtract { get; set; } = null;

        void ExtractEventHandler(object sender, CLRListenerEventArgs<CLREventData<object>> data)
        {
            var methodToExecute = (OnExtract != null) ? OnExtract : Extract;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<object>(0), data.EventData.GetAt<Org.Apache.Kafka.Streams.Processor.RecordContext>(1));
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/TopicNameExtractor.html#extract-java.lang.Object-java.lang.Object-org.apache.kafka.streams.processor.RecordContext-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Processor.RecordContext"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public virtual Java.Lang.String Extract(object arg0, object arg1, Org.Apache.Kafka.Streams.Processor.RecordContext arg2)
        {
            return default;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TopicNameExtractorDirect
    public partial class TopicNameExtractorDirect
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/TopicNameExtractor.html#extract-java.lang.Object-java.lang.Object-org.apache.kafka.streams.processor.RecordContext-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Processor.RecordContext"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public override Java.Lang.String Extract(object arg0, object arg1, Org.Apache.Kafka.Streams.Processor.RecordContext arg2)
        {
            return IExecute<Java.Lang.String>("extract", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ITopicNameExtractor<K, V>
    /// <summary>
    /// .NET interface for org.mases.knet.generated.org.apache.kafka.streams.processor.TopicNameExtractor implementing <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/TopicNameExtractor.html"/>
    /// </summary>
    public partial interface ITopicNameExtractor<K, V>
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TopicNameExtractor<K, V>
    public partial class TopicNameExtractor<K, V> : Org.Apache.Kafka.Streams.Processor.ITopicNameExtractor<K, V>
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
        /// Handlers initializer for <see cref="TopicNameExtractor"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("extract", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<K>>>(ExtractEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/TopicNameExtractor.html#extract-java.lang.Object-java.lang.Object-org.apache.kafka.streams.processor.RecordContext-"/>
        /// </summary>
        /// <remarks>If <see cref="OnExtract"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<K, V, Org.Apache.Kafka.Streams.Processor.RecordContext, Java.Lang.String> OnExtract { get; set; } = null;

        void ExtractEventHandler(object sender, CLRListenerEventArgs<CLREventData<K>> data)
        {
            var methodToExecute = (OnExtract != null) ? OnExtract : Extract;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<V>(0), data.EventData.GetAt<Org.Apache.Kafka.Streams.Processor.RecordContext>(1));
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/TopicNameExtractor.html#extract-java.lang.Object-java.lang.Object-org.apache.kafka.streams.processor.RecordContext-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Processor.RecordContext"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public virtual Java.Lang.String Extract(K arg0, V arg1, Org.Apache.Kafka.Streams.Processor.RecordContext arg2)
        {
            return default;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TopicNameExtractorDirect<K, V>
    public partial class TopicNameExtractorDirect<K, V> : Org.Apache.Kafka.Streams.Processor.ITopicNameExtractor<K, V>
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/TopicNameExtractor.html#extract-java.lang.Object-java.lang.Object-org.apache.kafka.streams.processor.RecordContext-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Processor.RecordContext"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public override Java.Lang.String Extract(K arg0, V arg1, Org.Apache.Kafka.Streams.Processor.RecordContext arg2)
        {
            return IExecute<Java.Lang.String>("extract", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}