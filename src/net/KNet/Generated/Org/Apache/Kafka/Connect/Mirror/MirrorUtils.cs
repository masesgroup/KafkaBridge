/*
*  Copyright 2023 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.1.0.0)
*  using connect-mirror-3.6.1.jar as reference
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/MirrorUtils.html#OFFSET_KEY"/>
        /// </summary>
        public static string OFFSET_KEY { get { return SGetField<string>(LocalBridgeClazz, "OFFSET_KEY"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/MirrorUtils.html#PARTITION_KEY"/>
        /// </summary>
        public static string PARTITION_KEY { get { return SGetField<string>(LocalBridgeClazz, "PARTITION_KEY"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/MirrorUtils.html#SOURCE_CLUSTER_KEY"/>
        /// </summary>
        public static string SOURCE_CLUSTER_KEY { get { return SGetField<string>(LocalBridgeClazz, "SOURCE_CLUSTER_KEY"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/MirrorUtils.html#TOPIC_KEY"/>
        /// </summary>
        public static string TOPIC_KEY { get { return SGetField<string>(LocalBridgeClazz, "TOPIC_KEY"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/MirrorUtils.html#wrapOffset-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public static Java.Util.Map<string, object> WrapOffset(long arg0)
        {
            return SExecute<Java.Util.Map<string, object>>(LocalBridgeClazz, "wrapOffset", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/MirrorUtils.html#unwrapPartition-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.TopicPartition"/></returns>
        public static Org.Apache.Kafka.Common.TopicPartition UnwrapPartition(Java.Util.Map<string, object> arg0)
        {
            return SExecute<Org.Apache.Kafka.Common.TopicPartition>(LocalBridgeClazz, "unwrapPartition", arg0);
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