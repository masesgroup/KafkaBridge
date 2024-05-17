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

using Java.Nio;
using Javax.Xml.Crypto;
using MASES.JCOBridge.C2JBridge;
using Org.Apache.Kafka.Common.Header;
using Org.Apache.Kafka.Common.Serialization;
using System;

namespace MASES.KNet.Serialization
{
    /// <summary>
    /// KNet common serializer/deserializer
    /// </summary>
    /// <typeparam name="T">The type to serialize/deserialize</typeparam>
    /// <typeparam name="TJVMT">The corresponding JVM type used</typeparam>
    public interface ISerDes<T, TJVMT> : ISerializer<T, TJVMT>, IDeserializer<T, TJVMT>
    {
        /// <summary>
        /// The <see cref="Serde{T}"/> to use in Apache Kafka
        /// </summary>
        Serde<TJVMT> KafkaSerde { get; }
    }

    ///// <summary>
    ///// KNet common serializer/deserializer based on <see cref="byte"/> array JVM type
    ///// </summary>
    ///// <typeparam name="T">The type to serialize/deserialize</typeparam>
    //public interface ISerDes<T> : ISerDes<T, byte[]>, ISerializer<T>, IDeserializer<T>
    //{

    //}

    /// <summary>
    /// Common serializer/deserializer
    /// </summary>
    /// <typeparam name="T">The type to serialize/deserialize</typeparam>
    /// <typeparam name="TJVMT">The corresponding JVM type used</typeparam>
    public class SerDes<T, TJVMT> : ISerDes<T, TJVMT>
    {
        #region private fields
        readonly KNetSerialization.SerializationType _SerializationType;
        readonly KNetSerialization.SerializationType _JVMSerializationType;
        Serde<TJVMT> _KafkaSerde;
        Serializer<TJVMT> _KafkaSerializer;
        Deserializer<TJVMT> _KafkaDeserializer;
        #endregion

