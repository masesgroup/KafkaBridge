﻿/*
*  Copyright 2025 MASES s.r.l.
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
    /// KNet interface for serializers
    /// </summary>
    /// <typeparam name="T">The .NET type</typeparam>
    /// <typeparam name="TJVMT">The JVM type used</typeparam>
    public interface ISerializer<T, TJVMT> : ISerDes
    {
        /// <summary>
        /// The <see cref="Serializer{T}"/> to use in Apache Kafka
        /// </summary>
        public Serializer<TJVMT> KafkaSerializer { get; }
        /// <inheritdoc cref="Org.Apache.Kafka.Common.Serialization.ISerializer{T}.Serialize(Java.Lang.String, T)"/>
        TJVMT Serialize(string topic, T data);
        /// <inheritdoc cref="Org.Apache.Kafka.Common.Serialization.ISerializer{T}.Serialize(Java.Lang.String, Headers, T)"/>
        TJVMT SerializeWithHeaders(string topic, Headers headers, T data);
    }
}
