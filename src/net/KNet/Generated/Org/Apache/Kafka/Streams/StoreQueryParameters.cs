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
*  This file is generated by MASES.JNetReflector (ver. 2.0.0.0)
*  using kafka-streams-3.5.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams
{
    #region StoreQueryParameters
    public partial class StoreQueryParameters
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/StoreQueryParameters.html#fromNameAndType-java.lang.String-org.apache.kafka.streams.state.QueryableStoreType-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.State.QueryableStoreType"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.StoreQueryParameters"/></returns>
        public static Org.Apache.Kafka.Streams.StoreQueryParameters FromNameAndType(string arg0, Org.Apache.Kafka.Streams.State.QueryableStoreType arg1)
        {
            return SExecute<Org.Apache.Kafka.Streams.StoreQueryParameters>(LocalBridgeClazz, "fromNameAndType", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/StoreQueryParameters.html#staleStoresEnabled--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool StaleStoresEnabled()
        {
            return IExecute<bool>("staleStoresEnabled");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/StoreQueryParameters.html#partition--"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.Integer"/></returns>
        public Java.Lang.Integer Partition()
        {
            return IExecute<Java.Lang.Integer>("partition");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/StoreQueryParameters.html#storeName--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string StoreName()
        {
            return IExecute<string>("storeName");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/StoreQueryParameters.html#queryableStoreType--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.State.QueryableStoreType"/></returns>
        public Org.Apache.Kafka.Streams.State.QueryableStoreType QueryableStoreType()
        {
            return IExecute<Org.Apache.Kafka.Streams.State.QueryableStoreType>("queryableStoreType");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/StoreQueryParameters.html#enableStaleStores--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.StoreQueryParameters"/></returns>
        public Org.Apache.Kafka.Streams.StoreQueryParameters EnableStaleStores()
        {
            return IExecute<Org.Apache.Kafka.Streams.StoreQueryParameters>("enableStaleStores");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/StoreQueryParameters.html#withPartition-java.lang.Integer-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Integer"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.StoreQueryParameters"/></returns>
        public Org.Apache.Kafka.Streams.StoreQueryParameters WithPartition(Java.Lang.Integer arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.StoreQueryParameters>("withPartition", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region StoreQueryParameters<T>
    public partial class StoreQueryParameters<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.StoreQueryParameters{T}"/> to <see cref="Org.Apache.Kafka.Streams.StoreQueryParameters"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.StoreQueryParameters(Org.Apache.Kafka.Streams.StoreQueryParameters<T> t) => t.Cast<Org.Apache.Kafka.Streams.StoreQueryParameters>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/StoreQueryParameters.html#fromNameAndType-java.lang.String-org.apache.kafka.streams.state.QueryableStoreType-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.State.QueryableStoreType"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.StoreQueryParameters"/></returns>
        public static Org.Apache.Kafka.Streams.StoreQueryParameters<T> FromNameAndType(string arg0, Org.Apache.Kafka.Streams.State.QueryableStoreType<T> arg1)
        {
            return SExecute<Org.Apache.Kafka.Streams.StoreQueryParameters<T>>(LocalBridgeClazz, "fromNameAndType", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/StoreQueryParameters.html#staleStoresEnabled--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool StaleStoresEnabled()
        {
            return IExecute<bool>("staleStoresEnabled");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/StoreQueryParameters.html#partition--"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.Integer"/></returns>
        public Java.Lang.Integer Partition()
        {
            return IExecute<Java.Lang.Integer>("partition");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/StoreQueryParameters.html#storeName--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string StoreName()
        {
            return IExecute<string>("storeName");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/StoreQueryParameters.html#queryableStoreType--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.State.QueryableStoreType"/></returns>
        public Org.Apache.Kafka.Streams.State.QueryableStoreType<T> QueryableStoreType()
        {
            return IExecute<Org.Apache.Kafka.Streams.State.QueryableStoreType<T>>("queryableStoreType");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/StoreQueryParameters.html#enableStaleStores--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.StoreQueryParameters"/></returns>
        public Org.Apache.Kafka.Streams.StoreQueryParameters<T> EnableStaleStores()
        {
            return IExecute<Org.Apache.Kafka.Streams.StoreQueryParameters<T>>("enableStaleStores");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/StoreQueryParameters.html#withPartition-java.lang.Integer-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Integer"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.StoreQueryParameters"/></returns>
        public Org.Apache.Kafka.Streams.StoreQueryParameters<T> WithPartition(Java.Lang.Integer arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.StoreQueryParameters<T>>("withPartition", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}