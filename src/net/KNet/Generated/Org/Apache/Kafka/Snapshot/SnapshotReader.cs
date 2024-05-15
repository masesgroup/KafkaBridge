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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using kafka-raft-3.6.2.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Snapshot
{
    #region SnapshotReader
    public partial class SnapshotReader
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Snapshot.SnapshotReader"/> to <see cref="Java.Lang.AutoCloseable"/>
        /// </summary>
        public static implicit operator Java.Lang.AutoCloseable(Org.Apache.Kafka.Snapshot.SnapshotReader t) => t.Cast<Java.Lang.AutoCloseable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/snapshot/SnapshotReader.html#lastContainedLogEpoch--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int LastContainedLogEpoch()
        {
            return IExecuteWithSignature<int>("lastContainedLogEpoch", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/snapshot/SnapshotReader.html#lastContainedLogOffset--"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long LastContainedLogOffset()
        {
            return IExecuteWithSignature<long>("lastContainedLogOffset", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/snapshot/SnapshotReader.html#lastContainedLogTimestamp--"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long LastContainedLogTimestamp()
        {
            return IExecuteWithSignature<long>("lastContainedLogTimestamp", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/snapshot/SnapshotReader.html#snapshotId--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Raft.OffsetAndEpoch"/></returns>
        public Org.Apache.Kafka.Raft.OffsetAndEpoch SnapshotId()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.OffsetAndEpoch>("snapshotId", "()Lorg/apache/kafka/raft/OffsetAndEpoch;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/snapshot/SnapshotReader.html#close--"/>
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

    #region ISnapshotReader<T>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ISnapshotReader<T>
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SnapshotReader<T>
    public partial class SnapshotReader<T> : Org.Apache.Kafka.Snapshot.ISnapshotReader<T>, Java.Lang.IAutoCloseable, Java.Util.IIterator<Org.Apache.Kafka.Raft.Batch<T>>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Snapshot.SnapshotReader{T}"/> to <see cref="Java.Lang.AutoCloseable"/>
        /// </summary>
        public static implicit operator Java.Lang.AutoCloseable(Org.Apache.Kafka.Snapshot.SnapshotReader<T> t) => t.Cast<Java.Lang.AutoCloseable>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Snapshot.SnapshotReader{T}"/> to <see cref="Org.Apache.Kafka.Snapshot.SnapshotReader"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Snapshot.SnapshotReader(Org.Apache.Kafka.Snapshot.SnapshotReader<T> t) => t.Cast<Org.Apache.Kafka.Snapshot.SnapshotReader>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/snapshot/SnapshotReader.html#lastContainedLogEpoch--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int LastContainedLogEpoch()
        {
            return IExecuteWithSignature<int>("lastContainedLogEpoch", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/snapshot/SnapshotReader.html#lastContainedLogOffset--"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long LastContainedLogOffset()
        {
            return IExecuteWithSignature<long>("lastContainedLogOffset", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/snapshot/SnapshotReader.html#lastContainedLogTimestamp--"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long LastContainedLogTimestamp()
        {
            return IExecuteWithSignature<long>("lastContainedLogTimestamp", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/snapshot/SnapshotReader.html#snapshotId--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Raft.OffsetAndEpoch"/></returns>
        public Org.Apache.Kafka.Raft.OffsetAndEpoch SnapshotId()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.OffsetAndEpoch>("snapshotId", "()Lorg/apache/kafka/raft/OffsetAndEpoch;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/snapshot/SnapshotReader.html#close--"/>
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