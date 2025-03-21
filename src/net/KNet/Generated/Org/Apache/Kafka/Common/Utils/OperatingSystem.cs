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
*  using kafka-clients-3.9.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Utils
{
    #region OperatingSystem declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/utils/OperatingSystem.html"/>
    /// </summary>
    public partial class OperatingSystem : MASES.JCOBridge.C2JBridge.JVMBridgeBase<OperatingSystem>
    {
        const string _bridgeClassName = "org.apache.kafka.common.utils.OperatingSystem";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public OperatingSystem() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public OperatingSystem(params object[] args) : base(args) { }

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

    #region OperatingSystem implementation
    public partial class OperatingSystem
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/utils/OperatingSystem.html#IS_WINDOWS"/>
        /// </summary>
        public static bool IS_WINDOWS { get { if (!_IS_WINDOWSReady) { _IS_WINDOWSContent = SGetField<bool>(LocalBridgeClazz, "IS_WINDOWS"); _IS_WINDOWSReady = true; } return _IS_WINDOWSContent; } }
        private static bool _IS_WINDOWSContent = default;
        private static bool _IS_WINDOWSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/utils/OperatingSystem.html#IS_ZOS"/>
        /// </summary>
        public static bool IS_ZOS { get { if (!_IS_ZOSReady) { _IS_ZOSContent = SGetField<bool>(LocalBridgeClazz, "IS_ZOS"); _IS_ZOSReady = true; } return _IS_ZOSContent; } }
        private static bool _IS_ZOSContent = default;
        private static bool _IS_ZOSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/utils/OperatingSystem.html#NAME"/>
        /// </summary>
        public static Java.Lang.String NAME { get { if (!_NAMEReady) { _NAMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "NAME"); _NAMEReady = true; } return _NAMEContent; } }
        private static Java.Lang.String _NAMEContent = default;
        private static bool _NAMEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}