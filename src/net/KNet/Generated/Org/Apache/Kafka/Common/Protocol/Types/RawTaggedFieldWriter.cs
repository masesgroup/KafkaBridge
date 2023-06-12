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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using kafka-clients-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Protocol.Types
{
    #region RawTaggedFieldWriter
    public partial class RawTaggedFieldWriter
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/types/RawTaggedFieldWriter.html#forFields(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Protocol.Types.RawTaggedFieldWriter"/></returns>
        public static Org.Apache.Kafka.Common.Protocol.Types.RawTaggedFieldWriter ForFields(Java.Util.List<Org.Apache.Kafka.Common.Protocol.Types.RawTaggedField> arg0)
        {
            return SExecute<Org.Apache.Kafka.Common.Protocol.Types.RawTaggedFieldWriter>(LocalBridgeClazz, "forFields", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/types/RawTaggedFieldWriter.html#numFields()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int NumFields()
        {
            return IExecute<int>("numFields");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/protocol/types/RawTaggedFieldWriter.html#writeRawTags(org.apache.kafka.common.protocol.Writable,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Protocol.Writable"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteRawTags(Org.Apache.Kafka.Common.Protocol.Writable arg0, int arg1)
        {
            IExecute("writeRawTags", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}