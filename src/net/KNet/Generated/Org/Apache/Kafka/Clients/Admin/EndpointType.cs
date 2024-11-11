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
*  using kafka-clients-3.9.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Admin
{
    #region EndpointType declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/EndpointType.html"/>
    /// </summary>
    public partial class EndpointType : Java.Lang.Enum<Org.Apache.Kafka.Clients.Admin.EndpointType>
    {
        const string _bridgeClassName = "org.apache.kafka.clients.admin.EndpointType";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public EndpointType() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public EndpointType(params object[] args) : base(args) { }

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

    #region EndpointType implementation
    public partial class EndpointType
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/EndpointType.html#BROKER"/>
        /// </summary>
        public static Org.Apache.Kafka.Clients.Admin.EndpointType BROKER { get { if (!_BROKERReady) { _BROKERContent = SGetField<Org.Apache.Kafka.Clients.Admin.EndpointType>(LocalBridgeClazz, "BROKER"); _BROKERReady = true; } return _BROKERContent; } }
        private static Org.Apache.Kafka.Clients.Admin.EndpointType _BROKERContent = default;
        private static bool _BROKERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/EndpointType.html#CONTROLLER"/>
        /// </summary>
        public static Org.Apache.Kafka.Clients.Admin.EndpointType CONTROLLER { get { if (!_CONTROLLERReady) { _CONTROLLERContent = SGetField<Org.Apache.Kafka.Clients.Admin.EndpointType>(LocalBridgeClazz, "CONTROLLER"); _CONTROLLERReady = true; } return _CONTROLLERContent; } }
        private static Org.Apache.Kafka.Clients.Admin.EndpointType _CONTROLLERContent = default;
        private static bool _CONTROLLERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/EndpointType.html#UNKNOWN"/>
        /// </summary>
        public static Org.Apache.Kafka.Clients.Admin.EndpointType UNKNOWN { get { if (!_UNKNOWNReady) { _UNKNOWNContent = SGetField<Org.Apache.Kafka.Clients.Admin.EndpointType>(LocalBridgeClazz, "UNKNOWN"); _UNKNOWNReady = true; } return _UNKNOWNContent; } }
        private static Org.Apache.Kafka.Clients.Admin.EndpointType _UNKNOWNContent = default;
        private static bool _UNKNOWNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/EndpointType.html#fromId-byte-"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.EndpointType"/></returns>
        public static Org.Apache.Kafka.Clients.Admin.EndpointType FromId(byte arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Clients.Admin.EndpointType>(LocalBridgeClazz, "fromId", "(B)Lorg/apache/kafka/clients/admin/EndpointType;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/EndpointType.html#valueOf-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.EndpointType"/></returns>
        public static Org.Apache.Kafka.Clients.Admin.EndpointType ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Clients.Admin.EndpointType>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/clients/admin/EndpointType;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/EndpointType.html#values--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.EndpointType"/></returns>
        public static Org.Apache.Kafka.Clients.Admin.EndpointType[] Values()
        {
            return SExecuteWithSignatureArray<Org.Apache.Kafka.Clients.Admin.EndpointType>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/clients/admin/EndpointType;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/EndpointType.html#id--"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte Id()
        {
            return IExecuteWithSignature<byte>("id", "()B");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}