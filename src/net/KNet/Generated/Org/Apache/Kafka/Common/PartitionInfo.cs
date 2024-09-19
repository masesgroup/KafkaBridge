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
*  using kafka-clients-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common
{
    #region PartitionInfo declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/PartitionInfo.html"/>
    /// </summary>
    public partial class PartitionInfo : MASES.JCOBridge.C2JBridge.JVMBridgeBase<PartitionInfo>
    {
        const string _bridgeClassName = "org.apache.kafka.common.PartitionInfo";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public PartitionInfo() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public PartitionInfo(params object[] args) : base(args) { }

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

    #region PartitionInfo implementation
    public partial class PartitionInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/PartitionInfo.html#org.apache.kafka.common.PartitionInfo(java.lang.String,int,org.apache.kafka.common.Node,org.apache.kafka.common.Node[],org.apache.kafka.common.Node[],org.apache.kafka.common.Node[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Node"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Common.Node"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Common.Node"/></param>
        /// <param name="arg5"><see cref="Org.Apache.Kafka.Common.Node"/></param>
        public PartitionInfo(Java.Lang.String arg0, int arg1, Org.Apache.Kafka.Common.Node arg2, Org.Apache.Kafka.Common.Node[] arg3, Org.Apache.Kafka.Common.Node[] arg4, Org.Apache.Kafka.Common.Node[] arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/PartitionInfo.html#org.apache.kafka.common.PartitionInfo(java.lang.String,int,org.apache.kafka.common.Node,org.apache.kafka.common.Node[],org.apache.kafka.common.Node[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Node"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Common.Node"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Common.Node"/></param>
        public PartitionInfo(Java.Lang.String arg0, int arg1, Org.Apache.Kafka.Common.Node arg2, Org.Apache.Kafka.Common.Node[] arg3, Org.Apache.Kafka.Common.Node[] arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/PartitionInfo.html#partition--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Partition()
        {
            return IExecuteWithSignature<int>("partition", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/PartitionInfo.html#topic--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Topic()
        {
            return IExecuteWithSignature<Java.Lang.String>("topic", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/PartitionInfo.html#leader--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Node"/></returns>
        public Org.Apache.Kafka.Common.Node Leader()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Node>("leader", "()Lorg/apache/kafka/common/Node;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/PartitionInfo.html#inSyncReplicas--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Node"/></returns>
        public Org.Apache.Kafka.Common.Node[] InSyncReplicas()
        {
            return IExecuteWithSignatureArray<Org.Apache.Kafka.Common.Node>("inSyncReplicas", "()[Lorg/apache/kafka/common/Node;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/PartitionInfo.html#offlineReplicas--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Node"/></returns>
        public Org.Apache.Kafka.Common.Node[] OfflineReplicas()
        {
            return IExecuteWithSignatureArray<Org.Apache.Kafka.Common.Node>("offlineReplicas", "()[Lorg/apache/kafka/common/Node;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/PartitionInfo.html#replicas--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Node"/></returns>
        public Org.Apache.Kafka.Common.Node[] Replicas()
        {
            return IExecuteWithSignatureArray<Org.Apache.Kafka.Common.Node>("replicas", "()[Lorg/apache/kafka/common/Node;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}