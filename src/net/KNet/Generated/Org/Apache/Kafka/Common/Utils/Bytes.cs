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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using kafka-clients-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Utils
{
    #region Bytes
    public partial class Bytes
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/utils/Bytes.html#org.apache.kafka.common.utils.Bytes(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        public Bytes(byte[] arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/utils/Bytes.html#EMPTY"/>
        /// </summary>
        public static byte[] EMPTY { get { if (!_EMPTYReady) { _EMPTYContent = SGetFieldArray<byte>(LocalBridgeClazz, "EMPTY"); _EMPTYReady = true; } return _EMPTYContent; } }
        private static byte[] _EMPTYContent = default;
        private static bool _EMPTYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/utils/Bytes.html#increment-org.apache.kafka.common.utils.Bytes-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Utils.Bytes"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Utils.Bytes"/></returns>
        /// <exception cref="Java.Lang.IndexOutOfBoundsException"/>
        public static Org.Apache.Kafka.Common.Utils.Bytes Increment(Org.Apache.Kafka.Common.Utils.Bytes arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.Utils.Bytes>(LocalBridgeClazz, "increment", "(Lorg/apache/kafka/common/utils/Bytes;)Lorg/apache/kafka/common/utils/Bytes;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/utils/Bytes.html#wrap-byte[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Utils.Bytes"/></returns>
        public static Org.Apache.Kafka.Common.Utils.Bytes Wrap(byte[] arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.Utils.Bytes>(LocalBridgeClazz, "wrap", "([B)Lorg/apache/kafka/common/utils/Bytes;", new object[] { arg0 });
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/utils/Bytes.html#get--"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] Get()
        {
            return IExecuteWithSignatureArray<byte>("get", "()[B");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/utils/Bytes.html#compareTo-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/utils/Bytes.html#compareTo-org.apache.kafka.common.utils.Bytes-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Utils.Bytes"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Org.Apache.Kafka.Common.Utils.Bytes arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Lorg/apache/kafka/common/utils/Bytes;)I", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}