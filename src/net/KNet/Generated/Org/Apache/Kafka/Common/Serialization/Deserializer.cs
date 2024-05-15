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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*  using kafka-clients-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Serialization
{
    #region Deserializer
    public partial class Deserializer
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
        /// Handlers initializer for <see cref="Deserializer"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("deserialize", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Lang.String>>>(DeserializeEventHandler));
            AddEventHandler("deserialize3", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Lang.String>>>(Deserialize3EventHandler));
            AddEventHandler("deserialize3_2", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Lang.String>>>(Deserialize3_2EventHandler));
            AddEventHandler("close", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(CloseEventHandler));
            AddEventHandler("configure", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Map>>>(ConfigureEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Deserializer.html#deserialize-java.lang.String-byte[]-"/>
        /// </summary>
        /// <remarks>If <see cref="OnDeserialize"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Java.Lang.String, byte[], object> OnDeserialize { get; set; } = null;

        void DeserializeEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Lang.String>> data)
        {
            var methodToExecute = (OnDeserialize != null) ? OnDeserialize : Deserialize;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<byte[]>(0));
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Deserializer.html#deserialize-java.lang.String-byte[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <returns><see cref="object"/></returns>
        public virtual object Deserialize(Java.Lang.String arg0, byte[] arg1)
        {
            return default;
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Deserializer.html#deserialize-java.lang.String-org.apache.kafka.common.header.Headers-byte[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Header.Headers"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        /// <returns><see cref="object"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public object DeserializeDefault(Java.Lang.String arg0, Org.Apache.Kafka.Common.Header.Headers arg1, byte[] arg2)
        {
            return IExecute("deserializeDefault", arg0, arg1, arg2);
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Deserializer.html#deserialize-java.lang.String-org.apache.kafka.common.header.Headers-byte[]-"/>
        /// </summary>
        /// <remarks>If <see cref="OnDeserialize3"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Java.Lang.String, Org.Apache.Kafka.Common.Header.Headers, byte[], object> OnDeserialize3 { get; set; } = null;

        void Deserialize3EventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Lang.String>> data)
        {
            var methodToExecute = (OnDeserialize3 != null) ? OnDeserialize3 : Deserialize;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Org.Apache.Kafka.Common.Header.Headers>(0), data.EventData.GetAt<byte[]>(1));
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Deserializer.html#deserialize-java.lang.String-org.apache.kafka.common.header.Headers-byte[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Header.Headers"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        /// <returns><see cref="object"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="DeserializeDefault"/>; override the method to implement a different behavior</remarks>
        public virtual object Deserialize(Java.Lang.String arg0, Org.Apache.Kafka.Common.Header.Headers arg1, byte[] arg2)
        {
            return DeserializeDefault(arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Deserializer.html#deserialize-java.lang.String-org.apache.kafka.common.header.Headers-java.nio.ByteBuffer-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Header.Headers"/></param>
        /// <param name="arg2"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="object"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public object DeserializeDefault(Java.Lang.String arg0, Org.Apache.Kafka.Common.Header.Headers arg1, Java.Nio.ByteBuffer arg2)
        {
            return IExecute("deserializeDefault", arg0, arg1, arg2);
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Deserializer.html#deserialize-java.lang.String-org.apache.kafka.common.header.Headers-java.nio.ByteBuffer-"/>
        /// </summary>
        /// <remarks>If <see cref="OnDeserialize3_2"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Java.Lang.String, Org.Apache.Kafka.Common.Header.Headers, Java.Nio.ByteBuffer, object> OnDeserialize3_2 { get; set; } = null;

        void Deserialize3_2EventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Lang.String>> data)
        {
            var methodToExecute = (OnDeserialize3_2 != null) ? OnDeserialize3_2 : Deserialize;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Org.Apache.Kafka.Common.Header.Headers>(0), data.EventData.GetAt<Java.Nio.ByteBuffer>(1));
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Deserializer.html#deserialize-java.lang.String-org.apache.kafka.common.header.Headers-java.nio.ByteBuffer-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Header.Headers"/></param>
        /// <param name="arg2"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="object"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="DeserializeDefault"/>; override the method to implement a different behavior</remarks>
        public virtual object Deserialize(Java.Lang.String arg0, Org.Apache.Kafka.Common.Header.Headers arg1, Java.Nio.ByteBuffer arg2)
        {
            return DeserializeDefault(arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Deserializer.html#close--"/>
        /// </summary>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void CloseDefault()
        {
            IExecuteWithSignature("closeDefault", "()V");
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Deserializer.html#close--"/>
        /// </summary>
        /// <remarks>If <see cref="OnClose"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action OnClose { get; set; } = null;

        void CloseEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnClose != null) ? OnClose : Close;
            methodToExecute.Invoke();
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Deserializer.html#close--"/>
        /// </summary>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="CloseDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void Close()
        {
            CloseDefault();
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Deserializer.html#configure-java.util.Map-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void ConfigureDefault(Java.Util.Map arg0, bool arg1)
        {
            IExecute("configureDefault", arg0, arg1);
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Deserializer.html#configure-java.util.Map-boolean-"/>
        /// </summary>
        /// <remarks>If <see cref="OnConfigure"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Util.Map, bool> OnConfigure { get; set; } = null;

        void ConfigureEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Map>> data)
        {
            var methodToExecute = (OnConfigure != null) ? OnConfigure : Configure;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<bool>(0));
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Deserializer.html#configure-java.util.Map-boolean-"/>
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

    #region IDeserializer<T>
    /// <summary>
    /// .NET interface for org.mases.knet.generated.org.apache.kafka.common.serialization.Deserializer implementing <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Deserializer.html"/>
    /// </summary>
    public partial interface IDeserializer<T>
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Deserializer<T>
    public partial class Deserializer<T> : Org.Apache.Kafka.Common.Serialization.IDeserializer<T>
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
        /// Handlers initializer for <see cref="Deserializer"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("deserialize", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Lang.String>>>(DeserializeEventHandler));
            AddEventHandler("deserialize3", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Lang.String>>>(Deserialize3EventHandler));
            AddEventHandler("deserialize3_2", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Lang.String>>>(Deserialize3_2EventHandler));
            AddEventHandler("close", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(CloseEventHandler));
            AddEventHandler("configure", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Map<Java.Lang.String, object>>>>(ConfigureEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Deserializer.html#deserialize-java.lang.String-byte[]-"/>
        /// </summary>
        /// <remarks>If <see cref="OnDeserialize"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Java.Lang.String, byte[], T> OnDeserialize { get; set; } = null;

        void DeserializeEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Lang.String>> data)
        {
            var methodToExecute = (OnDeserialize != null) ? OnDeserialize : Deserialize;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<byte[]>(0));
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Deserializer.html#deserialize-java.lang.String-byte[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <returns><typeparamref name="T"/></returns>
        public virtual T Deserialize(Java.Lang.String arg0, byte[] arg1)
        {
            return default;
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Deserializer.html#deserialize-java.lang.String-org.apache.kafka.common.header.Headers-byte[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Header.Headers"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        /// <returns><typeparamref name="T"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public T DeserializeDefault(Java.Lang.String arg0, Org.Apache.Kafka.Common.Header.Headers arg1, byte[] arg2)
        {
            return IExecute<T>("deserializeDefault", arg0, arg1, arg2);
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Deserializer.html#deserialize-java.lang.String-org.apache.kafka.common.header.Headers-byte[]-"/>
        /// </summary>
        /// <remarks>If <see cref="OnDeserialize3"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Java.Lang.String, Org.Apache.Kafka.Common.Header.Headers, byte[], T> OnDeserialize3 { get; set; } = null;

        void Deserialize3EventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Lang.String>> data)
        {
            var methodToExecute = (OnDeserialize3 != null) ? OnDeserialize3 : Deserialize;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Org.Apache.Kafka.Common.Header.Headers>(0), data.EventData.GetAt<byte[]>(1));
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Deserializer.html#deserialize-java.lang.String-org.apache.kafka.common.header.Headers-byte[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Header.Headers"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        /// <returns><typeparamref name="T"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="DeserializeDefault"/>; override the method to implement a different behavior</remarks>
        public virtual T Deserialize(Java.Lang.String arg0, Org.Apache.Kafka.Common.Header.Headers arg1, byte[] arg2)
        {
            return DeserializeDefault(arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Deserializer.html#deserialize-java.lang.String-org.apache.kafka.common.header.Headers-java.nio.ByteBuffer-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Header.Headers"/></param>
        /// <param name="arg2"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><typeparamref name="T"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public T DeserializeDefault(Java.Lang.String arg0, Org.Apache.Kafka.Common.Header.Headers arg1, Java.Nio.ByteBuffer arg2)
        {
            return IExecute<T>("deserializeDefault", arg0, arg1, arg2);
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Deserializer.html#deserialize-java.lang.String-org.apache.kafka.common.header.Headers-java.nio.ByteBuffer-"/>
        /// </summary>
        /// <remarks>If <see cref="OnDeserialize3_2"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Java.Lang.String, Org.Apache.Kafka.Common.Header.Headers, Java.Nio.ByteBuffer, T> OnDeserialize3_2 { get; set; } = null;

        void Deserialize3_2EventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Lang.String>> data)
        {
            var methodToExecute = (OnDeserialize3_2 != null) ? OnDeserialize3_2 : Deserialize;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Org.Apache.Kafka.Common.Header.Headers>(0), data.EventData.GetAt<Java.Nio.ByteBuffer>(1));
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Deserializer.html#deserialize-java.lang.String-org.apache.kafka.common.header.Headers-java.nio.ByteBuffer-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Header.Headers"/></param>
        /// <param name="arg2"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><typeparamref name="T"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="DeserializeDefault"/>; override the method to implement a different behavior</remarks>
        public virtual T Deserialize(Java.Lang.String arg0, Org.Apache.Kafka.Common.Header.Headers arg1, Java.Nio.ByteBuffer arg2)
        {
            return DeserializeDefault(arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Deserializer.html#close--"/>
        /// </summary>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void CloseDefault()
        {
            IExecuteWithSignature("closeDefault", "()V");
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Deserializer.html#close--"/>
        /// </summary>
        /// <remarks>If <see cref="OnClose"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action OnClose { get; set; } = null;

        void CloseEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnClose != null) ? OnClose : Close;
            methodToExecute.Invoke();
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Deserializer.html#close--"/>
        /// </summary>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="CloseDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void Close()
        {
            CloseDefault();
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Deserializer.html#configure-java.util.Map-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void ConfigureDefault(Java.Util.Map<Java.Lang.String, object> arg0, bool arg1)
        {
            IExecute("configureDefault", arg0, arg1);
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Deserializer.html#configure-java.util.Map-boolean-"/>
        /// </summary>
        /// <remarks>If <see cref="OnConfigure"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Util.Map<Java.Lang.String, object>, bool> OnConfigure { get; set; } = null;

        void ConfigureEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Map<Java.Lang.String, object>>> data)
        {
            var methodToExecute = (OnConfigure != null) ? OnConfigure : Configure;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<bool>(0));
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/serialization/Deserializer.html#configure-java.util.Map-boolean-"/>
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
}