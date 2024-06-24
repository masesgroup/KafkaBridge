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
*  This file is generated by MASES.JNetReflector (ver. 2.5.4.0)
*  using kafka-raft-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Snapshot
{
    #region Snapshots
    public partial class Snapshots
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/snapshot/Snapshots.html#DELETE_SUFFIX"/>
        /// </summary>
        public static Java.Lang.String DELETE_SUFFIX { get { if (!_DELETE_SUFFIXReady) { _DELETE_SUFFIXContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DELETE_SUFFIX"); _DELETE_SUFFIXReady = true; } return _DELETE_SUFFIXContent; } }
        private static Java.Lang.String _DELETE_SUFFIXContent = default;
        private static bool _DELETE_SUFFIXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/snapshot/Snapshots.html#SUFFIX"/>
        /// </summary>
        public static Java.Lang.String SUFFIX { get { if (!_SUFFIXReady) { _SUFFIXContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SUFFIX"); _SUFFIXReady = true; } return _SUFFIXContent; } }
        private static Java.Lang.String _SUFFIXContent = default;
        private static bool _SUFFIXReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/snapshot/Snapshots.html#deleteIfExists-java.nio.file.Path-org.apache.kafka.raft.OffsetAndEpoch-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Raft.OffsetAndEpoch"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool DeleteIfExists(Java.Nio.File.Path arg0, Org.Apache.Kafka.Raft.OffsetAndEpoch arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "deleteIfExists", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/snapshot/Snapshots.html#filenameFromSnapshotId-org.apache.kafka.raft.OffsetAndEpoch-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Raft.OffsetAndEpoch"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String FilenameFromSnapshotId(Org.Apache.Kafka.Raft.OffsetAndEpoch arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "filenameFromSnapshotId", "(Lorg/apache/kafka/raft/OffsetAndEpoch;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/snapshot/Snapshots.html#createTempFile-java.nio.file.Path-org.apache.kafka.raft.OffsetAndEpoch-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Raft.OffsetAndEpoch"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        public static Java.Nio.File.Path CreateTempFile(Java.Nio.File.Path arg0, Org.Apache.Kafka.Raft.OffsetAndEpoch arg1)
        {
            return SExecute<Java.Nio.File.Path>(LocalBridgeClazz, "createTempFile", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/snapshot/Snapshots.html#markForDelete-java.nio.file.Path-org.apache.kafka.raft.OffsetAndEpoch-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Raft.OffsetAndEpoch"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        public static Java.Nio.File.Path MarkForDelete(Java.Nio.File.Path arg0, Org.Apache.Kafka.Raft.OffsetAndEpoch arg1)
        {
            return SExecute<Java.Nio.File.Path>(LocalBridgeClazz, "markForDelete", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/snapshot/Snapshots.html#snapshotPath-java.nio.file.Path-org.apache.kafka.raft.OffsetAndEpoch-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Raft.OffsetAndEpoch"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        public static Java.Nio.File.Path SnapshotPath(Java.Nio.File.Path arg0, Org.Apache.Kafka.Raft.OffsetAndEpoch arg1)
        {
            return SExecute<Java.Nio.File.Path>(LocalBridgeClazz, "snapshotPath", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/snapshot/Snapshots.html#parse-java.nio.file.Path-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public static Java.Util.Optional<Org.Apache.Kafka.Snapshot.SnapshotPath> Parse(Java.Nio.File.Path arg0)
        {
            return SExecuteWithSignature<Java.Util.Optional<Org.Apache.Kafka.Snapshot.SnapshotPath>>(LocalBridgeClazz, "parse", "(Ljava/nio/file/Path;)Ljava/util/Optional;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/snapshot/Snapshots.html#lastContainedLogTimestamp-java.nio.file.Path-org.apache.kafka.raft.OffsetAndEpoch-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Raft.OffsetAndEpoch"/></param>
        /// <returns><see cref="long"/></returns>
        public static long LastContainedLogTimestamp(Java.Nio.File.Path arg0, Org.Apache.Kafka.Raft.OffsetAndEpoch arg1)
        {
            return SExecute<long>(LocalBridgeClazz, "lastContainedLogTimestamp", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/snapshot/Snapshots.html#lastContainedLogTimestamp-org.apache.kafka.snapshot.RawSnapshotReader-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Snapshot.RawSnapshotReader"/></param>
        /// <returns><see cref="long"/></returns>
        public static long LastContainedLogTimestamp(Org.Apache.Kafka.Snapshot.RawSnapshotReader arg0)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "lastContainedLogTimestamp", "(Lorg/apache/kafka/snapshot/RawSnapshotReader;)J", arg0);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}