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
*  using kafka-streams-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Query
{
    #region PositionBound
    public partial class PositionBound
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/query/PositionBound.html#at-org.apache.kafka.streams.query.Position-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Query.Position"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.PositionBound"/></returns>
        public static Org.Apache.Kafka.Streams.Query.PositionBound At(Org.Apache.Kafka.Streams.Query.Position arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Streams.Query.PositionBound>(LocalBridgeClazz, "at", "(Lorg/apache/kafka/streams/query/Position;)Lorg/apache/kafka/streams/query/PositionBound;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/query/PositionBound.html#unbounded--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.PositionBound"/></returns>
        public static Org.Apache.Kafka.Streams.Query.PositionBound Unbounded()
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Streams.Query.PositionBound>(LocalBridgeClazz, "unbounded", "()Lorg/apache/kafka/streams/query/PositionBound;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/query/PositionBound.html#isUnbounded--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsUnbounded()
        {
            return IExecuteWithSignature<bool>("isUnbounded", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/query/PositionBound.html#position--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.Position"/></returns>
        public Org.Apache.Kafka.Streams.Query.Position Position()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.Position>("position", "()Lorg/apache/kafka/streams/query/Position;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}