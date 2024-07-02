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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using kafka-clients-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Admin
{
    #region NewPartitions
    public partial class NewPartitions
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/NewPartitions.html#increaseTo-int-java.util.List-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.NewPartitions"/></returns>
        public static Org.Apache.Kafka.Clients.Admin.NewPartitions IncreaseTo(int arg0, Java.Util.List<Java.Util.List<Java.Lang.Integer>> arg1)
        {
            return SExecute<Org.Apache.Kafka.Clients.Admin.NewPartitions>(LocalBridgeClazz, "increaseTo", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/NewPartitions.html#increaseTo-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.NewPartitions"/></returns>
        public static Org.Apache.Kafka.Clients.Admin.NewPartitions IncreaseTo(int arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Clients.Admin.NewPartitions>(LocalBridgeClazz, "increaseTo", "(I)Lorg/apache/kafka/clients/admin/NewPartitions;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/NewPartitions.html#totalCount--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int TotalCount()
        {
            return IExecuteWithSignature<int>("totalCount", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/clients/admin/NewPartitions.html#assignments--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Util.List<Java.Lang.Integer>> Assignments()
        {
            return IExecuteWithSignature<Java.Util.List<Java.Util.List<Java.Lang.Integer>>>("assignments", "()Ljava/util/List;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}