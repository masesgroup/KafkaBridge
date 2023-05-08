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

namespace Kafka.Controller
{
    #region ControllerBrokerStateInfo
    public partial class ControllerBrokerStateInfo
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Kafka.Controller.ControllerBrokerStateInfo"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Kafka.Controller.ControllerBrokerStateInfo t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/controller/ControllerBrokerStateInfo.html#brokerNode()"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.Node BrokerNode
        {
            get { return IExecute<Org.Apache.Kafka.Common.Node>("brokerNode"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/controller/ControllerBrokerStateInfo.html#messageQueue()"/> 
        /// </summary>
        public Java.Util.Concurrent.BlockingQueue<Kafka.Controller.QueueItem> MessageQueue
        {
            get { return IExecute<Java.Util.Concurrent.BlockingQueue<Kafka.Controller.QueueItem>>("messageQueue"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/controller/ControllerBrokerStateInfo.html#networkClient()"/> 
        /// </summary>
        public Org.Apache.Kafka.Clients.NetworkClient NetworkClient
        {
            get { return IExecute<Org.Apache.Kafka.Clients.NetworkClient>("networkClient"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/controller/ControllerBrokerStateInfo.html#productArity()"/> 
        /// </summary>
        public int ProductArity
        {
            get { return IExecute<int>("productArity"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/controller/ControllerBrokerStateInfo.html#productPrefix()"/> 
        /// </summary>
        public string ProductPrefix
        {
            get { return IExecute<string>("productPrefix"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/controller/ControllerBrokerStateInfo.html#queueSizeGauge()"/> 
        /// </summary>
        public Com.Yammer.Metrics.Core.Gauge<object> QueueSizeGauge
        {
            get { return IExecute<Com.Yammer.Metrics.Core.Gauge<object>>("queueSizeGauge"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/controller/ControllerBrokerStateInfo.html#requestRateAndTimeMetrics()"/> 
        /// </summary>
        public Com.Yammer.Metrics.Core.Timer RequestRateAndTimeMetrics
        {
            get { return IExecute<Com.Yammer.Metrics.Core.Timer>("requestRateAndTimeMetrics"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/controller/ControllerBrokerStateInfo.html#requestSendThread()"/> 
        /// </summary>
        public Kafka.Controller.RequestSendThread RequestSendThread
        {
            get { return IExecute<Kafka.Controller.RequestSendThread>("requestSendThread"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/controller/ControllerBrokerStateInfo.html#canEqual(java.lang.Object)"/>
        /// </summary>
        /// <param name="x$1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CanEqual(object x_1)
        {
            return IExecute<bool>("canEqual", x_1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/controller/ControllerBrokerStateInfo.html#productElement(int)"/>
        /// </summary>
        /// <param name="x$1"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object ProductElement(int x_1)
        {
            return IExecute("productElement", x_1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/controller/ControllerBrokerStateInfo.html#productElementName(int)"/>
        /// </summary>
        /// <param name="x$1"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string ProductElementName(int x_1)
        {
            return IExecute<string>("productElementName", x_1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}