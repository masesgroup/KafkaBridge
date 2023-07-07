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
*  using kafka-clients-3.5.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Consumer
{
    #region ConsumerGroupMetadata
    public partial class ConsumerGroupMetadata
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/consumer/ConsumerGroupMetadata.html#org.apache.kafka.clients.consumer.ConsumerGroupMetadata(java.lang.String,int,java.lang.String,java.util.Optional)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="Java.Util.Optional"/></param>
        public ConsumerGroupMetadata(string arg0, int arg1, string arg2, Java.Util.Optional<string> arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/consumer/ConsumerGroupMetadata.html#org.apache.kafka.clients.consumer.ConsumerGroupMetadata(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public ConsumerGroupMetadata(string arg0)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/consumer/ConsumerGroupMetadata.html#generationId--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int GenerationId()
        {
            return IExecute<int>("generationId");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/consumer/ConsumerGroupMetadata.html#groupId--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string GroupId()
        {
            return IExecute<string>("groupId");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/consumer/ConsumerGroupMetadata.html#memberId--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string MemberId()
        {
            return IExecute<string>("memberId");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/consumer/ConsumerGroupMetadata.html#groupInstanceId--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<string> GroupInstanceId()
        {
            return IExecute<Java.Util.Optional<string>>("groupInstanceId");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}