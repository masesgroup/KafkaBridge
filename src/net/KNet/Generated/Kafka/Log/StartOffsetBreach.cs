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
    #region StartOffsetBreach
    public partial class StartOffsetBreach
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/StartOffsetBreach.html#%3Cinit%3E(kafka.log.UnifiedLog)"/>
        /// </summary>
        /// <param name="log"><see cref="Kafka.Log.UnifiedLog"/></param>
        public StartOffsetBreach(Kafka.Log.UnifiedLog log)
            : base(log)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Kafka.Log.StartOffsetBreach"/> to <see cref="Kafka.Log.SegmentDeletionReason"/>
        /// </summary>
        public static implicit operator Kafka.Log.SegmentDeletionReason(Kafka.Log.StartOffsetBreach t) => t.Cast<Kafka.Log.SegmentDeletionReason>();
        /// <summary>
        /// Converter from <see cref="Kafka.Log.StartOffsetBreach"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Kafka.Log.StartOffsetBreach t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/StartOffsetBreach.html#apply(kafka.log.UnifiedLog)"/>
        /// </summary>
        /// <param name="log"><see cref="Kafka.Log.UnifiedLog"/></param>
        /// <returns><see cref="Kafka.Log.StartOffsetBreach"/></returns>
        public static Kafka.Log.StartOffsetBreach Apply(Kafka.Log.UnifiedLog log)
        {
            return SExecute<Kafka.Log.StartOffsetBreach>(LocalBridgeClazz, "apply", log);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/StartOffsetBreach.html#log()"/> 
        /// </summary>
        public Kafka.Log.UnifiedLog Log
        {
            get { return IExecute<Kafka.Log.UnifiedLog>("log"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/StartOffsetBreach.html#productArity()"/> 
        /// </summary>
        public int ProductArity
        {
            get { return IExecute<int>("productArity"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/StartOffsetBreach.html#productPrefix()"/> 
        /// </summary>
        public string ProductPrefix
        {
            get { return IExecute<string>("productPrefix"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/StartOffsetBreach.html#canEqual(java.lang.Object)"/>
        /// </summary>
        /// <param name="x$1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CanEqual(object x_1)
        {
            return IExecute<bool>("canEqual", x_1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/StartOffsetBreach.html#productElement(int)"/>
        /// </summary>
        /// <param name="x$1"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object ProductElement(int x_1)
        {
            return IExecute("productElement", x_1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/StartOffsetBreach.html#productElementName(int)"/>
        /// </summary>
        /// <param name="x$1"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string ProductElementName(int x_1)
        {
            return IExecute<string>("productElementName", x_1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/StartOffsetBreach.html#copy(kafka.log.UnifiedLog)"/>
        /// </summary>
        /// <param name="log"><see cref="Kafka.Log.UnifiedLog"/></param>
        /// <returns><see cref="Kafka.Log.StartOffsetBreach"/></returns>
        public Kafka.Log.StartOffsetBreach Copy(Kafka.Log.UnifiedLog log)
        {
            return IExecute<Kafka.Log.StartOffsetBreach>("copy", log);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}