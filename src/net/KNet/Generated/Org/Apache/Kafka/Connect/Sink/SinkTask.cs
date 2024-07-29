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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using connect-api-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Sink
{
    #region SinkTask
    public partial class SinkTask
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.0/org/apache/kafka/connect/sink/SinkTask.html#TOPICS_CONFIG"/>
        /// </summary>
        public static Java.Lang.String TOPICS_CONFIG { get { if (!_TOPICS_CONFIGReady) { _TOPICS_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TOPICS_CONFIG"); _TOPICS_CONFIGReady = true; } return _TOPICS_CONFIGContent; } }
        private static Java.Lang.String _TOPICS_CONFIGContent = default;
        private static bool _TOPICS_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.0/org/apache/kafka/connect/sink/SinkTask.html#TOPICS_REGEX_CONFIG"/>
        /// </summary>
        public static Java.Lang.String TOPICS_REGEX_CONFIG { get { if (!_TOPICS_REGEX_CONFIGReady) { _TOPICS_REGEX_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TOPICS_REGEX_CONFIG"); _TOPICS_REGEX_CONFIGReady = true; } return _TOPICS_REGEX_CONFIGContent; } }
        private static Java.Lang.String _TOPICS_REGEX_CONFIGContent = default;
        private static bool _TOPICS_REGEX_CONFIGReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.0/org/apache/kafka/connect/sink/SinkTask.html#put-java.util.Collection-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public void Put(Java.Util.Collection<Org.Apache.Kafka.Connect.Sink.SinkRecord> arg0)
        {
            IExecuteWithSignature("put", "(Ljava/util/Collection;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.0/org/apache/kafka/connect/sink/SinkTask.html#start-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public void Start(Java.Util.Map<Java.Lang.String, Java.Lang.String> arg0)
        {
            IExecuteWithSignature("start", "(Ljava/util/Map;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.0/org/apache/kafka/connect/sink/SinkTask.html#stop--"/>
        /// </summary>
        public void Stop()
        {
            IExecuteWithSignature("stop", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.0/org/apache/kafka/connect/sink/SinkTask.html#preCommit-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Clients.Consumer.OffsetAndMetadata> PreCommit(Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Clients.Consumer.OffsetAndMetadata> arg0)
        {
            return IExecuteWithSignature<Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Clients.Consumer.OffsetAndMetadata>>("preCommit", "(Ljava/util/Map;)Ljava/util/Map;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.0/org/apache/kafka/connect/sink/SinkTask.html#close-java.util.Collection-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public void Close(Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartition> arg0)
        {
            IExecuteWithSignature("close", "(Ljava/util/Collection;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.0/org/apache/kafka/connect/sink/SinkTask.html#flush-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public void Flush(Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Clients.Consumer.OffsetAndMetadata> arg0)
        {
            IExecuteWithSignature("flush", "(Ljava/util/Map;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.0/org/apache/kafka/connect/sink/SinkTask.html#initialize-org.apache.kafka.connect.sink.SinkTaskContext-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Sink.SinkTaskContext"/></param>
        public void Initialize(Org.Apache.Kafka.Connect.Sink.SinkTaskContext arg0)
        {
            IExecuteWithSignature("initialize", "(Lorg/apache/kafka/connect/sink/SinkTaskContext;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.0/org/apache/kafka/connect/sink/SinkTask.html#open-java.util.Collection-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public void Open(Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartition> arg0)
        {
            IExecuteWithSignature("open", "(Ljava/util/Collection;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}