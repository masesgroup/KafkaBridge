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

namespace Kafka.Server
{
    #region ThrottledReplicaListValidator
    public partial class ThrottledReplicaListValidator
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ThrottledReplicaListValidator.html#ensureValid(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="name"><see cref="string"/></param>
        /// <param name="value"><see cref="object"/></param>
        public static void EnsureValid(string name, object value)
        {
            SExecute(LocalBridgeClazz, "ensureValid", name, value);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/ThrottledReplicaListValidator.html#ensureValidString(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="name"><see cref="string"/></param>
        /// <param name="value"><see cref="string"/></param>
        public static void EnsureValidString(string name, string value)
        {
            SExecute(LocalBridgeClazz, "ensureValidString", name, value);
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