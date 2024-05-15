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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using kafka-clients-3.6.2.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Security.Ssl
{
    #region DefaultSslEngineFactory
    public partial class DefaultSslEngineFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/ssl/DefaultSslEngineFactory.html#PEM_TYPE"/>
        /// </summary>
        public static Java.Lang.String PEM_TYPE { get { if (!_PEM_TYPEReady) { _PEM_TYPEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "PEM_TYPE"); _PEM_TYPEReady = true; } return _PEM_TYPEContent; } }
        private static Java.Lang.String _PEM_TYPEContent = default;
        private static bool _PEM_TYPEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/ssl/DefaultSslEngineFactory.html#shouldBeRebuilt-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ShouldBeRebuilt(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            return IExecuteWithSignature<bool>("shouldBeRebuilt", "(Ljava/util/Map;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/ssl/DefaultSslEngineFactory.html#keystore--"/>
        /// </summary>

        /// <returns><see cref="Java.Security.KeyStore"/></returns>
        public Java.Security.KeyStore Keystore()
        {
            return IExecuteWithSignature<Java.Security.KeyStore>("keystore", "()Ljava/security/KeyStore;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/ssl/DefaultSslEngineFactory.html#truststore--"/>
        /// </summary>

        /// <returns><see cref="Java.Security.KeyStore"/></returns>
        public Java.Security.KeyStore Truststore()
        {
            return IExecuteWithSignature<Java.Security.KeyStore>("truststore", "()Ljava/security/KeyStore;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/ssl/DefaultSslEngineFactory.html#reconfigurableConfigs--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> ReconfigurableConfigs()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("reconfigurableConfigs", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/ssl/DefaultSslEngineFactory.html#sslContext--"/>
        /// </summary>

        /// <returns><see cref="Javax.Net.Ssl.SSLContext"/></returns>
        public Javax.Net.Ssl.SSLContext SslContext()
        {
            return IExecuteWithSignature<Javax.Net.Ssl.SSLContext>("sslContext", "()Ljavax/net/ssl/SSLContext;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/ssl/DefaultSslEngineFactory.html#createClientSslEngine-java.lang.String-int-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Net.Ssl.SSLEngine"/></returns>
        public Javax.Net.Ssl.SSLEngine CreateClientSslEngine(Java.Lang.String arg0, int arg1, Java.Lang.String arg2)
        {
            return IExecute<Javax.Net.Ssl.SSLEngine>("createClientSslEngine", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/ssl/DefaultSslEngineFactory.html#createServerSslEngine-java.lang.String-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Javax.Net.Ssl.SSLEngine"/></returns>
        public Javax.Net.Ssl.SSLEngine CreateServerSslEngine(Java.Lang.String arg0, int arg1)
        {
            return IExecute<Javax.Net.Ssl.SSLEngine>("createServerSslEngine", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/ssl/DefaultSslEngineFactory.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/ssl/DefaultSslEngineFactory.html#configure-java.util.Map-"/>
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