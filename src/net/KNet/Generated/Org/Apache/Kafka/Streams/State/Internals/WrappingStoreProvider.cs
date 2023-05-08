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
    #region WrappingStoreProvider
    public partial class WrappingStoreProvider
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.State.Internals.WrappingStoreProvider"/> to <see cref="Org.Apache.Kafka.Streams.State.Internals.StateStoreProvider"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.State.Internals.StateStoreProvider(Org.Apache.Kafka.Streams.State.Internals.WrappingStoreProvider t) => t.Cast<Org.Apache.Kafka.Streams.State.Internals.StateStoreProvider>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/WrappingStoreProvider.html#stores(java.lang.String,org.apache.kafka.streams.state.QueryableStoreType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.State.QueryableStoreType"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<T> Stores<T>(string arg0, Org.Apache.Kafka.Streams.State.QueryableStoreType<T> arg1)
        {
            return IExecute<Java.Util.List<T>>("stores", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/WrappingStoreProvider.html#setStoreQueryParameters(org.apache.kafka.streams.StoreQueryParameters)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.StoreQueryParameters"/></param>
        public void SetStoreQueryParameters(Org.Apache.Kafka.Streams.StoreQueryParameters arg0)
        {
            IExecute("setStoreQueryParameters", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}