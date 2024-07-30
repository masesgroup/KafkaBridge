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
*  using kafka-clients-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Quota
{
    #region ClientQuotaFilter
    public partial class ClientQuotaFilter
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/quota/ClientQuotaFilter.html#all--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Quota.ClientQuotaFilter"/></returns>
        public static Org.Apache.Kafka.Common.Quota.ClientQuotaFilter All()
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.Quota.ClientQuotaFilter>(LocalBridgeClazz, "all", "()Lorg/apache/kafka/common/quota/ClientQuotaFilter;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/quota/ClientQuotaFilter.html#contains-java.util.Collection-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Quota.ClientQuotaFilter"/></returns>
        public static Org.Apache.Kafka.Common.Quota.ClientQuotaFilter Contains(Java.Util.Collection<Org.Apache.Kafka.Common.Quota.ClientQuotaFilterComponent> arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.Quota.ClientQuotaFilter>(LocalBridgeClazz, "contains", "(Ljava/util/Collection;)Lorg/apache/kafka/common/quota/ClientQuotaFilter;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/quota/ClientQuotaFilter.html#containsOnly-java.util.Collection-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Quota.ClientQuotaFilter"/></returns>
        public static Org.Apache.Kafka.Common.Quota.ClientQuotaFilter ContainsOnly(Java.Util.Collection<Org.Apache.Kafka.Common.Quota.ClientQuotaFilterComponent> arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.Quota.ClientQuotaFilter>(LocalBridgeClazz, "containsOnly", "(Ljava/util/Collection;)Lorg/apache/kafka/common/quota/ClientQuotaFilter;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/quota/ClientQuotaFilter.html#strict--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool Strict()
        {
            return IExecuteWithSignature<bool>("strict", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/quota/ClientQuotaFilter.html#components--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        public Java.Util.Collection<Org.Apache.Kafka.Common.Quota.ClientQuotaFilterComponent> Components()
        {
            return IExecuteWithSignature<Java.Util.Collection<Org.Apache.Kafka.Common.Quota.ClientQuotaFilterComponent>>("components", "()Ljava/util/Collection;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}