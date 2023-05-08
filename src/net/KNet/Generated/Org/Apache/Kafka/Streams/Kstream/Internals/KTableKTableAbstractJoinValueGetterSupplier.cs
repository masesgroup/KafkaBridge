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

namespace Org.Apache.Kafka.Streams.Kstream.Internals
{
    #region KTableKTableAbstractJoinValueGetterSupplier
    public partial class KTableKTableAbstractJoinValueGetterSupplier
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Kstream.Internals.KTableKTableAbstractJoinValueGetterSupplier"/> to <see cref="Org.Apache.Kafka.Streams.Kstream.Internals.KTableValueGetterSupplier"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Kstream.Internals.KTableValueGetterSupplier(Org.Apache.Kafka.Streams.Kstream.Internals.KTableKTableAbstractJoinValueGetterSupplier t) => t.Cast<Org.Apache.Kafka.Streams.Kstream.Internals.KTableValueGetterSupplier>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/KTableKTableAbstractJoinValueGetterSupplier.html#storeNames()"/> 
        /// </summary>
        public string[] StoreNames
        {
            get { return IExecuteArray<string>("storeNames"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region KTableKTableAbstractJoinValueGetterSupplier<K, R, V1, V2>
    public partial class KTableKTableAbstractJoinValueGetterSupplier<K, R, V1, V2>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Kstream.Internals.KTableKTableAbstractJoinValueGetterSupplier{K, R, V1, V2}"/> to <see cref="Org.Apache.Kafka.Streams.Kstream.Internals.KTableValueGetterSupplier"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Kstream.Internals.KTableValueGetterSupplier(Org.Apache.Kafka.Streams.Kstream.Internals.KTableKTableAbstractJoinValueGetterSupplier<K, R, V1, V2> t) => t.Cast<Org.Apache.Kafka.Streams.Kstream.Internals.KTableValueGetterSupplier>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Kstream.Internals.KTableKTableAbstractJoinValueGetterSupplier{K, R, V1, V2}"/> to <see cref="Org.Apache.Kafka.Streams.Kstream.Internals.KTableKTableAbstractJoinValueGetterSupplier"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Kstream.Internals.KTableKTableAbstractJoinValueGetterSupplier(Org.Apache.Kafka.Streams.Kstream.Internals.KTableKTableAbstractJoinValueGetterSupplier<K, R, V1, V2> t) => t.Cast<Org.Apache.Kafka.Streams.Kstream.Internals.KTableKTableAbstractJoinValueGetterSupplier>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/KTableKTableAbstractJoinValueGetterSupplier.html#storeNames()"/> 
        /// </summary>
        public string[] StoreNames
        {
            get { return IExecuteArray<string>("storeNames"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}