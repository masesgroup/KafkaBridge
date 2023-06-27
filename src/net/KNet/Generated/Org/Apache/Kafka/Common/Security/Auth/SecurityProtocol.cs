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
*  This file is generated by MASES.JNetReflector (ver. 2.0.0.0)
*  using kafka-clients-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Security.Auth
{
    #region SecurityProtocol
    public partial class SecurityProtocol
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/auth/SecurityProtocol.html#name"/>
        /// </summary>
        public string name { get { return IGetField<string>("name"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/auth/SecurityProtocol.html#id"/>
        /// </summary>
        public short id { get { return IGetField<short>("id"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/auth/SecurityProtocol.html#PLAINTEXT"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol PLAINTEXT { get { return SGetField<Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol>(LocalBridgeClazz, "PLAINTEXT"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/auth/SecurityProtocol.html#SASL_PLAINTEXT"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol SASL_PLAINTEXT { get { return SGetField<Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol>(LocalBridgeClazz, "SASL_PLAINTEXT"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/auth/SecurityProtocol.html#SASL_SSL"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol SASL_SSL { get { return SGetField<Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol>(LocalBridgeClazz, "SASL_SSL"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/auth/SecurityProtocol.html#SSL"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol SSL { get { return SGetField<Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol>(LocalBridgeClazz, "SSL"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/auth/SecurityProtocol.html#names()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List<string> Names()
        {
            return SExecute<Java.Util.List<string>>(LocalBridgeClazz, "names");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/auth/SecurityProtocol.html#forId(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol"/></returns>
        public static Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol ForId(short arg0)
        {
            return SExecute<Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol>(LocalBridgeClazz, "forId", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/auth/SecurityProtocol.html#forName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol"/></returns>
        public static Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol ForName(string arg0)
        {
            return SExecute<Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol>(LocalBridgeClazz, "forName", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/auth/SecurityProtocol.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol"/></returns>
        public static Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol ValueOf(string arg0)
        {
            return SExecute<Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/auth/SecurityProtocol.html#values()"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol"/></returns>
        public static Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol[] Values()
        {
            return SExecuteArray<Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol>(LocalBridgeClazz, "values");
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