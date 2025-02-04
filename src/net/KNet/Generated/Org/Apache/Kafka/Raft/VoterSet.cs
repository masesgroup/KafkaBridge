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
    #region VoterSet declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/VoterSet.html"/>
    /// </summary>
    public partial class VoterSet : MASES.JCOBridge.C2JBridge.JVMBridgeBase<VoterSet>
    {
        const string _bridgeClassName = "org.apache.kafka.raft.VoterSet";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public VoterSet() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public VoterSet(params object[] args) : base(args) { }

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
        #region VoterNode declaration
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/VoterSet.VoterNode.html"/>
        /// </summary>
        public partial class VoterNode : MASES.JCOBridge.C2JBridge.JVMBridgeBase<VoterNode>
        {
            const string _bridgeClassName = "org.apache.kafka.raft.VoterSet$VoterNode";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public VoterNode() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public VoterNode(params object[] args) : base(args) { }

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

    #region VoterSet implementation
    public partial class VoterSet
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/VoterSet.html#empty--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Raft.VoterSet"/></returns>
        public static Org.Apache.Kafka.Raft.VoterSet Empty()
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Raft.VoterSet>(LocalBridgeClazz, "empty", "()Lorg/apache/kafka/raft/VoterSet;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/VoterSet.html#fromMap-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Raft.VoterSet"/></returns>
        public static Org.Apache.Kafka.Raft.VoterSet FromMap(Java.Util.Map<Java.Lang.Integer, Org.Apache.Kafka.Raft.VoterSet.VoterNode> arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Raft.VoterSet>(LocalBridgeClazz, "fromMap", "(Ljava/util/Map;)Lorg/apache/kafka/raft/VoterSet;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/VoterSet.html#hasOverlappingMajority-org.apache.kafka.raft.VoterSet-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Raft.VoterSet"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasOverlappingMajority(Org.Apache.Kafka.Raft.VoterSet arg0)
        {
            return IExecuteWithSignature<bool>("hasOverlappingMajority", "(Lorg/apache/kafka/raft/VoterSet;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/VoterSet.html#isOnlyVoter-org.apache.kafka.raft.ReplicaKey-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Raft.ReplicaKey"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsOnlyVoter(Org.Apache.Kafka.Raft.ReplicaKey arg0)
        {
            return IExecuteWithSignature<bool>("isOnlyVoter", "(Lorg/apache/kafka/raft/ReplicaKey;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/VoterSet.html#isVoter-org.apache.kafka.raft.ReplicaKey-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Raft.ReplicaKey"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsVoter(Org.Apache.Kafka.Raft.ReplicaKey arg0)
        {
            return IExecuteWithSignature<bool>("isVoter", "(Lorg/apache/kafka/raft/ReplicaKey;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/VoterSet.html#voterNodeNeedsUpdate-org.apache.kafka.raft.VoterSet.VoterNode-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Raft.VoterSet.VoterNode"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool VoterNodeNeedsUpdate(Org.Apache.Kafka.Raft.VoterSet.VoterNode arg0)
        {
            return IExecuteWithSignature<bool>("voterNodeNeedsUpdate", "(Lorg/apache/kafka/raft/VoterSet$VoterNode;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/VoterSet.html#addVoter-org.apache.kafka.raft.VoterSet.VoterNode-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Raft.VoterSet.VoterNode"/></param>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Org.Apache.Kafka.Raft.VoterSet> AddVoter(Org.Apache.Kafka.Raft.VoterSet.VoterNode arg0)
        {
            return IExecuteWithSignature<Java.Util.Optional<Org.Apache.Kafka.Raft.VoterSet>>("addVoter", "(Lorg/apache/kafka/raft/VoterSet$VoterNode;)Ljava/util/Optional;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/VoterSet.html#removeVoter-org.apache.kafka.raft.ReplicaKey-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Raft.ReplicaKey"/></param>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Org.Apache.Kafka.Raft.VoterSet> RemoveVoter(Org.Apache.Kafka.Raft.ReplicaKey arg0)
        {
            return IExecuteWithSignature<Java.Util.Optional<Org.Apache.Kafka.Raft.VoterSet>>("removeVoter", "(Lorg/apache/kafka/raft/ReplicaKey;)Ljava/util/Optional;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/VoterSet.html#updateVoter-org.apache.kafka.raft.VoterSet.VoterNode-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Raft.VoterSet.VoterNode"/></param>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Org.Apache.Kafka.Raft.VoterSet> UpdateVoter(Org.Apache.Kafka.Raft.VoterSet.VoterNode arg0)
        {
            return IExecuteWithSignature<Java.Util.Optional<Org.Apache.Kafka.Raft.VoterSet>>("updateVoter", "(Lorg/apache/kafka/raft/VoterSet$VoterNode;)Ljava/util/Optional;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/VoterSet.html#voterIds--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.Integer> VoterIds()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.Integer>>("voterIds", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/VoterSet.html#voterKeys--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Org.Apache.Kafka.Raft.ReplicaKey> VoterKeys()
        {
            return IExecuteWithSignature<Java.Util.Set<Org.Apache.Kafka.Raft.ReplicaKey>>("voterKeys", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/VoterSet.html#voterNodes--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Org.Apache.Kafka.Raft.VoterSet.VoterNode> VoterNodes()
        {
            return IExecuteWithSignature<Java.Util.Set<Org.Apache.Kafka.Raft.VoterSet.VoterNode>>("voterNodes", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/VoterSet.html#listeners-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Raft.Endpoints"/></returns>
        public Org.Apache.Kafka.Raft.Endpoints Listeners(int arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.Endpoints>("listeners", "(I)Lorg/apache/kafka/raft/Endpoints;", arg0);
        }

        #endregion

        #region Nested classes
        #region VoterNode implementation
        public partial class VoterNode
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/VoterSet.VoterNode.html#isVoter-org.apache.kafka.raft.ReplicaKey-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Raft.ReplicaKey"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool IsVoter(Org.Apache.Kafka.Raft.ReplicaKey arg0)
            {
                return IExecuteWithSignature<bool>("isVoter", "(Lorg/apache/kafka/raft/ReplicaKey;)Z", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/VoterSet.VoterNode.html#listeners--"/>
            /// </summary>
            /// <returns><see cref="Org.Apache.Kafka.Raft.Endpoints"/></returns>
            public Org.Apache.Kafka.Raft.Endpoints Listeners()
            {
                return IExecuteWithSignature<Org.Apache.Kafka.Raft.Endpoints>("listeners", "()Lorg/apache/kafka/raft/Endpoints;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.9.0/org/apache/kafka/raft/VoterSet.VoterNode.html#voterKey--"/>
            /// </summary>
            /// <returns><see cref="Org.Apache.Kafka.Raft.ReplicaKey"/></returns>
            public Org.Apache.Kafka.Raft.ReplicaKey VoterKey()
            {
                return IExecuteWithSignature<Org.Apache.Kafka.Raft.ReplicaKey>("voterKey", "()Lorg/apache/kafka/raft/ReplicaKey;");
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