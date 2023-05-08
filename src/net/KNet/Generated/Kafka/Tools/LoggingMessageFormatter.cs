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

namespace Kafka.Tools
{
    #region LoggingMessageFormatter
    public partial class LoggingMessageFormatter
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Kafka.Tools.LoggingMessageFormatter"/> to <see cref="Org.Apache.Kafka.Common.MessageFormatter"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.MessageFormatter(Kafka.Tools.LoggingMessageFormatter t) => t.Cast<Org.Apache.Kafka.Common.MessageFormatter>();
        /// <summary>
        /// Converter from <see cref="Kafka.Tools.LoggingMessageFormatter"/> to <see cref="Com.Typesafe.Scalalogging.LazyLogging"/>
        /// </summary>
        public static implicit operator Com.Typesafe.Scalalogging.LazyLogging(Kafka.Tools.LoggingMessageFormatter t) => t.Cast<Com.Typesafe.Scalalogging.LazyLogging>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/tools/LoggingMessageFormatter.html#logger()"/> 
        /// </summary>
        public Com.Typesafe.Scalalogging.Logger Logger
        {
            get { return IExecute<Com.Typesafe.Scalalogging.Logger>("logger"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/tools/LoggingMessageFormatter.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/tools/LoggingMessageFormatter.html#configure(java.util.Map)"/>
        /// </summary>
        /// <param name="configs"><see cref="Java.Util.Map"/></param>
        /// <typeparam name="ConfigsExtendsobject"></typeparam>
        public void Configure<ConfigsExtendsobject>(Java.Util.Map<string, ConfigsExtendsobject> configs)
        {
            IExecute("configure", configs);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/tools/LoggingMessageFormatter.html#writeTo(org.apache.kafka.clients.consumer.ConsumerRecord,java.io.PrintStream)"/>
        /// </summary>
        /// <param name="consumerRecord"><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerRecord"/></param>
        /// <param name="output"><see cref="Java.Io.PrintStream"/></param>
        public void WriteTo(Org.Apache.Kafka.Clients.Consumer.ConsumerRecord<byte[], byte[]> consumerRecord, Java.Io.PrintStream output)
        {
            IExecute("writeTo", consumerRecord, output);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}