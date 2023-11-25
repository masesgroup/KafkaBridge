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
*  This file is generated by MASES.JNetReflector (ver. 2.1.0.0)
*  using kafka-clients-3.6.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Consumer
{
    #region IConsumerPartitionAssignor
    /// <summary>
    /// .NET interface for org.mases.knet.generated.org.apache.kafka.clients.consumer.ConsumerPartitionAssignor implementing <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.html"/>
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

        #endregion

        #region Instance methods
        /// <summary>
        /// Handlers initializer for <see cref="ConsumerPartitionAssignor"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("name", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(NameEventHandler));
            AddEventHandler("assign", new System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Common.Cluster>>>(AssignEventHandler));
            AddEventHandler("subscriptionUserData", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Set<string>>>>(SubscriptionUserDataEventHandler));
            AddEventHandler("supportedProtocols", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(SupportedProtocolsEventHandler));
            AddEventHandler("version", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(VersionEventHandler));
            AddEventHandler("onAssignment", new System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.Assignment>>>(OnAssignmentEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.html#name--"/>
        /// </summary>
        /// <remarks>If <see cref="OnName"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<string> OnName { get; set; } = null;

        void NameEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnName != null) ? OnName : Name;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.html#name--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public virtual string Name()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.html#assign-org.apache.kafka.common.Cluster-org.apache.kafka.clients.consumer.ConsumerPartitionAssignor.GroupSubscription-"/>
        /// </summary>
        /// <remarks>If <see cref="OnAssign"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Org.Apache.Kafka.Common.Cluster, Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.GroupSubscription, Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.GroupAssignment> OnAssign { get; set; } = null;

        void AssignEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Common.Cluster>> data)
        {
            var methodToExecute = (OnAssign != null) ? OnAssign : Assign;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.GroupSubscription>(0));
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.html#assign-org.apache.kafka.common.Cluster-org.apache.kafka.clients.consumer.ConsumerPartitionAssignor.GroupSubscription-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Cluster"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.GroupSubscription"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.GroupAssignment"/></returns>
        public virtual Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.GroupAssignment Assign(Org.Apache.Kafka.Common.Cluster arg0, Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.GroupSubscription arg1)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.html#subscriptionUserData-java.util.Set-"/>
        /// </summary>
        /// <remarks>If <see cref="OnSubscriptionUserData"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Java.Util.Set<string>, Java.Nio.ByteBuffer> OnSubscriptionUserData { get; set; } = null;

        void SubscriptionUserDataEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Set<string>>> data)
        {
            var methodToExecute = (OnSubscriptionUserData != null) ? OnSubscriptionUserData : SubscriptionUserData;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.html#subscriptionUserData-java.util.Set-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public virtual Java.Nio.ByteBuffer SubscriptionUserData(Java.Util.Set<string> arg0)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.html#supportedProtocols--"/>
        /// </summary>
        /// <remarks>If <see cref="OnSupportedProtocols"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Java.Util.List<Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.RebalanceProtocol>> OnSupportedProtocols { get; set; } = null;

        void SupportedProtocolsEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnSupportedProtocols != null) ? OnSupportedProtocols : SupportedProtocols;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.html#supportedProtocols--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.List"/></returns>
        public virtual Java.Util.List<Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.RebalanceProtocol> SupportedProtocols()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.html#version--"/>
        /// </summary>
        /// <remarks>If <see cref="OnVersion"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<short> OnVersion { get; set; } = null;

        void VersionEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnVersion != null) ? OnVersion : Version;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.html#version--"/>
        /// </summary>

        /// <returns><see cref="short"/></returns>
        public virtual short Version()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.html#onAssignment-org.apache.kafka.clients.consumer.ConsumerPartitionAssignor.Assignment-org.apache.kafka.clients.consumer.ConsumerGroupMetadata-"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnAssignment"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.Assignment, Org.Apache.Kafka.Clients.Consumer.ConsumerGroupMetadata> OnOnAssignment { get; set; } = null;

        void OnAssignmentEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.Assignment>> data)
        {
            var methodToExecute = (OnOnAssignment != null) ? OnOnAssignment : OnAssignment;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Org.Apache.Kafka.Clients.Consumer.ConsumerGroupMetadata>(0));
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.html#onAssignment-org.apache.kafka.clients.consumer.ConsumerPartitionAssignor.Assignment-org.apache.kafka.clients.consumer.ConsumerGroupMetadata-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.Assignment"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerGroupMetadata"/></param>
        public virtual void OnAssignment(Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.Assignment arg0, Org.Apache.Kafka.Clients.Consumer.ConsumerGroupMetadata arg1)
        {
            
        }

        #endregion

        #region Nested classes
        #region Assignment
        public partial class Assignment
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.Assignment.html#org.apache.kafka.clients.consumer.ConsumerPartitionAssignor$Assignment(java.util.List,java.nio.ByteBuffer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
            public Assignment(Java.Util.List<Org.Apache.Kafka.Common.TopicPartition> arg0, Java.Nio.ByteBuffer arg1)
                : base(arg0, arg1)
            {
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.Assignment.html#org.apache.kafka.clients.consumer.ConsumerPartitionAssignor$Assignment(java.util.List)"/>
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.Assignment.html#userData--"/>
            /// </summary>

            /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
            public Java.Nio.ByteBuffer UserData()
            {
                return IExecute<Java.Nio.ByteBuffer>("userData");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.Assignment.html#partitions--"/>
            /// </summary>

            /// <returns><see cref="Java.Util.List"/></returns>
            public Java.Util.List<Org.Apache.Kafka.Common.TopicPartition> Partitions()
            {
                return IExecute<Java.Util.List<Org.Apache.Kafka.Common.TopicPartition>>("partitions");
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.GroupAssignment.html#org.apache.kafka.clients.consumer.ConsumerPartitionAssignor$GroupAssignment(java.util.Map)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Map"/></param>
            public GroupAssignment(Java.Util.Map<string, Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.Assignment> arg0)
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.GroupAssignment.html#groupAssignment--"/>
            /// </summary>

            /// <returns><see cref="Java.Util.Map"/></returns>
            public Java.Util.Map<string, Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.Assignment> GroupAssignmentMethod()
            {
                return IExecute<Java.Util.Map<string, Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.Assignment>>("groupAssignment");
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.GroupSubscription.html#org.apache.kafka.clients.consumer.ConsumerPartitionAssignor$GroupSubscription(java.util.Map)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Map"/></param>
            public GroupSubscription(Java.Util.Map<string, Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.Subscription> arg0)
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.GroupSubscription.html#groupSubscription--"/>
            /// </summary>

            /// <returns><see cref="Java.Util.Map"/></returns>
            public Java.Util.Map<string, Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.Subscription> GroupSubscriptionMethod()
            {
                return IExecute<Java.Util.Map<string, Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.Subscription>>("groupSubscription");
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.RebalanceProtocol.html#COOPERATIVE"/>
            /// </summary>
            public static Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.RebalanceProtocol COOPERATIVE { get { return SGetField<Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.RebalanceProtocol>(LocalBridgeClazz, "COOPERATIVE"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.RebalanceProtocol.html#EAGER"/>
            /// </summary>
            public static Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.RebalanceProtocol EAGER { get { return SGetField<Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.RebalanceProtocol>(LocalBridgeClazz, "EAGER"); } }

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.RebalanceProtocol.html#forId-byte-"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.RebalanceProtocol"/></returns>
            public static Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.RebalanceProtocol ForId(byte arg0)
            {
                return SExecute<Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.RebalanceProtocol>(LocalBridgeClazz, "forId", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.RebalanceProtocol.html#valueOf-java.lang.String-"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.RebalanceProtocol"/></returns>
            public static Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.RebalanceProtocol ValueOf(string arg0)
            {
                return SExecute<Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.RebalanceProtocol>(LocalBridgeClazz, "valueOf", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.RebalanceProtocol.html#values--"/>
            /// </summary>

            /// <returns><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.RebalanceProtocol"/></returns>
            public static Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.RebalanceProtocol[] Values()
            {
                return SExecuteArray<Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.RebalanceProtocol>(LocalBridgeClazz, "values");
            }

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.RebalanceProtocol.html#id--"/>
            /// </summary>

            /// <returns><see cref="byte"/></returns>
            public byte Id()
            {
                return IExecute<byte>("id");
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.Subscription.html#org.apache.kafka.clients.consumer.ConsumerPartitionAssignor$Subscription(java.util.List,java.nio.ByteBuffer,java.util.List,int,java.util.Optional)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
            /// <param name="arg2"><see cref="Java.Util.List"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            /// <param name="arg4"><see cref="Java.Util.Optional"/></param>
            public Subscription(Java.Util.List<string> arg0, Java.Nio.ByteBuffer arg1, Java.Util.List<Org.Apache.Kafka.Common.TopicPartition> arg2, int arg3, Java.Util.Optional<string> arg4)
                : base(arg0, arg1, arg2, arg3, arg4)
            {
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.Subscription.html#org.apache.kafka.clients.consumer.ConsumerPartitionAssignor$Subscription(java.util.List,java.nio.ByteBuffer,java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
            /// <param name="arg2"><see cref="Java.Util.List"/></param>
            public Subscription(Java.Util.List<string> arg0, Java.Nio.ByteBuffer arg1, Java.Util.List<Org.Apache.Kafka.Common.TopicPartition> arg2)
                : base(arg0, arg1, arg2)
            {
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.Subscription.html#org.apache.kafka.clients.consumer.ConsumerPartitionAssignor$Subscription(java.util.List,java.nio.ByteBuffer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
            public Subscription(Java.Util.List<string> arg0, Java.Nio.ByteBuffer arg1)
                : base(arg0, arg1)
            {
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.Subscription.html#org.apache.kafka.clients.consumer.ConsumerPartitionAssignor$Subscription(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            public Subscription(Java.Util.List<string> arg0)
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.Subscription.html#userData--"/>
            /// </summary>

            /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
            public Java.Nio.ByteBuffer UserData()
            {
                return IExecute<Java.Nio.ByteBuffer>("userData");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.Subscription.html#topics--"/>
            /// </summary>

            /// <returns><see cref="Java.Util.List"/></returns>
            public Java.Util.List<string> Topics()
            {
                return IExecute<Java.Util.List<string>>("topics");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.Subscription.html#ownedPartitions--"/>
            /// </summary>

            /// <returns><see cref="Java.Util.List"/></returns>
            public Java.Util.List<Org.Apache.Kafka.Common.TopicPartition> OwnedPartitions()
            {
                return IExecute<Java.Util.List<Org.Apache.Kafka.Common.TopicPartition>>("ownedPartitions");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.Subscription.html#generationId--"/>
            /// </summary>

            /// <returns><see cref="Java.Util.Optional"/></returns>
            public Java.Util.Optional<Java.Lang.Integer> GenerationId()
            {
                return IExecute<Java.Util.Optional<Java.Lang.Integer>>("generationId");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.Subscription.html#groupInstanceId--"/>
            /// </summary>

            /// <returns><see cref="Java.Util.Optional"/></returns>
            public Java.Util.Optional<string> GroupInstanceId()
            {
                return IExecute<Java.Util.Optional<string>>("groupInstanceId");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.Subscription.html#rackId--"/>
            /// </summary>

            /// <returns><see cref="Java.Util.Optional"/></returns>
            public Java.Util.Optional<string> RackId()
            {
                return IExecute<Java.Util.Optional<string>>("rackId");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/consumer/ConsumerPartitionAssignor.Subscription.html#setGroupInstanceId-java.util.Optional-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Optional"/></param>
            public void SetGroupInstanceId(Java.Util.Optional<string> arg0)
            {
                IExecute("setGroupInstanceId", arg0);
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
}