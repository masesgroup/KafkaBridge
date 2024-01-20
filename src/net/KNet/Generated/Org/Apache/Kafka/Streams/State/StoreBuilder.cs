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
*  This file is generated by MASES.JNetReflector (ver. 2.2.1.0)
*  using kafka-streams-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.State
{
    #region StoreBuilder
    public partial class StoreBuilder
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/state/StoreBuilder.html#loggingEnabled--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool LoggingEnabled()
        {
            return IExecute<bool>("loggingEnabled");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/state/StoreBuilder.html#name--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string Name()
        {
            return IExecute<string>("name");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/state/StoreBuilder.html#logConfig--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map LogConfig()
        {
            return IExecute<Java.Util.Map>("logConfig");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/state/StoreBuilder.html#withCachingDisabled--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.State.StoreBuilder"/></returns>
        public Org.Apache.Kafka.Streams.State.StoreBuilder WithCachingDisabled()
        {
            return IExecute<Org.Apache.Kafka.Streams.State.StoreBuilder>("withCachingDisabled");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/state/StoreBuilder.html#withCachingEnabled--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.State.StoreBuilder"/></returns>
        public Org.Apache.Kafka.Streams.State.StoreBuilder WithCachingEnabled()
        {
            return IExecute<Org.Apache.Kafka.Streams.State.StoreBuilder>("withCachingEnabled");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/state/StoreBuilder.html#withLoggingDisabled--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.State.StoreBuilder"/></returns>
        public Org.Apache.Kafka.Streams.State.StoreBuilder WithLoggingDisabled()
        {
            return IExecute<Org.Apache.Kafka.Streams.State.StoreBuilder>("withLoggingDisabled");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/state/StoreBuilder.html#withLoggingEnabled-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.StoreBuilder"/></returns>
        public Org.Apache.Kafka.Streams.State.StoreBuilder WithLoggingEnabled(Java.Util.Map arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.StoreBuilder>("withLoggingEnabled", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/state/StoreBuilder.html#build--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.StateStore"/></returns>
        public Org.Apache.Kafka.Streams.Processor.StateStore Build()
        {
            return IExecute<Org.Apache.Kafka.Streams.Processor.StateStore>("build");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IStoreBuilder<T>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IStoreBuilder<T>
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region StoreBuilder<T>
    public partial class StoreBuilder<T> : Org.Apache.Kafka.Streams.State.IStoreBuilder<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.State.StoreBuilder{T}"/> to <see cref="Org.Apache.Kafka.Streams.State.StoreBuilder"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.State.StoreBuilder(Org.Apache.Kafka.Streams.State.StoreBuilder<T> t) => t.Cast<Org.Apache.Kafka.Streams.State.StoreBuilder>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/state/StoreBuilder.html#loggingEnabled--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool LoggingEnabled()
        {
            return IExecute<bool>("loggingEnabled");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/state/StoreBuilder.html#name--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string Name()
        {
            return IExecute<string>("name");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/state/StoreBuilder.html#logConfig--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<string, string> LogConfig()
        {
            return IExecute<Java.Util.Map<string, string>>("logConfig");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/state/StoreBuilder.html#withCachingDisabled--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.State.StoreBuilder"/></returns>
        public Org.Apache.Kafka.Streams.State.StoreBuilder<T> WithCachingDisabled()
        {
            return IExecute<Org.Apache.Kafka.Streams.State.StoreBuilder<T>>("withCachingDisabled");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/state/StoreBuilder.html#withCachingEnabled--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.State.StoreBuilder"/></returns>
        public Org.Apache.Kafka.Streams.State.StoreBuilder<T> WithCachingEnabled()
        {
            return IExecute<Org.Apache.Kafka.Streams.State.StoreBuilder<T>>("withCachingEnabled");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/state/StoreBuilder.html#withLoggingDisabled--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.State.StoreBuilder"/></returns>
        public Org.Apache.Kafka.Streams.State.StoreBuilder<T> WithLoggingDisabled()
        {
            return IExecute<Org.Apache.Kafka.Streams.State.StoreBuilder<T>>("withLoggingDisabled");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/state/StoreBuilder.html#withLoggingEnabled-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.StoreBuilder"/></returns>
        public Org.Apache.Kafka.Streams.State.StoreBuilder<T> WithLoggingEnabled(Java.Util.Map<string, string> arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.State.StoreBuilder<T>>("withLoggingEnabled", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/state/StoreBuilder.html#build--"/>
        /// </summary>

        /// <returns><typeparamref name="T"/></returns>
        public T Build()
        {
            return IExecute<T>("build");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}