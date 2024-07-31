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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using kafka-clients-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Utils
{
    #region SecurityUtils
    public partial class SecurityUtils
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/utils/SecurityUtils.html#operationName-org.apache.kafka.common.acl.AclOperation-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Acl.AclOperation"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String OperationName(Org.Apache.Kafka.Common.Acl.AclOperation arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "operationName", "(Lorg/apache/kafka/common/acl/AclOperation;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/utils/SecurityUtils.html#permissionTypeName-org.apache.kafka.common.acl.AclPermissionType-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Acl.AclPermissionType"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String PermissionTypeName(Org.Apache.Kafka.Common.Acl.AclPermissionType arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "permissionTypeName", "(Lorg/apache/kafka/common/acl/AclPermissionType;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/utils/SecurityUtils.html#resourceTypeName-org.apache.kafka.common.resource.ResourceType-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Resource.ResourceType"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ResourceTypeName(Org.Apache.Kafka.Common.Resource.ResourceType arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "resourceTypeName", "(Lorg/apache/kafka/common/resource/ResourceType;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/utils/SecurityUtils.html#operation-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Acl.AclOperation"/></returns>
        public static Org.Apache.Kafka.Common.Acl.AclOperation Operation(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.Acl.AclOperation>(LocalBridgeClazz, "operation", "(Ljava/lang/String;)Lorg/apache/kafka/common/acl/AclOperation;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/utils/SecurityUtils.html#permissionType-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Acl.AclPermissionType"/></returns>
        public static Org.Apache.Kafka.Common.Acl.AclPermissionType PermissionType(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.Acl.AclPermissionType>(LocalBridgeClazz, "permissionType", "(Ljava/lang/String;)Lorg/apache/kafka/common/acl/AclPermissionType;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/utils/SecurityUtils.html#resourceType-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Resource.ResourceType"/></returns>
        public static Org.Apache.Kafka.Common.Resource.ResourceType ResourceType(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.Resource.ResourceType>(LocalBridgeClazz, "resourceType", "(Ljava/lang/String;)Lorg/apache/kafka/common/resource/ResourceType;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/utils/SecurityUtils.html#parseKafkaPrincipal-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal"/></returns>
        public static Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal ParseKafkaPrincipal(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal>(LocalBridgeClazz, "parseKafkaPrincipal", "(Ljava/lang/String;)Lorg/apache/kafka/common/security/auth/KafkaPrincipal;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/utils/SecurityUtils.html#addConfiguredSecurityProviders-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public static void AddConfiguredSecurityProviders(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "addConfiguredSecurityProviders", "(Ljava/util/Map;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/utils/SecurityUtils.html#authorizeByResourceTypeCheckArgs-org.apache.kafka.common.acl.AclOperation-org.apache.kafka.common.resource.ResourceType-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Acl.AclOperation"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Resource.ResourceType"/></param>
        public static void AuthorizeByResourceTypeCheckArgs(Org.Apache.Kafka.Common.Acl.AclOperation arg0, Org.Apache.Kafka.Common.Resource.ResourceType arg1)
        {
            SExecute(LocalBridgeClazz, "authorizeByResourceTypeCheckArgs", arg0, arg1);
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