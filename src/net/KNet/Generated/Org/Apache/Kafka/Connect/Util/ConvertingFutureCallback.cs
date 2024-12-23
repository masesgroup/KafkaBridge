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
*  using connect-runtime-3.9.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Util
{
    #region ConvertingFutureCallback declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.9.0/org/apache/kafka/connect/util/ConvertingFutureCallback.html"/>
    /// </summary>
    public partial class ConvertingFutureCallback : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ConvertingFutureCallback>
    {
        const string _bridgeClassName = "org.apache.kafka.connect.util.ConvertingFutureCallback";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ConvertingFutureCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ConvertingFutureCallback() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ConvertingFutureCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ConvertingFutureCallback(params object[] args) : base(args) { }

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
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region ConvertingFutureCallback<U, T> declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.9.0/org/apache/kafka/connect/util/ConvertingFutureCallback.html"/>
    /// </summary>
    /// <typeparam name="U"></typeparam>
    /// <typeparam name="T"></typeparam>
    public partial class ConvertingFutureCallback<U, T> : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ConvertingFutureCallback<U, T>>
    {
        const string _bridgeClassName = "org.apache.kafka.connect.util.ConvertingFutureCallback";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ConvertingFutureCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ConvertingFutureCallback() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ConvertingFutureCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ConvertingFutureCallback(params object[] args) : base(args) { }

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
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class
    
    }
    #endregion

    #region ConvertingFutureCallback implementation
    public partial class ConvertingFutureCallback
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.9.0/org/apache/kafka/connect/util/ConvertingFutureCallback.html#org.apache.kafka.connect.util.ConvertingFutureCallback(org.apache.kafka.connect.util.Callback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Util.Callback"/></param>
        public ConvertingFutureCallback(Org.Apache.Kafka.Connect.Util.Callback arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Util.ConvertingFutureCallback"/> to <see cref="Org.Apache.Kafka.Connect.Util.Callback"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Connect.Util.Callback(Org.Apache.Kafka.Connect.Util.ConvertingFutureCallback t) => t.Cast<Org.Apache.Kafka.Connect.Util.Callback>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Util.ConvertingFutureCallback"/> to <see cref="Java.Util.Concurrent.Future"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.Future(Org.Apache.Kafka.Connect.Util.ConvertingFutureCallback t) => t.Cast<Java.Util.Concurrent.Future>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.9.0/org/apache/kafka/connect/util/ConvertingFutureCallback.html#convert-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Convert(object arg0)
        {
            return IExecuteWithSignature("convert", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.9.0/org/apache/kafka/connect/util/ConvertingFutureCallback.html#cancel-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Cancel(bool arg0)
        {
            return IExecuteWithSignature<bool>("cancel", "(Z)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.9.0/org/apache/kafka/connect/util/ConvertingFutureCallback.html#isCancelled--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCancelled()
        {
            return IExecuteWithSignature<bool>("isCancelled", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.9.0/org/apache/kafka/connect/util/ConvertingFutureCallback.html#isDone--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDone()
        {
            return IExecuteWithSignature<bool>("isDone", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.9.0/org/apache/kafka/connect/util/ConvertingFutureCallback.html#get--"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        /// <exception cref="Java.Util.Concurrent.ExecutionException"/>
        public object Get()
        {
            return IExecuteWithSignature("get", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.9.0/org/apache/kafka/connect/util/ConvertingFutureCallback.html#get-long-java.util.concurrent.TimeUnit-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        /// <exception cref="Java.Util.Concurrent.ExecutionException"/>
        /// <exception cref="Java.Util.Concurrent.TimeoutException"/>
        public object Get(long arg0, Java.Util.Concurrent.TimeUnit arg1)
        {
            return IExecuteWithSignature("get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.9.0/org/apache/kafka/connect/util/ConvertingFutureCallback.html#onCompletion-java.lang.Throwable-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Throwable"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void OnCompletion(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0, object arg1)
        {
            IExecuteWithSignature("onCompletion", "(Ljava/lang/Throwable;Ljava/lang/Object;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.9.0/org/apache/kafka/connect/util/ConvertingFutureCallback.html#recordStage-org.apache.kafka.connect.util.Stage-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Util.Stage"/></param>
        public void RecordStage(Org.Apache.Kafka.Connect.Util.Stage arg0)
        {
            IExecuteWithSignature("recordStage", "(Lorg/apache/kafka/connect/util/Stage;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ConvertingFutureCallback<U, T> implementation
    public partial class ConvertingFutureCallback<U, T> : Org.Apache.Kafka.Connect.Util.ICallback<U>, Java.Util.Concurrent.IFuture<T>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.9.0/org/apache/kafka/connect/util/ConvertingFutureCallback.html#org.apache.kafka.connect.util.ConvertingFutureCallback(org.apache.kafka.connect.util.Callback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Util.Callback"/></param>
        public ConvertingFutureCallback(Org.Apache.Kafka.Connect.Util.Callback<T> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Util.ConvertingFutureCallback{U, T}"/> to <see cref="Org.Apache.Kafka.Connect.Util.Callback"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Connect.Util.Callback(Org.Apache.Kafka.Connect.Util.ConvertingFutureCallback<U, T> t) => t.Cast<Org.Apache.Kafka.Connect.Util.Callback>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Util.ConvertingFutureCallback{U, T}"/> to <see cref="Java.Util.Concurrent.Future"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.Future(Org.Apache.Kafka.Connect.Util.ConvertingFutureCallback<U, T> t) => t.Cast<Java.Util.Concurrent.Future>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Util.ConvertingFutureCallback{U, T}"/> to <see cref="Org.Apache.Kafka.Connect.Util.ConvertingFutureCallback"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Connect.Util.ConvertingFutureCallback(Org.Apache.Kafka.Connect.Util.ConvertingFutureCallback<U, T> t) => t.Cast<Org.Apache.Kafka.Connect.Util.ConvertingFutureCallback>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.9.0/org/apache/kafka/connect/util/ConvertingFutureCallback.html#convert-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="U"/></param>
        /// <returns><typeparamref name="T"/></returns>
        public T Convert(U arg0)
        {
            return IExecuteWithSignature<T>("convert", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.9.0/org/apache/kafka/connect/util/ConvertingFutureCallback.html#cancel-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Cancel(bool arg0)
        {
            return IExecuteWithSignature<bool>("cancel", "(Z)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.9.0/org/apache/kafka/connect/util/ConvertingFutureCallback.html#isCancelled--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCancelled()
        {
            return IExecuteWithSignature<bool>("isCancelled", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.9.0/org/apache/kafka/connect/util/ConvertingFutureCallback.html#isDone--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDone()
        {
            return IExecuteWithSignature<bool>("isDone", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.9.0/org/apache/kafka/connect/util/ConvertingFutureCallback.html#get--"/>
        /// </summary>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        /// <exception cref="Java.Util.Concurrent.ExecutionException"/>
        public T Get()
        {
            return IExecuteWithSignature<T>("get", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.9.0/org/apache/kafka/connect/util/ConvertingFutureCallback.html#get-long-java.util.concurrent.TimeUnit-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        /// <exception cref="Java.Util.Concurrent.ExecutionException"/>
        /// <exception cref="Java.Util.Concurrent.TimeoutException"/>
        public T Get(long arg0, Java.Util.Concurrent.TimeUnit arg1)
        {
            return IExecuteWithSignature<T>("get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.9.0/org/apache/kafka/connect/util/ConvertingFutureCallback.html#onCompletion-java.lang.Throwable-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Throwable"/></param>
        /// <param name="arg1"><typeparamref name="U"/></param>
        public void OnCompletion(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0, U arg1)
        {
            IExecuteWithSignature("onCompletion", "(Ljava/lang/Throwable;Ljava/lang/Object;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.9.0/org/apache/kafka/connect/util/ConvertingFutureCallback.html#recordStage-org.apache.kafka.connect.util.Stage-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Util.Stage"/></param>
        public void RecordStage(Org.Apache.Kafka.Connect.Util.Stage arg0)
        {
            IExecuteWithSignature("recordStage", "(Lorg/apache/kafka/connect/util/Stage;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}