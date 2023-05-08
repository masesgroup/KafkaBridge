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
    #region TaskManager
    public partial class TaskManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/TaskManager.html#executeAndMaybeSwallow(boolean,java.lang.Runnable,java.lang.String,org.slf4j.Logger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="Org.Slf4j.Logger"/></param>
        public static void ExecuteAndMaybeSwallow(bool arg0, Java.Lang.Runnable arg1, string arg2, Org.Slf4j.Logger arg3)
        {
            SExecute(LocalBridgeClazz, "executeAndMaybeSwallow", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/TaskManager.html#executeAndMaybeSwallow(boolean,java.lang.Runnable,java.util.function.Consumer,java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.Consumer"/></param>
        /// <param name="arg3"><see cref="Java.Util.Function.Consumer"/></param>
        public static void ExecuteAndMaybeSwallow(bool arg0, Java.Lang.Runnable arg1, Java.Util.Function.Consumer<Java.Lang.RuntimeException> arg2, Java.Util.Function.Consumer<Java.Lang.RuntimeException> arg3)
        {
            SExecute(LocalBridgeClazz, "executeAndMaybeSwallow", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/TaskManager.html#processId()"/> 
        /// </summary>
        public Java.Util.UUID ProcessId
        {
            get { return IExecute<Java.Util.UUID>("processId"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/TaskManager.html#getTaskOffsetSums()"/> 
        /// </summary>
        public Java.Util.Map<Org.Apache.Kafka.Streams.Processor.TaskId, long?> TaskOffsetSums
        {
            get { return IExecute<Java.Util.Map<Org.Apache.Kafka.Streams.Processor.TaskId, long?>>("getTaskOffsetSums"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/TaskManager.html#topologyMetadata()"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.Processor.Internals.TopologyMetadata TopologyMetadata
        {
            get { return IExecute<Org.Apache.Kafka.Streams.Processor.Internals.TopologyMetadata>("topologyMetadata"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/TaskManager.html#totalProducerBlockedTime()"/> 
        /// </summary>
        public double TotalProducerBlockedTime
        {
            get { return IExecute<double>("totalProducerBlockedTime"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/TaskManager.html#checkStateUpdater(long,java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Consumer"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CheckStateUpdater(long arg0, Java.Util.Function.Consumer<Java.Util.Set<Org.Apache.Kafka.Common.TopicPartition>> arg1)
        {
            return IExecute<bool>("checkStateUpdater", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/TaskManager.html#toString(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string ToString(string arg0)
        {
            return IExecute<string>("toString", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/TaskManager.html#handleAssignment(java.util.Map,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        public void HandleAssignment(Java.Util.Map<Org.Apache.Kafka.Streams.Processor.TaskId, Java.Util.Set<Org.Apache.Kafka.Common.TopicPartition>> arg0, Java.Util.Map<Org.Apache.Kafka.Streams.Processor.TaskId, Java.Util.Set<Org.Apache.Kafka.Common.TopicPartition>> arg1)
        {
            IExecute("handleAssignment", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/TaskManager.html#handleExceptionsFromStateUpdater()"/>
        /// </summary>
        public void HandleExceptionsFromStateUpdater()
        {
            IExecute("handleExceptionsFromStateUpdater");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/TaskManager.html#updateTaskEndMetadata(org.apache.kafka.common.TopicPartition,java.lang.Long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        public void UpdateTaskEndMetadata(Org.Apache.Kafka.Common.TopicPartition arg0, long? arg1)
        {
            IExecute("updateTaskEndMetadata", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}