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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using kafka-clients-3.7.0.jar as reference
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

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/utils/BufferSupplier.html#NO_CACHING"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Utils.BufferSupplier NO_CACHING { get { if (!_NO_CACHINGReady) { _NO_CACHINGContent = SGetField<Org.Apache.Kafka.Common.Utils.BufferSupplier>(LocalBridgeClazz, "NO_CACHING"); _NO_CACHINGReady = true; } return _NO_CACHINGContent; } }
        private static Org.Apache.Kafka.Common.Utils.BufferSupplier _NO_CACHINGContent = default;
        private static bool _NO_CACHINGReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/utils/BufferSupplier.html#create--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Utils.BufferSupplier"/></returns>
        public static Org.Apache.Kafka.Common.Utils.BufferSupplier Create()
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.Utils.BufferSupplier>(LocalBridgeClazz, "create", "()Lorg/apache/kafka/common/utils/BufferSupplier;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/utils/BufferSupplier.html#get-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer Get(int arg0)
        {
            return IExecuteWithSignature<Java.Nio.ByteBuffer>("get", "(I)Ljava/nio/ByteBuffer;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/utils/BufferSupplier.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/utils/BufferSupplier.html#release-java.nio.ByteBuffer-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        public void Release(Java.Nio.ByteBuffer arg0)
        {
            IExecuteWithSignature("release", "(Ljava/nio/ByteBuffer;)V", arg0);
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