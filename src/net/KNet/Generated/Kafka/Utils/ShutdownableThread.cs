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
    #region ShutdownableThread
    public partial class ShutdownableThread
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/utils/ShutdownableThread.html#%3Cinit%3E(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="name"><see cref="string"/></param>
        /// <param name="isInterruptible"><see cref="bool"/></param>
        public ShutdownableThread(string name, bool isInterruptible)
            : base(name, isInterruptible)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Kafka.Utils.ShutdownableThread"/> to <see cref="Kafka.Utils.Logging"/>
        /// </summary>
        public static implicit operator Kafka.Utils.Logging(Kafka.Utils.ShutdownableThread t) => t.Cast<Kafka.Utils.Logging>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/utils/ShutdownableThread.html#initiateShutdown()"/> 
        /// </summary>
        public bool InitiateShutdown
        {
            get { return IExecute<bool>("initiateShutdown"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/utils/ShutdownableThread.html#isDebugEnabled()"/> 
        /// </summary>
        public bool IsDebugEnabled
        {
            get { return IExecute<bool>("isDebugEnabled"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/utils/ShutdownableThread.html#isInterruptible()"/> 
        /// </summary>
        public bool IsInterruptible
        {
            get { return IExecute<bool>("isInterruptible"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/utils/ShutdownableThread.html#isRunning()"/> 
        /// </summary>
        public bool IsRunning
        {
            get { return IExecute<bool>("isRunning"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/utils/ShutdownableThread.html#isShutdownComplete()"/> 
        /// </summary>
        public bool IsShutdownComplete
        {
            get { return IExecute<bool>("isShutdownComplete"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/utils/ShutdownableThread.html#isShutdownInitiated()"/> 
        /// </summary>
        public bool IsShutdownInitiated
        {
            get { return IExecute<bool>("isShutdownInitiated"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/utils/ShutdownableThread.html#isThreadFailed()"/> 
        /// </summary>
        public bool IsThreadFailed
        {
            get { return IExecute<bool>("isThreadFailed"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/utils/ShutdownableThread.html#isTraceEnabled()"/> 
        /// </summary>
        public bool IsTraceEnabled
        {
            get { return IExecute<bool>("isTraceEnabled"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/utils/ShutdownableThread.html#logger()"/> 
        /// </summary>
        public Com.Typesafe.Scalalogging.Logger Logger
        {
            get { return IExecute<Com.Typesafe.Scalalogging.Logger>("logger"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/utils/ShutdownableThread.html#loggerName()"/> 
        /// </summary>
        public string LoggerName
        {
            get { return IExecute<string>("loggerName"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/utils/ShutdownableThread.html#logIdent()"/> 
        /// </summary>
        public string LogIdent
        {
            get { return IExecute<string>("logIdent"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/utils/ShutdownableThread.html#name()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("name"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/utils/ShutdownableThread.html#doWork()"/>
        /// </summary>
        public void DoWork()
        {
            IExecute("doWork");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/utils/ShutdownableThread.html#msgWithLogIdent(java.lang.String)"/>
        /// </summary>
        /// <param name="msg"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string MsgWithLogIdent(string msg)
        {
            return IExecute<string>("msgWithLogIdent", msg);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/utils/ShutdownableThread.html#awaitShutdown()"/>
        /// </summary>
        public void AwaitShutdown()
        {
            IExecute("awaitShutdown");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/utils/ShutdownableThread.html#pause(long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="timeout"><see cref="long"/></param>
        /// <param name="unit"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        public void Pause(long timeout, Java.Util.Concurrent.TimeUnit unit)
        {
            IExecute("pause", timeout, unit);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/utils/ShutdownableThread.html#shutdown()"/>
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