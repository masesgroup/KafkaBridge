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
    #region DefaultConfigPropertyFilter declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/DefaultConfigPropertyFilter.html"/>
    /// </summary>
    public partial class DefaultConfigPropertyFilter : Org.Apache.Kafka.Connect.Mirror.ConfigPropertyFilter
    {
        const string _bridgeClassName = "org.apache.kafka.connect.mirror.DefaultConfigPropertyFilter";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DefaultConfigPropertyFilter() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DefaultConfigPropertyFilter(params object[] args) : base(args) { }

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

    #region DefaultConfigPropertyFilter implementation
    public partial class DefaultConfigPropertyFilter
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/DefaultConfigPropertyFilter.html#CONFIG_PROPERTIES_EXCLUDE_ALIAS_CONFIG"/>
        /// </summary>
        public static Java.Lang.String CONFIG_PROPERTIES_EXCLUDE_ALIAS_CONFIG { get { if (!_CONFIG_PROPERTIES_EXCLUDE_ALIAS_CONFIGReady) { _CONFIG_PROPERTIES_EXCLUDE_ALIAS_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CONFIG_PROPERTIES_EXCLUDE_ALIAS_CONFIG"); _CONFIG_PROPERTIES_EXCLUDE_ALIAS_CONFIGReady = true; } return _CONFIG_PROPERTIES_EXCLUDE_ALIAS_CONFIGContent; } }
        private static Java.Lang.String _CONFIG_PROPERTIES_EXCLUDE_ALIAS_CONFIGContent = default;
        private static bool _CONFIG_PROPERTIES_EXCLUDE_ALIAS_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/DefaultConfigPropertyFilter.html#CONFIG_PROPERTIES_EXCLUDE_CONFIG"/>
        /// </summary>
        public static Java.Lang.String CONFIG_PROPERTIES_EXCLUDE_CONFIG { get { if (!_CONFIG_PROPERTIES_EXCLUDE_CONFIGReady) { _CONFIG_PROPERTIES_EXCLUDE_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CONFIG_PROPERTIES_EXCLUDE_CONFIG"); _CONFIG_PROPERTIES_EXCLUDE_CONFIGReady = true; } return _CONFIG_PROPERTIES_EXCLUDE_CONFIGContent; } }
        private static Java.Lang.String _CONFIG_PROPERTIES_EXCLUDE_CONFIGContent = default;
        private static bool _CONFIG_PROPERTIES_EXCLUDE_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/DefaultConfigPropertyFilter.html#CONFIG_PROPERTIES_EXCLUDE_DEFAULT"/>
        /// </summary>
        public static Java.Lang.String CONFIG_PROPERTIES_EXCLUDE_DEFAULT { get { if (!_CONFIG_PROPERTIES_EXCLUDE_DEFAULTReady) { _CONFIG_PROPERTIES_EXCLUDE_DEFAULTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CONFIG_PROPERTIES_EXCLUDE_DEFAULT"); _CONFIG_PROPERTIES_EXCLUDE_DEFAULTReady = true; } return _CONFIG_PROPERTIES_EXCLUDE_DEFAULTContent; } }
        private static Java.Lang.String _CONFIG_PROPERTIES_EXCLUDE_DEFAULTContent = default;
        private static bool _CONFIG_PROPERTIES_EXCLUDE_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/DefaultConfigPropertyFilter.html#USE_DEFAULTS_FROM"/>
        /// </summary>
        public static Java.Lang.String USE_DEFAULTS_FROM { get { if (!_USE_DEFAULTS_FROMReady) { _USE_DEFAULTS_FROMContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "USE_DEFAULTS_FROM"); _USE_DEFAULTS_FROMReady = true; } return _USE_DEFAULTS_FROMContent; } }
        private static Java.Lang.String _USE_DEFAULTS_FROMContent = default;
        private static bool _USE_DEFAULTS_FROMReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/DefaultConfigPropertyFilter.html#shouldReplicateConfigProperty-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ShouldReplicateConfigProperty(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("shouldReplicateConfigProperty", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/DefaultConfigPropertyFilter.html#shouldReplicateSourceDefault-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ShouldReplicateSourceDefault(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("shouldReplicateSourceDefault", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.9.0/org/apache/kafka/connect/mirror/DefaultConfigPropertyFilter.html#configure-java.util.Map-"/>
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