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
*  using connect-api-3.6.2.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Transforms.Predicates
{
    #region Predicate declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.2/org/apache/kafka/connect/transforms/predicates/Predicate.html"/>
    /// </summary>
    public partial class Predicate : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Predicate>
    {
        const string _bridgeClassName = "org.apache.kafka.connect.transforms.predicates.Predicate";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("Predicate class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Predicate() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("Predicate class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Predicate(params object[] args) : base(args) { }

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

    }
    #endregion

    #region Predicate<R> declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.2/org/apache/kafka/connect/transforms/predicates/Predicate.html"/>
    /// </summary>
    /// <typeparam name="R"><see cref="Org.Apache.Kafka.Connect.Connector.ConnectRecord{R}"/></typeparam>
    public partial class Predicate<R> : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Predicate<R>> where R : Org.Apache.Kafka.Connect.Connector.ConnectRecord<R>
    {
        const string _bridgeClassName = "org.apache.kafka.connect.transforms.predicates.Predicate";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("Predicate class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Predicate() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("Predicate class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Predicate(params object[] args) : base(args) { }

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
    
    }
    #endregion

    #region Predicate implementation
    public partial class Predicate
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Transforms.Predicates.Predicate"/> to <see cref="Org.Apache.Kafka.Common.Configurable"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Configurable(Org.Apache.Kafka.Connect.Transforms.Predicates.Predicate t) => t.Cast<Org.Apache.Kafka.Common.Configurable>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Transforms.Predicates.Predicate"/> to <see cref="Java.Lang.AutoCloseable"/>
        /// </summary>
        public static implicit operator Java.Lang.AutoCloseable(Org.Apache.Kafka.Connect.Transforms.Predicates.Predicate t) => t.Cast<Java.Lang.AutoCloseable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.2/org/apache/kafka/connect/transforms/predicates/Predicate.html#test-org.apache.kafka.connect.connector.ConnectRecord-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Connector.ConnectRecord"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Test(Org.Apache.Kafka.Connect.Connector.ConnectRecord arg0)
        {
            return IExecuteWithSignature<bool>("test", "(Lorg/apache/kafka/connect/connector/ConnectRecord;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.2/org/apache/kafka/connect/transforms/predicates/Predicate.html#config--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Config.ConfigDef"/></returns>
        public Org.Apache.Kafka.Common.Config.ConfigDef Config()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Config.ConfigDef>("config", "()Lorg/apache/kafka/common/config/ConfigDef;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.2/org/apache/kafka/connect/transforms/predicates/Predicate.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IPredicate<R>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IPredicate<R>
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Predicate<R> implementation
    public partial class Predicate<R> : Org.Apache.Kafka.Connect.Transforms.Predicates.IPredicate<R>, Org.Apache.Kafka.Common.IConfigurable, Java.Lang.IAutoCloseable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Transforms.Predicates.Predicate{R}"/> to <see cref="Org.Apache.Kafka.Common.Configurable"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Configurable(Org.Apache.Kafka.Connect.Transforms.Predicates.Predicate<R> t) => t.Cast<Org.Apache.Kafka.Common.Configurable>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Transforms.Predicates.Predicate{R}"/> to <see cref="Java.Lang.AutoCloseable"/>
        /// </summary>
        public static implicit operator Java.Lang.AutoCloseable(Org.Apache.Kafka.Connect.Transforms.Predicates.Predicate<R> t) => t.Cast<Java.Lang.AutoCloseable>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Transforms.Predicates.Predicate{R}"/> to <see cref="Org.Apache.Kafka.Connect.Transforms.Predicates.Predicate"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Connect.Transforms.Predicates.Predicate(Org.Apache.Kafka.Connect.Transforms.Predicates.Predicate<R> t) => t.Cast<Org.Apache.Kafka.Connect.Transforms.Predicates.Predicate>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.2/org/apache/kafka/connect/transforms/predicates/Predicate.html#test-org.apache.kafka.connect.connector.ConnectRecord-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="R"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Test(R arg0)
        {
            return IExecuteWithSignature<bool>("test", "(Lorg/apache/kafka/connect/connector/ConnectRecord;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.2/org/apache/kafka/connect/transforms/predicates/Predicate.html#config--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Config.ConfigDef"/></returns>
        public Org.Apache.Kafka.Common.Config.ConfigDef Config()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Config.ConfigDef>("config", "()Lorg/apache/kafka/common/config/ConfigDef;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.2/org/apache/kafka/connect/transforms/predicates/Predicate.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}