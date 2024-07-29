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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/Position.html#emptyPosition--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.Position"/></returns>
        public static Org.Apache.Kafka.Streams.Query.Position EmptyPosition()
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Streams.Query.Position>(LocalBridgeClazz, "emptyPosition", "()Lorg/apache/kafka/streams/query/Position;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/Position.html#fromMap-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <typeparam name="Arg0ExtendsJava_Util_Map_Java_Lang_Integer_Java_Lang_Long_"><see cref="Java.Util.Map{Java.Lang.Integer, Java.Lang.Long}"/></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.Position"/></returns>
        public static Org.Apache.Kafka.Streams.Query.Position FromMap<Arg0ExtendsJava_Util_Map_Java_Lang_Integer_Java_Lang_Long_>(Java.Util.Map<Java.Lang.String, Arg0ExtendsJava_Util_Map_Java_Lang_Integer_Java_Lang_Long_> arg0) where Arg0ExtendsJava_Util_Map_Java_Lang_Integer_Java_Lang_Long_ : Java.Util.Map<Java.Lang.Integer, Java.Lang.Long>
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Streams.Query.Position>(LocalBridgeClazz, "fromMap", "(Ljava/util/Map;)Lorg/apache/kafka/streams/query/Position;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/Position.html#getTopics--"/> 
        /// </summary>
        public Java.Util.Set<Java.Lang.String> Topics
        {
            get { return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getTopics", "()Ljava/util/Set;"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/Position.html#isEmpty--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecuteWithSignature<bool>("isEmpty", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/Position.html#getPartitionPositions-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.Integer, Java.Lang.Long> GetPartitionPositions(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.Integer, Java.Lang.Long>>("getPartitionPositions", "(Ljava/lang/String;)Ljava/util/Map;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/Position.html#copy--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.Position"/></returns>
        public Org.Apache.Kafka.Streams.Query.Position Copy()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.Position>("copy", "()Lorg/apache/kafka/streams/query/Position;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/Position.html#merge-org.apache.kafka.streams.query.Position-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Query.Position"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.Position"/></returns>
        public Org.Apache.Kafka.Streams.Query.Position Merge(Org.Apache.Kafka.Streams.Query.Position arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.Query.Position>("merge", "(Lorg/apache/kafka/streams/query/Position;)Lorg/apache/kafka/streams/query/Position;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/query/Position.html#withComponent-java.lang.String-int-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.Query.Position"/></returns>
        public Org.Apache.Kafka.Streams.Query.Position WithComponent(Java.Lang.String arg0, int arg1, long arg2)
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