        #region Constructor
        /// <summary>
        /// Default initializer
        /// </summary>
        public SerDes()
        {
            _SerializationType = KNetSerialization.InternalSerDesType<T>();
            _JVMSerializationType = KNetSerialization.InternalJVMSerDesType<TJVMT>();
            if (_JVMSerializationType == KNetSerialization.SerializationType.External)
            {
                throw new ArgumentException($"Cannot manage {typeof(TJVMT).FullName} into TJVMT generic parameter");
            }

            if (_SerializationType == KNetSerialization.SerializationType.External
                && (IsDirectBuffered ? _JVMSerializationType != KNetSerialization.SerializationType.ByteBuffer
                                     : _JVMSerializationType != KNetSerialization.SerializationType.ByteArray))
            {
                throw new InvalidOperationException($"Serialization of {typeof(T).Name} can only be managed with TJVMT set to byte[].");
            }

            switch (_SerializationType)
            {
                case KNetSerialization.SerializationType.External:
                    if (IsDirectBuffered ? _JVMSerializationType != KNetSerialization.SerializationType.ByteBuffer
                                         : _JVMSerializationType != KNetSerialization.SerializationType.ByteArray)
                    {
                        throw new InvalidOperationException($"Serialization of {typeof(T).Name} can only be managed with TJVMT set to byte[] or Java.Lang.ByteBuffer.");
                    }
                    break;
                case KNetSerialization.SerializationType.Boolean:
                case KNetSerialization.SerializationType.ByteArray:
                case KNetSerialization.SerializationType.ByteBuffer:
                case KNetSerialization.SerializationType.Bytes:
                case KNetSerialization.SerializationType.Double:
                case KNetSerialization.SerializationType.Float:
                case KNetSerialization.SerializationType.Integer:
                case KNetSerialization.SerializationType.Long:
                case KNetSerialization.SerializationType.Short:
                case KNetSerialization.SerializationType.String:
                case KNetSerialization.SerializationType.Guid:
                case KNetSerialization.SerializationType.Void:
                    if (_JVMSerializationType != _SerializationType
                        && (IsDirectBuffered ? _JVMSerializationType != KNetSerialization.SerializationType.ByteBuffer
                                              : _JVMSerializationType != KNetSerialization.SerializationType.ByteArray))
                    {
                        throw new InvalidOperationException($"{typeof(T).Name} is incompatible with {typeof(TJVMT).Name}.");
                    }
                    break;
                default:
                    throw new InvalidOperationException($"{_SerializationType} is not valid.");
            }

            SerdeDirect<TJVMT> kSerde = null;

            if (IsDirectBuffered)
            {
                kSerde = new KNetSerdes.ByteBufferSerde().CastTo<SerdeDirect<TJVMT>>();
            }
            else
            {
                switch (_JVMSerializationType)
                {
                    case KNetSerialization.SerializationType.Boolean:
                        kSerde = new Serdes.BooleanSerde().CastTo<SerdeDirect<TJVMT>>();
                        break;
                    case KNetSerialization.SerializationType.ByteArray:
                        kSerde = new Serdes.ByteArraySerde().CastTo<SerdeDirect<TJVMT>>();
                        break;
                    case KNetSerialization.SerializationType.ByteBuffer:
                        kSerde = new Serdes.ByteBufferSerde().CastTo<SerdeDirect<TJVMT>>();
                        break;
                    case KNetSerialization.SerializationType.Bytes:
                        kSerde = new Serdes.BytesSerde().CastTo<SerdeDirect<TJVMT>>();
                        break;
                    case KNetSerialization.SerializationType.Double:
                        kSerde = new Serdes.DoubleSerde().CastTo<SerdeDirect<TJVMT>>();
                        break;
                    case KNetSerialization.SerializationType.Float:
                        kSerde = new Serdes.FloatSerde().CastTo<SerdeDirect<TJVMT>>();
                        break;
                    case KNetSerialization.SerializationType.Integer:
                        kSerde = new Serdes.IntegerSerde().CastTo<SerdeDirect<TJVMT>>();
                        break;
                    case KNetSerialization.SerializationType.Long:
                        kSerde = new Serdes.LongSerde().CastTo<SerdeDirect<TJVMT>>();
                        break;
                    case KNetSerialization.SerializationType.Short:
                        kSerde = new Serdes.ShortSerde().CastTo<SerdeDirect<TJVMT>>();
                        break;
                    case KNetSerialization.SerializationType.String:
                        kSerde = new Serdes.StringSerde().CastTo<SerdeDirect<TJVMT>>();
                        break;
                    case KNetSerialization.SerializationType.Guid:
                        kSerde = new Serdes.UUIDSerde().CastTo<SerdeDirect<TJVMT>>();
                        break;
                    case KNetSerialization.SerializationType.Void:
                        kSerde = new Serdes.VoidSerde().CastTo<SerdeDirect<TJVMT>>();
                        break;
                case KNetSerialization.SerializationType.External:
                default:
                    throw new InvalidOperationException($"{typeof(T)} needs an external serializer: set {nameof(OnSerialize)} or {nameof(OnSerializeWithHeaders)}.");
                }
            }

            _KafkaSerde = kSerde;
            _KafkaSerializer = kSerde.SerializerDirect();
            _KafkaDeserializer = kSerde.DeserializerDirect();
        }
        /// <summary>
        /// Finalizer
        /// </summary>
        ~SerDes()
        {
            Dispose();
        }
        /// <inheritdoc cref="IDisposable.Dispose"/>
        public void Dispose()
        {
            GC.SuppressFinalize(this);
            _KafkaSerde = null;
            _KafkaSerializer = null;
            _KafkaDeserializer = null;
        }
        #endregion

