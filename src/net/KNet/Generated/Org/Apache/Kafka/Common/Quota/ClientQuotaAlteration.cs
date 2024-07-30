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
    #region ClientQuotaAlteration
    public partial class ClientQuotaAlteration
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/quota/ClientQuotaAlteration.html#org.apache.kafka.common.quota.ClientQuotaAlteration(org.apache.kafka.common.quota.ClientQuotaEntity,java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Quota.ClientQuotaEntity"/></param>
        /// <param name="arg1"><see cref="Java.Util.Collection"/></param>
        public ClientQuotaAlteration(Org.Apache.Kafka.Common.Quota.ClientQuotaEntity arg0, Java.Util.Collection<Org.Apache.Kafka.Common.Quota.ClientQuotaAlteration.Op> arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/quota/ClientQuotaAlteration.html#ops--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        public Java.Util.Collection<Org.Apache.Kafka.Common.Quota.ClientQuotaAlteration.Op> Ops()
        {
            return IExecuteWithSignature<Java.Util.Collection<Org.Apache.Kafka.Common.Quota.ClientQuotaAlteration.Op>>("ops", "()Ljava/util/Collection;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/quota/ClientQuotaAlteration.html#entity--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Quota.ClientQuotaEntity"/></returns>
        public Org.Apache.Kafka.Common.Quota.ClientQuotaEntity Entity()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Quota.ClientQuotaEntity>("entity", "()Lorg/apache/kafka/common/quota/ClientQuotaEntity;");
        }

        #endregion

        #region Nested classes
        #region Op
        public partial class Op
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/quota/ClientQuotaAlteration.Op.html#org.apache.kafka.common.quota.ClientQuotaAlteration$Op(java.lang.String,java.lang.Double)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Lang.Double"/></param>
            public Op(Java.Lang.String arg0, Java.Lang.Double arg1)
                : base(arg0, arg1)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/quota/ClientQuotaAlteration.Op.html#value--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.Double"/></returns>
            public Java.Lang.Double Value()
            {
                return IExecuteWithSignature<Java.Lang.Double>("value", "()Ljava/lang/Double;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/quota/ClientQuotaAlteration.Op.html#key--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String Key()
            {
                return IExecuteWithSignature<Java.Lang.String>("key", "()Ljava/lang/String;");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}