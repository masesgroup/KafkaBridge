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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using kafka-streams-3.6.2.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Errors
{
    #region ProductionExceptionHandler declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/errors/ProductionExceptionHandler.html"/>
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

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

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
        #region ProductionExceptionHandlerResponse declaration
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/errors/ProductionExceptionHandler.ProductionExceptionHandlerResponse.html"/>
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

            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

    #region IProductionExceptionHandler
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IProductionExceptionHandler : Org.Apache.Kafka.Common.IConfigurable
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ProductionExceptionHandler implementation
    public partial class ProductionExceptionHandler : Org.Apache.Kafka.Streams.Errors.IProductionExceptionHandler
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/errors/ProductionExceptionHandler.html#handle-org.apache.kafka.clients.producer.ProducerRecord-java.lang.Exception-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Producer.ProducerRecord"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Exception"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Errors.ProductionExceptionHandler.ProductionExceptionHandlerResponse"/></returns>
        public Org.Apache.Kafka.Streams.Errors.ProductionExceptionHandler.ProductionExceptionHandlerResponse Handle(Org.Apache.Kafka.Clients.Producer.ProducerRecord<byte[], byte[]> arg0, MASES.JCOBridge.C2JBridge.JVMBridgeException arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.Errors.ProductionExceptionHandler.ProductionExceptionHandlerResponse>("handle", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/errors/ProductionExceptionHandler.html#handleSerializationException-org.apache.kafka.clients.producer.ProducerRecord-java.lang.Exception-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Producer.ProducerRecord"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Exception"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Errors.ProductionExceptionHandler.ProductionExceptionHandlerResponse"/></returns>
        public Org.Apache.Kafka.Streams.Errors.ProductionExceptionHandler.ProductionExceptionHandlerResponse HandleSerializationException(Org.Apache.Kafka.Clients.Producer.ProducerRecord arg0, MASES.JCOBridge.C2JBridge.JVMBridgeException arg1)
        {
            return IExecute<Org.Apache.Kafka.Streams.Errors.ProductionExceptionHandler.ProductionExceptionHandlerResponse>("handleSerializationException", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region ProductionExceptionHandlerResponse implementation
        public partial class ProductionExceptionHandlerResponse
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/errors/ProductionExceptionHandler.ProductionExceptionHandlerResponse.html#id"/>
            /// </summary>
            public int id { get { if (!_idReady) { _idContent = IGetField<int>("id"); _idReady = true; } return _idContent; } }
            private int _idContent = default;
            private bool _idReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/errors/ProductionExceptionHandler.ProductionExceptionHandlerResponse.html#name"/>
            /// </summary>
            public Java.Lang.String name { get { if (!_nameReady) { _nameContent = IGetField<Java.Lang.String>("name"); _nameReady = true; } return _nameContent; } }
            private Java.Lang.String _nameContent = default;
            private bool _nameReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/errors/ProductionExceptionHandler.ProductionExceptionHandlerResponse.html#CONTINUE"/>
            /// </summary>
            public static Org.Apache.Kafka.Streams.Errors.ProductionExceptionHandler.ProductionExceptionHandlerResponse CONTINUE { get { if (!_CONTINUEReady) { _CONTINUEContent = SGetField<Org.Apache.Kafka.Streams.Errors.ProductionExceptionHandler.ProductionExceptionHandlerResponse>(LocalBridgeClazz, "CONTINUE"); _CONTINUEReady = true; } return _CONTINUEContent; } }
            private static Org.Apache.Kafka.Streams.Errors.ProductionExceptionHandler.ProductionExceptionHandlerResponse _CONTINUEContent = default;
            private static bool _CONTINUEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/errors/ProductionExceptionHandler.ProductionExceptionHandlerResponse.html#FAIL"/>
            /// </summary>
            public static Org.Apache.Kafka.Streams.Errors.ProductionExceptionHandler.ProductionExceptionHandlerResponse FAIL { get { if (!_FAILReady) { _FAILContent = SGetField<Org.Apache.Kafka.Streams.Errors.ProductionExceptionHandler.ProductionExceptionHandlerResponse>(LocalBridgeClazz, "FAIL"); _FAILReady = true; } return _FAILContent; } }
            private static Org.Apache.Kafka.Streams.Errors.ProductionExceptionHandler.ProductionExceptionHandlerResponse _FAILContent = default;
            private static bool _FAILReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/errors/ProductionExceptionHandler.ProductionExceptionHandlerResponse.html#valueOf-java.lang.String-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Streams.Errors.ProductionExceptionHandler.ProductionExceptionHandlerResponse"/></returns>
            public static Org.Apache.Kafka.Streams.Errors.ProductionExceptionHandler.ProductionExceptionHandlerResponse ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Org.Apache.Kafka.Streams.Errors.ProductionExceptionHandler.ProductionExceptionHandlerResponse>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/streams/errors/ProductionExceptionHandler$ProductionExceptionHandlerResponse;", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/errors/ProductionExceptionHandler.ProductionExceptionHandlerResponse.html#values--"/>
            /// </summary>
            /// <returns><see cref="Org.Apache.Kafka.Streams.Errors.ProductionExceptionHandler.ProductionExceptionHandlerResponse"/></returns>
            public static Org.Apache.Kafka.Streams.Errors.ProductionExceptionHandler.ProductionExceptionHandlerResponse[] Values()
            {
                return SExecuteWithSignatureArray<Org.Apache.Kafka.Streams.Errors.ProductionExceptionHandler.ProductionExceptionHandlerResponse>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/streams/errors/ProductionExceptionHandler$ProductionExceptionHandlerResponse;");
            }

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
}