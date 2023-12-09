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
*  This file is generated by MASES.JNetReflector (ver. 2.1.0.0)
*  using kafka-clients-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Admin
{
    #region ScramCredentialInfo
    public partial class ScramCredentialInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/admin/ScramCredentialInfo.html#org.apache.kafka.clients.admin.ScramCredentialInfo(org.apache.kafka.clients.admin.ScramMechanism,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Admin.ScramMechanism"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public ScramCredentialInfo(Org.Apache.Kafka.Clients.Admin.ScramMechanism arg0, int arg1)
            : base(arg0, arg1)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/admin/ScramCredentialInfo.html#iterations--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Iterations()
        {
            return IExecute<int>("iterations");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/admin/ScramCredentialInfo.html#mechanism--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.ScramMechanism"/></returns>
        public Org.Apache.Kafka.Clients.Admin.ScramMechanism Mechanism()
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.ScramMechanism>("mechanism");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}