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

namespace Org.Apache.Kafka.Common.Security.Scram
{
    #region ScramCredentialCallback
    public partial class ScramCredentialCallback
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/security/scram/ScramCredentialCallback.html#scramCredential--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Security.Scram.ScramCredential"/></returns>
        public Org.Apache.Kafka.Common.Security.Scram.ScramCredential ScramCredential()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Security.Scram.ScramCredential>("scramCredential", "()Lorg/apache/kafka/common/security/scram/ScramCredential;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/security/scram/ScramCredentialCallback.html#scramCredential-org.apache.kafka.common.security.scram.ScramCredential-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Security.Scram.ScramCredential"/></param>
        public void ScramCredential(Org.Apache.Kafka.Common.Security.Scram.ScramCredential arg0)
        {
            IExecuteWithSignature("scramCredential", "(Lorg/apache/kafka/common/security/scram/ScramCredential;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}