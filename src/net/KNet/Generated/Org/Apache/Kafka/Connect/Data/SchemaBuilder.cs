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
*  This file is generated by MASES.JNetReflector (ver. 2.2.4.0)
*  using connect-api-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Data
{
    #region SchemaBuilder
    public partial class SchemaBuilder
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/SchemaBuilder.html#org.apache.kafka.connect.data.SchemaBuilder(org.apache.kafka.connect.data.Schema.Type)"/>
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/SchemaBuilder.html#array-org.apache.kafka.connect.data.Schema-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public static Org.Apache.Kafka.Connect.Data.SchemaBuilder Array(Org.Apache.Kafka.Connect.Data.Schema arg0)
        {
            return SExecute<Org.Apache.Kafka.Connect.Data.SchemaBuilder>(LocalBridgeClazz, "array", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/SchemaBuilder.html#bool--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public static Org.Apache.Kafka.Connect.Data.SchemaBuilder Bool()
        {
            return SExecute<Org.Apache.Kafka.Connect.Data.SchemaBuilder>(LocalBridgeClazz, "bool");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/SchemaBuilder.html#bytes--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public static Org.Apache.Kafka.Connect.Data.SchemaBuilder Bytes()
        {
            return SExecute<Org.Apache.Kafka.Connect.Data.SchemaBuilder>(LocalBridgeClazz, "bytes");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/SchemaBuilder.html#float32--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public static Org.Apache.Kafka.Connect.Data.SchemaBuilder Float32()
        {
            return SExecute<Org.Apache.Kafka.Connect.Data.SchemaBuilder>(LocalBridgeClazz, "float32");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/SchemaBuilder.html#float64--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public static Org.Apache.Kafka.Connect.Data.SchemaBuilder Float64()
        {
            return SExecute<Org.Apache.Kafka.Connect.Data.SchemaBuilder>(LocalBridgeClazz, "float64");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/SchemaBuilder.html#int16--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public static Org.Apache.Kafka.Connect.Data.SchemaBuilder Int16()
        {
            return SExecute<Org.Apache.Kafka.Connect.Data.SchemaBuilder>(LocalBridgeClazz, "int16");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/SchemaBuilder.html#int32--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public static Org.Apache.Kafka.Connect.Data.SchemaBuilder Int32()
        {
            return SExecute<Org.Apache.Kafka.Connect.Data.SchemaBuilder>(LocalBridgeClazz, "int32");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/SchemaBuilder.html#int64--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public static Org.Apache.Kafka.Connect.Data.SchemaBuilder Int64()
        {
            return SExecute<Org.Apache.Kafka.Connect.Data.SchemaBuilder>(LocalBridgeClazz, "int64");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/SchemaBuilder.html#int8--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public static Org.Apache.Kafka.Connect.Data.SchemaBuilder Int8()
        {
            return SExecute<Org.Apache.Kafka.Connect.Data.SchemaBuilder>(LocalBridgeClazz, "int8");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/SchemaBuilder.html#map-org.apache.kafka.connect.data.Schema-org.apache.kafka.connect.data.Schema-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public static Org.Apache.Kafka.Connect.Data.SchemaBuilder Map(Org.Apache.Kafka.Connect.Data.Schema arg0, Org.Apache.Kafka.Connect.Data.Schema arg1)
        {
            return SExecute<Org.Apache.Kafka.Connect.Data.SchemaBuilder>(LocalBridgeClazz, "map", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/SchemaBuilder.html#string--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public static Org.Apache.Kafka.Connect.Data.SchemaBuilder String()
        {
            return SExecute<Org.Apache.Kafka.Connect.Data.SchemaBuilder>(LocalBridgeClazz, "string");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/SchemaBuilder.html#struct--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public static Org.Apache.Kafka.Connect.Data.SchemaBuilder Struct()
        {
            return SExecute<Org.Apache.Kafka.Connect.Data.SchemaBuilder>(LocalBridgeClazz, "struct");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/SchemaBuilder.html#type-org.apache.kafka.connect.data.Schema.Type-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Data.Schema.Type"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public static Org.Apache.Kafka.Connect.Data.SchemaBuilder Type(Org.Apache.Kafka.Connect.Data.Schema.Type arg0)
        {
            return SExecute<Org.Apache.Kafka.Connect.Data.SchemaBuilder>(LocalBridgeClazz, "type", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/SchemaBuilder.html#isOptional--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsOptional()
        {
            return IExecute<bool>("isOptional");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/SchemaBuilder.html#version--"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.Integer"/></returns>
        public Java.Lang.Integer Version()
        {
            return IExecute<Java.Lang.Integer>("version");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/SchemaBuilder.html#defaultValue--"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object DefaultValue()
        {
            return IExecute("defaultValue");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/SchemaBuilder.html#doc--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string Doc()
        {
            return IExecute<string>("doc");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/SchemaBuilder.html#name--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string Name()
        {
            return IExecute<string>("name");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/SchemaBuilder.html#fields--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Org.Apache.Kafka.Connect.Data.Field> Fields()
        {
            return IExecute<Java.Util.List<Org.Apache.Kafka.Connect.Data.Field>>("fields");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/SchemaBuilder.html#parameters--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<string, string> Parameters()
        {
            return IExecute<Java.Util.Map<string, string>>("parameters");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/SchemaBuilder.html#field-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Field"/></returns>
        public Org.Apache.Kafka.Connect.Data.Field Field(string arg0)
        {
            return IExecute<Org.Apache.Kafka.Connect.Data.Field>("field", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/SchemaBuilder.html#build--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></returns>
        public Org.Apache.Kafka.Connect.Data.Schema Build()
        {
            return IExecute<Org.Apache.Kafka.Connect.Data.Schema>("build");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/SchemaBuilder.html#keySchema--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></returns>
        public Org.Apache.Kafka.Connect.Data.Schema KeySchema()
        {
            return IExecute<Org.Apache.Kafka.Connect.Data.Schema>("keySchema");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/SchemaBuilder.html#schema--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></returns>
        public Org.Apache.Kafka.Connect.Data.Schema Schema()
        {
            return IExecute<Org.Apache.Kafka.Connect.Data.Schema>("schema");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/SchemaBuilder.html#valueSchema--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></returns>
        public Org.Apache.Kafka.Connect.Data.Schema ValueSchema()
        {
            return IExecute<Org.Apache.Kafka.Connect.Data.Schema>("valueSchema");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/SchemaBuilder.html#type--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Schema.Type"/></returns>
        public Org.Apache.Kafka.Connect.Data.Schema.Type Type()
        {
            return IExecute<Org.Apache.Kafka.Connect.Data.Schema.Type>("type");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/SchemaBuilder.html#defaultValue-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public Org.Apache.Kafka.Connect.Data.SchemaBuilder DefaultValue(object arg0)
        {
            return IExecute<Org.Apache.Kafka.Connect.Data.SchemaBuilder>("defaultValue", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/SchemaBuilder.html#doc-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public Org.Apache.Kafka.Connect.Data.SchemaBuilder Doc(string arg0)
        {
            return IExecute<Org.Apache.Kafka.Connect.Data.SchemaBuilder>("doc", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/SchemaBuilder.html#field-java.lang.String-org.apache.kafka.connect.data.Schema-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public Org.Apache.Kafka.Connect.Data.SchemaBuilder Field(string arg0, Org.Apache.Kafka.Connect.Data.Schema arg1)
        {
            return IExecute<Org.Apache.Kafka.Connect.Data.SchemaBuilder>("field", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/SchemaBuilder.html#name-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public Org.Apache.Kafka.Connect.Data.SchemaBuilder Name(string arg0)
        {
            return IExecute<Org.Apache.Kafka.Connect.Data.SchemaBuilder>("name", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/SchemaBuilder.html#optional--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public Org.Apache.Kafka.Connect.Data.SchemaBuilder Optional()
        {
            return IExecute<Org.Apache.Kafka.Connect.Data.SchemaBuilder>("optional");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/SchemaBuilder.html#parameter-java.lang.String-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public Org.Apache.Kafka.Connect.Data.SchemaBuilder Parameter(string arg0, string arg1)
        {
            return IExecute<Org.Apache.Kafka.Connect.Data.SchemaBuilder>("parameter", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/SchemaBuilder.html#parameters-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public Org.Apache.Kafka.Connect.Data.SchemaBuilder Parameters(Java.Util.Map<string, string> arg0)
        {
            return IExecute<Org.Apache.Kafka.Connect.Data.SchemaBuilder>("parameters", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/SchemaBuilder.html#required--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public Org.Apache.Kafka.Connect.Data.SchemaBuilder Required()
        {
            return IExecute<Org.Apache.Kafka.Connect.Data.SchemaBuilder>("required");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/SchemaBuilder.html#version-java.lang.Integer-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Integer"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public Org.Apache.Kafka.Connect.Data.SchemaBuilder Version(Java.Lang.Integer arg0)
        {
            return IExecute<Org.Apache.Kafka.Connect.Data.SchemaBuilder>("version", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}