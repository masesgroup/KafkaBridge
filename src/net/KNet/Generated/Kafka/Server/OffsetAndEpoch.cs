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

namespace Kafka.Server
{
    #region OffsetAndEpoch
    public partial class OffsetAndEpoch
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/OffsetAndEpoch.html#%3Cinit%3E(long,int)"/>
        /// </summary>
        /// <param name="offset"><see cref="long"/></param>
        /// <param name="leaderEpoch"><see cref="int"/></param>
        public OffsetAndEpoch(long offset, int leaderEpoch)
            : base(offset, leaderEpoch)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Kafka.Server.OffsetAndEpoch"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Kafka.Server.OffsetAndEpoch t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/OffsetAndEpoch.html#apply(long,int)"/>
        /// </summary>
        /// <param name="offset"><see cref="long"/></param>
        /// <param name="leaderEpoch"><see cref="int"/></param>
        /// <returns><see cref="Kafka.Server.OffsetAndEpoch"/></returns>
        public static Kafka.Server.OffsetAndEpoch Apply(long offset, int leaderEpoch)
        {
            return SExecute<Kafka.Server.OffsetAndEpoch>(LocalBridgeClazz, "apply", offset, leaderEpoch);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/OffsetAndEpoch.html#leaderEpoch()"/> 
        /// </summary>
        public int LeaderEpoch
        {
            get { return IExecute<int>("leaderEpoch"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/OffsetAndEpoch.html#offset()"/> 
        /// </summary>
        public long Offset
        {
            get { return IExecute<long>("offset"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/OffsetAndEpoch.html#productArity()"/> 
        /// </summary>
        public int ProductArity
        {
            get { return IExecute<int>("productArity"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/OffsetAndEpoch.html#productPrefix()"/> 
        /// </summary>
        public string ProductPrefix
        {
            get { return IExecute<string>("productPrefix"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/OffsetAndEpoch.html#canEqual(java.lang.Object)"/>
        /// </summary>
        /// <param name="x$1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CanEqual(object x_1)
        {
            return IExecute<bool>("canEqual", x_1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/OffsetAndEpoch.html#productElement(int)"/>
        /// </summary>
        /// <param name="x$1"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object ProductElement(int x_1)
        {
            return IExecute("productElement", x_1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/OffsetAndEpoch.html#productElementName(int)"/>
        /// </summary>
        /// <param name="x$1"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string ProductElementName(int x_1)
        {
            return IExecute<string>("productElementName", x_1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/OffsetAndEpoch.html#copy(long,int)"/>
        /// </summary>
        /// <param name="offset"><see cref="long"/></param>
        /// <param name="leaderEpoch"><see cref="int"/></param>
        /// <returns><see cref="Kafka.Server.OffsetAndEpoch"/></returns>
        public Kafka.Server.OffsetAndEpoch Copy(long offset, int leaderEpoch)
        {
            return IExecute<Kafka.Server.OffsetAndEpoch>("copy", offset, leaderEpoch);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}