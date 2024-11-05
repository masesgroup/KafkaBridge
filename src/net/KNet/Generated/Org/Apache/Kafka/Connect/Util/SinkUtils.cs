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
*  using connect-runtime-3.8.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Util
{
    #region SinkUtils declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.8.1/org/apache/kafka/connect/util/SinkUtils.html"/>
    /// </summary>
    public partial class SinkUtils : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SinkUtils>
    {
        const string _bridgeClassName = "org.apache.kafka.connect.util.SinkUtils";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SinkUtils() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SinkUtils(params object[] args) : base(args) { }

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

    #region SinkUtils implementation
    public partial class SinkUtils
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.8.1/org/apache/kafka/connect/util/SinkUtils.html#KAFKA_OFFSET_KEY"/>
        /// </summary>
        public static Java.Lang.String KAFKA_OFFSET_KEY { get { if (!_KAFKA_OFFSET_KEYReady) { _KAFKA_OFFSET_KEYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "KAFKA_OFFSET_KEY"); _KAFKA_OFFSET_KEYReady = true; } return _KAFKA_OFFSET_KEYContent; } }
        private static Java.Lang.String _KAFKA_OFFSET_KEYContent = default;
        private static bool _KAFKA_OFFSET_KEYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.8.1/org/apache/kafka/connect/util/SinkUtils.html#KAFKA_PARTITION_KEY"/>
        /// </summary>
        public static Java.Lang.String KAFKA_PARTITION_KEY { get { if (!_KAFKA_PARTITION_KEYReady) { _KAFKA_PARTITION_KEYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "KAFKA_PARTITION_KEY"); _KAFKA_PARTITION_KEYReady = true; } return _KAFKA_PARTITION_KEYContent; } }
        private static Java.Lang.String _KAFKA_PARTITION_KEYContent = default;
        private static bool _KAFKA_PARTITION_KEYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.8.1/org/apache/kafka/connect/util/SinkUtils.html#KAFKA_TOPIC_KEY"/>
        /// </summary>
        public static Java.Lang.String KAFKA_TOPIC_KEY { get { if (!_KAFKA_TOPIC_KEYReady) { _KAFKA_TOPIC_KEYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "KAFKA_TOPIC_KEY"); _KAFKA_TOPIC_KEYReady = true; } return _KAFKA_TOPIC_KEYContent; } }
        private static Java.Lang.String _KAFKA_TOPIC_KEYContent = default;
        private static bool _KAFKA_TOPIC_KEYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.8.1/org/apache/kafka/connect/util/SinkUtils.html#consumerGroupId-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ConsumerGroupId(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "consumerGroupId", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.8.1/org/apache/kafka/connect/util/SinkUtils.html#parseSinkConnectorOffsets-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public static Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Java.Lang.Long> ParseSinkConnectorOffsets(Java.Util.Map<Java.Util.Map<Java.Lang.String, object>, Java.Util.Map<Java.Lang.String, object>> arg0)
        {
            return SExecuteWithSignature<Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Java.Lang.Long>>(LocalBridgeClazz, "parseSinkConnectorOffsets", "(Ljava/util/Map;)Ljava/util/Map;", arg0);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}