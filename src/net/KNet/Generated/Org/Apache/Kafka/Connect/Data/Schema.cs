/*
*  Copyright 2025 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.5.12.0)
*  using connect-api-3.9.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Data
{
    #region Schema declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.html"/>
    /// </summary>
    public partial class Schema : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Schema>
    {
        const string _bridgeClassName = "org.apache.kafka.connect.data.Schema";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("Schema class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Schema() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("Schema class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Schema(params object[] args) : base(args) { }

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
        #region Type declaration
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.Type.html"/>
        /// </summary>
        public partial class Type : Java.Lang.Enum<Org.Apache.Kafka.Connect.Data.Schema.Type>
        {
            const string _bridgeClassName = "org.apache.kafka.connect.data.Schema$Type";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Type() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Type(params object[] args) : base(args) { }

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

    #region ISchema
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ISchema
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Schema implementation
    public partial class Schema : Org.Apache.Kafka.Connect.Data.ISchema
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.html#BOOLEAN_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema BOOLEAN_SCHEMA { get { if (!_BOOLEAN_SCHEMAReady) { _BOOLEAN_SCHEMAContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "BOOLEAN_SCHEMA"); _BOOLEAN_SCHEMAReady = true; } return _BOOLEAN_SCHEMAContent; } }
        private static Org.Apache.Kafka.Connect.Data.Schema _BOOLEAN_SCHEMAContent = default;
        private static bool _BOOLEAN_SCHEMAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.html#BYTES_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema BYTES_SCHEMA { get { if (!_BYTES_SCHEMAReady) { _BYTES_SCHEMAContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "BYTES_SCHEMA"); _BYTES_SCHEMAReady = true; } return _BYTES_SCHEMAContent; } }
        private static Org.Apache.Kafka.Connect.Data.Schema _BYTES_SCHEMAContent = default;
        private static bool _BYTES_SCHEMAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.html#FLOAT32_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema FLOAT32_SCHEMA { get { if (!_FLOAT32_SCHEMAReady) { _FLOAT32_SCHEMAContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "FLOAT32_SCHEMA"); _FLOAT32_SCHEMAReady = true; } return _FLOAT32_SCHEMAContent; } }
        private static Org.Apache.Kafka.Connect.Data.Schema _FLOAT32_SCHEMAContent = default;
        private static bool _FLOAT32_SCHEMAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.html#FLOAT64_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema FLOAT64_SCHEMA { get { if (!_FLOAT64_SCHEMAReady) { _FLOAT64_SCHEMAContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "FLOAT64_SCHEMA"); _FLOAT64_SCHEMAReady = true; } return _FLOAT64_SCHEMAContent; } }
        private static Org.Apache.Kafka.Connect.Data.Schema _FLOAT64_SCHEMAContent = default;
        private static bool _FLOAT64_SCHEMAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.html#INT16_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema INT16_SCHEMA { get { if (!_INT16_SCHEMAReady) { _INT16_SCHEMAContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "INT16_SCHEMA"); _INT16_SCHEMAReady = true; } return _INT16_SCHEMAContent; } }
        private static Org.Apache.Kafka.Connect.Data.Schema _INT16_SCHEMAContent = default;
        private static bool _INT16_SCHEMAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.html#INT32_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema INT32_SCHEMA { get { if (!_INT32_SCHEMAReady) { _INT32_SCHEMAContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "INT32_SCHEMA"); _INT32_SCHEMAReady = true; } return _INT32_SCHEMAContent; } }
        private static Org.Apache.Kafka.Connect.Data.Schema _INT32_SCHEMAContent = default;
        private static bool _INT32_SCHEMAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.html#INT64_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema INT64_SCHEMA { get { if (!_INT64_SCHEMAReady) { _INT64_SCHEMAContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "INT64_SCHEMA"); _INT64_SCHEMAReady = true; } return _INT64_SCHEMAContent; } }
        private static Org.Apache.Kafka.Connect.Data.Schema _INT64_SCHEMAContent = default;
        private static bool _INT64_SCHEMAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.html#INT8_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema INT8_SCHEMA { get { if (!_INT8_SCHEMAReady) { _INT8_SCHEMAContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "INT8_SCHEMA"); _INT8_SCHEMAReady = true; } return _INT8_SCHEMAContent; } }
        private static Org.Apache.Kafka.Connect.Data.Schema _INT8_SCHEMAContent = default;
        private static bool _INT8_SCHEMAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.html#OPTIONAL_BOOLEAN_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema OPTIONAL_BOOLEAN_SCHEMA { get { if (!_OPTIONAL_BOOLEAN_SCHEMAReady) { _OPTIONAL_BOOLEAN_SCHEMAContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "OPTIONAL_BOOLEAN_SCHEMA"); _OPTIONAL_BOOLEAN_SCHEMAReady = true; } return _OPTIONAL_BOOLEAN_SCHEMAContent; } }
        private static Org.Apache.Kafka.Connect.Data.Schema _OPTIONAL_BOOLEAN_SCHEMAContent = default;
        private static bool _OPTIONAL_BOOLEAN_SCHEMAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.html#OPTIONAL_BYTES_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema OPTIONAL_BYTES_SCHEMA { get { if (!_OPTIONAL_BYTES_SCHEMAReady) { _OPTIONAL_BYTES_SCHEMAContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "OPTIONAL_BYTES_SCHEMA"); _OPTIONAL_BYTES_SCHEMAReady = true; } return _OPTIONAL_BYTES_SCHEMAContent; } }
        private static Org.Apache.Kafka.Connect.Data.Schema _OPTIONAL_BYTES_SCHEMAContent = default;
        private static bool _OPTIONAL_BYTES_SCHEMAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.html#OPTIONAL_FLOAT32_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema OPTIONAL_FLOAT32_SCHEMA { get { if (!_OPTIONAL_FLOAT32_SCHEMAReady) { _OPTIONAL_FLOAT32_SCHEMAContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "OPTIONAL_FLOAT32_SCHEMA"); _OPTIONAL_FLOAT32_SCHEMAReady = true; } return _OPTIONAL_FLOAT32_SCHEMAContent; } }
        private static Org.Apache.Kafka.Connect.Data.Schema _OPTIONAL_FLOAT32_SCHEMAContent = default;
        private static bool _OPTIONAL_FLOAT32_SCHEMAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.html#OPTIONAL_FLOAT64_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema OPTIONAL_FLOAT64_SCHEMA { get { if (!_OPTIONAL_FLOAT64_SCHEMAReady) { _OPTIONAL_FLOAT64_SCHEMAContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "OPTIONAL_FLOAT64_SCHEMA"); _OPTIONAL_FLOAT64_SCHEMAReady = true; } return _OPTIONAL_FLOAT64_SCHEMAContent; } }
        private static Org.Apache.Kafka.Connect.Data.Schema _OPTIONAL_FLOAT64_SCHEMAContent = default;
        private static bool _OPTIONAL_FLOAT64_SCHEMAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.html#OPTIONAL_INT16_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema OPTIONAL_INT16_SCHEMA { get { if (!_OPTIONAL_INT16_SCHEMAReady) { _OPTIONAL_INT16_SCHEMAContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "OPTIONAL_INT16_SCHEMA"); _OPTIONAL_INT16_SCHEMAReady = true; } return _OPTIONAL_INT16_SCHEMAContent; } }
        private static Org.Apache.Kafka.Connect.Data.Schema _OPTIONAL_INT16_SCHEMAContent = default;
        private static bool _OPTIONAL_INT16_SCHEMAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.html#OPTIONAL_INT32_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema OPTIONAL_INT32_SCHEMA { get { if (!_OPTIONAL_INT32_SCHEMAReady) { _OPTIONAL_INT32_SCHEMAContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "OPTIONAL_INT32_SCHEMA"); _OPTIONAL_INT32_SCHEMAReady = true; } return _OPTIONAL_INT32_SCHEMAContent; } }
        private static Org.Apache.Kafka.Connect.Data.Schema _OPTIONAL_INT32_SCHEMAContent = default;
        private static bool _OPTIONAL_INT32_SCHEMAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.html#OPTIONAL_INT64_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema OPTIONAL_INT64_SCHEMA { get { if (!_OPTIONAL_INT64_SCHEMAReady) { _OPTIONAL_INT64_SCHEMAContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "OPTIONAL_INT64_SCHEMA"); _OPTIONAL_INT64_SCHEMAReady = true; } return _OPTIONAL_INT64_SCHEMAContent; } }
        private static Org.Apache.Kafka.Connect.Data.Schema _OPTIONAL_INT64_SCHEMAContent = default;
        private static bool _OPTIONAL_INT64_SCHEMAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.html#OPTIONAL_INT8_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema OPTIONAL_INT8_SCHEMA { get { if (!_OPTIONAL_INT8_SCHEMAReady) { _OPTIONAL_INT8_SCHEMAContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "OPTIONAL_INT8_SCHEMA"); _OPTIONAL_INT8_SCHEMAReady = true; } return _OPTIONAL_INT8_SCHEMAContent; } }
        private static Org.Apache.Kafka.Connect.Data.Schema _OPTIONAL_INT8_SCHEMAContent = default;
        private static bool _OPTIONAL_INT8_SCHEMAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.html#OPTIONAL_STRING_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema OPTIONAL_STRING_SCHEMA { get { if (!_OPTIONAL_STRING_SCHEMAReady) { _OPTIONAL_STRING_SCHEMAContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "OPTIONAL_STRING_SCHEMA"); _OPTIONAL_STRING_SCHEMAReady = true; } return _OPTIONAL_STRING_SCHEMAContent; } }
        private static Org.Apache.Kafka.Connect.Data.Schema _OPTIONAL_STRING_SCHEMAContent = default;
        private static bool _OPTIONAL_STRING_SCHEMAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.html#STRING_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema STRING_SCHEMA { get { if (!_STRING_SCHEMAReady) { _STRING_SCHEMAContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "STRING_SCHEMA"); _STRING_SCHEMAReady = true; } return _STRING_SCHEMAContent; } }
        private static Org.Apache.Kafka.Connect.Data.Schema _STRING_SCHEMAContent = default;
        private static bool _STRING_SCHEMAReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.html#isOptional--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsOptional()
        {
            return IExecuteWithSignature<bool>("isOptional", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.html#version--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        public Java.Lang.Integer Version()
        {
            return IExecuteWithSignature<Java.Lang.Integer>("version", "()Ljava/lang/Integer;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.html#defaultValue--"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object DefaultValue()
        {
            return IExecuteWithSignature("defaultValue", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.html#doc--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Doc()
        {
            return IExecuteWithSignature<Java.Lang.String>("doc", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.html#name--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Name()
        {
            return IExecuteWithSignature<Java.Lang.String>("name", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.html#fields--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Org.Apache.Kafka.Connect.Data.Field> Fields()
        {
            return IExecuteWithSignature<Java.Util.List<Org.Apache.Kafka.Connect.Data.Field>>("fields", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.html#parameters--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, Java.Lang.String> Parameters()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Lang.String>>("parameters", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.html#field-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Field"/></returns>
        public Org.Apache.Kafka.Connect.Data.Field Field(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Data.Field>("field", "(Ljava/lang/String;)Lorg/apache/kafka/connect/data/Field;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.html#keySchema--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></returns>
        public Org.Apache.Kafka.Connect.Data.Schema KeySchema()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Data.Schema>("keySchema", "()Lorg/apache/kafka/connect/data/Schema;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.html#schema--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></returns>
        public Org.Apache.Kafka.Connect.Data.Schema SchemaMethod()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Data.Schema>("schema", "()Lorg/apache/kafka/connect/data/Schema;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.html#valueSchema--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></returns>
        public Org.Apache.Kafka.Connect.Data.Schema ValueSchema()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Data.Schema>("valueSchema", "()Lorg/apache/kafka/connect/data/Schema;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.html#type--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Schema.Type"/></returns>
        public Org.Apache.Kafka.Connect.Data.Schema.Type TypeMethod()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Data.Schema.Type>("type", "()Lorg/apache/kafka/connect/data/Schema$Type;");
        }

        #endregion

        #region Nested classes
        #region Type implementation
        public partial class Type
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.Type.html#ARRAY"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type ARRAY { get { if (!_ARRAYReady) { _ARRAYContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "ARRAY"); _ARRAYReady = true; } return _ARRAYContent; } }
            private static Org.Apache.Kafka.Connect.Data.Schema.Type _ARRAYContent = default;
            private static bool _ARRAYReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.Type.html#BOOLEAN"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type BOOLEAN { get { if (!_BOOLEANReady) { _BOOLEANContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "BOOLEAN"); _BOOLEANReady = true; } return _BOOLEANContent; } }
            private static Org.Apache.Kafka.Connect.Data.Schema.Type _BOOLEANContent = default;
            private static bool _BOOLEANReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.Type.html#BYTES"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type BYTES { get { if (!_BYTESReady) { _BYTESContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "BYTES"); _BYTESReady = true; } return _BYTESContent; } }
            private static Org.Apache.Kafka.Connect.Data.Schema.Type _BYTESContent = default;
            private static bool _BYTESReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.Type.html#FLOAT32"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type FLOAT32 { get { if (!_FLOAT32Ready) { _FLOAT32Content = SGetField<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "FLOAT32"); _FLOAT32Ready = true; } return _FLOAT32Content; } }
            private static Org.Apache.Kafka.Connect.Data.Schema.Type _FLOAT32Content = default;
            private static bool _FLOAT32Ready = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.Type.html#FLOAT64"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type FLOAT64 { get { if (!_FLOAT64Ready) { _FLOAT64Content = SGetField<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "FLOAT64"); _FLOAT64Ready = true; } return _FLOAT64Content; } }
            private static Org.Apache.Kafka.Connect.Data.Schema.Type _FLOAT64Content = default;
            private static bool _FLOAT64Ready = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.Type.html#INT16"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type INT16 { get { if (!_INT16Ready) { _INT16Content = SGetField<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "INT16"); _INT16Ready = true; } return _INT16Content; } }
            private static Org.Apache.Kafka.Connect.Data.Schema.Type _INT16Content = default;
            private static bool _INT16Ready = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.Type.html#INT32"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type INT32 { get { if (!_INT32Ready) { _INT32Content = SGetField<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "INT32"); _INT32Ready = true; } return _INT32Content; } }
            private static Org.Apache.Kafka.Connect.Data.Schema.Type _INT32Content = default;
            private static bool _INT32Ready = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.Type.html#INT64"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type INT64 { get { if (!_INT64Ready) { _INT64Content = SGetField<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "INT64"); _INT64Ready = true; } return _INT64Content; } }
            private static Org.Apache.Kafka.Connect.Data.Schema.Type _INT64Content = default;
            private static bool _INT64Ready = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.Type.html#INT8"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type INT8 { get { if (!_INT8Ready) { _INT8Content = SGetField<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "INT8"); _INT8Ready = true; } return _INT8Content; } }
            private static Org.Apache.Kafka.Connect.Data.Schema.Type _INT8Content = default;
            private static bool _INT8Ready = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.Type.html#MAP"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type MAP { get { if (!_MAPReady) { _MAPContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "MAP"); _MAPReady = true; } return _MAPContent; } }
            private static Org.Apache.Kafka.Connect.Data.Schema.Type _MAPContent = default;
            private static bool _MAPReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.Type.html#STRING"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type STRING { get { if (!_STRINGReady) { _STRINGContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "STRING"); _STRINGReady = true; } return _STRINGContent; } }
            private static Org.Apache.Kafka.Connect.Data.Schema.Type _STRINGContent = default;
            private static bool _STRINGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.Type.html#STRUCT"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type STRUCT { get { if (!_STRUCTReady) { _STRUCTContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "STRUCT"); _STRUCTReady = true; } return _STRUCTContent; } }
            private static Org.Apache.Kafka.Connect.Data.Schema.Type _STRUCTContent = default;
            private static bool _STRUCTReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.Type.html#valueOf-java.lang.String-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Schema.Type"/></returns>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/connect/data/Schema$Type;", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.Type.html#values--"/>
            /// </summary>
            /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Schema.Type"/></returns>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type[] Values()
            {
                return SExecuteWithSignatureArray<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/connect/data/Schema$Type;");
            }

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.Type.html#getName--"/> 
            /// </summary>
            public Java.Lang.String Name
            {
                get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/data/Schema.Type.html#isPrimitive--"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsPrimitive()
            {
                return IExecuteWithSignature<bool>("isPrimitive", "()Z");
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