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
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
*  using kafka-raft-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Snapshot
{
    #region IRawSnapshotWriter
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IRawSnapshotWriter : Java.Lang.IAutoCloseable
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region RawSnapshotWriter
    public partial class RawSnapshotWriter : Org.Apache.Kafka.Snapshot.IRawSnapshotWriter
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/snapshot/RawSnapshotWriter.html#isFrozen--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsFrozen()
        {
            return IExecute<bool>("isFrozen");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/snapshot/RawSnapshotWriter.html#sizeInBytes--"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long SizeInBytes()
        {
            return IExecute<long>("sizeInBytes");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/snapshot/RawSnapshotWriter.html#snapshotId--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Raft.OffsetAndEpoch"/></returns>
        public Org.Apache.Kafka.Raft.OffsetAndEpoch SnapshotId()
        {
            return IExecute<Org.Apache.Kafka.Raft.OffsetAndEpoch>("snapshotId");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/snapshot/RawSnapshotWriter.html#append-org.apache.kafka.common.record.UnalignedMemoryRecords-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Record.UnalignedMemoryRecords"/></param>
        public void Append(Org.Apache.Kafka.Common.Record.UnalignedMemoryRecords arg0)
        {
            IExecute("append", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/snapshot/RawSnapshotWriter.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/snapshot/RawSnapshotWriter.html#freeze--"/>
        /// </summary>
        public void Freeze()
        {
            IExecute("freeze");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}