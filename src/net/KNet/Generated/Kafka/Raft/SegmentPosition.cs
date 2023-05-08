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

namespace Kafka.Raft
{
    #region SegmentPosition
    public partial class SegmentPosition
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/raft/SegmentPosition.html#%3Cinit%3E(long,int)"/>
        /// </summary>
        /// <param name="baseOffset"><see cref="long"/></param>
        /// <param name="relativePosition"><see cref="int"/></param>
        public SegmentPosition(long baseOffset, int relativePosition)
            : base(baseOffset, relativePosition)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Kafka.Raft.SegmentPosition"/> to <see cref="Org.Apache.Kafka.Raft.OffsetMetadata"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Raft.OffsetMetadata(Kafka.Raft.SegmentPosition t) => t.Cast<Org.Apache.Kafka.Raft.OffsetMetadata>();
        /// <summary>
        /// Converter from <see cref="Kafka.Raft.SegmentPosition"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Kafka.Raft.SegmentPosition t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/raft/SegmentPosition.html#apply(long,int)"/>
        /// </summary>
        /// <param name="baseOffset"><see cref="long"/></param>
        /// <param name="relativePosition"><see cref="int"/></param>
        /// <returns><see cref="Kafka.Raft.SegmentPosition"/></returns>
        public static Kafka.Raft.SegmentPosition Apply(long baseOffset, int relativePosition)
        {
            return SExecute<Kafka.Raft.SegmentPosition>(LocalBridgeClazz, "apply", baseOffset, relativePosition);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/raft/SegmentPosition.html#baseOffset()"/> 
        /// </summary>
        public long BaseOffset
        {
            get { return IExecute<long>("baseOffset"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/raft/SegmentPosition.html#productArity()"/> 
        /// </summary>
        public int ProductArity
        {
            get { return IExecute<int>("productArity"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/raft/SegmentPosition.html#productPrefix()"/> 
        /// </summary>
        public string ProductPrefix
        {
            get { return IExecute<string>("productPrefix"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/raft/SegmentPosition.html#relativePosition()"/> 
        /// </summary>
        public int RelativePosition
        {
            get { return IExecute<int>("relativePosition"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/raft/SegmentPosition.html#canEqual(java.lang.Object)"/>
        /// </summary>
        /// <param name="x$1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CanEqual(object x_1)
        {
            return IExecute<bool>("canEqual", x_1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/raft/SegmentPosition.html#productElement(int)"/>
        /// </summary>
        /// <param name="x$1"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object ProductElement(int x_1)
        {
            return IExecute("productElement", x_1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/raft/SegmentPosition.html#productElementName(int)"/>
        /// </summary>
        /// <param name="x$1"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string ProductElementName(int x_1)
        {
            return IExecute<string>("productElementName", x_1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/raft/SegmentPosition.html#copy(long,int)"/>
        /// </summary>
        /// <param name="baseOffset"><see cref="long"/></param>
        /// <param name="relativePosition"><see cref="int"/></param>
        /// <returns><see cref="Kafka.Raft.SegmentPosition"/></returns>
        public Kafka.Raft.SegmentPosition Copy(long baseOffset, int relativePosition)
        {
            return IExecute<Kafka.Raft.SegmentPosition>("copy", baseOffset, relativePosition);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}