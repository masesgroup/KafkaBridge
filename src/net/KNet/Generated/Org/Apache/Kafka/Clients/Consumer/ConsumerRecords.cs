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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using kafka-clients-3.6.2.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Consumer
{
    #region ConsumerRecords
    public partial class ConsumerRecords
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/clients/consumer/ConsumerRecords.html#org.apache.kafka.clients.consumer.ConsumerRecords(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public ConsumerRecords(Java.Util.Map arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/clients/consumer/ConsumerRecords.html#EMPTY"/>
        /// </summary>
        public static Org.Apache.Kafka.Clients.Consumer.ConsumerRecords EMPTY { get { if (!_EMPTYReady) { _EMPTYContent = SGetField<Org.Apache.Kafka.Clients.Consumer.ConsumerRecords>(LocalBridgeClazz, "EMPTY"); _EMPTYReady = true; } return _EMPTYContent; } }
        private static Org.Apache.Kafka.Clients.Consumer.ConsumerRecords _EMPTYContent = default;
        private static bool _EMPTYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/clients/consumer/ConsumerRecords.html#empty--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerRecords"/></returns>
        public static Org.Apache.Kafka.Clients.Consumer.ConsumerRecords Empty()
        {
            return SExecute<Org.Apache.Kafka.Clients.Consumer.ConsumerRecords>(LocalBridgeClazz, "empty");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/clients/consumer/ConsumerRecords.html#isEmpty--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecuteWithSignature<bool>("isEmpty", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/clients/consumer/ConsumerRecords.html#count--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Count()
        {
            return IExecuteWithSignature<int>("count", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/clients/consumer/ConsumerRecords.html#records-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        public Java.Lang.Iterable Records(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.Iterable>("records", "(Ljava/lang/String;)Ljava/lang/Iterable;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/clients/consumer/ConsumerRecords.html#iterator--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator Iterator()
        {
            return IExecuteWithSignature<Java.Util.Iterator>("iterator", "()Ljava/util/Iterator;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/clients/consumer/ConsumerRecords.html#records-org.apache.kafka.common.TopicPartition-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List Records(Org.Apache.Kafka.Common.TopicPartition arg0)
        {
            return IExecuteWithSignature<Java.Util.List>("records", "(Lorg/apache/kafka/common/TopicPartition;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/clients/consumer/ConsumerRecords.html#partitions--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set Partitions()
        {
            return IExecuteWithSignature<Java.Util.Set>("partitions", "()Ljava/util/Set;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ConsumerRecords<K, V>
    public partial class ConsumerRecords<K, V>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/clients/consumer/ConsumerRecords.html#org.apache.kafka.clients.consumer.ConsumerRecords(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public ConsumerRecords(Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Java.Util.List<Org.Apache.Kafka.Clients.Consumer.ConsumerRecord<K, V>>> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerRecords{K, V}"/> to <see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerRecords"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Clients.Consumer.ConsumerRecords(Org.Apache.Kafka.Clients.Consumer.ConsumerRecords<K, V> t) => t.Cast<Org.Apache.Kafka.Clients.Consumer.ConsumerRecords>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/clients/consumer/ConsumerRecords.html#EMPTY"/>
        /// </summary>
        public static Org.Apache.Kafka.Clients.Consumer.ConsumerRecords<object, object> EMPTY { get { if (!_EMPTYReady) { _EMPTYContent = SGetField<Org.Apache.Kafka.Clients.Consumer.ConsumerRecords<object, object>>(LocalBridgeClazz, "EMPTY"); _EMPTYReady = true; } return _EMPTYContent; } }
        private static Org.Apache.Kafka.Clients.Consumer.ConsumerRecords<object, object> _EMPTYContent = default;
        private static bool _EMPTYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/clients/consumer/ConsumerRecords.html#empty--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerRecords"/></returns>
        public static Org.Apache.Kafka.Clients.Consumer.ConsumerRecords<K, V> Empty()
        {
            return SExecute<Org.Apache.Kafka.Clients.Consumer.ConsumerRecords<K, V>>(LocalBridgeClazz, "empty");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/clients/consumer/ConsumerRecords.html#isEmpty--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecuteWithSignature<bool>("isEmpty", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/clients/consumer/ConsumerRecords.html#count--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Count()
        {
            return IExecuteWithSignature<int>("count", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/clients/consumer/ConsumerRecords.html#records-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        public Java.Lang.Iterable<Org.Apache.Kafka.Clients.Consumer.ConsumerRecord<K, V>> Records(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.Iterable<Org.Apache.Kafka.Clients.Consumer.ConsumerRecord<K, V>>>("records", "(Ljava/lang/String;)Ljava/lang/Iterable;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/clients/consumer/ConsumerRecords.html#iterator--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator<Org.Apache.Kafka.Clients.Consumer.ConsumerRecord<K, V>> Iterator()
        {
            return IExecuteWithSignature<Java.Util.Iterator<Org.Apache.Kafka.Clients.Consumer.ConsumerRecord<K, V>>>("iterator", "()Ljava/util/Iterator;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/clients/consumer/ConsumerRecords.html#records-org.apache.kafka.common.TopicPartition-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Org.Apache.Kafka.Clients.Consumer.ConsumerRecord<K, V>> Records(Org.Apache.Kafka.Common.TopicPartition arg0)
        {
            return IExecuteWithSignature<Java.Util.List<Org.Apache.Kafka.Clients.Consumer.ConsumerRecord<K, V>>>("records", "(Lorg/apache/kafka/common/TopicPartition;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/clients/consumer/ConsumerRecords.html#partitions--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Org.Apache.Kafka.Common.TopicPartition> Partitions()
        {
            return IExecuteWithSignature<Java.Util.Set<Org.Apache.Kafka.Common.TopicPartition>>("partitions", "()Ljava/util/Set;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}