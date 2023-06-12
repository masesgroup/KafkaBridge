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

namespace Org.Apache.Kafka.Common.Security.Oauthbearer
{
    #region OAuthBearerExtensionsValidatorCallback
    public partial class OAuthBearerExtensionsValidatorCallback
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/oauthbearer/OAuthBearerExtensionsValidatorCallback.html#%3Cinit%3E(org.apache.kafka.common.security.oauthbearer.OAuthBearerToken,org.apache.kafka.common.security.auth.SaslExtensions)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Security.Oauthbearer.OAuthBearerToken"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Security.Auth.SaslExtensions"/></param>
        public OAuthBearerExtensionsValidatorCallback(Org.Apache.Kafka.Common.Security.Oauthbearer.OAuthBearerToken arg0, Org.Apache.Kafka.Common.Security.Auth.SaslExtensions arg1)
            : base(arg0, arg1)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/oauthbearer/OAuthBearerExtensionsValidatorCallback.html#ignoredExtensions()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<string, string> IgnoredExtensions()
        {
            return IExecute<Java.Util.Map<string, string>>("ignoredExtensions");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/oauthbearer/OAuthBearerExtensionsValidatorCallback.html#invalidExtensions()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<string, string> InvalidExtensions()
        {
            return IExecute<Java.Util.Map<string, string>>("invalidExtensions");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/oauthbearer/OAuthBearerExtensionsValidatorCallback.html#validatedExtensions()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<string, string> ValidatedExtensions()
        {
            return IExecute<Java.Util.Map<string, string>>("validatedExtensions");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/oauthbearer/OAuthBearerExtensionsValidatorCallback.html#inputExtensions()"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Security.Auth.SaslExtensions"/></returns>
        public Org.Apache.Kafka.Common.Security.Auth.SaslExtensions InputExtensions()
        {
            return IExecute<Org.Apache.Kafka.Common.Security.Auth.SaslExtensions>("inputExtensions");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/oauthbearer/OAuthBearerExtensionsValidatorCallback.html#token()"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Security.Oauthbearer.OAuthBearerToken"/></returns>
        public Org.Apache.Kafka.Common.Security.Oauthbearer.OAuthBearerToken Token()
        {
            return IExecute<Org.Apache.Kafka.Common.Security.Oauthbearer.OAuthBearerToken>("token");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/oauthbearer/OAuthBearerExtensionsValidatorCallback.html#error(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        public void Error(string arg0, string arg1)
        {
            IExecute("error", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/oauthbearer/OAuthBearerExtensionsValidatorCallback.html#valid(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public void Valid(string arg0)
        {
            IExecute("valid", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}