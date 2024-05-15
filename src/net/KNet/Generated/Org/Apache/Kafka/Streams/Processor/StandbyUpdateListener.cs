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
*  using kafka-streams-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Processor
{
    #region IStandbyUpdateListener
    /// <summary>
    /// .NET interface for org.mases.knet.generated.org.apache.kafka.streams.processor.StandbyUpdateListener implementing <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/StandbyUpdateListener.html"/>
    /// </summary>
    public partial interface IStandbyUpdateListener
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region StandbyUpdateListener
    public partial class StandbyUpdateListener : Org.Apache.Kafka.Streams.Processor.IStandbyUpdateListener
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
        /// Handlers initializer for <see cref="StandbyUpdateListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("onBatchLoaded", new System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Common.TopicPartition>>>(OnBatchLoadedEventHandler));
            AddEventHandler("onUpdateStart", new System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Common.TopicPartition>>>(OnUpdateStartEventHandler));
            AddEventHandler("onUpdateSuspended", new System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Common.TopicPartition>>>(OnUpdateSuspendedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/StandbyUpdateListener.html#onBatchLoaded-org.apache.kafka.common.TopicPartition-java.lang.String-org.apache.kafka.streams.processor.TaskId-long-long-long-"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnBatchLoaded"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Org.Apache.Kafka.Common.TopicPartition, Java.Lang.String, Org.Apache.Kafka.Streams.Processor.TaskId, long, long, long> OnOnBatchLoaded { get; set; } = null;

        void OnBatchLoadedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Common.TopicPartition>> data)
        {
            var methodToExecute = (OnOnBatchLoaded != null) ? OnOnBatchLoaded : OnBatchLoaded;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Java.Lang.String>(0), data.EventData.GetAt<Org.Apache.Kafka.Streams.Processor.TaskId>(1), data.EventData.GetAt<long>(2), data.EventData.GetAt<long>(3), data.EventData.GetAt<long>(4));
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/StandbyUpdateListener.html#onBatchLoaded-org.apache.kafka.common.TopicPartition-java.lang.String-org.apache.kafka.streams.processor.TaskId-long-long-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Processor.TaskId"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        /// <param name="arg5"><see cref="long"/></param>
        public virtual void OnBatchLoaded(Org.Apache.Kafka.Common.TopicPartition arg0, Java.Lang.String arg1, Org.Apache.Kafka.Streams.Processor.TaskId arg2, long arg3, long arg4, long arg5)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/StandbyUpdateListener.html#onUpdateStart-org.apache.kafka.common.TopicPartition-java.lang.String-long-"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnUpdateStart"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Org.Apache.Kafka.Common.TopicPartition, Java.Lang.String, long> OnOnUpdateStart { get; set; } = null;

        void OnUpdateStartEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Common.TopicPartition>> data)
        {
            var methodToExecute = (OnOnUpdateStart != null) ? OnOnUpdateStart : OnUpdateStart;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Java.Lang.String>(0), data.EventData.GetAt<long>(1));
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/StandbyUpdateListener.html#onUpdateStart-org.apache.kafka.common.TopicPartition-java.lang.String-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public virtual void OnUpdateStart(Org.Apache.Kafka.Common.TopicPartition arg0, Java.Lang.String arg1, long arg2)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/StandbyUpdateListener.html#onUpdateSuspended-org.apache.kafka.common.TopicPartition-java.lang.String-long-long-org.apache.kafka.streams.processor.StandbyUpdateListener.SuspendReason-"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnUpdateSuspended"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Org.Apache.Kafka.Common.TopicPartition, Java.Lang.String, long, long, Org.Apache.Kafka.Streams.Processor.StandbyUpdateListener.SuspendReason> OnOnUpdateSuspended { get; set; } = null;

        void OnUpdateSuspendedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Common.TopicPartition>> data)
        {
            var methodToExecute = (OnOnUpdateSuspended != null) ? OnOnUpdateSuspended : OnUpdateSuspended;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Java.Lang.String>(0), data.EventData.GetAt<long>(1), data.EventData.GetAt<long>(2), data.EventData.GetAt<Org.Apache.Kafka.Streams.Processor.StandbyUpdateListener.SuspendReason>(3));
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/StandbyUpdateListener.html#onUpdateSuspended-org.apache.kafka.common.TopicPartition-java.lang.String-long-long-org.apache.kafka.streams.processor.StandbyUpdateListener.SuspendReason-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Streams.Processor.StandbyUpdateListener.SuspendReason"/></param>
        public virtual void OnUpdateSuspended(Org.Apache.Kafka.Common.TopicPartition arg0, Java.Lang.String arg1, long arg2, long arg3, Org.Apache.Kafka.Streams.Processor.StandbyUpdateListener.SuspendReason arg4)
        {
            
        }

        #endregion

        #region Nested classes
        #region SuspendReason
        public partial class SuspendReason
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/StandbyUpdateListener.SuspendReason.html#MIGRATED"/>
            /// </summary>
            public static Org.Apache.Kafka.Streams.Processor.StandbyUpdateListener.SuspendReason MIGRATED { get { if (!_MIGRATEDReady) { _MIGRATEDContent = SGetField<Org.Apache.Kafka.Streams.Processor.StandbyUpdateListener.SuspendReason>(LocalBridgeClazz, "MIGRATED"); _MIGRATEDReady = true; } return _MIGRATEDContent; } }
            private static Org.Apache.Kafka.Streams.Processor.StandbyUpdateListener.SuspendReason _MIGRATEDContent = default;
            private static bool _MIGRATEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/StandbyUpdateListener.SuspendReason.html#PROMOTED"/>
            /// </summary>
            public static Org.Apache.Kafka.Streams.Processor.StandbyUpdateListener.SuspendReason PROMOTED { get { if (!_PROMOTEDReady) { _PROMOTEDContent = SGetField<Org.Apache.Kafka.Streams.Processor.StandbyUpdateListener.SuspendReason>(LocalBridgeClazz, "PROMOTED"); _PROMOTEDReady = true; } return _PROMOTEDContent; } }
            private static Org.Apache.Kafka.Streams.Processor.StandbyUpdateListener.SuspendReason _PROMOTEDContent = default;
            private static bool _PROMOTEDReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/StandbyUpdateListener.SuspendReason.html#valueOf-java.lang.String-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.StandbyUpdateListener.SuspendReason"/></returns>
            public static Org.Apache.Kafka.Streams.Processor.StandbyUpdateListener.SuspendReason ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Org.Apache.Kafka.Streams.Processor.StandbyUpdateListener.SuspendReason>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/streams/processor/StandbyUpdateListener$SuspendReason;", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/processor/StandbyUpdateListener.SuspendReason.html#values--"/>
            /// </summary>

            /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.StandbyUpdateListener.SuspendReason"/></returns>
            public static Org.Apache.Kafka.Streams.Processor.StandbyUpdateListener.SuspendReason[] Values()
            {
                return SExecuteWithSignatureArray<Org.Apache.Kafka.Streams.Processor.StandbyUpdateListener.SuspendReason>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/streams/processor/StandbyUpdateListener$SuspendReason;");
            }

            #endregion

            #region Instance methods

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
}