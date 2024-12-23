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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*  using kafka-clients-3.9.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Admin
{
    #region FeatureUpdate declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/FeatureUpdate.html"/>
    /// </summary>
    public partial class FeatureUpdate : MASES.JCOBridge.C2JBridge.JVMBridgeBase<FeatureUpdate>
    {
        const string _bridgeClassName = "org.apache.kafka.clients.admin.FeatureUpdate";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public FeatureUpdate() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public FeatureUpdate(params object[] args) : base(args) { }

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
        #region UpgradeType declaration
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/FeatureUpdate.UpgradeType.html"/>
        /// </summary>
        public partial class UpgradeType : Java.Lang.Enum<Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType>
        {
            const string _bridgeClassName = "org.apache.kafka.clients.admin.FeatureUpdate$UpgradeType";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public UpgradeType() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public UpgradeType(params object[] args) : base(args) { }

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

    #region FeatureUpdate implementation
    public partial class FeatureUpdate
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/FeatureUpdate.html#org.apache.kafka.clients.admin.FeatureUpdate(short,org.apache.kafka.clients.admin.FeatureUpdate.UpgradeType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType"/></param>
        public FeatureUpdate(short arg0, Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType arg1)
            : base(arg0, arg1)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/FeatureUpdate.html#upgradeType--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType"/></returns>
        public Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType UpgradeTypeMethod()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType>("upgradeType", "()Lorg/apache/kafka/clients/admin/FeatureUpdate$UpgradeType;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/FeatureUpdate.html#maxVersionLevel--"/>
        /// </summary>
        /// <returns><see cref="short"/></returns>
        public short MaxVersionLevel()
        {
            return IExecuteWithSignature<short>("maxVersionLevel", "()S");
        }

        #endregion

        #region Nested classes
        #region UpgradeType implementation
        public partial class UpgradeType
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/FeatureUpdate.UpgradeType.html#SAFE_DOWNGRADE"/>
            /// </summary>
            public static Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType SAFE_DOWNGRADE { get { if (!_SAFE_DOWNGRADEReady) { _SAFE_DOWNGRADEContent = SGetField<Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType>(LocalBridgeClazz, "SAFE_DOWNGRADE"); _SAFE_DOWNGRADEReady = true; } return _SAFE_DOWNGRADEContent; } }
            private static Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType _SAFE_DOWNGRADEContent = default;
            private static bool _SAFE_DOWNGRADEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/FeatureUpdate.UpgradeType.html#UNKNOWN"/>
            /// </summary>
            public static Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType UNKNOWN { get { if (!_UNKNOWNReady) { _UNKNOWNContent = SGetField<Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType>(LocalBridgeClazz, "UNKNOWN"); _UNKNOWNReady = true; } return _UNKNOWNContent; } }
            private static Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType _UNKNOWNContent = default;
            private static bool _UNKNOWNReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/FeatureUpdate.UpgradeType.html#UNSAFE_DOWNGRADE"/>
            /// </summary>
            public static Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType UNSAFE_DOWNGRADE { get { if (!_UNSAFE_DOWNGRADEReady) { _UNSAFE_DOWNGRADEContent = SGetField<Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType>(LocalBridgeClazz, "UNSAFE_DOWNGRADE"); _UNSAFE_DOWNGRADEReady = true; } return _UNSAFE_DOWNGRADEContent; } }
            private static Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType _UNSAFE_DOWNGRADEContent = default;
            private static bool _UNSAFE_DOWNGRADEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/FeatureUpdate.UpgradeType.html#UPGRADE"/>
            /// </summary>
            public static Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType UPGRADE { get { if (!_UPGRADEReady) { _UPGRADEContent = SGetField<Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType>(LocalBridgeClazz, "UPGRADE"); _UPGRADEReady = true; } return _UPGRADEContent; } }
            private static Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType _UPGRADEContent = default;
            private static bool _UPGRADEReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/FeatureUpdate.UpgradeType.html#fromCode-int-"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType"/></returns>
            public static Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType FromCode(int arg0)
            {
                return SExecuteWithSignature<Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType>(LocalBridgeClazz, "fromCode", "(I)Lorg/apache/kafka/clients/admin/FeatureUpdate$UpgradeType;", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/FeatureUpdate.UpgradeType.html#valueOf-java.lang.String-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType"/></returns>
            public static Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/clients/admin/FeatureUpdate$UpgradeType;", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/FeatureUpdate.UpgradeType.html#values--"/>
            /// </summary>
            /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType"/></returns>
            public static Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType[] Values()
            {
                return SExecuteWithSignatureArray<Org.Apache.Kafka.Clients.Admin.FeatureUpdate.UpgradeType>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/clients/admin/FeatureUpdate$UpgradeType;");
            }

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/clients/admin/FeatureUpdate.UpgradeType.html#code--"/>
            /// </summary>
            /// <returns><see cref="byte"/></returns>
            public byte Code()
            {
                return IExecuteWithSignature<byte>("code", "()B");
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