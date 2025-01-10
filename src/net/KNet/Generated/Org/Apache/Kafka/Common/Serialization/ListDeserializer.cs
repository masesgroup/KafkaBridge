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
*  using kafka-clients-3.9.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Serialization
{
    #region ListDeserializer declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/serialization/ListDeserializer.html"/>
    /// </summary>
    public partial class ListDeserializer : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ListDeserializer>
    {
        const string _bridgeClassName = "org.apache.kafka.common.serialization.ListDeserializer";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ListDeserializer() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ListDeserializer(params object[] args) : base(args) { }

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
        public override bool IsBridgeCloseable => true;
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

    #region ListDeserializer<Inner> declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/serialization/ListDeserializer.html"/>
    /// </summary>
    /// <typeparam name="Inner"></typeparam>
    public partial class ListDeserializer<Inner> : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ListDeserializer<Inner>>
    {
        const string _bridgeClassName = "org.apache.kafka.common.serialization.ListDeserializer";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ListDeserializer() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ListDeserializer(params object[] args) : base(args) { }

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
        public override bool IsBridgeCloseable => true;
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

    #region ListDeserializer implementation
    public partial class ListDeserializer
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/serialization/ListDeserializer.html#org.apache.kafka.common.serialization.ListDeserializer(java.lang.Class,org.apache.kafka.common.serialization.Deserializer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Serialization.Deserializer"/></param>
        public ListDeserializer(Java.Lang.Class arg0, Org.Apache.Kafka.Common.Serialization.Deserializer arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Common.Serialization.ListDeserializer"/> to <see cref="Org.Apache.Kafka.Common.Serialization.Deserializer"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Serialization.Deserializer(Org.Apache.Kafka.Common.Serialization.ListDeserializer t) => t.Cast<Org.Apache.Kafka.Common.Serialization.Deserializer>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/serialization/ListDeserializer.html#deserialize-java.lang.String-byte[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <returns><see cref="object"/></returns>
        public object Deserialize(Java.Lang.String arg0, byte[] arg1)
        {
            return IExecuteWithSignature("deserialize", "(Ljava/lang/String;[B)Ljava/lang/Object;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/serialization/ListDeserializer.html#innerDeserializer--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Deserializer"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Deserializer InnerDeserializer()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.Deserializer>("innerDeserializer", "()Lorg/apache/kafka/common/serialization/Deserializer;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/serialization/ListDeserializer.html#innerDeserializer--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Deserializer"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Deserializer InnerDeserializerDirect()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.DeserializerDirect, Org.Apache.Kafka.Common.Serialization.Deserializer>("innerDeserializer", "()Lorg/apache/kafka/common/serialization/Deserializer;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/serialization/ListDeserializer.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/serialization/ListDeserializer.html#configure-java.util.Map-boolean-"/>
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

    #region ListDeserializer<Inner> implementation
    public partial class ListDeserializer<Inner>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/serialization/ListDeserializer.html#org.apache.kafka.common.serialization.ListDeserializer(java.lang.Class,org.apache.kafka.common.serialization.Deserializer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Serialization.Deserializer"/></param>
        public ListDeserializer(Java.Lang.Class arg0, Org.Apache.Kafka.Common.Serialization.Deserializer<Inner> arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Common.Serialization.ListDeserializer{Inner}"/> to <see cref="Org.Apache.Kafka.Common.Serialization.Deserializer"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Serialization.Deserializer(Org.Apache.Kafka.Common.Serialization.ListDeserializer<Inner> t) => t.Cast<Org.Apache.Kafka.Common.Serialization.Deserializer>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Common.Serialization.ListDeserializer{Inner}"/> to <see cref="Org.Apache.Kafka.Common.Serialization.ListDeserializer"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Serialization.ListDeserializer(Org.Apache.Kafka.Common.Serialization.ListDeserializer<Inner> t) => t.Cast<Org.Apache.Kafka.Common.Serialization.ListDeserializer>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/serialization/ListDeserializer.html#deserialize-java.lang.String-byte[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <returns><see cref="object"/></returns>
        public object Deserialize(Java.Lang.String arg0, byte[] arg1)
        {
            return IExecuteWithSignature("deserialize", "(Ljava/lang/String;[B)Ljava/lang/Object;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/serialization/ListDeserializer.html#innerDeserializer--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Deserializer"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Deserializer<Inner> InnerDeserializer()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.Deserializer<Inner>>("innerDeserializer", "()Lorg/apache/kafka/common/serialization/Deserializer;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/serialization/ListDeserializer.html#innerDeserializer--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Deserializer"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Deserializer<Inner> InnerDeserializerDirect()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.DeserializerDirect<Inner>, Org.Apache.Kafka.Common.Serialization.Deserializer<Inner>>("innerDeserializer", "()Lorg/apache/kafka/common/serialization/Deserializer;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/serialization/ListDeserializer.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/serialization/ListDeserializer.html#configure-java.util.Map-boolean-"/>
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