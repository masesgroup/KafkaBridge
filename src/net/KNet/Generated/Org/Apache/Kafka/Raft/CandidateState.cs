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
*  using kafka-raft-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Raft
{
    #region CandidateState declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.8.0/org/apache/kafka/raft/CandidateState.html"/>
    /// </summary>
    public partial class CandidateState : Org.Apache.Kafka.Raft.EpochState
    {
        const string _bridgeClassName = "org.apache.kafka.raft.CandidateState";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public CandidateState() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public CandidateState(params object[] args) : base(args) { }

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

    #region CandidateState implementation
    public partial class CandidateState
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.8.0/org/apache/kafka/raft/CandidateState.html#hasElectionTimeoutExpired-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasElectionTimeoutExpired(long arg0)
        {
            return IExecuteWithSignature<bool>("hasElectionTimeoutExpired", "(J)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.8.0/org/apache/kafka/raft/CandidateState.html#isBackingOff--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsBackingOff()
        {
            return IExecuteWithSignature<bool>("isBackingOff", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.8.0/org/apache/kafka/raft/CandidateState.html#isBackoffComplete-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsBackoffComplete(long arg0)
        {
            return IExecuteWithSignature<bool>("isBackoffComplete", "(J)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.8.0/org/apache/kafka/raft/CandidateState.html#isVoteGranted--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsVoteGranted()
        {
            return IExecuteWithSignature<bool>("isVoteGranted", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.8.0/org/apache/kafka/raft/CandidateState.html#isVoteRejected--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsVoteRejected()
        {
            return IExecuteWithSignature<bool>("isVoteRejected", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.8.0/org/apache/kafka/raft/CandidateState.html#recordGrantedVote-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RecordGrantedVote(int arg0)
        {
            return IExecuteWithSignature<bool>("recordGrantedVote", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.8.0/org/apache/kafka/raft/CandidateState.html#recordRejectedVote-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RecordRejectedVote(int arg0)
        {
            return IExecuteWithSignature<bool>("recordRejectedVote", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.8.0/org/apache/kafka/raft/CandidateState.html#epoch--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Epoch()
        {
            return IExecuteWithSignature<int>("epoch", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.8.0/org/apache/kafka/raft/CandidateState.html#localId--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int LocalId()
        {
            return IExecuteWithSignature<int>("localId", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.8.0/org/apache/kafka/raft/CandidateState.html#majoritySize--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int MajoritySize()
        {
            return IExecuteWithSignature<int>("majoritySize", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.8.0/org/apache/kafka/raft/CandidateState.html#retries--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Retries()
        {
            return IExecuteWithSignature<int>("retries", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.8.0/org/apache/kafka/raft/CandidateState.html#name--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Name()
        {
            return IExecuteWithSignature<Java.Lang.String>("name", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.8.0/org/apache/kafka/raft/CandidateState.html#highWatermark--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Org.Apache.Kafka.Raft.LogOffsetMetadata> HighWatermark()
        {
            return IExecuteWithSignature<Java.Util.Optional<Org.Apache.Kafka.Raft.LogOffsetMetadata>>("highWatermark", "()Ljava/util/Optional;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.8.0/org/apache/kafka/raft/CandidateState.html#grantingVoters--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.Integer> GrantingVoters()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.Integer>>("grantingVoters", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.8.0/org/apache/kafka/raft/CandidateState.html#rejectingVoters--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.Integer> RejectingVoters()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.Integer>>("rejectingVoters", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.8.0/org/apache/kafka/raft/CandidateState.html#unrecordedVoters--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.Integer> UnrecordedVoters()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.Integer>>("unrecordedVoters", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.8.0/org/apache/kafka/raft/CandidateState.html#remainingBackoffMs-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long RemainingBackoffMs(long arg0)
        {
            return IExecuteWithSignature<long>("remainingBackoffMs", "(J)J", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.8.0/org/apache/kafka/raft/CandidateState.html#remainingElectionTimeMs-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long RemainingElectionTimeMs(long arg0)
        {
            return IExecuteWithSignature<long>("remainingElectionTimeMs", "(J)J", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.8.0/org/apache/kafka/raft/CandidateState.html#election--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Raft.ElectionState"/></returns>
        public Org.Apache.Kafka.Raft.ElectionState Election()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.ElectionState>("election", "()Lorg/apache/kafka/raft/ElectionState;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.8.0/org/apache/kafka/raft/CandidateState.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.8.0/org/apache/kafka/raft/CandidateState.html#startBackingOff-long-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        public void StartBackingOff(long arg0, long arg1)
        {
            IExecuteWithSignature("startBackingOff", "(JJ)V", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}