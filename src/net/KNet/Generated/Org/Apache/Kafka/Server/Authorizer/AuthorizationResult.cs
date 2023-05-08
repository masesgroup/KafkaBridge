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

namespace Org.Apache.Kafka.Server.Authorizer
{
    #region AuthorizationResult
    public partial class AuthorizationResult
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/server/authorizer/AuthorizationResult.html#ALLOWED"/>
        /// </summary>
        public static Org.Apache.Kafka.Server.Authorizer.AuthorizationResult ALLOWED { get { return SGetField<Org.Apache.Kafka.Server.Authorizer.AuthorizationResult>(LocalBridgeClazz, "ALLOWED"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/server/authorizer/AuthorizationResult.html#DENIED"/>
        /// </summary>
        public static Org.Apache.Kafka.Server.Authorizer.AuthorizationResult DENIED { get { return SGetField<Org.Apache.Kafka.Server.Authorizer.AuthorizationResult>(LocalBridgeClazz, "DENIED"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/server/authorizer/AuthorizationResult.html#values()"/> 
        /// </summary>
        public static Org.Apache.Kafka.Server.Authorizer.AuthorizationResult[] Values
        {
            get { return SExecuteArray<Org.Apache.Kafka.Server.Authorizer.AuthorizationResult>(LocalBridgeClazz, "values"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/server/authorizer/AuthorizationResult.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Server.Authorizer.AuthorizationResult"/></returns>
        public static Org.Apache.Kafka.Server.Authorizer.AuthorizationResult ValueOf(string arg0)
        {
            return SExecute<Org.Apache.Kafka.Server.Authorizer.AuthorizationResult>(LocalBridgeClazz, "valueOf", arg0);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}