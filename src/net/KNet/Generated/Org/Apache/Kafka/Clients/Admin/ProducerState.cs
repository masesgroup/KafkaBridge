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
    #region ProducerState
    public partial class ProducerState
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/ProducerState.html#%3Cinit%3E(long,int,int,long,java.util.OptionalInt,java.util.OptionalLong)"/>
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/ProducerState.html#lastSequence()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int LastSequence()
        {
            return IExecute<int>("lastSequence");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/ProducerState.html#producerEpoch()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int ProducerEpoch()
        {
            return IExecute<int>("producerEpoch");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/ProducerState.html#coordinatorEpoch()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.OptionalInt"/></returns>
        public Java.Util.OptionalInt CoordinatorEpoch()
        {
            return IExecute<Java.Util.OptionalInt>("coordinatorEpoch");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/ProducerState.html#currentTransactionStartOffset()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.OptionalLong"/></returns>
        public Java.Util.OptionalLong CurrentTransactionStartOffset()
        {
            return IExecute<Java.Util.OptionalLong>("currentTransactionStartOffset");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/ProducerState.html#lastTimestamp()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long LastTimestamp()
        {
            return IExecute<long>("lastTimestamp");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/ProducerState.html#producerId()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long ProducerId()
        {
            return IExecute<long>("producerId");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}