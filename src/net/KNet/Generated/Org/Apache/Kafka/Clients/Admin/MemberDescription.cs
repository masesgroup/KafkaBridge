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
*  This file is generated by MASES.JNetReflector (ver. 2.5.3.0)
*  using kafka-clients-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Admin
{
    #region MemberDescription
    public partial class MemberDescription
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/admin/MemberDescription.html#org.apache.kafka.clients.admin.MemberDescription(java.lang.String,java.lang.String,java.lang.String,org.apache.kafka.clients.admin.MemberAssignment)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Clients.Admin.MemberAssignment"/></param>
        public MemberDescription(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, Org.Apache.Kafka.Clients.Admin.MemberAssignment arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/admin/MemberDescription.html#org.apache.kafka.clients.admin.MemberDescription(java.lang.String,java.util.Optional,java.lang.String,java.lang.String,org.apache.kafka.clients.admin.MemberAssignment)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Optional"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Clients.Admin.MemberAssignment"/></param>
        public MemberDescription(Java.Lang.String arg0, Java.Util.Optional<Java.Lang.String> arg1, Java.Lang.String arg2, Java.Lang.String arg3, Org.Apache.Kafka.Clients.Admin.MemberAssignment arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/admin/MemberDescription.html#clientId--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ClientId()
        {
            return IExecuteWithSignature<Java.Lang.String>("clientId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/admin/MemberDescription.html#consumerId--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ConsumerId()
        {
            return IExecuteWithSignature<Java.Lang.String>("consumerId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/admin/MemberDescription.html#host--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Host()
        {
            return IExecuteWithSignature<Java.Lang.String>("host", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/admin/MemberDescription.html#groupInstanceId--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Java.Lang.String> GroupInstanceId()
        {
            return IExecuteWithSignature<Java.Util.Optional<Java.Lang.String>>("groupInstanceId", "()Ljava/util/Optional;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/admin/MemberDescription.html#assignment--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.MemberAssignment"/></returns>
        public Org.Apache.Kafka.Clients.Admin.MemberAssignment Assignment()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Clients.Admin.MemberAssignment>("assignment", "()Lorg/apache/kafka/clients/admin/MemberAssignment;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}