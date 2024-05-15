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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*  using kafka-clients-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Admin
{
    #region ConsumerGroupDescription
    public partial class ConsumerGroupDescription
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/admin/ConsumerGroupDescription.html#org.apache.kafka.clients.admin.ConsumerGroupDescription(java.lang.String,boolean,java.util.Collection,java.lang.String,org.apache.kafka.common.ConsumerGroupState,org.apache.kafka.common.Node,java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Common.ConsumerGroupState"/></param>
        /// <param name="arg5"><see cref="Org.Apache.Kafka.Common.Node"/></param>
        /// <param name="arg6"><see cref="Java.Util.Set"/></param>
        public ConsumerGroupDescription(Java.Lang.String arg0, bool arg1, Java.Util.Collection<Org.Apache.Kafka.Clients.Admin.MemberDescription> arg2, Java.Lang.String arg3, Org.Apache.Kafka.Common.ConsumerGroupState arg4, Org.Apache.Kafka.Common.Node arg5, Java.Util.Set<Org.Apache.Kafka.Common.Acl.AclOperation> arg6)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/admin/ConsumerGroupDescription.html#org.apache.kafka.clients.admin.ConsumerGroupDescription(java.lang.String,boolean,java.util.Collection,java.lang.String,org.apache.kafka.common.ConsumerGroupState,org.apache.kafka.common.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Common.ConsumerGroupState"/></param>
        /// <param name="arg5"><see cref="Org.Apache.Kafka.Common.Node"/></param>
        public ConsumerGroupDescription(Java.Lang.String arg0, bool arg1, Java.Util.Collection<Org.Apache.Kafka.Clients.Admin.MemberDescription> arg2, Java.Lang.String arg3, Org.Apache.Kafka.Common.ConsumerGroupState arg4, Org.Apache.Kafka.Common.Node arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/admin/ConsumerGroupDescription.html#isSimpleConsumerGroup--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsSimpleConsumerGroup()
        {
            return IExecuteWithSignature<bool>("isSimpleConsumerGroup", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/admin/ConsumerGroupDescription.html#groupId--"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GroupId()
        {
            return IExecuteWithSignature<Java.Lang.String>("groupId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/admin/ConsumerGroupDescription.html#partitionAssignor--"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String PartitionAssignor()
        {
            return IExecuteWithSignature<Java.Lang.String>("partitionAssignor", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/admin/ConsumerGroupDescription.html#members--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Collection"/></returns>
        public Java.Util.Collection<Org.Apache.Kafka.Clients.Admin.MemberDescription> Members()
        {
            return IExecuteWithSignature<Java.Util.Collection<Org.Apache.Kafka.Clients.Admin.MemberDescription>>("members", "()Ljava/util/Collection;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/admin/ConsumerGroupDescription.html#authorizedOperations--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Org.Apache.Kafka.Common.Acl.AclOperation> AuthorizedOperations()
        {
            return IExecuteWithSignature<Java.Util.Set<Org.Apache.Kafka.Common.Acl.AclOperation>>("authorizedOperations", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/admin/ConsumerGroupDescription.html#state--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.ConsumerGroupState"/></returns>
        public Org.Apache.Kafka.Common.ConsumerGroupState State()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.ConsumerGroupState>("state", "()Lorg/apache/kafka/common/ConsumerGroupState;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/admin/ConsumerGroupDescription.html#coordinator--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Node"/></returns>
        public Org.Apache.Kafka.Common.Node Coordinator()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Node>("coordinator", "()Lorg/apache/kafka/common/Node;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}