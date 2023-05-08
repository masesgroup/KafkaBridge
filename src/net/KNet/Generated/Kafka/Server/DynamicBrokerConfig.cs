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
    #region DynamicBrokerConfig
    public partial class DynamicBrokerConfig
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DynamicBrokerConfig.html#%3Cinit%3E(kafka.server.KafkaConfig)"/>
        /// </summary>
        /// <param name="kafkaConfig"><see cref="Kafka.Server.KafkaConfig"/></param>
        public DynamicBrokerConfig(Kafka.Server.KafkaConfig kafkaConfig)
            : base(kafkaConfig)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Kafka.Server.DynamicBrokerConfig"/> to <see cref="Kafka.Utils.Logging"/>
        /// </summary>
        public static implicit operator Kafka.Utils.Logging(Kafka.Server.DynamicBrokerConfig t) => t.Cast<Kafka.Utils.Logging>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DynamicBrokerConfig.html#isPasswordConfig(java.lang.String)"/>
        /// </summary>
        /// <param name="name"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsPasswordConfig(string name)
        {
            return SExecute<bool>(LocalBridgeClazz, "isPasswordConfig", name);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DynamicBrokerConfig.html#validateConfigs(java.util.Properties,boolean)"/>
        /// </summary>
        /// <param name="props"><see cref="Java.Util.Properties"/></param>
        /// <param name="perBrokerConfig"><see cref="bool"/></param>
        public static void ValidateConfigs(Java.Util.Properties props, bool perBrokerConfig)
        {
            SExecute(LocalBridgeClazz, "validateConfigs", props, perBrokerConfig);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DynamicBrokerConfig.html#currentKafkaConfig()"/> 
        /// </summary>
        public Kafka.Server.KafkaConfig CurrentKafkaConfig
        {
            get { return IExecute<Kafka.Server.KafkaConfig>("currentKafkaConfig"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DynamicBrokerConfig.html#isDebugEnabled()"/> 
        /// </summary>
        public bool IsDebugEnabled
        {
            get { return IExecute<bool>("isDebugEnabled"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DynamicBrokerConfig.html#isTraceEnabled()"/> 
        /// </summary>
        public bool IsTraceEnabled
        {
            get { return IExecute<bool>("isTraceEnabled"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DynamicBrokerConfig.html#logger()"/> 
        /// </summary>
        public Com.Typesafe.Scalalogging.Logger Logger
        {
            get { return IExecute<Com.Typesafe.Scalalogging.Logger>("logger"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DynamicBrokerConfig.html#loggerName()"/> 
        /// </summary>
        public string LoggerName
        {
            get { return IExecute<string>("loggerName"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DynamicBrokerConfig.html#logIdent()"/> 
        /// </summary>
        public string LogIdent
        {
            get { return IExecute<string>("logIdent"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DynamicBrokerConfig.html#msgWithLogIdent(java.lang.String)"/>
        /// </summary>
        /// <param name="msg"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string MsgWithLogIdent(string msg)
        {
            return IExecute<string>("msgWithLogIdent", msg);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DynamicBrokerConfig.html#fromPersistentProps(java.util.Properties,boolean)"/>
        /// </summary>
        /// <param name="persistentProps"><see cref="Java.Util.Properties"/></param>
        /// <param name="perBrokerConfig"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.Properties"/></returns>
        public Java.Util.Properties FromPersistentProps(Java.Util.Properties persistentProps, bool perBrokerConfig)
        {
            return IExecute<Java.Util.Properties>("fromPersistentProps", persistentProps, perBrokerConfig);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DynamicBrokerConfig.html#toPersistentProps(java.util.Properties,boolean)"/>
        /// </summary>
        /// <param name="configProps"><see cref="Java.Util.Properties"/></param>
        /// <param name="perBrokerConfig"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.Properties"/></returns>
        public Java.Util.Properties ToPersistentProps(Java.Util.Properties configProps, bool perBrokerConfig)
        {
            return IExecute<Java.Util.Properties>("toPersistentProps", configProps, perBrokerConfig);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DynamicBrokerConfig.html#addBrokerReconfigurable(kafka.server.BrokerReconfigurable)"/>
        /// </summary>
        /// <param name="reconfigurable"><see cref="Kafka.Server.BrokerReconfigurable"/></param>
        public void AddBrokerReconfigurable(Kafka.Server.BrokerReconfigurable reconfigurable)
        {
            IExecute("addBrokerReconfigurable", reconfigurable);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DynamicBrokerConfig.html#addReconfigurable(org.apache.kafka.common.Reconfigurable)"/>
        /// </summary>
        /// <param name="reconfigurable"><see cref="Org.Apache.Kafka.Common.Reconfigurable"/></param>
        public void AddReconfigurable(Org.Apache.Kafka.Common.Reconfigurable reconfigurable)
        {
            IExecute("addReconfigurable", reconfigurable);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DynamicBrokerConfig.html#addReconfigurables(kafka.server.KafkaBroker)"/>
        /// </summary>
        /// <param name="kafkaServer"><see cref="Kafka.Server.KafkaBroker"/></param>
        public void AddReconfigurables(Kafka.Server.KafkaBroker kafkaServer)
        {
            IExecute("addReconfigurables", kafkaServer);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DynamicBrokerConfig.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecute("clear");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DynamicBrokerConfig.html#maybeReconfigure(org.apache.kafka.common.Reconfigurable,kafka.server.KafkaConfig,java.util.Map)"/>
        /// </summary>
        /// <param name="reconfigurable"><see cref="Org.Apache.Kafka.Common.Reconfigurable"/></param>
        /// <param name="oldConfig"><see cref="Kafka.Server.KafkaConfig"/></param>
        /// <param name="newConfig"><see cref="Java.Util.Map"/></param>
        /// <typeparam name="NewConfigExtendsobject"></typeparam>
        public void MaybeReconfigure<NewConfigExtendsobject>(Org.Apache.Kafka.Common.Reconfigurable reconfigurable, Kafka.Server.KafkaConfig oldConfig, Java.Util.Map<string, NewConfigExtendsobject> newConfig)
        {
            IExecute("maybeReconfigure", reconfigurable, oldConfig, newConfig);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DynamicBrokerConfig.html#reloadUpdatedFilesWithoutConfigChange(java.util.Properties)"/>
        /// </summary>
        /// <param name="newProps"><see cref="Java.Util.Properties"/></param>
        public void ReloadUpdatedFilesWithoutConfigChange(Java.Util.Properties newProps)
        {
            IExecute("reloadUpdatedFilesWithoutConfigChange", newProps);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DynamicBrokerConfig.html#removeReconfigurable(org.apache.kafka.common.Reconfigurable)"/>
        /// </summary>
        /// <param name="reconfigurable"><see cref="Org.Apache.Kafka.Common.Reconfigurable"/></param>
        public void RemoveReconfigurable(Org.Apache.Kafka.Common.Reconfigurable reconfigurable)
        {
            IExecute("removeReconfigurable", reconfigurable);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DynamicBrokerConfig.html#updateBrokerConfig(int,java.util.Properties,boolean)"/>
        /// </summary>
        /// <param name="brokerId"><see cref="int"/></param>
        /// <param name="persistentProps"><see cref="Java.Util.Properties"/></param>
        /// <param name="doLog"><see cref="bool"/></param>
        public void UpdateBrokerConfig(int brokerId, Java.Util.Properties persistentProps, bool doLog)
        {
            IExecute("updateBrokerConfig", brokerId, persistentProps, doLog);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DynamicBrokerConfig.html#updateDefaultConfig(java.util.Properties,boolean)"/>
        /// </summary>
        /// <param name="persistentProps"><see cref="Java.Util.Properties"/></param>
        /// <param name="doLog"><see cref="bool"/></param>
        public void UpdateDefaultConfig(Java.Util.Properties persistentProps, bool doLog)
        {
            IExecute("updateDefaultConfig", persistentProps, doLog);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DynamicBrokerConfig.html#validate(java.util.Properties,boolean)"/>
        /// </summary>
        /// <param name="props"><see cref="Java.Util.Properties"/></param>
        /// <param name="perBrokerConfig"><see cref="bool"/></param>
        public void Validate(Java.Util.Properties props, bool perBrokerConfig)
        {
            IExecute("validate", props, perBrokerConfig);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}