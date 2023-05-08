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

namespace Kafka.Server.Metadata
{
    #region BrokerMetadataPublisher
    public partial class BrokerMetadataPublisher
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Kafka.Server.Metadata.BrokerMetadataPublisher"/> to <see cref="Kafka.Server.Metadata.MetadataPublisher"/>
        /// </summary>
        public static implicit operator Kafka.Server.Metadata.MetadataPublisher(Kafka.Server.Metadata.BrokerMetadataPublisher t) => t.Cast<Kafka.Server.Metadata.MetadataPublisher>();
        /// <summary>
        /// Converter from <see cref="Kafka.Server.Metadata.BrokerMetadataPublisher"/> to <see cref="Kafka.Utils.Logging"/>
        /// </summary>
        public static implicit operator Kafka.Utils.Logging(Kafka.Server.Metadata.BrokerMetadataPublisher t) => t.Cast<Kafka.Utils.Logging>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/metadata/BrokerMetadataPublisher.html#_firstPublish()"/> 
        /// </summary>
        public bool _firstPublish
        {
            get { return IExecute<bool>("_firstPublish"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/metadata/BrokerMetadataPublisher.html#brokerId()"/> 
        /// </summary>
        public int BrokerId
        {
            get { return IExecute<int>("brokerId"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/metadata/BrokerMetadataPublisher.html#dynamicConfigPublisher()"/> 
        /// </summary>
        public Kafka.Server.Metadata.DynamicConfigPublisher DynamicConfigPublisher
        {
            get { return IExecute<Kafka.Server.Metadata.DynamicConfigPublisher>("dynamicConfigPublisher"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/metadata/BrokerMetadataPublisher.html#isDebugEnabled()"/> 
        /// </summary>
        public bool IsDebugEnabled
        {
            get { return IExecute<bool>("isDebugEnabled"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/metadata/BrokerMetadataPublisher.html#isTraceEnabled()"/> 
        /// </summary>
        public bool IsTraceEnabled
        {
            get { return IExecute<bool>("isTraceEnabled"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/metadata/BrokerMetadataPublisher.html#logger()"/> 
        /// </summary>
        public Com.Typesafe.Scalalogging.Logger Logger
        {
            get { return IExecute<Com.Typesafe.Scalalogging.Logger>("logger"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/metadata/BrokerMetadataPublisher.html#loggerName()"/> 
        /// </summary>
        public string LoggerName
        {
            get { return IExecute<string>("loggerName"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/metadata/BrokerMetadataPublisher.html#logIdent()"/> 
        /// </summary>
        public string LogIdent
        {
            get { return IExecute<string>("logIdent"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/metadata/BrokerMetadataPublisher.html#publishedOffset()"/> 
        /// </summary>
        public long PublishedOffset
        {
            get { return IExecute<long>("publishedOffset"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/metadata/BrokerMetadataPublisher.html#publishedOffsetAtomic()"/> 
        /// </summary>
        public Java.Util.Concurrent.Atomic.AtomicLong PublishedOffsetAtomic
        {
            get { return IExecute<Java.Util.Concurrent.Atomic.AtomicLong>("publishedOffsetAtomic"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/metadata/BrokerMetadataPublisher.html#msgWithLogIdent(java.lang.String)"/>
        /// </summary>
        /// <param name="msg"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string MsgWithLogIdent(string msg)
        {
            return IExecute<string>("msgWithLogIdent", msg);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/metadata/BrokerMetadataPublisher.html#publish(org.apache.kafka.image.MetadataDelta,org.apache.kafka.image.MetadataImage)"/>
        /// </summary>
        /// <param name="delta"><see cref="Org.Apache.Kafka.Image.MetadataDelta"/></param>
        /// <param name="newImage"><see cref="Org.Apache.Kafka.Image.MetadataImage"/></param>
        public void Publish(Org.Apache.Kafka.Image.MetadataDelta delta, Org.Apache.Kafka.Image.MetadataImage newImage)
        {
            IExecute("publish", delta, newImage);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/metadata/BrokerMetadataPublisher.html#reloadUpdatedFilesWithoutConfigChange(java.util.Properties)"/>
        /// </summary>
        /// <param name="props"><see cref="Java.Util.Properties"/></param>
        public void ReloadUpdatedFilesWithoutConfigChange(Java.Util.Properties props)
        {
            IExecute("reloadUpdatedFilesWithoutConfigChange", props);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}