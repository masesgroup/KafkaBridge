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
*  using kafka-streams-3.9.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Processor.Assignment.Assignors
{
    #region StickyTaskAssignor declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/assignment/assignors/StickyTaskAssignor.html"/>
    /// </summary>
    public partial class StickyTaskAssignor : Org.Apache.Kafka.Streams.Processor.Assignment.TaskAssignor
    {
        const string _bridgeClassName = "org.apache.kafka.streams.processor.assignment.assignors.StickyTaskAssignor";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public StickyTaskAssignor() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public StickyTaskAssignor(params object[] args) : base(args) { }

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
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region StickyTaskAssignor implementation
    public partial class StickyTaskAssignor
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/assignment/assignors/StickyTaskAssignor.html#org.apache.kafka.streams.processor.assignment.assignors.StickyTaskAssignor(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public StickyTaskAssignor(bool arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/assignment/assignors/StickyTaskAssignor.html#DEFAULT_STICKY_NON_OVERLAP_COST"/>
        /// </summary>
        public static int DEFAULT_STICKY_NON_OVERLAP_COST { get { if (!_DEFAULT_STICKY_NON_OVERLAP_COSTReady) { _DEFAULT_STICKY_NON_OVERLAP_COSTContent = SGetField<int>(LocalBridgeClazz, "DEFAULT_STICKY_NON_OVERLAP_COST"); _DEFAULT_STICKY_NON_OVERLAP_COSTReady = true; } return _DEFAULT_STICKY_NON_OVERLAP_COSTContent; } }
        private static int _DEFAULT_STICKY_NON_OVERLAP_COSTContent = default;
        private static bool _DEFAULT_STICKY_NON_OVERLAP_COSTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/assignment/assignors/StickyTaskAssignor.html#DEFAULT_STICKY_TRAFFIC_COST"/>
        /// </summary>
        public static int DEFAULT_STICKY_TRAFFIC_COST { get { if (!_DEFAULT_STICKY_TRAFFIC_COSTReady) { _DEFAULT_STICKY_TRAFFIC_COSTContent = SGetField<int>(LocalBridgeClazz, "DEFAULT_STICKY_TRAFFIC_COST"); _DEFAULT_STICKY_TRAFFIC_COSTReady = true; } return _DEFAULT_STICKY_TRAFFIC_COSTContent; } }
        private static int _DEFAULT_STICKY_TRAFFIC_COSTContent = default;
        private static bool _DEFAULT_STICKY_TRAFFIC_COSTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/processor/assignment/assignors/StickyTaskAssignor.html#assign-org.apache.kafka.streams.processor.assignment.ApplicationState-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Assignment.ApplicationState"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.Assignment.TaskAssignor.TaskAssignment"/></returns>
        public Org.Apache.Kafka.Streams.Processor.Assignment.TaskAssignor.TaskAssignment Assign(Org.Apache.Kafka.Streams.Processor.Assignment.ApplicationState arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Processor.Assignment.TaskAssignor.TaskAssignment>("assign", "(Lorg/apache/kafka/streams/processor/assignment/ApplicationState;)Lorg/apache/kafka/streams/processor/assignment/TaskAssignor$TaskAssignment;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}