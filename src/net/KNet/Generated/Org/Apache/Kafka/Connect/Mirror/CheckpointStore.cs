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
*  using connect-mirror-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Mirror
{
    #region CheckpointStore
    public partial class CheckpointStore
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.8.0/org/apache/kafka/connect/mirror/CheckpointStore.html#org.apache.kafka.connect.mirror.CheckpointStore(org.apache.kafka.connect.mirror.MirrorCheckpointTaskConfig,java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Mirror.MirrorCheckpointTaskConfig"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        public CheckpointStore(Org.Apache.Kafka.Connect.Mirror.MirrorCheckpointTaskConfig arg0, Java.Util.Set<Java.Lang.String> arg1)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.8.0/org/apache/kafka/connect/mirror/CheckpointStore.html#isInitialized--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsInitialized()
        {
            return IExecuteWithSignature<bool>("isInitialized", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.8.0/org/apache/kafka/connect/mirror/CheckpointStore.html#start--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool Start()
        {
            return IExecuteWithSignature<bool>("start", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.8.0/org/apache/kafka/connect/mirror/CheckpointStore.html#computeConvertedUpstreamOffset--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Clients.Consumer.OffsetAndMetadata>> ComputeConvertedUpstreamOffset()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Clients.Consumer.OffsetAndMetadata>>>("computeConvertedUpstreamOffset", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.8.0/org/apache/kafka/connect/mirror/CheckpointStore.html#get-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Connect.Mirror.Checkpoint> Get(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Connect.Mirror.Checkpoint>>("get", "(Ljava/lang/String;)Ljava/util/Map;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.8.0/org/apache/kafka/connect/mirror/CheckpointStore.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.8.0/org/apache/kafka/connect/mirror/CheckpointStore.html#update-java.lang.String-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        public void Update(Java.Lang.String arg0, Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Org.Apache.Kafka.Connect.Mirror.Checkpoint> arg1)
        {
            IExecute("update", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}