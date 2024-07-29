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
*  using kafka-streams-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Processor.Api
{
    #region FixedKeyProcessorContext
    public partial class FixedKeyProcessorContext
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/api/FixedKeyProcessorContext.html#forward-org.apache.kafka.streams.processor.api.FixedKeyRecord-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.FixedKeyRecord"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void Forward(Org.Apache.Kafka.Streams.Processor.Api.FixedKeyRecord arg0, Java.Lang.String arg1)
        {
            IExecute("forward", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/api/FixedKeyProcessorContext.html#forward-org.apache.kafka.streams.processor.api.FixedKeyRecord-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.FixedKeyRecord"/></param>
        public void Forward(Org.Apache.Kafka.Streams.Processor.Api.FixedKeyRecord arg0)
        {
            IExecute("forward", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IFixedKeyProcessorContext<KForward, VForward>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IFixedKeyProcessorContext<KForward, VForward> : Org.Apache.Kafka.Streams.Processor.Api.IProcessingContext
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region FixedKeyProcessorContext<KForward, VForward>
    public partial class FixedKeyProcessorContext<KForward, VForward> : Org.Apache.Kafka.Streams.Processor.Api.IFixedKeyProcessorContext<KForward, VForward>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Processor.Api.FixedKeyProcessorContext{KForward, VForward}"/> to <see cref="Org.Apache.Kafka.Streams.Processor.Api.FixedKeyProcessorContext"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Processor.Api.FixedKeyProcessorContext(Org.Apache.Kafka.Streams.Processor.Api.FixedKeyProcessorContext<KForward, VForward> t) => t.Cast<Org.Apache.Kafka.Streams.Processor.Api.FixedKeyProcessorContext>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/api/FixedKeyProcessorContext.html#forward-org.apache.kafka.streams.processor.api.FixedKeyRecord-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.FixedKeyRecord"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <typeparam name="K"><typeparamref name="KForward"/></typeparam>
        /// <typeparam name="V"><typeparamref name="VForward"/></typeparam>
        public void Forward<K, V>(Org.Apache.Kafka.Streams.Processor.Api.FixedKeyRecord<K, V> arg0, Java.Lang.String arg1) where K : KForward where V : VForward
        {
            IExecute("forward", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/api/FixedKeyProcessorContext.html#forward-org.apache.kafka.streams.processor.api.FixedKeyRecord-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Api.FixedKeyRecord"/></param>
        /// <typeparam name="K"><typeparamref name="KForward"/></typeparam>
        /// <typeparam name="V"><typeparamref name="VForward"/></typeparam>
        public void Forward<K, V>(Org.Apache.Kafka.Streams.Processor.Api.FixedKeyRecord<K, V> arg0) where K : KForward where V : VForward
        {
            IExecute("forward", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}