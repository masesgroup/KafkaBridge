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
    #region DefaultTopicFilter
    public partial class DefaultTopicFilter
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/DefaultTopicFilter.html#TOPICS_EXCLUDE_CONFIG"/>
        /// </summary>
        public static string TOPICS_EXCLUDE_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "TOPICS_EXCLUDE_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/DefaultTopicFilter.html#TOPICS_EXCLUDE_CONFIG_ALIAS"/>
        /// </summary>
        public static string TOPICS_EXCLUDE_CONFIG_ALIAS { get { return SGetField<string>(LocalBridgeClazz, "TOPICS_EXCLUDE_CONFIG_ALIAS"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/DefaultTopicFilter.html#TOPICS_EXCLUDE_DEFAULT"/>
        /// </summary>
        public static string TOPICS_EXCLUDE_DEFAULT { get { return SGetField<string>(LocalBridgeClazz, "TOPICS_EXCLUDE_DEFAULT"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/DefaultTopicFilter.html#TOPICS_INCLUDE_CONFIG"/>
        /// </summary>
        public static string TOPICS_INCLUDE_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "TOPICS_INCLUDE_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/DefaultTopicFilter.html#TOPICS_INCLUDE_DEFAULT"/>
        /// </summary>
        public static string TOPICS_INCLUDE_DEFAULT { get { return SGetField<string>(LocalBridgeClazz, "TOPICS_INCLUDE_DEFAULT"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/DefaultTopicFilter.html#shouldReplicateTopic-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ShouldReplicateTopic(string arg0)
        {
            return IExecute<bool>("shouldReplicateTopic", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.1/org/apache/kafka/connect/mirror/DefaultTopicFilter.html#configure-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public void Configure(Java.Util.Map<string, object> arg0)
        {
            IExecute("configure", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}