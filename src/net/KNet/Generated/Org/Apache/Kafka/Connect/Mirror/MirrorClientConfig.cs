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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using connect-mirror-client-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Mirror
{
    #region MirrorClientConfig
    public partial class MirrorClientConfig
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.1/org/apache/kafka/connect/mirror/MirrorClientConfig.html#INTERNAL_TOPIC_SEPARATOR_ENABLED_DEFAULT"/>
        /// </summary>
        public static Java.Lang.Boolean INTERNAL_TOPIC_SEPARATOR_ENABLED_DEFAULT { get { if (!_INTERNAL_TOPIC_SEPARATOR_ENABLED_DEFAULTReady) { _INTERNAL_TOPIC_SEPARATOR_ENABLED_DEFAULTContent = SGetField<Java.Lang.Boolean>(LocalBridgeClazz, "INTERNAL_TOPIC_SEPARATOR_ENABLED_DEFAULT"); _INTERNAL_TOPIC_SEPARATOR_ENABLED_DEFAULTReady = true; } return _INTERNAL_TOPIC_SEPARATOR_ENABLED_DEFAULTContent; } }
        private static Java.Lang.Boolean _INTERNAL_TOPIC_SEPARATOR_ENABLED_DEFAULTContent = default;
        private static bool _INTERNAL_TOPIC_SEPARATOR_ENABLED_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.1/org/apache/kafka/connect/mirror/MirrorClientConfig.html#FORWARDING_ADMIN_CLASS_DEFAULT"/>
        /// </summary>
        public static Java.Lang.Class FORWARDING_ADMIN_CLASS_DEFAULT { get { if (!_FORWARDING_ADMIN_CLASS_DEFAULTReady) { _FORWARDING_ADMIN_CLASS_DEFAULTContent = SGetField<Java.Lang.Class>(LocalBridgeClazz, "FORWARDING_ADMIN_CLASS_DEFAULT"); _FORWARDING_ADMIN_CLASS_DEFAULTReady = true; } return _FORWARDING_ADMIN_CLASS_DEFAULTContent; } }
        private static Java.Lang.Class _FORWARDING_ADMIN_CLASS_DEFAULTContent = default;
        private static bool _FORWARDING_ADMIN_CLASS_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.1/org/apache/kafka/connect/mirror/MirrorClientConfig.html#REPLICATION_POLICY_CLASS_DEFAULT"/>
        /// </summary>
        public static Java.Lang.Class REPLICATION_POLICY_CLASS_DEFAULT { get { if (!_REPLICATION_POLICY_CLASS_DEFAULTReady) { _REPLICATION_POLICY_CLASS_DEFAULTContent = SGetField<Java.Lang.Class>(LocalBridgeClazz, "REPLICATION_POLICY_CLASS_DEFAULT"); _REPLICATION_POLICY_CLASS_DEFAULTReady = true; } return _REPLICATION_POLICY_CLASS_DEFAULTContent; } }
        private static Java.Lang.Class _REPLICATION_POLICY_CLASS_DEFAULTContent = default;
        private static bool _REPLICATION_POLICY_CLASS_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.1/org/apache/kafka/connect/mirror/MirrorClientConfig.html#ADMIN_CLIENT_PREFIX"/>
        /// </summary>
        public static Java.Lang.String ADMIN_CLIENT_PREFIX { get { if (!_ADMIN_CLIENT_PREFIXReady) { _ADMIN_CLIENT_PREFIXContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ADMIN_CLIENT_PREFIX"); _ADMIN_CLIENT_PREFIXReady = true; } return _ADMIN_CLIENT_PREFIXContent; } }
        private static Java.Lang.String _ADMIN_CLIENT_PREFIXContent = default;
        private static bool _ADMIN_CLIENT_PREFIXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.1/org/apache/kafka/connect/mirror/MirrorClientConfig.html#CONSUMER_CLIENT_PREFIX"/>
        /// </summary>
        public static Java.Lang.String CONSUMER_CLIENT_PREFIX { get { if (!_CONSUMER_CLIENT_PREFIXReady) { _CONSUMER_CLIENT_PREFIXContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CONSUMER_CLIENT_PREFIX"); _CONSUMER_CLIENT_PREFIXReady = true; } return _CONSUMER_CLIENT_PREFIXContent; } }
        private static Java.Lang.String _CONSUMER_CLIENT_PREFIXContent = default;
        private static bool _CONSUMER_CLIENT_PREFIXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.1/org/apache/kafka/connect/mirror/MirrorClientConfig.html#FORWARDING_ADMIN_CLASS"/>
        /// </summary>
        public static Java.Lang.String FORWARDING_ADMIN_CLASS { get { if (!_FORWARDING_ADMIN_CLASSReady) { _FORWARDING_ADMIN_CLASSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FORWARDING_ADMIN_CLASS"); _FORWARDING_ADMIN_CLASSReady = true; } return _FORWARDING_ADMIN_CLASSContent; } }
        private static Java.Lang.String _FORWARDING_ADMIN_CLASSContent = default;
        private static bool _FORWARDING_ADMIN_CLASSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.1/org/apache/kafka/connect/mirror/MirrorClientConfig.html#FORWARDING_ADMIN_CLASS_DOC"/>
        /// </summary>
        public static Java.Lang.String FORWARDING_ADMIN_CLASS_DOC { get { if (!_FORWARDING_ADMIN_CLASS_DOCReady) { _FORWARDING_ADMIN_CLASS_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FORWARDING_ADMIN_CLASS_DOC"); _FORWARDING_ADMIN_CLASS_DOCReady = true; } return _FORWARDING_ADMIN_CLASS_DOCContent; } }
        private static Java.Lang.String _FORWARDING_ADMIN_CLASS_DOCContent = default;
        private static bool _FORWARDING_ADMIN_CLASS_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.1/org/apache/kafka/connect/mirror/MirrorClientConfig.html#INTERNAL_TOPIC_SEPARATOR_ENABLED"/>
        /// </summary>
        public static Java.Lang.String INTERNAL_TOPIC_SEPARATOR_ENABLED { get { if (!_INTERNAL_TOPIC_SEPARATOR_ENABLEDReady) { _INTERNAL_TOPIC_SEPARATOR_ENABLEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "INTERNAL_TOPIC_SEPARATOR_ENABLED"); _INTERNAL_TOPIC_SEPARATOR_ENABLEDReady = true; } return _INTERNAL_TOPIC_SEPARATOR_ENABLEDContent; } }
        private static Java.Lang.String _INTERNAL_TOPIC_SEPARATOR_ENABLEDContent = default;
        private static bool _INTERNAL_TOPIC_SEPARATOR_ENABLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.1/org/apache/kafka/connect/mirror/MirrorClientConfig.html#INTERNAL_TOPIC_SEPARATOR_ENABLED_DOC"/>
        /// </summary>
        public static Java.Lang.String INTERNAL_TOPIC_SEPARATOR_ENABLED_DOC { get { if (!_INTERNAL_TOPIC_SEPARATOR_ENABLED_DOCReady) { _INTERNAL_TOPIC_SEPARATOR_ENABLED_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "INTERNAL_TOPIC_SEPARATOR_ENABLED_DOC"); _INTERNAL_TOPIC_SEPARATOR_ENABLED_DOCReady = true; } return _INTERNAL_TOPIC_SEPARATOR_ENABLED_DOCContent; } }
        private static Java.Lang.String _INTERNAL_TOPIC_SEPARATOR_ENABLED_DOCContent = default;
        private static bool _INTERNAL_TOPIC_SEPARATOR_ENABLED_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.1/org/apache/kafka/connect/mirror/MirrorClientConfig.html#PRODUCER_CLIENT_PREFIX"/>
        /// </summary>
        public static Java.Lang.String PRODUCER_CLIENT_PREFIX { get { if (!_PRODUCER_CLIENT_PREFIXReady) { _PRODUCER_CLIENT_PREFIXContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "PRODUCER_CLIENT_PREFIX"); _PRODUCER_CLIENT_PREFIXReady = true; } return _PRODUCER_CLIENT_PREFIXContent; } }
        private static Java.Lang.String _PRODUCER_CLIENT_PREFIXContent = default;
        private static bool _PRODUCER_CLIENT_PREFIXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.1/org/apache/kafka/connect/mirror/MirrorClientConfig.html#REPLICATION_POLICY_CLASS"/>
        /// </summary>
        public static Java.Lang.String REPLICATION_POLICY_CLASS { get { if (!_REPLICATION_POLICY_CLASSReady) { _REPLICATION_POLICY_CLASSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "REPLICATION_POLICY_CLASS"); _REPLICATION_POLICY_CLASSReady = true; } return _REPLICATION_POLICY_CLASSContent; } }
        private static Java.Lang.String _REPLICATION_POLICY_CLASSContent = default;
        private static bool _REPLICATION_POLICY_CLASSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.1/org/apache/kafka/connect/mirror/MirrorClientConfig.html#REPLICATION_POLICY_SEPARATOR"/>
        /// </summary>
        public static Java.Lang.String REPLICATION_POLICY_SEPARATOR { get { if (!_REPLICATION_POLICY_SEPARATORReady) { _REPLICATION_POLICY_SEPARATORContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "REPLICATION_POLICY_SEPARATOR"); _REPLICATION_POLICY_SEPARATORReady = true; } return _REPLICATION_POLICY_SEPARATORContent; } }
        private static Java.Lang.String _REPLICATION_POLICY_SEPARATORContent = default;
        private static bool _REPLICATION_POLICY_SEPARATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.1/org/apache/kafka/connect/mirror/MirrorClientConfig.html#REPLICATION_POLICY_SEPARATOR_DEFAULT"/>
        /// </summary>
        public static Java.Lang.String REPLICATION_POLICY_SEPARATOR_DEFAULT { get { if (!_REPLICATION_POLICY_SEPARATOR_DEFAULTReady) { _REPLICATION_POLICY_SEPARATOR_DEFAULTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "REPLICATION_POLICY_SEPARATOR_DEFAULT"); _REPLICATION_POLICY_SEPARATOR_DEFAULTReady = true; } return _REPLICATION_POLICY_SEPARATOR_DEFAULTContent; } }
        private static Java.Lang.String _REPLICATION_POLICY_SEPARATOR_DEFAULTContent = default;
        private static bool _REPLICATION_POLICY_SEPARATOR_DEFAULTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.1/org/apache/kafka/connect/mirror/MirrorClientConfig.html#adminConfig--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, object> AdminConfig()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, object>>("adminConfig", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.1/org/apache/kafka/connect/mirror/MirrorClientConfig.html#consumerConfig--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, object> ConsumerConfig()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, object>>("consumerConfig", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.1/org/apache/kafka/connect/mirror/MirrorClientConfig.html#producerConfig--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, object> ProducerConfig()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, object>>("producerConfig", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.7.1/org/apache/kafka/connect/mirror/MirrorClientConfig.html#replicationPolicy--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Mirror.ReplicationPolicy"/></returns>
        public Org.Apache.Kafka.Connect.Mirror.ReplicationPolicy ReplicationPolicy()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Mirror.ReplicationPolicy>("replicationPolicy", "()Lorg/apache/kafka/connect/mirror/ReplicationPolicy;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}