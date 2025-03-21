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

using MASES.JCOBridge.C2JBridge;
using MASES.JCOBridge.C2JBridge.JVMInterop;
using MASES.KNet.Serialization;
using System;

namespace MASES.KNet.Streams
{
    #region KeyValue<K, V>
    /// <summary>
    /// Support class for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/KeyValue.html#org.apache.kafka.streams.KeyValue"/>
    /// </summary>
    public partial class KeyValueSupport<K, V> : MASES.JCOBridge.C2JBridge.JVMBridgeBase<KeyValueSupport<K, V>>
    {
        #region Constructors
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public KeyValueSupport() { }
        /// <summary>
        /// Initialize a new instance of <see cref="KeyValueSupport{K, V}"/> from an instance of <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/KeyValue.html#org.apache.kafka.streams.KeyValue(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="obj">The <see cref="IJavaObject"/> referring <see cref="Org.Apache.Kafka.Streams.KeyValue{K, V}"/></param>
        public KeyValueSupport(IJavaObject obj)
            : base(obj)
        {
        }

        #endregion

        const string _bridgeClassName = "org.mases.knet.developed.streams.KeyValueSupport";

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        #region Static methods
        /// <summary>
        /// Convert the <paramref name="kvs"/> into an instance of <see cref="Org.Apache.Kafka.Streams.KeyValue{K, V}"/>
        /// </summary>
        /// <param name="kvs">An instance of <see cref="KeyValueSupport{K, V}"/></param>
        /// <returns>An instance of <see cref="Org.Apache.Kafka.Streams.KeyValue{K, V}"/></returns>
        public static Org.Apache.Kafka.Streams.KeyValue<K, V> ToKeyValue(KeyValueSupport<K, V> kvs) => SExecute<Org.Apache.Kafka.Streams.KeyValue<K, V>>("toKeyValue", kvs);

        #endregion

        #region Instance methods
        /// <summary>
        /// The value of the field <see cref="Org.Apache.Kafka.Streams.KeyValue{K, V}.key"/>
        /// </summary>
        public K Key => IExecute<K>("getKey");
        /// <summary>
        /// The value of the field <see cref="Org.Apache.Kafka.Streams.KeyValue{K, V}.value"/>
        /// </summary>
        public V Value => IExecute<V>("getValue");

        /// <summary>
        /// Convert this instance into an instance of <see cref="Org.Apache.Kafka.Streams.KeyValue{K, V}"/>
        /// </summary>
        /// <returns>An instance of <see cref="Org.Apache.Kafka.Streams.KeyValue{K, V}"/></returns>
        public Org.Apache.Kafka.Streams.KeyValue<K, V> ToKeyValue() => ToKeyValue(this);

        #endregion

        // TODO: complete the class
    }
    #endregion
}
