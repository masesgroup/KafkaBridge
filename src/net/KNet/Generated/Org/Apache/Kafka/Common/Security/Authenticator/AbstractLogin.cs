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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using kafka-clients-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Security.Authenticator
{
    #region AbstractLogin
    public partial class AbstractLogin
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/security/authenticator/AbstractLogin.html#login--"/>
        /// </summary>

        /// <returns><see cref="Javax.Security.Auth.Login.LoginContext"/></returns>
        /// <exception cref="Javax.Security.Auth.Login.LoginException"/>
        public Javax.Security.Auth.Login.LoginContext Login()
        {
            return IExecute<Javax.Security.Auth.Login.LoginContext>("login");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/security/authenticator/AbstractLogin.html#subject--"/>
        /// </summary>

        /// <returns><see cref="Javax.Security.Auth.Subject"/></returns>
        public Javax.Security.Auth.Subject Subject()
        {
            return IExecute<Javax.Security.Auth.Subject>("subject");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/security/authenticator/AbstractLogin.html#configure-java.util.Map-java.lang.String-javax.security.auth.login.Configuration-org.apache.kafka.common.security.auth.AuthenticateCallbackHandler-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Javax.Security.Auth.Login.Configuration"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Common.Security.Auth.AuthenticateCallbackHandler"/></param>
        public void Configure(Java.Util.Map<Java.Lang.String, object> arg0, Java.Lang.String arg1, Javax.Security.Auth.Login.Configuration arg2, Org.Apache.Kafka.Common.Security.Auth.AuthenticateCallbackHandler arg3)
        {
            IExecute("configure", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Nested classes
        #region DefaultLoginCallbackHandler
        public partial class DefaultLoginCallbackHandler
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/security/authenticator/AbstractLogin.DefaultLoginCallbackHandler.html#close--"/>
            /// </summary>
            public void Close()
            {
                IExecute("close");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/security/authenticator/AbstractLogin.DefaultLoginCallbackHandler.html#configure-java.util.Map-java.lang.String-java.util.List-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Map"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <param name="arg2"><see cref="Java.Util.List"/></param>
            public void Configure(Java.Util.Map<Java.Lang.String, object> arg0, Java.Lang.String arg1, Java.Util.List<Javax.Security.Auth.Login.AppConfigurationEntry> arg2)
            {
                IExecute("configure", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/security/authenticator/AbstractLogin.DefaultLoginCallbackHandler.html#handle-javax.security.auth.callback.Callback[]-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Security.Auth.Callback.Callback"/></param>
            /// <exception cref="Javax.Security.Auth.Callback.UnsupportedCallbackException"/>
            public void Handle(Javax.Security.Auth.Callback.Callback[] arg0)
            {
                IExecute("handle", new object[] { arg0 });
            }

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