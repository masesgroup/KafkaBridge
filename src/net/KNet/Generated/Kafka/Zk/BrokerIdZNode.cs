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

namespace Kafka.Zk
{
    #region BrokerIdZNode
    public partial class BrokerIdZNode
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/zk/BrokerIdZNode.html#encode(kafka.zk.BrokerInfo)"/>
        /// </summary>
        /// <param name="brokerInfo"><see cref="Kafka.Zk.BrokerInfo"/></param>
        /// <returns><see cref="byte"/></returns>
        public static byte[] Encode(Kafka.Zk.BrokerInfo brokerInfo)
        {
            return SExecuteArray<byte>(LocalBridgeClazz, "encode", brokerInfo);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/zk/BrokerIdZNode.html#path(int)"/>
        /// </summary>
        /// <param name="id"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public static string Path(int id)
        {
            return SExecute<string>(LocalBridgeClazz, "path", id);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/zk/BrokerIdZNode.html#featuresAsJavaMap(kafka.utils.json.JsonObject)"/>
        /// </summary>
        /// <param name="brokerInfo"><see cref="Kafka.Utils.Json.JsonObject"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public static Java.Util.Map<string, Java.Util.Map<string, short?>> FeaturesAsJavaMap(Kafka.Utils.Json.JsonObject brokerInfo)
        {
            return SExecute<Java.Util.Map<string, Java.Util.Map<string, short?>>>(LocalBridgeClazz, "featuresAsJavaMap", brokerInfo);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/zk/BrokerIdZNode.html#decode(int,byte[])"/>
        /// </summary>
        /// <param name="id"><see cref="int"/></param>
        /// <param name="jsonBytes"><see cref="byte"/></param>
        /// <returns><see cref="Kafka.Zk.BrokerInfo"/></returns>
        public static Kafka.Zk.BrokerInfo Decode(int id, byte[] jsonBytes)
        {
            return SExecute<Kafka.Zk.BrokerInfo>(LocalBridgeClazz, "decode", id, jsonBytes);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}