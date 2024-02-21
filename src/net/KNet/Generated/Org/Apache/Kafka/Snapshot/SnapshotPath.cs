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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using kafka-raft-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Snapshot
{
    #region SnapshotPath
    public partial class SnapshotPath
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/snapshot/SnapshotPath.html#org.apache.kafka.snapshot.SnapshotPath(java.nio.file.Path,org.apache.kafka.raft.OffsetAndEpoch,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Raft.OffsetAndEpoch"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        public SnapshotPath(Java.Nio.File.Path arg0, Org.Apache.Kafka.Raft.OffsetAndEpoch arg1, bool arg2, bool arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/snapshot/SnapshotPath.html#deleted"/>
        /// </summary>
        public bool deleted { get { if (!_deletedReady) { _deletedContent = IGetField<bool>("deleted"); _deletedReady = true; } return _deletedContent; } }
        private bool _deletedContent = default;
        private bool _deletedReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/snapshot/SnapshotPath.html#partial"/>
        /// </summary>
        public bool partial { get { if (!_partialReady) { _partialContent = IGetField<bool>("partial"); _partialReady = true; } return _partialContent; } }
        private bool _partialContent = default;
        private bool _partialReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/snapshot/SnapshotPath.html#path"/>
        /// </summary>
        public Java.Nio.File.Path path { get { if (!_pathReady) { _pathContent = IGetField<Java.Nio.File.Path>("path"); _pathReady = true; } return _pathContent; } }
        private Java.Nio.File.Path _pathContent = default;
        private bool _pathReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/snapshot/SnapshotPath.html#snapshotId"/>
        /// </summary>
        public Org.Apache.Kafka.Raft.OffsetAndEpoch snapshotId { get { if (!_snapshotIdReady) { _snapshotIdContent = IGetField<Org.Apache.Kafka.Raft.OffsetAndEpoch>("snapshotId"); _snapshotIdReady = true; } return _snapshotIdContent; } }
        private Org.Apache.Kafka.Raft.OffsetAndEpoch _snapshotIdContent = default;
        private bool _snapshotIdReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}