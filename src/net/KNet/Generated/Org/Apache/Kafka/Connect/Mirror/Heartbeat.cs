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
*  using connect-mirror-client-3.6.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Mirror
{
    #region Heartbeat
    public partial class Heartbeat
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.6.0/org/apache/kafka/connect/mirror/Heartbeat.html#org.apache.kafka.connect.mirror.Heartbeat(java.lang.String,java.lang.String,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public Heartbeat(string arg0, string arg1, long arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.6.0/org/apache/kafka/connect/mirror/Heartbeat.html#SOURCE_CLUSTER_ALIAS_KEY"/>
        /// </summary>
        public static string SOURCE_CLUSTER_ALIAS_KEY { get { return SGetField<string>(LocalBridgeClazz, "SOURCE_CLUSTER_ALIAS_KEY"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.6.0/org/apache/kafka/connect/mirror/Heartbeat.html#TARGET_CLUSTER_ALIAS_KEY"/>
        /// </summary>
        public static string TARGET_CLUSTER_ALIAS_KEY { get { return SGetField<string>(LocalBridgeClazz, "TARGET_CLUSTER_ALIAS_KEY"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.6.0/org/apache/kafka/connect/mirror/Heartbeat.html#TIMESTAMP_KEY"/>
        /// </summary>
        public static string TIMESTAMP_KEY { get { return SGetField<string>(LocalBridgeClazz, "TIMESTAMP_KEY"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.6.0/org/apache/kafka/connect/mirror/Heartbeat.html#VERSION_KEY"/>
        /// </summary>
        public static string VERSION_KEY { get { return SGetField<string>(LocalBridgeClazz, "VERSION_KEY"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.6.0/org/apache/kafka/connect/mirror/Heartbeat.html#VERSION"/>
        /// </summary>
        public static short VERSION { get { return SGetField<short>(LocalBridgeClazz, "VERSION"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.6.0/org/apache/kafka/connect/mirror/Heartbeat.html#deserializeRecord-org.apache.kafka.clients.consumer.ConsumerRecord-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerRecord"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Mirror.Heartbeat"/></returns>
        public static Org.Apache.Kafka.Connect.Mirror.Heartbeat DeserializeRecord(Org.Apache.Kafka.Clients.Consumer.ConsumerRecord<byte[], byte[]> arg0)
        {
            return SExecute<Org.Apache.Kafka.Connect.Mirror.Heartbeat>(LocalBridgeClazz, "deserializeRecord", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.6.0/org/apache/kafka/connect/mirror/Heartbeat.html#sourceClusterAlias--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string SourceClusterAlias()
        {
            return IExecute<string>("sourceClusterAlias");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.6.0/org/apache/kafka/connect/mirror/Heartbeat.html#targetClusterAlias--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string TargetClusterAlias()
        {
            return IExecute<string>("targetClusterAlias");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.6.0/org/apache/kafka/connect/mirror/Heartbeat.html#timestamp--"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long Timestamp()
        {
            return IExecute<long>("timestamp");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}