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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using kafka-streams-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Processor
{
    #region IStateRestoreListener
    /// <summary>
    /// .NET interface for org.mases.knet.generated.org.apache.kafka.streams.processor.StateRestoreListener implementing <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/StateRestoreListener.html"/>
    /// </summary>
    public partial interface IStateRestoreListener
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region StateRestoreListener
    public partial class StateRestoreListener : Org.Apache.Kafka.Streams.Processor.IStateRestoreListener
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
        /// Handlers initializer for <see cref="StateRestoreListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("onBatchRestored", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Common.TopicPartition>>>(OnBatchRestoredEventHandler));
            AddEventHandler("onRestoreEnd", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Common.TopicPartition>>>(OnRestoreEndEventHandler));
            AddEventHandler("onRestoreStart", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Common.TopicPartition>>>(OnRestoreStartEventHandler));
            AddEventHandler("onRestoreSuspended", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Common.TopicPartition>>>(OnRestoreSuspendedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/StateRestoreListener.html#onBatchRestored-org.apache.kafka.common.TopicPartition-java.lang.String-long-long-"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnBatchRestored"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Org.Apache.Kafka.Common.TopicPartition, Java.Lang.String, long, long> OnOnBatchRestored { get; set; } = null;

        void OnBatchRestoredEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Common.TopicPartition>> data)
        {
            var methodToExecute = (OnOnBatchRestored != null) ? OnOnBatchRestored : OnBatchRestored;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Java.Lang.String>(0), data.EventData.GetAt<long>(1), data.EventData.GetAt<long>(2));
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/StateRestoreListener.html#onBatchRestored-org.apache.kafka.common.TopicPartition-java.lang.String-long-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        public virtual void OnBatchRestored(Org.Apache.Kafka.Common.TopicPartition arg0, Java.Lang.String arg1, long arg2, long arg3)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/StateRestoreListener.html#onRestoreEnd-org.apache.kafka.common.TopicPartition-java.lang.String-long-"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnRestoreEnd"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Org.Apache.Kafka.Common.TopicPartition, Java.Lang.String, long> OnOnRestoreEnd { get; set; } = null;

        void OnRestoreEndEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Common.TopicPartition>> data)
        {
            var methodToExecute = (OnOnRestoreEnd != null) ? OnOnRestoreEnd : OnRestoreEnd;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Java.Lang.String>(0), data.EventData.GetAt<long>(1));
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/StateRestoreListener.html#onRestoreEnd-org.apache.kafka.common.TopicPartition-java.lang.String-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public virtual void OnRestoreEnd(Org.Apache.Kafka.Common.TopicPartition arg0, Java.Lang.String arg1, long arg2)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/StateRestoreListener.html#onRestoreStart-org.apache.kafka.common.TopicPartition-java.lang.String-long-long-"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnRestoreStart"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Org.Apache.Kafka.Common.TopicPartition, Java.Lang.String, long, long> OnOnRestoreStart { get; set; } = null;

        void OnRestoreStartEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Common.TopicPartition>> data)
        {
            var methodToExecute = (OnOnRestoreStart != null) ? OnOnRestoreStart : OnRestoreStart;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Java.Lang.String>(0), data.EventData.GetAt<long>(1), data.EventData.GetAt<long>(2));
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/StateRestoreListener.html#onRestoreStart-org.apache.kafka.common.TopicPartition-java.lang.String-long-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        public virtual void OnRestoreStart(Org.Apache.Kafka.Common.TopicPartition arg0, Java.Lang.String arg1, long arg2, long arg3)
        {
            
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/StateRestoreListener.html#onRestoreSuspended-org.apache.kafka.common.TopicPartition-java.lang.String-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void OnRestoreSuspendedDefault(Org.Apache.Kafka.Common.TopicPartition arg0, Java.Lang.String arg1, long arg2)
        {
            IExecute("onRestoreSuspendedDefault", arg0, arg1, arg2);
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/StateRestoreListener.html#onRestoreSuspended-org.apache.kafka.common.TopicPartition-java.lang.String-long-"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnRestoreSuspended"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Org.Apache.Kafka.Common.TopicPartition, Java.Lang.String, long> OnOnRestoreSuspended { get; set; } = null;

        void OnRestoreSuspendedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Common.TopicPartition>> data)
        {
            var methodToExecute = (OnOnRestoreSuspended != null) ? OnOnRestoreSuspended : OnRestoreSuspended;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Java.Lang.String>(0), data.EventData.GetAt<long>(1));
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/StateRestoreListener.html#onRestoreSuspended-org.apache.kafka.common.TopicPartition-java.lang.String-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="OnRestoreSuspendedDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void OnRestoreSuspended(Org.Apache.Kafka.Common.TopicPartition arg0, Java.Lang.String arg1, long arg2)
        {
            OnRestoreSuspendedDefault(arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region StateRestoreListenerDirect
    public partial class StateRestoreListenerDirect : Org.Apache.Kafka.Streams.Processor.IStateRestoreListener
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/StateRestoreListener.html#onBatchRestored-org.apache.kafka.common.TopicPartition-java.lang.String-long-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        public override void OnBatchRestored(Org.Apache.Kafka.Common.TopicPartition arg0, Java.Lang.String arg1, long arg2, long arg3)
        {
            IExecute("onBatchRestored", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/StateRestoreListener.html#onRestoreEnd-org.apache.kafka.common.TopicPartition-java.lang.String-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public override void OnRestoreEnd(Org.Apache.Kafka.Common.TopicPartition arg0, Java.Lang.String arg1, long arg2)
        {
            IExecute("onRestoreEnd", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/StateRestoreListener.html#onRestoreStart-org.apache.kafka.common.TopicPartition-java.lang.String-long-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        public override void OnRestoreStart(Org.Apache.Kafka.Common.TopicPartition arg0, Java.Lang.String arg1, long arg2, long arg3)
        {
            IExecute("onRestoreStart", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/processor/StateRestoreListener.html#onRestoreSuspended-org.apache.kafka.common.TopicPartition-java.lang.String-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public override void OnRestoreSuspended(Org.Apache.Kafka.Common.TopicPartition arg0, Java.Lang.String arg1, long arg2)
        {
            IExecute("onRestoreSuspended", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}