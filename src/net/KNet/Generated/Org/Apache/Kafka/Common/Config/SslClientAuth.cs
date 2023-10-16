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

namespace Org.Apache.Kafka.Common.Config
{
    #region SslClientAuth
    public partial class SslClientAuth
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/config/SslClientAuth.html#VALUES"/>
        /// </summary>
        public static Java.Util.List VALUES { get { return SGetField<Java.Util.List>(LocalBridgeClazz, "VALUES"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/config/SslClientAuth.html#NONE"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Config.SslClientAuth NONE { get { return SGetField<Org.Apache.Kafka.Common.Config.SslClientAuth>(LocalBridgeClazz, "NONE"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/config/SslClientAuth.html#REQUESTED"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Config.SslClientAuth REQUESTED { get { return SGetField<Org.Apache.Kafka.Common.Config.SslClientAuth>(LocalBridgeClazz, "REQUESTED"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/config/SslClientAuth.html#REQUIRED"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Config.SslClientAuth REQUIRED { get { return SGetField<Org.Apache.Kafka.Common.Config.SslClientAuth>(LocalBridgeClazz, "REQUIRED"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/config/SslClientAuth.html#forConfig-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Config.SslClientAuth"/></returns>
        public static Org.Apache.Kafka.Common.Config.SslClientAuth ForConfig(string arg0)
        {
            return SExecute<Org.Apache.Kafka.Common.Config.SslClientAuth>(LocalBridgeClazz, "forConfig", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/config/SslClientAuth.html#valueOf-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Config.SslClientAuth"/></returns>
        public static Org.Apache.Kafka.Common.Config.SslClientAuth ValueOf(string arg0)
        {
            return SExecute<Org.Apache.Kafka.Common.Config.SslClientAuth>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/common/config/SslClientAuth.html#values--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Config.SslClientAuth"/></returns>
        public static Org.Apache.Kafka.Common.Config.SslClientAuth[] Values()
        {
            return SExecuteArray<Org.Apache.Kafka.Common.Config.SslClientAuth>(LocalBridgeClazz, "values");
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