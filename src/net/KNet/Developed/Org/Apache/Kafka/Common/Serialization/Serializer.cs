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

using MASES.JCOBridge.C2JBridge;
using MASES.JCOBridge.C2JBridge.JVMInterop;
using Org.Apache.Kafka.Common.Header;
using System;

namespace Org.Apache.Kafka.Common.Serialization
{
    /// <summary>
    /// Listener for Kafka Serializer. Extends <see cref="IJVMBridgeBase"/>
    /// </summary>
    /// <typeparam name="E">The data associated to the event</typeparam>
    public partial interface ISerializer : IJVMBridgeBase
    {
    }

    /// <summary>
    /// Listener for Kafka Serializer. Extends <see cref="Serializer"/>
    /// </summary>
    /// <typeparam name="T">The data associated to the event</typeparam>
    public partial interface ISerializer<T> : ISerializer
    {
        /// <summary>
        /// Executes the Serializer action in the CLR
        /// </summary>
        /// <param name="topic">topic associated with the data</param>
        /// <param name="data"><typeparamref name="E"/> data</param>
        /// <returns>serialized bytes</returns>
        byte[] Serialize(string topic, T data);
        /// <summary>
        /// Executes the Serializer action in the CLR
        /// </summary>
        /// <param name="topic">topic associated with the data</param>
        /// <param name="headers"><see cref="Headers"/> associated with the record; may be empty.</param>
        /// <param name="data"><typeparamref name="T"/> data</param>
        /// <returns>serialized bytes</returns>
        byte[] SerializeWithHeaders(string topic, Headers headers, T data);
    }
    /// <summary>
    /// Listener for Kafka Serializer. Extends <see cref="JVMBridgeListener"/>. Implements <see cref="ISerializer{T}"/>
    /// </summary>
    /// <typeparam name="E">The data associated to the event</typeparam>
    /// <remarks>Dispose the object to avoid a resource leak, the object contains a reference to the corresponding JVM object</remarks>
    public partial class Serializer<T> : ISerializer<T>
    {
        /// <inheritdoc cref="JVMBridgeListener.ClassName"/>
        public override string BridgeClassName => "org.mases.knet.clients.common.serialization.SerializerImpl";

        readonly Func<string, T, byte[]> serialize = null;
        readonly Func<string, Headers, T, byte[]> serializeWithHeaders = null;
        /// <summary>
        /// The <see cref="Func{String, T, Byte[]}"/> to be executed on serialize
        /// </summary>
        public virtual Func<string, T, byte[]> OnSerialize { get { return serialize; } }
        /// <summary>
        /// The <see cref="Func{String, Headers, T, Byte[]}"/> to be executed on serialize
        /// </summary>
        public virtual Func<string, Headers, T, byte[]> OnSerializeWithHeaders { get { return serializeWithHeaders; } }
        /// <summary>
        /// Initialize a new instance of <see cref="Serializer{T}"/>
        /// </summary>
        /// <param name="serializeFun">The <see cref="Func{String, T, Byte[]}"/> to be executed on serialize</param>
        /// <param name="serializeWithHeadersFun">The <see cref="Func{String, Headers, T, Byte[]}"/> to be executed on serialize</param>
        /// <param name="attachEventHandler">Set to false to disable attach of <see cref="EventHandler"/> and set an own one</param>
        public Serializer(Func<string, T, byte[]> serializeFun = null, Func<string, Headers, T, byte[]> serializeWithHeadersFun = null, bool attachEventHandler = true)
        {
            if (serializeFun != null) serialize = serializeFun;
            else serialize = Serialize;
            if (serializeWithHeadersFun != null) serializeWithHeaders = serializeWithHeadersFun;
            else serializeWithHeaders = SerializeWithHeaders;

            if (attachEventHandler)
            {
                AddEventHandler("serialize", new EventHandler<CLRListenerEventArgs<CLREventData<string>>>(EventHandler));
                AddEventHandler("serializeWithHeaders", new EventHandler<CLRListenerEventArgs<CLREventData<string>>>(EventHandlerWithHeaders));
            }
        }

        void EventHandler(object sender, CLRListenerEventArgs<CLREventData<string>> eventData)
        {
            var data = eventData.EventData.ExtraData.Get(0);
            var retVal = OnSerialize(eventData.EventData.TypedEventData, data.Convert<T>());
            eventData.SetReturnValue(retVal);
        }

        void EventHandlerWithHeaders(object sender, CLRListenerEventArgs<CLREventData<string>> eventData)
        {
            var headers = eventData.EventData.ExtraData.Get(0) as IJavaObject; // it is a Headers
            var data = eventData.EventData.ExtraData.Get(1);
            var retVal = OnSerializeWithHeaders(eventData.EventData.TypedEventData, JVMBridgeBase.Wraps<Headers>(headers), data.Convert<T>());
            eventData.SetReturnValue(retVal);
        }

        /// <summary>
        /// Executes the Serializer action in the CLR
        /// </summary>
        /// <param name="topic">topic associated with the data</param>
        /// <param name="headers"><see cref="Headers"/> associated with the record; may be empty.</param>
        /// <param name="data"><typeparamref name="T"/> data</param>
        /// <returns>serialized bytes</returns>
        public virtual byte[] SerializeWithHeaders(string topic, Headers headers, T data) { return null; }
    }
}
