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
*  using kafka-tools-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Tools.Reassign
{
    #region ReassignPartitionsCommand
    public partial class ReassignPartitionsCommand
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.1/org/apache/kafka/tools/reassign/ReassignPartitionsCommand.html#formatAsReassignmentJson-java.util.Map-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Com.Fasterxml.Jackson.Core.JsonProcessingException"/>
        public static Java.Lang.String FormatAsReassignmentJson(Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Java.Util.List<Java.Lang.Integer>> arg0, Java.Util.Map<Org.Apache.Kafka.Common.TopicPartitionReplica, Java.Lang.String> arg1)
        {
            return SExecute<Java.Lang.String>(LocalBridgeClazz, "formatAsReassignmentJson", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.1/org/apache/kafka/tools/reassign/ReassignPartitionsCommand.html#generateAssignment-org.apache.kafka.clients.admin.Admin-java.lang.String-java.lang.String-java.lang.Boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Admin.Admin"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.Boolean"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Tools.Reassign.Tuple2"/></returns>
        /// <exception cref="Java.Util.Concurrent.ExecutionException"/>
        /// <exception cref="Java.Lang.InterruptedException"/>
        /// <exception cref="Com.Fasterxml.Jackson.Core.JsonProcessingException"/>
        public static Org.Apache.Kafka.Tools.Reassign.Tuple2<Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Java.Util.List<Java.Lang.Integer>>, Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Java.Util.List<Java.Lang.Integer>>> GenerateAssignment(Org.Apache.Kafka.Clients.Admin.Admin arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.Boolean arg3)
        {
            return SExecute<Org.Apache.Kafka.Tools.Reassign.Tuple2<Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Java.Util.List<Java.Lang.Integer>>, Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Java.Util.List<Java.Lang.Integer>>>>(LocalBridgeClazz, "generateAssignment", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.1/org/apache/kafka/tools/reassign/ReassignPartitionsCommand.html#executeAssignment-org.apache.kafka.clients.admin.Admin-java.lang.Boolean-java.lang.String-java.lang.Long-java.lang.Long-java.lang.Long-org.apache.kafka.common.utils.Time-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Admin.Admin"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Boolean"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.Long"/></param>
        /// <param name="arg4"><see cref="Java.Lang.Long"/></param>
        /// <param name="arg5"><see cref="Java.Lang.Long"/></param>
        /// <param name="arg6"><see cref="Org.Apache.Kafka.Common.Utils.Time"/></param>
        /// <exception cref="Java.Util.Concurrent.ExecutionException"/>
        /// <exception cref="Java.Lang.InterruptedException"/>
        /// <exception cref="Com.Fasterxml.Jackson.Core.JsonProcessingException"/>
        /// <exception cref="Org.Apache.Kafka.Tools.TerseException"/>
        public static void ExecuteAssignment(Org.Apache.Kafka.Clients.Admin.Admin arg0, Java.Lang.Boolean arg1, Java.Lang.String arg2, Java.Lang.Long arg3, Java.Lang.Long arg4, Java.Lang.Long arg5, Org.Apache.Kafka.Common.Utils.Time arg6)
        {
            SExecute(LocalBridgeClazz, "executeAssignment", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.1/org/apache/kafka/tools/reassign/ReassignPartitionsCommand.html#main-java.lang.String[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public static void Main(Java.Lang.String[] arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "main", "([Ljava/lang/String;)V", new object[] { arg0 });
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