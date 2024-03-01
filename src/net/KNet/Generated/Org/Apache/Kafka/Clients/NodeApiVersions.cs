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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using kafka-clients-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients
{
    #region NodeApiVersions
    public partial class NodeApiVersions
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/NodeApiVersions.html#create--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Clients.NodeApiVersions"/></returns>
        public static Org.Apache.Kafka.Clients.NodeApiVersions Create()
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Clients.NodeApiVersions>(LocalBridgeClazz, "create", "()Lorg/apache/kafka/clients/NodeApiVersions;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/NodeApiVersions.html#create-short-short-short-"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        /// <param name="arg2"><see cref="short"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.NodeApiVersions"/></returns>
        public static Org.Apache.Kafka.Clients.NodeApiVersions Create(short arg0, short arg1, short arg2)
        {
            return SExecute<Org.Apache.Kafka.Clients.NodeApiVersions>(LocalBridgeClazz, "create", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/NodeApiVersions.html#zkMigrationEnabled--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool ZkMigrationEnabled()
        {
            return IExecuteWithSignature<bool>("zkMigrationEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/NodeApiVersions.html#toString-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ToString(bool arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("toString", "(Z)Ljava/lang/String;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}