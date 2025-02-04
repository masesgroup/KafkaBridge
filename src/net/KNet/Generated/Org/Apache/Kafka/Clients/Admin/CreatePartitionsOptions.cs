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
*  using kafka-clients-3.9.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Admin
{
    #region CreatePartitionsOptions declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/CreatePartitionsOptions.html"/>
    /// </summary>
    public partial class CreatePartitionsOptions : Org.Apache.Kafka.Clients.Admin.AbstractOptions<Org.Apache.Kafka.Clients.Admin.CreatePartitionsOptions>
    {
        const string _bridgeClassName = "org.apache.kafka.clients.admin.CreatePartitionsOptions";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public CreatePartitionsOptions() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public CreatePartitionsOptions(params object[] args) : base(args) { }

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

    #region CreatePartitionsOptions implementation
    public partial class CreatePartitionsOptions
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/CreatePartitionsOptions.html#shouldRetryOnQuotaViolation--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool ShouldRetryOnQuotaViolation()
        {
            return IExecuteWithSignature<bool>("shouldRetryOnQuotaViolation", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/CreatePartitionsOptions.html#validateOnly--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool ValidateOnly()
        {
            return IExecuteWithSignature<bool>("validateOnly", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/CreatePartitionsOptions.html#retryOnQuotaViolation-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.CreatePartitionsOptions"/></returns>
        public Org.Apache.Kafka.Clients.Admin.CreatePartitionsOptions RetryOnQuotaViolation(bool arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Clients.Admin.CreatePartitionsOptions>("retryOnQuotaViolation", "(Z)Lorg/apache/kafka/clients/admin/CreatePartitionsOptions;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/CreatePartitionsOptions.html#validateOnly-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.CreatePartitionsOptions"/></returns>
        public Org.Apache.Kafka.Clients.Admin.CreatePartitionsOptions ValidateOnly(bool arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Clients.Admin.CreatePartitionsOptions>("validateOnly", "(Z)Lorg/apache/kafka/clients/admin/CreatePartitionsOptions;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}