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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using connect-mirror-client-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Mirror
{
    #region Heartbeat
    public partial class Heartbeat
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.8.0/org/apache/kafka/connect/mirror/Heartbeat.html#org.apache.kafka.connect.mirror.Heartbeat(java.lang.String,java.lang.String,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public Heartbeat(Java.Lang.String arg0, Java.Lang.String arg1, long arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.8.0/org/apache/kafka/connect/mirror/Heartbeat.html#SOURCE_CLUSTER_ALIAS_KEY"/>
        /// </summary>
        public static Java.Lang.String SOURCE_CLUSTER_ALIAS_KEY { get { if (!_SOURCE_CLUSTER_ALIAS_KEYReady) { _SOURCE_CLUSTER_ALIAS_KEYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SOURCE_CLUSTER_ALIAS_KEY"); _SOURCE_CLUSTER_ALIAS_KEYReady = true; } return _SOURCE_CLUSTER_ALIAS_KEYContent; } }
        private static Java.Lang.String _SOURCE_CLUSTER_ALIAS_KEYContent = default;
        private static bool _SOURCE_CLUSTER_ALIAS_KEYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.8.0/org/apache/kafka/connect/mirror/Heartbeat.html#TARGET_CLUSTER_ALIAS_KEY"/>
        /// </summary>
        public static Java.Lang.String TARGET_CLUSTER_ALIAS_KEY { get { if (!_TARGET_CLUSTER_ALIAS_KEYReady) { _TARGET_CLUSTER_ALIAS_KEYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TARGET_CLUSTER_ALIAS_KEY"); _TARGET_CLUSTER_ALIAS_KEYReady = true; } return _TARGET_CLUSTER_ALIAS_KEYContent; } }
        private static Java.Lang.String _TARGET_CLUSTER_ALIAS_KEYContent = default;
        private static bool _TARGET_CLUSTER_ALIAS_KEYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.8.0/org/apache/kafka/connect/mirror/Heartbeat.html#TIMESTAMP_KEY"/>
        /// </summary>
        public static Java.Lang.String TIMESTAMP_KEY { get { if (!_TIMESTAMP_KEYReady) { _TIMESTAMP_KEYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TIMESTAMP_KEY"); _TIMESTAMP_KEYReady = true; } return _TIMESTAMP_KEYContent; } }
        private static Java.Lang.String _TIMESTAMP_KEYContent = default;
        private static bool _TIMESTAMP_KEYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.8.0/org/apache/kafka/connect/mirror/Heartbeat.html#VERSION_KEY"/>
        /// </summary>
        public static Java.Lang.String VERSION_KEY { get { if (!_VERSION_KEYReady) { _VERSION_KEYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "VERSION_KEY"); _VERSION_KEYReady = true; } return _VERSION_KEYContent; } }
        private static Java.Lang.String _VERSION_KEYContent = default;
        private static bool _VERSION_KEYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.8.0/org/apache/kafka/connect/mirror/Heartbeat.html#VERSION"/>
        /// </summary>
        public static short VERSION { get { if (!_VERSIONReady) { _VERSIONContent = SGetField<short>(LocalBridgeClazz, "VERSION"); _VERSIONReady = true; } return _VERSIONContent; } }
        private static short _VERSIONContent = default;
        private static bool _VERSIONReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.8.0/org/apache/kafka/connect/mirror/Heartbeat.html#deserializeRecord-org.apache.kafka.clients.consumer.ConsumerRecord-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerRecord"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Mirror.Heartbeat"/></returns>
        public static Org.Apache.Kafka.Connect.Mirror.Heartbeat DeserializeRecord(Org.Apache.Kafka.Clients.Consumer.ConsumerRecord<byte[], byte[]> arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Connect.Mirror.Heartbeat>(LocalBridgeClazz, "deserializeRecord", "(Lorg/apache/kafka/clients/consumer/ConsumerRecord;)Lorg/apache/kafka/connect/mirror/Heartbeat;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.8.0/org/apache/kafka/connect/mirror/Heartbeat.html#sourceClusterAlias--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String SourceClusterAlias()
        {
            return IExecuteWithSignature<Java.Lang.String>("sourceClusterAlias", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.8.0/org/apache/kafka/connect/mirror/Heartbeat.html#targetClusterAlias--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String TargetClusterAlias()
        {
            return IExecuteWithSignature<Java.Lang.String>("targetClusterAlias", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.8.0/org/apache/kafka/connect/mirror/Heartbeat.html#timestamp--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long Timestamp()
        {
            return IExecuteWithSignature<long>("timestamp", "()J");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}