﻿/*
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

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Serialization
{ 
        /// <summary>
    /// Listener for Kafka Serializer. Extends <see cref="JVMBridgeListener"/>. Implements <see cref="ISerializer{T}"/>
    /// </summary>
    /// <remarks>Dispose the object to avoid a resource leak, the object contains a reference to the corresponding JVM object</remarks>
    public partial class Serde<T> : ISerde<T>
    {
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/serialization/Serde.html#deserializer--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Deserializer"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Deserializer<T> DeserializerDirect()
        {
            return new DeserializerDirect<T>();
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/serialization/Serde.html#serializer--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serializer"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Serializer<T> SerializerDirect()
        {
            return new SerializerDirect<T>();
        }
    }
}
