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
*  using connect-runtime-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Util
{
    #region ConnectUtils
    public partial class ConnectUtils
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.8.0/org/apache/kafka/connect/util/ConnectUtils.html#combineCollections-java.util.Collection-java.util.function.Function-java.util.stream.Collector-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Function"/></param>
        /// <param name="arg2"><see cref="Java.Util.Stream.Collector"/></param>
        /// <typeparam name="C"></typeparam>
        /// <typeparam name="I"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="C"/></returns>
        public static C CombineCollections<C, I, T>(Java.Util.Collection<I> arg0, Java.Util.Function.Function<I, Java.Util.Collection<T>> arg1, Java.Util.Stream.Collector<T, object, C> arg2)
        {
            return SExecute<C>(LocalBridgeClazz, "combineCollections", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.8.0/org/apache/kafka/connect/util/ConnectUtils.html#combineCollections-java.util.Collection-java.util.function.Function-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Function"/></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="I"></typeparam>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List<T> CombineCollections<T, I>(Java.Util.Collection<I> arg0, Java.Util.Function.Function<I, Java.Util.Collection<T>> arg1)
        {
            return SExecute<Java.Util.List<T>>(LocalBridgeClazz, "combineCollections", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.8.0/org/apache/kafka/connect/util/ConnectUtils.html#combineCollections-java.util.Collection-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <typeparam name="I"></typeparam>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List<I> CombineCollections<I>(Java.Util.Collection<Java.Util.Collection<I>> arg0)
        {
            return SExecuteWithSignature<Java.Util.List<I>>(LocalBridgeClazz, "combineCollections", "(Ljava/util/Collection;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.8.0/org/apache/kafka/connect/util/ConnectUtils.html#transformValues-java.util.Map-java.util.function.Function-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Function"/></param>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="O"></typeparam>
        /// <typeparam name="I"></typeparam>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public static Java.Util.Map<K, O> TransformValues<K, O, I>(Java.Util.Map<K, I> arg0, Java.Util.Function.Function<I, O> arg1)
        {
            return SExecute<Java.Util.Map<K, O>>(LocalBridgeClazz, "transformValues", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.8.0/org/apache/kafka/connect/util/ConnectUtils.html#isSinkConnector-org.apache.kafka.connect.connector.Connector-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Connector.Connector"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsSinkConnector(Org.Apache.Kafka.Connect.Connector.Connector arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isSinkConnector", "(Lorg/apache/kafka/connect/connector/Connector;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.8.0/org/apache/kafka/connect/util/ConnectUtils.html#isSourceConnector-org.apache.kafka.connect.connector.Connector-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Connector.Connector"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsSourceConnector(Org.Apache.Kafka.Connect.Connector.Connector arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isSourceConnector", "(Lorg/apache/kafka/connect/connector/Connector;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.8.0/org/apache/kafka/connect/util/ConnectUtils.html#checkAndConvertTimestamp-java.lang.Long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Long"/></param>
        /// <returns><see cref="Java.Lang.Long"/></returns>
        public static Java.Lang.Long CheckAndConvertTimestamp(Java.Lang.Long arg0)
        {
            return SExecuteWithSignature<Java.Lang.Long>(LocalBridgeClazz, "checkAndConvertTimestamp", "(Ljava/lang/Long;)Ljava/lang/Long;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.8.0/org/apache/kafka/connect/util/ConnectUtils.html#className-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ClassName(object arg0)
        {
            return SExecute<Java.Lang.String>(LocalBridgeClazz, "className", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.8.0/org/apache/kafka/connect/util/ConnectUtils.html#patchConfig-java.util.Map-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public static Java.Util.Map<Java.Lang.String, Java.Lang.String> PatchConfig(Java.Util.Map<Java.Lang.String, Java.Lang.String> arg0, Java.Util.Map<Java.Lang.String, Java.Lang.String> arg1)
        {
            return SExecute<Java.Util.Map<Java.Lang.String, Java.Lang.String>>(LocalBridgeClazz, "patchConfig", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.8.0/org/apache/kafka/connect/util/ConnectUtils.html#maybeWrap-java.lang.Throwable-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Throwable"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Errors.ConnectException"/></returns>
        public static Org.Apache.Kafka.Connect.Errors.ConnectException MaybeWrap(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0, Java.Lang.String arg1)
        {
            var obj = SExecute<MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject>(LocalBridgeClazz, "maybeWrap", arg0, arg1); return MASES.JCOBridge.C2JBridge.JVMBridgeException.New<Org.Apache.Kafka.Connect.Errors.ConnectException>(obj);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.8.0/org/apache/kafka/connect/util/ConnectUtils.html#ensureProperty-java.util.Map-java.lang.String-java.lang.String-java.lang.String-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        /// <typeparam name="Arg0objectSuperJava_Lang_String"><see cref="Java.Lang.String"/></typeparam>
        public static void EnsureProperty<Arg0objectSuperJava_Lang_String>(Java.Util.Map<Java.Lang.String, Arg0objectSuperJava_Lang_String> arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String arg3, bool arg4) where Arg0objectSuperJava_Lang_String : Java.Lang.String
        {
            SExecute(LocalBridgeClazz, "ensureProperty", arg0, arg1, arg2, arg3, arg4);
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