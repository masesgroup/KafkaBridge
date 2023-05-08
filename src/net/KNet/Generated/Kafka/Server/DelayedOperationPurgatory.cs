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

namespace Kafka.Server
{
    #region DelayedOperationPurgatory
    public partial class DelayedOperationPurgatory
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DelayedOperationPurgatory.html#%3Cinit%3E(java.lang.String,kafka.utils.timer.Timer,int,int,boolean,boolean)"/>
        /// </summary>
        /// <param name="purgatoryName"><see cref="string"/></param>
        /// <param name="timeoutTimer"><see cref="Kafka.Utils.Timer.Timer"/></param>
        /// <param name="brokerId"><see cref="int"/></param>
        /// <param name="purgeInterval"><see cref="int"/></param>
        /// <param name="reaperEnabled"><see cref="bool"/></param>
        /// <param name="timerEnabled"><see cref="bool"/></param>
        public DelayedOperationPurgatory(string purgatoryName, Kafka.Utils.Timer.Timer timeoutTimer, int brokerId, int purgeInterval, bool reaperEnabled, bool timerEnabled)
            : base(purgatoryName, timeoutTimer, brokerId, purgeInterval, reaperEnabled, timerEnabled)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Kafka.Server.DelayedOperationPurgatory"/> to <see cref="Kafka.Metrics.KafkaMetricsGroup"/>
        /// </summary>
        public static implicit operator Kafka.Metrics.KafkaMetricsGroup(Kafka.Server.DelayedOperationPurgatory t) => t.Cast<Kafka.Metrics.KafkaMetricsGroup>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DelayedOperationPurgatory.html#kafka$server$DelayedOperationPurgatory$$brokerId"/>
        /// </summary>
        public int kafka$server$DelayedOperationPurgatory$$brokerId { get { return IGetField<int>("kafka$server$DelayedOperationPurgatory$$brokerId"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DelayedOperationPurgatory.html#kafka$server$DelayedOperationPurgatory$$purgatoryName"/>
        /// </summary>
        public string kafka$server$DelayedOperationPurgatory$$purgatoryName { get { return IGetField<string>("kafka$server$DelayedOperationPurgatory$$purgatoryName"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DelayedOperationPurgatory.html#apply(java.lang.String,int,int,boolean,boolean)"/>
        /// </summary>
        /// <param name="purgatoryName"><see cref="string"/></param>
        /// <param name="brokerId"><see cref="int"/></param>
        /// <param name="purgeInterval"><see cref="int"/></param>
        /// <param name="reaperEnabled"><see cref="bool"/></param>
        /// <param name="timerEnabled"><see cref="bool"/></param>
        /// <returns><see cref="Kafka.Server.DelayedOperationPurgatory"/></returns>
        public static Kafka.Server.DelayedOperationPurgatory Apply(string purgatoryName, int brokerId, int purgeInterval, bool reaperEnabled, bool timerEnabled)
        {
            return SExecute<Kafka.Server.DelayedOperationPurgatory>(LocalBridgeClazz, "apply", purgatoryName, brokerId, purgeInterval, reaperEnabled, timerEnabled);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DelayedOperationPurgatory.html#isDebugEnabled()"/> 
        /// </summary>
        public bool IsDebugEnabled
        {
            get { return IExecute<bool>("isDebugEnabled"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DelayedOperationPurgatory.html#isTraceEnabled()"/> 
        /// </summary>
        public bool IsTraceEnabled
        {
            get { return IExecute<bool>("isTraceEnabled"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DelayedOperationPurgatory.html#logger()"/> 
        /// </summary>
        public Com.Typesafe.Scalalogging.Logger Logger
        {
            get { return IExecute<Com.Typesafe.Scalalogging.Logger>("logger"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DelayedOperationPurgatory.html#loggerName()"/> 
        /// </summary>
        public string LoggerName
        {
            get { return IExecute<string>("loggerName"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DelayedOperationPurgatory.html#logIdent()"/> 
        /// </summary>
        public string LogIdent
        {
            get { return IExecute<string>("logIdent"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DelayedOperationPurgatory.html#numDelayed()"/> 
        /// </summary>
        public int NumDelayed
        {
            get { return IExecute<int>("numDelayed"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DelayedOperationPurgatory.html#watched()"/> 
        /// </summary>
        public int Watched
        {
            get { return IExecute<int>("watched"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DelayedOperationPurgatory.html#newMeter(com.yammer.metrics.core.MetricName,java.lang.String,java.util.concurrent.TimeUnit)"/>
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
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DelayedOperationPurgatory.html#checkAndComplete(java.lang.Object)"/>
        /// </summary>
        /// <param name="key"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CheckAndComplete(object key)
        {
            return IExecute<int>("checkAndComplete", key);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DelayedOperationPurgatory.html#msgWithLogIdent(java.lang.String)"/>
        /// </summary>
        /// <param name="msg"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string MsgWithLogIdent(string msg)
        {
            return IExecute<string>("msgWithLogIdent", msg);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DelayedOperationPurgatory.html#advanceClock(long)"/>
        /// </summary>
        /// <param name="timeoutMs"><see cref="long"/></param>
        public void AdvanceClock(long timeoutMs)
        {
            IExecute("advanceClock", timeoutMs);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DelayedOperationPurgatory.html#shutdown()"/>
        /// </summary>
        public void Shutdown()
        {
            IExecute("shutdown");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DelayedOperationPurgatory<T>
    public partial class DelayedOperationPurgatory<T>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DelayedOperationPurgatory.html#%3Cinit%3E(java.lang.String,kafka.utils.timer.Timer,int,int,boolean,boolean)"/>
        /// </summary>
        /// <param name="purgatoryName"><see cref="string"/></param>
        /// <param name="timeoutTimer"><see cref="Kafka.Utils.Timer.Timer"/></param>
        /// <param name="brokerId"><see cref="int"/></param>
        /// <param name="purgeInterval"><see cref="int"/></param>
        /// <param name="reaperEnabled"><see cref="bool"/></param>
        /// <param name="timerEnabled"><see cref="bool"/></param>
        public DelayedOperationPurgatory(string purgatoryName, Kafka.Utils.Timer.Timer timeoutTimer, int brokerId, int purgeInterval, bool reaperEnabled, bool timerEnabled)
            : base(purgatoryName, timeoutTimer, brokerId, purgeInterval, reaperEnabled, timerEnabled)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Kafka.Server.DelayedOperationPurgatory{T}"/> to <see cref="Kafka.Metrics.KafkaMetricsGroup"/>
        /// </summary>
        public static implicit operator Kafka.Metrics.KafkaMetricsGroup(Kafka.Server.DelayedOperationPurgatory<T> t) => t.Cast<Kafka.Metrics.KafkaMetricsGroup>();
        /// <summary>
        /// Converter from <see cref="Kafka.Server.DelayedOperationPurgatory{T}"/> to <see cref="Kafka.Server.DelayedOperationPurgatory"/>
        /// </summary>
        public static implicit operator Kafka.Server.DelayedOperationPurgatory(Kafka.Server.DelayedOperationPurgatory<T> t) => t.Cast<Kafka.Server.DelayedOperationPurgatory>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DelayedOperationPurgatory.html#kafka$server$DelayedOperationPurgatory$$brokerId"/>
        /// </summary>
        public int kafka$server$DelayedOperationPurgatory$$brokerId { get { return IGetField<int>("kafka$server$DelayedOperationPurgatory$$brokerId"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DelayedOperationPurgatory.html#kafka$server$DelayedOperationPurgatory$$purgatoryName"/>
        /// </summary>
        public string kafka$server$DelayedOperationPurgatory$$purgatoryName { get { return IGetField<string>("kafka$server$DelayedOperationPurgatory$$purgatoryName"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DelayedOperationPurgatory.html#apply(java.lang.String,int,int,boolean,boolean)"/>
        /// </summary>
        /// <param name="purgatoryName"><see cref="string"/></param>
        /// <param name="brokerId"><see cref="int"/></param>
        /// <param name="purgeInterval"><see cref="int"/></param>
        /// <param name="reaperEnabled"><see cref="bool"/></param>
        /// <param name="timerEnabled"><see cref="bool"/></param>
        /// <returns><see cref="Kafka.Server.DelayedOperationPurgatory"/></returns>
        public static Kafka.Server.DelayedOperationPurgatory<T> Apply(string purgatoryName, int brokerId, int purgeInterval, bool reaperEnabled, bool timerEnabled)
        {
            return SExecute<Kafka.Server.DelayedOperationPurgatory<T>>(LocalBridgeClazz, "apply", purgatoryName, brokerId, purgeInterval, reaperEnabled, timerEnabled);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DelayedOperationPurgatory.html#isDebugEnabled()"/> 
        /// </summary>
        public bool IsDebugEnabled
        {
            get { return IExecute<bool>("isDebugEnabled"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DelayedOperationPurgatory.html#isTraceEnabled()"/> 
        /// </summary>
        public bool IsTraceEnabled
        {
            get { return IExecute<bool>("isTraceEnabled"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DelayedOperationPurgatory.html#logger()"/> 
        /// </summary>
        public Com.Typesafe.Scalalogging.Logger Logger
        {
            get { return IExecute<Com.Typesafe.Scalalogging.Logger>("logger"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DelayedOperationPurgatory.html#loggerName()"/> 
        /// </summary>
        public string LoggerName
        {
            get { return IExecute<string>("loggerName"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DelayedOperationPurgatory.html#logIdent()"/> 
        /// </summary>
        public string LogIdent
        {
            get { return IExecute<string>("logIdent"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DelayedOperationPurgatory.html#numDelayed()"/> 
        /// </summary>
        public int NumDelayed
        {
            get { return IExecute<int>("numDelayed"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DelayedOperationPurgatory.html#watched()"/> 
        /// </summary>
        public int Watched
        {
            get { return IExecute<int>("watched"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DelayedOperationPurgatory.html#newMeter(com.yammer.metrics.core.MetricName,java.lang.String,java.util.concurrent.TimeUnit)"/>
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
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DelayedOperationPurgatory.html#checkAndComplete(java.lang.Object)"/>
        /// </summary>
        /// <param name="key"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CheckAndComplete(object key)
        {
            return IExecute<int>("checkAndComplete", key);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DelayedOperationPurgatory.html#msgWithLogIdent(java.lang.String)"/>
        /// </summary>
        /// <param name="msg"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string MsgWithLogIdent(string msg)
        {
            return IExecute<string>("msgWithLogIdent", msg);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DelayedOperationPurgatory.html#advanceClock(long)"/>
        /// </summary>
        /// <param name="timeoutMs"><see cref="long"/></param>
        public void AdvanceClock(long timeoutMs)
        {
            IExecute("advanceClock", timeoutMs);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/DelayedOperationPurgatory.html#shutdown()"/>
        /// </summary>
        public void Shutdown()
        {
            IExecute("shutdown");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}