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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using kafka-clients-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common
{
    #region KafkaFuture
    public partial class KafkaFuture
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/KafkaFuture.html#completedFuture-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.KafkaFuture"/></returns>
        public static Org.Apache.Kafka.Common.KafkaFuture CompletedFuture(object arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.KafkaFuture>(LocalBridgeClazz, "completedFuture", "(Ljava/lang/Object;)Lorg/apache/kafka/common/KafkaFuture;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/KafkaFuture.html#allOf-org.apache.kafka.common.KafkaFuture[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.KafkaFuture"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.KafkaFuture"/></returns>
        public static Org.Apache.Kafka.Common.KafkaFuture AllOf(params Org.Apache.Kafka.Common.KafkaFuture[] arg0)
        {
            if (arg0.Length == 0) return SExecuteWithSignature<Org.Apache.Kafka.Common.KafkaFuture>(LocalBridgeClazz, "allOf", "([Lorg/apache/kafka/common/KafkaFuture;)Lorg/apache/kafka/common/KafkaFuture;"); else return SExecuteWithSignature<Org.Apache.Kafka.Common.KafkaFuture>(LocalBridgeClazz, "allOf", "([Lorg/apache/kafka/common/KafkaFuture;)Lorg/apache/kafka/common/KafkaFuture;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/KafkaFuture.html#thenApply-org.apache.kafka.common.KafkaFuture.BaseFunction-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.KafkaFuture.BaseFunction"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.KafkaFuture"/></returns>
        public Org.Apache.Kafka.Common.KafkaFuture ThenApply(Org.Apache.Kafka.Common.KafkaFuture.BaseFunction arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.KafkaFuture>("thenApply", "(Lorg/apache/kafka/common/KafkaFuture$BaseFunction;)Lorg/apache/kafka/common/KafkaFuture;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/KafkaFuture.html#cancel-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Cancel(bool arg0)
        {
            return IExecuteWithSignature<bool>("cancel", "(Z)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/KafkaFuture.html#isCancelled--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCancelled()
        {
            return IExecuteWithSignature<bool>("isCancelled", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/KafkaFuture.html#isCompletedExceptionally--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCompletedExceptionally()
        {
            return IExecuteWithSignature<bool>("isCompletedExceptionally", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/KafkaFuture.html#isDone--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDone()
        {
            return IExecuteWithSignature<bool>("isDone", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/KafkaFuture.html#toCompletionStage--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
        public Java.Util.Concurrent.CompletionStage ToCompletionStage()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.CompletionStage>("toCompletionStage", "()Ljava/util/concurrent/CompletionStage;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/KafkaFuture.html#whenComplete-org.apache.kafka.common.KafkaFuture.BiConsumer-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.KafkaFuture.BiConsumer"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.KafkaFuture"/></returns>
        public Org.Apache.Kafka.Common.KafkaFuture WhenComplete(Org.Apache.Kafka.Common.KafkaFuture.BiConsumer arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.KafkaFuture>("whenComplete", "(Lorg/apache/kafka/common/KafkaFuture$BiConsumer;)Lorg/apache/kafka/common/KafkaFuture;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/KafkaFuture.html#get--"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        /// <exception cref="Java.Util.Concurrent.ExecutionException"/>
        public object Get()
        {
            return IExecuteWithSignature("get", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/KafkaFuture.html#get-long-java.util.concurrent.TimeUnit-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        /// <exception cref="Java.Util.Concurrent.ExecutionException"/>
        /// <exception cref="Java.Util.Concurrent.TimeoutException"/>
        public object Get(long arg0, Java.Util.Concurrent.TimeUnit arg1)
        {
            return IExecute("get", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/KafkaFuture.html#getNow-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        /// <exception cref="Java.Util.Concurrent.ExecutionException"/>
        public object GetNow(object arg0)
        {
            return IExecuteWithSignature("getNow", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }

        #endregion

        #region Nested classes
        #region BaseFunction
        public partial class BaseFunction
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/KafkaFuture.BaseFunction.html#apply-java.lang.Object-"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <returns><see cref="object"/></returns>
            public object Apply(object arg0)
            {
                return IExecuteWithSignature("apply", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region BaseFunction<A, B>
        public partial class BaseFunction<A, B>
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Org.Apache.Kafka.Common.KafkaFuture.BaseFunction{A, B}"/> to <see cref="Org.Apache.Kafka.Common.KafkaFuture.BaseFunction"/>
            /// </summary>
            public static implicit operator Org.Apache.Kafka.Common.KafkaFuture.BaseFunction(Org.Apache.Kafka.Common.KafkaFuture.BaseFunction<A, B> t) => t.Cast<Org.Apache.Kafka.Common.KafkaFuture.BaseFunction>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/KafkaFuture.BaseFunction.html#apply-java.lang.Object-"/>
            /// </summary>
            /// <param name="arg0"><typeparamref name="A"/></param>
            /// <returns><typeparamref name="B"/></returns>
            public B Apply(A arg0)
            {
                return IExecuteWithSignature<B>("apply", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region BiConsumer
        public partial class BiConsumer
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/KafkaFuture.BiConsumer.html#accept-java.lang.Object-java.lang.Object-"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <param name="arg1"><see cref="object"/></param>
            public void Accept(object arg0, object arg1)
            {
                IExecute("accept", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region BiConsumer<A, B>
        public partial class BiConsumer<A, B>
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Org.Apache.Kafka.Common.KafkaFuture.BiConsumer{A, B}"/> to <see cref="Org.Apache.Kafka.Common.KafkaFuture.BiConsumer"/>
            /// </summary>
            public static implicit operator Org.Apache.Kafka.Common.KafkaFuture.BiConsumer(Org.Apache.Kafka.Common.KafkaFuture.BiConsumer<A, B> t) => t.Cast<Org.Apache.Kafka.Common.KafkaFuture.BiConsumer>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/KafkaFuture.BiConsumer.html#accept-java.lang.Object-java.lang.Object-"/>
            /// </summary>
            /// <param name="arg0"><typeparamref name="A"/></param>
            /// <param name="arg1"><typeparamref name="B"/></param>
            public void Accept(A arg0, B arg1)
            {
                IExecute("accept", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion

    #region KafkaFuture<T>
    public partial class KafkaFuture<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Common.KafkaFuture{T}"/> to <see cref="Org.Apache.Kafka.Common.KafkaFuture"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.KafkaFuture(Org.Apache.Kafka.Common.KafkaFuture<T> t) => t.Cast<Org.Apache.Kafka.Common.KafkaFuture>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/KafkaFuture.html#completedFuture-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="U"/></param>
        /// <typeparam name="U"></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Common.KafkaFuture"/></returns>
        public static Org.Apache.Kafka.Common.KafkaFuture<U> CompletedFuture<U>(U arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.KafkaFuture<U>>(LocalBridgeClazz, "completedFuture", "(Ljava/lang/Object;)Lorg/apache/kafka/common/KafkaFuture;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/KafkaFuture.html#allOf-org.apache.kafka.common.KafkaFuture[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.KafkaFuture"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.KafkaFuture"/></returns>
        public static Org.Apache.Kafka.Common.KafkaFuture<Java.Lang.Void> AllOf(params Org.Apache.Kafka.Common.KafkaFuture<object>[] arg0)
        {
            if (arg0.Length == 0) return SExecuteWithSignature<Org.Apache.Kafka.Common.KafkaFuture<Java.Lang.Void>>(LocalBridgeClazz, "allOf", "([Lorg/apache/kafka/common/KafkaFuture;)Lorg/apache/kafka/common/KafkaFuture;"); else return SExecuteWithSignature<Org.Apache.Kafka.Common.KafkaFuture<Java.Lang.Void>>(LocalBridgeClazz, "allOf", "([Lorg/apache/kafka/common/KafkaFuture;)Lorg/apache/kafka/common/KafkaFuture;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/KafkaFuture.html#thenApply-org.apache.kafka.common.KafkaFuture.BaseFunction-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.KafkaFuture.BaseFunction"/></param>
        /// <typeparam name="R"></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Common.KafkaFuture"/></returns>
        public Org.Apache.Kafka.Common.KafkaFuture<R> ThenApply<R>(Org.Apache.Kafka.Common.KafkaFuture.BaseFunction<T, R> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.KafkaFuture<R>>("thenApply", "(Lorg/apache/kafka/common/KafkaFuture$BaseFunction;)Lorg/apache/kafka/common/KafkaFuture;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/KafkaFuture.html#cancel-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Cancel(bool arg0)
        {
            return IExecuteWithSignature<bool>("cancel", "(Z)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/KafkaFuture.html#isCancelled--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCancelled()
        {
            return IExecuteWithSignature<bool>("isCancelled", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/KafkaFuture.html#isCompletedExceptionally--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCompletedExceptionally()
        {
            return IExecuteWithSignature<bool>("isCompletedExceptionally", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/KafkaFuture.html#isDone--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDone()
        {
            return IExecuteWithSignature<bool>("isDone", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/KafkaFuture.html#toCompletionStage--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.CompletionStage"/></returns>
        public Java.Util.Concurrent.CompletionStage<T> ToCompletionStage()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.CompletionStage<T>>("toCompletionStage", "()Ljava/util/concurrent/CompletionStage;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/KafkaFuture.html#whenComplete-org.apache.kafka.common.KafkaFuture.BiConsumer-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.KafkaFuture.BiConsumer"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <typeparam name="Arg0objectSuperJava_Lang_Throwable"><see cref="Java.Lang.Throwable"/></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Common.KafkaFuture"/></returns>
        public Org.Apache.Kafka.Common.KafkaFuture<T> WhenComplete<Arg0objectSuperT, Arg0objectSuperJava_Lang_Throwable>(Org.Apache.Kafka.Common.KafkaFuture.BiConsumer<Arg0objectSuperT, Arg0objectSuperJava_Lang_Throwable> arg0) where Arg0objectSuperT: T where Arg0objectSuperJava_Lang_Throwable: Java.Lang.Throwable
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.KafkaFuture<T>>("whenComplete", "(Lorg/apache/kafka/common/KafkaFuture$BiConsumer;)Lorg/apache/kafka/common/KafkaFuture;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/KafkaFuture.html#get--"/>
        /// </summary>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        /// <exception cref="Java.Util.Concurrent.ExecutionException"/>
        public T Get()
        {
            return IExecuteWithSignature<T>("get", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/KafkaFuture.html#get-long-java.util.concurrent.TimeUnit-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        /// <exception cref="Java.Util.Concurrent.ExecutionException"/>
        /// <exception cref="Java.Util.Concurrent.TimeoutException"/>
        public T Get(long arg0, Java.Util.Concurrent.TimeUnit arg1)
        {
            return IExecute<T>("get", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/KafkaFuture.html#getNow-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        /// <exception cref="Java.Util.Concurrent.ExecutionException"/>
        public T GetNow(T arg0)
        {
            return IExecuteWithSignature<T>("getNow", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}