        #region IKNetSerDes<T>
        /// <summary>
        /// External serialization function
        /// </summary>
        public Func<string, T, TJVMT> OnSerialize { get; set; }
        /// <summary>
        /// External serialization function using <see cref="Headers"/>
        /// </summary>
        public Func<string, Headers, T, TJVMT> OnSerializeWithHeaders { get; set; }
        /// <summary>
        /// External deserialization function
        /// </summary>
        public Func<string, TJVMT, T> OnDeserialize { get; set; }
        /// <summary>
        /// External deserialization function using <see cref="Headers"/>
        /// </summary>
        public Func<string, Headers, TJVMT, T> OnDeserializeWithHeaders { get; set; }
        /// <inheritdoc cref="ISerDes{T, TJVMT}.KafkaSerde"/>
        public Serde<TJVMT> KafkaSerde => _KafkaSerde;
        /// <inheritdoc cref="ISerializer{T, TJVMT}.KafkaSerializer"/>
        public Serializer<TJVMT> KafkaSerializer => _KafkaSerializer;
        /// <inheritdoc cref="IDeserializer{T, TJVMT}.KafkaDeserializer"/>
        public Deserializer<TJVMT> KafkaDeserializer => _KafkaDeserializer;
        /// <inheritdoc cref="IDeserializer{T, TJVMT}.UseHeaders"/>
        public virtual bool UseHeaders { get; set; } = false;
        /// <inheritdoc cref="IDeserializer{T, TJVMT}.UseKafkaClassForSupportedTypes"/>
        public virtual bool UseKafkaClassForSupportedTypes { get; set; } = false;
        /// <inheritdoc cref="IDeserializer{T, TJVMT}.IsDirectBuffered"/>
        public virtual bool IsDirectBuffered => false;
        /// <inheritdoc cref="ISerializer{T, TJVMT}.Serialize(string, T)"/>
        public virtual TJVMT Serialize(string topic, T data)
        {
            if (OnSerialize != null)
            {
                return OnSerialize.Invoke(topic, data);
            }
            var newData = _SerializationType switch
            {
                KNetSerialization.SerializationType.Boolean => KNetSerialization.SerializeBoolean(UseKafkaClassForSupportedTypes, topic, (bool)Convert.ChangeType(data, typeof(bool))),
                KNetSerialization.SerializationType.ByteArray => KNetSerialization.SerializeByteArray(UseKafkaClassForSupportedTypes, topic, data as byte[]),
                KNetSerialization.SerializationType.ByteBuffer => KNetSerialization.SerializeByteBuffer(UseKafkaClassForSupportedTypes, topic, data as ByteBuffer),
                KNetSerialization.SerializationType.Bytes => KNetSerialization.SerializeBytes(UseKafkaClassForSupportedTypes, topic, data as Org.Apache.Kafka.Common.Utils.Bytes),
                KNetSerialization.SerializationType.Double => KNetSerialization.SerializeDouble(UseKafkaClassForSupportedTypes, topic, (double)Convert.ChangeType(data, typeof(double))),
                KNetSerialization.SerializationType.Float => KNetSerialization.SerializeFloat(UseKafkaClassForSupportedTypes, topic, (float)Convert.ChangeType(data, typeof(float))),
                KNetSerialization.SerializationType.Integer => KNetSerialization.SerializeInt(UseKafkaClassForSupportedTypes, topic, (int)Convert.ChangeType(data, typeof(int))),
                KNetSerialization.SerializationType.Long => KNetSerialization.SerializeLong(UseKafkaClassForSupportedTypes, topic, (long)Convert.ChangeType(data, typeof(long))),
                KNetSerialization.SerializationType.Short => KNetSerialization.SerializeShort(UseKafkaClassForSupportedTypes, topic, (short)Convert.ChangeType(data, typeof(short))),
                KNetSerialization.SerializationType.String => KNetSerialization.SerializeString(UseKafkaClassForSupportedTypes, topic, data as string),
                KNetSerialization.SerializationType.Guid => KNetSerialization.SerializeGuid(UseKafkaClassForSupportedTypes, topic, (Guid)Convert.ChangeType(data, typeof(Guid))),
                KNetSerialization.SerializationType.Void => KNetSerialization.SerializeVoid(UseKafkaClassForSupportedTypes, topic, data as Java.Lang.Void),
                KNetSerialization.SerializationType.External => throw new InvalidOperationException($"{typeof(T)} needs an external serializer: set {nameof(OnSerialize)} or {nameof(OnSerializeWithHeaders)}."),
                _ => default,
            };
            return (IsDirectBuffered && _JVMSerializationType == KNetSerialization.SerializationType.ByteBuffer) ? (TJVMT)(object)(Java.Nio.ByteBuffer)newData 
                                                                                                                 : (TJVMT)(object)newData;
        }
        /// <inheritdoc cref="ISerializer{T, TJVMT}.SerializeWithHeaders(string, Headers, T)"/>
        public virtual TJVMT SerializeWithHeaders(string topic, Headers headers, T data)
        {
            if (OnSerializeWithHeaders != null)
            {
                return OnSerializeWithHeaders.Invoke(topic, headers, data);
            }
            return Serialize(topic, data);
        }

