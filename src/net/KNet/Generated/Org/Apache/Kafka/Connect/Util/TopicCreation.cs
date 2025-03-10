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
*  using connect-runtime-3.9.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Util
{
    #region TopicCreation declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.9.0/org/apache/kafka/connect/util/TopicCreation.html"/>
    /// </summary>
    public partial class TopicCreation : MASES.JCOBridge.C2JBridge.JVMBridgeBase<TopicCreation>
    {
        const string _bridgeClassName = "org.apache.kafka.connect.util.TopicCreation";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TopicCreation() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TopicCreation(params object[] args) : base(args) { }

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

    #region TopicCreation implementation
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.9.0/org/apache/kafka/connect/util/TopicCreation.html#empty--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Util.TopicCreation"/></returns>
        public static Org.Apache.Kafka.Connect.Util.TopicCreation Empty()
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Connect.Util.TopicCreation>(LocalBridgeClazz, "empty", "()Lorg/apache/kafka/connect/util/TopicCreation;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.9.0/org/apache/kafka/connect/util/TopicCreation.html#isTopicCreationEnabled--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsTopicCreationEnabled()
        {
            return IExecuteWithSignature<bool>("isTopicCreationEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.9.0/org/apache/kafka/connect/util/TopicCreation.html#isTopicCreationRequired-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsTopicCreationRequired(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("isTopicCreationRequired", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.9.0/org/apache/kafka/connect/util/TopicCreation.html#topicGroups--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, Org.Apache.Kafka.Connect.Util.TopicCreationGroup> TopicGroups()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Org.Apache.Kafka.Connect.Util.TopicCreationGroup>>("topicGroups", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.9.0/org/apache/kafka/connect/util/TopicCreation.html#defaultTopicGroup--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Util.TopicCreationGroup"/></returns>
        public Org.Apache.Kafka.Connect.Util.TopicCreationGroup DefaultTopicGroup()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Util.TopicCreationGroup>("defaultTopicGroup", "()Lorg/apache/kafka/connect/util/TopicCreationGroup;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.9.0/org/apache/kafka/connect/util/TopicCreation.html#findFirstGroup-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Util.TopicCreationGroup"/></returns>
        public Org.Apache.Kafka.Connect.Util.TopicCreationGroup FindFirstGroup(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Util.TopicCreationGroup>("findFirstGroup", "(Ljava/lang/String;)Lorg/apache/kafka/connect/util/TopicCreationGroup;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.9.0/org/apache/kafka/connect/util/TopicCreation.html#addTopic-java.lang.String-"/>
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