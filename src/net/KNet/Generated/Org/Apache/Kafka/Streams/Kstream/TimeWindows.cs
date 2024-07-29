/*
*  Copyright 2024 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using kafka-streams-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Kstream
{
    #region TimeWindows
    public partial class TimeWindows
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/TimeWindows.html#advanceMs"/>
        /// </summary>
        public long advanceMs { get { if (!_advanceMsReady) { _advanceMsContent = IGetField<long>("advanceMs"); _advanceMsReady = true; } return _advanceMsContent; } }
        private long _advanceMsContent = default;
        private bool _advanceMsReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/TimeWindows.html#sizeMs"/>
        /// </summary>
        public long sizeMs { get { if (!_sizeMsReady) { _sizeMsContent = IGetField<long>("sizeMs"); _sizeMsReady = true; } return _sizeMsContent; } }
        private long _sizeMsContent = default;
        private bool _sizeMsReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/TimeWindows.html#ofSizeAndGrace-java.time.Duration-java.time.Duration-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Duration"/></param>
        /// <param name="arg1"><see cref="Java.Time.Duration"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.TimeWindows"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public static Org.Apache.Kafka.Streams.Kstream.TimeWindows OfSizeAndGrace(Java.Time.Duration arg0, Java.Time.Duration arg1)
        {
            return SExecute<Org.Apache.Kafka.Streams.Kstream.TimeWindows>(LocalBridgeClazz, "ofSizeAndGrace", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/TimeWindows.html#ofSizeWithNoGrace-java.time.Duration-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Duration"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.TimeWindows"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public static Org.Apache.Kafka.Streams.Kstream.TimeWindows OfSizeWithNoGrace(Java.Time.Duration arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.TimeWindows>(LocalBridgeClazz, "ofSizeWithNoGrace", "(Ljava/time/Duration;)Lorg/apache/kafka/streams/kstream/TimeWindows;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/TimeWindows.html#advanceBy-java.time.Duration-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Duration"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.TimeWindows"/></returns>
        public Org.Apache.Kafka.Streams.Kstream.TimeWindows AdvanceBy(Java.Time.Duration arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.TimeWindows>("advanceBy", "(Ljava/time/Duration;)Lorg/apache/kafka/streams/kstream/TimeWindows;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}