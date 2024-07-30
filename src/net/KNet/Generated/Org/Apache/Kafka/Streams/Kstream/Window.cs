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
    #region Window
    public partial class Window
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/Window.html#org.apache.kafka.streams.kstream.Window(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public Window(long arg0, long arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/Window.html#overlap-org.apache.kafka.streams.kstream.Window-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Kstream.Window"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Overlap(Org.Apache.Kafka.Streams.Kstream.Window arg0)
        {
            return IExecuteWithSignature<bool>("overlap", "(Lorg/apache/kafka/streams/kstream/Window;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/Window.html#endTime--"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Instant"/></returns>
        public Java.Time.Instant EndTime()
        {
            return IExecuteWithSignature<Java.Time.Instant>("endTime", "()Ljava/time/Instant;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/Window.html#startTime--"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Instant"/></returns>
        public Java.Time.Instant StartTime()
        {
            return IExecuteWithSignature<Java.Time.Instant>("startTime", "()Ljava/time/Instant;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/Window.html#end--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long End()
        {
            return IExecuteWithSignature<long>("end", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/kstream/Window.html#start--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long Start()
        {
            return IExecuteWithSignature<long>("start", "()J");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}