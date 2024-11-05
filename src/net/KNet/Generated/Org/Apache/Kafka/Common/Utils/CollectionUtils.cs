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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using kafka-clients-3.8.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Utils
{
    #region CollectionUtils declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/utils/CollectionUtils.html"/>
    /// </summary>
    public partial class CollectionUtils : MASES.JCOBridge.C2JBridge.JVMBridgeBase<CollectionUtils>
    {
        const string _bridgeClassName = "org.apache.kafka.common.utils.CollectionUtils";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public CollectionUtils() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public CollectionUtils(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region CollectionUtils implementation
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/utils/CollectionUtils.html#subtractMap-java.util.Map-java.util.Map-"/>
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
            return SExecuteWithSignature<Java.Util.Map<K, V>>(LocalBridgeClazz, "subtractMap", "(Ljava/util/Map;Ljava/util/Map;)Ljava/util/Map;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/utils/CollectionUtils.html#groupPartitionDataByTopic-java.util.Map-"/>
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/utils/CollectionUtils.html#groupPartitionsByTopic-java.util.Collection-java.util.function.Function-java.util.function.BiConsumer-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Function"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.BiConsumer"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public static Java.Util.Map<Java.Lang.String, T> GroupPartitionsByTopic<T>(Java.Util.Collection<Org.Apache.Kafka.Common.TopicPartition> arg0, Java.Util.Function.Function<Java.Lang.String, T> arg1, Java.Util.Function.BiConsumer<T, Java.Lang.Integer> arg2)
        {
            return SExecuteWithSignature<Java.Util.Map<Java.Lang.String, T>>(LocalBridgeClazz, "groupPartitionsByTopic", "(Ljava/util/Collection;Ljava/util/function/Function;Ljava/util/function/BiConsumer;)Ljava/util/Map;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.1/org/apache/kafka/common/utils/CollectionUtils.html#groupPartitionsByTopic-java.util.Collection-"/>
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