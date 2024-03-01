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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using kafka-clients-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Serialization
{
    #region DoubleDeserializer
    public partial class DoubleDeserializer
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Common.Serialization.DoubleDeserializer"/> to <see cref="Org.Apache.Kafka.Common.Serialization.Deserializer"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Serialization.Deserializer(Org.Apache.Kafka.Common.Serialization.DoubleDeserializer t) => t.Cast<Org.Apache.Kafka.Common.Serialization.Deserializer>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/serialization/DoubleDeserializer.html#deserialize-java.lang.String-byte[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <returns><see cref="object"/></returns>
        public object Deserialize(Java.Lang.String arg0, byte[] arg1)
        {
            return IExecute("deserialize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/serialization/DoubleDeserializer.html#deserialize-java.lang.String-org.apache.kafka.common.header.Headers-java.nio.ByteBuffer-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Header.Headers"/></param>
        /// <param name="arg2"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="object"/></returns>
        public object Deserialize(Java.Lang.String arg0, Org.Apache.Kafka.Common.Header.Headers arg1, Java.Nio.ByteBuffer arg2)
        {
            return IExecute("deserialize", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}