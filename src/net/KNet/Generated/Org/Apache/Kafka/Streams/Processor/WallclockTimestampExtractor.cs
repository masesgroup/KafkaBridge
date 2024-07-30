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
*  using kafka-streams-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Processor
{
    #region WallclockTimestampExtractor
    public partial class WallclockTimestampExtractor
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Processor.WallclockTimestampExtractor"/> to <see cref="Org.Apache.Kafka.Streams.Processor.TimestampExtractor"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Processor.TimestampExtractor(Org.Apache.Kafka.Streams.Processor.WallclockTimestampExtractor t) => t.Cast<Org.Apache.Kafka.Streams.Processor.TimestampExtractor>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/WallclockTimestampExtractor.html#extract-org.apache.kafka.clients.consumer.ConsumerRecord-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerRecord"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long Extract(Org.Apache.Kafka.Clients.Consumer.ConsumerRecord<object, object> arg0, long arg1)
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