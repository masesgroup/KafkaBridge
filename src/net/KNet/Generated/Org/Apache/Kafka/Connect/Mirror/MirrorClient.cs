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
*  using connect-mirror-client-3.9.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Mirror
{
    #region MirrorClient declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.9.0/org/apache/kafka/connect/mirror/MirrorClient.html"/>
    /// </summary>
    public partial class MirrorClient : Java.Lang.AutoCloseable
    {
        const string _bridgeClassName = "org.apache.kafka.connect.mirror.MirrorClient";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public MirrorClient() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public MirrorClient(params object[] args) : base(args) { }

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

    #region MirrorClient implementation
    public partial class MirrorClient
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.9.0/org/apache/kafka/connect/mirror/MirrorClient.html#org.apache.kafka.connect.mirror.MirrorClient(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public MirrorClient(Java.Util.Map<Java.Lang.String, object> arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.9.0/org/apache/kafka/connect/mirror/MirrorClient.html#org.apache.kafka.connect.mirror.MirrorClient(org.apache.kafka.connect.mirror.MirrorClientConfig)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Mirror.MirrorClientConfig"/></param>
        public MirrorClient(Org.Apache.Kafka.Connect.Mirror.MirrorClientConfig arg0)
            : base(arg0)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.9.0/org/apache/kafka/connect/mirror/MirrorClient.html#replicationHops-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public int ReplicationHops(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<int>("replicationHops", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.9.0/org/apache/kafka/connect/mirror/MirrorClient.html#remoteConsumerOffsets-java.lang.String-java.lang.String-java.time.Duration-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Time.Duration"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Clients.Consumer.OffsetAndMetadata> RemoteConsumerOffsets(Java.Lang.String arg0, Java.Lang.String arg1, Java.Time.Duration arg2)
        {
            return IExecuteWithSignature<Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Clients.Consumer.OffsetAndMetadata>>("remoteConsumerOffsets", "(Ljava/lang/String;Ljava/lang/String;Ljava/time/Duration;)Ljava/util/Map;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.9.0/org/apache/kafka/connect/mirror/MirrorClient.html#checkpointTopics--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public Java.Util.Set<Java.Lang.String> CheckpointTopics()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("checkpointTopics", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.9.0/org/apache/kafka/connect/mirror/MirrorClient.html#heartbeatTopics--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public Java.Util.Set<Java.Lang.String> HeartbeatTopics()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("heartbeatTopics", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.9.0/org/apache/kafka/connect/mirror/MirrorClient.html#remoteTopics--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public Java.Util.Set<Java.Lang.String> RemoteTopics()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("remoteTopics", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.9.0/org/apache/kafka/connect/mirror/MirrorClient.html#remoteTopics-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public Java.Util.Set<Java.Lang.String> RemoteTopics(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("remoteTopics", "(Ljava/lang/String;)Ljava/util/Set;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.9.0/org/apache/kafka/connect/mirror/MirrorClient.html#upstreamClusters--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public Java.Util.Set<Java.Lang.String> UpstreamClusters()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("upstreamClusters", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.9.0/org/apache/kafka/connect/mirror/MirrorClient.html#replicationPolicy--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Mirror.ReplicationPolicy"/></returns>
        public Org.Apache.Kafka.Connect.Mirror.ReplicationPolicy ReplicationPolicy()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Mirror.ReplicationPolicy>("replicationPolicy", "()Lorg/apache/kafka/connect/mirror/ReplicationPolicy;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.9.0/org/apache/kafka/connect/mirror/MirrorClient.html#close--"/>
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