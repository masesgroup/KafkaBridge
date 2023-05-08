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
*  using kafka-streams-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.State.Internals
{
    #region RocksDbSessionBytesStoreSupplier
    public partial class RocksDbSessionBytesStoreSupplier
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/RocksDbSessionBytesStoreSupplier.html#%3Cinit%3E(java.lang.String,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        public RocksDbSessionBytesStoreSupplier(string arg0, long arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.State.Internals.RocksDbSessionBytesStoreSupplier"/> to <see cref="Org.Apache.Kafka.Streams.State.SessionBytesStoreSupplier"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.State.SessionBytesStoreSupplier(Org.Apache.Kafka.Streams.State.Internals.RocksDbSessionBytesStoreSupplier t) => t.Cast<Org.Apache.Kafka.Streams.State.SessionBytesStoreSupplier>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/RocksDbSessionBytesStoreSupplier.html#get()"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.Processor.StateStore Get
        {
            get { return IExecute<Org.Apache.Kafka.Streams.Processor.StateStore>("get"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/RocksDbSessionBytesStoreSupplier.html#metricsScope()"/> 
        /// </summary>
        public string MetricsScope
        {
            get { return IExecute<string>("metricsScope"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/RocksDbSessionBytesStoreSupplier.html#name()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("name"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/RocksDbSessionBytesStoreSupplier.html#retentionPeriod()"/> 
        /// </summary>
        public long RetentionPeriod
        {
            get { return IExecute<long>("retentionPeriod"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/RocksDbSessionBytesStoreSupplier.html#segmentIntervalMs()"/> 
        /// </summary>
        public long SegmentIntervalMs
        {
            get { return IExecute<long>("segmentIntervalMs"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}