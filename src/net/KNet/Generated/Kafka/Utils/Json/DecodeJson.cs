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
*  using kafka_2.13-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Kafka.Utils.Json
{
    #region DecodeJson
    public partial class DecodeJson
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/utils/json/DecodeJson.html#decodeOption(kafka.utils.json.DecodeJson)"/>
        /// </summary>
        /// <param name="decodeJson"><see cref="Kafka.Utils.Json.DecodeJson"/></param>
        /// <returns><see cref="Kafka.Utils.Json.DecodeJson"/></returns>
        public static Kafka.Utils.Json.DecodeJson DecodeOption(Kafka.Utils.Json.DecodeJson decodeJson)
        {
            return SExecute<Kafka.Utils.Json.DecodeJson>(LocalBridgeClazz, "decodeOption", decodeJson);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/utils/json/DecodeJson.html#decode(com.fasterxml.jackson.databind.JsonNode)"/>
        /// </summary>
        /// <param name="node"><see cref="Com.Fasterxml.Jackson.Databind.JsonNode"/></param>
        /// <returns><see cref="object"/></returns>
        public object Decode(Com.Fasterxml.Jackson.Databind.JsonNode node)
        {
            return IExecute("decode", node);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DecodeJson<T>
    public partial class DecodeJson<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Kafka.Utils.Json.DecodeJson{T}"/> to <see cref="Kafka.Utils.Json.DecodeJson"/>
        /// </summary>
        public static implicit operator Kafka.Utils.Json.DecodeJson(Kafka.Utils.Json.DecodeJson<T> t) => t.Cast<Kafka.Utils.Json.DecodeJson>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/utils/json/DecodeJson.html#decodeOption(kafka.utils.json.DecodeJson)"/>
        /// </summary>
        /// <param name="decodeJson"><see cref="Kafka.Utils.Json.DecodeJson"/></param>
        /// <typeparam name="E"></typeparam>
        /// <returns><see cref="Kafka.Utils.Json.DecodeJson"/></returns>
        public static Kafka.Utils.Json.DecodeJson<Scala.Option<E>> DecodeOption<E>(Kafka.Utils.Json.DecodeJson<E> decodeJson)
        {
            return SExecute<Kafka.Utils.Json.DecodeJson<Scala.Option<E>>>(LocalBridgeClazz, "decodeOption", decodeJson);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/utils/json/DecodeJson.html#decode(com.fasterxml.jackson.databind.JsonNode)"/>
        /// </summary>
        /// <param name="node"><see cref="Com.Fasterxml.Jackson.Databind.JsonNode"/></param>
        /// <returns><typeparamref name="T"/></returns>
        public T Decode(Com.Fasterxml.Jackson.Databind.JsonNode node)
        {
            return IExecute<T>("decode", node);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}