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
    #region StreamTask
    public partial class StreamTask
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/StreamTask.html#%3Cinit%3E(org.apache.kafka.streams.processor.TaskId,java.util.Set,org.apache.kafka.streams.processor.internals.ProcessorTopology,org.apache.kafka.clients.consumer.Consumer,org.apache.kafka.streams.TopologyConfig.TaskConfig,org.apache.kafka.streams.processor.internals.metrics.StreamsMetricsImpl,org.apache.kafka.streams.processor.internals.StateDirectory,org.apache.kafka.streams.state.internals.ThreadCache,org.apache.kafka.common.utils.Time,org.apache.kafka.streams.processor.internals.ProcessorStateManager,org.apache.kafka.streams.processor.internals.RecordCollector,org.apache.kafka.streams.processor.internals.InternalProcessorContext,org.apache.kafka.common.utils.LogContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.TaskId"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Processor.Internals.ProcessorTopology"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Clients.Consumer.Consumer"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Streams.TopologyConfig.TaskConfig"/></param>
        /// <param name="arg5"><see cref="Org.Apache.Kafka.Streams.Processor.Internals.Metrics.StreamsMetricsImpl"/></param>
        /// <param name="arg6"><see cref="Org.Apache.Kafka.Streams.Processor.Internals.StateDirectory"/></param>
        /// <param name="arg7"><see cref="Org.Apache.Kafka.Streams.State.Internals.ThreadCache"/></param>
        /// <param name="arg8"><see cref="Org.Apache.Kafka.Common.Utils.Time"/></param>
        /// <param name="arg9"><see cref="Org.Apache.Kafka.Streams.Processor.Internals.ProcessorStateManager"/></param>
        /// <param name="arg10"><see cref="Org.Apache.Kafka.Streams.Processor.Internals.RecordCollector"/></param>
        /// <param name="arg11"><see cref="Org.Apache.Kafka.Streams.Processor.Internals.InternalProcessorContext"/></param>
        /// <param name="arg12"><see cref="Org.Apache.Kafka.Common.Utils.LogContext"/></param>
        public StreamTask(Org.Apache.Kafka.Streams.Processor.TaskId arg0, Java.Util.Set arg1, Org.Apache.Kafka.Streams.Processor.Internals.ProcessorTopology arg2, Org.Apache.Kafka.Clients.Consumer.Consumer arg3, Org.Apache.Kafka.Streams.TopologyConfig.TaskConfig arg4, Org.Apache.Kafka.Streams.Processor.Internals.Metrics.StreamsMetricsImpl arg5, Org.Apache.Kafka.Streams.Processor.Internals.StateDirectory arg6, Org.Apache.Kafka.Streams.State.Internals.ThreadCache arg7, Org.Apache.Kafka.Common.Utils.Time arg8, Org.Apache.Kafka.Streams.Processor.Internals.ProcessorStateManager arg9, Org.Apache.Kafka.Streams.Processor.Internals.RecordCollector arg10, Org.Apache.Kafka.Streams.Processor.Internals.InternalProcessorContext arg11, Org.Apache.Kafka.Common.Utils.LogContext arg12)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Processor.Internals.StreamTask"/> to <see cref="Org.Apache.Kafka.Streams.Processor.Internals.ProcessorNodePunctuator"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Processor.Internals.ProcessorNodePunctuator(Org.Apache.Kafka.Streams.Processor.Internals.StreamTask t) => t.Cast<Org.Apache.Kafka.Streams.Processor.Internals.ProcessorNodePunctuator>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/StreamTask.html#hasRecordsQueued()"/> 
        /// </summary>
        public bool HasRecordsQueued
        {
            get { return IExecute<bool>("hasRecordsQueued"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/StreamTask.html#processorContext()"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.Processor.Internals.InternalProcessorContext ProcessorContext
        {
            get { return IExecute<Org.Apache.Kafka.Streams.Processor.Internals.InternalProcessorContext>("processorContext"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/StreamTask.html#isProcessable(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsProcessable(long arg0)
        {
            return IExecute<bool>("isProcessable", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/StreamTask.html#toString(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string ToString(string arg0)
        {
            return IExecute<string>("toString", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/StreamTask.html#schedule(long,org.apache.kafka.streams.processor.PunctuationType,org.apache.kafka.streams.processor.Punctuator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Processor.PunctuationType"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Processor.Punctuator"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.Cancellable"/></returns>
        public Org.Apache.Kafka.Streams.Processor.Cancellable Schedule(long arg0, Org.Apache.Kafka.Streams.Processor.PunctuationType arg1, Org.Apache.Kafka.Streams.Processor.Punctuator arg2)
        {
            return IExecute<Org.Apache.Kafka.Streams.Processor.Cancellable>("schedule", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/StreamTask.html#punctuate(org.apache.kafka.streams.processor.internals.ProcessorNode,long,org.apache.kafka.streams.processor.PunctuationType,org.apache.kafka.streams.processor.Punctuator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Internals.ProcessorNode"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Processor.PunctuationType"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Streams.Processor.Punctuator"/></param>
        /// <typeparam name="Arg0Extendsobject"></typeparam>
        public void Punctuate<Arg0Extendsobject>(Org.Apache.Kafka.Streams.Processor.Internals.ProcessorNode<Arg0Extendsobject, Arg0Extendsobject, Arg0Extendsobject, Arg0Extendsobject> arg0, long arg1, Org.Apache.Kafka.Streams.Processor.PunctuationType arg2, Org.Apache.Kafka.Streams.Processor.Punctuator arg3)
        {
            IExecute("punctuate", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/StreamTask.html#updateCommittedOffsets(org.apache.kafka.common.TopicPartition,java.lang.Long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        public void UpdateCommittedOffsets(Org.Apache.Kafka.Common.TopicPartition arg0, long? arg1)
        {
            IExecute("updateCommittedOffsets", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/StreamTask.html#updateEndOffsets(org.apache.kafka.common.TopicPartition,java.lang.Long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        public void UpdateEndOffsets(Org.Apache.Kafka.Common.TopicPartition arg0, long? arg1)
        {
            IExecute("updateEndOffsets", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}