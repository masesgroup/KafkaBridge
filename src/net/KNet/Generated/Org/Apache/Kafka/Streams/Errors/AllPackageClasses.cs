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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using kafka-streams-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge.JVMInterop;
using System;

namespace Org.Apache.Kafka.Streams.Errors
{
    #region BrokerNotFoundException
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/errors/BrokerNotFoundException.html"/>
    /// </summary>
    public partial class BrokerNotFoundException : Org.Apache.Kafka.Streams.Errors.StreamsException
    {
        const string _bridgeClassName = "org.apache.kafka.streams.errors.BrokerNotFoundException";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

        // TODO: complete the class

    }
    #endregion

    #region DefaultProductionExceptionHandler
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/errors/DefaultProductionExceptionHandler.html"/>
    /// </summary>
    public partial class DefaultProductionExceptionHandler : Org.Apache.Kafka.Streams.Errors.ProductionExceptionHandler
    {
        const string _bridgeClassName = "org.apache.kafka.streams.errors.DefaultProductionExceptionHandler";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DefaultProductionExceptionHandler() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DefaultProductionExceptionHandler(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region DeserializationExceptionHandler
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/errors/DeserializationExceptionHandler.html"/>
    /// </summary>
    public partial class DeserializationExceptionHandler : Org.Apache.Kafka.Common.Configurable
    {
        const string _bridgeClassName = "org.apache.kafka.streams.errors.DeserializationExceptionHandler";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("DeserializationExceptionHandler class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public DeserializationExceptionHandler() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("DeserializationExceptionHandler class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public DeserializationExceptionHandler(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class
        #region DeserializationHandlerResponse
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/errors/DeserializationExceptionHandler.DeserializationHandlerResponse.html"/>
        /// </summary>
        public partial class DeserializationHandlerResponse : Java.Lang.Enum<Org.Apache.Kafka.Streams.Errors.DeserializationExceptionHandler.DeserializationHandlerResponse>
        {
            const string _bridgeClassName = "org.apache.kafka.streams.errors.DeserializationExceptionHandler$DeserializationHandlerResponse";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public DeserializationHandlerResponse() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public DeserializationHandlerResponse(params object[] args) : base(args) { }

            private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
            /// </summary>
            public override bool IsBridgeCloseable => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
            /// </summary>
            public override bool IsBridgeInterface => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region InvalidStateStoreException
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/errors/InvalidStateStoreException.html"/>
    /// </summary>
    public partial class InvalidStateStoreException : Org.Apache.Kafka.Streams.Errors.StreamsException
    {
        const string _bridgeClassName = "org.apache.kafka.streams.errors.InvalidStateStoreException";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

        // TODO: complete the class

    }
    #endregion

    #region InvalidStateStorePartitionException
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/errors/InvalidStateStorePartitionException.html"/>
    /// </summary>
    public partial class InvalidStateStorePartitionException : Org.Apache.Kafka.Streams.Errors.InvalidStateStoreException
    {
        const string _bridgeClassName = "org.apache.kafka.streams.errors.InvalidStateStorePartitionException";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

        // TODO: complete the class

    }
    #endregion

    #region LockException
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/errors/LockException.html"/>
    /// </summary>
    public partial class LockException : Org.Apache.Kafka.Streams.Errors.StreamsException
    {
        const string _bridgeClassName = "org.apache.kafka.streams.errors.LockException";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

        // TODO: complete the class

    }
    #endregion

    #region LogAndContinueExceptionHandler
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/errors/LogAndContinueExceptionHandler.html"/>
    /// </summary>
    public partial class LogAndContinueExceptionHandler : Org.Apache.Kafka.Streams.Errors.DeserializationExceptionHandler
    {
        const string _bridgeClassName = "org.apache.kafka.streams.errors.LogAndContinueExceptionHandler";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public LogAndContinueExceptionHandler() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public LogAndContinueExceptionHandler(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region LogAndFailExceptionHandler
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/errors/LogAndFailExceptionHandler.html"/>
    /// </summary>
    public partial class LogAndFailExceptionHandler : Org.Apache.Kafka.Streams.Errors.DeserializationExceptionHandler
    {
        const string _bridgeClassName = "org.apache.kafka.streams.errors.LogAndFailExceptionHandler";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public LogAndFailExceptionHandler() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public LogAndFailExceptionHandler(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region MissingSourceTopicException
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/errors/MissingSourceTopicException.html"/>
    /// </summary>
    public partial class MissingSourceTopicException : Org.Apache.Kafka.Streams.Errors.StreamsException
    {
        const string _bridgeClassName = "org.apache.kafka.streams.errors.MissingSourceTopicException";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

        // TODO: complete the class

    }
    #endregion

    #region ProcessorStateException
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/errors/ProcessorStateException.html"/>
    /// </summary>
    public partial class ProcessorStateException : Org.Apache.Kafka.Streams.Errors.StreamsException
    {
        const string _bridgeClassName = "org.apache.kafka.streams.errors.ProcessorStateException";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

        // TODO: complete the class

    }
    #endregion

    #region ProductionExceptionHandler
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/errors/ProductionExceptionHandler.html"/>
    /// </summary>
    public partial class ProductionExceptionHandler : Org.Apache.Kafka.Common.Configurable
    {
        const string _bridgeClassName = "org.apache.kafka.streams.errors.ProductionExceptionHandler";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ProductionExceptionHandler class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ProductionExceptionHandler() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ProductionExceptionHandler class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ProductionExceptionHandler(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class
        #region ProductionExceptionHandlerResponse
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/errors/ProductionExceptionHandler.ProductionExceptionHandlerResponse.html"/>
        /// </summary>
        public partial class ProductionExceptionHandlerResponse : Java.Lang.Enum<Org.Apache.Kafka.Streams.Errors.ProductionExceptionHandler.ProductionExceptionHandlerResponse>
        {
            const string _bridgeClassName = "org.apache.kafka.streams.errors.ProductionExceptionHandler$ProductionExceptionHandlerResponse";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public ProductionExceptionHandlerResponse() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public ProductionExceptionHandlerResponse(params object[] args) : base(args) { }

            private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
            /// </summary>
            public override bool IsBridgeCloseable => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
            /// </summary>
            public override bool IsBridgeInterface => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region StateStoreMigratedException
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/errors/StateStoreMigratedException.html"/>
    /// </summary>
    public partial class StateStoreMigratedException : Org.Apache.Kafka.Streams.Errors.InvalidStateStoreException
    {
        const string _bridgeClassName = "org.apache.kafka.streams.errors.StateStoreMigratedException";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

        // TODO: complete the class

    }
    #endregion

    #region StateStoreNotAvailableException
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/errors/StateStoreNotAvailableException.html"/>
    /// </summary>
    public partial class StateStoreNotAvailableException : Org.Apache.Kafka.Streams.Errors.InvalidStateStoreException
    {
        const string _bridgeClassName = "org.apache.kafka.streams.errors.StateStoreNotAvailableException";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

        // TODO: complete the class

    }
    #endregion

    #region StreamsException
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/errors/StreamsException.html"/>
    /// </summary>
    public partial class StreamsException : Org.Apache.Kafka.Common.KafkaException
    {
        const string _bridgeClassName = "org.apache.kafka.streams.errors.StreamsException";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

        // TODO: complete the class

    }
    #endregion

    #region StreamsNotStartedException
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/errors/StreamsNotStartedException.html"/>
    /// </summary>
    public partial class StreamsNotStartedException : Org.Apache.Kafka.Streams.Errors.InvalidStateStoreException
    {
        const string _bridgeClassName = "org.apache.kafka.streams.errors.StreamsNotStartedException";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

        // TODO: complete the class

    }
    #endregion

    #region StreamsRebalancingException
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/errors/StreamsRebalancingException.html"/>
    /// </summary>
    public partial class StreamsRebalancingException : Org.Apache.Kafka.Streams.Errors.InvalidStateStoreException
    {
        const string _bridgeClassName = "org.apache.kafka.streams.errors.StreamsRebalancingException";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

        // TODO: complete the class

    }
    #endregion

    #region StreamsStoppedException
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/errors/StreamsStoppedException.html"/>
    /// </summary>
    public partial class StreamsStoppedException : Org.Apache.Kafka.Streams.Errors.InvalidStateStoreException
    {
        const string _bridgeClassName = "org.apache.kafka.streams.errors.StreamsStoppedException";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

        // TODO: complete the class

    }
    #endregion

    #region StreamsUncaughtExceptionHandler
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/errors/StreamsUncaughtExceptionHandler.html"/>
    /// </summary>
    public partial class StreamsUncaughtExceptionHandler : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public StreamsUncaughtExceptionHandler() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.knet.generated.org.apache.kafka.streams.errors.StreamsUncaughtExceptionHandler";
        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class
        #region StreamThreadExceptionResponse
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/errors/StreamsUncaughtExceptionHandler.StreamThreadExceptionResponse.html"/>
        /// </summary>
        public partial class StreamThreadExceptionResponse : Java.Lang.Enum<Org.Apache.Kafka.Streams.Errors.StreamsUncaughtExceptionHandler.StreamThreadExceptionResponse>
        {
            const string _bridgeClassName = "org.apache.kafka.streams.errors.StreamsUncaughtExceptionHandler$StreamThreadExceptionResponse";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public StreamThreadExceptionResponse() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public StreamThreadExceptionResponse(params object[] args) : base(args) { }

            private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
            /// </summary>
            public override bool IsBridgeCloseable => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
            /// </summary>
            public override bool IsBridgeInterface => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region StreamsUncaughtExceptionHandlerDirect
    /// <summary>
    /// Direct override of <see cref="StreamsUncaughtExceptionHandler"/> or its generic type if there is one
    /// </summary>
    public partial class StreamsUncaughtExceptionHandlerDirect : StreamsUncaughtExceptionHandler
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "org.apache.kafka.streams.errors.StreamsUncaughtExceptionHandler";
        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    }
    #endregion

    #region TaskAssignmentException
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/errors/TaskAssignmentException.html"/>
    /// </summary>
    public partial class TaskAssignmentException : Org.Apache.Kafka.Streams.Errors.StreamsException
    {
        const string _bridgeClassName = "org.apache.kafka.streams.errors.TaskAssignmentException";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

        // TODO: complete the class

    }
    #endregion

    #region TaskCorruptedException
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/errors/TaskCorruptedException.html"/>
    /// </summary>
    public partial class TaskCorruptedException : Org.Apache.Kafka.Streams.Errors.StreamsException
    {
        const string _bridgeClassName = "org.apache.kafka.streams.errors.TaskCorruptedException";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

        // TODO: complete the class

    }
    #endregion

    #region TaskIdFormatException
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/errors/TaskIdFormatException.html"/>
    /// </summary>
    public partial class TaskIdFormatException : Org.Apache.Kafka.Streams.Errors.StreamsException
    {
        const string _bridgeClassName = "org.apache.kafka.streams.errors.TaskIdFormatException";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

        // TODO: complete the class

    }
    #endregion

    #region TaskMigratedException
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/errors/TaskMigratedException.html"/>
    /// </summary>
    public partial class TaskMigratedException : Org.Apache.Kafka.Streams.Errors.StreamsException
    {
        const string _bridgeClassName = "org.apache.kafka.streams.errors.TaskMigratedException";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

        // TODO: complete the class

    }
    #endregion

    #region TopologyException
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/errors/TopologyException.html"/>
    /// </summary>
    public partial class TopologyException : Org.Apache.Kafka.Streams.Errors.StreamsException
    {
        const string _bridgeClassName = "org.apache.kafka.streams.errors.TopologyException";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

        // TODO: complete the class

    }
    #endregion

    #region UnknownStateStoreException
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/errors/UnknownStateStoreException.html"/>
    /// </summary>
    public partial class UnknownStateStoreException : Org.Apache.Kafka.Streams.Errors.InvalidStateStoreException
    {
        const string _bridgeClassName = "org.apache.kafka.streams.errors.UnknownStateStoreException";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

        // TODO: complete the class

    }
    #endregion

    #region UnknownTopologyException
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/errors/UnknownTopologyException.html"/>
    /// </summary>
    public partial class UnknownTopologyException : Org.Apache.Kafka.Streams.Errors.StreamsException
    {
        const string _bridgeClassName = "org.apache.kafka.streams.errors.UnknownTopologyException";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

        // TODO: complete the class

    }
    #endregion



}