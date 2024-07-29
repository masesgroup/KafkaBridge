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
*  using kafka-clients-3.8.0.jar as reference
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/security/auth/SecurityProtocol.html#name"/>
        /// </summary>
        public Java.Lang.String name { get { if (!_nameReady) { _nameContent = IGetField<Java.Lang.String>("name"); _nameReady = true; } return _nameContent; } }
        private Java.Lang.String _nameContent = default;
        private bool _nameReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/security/auth/SecurityProtocol.html#id"/>
        /// </summary>
        public short id { get { if (!_idReady) { _idContent = IGetField<short>("id"); _idReady = true; } return _idContent; } }
        private short _idContent = default;
        private bool _idReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/security/auth/SecurityProtocol.html#PLAINTEXT"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol PLAINTEXT { get { if (!_PLAINTEXTReady) { _PLAINTEXTContent = SGetField<Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol>(LocalBridgeClazz, "PLAINTEXT"); _PLAINTEXTReady = true; } return _PLAINTEXTContent; } }
        private static Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol _PLAINTEXTContent = default;
        private static bool _PLAINTEXTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/security/auth/SecurityProtocol.html#SASL_PLAINTEXT"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol SASL_PLAINTEXT { get { if (!_SASL_PLAINTEXTReady) { _SASL_PLAINTEXTContent = SGetField<Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol>(LocalBridgeClazz, "SASL_PLAINTEXT"); _SASL_PLAINTEXTReady = true; } return _SASL_PLAINTEXTContent; } }
        private static Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol _SASL_PLAINTEXTContent = default;
        private static bool _SASL_PLAINTEXTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/security/auth/SecurityProtocol.html#SASL_SSL"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol SASL_SSL { get { if (!_SASL_SSLReady) { _SASL_SSLContent = SGetField<Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol>(LocalBridgeClazz, "SASL_SSL"); _SASL_SSLReady = true; } return _SASL_SSLContent; } }
        private static Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol _SASL_SSLContent = default;
        private static bool _SASL_SSLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/security/auth/SecurityProtocol.html#SSL"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol SSL { get { if (!_SSLReady) { _SSLContent = SGetField<Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol>(LocalBridgeClazz, "SSL"); _SSLReady = true; } return _SSLContent; } }
        private static Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol _SSLContent = default;
        private static bool _SSLReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/security/auth/SecurityProtocol.html#names--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List<Java.Lang.String> Names()
        {
            return SExecuteWithSignature<Java.Util.List<Java.Lang.String>>(LocalBridgeClazz, "names", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/security/auth/SecurityProtocol.html#forId-short-"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol"/></returns>
        public static Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol ForId(short arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol>(LocalBridgeClazz, "forId", "(S)Lorg/apache/kafka/common/security/auth/SecurityProtocol;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/security/auth/SecurityProtocol.html#forName-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol"/></returns>
        public static Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol ForName(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol>(LocalBridgeClazz, "forName", "(Ljava/lang/String;)Lorg/apache/kafka/common/security/auth/SecurityProtocol;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/security/auth/SecurityProtocol.html#valueOf-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol"/></returns>
        public static Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/common/security/auth/SecurityProtocol;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/security/auth/SecurityProtocol.html#values--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol"/></returns>
        public static Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol[] Values()
        {
            return SExecuteWithSignatureArray<Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/common/security/auth/SecurityProtocol;");
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