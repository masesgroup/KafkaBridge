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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using connect-mirror-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Mirror
{
    #region MirrorUtils
    public partial class MirrorUtils
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.8.0/org/apache/kafka/connect/mirror/MirrorUtils.html#OFFSET_KEY"/>
        /// </summary>
        public static Java.Lang.String OFFSET_KEY { get { if (!_OFFSET_KEYReady) { _OFFSET_KEYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "OFFSET_KEY"); _OFFSET_KEYReady = true; } return _OFFSET_KEYContent; } }
        private static Java.Lang.String _OFFSET_KEYContent = default;
        private static bool _OFFSET_KEYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.8.0/org/apache/kafka/connect/mirror/MirrorUtils.html#PARTITION_KEY"/>
        /// </summary>
        public static Java.Lang.String PARTITION_KEY { get { if (!_PARTITION_KEYReady) { _PARTITION_KEYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "PARTITION_KEY"); _PARTITION_KEYReady = true; } return _PARTITION_KEYContent; } }
        private static Java.Lang.String _PARTITION_KEYContent = default;
        private static bool _PARTITION_KEYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.8.0/org/apache/kafka/connect/mirror/MirrorUtils.html#SOURCE_CLUSTER_KEY"/>
        /// </summary>
        public static Java.Lang.String SOURCE_CLUSTER_KEY { get { if (!_SOURCE_CLUSTER_KEYReady) { _SOURCE_CLUSTER_KEYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SOURCE_CLUSTER_KEY"); _SOURCE_CLUSTER_KEYReady = true; } return _SOURCE_CLUSTER_KEYContent; } }
        private static Java.Lang.String _SOURCE_CLUSTER_KEYContent = default;
        private static bool _SOURCE_CLUSTER_KEYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.8.0/org/apache/kafka/connect/mirror/MirrorUtils.html#TOPIC_KEY"/>
        /// </summary>
        public static Java.Lang.String TOPIC_KEY { get { if (!_TOPIC_KEYReady) { _TOPIC_KEYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TOPIC_KEY"); _TOPIC_KEYReady = true; } return _TOPIC_KEYContent; } }
        private static Java.Lang.String _TOPIC_KEYContent = default;
        private static bool _TOPIC_KEYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.8.0/org/apache/kafka/connect/mirror/MirrorUtils.html#wrapOffset-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public static Java.Util.Map<Java.Lang.String, object> WrapOffset(long arg0)
        {
            return SExecuteWithSignature<Java.Util.Map<Java.Lang.String, object>>(LocalBridgeClazz, "wrapOffset", "(J)Ljava/util/Map;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.8.0/org/apache/kafka/connect/mirror/MirrorUtils.html#unwrapPartition-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.TopicPartition"/></returns>
        public static Org.Apache.Kafka.Common.TopicPartition UnwrapPartition(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.TopicPartition>(LocalBridgeClazz, "unwrapPartition", "(Ljava/util/Map;)Lorg/apache/kafka/common/TopicPartition;", arg0);
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