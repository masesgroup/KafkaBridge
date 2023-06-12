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
    #region DefaultChannelMetadataRegistry
    public partial class DefaultChannelMetadataRegistry
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/network/DefaultChannelMetadataRegistry.html#cipherInformation()"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Network.CipherInformation"/></returns>
        public Org.Apache.Kafka.Common.Network.CipherInformation CipherInformation()
        {
            return IExecute<Org.Apache.Kafka.Common.Network.CipherInformation>("cipherInformation");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/network/DefaultChannelMetadataRegistry.html#clientInformation()"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Network.ClientInformation"/></returns>
        public Org.Apache.Kafka.Common.Network.ClientInformation ClientInformation()
        {
            return IExecute<Org.Apache.Kafka.Common.Network.ClientInformation>("clientInformation");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/network/DefaultChannelMetadataRegistry.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/network/DefaultChannelMetadataRegistry.html#registerCipherInformation(org.apache.kafka.common.network.CipherInformation)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Network.CipherInformation"/></param>
        public void RegisterCipherInformation(Org.Apache.Kafka.Common.Network.CipherInformation arg0)
        {
            IExecute("registerCipherInformation", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/network/DefaultChannelMetadataRegistry.html#registerClientInformation(org.apache.kafka.common.network.ClientInformation)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Network.ClientInformation"/></param>
        public void RegisterClientInformation(Org.Apache.Kafka.Common.Network.ClientInformation arg0)
        {
            IExecute("registerClientInformation", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}