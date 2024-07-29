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

namespace Org.Apache.Kafka.Common.Config
{
    #region ConfigTransformer
    public partial class ConfigTransformer
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/config/ConfigTransformer.html#org.apache.kafka.common.config.ConfigTransformer(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public ConfigTransformer(Java.Util.Map<Java.Lang.String, Org.Apache.Kafka.Common.Config.Provider.ConfigProvider> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/config/ConfigTransformer.html#DEFAULT_PATTERN"/>
        /// </summary>
        public static Java.Util.Regex.Pattern DEFAULT_PATTERN { get { if (!_DEFAULT_PATTERNReady) { _DEFAULT_PATTERNContent = SGetField<Java.Util.Regex.Pattern>(LocalBridgeClazz, "DEFAULT_PATTERN"); _DEFAULT_PATTERNReady = true; } return _DEFAULT_PATTERNContent; } }
        private static Java.Util.Regex.Pattern _DEFAULT_PATTERNContent = default;
        private static bool _DEFAULT_PATTERNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/config/ConfigTransformer.html#transform-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Config.ConfigTransformerResult"/></returns>
        public Org.Apache.Kafka.Common.Config.ConfigTransformerResult Transform(Java.Util.Map<Java.Lang.String, Java.Lang.String> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Config.ConfigTransformerResult>("transform", "(Ljava/util/Map;)Lorg/apache/kafka/common/config/ConfigTransformerResult;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}