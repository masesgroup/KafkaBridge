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
*  This file is generated by MASES.JNetReflector (ver. 2.0.0.0)
*  using kafka-clients-3.5.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Security.Oauthbearer
{
    #region IOAuthBearerToken
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IOAuthBearerToken
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region OAuthBearerToken
    public partial class OAuthBearerToken : Org.Apache.Kafka.Common.Security.Oauthbearer.IOAuthBearerToken
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/security/oauthbearer/OAuthBearerToken.html#startTimeMs--"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long? StartTimeMs()
        {
            return IExecute<long?>("startTimeMs");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/security/oauthbearer/OAuthBearerToken.html#principalName--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string PrincipalName()
        {
            return IExecute<string>("principalName");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/security/oauthbearer/OAuthBearerToken.html#value--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string Value()
        {
            return IExecute<string>("value");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/security/oauthbearer/OAuthBearerToken.html#scope--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<string> Scope()
        {
            return IExecute<Java.Util.Set<string>>("scope");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/security/oauthbearer/OAuthBearerToken.html#lifetimeMs--"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long LifetimeMs()
        {
            return IExecute<long>("lifetimeMs");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}