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

namespace Org.Apache.Kafka.Streams.Kstream
{
    #region BranchedKStream
    public partial class BranchedKStream
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
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/BranchedKStream.html#noDefaultBranch()"/> 
        /// </summary>
        public Java.Util.Map NoDefaultBranch
        {
            get { return IExecute<Java.Util.Map>("noDefaultBranch"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/BranchedKStream.html#defaultBranch()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map DefaultBranch()
        {
            return IExecute<Java.Util.Map>("defaultBranch");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/BranchedKStream.html#defaultBranch(org.apache.kafka.streams.kstream.Branched)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Branched"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map DefaultBranch(Org.Apache.Kafka.Streams.Kstream.Branched arg0)
        {
            return IExecute<Java.Util.Map>("defaultBranch", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/BranchedKStream.html#branch(org.apache.kafka.streams.kstream.Predicate,org.apache.kafka.streams.kstream.Branched)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Predicate"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Branched"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.BranchedKStream"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.BranchedKStream Branch(Org.Apache.Kafka.Streams.Kstream.Predicate arg0, Org.Apache.Kafka.Streams.Kstream.Branched arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.BranchedKStream>("branch", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/BranchedKStream.html#branch(org.apache.kafka.streams.kstream.Predicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Predicate"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.BranchedKStream"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.BranchedKStream Branch(Org.Apache.Kafka.Streams.Kstream.Predicate arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.BranchedKStream>("branch", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region BranchedKStream<K, V>
    public partial class BranchedKStream<K, V>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Kstream.BranchedKStream{K, V}"/> to <see cref="Org.Apache.Kafka.Streams.Kstream.BranchedKStream"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Kstream.BranchedKStream(Org.Apache.Kafka.Streams.Kstream.BranchedKStream<K, V> t) => t.Cast<Org.Apache.Kafka.Streams.Kstream.BranchedKStream>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/BranchedKStream.html#noDefaultBranch()"/> 
        /// </summary>
        public Java.Util.Map<string, Org.Apache.Kafka.Streams.Kstream.KStream<K, V>> NoDefaultBranch
        {
            get { return IExecute<Java.Util.Map<string, Org.Apache.Kafka.Streams.Kstream.KStream<K, V>>>("noDefaultBranch"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/BranchedKStream.html#defaultBranch()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<string, Org.Apache.Kafka.Streams.Kstream.KStream<K, V>> DefaultBranch()
        {
            return IExecute<Java.Util.Map<string, Org.Apache.Kafka.Streams.Kstream.KStream<K, V>>>("defaultBranch");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/BranchedKStream.html#defaultBranch(org.apache.kafka.streams.kstream.Branched)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Branched"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<string, Org.Apache.Kafka.Streams.Kstream.KStream<K, V>> DefaultBranch(Org.Apache.Kafka.Streams.Kstream.Branched<K, V> arg0)
        {
            return IExecute<Java.Util.Map<string, Org.Apache.Kafka.Streams.Kstream.KStream<K, V>>>("defaultBranch", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/BranchedKStream.html#branch(org.apache.kafka.streams.kstream.Predicate,org.apache.kafka.streams.kstream.Branched)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Predicate"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Kstream.Branched"/></param>
        /// <typeparam name="Arg0objectSuperK"><typeparamref name="K"/></typeparam>
        /// <typeparam name="Arg0objectSuperV"></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.BranchedKStream"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.BranchedKStream<K, V> Branch<Arg0objectSuperK, Arg0objectSuperV>(Org.Apache.Kafka.Streams.Kstream.Predicate<Arg0objectSuperK, Arg0objectSuperV> arg0, Org.Apache.Kafka.Streams.Kstream.Branched<K, V> arg1) where Arg0objectSuperK: K
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.BranchedKStream<K, V>>("branch", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/BranchedKStream.html#branch(org.apache.kafka.streams.kstream.Predicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Predicate"/></param>
        /// <typeparam name="Arg0objectSuperK"><typeparamref name="K"/></typeparam>
        /// <typeparam name="Arg0objectSuperV"></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.BranchedKStream"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.BranchedKStream<K, V> Branch<Arg0objectSuperK, Arg0objectSuperV>(Org.Apache.Kafka.Streams.Kstream.Predicate<Arg0objectSuperK, Arg0objectSuperV> arg0) where Arg0objectSuperK: K
        {
            return IExecute<Org.Apache.Kafka.Streams.Kstream.BranchedKStream<K, V>>("branch", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}