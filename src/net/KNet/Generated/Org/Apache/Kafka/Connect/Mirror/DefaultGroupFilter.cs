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
*  using connect-mirror-3.9.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Mirror
{
    #region DefaultGroupFilter declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/DefaultGroupFilter.html"/>
    /// </summary>
    public partial class DefaultGroupFilter : Org.Apache.Kafka.Connect.Mirror.GroupFilter
    {
        const string _bridgeClassName = "org.apache.kafka.connect.mirror.DefaultGroupFilter";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DefaultGroupFilter() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DefaultGroupFilter(params object[] args) : base(args) { }

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
        public override bool IsBridgeCloseable => true;
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

    #region DefaultGroupFilter implementation
    public partial class DefaultGroupFilter
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/DefaultGroupFilter.html#GROUPS_EXCLUDE_CONFIG"/>
        /// </summary>
        public static Java.Lang.String GROUPS_EXCLUDE_CONFIG { get { if (!_GROUPS_EXCLUDE_CONFIGReady) { _GROUPS_EXCLUDE_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "GROUPS_EXCLUDE_CONFIG"); _GROUPS_EXCLUDE_CONFIGReady = true; } return _GROUPS_EXCLUDE_CONFIGContent; } }
        private static Java.Lang.String _GROUPS_EXCLUDE_CONFIGContent = default;
        private static bool _GROUPS_EXCLUDE_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/DefaultGroupFilter.html#GROUPS_EXCLUDE_CONFIG_ALIAS"/>
        /// </summary>
        public static Java.Lang.String GROUPS_EXCLUDE_CONFIG_ALIAS { get { if (!_GROUPS_EXCLUDE_CONFIG_ALIASReady) { _GROUPS_EXCLUDE_CONFIG_ALIASContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "GROUPS_EXCLUDE_CONFIG_ALIAS"); _GROUPS_EXCLUDE_CONFIG_ALIASReady = true; } return _GROUPS_EXCLUDE_CONFIG_ALIASContent; } }
        private static Java.Lang.String _GROUPS_EXCLUDE_CONFIG_ALIASContent = default;
        private static bool _GROUPS_EXCLUDE_CONFIG_ALIASReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/DefaultGroupFilter.html#GROUPS_EXCLUDE_DEFAULT"/>
        /// </summary>
        public static Java.Lang.String GROUPS_EXCLUDE_DEFAULT { get { if (!_GROUPS_EXCLUDE_DEFAULTReady) { _GROUPS_EXCLUDE_DEFAULTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "GROUPS_EXCLUDE_DEFAULT"); _GROUPS_EXCLUDE_DEFAULTReady = true; } return _GROUPS_EXCLUDE_DEFAULTContent; } }
        private static Java.Lang.String _GROUPS_EXCLUDE_DEFAULTContent = default;
        private static bool _GROUPS_EXCLUDE_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/DefaultGroupFilter.html#GROUPS_INCLUDE_CONFIG"/>
        /// </summary>
        public static Java.Lang.String GROUPS_INCLUDE_CONFIG { get { if (!_GROUPS_INCLUDE_CONFIGReady) { _GROUPS_INCLUDE_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "GROUPS_INCLUDE_CONFIG"); _GROUPS_INCLUDE_CONFIGReady = true; } return _GROUPS_INCLUDE_CONFIGContent; } }
        private static Java.Lang.String _GROUPS_INCLUDE_CONFIGContent = default;
        private static bool _GROUPS_INCLUDE_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/DefaultGroupFilter.html#GROUPS_INCLUDE_DEFAULT"/>
        /// </summary>
        public static Java.Lang.String GROUPS_INCLUDE_DEFAULT { get { if (!_GROUPS_INCLUDE_DEFAULTReady) { _GROUPS_INCLUDE_DEFAULTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "GROUPS_INCLUDE_DEFAULT"); _GROUPS_INCLUDE_DEFAULTReady = true; } return _GROUPS_INCLUDE_DEFAULTContent; } }
        private static Java.Lang.String _GROUPS_INCLUDE_DEFAULTContent = default;
        private static bool _GROUPS_INCLUDE_DEFAULTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/DefaultGroupFilter.html#shouldReplicateGroup-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ShouldReplicateGroup(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("shouldReplicateGroup", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/DefaultGroupFilter.html#configure-java.util.Map-"/>
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