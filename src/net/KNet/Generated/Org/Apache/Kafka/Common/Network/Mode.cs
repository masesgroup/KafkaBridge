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

namespace Org.Apache.Kafka.Common.Network
{
    #region Mode
    public partial class Mode
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/network/Mode.html#CLIENT"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Network.Mode CLIENT { get { return SGetField<Org.Apache.Kafka.Common.Network.Mode>(LocalBridgeClazz, "CLIENT"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/network/Mode.html#SERVER"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Network.Mode SERVER { get { return SGetField<Org.Apache.Kafka.Common.Network.Mode>(LocalBridgeClazz, "SERVER"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/network/Mode.html#values()"/> 
        /// </summary>
        public static Org.Apache.Kafka.Common.Network.Mode[] Values
        {
            get { return SExecuteArray<Org.Apache.Kafka.Common.Network.Mode>(LocalBridgeClazz, "values"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/network/Mode.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Network.Mode"/></returns>
        public static Org.Apache.Kafka.Common.Network.Mode ValueOf(string arg0)
        {
            return SExecute<Org.Apache.Kafka.Common.Network.Mode>(LocalBridgeClazz, "valueOf", arg0);
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