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
*  using kafka-streams-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.State
{
    #region IWindowBytesStoreSupplier
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IWindowBytesStoreSupplier : Org.Apache.Kafka.Streams.State.IStoreSupplier<Org.Apache.Kafka.Streams.State.WindowStore<Org.Apache.Kafka.Common.Utils.Bytes, byte[]>>
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region WindowBytesStoreSupplier
    public partial class WindowBytesStoreSupplier : Org.Apache.Kafka.Streams.State.IWindowBytesStoreSupplier
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/WindowBytesStoreSupplier.html#retainDuplicates--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool RetainDuplicates()
        {
            return IExecuteWithSignature<bool>("retainDuplicates", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/WindowBytesStoreSupplier.html#retentionPeriod--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long RetentionPeriod()
        {
            return IExecuteWithSignature<long>("retentionPeriod", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/WindowBytesStoreSupplier.html#segmentIntervalMs--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long SegmentIntervalMs()
        {
            return IExecuteWithSignature<long>("segmentIntervalMs", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/state/WindowBytesStoreSupplier.html#windowSize--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long WindowSize()
        {
            return IExecuteWithSignature<long>("windowSize", "()J");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}