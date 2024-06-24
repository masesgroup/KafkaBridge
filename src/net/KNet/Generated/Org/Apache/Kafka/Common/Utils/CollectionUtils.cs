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
*  This file is generated by MASES.JNetReflector (ver. 2.5.4.0)
*  using kafka-clients-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Utils
{
    #region CollectionUtils
    public partial class CollectionUtils
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/utils/CollectionUtils.html#subtractMap-java.util.Map-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="V"></typeparam>
        /// <typeparam name="Arg0ExtendsK"><typeparamref name="K"/></typeparam>
        /// <typeparam name="Arg0ExtendsV"><typeparamref name="V"/></typeparam>
        /// <typeparam name="Arg1ExtendsK"><typeparamref name="K"/></typeparam>
        /// <typeparam name="Arg1ExtendsV"><typeparamref name="V"/></typeparam>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public static Java.Util.Map<K, V> SubtractMap<K, V, Arg0ExtendsK, Arg0ExtendsV, Arg1ExtendsK, Arg1ExtendsV>(Java.Util.Map<Arg0ExtendsK, Arg0ExtendsV> arg0, Java.Util.Map<Arg1ExtendsK, Arg1ExtendsV> arg1) where Arg0ExtendsK : K where Arg0ExtendsV : V where Arg1ExtendsK : K where Arg1ExtendsV : V
        {
            return SExecute<Java.Util.Map<K, V>>(LocalBridgeClazz, "subtractMap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/utils/CollectionUtils.html#groupPartitionDataByTopic-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="Arg0ExtendsT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public static Java.Util.Map<Java.Lang.String, Java.Util.Map<Java.Lang.Integer, T>> GroupPartitionDataByTopic<T, Arg0ExtendsT>(Java.Util.Map<Org.Apache.Kafka.Common.TopicPartition, Arg0ExtendsT> arg0) where Arg0ExtendsT : T
        {
            return SExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Util.Map<Java.Lang.Integer, T>>>(LocalBridgeClazz, "groupPartitionDataByTopic", "(Ljava/util/Map;)Ljava/util/Map;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/utils/CollectionUtils.html#groupPartitionsByTopic-java.util.Collection-java.util.function.Function-java.util.function.BiConsumer-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Function"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.BiConsumer"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public static Java.Util.Map<Java.Lang.String, T> GroupPartitionsByTopic<T>(Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartition> arg0, Java.Util.Function.Function<Java.Lang.String, T> arg1, Java.Util.Function.BiConsumer<T, Java.Lang.Integer> arg2)
        {
            return SExecute<Java.Util.Map<Java.Lang.String, T>>(LocalBridgeClazz, "groupPartitionsByTopic", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/utils/CollectionUtils.html#groupPartitionsByTopic-java.util.Collection-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public static Java.Util.Map<Java.Lang.String, Java.Util.List<Java.Lang.Integer>> GroupPartitionsByTopic(Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartition> arg0)
        {
            return SExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Util.List<Java.Lang.Integer>>>(LocalBridgeClazz, "groupPartitionsByTopic", "(Ljava/util/Collection;)Ljava/util/Map;", arg0);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}