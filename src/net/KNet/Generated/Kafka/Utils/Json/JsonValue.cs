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
    #region JsonValue
    public partial class JsonValue
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/utils/json/JsonValue.html#apply(com.fasterxml.jackson.databind.JsonNode)"/>
        /// </summary>
        /// <param name="node"><see cref="Com.Fasterxml.Jackson.Databind.JsonNode"/></param>
        /// <returns><see cref="Kafka.Utils.Json.JsonValue"/></returns>
        public static Kafka.Utils.Json.JsonValue Apply(Com.Fasterxml.Jackson.Databind.JsonNode node)
        {
            return SExecute<Kafka.Utils.Json.JsonValue>(LocalBridgeClazz, "apply", node);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/utils/json/JsonValue.html#asJsonArray()"/> 
        /// </summary>
        public Kafka.Utils.Json.JsonArray AsJsonArray
        {
            get { return IExecute<Kafka.Utils.Json.JsonArray>("asJsonArray"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/utils/json/JsonValue.html#asJsonObject()"/> 
        /// </summary>
        public Kafka.Utils.Json.JsonObject AsJsonObject
        {
            get { return IExecute<Kafka.Utils.Json.JsonObject>("asJsonObject"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/utils/json/JsonValue.html#node()"/> 
        /// </summary>
        public Com.Fasterxml.Jackson.Databind.JsonNode Node
        {
            get { return IExecute<Com.Fasterxml.Jackson.Databind.JsonNode>("node"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/utils/json/JsonValue.html#to(kafka.utils.json.DecodeJson)"/>
        /// </summary>
        /// <param name="decodeJson"><see cref="Kafka.Utils.Json.DecodeJson"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T To<T>(Kafka.Utils.Json.DecodeJson<T> decodeJson)
        {
            return IExecute<T>("to", decodeJson);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}