        /// <inheritdoc cref="IDeserializer{T, TJVMT}.Deserialize(string, TJVMT)"/>
        public virtual T Deserialize(string topic, TJVMT data)
        {
            if (OnDeserialize != null)
            {
                return OnDeserialize.Invoke(topic, data);
            }
            byte[] newData = data as byte[];
            if (IsDirectBuffered && _JVMSerializationType == KNetSerialization.SerializationType.ByteBuffer && data is Java.Nio.ByteBuffer nioBuffer)
            {
                newData = nioBuffer.ToArray();
            }
            return _SerializationType switch
            {
                KNetSerialization.SerializationType.Boolean => (T)(object)KNetSerialization.DeserializeBoolean(UseKafkaClassForSupportedTypes, topic, newData),
                KNetSerialization.SerializationType.ByteArray => (T)(object)KNetSerialization.DeserializeByteArray(UseKafkaClassForSupportedTypes, topic, newData),
                KNetSerialization.SerializationType.ByteBuffer => (T)(object)KNetSerialization.DeserializeByteBuffer(UseKafkaClassForSupportedTypes, topic, newData),
                KNetSerialization.SerializationType.Bytes => (T)(object)KNetSerialization.DeserializeBytes(UseKafkaClassForSupportedTypes, topic, newData),
                KNetSerialization.SerializationType.Double => (T)(object)KNetSerialization.DeserializeDouble(UseKafkaClassForSupportedTypes, topic, newData),
                KNetSerialization.SerializationType.Float => (T)(object)KNetSerialization.DeserializeFloat(UseKafkaClassForSupportedTypes, topic, newData),
                KNetSerialization.SerializationType.Integer => (T)(object)KNetSerialization.DeserializeInt(UseKafkaClassForSupportedTypes, topic, newData),
                KNetSerialization.SerializationType.Long => (T)(object)KNetSerialization.DeserializeLong(UseKafkaClassForSupportedTypes, topic, newData),
                KNetSerialization.SerializationType.String => (T)(object)KNetSerialization.DeserializeString(UseKafkaClassForSupportedTypes, topic, newData),
                KNetSerialization.SerializationType.Guid => (T)(object)KNetSerialization.DeserializeGuid(UseKafkaClassForSupportedTypes, topic, newData),
                KNetSerialization.SerializationType.Void => (T)(object)KNetSerialization.DeserializeVoid(UseKafkaClassForSupportedTypes, topic, newData),
                KNetSerialization.SerializationType.External => throw new InvalidOperationException($"{typeof(T)} needs an external deserializer: set {nameof(OnDeserialize)} or {nameof(OnDeserializeWithHeaders)}."),
                _ => default,
            };
        }
        /// <inheritdoc cref="IDeserializer{T, TJVMT}.DeserializeWithHeaders(string, Headers, TJVMT)"/>
        public virtual T DeserializeWithHeaders(string topic, Headers headers, TJVMT data)
        {
            if (OnDeserializeWithHeaders != null)
            {
                return OnDeserializeWithHeaders.Invoke(topic, headers, data);
            }

            return Deserialize(topic, data);
        }
        #endregion
    }

    /// <summary>
    /// Common serializer/deserializer based on <see cref="byte"/> array
    /// </summary>
    /// <typeparam name="T">The <see cref="Type"/> to serialize/deserialize</typeparam>
    public interface ISerDesRaw<T> : ISerDes<T, byte[]>
    {
    }

    /// <summary>
    /// Common serializer/deserializer based on <see cref="byte"/> array
    /// </summary>
    /// <typeparam name="T">The <see cref="Type"/> to serialize/deserialize</typeparam>
    public class SerDesRaw<T> : SerDes<T, byte[]>, ISerDesRaw<T>
    {
    }

    /// <summary>
    /// Common serializer/deserializer based on <see cref="Java.Nio.ByteBuffer"/>
    /// </summary>
    /// <typeparam name="T">The <see cref="Type"/> to serialize/deserialize</typeparam>
    public interface ISerDesBuffered<T> : ISerDes<T, Java.Nio.ByteBuffer>
    {
    }

