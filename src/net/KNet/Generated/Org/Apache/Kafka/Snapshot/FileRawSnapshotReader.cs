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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using kafka-raft-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Snapshot
{
    #region FileRawSnapshotReader declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/snapshot/FileRawSnapshotReader.html"/>
    /// </summary>
    public partial class FileRawSnapshotReader : MASES.JCOBridge.C2JBridge.JVMBridgeBase<FileRawSnapshotReader>
    {
        const string _bridgeClassName = "org.apache.kafka.snapshot.FileRawSnapshotReader";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public FileRawSnapshotReader() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public FileRawSnapshotReader(params object[] args) : base(args) { }

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

    #region FileRawSnapshotReader implementation
    public partial class FileRawSnapshotReader : Org.Apache.Kafka.Snapshot.IRawSnapshotReader, Java.Lang.IAutoCloseable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Snapshot.FileRawSnapshotReader"/> to <see cref="Org.Apache.Kafka.Snapshot.RawSnapshotReader"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Snapshot.RawSnapshotReader(Org.Apache.Kafka.Snapshot.FileRawSnapshotReader t) => t.Cast<Org.Apache.Kafka.Snapshot.RawSnapshotReader>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Snapshot.FileRawSnapshotReader"/> to <see cref="Java.Lang.AutoCloseable"/>
        /// </summary>
        public static implicit operator Java.Lang.AutoCloseable(Org.Apache.Kafka.Snapshot.FileRawSnapshotReader t) => t.Cast<Java.Lang.AutoCloseable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/snapshot/FileRawSnapshotReader.html#open-java.nio.file.Path-org.apache.kafka.raft.OffsetAndEpoch-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Raft.OffsetAndEpoch"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Snapshot.FileRawSnapshotReader"/></returns>
        public static Org.Apache.Kafka.Snapshot.FileRawSnapshotReader Open(Java.Nio.File.Path arg0, Org.Apache.Kafka.Raft.OffsetAndEpoch arg1)
        {
            return SExecute<Org.Apache.Kafka.Snapshot.FileRawSnapshotReader>(LocalBridgeClazz, "open", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/snapshot/FileRawSnapshotReader.html#sizeInBytes--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long SizeInBytes()
        {
            return IExecuteWithSignature<long>("sizeInBytes", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/snapshot/FileRawSnapshotReader.html#slice-long-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Record.UnalignedRecords"/></returns>
        public Org.Apache.Kafka.Common.Record.UnalignedRecords Slice(long arg0, int arg1)
        {
            return IExecute<Org.Apache.Kafka.Common.Record.UnalignedRecords>("slice", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/snapshot/FileRawSnapshotReader.html#snapshotId--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Raft.OffsetAndEpoch"/></returns>
        public Org.Apache.Kafka.Raft.OffsetAndEpoch SnapshotId()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.OffsetAndEpoch>("snapshotId", "()Lorg/apache/kafka/raft/OffsetAndEpoch;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/snapshot/FileRawSnapshotReader.html#close--"/>
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