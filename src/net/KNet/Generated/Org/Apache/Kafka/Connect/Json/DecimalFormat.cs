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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using connect-json-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Json
{
    #region DecimalFormat
    public partial class DecimalFormat
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-json/3.4.0/org/apache/kafka/connect/json/DecimalFormat.html#BASE64"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Json.DecimalFormat BASE64 { get { return SGetField<Org.Apache.Kafka.Connect.Json.DecimalFormat>(LocalBridgeClazz, "BASE64"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-json/3.4.0/org/apache/kafka/connect/json/DecimalFormat.html#NUMERIC"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Json.DecimalFormat NUMERIC { get { return SGetField<Org.Apache.Kafka.Connect.Json.DecimalFormat>(LocalBridgeClazz, "NUMERIC"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-json/3.4.0/org/apache/kafka/connect/json/DecimalFormat.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Json.DecimalFormat"/></returns>
        public static Org.Apache.Kafka.Connect.Json.DecimalFormat ValueOf(string arg0)
        {
            return SExecute<Org.Apache.Kafka.Connect.Json.DecimalFormat>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-json/3.4.0/org/apache/kafka/connect/json/DecimalFormat.html#values()"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Connect.Json.DecimalFormat"/></returns>
        public static Org.Apache.Kafka.Connect.Json.DecimalFormat[] Values()
        {
            return SExecuteArray<Org.Apache.Kafka.Connect.Json.DecimalFormat>(LocalBridgeClazz, "values");
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