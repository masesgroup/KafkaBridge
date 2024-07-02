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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using connect-mirror-client-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Mirror
{
    #region IReplicationPolicy
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IReplicationPolicy
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ReplicationPolicy
    public partial class ReplicationPolicy : Org.Apache.Kafka.Connect.Mirror.IReplicationPolicy
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.1/org/apache/kafka/connect/mirror/ReplicationPolicy.html#formatRemoteTopic-java.lang.String-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String FormatRemoteTopic(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Java.Lang.String>("formatRemoteTopic", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.1/org/apache/kafka/connect/mirror/ReplicationPolicy.html#topicSource-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String TopicSource(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("topicSource", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.1/org/apache/kafka/connect/mirror/ReplicationPolicy.html#upstreamTopic-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String UpstreamTopic(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("upstreamTopic", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.1/org/apache/kafka/connect/mirror/ReplicationPolicy.html#isCheckpointsTopic-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsCheckpointsTopic(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("isCheckpointsTopic", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.1/org/apache/kafka/connect/mirror/ReplicationPolicy.html#isHeartbeatsTopic-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsHeartbeatsTopic(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("isHeartbeatsTopic", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.1/org/apache/kafka/connect/mirror/ReplicationPolicy.html#isInternalTopic-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsInternalTopic(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("isInternalTopic", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.1/org/apache/kafka/connect/mirror/ReplicationPolicy.html#isMM2InternalTopic-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsMM2InternalTopic(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("isMM2InternalTopic", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.1/org/apache/kafka/connect/mirror/ReplicationPolicy.html#checkpointsTopic-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String CheckpointsTopic(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("checkpointsTopic", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.1/org/apache/kafka/connect/mirror/ReplicationPolicy.html#heartbeatsTopic--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String HeartbeatsTopic()
        {
            return IExecuteWithSignature<Java.Lang.String>("heartbeatsTopic", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.1/org/apache/kafka/connect/mirror/ReplicationPolicy.html#offsetSyncsTopic-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String OffsetSyncsTopic(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("offsetSyncsTopic", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.1/org/apache/kafka/connect/mirror/ReplicationPolicy.html#originalTopic-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String OriginalTopic(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("originalTopic", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}