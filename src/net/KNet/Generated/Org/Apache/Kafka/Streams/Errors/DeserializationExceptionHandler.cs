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

namespace Org.Apache.Kafka.Streams.Errors
{
    #region IDeserializationExceptionHandler
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDeserializationExceptionHandler : Org.Apache.Kafka.Common.IConfigurable
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DeserializationExceptionHandler
    public partial class DeserializationExceptionHandler : Org.Apache.Kafka.Streams.Errors.IDeserializationExceptionHandler
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/errors/DeserializationExceptionHandler.html#handle-org.apache.kafka.streams.processor.ProcessorContext-org.apache.kafka.clients.consumer.ConsumerRecord-java.lang.Exception-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.ProcessorContext"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerRecord"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Exception"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Errors.DeserializationExceptionHandler.DeserializationHandlerResponse"/></returns>
        public Org.Apache.Kafka.Streams.Errors.DeserializationExceptionHandler.DeserializationHandlerResponse Handle(Org.Apache.Kafka.Streams.Processor.ProcessorContext arg0, Org.Apache.Kafka.Clients.Consumer.ConsumerRecord<byte[], byte[]> arg1, MASES.JCOBridge.C2JBridge.JVMBridgeException arg2)
        {
            return IExecute<Org.Apache.Kafka.Streams.Errors.DeserializationExceptionHandler.DeserializationHandlerResponse>("handle", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes
        #region DeserializationHandlerResponse
        public partial class DeserializationHandlerResponse
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/errors/DeserializationExceptionHandler.DeserializationHandlerResponse.html#id"/>
            /// </summary>
            public int id { get { if (!_idReady) { _idContent = IGetField<int>("id"); _idReady = true; } return _idContent; } }
            private int _idContent = default;
            private bool _idReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/errors/DeserializationExceptionHandler.DeserializationHandlerResponse.html#name"/>
            /// </summary>
            public Java.Lang.String name { get { if (!_nameReady) { _nameContent = IGetField<Java.Lang.String>("name"); _nameReady = true; } return _nameContent; } }
            private Java.Lang.String _nameContent = default;
            private bool _nameReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/errors/DeserializationExceptionHandler.DeserializationHandlerResponse.html#CONTINUE"/>
            /// </summary>
            public static Org.Apache.Kafka.Streams.Errors.DeserializationExceptionHandler.DeserializationHandlerResponse CONTINUE { get { if (!_CONTINUEReady) { _CONTINUEContent = SGetField<Org.Apache.Kafka.Streams.Errors.DeserializationExceptionHandler.DeserializationHandlerResponse>(LocalBridgeClazz, "CONTINUE"); _CONTINUEReady = true; } return _CONTINUEContent; } }
            private static Org.Apache.Kafka.Streams.Errors.DeserializationExceptionHandler.DeserializationHandlerResponse _CONTINUEContent = default;
            private static bool _CONTINUEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/errors/DeserializationExceptionHandler.DeserializationHandlerResponse.html#FAIL"/>
            /// </summary>
            public static Org.Apache.Kafka.Streams.Errors.DeserializationExceptionHandler.DeserializationHandlerResponse FAIL { get { if (!_FAILReady) { _FAILContent = SGetField<Org.Apache.Kafka.Streams.Errors.DeserializationExceptionHandler.DeserializationHandlerResponse>(LocalBridgeClazz, "FAIL"); _FAILReady = true; } return _FAILContent; } }
            private static Org.Apache.Kafka.Streams.Errors.DeserializationExceptionHandler.DeserializationHandlerResponse _FAILContent = default;
            private static bool _FAILReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/errors/DeserializationExceptionHandler.DeserializationHandlerResponse.html#valueOf-java.lang.String-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Streams.Errors.DeserializationExceptionHandler.DeserializationHandlerResponse"/></returns>
            public static Org.Apache.Kafka.Streams.Errors.DeserializationExceptionHandler.DeserializationHandlerResponse ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Org.Apache.Kafka.Streams.Errors.DeserializationExceptionHandler.DeserializationHandlerResponse>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/streams/errors/DeserializationExceptionHandler$DeserializationHandlerResponse;", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.6.2/org/apache/kafka/streams/errors/DeserializationExceptionHandler.DeserializationHandlerResponse.html#values--"/>
            /// </summary>

            /// <returns><see cref="Org.Apache.Kafka.Streams.Errors.DeserializationExceptionHandler.DeserializationHandlerResponse"/></returns>
            public static Org.Apache.Kafka.Streams.Errors.DeserializationExceptionHandler.DeserializationHandlerResponse[] Values()
            {
                return SExecuteWithSignatureArray<Org.Apache.Kafka.Streams.Errors.DeserializationExceptionHandler.DeserializationHandlerResponse>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/streams/errors/DeserializationExceptionHandler$DeserializationHandlerResponse;");
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