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

namespace Org.Apache.Kafka.Common.Replica
{
    #region IClientMetadata
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IClientMetadata
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ClientMetadata
    public partial class ClientMetadata : Org.Apache.Kafka.Common.Replica.IClientMetadata
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/replica/ClientMetadata.html#clientId--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string ClientId()
        {
            return IExecute<string>("clientId");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/replica/ClientMetadata.html#listenerName--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string ListenerName()
        {
            return IExecute<string>("listenerName");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/replica/ClientMetadata.html#rackId--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string RackId()
        {
            return IExecute<string>("rackId");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/replica/ClientMetadata.html#clientAddress--"/>
        /// </summary>

        /// <returns><see cref="Java.Net.InetAddress"/></returns>
        public Java.Net.InetAddress ClientAddress()
        {
            return IExecute<Java.Net.InetAddress>("clientAddress");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/replica/ClientMetadata.html#principal--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal"/></returns>
        public Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal Principal()
        {
            return IExecute<Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal>("principal");
        }

        #endregion

        #region Nested classes
        #region DefaultClientMetadata
        public partial class DefaultClientMetadata
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/replica/ClientMetadata.DefaultClientMetadata.html#org.apache.kafka.common.replica.ClientMetadata$DefaultClientMetadata(java.lang.String,java.lang.String,java.net.InetAddress,org.apache.kafka.common.security.auth.KafkaPrincipal,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <param name="arg1"><see cref="string"/></param>
            /// <param name="arg2"><see cref="Java.Net.InetAddress"/></param>
            /// <param name="arg3"><see cref="Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal"/></param>
            /// <param name="arg4"><see cref="string"/></param>
            public DefaultClientMetadata(string arg0, string arg1, Java.Net.InetAddress arg2, Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal arg3, string arg4)
                : base(arg0, arg1, arg2, arg3, arg4)
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/replica/ClientMetadata.DefaultClientMetadata.html#clientId--"/>
            /// </summary>

            /// <returns><see cref="string"/></returns>
            public string ClientId()
            {
                return IExecute<string>("clientId");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/replica/ClientMetadata.DefaultClientMetadata.html#listenerName--"/>
            /// </summary>

            /// <returns><see cref="string"/></returns>
            public string ListenerName()
            {
                return IExecute<string>("listenerName");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/replica/ClientMetadata.DefaultClientMetadata.html#rackId--"/>
            /// </summary>

            /// <returns><see cref="string"/></returns>
            public string RackId()
            {
                return IExecute<string>("rackId");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/replica/ClientMetadata.DefaultClientMetadata.html#clientAddress--"/>
            /// </summary>

            /// <returns><see cref="Java.Net.InetAddress"/></returns>
            public Java.Net.InetAddress ClientAddress()
            {
                return IExecute<Java.Net.InetAddress>("clientAddress");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/replica/ClientMetadata.DefaultClientMetadata.html#principal--"/>
            /// </summary>

            /// <returns><see cref="Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal"/></returns>
            public Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal Principal()
            {
                return IExecute<Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal>("principal");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}