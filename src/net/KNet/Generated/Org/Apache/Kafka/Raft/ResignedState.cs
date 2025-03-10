/*
*  Copyright 2025 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.5.12.0)
*  using kafka-raft-3.9.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Raft
{
    #region ResignedState declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/ResignedState.html"/>
    /// </summary>
    public partial class ResignedState : Org.Apache.Kafka.Raft.EpochState
    {
        const string _bridgeClassName = "org.apache.kafka.raft.ResignedState";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ResignedState() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ResignedState(params object[] args) : base(args) { }

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
        public override bool IsBridgeCloseable => true;
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

    #region ResignedState implementation
    public partial class ResignedState
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/ResignedState.html#org.apache.kafka.raft.ResignedState(org.apache.kafka.common.utils.Time,int,int,java.util.Set,long,java.util.List,org.apache.kafka.raft.Endpoints,org.apache.kafka.common.utils.LogContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Utils.Time"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Util.Set"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        /// <param name="arg5"><see cref="Java.Util.List"/></param>
        /// <param name="arg6"><see cref="Org.Apache.Kafka.Raft.Endpoints"/></param>
        /// <param name="arg7"><see cref="Org.Apache.Kafka.Common.Utils.LogContext"/></param>
        public ResignedState(Org.Apache.Kafka.Common.Utils.Time arg0, int arg1, int arg2, Java.Util.Set<Java.Lang.Integer> arg3, long arg4, Java.Util.List<Org.Apache.Kafka.Raft.ReplicaKey> arg5, Org.Apache.Kafka.Raft.Endpoints arg6, Org.Apache.Kafka.Common.Utils.LogContext arg7)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/ResignedState.html#canGrantVote-org.apache.kafka.raft.ReplicaKey-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Raft.ReplicaKey"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CanGrantVote(Org.Apache.Kafka.Raft.ReplicaKey arg0, bool arg1)
        {
            return IExecuteWithSignature<bool>("canGrantVote", "(Lorg/apache/kafka/raft/ReplicaKey;Z)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/ResignedState.html#hasElectionTimeoutExpired-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasElectionTimeoutExpired(long arg0)
        {
            return IExecuteWithSignature<bool>("hasElectionTimeoutExpired", "(J)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/ResignedState.html#epoch--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Epoch()
        {
            return IExecuteWithSignature<int>("epoch", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/ResignedState.html#name--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Name()
        {
            return IExecuteWithSignature<Java.Lang.String>("name", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/ResignedState.html#preferredSuccessors--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Org.Apache.Kafka.Raft.ReplicaKey> PreferredSuccessors()
        {
            return IExecuteWithSignature<Java.Util.List<Org.Apache.Kafka.Raft.ReplicaKey>>("preferredSuccessors", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/ResignedState.html#unackedVoters--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.Integer> UnackedVoters()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.Integer>>("unackedVoters", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/ResignedState.html#remainingElectionTimeMs-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long RemainingElectionTimeMs(long arg0)
        {
            return IExecuteWithSignature<long>("remainingElectionTimeMs", "(J)J", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/ResignedState.html#election--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Raft.ElectionState"/></returns>
        public Org.Apache.Kafka.Raft.ElectionState Election()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.ElectionState>("election", "()Lorg/apache/kafka/raft/ElectionState;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/ResignedState.html#leaderEndpoints--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Raft.Endpoints"/></returns>
        public Org.Apache.Kafka.Raft.Endpoints LeaderEndpoints()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.Endpoints>("leaderEndpoints", "()Lorg/apache/kafka/raft/Endpoints;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/ResignedState.html#acknowledgeResignation-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void AcknowledgeResignation(int arg0)
        {
            IExecuteWithSignature("acknowledgeResignation", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/ResignedState.html#close--"/>
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