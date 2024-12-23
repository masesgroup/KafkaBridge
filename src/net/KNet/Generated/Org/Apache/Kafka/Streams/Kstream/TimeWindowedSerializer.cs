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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*  using kafka-streams-3.9.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Kstream
{
    #region TimeWindowedSerializer declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/kstream/TimeWindowedSerializer.html"/>
    /// </summary>
    public partial class TimeWindowedSerializer : MASES.JCOBridge.C2JBridge.JVMBridgeBase<TimeWindowedSerializer>
    {
        const string _bridgeClassName = "org.apache.kafka.streams.kstream.TimeWindowedSerializer";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TimeWindowedSerializer() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TimeWindowedSerializer(params object[] args) : base(args) { }

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

    #region TimeWindowedSerializer<T> declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/kstream/TimeWindowedSerializer.html"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public partial class TimeWindowedSerializer<T> : MASES.JCOBridge.C2JBridge.JVMBridgeBase<TimeWindowedSerializer<T>>
    {
        const string _bridgeClassName = "org.apache.kafka.streams.kstream.TimeWindowedSerializer";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TimeWindowedSerializer() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TimeWindowedSerializer(params object[] args) : base(args) { }

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

    #region TimeWindowedSerializer implementation
    public partial class TimeWindowedSerializer
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/kstream/TimeWindowedSerializer.html#org.apache.kafka.streams.kstream.TimeWindowedSerializer(org.apache.kafka.common.serialization.Serializer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serializer"/></param>
        public TimeWindowedSerializer(Org.Apache.Kafka.Common.Serialization.Serializer arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/kstream/TimeWindowedSerializer.html#serialize-java.lang.String-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] Serialize(Java.Lang.String arg0, object arg1)
        {
            return IExecuteWithSignatureArray<byte>("serialize", "(Ljava/lang/String;Ljava/lang/Object;)[B", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/kstream/TimeWindowedSerializer.html#serialize-java.lang.String-org.apache.kafka.streams.kstream.Windowed-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Windowed"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] Serialize(Java.Lang.String arg0, Org.Apache.Kafka.Streams.Kstream.Windowed arg1)
        {
            return IExecuteWithSignatureArray<byte>("serialize", "(Ljava/lang/String;Lorg/apache/kafka/streams/kstream/Windowed;)[B", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/kstream/TimeWindowedSerializer.html#serializeBaseKey-java.lang.String-org.apache.kafka.streams.kstream.Windowed-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Windowed"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] SerializeBaseKey(Java.Lang.String arg0, Org.Apache.Kafka.Streams.Kstream.Windowed arg1)
        {
            return IExecuteWithSignatureArray<byte>("serializeBaseKey", "(Ljava/lang/String;Lorg/apache/kafka/streams/kstream/Windowed;)[B", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/kstream/TimeWindowedSerializer.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/kstream/TimeWindowedSerializer.html#configure-java.util.Map-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void Configure(Java.Util.Map arg0, bool arg1)
        {
            IExecuteWithSignature("configure", "(Ljava/util/Map;Z)V", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TimeWindowedSerializer<T> implementation
    public partial class TimeWindowedSerializer<T>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/kstream/TimeWindowedSerializer.html#org.apache.kafka.streams.kstream.TimeWindowedSerializer(org.apache.kafka.common.serialization.Serializer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serializer"/></param>
        public TimeWindowedSerializer(Org.Apache.Kafka.Common.Serialization.Serializer<T> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Kstream.TimeWindowedSerializer{T}"/> to <see cref="Org.Apache.Kafka.Streams.Kstream.TimeWindowedSerializer"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Kstream.TimeWindowedSerializer(Org.Apache.Kafka.Streams.Kstream.TimeWindowedSerializer<T> t) => t.Cast<Org.Apache.Kafka.Streams.Kstream.TimeWindowedSerializer>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/kstream/TimeWindowedSerializer.html#serialize-java.lang.String-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] Serialize(Java.Lang.String arg0, object arg1)
        {
            return IExecuteWithSignatureArray<byte>("serialize", "(Ljava/lang/String;Ljava/lang/Object;)[B", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/kstream/TimeWindowedSerializer.html#serialize-java.lang.String-org.apache.kafka.streams.kstream.Windowed-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Windowed"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] Serialize(Java.Lang.String arg0, Org.Apache.Kafka.Streams.Kstream.Windowed<T> arg1)
        {
            return IExecuteWithSignatureArray<byte>("serialize", "(Ljava/lang/String;Lorg/apache/kafka/streams/kstream/Windowed;)[B", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/kstream/TimeWindowedSerializer.html#serializeBaseKey-java.lang.String-org.apache.kafka.streams.kstream.Windowed-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Windowed"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] SerializeBaseKey(Java.Lang.String arg0, Org.Apache.Kafka.Streams.Kstream.Windowed<T> arg1)
        {
            return IExecuteWithSignatureArray<byte>("serializeBaseKey", "(Ljava/lang/String;Lorg/apache/kafka/streams/kstream/Windowed;)[B", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/kstream/TimeWindowedSerializer.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/kstream/TimeWindowedSerializer.html#configure-java.util.Map-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void Configure(Java.Util.Map<Java.Lang.String, object> arg0, bool arg1)
        {
            IExecuteWithSignature("configure", "(Ljava/util/Map;Z)V", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}