/*
*  Copyright 2025 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.5.12.0)
*  using connect-transforms-3.9.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Transforms
{
    #region TimestampRouter declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.9.0/org/apache/kafka/connect/transforms/TimestampRouter.html"/>
    /// </summary>
    public partial class TimestampRouter : MASES.JCOBridge.C2JBridge.JVMBridgeBase<TimestampRouter>
    {
        const string _bridgeClassName = "org.apache.kafka.connect.transforms.TimestampRouter";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TimestampRouter() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TimestampRouter(params object[] args) : base(args) { }

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
        public override bool IsBridgeCloseable => true;
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

    #region TimestampRouter<R> declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.9.0/org/apache/kafka/connect/transforms/TimestampRouter.html"/>
    /// </summary>
    /// <typeparam name="R"><see cref="Org.Apache.Kafka.Connect.Connector.ConnectRecord{R}"/></typeparam>
    public partial class TimestampRouter<R> : MASES.JCOBridge.C2JBridge.JVMBridgeBase<TimestampRouter<R>> where R : Org.Apache.Kafka.Connect.Connector.ConnectRecord<R>
    {
        const string _bridgeClassName = "org.apache.kafka.connect.transforms.TimestampRouter";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TimestampRouter() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TimestampRouter(params object[] args) : base(args) { }

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
        public override bool IsBridgeCloseable => true;
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

    #region TimestampRouter implementation
    public partial class TimestampRouter
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Transforms.TimestampRouter"/> to <see cref="Org.Apache.Kafka.Connect.Transforms.Transformation"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Connect.Transforms.Transformation(Org.Apache.Kafka.Connect.Transforms.TimestampRouter t) => t.Cast<Org.Apache.Kafka.Connect.Transforms.Transformation>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Transforms.TimestampRouter"/> to <see cref="Java.Lang.AutoCloseable"/>
        /// </summary>
        public static implicit operator Java.Lang.AutoCloseable(Org.Apache.Kafka.Connect.Transforms.TimestampRouter t) => t.Cast<Java.Lang.AutoCloseable>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Transforms.TimestampRouter"/> to <see cref="Org.Apache.Kafka.Connect.Components.Versioned"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Connect.Components.Versioned(Org.Apache.Kafka.Connect.Transforms.TimestampRouter t) => t.Cast<Org.Apache.Kafka.Connect.Components.Versioned>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.9.0/org/apache/kafka/connect/transforms/TimestampRouter.html#OVERVIEW_DOC"/>
        /// </summary>
        public static Java.Lang.String OVERVIEW_DOC { get { if (!_OVERVIEW_DOCReady) { _OVERVIEW_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "OVERVIEW_DOC"); _OVERVIEW_DOCReady = true; } return _OVERVIEW_DOCContent; } }
        private static Java.Lang.String _OVERVIEW_DOCContent = default;
        private static bool _OVERVIEW_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.9.0/org/apache/kafka/connect/transforms/TimestampRouter.html#CONFIG_DEF"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Config.ConfigDef CONFIG_DEF { get { if (!_CONFIG_DEFReady) { _CONFIG_DEFContent = SGetField<Org.Apache.Kafka.Common.Config.ConfigDef>(LocalBridgeClazz, "CONFIG_DEF"); _CONFIG_DEFReady = true; } return _CONFIG_DEFContent; } }
        private static Org.Apache.Kafka.Common.Config.ConfigDef _CONFIG_DEFContent = default;
        private static bool _CONFIG_DEFReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.9.0/org/apache/kafka/connect/transforms/TimestampRouter.html#version--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Version()
        {
            return IExecuteWithSignature<Java.Lang.String>("version", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.9.0/org/apache/kafka/connect/transforms/TimestampRouter.html#config--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Config.ConfigDef"/></returns>
        public Org.Apache.Kafka.Common.Config.ConfigDef Config()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Config.ConfigDef>("config", "()Lorg/apache/kafka/common/config/ConfigDef;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.9.0/org/apache/kafka/connect/transforms/TimestampRouter.html#apply-org.apache.kafka.connect.connector.ConnectRecord-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Connector.ConnectRecord"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Connector.ConnectRecord"/></returns>
        public Org.Apache.Kafka.Connect.Connector.ConnectRecord Apply(Org.Apache.Kafka.Connect.Connector.ConnectRecord arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Connector.ConnectRecord>("apply", "(Lorg/apache/kafka/connect/connector/ConnectRecord;)Lorg/apache/kafka/connect/connector/ConnectRecord;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.9.0/org/apache/kafka/connect/transforms/TimestampRouter.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.9.0/org/apache/kafka/connect/transforms/TimestampRouter.html#configure-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public void Configure(Java.Util.Map arg0)
        {
            IExecuteWithSignature("configure", "(Ljava/util/Map;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TimestampRouter<R> implementation
    public partial class TimestampRouter<R> : Org.Apache.Kafka.Connect.Transforms.ITransformation<R>, Java.Lang.IAutoCloseable, Org.Apache.Kafka.Connect.Components.IVersioned
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Transforms.TimestampRouter{R}"/> to <see cref="Org.Apache.Kafka.Connect.Transforms.Transformation{R}"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Connect.Transforms.Transformation<R>(Org.Apache.Kafka.Connect.Transforms.TimestampRouter<R> t) => t.Cast<Org.Apache.Kafka.Connect.Transforms.Transformation<R>>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Transforms.TimestampRouter{R}"/> to <see cref="Java.Lang.AutoCloseable"/>
        /// </summary>
        public static implicit operator Java.Lang.AutoCloseable(Org.Apache.Kafka.Connect.Transforms.TimestampRouter<R> t) => t.Cast<Java.Lang.AutoCloseable>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Transforms.TimestampRouter{R}"/> to <see cref="Org.Apache.Kafka.Connect.Components.Versioned"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Connect.Components.Versioned(Org.Apache.Kafka.Connect.Transforms.TimestampRouter<R> t) => t.Cast<Org.Apache.Kafka.Connect.Components.Versioned>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Transforms.TimestampRouter{R}"/> to <see cref="Org.Apache.Kafka.Connect.Transforms.TimestampRouter"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Connect.Transforms.TimestampRouter(Org.Apache.Kafka.Connect.Transforms.TimestampRouter<R> t) => t.Cast<Org.Apache.Kafka.Connect.Transforms.TimestampRouter>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.9.0/org/apache/kafka/connect/transforms/TimestampRouter.html#OVERVIEW_DOC"/>
        /// </summary>
        public static Java.Lang.String OVERVIEW_DOC { get { if (!_OVERVIEW_DOCReady) { _OVERVIEW_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "OVERVIEW_DOC"); _OVERVIEW_DOCReady = true; } return _OVERVIEW_DOCContent; } }
        private static Java.Lang.String _OVERVIEW_DOCContent = default;
        private static bool _OVERVIEW_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.9.0/org/apache/kafka/connect/transforms/TimestampRouter.html#CONFIG_DEF"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Config.ConfigDef CONFIG_DEF { get { if (!_CONFIG_DEFReady) { _CONFIG_DEFContent = SGetField<Org.Apache.Kafka.Common.Config.ConfigDef>(LocalBridgeClazz, "CONFIG_DEF"); _CONFIG_DEFReady = true; } return _CONFIG_DEFContent; } }
        private static Org.Apache.Kafka.Common.Config.ConfigDef _CONFIG_DEFContent = default;
        private static bool _CONFIG_DEFReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.9.0/org/apache/kafka/connect/transforms/TimestampRouter.html#version--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Version()
        {
            return IExecuteWithSignature<Java.Lang.String>("version", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.9.0/org/apache/kafka/connect/transforms/TimestampRouter.html#config--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Config.ConfigDef"/></returns>
        public Org.Apache.Kafka.Common.Config.ConfigDef Config()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Config.ConfigDef>("config", "()Lorg/apache/kafka/common/config/ConfigDef;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.9.0/org/apache/kafka/connect/transforms/TimestampRouter.html#apply-org.apache.kafka.connect.connector.ConnectRecord-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="R"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R Apply(R arg0)
        {
            return IExecuteWithSignature<R>("apply", "(Lorg/apache/kafka/connect/connector/ConnectRecord;)Lorg/apache/kafka/connect/connector/ConnectRecord;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.9.0/org/apache/kafka/connect/transforms/TimestampRouter.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.9.0/org/apache/kafka/connect/transforms/TimestampRouter.html#configure-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public void Configure(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            IExecuteWithSignature("configure", "(Ljava/util/Map;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}