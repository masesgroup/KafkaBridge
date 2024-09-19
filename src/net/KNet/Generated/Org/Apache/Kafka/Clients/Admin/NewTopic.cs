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
*  using kafka-clients-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Admin
{
    #region NewTopic declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/admin/NewTopic.html"/>
    /// </summary>
    public partial class NewTopic : MASES.JCOBridge.C2JBridge.JVMBridgeBase<NewTopic>
    {
        const string _bridgeClassName = "org.apache.kafka.clients.admin.NewTopic";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public NewTopic() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public NewTopic(params object[] args) : base(args) { }

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

    #region NewTopic implementation
    public partial class NewTopic
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/admin/NewTopic.html#org.apache.kafka.clients.admin.NewTopic(java.lang.String,int,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="short"/></param>
        public NewTopic(Java.Lang.String arg0, int arg1, short arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/admin/NewTopic.html#org.apache.kafka.clients.admin.NewTopic(java.lang.String,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        public NewTopic(Java.Lang.String arg0, Java.Util.Map<Java.Lang.Integer, Java.Util.List<Java.Lang.Integer>> arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/admin/NewTopic.html#org.apache.kafka.clients.admin.NewTopic(java.lang.String,java.util.Optional,java.util.Optional)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Optional"/></param>
        /// <param name="arg2"><see cref="Java.Util.Optional"/></param>
        public NewTopic(Java.Lang.String arg0, Java.Util.Optional<Java.Lang.Integer> arg1, Java.Util.Optional<Java.Lang.Short> arg2)
            : base(arg0, arg1, arg2)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/admin/NewTopic.html#numPartitions--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int NumPartitions()
        {
            return IExecuteWithSignature<int>("numPartitions", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/admin/NewTopic.html#name--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Name()
        {
            return IExecuteWithSignature<Java.Lang.String>("name", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/admin/NewTopic.html#replicasAssignments--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.Integer, Java.Util.List<Java.Lang.Integer>> ReplicasAssignments()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.Integer, Java.Util.List<Java.Lang.Integer>>>("replicasAssignments", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/admin/NewTopic.html#configs--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, Java.Lang.String> Configs()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Lang.String>>("configs", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/admin/NewTopic.html#configs-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.NewTopic"/></returns>
        public Org.Apache.Kafka.Clients.Admin.NewTopic Configs(Java.Util.Map<Java.Lang.String, Java.Lang.String> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Clients.Admin.NewTopic>("configs", "(Ljava/util/Map;)Lorg/apache/kafka/clients/admin/NewTopic;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/admin/NewTopic.html#replicationFactor--"/>
        /// </summary>
        /// <returns><see cref="short"/></returns>
        public short ReplicationFactor()
        {
            return IExecuteWithSignature<short>("replicationFactor", "()S");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}