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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using kafka-clients-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Utils
{
    #region ITime
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ITime
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Time
    public partial class Time : Org.Apache.Kafka.Common.Utils.ITime
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/utils/Time.html#SYSTEM"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Utils.Time SYSTEM { get { if (!_SYSTEMReady) { _SYSTEMContent = SGetField<Org.Apache.Kafka.Common.Utils.Time>(LocalBridgeClazz, "SYSTEM"); _SYSTEMReady = true; } return _SYSTEMContent; } }
        private static Org.Apache.Kafka.Common.Utils.Time _SYSTEMContent = default;
        private static bool _SYSTEMReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/utils/Time.html#milliseconds--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long Milliseconds()
        {
            return IExecuteWithSignature<long>("milliseconds", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/utils/Time.html#nanoseconds--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long Nanoseconds()
        {
            return IExecuteWithSignature<long>("nanoseconds", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/utils/Time.html#sleep-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void Sleep(long arg0)
        {
            IExecuteWithSignature("sleep", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/utils/Time.html#waitObject-java.lang.Object-java.util.function.Supplier-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Supplier"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public void WaitObject(object arg0, Java.Util.Function.Supplier<Java.Lang.Boolean> arg1, long arg2)
        {
            IExecute("waitObject", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/utils/Time.html#waitForFuture-java.util.concurrent.CompletableFuture-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.CompletableFuture"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Java.Util.Concurrent.TimeoutException"/>
        /// <exception cref="Java.Lang.InterruptedException"/>
        /// <exception cref="Java.Util.Concurrent.ExecutionException"/>
        public T WaitForFuture<T>(Java.Util.Concurrent.CompletableFuture<T> arg0, long arg1)
        {
            return IExecute<T>("waitForFuture", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/utils/Time.html#hiResClockMs--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long HiResClockMs()
        {
            return IExecuteWithSignature<long>("hiResClockMs", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/utils/Time.html#timer-java.time.Duration-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Duration"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Utils.Timer"/></returns>
        public Org.Apache.Kafka.Common.Utils.Timer Timer(Java.Time.Duration arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Utils.Timer>("timer", "(Ljava/time/Duration;)Lorg/apache/kafka/common/utils/Timer;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/utils/Time.html#timer-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Utils.Timer"/></returns>
        public Org.Apache.Kafka.Common.Utils.Timer Timer(long arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Utils.Timer>("timer", "(J)Lorg/apache/kafka/common/utils/Timer;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}