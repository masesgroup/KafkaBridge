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
*  using kafka-streams-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Kstream
{
    #region Printed
    public partial class Printed
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/Printed.html#toFile(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Printed"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Printed ToFile(string arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Printed>(LocalBridgeClazz, "toFile", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/Printed.html#toSysOut()"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Printed"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Printed ToSysOut()
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Printed>(LocalBridgeClazz, "toSysOut");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/Printed.html#withKeyValueMapper(org.apache.kafka.streams.kstream.KeyValueMapper)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.KeyValueMapper"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Printed"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.Printed WithKeyValueMapper(Org.Apache.Kafka.Streams.Kstream.KeyValueMapper arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.Printed>("withKeyValueMapper", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/Printed.html#withLabel(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Printed"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.Printed WithLabel(string arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.Printed>("withLabel", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Printed<K, V>
    public partial class Printed<K, V>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Kstream.Printed{K, V}"/> to <see cref="Org.Apache.Kafka.Streams.Kstream.Printed"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Kstream.Printed(Org.Apache.Kafka.Streams.Kstream.Printed<K, V> t) => t.Cast<Org.Apache.Kafka.Streams.Kstream.Printed>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/Printed.html#toFile(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Printed"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Printed<K, V> ToFile(string arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Printed<K, V>>(LocalBridgeClazz, "toFile", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/Printed.html#toSysOut()"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Printed"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.Printed<K, V> ToSysOut()
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.Printed<K, V>>(LocalBridgeClazz, "toSysOut");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/Printed.html#withKeyValueMapper(org.apache.kafka.streams.kstream.KeyValueMapper)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.KeyValueMapper"/></param>
        /// <typeparam name="Arg0objectSuperK"><typeparamref name="K"/></typeparam>
        /// <typeparam name="Arg0objectSuperV"><typeparamref name="V"/></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Printed"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.Printed<K, V> WithKeyValueMapper<Arg0objectSuperK, Arg0objectSuperV>(Org.Apache.Kafka.Streams.Kstream.KeyValueMapper<Arg0objectSuperK, Arg0objectSuperV, string> arg0) where Arg0objectSuperK: K where Arg0objectSuperV: V
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.Printed<K, V>>("withKeyValueMapper", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/Printed.html#withLabel(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.Printed"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.Printed<K, V> WithLabel(string arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.Printed<K, V>>("withLabel", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}