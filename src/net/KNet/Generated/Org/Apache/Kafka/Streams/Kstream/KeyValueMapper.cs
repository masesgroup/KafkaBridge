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
*  using kafka-streams-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Kstream
{
    #region KeyValueMapper
    public partial class KeyValueMapper
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// Handlers initializer for <see cref="KeyValueMapper"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("apply", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<object>>>(ApplyEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/KeyValueMapper.html#apply-java.lang.Object-java.lang.Object-"/>
        /// </summary>
        /// <remarks>If <see cref="OnApply"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<object, object, object> OnApply { get; set; } = null;

        void ApplyEventHandler(object sender, CLRListenerEventArgs<CLREventData<object>> data)
        {
            var methodToExecute = (OnApply != null) ? OnApply : Apply;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<object>(0));
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/KeyValueMapper.html#apply-java.lang.Object-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public virtual object Apply(object arg0, object arg1)
        {
            return default;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region KeyValueMapperDirect
    public partial class KeyValueMapperDirect
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/KeyValueMapper.html#apply-java.lang.Object-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public override object Apply(object arg0, object arg1)
        {
            return IExecute("apply", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IKeyValueMapper<K, V, VR>
    /// <summary>
    /// .NET interface for org.mases.knet.generated.org.apache.kafka.streams.kstream.KeyValueMapper implementing <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/KeyValueMapper.html"/>
    /// </summary>
    public partial interface IKeyValueMapper<K, V, VR>
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region KeyValueMapper<K, V, VR>
    public partial class KeyValueMapper<K, V, VR> : Org.Apache.Kafka.Streams.Kstream.IKeyValueMapper<K, V, VR>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// Handlers initializer for <see cref="KeyValueMapper"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("apply", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<K>>>(ApplyEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/KeyValueMapper.html#apply-java.lang.Object-java.lang.Object-"/>
        /// </summary>
        /// <remarks>If <see cref="OnApply"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<K, V, VR> OnApply { get; set; } = null;

        void ApplyEventHandler(object sender, CLRListenerEventArgs<CLREventData<K>> data)
        {
            var methodToExecute = (OnApply != null) ? OnApply : Apply;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<V>(0));
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/KeyValueMapper.html#apply-java.lang.Object-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        /// <returns><typeparamref name="VR"/></returns>
        public virtual VR Apply(K arg0, V arg1)
        {
            return default;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region KeyValueMapperDirect<K, V, VR>
    public partial class KeyValueMapperDirect<K, V, VR> : Org.Apache.Kafka.Streams.Kstream.IKeyValueMapper<K, V, VR>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/KeyValueMapper.html#apply-java.lang.Object-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        /// <returns><typeparamref name="VR"/></returns>
        public override VR Apply(K arg0, V arg1)
        {
            return IExecute<VR>("apply", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}