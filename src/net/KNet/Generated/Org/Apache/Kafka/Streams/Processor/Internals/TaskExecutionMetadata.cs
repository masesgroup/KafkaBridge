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
    #region TaskExecutionMetadata
    public partial class TaskExecutionMetadata
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/TaskExecutionMetadata.html#%3Cinit%3E(java.util.Set,java.util.Set,org.apache.kafka.streams.internals.StreamsConfigUtils.ProcessingMode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Internals.StreamsConfigUtils.ProcessingMode"/></param>
        public TaskExecutionMetadata(Java.Util.Set arg0, Java.Util.Set arg1, Org.Apache.Kafka.Streams.Internals.StreamsConfigUtils.ProcessingMode arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/TaskExecutionMetadata.html#hasNamedTopologies()"/> 
        /// </summary>
        public bool HasNamedTopologies
        {
            get { return IExecute<bool>("hasNamedTopologies"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/TaskExecutionMetadata.html#processingMode()"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.Internals.StreamsConfigUtils.ProcessingMode ProcessingMode
        {
            get { return IExecute<Org.Apache.Kafka.Streams.Internals.StreamsConfigUtils.ProcessingMode>("processingMode"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/TaskExecutionMetadata.html#canProcessTask(org.apache.kafka.streams.processor.internals.Task,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Internals.Task"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CanProcessTask(Org.Apache.Kafka.Streams.Processor.Internals.Task arg0, long arg1)
        {
            return IExecute<bool>("canProcessTask", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/TaskExecutionMetadata.html#canPunctuateTask(org.apache.kafka.streams.processor.internals.Task)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Internals.Task"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CanPunctuateTask(Org.Apache.Kafka.Streams.Processor.Internals.Task arg0)
        {
            return IExecute<bool>("canPunctuateTask", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/TaskExecutionMetadata.html#registerTaskError(org.apache.kafka.streams.processor.internals.Task,java.lang.Throwable,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Internals.Task"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Throwable"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public void RegisterTaskError(Org.Apache.Kafka.Streams.Processor.Internals.Task arg0, Java.Lang.Throwable arg1, long arg2)
        {
            IExecute("registerTaskError", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}