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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using connect-api-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Health
{
    #region ConnectorType
    public partial class ConnectorType
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/health/ConnectorType.html#SINK"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Health.ConnectorType SINK { get { if (!_SINKReady) { _SINKContent = SGetField<Org.Apache.Kafka.Connect.Health.ConnectorType>(LocalBridgeClazz, "SINK"); _SINKReady = true; } return _SINKContent; } }
        private static Org.Apache.Kafka.Connect.Health.ConnectorType _SINKContent = default;
        private static bool _SINKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/health/ConnectorType.html#SOURCE"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Health.ConnectorType SOURCE { get { if (!_SOURCEReady) { _SOURCEContent = SGetField<Org.Apache.Kafka.Connect.Health.ConnectorType>(LocalBridgeClazz, "SOURCE"); _SOURCEReady = true; } return _SOURCEContent; } }
        private static Org.Apache.Kafka.Connect.Health.ConnectorType _SOURCEContent = default;
        private static bool _SOURCEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/health/ConnectorType.html#UNKNOWN"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Health.ConnectorType UNKNOWN { get { if (!_UNKNOWNReady) { _UNKNOWNContent = SGetField<Org.Apache.Kafka.Connect.Health.ConnectorType>(LocalBridgeClazz, "UNKNOWN"); _UNKNOWNReady = true; } return _UNKNOWNContent; } }
        private static Org.Apache.Kafka.Connect.Health.ConnectorType _UNKNOWNContent = default;
        private static bool _UNKNOWNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/health/ConnectorType.html#valueOf-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Health.ConnectorType"/></returns>
        public static Org.Apache.Kafka.Connect.Health.ConnectorType ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Connect.Health.ConnectorType>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/connect/health/ConnectorType;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/health/ConnectorType.html#values--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Connect.Health.ConnectorType"/></returns>
        public static Org.Apache.Kafka.Connect.Health.ConnectorType[] Values()
        {
            return SExecuteWithSignatureArray<Org.Apache.Kafka.Connect.Health.ConnectorType>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/connect/health/ConnectorType;");
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