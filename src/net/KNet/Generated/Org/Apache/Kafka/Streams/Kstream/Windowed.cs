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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using kafka-streams-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Kstream
{
    #region Windowed
    public partial class Windowed
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/Windowed.html#org.apache.kafka.streams.kstream.Windowed(java.lang.Object,org.apache.kafka.streams.kstream.Window)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Window"/></param>
        public Windowed(object arg0, Org.Apache.Kafka.Streams.Kstream.Window arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/Windowed.html#key--"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object Key()
        {
            return IExecute("key");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/Windowed.html#window--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Window"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.Window Window()
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.Window>("window");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Windowed<K>
    public partial class Windowed<K>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/Windowed.html#org.apache.kafka.streams.kstream.Windowed(java.lang.Object,org.apache.kafka.streams.kstream.Window)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Window"/></param>
        public Windowed(K arg0, Org.Apache.Kafka.Streams.Kstream.Window arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Kstream.Windowed{K}"/> to <see cref="Org.Apache.Kafka.Streams.Kstream.Windowed"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Kstream.Windowed(Org.Apache.Kafka.Streams.Kstream.Windowed<K> t) => t.Cast<Org.Apache.Kafka.Streams.Kstream.Windowed>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/Windowed.html#key--"/>
        /// </summary>

        /// <returns><typeparamref name="K"/></returns>
        public K Key()
        {
            return IExecute<K>("key");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/kstream/Windowed.html#window--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Window"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.Window Window()
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.Window>("window");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}