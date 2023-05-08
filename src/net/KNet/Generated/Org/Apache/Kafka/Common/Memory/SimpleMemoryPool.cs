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

namespace Org.Apache.Kafka.Common.Memory
{
    #region SimpleMemoryPool
    public partial class SimpleMemoryPool
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/memory/SimpleMemoryPool.html#%3Cinit%3E(long,int,boolean,org.apache.kafka.common.metrics.Sensor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Common.Metrics.Sensor"/></param>
        public SimpleMemoryPool(long arg0, int arg1, bool arg2, Org.Apache.Kafka.Common.Metrics.Sensor arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Common.Memory.SimpleMemoryPool"/> to <see cref="Org.Apache.Kafka.Common.Memory.MemoryPool"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Memory.MemoryPool(Org.Apache.Kafka.Common.Memory.SimpleMemoryPool t) => t.Cast<Org.Apache.Kafka.Common.Memory.MemoryPool>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/memory/SimpleMemoryPool.html#availableMemory()"/> 
        /// </summary>
        public long AvailableMemory
        {
            get { return IExecute<long>("availableMemory"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/memory/SimpleMemoryPool.html#isOutOfMemory()"/> 
        /// </summary>
        public bool IsOutOfMemory
        {
            get { return IExecute<bool>("isOutOfMemory"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/memory/SimpleMemoryPool.html#size()"/> 
        /// </summary>
        public long Size
        {
            get { return IExecute<long>("size"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/memory/SimpleMemoryPool.html#tryAllocate(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer TryAllocate(int arg0)
        {
            return IExecute<Java.Nio.ByteBuffer>("tryAllocate", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/memory/SimpleMemoryPool.html#release(java.nio.ByteBuffer)"/>
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