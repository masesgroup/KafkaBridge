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
*  This file is generated by MASES.JNetReflector (ver. 2.5.4.0)
*  using kafka-streams-3.7.0.jar as reference
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/PunctuationType.html#STREAM_TIME"/>
        /// </summary>
        public static Org.Apache.Kafka.Streams.Processor.PunctuationType STREAM_TIME { get { if (!_STREAM_TIMEReady) { _STREAM_TIMEContent = SGetField<Org.Apache.Kafka.Streams.Processor.PunctuationType>(LocalBridgeClazz, "STREAM_TIME"); _STREAM_TIMEReady = true; } return _STREAM_TIMEContent; } }
        private static Org.Apache.Kafka.Streams.Processor.PunctuationType _STREAM_TIMEContent = default;
        private static bool _STREAM_TIMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/PunctuationType.html#WALL_CLOCK_TIME"/>
        /// </summary>
        public static Org.Apache.Kafka.Streams.Processor.PunctuationType WALL_CLOCK_TIME { get { if (!_WALL_CLOCK_TIMEReady) { _WALL_CLOCK_TIMEContent = SGetField<Org.Apache.Kafka.Streams.Processor.PunctuationType>(LocalBridgeClazz, "WALL_CLOCK_TIME"); _WALL_CLOCK_TIMEReady = true; } return _WALL_CLOCK_TIMEContent; } }
        private static Org.Apache.Kafka.Streams.Processor.PunctuationType _WALL_CLOCK_TIMEContent = default;
        private static bool _WALL_CLOCK_TIMEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/PunctuationType.html#valueOf-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.PunctuationType"/></returns>
        public static Org.Apache.Kafka.Streams.Processor.PunctuationType ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Streams.Processor.PunctuationType>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/streams/processor/PunctuationType;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/PunctuationType.html#values--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.PunctuationType"/></returns>
        public static Org.Apache.Kafka.Streams.Processor.PunctuationType[] Values()
        {
            return SExecuteWithSignatureArray<Org.Apache.Kafka.Streams.Processor.PunctuationType>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/streams/processor/PunctuationType;");
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