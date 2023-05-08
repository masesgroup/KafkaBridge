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
*  using kafka-clients-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Security.Oauthbearer.Internals.Secured
{
    #region JaasOptionsUtils
    public partial class JaasOptionsUtils
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/oauthbearer/internals/secured/JaasOptionsUtils.html#%3Cinit%3E(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public JaasOptionsUtils(Java.Util.Map arg0)
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
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/oauthbearer/internals/secured/JaasOptionsUtils.html#getOptions(java.lang.String,java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public static Java.Util.Map<string, object> GetOptions(string arg0, Java.Util.List<Javax.Security.Auth.Login.AppConfigurationEntry> arg1)
        {
            return SExecute<Java.Util.Map<string, object>>(LocalBridgeClazz, "getOptions", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/oauthbearer/internals/secured/JaasOptionsUtils.html#createSSLSocketFactory()"/> 
        /// </summary>
        public Javax.Net.Ssl.SSLSocketFactory CreateSSLSocketFactory
        {
            get { return IExecute<Javax.Net.Ssl.SSLSocketFactory>("createSSLSocketFactory"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/oauthbearer/internals/secured/JaasOptionsUtils.html#getSslClientConfig()"/> 
        /// </summary>
        public Java.Util.Map SslClientConfig
        {
            get { return IExecute<Java.Util.Map>("getSslClientConfig"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/oauthbearer/internals/secured/JaasOptionsUtils.html#shouldCreateSSLSocketFactory(java.net.URL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ShouldCreateSSLSocketFactory(Java.Net.URL arg0)
        {
            return IExecute<bool>("shouldCreateSSLSocketFactory", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/oauthbearer/internals/secured/JaasOptionsUtils.html#validateString(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="string"/></returns>
        /// <exception cref="Org.Apache.Kafka.Common.Security.Oauthbearer.Internals.Secured.ValidateException"/>
        public string ValidateString(string arg0, bool arg1)
        {
            return IExecute<string>("validateString", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/security/oauthbearer/internals/secured/JaasOptionsUtils.html#validateString(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        /// <exception cref="Org.Apache.Kafka.Common.Security.Oauthbearer.Internals.Secured.ValidateException"/>
        public string ValidateString(string arg0)
        {
            return IExecute<string>("validateString", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}