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
*  This file is generated by MASES.JNetReflector (ver. 2.5.3.0)
*  using kafka-clients-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Admin
{
    #region UserScramCredentialUpsertion
    public partial class UserScramCredentialUpsertion
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/admin/UserScramCredentialUpsertion.html#org.apache.kafka.clients.admin.UserScramCredentialUpsertion(java.lang.String,org.apache.kafka.clients.admin.ScramCredentialInfo,byte[],byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Clients.Admin.ScramCredentialInfo"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        /// <param name="arg3"><see cref="byte"/></param>
        public UserScramCredentialUpsertion(Java.Lang.String arg0, Org.Apache.Kafka.Clients.Admin.ScramCredentialInfo arg1, byte[] arg2, byte[] arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/admin/UserScramCredentialUpsertion.html#org.apache.kafka.clients.admin.UserScramCredentialUpsertion(java.lang.String,org.apache.kafka.clients.admin.ScramCredentialInfo,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Clients.Admin.ScramCredentialInfo"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        public UserScramCredentialUpsertion(Java.Lang.String arg0, Org.Apache.Kafka.Clients.Admin.ScramCredentialInfo arg1, byte[] arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/admin/UserScramCredentialUpsertion.html#org.apache.kafka.clients.admin.UserScramCredentialUpsertion(java.lang.String,org.apache.kafka.clients.admin.ScramCredentialInfo,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Clients.Admin.ScramCredentialInfo"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        public UserScramCredentialUpsertion(Java.Lang.String arg0, Org.Apache.Kafka.Clients.Admin.ScramCredentialInfo arg1, Java.Lang.String arg2)
            : base(arg0, arg1, arg2)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/admin/UserScramCredentialUpsertion.html#password--"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] Password()
        {
            return IExecuteWithSignatureArray<byte>("password", "()[B");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/admin/UserScramCredentialUpsertion.html#salt--"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] Salt()
        {
            return IExecuteWithSignatureArray<byte>("salt", "()[B");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/admin/UserScramCredentialUpsertion.html#credentialInfo--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.ScramCredentialInfo"/></returns>
        public Org.Apache.Kafka.Clients.Admin.ScramCredentialInfo CredentialInfo()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Clients.Admin.ScramCredentialInfo>("credentialInfo", "()Lorg/apache/kafka/clients/admin/ScramCredentialInfo;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}