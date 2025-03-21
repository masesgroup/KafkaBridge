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
*  using kafka-server-common-3.9.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Admin
{
    #region AdminUtils declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-server-common/3.9.0/org/apache/kafka/admin/AdminUtils.html"/>
    /// </summary>
    public partial class AdminUtils : MASES.JCOBridge.C2JBridge.JVMBridgeBase<AdminUtils>
    {
        const string _bridgeClassName = "org.apache.kafka.admin.AdminUtils";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AdminUtils() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AdminUtils(params object[] args) : base(args) { }

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

    #region AdminUtils implementation
    public partial class AdminUtils
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-server-common/3.9.0/org/apache/kafka/admin/AdminUtils.html#ADMIN_CLIENT_ID"/>
        /// </summary>
        public static Java.Lang.String ADMIN_CLIENT_ID { get { if (!_ADMIN_CLIENT_IDReady) { _ADMIN_CLIENT_IDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ADMIN_CLIENT_ID"); _ADMIN_CLIENT_IDReady = true; } return _ADMIN_CLIENT_IDContent; } }
        private static Java.Lang.String _ADMIN_CLIENT_IDContent = default;
        private static bool _ADMIN_CLIENT_IDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-server-common/3.9.0/org/apache/kafka/admin/AdminUtils.html#getRackAlternatedBrokerList-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List<Java.Lang.Integer> GetRackAlternatedBrokerList(Java.Util.Map<Java.Lang.Integer, Java.Lang.String> arg0)
        {
            return SExecuteWithSignature<Java.Util.List<Java.Lang.Integer>>(LocalBridgeClazz, "getRackAlternatedBrokerList", "(Ljava/util/Map;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-server-common/3.9.0/org/apache/kafka/admin/AdminUtils.html#assignReplicasToBrokers-java.util.Collection-int-int-int-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public static Java.Util.Map<Java.Lang.Integer, Java.Util.List<Java.Lang.Integer>> AssignReplicasToBrokers(Java.Util.Collection<Org.Apache.Kafka.Admin.BrokerMetadata> arg0, int arg1, int arg2, int arg3, int arg4)
        {
            return SExecuteWithSignature<Java.Util.Map<Java.Lang.Integer, Java.Util.List<Java.Lang.Integer>>>(LocalBridgeClazz, "assignReplicasToBrokers", "(Ljava/util/Collection;IIII)Ljava/util/Map;", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-server-common/3.9.0/org/apache/kafka/admin/AdminUtils.html#assignReplicasToBrokers-java.util.Collection-int-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public static Java.Util.Map<Java.Lang.Integer, Java.Util.List<Java.Lang.Integer>> AssignReplicasToBrokers(Java.Util.Collection<Org.Apache.Kafka.Admin.BrokerMetadata> arg0, int arg1, int arg2)
        {
            return SExecuteWithSignature<Java.Util.Map<Java.Lang.Integer, Java.Util.List<Java.Lang.Integer>>>(LocalBridgeClazz, "assignReplicasToBrokers", "(Ljava/util/Collection;II)Ljava/util/Map;", arg0, arg1, arg2);
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