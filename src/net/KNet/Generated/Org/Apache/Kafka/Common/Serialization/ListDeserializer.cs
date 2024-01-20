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
*  This file is generated by MASES.JNetReflector (ver. 2.2.1.0)
*  using kafka-clients-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Serialization
{
    #region ListDeserializer
    public partial class ListDeserializer
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/serialization/ListDeserializer.html#org.apache.kafka.common.serialization.ListDeserializer(java.lang.Class,org.apache.kafka.common.serialization.Deserializer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Serialization.Deserializer"/></param>
        public ListDeserializer(Java.Lang.Class arg0, Org.Apache.Kafka.Common.Serialization.Deserializer arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Common.Serialization.ListDeserializer"/> to <see cref="Org.Apache.Kafka.Common.Serialization.Deserializer"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Serialization.Deserializer(Org.Apache.Kafka.Common.Serialization.ListDeserializer t) => t.Cast<Org.Apache.Kafka.Common.Serialization.Deserializer>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/serialization/ListDeserializer.html#deserialize-java.lang.String-byte[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <returns><see cref="object"/></returns>
        public object Deserialize(string arg0, byte[] arg1)
        {
            return IExecute("deserialize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/serialization/ListDeserializer.html#innerDeserializer--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Deserializer"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Deserializer InnerDeserializer()
        {
            return IExecute<Org.Apache.Kafka.Common.Serialization.Deserializer>("innerDeserializer");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/serialization/ListDeserializer.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/serialization/ListDeserializer.html#configure-java.util.Map-boolean-"/>
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

    #region ListDeserializer<Inner>
    public partial class ListDeserializer<Inner>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/serialization/ListDeserializer.html#org.apache.kafka.common.serialization.ListDeserializer(java.lang.Class,org.apache.kafka.common.serialization.Deserializer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Serialization.Deserializer"/></param>
        public ListDeserializer(Java.Lang.Class arg0, Org.Apache.Kafka.Common.Serialization.Deserializer<Inner> arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Common.Serialization.ListDeserializer{Inner}"/> to <see cref="Org.Apache.Kafka.Common.Serialization.Deserializer"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Serialization.Deserializer(Org.Apache.Kafka.Common.Serialization.ListDeserializer<Inner> t) => t.Cast<Org.Apache.Kafka.Common.Serialization.Deserializer>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Common.Serialization.ListDeserializer{Inner}"/> to <see cref="Org.Apache.Kafka.Common.Serialization.ListDeserializer"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Serialization.ListDeserializer(Org.Apache.Kafka.Common.Serialization.ListDeserializer<Inner> t) => t.Cast<Org.Apache.Kafka.Common.Serialization.ListDeserializer>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/serialization/ListDeserializer.html#deserialize-java.lang.String-byte[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <returns><see cref="object"/></returns>
        public object Deserialize(string arg0, byte[] arg1)
        {
            return IExecute("deserialize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/serialization/ListDeserializer.html#innerDeserializer--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Serialization.Deserializer"/></returns>
        public Org.Apache.Kafka.Common.Serialization.Deserializer<Inner> InnerDeserializer()
        {
            return IExecute<Org.Apache.Kafka.Common.Serialization.Deserializer<Inner>>("innerDeserializer");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/serialization/ListDeserializer.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/serialization/ListDeserializer.html#configure-java.util.Map-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void Configure(Java.Util.Map<string, object> arg0, bool arg1)
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