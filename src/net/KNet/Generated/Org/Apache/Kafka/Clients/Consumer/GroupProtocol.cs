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
*  using kafka-clients-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Consumer
{
    #region GroupProtocol declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/consumer/GroupProtocol.html"/>
    /// </summary>
    public partial class GroupProtocol : Java.Lang.Enum<Org.Apache.Kafka.Clients.Consumer.GroupProtocol>
    {
        const string _bridgeClassName = "org.apache.kafka.clients.consumer.GroupProtocol";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public GroupProtocol() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public GroupProtocol(params object[] args) : base(args) { }

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

    #region GroupProtocol implementation
    public partial class GroupProtocol
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/consumer/GroupProtocol.html#name"/>
        /// </summary>
        public Java.Lang.String name { get { if (!_nameReady) { _nameContent = IGetField<Java.Lang.String>("name"); _nameReady = true; } return _nameContent; } }
        private Java.Lang.String _nameContent = default;
        private bool _nameReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/consumer/GroupProtocol.html#CLASSIC"/>
        /// </summary>
        public static Org.Apache.Kafka.Clients.Consumer.GroupProtocol CLASSIC { get { if (!_CLASSICReady) { _CLASSICContent = SGetField<Org.Apache.Kafka.Clients.Consumer.GroupProtocol>(LocalBridgeClazz, "CLASSIC"); _CLASSICReady = true; } return _CLASSICContent; } }
        private static Org.Apache.Kafka.Clients.Consumer.GroupProtocol _CLASSICContent = default;
        private static bool _CLASSICReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/consumer/GroupProtocol.html#CONSUMER"/>
        /// </summary>
        public static Org.Apache.Kafka.Clients.Consumer.GroupProtocol CONSUMER { get { if (!_CONSUMERReady) { _CONSUMERContent = SGetField<Org.Apache.Kafka.Clients.Consumer.GroupProtocol>(LocalBridgeClazz, "CONSUMER"); _CONSUMERReady = true; } return _CONSUMERContent; } }
        private static Org.Apache.Kafka.Clients.Consumer.GroupProtocol _CONSUMERContent = default;
        private static bool _CONSUMERReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/consumer/GroupProtocol.html#of-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Consumer.GroupProtocol"/></returns>
        public static Org.Apache.Kafka.Clients.Consumer.GroupProtocol Of(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Clients.Consumer.GroupProtocol>(LocalBridgeClazz, "of", "(Ljava/lang/String;)Lorg/apache/kafka/clients/consumer/GroupProtocol;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/consumer/GroupProtocol.html#valueOf-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Consumer.GroupProtocol"/></returns>
        public static Org.Apache.Kafka.Clients.Consumer.GroupProtocol ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Clients.Consumer.GroupProtocol>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/clients/consumer/GroupProtocol;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/consumer/GroupProtocol.html#values--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Consumer.GroupProtocol"/></returns>
        public static Org.Apache.Kafka.Clients.Consumer.GroupProtocol[] Values()
        {
            return SExecuteWithSignatureArray<Org.Apache.Kafka.Clients.Consumer.GroupProtocol>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/clients/consumer/GroupProtocol;");
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