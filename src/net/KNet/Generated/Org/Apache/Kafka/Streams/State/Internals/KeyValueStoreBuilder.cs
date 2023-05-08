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
*  using kafka-streams-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.State.Internals
{
    #region KeyValueStoreBuilder
    public partial class KeyValueStoreBuilder
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/KeyValueStoreBuilder.html#%3Cinit%3E(org.apache.kafka.streams.state.KeyValueBytesStoreSupplier,org.apache.kafka.common.serialization.Serde,org.apache.kafka.common.serialization.Serde,org.apache.kafka.common.utils.Time)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.State.KeyValueBytesStoreSupplier"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Common.Utils.Time"/></param>
        public KeyValueStoreBuilder(Org.Apache.Kafka.Streams.State.KeyValueBytesStoreSupplier arg0, Org.Apache.Kafka.Common.Serialization.Serde arg1, Org.Apache.Kafka.Common.Serialization.Serde arg2, Org.Apache.Kafka.Common.Utils.Time arg3)
            : base(arg0, arg1, arg2, arg3)
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

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region KeyValueStoreBuilder<K, V>
    public partial class KeyValueStoreBuilder<K, V>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/KeyValueStoreBuilder.html#%3Cinit%3E(org.apache.kafka.streams.state.KeyValueBytesStoreSupplier,org.apache.kafka.common.serialization.Serde,org.apache.kafka.common.serialization.Serde,org.apache.kafka.common.utils.Time)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.State.KeyValueBytesStoreSupplier"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Common.Utils.Time"/></param>
        public KeyValueStoreBuilder(Org.Apache.Kafka.Streams.State.KeyValueBytesStoreSupplier arg0, Org.Apache.Kafka.Common.Serialization.Serde<K> arg1, Org.Apache.Kafka.Common.Serialization.Serde<V> arg2, Org.Apache.Kafka.Common.Utils.Time arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.State.Internals.KeyValueStoreBuilder{K, V}"/> to <see cref="Org.Apache.Kafka.Streams.State.Internals.KeyValueStoreBuilder"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.State.Internals.KeyValueStoreBuilder(Org.Apache.Kafka.Streams.State.Internals.KeyValueStoreBuilder<K, V> t) => t.Cast<Org.Apache.Kafka.Streams.State.Internals.KeyValueStoreBuilder>();

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
}