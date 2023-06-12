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

namespace Org.Apache.Kafka.Common.Network
{
    #region ListenerName
    public partial class ListenerName
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/network/ListenerName.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public ListenerName(string arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/network/ListenerName.html#saslMechanismPrefix(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public static string SaslMechanismPrefix(string arg0)
        {
            return SExecute<string>(LocalBridgeClazz, "saslMechanismPrefix", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/network/ListenerName.html#forSecurityProtocol(org.apache.kafka.common.security.auth.SecurityProtocol)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Network.ListenerName"/></returns>
        public static Org.Apache.Kafka.Common.Network.ListenerName ForSecurityProtocol(Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol arg0)
        {
            return SExecute<Org.Apache.Kafka.Common.Network.ListenerName>(LocalBridgeClazz, "forSecurityProtocol", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/network/ListenerName.html#normalised(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Network.ListenerName"/></returns>
        public static Org.Apache.Kafka.Common.Network.ListenerName Normalised(string arg0)
        {
            return SExecute<Org.Apache.Kafka.Common.Network.ListenerName>(LocalBridgeClazz, "normalised", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/network/ListenerName.html#configPrefix()"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string ConfigPrefix()
        {
            return IExecute<string>("configPrefix");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/network/ListenerName.html#saslMechanismConfigPrefix(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string SaslMechanismConfigPrefix(string arg0)
        {
            return IExecute<string>("saslMechanismConfigPrefix", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/network/ListenerName.html#value()"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string Value()
        {
            return IExecute<string>("value");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}