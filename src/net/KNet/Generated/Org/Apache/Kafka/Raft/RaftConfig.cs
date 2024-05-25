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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using kafka-raft-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Raft
{
    #region RaftConfig
    public partial class RaftConfig
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/RaftConfig.html#org.apache.kafka.raft.RaftConfig(java.util.Map,int,int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        public RaftConfig(Java.Util.Map<Java.Lang.Integer, Org.Apache.Kafka.Raft.RaftConfig.AddressSpec> arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/RaftConfig.html#org.apache.kafka.raft.RaftConfig(org.apache.kafka.common.config.AbstractConfig)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Config.AbstractConfig"/></param>
        public RaftConfig(Org.Apache.Kafka.Common.Config.AbstractConfig arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/RaftConfig.html#DEFAULT_QUORUM_ELECTION_BACKOFF_MAX_MS"/>
        /// </summary>
        public static int DEFAULT_QUORUM_ELECTION_BACKOFF_MAX_MS { get { if (!_DEFAULT_QUORUM_ELECTION_BACKOFF_MAX_MSReady) { _DEFAULT_QUORUM_ELECTION_BACKOFF_MAX_MSContent = SGetField<int>(LocalBridgeClazz, "DEFAULT_QUORUM_ELECTION_BACKOFF_MAX_MS"); _DEFAULT_QUORUM_ELECTION_BACKOFF_MAX_MSReady = true; } return _DEFAULT_QUORUM_ELECTION_BACKOFF_MAX_MSContent; } }
        private static int _DEFAULT_QUORUM_ELECTION_BACKOFF_MAX_MSContent = default;
        private static bool _DEFAULT_QUORUM_ELECTION_BACKOFF_MAX_MSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/RaftConfig.html#DEFAULT_QUORUM_ELECTION_TIMEOUT_MS"/>
        /// </summary>
        public static int DEFAULT_QUORUM_ELECTION_TIMEOUT_MS { get { if (!_DEFAULT_QUORUM_ELECTION_TIMEOUT_MSReady) { _DEFAULT_QUORUM_ELECTION_TIMEOUT_MSContent = SGetField<int>(LocalBridgeClazz, "DEFAULT_QUORUM_ELECTION_TIMEOUT_MS"); _DEFAULT_QUORUM_ELECTION_TIMEOUT_MSReady = true; } return _DEFAULT_QUORUM_ELECTION_TIMEOUT_MSContent; } }
        private static int _DEFAULT_QUORUM_ELECTION_TIMEOUT_MSContent = default;
        private static bool _DEFAULT_QUORUM_ELECTION_TIMEOUT_MSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/RaftConfig.html#DEFAULT_QUORUM_FETCH_TIMEOUT_MS"/>
        /// </summary>
        public static int DEFAULT_QUORUM_FETCH_TIMEOUT_MS { get { if (!_DEFAULT_QUORUM_FETCH_TIMEOUT_MSReady) { _DEFAULT_QUORUM_FETCH_TIMEOUT_MSContent = SGetField<int>(LocalBridgeClazz, "DEFAULT_QUORUM_FETCH_TIMEOUT_MS"); _DEFAULT_QUORUM_FETCH_TIMEOUT_MSReady = true; } return _DEFAULT_QUORUM_FETCH_TIMEOUT_MSContent; } }
        private static int _DEFAULT_QUORUM_FETCH_TIMEOUT_MSContent = default;
        private static bool _DEFAULT_QUORUM_FETCH_TIMEOUT_MSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/RaftConfig.html#DEFAULT_QUORUM_LINGER_MS"/>
        /// </summary>
        public static int DEFAULT_QUORUM_LINGER_MS { get { if (!_DEFAULT_QUORUM_LINGER_MSReady) { _DEFAULT_QUORUM_LINGER_MSContent = SGetField<int>(LocalBridgeClazz, "DEFAULT_QUORUM_LINGER_MS"); _DEFAULT_QUORUM_LINGER_MSReady = true; } return _DEFAULT_QUORUM_LINGER_MSContent; } }
        private static int _DEFAULT_QUORUM_LINGER_MSContent = default;
        private static bool _DEFAULT_QUORUM_LINGER_MSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/RaftConfig.html#DEFAULT_QUORUM_REQUEST_TIMEOUT_MS"/>
        /// </summary>
        public static int DEFAULT_QUORUM_REQUEST_TIMEOUT_MS { get { if (!_DEFAULT_QUORUM_REQUEST_TIMEOUT_MSReady) { _DEFAULT_QUORUM_REQUEST_TIMEOUT_MSContent = SGetField<int>(LocalBridgeClazz, "DEFAULT_QUORUM_REQUEST_TIMEOUT_MS"); _DEFAULT_QUORUM_REQUEST_TIMEOUT_MSReady = true; } return _DEFAULT_QUORUM_REQUEST_TIMEOUT_MSContent; } }
        private static int _DEFAULT_QUORUM_REQUEST_TIMEOUT_MSContent = default;
        private static bool _DEFAULT_QUORUM_REQUEST_TIMEOUT_MSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/RaftConfig.html#DEFAULT_QUORUM_RETRY_BACKOFF_MS"/>
        /// </summary>
        public static int DEFAULT_QUORUM_RETRY_BACKOFF_MS { get { if (!_DEFAULT_QUORUM_RETRY_BACKOFF_MSReady) { _DEFAULT_QUORUM_RETRY_BACKOFF_MSContent = SGetField<int>(LocalBridgeClazz, "DEFAULT_QUORUM_RETRY_BACKOFF_MS"); _DEFAULT_QUORUM_RETRY_BACKOFF_MSReady = true; } return _DEFAULT_QUORUM_RETRY_BACKOFF_MSContent; } }
        private static int _DEFAULT_QUORUM_RETRY_BACKOFF_MSContent = default;
        private static bool _DEFAULT_QUORUM_RETRY_BACKOFF_MSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/RaftConfig.html#QUORUM_ELECTION_BACKOFF_MAX_MS_CONFIG"/>
        /// </summary>
        public static Java.Lang.String QUORUM_ELECTION_BACKOFF_MAX_MS_CONFIG { get { if (!_QUORUM_ELECTION_BACKOFF_MAX_MS_CONFIGReady) { _QUORUM_ELECTION_BACKOFF_MAX_MS_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "QUORUM_ELECTION_BACKOFF_MAX_MS_CONFIG"); _QUORUM_ELECTION_BACKOFF_MAX_MS_CONFIGReady = true; } return _QUORUM_ELECTION_BACKOFF_MAX_MS_CONFIGContent; } }
        private static Java.Lang.String _QUORUM_ELECTION_BACKOFF_MAX_MS_CONFIGContent = default;
        private static bool _QUORUM_ELECTION_BACKOFF_MAX_MS_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/RaftConfig.html#QUORUM_ELECTION_BACKOFF_MAX_MS_DOC"/>
        /// </summary>
        public static Java.Lang.String QUORUM_ELECTION_BACKOFF_MAX_MS_DOC { get { if (!_QUORUM_ELECTION_BACKOFF_MAX_MS_DOCReady) { _QUORUM_ELECTION_BACKOFF_MAX_MS_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "QUORUM_ELECTION_BACKOFF_MAX_MS_DOC"); _QUORUM_ELECTION_BACKOFF_MAX_MS_DOCReady = true; } return _QUORUM_ELECTION_BACKOFF_MAX_MS_DOCContent; } }
        private static Java.Lang.String _QUORUM_ELECTION_BACKOFF_MAX_MS_DOCContent = default;
        private static bool _QUORUM_ELECTION_BACKOFF_MAX_MS_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/RaftConfig.html#QUORUM_ELECTION_TIMEOUT_MS_CONFIG"/>
        /// </summary>
        public static Java.Lang.String QUORUM_ELECTION_TIMEOUT_MS_CONFIG { get { if (!_QUORUM_ELECTION_TIMEOUT_MS_CONFIGReady) { _QUORUM_ELECTION_TIMEOUT_MS_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "QUORUM_ELECTION_TIMEOUT_MS_CONFIG"); _QUORUM_ELECTION_TIMEOUT_MS_CONFIGReady = true; } return _QUORUM_ELECTION_TIMEOUT_MS_CONFIGContent; } }
        private static Java.Lang.String _QUORUM_ELECTION_TIMEOUT_MS_CONFIGContent = default;
        private static bool _QUORUM_ELECTION_TIMEOUT_MS_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/RaftConfig.html#QUORUM_ELECTION_TIMEOUT_MS_DOC"/>
        /// </summary>
        public static Java.Lang.String QUORUM_ELECTION_TIMEOUT_MS_DOC { get { if (!_QUORUM_ELECTION_TIMEOUT_MS_DOCReady) { _QUORUM_ELECTION_TIMEOUT_MS_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "QUORUM_ELECTION_TIMEOUT_MS_DOC"); _QUORUM_ELECTION_TIMEOUT_MS_DOCReady = true; } return _QUORUM_ELECTION_TIMEOUT_MS_DOCContent; } }
        private static Java.Lang.String _QUORUM_ELECTION_TIMEOUT_MS_DOCContent = default;
        private static bool _QUORUM_ELECTION_TIMEOUT_MS_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/RaftConfig.html#QUORUM_FETCH_TIMEOUT_MS_CONFIG"/>
        /// </summary>
        public static Java.Lang.String QUORUM_FETCH_TIMEOUT_MS_CONFIG { get { if (!_QUORUM_FETCH_TIMEOUT_MS_CONFIGReady) { _QUORUM_FETCH_TIMEOUT_MS_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "QUORUM_FETCH_TIMEOUT_MS_CONFIG"); _QUORUM_FETCH_TIMEOUT_MS_CONFIGReady = true; } return _QUORUM_FETCH_TIMEOUT_MS_CONFIGContent; } }
        private static Java.Lang.String _QUORUM_FETCH_TIMEOUT_MS_CONFIGContent = default;
        private static bool _QUORUM_FETCH_TIMEOUT_MS_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/RaftConfig.html#QUORUM_FETCH_TIMEOUT_MS_DOC"/>
        /// </summary>
        public static Java.Lang.String QUORUM_FETCH_TIMEOUT_MS_DOC { get { if (!_QUORUM_FETCH_TIMEOUT_MS_DOCReady) { _QUORUM_FETCH_TIMEOUT_MS_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "QUORUM_FETCH_TIMEOUT_MS_DOC"); _QUORUM_FETCH_TIMEOUT_MS_DOCReady = true; } return _QUORUM_FETCH_TIMEOUT_MS_DOCContent; } }
        private static Java.Lang.String _QUORUM_FETCH_TIMEOUT_MS_DOCContent = default;
        private static bool _QUORUM_FETCH_TIMEOUT_MS_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/RaftConfig.html#QUORUM_LINGER_MS_CONFIG"/>
        /// </summary>
        public static Java.Lang.String QUORUM_LINGER_MS_CONFIG { get { if (!_QUORUM_LINGER_MS_CONFIGReady) { _QUORUM_LINGER_MS_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "QUORUM_LINGER_MS_CONFIG"); _QUORUM_LINGER_MS_CONFIGReady = true; } return _QUORUM_LINGER_MS_CONFIGContent; } }
        private static Java.Lang.String _QUORUM_LINGER_MS_CONFIGContent = default;
        private static bool _QUORUM_LINGER_MS_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/RaftConfig.html#QUORUM_LINGER_MS_DOC"/>
        /// </summary>
        public static Java.Lang.String QUORUM_LINGER_MS_DOC { get { if (!_QUORUM_LINGER_MS_DOCReady) { _QUORUM_LINGER_MS_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "QUORUM_LINGER_MS_DOC"); _QUORUM_LINGER_MS_DOCReady = true; } return _QUORUM_LINGER_MS_DOCContent; } }
        private static Java.Lang.String _QUORUM_LINGER_MS_DOCContent = default;
        private static bool _QUORUM_LINGER_MS_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/RaftConfig.html#QUORUM_REQUEST_TIMEOUT_MS_CONFIG"/>
        /// </summary>
        public static Java.Lang.String QUORUM_REQUEST_TIMEOUT_MS_CONFIG { get { if (!_QUORUM_REQUEST_TIMEOUT_MS_CONFIGReady) { _QUORUM_REQUEST_TIMEOUT_MS_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "QUORUM_REQUEST_TIMEOUT_MS_CONFIG"); _QUORUM_REQUEST_TIMEOUT_MS_CONFIGReady = true; } return _QUORUM_REQUEST_TIMEOUT_MS_CONFIGContent; } }
        private static Java.Lang.String _QUORUM_REQUEST_TIMEOUT_MS_CONFIGContent = default;
        private static bool _QUORUM_REQUEST_TIMEOUT_MS_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/RaftConfig.html#QUORUM_REQUEST_TIMEOUT_MS_DOC"/>
        /// </summary>
        public static Java.Lang.String QUORUM_REQUEST_TIMEOUT_MS_DOC { get { if (!_QUORUM_REQUEST_TIMEOUT_MS_DOCReady) { _QUORUM_REQUEST_TIMEOUT_MS_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "QUORUM_REQUEST_TIMEOUT_MS_DOC"); _QUORUM_REQUEST_TIMEOUT_MS_DOCReady = true; } return _QUORUM_REQUEST_TIMEOUT_MS_DOCContent; } }
        private static Java.Lang.String _QUORUM_REQUEST_TIMEOUT_MS_DOCContent = default;
        private static bool _QUORUM_REQUEST_TIMEOUT_MS_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/RaftConfig.html#QUORUM_RETRY_BACKOFF_MS_CONFIG"/>
        /// </summary>
        public static Java.Lang.String QUORUM_RETRY_BACKOFF_MS_CONFIG { get { if (!_QUORUM_RETRY_BACKOFF_MS_CONFIGReady) { _QUORUM_RETRY_BACKOFF_MS_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "QUORUM_RETRY_BACKOFF_MS_CONFIG"); _QUORUM_RETRY_BACKOFF_MS_CONFIGReady = true; } return _QUORUM_RETRY_BACKOFF_MS_CONFIGContent; } }
        private static Java.Lang.String _QUORUM_RETRY_BACKOFF_MS_CONFIGContent = default;
        private static bool _QUORUM_RETRY_BACKOFF_MS_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/RaftConfig.html#QUORUM_RETRY_BACKOFF_MS_DOC"/>
        /// </summary>
        public static Java.Lang.String QUORUM_RETRY_BACKOFF_MS_DOC { get { if (!_QUORUM_RETRY_BACKOFF_MS_DOCReady) { _QUORUM_RETRY_BACKOFF_MS_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "QUORUM_RETRY_BACKOFF_MS_DOC"); _QUORUM_RETRY_BACKOFF_MS_DOCReady = true; } return _QUORUM_RETRY_BACKOFF_MS_DOCContent; } }
        private static Java.Lang.String _QUORUM_RETRY_BACKOFF_MS_DOCContent = default;
        private static bool _QUORUM_RETRY_BACKOFF_MS_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/RaftConfig.html#QUORUM_VOTERS_CONFIG"/>
        /// </summary>
        public static Java.Lang.String QUORUM_VOTERS_CONFIG { get { if (!_QUORUM_VOTERS_CONFIGReady) { _QUORUM_VOTERS_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "QUORUM_VOTERS_CONFIG"); _QUORUM_VOTERS_CONFIGReady = true; } return _QUORUM_VOTERS_CONFIGContent; } }
        private static Java.Lang.String _QUORUM_VOTERS_CONFIGContent = default;
        private static bool _QUORUM_VOTERS_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/RaftConfig.html#QUORUM_VOTERS_DOC"/>
        /// </summary>
        public static Java.Lang.String QUORUM_VOTERS_DOC { get { if (!_QUORUM_VOTERS_DOCReady) { _QUORUM_VOTERS_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "QUORUM_VOTERS_DOC"); _QUORUM_VOTERS_DOCReady = true; } return _QUORUM_VOTERS_DOCContent; } }
        private static Java.Lang.String _QUORUM_VOTERS_DOCContent = default;
        private static bool _QUORUM_VOTERS_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/RaftConfig.html#NON_ROUTABLE_ADDRESS"/>
        /// </summary>
        public static Java.Net.InetSocketAddress NON_ROUTABLE_ADDRESS { get { if (!_NON_ROUTABLE_ADDRESSReady) { _NON_ROUTABLE_ADDRESSContent = SGetField<Java.Net.InetSocketAddress>(LocalBridgeClazz, "NON_ROUTABLE_ADDRESS"); _NON_ROUTABLE_ADDRESSReady = true; } return _NON_ROUTABLE_ADDRESSContent; } }
        private static Java.Net.InetSocketAddress _NON_ROUTABLE_ADDRESSContent = default;
        private static bool _NON_ROUTABLE_ADDRESSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/RaftConfig.html#DEFAULT_QUORUM_VOTERS"/>
        /// </summary>
        public static Java.Util.List DEFAULT_QUORUM_VOTERS { get { if (!_DEFAULT_QUORUM_VOTERSReady) { _DEFAULT_QUORUM_VOTERSContent = SGetField<Java.Util.List>(LocalBridgeClazz, "DEFAULT_QUORUM_VOTERS"); _DEFAULT_QUORUM_VOTERSReady = true; } return _DEFAULT_QUORUM_VOTERSContent; } }
        private static Java.Util.List _DEFAULT_QUORUM_VOTERSContent = default;
        private static bool _DEFAULT_QUORUM_VOTERSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/RaftConfig.html#UNKNOWN_ADDRESS_SPEC_INSTANCE"/>
        /// </summary>
        public static Org.Apache.Kafka.Raft.RaftConfig.UnknownAddressSpec UNKNOWN_ADDRESS_SPEC_INSTANCE { get { if (!_UNKNOWN_ADDRESS_SPEC_INSTANCEReady) { _UNKNOWN_ADDRESS_SPEC_INSTANCEContent = SGetField<Org.Apache.Kafka.Raft.RaftConfig.UnknownAddressSpec>(LocalBridgeClazz, "UNKNOWN_ADDRESS_SPEC_INSTANCE"); _UNKNOWN_ADDRESS_SPEC_INSTANCEReady = true; } return _UNKNOWN_ADDRESS_SPEC_INSTANCEContent; } }
        private static Org.Apache.Kafka.Raft.RaftConfig.UnknownAddressSpec _UNKNOWN_ADDRESS_SPEC_INSTANCEContent = default;
        private static bool _UNKNOWN_ADDRESS_SPEC_INSTANCEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/RaftConfig.html#quorumVoterStringsToNodes-java.util.List-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List<Org.Apache.Kafka.Common.Node> QuorumVoterStringsToNodes(Java.Util.List<Java.Lang.String> arg0)
        {
            return SExecuteWithSignature<Java.Util.List<Org.Apache.Kafka.Common.Node>>(LocalBridgeClazz, "quorumVoterStringsToNodes", "(Ljava/util/List;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/RaftConfig.html#voterConnectionsToNodes-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List<Org.Apache.Kafka.Common.Node> VoterConnectionsToNodes(Java.Util.Map<Java.Lang.Integer, Org.Apache.Kafka.Raft.RaftConfig.AddressSpec> arg0)
        {
            return SExecuteWithSignature<Java.Util.List<Org.Apache.Kafka.Common.Node>>(LocalBridgeClazz, "voterConnectionsToNodes", "(Ljava/util/Map;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/RaftConfig.html#parseVoterConnections-java.util.List-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public static Java.Util.Map<Java.Lang.Integer, Org.Apache.Kafka.Raft.RaftConfig.AddressSpec> ParseVoterConnections(Java.Util.List<Java.Lang.String> arg0)
        {
            return SExecuteWithSignature<Java.Util.Map<Java.Lang.Integer, Org.Apache.Kafka.Raft.RaftConfig.AddressSpec>>(LocalBridgeClazz, "parseVoterConnections", "(Ljava/util/List;)Ljava/util/Map;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/RaftConfig.html#appendLingerMs--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int AppendLingerMs()
        {
            return IExecuteWithSignature<int>("appendLingerMs", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/RaftConfig.html#electionBackoffMaxMs--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int ElectionBackoffMaxMs()
        {
            return IExecuteWithSignature<int>("electionBackoffMaxMs", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/RaftConfig.html#electionTimeoutMs--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int ElectionTimeoutMs()
        {
            return IExecuteWithSignature<int>("electionTimeoutMs", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/RaftConfig.html#fetchTimeoutMs--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int FetchTimeoutMs()
        {
            return IExecuteWithSignature<int>("fetchTimeoutMs", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/RaftConfig.html#requestTimeoutMs--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int RequestTimeoutMs()
        {
            return IExecuteWithSignature<int>("requestTimeoutMs", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/RaftConfig.html#retryBackoffMs--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int RetryBackoffMs()
        {
            return IExecuteWithSignature<int>("retryBackoffMs", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/RaftConfig.html#quorumVoterConnections--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.Integer, Org.Apache.Kafka.Raft.RaftConfig.AddressSpec> QuorumVoterConnections()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.Integer, Org.Apache.Kafka.Raft.RaftConfig.AddressSpec>>("quorumVoterConnections", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/RaftConfig.html#quorumVoterIds--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.Integer> QuorumVoterIds()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.Integer>>("quorumVoterIds", "()Ljava/util/Set;");
        }

        #endregion

        #region Nested classes
        #region AddressSpec
        public partial class AddressSpec
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

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ControllerQuorumVotersValidator
        public partial class ControllerQuorumVotersValidator
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/RaftConfig.ControllerQuorumVotersValidator.html#ensureValid-java.lang.String-java.lang.Object-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="object"/></param>
            public void EnsureValid(Java.Lang.String arg0, object arg1)
            {
                IExecute("ensureValid", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region InetAddressSpec
        public partial class InetAddressSpec
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/RaftConfig.InetAddressSpec.html#org.apache.kafka.raft.RaftConfig$InetAddressSpec(java.net.InetSocketAddress)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Net.InetSocketAddress"/></param>
            public InetAddressSpec(Java.Net.InetSocketAddress arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/RaftConfig.InetAddressSpec.html#address"/>
            /// </summary>
            public Java.Net.InetSocketAddress address { get { if (!_addressReady) { _addressContent = IGetField<Java.Net.InetSocketAddress>("address"); _addressReady = true; } return _addressContent; } }
            private Java.Net.InetSocketAddress _addressContent = default;
            private bool _addressReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region UnknownAddressSpec
        public partial class UnknownAddressSpec
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