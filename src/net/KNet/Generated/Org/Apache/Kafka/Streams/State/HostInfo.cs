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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using kafka-streams-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.State
{
    #region HostInfo
    public partial class HostInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/state/HostInfo.html#org.apache.kafka.streams.state.HostInfo(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public HostInfo(Java.Lang.String arg0, int arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/state/HostInfo.html#buildFromEndpoint-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.HostInfo"/></returns>
        public static Org.Apache.Kafka.Streams.State.HostInfo BuildFromEndpoint(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Streams.State.HostInfo>(LocalBridgeClazz, "buildFromEndpoint", "(Ljava/lang/String;)Lorg/apache/kafka/streams/state/HostInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/state/HostInfo.html#unavailable--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.HostInfo"/></returns>
        public static Org.Apache.Kafka.Streams.State.HostInfo Unavailable()
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Streams.State.HostInfo>(LocalBridgeClazz, "unavailable", "()Lorg/apache/kafka/streams/state/HostInfo;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/state/HostInfo.html#port--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Port()
        {
            return IExecuteWithSignature<int>("port", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/state/HostInfo.html#host--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Host()
        {
            return IExecuteWithSignature<Java.Lang.String>("host", "()Ljava/lang/String;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}