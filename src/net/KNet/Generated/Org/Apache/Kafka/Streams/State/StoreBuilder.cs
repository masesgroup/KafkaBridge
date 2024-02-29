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
            return IExecuteWithSignature<bool>("loggingEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/state/StoreBuilder.html#name--"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Name()
        {
            return IExecuteWithSignature<Java.Lang.String>("name", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/state/StoreBuilder.html#logConfig--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map LogConfig()
        {
            return IExecuteWithSignature<Java.Util.Map>("logConfig", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/state/StoreBuilder.html#withCachingDisabled--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.State.StoreBuilder"/></returns>
        public Org.Apache.Kafka.Streams.State.StoreBuilder WithCachingDisabled()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.State.StoreBuilder>("withCachingDisabled", "()Lorg/apache/kafka/streams/state/StoreBuilder;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/state/StoreBuilder.html#withCachingEnabled--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.State.StoreBuilder"/></returns>
        public Org.Apache.Kafka.Streams.State.StoreBuilder WithCachingEnabled()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.State.StoreBuilder>("withCachingEnabled", "()Lorg/apache/kafka/streams/state/StoreBuilder;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/state/StoreBuilder.html#withLoggingDisabled--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.State.StoreBuilder"/></returns>
        public Org.Apache.Kafka.Streams.State.StoreBuilder WithLoggingDisabled()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.State.StoreBuilder>("withLoggingDisabled", "()Lorg/apache/kafka/streams/state/StoreBuilder;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/state/StoreBuilder.html#withLoggingEnabled-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.StoreBuilder"/></returns>
        public Org.Apache.Kafka.Streams.State.StoreBuilder WithLoggingEnabled(Java.Util.Map arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.State.StoreBuilder>("withLoggingEnabled", "(Ljava/util/Map;)Lorg/apache/kafka/streams/state/StoreBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/state/StoreBuilder.html#build--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.Processor.StateStore"/></returns>
        public Org.Apache.Kafka.Streams.Processor.StateStore Build()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Processor.StateStore>("build", "()Lorg/apache/kafka/streams/processor/StateStore;");
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
            return IExecuteWithSignature<bool>("loggingEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/state/StoreBuilder.html#name--"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Name()
        {
            return IExecuteWithSignature<Java.Lang.String>("name", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/state/StoreBuilder.html#logConfig--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, Java.Lang.String> LogConfig()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Lang.String>>("logConfig", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/state/StoreBuilder.html#withCachingDisabled--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.State.StoreBuilder"/></returns>
        public Org.Apache.Kafka.Streams.State.StoreBuilder<T> WithCachingDisabled()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.State.StoreBuilder<T>>("withCachingDisabled", "()Lorg/apache/kafka/streams/state/StoreBuilder;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/state/StoreBuilder.html#withCachingEnabled--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.State.StoreBuilder"/></returns>
        public Org.Apache.Kafka.Streams.State.StoreBuilder<T> WithCachingEnabled()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.State.StoreBuilder<T>>("withCachingEnabled", "()Lorg/apache/kafka/streams/state/StoreBuilder;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/state/StoreBuilder.html#withLoggingDisabled--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.State.StoreBuilder"/></returns>
        public Org.Apache.Kafka.Streams.State.StoreBuilder<T> WithLoggingDisabled()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.State.StoreBuilder<T>>("withLoggingDisabled", "()Lorg/apache/kafka/streams/state/StoreBuilder;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/state/StoreBuilder.html#withLoggingEnabled-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.StoreBuilder"/></returns>
        public Org.Apache.Kafka.Streams.State.StoreBuilder<T> WithLoggingEnabled(Java.Util.Map<Java.Lang.String, Java.Lang.String> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.State.StoreBuilder<T>>("withLoggingEnabled", "(Ljava/util/Map;)Lorg/apache/kafka/streams/state/StoreBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.1/org/apache/kafka/streams/state/StoreBuilder.html#build--"/>
        /// </summary>

        /// <returns><typeparamref name="T"/></returns>
        public T Build()
        {
            return IExecuteWithSignature<T>("build", "()Lorg/apache/kafka/streams/processor/StateStore;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}