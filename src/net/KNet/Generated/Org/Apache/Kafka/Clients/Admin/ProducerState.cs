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
*  using kafka-clients-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Admin
{
    #region ProducerState
    public partial class ProducerState
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/admin/ProducerState.html#org.apache.kafka.clients.admin.ProducerState(long,int,int,long,java.util.OptionalInt,java.util.OptionalLong)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <param name="arg4"><see cref="Java.Util.OptionalInt"/></param>
        /// <param name="arg5"><see cref="Java.Util.OptionalLong"/></param>
        public ProducerState(long arg0, int arg1, int arg2, long arg3, Java.Util.OptionalInt arg4, Java.Util.OptionalLong arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/admin/ProducerState.html#lastSequence--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int LastSequence()
        {
            return IExecuteWithSignature<int>("lastSequence", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/admin/ProducerState.html#producerEpoch--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int ProducerEpoch()
        {
            return IExecuteWithSignature<int>("producerEpoch", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/admin/ProducerState.html#coordinatorEpoch--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.OptionalInt"/></returns>
        public Java.Util.OptionalInt CoordinatorEpoch()
        {
            return IExecuteWithSignature<Java.Util.OptionalInt>("coordinatorEpoch", "()Ljava/util/OptionalInt;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/admin/ProducerState.html#currentTransactionStartOffset--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.OptionalLong"/></returns>
        public Java.Util.OptionalLong CurrentTransactionStartOffset()
        {
            return IExecuteWithSignature<Java.Util.OptionalLong>("currentTransactionStartOffset", "()Ljava/util/OptionalLong;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/admin/ProducerState.html#lastTimestamp--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long LastTimestamp()
        {
            return IExecuteWithSignature<long>("lastTimestamp", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/admin/ProducerState.html#producerId--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long ProducerId()
        {
            return IExecuteWithSignature<long>("producerId", "()J");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}