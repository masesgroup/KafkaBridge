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
*  This file is generated by MASES.JNetReflector (ver. 2.5.3.0)
*  using kafka-streams-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Errors
{
    #region IStreamsUncaughtExceptionHandler
    /// <summary>
    /// .NET interface for org.mases.knet.generated.org.apache.kafka.streams.errors.StreamsUncaughtExceptionHandler implementing <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/errors/StreamsUncaughtExceptionHandler.html"/>
    /// </summary>
    public partial interface IStreamsUncaughtExceptionHandler
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region StreamsUncaughtExceptionHandler
    public partial class StreamsUncaughtExceptionHandler : Org.Apache.Kafka.Streams.Errors.IStreamsUncaughtExceptionHandler
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
        /// Handlers initializer for <see cref="StreamsUncaughtExceptionHandler"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("handle", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(HandleEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/errors/StreamsUncaughtExceptionHandler.html#handle-java.lang.Throwable-"/>
        /// </summary>
        /// <remarks>If <see cref="OnHandle"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<MASES.JCOBridge.C2JBridge.JVMBridgeException, Org.Apache.Kafka.Streams.Errors.StreamsUncaughtExceptionHandler.StreamThreadExceptionResponse> OnHandle { get; set; } = null;

        void HandleEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnHandle != null) ? OnHandle : Handle;
            var executionResult = methodToExecute.Invoke(JVMBridgeException.New(data.EventData.EventData as MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject));
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/errors/StreamsUncaughtExceptionHandler.html#handle-java.lang.Throwable-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Throwable"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Errors.StreamsUncaughtExceptionHandler.StreamThreadExceptionResponse"/></returns>
        public virtual Org.Apache.Kafka.Streams.Errors.StreamsUncaughtExceptionHandler.StreamThreadExceptionResponse Handle(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0)
        {
            return default;
        }

        #endregion

        #region Nested classes
        #region StreamThreadExceptionResponse
        public partial class StreamThreadExceptionResponse
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/errors/StreamsUncaughtExceptionHandler.StreamThreadExceptionResponse.html#id"/>
            /// </summary>
            public int id { get { if (!_idReady) { _idContent = IGetField<int>("id"); _idReady = true; } return _idContent; } }
            private int _idContent = default;
            private bool _idReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/errors/StreamsUncaughtExceptionHandler.StreamThreadExceptionResponse.html#name"/>
            /// </summary>
            public Java.Lang.String name { get { if (!_nameReady) { _nameContent = IGetField<Java.Lang.String>("name"); _nameReady = true; } return _nameContent; } }
            private Java.Lang.String _nameContent = default;
            private bool _nameReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/errors/StreamsUncaughtExceptionHandler.StreamThreadExceptionResponse.html#REPLACE_THREAD"/>
            /// </summary>
            public static Org.Apache.Kafka.Streams.Errors.StreamsUncaughtExceptionHandler.StreamThreadExceptionResponse REPLACE_THREAD { get { if (!_REPLACE_THREADReady) { _REPLACE_THREADContent = SGetField<Org.Apache.Kafka.Streams.Errors.StreamsUncaughtExceptionHandler.StreamThreadExceptionResponse>(LocalBridgeClazz, "REPLACE_THREAD"); _REPLACE_THREADReady = true; } return _REPLACE_THREADContent; } }
            private static Org.Apache.Kafka.Streams.Errors.StreamsUncaughtExceptionHandler.StreamThreadExceptionResponse _REPLACE_THREADContent = default;
            private static bool _REPLACE_THREADReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/errors/StreamsUncaughtExceptionHandler.StreamThreadExceptionResponse.html#SHUTDOWN_APPLICATION"/>
            /// </summary>
            public static Org.Apache.Kafka.Streams.Errors.StreamsUncaughtExceptionHandler.StreamThreadExceptionResponse SHUTDOWN_APPLICATION { get { if (!_SHUTDOWN_APPLICATIONReady) { _SHUTDOWN_APPLICATIONContent = SGetField<Org.Apache.Kafka.Streams.Errors.StreamsUncaughtExceptionHandler.StreamThreadExceptionResponse>(LocalBridgeClazz, "SHUTDOWN_APPLICATION"); _SHUTDOWN_APPLICATIONReady = true; } return _SHUTDOWN_APPLICATIONContent; } }
            private static Org.Apache.Kafka.Streams.Errors.StreamsUncaughtExceptionHandler.StreamThreadExceptionResponse _SHUTDOWN_APPLICATIONContent = default;
            private static bool _SHUTDOWN_APPLICATIONReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/errors/StreamsUncaughtExceptionHandler.StreamThreadExceptionResponse.html#SHUTDOWN_CLIENT"/>
            /// </summary>
            public static Org.Apache.Kafka.Streams.Errors.StreamsUncaughtExceptionHandler.StreamThreadExceptionResponse SHUTDOWN_CLIENT { get { if (!_SHUTDOWN_CLIENTReady) { _SHUTDOWN_CLIENTContent = SGetField<Org.Apache.Kafka.Streams.Errors.StreamsUncaughtExceptionHandler.StreamThreadExceptionResponse>(LocalBridgeClazz, "SHUTDOWN_CLIENT"); _SHUTDOWN_CLIENTReady = true; } return _SHUTDOWN_CLIENTContent; } }
            private static Org.Apache.Kafka.Streams.Errors.StreamsUncaughtExceptionHandler.StreamThreadExceptionResponse _SHUTDOWN_CLIENTContent = default;
            private static bool _SHUTDOWN_CLIENTReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/errors/StreamsUncaughtExceptionHandler.StreamThreadExceptionResponse.html#valueOf-java.lang.String-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Streams.Errors.StreamsUncaughtExceptionHandler.StreamThreadExceptionResponse"/></returns>
            public static Org.Apache.Kafka.Streams.Errors.StreamsUncaughtExceptionHandler.StreamThreadExceptionResponse ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Org.Apache.Kafka.Streams.Errors.StreamsUncaughtExceptionHandler.StreamThreadExceptionResponse>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/streams/errors/StreamsUncaughtExceptionHandler$StreamThreadExceptionResponse;", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/errors/StreamsUncaughtExceptionHandler.StreamThreadExceptionResponse.html#values--"/>
            /// </summary>
            /// <returns><see cref="Org.Apache.Kafka.Streams.Errors.StreamsUncaughtExceptionHandler.StreamThreadExceptionResponse"/></returns>
            public static Org.Apache.Kafka.Streams.Errors.StreamsUncaughtExceptionHandler.StreamThreadExceptionResponse[] Values()
            {
                return SExecuteWithSignatureArray<Org.Apache.Kafka.Streams.Errors.StreamsUncaughtExceptionHandler.StreamThreadExceptionResponse>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/streams/errors/StreamsUncaughtExceptionHandler$StreamThreadExceptionResponse;");
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

    #region StreamsUncaughtExceptionHandlerDirect
    public partial class StreamsUncaughtExceptionHandlerDirect : Org.Apache.Kafka.Streams.Errors.IStreamsUncaughtExceptionHandler
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.0/org/apache/kafka/streams/errors/StreamsUncaughtExceptionHandler.html#handle-java.lang.Throwable-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Throwable"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Errors.StreamsUncaughtExceptionHandler.StreamThreadExceptionResponse"/></returns>
        public override Org.Apache.Kafka.Streams.Errors.StreamsUncaughtExceptionHandler.StreamThreadExceptionResponse Handle(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Errors.StreamsUncaughtExceptionHandler.StreamThreadExceptionResponse>("handle", "(Ljava/lang/Throwable;)Lorg/apache/kafka/streams/errors/StreamsUncaughtExceptionHandler$StreamThreadExceptionResponse;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}