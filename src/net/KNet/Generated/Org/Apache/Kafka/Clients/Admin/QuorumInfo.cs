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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*  using kafka-clients-3.7.0.jar as reference
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/admin/QuorumInfo.html#leaderId--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int LeaderId()
        {
            return IExecuteWithSignature<int>("leaderId", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/admin/QuorumInfo.html#observers--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Org.Apache.Kafka.Clients.Admin.QuorumInfo.ReplicaState> Observers()
        {
            return IExecuteWithSignature<Java.Util.List<Org.Apache.Kafka.Clients.Admin.QuorumInfo.ReplicaState>>("observers", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/admin/QuorumInfo.html#voters--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Org.Apache.Kafka.Clients.Admin.QuorumInfo.ReplicaState> Voters()
        {
            return IExecuteWithSignature<Java.Util.List<Org.Apache.Kafka.Clients.Admin.QuorumInfo.ReplicaState>>("voters", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/admin/QuorumInfo.html#highWatermark--"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long HighWatermark()
        {
            return IExecuteWithSignature<long>("highWatermark", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/admin/QuorumInfo.html#leaderEpoch--"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long LeaderEpoch()
        {
            return IExecuteWithSignature<long>("leaderEpoch", "()J");
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/admin/QuorumInfo.ReplicaState.html#replicaId--"/>
            /// </summary>

            /// <returns><see cref="int"/></returns>
            public int ReplicaId()
            {
                return IExecuteWithSignature<int>("replicaId", "()I");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/admin/QuorumInfo.ReplicaState.html#lastCaughtUpTimestamp--"/>
            /// </summary>

            /// <returns><see cref="Java.Util.OptionalLong"/></returns>
            public Java.Util.OptionalLong LastCaughtUpTimestamp()
            {
                return IExecuteWithSignature<Java.Util.OptionalLong>("lastCaughtUpTimestamp", "()Ljava/util/OptionalLong;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/admin/QuorumInfo.ReplicaState.html#lastFetchTimestamp--"/>
            /// </summary>

            /// <returns><see cref="Java.Util.OptionalLong"/></returns>
            public Java.Util.OptionalLong LastFetchTimestamp()
            {
                return IExecuteWithSignature<Java.Util.OptionalLong>("lastFetchTimestamp", "()Ljava/util/OptionalLong;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/admin/QuorumInfo.ReplicaState.html#logEndOffset--"/>
            /// </summary>

            /// <returns><see cref="long"/></returns>
            public long LogEndOffset()
            {
                return IExecuteWithSignature<long>("logEndOffset", "()J");
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