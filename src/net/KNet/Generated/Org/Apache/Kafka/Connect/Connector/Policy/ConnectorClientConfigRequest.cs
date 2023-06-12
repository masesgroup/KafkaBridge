/*
*  Copyright 2023 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using connect-api-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Connector.Policy
{
    #region ConnectorClientConfigRequest
    public partial class ConnectorClientConfigRequest
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.4.0/org/apache/kafka/connect/connector/policy/ConnectorClientConfigRequest.html#%3Cinit%3E(java.lang.String,org.apache.kafka.connect.health.ConnectorType,java.lang.Class,java.util.Map,org.apache.kafka.connect.connector.policy.ConnectorClientConfigRequest.ClientType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Connect.Health.ConnectorType"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg3"><see cref="Java.Util.Map"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Connect.Connector.Policy.ConnectorClientConfigRequest.ClientType"/></param>
        public ConnectorClientConfigRequest(string arg0, Org.Apache.Kafka.Connect.Health.ConnectorType arg1, Java.Lang.Class arg2, Java.Util.Map<string, object> arg3, Org.Apache.Kafka.Connect.Connector.Policy.ConnectorClientConfigRequest.ClientType arg4)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.4.0/org/apache/kafka/connect/connector/policy/ConnectorClientConfigRequest.html#connectorClass()"/>
        /// </summary>

        /// <typeparam name="ReturnExtendsOrg_Apache_Kafka_Connect_Connector_Connector"><see cref="Org.Apache.Kafka.Connect.Connector.Connector"/></typeparam>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        public Java.Lang.Class ConnectorClass<ReturnExtendsOrg_Apache_Kafka_Connect_Connector_Connector>() where ReturnExtendsOrg_Apache_Kafka_Connect_Connector_Connector: Org.Apache.Kafka.Connect.Connector.Connector
        {
            return IExecute<Java.Lang.Class>("connectorClass");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.4.0/org/apache/kafka/connect/connector/policy/ConnectorClientConfigRequest.html#connectorName()"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string ConnectorName()
        {
            return IExecute<string>("connectorName");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.4.0/org/apache/kafka/connect/connector/policy/ConnectorClientConfigRequest.html#clientProps()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<string, object> ClientProps()
        {
            return IExecute<Java.Util.Map<string, object>>("clientProps");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.4.0/org/apache/kafka/connect/connector/policy/ConnectorClientConfigRequest.html#clientType()"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Connect.Connector.Policy.ConnectorClientConfigRequest.ClientType"/></returns>
        public Org.Apache.Kafka.Connect.Connector.Policy.ConnectorClientConfigRequest.ClientType ClientTypeMethod()
        {
            return IExecute<Org.Apache.Kafka.Connect.Connector.Policy.ConnectorClientConfigRequest.ClientType>("clientType");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.4.0/org/apache/kafka/connect/connector/policy/ConnectorClientConfigRequest.html#connectorType()"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Connect.Health.ConnectorType"/></returns>
        public Org.Apache.Kafka.Connect.Health.ConnectorType ConnectorType()
        {
            return IExecute<Org.Apache.Kafka.Connect.Health.ConnectorType>("connectorType");
        }

        #endregion

        #region Nested classes
        #region ClientType
        public partial class ClientType
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.4.0/org/apache/kafka/connect/connector/policy/ConnectorClientConfigRequest.ClientType.html#ADMIN"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Connector.Policy.ConnectorClientConfigRequest.ClientType ADMIN { get { return SGetField<Org.Apache.Kafka.Connect.Connector.Policy.ConnectorClientConfigRequest.ClientType>(LocalBridgeClazz, "ADMIN"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.4.0/org/apache/kafka/connect/connector/policy/ConnectorClientConfigRequest.ClientType.html#CONSUMER"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Connector.Policy.ConnectorClientConfigRequest.ClientType CONSUMER { get { return SGetField<Org.Apache.Kafka.Connect.Connector.Policy.ConnectorClientConfigRequest.ClientType>(LocalBridgeClazz, "CONSUMER"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.4.0/org/apache/kafka/connect/connector/policy/ConnectorClientConfigRequest.ClientType.html#PRODUCER"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Connector.Policy.ConnectorClientConfigRequest.ClientType PRODUCER { get { return SGetField<Org.Apache.Kafka.Connect.Connector.Policy.ConnectorClientConfigRequest.ClientType>(LocalBridgeClazz, "PRODUCER"); } }

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.4.0/org/apache/kafka/connect/connector/policy/ConnectorClientConfigRequest.ClientType.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Connect.Connector.Policy.ConnectorClientConfigRequest.ClientType"/></returns>
            public static Org.Apache.Kafka.Connect.Connector.Policy.ConnectorClientConfigRequest.ClientType ValueOf(string arg0)
            {
                return SExecute<Org.Apache.Kafka.Connect.Connector.Policy.ConnectorClientConfigRequest.ClientType>(LocalBridgeClazz, "valueOf", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.4.0/org/apache/kafka/connect/connector/policy/ConnectorClientConfigRequest.ClientType.html#values()"/>
            /// </summary>

            /// <returns><see cref="Org.Apache.Kafka.Connect.Connector.Policy.ConnectorClientConfigRequest.ClientType"/></returns>
            public static Org.Apache.Kafka.Connect.Connector.Policy.ConnectorClientConfigRequest.ClientType[] Values()
            {
                return SExecuteArray<Org.Apache.Kafka.Connect.Connector.Policy.ConnectorClientConfigRequest.ClientType>(LocalBridgeClazz, "values");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}