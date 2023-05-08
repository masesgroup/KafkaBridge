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
*  using kafka-clients-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Server.Policy
{
    #region CreateTopicPolicy
    public partial class CreateTopicPolicy
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Server.Policy.CreateTopicPolicy"/> to <see cref="Org.Apache.Kafka.Common.Configurable"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Configurable(Org.Apache.Kafka.Server.Policy.CreateTopicPolicy t) => t.Cast<Org.Apache.Kafka.Common.Configurable>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Server.Policy.CreateTopicPolicy"/> to <see cref="Java.Lang.AutoCloseable"/>
        /// </summary>
        public static implicit operator Java.Lang.AutoCloseable(Org.Apache.Kafka.Server.Policy.CreateTopicPolicy t) => t.Cast<Java.Lang.AutoCloseable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/server/policy/CreateTopicPolicy.html#validate(org.apache.kafka.server.policy.CreateTopicPolicy.RequestMetadata)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Server.Policy.CreateTopicPolicy.RequestMetadata"/></param>
        /// <exception cref="Org.Apache.Kafka.Common.Errors.PolicyViolationException"/>
        public void Validate(Org.Apache.Kafka.Server.Policy.CreateTopicPolicy.RequestMetadata arg0)
        {
            IExecute("validate", arg0);
        }

        #endregion

        #region Nested classes
        #region RequestMetadata
        public partial class RequestMetadata
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/server/policy/CreateTopicPolicy.RequestMetadata.html#%3Cinit%3E(java.lang.String,java.lang.Integer,java.lang.Short,java.util.Map,java.util.Map)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="short"/></param>
            /// <param name="arg3"><see cref="Java.Util.Map"/></param>
            /// <param name="arg4"><see cref="Java.Util.Map"/></param>
            public RequestMetadata(string arg0, int? arg1, short? arg2, Java.Util.Map arg3, Java.Util.Map arg4)
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
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/server/policy/CreateTopicPolicy.RequestMetadata.html#configs()"/> 
            /// </summary>
            public Java.Util.Map<string, string> Configs
            {
                get { return IExecute<Java.Util.Map<string, string>>("configs"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/server/policy/CreateTopicPolicy.RequestMetadata.html#numPartitions()"/> 
            /// </summary>
            public int? NumPartitions
            {
                get { return IExecute<int?>("numPartitions"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/server/policy/CreateTopicPolicy.RequestMetadata.html#replicasAssignments()"/> 
            /// </summary>
            public Java.Util.Map<int?, Java.Util.List<int?>> ReplicasAssignments
            {
                get { return IExecute<Java.Util.Map<int?, Java.Util.List<int?>>>("replicasAssignments"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/server/policy/CreateTopicPolicy.RequestMetadata.html#replicationFactor()"/> 
            /// </summary>
            public short? ReplicationFactor
            {
                get { return IExecute<short?>("replicationFactor"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/server/policy/CreateTopicPolicy.RequestMetadata.html#topic()"/> 
            /// </summary>
            public string Topic
            {
                get { return IExecute<string>("topic"); }
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