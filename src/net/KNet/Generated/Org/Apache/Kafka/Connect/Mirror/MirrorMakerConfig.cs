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
*  using connect-mirror-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Mirror
{
    #region MirrorMakerConfig
    public partial class MirrorMakerConfig
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorMakerConfig.html#org.apache.kafka.connect.mirror.MirrorMakerConfig(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public MirrorMakerConfig(Java.Util.Map<Java.Lang.String, Java.Lang.String> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorMakerConfig.html#CLUSTERS_CONFIG"/>
        /// </summary>
        public static Java.Lang.String CLUSTERS_CONFIG { get { if (!_CLUSTERS_CONFIGReady) { _CLUSTERS_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CLUSTERS_CONFIG"); _CLUSTERS_CONFIGReady = true; } return _CLUSTERS_CONFIGContent; } }
        private static Java.Lang.String _CLUSTERS_CONFIGContent = default;
        private static bool _CLUSTERS_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorMakerConfig.html#CONFIG_PROVIDERS_CONFIG"/>
        /// </summary>
        public static Java.Lang.String CONFIG_PROVIDERS_CONFIG { get { if (!_CONFIG_PROVIDERS_CONFIGReady) { _CONFIG_PROVIDERS_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CONFIG_PROVIDERS_CONFIG"); _CONFIG_PROVIDERS_CONFIGReady = true; } return _CONFIG_PROVIDERS_CONFIGContent; } }
        private static Java.Lang.String _CONFIG_PROVIDERS_CONFIGContent = default;
        private static bool _CONFIG_PROVIDERS_CONFIGReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorMakerConfig.html#enableInternalRest--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool EnableInternalRest()
        {
            return IExecuteWithSignature<bool>("enableInternalRest", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorMakerConfig.html#clusterPairs--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Org.Apache.Kafka.Connect.Mirror.SourceAndTarget> ClusterPairs()
        {
            return IExecuteWithSignature<Java.Util.List<Org.Apache.Kafka.Connect.Mirror.SourceAndTarget>>("clusterPairs", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorMakerConfig.html#connectorBaseConfig-org.apache.kafka.connect.mirror.SourceAndTarget-java.lang.Class-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Mirror.SourceAndTarget"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, Java.Lang.String> ConnectorBaseConfig(Org.Apache.Kafka.Connect.Mirror.SourceAndTarget arg0, Java.Lang.Class arg1)
        {
            return IExecute<Java.Util.Map<Java.Lang.String, Java.Lang.String>>("connectorBaseConfig", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorMakerConfig.html#workerConfig-org.apache.kafka.connect.mirror.SourceAndTarget-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Mirror.SourceAndTarget"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, Java.Lang.String> WorkerConfig(Org.Apache.Kafka.Connect.Mirror.SourceAndTarget arg0)
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Lang.String>>("workerConfig", "(Lorg/apache/kafka/connect/mirror/SourceAndTarget;)Ljava/util/Map;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorMakerConfig.html#clusters--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> Clusters()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("clusters", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.1/org/apache/kafka/connect/mirror/MirrorMakerConfig.html#clientConfig-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Mirror.MirrorClientConfig"/></returns>
        public Org.Apache.Kafka.Connect.Mirror.MirrorClientConfig ClientConfig(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Mirror.MirrorClientConfig>("clientConfig", "(Ljava/lang/String;)Lorg/apache/kafka/connect/mirror/MirrorClientConfig;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}