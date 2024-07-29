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
*  using kafka-streams-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Processor
{
    #region IStateStoreContext
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IStateStoreContext
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region StateStoreContext
    public partial class StateStoreContext : Org.Apache.Kafka.Streams.Processor.IStateStoreContext
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/StateStoreContext.html#stateDir--"/>
        /// </summary>
        /// <returns><see cref="Java.Io.File"/></returns>
        public Java.Io.File StateDir()
        {
            return IExecuteWithSignature<Java.Io.File>("stateDir", "()Ljava/io/File;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/StateStoreContext.html#applicationId--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ApplicationId()
        {
            return IExecuteWithSignature<Java.Lang.String>("applicationId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/StateStoreContext.html#appConfigs--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, object> AppConfigs()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, object>>("appConfigs", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/StateStoreContext.html#appConfigsWithPrefix-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, object> AppConfigsWithPrefix(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, object>>("appConfigsWithPrefix", "(Ljava/lang/String;)Ljava/util/Map;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/StateStoreContext.html#recordMetadata--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Org.Apache.Kafka.Streams.Processor.Api.RecordMetadata> RecordMetadata()
        {
            return IExecuteWithSignature<Java.Util.Optional<Org.Apache.Kafka.Streams.Processor.Api.RecordMetadata>>("recordMetadata", "()Ljava/util/Optional;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/StateStoreContext.html#keySerde--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Serde<object> KeySerde()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.Serde<object>>("keySerde", "()Lorg/apache/kafka/common/serialization/Serde;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/StateStoreContext.html#keySerde--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Serde<object> KeySerdeDirect()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.SerdeDirect<object>, Org.Apache.Kafka.Common.Serialization.Serde<object>>("keySerde", "()Lorg/apache/kafka/common/serialization/Serde;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/StateStoreContext.html#valueSerde--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Serde<object> ValueSerde()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.Serde<object>>("valueSerde", "()Lorg/apache/kafka/common/serialization/Serde;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/StateStoreContext.html#valueSerde--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Serde<object> ValueSerdeDirect()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.SerdeDirect<object>, Org.Apache.Kafka.Common.Serialization.Serde<object>>("valueSerde", "()Lorg/apache/kafka/common/serialization/Serde;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/StateStoreContext.html#taskId--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.TaskId"/></returns>
        public Org.Apache.Kafka.Streams.Processor.TaskId TaskId()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Processor.TaskId>("taskId", "()Lorg/apache/kafka/streams/processor/TaskId;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/StateStoreContext.html#metrics--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.StreamsMetrics"/></returns>
        public Org.Apache.Kafka.Streams.StreamsMetrics Metrics()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.StreamsMetrics>("metrics", "()Lorg/apache/kafka/streams/StreamsMetrics;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/StateStoreContext.html#register-org.apache.kafka.streams.processor.StateStore-org.apache.kafka.streams.processor.StateRestoreCallback-org.apache.kafka.streams.processor.CommitCallback-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.StateStore"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Processor.StateRestoreCallback"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Processor.CommitCallback"/></param>
        public void Register(Org.Apache.Kafka.Streams.Processor.StateStore arg0, Org.Apache.Kafka.Streams.Processor.StateRestoreCallback arg1, Org.Apache.Kafka.Streams.Processor.CommitCallback arg2)
        {
            IExecute("register", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/StateStoreContext.html#register-org.apache.kafka.streams.processor.StateStore-org.apache.kafka.streams.processor.StateRestoreCallback-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.StateStore"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Processor.StateRestoreCallback"/></param>
        public void Register(Org.Apache.Kafka.Streams.Processor.StateStore arg0, Org.Apache.Kafka.Streams.Processor.StateRestoreCallback arg1)
        {
            IExecute("register", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}