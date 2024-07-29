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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using connect-api-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Sink
{
    #region SinkRecord
    public partial class SinkRecord
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.0/org/apache/kafka/connect/sink/SinkRecord.html#org.apache.kafka.connect.sink.SinkRecord(java.lang.String,int,org.apache.kafka.connect.data.Schema,java.lang.Object,org.apache.kafka.connect.data.Schema,java.lang.Object,long,java.lang.Long,org.apache.kafka.common.record.TimestampType,java.lang.Iterable,java.lang.String,java.lang.Integer,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg5"><see cref="object"/></param>
        /// <param name="arg6"><see cref="long"/></param>
        /// <param name="arg7"><see cref="Java.Lang.Long"/></param>
        /// <param name="arg8"><see cref="Org.Apache.Kafka.Common.Record.TimestampType"/></param>
        /// <param name="arg9"><see cref="Java.Lang.Iterable"/></param>
        /// <param name="arg10"><see cref="Java.Lang.String"/></param>
        /// <param name="arg11"><see cref="Java.Lang.Integer"/></param>
        /// <param name="arg12"><see cref="long"/></param>
        public SinkRecord(Java.Lang.String arg0, int arg1, Org.Apache.Kafka.Connect.Data.Schema arg2, object arg3, Org.Apache.Kafka.Connect.Data.Schema arg4, object arg5, long arg6, Java.Lang.Long arg7, Org.Apache.Kafka.Common.Record.TimestampType arg8, Java.Lang.Iterable<Org.Apache.Kafka.Connect.Header.Header> arg9, Java.Lang.String arg10, Java.Lang.Integer arg11, long arg12)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.0/org/apache/kafka/connect/sink/SinkRecord.html#org.apache.kafka.connect.sink.SinkRecord(java.lang.String,int,org.apache.kafka.connect.data.Schema,java.lang.Object,org.apache.kafka.connect.data.Schema,java.lang.Object,long,java.lang.Long,org.apache.kafka.common.record.TimestampType,java.lang.Iterable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg5"><see cref="object"/></param>
        /// <param name="arg6"><see cref="long"/></param>
        /// <param name="arg7"><see cref="Java.Lang.Long"/></param>
        /// <param name="arg8"><see cref="Org.Apache.Kafka.Common.Record.TimestampType"/></param>
        /// <param name="arg9"><see cref="Java.Lang.Iterable"/></param>
        public SinkRecord(Java.Lang.String arg0, int arg1, Org.Apache.Kafka.Connect.Data.Schema arg2, object arg3, Org.Apache.Kafka.Connect.Data.Schema arg4, object arg5, long arg6, Java.Lang.Long arg7, Org.Apache.Kafka.Common.Record.TimestampType arg8, Java.Lang.Iterable<Org.Apache.Kafka.Connect.Header.Header> arg9)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.0/org/apache/kafka/connect/sink/SinkRecord.html#org.apache.kafka.connect.sink.SinkRecord(java.lang.String,int,org.apache.kafka.connect.data.Schema,java.lang.Object,org.apache.kafka.connect.data.Schema,java.lang.Object,long,java.lang.Long,org.apache.kafka.common.record.TimestampType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg5"><see cref="object"/></param>
        /// <param name="arg6"><see cref="long"/></param>
        /// <param name="arg7"><see cref="Java.Lang.Long"/></param>
        /// <param name="arg8"><see cref="Org.Apache.Kafka.Common.Record.TimestampType"/></param>
        public SinkRecord(Java.Lang.String arg0, int arg1, Org.Apache.Kafka.Connect.Data.Schema arg2, object arg3, Org.Apache.Kafka.Connect.Data.Schema arg4, object arg5, long arg6, Java.Lang.Long arg7, Org.Apache.Kafka.Common.Record.TimestampType arg8)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.0/org/apache/kafka/connect/sink/SinkRecord.html#org.apache.kafka.connect.sink.SinkRecord(java.lang.String,int,org.apache.kafka.connect.data.Schema,java.lang.Object,org.apache.kafka.connect.data.Schema,java.lang.Object,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <param name="arg4"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg5"><see cref="object"/></param>
        /// <param name="arg6"><see cref="long"/></param>
        public SinkRecord(Java.Lang.String arg0, int arg1, Org.Apache.Kafka.Connect.Data.Schema arg2, object arg3, Org.Apache.Kafka.Connect.Data.Schema arg4, object arg5, long arg6)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.0/org/apache/kafka/connect/sink/SinkRecord.html#originalKafkaPartition--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        public Java.Lang.Integer OriginalKafkaPartition()
        {
            return IExecuteWithSignature<Java.Lang.Integer>("originalKafkaPartition", "()Ljava/lang/Integer;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.0/org/apache/kafka/connect/sink/SinkRecord.html#originalTopic--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String OriginalTopic()
        {
            return IExecuteWithSignature<Java.Lang.String>("originalTopic", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.0/org/apache/kafka/connect/sink/SinkRecord.html#kafkaOffset--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long KafkaOffset()
        {
            return IExecuteWithSignature<long>("kafkaOffset", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.0/org/apache/kafka/connect/sink/SinkRecord.html#originalKafkaOffset--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long OriginalKafkaOffset()
        {
            return IExecuteWithSignature<long>("originalKafkaOffset", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.0/org/apache/kafka/connect/sink/SinkRecord.html#timestampType--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Record.TimestampType"/></returns>
        public Org.Apache.Kafka.Common.Record.TimestampType TimestampType()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Record.TimestampType>("timestampType", "()Lorg/apache/kafka/common/record/TimestampType;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}