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
    #region PrintedInternal
    public partial class PrintedInternal
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/PrintedInternal.html#%3Cinit%3E(org.apache.kafka.streams.kstream.Printed)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Printed"/></param>
        public PrintedInternal(Org.Apache.Kafka.Streams.Kstream.Printed arg0)
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
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/PrintedInternal.html#name()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("name"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/PrintedInternal.html#build(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.Api.ProcessorSupplier"/></returns>
        public Org.Apache.Kafka.Streams.Processor.Api.ProcessorSupplier Build(string arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Processor.Api.ProcessorSupplier>("build", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region PrintedInternal<K, V>
    public partial class PrintedInternal<K, V>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/PrintedInternal.html#%3Cinit%3E(org.apache.kafka.streams.kstream.Printed)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Printed"/></param>
        public PrintedInternal(Org.Apache.Kafka.Streams.Kstream.Printed<K, V> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Kstream.Internals.PrintedInternal{K, V}"/> to <see cref="Org.Apache.Kafka.Streams.Kstream.Internals.PrintedInternal"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Kstream.Internals.PrintedInternal(Org.Apache.Kafka.Streams.Kstream.Internals.PrintedInternal<K, V> t) => t.Cast<Org.Apache.Kafka.Streams.Kstream.Internals.PrintedInternal>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/PrintedInternal.html#name()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("name"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/PrintedInternal.html#build(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.Api.ProcessorSupplier"/></returns>
        public Org.Apache.Kafka.Streams.Processor.Api.ProcessorSupplier<K, V, Java.Lang.Void, Java.Lang.Void> Build(string arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Processor.Api.ProcessorSupplier<K, V, Java.Lang.Void, Java.Lang.Void>>("build", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}