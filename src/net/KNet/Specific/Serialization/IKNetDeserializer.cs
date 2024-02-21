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

using Org.Apache.Kafka.Common.Header;
using Org.Apache.Kafka.Common.Serialization;
using System;

namespace MASES.KNet.Serialization
{
    /// <summary>
    /// KNet interface for deserializers
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TJVMT">The JVM type used</typeparam>
    public interface IDeserializer<T, TJVMT> : IDisposable
    {
        /// <summary>
        /// The <see cref="Deserializer{T}"/> to use in Apache Kafka
        /// </summary>
        Deserializer<TJVMT> KafkaDeserializer { get; }
        /// <summary>
        /// <see langword="true"/> if <see cref="Headers"/>are used
        /// </summary>
        bool UseHeaders { get; }
        /// <inheritdoc cref="Org.Apache.Kafka.Common.Serialization.IDeserializer{T}.Deserialize(Java.Lang.String, byte[])"/>
        T Deserialize(string topic, byte[] data);
        /// <inheritdoc cref="Org.Apache.Kafka.Common.Serialization.IDeserializer{T}.Deserialize(Java.Lang.String, Headers, byte[])"/>
        T DeserializeWithHeaders(string topic, Headers headers, byte[] data);
    }

    /// <summary>
    /// KNet interface for deserializers based on <see cref="byte"/> array JVM type
    /// </summary>
    /// <typeparam name="T">The .NET type</typeparam>
    public interface IDeserializer<T> : IDeserializer<T, byte[]>
    {

    }
}
