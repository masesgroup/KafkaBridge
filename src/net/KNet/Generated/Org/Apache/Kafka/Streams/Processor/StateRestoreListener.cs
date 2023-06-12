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

namespace Org.Apache.Kafka.Streams.Processor
{
    #region IStateRestoreListener
    /// <summary>
    /// .NET interface for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/StateRestoreListener.html"/>
    /// </summary>
    public partial interface IStateRestoreListener
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region StateRestoreListener
    public partial class StateRestoreListener : Org.Apache.Kafka.Streams.Processor.IStateRestoreListener
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/StateRestoreListener.html#onBatchRestored(org.apache.kafka.common.TopicPartition,java.lang.String,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        public virtual void OnBatchRestored(Org.Apache.Kafka.Common.TopicPartition arg0, string arg1, long arg2, long arg3)
        {
            
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/StateRestoreListener.html#onRestoreEnd(org.apache.kafka.common.TopicPartition,java.lang.String,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public virtual void OnRestoreEnd(Org.Apache.Kafka.Common.TopicPartition arg0, string arg1, long arg2)
        {
            
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/StateRestoreListener.html#onRestoreStart(org.apache.kafka.common.TopicPartition,java.lang.String,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        public virtual void OnRestoreStart(Org.Apache.Kafka.Common.TopicPartition arg0, string arg1, long arg2, long arg3)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}