    /// <summary>
    /// Common serializer/deserializer based on <see cref="Java.Nio.ByteBuffer"/>
    /// </summary>
    /// <typeparam name="T">The <see cref="Type"/> to serialize/deserialize</typeparam>
    public class SerDesBuffered<T> : SerDes<T, Java.Nio.ByteBuffer>, ISerDesBuffered<T>
    {
        /// <inheritdoc/>
        public override bool IsDirectBuffered => true;
    }

    /// <summary>
    /// Sets of predefined <see cref="SerDes{T, TJVMT}"/> between specific types
    /// </summary>
    public static class SerDes
    {
        static SerDes<bool, Java.Lang.Boolean> _boolSerDes = null;
        /// <summary>
        /// <see cref="SerDes{T, TJVMT}"/> between <see cref="bool"/> and <see cref="Java.Lang.Boolean"/>
        /// </summary>
        public static SerDes<bool, Java.Lang.Boolean> Bool => _boolSerDes ?? new SerDes<bool, Java.Lang.Boolean>();

        static SerDes<short, Java.Lang.Short> _shortSerDes = null;
        /// <summary>
        /// <see cref="SerDes{T, TJVMT}"/> between <see cref="short"/> and <see cref="Java.Lang.Short"/>
        /// </summary>
        public static SerDes<short, Java.Lang.Short> Short => _shortSerDes ?? new SerDes<short, Java.Lang.Short>();

        static SerDes<int, Java.Lang.Integer> _intSerDes = null;
        /// <summary>
        /// <see cref="SerDes{T, TJVMT}"/> between <see cref="int"/> and <see cref="Java.Lang.Integer"/>
        /// </summary>
        public static SerDes<int, Java.Lang.Integer> Integer => _intSerDes ?? new SerDes<int, Java.Lang.Integer>();

        static SerDes<long, Java.Lang.Long> _longSerDes = null;
        /// <summary>
        /// <see cref="SerDes{T, TJVMT}"/> between <see cref="long"/> and <see cref="Java.Lang.Long"/>
        /// </summary>
        public static SerDes<long, Java.Lang.Long> Long => _longSerDes ?? new SerDes<long, Java.Lang.Long>();

        static SerDes<float, Java.Lang.Float> _floatSerDes = null;
        /// <summary>
        /// <see cref="SerDes{T, TJVMT}"/> between <see cref="float"/> and <see cref="Java.Lang.Float"/>
        /// </summary>
        public static SerDes<float, Java.Lang.Float> Float => _floatSerDes ?? new SerDes<float, Java.Lang.Float>();

        static SerDes<double, Java.Lang.Double> _doubleSerDes = null;
        /// <summary>
        /// <see cref="SerDes{T, TJVMT}"/> between <see cref="double"/> and <see cref="Java.Lang.Double"/>
        /// </summary>
        public static SerDes<double, Java.Lang.Double> Double => _doubleSerDes ?? new SerDes<double, Java.Lang.Double>();

        static SerDes<string, byte[]> _stringSerDes = null;
        /// <summary>
        /// <see cref="SerDes{T, TJVMT}"/> between <see cref="string"/> and <see cref="byte"/> array
        /// </summary>
        public static SerDes<string, byte[]> String => _stringSerDes ?? new SerDes<string, byte[]>();

        static SerDes<Guid, Java.Util.UUID> _GuidSerDes = null;
        /// <summary>
        /// <see cref="SerDes{T, TJVMT}"/> between <see cref="Guid"/> and <see cref="Java.Util.UUID"/>
        /// </summary>
        public static SerDes<Guid, Java.Util.UUID> Guid => _GuidSerDes ?? new SerDes<Guid, Java.Util.UUID>();

        static SerDes<object, Java.Lang.Void> _voidSerDes = null;
        /// <summary>
        /// <see cref="SerDes{T, TJVMT}"/> between <see cref="object"/> and <see cref="Java.Lang.Void"/>
        /// </summary>
        public static SerDes<object, Java.Lang.Void> Void => _voidSerDes ?? new SerDes<object, Java.Lang.Void>();
    }
}
