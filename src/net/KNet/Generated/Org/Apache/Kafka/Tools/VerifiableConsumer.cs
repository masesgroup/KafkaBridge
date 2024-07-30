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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using kafka-tools-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Tools
{
    #region VerifiableConsumer
    public partial class VerifiableConsumer : Java.Io.ICloseable, Org.Apache.Kafka.Clients.Consumer.IOffsetCommitCallback, Org.Apache.Kafka.Clients.Consumer.IConsumerRebalanceListener
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.8.0/org/apache/kafka/tools/VerifiableConsumer.html#org.apache.kafka.tools.VerifiableConsumer(org.apache.kafka.clients.consumer.KafkaConsumer,java.io.PrintStream,java.lang.String,int,boolean,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Consumer.KafkaConsumer"/></param>
        /// <param name="arg1"><see cref="Java.Io.PrintStream"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        /// <param name="arg5"><see cref="bool"/></param>
        /// <param name="arg6"><see cref="bool"/></param>
        public VerifiableConsumer(Org.Apache.Kafka.Clients.Consumer.KafkaConsumer<Java.Lang.String, Java.Lang.String> arg0, Java.Io.PrintStream arg1, Java.Lang.String arg2, int arg3, bool arg4, bool arg5, bool arg6)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Tools.VerifiableConsumer"/> to <see cref="Java.Io.Closeable"/>
        /// </summary>
        public static implicit operator Java.Io.Closeable(Org.Apache.Kafka.Tools.VerifiableConsumer t) => t.Cast<Java.Io.Closeable>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Tools.VerifiableConsumer"/> to <see cref="Org.Apache.Kafka.Clients.Consumer.OffsetCommitCallback"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Clients.Consumer.OffsetCommitCallback(Org.Apache.Kafka.Tools.VerifiableConsumer t) => t.Cast<Org.Apache.Kafka.Clients.Consumer.OffsetCommitCallback>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Tools.VerifiableConsumer"/> to <see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerRebalanceListener"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Clients.Consumer.ConsumerRebalanceListener(Org.Apache.Kafka.Tools.VerifiableConsumer t) => t.Cast<Org.Apache.Kafka.Clients.Consumer.ConsumerRebalanceListener>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.8.0/org/apache/kafka/tools/VerifiableConsumer.html#main-java.lang.String[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public static void Main(Java.Lang.String[] arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "main", "([Ljava/lang/String;)V", new object[] { arg0 });
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.8.0/org/apache/kafka/tools/VerifiableConsumer.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.8.0/org/apache/kafka/tools/VerifiableConsumer.html#commitSync-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public void CommitSync(Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Clients.Consumer.OffsetAndMetadata> arg0)
        {
            IExecuteWithSignature("commitSync", "(Ljava/util/Map;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.8.0/org/apache/kafka/tools/VerifiableConsumer.html#onComplete-java.util.Map-java.lang.Exception-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Exception"/></param>
        public void OnComplete(Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Clients.Consumer.OffsetAndMetadata> arg0, MASES.JCOBridge.C2JBridge.JVMBridgeException arg1)
        {
            IExecute("onComplete", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.8.0/org/apache/kafka/tools/VerifiableConsumer.html#onPartitionsAssigned-java.util.Collection-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public void OnPartitionsAssigned(Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartition> arg0)
        {
            IExecuteWithSignature("onPartitionsAssigned", "(Ljava/util/Collection;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.8.0/org/apache/kafka/tools/VerifiableConsumer.html#onPartitionsRevoked-java.util.Collection-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public void OnPartitionsRevoked(Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartition> arg0)
        {
            IExecuteWithSignature("onPartitionsRevoked", "(Ljava/util/Collection;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.8.0/org/apache/kafka/tools/VerifiableConsumer.html#run--"/>
        /// </summary>
        public void Run()
        {
            IExecuteWithSignature("run", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}