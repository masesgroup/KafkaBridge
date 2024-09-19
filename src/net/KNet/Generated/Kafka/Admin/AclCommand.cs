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
*  using kafka_2.13-3.6.2.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Kafka.Admin
{
    #region AclCommand declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.2/kafka/admin/AclCommand.html"/>
    /// </summary>
    public partial class AclCommand : MASES.JCOBridge.C2JBridge.JVMBridgeBase<AclCommand>, MASES.JCOBridge.C2JBridge.IJVMBridgeMain
    {
        const string _bridgeClassName = "kafka.admin.AclCommand";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AclCommand() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AclCommand(params object[] args) : base(args) { }

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
        #region AclCommandOptions declaration
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.2/kafka/admin/AclCommand.AclCommandOptions.html"/>
        /// </summary>
        public partial class AclCommandOptions : MASES.JCOBridge.C2JBridge.JVMBridgeBase<AclCommandOptions>
        {
            const string _bridgeClassName = "kafka.admin.AclCommand$AclCommandOptions";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public AclCommandOptions() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public AclCommandOptions(params object[] args) : base(args) { }

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

        #region AclCommandService declaration
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.2/kafka/admin/AclCommand.AclCommandService.html"/>
        /// </summary>
        public partial class AclCommandService : MASES.JCOBridge.C2JBridge.JVMBridgeBase<AclCommandService>
        {
            const string _bridgeClassName = "kafka.admin.AclCommand$AclCommandService";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("AclCommandService class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public AclCommandService() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("AclCommandService class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public AclCommandService(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

        #region AdminClientService declaration
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.2/kafka/admin/AclCommand.AdminClientService.html"/>
        /// </summary>
        public partial class AdminClientService : MASES.JCOBridge.C2JBridge.JVMBridgeBase<AdminClientService>
        {
            const string _bridgeClassName = "kafka.admin.AclCommand$AdminClientService";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public AdminClientService() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public AdminClientService(params object[] args) : base(args) { }

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

        #region AuthorizerService declaration
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.2/kafka/admin/AclCommand.AuthorizerService.html"/>
        /// </summary>
        public partial class AuthorizerService : MASES.JCOBridge.C2JBridge.JVMBridgeBase<AuthorizerService>
        {
            const string _bridgeClassName = "kafka.admin.AclCommand$AuthorizerService";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public AuthorizerService() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public AuthorizerService(params object[] args) : base(args) { }

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

    #region AclCommand implementation
    public partial class AclCommand
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.2/kafka/admin/AclCommand.html#isDebugEnabled--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public static bool IsDebugEnabled()
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isDebugEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.2/kafka/admin/AclCommand.html#isTraceEnabled--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public static bool IsTraceEnabled()
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isTraceEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.2/kafka/admin/AclCommand.html#AuthorizerDeprecationMessage--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String AuthorizerDeprecationMessage()
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "AuthorizerDeprecationMessage", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.2/kafka/admin/AclCommand.html#ClusterResourceFilter--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Resource.ResourcePatternFilter"/></returns>
        public static Org.Apache.Kafka.Common.Resource.ResourcePatternFilter ClusterResourceFilter()
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.Resource.ResourcePatternFilter>(LocalBridgeClazz, "ClusterResourceFilter", "()Lorg/apache/kafka/common/resource/ResourcePatternFilter;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.2/kafka/admin/AclCommand.html#main-java.lang.String[]-"/>
        /// </summary>
        /// <param name="args"><see cref="Java.Lang.String"/></param>
        public static void Main(Java.Lang.String[] args)
        {
            SExecuteWithSignature(LocalBridgeClazz, "main", "([Ljava/lang/String;)V", new object[] { args });
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region AclCommandOptions implementation
        public partial class AclCommandOptions
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.2/kafka/admin/AclCommand.AclCommandOptions.html#kafka.admin.AclCommand$AclCommandOptions(java.lang.String[])"/>
            /// </summary>
            /// <param name="args"><see cref="Java.Lang.String"/></param>
            public AclCommandOptions(Java.Lang.String[] args)
                : base(args)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.2/kafka/admin/AclCommand.AclCommandOptions.html#CommandConfigDoc--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String CommandConfigDoc()
            {
                return IExecuteWithSignature<Java.Lang.String>("CommandConfigDoc", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.2/kafka/admin/AclCommand.AclCommandOptions.html#checkArgs--"/>
            /// </summary>
            public void CheckArgs()
            {
                IExecuteWithSignature("checkArgs", "()V");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region AclCommandService implementation
        public partial class AclCommandService
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.2/kafka/admin/AclCommand.AclCommandService.html#addAcls--"/>
            /// </summary>
            public void AddAcls()
            {
                IExecuteWithSignature("addAcls", "()V");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.2/kafka/admin/AclCommand.AclCommandService.html#listAcls--"/>
            /// </summary>
            public void ListAcls()
            {
                IExecuteWithSignature("listAcls", "()V");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.2/kafka/admin/AclCommand.AclCommandService.html#removeAcls--"/>
            /// </summary>
            public void RemoveAcls()
            {
                IExecuteWithSignature("removeAcls", "()V");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region AdminClientService implementation
        public partial class AdminClientService
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.2/kafka/admin/AclCommand.AdminClientService.html#kafka.admin.AclCommand$AdminClientService(kafka.admin.AclCommand.AclCommandOptions)"/>
            /// </summary>
            /// <param name="opts"><see cref="Kafka.Admin.AclCommand.AclCommandOptions"/></param>
            public AdminClientService(Kafka.Admin.AclCommand.AclCommandOptions opts)
                : base(opts)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.2/kafka/admin/AclCommand.AdminClientService.html#isDebugEnabled--"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsDebugEnabled()
            {
                return IExecuteWithSignature<bool>("isDebugEnabled", "()Z");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.2/kafka/admin/AclCommand.AdminClientService.html#isTraceEnabled--"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsTraceEnabled()
            {
                return IExecuteWithSignature<bool>("isTraceEnabled", "()Z");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.2/kafka/admin/AclCommand.AdminClientService.html#loggerName--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String LoggerName()
            {
                return IExecuteWithSignature<Java.Lang.String>("loggerName", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.2/kafka/admin/AclCommand.AdminClientService.html#logIdent--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String LogIdent()
            {
                return IExecuteWithSignature<Java.Lang.String>("logIdent", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.2/kafka/admin/AclCommand.AdminClientService.html#msgWithLogIdent-java.lang.String-"/>
            /// </summary>
            /// <param name="msg"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String MsgWithLogIdent(Java.Lang.String msg)
            {
                return IExecuteWithSignature<Java.Lang.String>("msgWithLogIdent", "(Ljava/lang/String;)Ljava/lang/String;", msg);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.2/kafka/admin/AclCommand.AdminClientService.html#opts--"/>
            /// </summary>
            /// <returns><see cref="Kafka.Admin.AclCommand.AclCommandOptions"/></returns>
            public Kafka.Admin.AclCommand.AclCommandOptions Opts()
            {
                return IExecuteWithSignature<Kafka.Admin.AclCommand.AclCommandOptions>("opts", "()Lkafka/admin/AclCommand$AclCommandOptions;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.2/kafka/admin/AclCommand.AdminClientService.html#addAcls--"/>
            /// </summary>
            public void AddAcls()
            {
                IExecuteWithSignature("addAcls", "()V");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.2/kafka/admin/AclCommand.AdminClientService.html#listAcls--"/>
            /// </summary>
            public void ListAcls()
            {
                IExecuteWithSignature("listAcls", "()V");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.2/kafka/admin/AclCommand.AdminClientService.html#removeAcls--"/>
            /// </summary>
            public void RemoveAcls()
            {
                IExecuteWithSignature("removeAcls", "()V");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region AuthorizerService implementation
        public partial class AuthorizerService
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.2/kafka/admin/AclCommand.AuthorizerService.html#kafka.admin.AclCommand$AuthorizerService(java.lang.String,kafka.admin.AclCommand.AclCommandOptions)"/>
            /// </summary>
            /// <param name="authorizerClassName"><see cref="Java.Lang.String"/></param>
            /// <param name="opts"><see cref="Kafka.Admin.AclCommand.AclCommandOptions"/></param>
            public AuthorizerService(Java.Lang.String authorizerClassName, Kafka.Admin.AclCommand.AclCommandOptions opts)
                : base(authorizerClassName, opts)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.2/kafka/admin/AclCommand.AuthorizerService.html#isDebugEnabled--"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsDebugEnabled()
            {
                return IExecuteWithSignature<bool>("isDebugEnabled", "()Z");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.2/kafka/admin/AclCommand.AuthorizerService.html#isTraceEnabled--"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsTraceEnabled()
            {
                return IExecuteWithSignature<bool>("isTraceEnabled", "()Z");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.2/kafka/admin/AclCommand.AuthorizerService.html#authorizerClassName--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String AuthorizerClassName()
            {
                return IExecuteWithSignature<Java.Lang.String>("authorizerClassName", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.2/kafka/admin/AclCommand.AuthorizerService.html#loggerName--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String LoggerName()
            {
                return IExecuteWithSignature<Java.Lang.String>("loggerName", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.2/kafka/admin/AclCommand.AuthorizerService.html#logIdent--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String LogIdent()
            {
                return IExecuteWithSignature<Java.Lang.String>("logIdent", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.2/kafka/admin/AclCommand.AuthorizerService.html#msgWithLogIdent-java.lang.String-"/>
            /// </summary>
            /// <param name="msg"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String MsgWithLogIdent(Java.Lang.String msg)
            {
                return IExecuteWithSignature<Java.Lang.String>("msgWithLogIdent", "(Ljava/lang/String;)Ljava/lang/String;", msg);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.2/kafka/admin/AclCommand.AuthorizerService.html#opts--"/>
            /// </summary>
            /// <returns><see cref="Kafka.Admin.AclCommand.AclCommandOptions"/></returns>
            public Kafka.Admin.AclCommand.AclCommandOptions Opts()
            {
                return IExecuteWithSignature<Kafka.Admin.AclCommand.AclCommandOptions>("opts", "()Lkafka/admin/AclCommand$AclCommandOptions;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.2/kafka/admin/AclCommand.AuthorizerService.html#addAcls--"/>
            /// </summary>
            public void AddAcls()
            {
                IExecuteWithSignature("addAcls", "()V");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.2/kafka/admin/AclCommand.AuthorizerService.html#listAcls--"/>
            /// </summary>
            public void ListAcls()
            {
                IExecuteWithSignature("listAcls", "()V");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.2/kafka/admin/AclCommand.AuthorizerService.html#removeAcls--"/>
            /// </summary>
            public void RemoveAcls()
            {
                IExecuteWithSignature("removeAcls", "()V");
            }

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