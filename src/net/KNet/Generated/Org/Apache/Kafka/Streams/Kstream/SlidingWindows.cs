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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using kafka-streams-3.5.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Kstream
{
    #region SlidingWindows
    public partial class SlidingWindows
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/kstream/SlidingWindows.html#ofTimeDifferenceAndGrace-java.time.Duration-java.time.Duration-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Duration"/></param>
        /// <param name="arg1"><see cref="Java.Time.Duration"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.SlidingWindows"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public static Org.Apache.Kafka.Streams.Kstream.SlidingWindows OfTimeDifferenceAndGrace(Java.Time.Duration arg0, Java.Time.Duration arg1)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.SlidingWindows>(LocalBridgeClazz, "ofTimeDifferenceAndGrace", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/kstream/SlidingWindows.html#ofTimeDifferenceWithNoGrace-java.time.Duration-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Duration"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.SlidingWindows"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public static Org.Apache.Kafka.Streams.Kstream.SlidingWindows OfTimeDifferenceWithNoGrace(Java.Time.Duration arg0)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.SlidingWindows>(LocalBridgeClazz, "ofTimeDifferenceWithNoGrace", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/kstream/SlidingWindows.html#gracePeriodMs--"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long GracePeriodMs()
        {
            return IExecute<long>("gracePeriodMs");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/kstream/SlidingWindows.html#timeDifferenceMs--"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long TimeDifferenceMs()
        {
            return IExecute<long>("timeDifferenceMs");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}