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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using kafka-clients-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Utils
{
    #region ByteBufferOutputStream
    public partial class ByteBufferOutputStream
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/utils/ByteBufferOutputStream.html#org.apache.kafka.common.utils.ByteBufferOutputStream(int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public ByteBufferOutputStream(int arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/utils/ByteBufferOutputStream.html#org.apache.kafka.common.utils.ByteBufferOutputStream(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public ByteBufferOutputStream(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/utils/ByteBufferOutputStream.html#org.apache.kafka.common.utils.ByteBufferOutputStream(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        public ByteBufferOutputStream(Java.Nio.ByteBuffer arg0)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/utils/ByteBufferOutputStream.html#initialCapacity--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int InitialCapacity()
        {
            return IExecute<int>("initialCapacity");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/utils/ByteBufferOutputStream.html#limit--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Limit()
        {
            return IExecute<int>("limit");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/utils/ByteBufferOutputStream.html#position--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Position()
        {
            return IExecute<int>("position");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/utils/ByteBufferOutputStream.html#remaining--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Remaining()
        {
            return IExecute<int>("remaining");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/utils/ByteBufferOutputStream.html#buffer--"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer Buffer()
        {
            return IExecute<Java.Nio.ByteBuffer>("buffer");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/utils/ByteBufferOutputStream.html#ensureRemaining-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void EnsureRemaining(int arg0)
        {
            IExecute("ensureRemaining", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/utils/ByteBufferOutputStream.html#position-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Position(int arg0)
        {
            IExecute("position", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/utils/ByteBufferOutputStream.html#write-java.nio.ByteBuffer-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        public void Write(Java.Nio.ByteBuffer arg0)
        {
            IExecute("write", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}