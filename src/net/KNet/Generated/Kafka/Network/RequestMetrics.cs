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

namespace Kafka.Network
{
    #region RequestMetrics
    public partial class RequestMetrics
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/RequestMetrics.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="name"><see cref="string"/></param>
        public RequestMetrics(string name)
            : base(name)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Kafka.Network.RequestMetrics"/> to <see cref="Kafka.Metrics.KafkaMetricsGroup"/>
        /// </summary>
        public static implicit operator Kafka.Metrics.KafkaMetricsGroup(Kafka.Network.RequestMetrics t) => t.Cast<Kafka.Metrics.KafkaMetricsGroup>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/RequestMetrics.html#consumerFetchMetricName()"/> 
        /// </summary>
        public static string ConsumerFetchMetricName
        {
            get { return SExecute<string>(LocalBridgeClazz, "consumerFetchMetricName"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/RequestMetrics.html#ErrorsPerSec()"/> 
        /// </summary>
        public static string ErrorsPerSec
        {
            get { return SExecute<string>(LocalBridgeClazz, "ErrorsPerSec"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/RequestMetrics.html#followFetchMetricName()"/> 
        /// </summary>
        public static string FollowFetchMetricName
        {
            get { return SExecute<string>(LocalBridgeClazz, "followFetchMetricName"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/RequestMetrics.html#LocalTimeMs()"/> 
        /// </summary>
        public static string LocalTimeMs
        {
            get { return SExecute<string>(LocalBridgeClazz, "LocalTimeMs"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/RequestMetrics.html#MessageConversionsTimeMs()"/> 
        /// </summary>
        public static string MessageConversionsTimeMs
        {
            get { return SExecute<string>(LocalBridgeClazz, "MessageConversionsTimeMs"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/RequestMetrics.html#RemoteTimeMs()"/> 
        /// </summary>
        public static string RemoteTimeMs
        {
            get { return SExecute<string>(LocalBridgeClazz, "RemoteTimeMs"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/RequestMetrics.html#RequestBytes()"/> 
        /// </summary>
        public static string RequestBytes
        {
            get { return SExecute<string>(LocalBridgeClazz, "RequestBytes"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/RequestMetrics.html#RequestQueueTimeMs()"/> 
        /// </summary>
        public static string RequestQueueTimeMs
        {
            get { return SExecute<string>(LocalBridgeClazz, "RequestQueueTimeMs"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/RequestMetrics.html#RequestsPerSec()"/> 
        /// </summary>
        public static string RequestsPerSec
        {
            get { return SExecute<string>(LocalBridgeClazz, "RequestsPerSec"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/RequestMetrics.html#ResponseQueueTimeMs()"/> 
        /// </summary>
        public static string ResponseQueueTimeMs
        {
            get { return SExecute<string>(LocalBridgeClazz, "ResponseQueueTimeMs"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/RequestMetrics.html#ResponseSendTimeMs()"/> 
        /// </summary>
        public static string ResponseSendTimeMs
        {
            get { return SExecute<string>(LocalBridgeClazz, "ResponseSendTimeMs"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/RequestMetrics.html#TemporaryMemoryBytes()"/> 
        /// </summary>
        public static string TemporaryMemoryBytes
        {
            get { return SExecute<string>(LocalBridgeClazz, "TemporaryMemoryBytes"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/RequestMetrics.html#ThrottleTimeMs()"/> 
        /// </summary>
        public static string ThrottleTimeMs
        {
            get { return SExecute<string>(LocalBridgeClazz, "ThrottleTimeMs"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/RequestMetrics.html#TotalTimeMs()"/> 
        /// </summary>
        public static string TotalTimeMs
        {
            get { return SExecute<string>(LocalBridgeClazz, "TotalTimeMs"); }
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/RequestMetrics.html#isDebugEnabled()"/> 
        /// </summary>
        public bool IsDebugEnabled
        {
            get { return IExecute<bool>("isDebugEnabled"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/RequestMetrics.html#isTraceEnabled()"/> 
        /// </summary>
        public bool IsTraceEnabled
        {
            get { return IExecute<bool>("isTraceEnabled"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/RequestMetrics.html#localTimeHist()"/> 
        /// </summary>
        public Com.Yammer.Metrics.Core.Histogram LocalTimeHist
        {
            get { return IExecute<Com.Yammer.Metrics.Core.Histogram>("localTimeHist"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/RequestMetrics.html#logger()"/> 
        /// </summary>
        public Com.Typesafe.Scalalogging.Logger Logger
        {
            get { return IExecute<Com.Typesafe.Scalalogging.Logger>("logger"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/RequestMetrics.html#loggerName()"/> 
        /// </summary>
        public string LoggerName
        {
            get { return IExecute<string>("loggerName"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/RequestMetrics.html#logIdent()"/> 
        /// </summary>
        public string LogIdent
        {
            get { return IExecute<string>("logIdent"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/RequestMetrics.html#remoteTimeHist()"/> 
        /// </summary>
        public Com.Yammer.Metrics.Core.Histogram RemoteTimeHist
        {
            get { return IExecute<Com.Yammer.Metrics.Core.Histogram>("remoteTimeHist"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/RequestMetrics.html#requestBytesHist()"/> 
        /// </summary>
        public Com.Yammer.Metrics.Core.Histogram RequestBytesHist
        {
            get { return IExecute<Com.Yammer.Metrics.Core.Histogram>("requestBytesHist"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/RequestMetrics.html#requestQueueTimeHist()"/> 
        /// </summary>
        public Com.Yammer.Metrics.Core.Histogram RequestQueueTimeHist
        {
            get { return IExecute<Com.Yammer.Metrics.Core.Histogram>("requestQueueTimeHist"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/RequestMetrics.html#requestRateInternal()"/> 
        /// </summary>
        public Kafka.Utils.Pool<object, Com.Yammer.Metrics.Core.Meter> RequestRateInternal
        {
            get { return IExecute<Kafka.Utils.Pool<object, Com.Yammer.Metrics.Core.Meter>>("requestRateInternal"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/RequestMetrics.html#responseQueueTimeHist()"/> 
        /// </summary>
        public Com.Yammer.Metrics.Core.Histogram ResponseQueueTimeHist
        {
            get { return IExecute<Com.Yammer.Metrics.Core.Histogram>("responseQueueTimeHist"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/RequestMetrics.html#responseSendTimeHist()"/> 
        /// </summary>
        public Com.Yammer.Metrics.Core.Histogram ResponseSendTimeHist
        {
            get { return IExecute<Com.Yammer.Metrics.Core.Histogram>("responseSendTimeHist"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/RequestMetrics.html#throttleTimeHist()"/> 
        /// </summary>
        public Com.Yammer.Metrics.Core.Histogram ThrottleTimeHist
        {
            get { return IExecute<Com.Yammer.Metrics.Core.Histogram>("throttleTimeHist"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/RequestMetrics.html#totalTimeHist()"/> 
        /// </summary>
        public Com.Yammer.Metrics.Core.Histogram TotalTimeHist
        {
            get { return IExecute<Com.Yammer.Metrics.Core.Histogram>("totalTimeHist"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/RequestMetrics.html#newMeter(com.yammer.metrics.core.MetricName,java.lang.String,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="metricName"><see cref="Com.Yammer.Metrics.Core.MetricName"/></param>
        /// <param name="eventType"><see cref="string"/></param>
        /// <param name="timeUnit"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="Com.Yammer.Metrics.Core.Meter"/></returns>
        public Com.Yammer.Metrics.Core.Meter NewMeter(Com.Yammer.Metrics.Core.MetricName metricName, string eventType, Java.Util.Concurrent.TimeUnit timeUnit)
        {
            return IExecute<Com.Yammer.Metrics.Core.Meter>("newMeter", metricName, eventType, timeUnit);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/RequestMetrics.html#requestRate(short)"/>
        /// </summary>
        /// <param name="version"><see cref="short"/></param>
        /// <returns><see cref="Com.Yammer.Metrics.Core.Meter"/></returns>
        public Com.Yammer.Metrics.Core.Meter RequestRate(short version)
        {
            return IExecute<Com.Yammer.Metrics.Core.Meter>("requestRate", version);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/RequestMetrics.html#msgWithLogIdent(java.lang.String)"/>
        /// </summary>
        /// <param name="msg"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string MsgWithLogIdent(string msg)
        {
            return IExecute<string>("msgWithLogIdent", msg);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/RequestMetrics.html#markErrorMeter(org.apache.kafka.common.protocol.Errors,int)"/>
        /// </summary>
        /// <param name="error"><see cref="Org.Apache.Kafka.Common.Protocol.Errors"/></param>
        /// <param name="count"><see cref="int"/></param>
        public void MarkErrorMeter(Org.Apache.Kafka.Common.Protocol.Errors error, int count)
        {
            IExecute("markErrorMeter", error, count);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/RequestMetrics.html#removeMetrics()"/>
        /// </summary>
        public void RemoveMetrics()
        {
            IExecute("removeMetrics");
        }

        #endregion

        #region Nested classes
        #region ErrorMeter
        public partial class ErrorMeter
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/RequestMetrics.ErrorMeter.html#%3Cinit%3E(kafka.network.RequestMetrics,java.lang.String,org.apache.kafka.common.protocol.Errors)"/>
            /// </summary>
            /// <param name="$outer"><see cref="Kafka.Network.RequestMetrics"/></param>
            /// <param name="name"><see cref="string"/></param>
            /// <param name="error"><see cref="Org.Apache.Kafka.Common.Protocol.Errors"/></param>
            public ErrorMeter(Kafka.Network.RequestMetrics _outer, string name, Org.Apache.Kafka.Common.Protocol.Errors error)
                : base(_outer, name, error)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/RequestMetrics.ErrorMeter.html#$outer"/>
            /// </summary>
            public Kafka.Network.RequestMetrics $outer { get { return IGetField<Kafka.Network.RequestMetrics>("$outer"); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/RequestMetrics.ErrorMeter.html#getOrCreateMeter()"/> 
            /// </summary>
            public Com.Yammer.Metrics.Core.Meter OrCreateMeter
            {
                get { return IExecute<Com.Yammer.Metrics.Core.Meter>("getOrCreateMeter"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/RequestMetrics.ErrorMeter.html#removeMeter()"/>
            /// </summary>
            public void RemoveMeter()
            {
                IExecute("removeMeter");
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