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
*  This file is generated by MASES.JNetReflector (ver. 2.0.0.0)
*  using kafka-streams-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams
{
    #region IKafkaClientSupplier
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IKafkaClientSupplier
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region KafkaClientSupplier
    public partial class KafkaClientSupplier : Org.Apache.Kafka.Streams.IKafkaClientSupplier
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/KafkaClientSupplier.html#getConsumer(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Consumer.Consumer"/></returns>
        public Org.Apache.Kafka.Clients.Consumer.Consumer<byte[], byte[]> GetConsumer(Java.Util.Map<string, object> arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Consumer.Consumer<byte[], byte[]>>("getConsumer", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/KafkaClientSupplier.html#getGlobalConsumer(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Consumer.Consumer"/></returns>
        public Org.Apache.Kafka.Clients.Consumer.Consumer<byte[], byte[]> GetGlobalConsumer(Java.Util.Map<string, object> arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Consumer.Consumer<byte[], byte[]>>("getGlobalConsumer", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/KafkaClientSupplier.html#getRestoreConsumer(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Consumer.Consumer"/></returns>
        public Org.Apache.Kafka.Clients.Consumer.Consumer<byte[], byte[]> GetRestoreConsumer(Java.Util.Map<string, object> arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Consumer.Consumer<byte[], byte[]>>("getRestoreConsumer", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/KafkaClientSupplier.html#getProducer(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Producer.Producer"/></returns>
        public Org.Apache.Kafka.Clients.Producer.Producer<byte[], byte[]> GetProducer(Java.Util.Map<string, object> arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Producer.Producer<byte[], byte[]>>("getProducer", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/KafkaClientSupplier.html#getAdmin(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.Admin"/></returns>
        public Org.Apache.Kafka.Clients.Admin.Admin GetAdmin(Java.Util.Map<string, object> arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.Admin>("getAdmin", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}