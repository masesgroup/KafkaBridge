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
    #region LeaderState
    public partial class LeaderState
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/LeaderState.html#canGrantVote-int-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CanGrantVote(int arg0, bool arg1)
        {
            return IExecute<bool>("canGrantVote", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/LeaderState.html#isResignRequested--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsResignRequested()
        {
            return IExecuteWithSignature<bool>("isResignRequested", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/LeaderState.html#updateLocalState-org.apache.kafka.raft.LogOffsetMetadata-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Raft.LogOffsetMetadata"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool UpdateLocalState(Org.Apache.Kafka.Raft.LogOffsetMetadata arg0)
        {
            return IExecuteWithSignature<bool>("updateLocalState", "(Lorg/apache/kafka/raft/LogOffsetMetadata;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/LeaderState.html#updateReplicaState-int-long-org.apache.kafka.raft.LogOffsetMetadata-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Raft.LogOffsetMetadata"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool UpdateReplicaState(int arg0, long arg1, Org.Apache.Kafka.Raft.LogOffsetMetadata arg2)
        {
            return IExecute<bool>("updateReplicaState", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/LeaderState.html#epoch--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Epoch()
        {
            return IExecuteWithSignature<int>("epoch", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/LeaderState.html#localId--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int LocalId()
        {
            return IExecuteWithSignature<int>("localId", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/LeaderState.html#name--"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Name()
        {
            return IExecuteWithSignature<Java.Lang.String>("name", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/LeaderState.html#nonLeaderVotersByDescendingFetchOffset--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List NonLeaderVotersByDescendingFetchOffset()
        {
            return IExecuteWithSignature<Java.Util.List>("nonLeaderVotersByDescendingFetchOffset", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/LeaderState.html#highWatermark--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional HighWatermark()
        {
            return IExecuteWithSignature<Java.Util.Optional>("highWatermark", "()Ljava/util/Optional;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/LeaderState.html#grantingVoters--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set GrantingVoters()
        {
            return IExecuteWithSignature<Java.Util.Set>("grantingVoters", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/LeaderState.html#nonAcknowledgingVoters--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set NonAcknowledgingVoters()
        {
            return IExecuteWithSignature<Java.Util.Set>("nonAcknowledgingVoters", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/LeaderState.html#epochStartOffset--"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long EpochStartOffset()
        {
            return IExecuteWithSignature<long>("epochStartOffset", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/LeaderState.html#election--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Raft.ElectionState"/></returns>
        public Org.Apache.Kafka.Raft.ElectionState Election()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.ElectionState>("election", "()Lorg/apache/kafka/raft/ElectionState;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/LeaderState.html#addAcknowledgementFrom-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void AddAcknowledgementFrom(int arg0)
        {
            IExecuteWithSignature("addAcknowledgementFrom", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/LeaderState.html#appendLeaderChangeMessage-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void AppendLeaderChangeMessage(long arg0)
        {
            IExecuteWithSignature("appendLeaderChangeMessage", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/LeaderState.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/LeaderState.html#requestResign--"/>
        /// </summary>
        public void RequestResign()
        {
            IExecuteWithSignature("requestResign", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region LeaderState<T>
    public partial class LeaderState<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Raft.LeaderState{T}"/> to <see cref="Org.Apache.Kafka.Raft.LeaderState"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Raft.LeaderState(Org.Apache.Kafka.Raft.LeaderState<T> t) => t.Cast<Org.Apache.Kafka.Raft.LeaderState>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/LeaderState.html#canGrantVote-int-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CanGrantVote(int arg0, bool arg1)
        {
            return IExecute<bool>("canGrantVote", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/LeaderState.html#isResignRequested--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsResignRequested()
        {
            return IExecuteWithSignature<bool>("isResignRequested", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/LeaderState.html#updateLocalState-org.apache.kafka.raft.LogOffsetMetadata-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Raft.LogOffsetMetadata"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool UpdateLocalState(Org.Apache.Kafka.Raft.LogOffsetMetadata arg0)
        {
            return IExecuteWithSignature<bool>("updateLocalState", "(Lorg/apache/kafka/raft/LogOffsetMetadata;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/LeaderState.html#updateReplicaState-int-long-org.apache.kafka.raft.LogOffsetMetadata-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Raft.LogOffsetMetadata"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool UpdateReplicaState(int arg0, long arg1, Org.Apache.Kafka.Raft.LogOffsetMetadata arg2)
        {
            return IExecute<bool>("updateReplicaState", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/LeaderState.html#epoch--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Epoch()
        {
            return IExecuteWithSignature<int>("epoch", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/LeaderState.html#localId--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int LocalId()
        {
            return IExecuteWithSignature<int>("localId", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/LeaderState.html#name--"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Name()
        {
            return IExecuteWithSignature<Java.Lang.String>("name", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/LeaderState.html#nonLeaderVotersByDescendingFetchOffset--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Lang.Integer> NonLeaderVotersByDescendingFetchOffset()
        {
            return IExecuteWithSignature<Java.Util.List<Java.Lang.Integer>>("nonLeaderVotersByDescendingFetchOffset", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/LeaderState.html#highWatermark--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Org.Apache.Kafka.Raft.LogOffsetMetadata> HighWatermark()
        {
            return IExecuteWithSignature<Java.Util.Optional<Org.Apache.Kafka.Raft.LogOffsetMetadata>>("highWatermark", "()Ljava/util/Optional;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/LeaderState.html#grantingVoters--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.Integer> GrantingVoters()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.Integer>>("grantingVoters", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/LeaderState.html#nonAcknowledgingVoters--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.Integer> NonAcknowledgingVoters()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.Integer>>("nonAcknowledgingVoters", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/LeaderState.html#epochStartOffset--"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long EpochStartOffset()
        {
            return IExecuteWithSignature<long>("epochStartOffset", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/LeaderState.html#election--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Raft.ElectionState"/></returns>
        public Org.Apache.Kafka.Raft.ElectionState Election()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.ElectionState>("election", "()Lorg/apache/kafka/raft/ElectionState;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/LeaderState.html#addAcknowledgementFrom-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void AddAcknowledgementFrom(int arg0)
        {
            IExecuteWithSignature("addAcknowledgementFrom", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/LeaderState.html#appendLeaderChangeMessage-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void AppendLeaderChangeMessage(long arg0)
        {
            IExecuteWithSignature("appendLeaderChangeMessage", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/LeaderState.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/LeaderState.html#requestResign--"/>
        /// </summary>
        public void RequestResign()
        {
            IExecuteWithSignature("requestResign", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}