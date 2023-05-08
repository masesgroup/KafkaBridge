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
*  using kafka_2.13-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Kafka.Server
{
    #region FetchSession
    public partial class FetchSession
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/FetchSession.html#%3Cinit%3E(int,boolean,org.apache.kafka.common.utils.ImplicitLinkedHashCollection,boolean,long,long,int)"/>
        /// </summary>
        /// <param name="id"><see cref="int"/></param>
        /// <param name="privileged"><see cref="bool"/></param>
        /// <param name="partitionMap"><see cref="Org.Apache.Kafka.Common.Utils.ImplicitLinkedHashCollection"/></param>
        /// <param name="usesTopicIds"><see cref="bool"/></param>
        /// <param name="creationMs"><see cref="long"/></param>
        /// <param name="lastUsedMs"><see cref="long"/></param>
        /// <param name="epoch"><see cref="int"/></param>
        public FetchSession(int id, bool privileged, Org.Apache.Kafka.Common.Utils.ImplicitLinkedHashCollection partitionMap, bool usesTopicIds, long creationMs, long lastUsedMs, int epoch)
            : base(id, privileged, partitionMap, usesTopicIds, creationMs, lastUsedMs, epoch)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/FetchSession.html#EVICTIONS()"/> 
        /// </summary>
        public static string EVICTIONS
        {
            get { return SExecute<string>(LocalBridgeClazz, "EVICTIONS"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/FetchSession.html#INCREMENTAL_FETCH_SESSIONS_EVICTIONS_PER_SEC()"/> 
        /// </summary>
        public static string INCREMENTAL_FETCH_SESSIONS_EVICTIONS_PER_SEC
        {
            get { return SExecute<string>(LocalBridgeClazz, "INCREMENTAL_FETCH_SESSIONS_EVICTIONS_PER_SEC"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/FetchSession.html#NUM_INCREMENTAL_FETCH_PARTITIONS_CACHED()"/> 
        /// </summary>
        public static string NUM_INCREMENTAL_FETCH_PARTITIONS_CACHED
        {
            get { return SExecute<string>(LocalBridgeClazz, "NUM_INCREMENTAL_FETCH_PARTITIONS_CACHED"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/FetchSession.html#NUM_INCREMENTAL_FETCH_SESSIONS()"/> 
        /// </summary>
        public static string NUM_INCREMENTAL_FETCH_SESSIONS
        {
            get { return SExecute<string>(LocalBridgeClazz, "NUM_INCREMENTAL_FETCH_SESSIONS"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/FetchSession.html#partitionsToLogString(java.util.Collection,boolean)"/>
        /// </summary>
        /// <param name="partitions"><see cref="Java.Util.Collection"/></param>
        /// <param name="traceEnabled"><see cref="bool"/></param>
        /// <returns><see cref="string"/></returns>
        public static string PartitionsToLogString(Java.Util.Collection<Org.Apache.Kafka.Common.TopicIdPartition> partitions, bool traceEnabled)
        {
            return SExecute<string>(LocalBridgeClazz, "partitionsToLogString", partitions, traceEnabled);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/FetchSession.html#cachedSize()"/> 
        /// </summary>
        public int CachedSize
        {
            get { return IExecute<int>("cachedSize"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/FetchSession.html#creationMs()"/> 
        /// </summary>
        public long CreationMs
        {
            get { return IExecute<long>("creationMs"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/FetchSession.html#epoch()"/> 
        /// </summary>
        public int Epoch
        {
            get { return IExecute<int>("epoch"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/FetchSession.html#evictableKey()"/> 
        /// </summary>
        public Kafka.Server.EvictableKey EvictableKey
        {
            get { return IExecute<Kafka.Server.EvictableKey>("evictableKey"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/FetchSession.html#id()"/> 
        /// </summary>
        public int Id
        {
            get { return IExecute<int>("id"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/FetchSession.html#isEmpty()"/> 
        /// </summary>
        public bool IsEmpty
        {
            get { return IExecute<bool>("isEmpty"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/FetchSession.html#lastUsedKey()"/> 
        /// </summary>
        public Kafka.Server.LastUsedKey LastUsedKey
        {
            get { return IExecute<Kafka.Server.LastUsedKey>("lastUsedKey"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/FetchSession.html#lastUsedMs()"/> 
        /// </summary>
        public long LastUsedMs
        {
            get { return IExecute<long>("lastUsedMs"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/FetchSession.html#metadata()"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.Requests.FetchMetadata Metadata
        {
            get { return IExecute<Org.Apache.Kafka.Common.Requests.FetchMetadata>("metadata"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/FetchSession.html#partitionMap()"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.Utils.ImplicitLinkedHashCollection<Kafka.Server.CachedPartition> PartitionMap
        {
            get { return IExecute<Org.Apache.Kafka.Common.Utils.ImplicitLinkedHashCollection<Kafka.Server.CachedPartition>>("partitionMap"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/FetchSession.html#privileged()"/> 
        /// </summary>
        public bool Privileged
        {
            get { return IExecute<bool>("privileged"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/FetchSession.html#size()"/> 
        /// </summary>
        public int Size
        {
            get { return IExecute<int>("size"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/FetchSession.html#usesTopicIds()"/> 
        /// </summary>
        public bool UsesTopicIds
        {
            get { return IExecute<bool>("usesTopicIds"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}