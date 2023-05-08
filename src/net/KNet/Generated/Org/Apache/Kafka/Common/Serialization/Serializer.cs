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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using kafka-clients-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Serialization
{
    #region Serializer
    public partial class Serializer
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
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/serialization/Serializer.html#serialize(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] Serialize(string arg0, object arg1)
        {
            return IExecuteArray<byte>("serialize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/serialization/Serializer.html#serialize(java.lang.String,org.apache.kafka.common.header.Headers,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Header.Headers"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] Serialize(string arg0, Org.Apache.Kafka.Common.Header.Headers arg1, object arg2)
        {
            return IExecuteArray<byte>("serialize", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/serialization/Serializer.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/serialization/Serializer.html#configure(java.util.Map,boolean)"/>
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

    #region Serializer<T>
    public partial class Serializer<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Common.Serialization.Serializer{T}"/> to <see cref="Org.Apache.Kafka.Common.Serialization.Serializer"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Serialization.Serializer(Org.Apache.Kafka.Common.Serialization.Serializer<T> t) => t.Cast<Org.Apache.Kafka.Common.Serialization.Serializer>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/serialization/Serializer.html#serialize(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><typeparamref name="T"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] Serialize(string arg0, T arg1)
        {
            return IExecuteArray<byte>("serialize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/serialization/Serializer.html#serialize(java.lang.String,org.apache.kafka.common.header.Headers,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Header.Headers"/></param>
        /// <param name="arg2"><typeparamref name="T"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] Serialize(string arg0, Org.Apache.Kafka.Common.Header.Headers arg1, T arg2)
        {
            return IExecuteArray<byte>("serialize", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/serialization/Serializer.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/serialization/Serializer.html#configure(java.util.Map,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <typeparam name="Arg0Extendsobject"></typeparam>
        public void Configure<Arg0Extendsobject>(Java.Util.Map<string, Arg0Extendsobject> arg0, bool arg1)
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