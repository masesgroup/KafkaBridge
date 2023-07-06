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
*  using kafka-streams-3.5.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams
{
    #region IThreadMetadata
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IThreadMetadata
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ThreadMetadata
    public partial class ThreadMetadata : Org.Apache.Kafka.Streams.IThreadMetadata
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/ThreadMetadata.html#adminClientId--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string AdminClientId()
        {
            return IExecute<string>("adminClientId");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/ThreadMetadata.html#consumerClientId--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string ConsumerClientId()
        {
            return IExecute<string>("consumerClientId");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/ThreadMetadata.html#restoreConsumerClientId--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string RestoreConsumerClientId()
        {
            return IExecute<string>("restoreConsumerClientId");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/ThreadMetadata.html#threadName--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string ThreadName()
        {
            return IExecute<string>("threadName");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/ThreadMetadata.html#threadState--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string ThreadState()
        {
            return IExecute<string>("threadState");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/ThreadMetadata.html#producerClientIds--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<string> ProducerClientIds()
        {
            return IExecute<Java.Util.Set<string>>("producerClientIds");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/ThreadMetadata.html#activeTasks--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Org.Apache.Kafka.Streams.TaskMetadata> ActiveTasks()
        {
            return IExecute<Java.Util.Set<Org.Apache.Kafka.Streams.TaskMetadata>>("activeTasks");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/ThreadMetadata.html#standbyTasks--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Org.Apache.Kafka.Streams.TaskMetadata> StandbyTasks()
        {
            return IExecute<Java.Util.Set<Org.Apache.Kafka.Streams.TaskMetadata>>("standbyTasks");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}