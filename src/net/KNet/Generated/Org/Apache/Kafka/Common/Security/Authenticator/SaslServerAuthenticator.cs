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
    #region SaslServerAuthenticator
    public partial class SaslServerAuthenticator
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/authenticator/SaslServerAuthenticator.html#complete()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool Complete()
        {
            return IExecute<bool>("complete");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/authenticator/SaslServerAuthenticator.html#connectedClientSupportsReauthentication()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool ConnectedClientSupportsReauthentication()
        {
            return IExecute<bool>("connectedClientSupportsReauthentication");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/authenticator/SaslServerAuthenticator.html#reauthenticationLatencyMs()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long? ReauthenticationLatencyMs()
        {
            return IExecute<long?>("reauthenticationLatencyMs");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/authenticator/SaslServerAuthenticator.html#serverSessionExpirationTimeNanos()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long? ServerSessionExpirationTimeNanos()
        {
            return IExecute<long?>("serverSessionExpirationTimeNanos");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/authenticator/SaslServerAuthenticator.html#principalSerde()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipalSerde> PrincipalSerde()
        {
            return IExecute<Java.Util.Optional<Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipalSerde>>("principalSerde");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/authenticator/SaslServerAuthenticator.html#principal()"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal"/></returns>
        public Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal Principal()
        {
            return IExecute<Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal>("principal");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/authenticator/SaslServerAuthenticator.html#authenticate()"/>
        /// </summary>

        /// <exception cref="Java.Io.IOException"/>
        public void Authenticate()
        {
            IExecute("authenticate");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/authenticator/SaslServerAuthenticator.html#close()"/>
        /// </summary>

        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/authenticator/SaslServerAuthenticator.html#handleAuthenticationFailure()"/>
        /// </summary>

        /// <exception cref="Java.Io.IOException"/>
        public void HandleAuthenticationFailure()
        {
            IExecute("handleAuthenticationFailure");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/authenticator/SaslServerAuthenticator.html#reauthenticate(org.apache.kafka.common.network.ReauthenticationContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Network.ReauthenticationContext"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Reauthenticate(Org.Apache.Kafka.Common.Network.ReauthenticationContext arg0)
        {
            IExecute("reauthenticate", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}