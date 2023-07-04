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
*  using kafka-tools-3.5.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Tools
{
    #region StreamsResetter
    public partial class StreamsResetter
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.5.0/org/apache/kafka/tools/StreamsResetter.html#matchesInternalTopicFormat-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool MatchesInternalTopicFormat(string arg0)
        {
            return SExecute<bool>(LocalBridgeClazz, "matchesInternalTopicFormat", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.5.0/org/apache/kafka/tools/StreamsResetter.html#main-java.lang.String[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public static void Main(string[] arg0)
        {
            SExecute(LocalBridgeClazz, "main", new object[] { arg0 });
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.5.0/org/apache/kafka/tools/StreamsResetter.html#run-java.lang.String[]-java.util.Properties-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.Properties"/></param>
        /// <returns><see cref="int"/></returns>
        public int Run(string[] arg0, Java.Util.Properties arg1)
        {
            return IExecute<int>("run", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.5.0/org/apache/kafka/tools/StreamsResetter.html#run-java.lang.String[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        public int Run(string[] arg0)
        {
            return IExecute<int>("run", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.5.0/org/apache/kafka/tools/StreamsResetter.html#doDelete-java.util.List-org.apache.kafka.clients.admin.Admin-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Clients.Admin.Admin"/></param>
        public void DoDelete(Java.Util.List<string> arg0, Org.Apache.Kafka.Clients.Admin.Admin arg1)
        {
            IExecute("doDelete", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.5.0/org/apache/kafka/tools/StreamsResetter.html#maybeSeekToEnd-java.lang.String-org.apache.kafka.clients.consumer.Consumer-java.util.Set-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Clients.Consumer.Consumer"/></param>
        /// <param name="arg2"><see cref="Java.Util.Set"/></param>
        public void MaybeSeekToEnd(string arg0, Org.Apache.Kafka.Clients.Consumer.Consumer<byte[], byte[]> arg1, Java.Util.Set<Org.Apache.Kafka.Common.TopicPartition> arg2)
        {
            IExecute("maybeSeekToEnd", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.5.0/org/apache/kafka/tools/StreamsResetter.html#resetOffsetsFromResetPlan-org.apache.kafka.clients.consumer.Consumer-java.util.Set-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Consumer.Consumer"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        /// <param name="arg2"><see cref="Java.Util.Map"/></param>
        public void ResetOffsetsFromResetPlan(Org.Apache.Kafka.Clients.Consumer.Consumer<byte[], byte[]> arg0, Java.Util.Set<Org.Apache.Kafka.Common.TopicPartition> arg1, Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Java.Lang.Long> arg2)
        {
            IExecute("resetOffsetsFromResetPlan", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.5.0/org/apache/kafka/tools/StreamsResetter.html#resetOffsetsTo-org.apache.kafka.clients.consumer.Consumer-java.util.Set-java.lang.Long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Consumer.Consumer"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Long"/></param>
        public void ResetOffsetsTo(Org.Apache.Kafka.Clients.Consumer.Consumer<byte[], byte[]> arg0, Java.Util.Set<Org.Apache.Kafka.Common.TopicPartition> arg1, Java.Lang.Long arg2)
        {
            IExecute("resetOffsetsTo", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.5.0/org/apache/kafka/tools/StreamsResetter.html#resetToDatetime-org.apache.kafka.clients.consumer.Consumer-java.util.Set-java.lang.Long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Consumer.Consumer"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Long"/></param>
        public void ResetToDatetime(Org.Apache.Kafka.Clients.Consumer.Consumer<byte[], byte[]> arg0, Java.Util.Set<Org.Apache.Kafka.Common.TopicPartition> arg1, Java.Lang.Long arg2)
        {
            IExecute("resetToDatetime", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.5.0/org/apache/kafka/tools/StreamsResetter.html#shiftOffsetsBy-org.apache.kafka.clients.consumer.Consumer-java.util.Set-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Consumer.Consumer"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public void ShiftOffsetsBy(Org.Apache.Kafka.Clients.Consumer.Consumer<byte[], byte[]> arg0, Java.Util.Set<Org.Apache.Kafka.Common.TopicPartition> arg1, long arg2)
        {
            IExecute("shiftOffsetsBy", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}