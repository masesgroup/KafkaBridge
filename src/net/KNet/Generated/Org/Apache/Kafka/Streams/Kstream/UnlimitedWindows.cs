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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using kafka-streams-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Kstream
{
    #region UnlimitedWindows
    public partial class UnlimitedWindows
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/UnlimitedWindows.html#startMs"/>
        /// </summary>
        public long startMs { get { if (!_startMsReady) { _startMsContent = IGetField<long>("startMs"); _startMsReady = true; } return _startMsContent; } }
        private long _startMsContent = default;
        private bool _startMsReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/UnlimitedWindows.html#of--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.UnlimitedWindows"/></returns>
        public static Org.Apache.Kafka.Streams.Kstream.UnlimitedWindows Of()
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.UnlimitedWindows>(LocalBridgeClazz, "of", "()Lorg/apache/kafka/streams/kstream/UnlimitedWindows;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/UnlimitedWindows.html#startOn-java.time.Instant-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Kstream.UnlimitedWindows"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public Org.Apache.Kafka.Streams.Kstream.UnlimitedWindows StartOn(Java.Time.Instant arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Kstream.UnlimitedWindows>("startOn", "(Ljava/time/Instant;)Lorg/apache/kafka/streams/kstream/UnlimitedWindows;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}