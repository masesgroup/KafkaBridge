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
*  using kafka-streams-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.State
{
    #region IDslStoreSuppliers
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDslStoreSuppliers : Org.Apache.Kafka.Common.IConfigurable
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DslStoreSuppliers
    public partial class DslStoreSuppliers : Org.Apache.Kafka.Streams.State.IDslStoreSuppliers
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/DslStoreSuppliers.html#keyValueStore-org.apache.kafka.streams.state.DslKeyValueParams-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.State.DslKeyValueParams"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.KeyValueBytesStoreSupplier"/></returns>
        public Org.Apache.Kafka.Streams.State.KeyValueBytesStoreSupplier KeyValueStore(Org.Apache.Kafka.Streams.State.DslKeyValueParams arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.State.KeyValueBytesStoreSupplier>("keyValueStore", "(Lorg/apache/kafka/streams/state/DslKeyValueParams;)Lorg/apache/kafka/streams/state/KeyValueBytesStoreSupplier;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/DslStoreSuppliers.html#sessionStore-org.apache.kafka.streams.state.DslSessionParams-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.State.DslSessionParams"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.SessionBytesStoreSupplier"/></returns>
        public Org.Apache.Kafka.Streams.State.SessionBytesStoreSupplier SessionStore(Org.Apache.Kafka.Streams.State.DslSessionParams arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.State.SessionBytesStoreSupplier>("sessionStore", "(Lorg/apache/kafka/streams/state/DslSessionParams;)Lorg/apache/kafka/streams/state/SessionBytesStoreSupplier;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/DslStoreSuppliers.html#windowStore-org.apache.kafka.streams.state.DslWindowParams-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.State.DslWindowParams"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.WindowBytesStoreSupplier"/></returns>
        public Org.Apache.Kafka.Streams.State.WindowBytesStoreSupplier WindowStore(Org.Apache.Kafka.Streams.State.DslWindowParams arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.State.WindowBytesStoreSupplier>("windowStore", "(Lorg/apache/kafka/streams/state/DslWindowParams;)Lorg/apache/kafka/streams/state/WindowBytesStoreSupplier;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/DslStoreSuppliers.html#configure-java.util.Map-"/>
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