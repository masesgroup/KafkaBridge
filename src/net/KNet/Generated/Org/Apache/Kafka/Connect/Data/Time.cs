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
*  using connect-api-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Data
{
    #region Time
    public partial class Time
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/Time.html#LOGICAL_NAME"/>
        /// </summary>
        public static Java.Lang.String LOGICAL_NAME { get { if (!_LOGICAL_NAMEReady) { _LOGICAL_NAMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "LOGICAL_NAME"); _LOGICAL_NAMEReady = true; } return _LOGICAL_NAMEContent; } }
        private static Java.Lang.String _LOGICAL_NAMEContent = default;
        private static bool _LOGICAL_NAMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/Time.html#SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema SCHEMA { get { if (!_SCHEMAReady) { _SCHEMAContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "SCHEMA"); _SCHEMAReady = true; } return _SCHEMAContent; } }
        private static Org.Apache.Kafka.Connect.Data.Schema _SCHEMAContent = default;
        private static bool _SCHEMAReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/Time.html#fromLogical-org.apache.kafka.connect.data.Schema-java.util.Date-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg1"><see cref="Java.Util.Date"/></param>
        /// <returns><see cref="int"/></returns>
        public static int FromLogical(Org.Apache.Kafka.Connect.Data.Schema arg0, Java.Util.Date arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "fromLogical", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/Time.html#toLogical-org.apache.kafka.connect.data.Schema-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Date"/></returns>
        public static Java.Util.Date ToLogical(Org.Apache.Kafka.Connect.Data.Schema arg0, int arg1)
        {
            return SExecute<Java.Util.Date>(LocalBridgeClazz, "toLogical", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/Time.html#builder--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public static Org.Apache.Kafka.Connect.Data.SchemaBuilder Builder()
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Connect.Data.SchemaBuilder>(LocalBridgeClazz, "builder", "()Lorg/apache/kafka/connect/data/SchemaBuilder;");
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