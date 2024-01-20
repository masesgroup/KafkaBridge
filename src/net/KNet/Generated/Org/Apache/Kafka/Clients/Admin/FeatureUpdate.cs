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
*  This file is generated by MASES.JNetReflector (ver. 2.2.1.0)
*  using kafka-clients-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Admin
{
    #region FeatureUpdate
    public partial class FeatureUpdate
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/admin/FeatureUpdate.html#org.apache.kafka.clients.admin.FeatureUpdate(short,org.apache.kafka.clients.admin.FeatureUpdate.UpgradeType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType"/></param>
        public FeatureUpdate(short arg0, Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType arg1)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/admin/FeatureUpdate.html#upgradeType--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType"/></returns>
        public Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType UpgradeTypeMethod()
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType>("upgradeType");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/admin/FeatureUpdate.html#maxVersionLevel--"/>
        /// </summary>

        /// <returns><see cref="short"/></returns>
        public short MaxVersionLevel()
        {
            return IExecute<short>("maxVersionLevel");
        }

        #endregion

        #region Nested classes
        #region UpgradeType
        public partial class UpgradeType
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/admin/FeatureUpdate.UpgradeType.html#SAFE_DOWNGRADE"/>
            /// </summary>
            public static Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType SAFE_DOWNGRADE { get { return SGetField<Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType>(LocalBridgeClazz, "SAFE_DOWNGRADE"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/admin/FeatureUpdate.UpgradeType.html#UNKNOWN"/>
            /// </summary>
            public static Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType UNKNOWN { get { return SGetField<Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType>(LocalBridgeClazz, "UNKNOWN"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/admin/FeatureUpdate.UpgradeType.html#UNSAFE_DOWNGRADE"/>
            /// </summary>
            public static Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType UNSAFE_DOWNGRADE { get { return SGetField<Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType>(LocalBridgeClazz, "UNSAFE_DOWNGRADE"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/admin/FeatureUpdate.UpgradeType.html#UPGRADE"/>
            /// </summary>
            public static Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType UPGRADE { get { return SGetField<Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType>(LocalBridgeClazz, "UPGRADE"); } }

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/admin/FeatureUpdate.UpgradeType.html#fromCode-int-"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType"/></returns>
            public static Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType FromCode(int arg0)
            {
                return SExecute<Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType>(LocalBridgeClazz, "fromCode", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/admin/FeatureUpdate.UpgradeType.html#valueOf-java.lang.String-"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType"/></returns>
            public static Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType ValueOf(string arg0)
            {
                return SExecute<Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType>(LocalBridgeClazz, "valueOf", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/admin/FeatureUpdate.UpgradeType.html#values--"/>
            /// </summary>

            /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType"/></returns>
            public static Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType[] Values()
            {
                return SExecuteArray<Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType>(LocalBridgeClazz, "values");
            }

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/admin/FeatureUpdate.UpgradeType.html#code--"/>
            /// </summary>

            /// <returns><see cref="byte"/></returns>
            public byte Code()
            {
                return IExecute<byte>("code");
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