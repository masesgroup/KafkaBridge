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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using kafka-streams-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.State
{
    #region VersionedKeyValueStore
    public partial class VersionedKeyValueStore
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/state/VersionedKeyValueStore.html#PUT_RETURN_CODE_NOT_PUT"/>
        /// </summary>
        public static long PUT_RETURN_CODE_NOT_PUT { get { if (!_PUT_RETURN_CODE_NOT_PUTReady) { _PUT_RETURN_CODE_NOT_PUTContent = SGetField<long>(LocalBridgeClazz, "PUT_RETURN_CODE_NOT_PUT"); _PUT_RETURN_CODE_NOT_PUTReady = true; } return _PUT_RETURN_CODE_NOT_PUTContent; } }
        private static long _PUT_RETURN_CODE_NOT_PUTContent = default;
        private static bool _PUT_RETURN_CODE_NOT_PUTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/state/VersionedKeyValueStore.html#PUT_RETURN_CODE_VALID_TO_UNDEFINED"/>
        /// </summary>
        public static long PUT_RETURN_CODE_VALID_TO_UNDEFINED { get { if (!_PUT_RETURN_CODE_VALID_TO_UNDEFINEDReady) { _PUT_RETURN_CODE_VALID_TO_UNDEFINEDContent = SGetField<long>(LocalBridgeClazz, "PUT_RETURN_CODE_VALID_TO_UNDEFINED"); _PUT_RETURN_CODE_VALID_TO_UNDEFINEDReady = true; } return _PUT_RETURN_CODE_VALID_TO_UNDEFINEDContent; } }
        private static long _PUT_RETURN_CODE_VALID_TO_UNDEFINEDContent = default;
        private static bool _PUT_RETURN_CODE_VALID_TO_UNDEFINEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/state/VersionedKeyValueStore.html#put-java.lang.Object-java.lang.Object-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long Put(object arg0, object arg1, long arg2)
        {
            return IExecute<long>("put", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/state/VersionedKeyValueStore.html#delete-java.lang.Object-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.VersionedRecord"/></returns>
        public Org.Apache.Kafka.Streams.State.VersionedRecord Delete(object arg0, long arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.VersionedRecord>("delete", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/state/VersionedKeyValueStore.html#get-java.lang.Object-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.VersionedRecord"/></returns>
        public Org.Apache.Kafka.Streams.State.VersionedRecord Get(object arg0, long arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.VersionedRecord>("get", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/state/VersionedKeyValueStore.html#get-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.VersionedRecord"/></returns>
        public Org.Apache.Kafka.Streams.State.VersionedRecord Get(object arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.State.VersionedRecord>("get", "(Ljava/lang/Object;)Lorg/apache/kafka/streams/state/VersionedRecord;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IVersionedKeyValueStore<K, V>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IVersionedKeyValueStore<K, V> : Org.Apache.Kafka.Streams.Processor.IStateStore
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region VersionedKeyValueStore<K, V>
    public partial class VersionedKeyValueStore<K, V> : Org.Apache.Kafka.Streams.State.IVersionedKeyValueStore<K, V>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.State.VersionedKeyValueStore{K, V}"/> to <see cref="Org.Apache.Kafka.Streams.State.VersionedKeyValueStore"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.State.VersionedKeyValueStore(Org.Apache.Kafka.Streams.State.VersionedKeyValueStore<K, V> t) => t.Cast<Org.Apache.Kafka.Streams.State.VersionedKeyValueStore>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/state/VersionedKeyValueStore.html#PUT_RETURN_CODE_NOT_PUT"/>
        /// </summary>
        public static long PUT_RETURN_CODE_NOT_PUT { get { if (!_PUT_RETURN_CODE_NOT_PUTReady) { _PUT_RETURN_CODE_NOT_PUTContent = SGetField<long>(LocalBridgeClazz, "PUT_RETURN_CODE_NOT_PUT"); _PUT_RETURN_CODE_NOT_PUTReady = true; } return _PUT_RETURN_CODE_NOT_PUTContent; } }
        private static long _PUT_RETURN_CODE_NOT_PUTContent = default;
        private static bool _PUT_RETURN_CODE_NOT_PUTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/state/VersionedKeyValueStore.html#PUT_RETURN_CODE_VALID_TO_UNDEFINED"/>
        /// </summary>
        public static long PUT_RETURN_CODE_VALID_TO_UNDEFINED { get { if (!_PUT_RETURN_CODE_VALID_TO_UNDEFINEDReady) { _PUT_RETURN_CODE_VALID_TO_UNDEFINEDContent = SGetField<long>(LocalBridgeClazz, "PUT_RETURN_CODE_VALID_TO_UNDEFINED"); _PUT_RETURN_CODE_VALID_TO_UNDEFINEDReady = true; } return _PUT_RETURN_CODE_VALID_TO_UNDEFINEDContent; } }
        private static long _PUT_RETURN_CODE_VALID_TO_UNDEFINEDContent = default;
        private static bool _PUT_RETURN_CODE_VALID_TO_UNDEFINEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/state/VersionedKeyValueStore.html#put-java.lang.Object-java.lang.Object-long-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long Put(K arg0, V arg1, long arg2)
        {
            return IExecute<long>("put", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/state/VersionedKeyValueStore.html#delete-java.lang.Object-long-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.VersionedRecord"/></returns>
        public Org.Apache.Kafka.Streams.State.VersionedRecord<V> Delete(K arg0, long arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.VersionedRecord<V>>("delete", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/state/VersionedKeyValueStore.html#get-java.lang.Object-long-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.VersionedRecord"/></returns>
        public Org.Apache.Kafka.Streams.State.VersionedRecord<V> Get(K arg0, long arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.VersionedRecord<V>>("get", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/state/VersionedKeyValueStore.html#get-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.VersionedRecord"/></returns>
        public Org.Apache.Kafka.Streams.State.VersionedRecord<V> Get(K arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.State.VersionedRecord<V>>("get", "(Ljava/lang/Object;)Lorg/apache/kafka/streams/state/VersionedRecord;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}