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

namespace Kafka.Coordinator.Transaction
{
    #region PrepareEpochFence
    public partial class PrepareEpochFence
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/transaction/PrepareEpochFence.html#id()"/> 
        /// </summary>
        public static byte Id
        {
            get { return SExecute<byte>(LocalBridgeClazz, "id"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/transaction/PrepareEpochFence.html#isExpirationAllowed()"/> 
        /// </summary>
        public static bool IsExpirationAllowed
        {
            get { return SExecute<bool>(LocalBridgeClazz, "isExpirationAllowed"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/transaction/PrepareEpochFence.html#name()"/> 
        /// </summary>
        public static string Name
        {
            get { return SExecute<string>(LocalBridgeClazz, "name"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/transaction/PrepareEpochFence.html#productArity()"/> 
        /// </summary>
        public static int ProductArity
        {
            get { return SExecute<int>(LocalBridgeClazz, "productArity"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/transaction/PrepareEpochFence.html#productPrefix()"/> 
        /// </summary>
        public static string ProductPrefix
        {
            get { return SExecute<string>(LocalBridgeClazz, "productPrefix"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/transaction/PrepareEpochFence.html#canEqual(java.lang.Object)"/>
        /// </summary>
        /// <param name="x$1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool CanEqual(object x_1)
        {
            return SExecute<bool>(LocalBridgeClazz, "canEqual", x_1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/transaction/PrepareEpochFence.html#productElement(int)"/>
        /// </summary>
        /// <param name="x$1"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public static object ProductElement(int x_1)
        {
            return SExecute(LocalBridgeClazz, "productElement", x_1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/coordinator/transaction/PrepareEpochFence.html#productElementName(int)"/>
        /// </summary>
        /// <param name="n"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public static string ProductElementName(int n)
        {
            return SExecute<string>(LocalBridgeClazz, "productElementName", n);
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