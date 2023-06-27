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
*  This file is generated by MASES.JNetReflector (ver. 2.0.0.0)
*  using kafka-streams-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Processor
{
    #region PunctuationType
    public partial class PunctuationType
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/PunctuationType.html#STREAM_TIME"/>
        /// </summary>
        public static Org.Apache.Kafka.Streams.Processor.PunctuationType STREAM_TIME { get { return SGetField<Org.Apache.Kafka.Streams.Processor.PunctuationType>(LocalBridgeClazz, "STREAM_TIME"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/PunctuationType.html#WALL_CLOCK_TIME"/>
        /// </summary>
        public static Org.Apache.Kafka.Streams.Processor.PunctuationType WALL_CLOCK_TIME { get { return SGetField<Org.Apache.Kafka.Streams.Processor.PunctuationType>(LocalBridgeClazz, "WALL_CLOCK_TIME"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/PunctuationType.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.PunctuationType"/></returns>
        public static Org.Apache.Kafka.Streams.Processor.PunctuationType ValueOf(string arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Processor.PunctuationType>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/PunctuationType.html#values()"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.PunctuationType"/></returns>
        public static Org.Apache.Kafka.Streams.Processor.PunctuationType[] Values()
        {
            return SExecuteArray<Org.Apache.Kafka.Streams.Processor.PunctuationType>(LocalBridgeClazz, "values");
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}