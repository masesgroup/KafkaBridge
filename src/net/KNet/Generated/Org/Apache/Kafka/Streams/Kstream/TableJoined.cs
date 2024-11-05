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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using kafka-streams-3.8.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Kstream
{
    #region TableJoined declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/kstream/TableJoined.html"/>
    /// </summary>
    public partial class TableJoined : MASES.JCOBridge.C2JBridge.JVMBridgeBase<TableJoined>
    {
        const string _bridgeClassName = "org.apache.kafka.streams.kstream.TableJoined";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TableJoined() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TableJoined(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region TableJoined<K, KO> declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/kstream/TableJoined.html"/>
    /// </summary>
    /// <typeparam name="K"></typeparam>
    /// <typeparam name="KO"></typeparam>
    public partial class TableJoined<K, KO> : MASES.JCOBridge.C2JBridge.JVMBridgeBase<TableJoined<K, KO>>
    {
        const string _bridgeClassName = "org.apache.kafka.streams.kstream.TableJoined";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TableJoined() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TableJoined(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class
    
    }
    #endregion

    #region TableJoined implementation
    public partial class TableJoined
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/kstream/TableJoined.html#as-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.TableJoined"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.TableJoined As(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.TableJoined>(LocalBridgeClazz, "as", "(Ljava/lang/String;)Lorg/apache/kafka/streams/kstream/TableJoined;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/kstream/TableJoined.html#with-org.apache.kafka.streams.processor.StreamPartitioner-org.apache.kafka.streams.processor.StreamPartitioner-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.StreamPartitioner"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Processor.StreamPartitioner"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.TableJoined"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.TableJoined With(Org.Apache.Kafka.Streams.Processor.StreamPartitioner arg0, Org.Apache.Kafka.Streams.Processor.StreamPartitioner arg1)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.TableJoined>(LocalBridgeClazz, "with", "(Lorg/apache/kafka/streams/processor/StreamPartitioner;Lorg/apache/kafka/streams/processor/StreamPartitioner;)Lorg/apache/kafka/streams/kstream/TableJoined;", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/kstream/TableJoined.html#withOtherPartitioner-org.apache.kafka.streams.processor.StreamPartitioner-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.StreamPartitioner"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.TableJoined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.TableJoined WithOtherPartitioner(Org.Apache.Kafka.Streams.Processor.StreamPartitioner arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.TableJoined>("withOtherPartitioner", "(Lorg/apache/kafka/streams/processor/StreamPartitioner;)Lorg/apache/kafka/streams/kstream/TableJoined;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/kstream/TableJoined.html#withPartitioner-org.apache.kafka.streams.processor.StreamPartitioner-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.StreamPartitioner"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.TableJoined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.TableJoined WithPartitioner(Org.Apache.Kafka.Streams.Processor.StreamPartitioner arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.TableJoined>("withPartitioner", "(Lorg/apache/kafka/streams/processor/StreamPartitioner;)Lorg/apache/kafka/streams/kstream/TableJoined;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TableJoined<K, KO> implementation
    public partial class TableJoined<K, KO>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Kstream.TableJoined{K, KO}"/> to <see cref="Org.Apache.Kafka.Streams.Kstream.TableJoined"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Kstream.TableJoined(Org.Apache.Kafka.Streams.Kstream.TableJoined<K, KO> t) => t.Cast<Org.Apache.Kafka.Streams.Kstream.TableJoined>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/kstream/TableJoined.html#as-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.TableJoined"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.TableJoined<K, KO> As(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.TableJoined<K, KO>>(LocalBridgeClazz, "as", "(Ljava/lang/String;)Lorg/apache/kafka/streams/kstream/TableJoined;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/kstream/TableJoined.html#with-org.apache.kafka.streams.processor.StreamPartitioner-org.apache.kafka.streams.processor.StreamPartitioner-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.StreamPartitioner"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Processor.StreamPartitioner"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.TableJoined"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.TableJoined<K, KO> With(Org.Apache.Kafka.Streams.Processor.StreamPartitioner<K, Java.Lang.Void> arg0, Org.Apache.Kafka.Streams.Processor.StreamPartitioner<KO, Java.Lang.Void> arg1)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.TableJoined<K, KO>>(LocalBridgeClazz, "with", "(Lorg/apache/kafka/streams/processor/StreamPartitioner;Lorg/apache/kafka/streams/processor/StreamPartitioner;)Lorg/apache/kafka/streams/kstream/TableJoined;", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/kstream/TableJoined.html#withOtherPartitioner-org.apache.kafka.streams.processor.StreamPartitioner-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.StreamPartitioner"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.TableJoined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.TableJoined<K, KO> WithOtherPartitioner(Org.Apache.Kafka.Streams.Processor.StreamPartitioner<KO, Java.Lang.Void> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.TableJoined<K, KO>>("withOtherPartitioner", "(Lorg/apache/kafka/streams/processor/StreamPartitioner;)Lorg/apache/kafka/streams/kstream/TableJoined;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.1/org/apache/kafka/streams/kstream/TableJoined.html#withPartitioner-org.apache.kafka.streams.processor.StreamPartitioner-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.StreamPartitioner"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.TableJoined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.TableJoined<K, KO> WithPartitioner(Org.Apache.Kafka.Streams.Processor.StreamPartitioner<K, Java.Lang.Void> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.TableJoined<K, KO>>("withPartitioner", "(Lorg/apache/kafka/streams/processor/StreamPartitioner;)Lorg/apache/kafka/streams/kstream/TableJoined;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}