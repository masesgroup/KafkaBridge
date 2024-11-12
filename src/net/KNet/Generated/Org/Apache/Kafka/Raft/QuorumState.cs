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
*  using kafka-raft-3.9.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Raft
{
    #region QuorumState declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumState.html"/>
    /// </summary>
    public partial class QuorumState : MASES.JCOBridge.C2JBridge.JVMBridgeBase<QuorumState>
    {
        const string _bridgeClassName = "org.apache.kafka.raft.QuorumState";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public QuorumState() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public QuorumState(params object[] args) : base(args) { }

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

    #region QuorumState implementation
    public partial class QuorumState
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumState.html#maybeLeaderState--"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Org.Apache.Kafka.Raft.LeaderState<T>> MaybeLeaderState<T>()
        {
            return IExecuteWithSignature<Java.Util.Optional<Org.Apache.Kafka.Raft.LeaderState<T>>>("maybeLeaderState", "()Ljava/util/Optional;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumState.html#leaderStateOrThrow--"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Raft.LeaderState"/></returns>
        public Org.Apache.Kafka.Raft.LeaderState<T> LeaderStateOrThrow<T>()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.LeaderState<T>>("leaderStateOrThrow", "()Lorg/apache/kafka/raft/LeaderState;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumState.html#canGrantVote-org.apache.kafka.raft.ReplicaKey-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Raft.ReplicaKey"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CanGrantVote(Org.Apache.Kafka.Raft.ReplicaKey arg0, bool arg1)
        {
            return IExecuteWithSignature<bool>("canGrantVote", "(Lorg/apache/kafka/raft/ReplicaKey;Z)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumState.html#hasLeader--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasLeader()
        {
            return IExecuteWithSignature<bool>("hasLeader", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumState.html#hasRemoteLeader--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasRemoteLeader()
        {
            return IExecuteWithSignature<bool>("hasRemoteLeader", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumState.html#isCandidate--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCandidate()
        {
            return IExecuteWithSignature<bool>("isCandidate", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumState.html#isFollower--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsFollower()
        {
            return IExecuteWithSignature<bool>("isFollower", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumState.html#isLeader--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsLeader()
        {
            return IExecuteWithSignature<bool>("isLeader", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumState.html#isObserver--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsObserver()
        {
            return IExecuteWithSignature<bool>("isObserver", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumState.html#isOnlyVoter--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsOnlyVoter()
        {
            return IExecuteWithSignature<bool>("isOnlyVoter", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumState.html#isResigned--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsResigned()
        {
            return IExecuteWithSignature<bool>("isResigned", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumState.html#isUnattached--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsUnattached()
        {
            return IExecuteWithSignature<bool>("isUnattached", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumState.html#isUnattachedAndVoted--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsUnattachedAndVoted()
        {
            return IExecuteWithSignature<bool>("isUnattachedAndVoted", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumState.html#isUnattachedNotVoted--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsUnattachedNotVoted()
        {
            return IExecuteWithSignature<bool>("isUnattachedNotVoted", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumState.html#isVoter--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsVoter()
        {
            return IExecuteWithSignature<bool>("isVoter", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumState.html#isVoter-org.apache.kafka.raft.ReplicaKey-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Raft.ReplicaKey"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsVoter(Org.Apache.Kafka.Raft.ReplicaKey arg0)
        {
            return IExecuteWithSignature<bool>("isVoter", "(Lorg/apache/kafka/raft/ReplicaKey;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumState.html#epoch--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Epoch()
        {
            return IExecuteWithSignature<int>("epoch", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumState.html#leaderIdOrSentinel--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int LeaderIdOrSentinel()
        {
            return IExecuteWithSignature<int>("leaderIdOrSentinel", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumState.html#localIdOrSentinel--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int LocalIdOrSentinel()
        {
            return IExecuteWithSignature<int>("localIdOrSentinel", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumState.html#localIdOrThrow--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int LocalIdOrThrow()
        {
            return IExecuteWithSignature<int>("localIdOrThrow", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumState.html#highWatermark--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Org.Apache.Kafka.Raft.LogOffsetMetadata> HighWatermark()
        {
            return IExecuteWithSignature<Java.Util.Optional<Org.Apache.Kafka.Raft.LogOffsetMetadata>>("highWatermark", "()Ljava/util/Optional;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumState.html#maybeUnattachedState--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Org.Apache.Kafka.Raft.UnattachedState> MaybeUnattachedState()
        {
            return IExecuteWithSignature<Java.Util.Optional<Org.Apache.Kafka.Raft.UnattachedState>>("maybeUnattachedState", "()Ljava/util/Optional;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumState.html#leaderId--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.OptionalInt"/></returns>
        public Java.Util.OptionalInt LeaderId()
        {
            return IExecuteWithSignature<Java.Util.OptionalInt>("leaderId", "()Ljava/util/OptionalInt;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumState.html#localId--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.OptionalInt"/></returns>
        public Java.Util.OptionalInt LocalId()
        {
            return IExecuteWithSignature<Java.Util.OptionalInt>("localId", "()Ljava/util/OptionalInt;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumState.html#localDirectoryId--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Uuid"/></returns>
        public Org.Apache.Kafka.Common.Uuid LocalDirectoryId()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Uuid>("localDirectoryId", "()Lorg/apache/kafka/common/Uuid;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumState.html#candidateStateOrThrow--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Raft.CandidateState"/></returns>
        public Org.Apache.Kafka.Raft.CandidateState CandidateStateOrThrow()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.CandidateState>("candidateStateOrThrow", "()Lorg/apache/kafka/raft/CandidateState;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumState.html#leaderEndpoints--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Raft.Endpoints"/></returns>
        public Org.Apache.Kafka.Raft.Endpoints LeaderEndpoints()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.Endpoints>("leaderEndpoints", "()Lorg/apache/kafka/raft/Endpoints;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumState.html#followerStateOrThrow--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Raft.FollowerState"/></returns>
        public Org.Apache.Kafka.Raft.FollowerState FollowerStateOrThrow()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.FollowerState>("followerStateOrThrow", "()Lorg/apache/kafka/raft/FollowerState;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumState.html#leaderAndEpoch--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Raft.LeaderAndEpoch"/></returns>
        public Org.Apache.Kafka.Raft.LeaderAndEpoch LeaderAndEpoch()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.LeaderAndEpoch>("leaderAndEpoch", "()Lorg/apache/kafka/raft/LeaderAndEpoch;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumState.html#localReplicaKeyOrThrow--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Raft.ReplicaKey"/></returns>
        public Org.Apache.Kafka.Raft.ReplicaKey LocalReplicaKeyOrThrow()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.ReplicaKey>("localReplicaKeyOrThrow", "()Lorg/apache/kafka/raft/ReplicaKey;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumState.html#resignedStateOrThrow--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Raft.ResignedState"/></returns>
        public Org.Apache.Kafka.Raft.ResignedState ResignedStateOrThrow()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.ResignedState>("resignedStateOrThrow", "()Lorg/apache/kafka/raft/ResignedState;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumState.html#unattachedStateOrThrow--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Raft.UnattachedState"/></returns>
        public Org.Apache.Kafka.Raft.UnattachedState UnattachedStateOrThrow()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.UnattachedState>("unattachedStateOrThrow", "()Lorg/apache/kafka/raft/UnattachedState;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumState.html#localVoterNodeOrThrow--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Raft.VoterSet.VoterNode"/></returns>
        public Org.Apache.Kafka.Raft.VoterSet.VoterNode LocalVoterNodeOrThrow()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.VoterSet.VoterNode>("localVoterNodeOrThrow", "()Lorg/apache/kafka/raft/VoterSet$VoterNode;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumState.html#initialize-org.apache.kafka.raft.OffsetAndEpoch-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Raft.OffsetAndEpoch"/></param>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        public void Initialize(Org.Apache.Kafka.Raft.OffsetAndEpoch arg0)
        {
            IExecuteWithSignature("initialize", "(Lorg/apache/kafka/raft/OffsetAndEpoch;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumState.html#transitionToCandidate--"/>
        /// </summary>
        public void TransitionToCandidate()
        {
            IExecuteWithSignature("transitionToCandidate", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumState.html#transitionToFollower-int-int-org.apache.kafka.raft.Endpoints-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Raft.Endpoints"/></param>
        public void TransitionToFollower(int arg0, int arg1, Org.Apache.Kafka.Raft.Endpoints arg2)
        {
            IExecuteWithSignature("transitionToFollower", "(IILorg/apache/kafka/raft/Endpoints;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumState.html#transitionToResigned-java.util.List-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        public void TransitionToResigned(Java.Util.List<Org.Apache.Kafka.Raft.ReplicaKey> arg0)
        {
            IExecuteWithSignature("transitionToResigned", "(Ljava/util/List;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumState.html#transitionToUnattached-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void TransitionToUnattached(int arg0)
        {
            IExecuteWithSignature("transitionToUnattached", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/QuorumState.html#transitionToUnattachedVotedState-int-org.apache.kafka.raft.ReplicaKey-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Raft.ReplicaKey"/></param>
        public void TransitionToUnattachedVotedState(int arg0, Org.Apache.Kafka.Raft.ReplicaKey arg1)
        {
            IExecuteWithSignature("transitionToUnattachedVotedState", "(ILorg/apache/kafka/raft/ReplicaKey;)V", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}