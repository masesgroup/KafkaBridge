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
*  This file is generated by MASES.JNetReflector (ver. 2.1.0.0)
*  using connect-runtime-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Converters
{
    #region ByteArrayConverter
    public partial class ByteArrayConverter : Org.Apache.Kafka.Connect.Components.IVersioned
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Converters.ByteArrayConverter"/> to <see cref="Org.Apache.Kafka.Connect.Components.Versioned"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Connect.Components.Versioned(Org.Apache.Kafka.Connect.Converters.ByteArrayConverter t) => t.Cast<Org.Apache.Kafka.Connect.Components.Versioned>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.6.1/org/apache/kafka/connect/converters/ByteArrayConverter.html#fromConnectData-java.lang.String-org.apache.kafka.connect.data.Schema-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] FromConnectData(string arg0, Org.Apache.Kafka.Connect.Data.Schema arg1, object arg2)
        {
            return IExecuteArray<byte>("fromConnectData", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.6.1/org/apache/kafka/connect/converters/ByteArrayConverter.html#fromConnectHeader-java.lang.String-java.lang.String-org.apache.kafka.connect.data.Schema-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] FromConnectHeader(string arg0, string arg1, Org.Apache.Kafka.Connect.Data.Schema arg2, object arg3)
        {
            return IExecuteArray<byte>("fromConnectHeader", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.6.1/org/apache/kafka/connect/converters/ByteArrayConverter.html#version--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string Version()
        {
            return IExecute<string>("version");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.6.1/org/apache/kafka/connect/converters/ByteArrayConverter.html#config--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Config.ConfigDef"/></returns>
        public Org.Apache.Kafka.Common.Config.ConfigDef Config()
        {
            return IExecute<Org.Apache.Kafka.Common.Config.ConfigDef>("config");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.6.1/org/apache/kafka/connect/converters/ByteArrayConverter.html#toConnectData-java.lang.String-byte[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaAndValue"/></returns>
        public Org.Apache.Kafka.Connect.Data.SchemaAndValue ToConnectData(string arg0, byte[] arg1)
        {
            return IExecute<Org.Apache.Kafka.Connect.Data.SchemaAndValue>("toConnectData", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.6.1/org/apache/kafka/connect/converters/ByteArrayConverter.html#toConnectHeader-java.lang.String-java.lang.String-byte[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaAndValue"/></returns>
        public Org.Apache.Kafka.Connect.Data.SchemaAndValue ToConnectHeader(string arg0, string arg1, byte[] arg2)
        {
            return IExecute<Org.Apache.Kafka.Connect.Data.SchemaAndValue>("toConnectHeader", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.6.1/org/apache/kafka/connect/converters/ByteArrayConverter.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.6.1/org/apache/kafka/connect/converters/ByteArrayConverter.html#configure-java.util.Map-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void Configure(Java.Util.Map<string, object> arg0, bool arg1)
        {
            IExecute("configure", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.6.1/org/apache/kafka/connect/converters/ByteArrayConverter.html#configure-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public void Configure(Java.Util.Map<string, object> arg0)
        {
            IExecute("configure", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}