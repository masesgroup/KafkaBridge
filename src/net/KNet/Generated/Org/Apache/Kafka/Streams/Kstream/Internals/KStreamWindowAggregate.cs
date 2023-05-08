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
    #region KStreamWindowAggregate
    public partial class KStreamWindowAggregate
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/KStreamWindowAggregate.html#%3Cinit%3E(org.apache.kafka.streams.kstream.Windows,java.lang.String,org.apache.kafka.streams.kstream.EmitStrategy,org.apache.kafka.streams.kstream.Initializer,org.apache.kafka.streams.kstream.Aggregator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Windows"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Kstream.EmitStrategy"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Streams.Kstream.Initializer"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Streams.Kstream.Aggregator"/></param>
        public KStreamWindowAggregate(Org.Apache.Kafka.Streams.Kstream.Windows arg0, string arg1, Org.Apache.Kafka.Streams.Kstream.EmitStrategy arg2, Org.Apache.Kafka.Streams.Kstream.Initializer arg3, Org.Apache.Kafka.Streams.Kstream.Aggregator arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Kstream.Internals.KStreamWindowAggregate"/> to <see cref="Org.Apache.Kafka.Streams.Kstream.Internals.KStreamAggProcessorSupplier"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Kstream.Internals.KStreamAggProcessorSupplier(Org.Apache.Kafka.Streams.Kstream.Internals.KStreamWindowAggregate t) => t.Cast<Org.Apache.Kafka.Streams.Kstream.Internals.KStreamAggProcessorSupplier>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/KStreamWindowAggregate.html#get()"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.Processor.Api.Processor Get
        {
            get { return IExecute<Org.Apache.Kafka.Streams.Processor.Api.Processor>("get"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/KStreamWindowAggregate.html#view()"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.Kstream.Internals.KTableValueGetterSupplier View
        {
            get { return IExecute<Org.Apache.Kafka.Streams.Kstream.Internals.KTableValueGetterSupplier>("view"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/KStreamWindowAggregate.html#windows()"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.Kstream.Windows Windows
        {
            get { return IExecute<Org.Apache.Kafka.Streams.Kstream.Windows>("windows"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/KStreamWindowAggregate.html#enableSendingOldValues()"/>
        /// </summary>
        public void EnableSendingOldValues()
        {
            IExecute("enableSendingOldValues");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region KStreamWindowAggregate<KIn, VIn, VAgg, W>
    public partial class KStreamWindowAggregate<KIn, VIn, VAgg, W>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/KStreamWindowAggregate.html#%3Cinit%3E(org.apache.kafka.streams.kstream.Windows,java.lang.String,org.apache.kafka.streams.kstream.EmitStrategy,org.apache.kafka.streams.kstream.Initializer,org.apache.kafka.streams.kstream.Aggregator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Windows"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Streams.Kstream.EmitStrategy"/></param>
        /// <param name="arg3"><see cref="Org.Apache.Kafka.Streams.Kstream.Initializer"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Streams.Kstream.Aggregator"/></param>
        public KStreamWindowAggregate(Org.Apache.Kafka.Streams.Kstream.Windows<W> arg0, string arg1, Org.Apache.Kafka.Streams.Kstream.EmitStrategy arg2, Org.Apache.Kafka.Streams.Kstream.Initializer<VAgg> arg3, Org.Apache.Kafka.Streams.Kstream.Aggregator arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Kstream.Internals.KStreamWindowAggregate{KIn, VIn, VAgg, W}"/> to <see cref="Org.Apache.Kafka.Streams.Kstream.Internals.KStreamAggProcessorSupplier"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Kstream.Internals.KStreamAggProcessorSupplier(Org.Apache.Kafka.Streams.Kstream.Internals.KStreamWindowAggregate<KIn, VIn, VAgg, W> t) => t.Cast<Org.Apache.Kafka.Streams.Kstream.Internals.KStreamAggProcessorSupplier>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Kstream.Internals.KStreamWindowAggregate{KIn, VIn, VAgg, W}"/> to <see cref="Org.Apache.Kafka.Streams.Kstream.Internals.KStreamWindowAggregate"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Kstream.Internals.KStreamWindowAggregate(Org.Apache.Kafka.Streams.Kstream.Internals.KStreamWindowAggregate<KIn, VIn, VAgg, W> t) => t.Cast<Org.Apache.Kafka.Streams.Kstream.Internals.KStreamWindowAggregate>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/KStreamWindowAggregate.html#get()"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.Processor.Api.Processor<KIn, VIn, Org.Apache.Kafka.Streams.Kstream.Windowed<KIn>, Org.Apache.Kafka.Streams.Kstream.Internals.Change<VAgg>> Get
        {
            get { return IExecute<Org.Apache.Kafka.Streams.Processor.Api.Processor<KIn, VIn, Org.Apache.Kafka.Streams.Kstream.Windowed<KIn>, Org.Apache.Kafka.Streams.Kstream.Internals.Change<VAgg>>>("get"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/KStreamWindowAggregate.html#view()"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.Kstream.Internals.KTableValueGetterSupplier<Org.Apache.Kafka.Streams.Kstream.Windowed<KIn>, VAgg> View
        {
            get { return IExecute<Org.Apache.Kafka.Streams.Kstream.Internals.KTableValueGetterSupplier<Org.Apache.Kafka.Streams.Kstream.Windowed<KIn>, VAgg>>("view"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/KStreamWindowAggregate.html#windows()"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.Kstream.Windows<W> Windows
        {
            get { return IExecute<Org.Apache.Kafka.Streams.Kstream.Windows<W>>("windows"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/KStreamWindowAggregate.html#enableSendingOldValues()"/>
        /// </summary>
        public void EnableSendingOldValues()
        {
            IExecute("enableSendingOldValues");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}