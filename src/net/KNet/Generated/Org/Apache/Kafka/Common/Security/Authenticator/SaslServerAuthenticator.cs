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
*  using kafka-clients-3.6.2.jar as reference
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/authenticator/SaslServerAuthenticator.html#complete--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool Complete()
        {
            return IExecuteWithSignature<bool>("complete", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/authenticator/SaslServerAuthenticator.html#connectedClientSupportsReauthentication--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool ConnectedClientSupportsReauthentication()
        {
            return IExecuteWithSignature<bool>("connectedClientSupportsReauthentication", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/authenticator/SaslServerAuthenticator.html#reauthenticationLatencyMs--"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.Long"/></returns>
        public Java.Lang.Long ReauthenticationLatencyMs()
        {
            return IExecuteWithSignature<Java.Lang.Long>("reauthenticationLatencyMs", "()Ljava/lang/Long;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/authenticator/SaslServerAuthenticator.html#serverSessionExpirationTimeNanos--"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.Long"/></returns>
        public Java.Lang.Long ServerSessionExpirationTimeNanos()
        {
            return IExecuteWithSignature<Java.Lang.Long>("serverSessionExpirationTimeNanos", "()Ljava/lang/Long;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/authenticator/SaslServerAuthenticator.html#principalSerde--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipalSerde> PrincipalSerde()
        {
            return IExecuteWithSignature<Java.Util.Optional<Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipalSerde>>("principalSerde", "()Ljava/util/Optional;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/authenticator/SaslServerAuthenticator.html#principal--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal"/></returns>
        public Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal Principal()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal>("principal", "()Lorg/apache/kafka/common/security/auth/KafkaPrincipal;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/authenticator/SaslServerAuthenticator.html#authenticate--"/>
        /// </summary>

        /// <exception cref="Java.Io.IOException"/>
        public void Authenticate()
        {
            IExecuteWithSignature("authenticate", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/authenticator/SaslServerAuthenticator.html#close--"/>
        /// </summary>

        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/authenticator/SaslServerAuthenticator.html#handleAuthenticationFailure--"/>
        /// </summary>

        /// <exception cref="Java.Io.IOException"/>
        public void HandleAuthenticationFailure()
        {
            IExecuteWithSignature("handleAuthenticationFailure", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}