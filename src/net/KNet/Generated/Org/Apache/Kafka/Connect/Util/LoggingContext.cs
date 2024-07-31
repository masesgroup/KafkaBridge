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
*  using connect-runtime-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Util
{
    #region LoggingContext
    public partial class LoggingContext
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.1/org/apache/kafka/connect/util/LoggingContext.html#CONNECTOR_CONTEXT"/>
        /// </summary>
        public static Java.Lang.String CONNECTOR_CONTEXT { get { if (!_CONNECTOR_CONTEXTReady) { _CONNECTOR_CONTEXTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CONNECTOR_CONTEXT"); _CONNECTOR_CONTEXTReady = true; } return _CONNECTOR_CONTEXTContent; } }
        private static Java.Lang.String _CONNECTOR_CONTEXTContent = default;
        private static bool _CONNECTOR_CONTEXTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.1/org/apache/kafka/connect/util/LoggingContext.html#ALL_CONTEXTS"/>
        /// </summary>
        public static Java.Util.Collection ALL_CONTEXTS { get { if (!_ALL_CONTEXTSReady) { _ALL_CONTEXTSContent = SGetField<Java.Util.Collection>(LocalBridgeClazz, "ALL_CONTEXTS"); _ALL_CONTEXTSReady = true; } return _ALL_CONTEXTSContent; } }
        private static Java.Util.Collection _ALL_CONTEXTSContent = default;
        private static bool _ALL_CONTEXTSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.1/org/apache/kafka/connect/util/LoggingContext.html#forConnector-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Util.LoggingContext"/></returns>
        public static Org.Apache.Kafka.Connect.Util.LoggingContext ForConnector(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Connect.Util.LoggingContext>(LocalBridgeClazz, "forConnector", "(Ljava/lang/String;)Lorg/apache/kafka/connect/util/LoggingContext;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.1/org/apache/kafka/connect/util/LoggingContext.html#forOffsets-org.apache.kafka.connect.util.ConnectorTaskId-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Util.ConnectorTaskId"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Util.LoggingContext"/></returns>
        public static Org.Apache.Kafka.Connect.Util.LoggingContext ForOffsets(Org.Apache.Kafka.Connect.Util.ConnectorTaskId arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Connect.Util.LoggingContext>(LocalBridgeClazz, "forOffsets", "(Lorg/apache/kafka/connect/util/ConnectorTaskId;)Lorg/apache/kafka/connect/util/LoggingContext;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.1/org/apache/kafka/connect/util/LoggingContext.html#forTask-org.apache.kafka.connect.util.ConnectorTaskId-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Util.ConnectorTaskId"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Util.LoggingContext"/></returns>
        public static Org.Apache.Kafka.Connect.Util.LoggingContext ForTask(Org.Apache.Kafka.Connect.Util.ConnectorTaskId arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Connect.Util.LoggingContext>(LocalBridgeClazz, "forTask", "(Lorg/apache/kafka/connect/util/ConnectorTaskId;)Lorg/apache/kafka/connect/util/LoggingContext;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.1/org/apache/kafka/connect/util/LoggingContext.html#forValidation-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Util.LoggingContext"/></returns>
        public static Org.Apache.Kafka.Connect.Util.LoggingContext ForValidation(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Connect.Util.LoggingContext>(LocalBridgeClazz, "forValidation", "(Ljava/lang/String;)Lorg/apache/kafka/connect/util/LoggingContext;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.1/org/apache/kafka/connect/util/LoggingContext.html#clear--"/>
        /// </summary>
        public static void Clear()
        {
            SExecuteWithSignature(LocalBridgeClazz, "clear", "()V");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.1/org/apache/kafka/connect/util/LoggingContext.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }

        #endregion

        #region Nested classes
        #region Scope
        public partial class Scope
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.1/org/apache/kafka/connect/util/LoggingContext.Scope.html#OFFSETS"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Util.LoggingContext.Scope OFFSETS { get { if (!_OFFSETSReady) { _OFFSETSContent = SGetField<Org.Apache.Kafka.Connect.Util.LoggingContext.Scope>(LocalBridgeClazz, "OFFSETS"); _OFFSETSReady = true; } return _OFFSETSContent; } }
            private static Org.Apache.Kafka.Connect.Util.LoggingContext.Scope _OFFSETSContent = default;
            private static bool _OFFSETSReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.1/org/apache/kafka/connect/util/LoggingContext.Scope.html#TASK"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Util.LoggingContext.Scope TASK { get { if (!_TASKReady) { _TASKContent = SGetField<Org.Apache.Kafka.Connect.Util.LoggingContext.Scope>(LocalBridgeClazz, "TASK"); _TASKReady = true; } return _TASKContent; } }
            private static Org.Apache.Kafka.Connect.Util.LoggingContext.Scope _TASKContent = default;
            private static bool _TASKReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.1/org/apache/kafka/connect/util/LoggingContext.Scope.html#VALIDATE"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Util.LoggingContext.Scope VALIDATE { get { if (!_VALIDATEReady) { _VALIDATEContent = SGetField<Org.Apache.Kafka.Connect.Util.LoggingContext.Scope>(LocalBridgeClazz, "VALIDATE"); _VALIDATEReady = true; } return _VALIDATEContent; } }
            private static Org.Apache.Kafka.Connect.Util.LoggingContext.Scope _VALIDATEContent = default;
            private static bool _VALIDATEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.1/org/apache/kafka/connect/util/LoggingContext.Scope.html#WORKER"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Util.LoggingContext.Scope WORKER { get { if (!_WORKERReady) { _WORKERContent = SGetField<Org.Apache.Kafka.Connect.Util.LoggingContext.Scope>(LocalBridgeClazz, "WORKER"); _WORKERReady = true; } return _WORKERContent; } }
            private static Org.Apache.Kafka.Connect.Util.LoggingContext.Scope _WORKERContent = default;
            private static bool _WORKERReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.1/org/apache/kafka/connect/util/LoggingContext.Scope.html#valueOf-java.lang.String-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Connect.Util.LoggingContext.Scope"/></returns>
            public static Org.Apache.Kafka.Connect.Util.LoggingContext.Scope ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Org.Apache.Kafka.Connect.Util.LoggingContext.Scope>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/connect/util/LoggingContext$Scope;", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.1/org/apache/kafka/connect/util/LoggingContext.Scope.html#values--"/>
            /// </summary>
            /// <returns><see cref="Org.Apache.Kafka.Connect.Util.LoggingContext.Scope"/></returns>
            public static Org.Apache.Kafka.Connect.Util.LoggingContext.Scope[] Values()
            {
                return SExecuteWithSignatureArray<Org.Apache.Kafka.Connect.Util.LoggingContext.Scope>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/connect/util/LoggingContext$Scope;");
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