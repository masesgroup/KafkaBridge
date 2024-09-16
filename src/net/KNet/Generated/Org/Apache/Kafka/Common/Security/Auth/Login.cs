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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using kafka-clients-3.6.2.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Security.Auth
{
    #region ILogin
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ILogin
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Login
    public partial class Login : Org.Apache.Kafka.Common.Security.Auth.ILogin
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/auth/Login.html#serviceName--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ServiceName()
        {
            return IExecuteWithSignature<Java.Lang.String>("serviceName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/auth/Login.html#login--"/>
        /// </summary>
        /// <returns><see cref="Javax.Security.Auth.Login.LoginContext"/></returns>
        /// <exception cref="Javax.Security.Auth.Login.LoginException"/>
        public Javax.Security.Auth.Login.LoginContext LoginMethod()
        {
            return IExecuteWithSignature<Javax.Security.Auth.Login.LoginContext>("login", "()Ljavax/security/auth/login/LoginContext;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/auth/Login.html#subject--"/>
        /// </summary>
        /// <returns><see cref="Javax.Security.Auth.Subject"/></returns>
        public Javax.Security.Auth.Subject Subject()
        {
            return IExecuteWithSignature<Javax.Security.Auth.Subject>("subject", "()Ljavax/security/auth/Subject;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/auth/Login.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/auth/Login.html#configure-java.util.Map-java.lang.String-javax.security.auth.login.Configuration-org.apache.kafka.common.security.auth.AuthenticateCallbackHandler-"/>
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

        #endregion

        // TODO: complete the class
    }
    #endregion
}