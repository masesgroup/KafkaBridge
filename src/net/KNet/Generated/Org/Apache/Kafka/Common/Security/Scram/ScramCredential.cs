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

namespace Org.Apache.Kafka.Common.Security.Scram
{
    #region ScramCredential
    public partial class ScramCredential
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/scram/ScramCredential.html#org.apache.kafka.common.security.scram.ScramCredential(byte[],byte[],byte[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public ScramCredential(byte[] arg0, byte[] arg1, byte[] arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/scram/ScramCredential.html#salt--"/>
        /// </summary>

        /// <returns><see cref="byte"/></returns>
        public byte[] Salt()
        {
            return IExecuteWithSignatureArray<byte>("salt", "()[B");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/scram/ScramCredential.html#serverKey--"/>
        /// </summary>

        /// <returns><see cref="byte"/></returns>
        public byte[] ServerKey()
        {
            return IExecuteWithSignatureArray<byte>("serverKey", "()[B");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/scram/ScramCredential.html#storedKey--"/>
        /// </summary>

        /// <returns><see cref="byte"/></returns>
        public byte[] StoredKey()
        {
            return IExecuteWithSignatureArray<byte>("storedKey", "()[B");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/security/scram/ScramCredential.html#iterations--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Iterations()
        {
            return IExecuteWithSignature<int>("iterations", "()I");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}