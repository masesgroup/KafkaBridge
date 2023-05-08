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

namespace Org.Apache.Kafka.Common.Security.Oauthbearer.Internals.Secured
{
    #region LoginAccessTokenValidator
    public partial class LoginAccessTokenValidator
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/oauthbearer/internals/secured/LoginAccessTokenValidator.html#%3Cinit%3E(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        public LoginAccessTokenValidator(string arg0, string arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Common.Security.Oauthbearer.Internals.Secured.LoginAccessTokenValidator"/> to <see cref="Org.Apache.Kafka.Common.Security.Oauthbearer.Internals.Secured.AccessTokenValidator"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Security.Oauthbearer.Internals.Secured.AccessTokenValidator(Org.Apache.Kafka.Common.Security.Oauthbearer.Internals.Secured.LoginAccessTokenValidator t) => t.Cast<Org.Apache.Kafka.Common.Security.Oauthbearer.Internals.Secured.AccessTokenValidator>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/oauthbearer/internals/secured/LoginAccessTokenValidator.html#EXPIRATION_CLAIM_NAME"/>
        /// </summary>
        public static string EXPIRATION_CLAIM_NAME { get { return SGetField<string>(LocalBridgeClazz, "EXPIRATION_CLAIM_NAME"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/oauthbearer/internals/secured/LoginAccessTokenValidator.html#ISSUED_AT_CLAIM_NAME"/>
        /// </summary>
        public static string ISSUED_AT_CLAIM_NAME { get { return SGetField<string>(LocalBridgeClazz, "ISSUED_AT_CLAIM_NAME"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/oauthbearer/internals/secured/LoginAccessTokenValidator.html#validate(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Security.Oauthbearer.OAuthBearerToken"/></returns>
        /// <exception cref="Org.Apache.Kafka.Common.Security.Oauthbearer.Internals.Secured.ValidateException"/>
        public Org.Apache.Kafka.Common.Security.Oauthbearer.OAuthBearerToken Validate(string arg0)
        {
            return IExecute<Org.Apache.Kafka.Common.Security.Oauthbearer.OAuthBearerToken>("validate", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}