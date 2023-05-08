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
    #region LogDirDescription
    public partial class LogDirDescription
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/LogDirDescription.html#%3Cinit%3E(org.apache.kafka.common.errors.ApiException,java.util.Map,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Errors.ApiException"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        public LogDirDescription(Org.Apache.Kafka.Common.Errors.ApiException arg0, Java.Util.Map arg1, long arg2, long arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/LogDirDescription.html#%3Cinit%3E(org.apache.kafka.common.errors.ApiException,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Errors.ApiException"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        public LogDirDescription(Org.Apache.Kafka.Common.Errors.ApiException arg0, Java.Util.Map arg1)
            : base(arg0, arg1)
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
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/LogDirDescription.html#error()"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.Errors.ApiException Error
        {
            get { var obj = IExecute<MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject>("error"); return MASES.JCOBridge.C2JBridge.JVMBridgeException.New<Org.Apache.Kafka.Common.Errors.ApiException>(obj); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/LogDirDescription.html#replicaInfos()"/> 
        /// </summary>
        public Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Clients.Admin.ReplicaInfo> ReplicaInfos
        {
            get { return IExecute<Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Clients.Admin.ReplicaInfo>>("replicaInfos"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/LogDirDescription.html#totalBytes()"/> 
        /// </summary>
        public Java.Util.OptionalLong TotalBytes
        {
            get { return IExecute<Java.Util.OptionalLong>("totalBytes"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/clients/admin/LogDirDescription.html#usableBytes()"/> 
        /// </summary>
        public Java.Util.OptionalLong UsableBytes
        {
            get { return IExecute<Java.Util.OptionalLong>("usableBytes"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}