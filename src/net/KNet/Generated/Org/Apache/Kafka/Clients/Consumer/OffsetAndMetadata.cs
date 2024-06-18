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
*  This file is generated by MASES.JNetReflector (ver. 2.5.3.0)
*  using kafka-clients-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Consumer
{
    #region OffsetAndMetadata
    public partial class OffsetAndMetadata
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/consumer/OffsetAndMetadata.html#org.apache.kafka.clients.consumer.OffsetAndMetadata(long,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public OffsetAndMetadata(long arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/consumer/OffsetAndMetadata.html#org.apache.kafka.clients.consumer.OffsetAndMetadata(long,java.util.Optional,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Optional"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        public OffsetAndMetadata(long arg0, Java.Util.Optional<Java.Lang.Integer> arg1, Java.Lang.String arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/consumer/OffsetAndMetadata.html#org.apache.kafka.clients.consumer.OffsetAndMetadata(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public OffsetAndMetadata(long arg0)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/consumer/OffsetAndMetadata.html#metadata--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Metadata()
        {
            return IExecuteWithSignature<Java.Lang.String>("metadata", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/consumer/OffsetAndMetadata.html#leaderEpoch--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Java.Lang.Integer> LeaderEpoch()
        {
            return IExecuteWithSignature<Java.Util.Optional<Java.Lang.Integer>>("leaderEpoch", "()Ljava/util/Optional;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/consumer/OffsetAndMetadata.html#offset--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long Offset()
        {
            return IExecuteWithSignature<long>("offset", "()J");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}