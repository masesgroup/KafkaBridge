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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using kafka-raft-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Raft
{
    #region ReplicatedCounter
    public partial class ReplicatedCounter
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/ReplicatedCounter.html#org.apache.kafka.raft.ReplicatedCounter(int,org.apache.kafka.raft.RaftClient,org.apache.kafka.common.utils.LogContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Raft.RaftClient"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Utils.LogContext"/></param>
        public ReplicatedCounter(int arg0, Org.Apache.Kafka.Raft.RaftClient<Java.Lang.Integer> arg1, Org.Apache.Kafka.Common.Utils.LogContext arg2)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/ReplicatedCounter.html#handleLoadSnapshotCalls--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int HandleLoadSnapshotCalls()
        {
            return IExecuteWithSignature<int>("handleLoadSnapshotCalls", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/ReplicatedCounter.html#isWritable--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsWritable()
        {
            return IExecuteWithSignature<bool>("isWritable", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/ReplicatedCounter.html#handleCommit-org.apache.kafka.raft.BatchReader-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Raft.BatchReader"/></param>
        public void HandleCommit(Org.Apache.Kafka.Raft.BatchReader<Java.Lang.Integer> arg0)
        {
            IExecuteWithSignature("handleCommit", "(Lorg/apache/kafka/raft/BatchReader;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/ReplicatedCounter.html#handleLeaderChange-org.apache.kafka.raft.LeaderAndEpoch-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Raft.LeaderAndEpoch"/></param>
        public void HandleLeaderChange(Org.Apache.Kafka.Raft.LeaderAndEpoch arg0)
        {
            IExecuteWithSignature("handleLeaderChange", "(Lorg/apache/kafka/raft/LeaderAndEpoch;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/ReplicatedCounter.html#handleLoadSnapshot-org.apache.kafka.snapshot.SnapshotReader-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Snapshot.SnapshotReader"/></param>
        public void HandleLoadSnapshot(Org.Apache.Kafka.Snapshot.SnapshotReader<Java.Lang.Integer> arg0)
        {
            IExecuteWithSignature("handleLoadSnapshot", "(Lorg/apache/kafka/snapshot/SnapshotReader;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/ReplicatedCounter.html#increment--"/>
        /// </summary>
        public void Increment()
        {
            IExecuteWithSignature("increment", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}