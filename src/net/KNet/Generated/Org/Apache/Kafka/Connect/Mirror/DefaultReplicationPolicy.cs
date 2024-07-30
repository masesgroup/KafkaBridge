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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using connect-mirror-client-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Mirror
{
    #region DefaultReplicationPolicy
    public partial class DefaultReplicationPolicy : Org.Apache.Kafka.Connect.Mirror.IReplicationPolicy, Org.Apache.Kafka.Common.IConfigurable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Mirror.DefaultReplicationPolicy"/> to <see cref="Org.Apache.Kafka.Connect.Mirror.ReplicationPolicy"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Connect.Mirror.ReplicationPolicy(Org.Apache.Kafka.Connect.Mirror.DefaultReplicationPolicy t) => t.Cast<Org.Apache.Kafka.Connect.Mirror.ReplicationPolicy>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Mirror.DefaultReplicationPolicy"/> to <see cref="Org.Apache.Kafka.Common.Configurable"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Configurable(Org.Apache.Kafka.Connect.Mirror.DefaultReplicationPolicy t) => t.Cast<Org.Apache.Kafka.Common.Configurable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.1/org/apache/kafka/connect/mirror/DefaultReplicationPolicy.html#INTERNAL_TOPIC_SEPARATOR_ENABLED_DEFAULT"/>
        /// </summary>
        public static Java.Lang.Boolean INTERNAL_TOPIC_SEPARATOR_ENABLED_DEFAULT { get { if (!_INTERNAL_TOPIC_SEPARATOR_ENABLED_DEFAULTReady) { _INTERNAL_TOPIC_SEPARATOR_ENABLED_DEFAULTContent = SGetField<Java.Lang.Boolean>(LocalBridgeClazz, "INTERNAL_TOPIC_SEPARATOR_ENABLED_DEFAULT"); _INTERNAL_TOPIC_SEPARATOR_ENABLED_DEFAULTReady = true; } return _INTERNAL_TOPIC_SEPARATOR_ENABLED_DEFAULTContent; } }
        private static Java.Lang.Boolean _INTERNAL_TOPIC_SEPARATOR_ENABLED_DEFAULTContent = default;
        private static bool _INTERNAL_TOPIC_SEPARATOR_ENABLED_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.1/org/apache/kafka/connect/mirror/DefaultReplicationPolicy.html#INTERNAL_TOPIC_SEPARATOR_ENABLED_CONFIG"/>
        /// </summary>
        public static Java.Lang.String INTERNAL_TOPIC_SEPARATOR_ENABLED_CONFIG { get { if (!_INTERNAL_TOPIC_SEPARATOR_ENABLED_CONFIGReady) { _INTERNAL_TOPIC_SEPARATOR_ENABLED_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "INTERNAL_TOPIC_SEPARATOR_ENABLED_CONFIG"); _INTERNAL_TOPIC_SEPARATOR_ENABLED_CONFIGReady = true; } return _INTERNAL_TOPIC_SEPARATOR_ENABLED_CONFIGContent; } }
        private static Java.Lang.String _INTERNAL_TOPIC_SEPARATOR_ENABLED_CONFIGContent = default;
        private static bool _INTERNAL_TOPIC_SEPARATOR_ENABLED_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.1/org/apache/kafka/connect/mirror/DefaultReplicationPolicy.html#SEPARATOR_CONFIG"/>
        /// </summary>
        public static Java.Lang.String SEPARATOR_CONFIG { get { if (!_SEPARATOR_CONFIGReady) { _SEPARATOR_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SEPARATOR_CONFIG"); _SEPARATOR_CONFIGReady = true; } return _SEPARATOR_CONFIGContent; } }
        private static Java.Lang.String _SEPARATOR_CONFIGContent = default;
        private static bool _SEPARATOR_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.1/org/apache/kafka/connect/mirror/DefaultReplicationPolicy.html#SEPARATOR_DEFAULT"/>
        /// </summary>
        public static Java.Lang.String SEPARATOR_DEFAULT { get { if (!_SEPARATOR_DEFAULTReady) { _SEPARATOR_DEFAULTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SEPARATOR_DEFAULT"); _SEPARATOR_DEFAULTReady = true; } return _SEPARATOR_DEFAULTContent; } }
        private static Java.Lang.String _SEPARATOR_DEFAULTContent = default;
        private static bool _SEPARATOR_DEFAULTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.1/org/apache/kafka/connect/mirror/DefaultReplicationPolicy.html#isCheckpointsTopic-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsCheckpointsTopic(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("isCheckpointsTopic", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.1/org/apache/kafka/connect/mirror/DefaultReplicationPolicy.html#isMM2InternalTopic-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsMM2InternalTopic(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("isMM2InternalTopic", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.1/org/apache/kafka/connect/mirror/DefaultReplicationPolicy.html#checkpointsTopic-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String CheckpointsTopic(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("checkpointsTopic", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.1/org/apache/kafka/connect/mirror/DefaultReplicationPolicy.html#formatRemoteTopic-java.lang.String-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String FormatRemoteTopic(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Java.Lang.String>("formatRemoteTopic", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.1/org/apache/kafka/connect/mirror/DefaultReplicationPolicy.html#offsetSyncsTopic-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String OffsetSyncsTopic(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("offsetSyncsTopic", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.1/org/apache/kafka/connect/mirror/DefaultReplicationPolicy.html#topicSource-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String TopicSource(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("topicSource", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.1/org/apache/kafka/connect/mirror/DefaultReplicationPolicy.html#upstreamTopic-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String UpstreamTopic(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("upstreamTopic", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.1/org/apache/kafka/connect/mirror/DefaultReplicationPolicy.html#configure-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public void Configure(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            IExecuteWithSignature("configure", "(Ljava/util/Map;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}