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
    #region IChannelBuilder
    /// <summary>
    /// .NET interface for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/network/ChannelBuilder.html"/>
    /// </summary>
    public partial interface IChannelBuilder
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ChannelBuilder
    public partial class ChannelBuilder : Org.Apache.Kafka.Common.Network.IChannelBuilder, Java.Lang.IAutoCloseable, Org.Apache.Kafka.Common.IConfigurable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Common.Network.ChannelBuilder"/> to <see cref="Java.Lang.AutoCloseable"/>
        /// </summary>
        public static implicit operator Java.Lang.AutoCloseable(Org.Apache.Kafka.Common.Network.ChannelBuilder t) => t.Cast<Java.Lang.AutoCloseable>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Common.Network.ChannelBuilder"/> to <see cref="Org.Apache.Kafka.Common.Configurable"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Configurable(Org.Apache.Kafka.Common.Network.ChannelBuilder t) => t.Cast<Org.Apache.Kafka.Common.Configurable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/network/ChannelBuilder.html#buildChannel(java.lang.String,java.nio.channels.SelectionKey,int,org.apache.kafka.common.memory.MemoryPool,org.apache.kafka.common.network.ChannelMetadataRegistry)"/>
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/network/ChannelBuilder.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}