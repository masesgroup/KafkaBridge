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
    #region SessionWindowedSerializer
    public partial class SessionWindowedSerializer
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/SessionWindowedSerializer.html#org.apache.kafka.streams.kstream.SessionWindowedSerializer(org.apache.kafka.common.serialization.Serializer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serializer"/></param>
        public SessionWindowedSerializer(Org.Apache.Kafka.Common.Serialization.Serializer arg0)
            : base(arg0)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/SessionWindowedSerializer.html#serialize-java.lang.String-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] Serialize(Java.Lang.String arg0, object arg1)
        {
            return IExecuteArray<byte>("serialize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/SessionWindowedSerializer.html#serialize-java.lang.String-org.apache.kafka.streams.kstream.Windowed-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Windowed"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] Serialize(Java.Lang.String arg0, Org.Apache.Kafka.Streams.Kstream.Windowed arg1)
        {
            return IExecuteArray<byte>("serialize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/SessionWindowedSerializer.html#serializeBaseKey-java.lang.String-org.apache.kafka.streams.kstream.Windowed-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Windowed"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] SerializeBaseKey(Java.Lang.String arg0, Org.Apache.Kafka.Streams.Kstream.Windowed arg1)
        {
            return IExecuteArray<byte>("serializeBaseKey", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/SessionWindowedSerializer.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/SessionWindowedSerializer.html#configure-java.util.Map-boolean-"/>
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

    #region SessionWindowedSerializer<T>
    public partial class SessionWindowedSerializer<T>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/SessionWindowedSerializer.html#org.apache.kafka.streams.kstream.SessionWindowedSerializer(org.apache.kafka.common.serialization.Serializer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serializer"/></param>
        public SessionWindowedSerializer(Org.Apache.Kafka.Common.Serialization.Serializer<T> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Kstream.SessionWindowedSerializer{T}"/> to <see cref="Org.Apache.Kafka.Streams.Kstream.SessionWindowedSerializer"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Kstream.SessionWindowedSerializer(Org.Apache.Kafka.Streams.Kstream.SessionWindowedSerializer<T> t) => t.Cast<Org.Apache.Kafka.Streams.Kstream.SessionWindowedSerializer>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/SessionWindowedSerializer.html#serialize-java.lang.String-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] Serialize(Java.Lang.String arg0, object arg1)
        {
            return IExecuteArray<byte>("serialize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/SessionWindowedSerializer.html#serialize-java.lang.String-org.apache.kafka.streams.kstream.Windowed-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Windowed"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] Serialize(Java.Lang.String arg0, Org.Apache.Kafka.Streams.Kstream.Windowed<T> arg1)
        {
            return IExecuteArray<byte>("serialize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/SessionWindowedSerializer.html#serializeBaseKey-java.lang.String-org.apache.kafka.streams.kstream.Windowed-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Windowed"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] SerializeBaseKey(Java.Lang.String arg0, Org.Apache.Kafka.Streams.Kstream.Windowed<T> arg1)
        {
            return IExecuteArray<byte>("serializeBaseKey", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/SessionWindowedSerializer.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/SessionWindowedSerializer.html#configure-java.util.Map-boolean-"/>
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