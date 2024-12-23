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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*  using kafka-raft-3.9.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Raft.Generated
{
    #region QuorumStateData declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/generated/QuorumStateData.html"/>
    /// </summary>
    public partial class QuorumStateData : MASES.JCOBridge.C2JBridge.JVMBridgeBase<QuorumStateData>
    {
        const string _bridgeClassName = "org.apache.kafka.raft.generated.QuorumStateData";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public QuorumStateData() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public QuorumStateData(params object[] args) : base(args) { }

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
        #region Voter declaration
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/generated/QuorumStateData.Voter.html"/>
        /// </summary>
        public partial class Voter : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Voter>
        {
            const string _bridgeClassName = "org.apache.kafka.raft.generated.QuorumStateData$Voter";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Voter() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Voter(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region QuorumStateData implementation
    public partial class QuorumStateData
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/generated/QuorumStateData.html#HIGHEST_SUPPORTED_VERSION"/>
        /// </summary>
        public static short HIGHEST_SUPPORTED_VERSION { get { if (!_HIGHEST_SUPPORTED_VERSIONReady) { _HIGHEST_SUPPORTED_VERSIONContent = SGetField<short>(LocalBridgeClazz, "HIGHEST_SUPPORTED_VERSION"); _HIGHEST_SUPPORTED_VERSIONReady = true; } return _HIGHEST_SUPPORTED_VERSIONContent; } }
        private static short _HIGHEST_SUPPORTED_VERSIONContent = default;
        private static bool _HIGHEST_SUPPORTED_VERSIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/generated/QuorumStateData.html#LOWEST_SUPPORTED_VERSION"/>
        /// </summary>
        public static short LOWEST_SUPPORTED_VERSION { get { if (!_LOWEST_SUPPORTED_VERSIONReady) { _LOWEST_SUPPORTED_VERSIONContent = SGetField<short>(LocalBridgeClazz, "LOWEST_SUPPORTED_VERSION"); _LOWEST_SUPPORTED_VERSIONReady = true; } return _LOWEST_SUPPORTED_VERSIONContent; } }
        private static short _LOWEST_SUPPORTED_VERSIONContent = default;
        private static bool _LOWEST_SUPPORTED_VERSIONReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/generated/QuorumStateData.html#leaderEpoch--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int LeaderEpoch()
        {
            return IExecuteWithSignature<int>("leaderEpoch", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/generated/QuorumStateData.html#leaderId--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int LeaderId()
        {
            return IExecuteWithSignature<int>("leaderId", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/generated/QuorumStateData.html#votedId--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int VotedId()
        {
            return IExecuteWithSignature<int>("votedId", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/generated/QuorumStateData.html#clusterId--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ClusterId()
        {
            return IExecuteWithSignature<Java.Lang.String>("clusterId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/generated/QuorumStateData.html#currentVoters--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Org.Apache.Kafka.Raft.Generated.QuorumStateData.Voter> CurrentVoters()
        {
            return IExecuteWithSignature<Java.Util.List<Org.Apache.Kafka.Raft.Generated.QuorumStateData.Voter>>("currentVoters", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/generated/QuorumStateData.html#appliedOffset--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long AppliedOffset()
        {
            return IExecuteWithSignature<long>("appliedOffset", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/generated/QuorumStateData.html#votedDirectoryId--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Uuid"/></returns>
        public Org.Apache.Kafka.Common.Uuid VotedDirectoryId()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Uuid>("votedDirectoryId", "()Lorg/apache/kafka/common/Uuid;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/generated/QuorumStateData.html#setAppliedOffset-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Raft.Generated.QuorumStateData"/></returns>
        public Org.Apache.Kafka.Raft.Generated.QuorumStateData SetAppliedOffset(long arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.Generated.QuorumStateData>("setAppliedOffset", "(J)Lorg/apache/kafka/raft/generated/QuorumStateData;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/generated/QuorumStateData.html#setClusterId-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Raft.Generated.QuorumStateData"/></returns>
        public Org.Apache.Kafka.Raft.Generated.QuorumStateData SetClusterId(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.Generated.QuorumStateData>("setClusterId", "(Ljava/lang/String;)Lorg/apache/kafka/raft/generated/QuorumStateData;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/generated/QuorumStateData.html#setCurrentVoters-java.util.List-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Raft.Generated.QuorumStateData"/></returns>
        public Org.Apache.Kafka.Raft.Generated.QuorumStateData SetCurrentVoters(Java.Util.List<Org.Apache.Kafka.Raft.Generated.QuorumStateData.Voter> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.Generated.QuorumStateData>("setCurrentVoters", "(Ljava/util/List;)Lorg/apache/kafka/raft/generated/QuorumStateData;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/generated/QuorumStateData.html#setLeaderEpoch-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Raft.Generated.QuorumStateData"/></returns>
        public Org.Apache.Kafka.Raft.Generated.QuorumStateData SetLeaderEpoch(int arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.Generated.QuorumStateData>("setLeaderEpoch", "(I)Lorg/apache/kafka/raft/generated/QuorumStateData;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/generated/QuorumStateData.html#setLeaderId-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Raft.Generated.QuorumStateData"/></returns>
        public Org.Apache.Kafka.Raft.Generated.QuorumStateData SetLeaderId(int arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.Generated.QuorumStateData>("setLeaderId", "(I)Lorg/apache/kafka/raft/generated/QuorumStateData;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/generated/QuorumStateData.html#setVotedDirectoryId-org.apache.kafka.common.Uuid-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Uuid"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Raft.Generated.QuorumStateData"/></returns>
        public Org.Apache.Kafka.Raft.Generated.QuorumStateData SetVotedDirectoryId(Org.Apache.Kafka.Common.Uuid arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.Generated.QuorumStateData>("setVotedDirectoryId", "(Lorg/apache/kafka/common/Uuid;)Lorg/apache/kafka/raft/generated/QuorumStateData;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/generated/QuorumStateData.html#setVotedId-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Raft.Generated.QuorumStateData"/></returns>
        public Org.Apache.Kafka.Raft.Generated.QuorumStateData SetVotedId(int arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.Generated.QuorumStateData>("setVotedId", "(I)Lorg/apache/kafka/raft/generated/QuorumStateData;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/generated/QuorumStateData.html#apiKey--"/>
        /// </summary>
        /// <returns><see cref="short"/></returns>
        public short ApiKey()
        {
            return IExecuteWithSignature<short>("apiKey", "()S");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/generated/QuorumStateData.html#highestSupportedVersion--"/>
        /// </summary>
        /// <returns><see cref="short"/></returns>
        public short HighestSupportedVersion()
        {
            return IExecuteWithSignature<short>("highestSupportedVersion", "()S");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/generated/QuorumStateData.html#lowestSupportedVersion--"/>
        /// </summary>
        /// <returns><see cref="short"/></returns>
        public short LowestSupportedVersion()
        {
            return IExecuteWithSignature<short>("lowestSupportedVersion", "()S");
        }

        #endregion

        #region Nested classes
        #region Voter implementation
        public partial class Voter
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/generated/QuorumStateData.Voter.html#HIGHEST_SUPPORTED_VERSION"/>
            /// </summary>
            public static short HIGHEST_SUPPORTED_VERSION { get { if (!_HIGHEST_SUPPORTED_VERSIONReady) { _HIGHEST_SUPPORTED_VERSIONContent = SGetField<short>(LocalBridgeClazz, "HIGHEST_SUPPORTED_VERSION"); _HIGHEST_SUPPORTED_VERSIONReady = true; } return _HIGHEST_SUPPORTED_VERSIONContent; } }
            private static short _HIGHEST_SUPPORTED_VERSIONContent = default;
            private static bool _HIGHEST_SUPPORTED_VERSIONReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/generated/QuorumStateData.Voter.html#LOWEST_SUPPORTED_VERSION"/>
            /// </summary>
            public static short LOWEST_SUPPORTED_VERSION { get { if (!_LOWEST_SUPPORTED_VERSIONReady) { _LOWEST_SUPPORTED_VERSIONContent = SGetField<short>(LocalBridgeClazz, "LOWEST_SUPPORTED_VERSION"); _LOWEST_SUPPORTED_VERSIONReady = true; } return _LOWEST_SUPPORTED_VERSIONContent; } }
            private static short _LOWEST_SUPPORTED_VERSIONContent = default;
            private static bool _LOWEST_SUPPORTED_VERSIONReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/generated/QuorumStateData.Voter.html#voterId--"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int VoterId()
            {
                return IExecuteWithSignature<int>("voterId", "()I");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/generated/QuorumStateData.Voter.html#setVoterId-int-"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Raft.Generated.QuorumStateData.Voter"/></returns>
            public Org.Apache.Kafka.Raft.Generated.QuorumStateData.Voter SetVoterId(int arg0)
            {
                return IExecuteWithSignature<Org.Apache.Kafka.Raft.Generated.QuorumStateData.Voter>("setVoterId", "(I)Lorg/apache/kafka/raft/generated/QuorumStateData$Voter;", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/generated/QuorumStateData.Voter.html#highestSupportedVersion--"/>
            /// </summary>
            /// <returns><see cref="short"/></returns>
            public short HighestSupportedVersion()
            {
                return IExecuteWithSignature<short>("highestSupportedVersion", "()S");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/generated/QuorumStateData.Voter.html#lowestSupportedVersion--"/>
            /// </summary>
            /// <returns><see cref="short"/></returns>
            public short LowestSupportedVersion()
            {
                return IExecuteWithSignature<short>("lowestSupportedVersion", "()S");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}