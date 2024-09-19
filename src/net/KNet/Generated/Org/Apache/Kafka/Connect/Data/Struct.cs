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
*  using connect-api-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Data
{
    #region Struct declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/Struct.html"/>
    /// </summary>
    public partial class Struct : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Struct>
    {
        const string _bridgeClassName = "org.apache.kafka.connect.data.Struct";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Struct() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Struct(params object[] args) : base(args) { }

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

    #region Struct implementation
    public partial class Struct
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/Struct.html#org.apache.kafka.connect.data.Struct(org.apache.kafka.connect.data.Schema)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        public Struct(Org.Apache.Kafka.Connect.Data.Schema arg0)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/Struct.html#getMap-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="V"></typeparam>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<K, V> GetMap<K, V>(Java.Lang.String arg0)
        {
            return IExecute<Java.Util.Map<K, V>>("getMap", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/Struct.html#getArray-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<T> GetArray<T>(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.List<T>>("getArray", "(Ljava/lang/String;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/Struct.html#getBytes-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetBytes(Java.Lang.String arg0)
        {
            return IExecuteWithSignatureArray<byte>("getBytes", "(Ljava/lang/String;)[B", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/Struct.html#getBoolean-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Boolean"/></returns>
        public Java.Lang.Boolean GetBoolean(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.Boolean>("getBoolean", "(Ljava/lang/String;)Ljava/lang/Boolean;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/Struct.html#getInt8-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Byte"/></returns>
        public Java.Lang.Byte GetInt8(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.Byte>("getInt8", "(Ljava/lang/String;)Ljava/lang/Byte;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/Struct.html#getFloat64-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Double"/></returns>
        public Java.Lang.Double GetFloat64(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.Double>("getFloat64", "(Ljava/lang/String;)Ljava/lang/Double;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/Struct.html#getFloat32-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Float"/></returns>
        public Java.Lang.Float GetFloat32(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.Float>("getFloat32", "(Ljava/lang/String;)Ljava/lang/Float;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/Struct.html#getInt32-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        public Java.Lang.Integer GetInt32(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.Integer>("getInt32", "(Ljava/lang/String;)Ljava/lang/Integer;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/Struct.html#getInt64-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Long"/></returns>
        public Java.Lang.Long GetInt64(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.Long>("getInt64", "(Ljava/lang/String;)Ljava/lang/Long;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/Struct.html#get-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        public object Get(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("get", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/Struct.html#get-org.apache.kafka.connect.data.Field-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Data.Field"/></param>
        /// <returns><see cref="object"/></returns>
        public object Get(Org.Apache.Kafka.Connect.Data.Field arg0)
        {
            return IExecuteWithSignature("get", "(Lorg/apache/kafka/connect/data/Field;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/Struct.html#getWithoutDefault-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetWithoutDefault(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("getWithoutDefault", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/Struct.html#getInt16-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Short"/></returns>
        public Java.Lang.Short GetInt16(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.Short>("getInt16", "(Ljava/lang/String;)Ljava/lang/Short;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/Struct.html#getString-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetString(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getString", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/Struct.html#schema--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></returns>
        public Org.Apache.Kafka.Connect.Data.Schema Schema()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Data.Schema>("schema", "()Lorg/apache/kafka/connect/data/Schema;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/Struct.html#getStruct-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Struct"/></returns>
        public Org.Apache.Kafka.Connect.Data.Struct GetStruct(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Data.Struct>("getStruct", "(Ljava/lang/String;)Lorg/apache/kafka/connect/data/Struct;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/Struct.html#put-java.lang.String-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Struct"/></returns>
        public Org.Apache.Kafka.Connect.Data.Struct Put(Java.Lang.String arg0, object arg1)
        {
            return IExecute<Org.Apache.Kafka.Connect.Data.Struct>("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/Struct.html#put-org.apache.kafka.connect.data.Field-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Data.Field"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Struct"/></returns>
        public Org.Apache.Kafka.Connect.Data.Struct Put(Org.Apache.Kafka.Connect.Data.Field arg0, object arg1)
        {
            return IExecute<Org.Apache.Kafka.Connect.Data.Struct>("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/Struct.html#validate--"/>
        /// </summary>
        public void Validate()
        {
            IExecuteWithSignature("validate", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}