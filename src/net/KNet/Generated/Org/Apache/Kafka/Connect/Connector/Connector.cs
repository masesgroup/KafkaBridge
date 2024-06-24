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
*  This file is generated by MASES.JNetReflector (ver. 2.5.4.0)
*  using connect-api-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Connector
{
    #region Connector
    public partial class Connector
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.0/org/apache/kafka/connect/connector/Connector.html#taskClass--"/>
        /// </summary>
        /// <typeparam name="ReturnExtendsOrg_Apache_Kafka_Connect_Connector_Task"><see cref="Org.Apache.Kafka.Connect.Connector.Task"/></typeparam>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        public Java.Lang.Class TaskClass<ReturnExtendsOrg_Apache_Kafka_Connect_Connector_Task>() where ReturnExtendsOrg_Apache_Kafka_Connect_Connector_Task : Org.Apache.Kafka.Connect.Connector.Task
        {
            return IExecuteWithSignature<Java.Lang.Class>("taskClass", "()Ljava/lang/Class;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.0/org/apache/kafka/connect/connector/Connector.html#taskConfigs-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Util.Map<Java.Lang.String, Java.Lang.String>> TaskConfigs(int arg0)
        {
            return IExecuteWithSignature<Java.Util.List<Java.Util.Map<Java.Lang.String, Java.Lang.String>>>("taskConfigs", "(I)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.0/org/apache/kafka/connect/connector/Connector.html#config--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Config.ConfigDef"/></returns>
        public Org.Apache.Kafka.Common.Config.ConfigDef Config()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Config.ConfigDef>("config", "()Lorg/apache/kafka/common/config/ConfigDef;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.0/org/apache/kafka/connect/connector/Connector.html#start-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public void Start(Java.Util.Map<Java.Lang.String, Java.Lang.String> arg0)
        {
            IExecuteWithSignature("start", "(Ljava/util/Map;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.0/org/apache/kafka/connect/connector/Connector.html#stop--"/>
        /// </summary>
        public void Stop()
        {
            IExecuteWithSignature("stop", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.0/org/apache/kafka/connect/connector/Connector.html#validate-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Config.Config"/></returns>
        public Org.Apache.Kafka.Common.Config.Config Validate(Java.Util.Map<Java.Lang.String, Java.Lang.String> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Config.Config>("validate", "(Ljava/util/Map;)Lorg/apache/kafka/common/config/Config;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.0/org/apache/kafka/connect/connector/Connector.html#initialize-org.apache.kafka.connect.connector.ConnectorContext-java.util.List-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Connector.ConnectorContext"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        public void Initialize(Org.Apache.Kafka.Connect.Connector.ConnectorContext arg0, Java.Util.List<Java.Util.Map<Java.Lang.String, Java.Lang.String>> arg1)
        {
            IExecute("initialize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.0/org/apache/kafka/connect/connector/Connector.html#initialize-org.apache.kafka.connect.connector.ConnectorContext-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Connector.ConnectorContext"/></param>
        public void Initialize(Org.Apache.Kafka.Connect.Connector.ConnectorContext arg0)
        {
            IExecuteWithSignature("initialize", "(Lorg/apache/kafka/connect/connector/ConnectorContext;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.0/org/apache/kafka/connect/connector/Connector.html#reconfigure-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public void Reconfigure(Java.Util.Map<Java.Lang.String, Java.Lang.String> arg0)
        {
            IExecuteWithSignature("reconfigure", "(Ljava/util/Map;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}