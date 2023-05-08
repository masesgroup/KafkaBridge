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

namespace Org.Apache.Kafka.Clients.Admin
{
    #region NewTopic
    public partial class NewTopic
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/NewTopic.html#%3Cinit%3E(java.lang.String,int,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="short"/></param>
        public NewTopic(string arg0, int arg1, short arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/NewTopic.html#%3Cinit%3E(java.lang.String,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        public NewTopic(string arg0, Java.Util.Map arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/NewTopic.html#%3Cinit%3E(java.lang.String,java.util.Optional,java.util.Optional)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.Optional"/></param>
        /// <param name="arg2"><see cref="Java.Util.Optional"/></param>
        public NewTopic(string arg0, Java.Util.Optional arg1, Java.Util.Optional arg2)
            : base(arg0, arg1, arg2)
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
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/NewTopic.html#name()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("name"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/NewTopic.html#numPartitions()"/> 
        /// </summary>
        public int NumPartitions
        {
            get { return IExecute<int>("numPartitions"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/NewTopic.html#replicasAssignments()"/> 
        /// </summary>
        public Java.Util.Map<int?, Java.Util.List<int?>> ReplicasAssignments
        {
            get { return IExecute<Java.Util.Map<int?, Java.Util.List<int?>>>("replicasAssignments"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/NewTopic.html#replicationFactor()"/> 
        /// </summary>
        public short ReplicationFactor
        {
            get { return IExecute<short>("replicationFactor"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/NewTopic.html#configs()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<string, string> Configs()
        {
            return IExecute<Java.Util.Map<string, string>>("configs");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/NewTopic.html#configs(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.NewTopic"/></returns>
        public Org.Apache.Kafka.Clients.Admin.NewTopic Configs(Java.Util.Map<string, string> arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.NewTopic>("configs", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}