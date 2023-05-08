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

namespace Org.Apache.Kafka.Streams.Kstream.Internals
{
    #region TableJoinedInternal
    public partial class TableJoinedInternal
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
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/TableJoinedInternal.html#name()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("name"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/TableJoinedInternal.html#otherPartitioner()"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.Processor.StreamPartitioner OtherPartitioner
        {
            get { return IExecute<Org.Apache.Kafka.Streams.Processor.StreamPartitioner>("otherPartitioner"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/TableJoinedInternal.html#partitioner()"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.Processor.StreamPartitioner Partitioner
        {
            get { return IExecute<Org.Apache.Kafka.Streams.Processor.StreamPartitioner>("partitioner"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TableJoinedInternal<K, KO>
    public partial class TableJoinedInternal<K, KO>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Kstream.Internals.TableJoinedInternal{K, KO}"/> to <see cref="Org.Apache.Kafka.Streams.Kstream.Internals.TableJoinedInternal"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Kstream.Internals.TableJoinedInternal(Org.Apache.Kafka.Streams.Kstream.Internals.TableJoinedInternal<K, KO> t) => t.Cast<Org.Apache.Kafka.Streams.Kstream.Internals.TableJoinedInternal>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/TableJoinedInternal.html#name()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("name"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/TableJoinedInternal.html#otherPartitioner()"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.Processor.StreamPartitioner<KO, Java.Lang.Void> OtherPartitioner
        {
            get { return IExecute<Org.Apache.Kafka.Streams.Processor.StreamPartitioner<KO, Java.Lang.Void>>("otherPartitioner"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/TableJoinedInternal.html#partitioner()"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.Processor.StreamPartitioner<K, Java.Lang.Void> Partitioner
        {
            get { return IExecute<Org.Apache.Kafka.Streams.Processor.StreamPartitioner<K, Java.Lang.Void>>("partitioner"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}