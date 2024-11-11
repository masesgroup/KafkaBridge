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

namespace Org.Apache.Kafka.Streams.State
{
    #region DslWindowParams declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/state/DslWindowParams.html"/>
    /// </summary>
    public partial class DslWindowParams : MASES.JCOBridge.C2JBridge.JVMBridgeBase<DslWindowParams>
    {
        const string _bridgeClassName = "org.apache.kafka.streams.state.DslWindowParams";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DslWindowParams() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DslWindowParams(params object[] args) : base(args) { }

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

    #region DslWindowParams implementation
    public partial class DslWindowParams
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/state/DslWindowParams.html#org.apache.kafka.streams.state.DslWindowParams(java.lang.String,java.time.Duration,java.time.Duration,boolean,org.apache.kafka.streams.kstream.EmitStrategy,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Time.Duration"/></param>
        /// <param name="arg2"><see cref="Java.Time.Duration"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Streams.Kstream.EmitStrategy"/></param>
        /// <param name="arg5"><see cref="bool"/></param>
        /// <param name="arg6"><see cref="bool"/></param>
        public DslWindowParams(Java.Lang.String arg0, Java.Time.Duration arg1, Java.Time.Duration arg2, bool arg3, Org.Apache.Kafka.Streams.Kstream.EmitStrategy arg4, bool arg5, bool arg6)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/state/DslWindowParams.html#isSlidingWindow--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSlidingWindow()
        {
            return IExecuteWithSignature<bool>("isSlidingWindow", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/state/DslWindowParams.html#isTimestamped--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsTimestamped()
        {
            return IExecuteWithSignature<bool>("isTimestamped", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/state/DslWindowParams.html#retainDuplicates--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool RetainDuplicates()
        {
            return IExecuteWithSignature<bool>("retainDuplicates", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/state/DslWindowParams.html#name--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Name()
        {
            return IExecuteWithSignature<Java.Lang.String>("name", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/state/DslWindowParams.html#retentionPeriod--"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public Java.Time.Duration RetentionPeriod()
        {
            return IExecuteWithSignature<Java.Time.Duration>("retentionPeriod", "()Ljava/time/Duration;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/state/DslWindowParams.html#windowSize--"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public Java.Time.Duration WindowSize()
        {
            return IExecuteWithSignature<Java.Time.Duration>("windowSize", "()Ljava/time/Duration;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.9.0/org/apache/kafka/streams/state/DslWindowParams.html#emitStrategy--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.EmitStrategy"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.EmitStrategy EmitStrategy()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.EmitStrategy>("emitStrategy", "()Lorg/apache/kafka/streams/kstream/EmitStrategy;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}