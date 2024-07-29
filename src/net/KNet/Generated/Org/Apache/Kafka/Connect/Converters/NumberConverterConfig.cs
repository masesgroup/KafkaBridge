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
*  using connect-runtime-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Converters
{
    #region NumberConverterConfig
    public partial class NumberConverterConfig
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.8.0/org/apache/kafka/connect/converters/NumberConverterConfig.html#org.apache.kafka.connect.converters.NumberConverterConfig(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public NumberConverterConfig(Java.Util.Map<Java.Lang.String, object> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.8.0/org/apache/kafka/connect/converters/NumberConverterConfig.html#configDef--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Config.ConfigDef"/></returns>
        public static Org.Apache.Kafka.Common.Config.ConfigDef ConfigDef()
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.Config.ConfigDef>(LocalBridgeClazz, "configDef", "()Lorg/apache/kafka/common/config/ConfigDef;");
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