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
*  This file is generated by MASES.JNetReflector (ver. 2.2.4.0)
*  using kafka-raft-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Raft
{
    #region QuorumState
    public partial class QuorumState
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/raft/QuorumState.html#org.apache.kafka.raft.QuorumState(java.util.OptionalInt,java.util.Set,int,int,org.apache.kafka.raft.QuorumStateStore,org.apache.kafka.common.utils.Time,org.apache.kafka.common.utils.LogContext,java.util.Random)"/>
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/raft/QuorumState.html#maybeLeaderState--"/>
        /// </summary>

        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Org.Apache.Kafka.Raft.LeaderState<T>> MaybeLeaderState<T>()
        {
            return IExecute<Java.Util.Optional<Org.Apache.Kafka.Raft.LeaderState<T>>>("maybeLeaderState");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/raft/QuorumState.html#leaderStateOrThrow--"/>
        /// </summary>

        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Raft.LeaderState"/></returns>
        public Org.Apache.Kafka.Raft.LeaderState<T> LeaderStateOrThrow<T>()
        {
            return IExecute<Org.Apache.Kafka.Raft.LeaderState<T>>("leaderStateOrThrow");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/raft/QuorumState.html#canGrantVote-int-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CanGrantVote(int arg0, bool arg1)
        {
            return IExecute<bool>("canGrantVote", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/raft/QuorumState.html#hasLeader--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HasLeader()
        {
            return IExecute<bool>("hasLeader");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/raft/QuorumState.html#hasRemoteLeader--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HasRemoteLeader()
        {
            return IExecute<bool>("hasRemoteLeader");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/raft/QuorumState.html#isCandidate--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsCandidate()
        {
            return IExecute<bool>("isCandidate");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/raft/QuorumState.html#isFollower--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsFollower()
        {
            return IExecute<bool>("isFollower");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/raft/QuorumState.html#isLeader--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsLeader()
        {
            return IExecute<bool>("isLeader");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/raft/QuorumState.html#isObserver--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsObserver()
        {
            return IExecute<bool>("isObserver");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/raft/QuorumState.html#isResigned--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsResigned()
        {
            return IExecute<bool>("isResigned");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/raft/QuorumState.html#isUnattached--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsUnattached()
        {
            return IExecute<bool>("isUnattached");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/raft/QuorumState.html#isVoted--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsVoted()
        {
            return IExecute<bool>("isVoted");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/raft/QuorumState.html#isVoter--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsVoter()
        {
            return IExecute<bool>("isVoter");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/raft/QuorumState.html#isVoter-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsVoter(int arg0)
        {
            return IExecute<bool>("isVoter", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/raft/QuorumState.html#epoch--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Epoch()
        {
            return IExecute<int>("epoch");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/raft/QuorumState.html#leaderIdOrSentinel--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int LeaderIdOrSentinel()
        {
            return IExecute<int>("leaderIdOrSentinel");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/raft/QuorumState.html#localIdOrSentinel--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int LocalIdOrSentinel()
        {
            return IExecute<int>("localIdOrSentinel");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/raft/QuorumState.html#localIdOrThrow--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int LocalIdOrThrow()
        {
            return IExecute<int>("localIdOrThrow");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/raft/QuorumState.html#highWatermark--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Org.Apache.Kafka.Raft.LogOffsetMetadata> HighWatermark()
        {
            return IExecute<Java.Util.Optional<Org.Apache.Kafka.Raft.LogOffsetMetadata>>("highWatermark");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/raft/QuorumState.html#leaderId--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.OptionalInt"/></returns>
        public Java.Util.OptionalInt LeaderId()
        {
            return IExecute<Java.Util.OptionalInt>("leaderId");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/raft/QuorumState.html#localId--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.OptionalInt"/></returns>
        public Java.Util.OptionalInt LocalId()
        {
            return IExecute<Java.Util.OptionalInt>("localId");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/raft/QuorumState.html#remoteVoters--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.Integer> RemoteVoters()
        {
            return IExecute<Java.Util.Set<Java.Lang.Integer>>("remoteVoters");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/raft/QuorumState.html#candidateStateOrThrow--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Raft.CandidateState"/></returns>
        public Org.Apache.Kafka.Raft.CandidateState CandidateStateOrThrow()
        {
            return IExecute<Org.Apache.Kafka.Raft.CandidateState>("candidateStateOrThrow");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/raft/QuorumState.html#followerStateOrThrow--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Raft.FollowerState"/></returns>
        public Org.Apache.Kafka.Raft.FollowerState FollowerStateOrThrow()
        {
            return IExecute<Org.Apache.Kafka.Raft.FollowerState>("followerStateOrThrow");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/raft/QuorumState.html#leaderAndEpoch--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Raft.LeaderAndEpoch"/></returns>
        public Org.Apache.Kafka.Raft.LeaderAndEpoch LeaderAndEpoch()
        {
            return IExecute<Org.Apache.Kafka.Raft.LeaderAndEpoch>("leaderAndEpoch");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/raft/QuorumState.html#resignedStateOrThrow--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Raft.ResignedState"/></returns>
        public Org.Apache.Kafka.Raft.ResignedState ResignedStateOrThrow()
        {
            return IExecute<Org.Apache.Kafka.Raft.ResignedState>("resignedStateOrThrow");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/raft/QuorumState.html#unattachedStateOrThrow--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Raft.UnattachedState"/></returns>
        public Org.Apache.Kafka.Raft.UnattachedState UnattachedStateOrThrow()
        {
            return IExecute<Org.Apache.Kafka.Raft.UnattachedState>("unattachedStateOrThrow");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/raft/QuorumState.html#votedStateOrThrow--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Raft.VotedState"/></returns>
        public Org.Apache.Kafka.Raft.VotedState VotedStateOrThrow()
        {
            return IExecute<Org.Apache.Kafka.Raft.VotedState>("votedStateOrThrow");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/raft/QuorumState.html#initialize-org.apache.kafka.raft.OffsetAndEpoch-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Raft.OffsetAndEpoch"/></param>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        public void Initialize(Org.Apache.Kafka.Raft.OffsetAndEpoch arg0)
        {
            IExecute("initialize", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/raft/QuorumState.html#transitionToCandidate--"/>
        /// </summary>
        public void TransitionToCandidate()
        {
            IExecute("transitionToCandidate");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/raft/QuorumState.html#transitionToFollower-int-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void TransitionToFollower(int arg0, int arg1)
        {
            IExecute("transitionToFollower", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/raft/QuorumState.html#transitionToResigned-java.util.List-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        public void TransitionToResigned(Java.Util.List<Java.Lang.Integer> arg0)
        {
            IExecute("transitionToResigned", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/raft/QuorumState.html#transitionToUnattached-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void TransitionToUnattached(int arg0)
        {
            IExecute("transitionToUnattached", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/raft/QuorumState.html#transitionToVoted-int-int-"/>
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