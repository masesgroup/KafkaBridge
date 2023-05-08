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
*  using kafka_2.13-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Kafka.Coordinator.Transaction
{
    #region CoordinatorEpochAndTxnMetadata
    public partial class CoordinatorEpochAndTxnMetadata
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/transaction/CoordinatorEpochAndTxnMetadata.html#%3Cinit%3E(int,kafka.coordinator.transaction.TransactionMetadata)"/>
        /// </summary>
        /// <param name="coordinatorEpoch"><see cref="int"/></param>
        /// <param name="transactionMetadata"><see cref="Kafka.Coordinator.Transaction.TransactionMetadata"/></param>
        public CoordinatorEpochAndTxnMetadata(int coordinatorEpoch, Kafka.Coordinator.Transaction.TransactionMetadata transactionMetadata)
            : base(coordinatorEpoch, transactionMetadata)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Kafka.Coordinator.Transaction.CoordinatorEpochAndTxnMetadata"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Kafka.Coordinator.Transaction.CoordinatorEpochAndTxnMetadata t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/transaction/CoordinatorEpochAndTxnMetadata.html#apply(int,kafka.coordinator.transaction.TransactionMetadata)"/>
        /// </summary>
        /// <param name="coordinatorEpoch"><see cref="int"/></param>
        /// <param name="transactionMetadata"><see cref="Kafka.Coordinator.Transaction.TransactionMetadata"/></param>
        /// <returns><see cref="Kafka.Coordinator.Transaction.CoordinatorEpochAndTxnMetadata"/></returns>
        public static Kafka.Coordinator.Transaction.CoordinatorEpochAndTxnMetadata Apply(int coordinatorEpoch, Kafka.Coordinator.Transaction.TransactionMetadata transactionMetadata)
        {
            return SExecute<Kafka.Coordinator.Transaction.CoordinatorEpochAndTxnMetadata>(LocalBridgeClazz, "apply", coordinatorEpoch, transactionMetadata);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/transaction/CoordinatorEpochAndTxnMetadata.html#coordinatorEpoch()"/> 
        /// </summary>
        public int CoordinatorEpoch
        {
            get { return IExecute<int>("coordinatorEpoch"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/transaction/CoordinatorEpochAndTxnMetadata.html#productArity()"/> 
        /// </summary>
        public int ProductArity
        {
            get { return IExecute<int>("productArity"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/transaction/CoordinatorEpochAndTxnMetadata.html#productPrefix()"/> 
        /// </summary>
        public string ProductPrefix
        {
            get { return IExecute<string>("productPrefix"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/transaction/CoordinatorEpochAndTxnMetadata.html#transactionMetadata()"/> 
        /// </summary>
        public Kafka.Coordinator.Transaction.TransactionMetadata TransactionMetadata
        {
            get { return IExecute<Kafka.Coordinator.Transaction.TransactionMetadata>("transactionMetadata"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/transaction/CoordinatorEpochAndTxnMetadata.html#canEqual(java.lang.Object)"/>
        /// </summary>
        /// <param name="x$1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CanEqual(object x_1)
        {
            return IExecute<bool>("canEqual", x_1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/transaction/CoordinatorEpochAndTxnMetadata.html#productElement(int)"/>
        /// </summary>
        /// <param name="x$1"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object ProductElement(int x_1)
        {
            return IExecute("productElement", x_1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/transaction/CoordinatorEpochAndTxnMetadata.html#productElementName(int)"/>
        /// </summary>
        /// <param name="x$1"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string ProductElementName(int x_1)
        {
            return IExecute<string>("productElementName", x_1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/transaction/CoordinatorEpochAndTxnMetadata.html#copy(int,kafka.coordinator.transaction.TransactionMetadata)"/>
        /// </summary>
        /// <param name="coordinatorEpoch"><see cref="int"/></param>
        /// <param name="transactionMetadata"><see cref="Kafka.Coordinator.Transaction.TransactionMetadata"/></param>
        /// <returns><see cref="Kafka.Coordinator.Transaction.CoordinatorEpochAndTxnMetadata"/></returns>
        public Kafka.Coordinator.Transaction.CoordinatorEpochAndTxnMetadata Copy(int coordinatorEpoch, Kafka.Coordinator.Transaction.TransactionMetadata transactionMetadata)
        {
            return IExecute<Kafka.Coordinator.Transaction.CoordinatorEpochAndTxnMetadata>("copy", coordinatorEpoch, transactionMetadata);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}