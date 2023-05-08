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
    #region KafkaRaftServer
    public partial class KafkaRaftServer
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Kafka.Server.KafkaRaftServer"/> to <see cref="Kafka.Server.Server"/>
        /// </summary>
        public static implicit operator Kafka.Server.Server(Kafka.Server.KafkaRaftServer t) => t.Cast<Kafka.Server.Server>();
        /// <summary>
        /// Converter from <see cref="Kafka.Server.KafkaRaftServer"/> to <see cref="Kafka.Utils.Logging"/>
        /// </summary>
        public static implicit operator Kafka.Utils.Logging(Kafka.Server.KafkaRaftServer t) => t.Cast<Kafka.Utils.Logging>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaRaftServer.html#configSchema()"/> 
        /// </summary>
        public static Org.Apache.Kafka.Metadata.KafkaConfigSchema ConfigSchema
        {
            get { return SExecute<Org.Apache.Kafka.Metadata.KafkaConfigSchema>(LocalBridgeClazz, "configSchema"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaRaftServer.html#MetadataPartition()"/> 
        /// </summary>
        public static Org.Apache.Kafka.Common.TopicPartition MetadataPartition
        {
            get { return SExecute<Org.Apache.Kafka.Common.TopicPartition>(LocalBridgeClazz, "MetadataPartition"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaRaftServer.html#MetadataTopic()"/> 
        /// </summary>
        public static string MetadataTopic
        {
            get { return SExecute<string>(LocalBridgeClazz, "MetadataTopic"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaRaftServer.html#MetadataTopicId()"/> 
        /// </summary>
        public static Org.Apache.Kafka.Common.Uuid MetadataTopicId
        {
            get { return SExecute<Org.Apache.Kafka.Common.Uuid>(LocalBridgeClazz, "MetadataTopicId"); }
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaRaftServer.html#isDebugEnabled()"/> 
        /// </summary>
        public bool IsDebugEnabled
        {
            get { return IExecute<bool>("isDebugEnabled"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaRaftServer.html#isTraceEnabled()"/> 
        /// </summary>
        public bool IsTraceEnabled
        {
            get { return IExecute<bool>("isTraceEnabled"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaRaftServer.html#logger()"/> 
        /// </summary>
        public Com.Typesafe.Scalalogging.Logger Logger
        {
            get { return IExecute<Com.Typesafe.Scalalogging.Logger>("logger"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaRaftServer.html#loggerName()"/> 
        /// </summary>
        public string LoggerName
        {
            get { return IExecute<string>("loggerName"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaRaftServer.html#logIdent()"/> 
        /// </summary>
        public string LogIdent
        {
            get { return IExecute<string>("logIdent"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaRaftServer.html#msgWithLogIdent(java.lang.String)"/>
        /// </summary>
        /// <param name="msg"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string MsgWithLogIdent(string msg)
        {
            return IExecute<string>("msgWithLogIdent", msg);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaRaftServer.html#awaitShutdown()"/>
        /// </summary>
        public void AwaitShutdown()
        {
            IExecute("awaitShutdown");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaRaftServer.html#shutdown()"/>
        /// </summary>
        public void Shutdown()
        {
            IExecute("shutdown");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/KafkaRaftServer.html#startup()"/>
        /// </summary>
        public void Startup()
        {
            IExecute("startup");
        }

        #endregion

        #region Nested classes
        #region ProcessRole
        public partial class ProcessRole
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