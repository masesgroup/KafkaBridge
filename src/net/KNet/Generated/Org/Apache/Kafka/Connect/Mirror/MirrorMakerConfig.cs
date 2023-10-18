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
*  This file is generated by MASES.JNetReflector (ver. 2.0.2.0)
*  using connect-mirror-3.6.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Mirror
{
    #region MirrorMakerConfig
    public partial class MirrorMakerConfig
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.0/org/apache/kafka/connect/mirror/MirrorMakerConfig.html#org.apache.kafka.connect.mirror.MirrorMakerConfig(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public MirrorMakerConfig(Java.Util.Map<string, string> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.0/org/apache/kafka/connect/mirror/MirrorMakerConfig.html#CLUSTERS_CONFIG"/>
        /// </summary>
        public static string CLUSTERS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "CLUSTERS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.0/org/apache/kafka/connect/mirror/MirrorMakerConfig.html#CONFIG_PROVIDERS_CONFIG"/>
        /// </summary>
        public static string CONFIG_PROVIDERS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "CONFIG_PROVIDERS_CONFIG"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.0/org/apache/kafka/connect/mirror/MirrorMakerConfig.html#enableInternalRest--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool EnableInternalRest()
        {
            return IExecute<bool>("enableInternalRest");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.0/org/apache/kafka/connect/mirror/MirrorMakerConfig.html#clusterPairs--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Org.Apache.Kafka.Connect.Mirror.SourceAndTarget> ClusterPairs()
        {
            return IExecute<Java.Util.List<Org.Apache.Kafka.Connect.Mirror.SourceAndTarget>>("clusterPairs");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.0/org/apache/kafka/connect/mirror/MirrorMakerConfig.html#connectorBaseConfig-org.apache.kafka.connect.mirror.SourceAndTarget-java.lang.Class-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Mirror.SourceAndTarget"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<string, string> ConnectorBaseConfig(Org.Apache.Kafka.Connect.Mirror.SourceAndTarget arg0, Java.Lang.Class arg1)
        {
            return IExecute<Java.Util.Map<string, string>>("connectorBaseConfig", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.0/org/apache/kafka/connect/mirror/MirrorMakerConfig.html#workerConfig-org.apache.kafka.connect.mirror.SourceAndTarget-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Mirror.SourceAndTarget"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<string, string> WorkerConfig(Org.Apache.Kafka.Connect.Mirror.SourceAndTarget arg0)
        {
            return IExecute<Java.Util.Map<string, string>>("workerConfig", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.0/org/apache/kafka/connect/mirror/MirrorMakerConfig.html#clusters--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<string> Clusters()
        {
            return IExecute<Java.Util.Set<string>>("clusters");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.0/org/apache/kafka/connect/mirror/MirrorMakerConfig.html#clientConfig-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Mirror.MirrorClientConfig"/></returns>
        public Org.Apache.Kafka.Connect.Mirror.MirrorClientConfig ClientConfig(string arg0)
        {
            return IExecute<Org.Apache.Kafka.Connect.Mirror.MirrorClientConfig>("clientConfig", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}