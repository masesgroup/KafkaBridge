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

namespace Org.Apache.Kafka.Server.Quota
{
    #region ClientQuotaCallback
    public partial class ClientQuotaCallback
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/server/quota/ClientQuotaCallback.html#quotaResetRequired(org.apache.kafka.server.quota.ClientQuotaType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Server.Quota.ClientQuotaType"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool QuotaResetRequired(Org.Apache.Kafka.Server.Quota.ClientQuotaType arg0)
        {
            return IExecute<bool>("quotaResetRequired", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/server/quota/ClientQuotaCallback.html#updateClusterMetadata(org.apache.kafka.common.Cluster)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Cluster"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool UpdateClusterMetadata(Org.Apache.Kafka.Common.Cluster arg0)
        {
            return IExecute<bool>("updateClusterMetadata", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/server/quota/ClientQuotaCallback.html#quotaLimit(org.apache.kafka.server.quota.ClientQuotaType,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Server.Quota.ClientQuotaType"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="double"/></returns>
        public double? QuotaLimit(Org.Apache.Kafka.Server.Quota.ClientQuotaType arg0, Java.Util.Map<string, string> arg1)
        {
            return IExecute<double?>("quotaLimit", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/server/quota/ClientQuotaCallback.html#quotaMetricTags(org.apache.kafka.server.quota.ClientQuotaType,org.apache.kafka.common.security.auth.KafkaPrincipal,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Server.Quota.ClientQuotaType"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<string, string> QuotaMetricTags(Org.Apache.Kafka.Server.Quota.ClientQuotaType arg0, Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal arg1, string arg2)
        {
            return IExecute<Java.Util.Map<string, string>>("quotaMetricTags", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/server/quota/ClientQuotaCallback.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/server/quota/ClientQuotaCallback.html#removeQuota(org.apache.kafka.server.quota.ClientQuotaType,org.apache.kafka.server.quota.ClientQuotaEntity)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Server.Quota.ClientQuotaType"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Server.Quota.ClientQuotaEntity"/></param>
        public void RemoveQuota(Org.Apache.Kafka.Server.Quota.ClientQuotaType arg0, Org.Apache.Kafka.Server.Quota.ClientQuotaEntity arg1)
        {
            IExecute("removeQuota", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/server/quota/ClientQuotaCallback.html#updateQuota(org.apache.kafka.server.quota.ClientQuotaType,org.apache.kafka.server.quota.ClientQuotaEntity,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Server.Quota.ClientQuotaType"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Server.Quota.ClientQuotaEntity"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        public void UpdateQuota(Org.Apache.Kafka.Server.Quota.ClientQuotaType arg0, Org.Apache.Kafka.Server.Quota.ClientQuotaEntity arg1, double arg2)
        {
            IExecute("updateQuota", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}