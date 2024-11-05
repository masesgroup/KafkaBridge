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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using kafka-raft-3.6.2.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Snapshot
{
    #region FileRawSnapshotWriter declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/snapshot/FileRawSnapshotWriter.html"/>
    /// </summary>
    public partial class FileRawSnapshotWriter : Org.Apache.Kafka.Snapshot.RawSnapshotWriter
    {
        const string _bridgeClassName = "org.apache.kafka.snapshot.FileRawSnapshotWriter";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public FileRawSnapshotWriter() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public FileRawSnapshotWriter(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region FileRawSnapshotWriter implementation
    public partial class FileRawSnapshotWriter
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/snapshot/FileRawSnapshotWriter.html#create-java.nio.file.Path-org.apache.kafka.raft.OffsetAndEpoch-java.util.Optional-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Raft.OffsetAndEpoch"/></param>
        /// <param name="arg2"><see cref="Java.Util.Optional"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Snapshot.FileRawSnapshotWriter"/></returns>
        public static Org.Apache.Kafka.Snapshot.FileRawSnapshotWriter Create(Java.Nio.File.Path arg0, Org.Apache.Kafka.Raft.OffsetAndEpoch arg1, Java.Util.Optional<Org.Apache.Kafka.Raft.ReplicatedLog> arg2)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Snapshot.FileRawSnapshotWriter>(LocalBridgeClazz, "create", "(Ljava/nio/file/Path;Lorg/apache/kafka/raft/OffsetAndEpoch;Ljava/util/Optional;)Lorg/apache/kafka/snapshot/FileRawSnapshotWriter;", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/snapshot/FileRawSnapshotWriter.html#isFrozen--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsFrozen()
        {
            return IExecuteWithSignature<bool>("isFrozen", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/snapshot/FileRawSnapshotWriter.html#sizeInBytes--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long SizeInBytes()
        {
            return IExecuteWithSignature<long>("sizeInBytes", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/snapshot/FileRawSnapshotWriter.html#snapshotId--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Raft.OffsetAndEpoch"/></returns>
        public Org.Apache.Kafka.Raft.OffsetAndEpoch SnapshotId()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.OffsetAndEpoch>("snapshotId", "()Lorg/apache/kafka/raft/OffsetAndEpoch;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/snapshot/FileRawSnapshotWriter.html#append-org.apache.kafka.common.record.UnalignedMemoryRecords-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Record.UnalignedMemoryRecords"/></param>
        public void Append(Org.Apache.Kafka.Common.Record.UnalignedMemoryRecords arg0)
        {
            IExecuteWithSignature("append", "(Lorg/apache/kafka/common/record/UnalignedMemoryRecords;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/snapshot/FileRawSnapshotWriter.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/snapshot/FileRawSnapshotWriter.html#freeze--"/>
        /// </summary>
        public void Freeze()
        {
            IExecuteWithSignature("freeze", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}