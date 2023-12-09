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
    #region ListOffsetsOptions
    public partial class ListOffsetsOptions
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/admin/ListOffsetsOptions.html#org.apache.kafka.clients.admin.ListOffsetsOptions(org.apache.kafka.common.IsolationLevel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.IsolationLevel"/></param>
        public ListOffsetsOptions(Org.Apache.Kafka.Common.IsolationLevel arg0)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/admin/ListOffsetsOptions.html#isolationLevel--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.IsolationLevel"/></returns>
        public Org.Apache.Kafka.Common.IsolationLevel IsolationLevel()
        {
            return IExecute<Org.Apache.Kafka.Common.IsolationLevel>("isolationLevel");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}