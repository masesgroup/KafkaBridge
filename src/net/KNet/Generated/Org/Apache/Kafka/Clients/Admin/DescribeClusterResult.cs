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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*  using kafka-clients-3.9.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Admin
{
    #region DescribeClusterResult declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/DescribeClusterResult.html"/>
    /// </summary>
    public partial class DescribeClusterResult : MASES.JCOBridge.C2JBridge.JVMBridgeBase<DescribeClusterResult>
    {
        const string _bridgeClassName = "org.apache.kafka.clients.admin.DescribeClusterResult";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DescribeClusterResult() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DescribeClusterResult(params object[] args) : base(args) { }

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

    #region DescribeClusterResult implementation
    public partial class DescribeClusterResult
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/DescribeClusterResult.html#clusterId--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.KafkaFuture"/></returns>
        public Org.Apache.Kafka.Common.KafkaFuture<Java.Lang.String> ClusterId()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.KafkaFuture<Java.Lang.String>>("clusterId", "()Lorg/apache/kafka/common/KafkaFuture;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/DescribeClusterResult.html#nodes--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.KafkaFuture"/></returns>
        public Org.Apache.Kafka.Common.KafkaFuture<Java.Util.Collection<Org.Apache.Kafka.Common.Node>> Nodes()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.KafkaFuture<Java.Util.Collection<Org.Apache.Kafka.Common.Node>>>("nodes", "()Lorg/apache/kafka/common/KafkaFuture;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/DescribeClusterResult.html#authorizedOperations--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.KafkaFuture"/></returns>
        public Org.Apache.Kafka.Common.KafkaFuture<Java.Util.Set<Org.Apache.Kafka.Common.Acl.AclOperation>> AuthorizedOperations()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.KafkaFuture<Java.Util.Set<Org.Apache.Kafka.Common.Acl.AclOperation>>>("authorizedOperations", "()Lorg/apache/kafka/common/KafkaFuture;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/DescribeClusterResult.html#controller--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.KafkaFuture"/></returns>
        public Org.Apache.Kafka.Common.KafkaFuture<Org.Apache.Kafka.Common.Node> Controller()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.KafkaFuture<Org.Apache.Kafka.Common.Node>>("controller", "()Lorg/apache/kafka/common/KafkaFuture;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}