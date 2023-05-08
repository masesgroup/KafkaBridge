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

namespace Org.Apache.Kafka.Streams.State
{
    #region WindowBytesStoreSupplier
    public partial class WindowBytesStoreSupplier
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
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/WindowBytesStoreSupplier.html#retainDuplicates()"/> 
        /// </summary>
        public bool RetainDuplicates
        {
            get { return IExecute<bool>("retainDuplicates"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/WindowBytesStoreSupplier.html#retentionPeriod()"/> 
        /// </summary>
        public long RetentionPeriod
        {
            get { return IExecute<long>("retentionPeriod"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/WindowBytesStoreSupplier.html#segmentIntervalMs()"/> 
        /// </summary>
        public long SegmentIntervalMs
        {
            get { return IExecute<long>("segmentIntervalMs"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/WindowBytesStoreSupplier.html#windowSize()"/> 
        /// </summary>
        public long WindowSize
        {
            get { return IExecute<long>("windowSize"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}