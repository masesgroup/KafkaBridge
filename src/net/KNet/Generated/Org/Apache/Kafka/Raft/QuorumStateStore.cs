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
*  using kafka-raft-3.6.2.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Raft
{
    #region QuorumStateStore declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/QuorumStateStore.html"/>
    /// </summary>
    public partial class QuorumStateStore : MASES.JCOBridge.C2JBridge.JVMBridgeBase<QuorumStateStore>
    {
        const string _bridgeClassName = "org.apache.kafka.raft.QuorumStateStore";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("QuorumStateStore class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public QuorumStateStore() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("QuorumStateStore class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public QuorumStateStore(params object[] args) : base(args) { }

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

    #region IQuorumStateStore
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IQuorumStateStore
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region QuorumStateStore implementation
    public partial class QuorumStateStore : Org.Apache.Kafka.Raft.IQuorumStateStore
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/QuorumStateStore.html#NOT_VOTED"/>
        /// </summary>
        public static int NOT_VOTED { get { if (!_NOT_VOTEDReady) { _NOT_VOTEDContent = SGetField<int>(LocalBridgeClazz, "NOT_VOTED"); _NOT_VOTEDReady = true; } return _NOT_VOTEDContent; } }
        private static int _NOT_VOTEDContent = default;
        private static bool _NOT_VOTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/QuorumStateStore.html#UNKNOWN_LEADER_ID"/>
        /// </summary>
        public static int UNKNOWN_LEADER_ID { get { if (!_UNKNOWN_LEADER_IDReady) { _UNKNOWN_LEADER_IDContent = SGetField<int>(LocalBridgeClazz, "UNKNOWN_LEADER_ID"); _UNKNOWN_LEADER_IDReady = true; } return _UNKNOWN_LEADER_IDContent; } }
        private static int _UNKNOWN_LEADER_IDContent = default;
        private static bool _UNKNOWN_LEADER_IDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/QuorumStateStore.html#readElectionState--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Raft.ElectionState"/></returns>
        public Org.Apache.Kafka.Raft.ElectionState ReadElectionState()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.ElectionState>("readElectionState", "()Lorg/apache/kafka/raft/ElectionState;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/QuorumStateStore.html#clear--"/>
        /// </summary>
        public void Clear()
        {
            IExecuteWithSignature("clear", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/QuorumStateStore.html#writeElectionState-org.apache.kafka.raft.ElectionState-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Raft.ElectionState"/></param>
        public void WriteElectionState(Org.Apache.Kafka.Raft.ElectionState arg0)
        {
            IExecuteWithSignature("writeElectionState", "(Lorg/apache/kafka/raft/ElectionState;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}