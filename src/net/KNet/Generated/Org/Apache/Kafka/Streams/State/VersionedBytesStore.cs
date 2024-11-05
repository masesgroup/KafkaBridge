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
*  using kafka-streams-3.8.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.State
{
    #region VersionedBytesStore declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/state/VersionedBytesStore.html"/>
    /// </summary>
    public partial class VersionedBytesStore : MASES.JCOBridge.C2JBridge.JVMBridgeBase<VersionedBytesStore>
    {
        const string _bridgeClassName = "org.apache.kafka.streams.state.VersionedBytesStore";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("VersionedBytesStore class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public VersionedBytesStore() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("VersionedBytesStore class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public VersionedBytesStore(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region IVersionedBytesStore
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IVersionedBytesStore
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region VersionedBytesStore implementation
    public partial class VersionedBytesStore : Org.Apache.Kafka.Streams.State.IVersionedBytesStore, Org.Apache.Kafka.Streams.State.IKeyValueStore<Org.Apache.Kafka.Common.Utils.Bytes, byte[]>, Org.Apache.Kafka.Streams.State.ITimestampedBytesStore
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.State.VersionedBytesStore"/> to <see cref="Org.Apache.Kafka.Streams.State.KeyValueStore"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.State.KeyValueStore(Org.Apache.Kafka.Streams.State.VersionedBytesStore t) => t.Cast<Org.Apache.Kafka.Streams.State.KeyValueStore>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.State.VersionedBytesStore"/> to <see cref="Org.Apache.Kafka.Streams.State.TimestampedBytesStore"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.State.TimestampedBytesStore(Org.Apache.Kafka.Streams.State.VersionedBytesStore t) => t.Cast<Org.Apache.Kafka.Streams.State.TimestampedBytesStore>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/state/VersionedBytesStore.html#delete-org.apache.kafka.common.utils.Bytes-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Utils.Bytes"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] Delete(Org.Apache.Kafka.Common.Utils.Bytes arg0, long arg1)
        {
            return IExecuteWithSignatureArray<byte>("delete", "(Lorg/apache/kafka/common/utils/Bytes;J)[B", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/state/VersionedBytesStore.html#get-org.apache.kafka.common.utils.Bytes-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Utils.Bytes"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] Get(Org.Apache.Kafka.Common.Utils.Bytes arg0, long arg1)
        {
            return IExecuteWithSignatureArray<byte>("get", "(Lorg/apache/kafka/common/utils/Bytes;J)[B", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/state/VersionedBytesStore.html#put-org.apache.kafka.common.utils.Bytes-byte[]-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Utils.Bytes"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long Put(Org.Apache.Kafka.Common.Utils.Bytes arg0, byte[] arg1, long arg2)
        {
            return IExecuteWithSignature<long>("put", "(Lorg/apache/kafka/common/utils/Bytes;[BJ)J", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}