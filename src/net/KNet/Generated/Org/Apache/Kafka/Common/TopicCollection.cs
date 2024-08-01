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
*  using kafka-clients-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common
{
    #region TopicCollection
    public partial class TopicCollection
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/TopicCollection.html#ofTopicIds-java.util.Collection-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.TopicCollection.TopicIdCollection"/></returns>
        public static Org.Apache.Kafka.Common.TopicCollection.TopicIdCollection OfTopicIds(Java.Util.Collection<Org.Apache.Kafka.Common.Uuid> arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.TopicCollection.TopicIdCollection>(LocalBridgeClazz, "ofTopicIds", "(Ljava/util/Collection;)Lorg/apache/kafka/common/TopicCollection$TopicIdCollection;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/TopicCollection.html#ofTopicNames-java.util.Collection-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.TopicCollection.TopicNameCollection"/></returns>
        public static Org.Apache.Kafka.Common.TopicCollection.TopicNameCollection OfTopicNames(Java.Util.Collection<Java.Lang.String> arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.TopicCollection.TopicNameCollection>(LocalBridgeClazz, "ofTopicNames", "(Ljava/util/Collection;)Lorg/apache/kafka/common/TopicCollection$TopicNameCollection;", arg0);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region TopicIdCollection
        public partial class TopicIdCollection
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/TopicCollection.TopicIdCollection.html#topicIds--"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Collection"/></returns>
            public Java.Util.Collection<Org.Apache.Kafka.Common.Uuid> TopicIds()
            {
                return IExecuteWithSignature<Java.Util.Collection<Org.Apache.Kafka.Common.Uuid>>("topicIds", "()Ljava/util/Collection;");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region TopicNameCollection
        public partial class TopicNameCollection
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/TopicCollection.TopicNameCollection.html#topicNames--"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Collection"/></returns>
            public Java.Util.Collection<Java.Lang.String> TopicNames()
            {
                return IExecuteWithSignature<Java.Util.Collection<Java.Lang.String>>("topicNames", "()Ljava/util/Collection;");
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