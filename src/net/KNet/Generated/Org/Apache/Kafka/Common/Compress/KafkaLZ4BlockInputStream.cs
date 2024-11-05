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
*  using kafka-clients-3.6.2.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Compress
{
    #region KafkaLZ4BlockInputStream declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/compress/KafkaLZ4BlockInputStream.html"/>
    /// </summary>
    public partial class KafkaLZ4BlockInputStream : Java.Io.InputStream
    {
        const string _bridgeClassName = "org.apache.kafka.common.compress.KafkaLZ4BlockInputStream";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public KafkaLZ4BlockInputStream() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public KafkaLZ4BlockInputStream(params object[] args) : base(args) { }

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

    #region KafkaLZ4BlockInputStream implementation
    public partial class KafkaLZ4BlockInputStream
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/compress/KafkaLZ4BlockInputStream.html#org.apache.kafka.common.compress.KafkaLZ4BlockInputStream(java.nio.ByteBuffer,org.apache.kafka.common.utils.BufferSupplier,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Utils.BufferSupplier"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public KafkaLZ4BlockInputStream(Java.Nio.ByteBuffer arg0, Org.Apache.Kafka.Common.Utils.BufferSupplier arg1, bool arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/compress/KafkaLZ4BlockInputStream.html#BLOCK_HASH_MISMATCH"/>
        /// </summary>
        public static Java.Lang.String BLOCK_HASH_MISMATCH { get { if (!_BLOCK_HASH_MISMATCHReady) { _BLOCK_HASH_MISMATCHContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "BLOCK_HASH_MISMATCH"); _BLOCK_HASH_MISMATCHReady = true; } return _BLOCK_HASH_MISMATCHContent; } }
        private static Java.Lang.String _BLOCK_HASH_MISMATCHContent = default;
        private static bool _BLOCK_HASH_MISMATCHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/compress/KafkaLZ4BlockInputStream.html#DESCRIPTOR_HASH_MISMATCH"/>
        /// </summary>
        public static Java.Lang.String DESCRIPTOR_HASH_MISMATCH { get { if (!_DESCRIPTOR_HASH_MISMATCHReady) { _DESCRIPTOR_HASH_MISMATCHContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DESCRIPTOR_HASH_MISMATCH"); _DESCRIPTOR_HASH_MISMATCHReady = true; } return _DESCRIPTOR_HASH_MISMATCHContent; } }
        private static Java.Lang.String _DESCRIPTOR_HASH_MISMATCHContent = default;
        private static bool _DESCRIPTOR_HASH_MISMATCHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/compress/KafkaLZ4BlockInputStream.html#NOT_SUPPORTED"/>
        /// </summary>
        public static Java.Lang.String NOT_SUPPORTED { get { if (!_NOT_SUPPORTEDReady) { _NOT_SUPPORTEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "NOT_SUPPORTED"); _NOT_SUPPORTEDReady = true; } return _NOT_SUPPORTEDContent; } }
        private static Java.Lang.String _NOT_SUPPORTEDContent = default;
        private static bool _NOT_SUPPORTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/compress/KafkaLZ4BlockInputStream.html#PREMATURE_EOS"/>
        /// </summary>
        public static Java.Lang.String PREMATURE_EOS { get { if (!_PREMATURE_EOSReady) { _PREMATURE_EOSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "PREMATURE_EOS"); _PREMATURE_EOSReady = true; } return _PREMATURE_EOSContent; } }
        private static Java.Lang.String _PREMATURE_EOSContent = default;
        private static bool _PREMATURE_EOSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/compress/KafkaLZ4BlockInputStream.html#ignoreFlagDescriptorChecksum--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IgnoreFlagDescriptorChecksum()
        {
            return IExecuteWithSignature<bool>("ignoreFlagDescriptorChecksum", "()Z");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}