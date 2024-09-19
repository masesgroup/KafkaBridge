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
    #region SchemaBuilder declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/SchemaBuilder.html"/>
    /// </summary>
    public partial class SchemaBuilder : Org.Apache.Kafka.Connect.Data.Schema
    {
        const string _bridgeClassName = "org.apache.kafka.connect.data.SchemaBuilder";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SchemaBuilder() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SchemaBuilder(params object[] args) : base(args) { }

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

    #region SchemaBuilder implementation
    public partial class SchemaBuilder
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/SchemaBuilder.html#org.apache.kafka.connect.data.SchemaBuilder(org.apache.kafka.connect.data.Schema.Type)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Data.Schema.Type"/></param>
        public SchemaBuilder(Org.Apache.Kafka.Connect.Data.Schema.Type arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/SchemaBuilder.html#array-org.apache.kafka.connect.data.Schema-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public static Org.Apache.Kafka.Connect.Data.SchemaBuilder Array(Org.Apache.Kafka.Connect.Data.Schema arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Connect.Data.SchemaBuilder>(LocalBridgeClazz, "array", "(Lorg/apache/kafka/connect/data/Schema;)Lorg/apache/kafka/connect/data/SchemaBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/SchemaBuilder.html#bool--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public static Org.Apache.Kafka.Connect.Data.SchemaBuilder Bool()
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Connect.Data.SchemaBuilder>(LocalBridgeClazz, "bool", "()Lorg/apache/kafka/connect/data/SchemaBuilder;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/SchemaBuilder.html#bytes--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public static Org.Apache.Kafka.Connect.Data.SchemaBuilder Bytes()
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Connect.Data.SchemaBuilder>(LocalBridgeClazz, "bytes", "()Lorg/apache/kafka/connect/data/SchemaBuilder;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/SchemaBuilder.html#float32--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public static Org.Apache.Kafka.Connect.Data.SchemaBuilder Float32()
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Connect.Data.SchemaBuilder>(LocalBridgeClazz, "float32", "()Lorg/apache/kafka/connect/data/SchemaBuilder;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/SchemaBuilder.html#float64--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public static Org.Apache.Kafka.Connect.Data.SchemaBuilder Float64()
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Connect.Data.SchemaBuilder>(LocalBridgeClazz, "float64", "()Lorg/apache/kafka/connect/data/SchemaBuilder;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/SchemaBuilder.html#int16--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public static Org.Apache.Kafka.Connect.Data.SchemaBuilder Int16()
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Connect.Data.SchemaBuilder>(LocalBridgeClazz, "int16", "()Lorg/apache/kafka/connect/data/SchemaBuilder;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/SchemaBuilder.html#int32--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public static Org.Apache.Kafka.Connect.Data.SchemaBuilder Int32()
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Connect.Data.SchemaBuilder>(LocalBridgeClazz, "int32", "()Lorg/apache/kafka/connect/data/SchemaBuilder;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/SchemaBuilder.html#int64--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public static Org.Apache.Kafka.Connect.Data.SchemaBuilder Int64()
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Connect.Data.SchemaBuilder>(LocalBridgeClazz, "int64", "()Lorg/apache/kafka/connect/data/SchemaBuilder;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/SchemaBuilder.html#int8--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public static Org.Apache.Kafka.Connect.Data.SchemaBuilder Int8()
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Connect.Data.SchemaBuilder>(LocalBridgeClazz, "int8", "()Lorg/apache/kafka/connect/data/SchemaBuilder;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/SchemaBuilder.html#map-org.apache.kafka.connect.data.Schema-org.apache.kafka.connect.data.Schema-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public static Org.Apache.Kafka.Connect.Data.SchemaBuilder Map(Org.Apache.Kafka.Connect.Data.Schema arg0, Org.Apache.Kafka.Connect.Data.Schema arg1)
        {
            return SExecute<Org.Apache.Kafka.Connect.Data.SchemaBuilder>(LocalBridgeClazz, "map", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/SchemaBuilder.html#string--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public static Org.Apache.Kafka.Connect.Data.SchemaBuilder String()
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Connect.Data.SchemaBuilder>(LocalBridgeClazz, "string", "()Lorg/apache/kafka/connect/data/SchemaBuilder;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/SchemaBuilder.html#struct--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public static Org.Apache.Kafka.Connect.Data.SchemaBuilder Struct()
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Connect.Data.SchemaBuilder>(LocalBridgeClazz, "struct", "()Lorg/apache/kafka/connect/data/SchemaBuilder;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/SchemaBuilder.html#type-org.apache.kafka.connect.data.Schema.Type-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Data.Schema.Type"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public static Org.Apache.Kafka.Connect.Data.SchemaBuilder Type(Org.Apache.Kafka.Connect.Data.Schema.Type arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Connect.Data.SchemaBuilder>(LocalBridgeClazz, "type", "(Lorg/apache/kafka/connect/data/Schema$Type;)Lorg/apache/kafka/connect/data/SchemaBuilder;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/SchemaBuilder.html#isOptional--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsOptional()
        {
            return IExecuteWithSignature<bool>("isOptional", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/SchemaBuilder.html#version--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        public Java.Lang.Integer Version()
        {
            return IExecuteWithSignature<Java.Lang.Integer>("version", "()Ljava/lang/Integer;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/SchemaBuilder.html#defaultValue--"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object DefaultValue()
        {
            return IExecuteWithSignature("defaultValue", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/SchemaBuilder.html#doc--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Doc()
        {
            return IExecuteWithSignature<Java.Lang.String>("doc", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/SchemaBuilder.html#name--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Name()
        {
            return IExecuteWithSignature<Java.Lang.String>("name", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/SchemaBuilder.html#fields--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Org.Apache.Kafka.Connect.Data.Field> Fields()
        {
            return IExecuteWithSignature<Java.Util.List<Org.Apache.Kafka.Connect.Data.Field>>("fields", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/SchemaBuilder.html#parameters--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, Java.Lang.String> Parameters()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Lang.String>>("parameters", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/SchemaBuilder.html#field-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Field"/></returns>
        public Org.Apache.Kafka.Connect.Data.Field Field(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Data.Field>("field", "(Ljava/lang/String;)Lorg/apache/kafka/connect/data/Field;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/SchemaBuilder.html#build--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></returns>
        public Org.Apache.Kafka.Connect.Data.Schema Build()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Data.Schema>("build", "()Lorg/apache/kafka/connect/data/Schema;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/SchemaBuilder.html#keySchema--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></returns>
        public Org.Apache.Kafka.Connect.Data.Schema KeySchema()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Data.Schema>("keySchema", "()Lorg/apache/kafka/connect/data/Schema;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/SchemaBuilder.html#schema--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></returns>
        public Org.Apache.Kafka.Connect.Data.Schema Schema()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Data.Schema>("schema", "()Lorg/apache/kafka/connect/data/Schema;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/SchemaBuilder.html#valueSchema--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></returns>
        public Org.Apache.Kafka.Connect.Data.Schema ValueSchema()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Data.Schema>("valueSchema", "()Lorg/apache/kafka/connect/data/Schema;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/SchemaBuilder.html#type--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Schema.Type"/></returns>
        public Org.Apache.Kafka.Connect.Data.Schema.Type Type()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Data.Schema.Type>("type", "()Lorg/apache/kafka/connect/data/Schema$Type;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/SchemaBuilder.html#defaultValue-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public Org.Apache.Kafka.Connect.Data.SchemaBuilder DefaultValue(object arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Data.SchemaBuilder>("defaultValue", "(Ljava/lang/Object;)Lorg/apache/kafka/connect/data/SchemaBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/SchemaBuilder.html#doc-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public Org.Apache.Kafka.Connect.Data.SchemaBuilder Doc(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Data.SchemaBuilder>("doc", "(Ljava/lang/String;)Lorg/apache/kafka/connect/data/SchemaBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/SchemaBuilder.html#field-java.lang.String-org.apache.kafka.connect.data.Schema-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public Org.Apache.Kafka.Connect.Data.SchemaBuilder Field(Java.Lang.String arg0, Org.Apache.Kafka.Connect.Data.Schema arg1)
        {
            return IExecute<Org.Apache.Kafka.Connect.Data.SchemaBuilder>("field", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/SchemaBuilder.html#name-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public Org.Apache.Kafka.Connect.Data.SchemaBuilder Name(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Data.SchemaBuilder>("name", "(Ljava/lang/String;)Lorg/apache/kafka/connect/data/SchemaBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/SchemaBuilder.html#optional--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public Org.Apache.Kafka.Connect.Data.SchemaBuilder Optional()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Data.SchemaBuilder>("optional", "()Lorg/apache/kafka/connect/data/SchemaBuilder;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/SchemaBuilder.html#parameter-java.lang.String-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public Org.Apache.Kafka.Connect.Data.SchemaBuilder Parameter(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Org.Apache.Kafka.Connect.Data.SchemaBuilder>("parameter", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/SchemaBuilder.html#parameters-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public Org.Apache.Kafka.Connect.Data.SchemaBuilder Parameters(Java.Util.Map<Java.Lang.String, Java.Lang.String> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Data.SchemaBuilder>("parameters", "(Ljava/util/Map;)Lorg/apache/kafka/connect/data/SchemaBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/SchemaBuilder.html#required--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public Org.Apache.Kafka.Connect.Data.SchemaBuilder Required()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Data.SchemaBuilder>("required", "()Lorg/apache/kafka/connect/data/SchemaBuilder;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/SchemaBuilder.html#version-java.lang.Integer-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Integer"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public Org.Apache.Kafka.Connect.Data.SchemaBuilder Version(Java.Lang.Integer arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Data.SchemaBuilder>("version", "(Ljava/lang/Integer;)Lorg/apache/kafka/connect/data/SchemaBuilder;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}