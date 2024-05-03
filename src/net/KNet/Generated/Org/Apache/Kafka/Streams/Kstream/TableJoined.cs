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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using kafka-streams-3.6.2.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Kstream
{
    #region TableJoined
    public partial class TableJoined
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/TableJoined.html#as-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.TableJoined"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.TableJoined As(Java.Lang.String arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.TableJoined>(LocalBridgeClazz, "as", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/TableJoined.html#with-org.apache.kafka.streams.processor.StreamPartitioner-org.apache.kafka.streams.processor.StreamPartitioner-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.StreamPartitioner"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Processor.StreamPartitioner"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.TableJoined"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.TableJoined With(Org.Apache.Kafka.Streams.Processor.StreamPartitioner arg0, Org.Apache.Kafka.Streams.Processor.StreamPartitioner arg1)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.TableJoined>(LocalBridgeClazz, "with", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/TableJoined.html#withOtherPartitioner-org.apache.kafka.streams.processor.StreamPartitioner-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.StreamPartitioner"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.TableJoined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.TableJoined WithOtherPartitioner(Org.Apache.Kafka.Streams.Processor.StreamPartitioner arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.TableJoined>("withOtherPartitioner", "(Lorg/apache/kafka/streams/processor/StreamPartitioner;)Lorg/apache/kafka/streams/kstream/TableJoined;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/TableJoined.html#withPartitioner-org.apache.kafka.streams.processor.StreamPartitioner-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.StreamPartitioner"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.TableJoined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.TableJoined WithPartitioner(Org.Apache.Kafka.Streams.Processor.StreamPartitioner arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.TableJoined>("withPartitioner", "(Lorg/apache/kafka/streams/processor/StreamPartitioner;)Lorg/apache/kafka/streams/kstream/TableJoined;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TableJoined<K, KO>
    public partial class TableJoined<K, KO>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Kstream.TableJoined{K, KO}"/> to <see cref="Org.Apache.Kafka.Streams.Kstream.TableJoined"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Kstream.TableJoined(Org.Apache.Kafka.Streams.Kstream.TableJoined<K, KO> t) => t.Cast<Org.Apache.Kafka.Streams.Kstream.TableJoined>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/TableJoined.html#as-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.TableJoined"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.TableJoined<K, KO> As(Java.Lang.String arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.TableJoined<K, KO>>(LocalBridgeClazz, "as", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/TableJoined.html#with-org.apache.kafka.streams.processor.StreamPartitioner-org.apache.kafka.streams.processor.StreamPartitioner-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.StreamPartitioner"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.Processor.StreamPartitioner"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.TableJoined"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.TableJoined<K, KO> With(Org.Apache.Kafka.Streams.Processor.StreamPartitioner<K, Java.Lang.Void> arg0, Org.Apache.Kafka.Streams.Processor.StreamPartitioner<KO, Java.Lang.Void> arg1)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.TableJoined<K, KO>>(LocalBridgeClazz, "with", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/TableJoined.html#withOtherPartitioner-org.apache.kafka.streams.processor.StreamPartitioner-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.StreamPartitioner"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.TableJoined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.TableJoined<K, KO> WithOtherPartitioner(Org.Apache.Kafka.Streams.Processor.StreamPartitioner<KO, Java.Lang.Void> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.TableJoined<K, KO>>("withOtherPartitioner", "(Lorg/apache/kafka/streams/processor/StreamPartitioner;)Lorg/apache/kafka/streams/kstream/TableJoined;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/kstream/TableJoined.html#withPartitioner-org.apache.kafka.streams.processor.StreamPartitioner-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.StreamPartitioner"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.TableJoined"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.TableJoined<K, KO> WithPartitioner(Org.Apache.Kafka.Streams.Processor.StreamPartitioner<K, Java.Lang.Void> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.TableJoined<K, KO>>("withPartitioner", "(Lorg/apache/kafka/streams/processor/StreamPartitioner;)Lorg/apache/kafka/streams/kstream/TableJoined;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}