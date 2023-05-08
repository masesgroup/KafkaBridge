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
    #region StoreChangelogReader
    public partial class StoreChangelogReader
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/StoreChangelogReader.html#%3Cinit%3E(org.apache.kafka.common.utils.Time,org.apache.kafka.streams.StreamsConfig,org.apache.kafka.common.utils.LogContext,org.apache.kafka.clients.admin.Admin,org.apache.kafka.clients.consumer.Consumer,org.apache.kafka.streams.processor.StateRestoreListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Utils.Time"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.StreamsConfig"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Utils.LogContext"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Clients.Admin.Admin"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Clients.Consumer.Consumer"/></param>
        /// <param name="arg5"><see cref="Org.Apache.Kafka.Streams.Processor.StateRestoreListener"/></param>
        public StoreChangelogReader(Org.Apache.Kafka.Common.Utils.Time arg0, Org.Apache.Kafka.Streams.StreamsConfig arg1, Org.Apache.Kafka.Common.Utils.LogContext arg2, Org.Apache.Kafka.Clients.Admin.Admin arg3, Org.Apache.Kafka.Clients.Consumer.Consumer arg4, Org.Apache.Kafka.Streams.Processor.StateRestoreListener arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Processor.Internals.StoreChangelogReader"/> to <see cref="Org.Apache.Kafka.Streams.Processor.Internals.ChangelogReader"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Processor.Internals.ChangelogReader(Org.Apache.Kafka.Streams.Processor.Internals.StoreChangelogReader t) => t.Cast<Org.Apache.Kafka.Streams.Processor.Internals.ChangelogReader>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/StoreChangelogReader.html#allChangelogsCompleted()"/> 
        /// </summary>
        public bool AllChangelogsCompleted
        {
            get { return IExecute<bool>("allChangelogsCompleted"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/StoreChangelogReader.html#completedChangelogs()"/> 
        /// </summary>
        public Java.Util.Set<Org.Apache.Kafka.Common.TopicPartition> CompletedChangelogs
        {
            get { return IExecute<Java.Util.Set<Org.Apache.Kafka.Common.TopicPartition>>("completedChangelogs"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/StoreChangelogReader.html#isEmpty()"/> 
        /// </summary>
        public bool IsEmpty
        {
            get { return IExecute<bool>("isEmpty"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/StoreChangelogReader.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecute("clear");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/StoreChangelogReader.html#enforceRestoreActive()"/>
        /// </summary>
        public void EnforceRestoreActive()
        {
            IExecute("enforceRestoreActive");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/StoreChangelogReader.html#register(java.util.Set,org.apache.kafka.streams.processor.internals.ProcessorStateManager)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Processor.Internals.ProcessorStateManager"/></param>
        public void Register(Java.Util.Set<Org.Apache.Kafka.Common.TopicPartition> arg0, Org.Apache.Kafka.Streams.Processor.Internals.ProcessorStateManager arg1)
        {
            IExecute("register", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/StoreChangelogReader.html#register(org.apache.kafka.common.TopicPartition,org.apache.kafka.streams.processor.internals.ProcessorStateManager)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Processor.Internals.ProcessorStateManager"/></param>
        public void Register(Org.Apache.Kafka.Common.TopicPartition arg0, Org.Apache.Kafka.Streams.Processor.Internals.ProcessorStateManager arg1)
        {
            IExecute("register", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/StoreChangelogReader.html#restore(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public void Restore(Java.Util.Map<Org.Apache.Kafka.Streams.Processor.TaskId, Org.Apache.Kafka.Streams.Processor.Internals.Task> arg0)
        {
            IExecute("restore", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/StoreChangelogReader.html#transitToUpdateStandby()"/>
        /// </summary>
        public void TransitToUpdateStandby()
        {
            IExecute("transitToUpdateStandby");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/StoreChangelogReader.html#unregister(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public void Unregister(Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartition> arg0)
        {
            IExecute("unregister", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}