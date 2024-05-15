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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*  using kafka-clients-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Utils
{
    #region Checksums
    public partial class Checksums
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/utils/Checksums.html#update-java.util.zip.Checksum-java.nio.ByteBuffer-int-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Zip.Checksum"/></param>
        /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public static void Update(Java.Util.Zip.Checksum arg0, Java.Nio.ByteBuffer arg1, int arg2, int arg3)
        {
            SExecute(LocalBridgeClazz, "update", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/utils/Checksums.html#update-java.util.zip.Checksum-java.nio.ByteBuffer-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Zip.Checksum"/></param>
        /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public static void Update(Java.Util.Zip.Checksum arg0, Java.Nio.ByteBuffer arg1, int arg2)
        {
            SExecute(LocalBridgeClazz, "update", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/utils/Checksums.html#updateInt-java.util.zip.Checksum-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Zip.Checksum"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public static void UpdateInt(Java.Util.Zip.Checksum arg0, int arg1)
        {
            SExecute(LocalBridgeClazz, "updateInt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/utils/Checksums.html#updateLong-java.util.zip.Checksum-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Zip.Checksum"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        public static void UpdateLong(Java.Util.Zip.Checksum arg0, long arg1)
        {
            SExecute(LocalBridgeClazz, "updateLong", arg0, arg1);
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