/*
*  Copyright 2023 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using connect-api-3.6.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Data
{
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

    #region Schema
    public partial class Schema : Org.Apache.Kafka.Connect.Data.ISchema
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.html#BOOLEAN_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema BOOLEAN_SCHEMA { get { return SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "BOOLEAN_SCHEMA"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.html#BYTES_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema BYTES_SCHEMA { get { return SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "BYTES_SCHEMA"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.html#FLOAT32_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema FLOAT32_SCHEMA { get { return SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "FLOAT32_SCHEMA"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.html#FLOAT64_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema FLOAT64_SCHEMA { get { return SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "FLOAT64_SCHEMA"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.html#INT16_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema INT16_SCHEMA { get { return SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "INT16_SCHEMA"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.html#INT32_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema INT32_SCHEMA { get { return SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "INT32_SCHEMA"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.html#INT64_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema INT64_SCHEMA { get { return SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "INT64_SCHEMA"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.html#INT8_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema INT8_SCHEMA { get { return SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "INT8_SCHEMA"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.html#OPTIONAL_BOOLEAN_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema OPTIONAL_BOOLEAN_SCHEMA { get { return SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "OPTIONAL_BOOLEAN_SCHEMA"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.html#OPTIONAL_BYTES_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema OPTIONAL_BYTES_SCHEMA { get { return SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "OPTIONAL_BYTES_SCHEMA"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.html#OPTIONAL_FLOAT32_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema OPTIONAL_FLOAT32_SCHEMA { get { return SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "OPTIONAL_FLOAT32_SCHEMA"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.html#OPTIONAL_FLOAT64_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema OPTIONAL_FLOAT64_SCHEMA { get { return SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "OPTIONAL_FLOAT64_SCHEMA"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.html#OPTIONAL_INT16_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema OPTIONAL_INT16_SCHEMA { get { return SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "OPTIONAL_INT16_SCHEMA"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.html#OPTIONAL_INT32_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema OPTIONAL_INT32_SCHEMA { get { return SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "OPTIONAL_INT32_SCHEMA"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.html#OPTIONAL_INT64_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema OPTIONAL_INT64_SCHEMA { get { return SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "OPTIONAL_INT64_SCHEMA"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.html#OPTIONAL_INT8_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema OPTIONAL_INT8_SCHEMA { get { return SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "OPTIONAL_INT8_SCHEMA"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.html#OPTIONAL_STRING_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema OPTIONAL_STRING_SCHEMA { get { return SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "OPTIONAL_STRING_SCHEMA"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.html#STRING_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema STRING_SCHEMA { get { return SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "STRING_SCHEMA"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.html#isOptional--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsOptional()
        {
            return IExecute<bool>("isOptional");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.html#version--"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.Integer"/></returns>
        public Java.Lang.Integer Version()
        {
            return IExecute<Java.Lang.Integer>("version");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.html#defaultValue--"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object DefaultValue()
        {
            return IExecute("defaultValue");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.html#doc--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string Doc()
        {
            return IExecute<string>("doc");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.html#name--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string Name()
        {
            return IExecute<string>("name");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.html#fields--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Org.Apache.Kafka.Connect.Data.Field> Fields()
        {
            return IExecute<Java.Util.List<Org.Apache.Kafka.Connect.Data.Field>>("fields");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.html#parameters--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<string, string> Parameters()
        {
            return IExecute<Java.Util.Map<string, string>>("parameters");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.html#field-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Field"/></returns>
        public Org.Apache.Kafka.Connect.Data.Field Field(string arg0)
        {
            return IExecute<Org.Apache.Kafka.Connect.Data.Field>("field", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.html#keySchema--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></returns>
        public Org.Apache.Kafka.Connect.Data.Schema KeySchema()
        {
            return IExecute<Org.Apache.Kafka.Connect.Data.Schema>("keySchema");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.html#schema--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></returns>
        public Org.Apache.Kafka.Connect.Data.Schema SchemaMethod()
        {
            return IExecute<Org.Apache.Kafka.Connect.Data.Schema>("schema");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.html#valueSchema--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></returns>
        public Org.Apache.Kafka.Connect.Data.Schema ValueSchema()
        {
            return IExecute<Org.Apache.Kafka.Connect.Data.Schema>("valueSchema");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.html#type--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Schema.Type"/></returns>
        public Org.Apache.Kafka.Connect.Data.Schema.Type TypeMethod()
        {
            return IExecute<Org.Apache.Kafka.Connect.Data.Schema.Type>("type");
        }

        #endregion

        #region Nested classes
        #region Type
        public partial class Type
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.Type.html#ARRAY"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type ARRAY { get { return SGetField<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "ARRAY"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.Type.html#BOOLEAN"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type BOOLEAN { get { return SGetField<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "BOOLEAN"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.Type.html#BYTES"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type BYTES { get { return SGetField<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "BYTES"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.Type.html#FLOAT32"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type FLOAT32 { get { return SGetField<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "FLOAT32"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.Type.html#FLOAT64"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type FLOAT64 { get { return SGetField<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "FLOAT64"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.Type.html#INT16"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type INT16 { get { return SGetField<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "INT16"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.Type.html#INT32"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type INT32 { get { return SGetField<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "INT32"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.Type.html#INT64"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type INT64 { get { return SGetField<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "INT64"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.Type.html#INT8"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type INT8 { get { return SGetField<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "INT8"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.Type.html#MAP"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type MAP { get { return SGetField<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "MAP"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.Type.html#STRING"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type STRING { get { return SGetField<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "STRING"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.Type.html#STRUCT"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type STRUCT { get { return SGetField<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "STRUCT"); } }

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.Type.html#valueOf-java.lang.String-"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Schema.Type"/></returns>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type ValueOf(string arg0)
            {
                return SExecute<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "valueOf", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.Type.html#values--"/>
            /// </summary>

            /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Schema.Type"/></returns>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type[] Values()
            {
                return SExecuteArray<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "values");
            }

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.Type.html#getName--"/> 
            /// </summary>
            public string Name
            {
                get { return IExecute<string>("getName"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.0/org/apache/kafka/connect/data/Schema.Type.html#isPrimitive--"/>
            /// </summary>

            /// <returns><see cref="bool"/></returns>
            public bool IsPrimitive()
            {
                return IExecute<bool>("isPrimitive");
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