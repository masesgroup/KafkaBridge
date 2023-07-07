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
*  This file is generated by MASES.JNetReflector (ver. 2.0.0.0)
*  using kafka-streams-3.5.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Query
{
    #region Position
    public partial class Position
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/query/Position.html#emptyPosition--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.Position"/></returns>
        public static Org.Apache.Kafka.Streams.Query.Position EmptyPosition()
        {
            return SExecute<Org.Apache.Kafka.Streams.Query.Position>(LocalBridgeClazz, "emptyPosition");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/query/Position.html#fromMap-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <typeparam name="Arg0ExtendsJava_Util_Map_Java_Lang_Integer_Java_Lang_Long_"><see cref="Java.Util.Map{Java.Lang.Integer, Java.Lang.Long}"/></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.Position"/></returns>
        public static Org.Apache.Kafka.Streams.Query.Position FromMap<Arg0ExtendsJava_Util_Map_Java_Lang_Integer_Java_Lang_Long_>(Java.Util.Map<string, Arg0ExtendsJava_Util_Map_Java_Lang_Integer_Java_Lang_Long_> arg0) where Arg0ExtendsJava_Util_Map_Java_Lang_Integer_Java_Lang_Long_: Java.Util.Map<Java.Lang.Integer, Java.Lang.Long>
        {
            return SExecute<Org.Apache.Kafka.Streams.Query.Position>(LocalBridgeClazz, "fromMap", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/query/Position.html#getTopics--"/> 
        /// </summary>
        public Java.Util.Set<string> Topics
        {
            get { return IExecute<Java.Util.Set<string>>("getTopics"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/query/Position.html#isEmpty--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecute<bool>("isEmpty");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/query/Position.html#getPartitionPositions-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.Integer, Java.Lang.Long> GetPartitionPositions(string arg0)
        {
            return IExecute<Java.Util.Map<Java.Lang.Integer, Java.Lang.Long>>("getPartitionPositions", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/query/Position.html#copy--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.Position"/></returns>
        public Org.Apache.Kafka.Streams.Query.Position Copy()
        {
            return IExecute<Org.Apache.Kafka.Streams.Query.Position>("copy");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/query/Position.html#merge-org.apache.kafka.streams.query.Position-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Query.Position"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.Position"/></returns>
        public Org.Apache.Kafka.Streams.Query.Position Merge(Org.Apache.Kafka.Streams.Query.Position arg0)
        {
            return IExecute<Org.Apache.Kafka.Streams.Query.Position>("merge", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/query/Position.html#withComponent-java.lang.String-int-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.Position"/></returns>
        public Org.Apache.Kafka.Streams.Query.Position WithComponent(string arg0, int arg1, long arg2)
        {
            return IExecute<Org.Apache.Kafka.Streams.Query.Position>("withComponent", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}