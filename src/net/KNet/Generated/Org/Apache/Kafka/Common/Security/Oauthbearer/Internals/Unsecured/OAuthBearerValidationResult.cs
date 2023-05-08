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

namespace Org.Apache.Kafka.Common.Security.Oauthbearer.Internals.Unsecured
{
    #region OAuthBearerValidationResult
    public partial class OAuthBearerValidationResult
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Common.Security.Oauthbearer.Internals.Unsecured.OAuthBearerValidationResult"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Org.Apache.Kafka.Common.Security.Oauthbearer.Internals.Unsecured.OAuthBearerValidationResult t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/oauthbearer/internals/unsecured/OAuthBearerValidationResult.html#newSuccess()"/> 
        /// </summary>
        public static Org.Apache.Kafka.Common.Security.Oauthbearer.Internals.Unsecured.OAuthBearerValidationResult NewSuccess
        {
            get { return SExecute<Org.Apache.Kafka.Common.Security.Oauthbearer.Internals.Unsecured.OAuthBearerValidationResult>(LocalBridgeClazz, "newSuccess"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/oauthbearer/internals/unsecured/OAuthBearerValidationResult.html#newFailure(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Security.Oauthbearer.Internals.Unsecured.OAuthBearerValidationResult"/></returns>
        public static Org.Apache.Kafka.Common.Security.Oauthbearer.Internals.Unsecured.OAuthBearerValidationResult NewFailure(string arg0, string arg1, string arg2)
        {
            return SExecute<Org.Apache.Kafka.Common.Security.Oauthbearer.Internals.Unsecured.OAuthBearerValidationResult>(LocalBridgeClazz, "newFailure", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/oauthbearer/internals/unsecured/OAuthBearerValidationResult.html#newFailure(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Security.Oauthbearer.Internals.Unsecured.OAuthBearerValidationResult"/></returns>
        public static Org.Apache.Kafka.Common.Security.Oauthbearer.Internals.Unsecured.OAuthBearerValidationResult NewFailure(string arg0)
        {
            return SExecute<Org.Apache.Kafka.Common.Security.Oauthbearer.Internals.Unsecured.OAuthBearerValidationResult>(LocalBridgeClazz, "newFailure", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/oauthbearer/internals/unsecured/OAuthBearerValidationResult.html#failureDescription()"/> 
        /// </summary>
        public string FailureDescription
        {
            get { return IExecute<string>("failureDescription"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/oauthbearer/internals/unsecured/OAuthBearerValidationResult.html#failureOpenIdConfig()"/> 
        /// </summary>
        public string FailureOpenIdConfig
        {
            get { return IExecute<string>("failureOpenIdConfig"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/oauthbearer/internals/unsecured/OAuthBearerValidationResult.html#failureScope()"/> 
        /// </summary>
        public string FailureScope
        {
            get { return IExecute<string>("failureScope"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/oauthbearer/internals/unsecured/OAuthBearerValidationResult.html#success()"/> 
        /// </summary>
        public bool Success
        {
            get { return IExecute<bool>("success"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/oauthbearer/internals/unsecured/OAuthBearerValidationResult.html#throwExceptionIfFailed()"/>
        /// </summary>

        /// <exception cref="Org.Apache.Kafka.Common.Security.Oauthbearer.Internals.Unsecured.OAuthBearerIllegalTokenException"/>
        public void ThrowExceptionIfFailed()
        {
            IExecute("throwExceptionIfFailed");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}