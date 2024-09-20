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
*  using connect-api-3.6.2.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Health
{
    #region ConnectorHealth declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.2/org/apache/kafka/connect/health/ConnectorHealth.html"/>
    /// </summary>
    public partial class ConnectorHealth : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ConnectorHealth>
    {
        const string _bridgeClassName = "org.apache.kafka.connect.health.ConnectorHealth";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ConnectorHealth() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ConnectorHealth(params object[] args) : base(args) { }

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

    #region ConnectorHealth implementation
    public partial class ConnectorHealth
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.2/org/apache/kafka/connect/health/ConnectorHealth.html#org.apache.kafka.connect.health.ConnectorHealth(java.lang.String,org.apache.kafka.connect.health.ConnectorState,java.util.Map,org.apache.kafka.connect.health.ConnectorType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Connect.Health.ConnectorState"/></param>
        /// <param name="arg2"><see cref="Java.Util.Map"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Connect.Health.ConnectorType"/></param>
        public ConnectorHealth(Java.Lang.String arg0, Org.Apache.Kafka.Connect.Health.ConnectorState arg1, Java.Util.Map<Java.Lang.Integer, Org.Apache.Kafka.Connect.Health.TaskState> arg2, Org.Apache.Kafka.Connect.Health.ConnectorType arg3)
            : base(arg0, arg1, arg2, arg3)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.2/org/apache/kafka/connect/health/ConnectorHealth.html#name--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Name()
        {
            return IExecuteWithSignature<Java.Lang.String>("name", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.2/org/apache/kafka/connect/health/ConnectorHealth.html#tasksState--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.Integer, Org.Apache.Kafka.Connect.Health.TaskState> TasksState()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.Integer, Org.Apache.Kafka.Connect.Health.TaskState>>("tasksState", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.2/org/apache/kafka/connect/health/ConnectorHealth.html#connectorState--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Health.ConnectorState"/></returns>
        public Org.Apache.Kafka.Connect.Health.ConnectorState ConnectorState()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Health.ConnectorState>("connectorState", "()Lorg/apache/kafka/connect/health/ConnectorState;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.2/org/apache/kafka/connect/health/ConnectorHealth.html#type--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Health.ConnectorType"/></returns>
        public Org.Apache.Kafka.Connect.Health.ConnectorType Type()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Health.ConnectorType>("type", "()Lorg/apache/kafka/connect/health/ConnectorType;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}