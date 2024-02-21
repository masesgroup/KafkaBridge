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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using kafka-raft-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Raft
{
    #region LogOffsetMetadata
    public partial class LogOffsetMetadata
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/raft/LogOffsetMetadata.html#org.apache.kafka.raft.LogOffsetMetadata(long,java.util.Optional)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Optional"/></param>
        public LogOffsetMetadata(long arg0, Java.Util.Optional<Org.Apache.Kafka.Raft.OffsetMetadata> arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/raft/LogOffsetMetadata.html#org.apache.kafka.raft.LogOffsetMetadata(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public LogOffsetMetadata(long arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/raft/LogOffsetMetadata.html#metadata"/>
        /// </summary>
        public Java.Util.Optional metadata { get { if (!_metadataReady) { _metadataContent = IGetField<Java.Util.Optional>("metadata"); _metadataReady = true; } return _metadataContent; } }
        private Java.Util.Optional _metadataContent = default;
        private bool _metadataReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.1/org/apache/kafka/raft/LogOffsetMetadata.html#offset"/>
        /// </summary>
        public long offset { get { if (!_offsetReady) { _offsetContent = IGetField<long>("offset"); _offsetReady = true; } return _offsetContent; } }
        private long _offsetContent = default;
        private bool _offsetReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}