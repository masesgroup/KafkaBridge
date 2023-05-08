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

namespace Kafka.Utils
{
    #region DelayedItem
    public partial class DelayedItem
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/utils/DelayedItem.html#%3Cinit%3E(long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="delay"><see cref="long"/></param>
        /// <param name="unit"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        public DelayedItem(long delay, Java.Util.Concurrent.TimeUnit unit)
            : base(delay, unit)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/utils/DelayedItem.html#%3Cinit%3E(long)"/>
        /// </summary>
        /// <param name="delayMs"><see cref="long"/></param>
        public DelayedItem(long delayMs)
            : base(delayMs)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Kafka.Utils.DelayedItem"/> to <see cref="Java.Util.Concurrent.Delayed"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.Delayed(Kafka.Utils.DelayedItem t) => t.Cast<Java.Util.Concurrent.Delayed>();
        /// <summary>
        /// Converter from <see cref="Kafka.Utils.DelayedItem"/> to <see cref="Kafka.Utils.Logging"/>
        /// </summary>
        public static implicit operator Kafka.Utils.Logging(Kafka.Utils.DelayedItem t) => t.Cast<Kafka.Utils.Logging>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/utils/DelayedItem.html#delayMs()"/> 
        /// </summary>
        public long DelayMs
        {
            get { return IExecute<long>("delayMs"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/utils/DelayedItem.html#isDebugEnabled()"/> 
        /// </summary>
        public bool IsDebugEnabled
        {
            get { return IExecute<bool>("isDebugEnabled"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/utils/DelayedItem.html#isTraceEnabled()"/> 
        /// </summary>
        public bool IsTraceEnabled
        {
            get { return IExecute<bool>("isTraceEnabled"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/utils/DelayedItem.html#logger()"/> 
        /// </summary>
        public Com.Typesafe.Scalalogging.Logger Logger
        {
            get { return IExecute<Com.Typesafe.Scalalogging.Logger>("logger"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/utils/DelayedItem.html#loggerName()"/> 
        /// </summary>
        public string LoggerName
        {
            get { return IExecute<string>("loggerName"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/utils/DelayedItem.html#logIdent()"/> 
        /// </summary>
        public string LogIdent
        {
            get { return IExecute<string>("logIdent"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/utils/DelayedItem.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="x$1"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object x_1)
        {
            return IExecute<int>("compareTo", x_1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/utils/DelayedItem.html#compareTo(java.util.concurrent.Delayed)"/>
        /// </summary>
        /// <param name="d"><see cref="Java.Util.Concurrent.Delayed"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Util.Concurrent.Delayed d)
        {
            return IExecute<int>("compareTo", d);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/utils/DelayedItem.html#msgWithLogIdent(java.lang.String)"/>
        /// </summary>
        /// <param name="msg"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string MsgWithLogIdent(string msg)
        {
            return IExecute<string>("msgWithLogIdent", msg);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/utils/DelayedItem.html#getDelay(java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="unit"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetDelay(Java.Util.Concurrent.TimeUnit unit)
        {
            return IExecute<long>("getDelay", unit);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}