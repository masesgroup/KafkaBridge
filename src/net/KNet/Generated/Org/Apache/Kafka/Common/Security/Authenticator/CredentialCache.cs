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
*  using kafka-clients-3.8.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Security.Authenticator
{
    #region CredentialCache declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/security/authenticator/CredentialCache.html"/>
    /// </summary>
    public partial class CredentialCache : MASES.JCOBridge.C2JBridge.JVMBridgeBase<CredentialCache>
    {
        const string _bridgeClassName = "org.apache.kafka.common.security.authenticator.CredentialCache";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public CredentialCache() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public CredentialCache(params object[] args) : base(args) { }

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
        #region Cache declaration
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/security/authenticator/CredentialCache.Cache.html"/>
        /// </summary>
        public partial class Cache : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Cache>
        {
            const string _bridgeClassName = "org.apache.kafka.common.security.authenticator.CredentialCache$Cache";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Cache() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Cache(params object[] args) : base(args) { }

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

        #region Cache<C> declaration
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/security/authenticator/CredentialCache.Cache.html"/>
        /// </summary>
        /// <typeparam name="C"></typeparam>
        public partial class Cache<C> : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Cache<C>>
        {
            const string _bridgeClassName = "org.apache.kafka.common.security.authenticator.CredentialCache$Cache";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Cache() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Cache(params object[] args) : base(args) { }

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

    #region CredentialCache implementation
    public partial class CredentialCache
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/security/authenticator/CredentialCache.html#cache-java.lang.String-java.lang.Class-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="C"></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Common.Security.Authenticator.CredentialCache.Cache"/></returns>
        public Org.Apache.Kafka.Common.Security.Authenticator.CredentialCache.Cache<C> CacheMethod<C>(Java.Lang.String arg0, Java.Lang.Class arg1)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Security.Authenticator.CredentialCache.Cache<C>>("cache", "(Ljava/lang/String;Ljava/lang/Class;)Lorg/apache/kafka/common/security/authenticator/CredentialCache$Cache;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/security/authenticator/CredentialCache.html#createCache-java.lang.String-java.lang.Class-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="C"></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Common.Security.Authenticator.CredentialCache.Cache"/></returns>
        public Org.Apache.Kafka.Common.Security.Authenticator.CredentialCache.Cache<C> CreateCache<C>(Java.Lang.String arg0, Java.Lang.Class arg1)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Security.Authenticator.CredentialCache.Cache<C>>("createCache", "(Ljava/lang/String;Ljava/lang/Class;)Lorg/apache/kafka/common/security/authenticator/CredentialCache$Cache;", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Cache implementation
        public partial class Cache
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/security/authenticator/CredentialCache.Cache.html#org.apache.kafka.common.security.authenticator.CredentialCache$Cache(java.lang.Class)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
            public Cache(Java.Lang.Class arg0)
                : base(arg0)
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/security/authenticator/CredentialCache.Cache.html#get-java.lang.String-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="object"/></returns>
            public object Get(Java.Lang.String arg0)
            {
                return IExecuteWithSignature("get", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/security/authenticator/CredentialCache.Cache.html#put-java.lang.String-java.lang.Object-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="object"/></param>
            /// <returns><see cref="object"/></returns>
            public object Put(Java.Lang.String arg0, object arg1)
            {
                return IExecuteWithSignature("put", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/security/authenticator/CredentialCache.Cache.html#remove-java.lang.String-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="object"/></returns>
            public object Remove(Java.Lang.String arg0)
            {
                return IExecuteWithSignature("remove", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/security/authenticator/CredentialCache.Cache.html#credentialClass--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.Class"/></returns>
            public Java.Lang.Class CredentialClass()
            {
                return IExecuteWithSignature<Java.Lang.Class>("credentialClass", "()Ljava/lang/Class;");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Cache<C> implementation
        public partial class Cache<C>
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/security/authenticator/CredentialCache.Cache.html#org.apache.kafka.common.security.authenticator.CredentialCache$Cache(java.lang.Class)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
            public Cache(Java.Lang.Class arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Org.Apache.Kafka.Common.Security.Authenticator.CredentialCache.Cache{C}"/> to <see cref="Org.Apache.Kafka.Common.Security.Authenticator.CredentialCache.Cache"/>
            /// </summary>
            public static implicit operator Org.Apache.Kafka.Common.Security.Authenticator.CredentialCache.Cache(Org.Apache.Kafka.Common.Security.Authenticator.CredentialCache.Cache<C> t) => t.Cast<Org.Apache.Kafka.Common.Security.Authenticator.CredentialCache.Cache>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/security/authenticator/CredentialCache.Cache.html#get-java.lang.String-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><typeparamref name="C"/></returns>
            public C Get(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<C>("get", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/security/authenticator/CredentialCache.Cache.html#put-java.lang.String-java.lang.Object-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><typeparamref name="C"/></param>
            /// <returns><typeparamref name="C"/></returns>
            public C Put(Java.Lang.String arg0, C arg1)
            {
                return IExecuteWithSignature<C>("put", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/security/authenticator/CredentialCache.Cache.html#remove-java.lang.String-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><typeparamref name="C"/></returns>
            public C Remove(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<C>("remove", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/security/authenticator/CredentialCache.Cache.html#credentialClass--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.Class"/></returns>
            public Java.Lang.Class CredentialClass()
            {
                return IExecuteWithSignature<Java.Lang.Class>("credentialClass", "()Ljava/lang/Class;");
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