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

namespace Org.Apache.Kafka.Common.Acl
{
    #region AccessControlEntryFilter
    public partial class AccessControlEntryFilter
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/acl/AccessControlEntryFilter.html#org.apache.kafka.common.acl.AccessControlEntryFilter(java.lang.String,java.lang.String,org.apache.kafka.common.acl.AclOperation,org.apache.kafka.common.acl.AclPermissionType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Acl.AclOperation"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Common.Acl.AclPermissionType"/></param>
        public AccessControlEntryFilter(Java.Lang.String arg0, Java.Lang.String arg1, Org.Apache.Kafka.Common.Acl.AclOperation arg2, Org.Apache.Kafka.Common.Acl.AclPermissionType arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/acl/AccessControlEntryFilter.html#ANY"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Acl.AccessControlEntryFilter ANY { get { if (!_ANYReady) { _ANYContent = SGetField<Org.Apache.Kafka.Common.Acl.AccessControlEntryFilter>(LocalBridgeClazz, "ANY"); _ANYReady = true; } return _ANYContent; } }
        private static Org.Apache.Kafka.Common.Acl.AccessControlEntryFilter _ANYContent = default;
        private static bool _ANYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/acl/AccessControlEntryFilter.html#isUnknown--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsUnknown()
        {
            return IExecuteWithSignature<bool>("isUnknown", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/acl/AccessControlEntryFilter.html#matches-org.apache.kafka.common.acl.AccessControlEntry-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Acl.AccessControlEntry"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Matches(Org.Apache.Kafka.Common.Acl.AccessControlEntry arg0)
        {
            return IExecuteWithSignature<bool>("matches", "(Lorg/apache/kafka/common/acl/AccessControlEntry;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/acl/AccessControlEntryFilter.html#matchesAtMostOne--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool MatchesAtMostOne()
        {
            return IExecuteWithSignature<bool>("matchesAtMostOne", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/acl/AccessControlEntryFilter.html#findIndefiniteField--"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String FindIndefiniteField()
        {
            return IExecuteWithSignature<Java.Lang.String>("findIndefiniteField", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/acl/AccessControlEntryFilter.html#host--"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Host()
        {
            return IExecuteWithSignature<Java.Lang.String>("host", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/acl/AccessControlEntryFilter.html#principal--"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Principal()
        {
            return IExecuteWithSignature<Java.Lang.String>("principal", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/acl/AccessControlEntryFilter.html#operation--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Acl.AclOperation"/></returns>
        public Org.Apache.Kafka.Common.Acl.AclOperation Operation()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Acl.AclOperation>("operation", "()Lorg/apache/kafka/common/acl/AclOperation;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/acl/AccessControlEntryFilter.html#permissionType--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Acl.AclPermissionType"/></returns>
        public Org.Apache.Kafka.Common.Acl.AclPermissionType PermissionType()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Acl.AclPermissionType>("permissionType", "()Lorg/apache/kafka/common/acl/AclPermissionType;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}