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

namespace Org.Apache.Kafka.Streams.Kstream
{
    #region SessionWindowedDeserializer
    public partial class SessionWindowedDeserializer
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/kstream/SessionWindowedDeserializer.html#org.apache.kafka.streams.kstream.SessionWindowedDeserializer(org.apache.kafka.common.serialization.Deserializer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Deserializer"/></param>
        public SessionWindowedDeserializer(Org.Apache.Kafka.Common.Serialization.Deserializer arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Kstream.SessionWindowedDeserializer"/> to <see cref="Org.Apache.Kafka.Common.Serialization.Deserializer"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Serialization.Deserializer(Org.Apache.Kafka.Streams.Kstream.SessionWindowedDeserializer t) => t.Cast<Org.Apache.Kafka.Common.Serialization.Deserializer>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/kstream/SessionWindowedDeserializer.html#deserialize-java.lang.String-byte[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <returns><see cref="object"/></returns>
        public object Deserialize(Java.Lang.String arg0, byte[] arg1)
        {
            return IExecute("deserialize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/kstream/SessionWindowedDeserializer.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/kstream/SessionWindowedDeserializer.html#configure-java.util.Map-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void Configure(Java.Util.Map arg0, bool arg1)
        {
            IExecute("configure", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SessionWindowedDeserializer<T>
    public partial class SessionWindowedDeserializer<T>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/kstream/SessionWindowedDeserializer.html#org.apache.kafka.streams.kstream.SessionWindowedDeserializer(org.apache.kafka.common.serialization.Deserializer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Deserializer"/></param>
        public SessionWindowedDeserializer(Org.Apache.Kafka.Common.Serialization.Deserializer<T> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Kstream.SessionWindowedDeserializer{T}"/> to <see cref="Org.Apache.Kafka.Common.Serialization.Deserializer{T}"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Serialization.Deserializer<T>(Org.Apache.Kafka.Streams.Kstream.SessionWindowedDeserializer<T> t) => t.Cast<Org.Apache.Kafka.Common.Serialization.Deserializer<T>>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Kstream.SessionWindowedDeserializer{T}"/> to <see cref="Org.Apache.Kafka.Streams.Kstream.SessionWindowedDeserializer"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Kstream.SessionWindowedDeserializer(Org.Apache.Kafka.Streams.Kstream.SessionWindowedDeserializer<T> t) => t.Cast<Org.Apache.Kafka.Streams.Kstream.SessionWindowedDeserializer>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/kstream/SessionWindowedDeserializer.html#deserialize-java.lang.String-byte[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <returns><see cref="object"/></returns>
        public object Deserialize(Java.Lang.String arg0, byte[] arg1)
        {
            return IExecute("deserialize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/kstream/SessionWindowedDeserializer.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/kstream/SessionWindowedDeserializer.html#configure-java.util.Map-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void Configure(Java.Util.Map<Java.Lang.String, object> arg0, bool arg1)
        {
            IExecute("configure", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}