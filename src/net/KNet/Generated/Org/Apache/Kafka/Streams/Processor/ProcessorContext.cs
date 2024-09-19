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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using kafka-streams-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Processor
{
    #region ProcessorContext declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/ProcessorContext.html"/>
    /// </summary>
    public partial class ProcessorContext : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ProcessorContext>
    {
        const string _bridgeClassName = "org.apache.kafka.streams.processor.ProcessorContext";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ProcessorContext class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ProcessorContext() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ProcessorContext class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ProcessorContext(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region IProcessorContext
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IProcessorContext
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ProcessorContext implementation
    public partial class ProcessorContext : Org.Apache.Kafka.Streams.Processor.IProcessorContext
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/ProcessorContext.html#forward-java.lang.Object-java.lang.Object-org.apache.kafka.streams.processor.To-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Processor.To"/></param>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="V"></typeparam>
        public void Forward<K, V>(K arg0, V arg1, Org.Apache.Kafka.Streams.Processor.To arg2)
        {
            IExecute("forward", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/ProcessorContext.html#forward-java.lang.Object-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="V"></typeparam>
        public void Forward<K, V>(K arg0, V arg1)
        {
            IExecute("forward", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/ProcessorContext.html#getStateStore-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <typeparam name="S"><see cref="Org.Apache.Kafka.Streams.Processor.IStateStore"/></typeparam>
        /// <returns><typeparamref name="S"/></returns>
        public S GetStateStore<S>(Java.Lang.String arg0) where S : Org.Apache.Kafka.Streams.Processor.IStateStore, new()
        {
            return IExecute<S>("getStateStore", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/ProcessorContext.html#partition--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Partition()
        {
            return IExecuteWithSignature<int>("partition", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/ProcessorContext.html#stateDir--"/>
        /// </summary>
        /// <returns><see cref="Java.Io.File"/></returns>
        public Java.Io.File StateDir()
        {
            return IExecuteWithSignature<Java.Io.File>("stateDir", "()Ljava/io/File;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/ProcessorContext.html#applicationId--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ApplicationId()
        {
            return IExecuteWithSignature<Java.Lang.String>("applicationId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/ProcessorContext.html#topic--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Topic()
        {
            return IExecuteWithSignature<Java.Lang.String>("topic", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/ProcessorContext.html#appConfigs--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, object> AppConfigs()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, object>>("appConfigs", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/ProcessorContext.html#appConfigsWithPrefix-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, object> AppConfigsWithPrefix(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, object>>("appConfigsWithPrefix", "(Ljava/lang/String;)Ljava/util/Map;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/ProcessorContext.html#currentStreamTimeMs--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long CurrentStreamTimeMs()
        {
            return IExecuteWithSignature<long>("currentStreamTimeMs", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/ProcessorContext.html#currentSystemTimeMs--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long CurrentSystemTimeMs()
        {
            return IExecuteWithSignature<long>("currentSystemTimeMs", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/ProcessorContext.html#offset--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long Offset()
        {
            return IExecuteWithSignature<long>("offset", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/ProcessorContext.html#timestamp--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long Timestamp()
        {
            return IExecuteWithSignature<long>("timestamp", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/ProcessorContext.html#headers--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Header.Headers"/></returns>
        public Org.Apache.Kafka.Common.Header.Headers Headers()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Header.Headers>("headers", "()Lorg/apache/kafka/common/header/Headers;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/ProcessorContext.html#keySerde--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Serde<object> KeySerde()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.Serde<object>>("keySerde", "()Lorg/apache/kafka/common/serialization/Serde;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/ProcessorContext.html#keySerde--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Serde<object> KeySerdeDirect()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.SerdeDirect<object>, Org.Apache.Kafka.Common.Serialization.Serde<object>>("keySerde", "()Lorg/apache/kafka/common/serialization/Serde;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/ProcessorContext.html#valueSerde--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Serde<object> ValueSerde()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.Serde<object>>("valueSerde", "()Lorg/apache/kafka/common/serialization/Serde;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/ProcessorContext.html#valueSerde--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Serde<object> ValueSerdeDirect()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.SerdeDirect<object>, Org.Apache.Kafka.Common.Serialization.Serde<object>>("valueSerde", "()Lorg/apache/kafka/common/serialization/Serde;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/ProcessorContext.html#schedule-java.time.Duration-org.apache.kafka.streams.processor.PunctuationType-org.apache.kafka.streams.processor.Punctuator-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Duration"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Processor.PunctuationType"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Processor.Punctuator"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.Cancellable"/></returns>
        public Org.Apache.Kafka.Streams.Processor.Cancellable Schedule(Java.Time.Duration arg0, Org.Apache.Kafka.Streams.Processor.PunctuationType arg1, Org.Apache.Kafka.Streams.Processor.Punctuator arg2)
        {
            return IExecute<Org.Apache.Kafka.Streams.Processor.Cancellable>("schedule", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/ProcessorContext.html#taskId--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.TaskId"/></returns>
        public Org.Apache.Kafka.Streams.Processor.TaskId TaskId()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Processor.TaskId>("taskId", "()Lorg/apache/kafka/streams/processor/TaskId;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/ProcessorContext.html#metrics--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.StreamsMetrics"/></returns>
        public Org.Apache.Kafka.Streams.StreamsMetrics Metrics()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.StreamsMetrics>("metrics", "()Lorg/apache/kafka/streams/StreamsMetrics;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/ProcessorContext.html#commit--"/>
        /// </summary>
        public void Commit()
        {
            IExecuteWithSignature("commit", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/ProcessorContext.html#register-org.apache.kafka.streams.processor.StateStore-org.apache.kafka.streams.processor.StateRestoreCallback-"/>
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