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
*  using kafka-clients-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Utils
{
    #region ConfigUtils
    public partial class ConfigUtils
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/utils/ConfigUtils.html#translateDeprecatedConfigs-java.util.Map-java.lang.String[][]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public static Java.Util.Map<Java.Lang.String, T> TranslateDeprecatedConfigs<T>(Java.Util.Map<Java.Lang.String, T> arg0, Java.Lang.String[][] arg1)
        {
            return SExecute<Java.Util.Map<Java.Lang.String, T>>(LocalBridgeClazz, "translateDeprecatedConfigs", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/utils/ConfigUtils.html#translateDeprecatedConfigs-java.util.Map-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public static Java.Util.Map<Java.Lang.String, T> TranslateDeprecatedConfigs<T>(Java.Util.Map<Java.Lang.String, T> arg0, Java.Util.Map<Java.Lang.String, Java.Util.List<Java.Lang.String>> arg1)
        {
            return SExecute<Java.Util.Map<Java.Lang.String, T>>(LocalBridgeClazz, "translateDeprecatedConfigs", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/utils/ConfigUtils.html#getBoolean-java.util.Map-java.lang.String-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool GetBoolean(Java.Util.Map<Java.Lang.String, object> arg0, Java.Lang.String arg1, bool arg2)
        {
            return SExecute<bool>(LocalBridgeClazz, "getBoolean", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/utils/ConfigUtils.html#configMapToRedactedString-java.util.Map-org.apache.kafka.common.config.ConfigDef-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Config.ConfigDef"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ConfigMapToRedactedString(Java.Util.Map<Java.Lang.String, object> arg0, Org.Apache.Kafka.Common.Config.ConfigDef arg1)
        {
            return SExecute<Java.Lang.String>(LocalBridgeClazz, "configMapToRedactedString", arg0, arg1);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}