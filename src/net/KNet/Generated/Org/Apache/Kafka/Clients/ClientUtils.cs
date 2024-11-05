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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using kafka-clients-3.8.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients
{
    #region ClientUtils declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/clients/ClientUtils.html"/>
    /// </summary>
    public partial class ClientUtils : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ClientUtils>
    {
        const string _bridgeClassName = "org.apache.kafka.clients.ClientUtils";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ClientUtils() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ClientUtils(params object[] args) : base(args) { }

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

    #region ClientUtils implementation
    public partial class ClientUtils
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/clients/ClientUtils.html#configuredInterceptors-org.apache.kafka.common.config.AbstractConfig-java.lang.String-java.lang.Class-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Config.AbstractConfig"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List ConfiguredInterceptors(Org.Apache.Kafka.Common.Config.AbstractConfig arg0, Java.Lang.String arg1, Java.Lang.Class arg2)
        {
            return SExecuteWithSignature<Java.Util.List>(LocalBridgeClazz, "configuredInterceptors", "(Lorg/apache/kafka/common/config/AbstractConfig;Ljava/lang/String;Ljava/lang/Class;)Ljava/util/List;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/clients/ClientUtils.html#parseAndValidateAddresses-java.util.List-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List<Java.Net.InetSocketAddress> ParseAndValidateAddresses(Java.Util.List<Java.Lang.String> arg0, Java.Lang.String arg1)
        {
            return SExecuteWithSignature<Java.Util.List<Java.Net.InetSocketAddress>>(LocalBridgeClazz, "parseAndValidateAddresses", "(Ljava/util/List;Ljava/lang/String;)Ljava/util/List;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/clients/ClientUtils.html#parseAndValidateAddresses-java.util.List-org.apache.kafka.clients.ClientDnsLookup-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Clients.ClientDnsLookup"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List<Java.Net.InetSocketAddress> ParseAndValidateAddresses(Java.Util.List<Java.Lang.String> arg0, Org.Apache.Kafka.Clients.ClientDnsLookup arg1)
        {
            return SExecuteWithSignature<Java.Util.List<Java.Net.InetSocketAddress>>(LocalBridgeClazz, "parseAndValidateAddresses", "(Ljava/util/List;Lorg/apache/kafka/clients/ClientDnsLookup;)Ljava/util/List;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/clients/ClientUtils.html#parseAndValidateAddresses-org.apache.kafka.common.config.AbstractConfig-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Config.AbstractConfig"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List<Java.Net.InetSocketAddress> ParseAndValidateAddresses(Org.Apache.Kafka.Common.Config.AbstractConfig arg0)
        {
            return SExecuteWithSignature<Java.Util.List<Java.Net.InetSocketAddress>>(LocalBridgeClazz, "parseAndValidateAddresses", "(Lorg/apache/kafka/common/config/AbstractConfig;)Ljava/util/List;", arg0);
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