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

namespace Org.Apache.Kafka.Common
{
    #region DirectoryId declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-server-common/3.9.0/org/apache/kafka/common/DirectoryId.html"/>
    /// </summary>
    public partial class DirectoryId : MASES.JCOBridge.C2JBridge.JVMBridgeBase<DirectoryId>
    {
        const string _bridgeClassName = "org.apache.kafka.common.DirectoryId";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DirectoryId() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DirectoryId(params object[] args) : base(args) { }

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

    #region DirectoryId implementation
    public partial class DirectoryId
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-server-common/3.9.0/org/apache/kafka/common/DirectoryId.html#LOST"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Uuid LOST { get { if (!_LOSTReady) { _LOSTContent = SGetField<Org.Apache.Kafka.Common.Uuid>(LocalBridgeClazz, "LOST"); _LOSTReady = true; } return _LOSTContent; } }
        private static Org.Apache.Kafka.Common.Uuid _LOSTContent = default;
        private static bool _LOSTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-server-common/3.9.0/org/apache/kafka/common/DirectoryId.html#MIGRATING"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Uuid MIGRATING { get { if (!_MIGRATINGReady) { _MIGRATINGContent = SGetField<Org.Apache.Kafka.Common.Uuid>(LocalBridgeClazz, "MIGRATING"); _MIGRATINGReady = true; } return _MIGRATINGContent; } }
        private static Org.Apache.Kafka.Common.Uuid _MIGRATINGContent = default;
        private static bool _MIGRATINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-server-common/3.9.0/org/apache/kafka/common/DirectoryId.html#UNASSIGNED"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Uuid UNASSIGNED { get { if (!_UNASSIGNEDReady) { _UNASSIGNEDContent = SGetField<Org.Apache.Kafka.Common.Uuid>(LocalBridgeClazz, "UNASSIGNED"); _UNASSIGNEDReady = true; } return _UNASSIGNEDContent; } }
        private static Org.Apache.Kafka.Common.Uuid _UNASSIGNEDContent = default;
        private static bool _UNASSIGNEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-server-common/3.9.0/org/apache/kafka/common/DirectoryId.html#isOnline-org.apache.kafka.common.Uuid-java.util.List-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Uuid"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsOnline(Org.Apache.Kafka.Common.Uuid arg0, Java.Util.List<Org.Apache.Kafka.Common.Uuid> arg1)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isOnline", "(Lorg/apache/kafka/common/Uuid;Ljava/util/List;)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-server-common/3.9.0/org/apache/kafka/common/DirectoryId.html#reserved-org.apache.kafka.common.Uuid-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Uuid"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool Reserved(Org.Apache.Kafka.Common.Uuid arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "reserved", "(Lorg/apache/kafka/common/Uuid;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-server-common/3.9.0/org/apache/kafka/common/DirectoryId.html#createAssignmentMap-int[]-org.apache.kafka.common.Uuid[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Uuid"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public static Java.Util.Map<Java.Lang.Integer, Org.Apache.Kafka.Common.Uuid> CreateAssignmentMap(int[] arg0, Org.Apache.Kafka.Common.Uuid[] arg1)
        {
            return SExecuteWithSignature<Java.Util.Map<Java.Lang.Integer, Org.Apache.Kafka.Common.Uuid>>(LocalBridgeClazz, "createAssignmentMap", "([I[Lorg/apache/kafka/common/Uuid;)Ljava/util/Map;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-server-common/3.9.0/org/apache/kafka/common/DirectoryId.html#random--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Uuid"/></returns>
        public static Org.Apache.Kafka.Common.Uuid Random()
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.Uuid>(LocalBridgeClazz, "random", "()Lorg/apache/kafka/common/Uuid;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-server-common/3.9.0/org/apache/kafka/common/DirectoryId.html#migratingArray-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Uuid"/></returns>
        public static Org.Apache.Kafka.Common.Uuid[] MigratingArray(int arg0)
        {
            return SExecuteWithSignatureArray<Org.Apache.Kafka.Common.Uuid>(LocalBridgeClazz, "migratingArray", "(I)[Lorg/apache/kafka/common/Uuid;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-server-common/3.9.0/org/apache/kafka/common/DirectoryId.html#unassignedArray-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Uuid"/></returns>
        public static Org.Apache.Kafka.Common.Uuid[] UnassignedArray(int arg0)
        {
            return SExecuteWithSignatureArray<Org.Apache.Kafka.Common.Uuid>(LocalBridgeClazz, "unassignedArray", "(I)[Lorg/apache/kafka/common/Uuid;", arg0);
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