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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using kafka-clients-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Security.Token.Delegation
{
    #region TokenInformation
    public partial class TokenInformation
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/security/token/delegation/TokenInformation.html#org.apache.kafka.common.security.token.delegation.TokenInformation(java.lang.String,org.apache.kafka.common.security.auth.KafkaPrincipal,java.util.Collection,long,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal"/></param>
        /// <param name="arg2"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        /// <param name="arg5"><see cref="long"/></param>
        public TokenInformation(Java.Lang.String arg0, Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal arg1, Java.Util.Collection<Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal> arg2, long arg3, long arg4, long arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/security/token/delegation/TokenInformation.html#org.apache.kafka.common.security.token.delegation.TokenInformation(java.lang.String,org.apache.kafka.common.security.auth.KafkaPrincipal,org.apache.kafka.common.security.auth.KafkaPrincipal,java.util.Collection,long,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal"/></param>
        /// <param name="arg3"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        /// <param name="arg5"><see cref="long"/></param>
        /// <param name="arg6"><see cref="long"/></param>
        public TokenInformation(Java.Lang.String arg0, Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal arg1, Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal arg2, Java.Util.Collection<Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal> arg3, long arg4, long arg5, long arg6)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/security/token/delegation/TokenInformation.html#fromRecord-java.lang.String-org.apache.kafka.common.security.auth.KafkaPrincipal-org.apache.kafka.common.security.auth.KafkaPrincipal-java.util.Collection-long-long-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal"/></param>
        /// <param name="arg3"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        /// <param name="arg5"><see cref="long"/></param>
        /// <param name="arg6"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Security.Token.Delegation.TokenInformation"/></returns>
        public static Org.Apache.Kafka.Common.Security.Token.Delegation.TokenInformation FromRecord(Java.Lang.String arg0, Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal arg1, Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal arg2, Java.Util.Collection<Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal> arg3, long arg4, long arg5, long arg6)
        {
            return SExecute<Org.Apache.Kafka.Common.Security.Token.Delegation.TokenInformation>(LocalBridgeClazz, "fromRecord", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/security/token/delegation/TokenInformation.html#ownerOrRenewer-org.apache.kafka.common.security.auth.KafkaPrincipal-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OwnerOrRenewer(Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal arg0)
        {
            return IExecuteWithSignature<bool>("ownerOrRenewer", "(Lorg/apache/kafka/common/security/auth/KafkaPrincipal;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/security/token/delegation/TokenInformation.html#ownerAsString--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String OwnerAsString()
        {
            return IExecuteWithSignature<Java.Lang.String>("ownerAsString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/security/token/delegation/TokenInformation.html#tokenId--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String TokenId()
        {
            return IExecuteWithSignature<Java.Lang.String>("tokenId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/security/token/delegation/TokenInformation.html#tokenRequesterAsString--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String TokenRequesterAsString()
        {
            return IExecuteWithSignature<Java.Lang.String>("tokenRequesterAsString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/security/token/delegation/TokenInformation.html#renewersAsString--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        public Java.Util.Collection<Java.Lang.String> RenewersAsString()
        {
            return IExecuteWithSignature<Java.Util.Collection<Java.Lang.String>>("renewersAsString", "()Ljava/util/Collection;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/security/token/delegation/TokenInformation.html#renewers--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        public Java.Util.Collection<Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal> Renewers()
        {
            return IExecuteWithSignature<Java.Util.Collection<Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal>>("renewers", "()Ljava/util/Collection;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/security/token/delegation/TokenInformation.html#expiryTimestamp--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long ExpiryTimestamp()
        {
            return IExecuteWithSignature<long>("expiryTimestamp", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/security/token/delegation/TokenInformation.html#issueTimestamp--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long IssueTimestamp()
        {
            return IExecuteWithSignature<long>("issueTimestamp", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/security/token/delegation/TokenInformation.html#maxTimestamp--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long MaxTimestamp()
        {
            return IExecuteWithSignature<long>("maxTimestamp", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/security/token/delegation/TokenInformation.html#owner--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal"/></returns>
        public Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal Owner()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal>("owner", "()Lorg/apache/kafka/common/security/auth/KafkaPrincipal;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/security/token/delegation/TokenInformation.html#tokenRequester--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal"/></returns>
        public Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal TokenRequester()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Security.Auth.KafkaPrincipal>("tokenRequester", "()Lorg/apache/kafka/common/security/auth/KafkaPrincipal;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/security/token/delegation/TokenInformation.html#setExpiryTimestamp-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetExpiryTimestamp(long arg0)
        {
            IExecuteWithSignature("setExpiryTimestamp", "(J)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}