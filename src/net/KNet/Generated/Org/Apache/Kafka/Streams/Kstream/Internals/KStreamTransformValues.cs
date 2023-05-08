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
    #region KStreamTransformValues
    public partial class KStreamTransformValues
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Kstream.Internals.KStreamTransformValues"/> to <see cref="Org.Apache.Kafka.Streams.Processor.Api.ProcessorSupplier"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Processor.Api.ProcessorSupplier(Org.Apache.Kafka.Streams.Kstream.Internals.KStreamTransformValues t) => t.Cast<Org.Apache.Kafka.Streams.Processor.Api.ProcessorSupplier>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/KStreamTransformValues.html#get()"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.Processor.Api.Processor Get
        {
            get { return IExecute<Org.Apache.Kafka.Streams.Processor.Api.Processor>("get"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/KStreamTransformValues.html#stores()"/> 
        /// </summary>
        public Java.Util.Set Stores
        {
            get { return IExecute<Java.Util.Set>("stores"); }
        }

        #endregion

        #region Nested classes
        #region KStreamTransformValuesProcessor
        public partial class KStreamTransformValuesProcessor
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

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region KStreamTransformValuesProcessor<KIn, VIn, VOut>
        public partial class KStreamTransformValuesProcessor<KIn, VIn, VOut>
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Org.Apache.Kafka.Streams.Kstream.Internals.KStreamTransformValues.KStreamTransformValuesProcessor{KIn, VIn, VOut}"/> to <see cref="Org.Apache.Kafka.Streams.Kstream.Internals.KStreamTransformValues.KStreamTransformValuesProcessor"/>
            /// </summary>
            public static implicit operator Org.Apache.Kafka.Streams.Kstream.Internals.KStreamTransformValues.KStreamTransformValuesProcessor(Org.Apache.Kafka.Streams.Kstream.Internals.KStreamTransformValues.KStreamTransformValuesProcessor<KIn, VIn, VOut> t) => t.Cast<Org.Apache.Kafka.Streams.Kstream.Internals.KStreamTransformValues.KStreamTransformValuesProcessor>();

            #endregion

            #region Fields

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

    
        #endregion

        // TODO: complete the class
    }
    #endregion

    #region KStreamTransformValues<KIn, VIn, VOut>
    public partial class KStreamTransformValues<KIn, VIn, VOut>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Kstream.Internals.KStreamTransformValues{KIn, VIn, VOut}"/> to <see cref="Org.Apache.Kafka.Streams.Processor.Api.ProcessorSupplier"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Processor.Api.ProcessorSupplier(Org.Apache.Kafka.Streams.Kstream.Internals.KStreamTransformValues<KIn, VIn, VOut> t) => t.Cast<Org.Apache.Kafka.Streams.Processor.Api.ProcessorSupplier>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Kstream.Internals.KStreamTransformValues{KIn, VIn, VOut}"/> to <see cref="Org.Apache.Kafka.Streams.Kstream.Internals.KStreamTransformValues"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Kstream.Internals.KStreamTransformValues(Org.Apache.Kafka.Streams.Kstream.Internals.KStreamTransformValues<KIn, VIn, VOut> t) => t.Cast<Org.Apache.Kafka.Streams.Kstream.Internals.KStreamTransformValues>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/KStreamTransformValues.html#get()"/> 
        /// </summary>
        public Org.Apache.Kafka.Streams.Processor.Api.Processor<KIn, VIn, KIn, VOut> Get
        {
            get { return IExecute<Org.Apache.Kafka.Streams.Processor.Api.Processor<KIn, VIn, KIn, VOut>>("get"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/internals/KStreamTransformValues.html#stores()"/> 
        /// </summary>
        public Java.Util.Set Stores
        {
            get { return IExecute<Java.Util.Set>("stores"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}