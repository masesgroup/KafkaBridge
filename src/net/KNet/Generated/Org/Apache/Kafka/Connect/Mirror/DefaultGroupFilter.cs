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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using connect-mirror-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Mirror
{
    #region DefaultGroupFilter
    public partial class DefaultGroupFilter
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Mirror.DefaultGroupFilter"/> to <see cref="Org.Apache.Kafka.Connect.Mirror.GroupFilter"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Connect.Mirror.GroupFilter(Org.Apache.Kafka.Connect.Mirror.DefaultGroupFilter t) => t.Cast<Org.Apache.Kafka.Connect.Mirror.GroupFilter>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-mirror/3.4.0/org/apache/kafka/connect/mirror/DefaultGroupFilter.html#GROUPS_EXCLUDE_CONFIG"/>
        /// </summary>
        public static string GROUPS_EXCLUDE_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "GROUPS_EXCLUDE_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-mirror/3.4.0/org/apache/kafka/connect/mirror/DefaultGroupFilter.html#GROUPS_EXCLUDE_CONFIG_ALIAS"/>
        /// </summary>
        public static string GROUPS_EXCLUDE_CONFIG_ALIAS { get { return SGetField<string>(LocalBridgeClazz, "GROUPS_EXCLUDE_CONFIG_ALIAS"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-mirror/3.4.0/org/apache/kafka/connect/mirror/DefaultGroupFilter.html#GROUPS_EXCLUDE_DEFAULT"/>
        /// </summary>
        public static string GROUPS_EXCLUDE_DEFAULT { get { return SGetField<string>(LocalBridgeClazz, "GROUPS_EXCLUDE_DEFAULT"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-mirror/3.4.0/org/apache/kafka/connect/mirror/DefaultGroupFilter.html#GROUPS_INCLUDE_CONFIG"/>
        /// </summary>
        public static string GROUPS_INCLUDE_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "GROUPS_INCLUDE_CONFIG"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-mirror/3.4.0/org/apache/kafka/connect/mirror/DefaultGroupFilter.html#GROUPS_INCLUDE_DEFAULT"/>
        /// </summary>
        public static string GROUPS_INCLUDE_DEFAULT { get { return SGetField<string>(LocalBridgeClazz, "GROUPS_INCLUDE_DEFAULT"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-mirror/3.4.0/org/apache/kafka/connect/mirror/DefaultGroupFilter.html#shouldReplicateGroup(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ShouldReplicateGroup(string arg0)
        {
            return IExecute<bool>("shouldReplicateGroup", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-mirror/3.4.0/org/apache/kafka/connect/mirror/DefaultGroupFilter.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-mirror/3.4.0/org/apache/kafka/connect/mirror/DefaultGroupFilter.html#configure(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <typeparam name="Arg0Extendsobject"></typeparam>
        public void Configure<Arg0Extendsobject>(Java.Util.Map<string, Arg0Extendsobject> arg0)
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