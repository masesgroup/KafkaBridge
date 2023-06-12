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
    #region ReauthenticationContext
    public partial class ReauthenticationContext
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/network/ReauthenticationContext.html#%3Cinit%3E(org.apache.kafka.common.network.Authenticator,org.apache.kafka.common.network.NetworkReceive,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Network.Authenticator"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Network.NetworkReceive"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public ReauthenticationContext(Org.Apache.Kafka.Common.Network.Authenticator arg0, Org.Apache.Kafka.Common.Network.NetworkReceive arg1, long arg2)
            : base(arg0, arg1, arg2)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/network/ReauthenticationContext.html#reauthenticationBeginNanos()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long ReauthenticationBeginNanos()
        {
            return IExecute<long>("reauthenticationBeginNanos");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/network/ReauthenticationContext.html#previousAuthenticator()"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Network.Authenticator"/></returns>
        public Org.Apache.Kafka.Common.Network.Authenticator PreviousAuthenticator()
        {
            return IExecute<Org.Apache.Kafka.Common.Network.Authenticator>("previousAuthenticator");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/network/ReauthenticationContext.html#networkReceive()"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Network.NetworkReceive"/></returns>
        public Org.Apache.Kafka.Common.Network.NetworkReceive NetworkReceive()
        {
            return IExecute<Org.Apache.Kafka.Common.Network.NetworkReceive>("networkReceive");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}