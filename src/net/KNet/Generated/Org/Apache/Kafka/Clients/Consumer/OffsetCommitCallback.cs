/*
*  Copyright 2023 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using kafka-clients-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Consumer
{
    #region IOffsetCommitCallback
    /// <summary>
    /// .NET interface for org.mases.knet.generated.org.apache.kafka.clients.consumer.OffsetCommitCallback implementing <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/consumer/OffsetCommitCallback.html"/>
    /// </summary>
    public partial interface IOffsetCommitCallback
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region OffsetCommitCallback
    public partial class OffsetCommitCallback : Org.Apache.Kafka.Clients.Consumer.IOffsetCommitCallback
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
        /// Handlers initializer for <see cref="OffsetCommitCallback"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("onComplete", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Clients.Consumer.OffsetAndMetadata>>>>(OnCompleteEventHandler)); OnOnComplete = OnComplete;

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/consumer/OffsetCommitCallback.html#onComplete(java.util.Map,java.lang.Exception)"/>
        /// </summary>
        public System.Action<Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Clients.Consumer.OffsetAndMetadata>, MASES.JCOBridge.C2JBridge.JVMBridgeException> OnOnComplete { get; set; }

        void OnCompleteEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Clients.Consumer.OffsetAndMetadata>>> data)
        {
            if (OnOnComplete != null) OnOnComplete.Invoke(data.EventData.TypedEventData, JVMBridgeException.New(data.EventData.ExtraData.Get(0) as MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject));
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/consumer/OffsetCommitCallback.html#onComplete(java.util.Map,java.lang.Exception)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Exception"/></param>
        public virtual void OnComplete(Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Clients.Consumer.OffsetAndMetadata> arg0, MASES.JCOBridge.C2JBridge.JVMBridgeException arg1)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}