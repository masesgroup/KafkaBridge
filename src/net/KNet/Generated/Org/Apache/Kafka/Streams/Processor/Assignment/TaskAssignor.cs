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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using kafka-streams-3.9.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Processor.Assignment
{
    #region TaskAssignor declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/assignment/TaskAssignor.html"/>
    /// </summary>
    public partial class TaskAssignor : Org.Apache.Kafka.Common.Configurable
    {
        const string _bridgeClassName = "org.apache.kafka.streams.processor.assignment.TaskAssignor";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("TaskAssignor class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public TaskAssignor() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("TaskAssignor class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public TaskAssignor(params object[] args) : base(args) { }

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
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class
        #region AssignmentError declaration
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/assignment/TaskAssignor.AssignmentError.html"/>
        /// </summary>
        public partial class AssignmentError : Java.Lang.Enum<Org.Apache.Kafka.Streams.Processor.Assignment.TaskAssignor.AssignmentError>
        {
            const string _bridgeClassName = "org.apache.kafka.streams.processor.assignment.TaskAssignor$AssignmentError";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public AssignmentError() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public AssignmentError(params object[] args) : base(args) { }

            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => false;
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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

        #region TaskAssignment declaration
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/assignment/TaskAssignor.TaskAssignment.html"/>
        /// </summary>
        public partial class TaskAssignment : MASES.JCOBridge.C2JBridge.JVMBridgeBase<TaskAssignment>
        {
            const string _bridgeClassName = "org.apache.kafka.streams.processor.assignment.TaskAssignor$TaskAssignment";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public TaskAssignment() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public TaskAssignment(params object[] args) : base(args) { }

            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => false;
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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region ITaskAssignor
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ITaskAssignor : Org.Apache.Kafka.Common.IConfigurable
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TaskAssignor implementation
    public partial class TaskAssignor : Org.Apache.Kafka.Streams.Processor.Assignment.ITaskAssignor
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/assignment/TaskAssignor.html#assign-org.apache.kafka.streams.processor.assignment.ApplicationState-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Assignment.ApplicationState"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.Assignment.TaskAssignor.TaskAssignment"/></returns>
        public Org.Apache.Kafka.Streams.Processor.Assignment.TaskAssignor.TaskAssignment Assign(Org.Apache.Kafka.Streams.Processor.Assignment.ApplicationState arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Processor.Assignment.TaskAssignor.TaskAssignment>("assign", "(Lorg/apache/kafka/streams/processor/assignment/ApplicationState;)Lorg/apache/kafka/streams/processor/assignment/TaskAssignor$TaskAssignment;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/assignment/TaskAssignor.html#configure-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public void Configure(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            IExecuteWithSignature("configure", "(Ljava/util/Map;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/assignment/TaskAssignor.html#onAssignmentComputed-org.apache.kafka.clients.consumer.ConsumerPartitionAssignor.GroupAssignment-org.apache.kafka.clients.consumer.ConsumerPartitionAssignor.GroupSubscription-org.apache.kafka.streams.processor.assignment.TaskAssignor.AssignmentError-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.GroupAssignment"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.GroupSubscription"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Processor.Assignment.TaskAssignor.AssignmentError"/></param>
        public void OnAssignmentComputed(Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.GroupAssignment arg0, Org.Apache.Kafka.Clients.Consumer.ConsumerPartitionAssignor.GroupSubscription arg1, Org.Apache.Kafka.Streams.Processor.Assignment.TaskAssignor.AssignmentError arg2)
        {
            IExecuteWithSignature("onAssignmentComputed", "(Lorg/apache/kafka/clients/consumer/ConsumerPartitionAssignor$GroupAssignment;Lorg/apache/kafka/clients/consumer/ConsumerPartitionAssignor$GroupSubscription;Lorg/apache/kafka/streams/processor/assignment/TaskAssignor$AssignmentError;)V", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes
        #region AssignmentError implementation
        public partial class AssignmentError
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/assignment/TaskAssignor.AssignmentError.html#ACTIVE_TASK_ASSIGNED_MULTIPLE_TIMES"/>
            /// </summary>
            public static Org.Apache.Kafka.Streams.Processor.Assignment.TaskAssignor.AssignmentError ACTIVE_TASK_ASSIGNED_MULTIPLE_TIMES { get { if (!_ACTIVE_TASK_ASSIGNED_MULTIPLE_TIMESReady) { _ACTIVE_TASK_ASSIGNED_MULTIPLE_TIMESContent = SGetField<Org.Apache.Kafka.Streams.Processor.Assignment.TaskAssignor.AssignmentError>(LocalBridgeClazz, "ACTIVE_TASK_ASSIGNED_MULTIPLE_TIMES"); _ACTIVE_TASK_ASSIGNED_MULTIPLE_TIMESReady = true; } return _ACTIVE_TASK_ASSIGNED_MULTIPLE_TIMESContent; } }
            private static Org.Apache.Kafka.Streams.Processor.Assignment.TaskAssignor.AssignmentError _ACTIVE_TASK_ASSIGNED_MULTIPLE_TIMESContent = default;
            private static bool _ACTIVE_TASK_ASSIGNED_MULTIPLE_TIMESReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/assignment/TaskAssignor.AssignmentError.html#INVALID_STANDBY_TASK"/>
            /// </summary>
            public static Org.Apache.Kafka.Streams.Processor.Assignment.TaskAssignor.AssignmentError INVALID_STANDBY_TASK { get { if (!_INVALID_STANDBY_TASKReady) { _INVALID_STANDBY_TASKContent = SGetField<Org.Apache.Kafka.Streams.Processor.Assignment.TaskAssignor.AssignmentError>(LocalBridgeClazz, "INVALID_STANDBY_TASK"); _INVALID_STANDBY_TASKReady = true; } return _INVALID_STANDBY_TASKContent; } }
            private static Org.Apache.Kafka.Streams.Processor.Assignment.TaskAssignor.AssignmentError _INVALID_STANDBY_TASKContent = default;
            private static bool _INVALID_STANDBY_TASKReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/assignment/TaskAssignor.AssignmentError.html#MISSING_PROCESS_ID"/>
            /// </summary>
            public static Org.Apache.Kafka.Streams.Processor.Assignment.TaskAssignor.AssignmentError MISSING_PROCESS_ID { get { if (!_MISSING_PROCESS_IDReady) { _MISSING_PROCESS_IDContent = SGetField<Org.Apache.Kafka.Streams.Processor.Assignment.TaskAssignor.AssignmentError>(LocalBridgeClazz, "MISSING_PROCESS_ID"); _MISSING_PROCESS_IDReady = true; } return _MISSING_PROCESS_IDContent; } }
            private static Org.Apache.Kafka.Streams.Processor.Assignment.TaskAssignor.AssignmentError _MISSING_PROCESS_IDContent = default;
            private static bool _MISSING_PROCESS_IDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/assignment/TaskAssignor.AssignmentError.html#NONE"/>
            /// </summary>
            public static Org.Apache.Kafka.Streams.Processor.Assignment.TaskAssignor.AssignmentError NONE { get { if (!_NONEReady) { _NONEContent = SGetField<Org.Apache.Kafka.Streams.Processor.Assignment.TaskAssignor.AssignmentError>(LocalBridgeClazz, "NONE"); _NONEReady = true; } return _NONEContent; } }
            private static Org.Apache.Kafka.Streams.Processor.Assignment.TaskAssignor.AssignmentError _NONEContent = default;
            private static bool _NONEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/assignment/TaskAssignor.AssignmentError.html#UNKNOWN_PROCESS_ID"/>
            /// </summary>
            public static Org.Apache.Kafka.Streams.Processor.Assignment.TaskAssignor.AssignmentError UNKNOWN_PROCESS_ID { get { if (!_UNKNOWN_PROCESS_IDReady) { _UNKNOWN_PROCESS_IDContent = SGetField<Org.Apache.Kafka.Streams.Processor.Assignment.TaskAssignor.AssignmentError>(LocalBridgeClazz, "UNKNOWN_PROCESS_ID"); _UNKNOWN_PROCESS_IDReady = true; } return _UNKNOWN_PROCESS_IDContent; } }
            private static Org.Apache.Kafka.Streams.Processor.Assignment.TaskAssignor.AssignmentError _UNKNOWN_PROCESS_IDContent = default;
            private static bool _UNKNOWN_PROCESS_IDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/assignment/TaskAssignor.AssignmentError.html#UNKNOWN_TASK_ID"/>
            /// </summary>
            public static Org.Apache.Kafka.Streams.Processor.Assignment.TaskAssignor.AssignmentError UNKNOWN_TASK_ID { get { if (!_UNKNOWN_TASK_IDReady) { _UNKNOWN_TASK_IDContent = SGetField<Org.Apache.Kafka.Streams.Processor.Assignment.TaskAssignor.AssignmentError>(LocalBridgeClazz, "UNKNOWN_TASK_ID"); _UNKNOWN_TASK_IDReady = true; } return _UNKNOWN_TASK_IDContent; } }
            private static Org.Apache.Kafka.Streams.Processor.Assignment.TaskAssignor.AssignmentError _UNKNOWN_TASK_IDContent = default;
            private static bool _UNKNOWN_TASK_IDReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/assignment/TaskAssignor.AssignmentError.html#valueOf-java.lang.String-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.Assignment.TaskAssignor.AssignmentError"/></returns>
            public static Org.Apache.Kafka.Streams.Processor.Assignment.TaskAssignor.AssignmentError ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Org.Apache.Kafka.Streams.Processor.Assignment.TaskAssignor.AssignmentError>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/streams/processor/assignment/TaskAssignor$AssignmentError;", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/assignment/TaskAssignor.AssignmentError.html#values--"/>
            /// </summary>
            /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.Assignment.TaskAssignor.AssignmentError"/></returns>
            public static Org.Apache.Kafka.Streams.Processor.Assignment.TaskAssignor.AssignmentError[] Values()
            {
                return SExecuteWithSignatureArray<Org.Apache.Kafka.Streams.Processor.Assignment.TaskAssignor.AssignmentError>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/streams/processor/assignment/TaskAssignor$AssignmentError;");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region TaskAssignment implementation
        public partial class TaskAssignment
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/assignment/TaskAssignor.TaskAssignment.html#org.apache.kafka.streams.processor.assignment.TaskAssignor$TaskAssignment(java.util.Collection)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
            public TaskAssignment(Java.Util.Collection<Org.Apache.Kafka.Streams.Processor.Assignment.KafkaStreamsAssignment> arg0)
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/assignment/TaskAssignor.TaskAssignment.html#assignment--"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Collection"/></returns>
            public Java.Util.Collection<Org.Apache.Kafka.Streams.Processor.Assignment.KafkaStreamsAssignment> Assignment()
            {
                return IExecuteWithSignature<Java.Util.Collection<Org.Apache.Kafka.Streams.Processor.Assignment.KafkaStreamsAssignment>>("assignment", "()Ljava/util/Collection;");
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