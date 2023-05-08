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
*  using kafka_2.13-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Kafka.Server
{
    #region BrokerConfigHandler
    public partial class BrokerConfigHandler
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/BrokerConfigHandler.html#%3Cinit%3E(kafka.server.KafkaConfig,kafka.server.QuotaFactory.QuotaManagers)"/>
        /// </summary>
        /// <param name="brokerConfig"><see cref="Kafka.Server.KafkaConfig"/></param>
        /// <param name="quotaManagers"><see cref="Kafka.Server.QuotaFactory.QuotaManagers"/></param>
        public BrokerConfigHandler(Kafka.Server.KafkaConfig brokerConfig, Kafka.Server.QuotaFactory.QuotaManagers quotaManagers)
            : base(brokerConfig, quotaManagers)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Kafka.Server.BrokerConfigHandler"/> to <see cref="Kafka.Server.ConfigHandler"/>
        /// </summary>
        public static implicit operator Kafka.Server.ConfigHandler(Kafka.Server.BrokerConfigHandler t) => t.Cast<Kafka.Server.ConfigHandler>();
        /// <summary>
        /// Converter from <see cref="Kafka.Server.BrokerConfigHandler"/> to <see cref="Kafka.Utils.Logging"/>
        /// </summary>
        public static implicit operator Kafka.Utils.Logging(Kafka.Server.BrokerConfigHandler t) => t.Cast<Kafka.Utils.Logging>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/BrokerConfigHandler.html#isDebugEnabled()"/> 
        /// </summary>
        public bool IsDebugEnabled
        {
            get { return IExecute<bool>("isDebugEnabled"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/BrokerConfigHandler.html#isTraceEnabled()"/> 
        /// </summary>
        public bool IsTraceEnabled
        {
            get { return IExecute<bool>("isTraceEnabled"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/BrokerConfigHandler.html#logger()"/> 
        /// </summary>
        public Com.Typesafe.Scalalogging.Logger Logger
        {
            get { return IExecute<Com.Typesafe.Scalalogging.Logger>("logger"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/BrokerConfigHandler.html#loggerName()"/> 
        /// </summary>
        public string LoggerName
        {
            get { return IExecute<string>("loggerName"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/BrokerConfigHandler.html#logIdent()"/> 
        /// </summary>
        public string LogIdent
        {
            get { return IExecute<string>("logIdent"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/BrokerConfigHandler.html#msgWithLogIdent(java.lang.String)"/>
        /// </summary>
        /// <param name="msg"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string MsgWithLogIdent(string msg)
        {
            return IExecute<string>("msgWithLogIdent", msg);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/BrokerConfigHandler.html#processConfigChanges(java.lang.String,java.util.Properties)"/>
        /// </summary>
        /// <param name="brokerId"><see cref="string"/></param>
        /// <param name="properties"><see cref="Java.Util.Properties"/></param>
        public void ProcessConfigChanges(string brokerId, Java.Util.Properties properties)
        {
            IExecute("processConfigChanges", brokerId, properties);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}