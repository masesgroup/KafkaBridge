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

namespace Org.Apache.Kafka.Streams.State
{
    #region ValueAndTimestamp
    public partial class ValueAndTimestamp
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/state/ValueAndTimestamp.html#make-java.lang.Object-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.ValueAndTimestamp"/></returns>
        public static Org.Apache.Kafka.Streams.State.ValueAndTimestamp Make(object arg0, long arg1)
        {
            return SExecute<Org.Apache.Kafka.Streams.State.ValueAndTimestamp>(LocalBridgeClazz, "make", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/state/ValueAndTimestamp.html#makeAllowNullable-java.lang.Object-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.ValueAndTimestamp"/></returns>
        public static Org.Apache.Kafka.Streams.State.ValueAndTimestamp MakeAllowNullable(object arg0, long arg1)
        {
            return SExecute<Org.Apache.Kafka.Streams.State.ValueAndTimestamp>(LocalBridgeClazz, "makeAllowNullable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/state/ValueAndTimestamp.html#getValueOrNull-org.apache.kafka.streams.state.ValueAndTimestamp-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.State.ValueAndTimestamp"/></param>
        /// <returns><see cref="object"/></returns>
        public static object GetValueOrNull(Org.Apache.Kafka.Streams.State.ValueAndTimestamp arg0)
        {
            return SExecute(LocalBridgeClazz, "getValueOrNull", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/state/ValueAndTimestamp.html#timestamp--"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long Timestamp()
        {
            return IExecute<long>("timestamp");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/state/ValueAndTimestamp.html#value--"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object Value()
        {
            return IExecute("value");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ValueAndTimestamp<V>
    public partial class ValueAndTimestamp<V>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.State.ValueAndTimestamp{V}"/> to <see cref="Org.Apache.Kafka.Streams.State.ValueAndTimestamp"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.State.ValueAndTimestamp(Org.Apache.Kafka.Streams.State.ValueAndTimestamp<V> t) => t.Cast<Org.Apache.Kafka.Streams.State.ValueAndTimestamp>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/state/ValueAndTimestamp.html#make-java.lang.Object-long-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="V"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.ValueAndTimestamp"/></returns>
        public static Org.Apache.Kafka.Streams.State.ValueAndTimestamp<V> Make(V arg0, long arg1)
        {
            return SExecute<Org.Apache.Kafka.Streams.State.ValueAndTimestamp<V>>(LocalBridgeClazz, "make", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/state/ValueAndTimestamp.html#makeAllowNullable-java.lang.Object-long-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="V"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.ValueAndTimestamp"/></returns>
        public static Org.Apache.Kafka.Streams.State.ValueAndTimestamp<V> MakeAllowNullable(V arg0, long arg1)
        {
            return SExecute<Org.Apache.Kafka.Streams.State.ValueAndTimestamp<V>>(LocalBridgeClazz, "makeAllowNullable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/state/ValueAndTimestamp.html#getValueOrNull-org.apache.kafka.streams.state.ValueAndTimestamp-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.State.ValueAndTimestamp"/></param>
        /// <returns><typeparamref name="V"/></returns>
        public static V GetValueOrNull(Org.Apache.Kafka.Streams.State.ValueAndTimestamp<V> arg0)
        {
            return SExecute<V>(LocalBridgeClazz, "getValueOrNull", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/state/ValueAndTimestamp.html#timestamp--"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long Timestamp()
        {
            return IExecute<long>("timestamp");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/state/ValueAndTimestamp.html#value--"/>
        /// </summary>

        /// <returns><typeparamref name="V"/></returns>
        public V Value()
        {
            return IExecute<V>("value");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}