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

namespace Org.Apache.Kafka.Common.Record
{
    #region Record declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/record/Record.html"/>
    /// </summary>
    public partial class Record : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Record>
    {
        const string _bridgeClassName = "org.apache.kafka.common.record.Record";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("Record class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Record() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("Record class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Record(params object[] args) : base(args) { }

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

    #region IRecord
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IRecord
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Record implementation
    public partial class Record : Org.Apache.Kafka.Common.Record.IRecord
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/record/Record.html#EMPTY_HEADERS"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Header.Header[] EMPTY_HEADERS { get { if (!_EMPTY_HEADERSReady) { _EMPTY_HEADERSContent = SGetFieldArray<Org.Apache.Kafka.Common.Header.Header>(LocalBridgeClazz, "EMPTY_HEADERS"); _EMPTY_HEADERSReady = true; } return _EMPTY_HEADERSContent; } }
        private static Org.Apache.Kafka.Common.Header.Header[] _EMPTY_HEADERSContent = default;
        private static bool _EMPTY_HEADERSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/record/Record.html#hasKey--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasKey()
        {
            return IExecuteWithSignature<bool>("hasKey", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/record/Record.html#hasMagic-byte-"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasMagic(byte arg0)
        {
            return IExecuteWithSignature<bool>("hasMagic", "(B)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/record/Record.html#hasTimestampType-org.apache.kafka.common.record.TimestampType-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Record.TimestampType"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasTimestampType(Org.Apache.Kafka.Common.Record.TimestampType arg0)
        {
            return IExecuteWithSignature<bool>("hasTimestampType", "(Lorg/apache/kafka/common/record/TimestampType;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/record/Record.html#hasValue--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasValue()
        {
            return IExecuteWithSignature<bool>("hasValue", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/record/Record.html#isCompressed--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCompressed()
        {
            return IExecuteWithSignature<bool>("isCompressed", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/record/Record.html#keySize--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int KeySize()
        {
            return IExecuteWithSignature<int>("keySize", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/record/Record.html#sequence--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Sequence()
        {
            return IExecuteWithSignature<int>("sequence", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/record/Record.html#sizeInBytes--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int SizeInBytes()
        {
            return IExecuteWithSignature<int>("sizeInBytes", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/record/Record.html#valueSize--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int ValueSize()
        {
            return IExecuteWithSignature<int>("valueSize", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/record/Record.html#key--"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer Key()
        {
            return IExecuteWithSignature<Java.Nio.ByteBuffer>("key", "()Ljava/nio/ByteBuffer;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/record/Record.html#value--"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer Value()
        {
            return IExecuteWithSignature<Java.Nio.ByteBuffer>("value", "()Ljava/nio/ByteBuffer;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/record/Record.html#offset--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long Offset()
        {
            return IExecuteWithSignature<long>("offset", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/record/Record.html#timestamp--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long Timestamp()
        {
            return IExecuteWithSignature<long>("timestamp", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/record/Record.html#headers--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Header.Header"/></returns>
        public Org.Apache.Kafka.Common.Header.Header[] Headers()
        {
            return IExecuteWithSignatureArray<Org.Apache.Kafka.Common.Header.Header>("headers", "()[Lorg/apache/kafka/common/header/Header;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/record/Record.html#ensureValid--"/>
        /// </summary>
        public void EnsureValid()
        {
            IExecuteWithSignature("ensureValid", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}