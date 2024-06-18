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
*  This file is generated by MASES.JNetReflector (ver. 2.5.3.0)
*  using kafka-streams-3.7.0.jar as reference
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/ThreadMetadata.html#adminClientId--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String AdminClientId()
        {
            return IExecuteWithSignature<Java.Lang.String>("adminClientId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/ThreadMetadata.html#consumerClientId--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ConsumerClientId()
        {
            return IExecuteWithSignature<Java.Lang.String>("consumerClientId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/ThreadMetadata.html#restoreConsumerClientId--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String RestoreConsumerClientId()
        {
            return IExecuteWithSignature<Java.Lang.String>("restoreConsumerClientId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/ThreadMetadata.html#threadName--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ThreadName()
        {
            return IExecuteWithSignature<Java.Lang.String>("threadName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/ThreadMetadata.html#threadState--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ThreadState()
        {
            return IExecuteWithSignature<Java.Lang.String>("threadState", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/ThreadMetadata.html#producerClientIds--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> ProducerClientIds()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("producerClientIds", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/ThreadMetadata.html#activeTasks--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Org.Apache.Kafka.Streams.TaskMetadata> ActiveTasks()
        {
            return IExecuteWithSignature<Java.Util.Set<Org.Apache.Kafka.Streams.TaskMetadata>>("activeTasks", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/ThreadMetadata.html#standbyTasks--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Org.Apache.Kafka.Streams.TaskMetadata> StandbyTasks()
        {
            return IExecuteWithSignature<Java.Util.Set<Org.Apache.Kafka.Streams.TaskMetadata>>("standbyTasks", "()Ljava/util/Set;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}