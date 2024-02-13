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
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
*  using kafka-clients-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Serialization
{
    #region Serializer
    public partial class Serializer
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
        /// Handlers initializer for <see cref="Serializer"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("serialize", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Lang.String>>>(SerializeEventHandler));
            AddEventHandler("serialize3", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Lang.String>>>(Serialize3EventHandler));
            AddEventHandler("close", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(CloseEventHandler));
            AddEventHandler("configure", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Map>>>(ConfigureEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/serialization/Serializer.html#serialize-java.lang.String-java.lang.Object-"/>
        /// </summary>
        /// <remarks>If <see cref="OnSerialize"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Java.Lang.String, object, byte[]> OnSerialize { get; set; } = null;

        void SerializeEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Lang.String>> data)
        {
            var methodToExecute = (OnSerialize != null) ? OnSerialize : Serialize;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<object>(0));
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/serialization/Serializer.html#serialize-java.lang.String-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="byte"/></returns>
        public virtual byte[] Serialize(Java.Lang.String arg0, object arg1)
        {
            return default;
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/serialization/Serializer.html#serialize-java.lang.String-org.apache.kafka.common.header.Headers-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Header.Headers"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public byte[] SerializeDefault(Java.Lang.String arg0, Org.Apache.Kafka.Common.Header.Headers arg1, object arg2)
        {
            return IExecuteArray<byte>("serializeDefault", arg0, arg1, arg2);
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/serialization/Serializer.html#serialize-java.lang.String-org.apache.kafka.common.header.Headers-java.lang.Object-"/>
        /// </summary>
        /// <remarks>If <see cref="OnSerialize3"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Java.Lang.String, Org.Apache.Kafka.Common.Header.Headers, object, byte[]> OnSerialize3 { get; set; } = null;

        void Serialize3EventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Lang.String>> data)
        {
            var methodToExecute = (OnSerialize3 != null) ? OnSerialize3 : Serialize;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Org.Apache.Kafka.Common.Header.Headers>(0), data.EventData.GetAt<object>(1));
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/serialization/Serializer.html#serialize-java.lang.String-org.apache.kafka.common.header.Headers-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Header.Headers"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="SerializeDefault"/>; override the method to implement a different behavior</remarks>
        public virtual byte[] Serialize(Java.Lang.String arg0, Org.Apache.Kafka.Common.Header.Headers arg1, object arg2)
        {
            return SerializeDefault(arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/serialization/Serializer.html#close--"/>
        /// </summary>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void CloseDefault()
        {
            IExecute("closeDefault");
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/serialization/Serializer.html#close--"/>
        /// </summary>
        /// <remarks>If <see cref="OnClose"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action OnClose { get; set; } = null;

        void CloseEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnClose != null) ? OnClose : Close;
            methodToExecute.Invoke();
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/serialization/Serializer.html#close--"/>
        /// </summary>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="CloseDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void Close()
        {
            CloseDefault();
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/serialization/Serializer.html#configure-java.util.Map-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void ConfigureDefault(Java.Util.Map arg0, bool arg1)
        {
            IExecute("configureDefault", arg0, arg1);
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/serialization/Serializer.html#configure-java.util.Map-boolean-"/>
        /// </summary>
        /// <remarks>If <see cref="OnConfigure"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Util.Map, bool> OnConfigure { get; set; } = null;

        void ConfigureEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Map>> data)
        {
            var methodToExecute = (OnConfigure != null) ? OnConfigure : Configure;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<bool>(0));
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/serialization/Serializer.html#configure-java.util.Map-boolean-"/>
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

    #region ISerializer<T>
    /// <summary>
    /// .NET interface for org.mases.knet.generated.org.apache.kafka.common.serialization.Serializer implementing <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/serialization/Serializer.html"/>
    /// </summary>
    public partial interface ISerializer<T>
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Serializer<T>
    public partial class Serializer<T> : Org.Apache.Kafka.Common.Serialization.ISerializer<T>
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
        /// Handlers initializer for <see cref="Serializer"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("serialize", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Lang.String>>>(SerializeEventHandler));
            AddEventHandler("serialize3", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Lang.String>>>(Serialize3EventHandler));
            AddEventHandler("close", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(CloseEventHandler));
            AddEventHandler("configure", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Map<Java.Lang.String, object>>>>(ConfigureEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/serialization/Serializer.html#serialize-java.lang.String-java.lang.Object-"/>
        /// </summary>
        /// <remarks>If <see cref="OnSerialize"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Java.Lang.String, T, byte[]> OnSerialize { get; set; } = null;

        void SerializeEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Lang.String>> data)
        {
            var methodToExecute = (OnSerialize != null) ? OnSerialize : Serialize;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<T>(0));
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/serialization/Serializer.html#serialize-java.lang.String-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><typeparamref name="T"/></param>
        /// <returns><see cref="byte"/></returns>
        public virtual byte[] Serialize(Java.Lang.String arg0, T arg1)
        {
            return default;
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/serialization/Serializer.html#serialize-java.lang.String-org.apache.kafka.common.header.Headers-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Header.Headers"/></param>
        /// <param name="arg2"><typeparamref name="T"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public byte[] SerializeDefault(Java.Lang.String arg0, Org.Apache.Kafka.Common.Header.Headers arg1, T arg2)
        {
            return IExecuteArray<byte>("serializeDefault", arg0, arg1, arg2);
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/serialization/Serializer.html#serialize-java.lang.String-org.apache.kafka.common.header.Headers-java.lang.Object-"/>
        /// </summary>
        /// <remarks>If <see cref="OnSerialize3"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Java.Lang.String, Org.Apache.Kafka.Common.Header.Headers, T, byte[]> OnSerialize3 { get; set; } = null;

        void Serialize3EventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Lang.String>> data)
        {
            var methodToExecute = (OnSerialize3 != null) ? OnSerialize3 : Serialize;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Org.Apache.Kafka.Common.Header.Headers>(0), data.EventData.GetAt<T>(1));
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/serialization/Serializer.html#serialize-java.lang.String-org.apache.kafka.common.header.Headers-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Header.Headers"/></param>
        /// <param name="arg2"><typeparamref name="T"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="SerializeDefault"/>; override the method to implement a different behavior</remarks>
        public virtual byte[] Serialize(Java.Lang.String arg0, Org.Apache.Kafka.Common.Header.Headers arg1, T arg2)
        {
            return SerializeDefault(arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/serialization/Serializer.html#close--"/>
        /// </summary>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void CloseDefault()
        {
            IExecute("closeDefault");
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/serialization/Serializer.html#close--"/>
        /// </summary>
        /// <remarks>If <see cref="OnClose"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action OnClose { get; set; } = null;

        void CloseEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnClose != null) ? OnClose : Close;
            methodToExecute.Invoke();
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/serialization/Serializer.html#close--"/>
        /// </summary>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="CloseDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void Close()
        {
            CloseDefault();
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/serialization/Serializer.html#configure-java.util.Map-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void ConfigureDefault(Java.Util.Map<Java.Lang.String, object> arg0, bool arg1)
        {
            IExecute("configureDefault", arg0, arg1);
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/serialization/Serializer.html#configure-java.util.Map-boolean-"/>
        /// </summary>
        /// <remarks>If <see cref="OnConfigure"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Util.Map<Java.Lang.String, object>, bool> OnConfigure { get; set; } = null;

        void ConfigureEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Map<Java.Lang.String, object>>> data)
        {
            var methodToExecute = (OnConfigure != null) ? OnConfigure : Configure;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<bool>(0));
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/serialization/Serializer.html#configure-java.util.Map-boolean-"/>
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