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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using connect-mirror-client-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Mirror
{
    #region RemoteClusterUtils
    public partial class RemoteClusterUtils
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.0/org/apache/kafka/connect/mirror/RemoteClusterUtils.html#replicationHops-java.util.Map-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        /// <exception cref="Java.Util.Concurrent.TimeoutException"/>
        public static int ReplicationHops(Java.Util.Map<Java.Lang.String, object> arg0, Java.Lang.String arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "replicationHops", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.0/org/apache/kafka/connect/mirror/RemoteClusterUtils.html#translateOffsets-java.util.Map-java.lang.String-java.lang.String-java.time.Duration-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Time.Duration"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        /// <exception cref="Java.Util.Concurrent.TimeoutException"/>
        public static Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Clients.Consumer.OffsetAndMetadata> TranslateOffsets(Java.Util.Map<Java.Lang.String, object> arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Time.Duration arg3)
        {
            return SExecute<Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Clients.Consumer.OffsetAndMetadata>>(LocalBridgeClazz, "translateOffsets", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.0/org/apache/kafka/connect/mirror/RemoteClusterUtils.html#checkpointTopics-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        /// <exception cref="Java.Util.Concurrent.TimeoutException"/>
        public static Java.Util.Set<Java.Lang.String> CheckpointTopics(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            return SExecuteWithSignature<Java.Util.Set<Java.Lang.String>>(LocalBridgeClazz, "checkpointTopics", "(Ljava/util/Map;)Ljava/util/Set;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.0/org/apache/kafka/connect/mirror/RemoteClusterUtils.html#heartbeatTopics-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        /// <exception cref="Java.Util.Concurrent.TimeoutException"/>
        public static Java.Util.Set<Java.Lang.String> HeartbeatTopics(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            return SExecuteWithSignature<Java.Util.Set<Java.Lang.String>>(LocalBridgeClazz, "heartbeatTopics", "(Ljava/util/Map;)Ljava/util/Set;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.0/org/apache/kafka/connect/mirror/RemoteClusterUtils.html#upstreamClusters-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        /// <exception cref="Java.Util.Concurrent.TimeoutException"/>
        public static Java.Util.Set<Java.Lang.String> UpstreamClusters(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            return SExecuteWithSignature<Java.Util.Set<Java.Lang.String>>(LocalBridgeClazz, "upstreamClusters", "(Ljava/util/Map;)Ljava/util/Set;", arg0);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}