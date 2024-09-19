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
*  using connect-api-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Source
{
    #region SourceRecord declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.0/org/apache/kafka/connect/source/SourceRecord.html"/>
    /// </summary>
    public partial class SourceRecord : Org.Apache.Kafka.Connect.Connector.ConnectRecord<Org.Apache.Kafka.Connect.Source.SourceRecord>
    {
        const string _bridgeClassName = "org.apache.kafka.connect.source.SourceRecord";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SourceRecord() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SourceRecord(params object[] args) : base(args) { }

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

    #region SourceRecord implementation
    public partial class SourceRecord
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.0/org/apache/kafka/connect/source/SourceRecord.html#org.apache.kafka.connect.source.SourceRecord(java.util.Map,java.util.Map,java.lang.String,java.lang.Integer,org.apache.kafka.connect.data.Schema,java.lang.Object,org.apache.kafka.connect.data.Schema,java.lang.Object,java.lang.Long,java.lang.Iterable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.Integer"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg5"><see cref="object"/></param>
        /// <param name="arg6"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg7"><see cref="object"/></param>
        /// <param name="arg8"><see cref="Java.Lang.Long"/></param>
        /// <param name="arg9"><see cref="Java.Lang.Iterable"/></param>
        public SourceRecord(Java.Util.Map<Java.Lang.String, object> arg0, Java.Util.Map<Java.Lang.String, object> arg1, Java.Lang.String arg2, Java.Lang.Integer arg3, Org.Apache.Kafka.Connect.Data.Schema arg4, object arg5, Org.Apache.Kafka.Connect.Data.Schema arg6, object arg7, Java.Lang.Long arg8, Java.Lang.Iterable<Org.Apache.Kafka.Connect.Header.Header> arg9)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.0/org/apache/kafka/connect/source/SourceRecord.html#org.apache.kafka.connect.source.SourceRecord(java.util.Map,java.util.Map,java.lang.String,java.lang.Integer,org.apache.kafka.connect.data.Schema,java.lang.Object,org.apache.kafka.connect.data.Schema,java.lang.Object,java.lang.Long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.Integer"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg5"><see cref="object"/></param>
        /// <param name="arg6"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg7"><see cref="object"/></param>
        /// <param name="arg8"><see cref="Java.Lang.Long"/></param>
        public SourceRecord(Java.Util.Map<Java.Lang.String, object> arg0, Java.Util.Map<Java.Lang.String, object> arg1, Java.Lang.String arg2, Java.Lang.Integer arg3, Org.Apache.Kafka.Connect.Data.Schema arg4, object arg5, Org.Apache.Kafka.Connect.Data.Schema arg6, object arg7, Java.Lang.Long arg8)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.0/org/apache/kafka/connect/source/SourceRecord.html#org.apache.kafka.connect.source.SourceRecord(java.util.Map,java.util.Map,java.lang.String,java.lang.Integer,org.apache.kafka.connect.data.Schema,java.lang.Object,org.apache.kafka.connect.data.Schema,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.Integer"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg5"><see cref="object"/></param>
        /// <param name="arg6"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg7"><see cref="object"/></param>
        public SourceRecord(Java.Util.Map<Java.Lang.String, object> arg0, Java.Util.Map<Java.Lang.String, object> arg1, Java.Lang.String arg2, Java.Lang.Integer arg3, Org.Apache.Kafka.Connect.Data.Schema arg4, object arg5, Org.Apache.Kafka.Connect.Data.Schema arg6, object arg7)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.0/org/apache/kafka/connect/source/SourceRecord.html#org.apache.kafka.connect.source.SourceRecord(java.util.Map,java.util.Map,java.lang.String,java.lang.Integer,org.apache.kafka.connect.data.Schema,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.Integer"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg5"><see cref="object"/></param>
        public SourceRecord(Java.Util.Map<Java.Lang.String, object> arg0, Java.Util.Map<Java.Lang.String, object> arg1, Java.Lang.String arg2, Java.Lang.Integer arg3, Org.Apache.Kafka.Connect.Data.Schema arg4, object arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.0/org/apache/kafka/connect/source/SourceRecord.html#org.apache.kafka.connect.source.SourceRecord(java.util.Map,java.util.Map,java.lang.String,org.apache.kafka.connect.data.Schema,java.lang.Object,org.apache.kafka.connect.data.Schema,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg4"><see cref="object"/></param>
        /// <param name="arg5"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg6"><see cref="object"/></param>
        public SourceRecord(Java.Util.Map<Java.Lang.String, object> arg0, Java.Util.Map<Java.Lang.String, object> arg1, Java.Lang.String arg2, Org.Apache.Kafka.Connect.Data.Schema arg3, object arg4, Org.Apache.Kafka.Connect.Data.Schema arg5, object arg6)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.0/org/apache/kafka/connect/source/SourceRecord.html#org.apache.kafka.connect.source.SourceRecord(java.util.Map,java.util.Map,java.lang.String,org.apache.kafka.connect.data.Schema,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg4"><see cref="object"/></param>
        public SourceRecord(Java.Util.Map<Java.Lang.String, object> arg0, Java.Util.Map<Java.Lang.String, object> arg1, Java.Lang.String arg2, Org.Apache.Kafka.Connect.Data.Schema arg3, object arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.0/org/apache/kafka/connect/source/SourceRecord.html#sourceOffset--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, object> SourceOffset()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, object>>("sourceOffset", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.0/org/apache/kafka/connect/source/SourceRecord.html#sourcePartition--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, object> SourcePartition()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, object>>("sourcePartition", "()Ljava/util/Map;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}