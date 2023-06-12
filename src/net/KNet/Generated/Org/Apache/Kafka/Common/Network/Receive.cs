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

namespace Org.Apache.Kafka.Common.Network
{
    #region IReceive
    /// <summary>
    /// .NET interface for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/network/Receive.html"/>
    /// </summary>
    public partial interface IReceive : Java.Io.ICloseable
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Receive
    public partial class Receive : Org.Apache.Kafka.Common.Network.IReceive
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/network/Receive.html#complete()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool Complete()
        {
            return IExecute<bool>("complete");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/network/Receive.html#memoryAllocated()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool MemoryAllocated()
        {
            return IExecute<bool>("memoryAllocated");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/network/Receive.html#requiredMemoryAmountKnown()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool RequiredMemoryAmountKnown()
        {
            return IExecute<bool>("requiredMemoryAmountKnown");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/network/Receive.html#source()"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string Source()
        {
            return IExecute<string>("source");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/network/Receive.html#readFrom(java.nio.channels.ScatteringByteChannel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.Channels.ScatteringByteChannel"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long ReadFrom(Java.Nio.Channels.ScatteringByteChannel arg0)
        {
            return IExecute<long>("readFrom", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}