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
*  This file is generated by MASES.JNetReflector (ver. 2.0.0.0)
*  using kafka-clients-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Acl
{
    #region AclPermissionType
    public partial class AclPermissionType
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/acl/AclPermissionType.html#ALLOW"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Acl.AclPermissionType ALLOW { get { return SGetField<Org.Apache.Kafka.Common.Acl.AclPermissionType>(LocalBridgeClazz, "ALLOW"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/acl/AclPermissionType.html#ANY"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Acl.AclPermissionType ANY { get { return SGetField<Org.Apache.Kafka.Common.Acl.AclPermissionType>(LocalBridgeClazz, "ANY"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/acl/AclPermissionType.html#DENY"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Acl.AclPermissionType DENY { get { return SGetField<Org.Apache.Kafka.Common.Acl.AclPermissionType>(LocalBridgeClazz, "DENY"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/acl/AclPermissionType.html#UNKNOWN"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Acl.AclPermissionType UNKNOWN { get { return SGetField<Org.Apache.Kafka.Common.Acl.AclPermissionType>(LocalBridgeClazz, "UNKNOWN"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/acl/AclPermissionType.html#fromCode(byte)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Acl.AclPermissionType"/></returns>
        public static Org.Apache.Kafka.Common.Acl.AclPermissionType FromCode(byte arg0)
        {
            return SExecute<Org.Apache.Kafka.Common.Acl.AclPermissionType>(LocalBridgeClazz, "fromCode", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/acl/AclPermissionType.html#fromString(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Acl.AclPermissionType"/></returns>
        public static Org.Apache.Kafka.Common.Acl.AclPermissionType FromString(string arg0)
        {
            return SExecute<Org.Apache.Kafka.Common.Acl.AclPermissionType>(LocalBridgeClazz, "fromString", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/acl/AclPermissionType.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Acl.AclPermissionType"/></returns>
        public static Org.Apache.Kafka.Common.Acl.AclPermissionType ValueOf(string arg0)
        {
            return SExecute<Org.Apache.Kafka.Common.Acl.AclPermissionType>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/acl/AclPermissionType.html#values()"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Acl.AclPermissionType"/></returns>
        public static Org.Apache.Kafka.Common.Acl.AclPermissionType[] Values()
        {
            return SExecuteArray<Org.Apache.Kafka.Common.Acl.AclPermissionType>(LocalBridgeClazz, "values");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/acl/AclPermissionType.html#isUnknown()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsUnknown()
        {
            return IExecute<bool>("isUnknown");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/acl/AclPermissionType.html#code()"/>
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
}