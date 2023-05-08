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
*  using kafka-clients-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Consumer
{
    #region ConsumerRecords
    public partial class ConsumerRecords
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/consumer/ConsumerRecords.html#%3Cinit%3E(java.util.Map)"/>
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
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/consumer/ConsumerRecords.html#EMPTY"/>
        /// </summary>
        public static Org.Apache.Kafka.Clients.Consumer.ConsumerRecords EMPTY { get { return SGetField<Org.Apache.Kafka.Clients.Consumer.ConsumerRecords>(LocalBridgeClazz, "EMPTY"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/consumer/ConsumerRecords.html#empty()"/> 
        /// </summary>
        public static Org.Apache.Kafka.Clients.Consumer.ConsumerRecords Empty
        {
            get { return SExecute<Org.Apache.Kafka.Clients.Consumer.ConsumerRecords>(LocalBridgeClazz, "empty"); }
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/consumer/ConsumerRecords.html#count()"/> 
        /// </summary>
        public int Count
        {
            get { return IExecute<int>("count"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/consumer/ConsumerRecords.html#isEmpty()"/> 
        /// </summary>
        public bool IsEmpty
        {
            get { return IExecute<bool>("isEmpty"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/consumer/ConsumerRecords.html#iterator()"/> 
        /// </summary>
        public Java.Util.Iterator Iterator
        {
            get { return IExecute<Java.Util.Iterator>("iterator"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/consumer/ConsumerRecords.html#partitions()"/> 
        /// </summary>
        public Java.Util.Set Partitions
        {
            get { return IExecute<Java.Util.Set>("partitions"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/consumer/ConsumerRecords.html#records(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        public Java.Lang.Iterable Records(string arg0)
        {
            return IExecute<Java.Lang.Iterable>("records", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/consumer/ConsumerRecords.html#records(org.apache.kafka.common.TopicPartition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List Records(Org.Apache.Kafka.Common.TopicPartition arg0)
        {
            return IExecute<Java.Util.List>("records", arg0);
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
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/consumer/ConsumerRecords.html#%3Cinit%3E(java.util.Map)"/>
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
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/consumer/ConsumerRecords.html#EMPTY"/>
        /// </summary>
        public static Org.Apache.Kafka.Clients.Consumer.ConsumerRecords<object, object> EMPTY { get { return SGetField<Org.Apache.Kafka.Clients.Consumer.ConsumerRecords<object, object>>(LocalBridgeClazz, "EMPTY"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/consumer/ConsumerRecords.html#empty()"/> 
        /// </summary>
        public static Org.Apache.Kafka.Clients.Consumer.ConsumerRecords<K, V> Empty
        {
            get { return SExecute<Org.Apache.Kafka.Clients.Consumer.ConsumerRecords<K, V>>(LocalBridgeClazz, "empty"); }
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/consumer/ConsumerRecords.html#count()"/> 
        /// </summary>
        public int Count
        {
            get { return IExecute<int>("count"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/consumer/ConsumerRecords.html#isEmpty()"/> 
        /// </summary>
        public bool IsEmpty
        {
            get { return IExecute<bool>("isEmpty"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/consumer/ConsumerRecords.html#iterator()"/> 
        /// </summary>
        public Java.Util.Iterator<Org.Apache.Kafka.Clients.Consumer.ConsumerRecord<K, V>> Iterator
        {
            get { return IExecute<Java.Util.Iterator<Org.Apache.Kafka.Clients.Consumer.ConsumerRecord<K, V>>>("iterator"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/consumer/ConsumerRecords.html#partitions()"/> 
        /// </summary>
        public Java.Util.Set<Org.Apache.Kafka.Common.TopicPartition> Partitions
        {
            get { return IExecute<Java.Util.Set<Org.Apache.Kafka.Common.TopicPartition>>("partitions"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/consumer/ConsumerRecords.html#records(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        public Java.Lang.Iterable<Org.Apache.Kafka.Clients.Consumer.ConsumerRecord<K, V>> Records(string arg0)
        {
            return IExecute<Java.Lang.Iterable<Org.Apache.Kafka.Clients.Consumer.ConsumerRecord<K, V>>>("records", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/consumer/ConsumerRecords.html#records(org.apache.kafka.common.TopicPartition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Org.Apache.Kafka.Clients.Consumer.ConsumerRecord<K, V>> Records(Org.Apache.Kafka.Common.TopicPartition arg0)
        {
            return IExecute<Java.Util.List<Org.Apache.Kafka.Clients.Consumer.ConsumerRecord<K, V>>>("records", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}