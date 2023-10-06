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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using kafka-clients-3.6.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Serialization
{
    #region ListSerializer
    public partial class ListSerializer
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/serialization/ListSerializer.html#org.apache.kafka.common.serialization.ListSerializer(org.apache.kafka.common.serialization.Serializer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serializer"/></param>
        public ListSerializer(Org.Apache.Kafka.Common.Serialization.Serializer arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Common.Serialization.ListSerializer"/> to <see cref="Org.Apache.Kafka.Common.Serialization.Serializer"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Serialization.Serializer(Org.Apache.Kafka.Common.Serialization.ListSerializer t) => t.Cast<Org.Apache.Kafka.Common.Serialization.Serializer>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/serialization/ListSerializer.html#getInnerSerializer--"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.Serialization.Serializer InnerSerializer
        {
            get { return IExecute<Org.Apache.Kafka.Common.Serialization.Serializer>("getInnerSerializer"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/serialization/ListSerializer.html#serialize-java.lang.String-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] Serialize(string arg0, object arg1)
        {
            return IExecuteArray<byte>("serialize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/serialization/ListSerializer.html#serialize-java.lang.String-java.util.List-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] Serialize(string arg0, Java.Util.List arg1)
        {
            return IExecuteArray<byte>("serialize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/serialization/ListSerializer.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/serialization/ListSerializer.html#configure-java.util.Map-boolean-"/>
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

    #region ListSerializer<Inner>
    public partial class ListSerializer<Inner>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/serialization/ListSerializer.html#org.apache.kafka.common.serialization.ListSerializer(org.apache.kafka.common.serialization.Serializer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Serialization.Serializer"/></param>
        public ListSerializer(Org.Apache.Kafka.Common.Serialization.Serializer<Inner> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Common.Serialization.ListSerializer{Inner}"/> to <see cref="Org.Apache.Kafka.Common.Serialization.Serializer"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Serialization.Serializer(Org.Apache.Kafka.Common.Serialization.ListSerializer<Inner> t) => t.Cast<Org.Apache.Kafka.Common.Serialization.Serializer>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Common.Serialization.ListSerializer{Inner}"/> to <see cref="Org.Apache.Kafka.Common.Serialization.ListSerializer"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Serialization.ListSerializer(Org.Apache.Kafka.Common.Serialization.ListSerializer<Inner> t) => t.Cast<Org.Apache.Kafka.Common.Serialization.ListSerializer>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/serialization/ListSerializer.html#getInnerSerializer--"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.Serialization.Serializer<Inner> InnerSerializer
        {
            get { return IExecute<Org.Apache.Kafka.Common.Serialization.Serializer<Inner>>("getInnerSerializer"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/serialization/ListSerializer.html#serialize-java.lang.String-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] Serialize(string arg0, object arg1)
        {
            return IExecuteArray<byte>("serialize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/serialization/ListSerializer.html#serialize-java.lang.String-java.util.List-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] Serialize(string arg0, Java.Util.List<Inner> arg1)
        {
            return IExecuteArray<byte>("serialize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/serialization/ListSerializer.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/serialization/ListSerializer.html#configure-java.util.Map-boolean-"/>
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