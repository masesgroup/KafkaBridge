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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using kafka-clients-3.5.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Security
{
    #region JaasContext
    public partial class JaasContext
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/security/JaasContext.html#org.apache.kafka.common.security.JaasContext(java.lang.String,org.apache.kafka.common.security.JaasContext.Type,javax.security.auth.login.Configuration,org.apache.kafka.common.config.types.Password)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Security.JaasContext.Type"/></param>
        /// <param name="arg2"><see cref="Javax.Security.Auth.Login.Configuration"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Common.Config.Types.Password"/></param>
        public JaasContext(string arg0, Org.Apache.Kafka.Common.Security.JaasContext.Type arg1, Javax.Security.Auth.Login.Configuration arg2, Org.Apache.Kafka.Common.Config.Types.Password arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/security/JaasContext.html#configEntryOption-java.util.List-java.lang.String-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public static string ConfigEntryOption(Java.Util.List<Javax.Security.Auth.Login.AppConfigurationEntry> arg0, string arg1, string arg2)
        {
            return SExecute<string>(LocalBridgeClazz, "configEntryOption", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/security/JaasContext.html#loadClientContext-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Security.JaasContext"/></returns>
        public static Org.Apache.Kafka.Common.Security.JaasContext LoadClientContext(Java.Util.Map<string, object> arg0)
        {
            return SExecute<Org.Apache.Kafka.Common.Security.JaasContext>(LocalBridgeClazz, "loadClientContext", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/security/JaasContext.html#name--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string Name()
        {
            return IExecute<string>("name");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/security/JaasContext.html#configurationEntries--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Javax.Security.Auth.Login.AppConfigurationEntry> ConfigurationEntries()
        {
            return IExecute<Java.Util.List<Javax.Security.Auth.Login.AppConfigurationEntry>>("configurationEntries");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/security/JaasContext.html#configuration--"/>
        /// </summary>

        /// <returns><see cref="Javax.Security.Auth.Login.Configuration"/></returns>
        public Javax.Security.Auth.Login.Configuration Configuration()
        {
            return IExecute<Javax.Security.Auth.Login.Configuration>("configuration");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/security/JaasContext.html#dynamicJaasConfig--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Config.Types.Password"/></returns>
        public Org.Apache.Kafka.Common.Config.Types.Password DynamicJaasConfig()
        {
            return IExecute<Org.Apache.Kafka.Common.Config.Types.Password>("dynamicJaasConfig");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/security/JaasContext.html#type--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Security.JaasContext.Type"/></returns>
        public Org.Apache.Kafka.Common.Security.JaasContext.Type TypeMethod()
        {
            return IExecute<Org.Apache.Kafka.Common.Security.JaasContext.Type>("type");
        }

        #endregion

        #region Nested classes
        #region Type
        public partial class Type
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/security/JaasContext.Type.html#CLIENT"/>
            /// </summary>
            public static Org.Apache.Kafka.Common.Security.JaasContext.Type CLIENT { get { return SGetField<Org.Apache.Kafka.Common.Security.JaasContext.Type>(LocalBridgeClazz, "CLIENT"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/security/JaasContext.Type.html#SERVER"/>
            /// </summary>
            public static Org.Apache.Kafka.Common.Security.JaasContext.Type SERVER { get { return SGetField<Org.Apache.Kafka.Common.Security.JaasContext.Type>(LocalBridgeClazz, "SERVER"); } }

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/security/JaasContext.Type.html#valueOf-java.lang.String-"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Common.Security.JaasContext.Type"/></returns>
            public static Org.Apache.Kafka.Common.Security.JaasContext.Type ValueOf(string arg0)
            {
                return SExecute<Org.Apache.Kafka.Common.Security.JaasContext.Type>(LocalBridgeClazz, "valueOf", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/security/JaasContext.Type.html#values--"/>
            /// </summary>

            /// <returns><see cref="Org.Apache.Kafka.Common.Security.JaasContext.Type"/></returns>
            public static Org.Apache.Kafka.Common.Security.JaasContext.Type[] Values()
            {
                return SExecuteArray<Org.Apache.Kafka.Common.Security.JaasContext.Type>(LocalBridgeClazz, "values");
            }

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