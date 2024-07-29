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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using connect-api-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Data
{
    #region Decimal
    public partial class Decimal
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/Decimal.html#LOGICAL_NAME"/>
        /// </summary>
        public static Java.Lang.String LOGICAL_NAME { get { if (!_LOGICAL_NAMEReady) { _LOGICAL_NAMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "LOGICAL_NAME"); _LOGICAL_NAMEReady = true; } return _LOGICAL_NAMEContent; } }
        private static Java.Lang.String _LOGICAL_NAMEContent = default;
        private static bool _LOGICAL_NAMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/Decimal.html#SCALE_FIELD"/>
        /// </summary>
        public static Java.Lang.String SCALE_FIELD { get { if (!_SCALE_FIELDReady) { _SCALE_FIELDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SCALE_FIELD"); _SCALE_FIELDReady = true; } return _SCALE_FIELDContent; } }
        private static Java.Lang.String _SCALE_FIELDContent = default;
        private static bool _SCALE_FIELDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/Decimal.html#fromLogical-org.apache.kafka.connect.data.Schema-java.math.BigDecimal-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg1"><see cref="Java.Math.BigDecimal"/></param>
        /// <returns><see cref="byte"/></returns>
        public static byte[] FromLogical(Org.Apache.Kafka.Connect.Data.Schema arg0, Java.Math.BigDecimal arg1)
        {
            return SExecuteArray<byte>(LocalBridgeClazz, "fromLogical", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/Decimal.html#toLogical-org.apache.kafka.connect.data.Schema-byte[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public static Java.Math.BigDecimal ToLogical(Org.Apache.Kafka.Connect.Data.Schema arg0, byte[] arg1)
        {
            return SExecute<Java.Math.BigDecimal>(LocalBridgeClazz, "toLogical", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/Decimal.html#schema-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></returns>
        public static Org.Apache.Kafka.Connect.Data.Schema Schema(int arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "schema", "(I)Lorg/apache/kafka/connect/data/Schema;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/Decimal.html#builder-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public static Org.Apache.Kafka.Connect.Data.SchemaBuilder Builder(int arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Connect.Data.SchemaBuilder>(LocalBridgeClazz, "builder", "(I)Lorg/apache/kafka/connect/data/SchemaBuilder;", arg0);
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