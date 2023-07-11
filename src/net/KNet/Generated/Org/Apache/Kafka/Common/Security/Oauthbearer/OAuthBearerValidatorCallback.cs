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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using kafka-clients-3.5.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Security.Oauthbearer
{
    #region OAuthBearerValidatorCallback
    public partial class OAuthBearerValidatorCallback
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/security/oauthbearer/OAuthBearerValidatorCallback.html#org.apache.kafka.common.security.oauthbearer.OAuthBearerValidatorCallback(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public OAuthBearerValidatorCallback(string arg0)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/security/oauthbearer/OAuthBearerValidatorCallback.html#errorOpenIDConfiguration--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string ErrorOpenIDConfiguration()
        {
            return IExecute<string>("errorOpenIDConfiguration");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/security/oauthbearer/OAuthBearerValidatorCallback.html#errorScope--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string ErrorScope()
        {
            return IExecute<string>("errorScope");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/security/oauthbearer/OAuthBearerValidatorCallback.html#errorStatus--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string ErrorStatus()
        {
            return IExecute<string>("errorStatus");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/security/oauthbearer/OAuthBearerValidatorCallback.html#tokenValue--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string TokenValue()
        {
            return IExecute<string>("tokenValue");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/security/oauthbearer/OAuthBearerValidatorCallback.html#token--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Security.Oauthbearer.OAuthBearerToken"/></returns>
        public Org.Apache.Kafka.Common.Security.Oauthbearer.OAuthBearerToken Token()
        {
            return IExecute<Org.Apache.Kafka.Common.Security.Oauthbearer.OAuthBearerToken>("token");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/security/oauthbearer/OAuthBearerValidatorCallback.html#error-java.lang.String-java.lang.String-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        public void Error(string arg0, string arg1, string arg2)
        {
            IExecute("error", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/security/oauthbearer/OAuthBearerValidatorCallback.html#token-org.apache.kafka.common.security.oauthbearer.OAuthBearerToken-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Security.Oauthbearer.OAuthBearerToken"/></param>
        public void Token(Org.Apache.Kafka.Common.Security.Oauthbearer.OAuthBearerToken arg0)
        {
            IExecute("token", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}