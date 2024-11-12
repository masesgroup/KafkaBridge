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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using connect-api-3.9.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Source
{
    #region ConnectorTransactionBoundaries declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/source/ConnectorTransactionBoundaries.html"/>
    /// </summary>
    public partial class ConnectorTransactionBoundaries : Java.Lang.Enum<Org.Apache.Kafka.Connect.Source.ConnectorTransactionBoundaries>
    {
        const string _bridgeClassName = "org.apache.kafka.connect.source.ConnectorTransactionBoundaries";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ConnectorTransactionBoundaries() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ConnectorTransactionBoundaries(params object[] args) : base(args) { }

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
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region ConnectorTransactionBoundaries implementation
    public partial class ConnectorTransactionBoundaries
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/source/ConnectorTransactionBoundaries.html#SUPPORTED"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Source.ConnectorTransactionBoundaries SUPPORTED { get { if (!_SUPPORTEDReady) { _SUPPORTEDContent = SGetField<Org.Apache.Kafka.Connect.Source.ConnectorTransactionBoundaries>(LocalBridgeClazz, "SUPPORTED"); _SUPPORTEDReady = true; } return _SUPPORTEDContent; } }
        private static Org.Apache.Kafka.Connect.Source.ConnectorTransactionBoundaries _SUPPORTEDContent = default;
        private static bool _SUPPORTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/source/ConnectorTransactionBoundaries.html#UNSUPPORTED"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Source.ConnectorTransactionBoundaries UNSUPPORTED { get { if (!_UNSUPPORTEDReady) { _UNSUPPORTEDContent = SGetField<Org.Apache.Kafka.Connect.Source.ConnectorTransactionBoundaries>(LocalBridgeClazz, "UNSUPPORTED"); _UNSUPPORTEDReady = true; } return _UNSUPPORTEDContent; } }
        private static Org.Apache.Kafka.Connect.Source.ConnectorTransactionBoundaries _UNSUPPORTEDContent = default;
        private static bool _UNSUPPORTEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/source/ConnectorTransactionBoundaries.html#valueOf-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Source.ConnectorTransactionBoundaries"/></returns>
        public static Org.Apache.Kafka.Connect.Source.ConnectorTransactionBoundaries ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Connect.Source.ConnectorTransactionBoundaries>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/connect/source/ConnectorTransactionBoundaries;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.9.0/org/apache/kafka/connect/source/ConnectorTransactionBoundaries.html#values--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Source.ConnectorTransactionBoundaries"/></returns>
        public static Org.Apache.Kafka.Connect.Source.ConnectorTransactionBoundaries[] Values()
        {
            return SExecuteWithSignatureArray<Org.Apache.Kafka.Connect.Source.ConnectorTransactionBoundaries>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/connect/source/ConnectorTransactionBoundaries;");
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}