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
*  using kafka-clients-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Config.Provider
{
    #region FileConfigProvider
    public partial class FileConfigProvider
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/config/provider/FileConfigProvider.html#ALLOWED_PATHS_CONFIG"/>
        /// </summary>
        public static Java.Lang.String ALLOWED_PATHS_CONFIG { get { if (!_ALLOWED_PATHS_CONFIGReady) { _ALLOWED_PATHS_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ALLOWED_PATHS_CONFIG"); _ALLOWED_PATHS_CONFIGReady = true; } return _ALLOWED_PATHS_CONFIGContent; } }
        private static Java.Lang.String _ALLOWED_PATHS_CONFIGContent = default;
        private static bool _ALLOWED_PATHS_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/config/provider/FileConfigProvider.html#ALLOWED_PATHS_DOC"/>
        /// </summary>
        public static Java.Lang.String ALLOWED_PATHS_DOC { get { if (!_ALLOWED_PATHS_DOCReady) { _ALLOWED_PATHS_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ALLOWED_PATHS_DOC"); _ALLOWED_PATHS_DOCReady = true; } return _ALLOWED_PATHS_DOCContent; } }
        private static Java.Lang.String _ALLOWED_PATHS_DOCContent = default;
        private static bool _ALLOWED_PATHS_DOCReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/config/provider/FileConfigProvider.html#get-java.lang.String-java.util.Set-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Config.ConfigData"/></returns>
        public Org.Apache.Kafka.Common.Config.ConfigData Get(Java.Lang.String arg0, Java.Util.Set<Java.Lang.String> arg1)
        {
            return IExecute<Org.Apache.Kafka.Common.Config.ConfigData>("get", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/config/provider/FileConfigProvider.html#get-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Config.ConfigData"/></returns>
        public Org.Apache.Kafka.Common.Config.ConfigData Get(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Config.ConfigData>("get", "(Ljava/lang/String;)Lorg/apache/kafka/common/config/ConfigData;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/config/provider/FileConfigProvider.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/config/provider/FileConfigProvider.html#configure-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public void Configure(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            IExecuteWithSignature("configure", "(Ljava/util/Map;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}