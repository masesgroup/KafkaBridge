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

namespace Org.Apache.Kafka.Common.Acl
{
    #region AclBinding declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/acl/AclBinding.html"/>
    /// </summary>
    public partial class AclBinding : MASES.JCOBridge.C2JBridge.JVMBridgeBase<AclBinding>
    {
        const string _bridgeClassName = "org.apache.kafka.common.acl.AclBinding";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AclBinding() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AclBinding(params object[] args) : base(args) { }

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

    #region AclBinding implementation
    public partial class AclBinding
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/acl/AclBinding.html#org.apache.kafka.common.acl.AclBinding(org.apache.kafka.common.resource.ResourcePattern,org.apache.kafka.common.acl.AccessControlEntry)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Resource.ResourcePattern"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Acl.AccessControlEntry"/></param>
        public AclBinding(Org.Apache.Kafka.Common.Resource.ResourcePattern arg0, Org.Apache.Kafka.Common.Acl.AccessControlEntry arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/acl/AclBinding.html#isUnknown--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsUnknown()
        {
            return IExecuteWithSignature<bool>("isUnknown", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/acl/AclBinding.html#entry--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Acl.AccessControlEntry"/></returns>
        public Org.Apache.Kafka.Common.Acl.AccessControlEntry Entry()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Acl.AccessControlEntry>("entry", "()Lorg/apache/kafka/common/acl/AccessControlEntry;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/acl/AclBinding.html#toFilter--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Acl.AclBindingFilter"/></returns>
        public Org.Apache.Kafka.Common.Acl.AclBindingFilter ToFilter()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Acl.AclBindingFilter>("toFilter", "()Lorg/apache/kafka/common/acl/AclBindingFilter;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/acl/AclBinding.html#pattern--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Resource.ResourcePattern"/></returns>
        public Org.Apache.Kafka.Common.Resource.ResourcePattern Pattern()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Resource.ResourcePattern>("pattern", "()Lorg/apache/kafka/common/resource/ResourcePattern;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}