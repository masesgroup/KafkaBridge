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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using kafka-clients-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Admin
{
    #region RemoveMembersFromConsumerGroupOptions
    public partial class RemoveMembersFromConsumerGroupOptions
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/admin/RemoveMembersFromConsumerGroupOptions.html#org.apache.kafka.clients.admin.RemoveMembersFromConsumerGroupOptions(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public RemoveMembersFromConsumerGroupOptions(Java.Util.Collection<Org.Apache.Kafka.Clients.Admin.MemberToRemove> arg0)
            : base(arg0)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/admin/RemoveMembersFromConsumerGroupOptions.html#removeAll--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveAll()
        {
            return IExecuteWithSignature<bool>("removeAll", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/admin/RemoveMembersFromConsumerGroupOptions.html#reason--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Reason()
        {
            return IExecuteWithSignature<Java.Lang.String>("reason", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/admin/RemoveMembersFromConsumerGroupOptions.html#members--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Org.Apache.Kafka.Clients.Admin.MemberToRemove> Members()
        {
            return IExecuteWithSignature<Java.Util.Set<Org.Apache.Kafka.Clients.Admin.MemberToRemove>>("members", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/admin/RemoveMembersFromConsumerGroupOptions.html#reason-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void Reason(Java.Lang.String arg0)
        {
            IExecuteWithSignature("reason", "(Ljava/lang/String;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}