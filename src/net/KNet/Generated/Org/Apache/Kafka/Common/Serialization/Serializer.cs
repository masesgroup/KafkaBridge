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
*  using kafka-clients-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Serialization
{
    #region Serializer declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/serialization/Serializer.html"/>
    /// </summary>
    public partial class Serializer : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Serializer() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.knet.generated.org.apache.kafka.common.serialization.Serializer";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region SerializerDirect declaration
    /// <summary>
    /// Direct override of <see cref="Serializer"/> or its generic type if there is one
    /// </summary>
    public partial class SerializerDirect : Serializer
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "org.apache.kafka.common.serialization.Serializer";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
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
    }
    #endregion

    #region Serializer<T> declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/serialization/Serializer.html"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public partial class Serializer<T> : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Serializer() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.knet.generated.org.apache.kafka.common.serialization.Serializer";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class
    
    }
    #endregion

    #region SerializerDirect<T> declaration
    /// <summary>
    /// Direct override of <see cref="Serializer"/> or its generic type if there is one
    /// </summary>
    public partial class SerializerDirect<T> : Serializer<T>
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "org.apache.kafka.common.serialization.Serializer";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
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
    }
    #endregion

    #region Serializer implementation
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
            AddEventHandler("serialize", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(SerializeEventHandler));
            AddEventHandler("serialize3", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(Serialize3EventHandler));
            AddEventHandler("close", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(CloseEventHandler));
            AddEventHandler("configure", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ConfigureEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/serialization/Serializer.html#serialize-java.lang.String-java.lang.Object-"/>
        /// </summary>
        /// <remarks>If <see cref="OnSerialize"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Lang.String, object, byte[]> OnSerialize { get; set; } = null;

        bool hasOverrideSerialize = true;
        void SerializeEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideSerialize = true;
            var methodToExecute = (OnSerialize != null) ? OnSerialize : Serialize;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Java.Lang.String>(0), data.EventData.GetAt<object>(1));
            data.EventData.TypedEventData.SetReturnData(hasOverrideSerialize, executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/serialization/Serializer.html#serialize-java.lang.String-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="byte"/></returns>
        public virtual byte[] Serialize(Java.Lang.String arg0, object arg1)
        {
            hasOverrideSerialize = false; return default;
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/serialization/Serializer.html#serialize-java.lang.String-org.apache.kafka.common.header.Headers-java.lang.Object-"/>
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
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/serialization/Serializer.html#serialize-java.lang.String-org.apache.kafka.common.header.Headers-java.lang.Object-"/>
        /// </summary>
        /// <remarks>If <see cref="OnSerialize3"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Lang.String, Org.Apache.Kafka.Common.Header.Headers, object, byte[]> OnSerialize3 { get; set; } = null;

        bool hasOverrideSerialize3 = true;
        void Serialize3EventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideSerialize3 = true;
            var methodToExecute = (OnSerialize3 != null) ? OnSerialize3 : Serialize;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Java.Lang.String>(0), data.EventData.GetAt<Org.Apache.Kafka.Common.Header.Headers>(1), data.EventData.GetAt<object>(2));
            data.EventData.TypedEventData.SetReturnData(hasOverrideSerialize3, executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/serialization/Serializer.html#serialize-java.lang.String-org.apache.kafka.common.header.Headers-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Header.Headers"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="SerializeDefault"/>; override the method to implement a different behavior</remarks>
        public virtual byte[] Serialize(Java.Lang.String arg0, Org.Apache.Kafka.Common.Header.Headers arg1, object arg2)
        {
            hasOverrideSerialize3 = false; return default;
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/serialization/Serializer.html#close--"/>
        /// </summary>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void CloseDefault()
        {
            IExecuteWithSignature("closeDefault", "()V");
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/serialization/Serializer.html#close--"/>
        /// </summary>
        /// <remarks>If <see cref="OnClose"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action OnClose { get; set; } = null;

        bool hasOverrideClose = true;
        void CloseEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideClose = true;
            var methodToExecute = (OnClose != null) ? OnClose : Close;
            methodToExecute.Invoke();
            data.EventData.TypedEventData.HasOverride = hasOverrideClose;
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/serialization/Serializer.html#close--"/>
        /// </summary>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="CloseDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void Close()
        {
            hasOverrideClose = false;
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/serialization/Serializer.html#configure-java.util.Map-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void ConfigureDefault(Java.Util.Map arg0, bool arg1)
        {
            IExecute("configureDefault", arg0, arg1);
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/serialization/Serializer.html#configure-java.util.Map-boolean-"/>
        /// </summary>
        /// <remarks>If <see cref="OnConfigure"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Util.Map, bool> OnConfigure { get; set; } = null;

        bool hasOverrideConfigure = true;
        void ConfigureEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideConfigure = true;
            var methodToExecute = (OnConfigure != null) ? OnConfigure : Configure;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Util.Map>(0), data.EventData.GetAt<bool>(1));
            data.EventData.TypedEventData.HasOverride = hasOverrideConfigure;
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/serialization/Serializer.html#configure-java.util.Map-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="ConfigureDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void Configure(Java.Util.Map arg0, bool arg1)
        {
            hasOverrideConfigure = false;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SerializerDirect implementation
    public partial class SerializerDirect
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/serialization/Serializer.html#serialize-java.lang.String-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="byte"/></returns>
        public override byte[] Serialize(Java.Lang.String arg0, object arg1)
        {
            return IExecuteArray<byte>("serialize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/serialization/Serializer.html#serialize-java.lang.String-org.apache.kafka.common.header.Headers-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Header.Headers"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <returns><see cref="byte"/></returns>
        public override byte[] Serialize(Java.Lang.String arg0, Org.Apache.Kafka.Common.Header.Headers arg1, object arg2)
        {
            return IExecuteArray<byte>("serialize", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/serialization/Serializer.html#close--"/>
        /// </summary>
        public override void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/serialization/Serializer.html#configure-java.util.Map-boolean-"/>
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

    #region ISerializer<T>
    /// <summary>
    /// .NET interface for org.mases.knet.generated.org.apache.kafka.common.serialization.Serializer implementing <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/serialization/Serializer.html"/>
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

    #region Serializer<T> implementation
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
            AddEventHandler("serialize", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(SerializeEventHandler));
            AddEventHandler("serialize3", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(Serialize3EventHandler));
            AddEventHandler("close", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(CloseEventHandler));
            AddEventHandler("configure", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ConfigureEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/serialization/Serializer.html#serialize-java.lang.String-java.lang.Object-"/>
        /// </summary>
        /// <remarks>If <see cref="OnSerialize"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Lang.String, T, byte[]> OnSerialize { get; set; } = null;

        bool hasOverrideSerialize = true;
        void SerializeEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideSerialize = true;
            var methodToExecute = (OnSerialize != null) ? OnSerialize : Serialize;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Java.Lang.String>(0), data.EventData.GetAt<T>(1));
            data.EventData.TypedEventData.SetReturnData(hasOverrideSerialize, executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/serialization/Serializer.html#serialize-java.lang.String-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><typeparamref name="T"/></param>
        /// <returns><see cref="byte"/></returns>
        public virtual byte[] Serialize(Java.Lang.String arg0, T arg1)
        {
            hasOverrideSerialize = false; return default;
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/serialization/Serializer.html#serialize-java.lang.String-org.apache.kafka.common.header.Headers-java.lang.Object-"/>
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
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/serialization/Serializer.html#serialize-java.lang.String-org.apache.kafka.common.header.Headers-java.lang.Object-"/>
        /// </summary>
        /// <remarks>If <see cref="OnSerialize3"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Lang.String, Org.Apache.Kafka.Common.Header.Headers, T, byte[]> OnSerialize3 { get; set; } = null;

        bool hasOverrideSerialize3 = true;
        void Serialize3EventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideSerialize3 = true;
            var methodToExecute = (OnSerialize3 != null) ? OnSerialize3 : Serialize;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Java.Lang.String>(0), data.EventData.GetAt<Org.Apache.Kafka.Common.Header.Headers>(1), data.EventData.GetAt<T>(2));
            data.EventData.TypedEventData.SetReturnData(hasOverrideSerialize3, executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/serialization/Serializer.html#serialize-java.lang.String-org.apache.kafka.common.header.Headers-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Header.Headers"/></param>
        /// <param name="arg2"><typeparamref name="T"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="SerializeDefault"/>; override the method to implement a different behavior</remarks>
        public virtual byte[] Serialize(Java.Lang.String arg0, Org.Apache.Kafka.Common.Header.Headers arg1, T arg2)
        {
            hasOverrideSerialize3 = false; return default;
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/serialization/Serializer.html#close--"/>
        /// </summary>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void CloseDefault()
        {
            IExecuteWithSignature("closeDefault", "()V");
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/serialization/Serializer.html#close--"/>
        /// </summary>
        /// <remarks>If <see cref="OnClose"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action OnClose { get; set; } = null;

        bool hasOverrideClose = true;
        void CloseEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideClose = true;
            var methodToExecute = (OnClose != null) ? OnClose : Close;
            methodToExecute.Invoke();
            data.EventData.TypedEventData.HasOverride = hasOverrideClose;
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/serialization/Serializer.html#close--"/>
        /// </summary>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="CloseDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void Close()
        {
            hasOverrideClose = false;
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/serialization/Serializer.html#configure-java.util.Map-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void ConfigureDefault(Java.Util.Map<Java.Lang.String, object> arg0, bool arg1)
        {
            IExecute("configureDefault", arg0, arg1);
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/serialization/Serializer.html#configure-java.util.Map-boolean-"/>
        /// </summary>
        /// <remarks>If <see cref="OnConfigure"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Util.Map<Java.Lang.String, object>, bool> OnConfigure { get; set; } = null;

        bool hasOverrideConfigure = true;
        void ConfigureEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideConfigure = true;
            var methodToExecute = (OnConfigure != null) ? OnConfigure : Configure;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Util.Map<Java.Lang.String, object>>(0), data.EventData.GetAt<bool>(1));
            data.EventData.TypedEventData.HasOverride = hasOverrideConfigure;
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/serialization/Serializer.html#configure-java.util.Map-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="ConfigureDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void Configure(Java.Util.Map<Java.Lang.String, object> arg0, bool arg1)
        {
            hasOverrideConfigure = false;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SerializerDirect<T> implementation
    public partial class SerializerDirect<T> : Org.Apache.Kafka.Common.Serialization.ISerializer<T>
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/serialization/Serializer.html#serialize-java.lang.String-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><typeparamref name="T"/></param>
        /// <returns><see cref="byte"/></returns>
        public override byte[] Serialize(Java.Lang.String arg0, T arg1)
        {
            return IExecuteArray<byte>("serialize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/serialization/Serializer.html#serialize-java.lang.String-org.apache.kafka.common.header.Headers-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Header.Headers"/></param>
        /// <param name="arg2"><typeparamref name="T"/></param>
        /// <returns><see cref="byte"/></returns>
        public override byte[] Serialize(Java.Lang.String arg0, Org.Apache.Kafka.Common.Header.Headers arg1, T arg2)
        {
            return IExecuteArray<byte>("serialize", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/serialization/Serializer.html#close--"/>
        /// </summary>
        public override void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/serialization/Serializer.html#configure-java.util.Map-boolean-"/>
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