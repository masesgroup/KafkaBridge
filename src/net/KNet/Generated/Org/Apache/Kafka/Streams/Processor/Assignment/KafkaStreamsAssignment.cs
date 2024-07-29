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
*  using kafka-streams-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Processor.Assignment
{
    #region KafkaStreamsAssignment
    public partial class KafkaStreamsAssignment
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/assignment/KafkaStreamsAssignment.html#followupRebalanceDeadline--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Java.Time.Instant> FollowupRebalanceDeadline()
        {
            return IExecuteWithSignature<Java.Util.Optional<Java.Time.Instant>>("followupRebalanceDeadline", "()Ljava/util/Optional;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/assignment/KafkaStreamsAssignment.html#withFollowupRebalance-java.time.Instant-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.Assignment.KafkaStreamsAssignment"/></returns>
        public Org.Apache.Kafka.Streams.Processor.Assignment.KafkaStreamsAssignment WithFollowupRebalance(Java.Time.Instant arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Processor.Assignment.KafkaStreamsAssignment>("withFollowupRebalance", "(Ljava/time/Instant;)Lorg/apache/kafka/streams/processor/assignment/KafkaStreamsAssignment;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/assignment/KafkaStreamsAssignment.html#processId--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.Assignment.ProcessId"/></returns>
        public Org.Apache.Kafka.Streams.Processor.Assignment.ProcessId ProcessId()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Processor.Assignment.ProcessId>("processId", "()Lorg/apache/kafka/streams/processor/assignment/ProcessId;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}