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

namespace Org.Apache.Kafka.Clients
{
    #region GroupRebalanceConfig
    public partial class GroupRebalanceConfig
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/GroupRebalanceConfig.html#%3Cinit%3E(int,int,int,java.lang.String,java.util.Optional,long,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        /// <param name="arg4"><see cref="Java.Util.Optional"/></param>
        /// <param name="arg5"><see cref="long"/></param>
        /// <param name="arg6"><see cref="bool"/></param>
        public GroupRebalanceConfig(int arg0, int arg1, int arg2, string arg3, Java.Util.Optional<string> arg4, long arg5, bool arg6)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/GroupRebalanceConfig.html#%3Cinit%3E(org.apache.kafka.common.config.AbstractConfig,org.apache.kafka.clients.GroupRebalanceConfig.ProtocolType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Config.AbstractConfig"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Clients.GroupRebalanceConfig.ProtocolType"/></param>
        public GroupRebalanceConfig(Org.Apache.Kafka.Common.Config.AbstractConfig arg0, Org.Apache.Kafka.Clients.GroupRebalanceConfig.ProtocolType arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/GroupRebalanceConfig.html#leaveGroupOnClose"/>
        /// </summary>
        public bool leaveGroupOnClose { get { return IGetField<bool>("leaveGroupOnClose"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/GroupRebalanceConfig.html#heartbeatIntervalMs"/>
        /// </summary>
        public int heartbeatIntervalMs { get { return IGetField<int>("heartbeatIntervalMs"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/GroupRebalanceConfig.html#rebalanceTimeoutMs"/>
        /// </summary>
        public int rebalanceTimeoutMs { get { return IGetField<int>("rebalanceTimeoutMs"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/GroupRebalanceConfig.html#sessionTimeoutMs"/>
        /// </summary>
        public int sessionTimeoutMs { get { return IGetField<int>("sessionTimeoutMs"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/GroupRebalanceConfig.html#groupId"/>
        /// </summary>
        public string groupId { get { return IGetField<string>("groupId"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/GroupRebalanceConfig.html#groupInstanceId"/>
        /// </summary>
        public Java.Util.Optional groupInstanceId { get { return IGetField<Java.Util.Optional>("groupInstanceId"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/GroupRebalanceConfig.html#retryBackoffMs"/>
        /// </summary>
        public long retryBackoffMs { get { return IGetField<long>("retryBackoffMs"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region ProtocolType
        public partial class ProtocolType
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/GroupRebalanceConfig.ProtocolType.html#CONNECT"/>
            /// </summary>
            public static Org.Apache.Kafka.Clients.GroupRebalanceConfig.ProtocolType CONNECT { get { return SGetField<Org.Apache.Kafka.Clients.GroupRebalanceConfig.ProtocolType>(LocalBridgeClazz, "CONNECT"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/GroupRebalanceConfig.ProtocolType.html#CONSUMER"/>
            /// </summary>
            public static Org.Apache.Kafka.Clients.GroupRebalanceConfig.ProtocolType CONSUMER { get { return SGetField<Org.Apache.Kafka.Clients.GroupRebalanceConfig.ProtocolType>(LocalBridgeClazz, "CONSUMER"); } }

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/GroupRebalanceConfig.ProtocolType.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Clients.GroupRebalanceConfig.ProtocolType"/></returns>
            public static Org.Apache.Kafka.Clients.GroupRebalanceConfig.ProtocolType ValueOf(string arg0)
            {
                return SExecute<Org.Apache.Kafka.Clients.GroupRebalanceConfig.ProtocolType>(LocalBridgeClazz, "valueOf", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/GroupRebalanceConfig.ProtocolType.html#values()"/>
            /// </summary>

            /// <returns><see cref="Org.Apache.Kafka.Clients.GroupRebalanceConfig.ProtocolType"/></returns>
            public static Org.Apache.Kafka.Clients.GroupRebalanceConfig.ProtocolType[] Values()
            {
                return SExecuteArray<Org.Apache.Kafka.Clients.GroupRebalanceConfig.ProtocolType>(LocalBridgeClazz, "values");
            }

            #endregion

            #region Instance methods

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