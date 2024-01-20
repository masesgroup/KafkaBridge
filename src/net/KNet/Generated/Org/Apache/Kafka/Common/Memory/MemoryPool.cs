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
*  This file is generated by MASES.JNetReflector (ver. 2.2.1.0)
*  using kafka-clients-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Memory
{
    #region IMemoryPool
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IMemoryPool
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region MemoryPool
    public partial class MemoryPool : Org.Apache.Kafka.Common.Memory.IMemoryPool
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/memory/MemoryPool.html#NONE"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Memory.MemoryPool NONE { get { return SGetField<Org.Apache.Kafka.Common.Memory.MemoryPool>(LocalBridgeClazz, "NONE"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/memory/MemoryPool.html#isOutOfMemory--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsOutOfMemory()
        {
            return IExecute<bool>("isOutOfMemory");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/memory/MemoryPool.html#tryAllocate-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer TryAllocate(int arg0)
        {
            return IExecute<Java.Nio.ByteBuffer>("tryAllocate", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/memory/MemoryPool.html#availableMemory--"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long AvailableMemory()
        {
            return IExecute<long>("availableMemory");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/memory/MemoryPool.html#size--"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long Size()
        {
            return IExecute<long>("size");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/memory/MemoryPool.html#release-java.nio.ByteBuffer-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        public void Release(Java.Nio.ByteBuffer arg0)
        {
            IExecute("release", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}