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
*  using kafka-clients-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Security.Authenticator
{
    #region DefaultKafkaPrincipalBuilder
    public partial class DefaultKafkaPrincipalBuilder
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/authenticator/DefaultKafkaPrincipalBuilder.html#%3Cinit%3E(org.apache.kafka.common.security.kerberos.KerberosShortNamer,org.apache.kafka.common.security.ssl.SslPrincipalMapper)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Security.Kerberos.KerberosShortNamer"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Security.Ssl.SslPrincipalMapper"/></param>
        public DefaultKafkaPrincipalBuilder(Org.Apache.Kafka.Common.Security.Kerberos.KerberosShortNamer arg0, Org.Apache.Kafka.Common.Security.Ssl.SslPrincipalMapper arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Common.Security.Authenticator.DefaultKafkaPrincipalBuilder"/> to <see cref="Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipalBuilder"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipalBuilder(Org.Apache.Kafka.Common.Security.Authenticator.DefaultKafkaPrincipalBuilder t) => t.Cast<Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipalBuilder>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Common.Security.Authenticator.DefaultKafkaPrincipalBuilder"/> to <see cref="Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipalSerde"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipalSerde(Org.Apache.Kafka.Common.Security.Authenticator.DefaultKafkaPrincipalBuilder t) => t.Cast<Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipalSerde>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/authenticator/DefaultKafkaPrincipalBuilder.html#serialize(org.apache.kafka.common.security.auth.KafkaPrincipal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] Serialize(Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal arg0)
        {
            return IExecuteArray<byte>("serialize", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/authenticator/DefaultKafkaPrincipalBuilder.html#build(org.apache.kafka.common.security.auth.AuthenticationContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Security.Auth.AuthenticationContext"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal"/></returns>
        public Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal Build(Org.Apache.Kafka.Common.Security.Auth.AuthenticationContext arg0)
        {
            return IExecute<Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal>("build", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/authenticator/DefaultKafkaPrincipalBuilder.html#deserialize(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal"/></returns>
        public Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal Deserialize(byte[] arg0)
        {
            return IExecute<Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal>("deserialize", new object[] { arg0 });
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}