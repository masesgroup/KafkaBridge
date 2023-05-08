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
    #region Task
    public partial class Task
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.html#LATEST_OFFSET"/>
        /// </summary>
        public static long LATEST_OFFSET { get { return SGetField<long>(LocalBridgeClazz, "LATEST_OFFSET"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.html#changelogOffsets()"/> 
        /// </summary>
        public Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, long?> ChangelogOffsets
        {
            get { return IExecute<Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, long?>>("changelogOffsets"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.html#changelogPartitions()"/> 
        /// </summary>
        public Java.Util.Set<Org.Apache.Kafka.Common.TopicPartition> ChangelogPartitions
        {
            get { return IExecute<Java.Util.Set<Org.Apache.Kafka.Common.TopicPartition>>("changelogPartitions"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.html#commitNeeded()"/> 
        /// </summary>
        public bool CommitNeeded
        {
            get { return IExecute<bool>("commitNeeded"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.html#commitRequested()"/> 
        /// </summary>
        public bool CommitRequested
        {
            get { return IExecute<bool>("commitRequested"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.html#committedOffsets()"/> 
        /// </summary>
        public Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, long?> CommittedOffsets
        {
            get { return IExecute<Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, long?>>("committedOffsets"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.html#highWaterMark()"/> 
        /// </summary>
        public Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, long?> HighWaterMark
        {
            get { return IExecute<Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, long?>>("highWaterMark"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.html#id()"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.Processor.TaskId Id
        {
            get { return IExecute<Org.Apache.Kafka.Streams.Processor.TaskId>("id"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.html#inputPartitions()"/> 
        /// </summary>
        public Java.Util.Set<Org.Apache.Kafka.Common.TopicPartition> InputPartitions
        {
            get { return IExecute<Java.Util.Set<Org.Apache.Kafka.Common.TopicPartition>>("inputPartitions"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.html#isActive()"/> 
        /// </summary>
        public bool IsActive
        {
            get { return IExecute<bool>("isActive"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.html#maybePunctuateStreamTime()"/> 
        /// </summary>
        public bool MaybePunctuateStreamTime
        {
            get { return IExecute<bool>("maybePunctuateStreamTime"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.html#maybePunctuateSystemTime()"/> 
        /// </summary>
        public bool MaybePunctuateSystemTime
        {
            get { return IExecute<bool>("maybePunctuateSystemTime"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.html#needsInitializationOrRestoration()"/> 
        /// </summary>
        public bool NeedsInitializationOrRestoration
        {
            get { return IExecute<bool>("needsInitializationOrRestoration"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.html#prepareCommit()"/> 
        /// </summary>
        public Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Clients.Consumer.OffsetAndMetadata> PrepareCommit
        {
            get { return IExecute<Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Clients.Consumer.OffsetAndMetadata>>("prepareCommit"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.html#purgeableOffsets()"/> 
        /// </summary>
        public Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, long?> PurgeableOffsets
        {
            get { return IExecute<Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, long?>>("purgeableOffsets"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.html#stateManager()"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.Processor.Internals.ProcessorStateManager StateManager
        {
            get { return IExecute<Org.Apache.Kafka.Streams.Processor.Internals.ProcessorStateManager>("stateManager"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.html#timeCurrentIdlingStarted()"/> 
        /// </summary>
        public Java.Util.Optional<long?> TimeCurrentIdlingStarted
        {
            get { return IExecute<Java.Util.Optional<long?>>("timeCurrentIdlingStarted"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.html#state()"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.Internals.Task.State"/></returns>
        public Org.Apache.Kafka.Streams.Processor.Internals.Task.State StateMethod()
        {
            return IExecute<Org.Apache.Kafka.Streams.Processor.Internals.Task.State>("state");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.html#getStore(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.StateStore"/></returns>
        public Org.Apache.Kafka.Streams.Processor.StateStore GetStore(string arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Processor.StateStore>("getStore", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.html#addRecords(org.apache.kafka.common.TopicPartition,java.lang.Iterable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Iterable"/></param>
        public void AddRecords(Org.Apache.Kafka.Common.TopicPartition arg0, Java.Lang.Iterable<Org.Apache.Kafka.Clients.Consumer.ConsumerRecord<byte[], byte[]>> arg1)
        {
            IExecute("addRecords", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.html#clearTaskTimeout()"/>
        /// </summary>
        public void ClearTaskTimeout()
        {
            IExecute("clearTaskTimeout");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.html#closeClean()"/>
        /// </summary>
        public void CloseClean()
        {
            IExecute("closeClean");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.html#closeDirty()"/>
        /// </summary>
        public void CloseDirty()
        {
            IExecute("closeDirty");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.html#completeRestoration(java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        public void CompleteRestoration(Java.Util.Function.Consumer<Java.Util.Set<Org.Apache.Kafka.Common.TopicPartition>> arg0)
        {
            IExecute("completeRestoration", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.html#initializeIfNeeded()"/>
        /// </summary>
        public void InitializeIfNeeded()
        {
            IExecute("initializeIfNeeded");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.html#markChangelogAsCorrupted(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public void MarkChangelogAsCorrupted(Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartition> arg0)
        {
            IExecute("markChangelogAsCorrupted", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.html#maybeCheckpoint(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void MaybeCheckpoint(bool arg0)
        {
            IExecute("maybeCheckpoint", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.html#maybeInitTaskTimeoutOrThrow(long,java.lang.Exception)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Exception"/></param>
        public void MaybeInitTaskTimeoutOrThrow(long arg0, Java.Lang.Exception arg1)
        {
            IExecute("maybeInitTaskTimeoutOrThrow", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.html#postCommit(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void PostCommit(bool arg0)
        {
            IExecute("postCommit", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.html#prepareRecycle()"/>
        /// </summary>
        public void PrepareRecycle()
        {
            IExecute("prepareRecycle");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.html#resume()"/>
        /// </summary>
        public void Resume()
        {
            IExecute("resume");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.html#revive()"/>
        /// </summary>
        public void Revive()
        {
            IExecute("revive");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.html#suspend()"/>
        /// </summary>
        public void Suspend()
        {
            IExecute("suspend");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.html#updateInputPartitions(java.util.Set,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        public void UpdateInputPartitions(Java.Util.Set<Org.Apache.Kafka.Common.TopicPartition> arg0, Java.Util.Map<string, Java.Util.List<string>> arg1)
        {
            IExecute("updateInputPartitions", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.html#process(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Process(long arg0)
        {
            return IExecute<bool>("process", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.html#addPartitionsForOffsetReset(java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        public void AddPartitionsForOffsetReset(Java.Util.Set<Org.Apache.Kafka.Common.TopicPartition> arg0)
        {
            IExecute("addPartitionsForOffsetReset", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.html#recordProcessBatchTime(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void RecordProcessBatchTime(long arg0)
        {
            IExecute("recordProcessBatchTime", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.html#recordProcessTimeRatioAndBufferSize(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        public void RecordProcessTimeRatioAndBufferSize(long arg0, long arg1)
        {
            IExecute("recordProcessTimeRatioAndBufferSize", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region State
        public partial class State
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.State.html#CLOSED"/>
            /// </summary>
            public static Org.Apache.Kafka.Streams.Processor.Internals.Task.State CLOSED { get { return SGetField<Org.Apache.Kafka.Streams.Processor.Internals.Task.State>(LocalBridgeClazz, "CLOSED"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.State.html#CREATED"/>
            /// </summary>
            public static Org.Apache.Kafka.Streams.Processor.Internals.Task.State CREATED { get { return SGetField<Org.Apache.Kafka.Streams.Processor.Internals.Task.State>(LocalBridgeClazz, "CREATED"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.State.html#RESTORING"/>
            /// </summary>
            public static Org.Apache.Kafka.Streams.Processor.Internals.Task.State RESTORING { get { return SGetField<Org.Apache.Kafka.Streams.Processor.Internals.Task.State>(LocalBridgeClazz, "RESTORING"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.State.html#RUNNING"/>
            /// </summary>
            public static Org.Apache.Kafka.Streams.Processor.Internals.Task.State RUNNING { get { return SGetField<Org.Apache.Kafka.Streams.Processor.Internals.Task.State>(LocalBridgeClazz, "RUNNING"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.State.html#SUSPENDED"/>
            /// </summary>
            public static Org.Apache.Kafka.Streams.Processor.Internals.Task.State SUSPENDED { get { return SGetField<Org.Apache.Kafka.Streams.Processor.Internals.Task.State>(LocalBridgeClazz, "SUSPENDED"); } }

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.State.html#values()"/> 
            /// </summary>
            public static Org.Apache.Kafka.Streams.Processor.Internals.Task.State[] Values
            {
                get { return SExecuteArray<Org.Apache.Kafka.Streams.Processor.Internals.Task.State>(LocalBridgeClazz, "values"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.State.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.Internals.Task.State"/></returns>
            public static Org.Apache.Kafka.Streams.Processor.Internals.Task.State ValueOf(string arg0)
            {
                return SExecute<Org.Apache.Kafka.Streams.Processor.Internals.Task.State>(LocalBridgeClazz, "valueOf", arg0);
            }

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.State.html#isValidTransition(org.apache.kafka.streams.processor.internals.Task.State)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Internals.Task.State"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool IsValidTransition(Org.Apache.Kafka.Streams.Processor.Internals.Task.State arg0)
            {
                return IExecute<bool>("isValidTransition", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region TaskType
        public partial class TaskType
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.TaskType.html#name"/>
            /// </summary>
            public string name { get { return IGetField<string>("name"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.TaskType.html#ACTIVE"/>
            /// </summary>
            public static Org.Apache.Kafka.Streams.Processor.Internals.Task.TaskType ACTIVE { get { return SGetField<Org.Apache.Kafka.Streams.Processor.Internals.Task.TaskType>(LocalBridgeClazz, "ACTIVE"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.TaskType.html#GLOBAL"/>
            /// </summary>
            public static Org.Apache.Kafka.Streams.Processor.Internals.Task.TaskType GLOBAL { get { return SGetField<Org.Apache.Kafka.Streams.Processor.Internals.Task.TaskType>(LocalBridgeClazz, "GLOBAL"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.TaskType.html#STANDBY"/>
            /// </summary>
            public static Org.Apache.Kafka.Streams.Processor.Internals.Task.TaskType STANDBY { get { return SGetField<Org.Apache.Kafka.Streams.Processor.Internals.Task.TaskType>(LocalBridgeClazz, "STANDBY"); } }

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.TaskType.html#values()"/> 
            /// </summary>
            public static Org.Apache.Kafka.Streams.Processor.Internals.Task.TaskType[] Values
            {
                get { return SExecuteArray<Org.Apache.Kafka.Streams.Processor.Internals.Task.TaskType>(LocalBridgeClazz, "values"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/Task.TaskType.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.Internals.Task.TaskType"/></returns>
            public static Org.Apache.Kafka.Streams.Processor.Internals.Task.TaskType ValueOf(string arg0)
            {
                return SExecute<Org.Apache.Kafka.Streams.Processor.Internals.Task.TaskType>(LocalBridgeClazz, "valueOf", arg0);
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}