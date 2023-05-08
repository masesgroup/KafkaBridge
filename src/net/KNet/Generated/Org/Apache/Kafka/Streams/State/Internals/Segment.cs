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
    #region Segment
    public partial class Segment
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.State.Internals.Segment"/> to <see cref="Org.Apache.Kafka.Streams.State.KeyValueStore"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.State.KeyValueStore(Org.Apache.Kafka.Streams.State.Internals.Segment t) => t.Cast<Org.Apache.Kafka.Streams.State.KeyValueStore>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.State.Internals.Segment"/> to <see cref="Org.Apache.Kafka.Streams.State.Internals.BatchWritingStore"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.State.Internals.BatchWritingStore(Org.Apache.Kafka.Streams.State.Internals.Segment t) => t.Cast<Org.Apache.Kafka.Streams.State.Internals.BatchWritingStore>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/Segment.html#deleteRange(org.apache.kafka.common.utils.Bytes,org.apache.kafka.common.utils.Bytes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Utils.Bytes"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Utils.Bytes"/></param>
        public void DeleteRange(Org.Apache.Kafka.Common.Utils.Bytes arg0, Org.Apache.Kafka.Common.Utils.Bytes arg1)
        {
            IExecute("deleteRange", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/state/internals/Segment.html#destroy()"/>
        /// </summary>

        /// <exception cref="Java.Io.IOException"/>
        public void Destroy()
        {
            IExecute("destroy");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}