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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using connect-runtime-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Util
{
    #region TopicCreation
    public partial class TopicCreation
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.1/org/apache/kafka/connect/util/TopicCreation.html#empty--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Util.TopicCreation"/></returns>
        public static Org.Apache.Kafka.Connect.Util.TopicCreation Empty()
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Connect.Util.TopicCreation>(LocalBridgeClazz, "empty", "()Lorg/apache/kafka/connect/util/TopicCreation;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.1/org/apache/kafka/connect/util/TopicCreation.html#isTopicCreationEnabled--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsTopicCreationEnabled()
        {
            return IExecuteWithSignature<bool>("isTopicCreationEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.1/org/apache/kafka/connect/util/TopicCreation.html#isTopicCreationRequired-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsTopicCreationRequired(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("isTopicCreationRequired", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.1/org/apache/kafka/connect/util/TopicCreation.html#topicGroups--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, Org.Apache.Kafka.Connect.Util.TopicCreationGroup> TopicGroups()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Org.Apache.Kafka.Connect.Util.TopicCreationGroup>>("topicGroups", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.1/org/apache/kafka/connect/util/TopicCreation.html#defaultTopicGroup--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Util.TopicCreationGroup"/></returns>
        public Org.Apache.Kafka.Connect.Util.TopicCreationGroup DefaultTopicGroup()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Util.TopicCreationGroup>("defaultTopicGroup", "()Lorg/apache/kafka/connect/util/TopicCreationGroup;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.1/org/apache/kafka/connect/util/TopicCreation.html#findFirstGroup-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Util.TopicCreationGroup"/></returns>
        public Org.Apache.Kafka.Connect.Util.TopicCreationGroup FindFirstGroup(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Util.TopicCreationGroup>("findFirstGroup", "(Ljava/lang/String;)Lorg/apache/kafka/connect/util/TopicCreationGroup;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.1/org/apache/kafka/connect/util/TopicCreation.html#addTopic-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void AddTopic(Java.Lang.String arg0)
        {
            IExecuteWithSignature("addTopic", "(Ljava/lang/String;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}