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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using kafka-clients-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Security.Auth
{
    #region PlaintextAuthenticationContext
    public partial class PlaintextAuthenticationContext
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/security/auth/PlaintextAuthenticationContext.html#org.apache.kafka.common.security.auth.PlaintextAuthenticationContext(java.net.InetAddress,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.InetAddress"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public PlaintextAuthenticationContext(Java.Net.InetAddress arg0, Java.Lang.String arg1)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/security/auth/PlaintextAuthenticationContext.html#listenerName--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ListenerName()
        {
            return IExecuteWithSignature<Java.Lang.String>("listenerName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/security/auth/PlaintextAuthenticationContext.html#clientAddress--"/>
        /// </summary>
        /// <returns><see cref="Java.Net.InetAddress"/></returns>
        public Java.Net.InetAddress ClientAddress()
        {
            return IExecuteWithSignature<Java.Net.InetAddress>("clientAddress", "()Ljava/net/InetAddress;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/security/auth/PlaintextAuthenticationContext.html#securityProtocol--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol"/></returns>
        public Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol SecurityProtocol()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol>("securityProtocol", "()Lorg/apache/kafka/common/security/auth/SecurityProtocol;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}