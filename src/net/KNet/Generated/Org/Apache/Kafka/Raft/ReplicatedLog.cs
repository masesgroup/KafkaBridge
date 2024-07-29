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
*  using kafka-raft-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Raft
{
    #region IReplicatedLog
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IReplicatedLog : Java.Lang.IAutoCloseable
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ReplicatedLog
    public partial class ReplicatedLog : Org.Apache.Kafka.Raft.IReplicatedLog
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/ReplicatedLog.html#deleteBeforeSnapshot-org.apache.kafka.raft.OffsetAndEpoch-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Raft.OffsetAndEpoch"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool DeleteBeforeSnapshot(Org.Apache.Kafka.Raft.OffsetAndEpoch arg0)
        {
            return IExecuteWithSignature<bool>("deleteBeforeSnapshot", "(Lorg/apache/kafka/raft/OffsetAndEpoch;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/ReplicatedLog.html#maybeClean--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool MaybeClean()
        {
            return IExecuteWithSignature<bool>("maybeClean", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/ReplicatedLog.html#truncateToLatestSnapshot--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool TruncateToLatestSnapshot()
        {
            return IExecuteWithSignature<bool>("truncateToLatestSnapshot", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/ReplicatedLog.html#lastFetchedEpoch--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int LastFetchedEpoch()
        {
            return IExecuteWithSignature<int>("lastFetchedEpoch", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/ReplicatedLog.html#earliestSnapshotId--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Org.Apache.Kafka.Raft.OffsetAndEpoch> EarliestSnapshotId()
        {
            return IExecuteWithSignature<Java.Util.Optional<Org.Apache.Kafka.Raft.OffsetAndEpoch>>("earliestSnapshotId", "()Ljava/util/Optional;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/ReplicatedLog.html#latestSnapshotId--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Org.Apache.Kafka.Raft.OffsetAndEpoch> LatestSnapshotId()
        {
            return IExecuteWithSignature<Java.Util.Optional<Org.Apache.Kafka.Raft.OffsetAndEpoch>>("latestSnapshotId", "()Ljava/util/Optional;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/ReplicatedLog.html#latestSnapshot--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Org.Apache.Kafka.Snapshot.RawSnapshotReader> LatestSnapshot()
        {
            return IExecuteWithSignature<Java.Util.Optional<Org.Apache.Kafka.Snapshot.RawSnapshotReader>>("latestSnapshot", "()Ljava/util/Optional;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/ReplicatedLog.html#readSnapshot-org.apache.kafka.raft.OffsetAndEpoch-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Raft.OffsetAndEpoch"/></param>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Org.Apache.Kafka.Snapshot.RawSnapshotReader> ReadSnapshot(Org.Apache.Kafka.Raft.OffsetAndEpoch arg0)
        {
            return IExecuteWithSignature<Java.Util.Optional<Org.Apache.Kafka.Snapshot.RawSnapshotReader>>("readSnapshot", "(Lorg/apache/kafka/raft/OffsetAndEpoch;)Ljava/util/Optional;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/ReplicatedLog.html#createNewSnapshot-org.apache.kafka.raft.OffsetAndEpoch-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Raft.OffsetAndEpoch"/></param>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Org.Apache.Kafka.Snapshot.RawSnapshotWriter> CreateNewSnapshot(Org.Apache.Kafka.Raft.OffsetAndEpoch arg0)
        {
            return IExecuteWithSignature<Java.Util.Optional<Org.Apache.Kafka.Snapshot.RawSnapshotWriter>>("createNewSnapshot", "(Lorg/apache/kafka/raft/OffsetAndEpoch;)Ljava/util/Optional;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/ReplicatedLog.html#storeSnapshot-org.apache.kafka.raft.OffsetAndEpoch-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Raft.OffsetAndEpoch"/></param>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Org.Apache.Kafka.Snapshot.RawSnapshotWriter> StoreSnapshot(Org.Apache.Kafka.Raft.OffsetAndEpoch arg0)
        {
            return IExecuteWithSignature<Java.Util.Optional<Org.Apache.Kafka.Snapshot.RawSnapshotWriter>>("storeSnapshot", "(Lorg/apache/kafka/raft/OffsetAndEpoch;)Ljava/util/Optional;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/ReplicatedLog.html#startOffset--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long StartOffset()
        {
            return IExecuteWithSignature<long>("startOffset", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/ReplicatedLog.html#topicPartition--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.TopicPartition"/></returns>
        public Org.Apache.Kafka.Common.TopicPartition TopicPartition()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.TopicPartition>("topicPartition", "()Lorg/apache/kafka/common/TopicPartition;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/ReplicatedLog.html#topicId--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Uuid"/></returns>
        public Org.Apache.Kafka.Common.Uuid TopicId()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Uuid>("topicId", "()Lorg/apache/kafka/common/Uuid;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/ReplicatedLog.html#read-long-org.apache.kafka.raft.Isolation-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Raft.Isolation"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Raft.LogFetchInfo"/></returns>
        public Org.Apache.Kafka.Raft.LogFetchInfo Read(long arg0, Org.Apache.Kafka.Raft.Isolation arg1)
        {
            return IExecute<Org.Apache.Kafka.Raft.LogFetchInfo>("read", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/ReplicatedLog.html#endOffset--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Raft.LogOffsetMetadata"/></returns>
        public Org.Apache.Kafka.Raft.LogOffsetMetadata EndOffset()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.LogOffsetMetadata>("endOffset", "()Lorg/apache/kafka/raft/LogOffsetMetadata;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/ReplicatedLog.html#highWatermark--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Raft.LogOffsetMetadata"/></returns>
        public Org.Apache.Kafka.Raft.LogOffsetMetadata HighWatermark()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.LogOffsetMetadata>("highWatermark", "()Lorg/apache/kafka/raft/LogOffsetMetadata;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/ReplicatedLog.html#endOffsetForEpoch-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Raft.OffsetAndEpoch"/></returns>
        public Org.Apache.Kafka.Raft.OffsetAndEpoch EndOffsetForEpoch(int arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.OffsetAndEpoch>("endOffsetForEpoch", "(I)Lorg/apache/kafka/raft/OffsetAndEpoch;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/ReplicatedLog.html#flush-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void Flush(bool arg0)
        {
            IExecuteWithSignature("flush", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/ReplicatedLog.html#initializeLeaderEpoch-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void InitializeLeaderEpoch(int arg0)
        {
            IExecuteWithSignature("initializeLeaderEpoch", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/ReplicatedLog.html#onSnapshotFrozen-org.apache.kafka.raft.OffsetAndEpoch-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Raft.OffsetAndEpoch"/></param>
        public void OnSnapshotFrozen(Org.Apache.Kafka.Raft.OffsetAndEpoch arg0)
        {
            IExecuteWithSignature("onSnapshotFrozen", "(Lorg/apache/kafka/raft/OffsetAndEpoch;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/ReplicatedLog.html#truncateTo-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void TruncateTo(long arg0)
        {
            IExecuteWithSignature("truncateTo", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/ReplicatedLog.html#updateHighWatermark-org.apache.kafka.raft.LogOffsetMetadata-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Raft.LogOffsetMetadata"/></param>
        public void UpdateHighWatermark(Org.Apache.Kafka.Raft.LogOffsetMetadata arg0)
        {
            IExecuteWithSignature("updateHighWatermark", "(Lorg/apache/kafka/raft/LogOffsetMetadata;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/ReplicatedLog.html#truncateToEndOffset-org.apache.kafka.raft.OffsetAndEpoch-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Raft.OffsetAndEpoch"/></param>
        /// <returns><see cref="long"/></returns>
        public long TruncateToEndOffset(Org.Apache.Kafka.Raft.OffsetAndEpoch arg0)
        {
            return IExecuteWithSignature<long>("truncateToEndOffset", "(Lorg/apache/kafka/raft/OffsetAndEpoch;)J", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/ReplicatedLog.html#validateOffsetAndEpoch-long-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Raft.ValidOffsetAndEpoch"/></returns>
        public Org.Apache.Kafka.Raft.ValidOffsetAndEpoch ValidateOffsetAndEpoch(long arg0, int arg1)
        {
            return IExecute<Org.Apache.Kafka.Raft.ValidOffsetAndEpoch>("validateOffsetAndEpoch", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/ReplicatedLog.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}