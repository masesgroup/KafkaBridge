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
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/authenticator/SaslServerAuthenticator.html#%3Cinit%3E(java.util.Map,java.util.Map,java.lang.String,java.util.Map,org.apache.kafka.common.security.kerberos.KerberosShortNamer,org.apache.kafka.common.network.ListenerName,org.apache.kafka.common.security.auth.SecurityProtocol,org.apache.kafka.common.network.TransportLayer,java.util.Map,org.apache.kafka.common.network.ChannelMetadataRegistry,org.apache.kafka.common.utils.Time,java.util.function.Supplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="Java.Util.Map"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Common.Security.Kerberos.KerberosShortNamer"/></param>
        /// <param name="arg5"><see cref="Org.Apache.Kafka.Common.Network.ListenerName"/></param>
        /// <param name="arg6"><see cref="Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol"/></param>
        /// <param name="arg7"><see cref="Org.Apache.Kafka.Common.Network.TransportLayer"/></param>
        /// <param name="arg8"><see cref="Java.Util.Map"/></param>
        /// <param name="arg9"><see cref="Org.Apache.Kafka.Common.Network.ChannelMetadataRegistry"/></param>
        /// <param name="arg10"><see cref="Org.Apache.Kafka.Common.Utils.Time"/></param>
        /// <param name="arg11"><see cref="Java.Util.Function.Supplier"/></param>
        public SaslServerAuthenticator(Java.Util.Map arg0, Java.Util.Map arg1, string arg2, Java.Util.Map arg3, Org.Apache.Kafka.Common.Security.Kerberos.KerberosShortNamer arg4, Org.Apache.Kafka.Common.Network.ListenerName arg5, Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol arg6, Org.Apache.Kafka.Common.Network.TransportLayer arg7, Java.Util.Map arg8, Org.Apache.Kafka.Common.Network.ChannelMetadataRegistry arg9, Org.Apache.Kafka.Common.Utils.Time arg10, Java.Util.Function.Supplier arg11)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Common.Security.Authenticator.SaslServerAuthenticator"/> to <see cref="Org.Apache.Kafka.Common.Network.Authenticator"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Network.Authenticator(Org.Apache.Kafka.Common.Security.Authenticator.SaslServerAuthenticator t) => t.Cast<Org.Apache.Kafka.Common.Network.Authenticator>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/authenticator/SaslServerAuthenticator.html#complete()"/> 
        /// </summary>
        public bool Complete
        {
            get { return IExecute<bool>("complete"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/authenticator/SaslServerAuthenticator.html#connectedClientSupportsReauthentication()"/> 
        /// </summary>
        public bool ConnectedClientSupportsReauthentication
        {
            get { return IExecute<bool>("connectedClientSupportsReauthentication"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/authenticator/SaslServerAuthenticator.html#principal()"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal Principal
        {
            get { return IExecute<Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal>("principal"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/authenticator/SaslServerAuthenticator.html#principalSerde()"/> 
        /// </summary>
        public Java.Util.Optional<Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipalSerde> PrincipalSerde
        {
            get { return IExecute<Java.Util.Optional<Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipalSerde>>("principalSerde"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/authenticator/SaslServerAuthenticator.html#reauthenticationLatencyMs()"/> 
        /// </summary>
        public long? ReauthenticationLatencyMs
        {
            get { return IExecute<long?>("reauthenticationLatencyMs"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/authenticator/SaslServerAuthenticator.html#serverSessionExpirationTimeNanos()"/> 
        /// </summary>
        public long? ServerSessionExpirationTimeNanos
        {
            get { return IExecute<long?>("serverSessionExpirationTimeNanos"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/authenticator/SaslServerAuthenticator.html#authenticate()"/>
        /// </summary>

        /// <exception cref="Java.Io.IOException"/>
        public void Authenticate()
        {
            IExecute("authenticate");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/authenticator/SaslServerAuthenticator.html#close()"/>
        /// </summary>

        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/authenticator/SaslServerAuthenticator.html#handleAuthenticationFailure()"/>
        /// </summary>

        /// <exception cref="Java.Io.IOException"/>
        public void HandleAuthenticationFailure()
        {
            IExecute("handleAuthenticationFailure");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/authenticator/SaslServerAuthenticator.html#reauthenticate(org.apache.kafka.common.network.ReauthenticationContext)"/>
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