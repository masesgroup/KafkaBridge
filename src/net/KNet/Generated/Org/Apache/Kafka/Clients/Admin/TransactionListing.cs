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

namespace Org.Apache.Kafka.Clients.Admin
{
    #region TransactionListing
    public partial class TransactionListing
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/TransactionListing.html#%3Cinit%3E(java.lang.String,long,org.apache.kafka.clients.admin.TransactionState)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Clients.Admin.TransactionState"/></param>
        public TransactionListing(string arg0, long arg1, Org.Apache.Kafka.Clients.Admin.TransactionState arg2)
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
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/TransactionListing.html#producerId()"/> 
        /// </summary>
        public long ProducerId
        {
            get { return IExecute<long>("producerId"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/TransactionListing.html#state()"/> 
        /// </summary>
        public Org.Apache.Kafka.Clients.Admin.TransactionState State
        {
            get { return IExecute<Org.Apache.Kafka.Clients.Admin.TransactionState>("state"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/TransactionListing.html#transactionalId()"/> 
        /// </summary>
        public string TransactionalId
        {
            get { return IExecute<string>("transactionalId"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}