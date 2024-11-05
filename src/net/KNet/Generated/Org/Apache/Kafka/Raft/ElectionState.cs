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
*  using kafka-raft-3.8.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Raft
{
    #region ElectionState declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.8.1/org/apache/kafka/raft/ElectionState.html"/>
    /// </summary>
    public partial class ElectionState : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ElectionState>
    {
        const string _bridgeClassName = "org.apache.kafka.raft.ElectionState";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ElectionState() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ElectionState(params object[] args) : base(args) { }

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

    #region ElectionState implementation
    public partial class ElectionState
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.8.1/org/apache/kafka/raft/ElectionState.html#fromQuorumStateData-org.apache.kafka.raft.generated.QuorumStateData-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Raft.Generated.QuorumStateData"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Raft.ElectionState"/></returns>
        public static Org.Apache.Kafka.Raft.ElectionState FromQuorumStateData(Org.Apache.Kafka.Raft.Generated.QuorumStateData arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Raft.ElectionState>(LocalBridgeClazz, "fromQuorumStateData", "(Lorg/apache/kafka/raft/generated/QuorumStateData;)Lorg/apache/kafka/raft/ElectionState;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.8.1/org/apache/kafka/raft/ElectionState.html#withElectedLeader-int-int-java.util.Set-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Raft.ElectionState"/></returns>
        public static Org.Apache.Kafka.Raft.ElectionState WithElectedLeader(int arg0, int arg1, Java.Util.Set<Java.Lang.Integer> arg2)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Raft.ElectionState>(LocalBridgeClazz, "withElectedLeader", "(IILjava/util/Set;)Lorg/apache/kafka/raft/ElectionState;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.8.1/org/apache/kafka/raft/ElectionState.html#withUnknownLeader-int-java.util.Set-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Raft.ElectionState"/></returns>
        public static Org.Apache.Kafka.Raft.ElectionState WithUnknownLeader(int arg0, Java.Util.Set<Java.Lang.Integer> arg1)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Raft.ElectionState>(LocalBridgeClazz, "withUnknownLeader", "(ILjava/util/Set;)Lorg/apache/kafka/raft/ElectionState;", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.8.1/org/apache/kafka/raft/ElectionState.html#hasLeader--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasLeader()
        {
            return IExecuteWithSignature<bool>("hasLeader", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.8.1/org/apache/kafka/raft/ElectionState.html#hasVoted--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasVoted()
        {
            return IExecuteWithSignature<bool>("hasVoted", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.8.1/org/apache/kafka/raft/ElectionState.html#isLeader-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsLeader(int arg0)
        {
            return IExecuteWithSignature<bool>("isLeader", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.8.1/org/apache/kafka/raft/ElectionState.html#epoch--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Epoch()
        {
            return IExecuteWithSignature<int>("epoch", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.8.1/org/apache/kafka/raft/ElectionState.html#leaderId--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int LeaderId()
        {
            return IExecuteWithSignature<int>("leaderId", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.8.1/org/apache/kafka/raft/ElectionState.html#leaderIdOrSentinel--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int LeaderIdOrSentinel()
        {
            return IExecuteWithSignature<int>("leaderIdOrSentinel", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.8.1/org/apache/kafka/raft/ElectionState.html#optionalLeaderId--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.OptionalInt"/></returns>
        public Java.Util.OptionalInt OptionalLeaderId()
        {
            return IExecuteWithSignature<Java.Util.OptionalInt>("optionalLeaderId", "()Ljava/util/OptionalInt;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.8.1/org/apache/kafka/raft/ElectionState.html#toQuorumStateData-short-"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Raft.Generated.QuorumStateData"/></returns>
        public Org.Apache.Kafka.Raft.Generated.QuorumStateData ToQuorumStateData(short arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.Generated.QuorumStateData>("toQuorumStateData", "(S)Lorg/apache/kafka/raft/generated/QuorumStateData;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}