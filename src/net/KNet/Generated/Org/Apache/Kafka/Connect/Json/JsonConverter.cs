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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using connect-json-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Json
{
    #region JsonConverter
    public partial class JsonConverter : Org.Apache.Kafka.Connect.Components.IVersioned
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-json/3.8.0/org/apache/kafka/connect/json/JsonConverter.html#org.apache.kafka.connect.json.JsonConverter(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public JsonConverter(bool arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Json.JsonConverter"/> to <see cref="Org.Apache.Kafka.Connect.Components.Versioned"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Connect.Components.Versioned(Org.Apache.Kafka.Connect.Json.JsonConverter t) => t.Cast<Org.Apache.Kafka.Connect.Components.Versioned>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-json/3.8.0/org/apache/kafka/connect/json/JsonConverter.html#fromConnectData-java.lang.String-org.apache.kafka.connect.data.Schema-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] FromConnectData(Java.Lang.String arg0, Org.Apache.Kafka.Connect.Data.Schema arg1, object arg2)
        {
            return IExecuteArray<byte>("fromConnectData", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-json/3.8.0/org/apache/kafka/connect/json/JsonConverter.html#fromConnectHeader-java.lang.String-java.lang.String-org.apache.kafka.connect.data.Schema-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] FromConnectHeader(Java.Lang.String arg0, Java.Lang.String arg1, Org.Apache.Kafka.Connect.Data.Schema arg2, object arg3)
        {
            return IExecuteArray<byte>("fromConnectHeader", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-json/3.8.0/org/apache/kafka/connect/json/JsonConverter.html#version--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Version()
        {
            return IExecuteWithSignature<Java.Lang.String>("version", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-json/3.8.0/org/apache/kafka/connect/json/JsonConverter.html#config--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Config.ConfigDef"/></returns>
        public Org.Apache.Kafka.Common.Config.ConfigDef Config()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Config.ConfigDef>("config", "()Lorg/apache/kafka/common/config/ConfigDef;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-json/3.8.0/org/apache/kafka/connect/json/JsonConverter.html#toConnectData-java.lang.String-byte[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaAndValue"/></returns>
        public Org.Apache.Kafka.Connect.Data.SchemaAndValue ToConnectData(Java.Lang.String arg0, byte[] arg1)
        {
            return IExecute<Org.Apache.Kafka.Connect.Data.SchemaAndValue>("toConnectData", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-json/3.8.0/org/apache/kafka/connect/json/JsonConverter.html#toConnectHeader-java.lang.String-java.lang.String-byte[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaAndValue"/></returns>
        public Org.Apache.Kafka.Connect.Data.SchemaAndValue ToConnectHeader(Java.Lang.String arg0, Java.Lang.String arg1, byte[] arg2)
        {
            return IExecute<Org.Apache.Kafka.Connect.Data.SchemaAndValue>("toConnectHeader", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-json/3.8.0/org/apache/kafka/connect/json/JsonConverter.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-json/3.8.0/org/apache/kafka/connect/json/JsonConverter.html#configure-java.util.Map-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void Configure(Java.Util.Map<Java.Lang.String, object> arg0, bool arg1)
        {
            IExecute("configure", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-json/3.8.0/org/apache/kafka/connect/json/JsonConverter.html#configure-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public void Configure(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            IExecuteWithSignature("configure", "(Ljava/util/Map;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}