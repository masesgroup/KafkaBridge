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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using connect-mirror-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Mirror
{
    #region DefaultTopicFilter declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.8.0/org/apache/kafka/connect/mirror/DefaultTopicFilter.html"/>
    /// </summary>
    public partial class DefaultTopicFilter : Org.Apache.Kafka.Connect.Mirror.TopicFilter
    {
        const string _bridgeClassName = "org.apache.kafka.connect.mirror.DefaultTopicFilter";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DefaultTopicFilter() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DefaultTopicFilter(params object[] args) : base(args) { }

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

    #region DefaultTopicFilter implementation
    public partial class DefaultTopicFilter
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.8.0/org/apache/kafka/connect/mirror/DefaultTopicFilter.html#TOPICS_EXCLUDE_CONFIG"/>
        /// </summary>
        public static Java.Lang.String TOPICS_EXCLUDE_CONFIG { get { if (!_TOPICS_EXCLUDE_CONFIGReady) { _TOPICS_EXCLUDE_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TOPICS_EXCLUDE_CONFIG"); _TOPICS_EXCLUDE_CONFIGReady = true; } return _TOPICS_EXCLUDE_CONFIGContent; } }
        private static Java.Lang.String _TOPICS_EXCLUDE_CONFIGContent = default;
        private static bool _TOPICS_EXCLUDE_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.8.0/org/apache/kafka/connect/mirror/DefaultTopicFilter.html#TOPICS_EXCLUDE_CONFIG_ALIAS"/>
        /// </summary>
        public static Java.Lang.String TOPICS_EXCLUDE_CONFIG_ALIAS { get { if (!_TOPICS_EXCLUDE_CONFIG_ALIASReady) { _TOPICS_EXCLUDE_CONFIG_ALIASContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TOPICS_EXCLUDE_CONFIG_ALIAS"); _TOPICS_EXCLUDE_CONFIG_ALIASReady = true; } return _TOPICS_EXCLUDE_CONFIG_ALIASContent; } }
        private static Java.Lang.String _TOPICS_EXCLUDE_CONFIG_ALIASContent = default;
        private static bool _TOPICS_EXCLUDE_CONFIG_ALIASReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.8.0/org/apache/kafka/connect/mirror/DefaultTopicFilter.html#TOPICS_EXCLUDE_DEFAULT"/>
        /// </summary>
        public static Java.Lang.String TOPICS_EXCLUDE_DEFAULT { get { if (!_TOPICS_EXCLUDE_DEFAULTReady) { _TOPICS_EXCLUDE_DEFAULTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TOPICS_EXCLUDE_DEFAULT"); _TOPICS_EXCLUDE_DEFAULTReady = true; } return _TOPICS_EXCLUDE_DEFAULTContent; } }
        private static Java.Lang.String _TOPICS_EXCLUDE_DEFAULTContent = default;
        private static bool _TOPICS_EXCLUDE_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.8.0/org/apache/kafka/connect/mirror/DefaultTopicFilter.html#TOPICS_INCLUDE_CONFIG"/>
        /// </summary>
        public static Java.Lang.String TOPICS_INCLUDE_CONFIG { get { if (!_TOPICS_INCLUDE_CONFIGReady) { _TOPICS_INCLUDE_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TOPICS_INCLUDE_CONFIG"); _TOPICS_INCLUDE_CONFIGReady = true; } return _TOPICS_INCLUDE_CONFIGContent; } }
        private static Java.Lang.String _TOPICS_INCLUDE_CONFIGContent = default;
        private static bool _TOPICS_INCLUDE_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.8.0/org/apache/kafka/connect/mirror/DefaultTopicFilter.html#TOPICS_INCLUDE_DEFAULT"/>
        /// </summary>
        public static Java.Lang.String TOPICS_INCLUDE_DEFAULT { get { if (!_TOPICS_INCLUDE_DEFAULTReady) { _TOPICS_INCLUDE_DEFAULTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TOPICS_INCLUDE_DEFAULT"); _TOPICS_INCLUDE_DEFAULTReady = true; } return _TOPICS_INCLUDE_DEFAULTContent; } }
        private static Java.Lang.String _TOPICS_INCLUDE_DEFAULTContent = default;
        private static bool _TOPICS_INCLUDE_DEFAULTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.8.0/org/apache/kafka/connect/mirror/DefaultTopicFilter.html#shouldReplicateTopic-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ShouldReplicateTopic(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("shouldReplicateTopic", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.8.0/org/apache/kafka/connect/mirror/DefaultTopicFilter.html#configure-java.util.Map-"/>
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