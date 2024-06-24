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
*  This file is generated by MASES.JNetReflector (ver. 2.5.4.0)
*  using kafka-clients-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Serialization
{
    #region Serde
    public partial class Serde
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
        /// Handlers initializer for <see cref="Serde"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("deserializer", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(DeserializerEventHandler));
            AddEventHandler("serializer", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(SerializerEventHandler));
            AddEventHandler("close", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(CloseEventHandler));
            AddEventHandler("configure", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Map>>>(ConfigureEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Serde.html#deserializer--"/>
        /// </summary>
        /// <remarks>If <see cref="OnDeserializer"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Org.Apache.Kafka.Common.Serialization.Deserializer> OnDeserializer { get; set; } = null;

        void DeserializerEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnDeserializer != null) ? OnDeserializer : Deserializer;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Serde.html#deserializer--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Deserializer"/></returns>
        public virtual Org.Apache.Kafka.Common.Serialization.Deserializer Deserializer()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Serde.html#serializer--"/>
        /// </summary>
        /// <remarks>If <see cref="OnSerializer"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Org.Apache.Kafka.Common.Serialization.Serializer> OnSerializer { get; set; } = null;

        void SerializerEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnSerializer != null) ? OnSerializer : Serializer;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Serde.html#serializer--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serializer"/></returns>
        public virtual Org.Apache.Kafka.Common.Serialization.Serializer Serializer()
        {
            return default;
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Serde.html#close--"/>
        /// </summary>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void CloseDefault()
        {
            IExecuteWithSignature("closeDefault", "()V");
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Serde.html#close--"/>
        /// </summary>
        /// <remarks>If <see cref="OnClose"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action OnClose { get; set; } = null;

        void CloseEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnClose != null) ? OnClose : Close;
            methodToExecute.Invoke();
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Serde.html#close--"/>
        /// </summary>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="CloseDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void Close()
        {
            CloseDefault();
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Serde.html#configure-java.util.Map-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void ConfigureDefault(Java.Util.Map arg0, bool arg1)
        {
            IExecute("configureDefault", arg0, arg1);
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Serde.html#configure-java.util.Map-boolean-"/>
        /// </summary>
        /// <remarks>If <see cref="OnConfigure"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Util.Map, bool> OnConfigure { get; set; } = null;

        void ConfigureEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Map>> data)
        {
            var methodToExecute = (OnConfigure != null) ? OnConfigure : Configure;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<bool>(0));
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Serde.html#configure-java.util.Map-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="ConfigureDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void Configure(Java.Util.Map arg0, bool arg1)
        {
            ConfigureDefault(arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SerdeDirect
    public partial class SerdeDirect
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Serde.html#deserializer--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Deserializer"/></returns>
        public override Org.Apache.Kafka.Common.Serialization.Deserializer Deserializer()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.DeserializerDirect, Org.Apache.Kafka.Common.Serialization.Deserializer>("deserializer", "()Lorg/apache/kafka/common/serialization/Deserializer;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Serde.html#serializer--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serializer"/></returns>
        public override Org.Apache.Kafka.Common.Serialization.Serializer Serializer()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.SerializerDirect, Org.Apache.Kafka.Common.Serialization.Serializer>("serializer", "()Lorg/apache/kafka/common/serialization/Serializer;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Serde.html#close--"/>
        /// </summary>
        public override void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Serde.html#configure-java.util.Map-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public override void Configure(Java.Util.Map arg0, bool arg1)
        {
            IExecute("configure", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ISerde<T>
    /// <summary>
    /// .NET interface for org.mases.knet.generated.org.apache.kafka.common.serialization.Serde implementing <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Serde.html"/>
    /// </summary>
    public partial interface ISerde<T>
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Serde<T>
    public partial class Serde<T> : Org.Apache.Kafka.Common.Serialization.ISerde<T>
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
        /// Handlers initializer for <see cref="Serde"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("deserializer", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(DeserializerEventHandler));
            AddEventHandler("serializer", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(SerializerEventHandler));
            AddEventHandler("close", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(CloseEventHandler));
            AddEventHandler("configure", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Map<Java.Lang.String, object>>>>(ConfigureEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Serde.html#deserializer--"/>
        /// </summary>
        /// <remarks>If <see cref="OnDeserializer"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Org.Apache.Kafka.Common.Serialization.Deserializer<T>> OnDeserializer { get; set; } = null;

        void DeserializerEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnDeserializer != null) ? OnDeserializer : Deserializer;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Serde.html#deserializer--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Deserializer"/></returns>
        public virtual Org.Apache.Kafka.Common.Serialization.Deserializer<T> Deserializer()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Serde.html#serializer--"/>
        /// </summary>
        /// <remarks>If <see cref="OnSerializer"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Org.Apache.Kafka.Common.Serialization.Serializer<T>> OnSerializer { get; set; } = null;

        void SerializerEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnSerializer != null) ? OnSerializer : Serializer;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Serde.html#serializer--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serializer"/></returns>
        public virtual Org.Apache.Kafka.Common.Serialization.Serializer<T> Serializer()
        {
            return default;
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Serde.html#close--"/>
        /// </summary>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void CloseDefault()
        {
            IExecuteWithSignature("closeDefault", "()V");
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Serde.html#close--"/>
        /// </summary>
        /// <remarks>If <see cref="OnClose"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action OnClose { get; set; } = null;

        void CloseEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnClose != null) ? OnClose : Close;
            methodToExecute.Invoke();
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Serde.html#close--"/>
        /// </summary>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="CloseDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void Close()
        {
            CloseDefault();
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Serde.html#configure-java.util.Map-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void ConfigureDefault(Java.Util.Map<Java.Lang.String, object> arg0, bool arg1)
        {
            IExecute("configureDefault", arg0, arg1);
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Serde.html#configure-java.util.Map-boolean-"/>
        /// </summary>
        /// <remarks>If <see cref="OnConfigure"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Util.Map<Java.Lang.String, object>, bool> OnConfigure { get; set; } = null;

        void ConfigureEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Map<Java.Lang.String, object>>> data)
        {
            var methodToExecute = (OnConfigure != null) ? OnConfigure : Configure;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<bool>(0));
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Serde.html#configure-java.util.Map-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="ConfigureDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void Configure(Java.Util.Map<Java.Lang.String, object> arg0, bool arg1)
        {
            ConfigureDefault(arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SerdeDirect<T>
    public partial class SerdeDirect<T> : Org.Apache.Kafka.Common.Serialization.ISerde<T>
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Serde.html#deserializer--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Deserializer"/></returns>
        public override Org.Apache.Kafka.Common.Serialization.Deserializer<T> Deserializer()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.DeserializerDirect<T>, Org.Apache.Kafka.Common.Serialization.Deserializer<T>>("deserializer", "()Lorg/apache/kafka/common/serialization/Deserializer;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Serde.html#serializer--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serializer"/></returns>
        public override Org.Apache.Kafka.Common.Serialization.Serializer<T> Serializer()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.SerializerDirect<T>, Org.Apache.Kafka.Common.Serialization.Serializer<T>>("serializer", "()Lorg/apache/kafka/common/serialization/Serializer;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Serde.html#close--"/>
        /// </summary>
        public override void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Serde.html#configure-java.util.Map-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public override void Configure(Java.Util.Map<Java.Lang.String, object> arg0, bool arg1)
        {
            IExecute("configure", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}