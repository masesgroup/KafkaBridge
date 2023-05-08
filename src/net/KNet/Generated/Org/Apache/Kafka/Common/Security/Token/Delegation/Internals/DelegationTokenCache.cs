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

namespace Org.Apache.Kafka.Common.Security.Token.Delegation.Internals
{
    #region DelegationTokenCache
    public partial class DelegationTokenCache
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/token/delegation/internals/DelegationTokenCache.html#%3Cinit%3E(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public DelegationTokenCache(Java.Util.Collection arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/token/delegation/internals/DelegationTokenCache.html#tokens()"/> 
        /// </summary>
        public Java.Util.Collection<Org.Apache.Kafka.Common.Security.Token.Delegation.TokenInformation> Tokens
        {
            get { return IExecute<Java.Util.Collection<Org.Apache.Kafka.Common.Security.Token.Delegation.TokenInformation>>("tokens"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/token/delegation/internals/DelegationTokenCache.html#owner(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string Owner(string arg0)
        {
            return IExecute<string>("owner", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/token/delegation/internals/DelegationTokenCache.html#tokenIdForHmac(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string TokenIdForHmac(string arg0)
        {
            return IExecute<string>("tokenIdForHmac", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/token/delegation/internals/DelegationTokenCache.html#credentialCache(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Security.Authenticator.CredentialCache.Cache"/></returns>
        public Org.Apache.Kafka.Common.Security.Authenticator.CredentialCache.Cache<Org.Apache.Kafka.Common.Security.Scram.ScramCredential> CredentialCache(string arg0)
        {
            return IExecute<Org.Apache.Kafka.Common.Security.Authenticator.CredentialCache.Cache<Org.Apache.Kafka.Common.Security.Scram.ScramCredential>>("credentialCache", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/token/delegation/internals/DelegationTokenCache.html#credential(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Security.Scram.ScramCredential"/></returns>
        public Org.Apache.Kafka.Common.Security.Scram.ScramCredential Credential(string arg0, string arg1)
        {
            return IExecute<Org.Apache.Kafka.Common.Security.Scram.ScramCredential>("credential", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/token/delegation/internals/DelegationTokenCache.html#addToken(java.lang.String,org.apache.kafka.common.security.token.delegation.TokenInformation)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Security.Token.Delegation.TokenInformation"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Security.Token.Delegation.TokenInformation"/></returns>
        public Org.Apache.Kafka.Common.Security.Token.Delegation.TokenInformation AddToken(string arg0, Org.Apache.Kafka.Common.Security.Token.Delegation.TokenInformation arg1)
        {
            return IExecute<Org.Apache.Kafka.Common.Security.Token.Delegation.TokenInformation>("addToken", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/token/delegation/internals/DelegationTokenCache.html#token(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Security.Token.Delegation.TokenInformation"/></returns>
        public Org.Apache.Kafka.Common.Security.Token.Delegation.TokenInformation Token(string arg0)
        {
            return IExecute<Org.Apache.Kafka.Common.Security.Token.Delegation.TokenInformation>("token", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/token/delegation/internals/DelegationTokenCache.html#tokenForHmac(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Security.Token.Delegation.TokenInformation"/></returns>
        public Org.Apache.Kafka.Common.Security.Token.Delegation.TokenInformation TokenForHmac(string arg0)
        {
            return IExecute<Org.Apache.Kafka.Common.Security.Token.Delegation.TokenInformation>("tokenForHmac", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/token/delegation/internals/DelegationTokenCache.html#removeCache(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public void RemoveCache(string arg0)
        {
            IExecute("removeCache", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/token/delegation/internals/DelegationTokenCache.html#removeToken(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public void RemoveToken(string arg0)
        {
            IExecute("removeToken", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/token/delegation/internals/DelegationTokenCache.html#updateCache(org.apache.kafka.common.security.token.delegation.DelegationToken,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Security.Token.Delegation.DelegationToken"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        public void UpdateCache(Org.Apache.Kafka.Common.Security.Token.Delegation.DelegationToken arg0, Java.Util.Map<string, Org.Apache.Kafka.Common.Security.Scram.ScramCredential> arg1)
        {
            IExecute("updateCache", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}