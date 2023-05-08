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
*  using kafka_2.13-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Kafka.Log
{
    #region LogToClean
    public partial class LogToClean
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/LogToClean.html#%3Cinit%3E(org.apache.kafka.common.TopicPartition,kafka.log.UnifiedLog,long,long,boolean)"/>
        /// </summary>
        /// <param name="topicPartition"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <param name="log"><see cref="Kafka.Log.UnifiedLog"/></param>
        /// <param name="firstDirtyOffset"><see cref="long"/></param>
        /// <param name="uncleanableOffset"><see cref="long"/></param>
        /// <param name="needCompactionNow"><see cref="bool"/></param>
        public LogToClean(Org.Apache.Kafka.Common.TopicPartition topicPartition, Kafka.Log.UnifiedLog log, long firstDirtyOffset, long uncleanableOffset, bool needCompactionNow)
            : base(topicPartition, log, firstDirtyOffset, uncleanableOffset, needCompactionNow)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Kafka.Log.LogToClean"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Kafka.Log.LogToClean t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/LogToClean.html#apply(org.apache.kafka.common.TopicPartition,kafka.log.UnifiedLog,long,long,boolean)"/>
        /// </summary>
        /// <param name="topicPartition"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <param name="log"><see cref="Kafka.Log.UnifiedLog"/></param>
        /// <param name="firstDirtyOffset"><see cref="long"/></param>
        /// <param name="uncleanableOffset"><see cref="long"/></param>
        /// <param name="needCompactionNow"><see cref="bool"/></param>
        /// <returns><see cref="Kafka.Log.LogToClean"/></returns>
        public static Kafka.Log.LogToClean Apply(Org.Apache.Kafka.Common.TopicPartition topicPartition, Kafka.Log.UnifiedLog log, long firstDirtyOffset, long uncleanableOffset, bool needCompactionNow)
        {
            return SExecute<Kafka.Log.LogToClean>(LocalBridgeClazz, "apply", topicPartition, log, firstDirtyOffset, uncleanableOffset, needCompactionNow);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/LogToClean.html#cleanableBytes()"/> 
        /// </summary>
        public long CleanableBytes
        {
            get { return IExecute<long>("cleanableBytes"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/LogToClean.html#cleanableRatio()"/> 
        /// </summary>
        public double CleanableRatio
        {
            get { return IExecute<double>("cleanableRatio"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/LogToClean.html#cleanBytes()"/> 
        /// </summary>
        public long CleanBytes
        {
            get { return IExecute<long>("cleanBytes"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/LogToClean.html#firstDirtyOffset()"/> 
        /// </summary>
        public long FirstDirtyOffset
        {
            get { return IExecute<long>("firstDirtyOffset"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/LogToClean.html#firstUncleanableOffset()"/> 
        /// </summary>
        public long FirstUncleanableOffset
        {
            get { return IExecute<long>("firstUncleanableOffset"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/LogToClean.html#log()"/> 
        /// </summary>
        public Kafka.Log.UnifiedLog Log
        {
            get { return IExecute<Kafka.Log.UnifiedLog>("log"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/LogToClean.html#needCompactionNow()"/> 
        /// </summary>
        public bool NeedCompactionNow
        {
            get { return IExecute<bool>("needCompactionNow"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/LogToClean.html#productArity()"/> 
        /// </summary>
        public int ProductArity
        {
            get { return IExecute<int>("productArity"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/LogToClean.html#productPrefix()"/> 
        /// </summary>
        public string ProductPrefix
        {
            get { return IExecute<string>("productPrefix"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/LogToClean.html#topicPartition()"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.TopicPartition TopicPartition
        {
            get { return IExecute<Org.Apache.Kafka.Common.TopicPartition>("topicPartition"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/LogToClean.html#totalBytes()"/> 
        /// </summary>
        public long TotalBytes
        {
            get { return IExecute<long>("totalBytes"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/LogToClean.html#uncleanableOffset()"/> 
        /// </summary>
        public long UncleanableOffset
        {
            get { return IExecute<long>("uncleanableOffset"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/LogToClean.html#canEqual(java.lang.Object)"/>
        /// </summary>
        /// <param name="x$1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CanEqual(object x_1)
        {
            return IExecute<bool>("canEqual", x_1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/LogToClean.html#compare(java.lang.Object)"/>
        /// </summary>
        /// <param name="that"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int Compare(object that)
        {
            return IExecute<int>("compare", that);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/LogToClean.html#compare(kafka.log.LogToClean)"/>
        /// </summary>
        /// <param name="that"><see cref="Kafka.Log.LogToClean"/></param>
        /// <returns><see cref="int"/></returns>
        public int Compare(Kafka.Log.LogToClean that)
        {
            return IExecute<int>("compare", that);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/LogToClean.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="that"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object that)
        {
            return IExecute<int>("compareTo", that);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/LogToClean.html#productElement(int)"/>
        /// </summary>
        /// <param name="x$1"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object ProductElement(int x_1)
        {
            return IExecute("productElement", x_1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/LogToClean.html#productElementName(int)"/>
        /// </summary>
        /// <param name="x$1"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string ProductElementName(int x_1)
        {
            return IExecute<string>("productElementName", x_1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/LogToClean.html#copy(org.apache.kafka.common.TopicPartition,kafka.log.UnifiedLog,long,long,boolean)"/>
        /// </summary>
        /// <param name="topicPartition"><see cref="Org.Apache.Kafka.Common.TopicPartition"/></param>
        /// <param name="log"><see cref="Kafka.Log.UnifiedLog"/></param>
        /// <param name="firstDirtyOffset"><see cref="long"/></param>
        /// <param name="uncleanableOffset"><see cref="long"/></param>
        /// <param name="needCompactionNow"><see cref="bool"/></param>
        /// <returns><see cref="Kafka.Log.LogToClean"/></returns>
        public Kafka.Log.LogToClean Copy(Org.Apache.Kafka.Common.TopicPartition topicPartition, Kafka.Log.UnifiedLog log, long firstDirtyOffset, long uncleanableOffset, bool needCompactionNow)
        {
            return IExecute<Kafka.Log.LogToClean>("copy", topicPartition, log, firstDirtyOffset, uncleanableOffset, needCompactionNow);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}