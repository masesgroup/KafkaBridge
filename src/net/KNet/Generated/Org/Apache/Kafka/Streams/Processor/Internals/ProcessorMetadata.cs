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
    #region ProcessorMetadata
    public partial class ProcessorMetadata
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/ProcessorMetadata.html#%3Cinit%3E(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public ProcessorMetadata(Java.Util.Map arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/ProcessorMetadata.html#deserialize(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.Internals.ProcessorMetadata"/></returns>
        public static Org.Apache.Kafka.Streams.Processor.Internals.ProcessorMetadata Deserialize(byte[] arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Processor.Internals.ProcessorMetadata>(LocalBridgeClazz, "deserialize", new object[] { arg0 });
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/ProcessorMetadata.html#needsCommit()"/> 
        /// </summary>
        public bool NeedsCommit
        {
            get { return IExecute<bool>("needsCommit"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/ProcessorMetadata.html#serialize()"/> 
        /// </summary>
        public byte[] Serialize
        {
            get { return IExecuteArray<byte>("serialize"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/ProcessorMetadata.html#get(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="long"/></returns>
        public long? Get(string arg0)
        {
            return IExecute<long?>("get", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/ProcessorMetadata.html#put(java.lang.String,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        public void Put(string arg0, long arg1)
        {
            IExecute("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/ProcessorMetadata.html#setNeedsCommit(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetNeedsCommit(bool arg0)
        {
            IExecute("setNeedsCommit", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/processor/internals/ProcessorMetadata.html#update(org.apache.kafka.streams.processor.internals.ProcessorMetadata)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.Internals.ProcessorMetadata"/></param>
        public void Update(Org.Apache.Kafka.Streams.Processor.Internals.ProcessorMetadata arg0)
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