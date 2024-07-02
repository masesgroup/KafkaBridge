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
*  using kafka-clients-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Consumer
{
    #region IConsumerPartitionAssignor
    /// <summary>
    /// .NET interface for org.mases.knet.generated.org.apache.kafka.clients.consumer.ConsumerPartitionAssignor implementing <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.html"/>
    /// </summary>
    public partial interface IConsumerPartitionAssignor
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ConsumerPartitionAssignor
    public partial class ConsumerPartitionAssignor : Org.Apache.Kafka.Clients.Consumer.IConsumerPartitionAssignor
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.html#getAssignorInstances-java.util.List-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static Java.Util.List<Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor> GetAssignorInstances(Java.Util.List<Java.Lang.String> arg0, Java.Util.Map<Java.Lang.String, object> arg1)
        {
            return SExecute<Java.Util.List<Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor>>(LocalBridgeClazz, "getAssignorInstances", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// Handlers initializer for <see cref="ConsumerPartitionAssignor"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("name", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(NameEventHandler));
            AddEventHandler("assign", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Common.Cluster>>>(AssignEventHandler));
            AddEventHandler("subscriptionUserData", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Set<Java.Lang.String>>>>(SubscriptionUserDataEventHandler));
            AddEventHandler("supportedProtocols", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(SupportedProtocolsEventHandler));
            AddEventHandler("version", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(VersionEventHandler));
            AddEventHandler("onAssignment", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.Assignment>>>(OnAssignmentEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.html#name--"/>
        /// </summary>
        /// <remarks>If <see cref="OnName"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Lang.String> OnName { get; set; } = null;

        void NameEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnName != null) ? OnName : Name;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.html#name--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public virtual Java.Lang.String Name()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.html#assign-org.apache.kafka.common.Cluster-org.apache.kafka.clients.consumer.ConsumerPartitionAssignor.GroupSubscription-"/>
        /// </summary>
        /// <remarks>If <see cref="OnAssign"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Org.Apache.Kafka.Common.Cluster, Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.GroupSubscription, Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.GroupAssignment> OnAssign { get; set; } = null;

        void AssignEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Common.Cluster>> data)
        {
            var methodToExecute = (OnAssign != null) ? OnAssign : Assign;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.GroupSubscription>(0));
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.html#assign-org.apache.kafka.common.Cluster-org.apache.kafka.clients.consumer.ConsumerPartitionAssignor.GroupSubscription-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Cluster"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.GroupSubscription"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.GroupAssignment"/></returns>
        public virtual Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.GroupAssignment Assign(Org.Apache.Kafka.Common.Cluster arg0, Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.GroupSubscription arg1)
        {
            return default;
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.html#subscriptionUserData-java.util.Set-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Nio.ByteBuffer SubscriptionUserDataDefault(Java.Util.Set<Java.Lang.String> arg0)
        {
            return IExecuteWithSignature<Java.Nio.ByteBuffer>("subscriptionUserDataDefault", "(Ljava/util/Set;)Ljava/nio/ByteBuffer;", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.html#subscriptionUserData-java.util.Set-"/>
        /// </summary>
        /// <remarks>If <see cref="OnSubscriptionUserData"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Set<Java.Lang.String>, Java.Nio.ByteBuffer> OnSubscriptionUserData { get; set; } = null;

        void SubscriptionUserDataEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Set<Java.Lang.String>>> data)
        {
            var methodToExecute = (OnSubscriptionUserData != null) ? OnSubscriptionUserData : SubscriptionUserData;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.html#subscriptionUserData-java.util.Set-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="SubscriptionUserDataDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Nio.ByteBuffer SubscriptionUserData(Java.Util.Set<Java.Lang.String> arg0)
        {
            return SubscriptionUserDataDefault(arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.html#supportedProtocols--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.List<Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.RebalanceProtocol> SupportedProtocolsDefault()
        {
            return IExecuteWithSignature<Java.Util.List<Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.RebalanceProtocol>>("supportedProtocolsDefault", "()Ljava/util/List;");
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.html#supportedProtocols--"/>
        /// </summary>
        /// <remarks>If <see cref="OnSupportedProtocols"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.List<Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.RebalanceProtocol>> OnSupportedProtocols { get; set; } = null;

        void SupportedProtocolsEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnSupportedProtocols != null) ? OnSupportedProtocols : SupportedProtocols;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.html#supportedProtocols--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="SupportedProtocolsDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.List<Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.RebalanceProtocol> SupportedProtocols()
        {
            return SupportedProtocolsDefault();
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.html#version--"/>
        /// </summary>
        /// <returns><see cref="short"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public short VersionDefault()
        {
            return IExecuteWithSignature<short>("versionDefault", "()S");
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.html#version--"/>
        /// </summary>
        /// <remarks>If <see cref="OnVersion"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<short> OnVersion { get; set; } = null;

        void VersionEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnVersion != null) ? OnVersion : Version;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.html#version--"/>
        /// </summary>
        /// <returns><see cref="short"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="VersionDefault"/>; override the method to implement a different behavior</remarks>
        public virtual short Version()
        {
            return VersionDefault();
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.html#onAssignment-org.apache.kafka.clients.consumer.ConsumerPartitionAssignor.Assignment-org.apache.kafka.clients.consumer.ConsumerGroupMetadata-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.Assignment"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerGroupMetadata"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void OnAssignmentDefault(Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.Assignment arg0, Org.Apache.Kafka.Clients.Consumer.ConsumerGroupMetadata arg1)
        {
            IExecute("onAssignmentDefault", arg0, arg1);
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.html#onAssignment-org.apache.kafka.clients.consumer.ConsumerPartitionAssignor.Assignment-org.apache.kafka.clients.consumer.ConsumerGroupMetadata-"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnAssignment"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.Assignment, Org.Apache.Kafka.Clients.Consumer.ConsumerGroupMetadata> OnOnAssignment { get; set; } = null;

        void OnAssignmentEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.Assignment>> data)
        {
            var methodToExecute = (OnOnAssignment != null) ? OnOnAssignment : OnAssignment;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Org.Apache.Kafka.Clients.Consumer.ConsumerGroupMetadata>(0));
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.html#onAssignment-org.apache.kafka.clients.consumer.ConsumerPartitionAssignor.Assignment-org.apache.kafka.clients.consumer.ConsumerGroupMetadata-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.Assignment"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerGroupMetadata"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="OnAssignmentDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void OnAssignment(Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.Assignment arg0, Org.Apache.Kafka.Clients.Consumer.ConsumerGroupMetadata arg1)
        {
            OnAssignmentDefault(arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Assignment
        public partial class Assignment
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.Assignment.html#org.apache.kafka.clients.consumer.ConsumerPartitionAssignor$Assignment(java.util.List,java.nio.ByteBuffer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
            public Assignment(Java.Util.List<Org.Apache.Kafka.Common.TopicPartition> arg0, Java.Nio.ByteBuffer arg1)
                : base(arg0, arg1)
            {
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.Assignment.html#org.apache.kafka.clients.consumer.ConsumerPartitionAssignor$Assignment(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            public Assignment(Java.Util.List<Org.Apache.Kafka.Common.TopicPartition> arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.Assignment.html#userData--"/>
            /// </summary>
            /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
            public Java.Nio.ByteBuffer UserData()
            {
                return IExecuteWithSignature<Java.Nio.ByteBuffer>("userData", "()Ljava/nio/ByteBuffer;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.Assignment.html#partitions--"/>
            /// </summary>
            /// <returns><see cref="Java.Util.List"/></returns>
            public Java.Util.List<Org.Apache.Kafka.Common.TopicPartition> Partitions()
            {
                return IExecuteWithSignature<Java.Util.List<Org.Apache.Kafka.Common.TopicPartition>>("partitions", "()Ljava/util/List;");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region GroupAssignment
        public partial class GroupAssignment
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.GroupAssignment.html#org.apache.kafka.clients.consumer.ConsumerPartitionAssignor$GroupAssignment(java.util.Map)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Map"/></param>
            public GroupAssignment(Java.Util.Map<Java.Lang.String, Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.Assignment> arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.GroupAssignment.html#groupAssignment--"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Map"/></returns>
            public Java.Util.Map<Java.Lang.String, Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.Assignment> GroupAssignmentMethod()
            {
                return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.Assignment>>("groupAssignment", "()Ljava/util/Map;");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region GroupSubscription
        public partial class GroupSubscription
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.GroupSubscription.html#org.apache.kafka.clients.consumer.ConsumerPartitionAssignor$GroupSubscription(java.util.Map)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Map"/></param>
            public GroupSubscription(Java.Util.Map<Java.Lang.String, Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.Subscription> arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.GroupSubscription.html#groupSubscription--"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Map"/></returns>
            public Java.Util.Map<Java.Lang.String, Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.Subscription> GroupSubscriptionMethod()
            {
                return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.Subscription>>("groupSubscription", "()Ljava/util/Map;");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region RebalanceProtocol
        public partial class RebalanceProtocol
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.RebalanceProtocol.html#COOPERATIVE"/>
            /// </summary>
            public static Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.RebalanceProtocol COOPERATIVE { get { if (!_COOPERATIVEReady) { _COOPERATIVEContent = SGetField<Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.RebalanceProtocol>(LocalBridgeClazz, "COOPERATIVE"); _COOPERATIVEReady = true; } return _COOPERATIVEContent; } }
            private static Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.RebalanceProtocol _COOPERATIVEContent = default;
            private static bool _COOPERATIVEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.RebalanceProtocol.html#EAGER"/>
            /// </summary>
            public static Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.RebalanceProtocol EAGER { get { if (!_EAGERReady) { _EAGERContent = SGetField<Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.RebalanceProtocol>(LocalBridgeClazz, "EAGER"); _EAGERReady = true; } return _EAGERContent; } }
            private static Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.RebalanceProtocol _EAGERContent = default;
            private static bool _EAGERReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.RebalanceProtocol.html#forId-byte-"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.RebalanceProtocol"/></returns>
            public static Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.RebalanceProtocol ForId(byte arg0)
            {
                return SExecuteWithSignature<Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.RebalanceProtocol>(LocalBridgeClazz, "forId", "(B)Lorg/apache/kafka/clients/consumer/ConsumerPartitionAssignor$RebalanceProtocol;", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.RebalanceProtocol.html#valueOf-java.lang.String-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.RebalanceProtocol"/></returns>
            public static Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.RebalanceProtocol ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.RebalanceProtocol>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/clients/consumer/ConsumerPartitionAssignor$RebalanceProtocol;", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.RebalanceProtocol.html#values--"/>
            /// </summary>
            /// <returns><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.RebalanceProtocol"/></returns>
            public static Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.RebalanceProtocol[] Values()
            {
                return SExecuteWithSignatureArray<Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.RebalanceProtocol>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/clients/consumer/ConsumerPartitionAssignor$RebalanceProtocol;");
            }

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.RebalanceProtocol.html#id--"/>
            /// </summary>
            /// <returns><see cref="byte"/></returns>
            public byte Id()
            {
                return IExecuteWithSignature<byte>("id", "()B");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Subscription
        public partial class Subscription
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.Subscription.html#org.apache.kafka.clients.consumer.ConsumerPartitionAssignor$Subscription(java.util.List,java.nio.ByteBuffer,java.util.List,int,java.util.Optional)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
            /// <param name="arg2"><see cref="Java.Util.List"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            /// <param name="arg4"><see cref="Java.Util.Optional"/></param>
            public Subscription(Java.Util.List<Java.Lang.String> arg0, Java.Nio.ByteBuffer arg1, Java.Util.List<Org.Apache.Kafka.Common.TopicPartition> arg2, int arg3, Java.Util.Optional<Java.Lang.String> arg4)
                : base(arg0, arg1, arg2, arg3, arg4)
            {
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.Subscription.html#org.apache.kafka.clients.consumer.ConsumerPartitionAssignor$Subscription(java.util.List,java.nio.ByteBuffer,java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
            /// <param name="arg2"><see cref="Java.Util.List"/></param>
            public Subscription(Java.Util.List<Java.Lang.String> arg0, Java.Nio.ByteBuffer arg1, Java.Util.List<Org.Apache.Kafka.Common.TopicPartition> arg2)
                : base(arg0, arg1, arg2)
            {
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.Subscription.html#org.apache.kafka.clients.consumer.ConsumerPartitionAssignor$Subscription(java.util.List,java.nio.ByteBuffer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
            public Subscription(Java.Util.List<Java.Lang.String> arg0, Java.Nio.ByteBuffer arg1)
                : base(arg0, arg1)
            {
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.Subscription.html#org.apache.kafka.clients.consumer.ConsumerPartitionAssignor$Subscription(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            public Subscription(Java.Util.List<Java.Lang.String> arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.Subscription.html#userData--"/>
            /// </summary>
            /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
            public Java.Nio.ByteBuffer UserData()
            {
                return IExecuteWithSignature<Java.Nio.ByteBuffer>("userData", "()Ljava/nio/ByteBuffer;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.Subscription.html#topics--"/>
            /// </summary>
            /// <returns><see cref="Java.Util.List"/></returns>
            public Java.Util.List<Java.Lang.String> Topics()
            {
                return IExecuteWithSignature<Java.Util.List<Java.Lang.String>>("topics", "()Ljava/util/List;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.Subscription.html#ownedPartitions--"/>
            /// </summary>
            /// <returns><see cref="Java.Util.List"/></returns>
            public Java.Util.List<Org.Apache.Kafka.Common.TopicPartition> OwnedPartitions()
            {
                return IExecuteWithSignature<Java.Util.List<Org.Apache.Kafka.Common.TopicPartition>>("ownedPartitions", "()Ljava/util/List;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.Subscription.html#generationId--"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Optional"/></returns>
            public Java.Util.Optional<Java.Lang.Integer> GenerationId()
            {
                return IExecuteWithSignature<Java.Util.Optional<Java.Lang.Integer>>("generationId", "()Ljava/util/Optional;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.Subscription.html#groupInstanceId--"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Optional"/></returns>
            public Java.Util.Optional<Java.Lang.String> GroupInstanceId()
            {
                return IExecuteWithSignature<Java.Util.Optional<Java.Lang.String>>("groupInstanceId", "()Ljava/util/Optional;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.Subscription.html#rackId--"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Optional"/></returns>
            public Java.Util.Optional<Java.Lang.String> RackId()
            {
                return IExecuteWithSignature<Java.Util.Optional<Java.Lang.String>>("rackId", "()Ljava/util/Optional;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.Subscription.html#setGroupInstanceId-java.util.Optional-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Optional"/></param>
            public void SetGroupInstanceId(Java.Util.Optional<Java.Lang.String> arg0)
            {
                IExecuteWithSignature("setGroupInstanceId", "(Ljava/util/Optional;)V", arg0);
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

    #region ConsumerPartitionAssignorDirect
    public partial class ConsumerPartitionAssignorDirect : Org.Apache.Kafka.Clients.Consumer.IConsumerPartitionAssignor
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.html#name--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public override Java.Lang.String Name()
        {
            return IExecuteWithSignature<Java.Lang.String>("name", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.html#assign-org.apache.kafka.common.Cluster-org.apache.kafka.clients.consumer.ConsumerPartitionAssignor.GroupSubscription-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Cluster"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.GroupSubscription"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.GroupAssignment"/></returns>
        public override Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.GroupAssignment Assign(Org.Apache.Kafka.Common.Cluster arg0, Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.GroupSubscription arg1)
        {
            return IExecute<Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.GroupAssignment>("assign", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.html#subscriptionUserData-java.util.Set-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public override Java.Nio.ByteBuffer SubscriptionUserData(Java.Util.Set<Java.Lang.String> arg0)
        {
            return IExecuteWithSignature<Java.Nio.ByteBuffer>("subscriptionUserData", "(Ljava/util/Set;)Ljava/nio/ByteBuffer;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.html#supportedProtocols--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public override Java.Util.List<Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.RebalanceProtocol> SupportedProtocols()
        {
            return IExecuteWithSignature<Java.Util.List<Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.RebalanceProtocol>>("supportedProtocols", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.html#version--"/>
        /// </summary>
        /// <returns><see cref="short"/></returns>
        public override short Version()
        {
            return IExecuteWithSignature<short>("version", "()S");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.html#onAssignment-org.apache.kafka.clients.consumer.ConsumerPartitionAssignor.Assignment-org.apache.kafka.clients.consumer.ConsumerGroupMetadata-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.Assignment"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerGroupMetadata"/></param>
        public override void OnAssignment(Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.Assignment arg0, Org.Apache.Kafka.Clients.Consumer.ConsumerGroupMetadata arg1)
        {
            IExecute("onAssignment", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}