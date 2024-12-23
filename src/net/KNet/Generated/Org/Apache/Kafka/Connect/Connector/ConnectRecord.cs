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
*  using connect-api-3.9.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Connector
{
    #region ConnectRecord declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/connector/ConnectRecord.html"/>
    /// </summary>
    public partial class ConnectRecord : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ConnectRecord>
    {
        const string _bridgeClassName = "org.apache.kafka.connect.connector.ConnectRecord";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ConnectRecord class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ConnectRecord() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ConnectRecord class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ConnectRecord(params object[] args) : base(args) { }

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
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region ConnectRecord<R> declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/connector/ConnectRecord.html"/>
    /// </summary>
    /// <typeparam name="R"><see cref="Org.Apache.Kafka.Connect.Connector.ConnectRecord{R}"/></typeparam>
    public partial class ConnectRecord<R> : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ConnectRecord<R>> where R : Org.Apache.Kafka.Connect.Connector.ConnectRecord<R>
    {
        const string _bridgeClassName = "org.apache.kafka.connect.connector.ConnectRecord";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ConnectRecord class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ConnectRecord() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ConnectRecord class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ConnectRecord(params object[] args) : base(args) { }

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
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class
    
    }
    #endregion

    #region ConnectRecord implementation
    public partial class ConnectRecord
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/connector/ConnectRecord.html#org.apache.kafka.connect.connector.ConnectRecord(java.lang.String,java.lang.Integer,org.apache.kafka.connect.data.Schema,java.lang.Object,org.apache.kafka.connect.data.Schema,java.lang.Object,java.lang.Long,java.lang.Iterable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Integer"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg5"><see cref="object"/></param>
        /// <param name="arg6"><see cref="Java.Lang.Long"/></param>
        /// <param name="arg7"><see cref="Java.Lang.Iterable"/></param>
        public ConnectRecord(Java.Lang.String arg0, Java.Lang.Integer arg1, Org.Apache.Kafka.Connect.Data.Schema arg2, object arg3, Org.Apache.Kafka.Connect.Data.Schema arg4, object arg5, Java.Lang.Long arg6, Java.Lang.Iterable arg7)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/connector/ConnectRecord.html#org.apache.kafka.connect.connector.ConnectRecord(java.lang.String,java.lang.Integer,org.apache.kafka.connect.data.Schema,java.lang.Object,org.apache.kafka.connect.data.Schema,java.lang.Object,java.lang.Long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Integer"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg5"><see cref="object"/></param>
        /// <param name="arg6"><see cref="Java.Lang.Long"/></param>
        public ConnectRecord(Java.Lang.String arg0, Java.Lang.Integer arg1, Org.Apache.Kafka.Connect.Data.Schema arg2, object arg3, Org.Apache.Kafka.Connect.Data.Schema arg4, object arg5, Java.Lang.Long arg6)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/connector/ConnectRecord.html#newRecord-java.lang.String-java.lang.Integer-org.apache.kafka.connect.data.Schema-java.lang.Object-org.apache.kafka.connect.data.Schema-java.lang.Object-java.lang.Long-java.lang.Iterable-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Integer"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg5"><see cref="object"/></param>
        /// <param name="arg6"><see cref="Java.Lang.Long"/></param>
        /// <param name="arg7"><see cref="Java.Lang.Iterable"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Connector.ConnectRecord"/></returns>
        public Org.Apache.Kafka.Connect.Connector.ConnectRecord NewRecord(Java.Lang.String arg0, Java.Lang.Integer arg1, Org.Apache.Kafka.Connect.Data.Schema arg2, object arg3, Org.Apache.Kafka.Connect.Data.Schema arg4, object arg5, Java.Lang.Long arg6, Java.Lang.Iterable arg7)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Connector.ConnectRecord>("newRecord", "(Ljava/lang/String;Ljava/lang/Integer;Lorg/apache/kafka/connect/data/Schema;Ljava/lang/Object;Lorg/apache/kafka/connect/data/Schema;Ljava/lang/Object;Ljava/lang/Long;Ljava/lang/Iterable;)Lorg/apache/kafka/connect/connector/ConnectRecord;", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/connector/ConnectRecord.html#newRecord-java.lang.String-java.lang.Integer-org.apache.kafka.connect.data.Schema-java.lang.Object-org.apache.kafka.connect.data.Schema-java.lang.Object-java.lang.Long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Integer"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg5"><see cref="object"/></param>
        /// <param name="arg6"><see cref="Java.Lang.Long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Connector.ConnectRecord"/></returns>
        public Org.Apache.Kafka.Connect.Connector.ConnectRecord NewRecord(Java.Lang.String arg0, Java.Lang.Integer arg1, Org.Apache.Kafka.Connect.Data.Schema arg2, object arg3, Org.Apache.Kafka.Connect.Data.Schema arg4, object arg5, Java.Lang.Long arg6)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Connector.ConnectRecord>("newRecord", "(Ljava/lang/String;Ljava/lang/Integer;Lorg/apache/kafka/connect/data/Schema;Ljava/lang/Object;Lorg/apache/kafka/connect/data/Schema;Ljava/lang/Object;Ljava/lang/Long;)Lorg/apache/kafka/connect/connector/ConnectRecord;", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/connector/ConnectRecord.html#kafkaPartition--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        public Java.Lang.Integer KafkaPartition()
        {
            return IExecuteWithSignature<Java.Lang.Integer>("kafkaPartition", "()Ljava/lang/Integer;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/connector/ConnectRecord.html#timestamp--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Long"/></returns>
        public Java.Lang.Long Timestamp()
        {
            return IExecuteWithSignature<Java.Lang.Long>("timestamp", "()Ljava/lang/Long;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/connector/ConnectRecord.html#key--"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object Key()
        {
            return IExecuteWithSignature("key", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/connector/ConnectRecord.html#value--"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object Value()
        {
            return IExecuteWithSignature("value", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/connector/ConnectRecord.html#topic--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Topic()
        {
            return IExecuteWithSignature<Java.Lang.String>("topic", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/connector/ConnectRecord.html#keySchema--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></returns>
        public Org.Apache.Kafka.Connect.Data.Schema KeySchema()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Data.Schema>("keySchema", "()Lorg/apache/kafka/connect/data/Schema;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/connector/ConnectRecord.html#valueSchema--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></returns>
        public Org.Apache.Kafka.Connect.Data.Schema ValueSchema()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Data.Schema>("valueSchema", "()Lorg/apache/kafka/connect/data/Schema;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/connector/ConnectRecord.html#headers--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Header.Headers"/></returns>
        public Org.Apache.Kafka.Connect.Header.Headers Headers()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Header.Headers>("headers", "()Lorg/apache/kafka/connect/header/Headers;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ConnectRecord<R> implementation
    public partial class ConnectRecord<R>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/connector/ConnectRecord.html#org.apache.kafka.connect.connector.ConnectRecord(java.lang.String,java.lang.Integer,org.apache.kafka.connect.data.Schema,java.lang.Object,org.apache.kafka.connect.data.Schema,java.lang.Object,java.lang.Long,java.lang.Iterable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Integer"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg5"><see cref="object"/></param>
        /// <param name="arg6"><see cref="Java.Lang.Long"/></param>
        /// <param name="arg7"><see cref="Java.Lang.Iterable"/></param>
        public ConnectRecord(Java.Lang.String arg0, Java.Lang.Integer arg1, Org.Apache.Kafka.Connect.Data.Schema arg2, object arg3, Org.Apache.Kafka.Connect.Data.Schema arg4, object arg5, Java.Lang.Long arg6, Java.Lang.Iterable<Org.Apache.Kafka.Connect.Header.Header> arg7)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/connector/ConnectRecord.html#org.apache.kafka.connect.connector.ConnectRecord(java.lang.String,java.lang.Integer,org.apache.kafka.connect.data.Schema,java.lang.Object,org.apache.kafka.connect.data.Schema,java.lang.Object,java.lang.Long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Integer"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg5"><see cref="object"/></param>
        /// <param name="arg6"><see cref="Java.Lang.Long"/></param>
        public ConnectRecord(Java.Lang.String arg0, Java.Lang.Integer arg1, Org.Apache.Kafka.Connect.Data.Schema arg2, object arg3, Org.Apache.Kafka.Connect.Data.Schema arg4, object arg5, Java.Lang.Long arg6)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Connector.ConnectRecord{R}"/> to <see cref="Org.Apache.Kafka.Connect.Connector.ConnectRecord"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Connect.Connector.ConnectRecord(Org.Apache.Kafka.Connect.Connector.ConnectRecord<R> t) => t.Cast<Org.Apache.Kafka.Connect.Connector.ConnectRecord>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/connector/ConnectRecord.html#newRecord-java.lang.String-java.lang.Integer-org.apache.kafka.connect.data.Schema-java.lang.Object-org.apache.kafka.connect.data.Schema-java.lang.Object-java.lang.Long-java.lang.Iterable-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Integer"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg5"><see cref="object"/></param>
        /// <param name="arg6"><see cref="Java.Lang.Long"/></param>
        /// <param name="arg7"><see cref="Java.Lang.Iterable"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R NewRecord(Java.Lang.String arg0, Java.Lang.Integer arg1, Org.Apache.Kafka.Connect.Data.Schema arg2, object arg3, Org.Apache.Kafka.Connect.Data.Schema arg4, object arg5, Java.Lang.Long arg6, Java.Lang.Iterable<Org.Apache.Kafka.Connect.Header.Header> arg7)
        {
            return IExecuteWithSignature<R>("newRecord", "(Ljava/lang/String;Ljava/lang/Integer;Lorg/apache/kafka/connect/data/Schema;Ljava/lang/Object;Lorg/apache/kafka/connect/data/Schema;Ljava/lang/Object;Ljava/lang/Long;Ljava/lang/Iterable;)Lorg/apache/kafka/connect/connector/ConnectRecord;", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/connector/ConnectRecord.html#newRecord-java.lang.String-java.lang.Integer-org.apache.kafka.connect.data.Schema-java.lang.Object-org.apache.kafka.connect.data.Schema-java.lang.Object-java.lang.Long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Integer"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg5"><see cref="object"/></param>
        /// <param name="arg6"><see cref="Java.Lang.Long"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R NewRecord(Java.Lang.String arg0, Java.Lang.Integer arg1, Org.Apache.Kafka.Connect.Data.Schema arg2, object arg3, Org.Apache.Kafka.Connect.Data.Schema arg4, object arg5, Java.Lang.Long arg6)
        {
            return IExecuteWithSignature<R>("newRecord", "(Ljava/lang/String;Ljava/lang/Integer;Lorg/apache/kafka/connect/data/Schema;Ljava/lang/Object;Lorg/apache/kafka/connect/data/Schema;Ljava/lang/Object;Ljava/lang/Long;)Lorg/apache/kafka/connect/connector/ConnectRecord;", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/connector/ConnectRecord.html#kafkaPartition--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        public Java.Lang.Integer KafkaPartition()
        {
            return IExecuteWithSignature<Java.Lang.Integer>("kafkaPartition", "()Ljava/lang/Integer;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/connector/ConnectRecord.html#timestamp--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Long"/></returns>
        public Java.Lang.Long Timestamp()
        {
            return IExecuteWithSignature<Java.Lang.Long>("timestamp", "()Ljava/lang/Long;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/connector/ConnectRecord.html#key--"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object Key()
        {
            return IExecuteWithSignature("key", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/connector/ConnectRecord.html#value--"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object Value()
        {
            return IExecuteWithSignature("value", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/connector/ConnectRecord.html#topic--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Topic()
        {
            return IExecuteWithSignature<Java.Lang.String>("topic", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/connector/ConnectRecord.html#keySchema--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></returns>
        public Org.Apache.Kafka.Connect.Data.Schema KeySchema()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Data.Schema>("keySchema", "()Lorg/apache/kafka/connect/data/Schema;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/connector/ConnectRecord.html#valueSchema--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></returns>
        public Org.Apache.Kafka.Connect.Data.Schema ValueSchema()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Data.Schema>("valueSchema", "()Lorg/apache/kafka/connect/data/Schema;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/connector/ConnectRecord.html#headers--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Header.Headers"/></returns>
        public Org.Apache.Kafka.Connect.Header.Headers Headers()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Header.Headers>("headers", "()Lorg/apache/kafka/connect/header/Headers;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}