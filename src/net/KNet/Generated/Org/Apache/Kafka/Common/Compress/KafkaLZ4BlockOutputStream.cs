/*
*  Copyright 2023 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.0.0.0)
*  using kafka-clients-3.5.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Compress
{
    #region KafkaLZ4BlockOutputStream
    public partial class KafkaLZ4BlockOutputStream
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/compress/KafkaLZ4BlockOutputStream.html#org.apache.kafka.common.compress.KafkaLZ4BlockOutputStream(java.io.OutputStream,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public KafkaLZ4BlockOutputStream(Java.Io.OutputStream arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/compress/KafkaLZ4BlockOutputStream.html#org.apache.kafka.common.compress.KafkaLZ4BlockOutputStream(java.io.OutputStream,int,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public KafkaLZ4BlockOutputStream(Java.Io.OutputStream arg0, int arg1, bool arg2, bool arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/compress/KafkaLZ4BlockOutputStream.html#org.apache.kafka.common.compress.KafkaLZ4BlockOutputStream(java.io.OutputStream,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public KafkaLZ4BlockOutputStream(Java.Io.OutputStream arg0, int arg1, bool arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/compress/KafkaLZ4BlockOutputStream.html#org.apache.kafka.common.compress.KafkaLZ4BlockOutputStream(java.io.OutputStream,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public KafkaLZ4BlockOutputStream(Java.Io.OutputStream arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/compress/KafkaLZ4BlockOutputStream.html#org.apache.kafka.common.compress.KafkaLZ4BlockOutputStream(java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public KafkaLZ4BlockOutputStream(Java.Io.OutputStream arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/compress/KafkaLZ4BlockOutputStream.html#BLOCKSIZE_1MB"/>
        /// </summary>
        public static int BLOCKSIZE_1MB { get { return SGetField<int>(LocalBridgeClazz, "BLOCKSIZE_1MB"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/compress/KafkaLZ4BlockOutputStream.html#BLOCKSIZE_256KB"/>
        /// </summary>
        public static int BLOCKSIZE_256KB { get { return SGetField<int>(LocalBridgeClazz, "BLOCKSIZE_256KB"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/compress/KafkaLZ4BlockOutputStream.html#BLOCKSIZE_4MB"/>
        /// </summary>
        public static int BLOCKSIZE_4MB { get { return SGetField<int>(LocalBridgeClazz, "BLOCKSIZE_4MB"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/compress/KafkaLZ4BlockOutputStream.html#BLOCKSIZE_64KB"/>
        /// </summary>
        public static int BLOCKSIZE_64KB { get { return SGetField<int>(LocalBridgeClazz, "BLOCKSIZE_64KB"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/compress/KafkaLZ4BlockOutputStream.html#LZ4_FRAME_INCOMPRESSIBLE_MASK"/>
        /// </summary>
        public static int LZ4_FRAME_INCOMPRESSIBLE_MASK { get { return SGetField<int>(LocalBridgeClazz, "LZ4_FRAME_INCOMPRESSIBLE_MASK"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/compress/KafkaLZ4BlockOutputStream.html#LZ4_MAX_HEADER_LENGTH"/>
        /// </summary>
        public static int LZ4_MAX_HEADER_LENGTH { get { return SGetField<int>(LocalBridgeClazz, "LZ4_MAX_HEADER_LENGTH"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/compress/KafkaLZ4BlockOutputStream.html#MAGIC"/>
        /// </summary>
        public static int MAGIC { get { return SGetField<int>(LocalBridgeClazz, "MAGIC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/compress/KafkaLZ4BlockOutputStream.html#CLOSED_STREAM"/>
        /// </summary>
        public static string CLOSED_STREAM { get { return SGetField<string>(LocalBridgeClazz, "CLOSED_STREAM"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/compress/KafkaLZ4BlockOutputStream.html#useBrokenFlagDescriptorChecksum--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool UseBrokenFlagDescriptorChecksum()
        {
            return IExecute<bool>("useBrokenFlagDescriptorChecksum");
        }

        #endregion

        #region Nested classes
        #region BD
        public partial class BD
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/compress/KafkaLZ4BlockOutputStream.BD.html#org.apache.kafka.common.compress.KafkaLZ4BlockOutputStream$BD(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public BD(int arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/compress/KafkaLZ4BlockOutputStream.BD.html#fromByte-byte-"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Common.Compress.KafkaLZ4BlockOutputStream.BD"/></returns>
            public static Org.Apache.Kafka.Common.Compress.KafkaLZ4BlockOutputStream.BD FromByte(byte arg0)
            {
                return SExecute<Org.Apache.Kafka.Common.Compress.KafkaLZ4BlockOutputStream.BD>(LocalBridgeClazz, "fromByte", arg0);
            }

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/compress/KafkaLZ4BlockOutputStream.BD.html#getBlockMaximumSize--"/> 
            /// </summary>
            public int BlockMaximumSize
            {
                get { return IExecute<int>("getBlockMaximumSize"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/compress/KafkaLZ4BlockOutputStream.BD.html#toByte--"/>
            /// </summary>

            /// <returns><see cref="byte"/></returns>
            public byte ToByte()
            {
                return IExecute<byte>("toByte");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region FLG
        public partial class FLG
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/compress/KafkaLZ4BlockOutputStream.FLG.html#org.apache.kafka.common.compress.KafkaLZ4BlockOutputStream$FLG(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            public FLG(bool arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/compress/KafkaLZ4BlockOutputStream.FLG.html#fromByte-byte-"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Common.Compress.KafkaLZ4BlockOutputStream.FLG"/></returns>
            public static Org.Apache.Kafka.Common.Compress.KafkaLZ4BlockOutputStream.FLG FromByte(byte arg0)
            {
                return SExecute<Org.Apache.Kafka.Common.Compress.KafkaLZ4BlockOutputStream.FLG>(LocalBridgeClazz, "fromByte", arg0);
            }

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/compress/KafkaLZ4BlockOutputStream.FLG.html#getVersion--"/> 
            /// </summary>
            public int Version
            {
                get { return IExecute<int>("getVersion"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/compress/KafkaLZ4BlockOutputStream.FLG.html#isBlockChecksumSet--"/>
            /// </summary>

            /// <returns><see cref="bool"/></returns>
            public bool IsBlockChecksumSet()
            {
                return IExecute<bool>("isBlockChecksumSet");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/compress/KafkaLZ4BlockOutputStream.FLG.html#isBlockIndependenceSet--"/>
            /// </summary>

            /// <returns><see cref="bool"/></returns>
            public bool IsBlockIndependenceSet()
            {
                return IExecute<bool>("isBlockIndependenceSet");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/compress/KafkaLZ4BlockOutputStream.FLG.html#isContentChecksumSet--"/>
            /// </summary>

            /// <returns><see cref="bool"/></returns>
            public bool IsContentChecksumSet()
            {
                return IExecute<bool>("isContentChecksumSet");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/compress/KafkaLZ4BlockOutputStream.FLG.html#isContentSizeSet--"/>
            /// </summary>

            /// <returns><see cref="bool"/></returns>
            public bool IsContentSizeSet()
            {
                return IExecute<bool>("isContentSizeSet");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/compress/KafkaLZ4BlockOutputStream.FLG.html#toByte--"/>
            /// </summary>

            /// <returns><see cref="byte"/></returns>
            public byte ToByte()
            {
                return IExecute<byte>("toByte");
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