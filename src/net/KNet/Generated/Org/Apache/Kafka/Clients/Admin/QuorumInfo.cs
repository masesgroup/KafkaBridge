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
*  using kafka-clients-3.6.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Admin
{
    #region QuorumInfo
    public partial class QuorumInfo
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/admin/QuorumInfo.html#leaderId--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int LeaderId()
        {
            return IExecute<int>("leaderId");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/admin/QuorumInfo.html#observers--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Org.Apache.Kafka.Clients.Admin.QuorumInfo.ReplicaState> Observers()
        {
            return IExecute<Java.Util.List<Org.Apache.Kafka.Clients.Admin.QuorumInfo.ReplicaState>>("observers");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/admin/QuorumInfo.html#voters--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Org.Apache.Kafka.Clients.Admin.QuorumInfo.ReplicaState> Voters()
        {
            return IExecute<Java.Util.List<Org.Apache.Kafka.Clients.Admin.QuorumInfo.ReplicaState>>("voters");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/admin/QuorumInfo.html#highWatermark--"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long HighWatermark()
        {
            return IExecute<long>("highWatermark");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/admin/QuorumInfo.html#leaderEpoch--"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long LeaderEpoch()
        {
            return IExecute<long>("leaderEpoch");
        }

        #endregion

        #region Nested classes
        #region ReplicaState
        public partial class ReplicaState
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/admin/QuorumInfo.ReplicaState.html#replicaId--"/>
            /// </summary>

            /// <returns><see cref="int"/></returns>
            public int ReplicaId()
            {
                return IExecute<int>("replicaId");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/admin/QuorumInfo.ReplicaState.html#lastCaughtUpTimestamp--"/>
            /// </summary>

            /// <returns><see cref="Java.Util.OptionalLong"/></returns>
            public Java.Util.OptionalLong LastCaughtUpTimestamp()
            {
                return IExecute<Java.Util.OptionalLong>("lastCaughtUpTimestamp");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/admin/QuorumInfo.ReplicaState.html#lastFetchTimestamp--"/>
            /// </summary>

            /// <returns><see cref="Java.Util.OptionalLong"/></returns>
            public Java.Util.OptionalLong LastFetchTimestamp()
            {
                return IExecute<Java.Util.OptionalLong>("lastFetchTimestamp");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/admin/QuorumInfo.ReplicaState.html#logEndOffset--"/>
            /// </summary>

            /// <returns><see cref="long"/></returns>
            public long LogEndOffset()
            {
                return IExecute<long>("logEndOffset");
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