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

namespace Org.Apache.Kafka.Clients.Producer
{
    #region RoundRobinPartitioner
    public partial class RoundRobinPartitioner
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Clients.Producer.RoundRobinPartitioner"/> to <see cref="Org.Apache.Kafka.Clients.Producer.Partitioner"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Clients.Producer.Partitioner(Org.Apache.Kafka.Clients.Producer.RoundRobinPartitioner t) => t.Cast<Org.Apache.Kafka.Clients.Producer.Partitioner>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/RoundRobinPartitioner.html#partition-java.lang.String-java.lang.Object-byte[]-java.lang.Object-byte[]-org.apache.kafka.common.Cluster-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <param name="arg4"><see cref="byte"/></param>
        /// <param name="arg5"><see cref="Org.Apache.Kafka.Common.Cluster"/></param>
        /// <returns><see cref="int"/></returns>
        public int Partition(Java.Lang.String arg0, object arg1, byte[] arg2, object arg3, byte[] arg4, Org.Apache.Kafka.Common.Cluster arg5)
        {
            return IExecute<int>("partition", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/RoundRobinPartitioner.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/producer/RoundRobinPartitioner.html#configure-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public void Configure(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            IExecuteWithSignature("configure", "(Ljava/util/Map;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}