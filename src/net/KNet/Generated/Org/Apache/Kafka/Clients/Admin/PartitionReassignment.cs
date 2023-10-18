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
*  This file is generated by MASES.JNetReflector (ver. 2.0.2.0)
*  using kafka-clients-3.6.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Admin
{
    #region PartitionReassignment
    public partial class PartitionReassignment
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/admin/PartitionReassignment.html#org.apache.kafka.clients.admin.PartitionReassignment(java.util.List,java.util.List,java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        /// <param name="arg2"><see cref="Java.Util.List"/></param>
        public PartitionReassignment(Java.Util.List<Java.Lang.Integer> arg0, Java.Util.List<Java.Lang.Integer> arg1, Java.Util.List<Java.Lang.Integer> arg2)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/admin/PartitionReassignment.html#addingReplicas--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Lang.Integer> AddingReplicas()
        {
            return IExecute<Java.Util.List<Java.Lang.Integer>>("addingReplicas");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/admin/PartitionReassignment.html#removingReplicas--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Lang.Integer> RemovingReplicas()
        {
            return IExecute<Java.Util.List<Java.Lang.Integer>>("removingReplicas");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/admin/PartitionReassignment.html#replicas--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Lang.Integer> Replicas()
        {
            return IExecute<Java.Util.List<Java.Lang.Integer>>("replicas");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}