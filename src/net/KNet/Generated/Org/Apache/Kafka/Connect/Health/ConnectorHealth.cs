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

namespace Org.Apache.Kafka.Connect.Health
{
    #region ConnectorHealth
    public partial class ConnectorHealth
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-api/3.4.0/org/apache/kafka/connect/health/ConnectorHealth.html#%3Cinit%3E(java.lang.String,org.apache.kafka.connect.health.ConnectorState,java.util.Map,org.apache.kafka.connect.health.ConnectorType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Connect.Health.ConnectorState"/></param>
        /// <param name="arg2"><see cref="Java.Util.Map"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Connect.Health.ConnectorType"/></param>
        public ConnectorHealth(string arg0, Org.Apache.Kafka.Connect.Health.ConnectorState arg1, Java.Util.Map arg2, Org.Apache.Kafka.Connect.Health.ConnectorType arg3)
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
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-api/3.4.0/org/apache/kafka/connect/health/ConnectorHealth.html#connectorState()"/> 
        /// </summary>
        public Org.Apache.Kafka.Connect.Health.ConnectorState ConnectorState
        {
            get { return IExecute<Org.Apache.Kafka.Connect.Health.ConnectorState>("connectorState"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-api/3.4.0/org/apache/kafka/connect/health/ConnectorHealth.html#name()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("name"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-api/3.4.0/org/apache/kafka/connect/health/ConnectorHealth.html#tasksState()"/> 
        /// </summary>
        public Java.Util.Map<int?, Org.Apache.Kafka.Connect.Health.TaskState> TasksState
        {
            get { return IExecute<Java.Util.Map<int?, Org.Apache.Kafka.Connect.Health.TaskState>>("tasksState"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-api/3.4.0/org/apache/kafka/connect/health/ConnectorHealth.html#type()"/> 
        /// </summary>
        public Org.Apache.Kafka.Connect.Health.ConnectorType Type
        {
            get { return IExecute<Org.Apache.Kafka.Connect.Health.ConnectorType>("type"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}