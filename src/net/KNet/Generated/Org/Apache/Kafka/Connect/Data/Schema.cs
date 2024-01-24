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
*  This file is generated by MASES.JNetReflector (ver. 2.2.3.0)
*  using connect-api-3.6.1.jar as reference
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.html#BOOLEAN_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema BOOLEAN_SCHEMA { get { if (!_BOOLEAN_SCHEMAReady) { _BOOLEAN_SCHEMAContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "BOOLEAN_SCHEMA"); _BOOLEAN_SCHEMAReady = true; } return _BOOLEAN_SCHEMAContent; } }
        private static Org.Apache.Kafka.Connect.Data.Schema _BOOLEAN_SCHEMAContent = default;
        private static bool _BOOLEAN_SCHEMAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.html#BYTES_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema BYTES_SCHEMA { get { if (!_BYTES_SCHEMAReady) { _BYTES_SCHEMAContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "BYTES_SCHEMA"); _BYTES_SCHEMAReady = true; } return _BYTES_SCHEMAContent; } }
        private static Org.Apache.Kafka.Connect.Data.Schema _BYTES_SCHEMAContent = default;
        private static bool _BYTES_SCHEMAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.html#FLOAT32_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema FLOAT32_SCHEMA { get { if (!_FLOAT32_SCHEMAReady) { _FLOAT32_SCHEMAContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "FLOAT32_SCHEMA"); _FLOAT32_SCHEMAReady = true; } return _FLOAT32_SCHEMAContent; } }
        private static Org.Apache.Kafka.Connect.Data.Schema _FLOAT32_SCHEMAContent = default;
        private static bool _FLOAT32_SCHEMAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.html#FLOAT64_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema FLOAT64_SCHEMA { get { if (!_FLOAT64_SCHEMAReady) { _FLOAT64_SCHEMAContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "FLOAT64_SCHEMA"); _FLOAT64_SCHEMAReady = true; } return _FLOAT64_SCHEMAContent; } }
        private static Org.Apache.Kafka.Connect.Data.Schema _FLOAT64_SCHEMAContent = default;
        private static bool _FLOAT64_SCHEMAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.html#INT16_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema INT16_SCHEMA { get { if (!_INT16_SCHEMAReady) { _INT16_SCHEMAContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "INT16_SCHEMA"); _INT16_SCHEMAReady = true; } return _INT16_SCHEMAContent; } }
        private static Org.Apache.Kafka.Connect.Data.Schema _INT16_SCHEMAContent = default;
        private static bool _INT16_SCHEMAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.html#INT32_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema INT32_SCHEMA { get { if (!_INT32_SCHEMAReady) { _INT32_SCHEMAContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "INT32_SCHEMA"); _INT32_SCHEMAReady = true; } return _INT32_SCHEMAContent; } }
        private static Org.Apache.Kafka.Connect.Data.Schema _INT32_SCHEMAContent = default;
        private static bool _INT32_SCHEMAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.html#INT64_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema INT64_SCHEMA { get { if (!_INT64_SCHEMAReady) { _INT64_SCHEMAContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "INT64_SCHEMA"); _INT64_SCHEMAReady = true; } return _INT64_SCHEMAContent; } }
        private static Org.Apache.Kafka.Connect.Data.Schema _INT64_SCHEMAContent = default;
        private static bool _INT64_SCHEMAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.html#INT8_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema INT8_SCHEMA { get { if (!_INT8_SCHEMAReady) { _INT8_SCHEMAContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "INT8_SCHEMA"); _INT8_SCHEMAReady = true; } return _INT8_SCHEMAContent; } }
        private static Org.Apache.Kafka.Connect.Data.Schema _INT8_SCHEMAContent = default;
        private static bool _INT8_SCHEMAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.html#OPTIONAL_BOOLEAN_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema OPTIONAL_BOOLEAN_SCHEMA { get { if (!_OPTIONAL_BOOLEAN_SCHEMAReady) { _OPTIONAL_BOOLEAN_SCHEMAContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "OPTIONAL_BOOLEAN_SCHEMA"); _OPTIONAL_BOOLEAN_SCHEMAReady = true; } return _OPTIONAL_BOOLEAN_SCHEMAContent; } }
        private static Org.Apache.Kafka.Connect.Data.Schema _OPTIONAL_BOOLEAN_SCHEMAContent = default;
        private static bool _OPTIONAL_BOOLEAN_SCHEMAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.html#OPTIONAL_BYTES_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema OPTIONAL_BYTES_SCHEMA { get { if (!_OPTIONAL_BYTES_SCHEMAReady) { _OPTIONAL_BYTES_SCHEMAContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "OPTIONAL_BYTES_SCHEMA"); _OPTIONAL_BYTES_SCHEMAReady = true; } return _OPTIONAL_BYTES_SCHEMAContent; } }
        private static Org.Apache.Kafka.Connect.Data.Schema _OPTIONAL_BYTES_SCHEMAContent = default;
        private static bool _OPTIONAL_BYTES_SCHEMAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.html#OPTIONAL_FLOAT32_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema OPTIONAL_FLOAT32_SCHEMA { get { if (!_OPTIONAL_FLOAT32_SCHEMAReady) { _OPTIONAL_FLOAT32_SCHEMAContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "OPTIONAL_FLOAT32_SCHEMA"); _OPTIONAL_FLOAT32_SCHEMAReady = true; } return _OPTIONAL_FLOAT32_SCHEMAContent; } }
        private static Org.Apache.Kafka.Connect.Data.Schema _OPTIONAL_FLOAT32_SCHEMAContent = default;
        private static bool _OPTIONAL_FLOAT32_SCHEMAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.html#OPTIONAL_FLOAT64_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema OPTIONAL_FLOAT64_SCHEMA { get { if (!_OPTIONAL_FLOAT64_SCHEMAReady) { _OPTIONAL_FLOAT64_SCHEMAContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "OPTIONAL_FLOAT64_SCHEMA"); _OPTIONAL_FLOAT64_SCHEMAReady = true; } return _OPTIONAL_FLOAT64_SCHEMAContent; } }
        private static Org.Apache.Kafka.Connect.Data.Schema _OPTIONAL_FLOAT64_SCHEMAContent = default;
        private static bool _OPTIONAL_FLOAT64_SCHEMAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.html#OPTIONAL_INT16_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema OPTIONAL_INT16_SCHEMA { get { if (!_OPTIONAL_INT16_SCHEMAReady) { _OPTIONAL_INT16_SCHEMAContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "OPTIONAL_INT16_SCHEMA"); _OPTIONAL_INT16_SCHEMAReady = true; } return _OPTIONAL_INT16_SCHEMAContent; } }
        private static Org.Apache.Kafka.Connect.Data.Schema _OPTIONAL_INT16_SCHEMAContent = default;
        private static bool _OPTIONAL_INT16_SCHEMAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.html#OPTIONAL_INT32_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema OPTIONAL_INT32_SCHEMA { get { if (!_OPTIONAL_INT32_SCHEMAReady) { _OPTIONAL_INT32_SCHEMAContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "OPTIONAL_INT32_SCHEMA"); _OPTIONAL_INT32_SCHEMAReady = true; } return _OPTIONAL_INT32_SCHEMAContent; } }
        private static Org.Apache.Kafka.Connect.Data.Schema _OPTIONAL_INT32_SCHEMAContent = default;
        private static bool _OPTIONAL_INT32_SCHEMAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.html#OPTIONAL_INT64_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema OPTIONAL_INT64_SCHEMA { get { if (!_OPTIONAL_INT64_SCHEMAReady) { _OPTIONAL_INT64_SCHEMAContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "OPTIONAL_INT64_SCHEMA"); _OPTIONAL_INT64_SCHEMAReady = true; } return _OPTIONAL_INT64_SCHEMAContent; } }
        private static Org.Apache.Kafka.Connect.Data.Schema _OPTIONAL_INT64_SCHEMAContent = default;
        private static bool _OPTIONAL_INT64_SCHEMAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.html#OPTIONAL_INT8_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema OPTIONAL_INT8_SCHEMA { get { if (!_OPTIONAL_INT8_SCHEMAReady) { _OPTIONAL_INT8_SCHEMAContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "OPTIONAL_INT8_SCHEMA"); _OPTIONAL_INT8_SCHEMAReady = true; } return _OPTIONAL_INT8_SCHEMAContent; } }
        private static Org.Apache.Kafka.Connect.Data.Schema _OPTIONAL_INT8_SCHEMAContent = default;
        private static bool _OPTIONAL_INT8_SCHEMAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.html#OPTIONAL_STRING_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema OPTIONAL_STRING_SCHEMA { get { if (!_OPTIONAL_STRING_SCHEMAReady) { _OPTIONAL_STRING_SCHEMAContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "OPTIONAL_STRING_SCHEMA"); _OPTIONAL_STRING_SCHEMAReady = true; } return _OPTIONAL_STRING_SCHEMAContent; } }
        private static Org.Apache.Kafka.Connect.Data.Schema _OPTIONAL_STRING_SCHEMAContent = default;
        private static bool _OPTIONAL_STRING_SCHEMAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.html#STRING_SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema STRING_SCHEMA { get { if (!_STRING_SCHEMAReady) { _STRING_SCHEMAContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "STRING_SCHEMA"); _STRING_SCHEMAReady = true; } return _STRING_SCHEMAContent; } }
        private static Org.Apache.Kafka.Connect.Data.Schema _STRING_SCHEMAContent = default;
        private static bool _STRING_SCHEMAReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.html#isOptional--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsOptional()
        {
            return IExecute<bool>("isOptional");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.html#version--"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.Integer"/></returns>
        public Java.Lang.Integer Version()
        {
            return IExecute<Java.Lang.Integer>("version");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.html#defaultValue--"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object DefaultValue()
        {
            return IExecute("defaultValue");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.html#doc--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string Doc()
        {
            return IExecute<string>("doc");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.html#name--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string Name()
        {
            return IExecute<string>("name");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.html#fields--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Org.Apache.Kafka.Connect.Data.Field> Fields()
        {
            return IExecute<Java.Util.List<Org.Apache.Kafka.Connect.Data.Field>>("fields");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.html#parameters--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<string, string> Parameters()
        {
            return IExecute<Java.Util.Map<string, string>>("parameters");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.html#field-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Field"/></returns>
        public Org.Apache.Kafka.Connect.Data.Field Field(string arg0)
        {
            return IExecute<Org.Apache.Kafka.Connect.Data.Field>("field", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.html#keySchema--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></returns>
        public Org.Apache.Kafka.Connect.Data.Schema KeySchema()
        {
            return IExecute<Org.Apache.Kafka.Connect.Data.Schema>("keySchema");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.html#schema--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></returns>
        public Org.Apache.Kafka.Connect.Data.Schema SchemaMethod()
        {
            return IExecute<Org.Apache.Kafka.Connect.Data.Schema>("schema");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.html#valueSchema--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></returns>
        public Org.Apache.Kafka.Connect.Data.Schema ValueSchema()
        {
            return IExecute<Org.Apache.Kafka.Connect.Data.Schema>("valueSchema");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.html#type--"/>
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.Type.html#ARRAY"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type ARRAY { get { if (!_ARRAYReady) { _ARRAYContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "ARRAY"); _ARRAYReady = true; } return _ARRAYContent; } }
            private static Org.Apache.Kafka.Connect.Data.Schema.Type _ARRAYContent = default;
            private static bool _ARRAYReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.Type.html#BOOLEAN"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type BOOLEAN { get { if (!_BOOLEANReady) { _BOOLEANContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "BOOLEAN"); _BOOLEANReady = true; } return _BOOLEANContent; } }
            private static Org.Apache.Kafka.Connect.Data.Schema.Type _BOOLEANContent = default;
            private static bool _BOOLEANReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.Type.html#BYTES"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type BYTES { get { if (!_BYTESReady) { _BYTESContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "BYTES"); _BYTESReady = true; } return _BYTESContent; } }
            private static Org.Apache.Kafka.Connect.Data.Schema.Type _BYTESContent = default;
            private static bool _BYTESReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.Type.html#FLOAT32"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type FLOAT32 { get { if (!_FLOAT32Ready) { _FLOAT32Content = SGetField<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "FLOAT32"); _FLOAT32Ready = true; } return _FLOAT32Content; } }
            private static Org.Apache.Kafka.Connect.Data.Schema.Type _FLOAT32Content = default;
            private static bool _FLOAT32Ready = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.Type.html#FLOAT64"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type FLOAT64 { get { if (!_FLOAT64Ready) { _FLOAT64Content = SGetField<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "FLOAT64"); _FLOAT64Ready = true; } return _FLOAT64Content; } }
            private static Org.Apache.Kafka.Connect.Data.Schema.Type _FLOAT64Content = default;
            private static bool _FLOAT64Ready = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.Type.html#INT16"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type INT16 { get { if (!_INT16Ready) { _INT16Content = SGetField<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "INT16"); _INT16Ready = true; } return _INT16Content; } }
            private static Org.Apache.Kafka.Connect.Data.Schema.Type _INT16Content = default;
            private static bool _INT16Ready = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.Type.html#INT32"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type INT32 { get { if (!_INT32Ready) { _INT32Content = SGetField<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "INT32"); _INT32Ready = true; } return _INT32Content; } }
            private static Org.Apache.Kafka.Connect.Data.Schema.Type _INT32Content = default;
            private static bool _INT32Ready = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.Type.html#INT64"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type INT64 { get { if (!_INT64Ready) { _INT64Content = SGetField<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "INT64"); _INT64Ready = true; } return _INT64Content; } }
            private static Org.Apache.Kafka.Connect.Data.Schema.Type _INT64Content = default;
            private static bool _INT64Ready = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.Type.html#INT8"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type INT8 { get { if (!_INT8Ready) { _INT8Content = SGetField<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "INT8"); _INT8Ready = true; } return _INT8Content; } }
            private static Org.Apache.Kafka.Connect.Data.Schema.Type _INT8Content = default;
            private static bool _INT8Ready = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.Type.html#MAP"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type MAP { get { if (!_MAPReady) { _MAPContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "MAP"); _MAPReady = true; } return _MAPContent; } }
            private static Org.Apache.Kafka.Connect.Data.Schema.Type _MAPContent = default;
            private static bool _MAPReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.Type.html#STRING"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type STRING { get { if (!_STRINGReady) { _STRINGContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "STRING"); _STRINGReady = true; } return _STRINGContent; } }
            private static Org.Apache.Kafka.Connect.Data.Schema.Type _STRINGContent = default;
            private static bool _STRINGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.Type.html#STRUCT"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type STRUCT { get { if (!_STRUCTReady) { _STRUCTContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "STRUCT"); _STRUCTReady = true; } return _STRUCTContent; } }
            private static Org.Apache.Kafka.Connect.Data.Schema.Type _STRUCTContent = default;
            private static bool _STRUCTReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.Type.html#valueOf-java.lang.String-"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Schema.Type"/></returns>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type ValueOf(string arg0)
            {
                return SExecute<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "valueOf", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.Type.html#values--"/>
            /// </summary>

            /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Schema.Type"/></returns>
            public static Org.Apache.Kafka.Connect.Data.Schema.Type[] Values()
            {
                return SExecuteArray<Org.Apache.Kafka.Connect.Data.Schema.Type>(LocalBridgeClazz, "values");
            }

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.Type.html#getName--"/> 
            /// </summary>
            public string Name
            {
                get { return IExecute<string>("getName"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/data/Schema.Type.html#isPrimitive--"/>
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