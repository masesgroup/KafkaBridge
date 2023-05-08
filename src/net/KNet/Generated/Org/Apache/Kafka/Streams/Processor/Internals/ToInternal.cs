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

namespace Org.Apache.Kafka.Streams.Processor.Internals
{
    #region ToInternal
    public partial class ToInternal
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/ToInternal.html#%3Cinit%3E(org.apache.kafka.streams.processor.To)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.To"/></param>
        public ToInternal(Org.Apache.Kafka.Streams.Processor.To arg0)
            : base(arg0)
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
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/ToInternal.html#child()"/> 
        /// </summary>
        public string Child
        {
            get { return IExecute<string>("child"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/ToInternal.html#hasTimestamp()"/> 
        /// </summary>
        public bool HasTimestamp
        {
            get { return IExecute<bool>("hasTimestamp"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/ToInternal.html#timestamp()"/> 
        /// </summary>
        public long Timestamp
        {
            get { return IExecute<long>("timestamp"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/ToInternal.html#update(org.apache.kafka.streams.processor.To)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.To"/></param>
        public void Update(Org.Apache.Kafka.Streams.Processor.To arg0)
        {
            IExecute("update", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}