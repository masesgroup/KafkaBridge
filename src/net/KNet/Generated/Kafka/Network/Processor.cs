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
    #region Processor
    public partial class Processor
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.html#%3Cinit%3E(int,org.apache.kafka.common.utils.Time,int,kafka.network.RequestChannel,kafka.network.ConnectionQuotas,long,int,org.apache.kafka.common.network.ListenerName,org.apache.kafka.common.security.auth.SecurityProtocol,kafka.server.KafkaConfig,org.apache.kafka.common.metrics.Metrics,kafka.security.CredentialProvider,org.apache.kafka.common.memory.MemoryPool,org.apache.kafka.common.utils.LogContext,int,boolean,kafka.server.ApiVersionManager,java.lang.String)"/>
        /// </summary>
        /// <param name="id"><see cref="int"/></param>
        /// <param name="time"><see cref="Org.Apache.Kafka.Common.Utils.Time"/></param>
        /// <param name="maxRequestSize"><see cref="int"/></param>
        /// <param name="requestChannel"><see cref="Kafka.Network.RequestChannel"/></param>
        /// <param name="connectionQuotas"><see cref="Kafka.Network.ConnectionQuotas"/></param>
        /// <param name="connectionsMaxIdleMs"><see cref="long"/></param>
        /// <param name="failedAuthenticationDelayMs"><see cref="int"/></param>
        /// <param name="listenerName"><see cref="Org.Apache.Kafka.Common.Network.ListenerName"/></param>
        /// <param name="securityProtocol"><see cref="Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol"/></param>
        /// <param name="config"><see cref="Kafka.Server.KafkaConfig"/></param>
        /// <param name="metrics"><see cref="Org.Apache.Kafka.Common.Metrics.Metrics"/></param>
        /// <param name="credentialProvider"><see cref="Kafka.Security.CredentialProvider"/></param>
        /// <param name="memoryPool"><see cref="Org.Apache.Kafka.Common.Memory.MemoryPool"/></param>
        /// <param name="logContext"><see cref="Org.Apache.Kafka.Common.Utils.LogContext"/></param>
        /// <param name="connectionQueueSize"><see cref="int"/></param>
        /// <param name="isPrivilegedListener"><see cref="bool"/></param>
        /// <param name="apiVersionManager"><see cref="Kafka.Server.ApiVersionManager"/></param>
        /// <param name="threadName"><see cref="string"/></param>
        public Processor(int id, Org.Apache.Kafka.Common.Utils.Time time, int maxRequestSize, Kafka.Network.RequestChannel requestChannel, Kafka.Network.ConnectionQuotas connectionQuotas, long connectionsMaxIdleMs, int failedAuthenticationDelayMs, Org.Apache.Kafka.Common.Network.ListenerName listenerName, Org.Apache.Kafka.Common.Security.Auth.SecurityProtocol securityProtocol, Kafka.Server.KafkaConfig config, Org.Apache.Kafka.Common.Metrics.Metrics metrics, Kafka.Security.CredentialProvider credentialProvider, Org.Apache.Kafka.Common.Memory.MemoryPool memoryPool, Org.Apache.Kafka.Common.Utils.LogContext logContext, int connectionQueueSize, bool isPrivilegedListener, Kafka.Server.ApiVersionManager apiVersionManager, string threadName)
            : base(id, time, maxRequestSize, requestChannel, connectionQuotas, connectionsMaxIdleMs, failedAuthenticationDelayMs, listenerName, securityProtocol, config, metrics, credentialProvider, memoryPool, logContext, connectionQueueSize, isPrivilegedListener, apiVersionManager, threadName)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Kafka.Network.Processor"/> to <see cref="Java.Lang.Runnable"/>
        /// </summary>
        public static implicit operator Java.Lang.Runnable(Kafka.Network.Processor t) => t.Cast<Java.Lang.Runnable>();
        /// <summary>
        /// Converter from <see cref="Kafka.Network.Processor"/> to <see cref="Kafka.Metrics.KafkaMetricsGroup"/>
        /// </summary>
        public static implicit operator Kafka.Metrics.KafkaMetricsGroup(Kafka.Network.Processor t) => t.Cast<Kafka.Metrics.KafkaMetricsGroup>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.html#ConnectionQueueSize()"/> 
        /// </summary>
        public static int ConnectionQueueSize
        {
            get { return SExecute<int>(LocalBridgeClazz, "ConnectionQueueSize"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.html#IdlePercentMetricName()"/> 
        /// </summary>
        public static string IdlePercentMetricName
        {
            get { return SExecute<string>(LocalBridgeClazz, "IdlePercentMetricName"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.html#ListenerMetricTag()"/> 
        /// </summary>
        public static string ListenerMetricTag
        {
            get { return SExecute<string>(LocalBridgeClazz, "ListenerMetricTag"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.html#NetworkProcessorMetricTag()"/> 
        /// </summary>
        public static string NetworkProcessorMetricTag
        {
            get { return SExecute<string>(LocalBridgeClazz, "NetworkProcessorMetricTag"); }
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.html#expiredConnectionsKilledCount()"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.Metrics.Stats.CumulativeSum ExpiredConnectionsKilledCount
        {
            get { return IExecute<Org.Apache.Kafka.Common.Metrics.Stats.CumulativeSum>("expiredConnectionsKilledCount"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.html#id()"/> 
        /// </summary>
        public int Id
        {
            get { return IExecute<int>("id"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.html#inflightResponseCount()"/> 
        /// </summary>
        public int InflightResponseCount
        {
            get { return IExecute<int>("inflightResponseCount"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.html#isDebugEnabled()"/> 
        /// </summary>
        public bool IsDebugEnabled
        {
            get { return IExecute<bool>("isDebugEnabled"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.html#isTraceEnabled()"/> 
        /// </summary>
        public bool IsTraceEnabled
        {
            get { return IExecute<bool>("isTraceEnabled"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.html#logger()"/> 
        /// </summary>
        public Com.Typesafe.Scalalogging.Logger Logger
        {
            get { return IExecute<Com.Typesafe.Scalalogging.Logger>("logger"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.html#loggerName()"/> 
        /// </summary>
        public string LoggerName
        {
            get { return IExecute<string>("loggerName"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.html#logIdent()"/> 
        /// </summary>
        public string LogIdent
        {
            get { return IExecute<string>("logIdent"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.html#metricTags()"/> 
        /// </summary>
        public Java.Util.Map<string, string> MetricTags
        {
            get { return IExecute<Java.Util.Map<string, string>>("metricTags"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.html#responseQueueSize()"/> 
        /// </summary>
        public int ResponseQueueSize
        {
            get { return IExecute<int>("responseQueueSize"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.html#selector()"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.Network.Selector Selector
        {
            get { return IExecute<Org.Apache.Kafka.Common.Network.Selector>("selector"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.html#shouldRun()"/> 
        /// </summary>
        public Java.Util.Concurrent.Atomic.AtomicBoolean ShouldRun
        {
            get { return IExecute<Java.Util.Concurrent.Atomic.AtomicBoolean>("shouldRun"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.html#thread()"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.Utils.KafkaThread Thread
        {
            get { return IExecute<Org.Apache.Kafka.Common.Utils.KafkaThread>("thread"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.html#accept(java.nio.channels.SocketChannel,boolean,com.yammer.metrics.core.Meter)"/>
        /// </summary>
        /// <param name="socketChannel"><see cref="Java.Nio.Channels.SocketChannel"/></param>
        /// <param name="mayBlock"><see cref="bool"/></param>
        /// <param name="acceptorIdlePercentMeter"><see cref="Com.Yammer.Metrics.Core.Meter"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Accept(Java.Nio.Channels.SocketChannel socketChannel, bool mayBlock, Com.Yammer.Metrics.Core.Meter acceptorIdlePercentMeter)
        {
            return IExecute<bool>("accept", socketChannel, mayBlock, acceptorIdlePercentMeter);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.html#newMeter(com.yammer.metrics.core.MetricName,java.lang.String,java.util.concurrent.TimeUnit)"/>
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
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.html#connectionId(java.net.Socket)"/>
        /// </summary>
        /// <param name="socket"><see cref="Java.Net.Socket"/></param>
        /// <returns><see cref="string"/></returns>
        public string ConnectionIdMethod(Java.Net.Socket socket)
        {
            return IExecute<string>("connectionId", socket);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.html#msgWithLogIdent(java.lang.String)"/>
        /// </summary>
        /// <param name="msg"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string MsgWithLogIdent(string msg)
        {
            return IExecute<string>("msgWithLogIdent", msg);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.html#createSelector(org.apache.kafka.common.network.ChannelBuilder)"/>
        /// </summary>
        /// <param name="channelBuilder"><see cref="Org.Apache.Kafka.Common.Network.ChannelBuilder"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Network.Selector"/></returns>
        public Org.Apache.Kafka.Common.Network.Selector CreateSelector(Org.Apache.Kafka.Common.Network.ChannelBuilder channelBuilder)
        {
            return IExecute<Org.Apache.Kafka.Common.Network.Selector>("createSelector", channelBuilder);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.html#parseRequestHeader(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="buffer"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Requests.RequestHeader"/></returns>
        public Org.Apache.Kafka.Common.Requests.RequestHeader ParseRequestHeader(Java.Nio.ByteBuffer buffer)
        {
            return IExecute<Org.Apache.Kafka.Common.Requests.RequestHeader>("parseRequestHeader", buffer);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.html#beginShutdown()"/>
        /// </summary>
        public void BeginShutdown()
        {
            IExecute("beginShutdown");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.html#enqueueResponse(kafka.network.RequestChannel.Response)"/>
        /// </summary>
        /// <param name="response"><see cref="Kafka.Network.RequestChannel.Response"/></param>
        public void EnqueueResponse(Kafka.Network.RequestChannel.Response response)
        {
            IExecute("enqueueResponse", response);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.html#processException(java.lang.String,java.lang.Throwable)"/>
        /// </summary>
        /// <param name="errorMessage"><see cref="string"/></param>
        /// <param name="throwable"><see cref="Java.Lang.Throwable"/></param>
        public void ProcessException(string errorMessage, Java.Lang.Throwable throwable)
        {
            IExecute("processException", errorMessage, throwable);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.html#run()"/>
        /// </summary>
        public void Run()
        {
            IExecute("run");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.html#sendResponse(kafka.network.RequestChannel.Response,org.apache.kafka.common.network.Send)"/>
        /// </summary>
        /// <param name="response"><see cref="Kafka.Network.RequestChannel.Response"/></param>
        /// <param name="responseSend"><see cref="Org.Apache.Kafka.Common.Network.Send"/></param>
        public void SendResponse(Kafka.Network.RequestChannel.Response response, Org.Apache.Kafka.Common.Network.Send responseSend)
        {
            IExecute("sendResponse", response, responseSend);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.html#start()"/>
        /// </summary>
        public void Start()
        {
            IExecute("start");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.html#wakeup()"/>
        /// </summary>
        public void Wakeup()
        {
            IExecute("wakeup");
        }

        #endregion

        #region Nested classes
        #region ConnectionId
        public partial class ConnectionId
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.ConnectionId.html#%3Cinit%3E(kafka.network.Processor,java.lang.String,int,java.lang.String,int,int)"/>
            /// </summary>
            /// <param name="$outer"><see cref="Kafka.Network.Processor"/></param>
            /// <param name="localHost"><see cref="string"/></param>
            /// <param name="localPort"><see cref="int"/></param>
            /// <param name="remoteHost"><see cref="string"/></param>
            /// <param name="remotePort"><see cref="int"/></param>
            /// <param name="index"><see cref="int"/></param>
            public ConnectionId(Kafka.Network.Processor _outer, string localHost, int localPort, string remoteHost, int remotePort, int index)
                : base(_outer, localHost, localPort, remoteHost, remotePort, index)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Kafka.Network.Processor.ConnectionId"/> to <see cref="Java.Io.Serializable"/>
            /// </summary>
            public static implicit operator Java.Io.Serializable(Kafka.Network.Processor.ConnectionId t) => t.Cast<Java.Io.Serializable>();

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.ConnectionId.html#$outer"/>
            /// </summary>
            public Kafka.Network.Processor $outer { get { return IGetField<Kafka.Network.Processor>("$outer"); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.ConnectionId.html#index()"/> 
            /// </summary>
            public int Index
            {
                get { return IExecute<int>("index"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.ConnectionId.html#localHost()"/> 
            /// </summary>
            public string LocalHost
            {
                get { return IExecute<string>("localHost"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.ConnectionId.html#localPort()"/> 
            /// </summary>
            public int LocalPort
            {
                get { return IExecute<int>("localPort"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.ConnectionId.html#productArity()"/> 
            /// </summary>
            public int ProductArity
            {
                get { return IExecute<int>("productArity"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.ConnectionId.html#productPrefix()"/> 
            /// </summary>
            public string ProductPrefix
            {
                get { return IExecute<string>("productPrefix"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.ConnectionId.html#remoteHost()"/> 
            /// </summary>
            public string RemoteHost
            {
                get { return IExecute<string>("remoteHost"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.ConnectionId.html#remotePort()"/> 
            /// </summary>
            public int RemotePort
            {
                get { return IExecute<int>("remotePort"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.ConnectionId.html#canEqual(java.lang.Object)"/>
            /// </summary>
            /// <param name="x$1"><see cref="object"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool CanEqual(object x_1)
            {
                return IExecute<bool>("canEqual", x_1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.ConnectionId.html#productElement(int)"/>
            /// </summary>
            /// <param name="x$1"><see cref="int"/></param>
            /// <returns><see cref="object"/></returns>
            public object ProductElement(int x_1)
            {
                return IExecute("productElement", x_1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.ConnectionId.html#productElementName(int)"/>
            /// </summary>
            /// <param name="x$1"><see cref="int"/></param>
            /// <returns><see cref="string"/></returns>
            public string ProductElementName(int x_1)
            {
                return IExecute<string>("productElementName", x_1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/Processor.ConnectionId.html#copy(java.lang.String,int,java.lang.String,int,int)"/>
            /// </summary>
            /// <param name="localHost"><see cref="string"/></param>
            /// <param name="localPort"><see cref="int"/></param>
            /// <param name="remoteHost"><see cref="string"/></param>
            /// <param name="remotePort"><see cref="int"/></param>
            /// <param name="index"><see cref="int"/></param>
            /// <returns><see cref="Kafka.Network.Processor.ConnectionId"/></returns>
            public Kafka.Network.Processor.ConnectionId Copy(string localHost, int localPort, string remoteHost, int remotePort, int index)
            {
                return IExecute<Kafka.Network.Processor.ConnectionId>("copy", localHost, localPort, remoteHost, remotePort, index);
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