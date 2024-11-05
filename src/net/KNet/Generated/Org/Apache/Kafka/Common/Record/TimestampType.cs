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
*  using kafka-clients-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Record
{
    #region TimestampType declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/record/TimestampType.html"/>
    /// </summary>
    public partial class TimestampType : Java.Lang.Enum<Org.Apache.Kafka.Common.Record.TimestampType>
    {
        const string _bridgeClassName = "org.apache.kafka.common.record.TimestampType";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TimestampType() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TimestampType(params object[] args) : base(args) { }

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

    #region TimestampType implementation
    public partial class TimestampType
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/record/TimestampType.html#id"/>
        /// </summary>
        public int id { get { if (!_idReady) { _idContent = IGetField<int>("id"); _idReady = true; } return _idContent; } }
        private int _idContent = default;
        private bool _idReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/record/TimestampType.html#name"/>
        /// </summary>
        public Java.Lang.String name { get { if (!_nameReady) { _nameContent = IGetField<Java.Lang.String>("name"); _nameReady = true; } return _nameContent; } }
        private Java.Lang.String _nameContent = default;
        private bool _nameReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/record/TimestampType.html#CREATE_TIME"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Record.TimestampType CREATE_TIME { get { if (!_CREATE_TIMEReady) { _CREATE_TIMEContent = SGetField<Org.Apache.Kafka.Common.Record.TimestampType>(LocalBridgeClazz, "CREATE_TIME"); _CREATE_TIMEReady = true; } return _CREATE_TIMEContent; } }
        private static Org.Apache.Kafka.Common.Record.TimestampType _CREATE_TIMEContent = default;
        private static bool _CREATE_TIMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/record/TimestampType.html#LOG_APPEND_TIME"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Record.TimestampType LOG_APPEND_TIME { get { if (!_LOG_APPEND_TIMEReady) { _LOG_APPEND_TIMEContent = SGetField<Org.Apache.Kafka.Common.Record.TimestampType>(LocalBridgeClazz, "LOG_APPEND_TIME"); _LOG_APPEND_TIMEReady = true; } return _LOG_APPEND_TIMEContent; } }
        private static Org.Apache.Kafka.Common.Record.TimestampType _LOG_APPEND_TIMEContent = default;
        private static bool _LOG_APPEND_TIMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/record/TimestampType.html#NO_TIMESTAMP_TYPE"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Record.TimestampType NO_TIMESTAMP_TYPE { get { if (!_NO_TIMESTAMP_TYPEReady) { _NO_TIMESTAMP_TYPEContent = SGetField<Org.Apache.Kafka.Common.Record.TimestampType>(LocalBridgeClazz, "NO_TIMESTAMP_TYPE"); _NO_TIMESTAMP_TYPEReady = true; } return _NO_TIMESTAMP_TYPEContent; } }
        private static Org.Apache.Kafka.Common.Record.TimestampType _NO_TIMESTAMP_TYPEContent = default;
        private static bool _NO_TIMESTAMP_TYPEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/record/TimestampType.html#forName-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Record.TimestampType"/></returns>
        public static Org.Apache.Kafka.Common.Record.TimestampType ForName(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.Record.TimestampType>(LocalBridgeClazz, "forName", "(Ljava/lang/String;)Lorg/apache/kafka/common/record/TimestampType;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/record/TimestampType.html#valueOf-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Record.TimestampType"/></returns>
        public static Org.Apache.Kafka.Common.Record.TimestampType ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.Record.TimestampType>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/common/record/TimestampType;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/record/TimestampType.html#values--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Record.TimestampType"/></returns>
        public static Org.Apache.Kafka.Common.Record.TimestampType[] Values()
        {
            return SExecuteWithSignatureArray<Org.Apache.Kafka.Common.Record.TimestampType>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/common/record/TimestampType;");
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