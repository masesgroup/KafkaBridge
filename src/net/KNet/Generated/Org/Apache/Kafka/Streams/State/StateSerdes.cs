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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using kafka-streams-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.State
{
    #region StateSerdes
    public partial class StateSerdes
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#org.apache.kafka.streams.state.StateSerdes(java.lang.String,org.apache.kafka.common.serialization.Serde,org.apache.kafka.common.serialization.Serde)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        public StateSerdes(Java.Lang.String arg0, Org.Apache.Kafka.Common.Serialization.Serde arg1, Org.Apache.Kafka.Common.Serialization.Serde arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#BOOLEAN_SIZE"/>
        /// </summary>
        public static int BOOLEAN_SIZE { get { if (!_BOOLEAN_SIZEReady) { _BOOLEAN_SIZEContent = SGetField<int>(LocalBridgeClazz, "BOOLEAN_SIZE"); _BOOLEAN_SIZEReady = true; } return _BOOLEAN_SIZEContent; } }
        private static int _BOOLEAN_SIZEContent = default;
        private static bool _BOOLEAN_SIZEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#TIMESTAMP_SIZE"/>
        /// </summary>
        public static int TIMESTAMP_SIZE { get { if (!_TIMESTAMP_SIZEReady) { _TIMESTAMP_SIZEContent = SGetField<int>(LocalBridgeClazz, "TIMESTAMP_SIZE"); _TIMESTAMP_SIZEReady = true; } return _TIMESTAMP_SIZEContent; } }
        private static int _TIMESTAMP_SIZEContent = default;
        private static bool _TIMESTAMP_SIZEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#withBuiltinTypes-java.lang.String-java.lang.Class-java.lang.Class-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.StateSerdes"/></returns>
        public static Org.Apache.Kafka.Streams.State.StateSerdes WithBuiltinTypes(Java.Lang.String arg0, Java.Lang.Class arg1, Java.Lang.Class arg2)
        {
            return SExecute<Org.Apache.Kafka.Streams.State.StateSerdes>(LocalBridgeClazz, "withBuiltinTypes", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#rawKey-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] RawKey(object arg0)
        {
            return IExecuteWithSignatureArray<byte>("rawKey", "(Ljava/lang/Object;)[B", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#rawValue-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] RawValue(object arg0)
        {
            return IExecuteWithSignatureArray<byte>("rawValue", "(Ljava/lang/Object;)[B", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#topic--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Topic()
        {
            return IExecuteWithSignature<Java.Lang.String>("topic", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#keyFrom-byte[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="object"/></returns>
        public object KeyFrom(byte[] arg0)
        {
            return IExecuteWithSignature("keyFrom", "([B)Ljava/lang/Object;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#keyDeserializer--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Deserializer"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Deserializer KeyDeserializer()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.Deserializer>("keyDeserializer", "()Lorg/apache/kafka/common/serialization/Deserializer;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#keyDeserializer--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Deserializer"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Deserializer KeyDeserializerDirect()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.DeserializerDirect, Org.Apache.Kafka.Common.Serialization.Deserializer>("keyDeserializer", "()Lorg/apache/kafka/common/serialization/Deserializer;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#valueDeserializer--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Deserializer"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Deserializer ValueDeserializer()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.Deserializer>("valueDeserializer", "()Lorg/apache/kafka/common/serialization/Deserializer;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#valueDeserializer--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Deserializer"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Deserializer ValueDeserializerDirect()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.DeserializerDirect, Org.Apache.Kafka.Common.Serialization.Deserializer>("valueDeserializer", "()Lorg/apache/kafka/common/serialization/Deserializer;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#keySerde--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Serde KeySerde()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.Serde>("keySerde", "()Lorg/apache/kafka/common/serialization/Serde;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#keySerde--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Serde KeySerdeDirect()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.SerdeDirect, Org.Apache.Kafka.Common.Serialization.Serde>("keySerde", "()Lorg/apache/kafka/common/serialization/Serde;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#valueSerde--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Serde ValueSerde()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.Serde>("valueSerde", "()Lorg/apache/kafka/common/serialization/Serde;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#valueSerde--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Serde ValueSerdeDirect()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.SerdeDirect, Org.Apache.Kafka.Common.Serialization.Serde>("valueSerde", "()Lorg/apache/kafka/common/serialization/Serde;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#keySerializer--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serializer"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Serializer KeySerializer()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.Serializer>("keySerializer", "()Lorg/apache/kafka/common/serialization/Serializer;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#keySerializer--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serializer"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Serializer KeySerializerDirect()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.SerializerDirect, Org.Apache.Kafka.Common.Serialization.Serializer>("keySerializer", "()Lorg/apache/kafka/common/serialization/Serializer;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#valueSerializer--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serializer"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Serializer ValueSerializer()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.Serializer>("valueSerializer", "()Lorg/apache/kafka/common/serialization/Serializer;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#valueSerializer--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serializer"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Serializer ValueSerializerDirect()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.SerializerDirect, Org.Apache.Kafka.Common.Serialization.Serializer>("valueSerializer", "()Lorg/apache/kafka/common/serialization/Serializer;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#valueFrom-byte[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="object"/></returns>
        public object ValueFrom(byte[] arg0)
        {
            return IExecuteWithSignature("valueFrom", "([B)Ljava/lang/Object;", new object[] { arg0 });
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region StateSerdes<K, V>
    public partial class StateSerdes<K, V>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#org.apache.kafka.streams.state.StateSerdes(java.lang.String,org.apache.kafka.common.serialization.Serde,org.apache.kafka.common.serialization.Serde)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></param>
        public StateSerdes(Java.Lang.String arg0, Org.Apache.Kafka.Common.Serialization.Serde<K> arg1, Org.Apache.Kafka.Common.Serialization.Serde<V> arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.State.StateSerdes{K, V}"/> to <see cref="Org.Apache.Kafka.Streams.State.StateSerdes"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.State.StateSerdes(Org.Apache.Kafka.Streams.State.StateSerdes<K, V> t) => t.Cast<Org.Apache.Kafka.Streams.State.StateSerdes>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#BOOLEAN_SIZE"/>
        /// </summary>
        public static int BOOLEAN_SIZE { get { if (!_BOOLEAN_SIZEReady) { _BOOLEAN_SIZEContent = SGetField<int>(LocalBridgeClazz, "BOOLEAN_SIZE"); _BOOLEAN_SIZEReady = true; } return _BOOLEAN_SIZEContent; } }
        private static int _BOOLEAN_SIZEContent = default;
        private static bool _BOOLEAN_SIZEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#TIMESTAMP_SIZE"/>
        /// </summary>
        public static int TIMESTAMP_SIZE { get { if (!_TIMESTAMP_SIZEReady) { _TIMESTAMP_SIZEContent = SGetField<int>(LocalBridgeClazz, "TIMESTAMP_SIZE"); _TIMESTAMP_SIZEReady = true; } return _TIMESTAMP_SIZEContent; } }
        private static int _TIMESTAMP_SIZEContent = default;
        private static bool _TIMESTAMP_SIZEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#withBuiltinTypes-java.lang.String-java.lang.Class-java.lang.Class-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.StateSerdes"/></returns>
        public static Org.Apache.Kafka.Streams.State.StateSerdes<K, V> WithBuiltinTypes(Java.Lang.String arg0, Java.Lang.Class arg1, Java.Lang.Class arg2)
        {
            return SExecute<Org.Apache.Kafka.Streams.State.StateSerdes<K, V>>(LocalBridgeClazz, "withBuiltinTypes", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#rawKey-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] RawKey(K arg0)
        {
            return IExecuteWithSignatureArray<byte>("rawKey", "(Ljava/lang/Object;)[B", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#rawValue-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="V"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] RawValue(V arg0)
        {
            return IExecuteWithSignatureArray<byte>("rawValue", "(Ljava/lang/Object;)[B", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#topic--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Topic()
        {
            return IExecuteWithSignature<Java.Lang.String>("topic", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#keyFrom-byte[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><typeparamref name="K"/></returns>
        public K KeyFrom(byte[] arg0)
        {
            return IExecuteWithSignature<K>("keyFrom", "([B)Ljava/lang/Object;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#keyDeserializer--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Deserializer"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Deserializer<K> KeyDeserializer()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.Deserializer<K>>("keyDeserializer", "()Lorg/apache/kafka/common/serialization/Deserializer;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#keyDeserializer--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Deserializer"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Deserializer<K> KeyDeserializerDirect()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.DeserializerDirect<K>, Org.Apache.Kafka.Common.Serialization.Deserializer<K>>("keyDeserializer", "()Lorg/apache/kafka/common/serialization/Deserializer;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#valueDeserializer--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Deserializer"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Deserializer<V> ValueDeserializer()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.Deserializer<V>>("valueDeserializer", "()Lorg/apache/kafka/common/serialization/Deserializer;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#valueDeserializer--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Deserializer"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Deserializer<V> ValueDeserializerDirect()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.DeserializerDirect<V>, Org.Apache.Kafka.Common.Serialization.Deserializer<V>>("valueDeserializer", "()Lorg/apache/kafka/common/serialization/Deserializer;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#keySerde--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Serde<K> KeySerde()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.Serde<K>>("keySerde", "()Lorg/apache/kafka/common/serialization/Serde;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#keySerde--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Serde<K> KeySerdeDirect()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.SerdeDirect<K>, Org.Apache.Kafka.Common.Serialization.Serde<K>>("keySerde", "()Lorg/apache/kafka/common/serialization/Serde;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#valueSerde--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Serde<V> ValueSerde()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.Serde<V>>("valueSerde", "()Lorg/apache/kafka/common/serialization/Serde;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#valueSerde--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serde"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Serde<V> ValueSerdeDirect()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.SerdeDirect<V>, Org.Apache.Kafka.Common.Serialization.Serde<V>>("valueSerde", "()Lorg/apache/kafka/common/serialization/Serde;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#keySerializer--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serializer"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Serializer<K> KeySerializer()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.Serializer<K>>("keySerializer", "()Lorg/apache/kafka/common/serialization/Serializer;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#keySerializer--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serializer"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Serializer<K> KeySerializerDirect()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.SerializerDirect<K>, Org.Apache.Kafka.Common.Serialization.Serializer<K>>("keySerializer", "()Lorg/apache/kafka/common/serialization/Serializer;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#valueSerializer--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serializer"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Serializer<V> ValueSerializer()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.Serializer<V>>("valueSerializer", "()Lorg/apache/kafka/common/serialization/Serializer;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#valueSerializer--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Serializer"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Serializer<V> ValueSerializerDirect()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Serialization.SerializerDirect<V>, Org.Apache.Kafka.Common.Serialization.Serializer<V>>("valueSerializer", "()Lorg/apache/kafka/common/serialization/Serializer;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/StateSerdes.html#valueFrom-byte[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><typeparamref name="V"/></returns>
        public V ValueFrom(byte[] arg0)
        {
            return IExecuteWithSignature<V>("valueFrom", "([B)Ljava/lang/Object;", new object[] { arg0 });
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}