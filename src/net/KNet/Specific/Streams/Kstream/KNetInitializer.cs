﻿/*
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

using MASES.KNet.Serialization;

namespace MASES.KNet.Streams.Kstream
{
    /// <summary>
    /// KNet implementation of <see cref="Org.Apache.Kafka.Streams.Kstream.Initializer{VA}"/>
    /// </summary>
    /// <typeparam name="VA">The key type</typeparam>
    public class KNetInitializer<VA> : Org.Apache.Kafka.Streams.Kstream.Initializer<byte[]>, IGenericSerDesFactoryApplier
    {
        IGenericSerDesFactory _factory;
        IGenericSerDesFactory IGenericSerDesFactoryApplier.Factory { get => _factory; set { _factory = value; } }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/Initializer.html#apply--"/>
        /// </summary>
        /// <remarks>If <see cref="OnApply2"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<VA> OnApply2 { get; set; } = null;
        /// <inheritdoc/>
        public sealed override byte[] Apply()
        {
            IKNetSerDes<VA> valueSerializer = _factory.BuildValueSerDes<VA>();

            var methodToExecute = (OnApply2 != null) ? OnApply2 : Apply2;
            var res = methodToExecute();
            return valueSerializer.Serialize(null, res);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/Initializer.html#apply--"/>
        /// </summary>
        /// <returns><typeparamref name="VA"/></returns>
        public virtual VA Apply2()
        {
            return default;
        }
    }
}
