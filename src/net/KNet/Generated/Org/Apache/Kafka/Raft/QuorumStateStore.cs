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
*  This file is generated by MASES.JNetReflector (ver. 2.5.3.0)
*  using kafka-raft-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Raft
{
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

    #region QuorumStateStore
    public partial class QuorumStateStore : Org.Apache.Kafka.Raft.IQuorumStateStore
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/QuorumStateStore.html#NOT_VOTED"/>
        /// </summary>
        public static int NOT_VOTED { get { if (!_NOT_VOTEDReady) { _NOT_VOTEDContent = SGetField<int>(LocalBridgeClazz, "NOT_VOTED"); _NOT_VOTEDReady = true; } return _NOT_VOTEDContent; } }
        private static int _NOT_VOTEDContent = default;
        private static bool _NOT_VOTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/QuorumStateStore.html#UNKNOWN_LEADER_ID"/>
        /// </summary>
        public static int UNKNOWN_LEADER_ID { get { if (!_UNKNOWN_LEADER_IDReady) { _UNKNOWN_LEADER_IDContent = SGetField<int>(LocalBridgeClazz, "UNKNOWN_LEADER_ID"); _UNKNOWN_LEADER_IDReady = true; } return _UNKNOWN_LEADER_IDContent; } }
        private static int _UNKNOWN_LEADER_IDContent = default;
        private static bool _UNKNOWN_LEADER_IDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/QuorumStateStore.html#readElectionState--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Raft.ElectionState"/></returns>
        public Org.Apache.Kafka.Raft.ElectionState ReadElectionState()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.ElectionState>("readElectionState", "()Lorg/apache/kafka/raft/ElectionState;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/QuorumStateStore.html#clear--"/>
        /// </summary>
        public void Clear()
        {
            IExecuteWithSignature("clear", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/QuorumStateStore.html#writeElectionState-org.apache.kafka.raft.ElectionState-"/>
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