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

namespace Kafka.Security.Authorizer
{
    #region AclAuthorizer
    public partial class AclAuthorizer
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Kafka.Security.Authorizer.AclAuthorizer"/> to <see cref="Org.Apache.Kafka.Server.Authorizer.Authorizer"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Server.Authorizer.Authorizer(Kafka.Security.Authorizer.AclAuthorizer t) => t.Cast<Org.Apache.Kafka.Server.Authorizer.Authorizer>();
        /// <summary>
        /// Converter from <see cref="Kafka.Security.Authorizer.AclAuthorizer"/> to <see cref="Kafka.Utils.Logging"/>
        /// </summary>
        public static implicit operator Kafka.Utils.Logging(Kafka.Security.Authorizer.AclAuthorizer t) => t.Cast<Kafka.Utils.Logging>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.html#AllowEveryoneIfNoAclIsFoundProp()"/> 
        /// </summary>
        public static string AllowEveryoneIfNoAclIsFoundProp
        {
            get { return SExecute<string>(LocalBridgeClazz, "AllowEveryoneIfNoAclIsFoundProp"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.html#configPrefix()"/> 
        /// </summary>
        public static string ConfigPrefix
        {
            get { return SExecute<string>(LocalBridgeClazz, "configPrefix"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.html#NoAcls()"/> 
        /// </summary>
        public static Kafka.Security.Authorizer.AclAuthorizer.VersionedAcls NoAcls
        {
            get { return SExecute<Kafka.Security.Authorizer.AclAuthorizer.VersionedAcls>(LocalBridgeClazz, "NoAcls"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.html#SuperUsersProp()"/> 
        /// </summary>
        public static string SuperUsersProp
        {
            get { return SExecute<string>(LocalBridgeClazz, "SuperUsersProp"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.html#WildcardHost()"/> 
        /// </summary>
        public static string WildcardHost
        {
            get { return SExecute<string>(LocalBridgeClazz, "WildcardHost"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.html#ZkConnectionTimeOutProp()"/> 
        /// </summary>
        public static string ZkConnectionTimeOutProp
        {
            get { return SExecute<string>(LocalBridgeClazz, "ZkConnectionTimeOutProp"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.html#ZkMaxInFlightRequests()"/> 
        /// </summary>
        public static string ZkMaxInFlightRequests
        {
            get { return SExecute<string>(LocalBridgeClazz, "ZkMaxInFlightRequests"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.html#ZkSessionTimeOutProp()"/> 
        /// </summary>
        public static string ZkSessionTimeOutProp
        {
            get { return SExecute<string>(LocalBridgeClazz, "ZkSessionTimeOutProp"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.html#ZkUrlProp()"/> 
        /// </summary>
        public static string ZkUrlProp
        {
            get { return SExecute<string>(LocalBridgeClazz, "ZkUrlProp"); }
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.html#AclChangedNotificationHandler()"/> 
        /// </summary>
        public Kafka.Security.Authorizer.AclAuthorizer.AclChangedNotificationHandler. AclChangedNotificationHandler
        {
            get { return IExecute<Kafka.Security.Authorizer.AclAuthorizer.AclChangedNotificationHandler.>("AclChangedNotificationHandler"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.html#aclCount()"/> 
        /// </summary>
        public int AclCount
        {
            get { return IExecute<int>("aclCount"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.html#authorizerLogger()"/> 
        /// </summary>
        public Com.Typesafe.Scalalogging.Logger AuthorizerLogger
        {
            get { return IExecute<Com.Typesafe.Scalalogging.Logger>("authorizerLogger"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.html#isDebugEnabled()"/> 
        /// </summary>
        public bool IsDebugEnabled
        {
            get { return IExecute<bool>("isDebugEnabled"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.html#isTraceEnabled()"/> 
        /// </summary>
        public bool IsTraceEnabled
        {
            get { return IExecute<bool>("isTraceEnabled"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.html#logger()"/> 
        /// </summary>
        public Com.Typesafe.Scalalogging.Logger Logger
        {
            get { return IExecute<Com.Typesafe.Scalalogging.Logger>("logger"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.html#loggerName()"/> 
        /// </summary>
        public string LoggerName
        {
            get { return IExecute<string>("loggerName"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.html#logIdent()"/> 
        /// </summary>
        public string LogIdent
        {
            get { return IExecute<string>("logIdent"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.html#maxUpdateRetries()"/> 
        /// </summary>
        public int MaxUpdateRetries
        {
            get { return IExecute<int>("maxUpdateRetries"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.html#isSuperUser(org.apache.kafka.common.security.auth.KafkaPrincipal)"/>
        /// </summary>
        /// <param name="principal"><see cref="Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSuperUser(Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal principal)
        {
            return IExecute<bool>("isSuperUser", principal);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.html#acls(org.apache.kafka.common.acl.AclBindingFilter)"/>
        /// </summary>
        /// <param name="filter"><see cref="Org.Apache.Kafka.Common.Acl.AclBindingFilter"/></param>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        public Java.Lang.Iterable<Org.Apache.Kafka.Common.Acl.AclBinding> Acls(Org.Apache.Kafka.Common.Acl.AclBindingFilter filter)
        {
            return IExecute<Java.Lang.Iterable<Org.Apache.Kafka.Common.Acl.AclBinding>>("acls", filter);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.html#msgWithLogIdent(java.lang.String)"/>
        /// </summary>
        /// <param name="msg"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string MsgWithLogIdent(string msg)
        {
            return IExecute<string>("msgWithLogIdent", msg);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.html#createAcls(org.apache.kafka.server.authorizer.AuthorizableRequestContext,java.util.List)"/>
        /// </summary>
        /// <param name="requestContext"><see cref="Org.Apache.Kafka.Server.Authorizer.AuthorizableRequestContext"/></param>
        /// <param name="aclBindings"><see cref="Java.Util.List"/></param>
        /// <typeparam name="ReturnExtendsJava_Util_Concurrent_CompletionStage_Org_Apache_Kafka_Server_Authorizer_AclCreateResult_"><see cref="Java.Util.Concurrent.CompletionStage{Org.Apache.Kafka.Server.Authorizer.AclCreateResult}"/></typeparam>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<ReturnExtendsJava_Util_Concurrent_CompletionStage_Org_Apache_Kafka_Server_Authorizer_AclCreateResult_> CreateAcls<ReturnExtendsJava_Util_Concurrent_CompletionStage_Org_Apache_Kafka_Server_Authorizer_AclCreateResult_>(Org.Apache.Kafka.Server.Authorizer.AuthorizableRequestContext requestContext, Java.Util.List<Org.Apache.Kafka.Common.Acl.AclBinding> aclBindings) where ReturnExtendsJava_Util_Concurrent_CompletionStage_Org_Apache_Kafka_Server_Authorizer_AclCreateResult_: Java.Util.Concurrent.CompletionStage<Org.Apache.Kafka.Server.Authorizer.AclCreateResult>
        {
            return IExecute<Java.Util.List<ReturnExtendsJava_Util_Concurrent_CompletionStage_Org_Apache_Kafka_Server_Authorizer_AclCreateResult_>>("createAcls", requestContext, aclBindings);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.html#deleteAcls(org.apache.kafka.server.authorizer.AuthorizableRequestContext,java.util.List)"/>
        /// </summary>
        /// <param name="requestContext"><see cref="Org.Apache.Kafka.Server.Authorizer.AuthorizableRequestContext"/></param>
        /// <param name="aclBindingFilters"><see cref="Java.Util.List"/></param>
        /// <typeparam name="ReturnExtendsJava_Util_Concurrent_CompletionStage_Org_Apache_Kafka_Server_Authorizer_AclDeleteResult_"><see cref="Java.Util.Concurrent.CompletionStage{Org.Apache.Kafka.Server.Authorizer.AclDeleteResult}"/></typeparam>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<ReturnExtendsJava_Util_Concurrent_CompletionStage_Org_Apache_Kafka_Server_Authorizer_AclDeleteResult_> DeleteAcls<ReturnExtendsJava_Util_Concurrent_CompletionStage_Org_Apache_Kafka_Server_Authorizer_AclDeleteResult_>(Org.Apache.Kafka.Server.Authorizer.AuthorizableRequestContext requestContext, Java.Util.List<Org.Apache.Kafka.Common.Acl.AclBindingFilter> aclBindingFilters) where ReturnExtendsJava_Util_Concurrent_CompletionStage_Org_Apache_Kafka_Server_Authorizer_AclDeleteResult_: Java.Util.Concurrent.CompletionStage<Org.Apache.Kafka.Server.Authorizer.AclDeleteResult>
        {
            return IExecute<Java.Util.List<ReturnExtendsJava_Util_Concurrent_CompletionStage_Org_Apache_Kafka_Server_Authorizer_AclDeleteResult_>>("deleteAcls", requestContext, aclBindingFilters);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.html#authorize(org.apache.kafka.server.authorizer.AuthorizableRequestContext,java.util.List)"/>
        /// </summary>
        /// <param name="requestContext"><see cref="Org.Apache.Kafka.Server.Authorizer.AuthorizableRequestContext"/></param>
        /// <param name="actions"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Org.Apache.Kafka.Server.Authorizer.AuthorizationResult> Authorize(Org.Apache.Kafka.Server.Authorizer.AuthorizableRequestContext requestContext, Java.Util.List<Org.Apache.Kafka.Server.Authorizer.Action> actions)
        {
            return IExecute<Java.Util.List<Org.Apache.Kafka.Server.Authorizer.AuthorizationResult>>("authorize", requestContext, actions);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.html#start(org.apache.kafka.server.authorizer.AuthorizerServerInfo)"/>
        /// </summary>
        /// <param name="serverInfo"><see cref="Org.Apache.Kafka.Server.Authorizer.AuthorizerServerInfo"/></param>
        /// <typeparam name="ReturnExtendsJava_Util_Concurrent_CompletionStage_Java_Lang_Void_"><see cref="Java.Util.Concurrent.CompletionStage{Java.Lang.Void}"/></typeparam>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Org.Apache.Kafka.Common.Endpoint, ReturnExtendsJava_Util_Concurrent_CompletionStage_Java_Lang_Void_> Start<ReturnExtendsJava_Util_Concurrent_CompletionStage_Java_Lang_Void_>(Org.Apache.Kafka.Server.Authorizer.AuthorizerServerInfo serverInfo) where ReturnExtendsJava_Util_Concurrent_CompletionStage_Java_Lang_Void_: Java.Util.Concurrent.CompletionStage<Java.Lang.Void>
        {
            return IExecute<Java.Util.Map<Org.Apache.Kafka.Common.Endpoint, ReturnExtendsJava_Util_Concurrent_CompletionStage_Java_Lang_Void_>>("start", serverInfo);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.html#authorizeByResourceType(org.apache.kafka.server.authorizer.AuthorizableRequestContext,org.apache.kafka.common.acl.AclOperation,org.apache.kafka.common.resource.ResourceType)"/>
        /// </summary>
        /// <param name="requestContext"><see cref="Org.Apache.Kafka.Server.Authorizer.AuthorizableRequestContext"/></param>
        /// <param name="op"><see cref="Org.Apache.Kafka.Common.Acl.AclOperation"/></param>
        /// <param name="resourceType"><see cref="Org.Apache.Kafka.Common.Resource.ResourceType"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Server.Authorizer.AuthorizationResult"/></returns>
        public Org.Apache.Kafka.Server.Authorizer.AuthorizationResult AuthorizeByResourceType(Org.Apache.Kafka.Server.Authorizer.AuthorizableRequestContext requestContext, Org.Apache.Kafka.Common.Acl.AclOperation op, Org.Apache.Kafka.Common.Resource.ResourceType resourceType)
        {
            return IExecute<Org.Apache.Kafka.Server.Authorizer.AuthorizationResult>("authorizeByResourceType", requestContext, op, resourceType);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.html#configure(java.util.Map)"/>
        /// </summary>
        /// <param name="javaConfigs"><see cref="Java.Util.Map"/></param>
        /// <typeparam name="JavaConfigsExtendsobject"></typeparam>
        public void Configure<JavaConfigsExtendsobject>(Java.Util.Map<string, JavaConfigsExtendsobject> javaConfigs)
        {
            IExecute("configure", javaConfigs);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.html#logAuditMessage(org.apache.kafka.server.authorizer.AuthorizableRequestContext,org.apache.kafka.server.authorizer.Action,boolean)"/>
        /// </summary>
        /// <param name="requestContext"><see cref="Org.Apache.Kafka.Server.Authorizer.AuthorizableRequestContext"/></param>
        /// <param name="action"><see cref="Org.Apache.Kafka.Server.Authorizer.Action"/></param>
        /// <param name="authorized"><see cref="bool"/></param>
        public void LogAuditMessage(Org.Apache.Kafka.Server.Authorizer.AuthorizableRequestContext requestContext, Org.Apache.Kafka.Server.Authorizer.Action action, bool authorized)
        {
            IExecute("logAuditMessage", requestContext, action, authorized);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.html#processAclChangeNotification(org.apache.kafka.common.resource.ResourcePattern)"/>
        /// </summary>
        /// <param name="resource"><see cref="Org.Apache.Kafka.Common.Resource.ResourcePattern"/></param>
        public void ProcessAclChangeNotification(Org.Apache.Kafka.Common.Resource.ResourcePattern resource)
        {
            IExecute("processAclChangeNotification", resource);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.html#startZkChangeListeners()"/>
        /// </summary>
        public void StartZkChangeListeners()
        {
            IExecute("startZkChangeListeners");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.html#updateCache(org.apache.kafka.common.resource.ResourcePattern,kafka.security.authorizer.AclAuthorizer.VersionedAcls)"/>
        /// </summary>
        /// <param name="resource"><see cref="Org.Apache.Kafka.Common.Resource.ResourcePattern"/></param>
        /// <param name="versionedAcls"><see cref="Kafka.Security.Authorizer.AclAuthorizer.VersionedAcls"/></param>
        public void UpdateCache(Org.Apache.Kafka.Common.Resource.ResourcePattern resource, Kafka.Security.Authorizer.AclAuthorizer.VersionedAcls versionedAcls)
        {
            IExecute("updateCache", resource, versionedAcls);
        }

        #endregion

        #region Nested classes
        #region AclSeqs
        public partial class AclSeqs
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
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.AclSeqs.html#isEmpty()"/> 
            /// </summary>
            public bool IsEmpty
            {
                get { return IExecute<bool>("isEmpty"); }
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ResourceOrdering
        public partial class ResourceOrdering
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
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.ResourceOrdering.html#equiv(java.lang.Object,java.lang.Object)"/>
            /// </summary>
            /// <param name="x"><see cref="object"/></param>
            /// <param name="y"><see cref="object"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool Equiv(object x, object y)
            {
                return IExecute<bool>("equiv", x, y);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.ResourceOrdering.html#gt(java.lang.Object,java.lang.Object)"/>
            /// </summary>
            /// <param name="x"><see cref="object"/></param>
            /// <param name="y"><see cref="object"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool Gt(object x, object y)
            {
                return IExecute<bool>("gt", x, y);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.ResourceOrdering.html#gteq(java.lang.Object,java.lang.Object)"/>
            /// </summary>
            /// <param name="x"><see cref="object"/></param>
            /// <param name="y"><see cref="object"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool Gteq(object x, object y)
            {
                return IExecute<bool>("gteq", x, y);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.ResourceOrdering.html#lt(java.lang.Object,java.lang.Object)"/>
            /// </summary>
            /// <param name="x"><see cref="object"/></param>
            /// <param name="y"><see cref="object"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool Lt(object x, object y)
            {
                return IExecute<bool>("lt", x, y);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.ResourceOrdering.html#lteq(java.lang.Object,java.lang.Object)"/>
            /// </summary>
            /// <param name="x"><see cref="object"/></param>
            /// <param name="y"><see cref="object"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool Lteq(object x, object y)
            {
                return IExecute<bool>("lteq", x, y);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.ResourceOrdering.html#compare(java.lang.Object,java.lang.Object)"/>
            /// </summary>
            /// <param name="x"><see cref="object"/></param>
            /// <param name="y"><see cref="object"/></param>
            /// <returns><see cref="int"/></returns>
            public int Compare(object x, object y)
            {
                return IExecute<int>("compare", x, y);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.ResourceOrdering.html#compare(org.apache.kafka.common.resource.ResourcePattern,org.apache.kafka.common.resource.ResourcePattern)"/>
            /// </summary>
            /// <param name="a"><see cref="Org.Apache.Kafka.Common.Resource.ResourcePattern"/></param>
            /// <param name="b"><see cref="Org.Apache.Kafka.Common.Resource.ResourcePattern"/></param>
            /// <returns><see cref="int"/></returns>
            public int Compare(Org.Apache.Kafka.Common.Resource.ResourcePattern a, Org.Apache.Kafka.Common.Resource.ResourcePattern b)
            {
                return IExecute<int>("compare", a, b);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.ResourceOrdering.html#max(java.lang.Object,java.lang.Object)"/>
            /// </summary>
            /// <param name="x"><see cref="object"/></param>
            /// <param name="y"><see cref="object"/></param>
            /// <returns><see cref="object"/></returns>
            public object Max(object x, object y)
            {
                return IExecute("max", x, y);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.ResourceOrdering.html#min(java.lang.Object,java.lang.Object)"/>
            /// </summary>
            /// <param name="x"><see cref="object"/></param>
            /// <param name="y"><see cref="object"/></param>
            /// <returns><see cref="object"/></returns>
            public object Min(object x, object y)
            {
                return IExecute("min", x, y);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region VersionedAcls
        public partial class VersionedAcls
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Kafka.Security.Authorizer.AclAuthorizer.VersionedAcls"/> to <see cref="Java.Io.Serializable"/>
            /// </summary>
            public static implicit operator Java.Io.Serializable(Kafka.Security.Authorizer.AclAuthorizer.VersionedAcls t) => t.Cast<Java.Io.Serializable>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.VersionedAcls.html#exists()"/> 
            /// </summary>
            public bool Exists
            {
                get { return IExecute<bool>("exists"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.VersionedAcls.html#productArity()"/> 
            /// </summary>
            public int ProductArity
            {
                get { return IExecute<int>("productArity"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.VersionedAcls.html#productPrefix()"/> 
            /// </summary>
            public string ProductPrefix
            {
                get { return IExecute<string>("productPrefix"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.VersionedAcls.html#zkVersion()"/> 
            /// </summary>
            public int ZkVersion
            {
                get { return IExecute<int>("zkVersion"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.VersionedAcls.html#canEqual(java.lang.Object)"/>
            /// </summary>
            /// <param name="x$1"><see cref="object"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool CanEqual(object x_1)
            {
                return IExecute<bool>("canEqual", x_1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.VersionedAcls.html#productElement(int)"/>
            /// </summary>
            /// <param name="x$1"><see cref="int"/></param>
            /// <returns><see cref="object"/></returns>
            public object ProductElement(int x_1)
            {
                return IExecute("productElement", x_1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/security/authorizer/AclAuthorizer.VersionedAcls.html#productElementName(int)"/>
            /// </summary>
            /// <param name="x$1"><see cref="int"/></param>
            /// <returns><see cref="string"/></returns>
            public string ProductElementName(int x_1)
            {
                return IExecute<string>("productElementName", x_1);
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