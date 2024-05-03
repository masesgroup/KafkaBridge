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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using kafka-raft-3.6.2.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Raft
{
    #region QuorumState
    public partial class QuorumState
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/QuorumState.html#org.apache.kafka.raft.QuorumState(java.util.OptionalInt,java.util.Set,int,int,org.apache.kafka.raft.QuorumStateStore,org.apache.kafka.common.utils.Time,org.apache.kafka.common.utils.LogContext,java.util.Random)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.OptionalInt"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Raft.QuorumStateStore"/></param>
        /// <param name="arg5"><see cref="Org.Apache.Kafka.Common.Utils.Time"/></param>
        /// <param name="arg6"><see cref="Org.Apache.Kafka.Common.Utils.LogContext"/></param>
        /// <param name="arg7"><see cref="Java.Util.Random"/></param>
        public QuorumState(Java.Util.OptionalInt arg0, Java.Util.Set<Java.Lang.Integer> arg1, int arg2, int arg3, Org.Apache.Kafka.Raft.QuorumStateStore arg4, Org.Apache.Kafka.Common.Utils.Time arg5, Org.Apache.Kafka.Common.Utils.LogContext arg6, Java.Util.Random arg7)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/QuorumState.html#maybeLeaderState--"/>
        /// </summary>

        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Org.Apache.Kafka.Raft.LeaderState<T>> MaybeLeaderState<T>()
        {
            return IExecuteWithSignature<Java.Util.Optional<Org.Apache.Kafka.Raft.LeaderState<T>>>("maybeLeaderState", "()Ljava/util/Optional;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/QuorumState.html#leaderStateOrThrow--"/>
        /// </summary>

        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Raft.LeaderState"/></returns>
        public Org.Apache.Kafka.Raft.LeaderState<T> LeaderStateOrThrow<T>()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.LeaderState<T>>("leaderStateOrThrow", "()Lorg/apache/kafka/raft/LeaderState;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/QuorumState.html#canGrantVote-int-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CanGrantVote(int arg0, bool arg1)
        {
            return IExecute<bool>("canGrantVote", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/QuorumState.html#hasLeader--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HasLeader()
        {
            return IExecuteWithSignature<bool>("hasLeader", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/QuorumState.html#hasRemoteLeader--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HasRemoteLeader()
        {
            return IExecuteWithSignature<bool>("hasRemoteLeader", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/QuorumState.html#isCandidate--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsCandidate()
        {
            return IExecuteWithSignature<bool>("isCandidate", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/QuorumState.html#isFollower--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsFollower()
        {
            return IExecuteWithSignature<bool>("isFollower", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/QuorumState.html#isLeader--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsLeader()
        {
            return IExecuteWithSignature<bool>("isLeader", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/QuorumState.html#isObserver--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsObserver()
        {
            return IExecuteWithSignature<bool>("isObserver", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/QuorumState.html#isResigned--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsResigned()
        {
            return IExecuteWithSignature<bool>("isResigned", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/QuorumState.html#isUnattached--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsUnattached()
        {
            return IExecuteWithSignature<bool>("isUnattached", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/QuorumState.html#isVoted--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsVoted()
        {
            return IExecuteWithSignature<bool>("isVoted", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/QuorumState.html#isVoter--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsVoter()
        {
            return IExecuteWithSignature<bool>("isVoter", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/QuorumState.html#isVoter-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsVoter(int arg0)
        {
            return IExecuteWithSignature<bool>("isVoter", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/QuorumState.html#epoch--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Epoch()
        {
            return IExecuteWithSignature<int>("epoch", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/QuorumState.html#leaderIdOrSentinel--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int LeaderIdOrSentinel()
        {
            return IExecuteWithSignature<int>("leaderIdOrSentinel", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/QuorumState.html#localIdOrSentinel--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int LocalIdOrSentinel()
        {
            return IExecuteWithSignature<int>("localIdOrSentinel", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/QuorumState.html#localIdOrThrow--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int LocalIdOrThrow()
        {
            return IExecuteWithSignature<int>("localIdOrThrow", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/QuorumState.html#highWatermark--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Org.Apache.Kafka.Raft.LogOffsetMetadata> HighWatermark()
        {
            return IExecuteWithSignature<Java.Util.Optional<Org.Apache.Kafka.Raft.LogOffsetMetadata>>("highWatermark", "()Ljava/util/Optional;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/QuorumState.html#leaderId--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.OptionalInt"/></returns>
        public Java.Util.OptionalInt LeaderId()
        {
            return IExecuteWithSignature<Java.Util.OptionalInt>("leaderId", "()Ljava/util/OptionalInt;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/QuorumState.html#localId--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.OptionalInt"/></returns>
        public Java.Util.OptionalInt LocalId()
        {
            return IExecuteWithSignature<Java.Util.OptionalInt>("localId", "()Ljava/util/OptionalInt;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/QuorumState.html#remoteVoters--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.Integer> RemoteVoters()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.Integer>>("remoteVoters", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/QuorumState.html#candidateStateOrThrow--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Raft.CandidateState"/></returns>
        public Org.Apache.Kafka.Raft.CandidateState CandidateStateOrThrow()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.CandidateState>("candidateStateOrThrow", "()Lorg/apache/kafka/raft/CandidateState;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/QuorumState.html#followerStateOrThrow--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Raft.FollowerState"/></returns>
        public Org.Apache.Kafka.Raft.FollowerState FollowerStateOrThrow()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.FollowerState>("followerStateOrThrow", "()Lorg/apache/kafka/raft/FollowerState;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/QuorumState.html#leaderAndEpoch--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Raft.LeaderAndEpoch"/></returns>
        public Org.Apache.Kafka.Raft.LeaderAndEpoch LeaderAndEpoch()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.LeaderAndEpoch>("leaderAndEpoch", "()Lorg/apache/kafka/raft/LeaderAndEpoch;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/QuorumState.html#resignedStateOrThrow--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Raft.ResignedState"/></returns>
        public Org.Apache.Kafka.Raft.ResignedState ResignedStateOrThrow()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.ResignedState>("resignedStateOrThrow", "()Lorg/apache/kafka/raft/ResignedState;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/QuorumState.html#unattachedStateOrThrow--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Raft.UnattachedState"/></returns>
        public Org.Apache.Kafka.Raft.UnattachedState UnattachedStateOrThrow()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.UnattachedState>("unattachedStateOrThrow", "()Lorg/apache/kafka/raft/UnattachedState;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/QuorumState.html#votedStateOrThrow--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Raft.VotedState"/></returns>
        public Org.Apache.Kafka.Raft.VotedState VotedStateOrThrow()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.VotedState>("votedStateOrThrow", "()Lorg/apache/kafka/raft/VotedState;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/QuorumState.html#initialize-org.apache.kafka.raft.OffsetAndEpoch-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Raft.OffsetAndEpoch"/></param>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        public void Initialize(Org.Apache.Kafka.Raft.OffsetAndEpoch arg0)
        {
            IExecuteWithSignature("initialize", "(Lorg/apache/kafka/raft/OffsetAndEpoch;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/QuorumState.html#transitionToCandidate--"/>
        /// </summary>
        public void TransitionToCandidate()
        {
            IExecuteWithSignature("transitionToCandidate", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/QuorumState.html#transitionToFollower-int-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void TransitionToFollower(int arg0, int arg1)
        {
            IExecute("transitionToFollower", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/QuorumState.html#transitionToResigned-java.util.List-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        public void TransitionToResigned(Java.Util.List<Java.Lang.Integer> arg0)
        {
            IExecuteWithSignature("transitionToResigned", "(Ljava/util/List;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/QuorumState.html#transitionToUnattached-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void TransitionToUnattached(int arg0)
        {
            IExecuteWithSignature("transitionToUnattached", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/QuorumState.html#transitionToVoted-int-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void TransitionToVoted(int arg0, int arg1)
        {
            IExecute("transitionToVoted", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}