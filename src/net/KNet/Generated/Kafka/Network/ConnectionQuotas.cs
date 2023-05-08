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
    #region ConnectionQuotas
    public partial class ConnectionQuotas
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/ConnectionQuotas.html#%3Cinit%3E(kafka.server.KafkaConfig,org.apache.kafka.common.utils.Time,org.apache.kafka.common.metrics.Metrics)"/>
        /// </summary>
        /// <param name="config"><see cref="Kafka.Server.KafkaConfig"/></param>
        /// <param name="time"><see cref="Org.Apache.Kafka.Common.Utils.Time"/></param>
        /// <param name="metrics"><see cref="Org.Apache.Kafka.Common.Metrics.Metrics"/></param>
        public ConnectionQuotas(Kafka.Server.KafkaConfig config, Org.Apache.Kafka.Common.Utils.Time time, Org.Apache.Kafka.Common.Metrics.Metrics metrics)
            : base(config, time, metrics)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Kafka.Network.ConnectionQuotas"/> to <see cref="Kafka.Utils.Logging"/>
        /// </summary>
        public static implicit operator Kafka.Utils.Logging(Kafka.Network.ConnectionQuotas t) => t.Cast<Kafka.Utils.Logging>();
        /// <summary>
        /// Converter from <see cref="Kafka.Network.ConnectionQuotas"/> to <see cref="Java.Lang.AutoCloseable"/>
        /// </summary>
        public static implicit operator Java.Lang.AutoCloseable(Kafka.Network.ConnectionQuotas t) => t.Cast<Java.Lang.AutoCloseable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/ConnectionQuotas.html#kafka$network$ConnectionQuotas$$metrics"/>
        /// </summary>
        public Org.Apache.Kafka.Common.Metrics.Metrics kafka$network$ConnectionQuotas$$metrics { get { return IGetField<Org.Apache.Kafka.Common.Metrics.Metrics>("kafka$network$ConnectionQuotas$$metrics"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/ConnectionQuotas.html#isDebugEnabled()"/> 
        /// </summary>
        public bool IsDebugEnabled
        {
            get { return IExecute<bool>("isDebugEnabled"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/ConnectionQuotas.html#isTraceEnabled()"/> 
        /// </summary>
        public bool IsTraceEnabled
        {
            get { return IExecute<bool>("isTraceEnabled"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/ConnectionQuotas.html#logger()"/> 
        /// </summary>
        public Com.Typesafe.Scalalogging.Logger Logger
        {
            get { return IExecute<Com.Typesafe.Scalalogging.Logger>("logger"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/ConnectionQuotas.html#loggerName()"/> 
        /// </summary>
        public string LoggerName
        {
            get { return IExecute<string>("loggerName"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/ConnectionQuotas.html#logIdent()"/> 
        /// </summary>
        public string LogIdent
        {
            get { return IExecute<string>("logIdent"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/ConnectionQuotas.html#maxConnectionsExceeded(org.apache.kafka.common.network.ListenerName)"/>
        /// </summary>
        /// <param name="listenerName"><see cref="Org.Apache.Kafka.Common.Network.ListenerName"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool MaxConnectionsExceeded(Org.Apache.Kafka.Common.Network.ListenerName listenerName)
        {
            return IExecute<bool>("maxConnectionsExceeded", listenerName);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/ConnectionQuotas.html#connectionRateForIp(java.net.InetAddress)"/>
        /// </summary>
        /// <param name="ip"><see cref="Java.Net.InetAddress"/></param>
        /// <returns><see cref="int"/></returns>
        public int ConnectionRateForIp(Java.Net.InetAddress ip)
        {
            return IExecute<int>("connectionRateForIp", ip);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/ConnectionQuotas.html#get(java.net.InetAddress)"/>
        /// </summary>
        /// <param name="address"><see cref="Java.Net.InetAddress"/></param>
        /// <returns><see cref="int"/></returns>
        public int Get(Java.Net.InetAddress address)
        {
            return IExecute<int>("get", address);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/ConnectionQuotas.html#msgWithLogIdent(java.lang.String)"/>
        /// </summary>
        /// <param name="msg"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string MsgWithLogIdent(string msg)
        {
            return IExecute<string>("msgWithLogIdent", msg);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/ConnectionQuotas.html#addListener(kafka.server.KafkaConfig,org.apache.kafka.common.network.ListenerName)"/>
        /// </summary>
        /// <param name="config"><see cref="Kafka.Server.KafkaConfig"/></param>
        /// <param name="listenerName"><see cref="Org.Apache.Kafka.Common.Network.ListenerName"/></param>
        public void AddListener(Kafka.Server.KafkaConfig config, Org.Apache.Kafka.Common.Network.ListenerName listenerName)
        {
            IExecute("addListener", config, listenerName);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/ConnectionQuotas.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/ConnectionQuotas.html#closeChannel(kafka.utils.Logging,org.apache.kafka.common.network.ListenerName,java.nio.channels.SocketChannel)"/>
        /// </summary>
        /// <param name="log"><see cref="Kafka.Utils.Logging"/></param>
        /// <param name="listenerName"><see cref="Org.Apache.Kafka.Common.Network.ListenerName"/></param>
        /// <param name="channel"><see cref="Java.Nio.Channels.SocketChannel"/></param>
        public void CloseChannel(Kafka.Utils.Logging log, Org.Apache.Kafka.Common.Network.ListenerName listenerName, Java.Nio.Channels.SocketChannel channel)
        {
            IExecute("closeChannel", log, listenerName, channel);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/ConnectionQuotas.html#dec(org.apache.kafka.common.network.ListenerName,java.net.InetAddress)"/>
        /// </summary>
        /// <param name="listenerName"><see cref="Org.Apache.Kafka.Common.Network.ListenerName"/></param>
        /// <param name="address"><see cref="Java.Net.InetAddress"/></param>
        public void Dec(Org.Apache.Kafka.Common.Network.ListenerName listenerName, Java.Net.InetAddress address)
        {
            IExecute("dec", listenerName, address);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/ConnectionQuotas.html#inc(org.apache.kafka.common.network.ListenerName,java.net.InetAddress,com.yammer.metrics.core.Meter)"/>
        /// </summary>
        /// <param name="listenerName"><see cref="Org.Apache.Kafka.Common.Network.ListenerName"/></param>
        /// <param name="address"><see cref="Java.Net.InetAddress"/></param>
        /// <param name="acceptorBlockedPercentMeter"><see cref="Com.Yammer.Metrics.Core.Meter"/></param>
        public void Inc(Org.Apache.Kafka.Common.Network.ListenerName listenerName, Java.Net.InetAddress address, Com.Yammer.Metrics.Core.Meter acceptorBlockedPercentMeter)
        {
            IExecute("inc", listenerName, address, acceptorBlockedPercentMeter);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/ConnectionQuotas.html#removeListener(kafka.server.KafkaConfig,org.apache.kafka.common.network.ListenerName)"/>
        /// </summary>
        /// <param name="config"><see cref="Kafka.Server.KafkaConfig"/></param>
        /// <param name="listenerName"><see cref="Org.Apache.Kafka.Common.Network.ListenerName"/></param>
        public void RemoveListener(Kafka.Server.KafkaConfig config, Org.Apache.Kafka.Common.Network.ListenerName listenerName)
        {
            IExecute("removeListener", config, listenerName);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/ConnectionQuotas.html#updateBrokerMaxConnectionRate(int)"/>
        /// </summary>
        /// <param name="maxConnectionRate"><see cref="int"/></param>
        public void UpdateBrokerMaxConnectionRate(int maxConnectionRate)
        {
            IExecute("updateBrokerMaxConnectionRate", maxConnectionRate);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/ConnectionQuotas.html#updateBrokerMaxConnections(int)"/>
        /// </summary>
        /// <param name="maxConnections"><see cref="int"/></param>
        public void UpdateBrokerMaxConnections(int maxConnections)
        {
            IExecute("updateBrokerMaxConnections", maxConnections);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/ConnectionQuotas.html#updateMaxConnectionsPerIp(int)"/>
        /// </summary>
        /// <param name="maxConnectionsPerIp"><see cref="int"/></param>
        public void UpdateMaxConnectionsPerIp(int maxConnectionsPerIp)
        {
            IExecute("updateMaxConnectionsPerIp", maxConnectionsPerIp);
        }

        #endregion

        #region Nested classes
        #region ListenerConnectionQuota
        public partial class ListenerConnectionQuota
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/ConnectionQuotas.ListenerConnectionQuota.html#%3Cinit%3E(kafka.network.ConnectionQuotas,java.lang.Object,org.apache.kafka.common.network.ListenerName)"/>
            /// </summary>
            /// <param name="$outer"><see cref="Kafka.Network.ConnectionQuotas"/></param>
            /// <param name="lock"><see cref="object"/></param>
            /// <param name="listener"><see cref="Org.Apache.Kafka.Common.Network.ListenerName"/></param>
            public ListenerConnectionQuota(Kafka.Network.ConnectionQuotas _outer, object lock, Org.Apache.Kafka.Common.Network.ListenerName listener)
                : base(_outer, lock, listener)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Kafka.Network.ConnectionQuotas.ListenerConnectionQuota"/> to <see cref="Org.Apache.Kafka.Common.Network.ListenerReconfigurable"/>
            /// </summary>
            public static implicit operator Org.Apache.Kafka.Common.Network.ListenerReconfigurable(Kafka.Network.ConnectionQuotas.ListenerConnectionQuota t) => t.Cast<Org.Apache.Kafka.Common.Network.ListenerReconfigurable>();
            /// <summary>
            /// Converter from <see cref="Kafka.Network.ConnectionQuotas.ListenerConnectionQuota"/> to <see cref="Java.Lang.AutoCloseable"/>
            /// </summary>
            public static implicit operator Java.Lang.AutoCloseable(Kafka.Network.ConnectionQuotas.ListenerConnectionQuota t) => t.Cast<Java.Lang.AutoCloseable>();

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/ConnectionQuotas.ListenerConnectionQuota.html#$outer"/>
            /// </summary>
            public Kafka.Network.ConnectionQuotas $outer { get { return IGetField<Kafka.Network.ConnectionQuotas>("$outer"); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/ConnectionQuotas.ListenerConnectionQuota.html#connectionRateSensor()"/> 
            /// </summary>
            public Org.Apache.Kafka.Common.Metrics.Sensor ConnectionRateSensor
            {
                get { return IExecute<Org.Apache.Kafka.Common.Metrics.Sensor>("connectionRateSensor"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/ConnectionQuotas.ListenerConnectionQuota.html#ipConnectionRateThrottleSensor()"/> 
            /// </summary>
            public Org.Apache.Kafka.Common.Metrics.Sensor IpConnectionRateThrottleSensor
            {
                get { return IExecute<Org.Apache.Kafka.Common.Metrics.Sensor>("ipConnectionRateThrottleSensor"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/ConnectionQuotas.ListenerConnectionQuota.html#listenerConnectionRateThrottleSensor()"/> 
            /// </summary>
            public Org.Apache.Kafka.Common.Metrics.Sensor ListenerConnectionRateThrottleSensor
            {
                get { return IExecute<Org.Apache.Kafka.Common.Metrics.Sensor>("listenerConnectionRateThrottleSensor"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/ConnectionQuotas.ListenerConnectionQuota.html#listenerName()"/> 
            /// </summary>
            public Org.Apache.Kafka.Common.Network.ListenerName ListenerName
            {
                get { return IExecute<Org.Apache.Kafka.Common.Network.ListenerName>("listenerName"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/ConnectionQuotas.ListenerConnectionQuota.html#maxConnections()"/> 
            /// </summary>
            public int MaxConnections
            {
                get { return IExecute<int>("maxConnections"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/ConnectionQuotas.ListenerConnectionQuota.html#reconfigurableConfigs()"/> 
            /// </summary>
            public Java.Util.Set<string> ReconfigurableConfigs
            {
                get { return IExecute<Java.Util.Set<string>>("reconfigurableConfigs"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/ConnectionQuotas.ListenerConnectionQuota.html#close()"/>
            /// </summary>
            public void Close()
            {
                IExecute("close");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/ConnectionQuotas.ListenerConnectionQuota.html#configure(java.util.Map)"/>
            /// </summary>
            /// <param name="configs"><see cref="Java.Util.Map"/></param>
            /// <typeparam name="ConfigsExtendsobject"></typeparam>
            public void Configure<ConfigsExtendsobject>(Java.Util.Map<string, ConfigsExtendsobject> configs)
            {
                IExecute("configure", configs);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/ConnectionQuotas.ListenerConnectionQuota.html#reconfigure(java.util.Map)"/>
            /// </summary>
            /// <param name="configs"><see cref="Java.Util.Map"/></param>
            /// <typeparam name="ConfigsExtendsobject"></typeparam>
            public void Reconfigure<ConfigsExtendsobject>(Java.Util.Map<string, ConfigsExtendsobject> configs)
            {
                IExecute("reconfigure", configs);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/network/ConnectionQuotas.ListenerConnectionQuota.html#validateReconfiguration(java.util.Map)"/>
            /// </summary>
            /// <param name="configs"><see cref="Java.Util.Map"/></param>
            /// <typeparam name="ConfigsExtendsobject"></typeparam>
            public void ValidateReconfiguration<ConfigsExtendsobject>(Java.Util.Map<string, ConfigsExtendsobject> configs)
            {
                IExecute("validateReconfiguration", configs);
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