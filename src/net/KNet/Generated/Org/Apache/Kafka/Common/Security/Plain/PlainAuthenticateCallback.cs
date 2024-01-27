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
*  This file is generated by MASES.JNetReflector (ver. 2.2.4.0)
*  using kafka-clients-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Security.Plain
{
    #region PlainAuthenticateCallback
    public partial class PlainAuthenticateCallback
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/security/plain/PlainAuthenticateCallback.html#org.apache.kafka.common.security.plain.PlainAuthenticateCallback(char[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        public PlainAuthenticateCallback(char[] arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/security/plain/PlainAuthenticateCallback.html#authenticated--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool Authenticated()
        {
            return IExecute<bool>("authenticated");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/security/plain/PlainAuthenticateCallback.html#password--"/>
        /// </summary>

        /// <returns><see cref="char"/></returns>
        public char[] Password()
        {
            return IExecuteArray<char>("password");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/security/plain/PlainAuthenticateCallback.html#authenticated-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void Authenticated(bool arg0)
        {
            IExecute("authenticated", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}