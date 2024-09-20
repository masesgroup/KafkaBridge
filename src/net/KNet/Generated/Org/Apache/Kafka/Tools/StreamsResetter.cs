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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using kafka-tools-3.6.2.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Tools
{
    #region StreamsResetter declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.6.2/org/apache/kafka/tools/StreamsResetter.html"/>
    /// </summary>
    public partial class StreamsResetter : MASES.JCOBridge.C2JBridge.JVMBridgeBase<StreamsResetter>, MASES.JCOBridge.C2JBridge.IJVMBridgeMain
    {
        const string _bridgeClassName = "org.apache.kafka.tools.StreamsResetter";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public StreamsResetter() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public StreamsResetter(params object[] args) : base(args) { }

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

    #region StreamsResetter implementation
    public partial class StreamsResetter
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.6.2/org/apache/kafka/tools/StreamsResetter.html#matchesInternalTopicFormat-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool MatchesInternalTopicFormat(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "matchesInternalTopicFormat", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.6.2/org/apache/kafka/tools/StreamsResetter.html#main-java.lang.String[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public static void Main(Java.Lang.String[] arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "main", "([Ljava/lang/String;)V", new object[] { arg0 });
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.6.2/org/apache/kafka/tools/StreamsResetter.html#execute-java.lang.String[]-java.util.Properties-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Properties"/></param>
        /// <returns><see cref="int"/></returns>
        public int Execute(Java.Lang.String[] arg0, Java.Util.Properties arg1)
        {
            return IExecute<int>("execute", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.6.2/org/apache/kafka/tools/StreamsResetter.html#execute-java.lang.String[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public int Execute(Java.Lang.String[] arg0)
        {
            return IExecuteWithSignature<int>("execute", "([Ljava/lang/String;)I", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.6.2/org/apache/kafka/tools/StreamsResetter.html#doDelete-java.util.List-org.apache.kafka.clients.admin.Admin-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Clients.Admin.Admin"/></param>
        public void DoDelete(Java.Util.List<Java.Lang.String> arg0, Org.Apache.Kafka.Clients.Admin.Admin arg1)
        {
            IExecute("doDelete", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.6.2/org/apache/kafka/tools/StreamsResetter.html#maybeSeekToEnd-java.lang.String-org.apache.kafka.clients.consumer.Consumer-java.util.Set-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Clients.Consumer.Consumer"/></param>
        /// <param name="arg2"><see cref="Java.Util.Set"/></param>
        public void MaybeSeekToEnd(Java.Lang.String arg0, Org.Apache.Kafka.Clients.Consumer.Consumer<byte[], byte[]> arg1, Java.Util.Set<Org.Apache.Kafka.Common.TopicPartition> arg2)
        {
            IExecute("maybeSeekToEnd", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.6.2/org/apache/kafka/tools/StreamsResetter.html#resetOffsetsFromResetPlan-org.apache.kafka.clients.consumer.Consumer-java.util.Set-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Consumer.Consumer"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        /// <param name="arg2"><see cref="Java.Util.Map"/></param>
        public void ResetOffsetsFromResetPlan(Org.Apache.Kafka.Clients.Consumer.Consumer<byte[], byte[]> arg0, Java.Util.Set<Org.Apache.Kafka.Common.TopicPartition> arg1, Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Java.Lang.Long> arg2)
        {
            IExecute("resetOffsetsFromResetPlan", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.6.2/org/apache/kafka/tools/StreamsResetter.html#resetOffsetsTo-org.apache.kafka.clients.consumer.Consumer-java.util.Set-java.lang.Long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Consumer.Consumer"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Long"/></param>
        public void ResetOffsetsTo(Org.Apache.Kafka.Clients.Consumer.Consumer<byte[], byte[]> arg0, Java.Util.Set<Org.Apache.Kafka.Common.TopicPartition> arg1, Java.Lang.Long arg2)
        {
            IExecute("resetOffsetsTo", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.6.2/org/apache/kafka/tools/StreamsResetter.html#resetToDatetime-org.apache.kafka.clients.consumer.Consumer-java.util.Set-java.lang.Long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Consumer.Consumer"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Long"/></param>
        public void ResetToDatetime(Org.Apache.Kafka.Clients.Consumer.Consumer<byte[], byte[]> arg0, Java.Util.Set<Org.Apache.Kafka.Common.TopicPartition> arg1, Java.Lang.Long arg2)
        {
            IExecute("resetToDatetime", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.6.2/org/apache/kafka/tools/StreamsResetter.html#shiftOffsetsBy-org.apache.kafka.clients.consumer.Consumer-java.util.Set-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Consumer.Consumer"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public void ShiftOffsetsBy(Org.Apache.Kafka.Clients.Consumer.Consumer<byte[], byte[]> arg0, Java.Util.Set<Org.Apache.Kafka.Common.TopicPartition> arg1, long arg2)
        {
            IExecute("shiftOffsetsBy", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}