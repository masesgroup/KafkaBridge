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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using kafka-streams-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Processor
{
    #region IBatchingStateRestoreCallback
    /// <summary>
    /// .NET interface for org.mases.knet.generated.org.apache.kafka.streams.processor.BatchingStateRestoreCallback implementing <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/BatchingStateRestoreCallback.html"/>
    /// </summary>
    public partial interface IBatchingStateRestoreCallback
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region BatchingStateRestoreCallback
    public partial class BatchingStateRestoreCallback : Org.Apache.Kafka.Streams.Processor.IBatchingStateRestoreCallback
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
        /// Handlers initializer for <see cref="BatchingStateRestoreCallback"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("restoreAll", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Collection<Org.Apache.Kafka.Streams.KeyValue<byte[], byte[]>>>>>(RestoreAllEventHandler));
            AddEventHandler("restore", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<byte[]>>>(RestoreEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/BatchingStateRestoreCallback.html#restoreAll-java.util.Collection-"/>
        /// </summary>
        /// <remarks>If <see cref="OnRestoreAll"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Util.Collection<Org.Apache.Kafka.Streams.KeyValue<byte[], byte[]>>> OnRestoreAll { get; set; } = null;

        void RestoreAllEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Collection<Org.Apache.Kafka.Streams.KeyValue<byte[], byte[]>>>> data)
        {
            var methodToExecute = (OnRestoreAll != null) ? OnRestoreAll : RestoreAll;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/BatchingStateRestoreCallback.html#restoreAll-java.util.Collection-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public virtual void RestoreAll(Java.Util.Collection<Org.Apache.Kafka.Streams.KeyValue<byte[], byte[]>> arg0)
        {
            
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/BatchingStateRestoreCallback.html#restore-byte[]-byte[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void RestoreDefault(byte[] arg0, byte[] arg1)
        {
            IExecute("restoreDefault", arg0, arg1);
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/BatchingStateRestoreCallback.html#restore-byte[]-byte[]-"/>
        /// </summary>
        /// <remarks>If <see cref="OnRestore"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<byte[], byte[]> OnRestore { get; set; } = null;

        void RestoreEventHandler(object sender, CLRListenerEventArgs<CLREventData<byte[]>> data)
        {
            var methodToExecute = (OnRestore != null) ? OnRestore : Restore;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<byte[]>(0));
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/BatchingStateRestoreCallback.html#restore-byte[]-byte[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="RestoreDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void Restore(byte[] arg0, byte[] arg1)
        {
            RestoreDefault(arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region BatchingStateRestoreCallbackDirect
    public partial class BatchingStateRestoreCallbackDirect : Org.Apache.Kafka.Streams.Processor.IBatchingStateRestoreCallback
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/BatchingStateRestoreCallback.html#restoreAll-java.util.Collection-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public override void RestoreAll(Java.Util.Collection<Org.Apache.Kafka.Streams.KeyValue<byte[], byte[]>> arg0)
        {
            IExecuteWithSignature("restoreAll", "(Ljava/util/Collection;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/BatchingStateRestoreCallback.html#restore-byte[]-byte[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        public override void Restore(byte[] arg0, byte[] arg1)
        {
            IExecute("restore", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}