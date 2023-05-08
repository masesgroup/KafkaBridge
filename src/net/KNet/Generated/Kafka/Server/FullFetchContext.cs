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
    #region FullFetchContext
    public partial class FullFetchContext
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/FullFetchContext.html#%3Cinit%3E(org.apache.kafka.common.utils.Time,kafka.server.FetchSessionCache,org.apache.kafka.common.requests.FetchMetadata,java.util.Map,boolean,boolean)"/>
        /// </summary>
        /// <param name="time"><see cref="Org.Apache.Kafka.Common.Utils.Time"/></param>
        /// <param name="cache"><see cref="Kafka.Server.FetchSessionCache"/></param>
        /// <param name="reqMetadata"><see cref="Org.Apache.Kafka.Common.Requests.FetchMetadata"/></param>
        /// <param name="fetchData"><see cref="Java.Util.Map"/></param>
        /// <param name="usesTopicIds"><see cref="bool"/></param>
        /// <param name="isFromFollower"><see cref="bool"/></param>
        public FullFetchContext(Org.Apache.Kafka.Common.Utils.Time time, Kafka.Server.FetchSessionCache cache, Org.Apache.Kafka.Common.Requests.FetchMetadata reqMetadata, Java.Util.Map fetchData, bool usesTopicIds, bool isFromFollower)
            : base(time, cache, reqMetadata, fetchData, usesTopicIds, isFromFollower)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Kafka.Server.FullFetchContext"/> to <see cref="Kafka.Server.FetchContext"/>
        /// </summary>
        public static implicit operator Kafka.Server.FetchContext(Kafka.Server.FullFetchContext t) => t.Cast<Kafka.Server.FetchContext>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/FullFetchContext.html#isDebugEnabled()"/> 
        /// </summary>
        public bool IsDebugEnabled
        {
            get { return IExecute<bool>("isDebugEnabled"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/FullFetchContext.html#isTraceEnabled()"/> 
        /// </summary>
        public bool IsTraceEnabled
        {
            get { return IExecute<bool>("isTraceEnabled"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/FullFetchContext.html#logger()"/> 
        /// </summary>
        public Com.Typesafe.Scalalogging.Logger Logger
        {
            get { return IExecute<Com.Typesafe.Scalalogging.Logger>("logger"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/FullFetchContext.html#loggerName()"/> 
        /// </summary>
        public string LoggerName
        {
            get { return IExecute<string>("loggerName"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/FullFetchContext.html#logIdent()"/> 
        /// </summary>
        public string LogIdent
        {
            get { return IExecute<string>("logIdent"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/FullFetchContext.html#getResponseSize(java.util.LinkedHashMap,short)"/>
        /// </summary>
        /// <param name="updates"><see cref="Java.Util.LinkedHashMap"/></param>
        /// <param name="versionId"><see cref="short"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetResponseSize(Java.Util.LinkedHashMap<Org.Apache.Kafka.Common.TopicIdPartition, Org.Apache.Kafka.Common.Message.FetchResponseData.PartitionData> updates, short versionId)
        {
            return IExecute<int>("getResponseSize", updates, versionId);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/FullFetchContext.html#msgWithLogIdent(java.lang.String)"/>
        /// </summary>
        /// <param name="msg"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string MsgWithLogIdent(string msg)
        {
            return IExecute<string>("msgWithLogIdent", msg);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/FullFetchContext.html#partitionsToLogString(java.util.Collection)"/>
        /// </summary>
        /// <param name="partitions"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="string"/></returns>
        public string PartitionsToLogString(Java.Util.Collection<Org.Apache.Kafka.Common.TopicIdPartition> partitions)
        {
            return IExecute<string>("partitionsToLogString", partitions);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/FullFetchContext.html#getThrottledResponse(int)"/>
        /// </summary>
        /// <param name="throttleTimeMs"><see cref="int"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Requests.FetchResponse"/></returns>
        public Org.Apache.Kafka.Common.Requests.FetchResponse GetThrottledResponse(int throttleTimeMs)
        {
            return IExecute<Org.Apache.Kafka.Common.Requests.FetchResponse>("getThrottledResponse", throttleTimeMs);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/FullFetchContext.html#updateAndGenerateResponseData(java.util.LinkedHashMap)"/>
        /// </summary>
        /// <param name="updates"><see cref="Java.Util.LinkedHashMap"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Requests.FetchResponse"/></returns>
        public Org.Apache.Kafka.Common.Requests.FetchResponse UpdateAndGenerateResponseData(Java.Util.LinkedHashMap<Org.Apache.Kafka.Common.TopicIdPartition, Org.Apache.Kafka.Common.Message.FetchResponseData.PartitionData> updates)
        {
            return IExecute<Org.Apache.Kafka.Common.Requests.FetchResponse>("updateAndGenerateResponseData", updates);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}