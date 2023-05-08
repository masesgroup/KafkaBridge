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

namespace Org.Apache.Kafka.Common.Utils
{
    #region BufferSupplier
    public partial class BufferSupplier
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Common.Utils.BufferSupplier"/> to <see cref="Java.Lang.AutoCloseable"/>
        /// </summary>
        public static implicit operator Java.Lang.AutoCloseable(Org.Apache.Kafka.Common.Utils.BufferSupplier t) => t.Cast<Java.Lang.AutoCloseable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/utils/BufferSupplier.html#NO_CACHING"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Utils.BufferSupplier NO_CACHING { get { return SGetField<Org.Apache.Kafka.Common.Utils.BufferSupplier>(LocalBridgeClazz, "NO_CACHING"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/utils/BufferSupplier.html#create()"/> 
        /// </summary>
        public static Org.Apache.Kafka.Common.Utils.BufferSupplier Create
        {
            get { return SExecute<Org.Apache.Kafka.Common.Utils.BufferSupplier>(LocalBridgeClazz, "create"); }
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/utils/BufferSupplier.html#get(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer Get(int arg0)
        {
            return IExecute<Java.Nio.ByteBuffer>("get", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/utils/BufferSupplier.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/utils/BufferSupplier.html#release(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        public void Release(Java.Nio.ByteBuffer arg0)
        {
            IExecute("release", arg0);
        }

        #endregion

        #region Nested classes
        #region GrowableBufferSupplier
        public partial class GrowableBufferSupplier
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

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}