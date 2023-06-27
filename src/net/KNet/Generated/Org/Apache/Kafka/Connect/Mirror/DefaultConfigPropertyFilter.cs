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
*  This file is generated by MASES.JNetReflector (ver. 2.0.0.0)
*  using connect-mirror-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Mirror
{
    #region DefaultConfigPropertyFilter
    public partial class DefaultConfigPropertyFilter
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.4.0/org/apache/kafka/connect/mirror/DefaultConfigPropertyFilter.html#CONFIG_PROPERTIES_EXCLUDE_ALIAS_CONFIG"/>
        /// </summary>
        public static string CONFIG_PROPERTIES_EXCLUDE_ALIAS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "CONFIG_PROPERTIES_EXCLUDE_ALIAS_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.4.0/org/apache/kafka/connect/mirror/DefaultConfigPropertyFilter.html#CONFIG_PROPERTIES_EXCLUDE_CONFIG"/>
        /// </summary>
        public static string CONFIG_PROPERTIES_EXCLUDE_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "CONFIG_PROPERTIES_EXCLUDE_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.4.0/org/apache/kafka/connect/mirror/DefaultConfigPropertyFilter.html#CONFIG_PROPERTIES_EXCLUDE_DEFAULT"/>
        /// </summary>
        public static string CONFIG_PROPERTIES_EXCLUDE_DEFAULT { get { return SGetField<string>(LocalBridgeClazz, "CONFIG_PROPERTIES_EXCLUDE_DEFAULT"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.4.0/org/apache/kafka/connect/mirror/DefaultConfigPropertyFilter.html#shouldReplicateConfigProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ShouldReplicateConfigProperty(string arg0)
        {
            return IExecute<bool>("shouldReplicateConfigProperty", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.4.0/org/apache/kafka/connect/mirror/DefaultConfigPropertyFilter.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.4.0/org/apache/kafka/connect/mirror/DefaultConfigPropertyFilter.html#configure(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public void Configure(Java.Util.Map<string, object> arg0)
        {
            IExecute("configure", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}