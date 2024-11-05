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
*  using connect-transforms-3.6.2.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Transforms.Util
{
    #region SchemaUtil declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.6.2/org/apache/kafka/connect/transforms/util/SchemaUtil.html"/>
    /// </summary>
    public partial class SchemaUtil : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SchemaUtil>
    {
        const string _bridgeClassName = "org.apache.kafka.connect.transforms.util.SchemaUtil";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SchemaUtil() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SchemaUtil(params object[] args) : base(args) { }

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

    #region SchemaUtil implementation
    public partial class SchemaUtil
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.6.2/org/apache/kafka/connect/transforms/util/SchemaUtil.html#copySchemaBasics-org.apache.kafka.connect.data.Schema-org.apache.kafka.connect.data.SchemaBuilder-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public static Org.Apache.Kafka.Connect.Data.SchemaBuilder CopySchemaBasics(Org.Apache.Kafka.Connect.Data.Schema arg0, Org.Apache.Kafka.Connect.Data.SchemaBuilder arg1)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Connect.Data.SchemaBuilder>(LocalBridgeClazz, "copySchemaBasics", "(Lorg/apache/kafka/connect/data/Schema;Lorg/apache/kafka/connect/data/SchemaBuilder;)Lorg/apache/kafka/connect/data/SchemaBuilder;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.6.2/org/apache/kafka/connect/transforms/util/SchemaUtil.html#copySchemaBasics-org.apache.kafka.connect.data.Schema-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public static Org.Apache.Kafka.Connect.Data.SchemaBuilder CopySchemaBasics(Org.Apache.Kafka.Connect.Data.Schema arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Connect.Data.SchemaBuilder>(LocalBridgeClazz, "copySchemaBasics", "(Lorg/apache/kafka/connect/data/Schema;)Lorg/apache/kafka/connect/data/SchemaBuilder;", arg0);
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