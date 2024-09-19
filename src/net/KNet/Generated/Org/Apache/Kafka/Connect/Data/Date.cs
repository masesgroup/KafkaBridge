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
*  using connect-api-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Data
{
    #region Date declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/Date.html"/>
    /// </summary>
    public partial class Date : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Date>
    {
        const string _bridgeClassName = "org.apache.kafka.connect.data.Date";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Date() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Date(params object[] args) : base(args) { }

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

    #region Date implementation
    public partial class Date
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/Date.html#LOGICAL_NAME"/>
        /// </summary>
        public static Java.Lang.String LOGICAL_NAME { get { if (!_LOGICAL_NAMEReady) { _LOGICAL_NAMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "LOGICAL_NAME"); _LOGICAL_NAMEReady = true; } return _LOGICAL_NAMEContent; } }
        private static Java.Lang.String _LOGICAL_NAMEContent = default;
        private static bool _LOGICAL_NAMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/Date.html#SCHEMA"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Data.Schema SCHEMA { get { if (!_SCHEMAReady) { _SCHEMAContent = SGetField<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "SCHEMA"); _SCHEMAReady = true; } return _SCHEMAContent; } }
        private static Org.Apache.Kafka.Connect.Data.Schema _SCHEMAContent = default;
        private static bool _SCHEMAReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/Date.html#fromLogical-org.apache.kafka.connect.data.Schema-java.util.Date-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg1"><see cref="Java.Util.Date"/></param>
        /// <returns><see cref="int"/></returns>
        public static int FromLogical(Org.Apache.Kafka.Connect.Data.Schema arg0, Java.Util.Date arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "fromLogical", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/Date.html#toLogical-org.apache.kafka.connect.data.Schema-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Date"/></returns>
        public static Java.Util.Date ToLogical(Org.Apache.Kafka.Connect.Data.Schema arg0, int arg1)
        {
            return SExecute<Java.Util.Date>(LocalBridgeClazz, "toLogical", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.1/org/apache/kafka/connect/data/Date.html#builder--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public static Org.Apache.Kafka.Connect.Data.SchemaBuilder Builder()
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Connect.Data.SchemaBuilder>(LocalBridgeClazz, "builder", "()Lorg/apache/kafka/connect/data/SchemaBuilder;");
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