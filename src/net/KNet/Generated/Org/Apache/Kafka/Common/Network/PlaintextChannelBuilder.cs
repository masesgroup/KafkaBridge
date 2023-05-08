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

namespace Org.Apache.Kafka.Common.Network
{
    #region PlaintextChannelBuilder
    public partial class PlaintextChannelBuilder
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/network/PlaintextChannelBuilder.html#%3Cinit%3E(org.apache.kafka.common.network.ListenerName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Network.ListenerName"/></param>
        public PlaintextChannelBuilder(Org.Apache.Kafka.Common.Network.ListenerName arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Common.Network.PlaintextChannelBuilder"/> to <see cref="Org.Apache.Kafka.Common.Network.ChannelBuilder"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Network.ChannelBuilder(Org.Apache.Kafka.Common.Network.PlaintextChannelBuilder t) => t.Cast<Org.Apache.Kafka.Common.Network.ChannelBuilder>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/network/PlaintextChannelBuilder.html#buildChannel(java.lang.String,java.nio.channels.SelectionKey,int,org.apache.kafka.common.memory.MemoryPool,org.apache.kafka.common.network.ChannelMetadataRegistry)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Nio.Channels.SelectionKey"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Common.Memory.MemoryPool"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Common.Network.ChannelMetadataRegistry"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Network.KafkaChannel"/></returns>
        /// <exception cref="Org.Apache.Kafka.Common.KafkaException"/>
        public Org.Apache.Kafka.Common.Network.KafkaChannel BuildChannel(string arg0, Java.Nio.Channels.SelectionKey arg1, int arg2, Org.Apache.Kafka.Common.Memory.MemoryPool arg3, Org.Apache.Kafka.Common.Network.ChannelMetadataRegistry arg4)
        {
            return IExecute<Org.Apache.Kafka.Common.Network.KafkaChannel>("buildChannel", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/network/PlaintextChannelBuilder.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/network/PlaintextChannelBuilder.html#configure(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <typeparam name="Arg0Extendsobject"></typeparam>
        /// <exception cref="Org.Apache.Kafka.Common.KafkaException"/>
        public void Configure<Arg0Extendsobject>(Java.Util.Map<string, Arg0Extendsobject> arg0)
        {
            IExecute("configure", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}