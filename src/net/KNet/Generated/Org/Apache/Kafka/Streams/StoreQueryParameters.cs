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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using kafka-streams-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams
{
    #region StoreQueryParameters declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StoreQueryParameters.html"/>
    /// </summary>
    public partial class StoreQueryParameters : MASES.JCOBridge.C2JBridge.JVMBridgeBase<StoreQueryParameters>
    {
        const string _bridgeClassName = "org.apache.kafka.streams.StoreQueryParameters";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public StoreQueryParameters() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public StoreQueryParameters(params object[] args) : base(args) { }

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

    #region StoreQueryParameters<T> declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StoreQueryParameters.html"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public partial class StoreQueryParameters<T> : MASES.JCOBridge.C2JBridge.JVMBridgeBase<StoreQueryParameters<T>>
    {
        const string _bridgeClassName = "org.apache.kafka.streams.StoreQueryParameters";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public StoreQueryParameters() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public StoreQueryParameters(params object[] args) : base(args) { }

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

    #region StoreQueryParameters implementation
    public partial class StoreQueryParameters
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StoreQueryParameters.html#fromNameAndType-java.lang.String-org.apache.kafka.streams.state.QueryableStoreType-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.State.QueryableStoreType"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.StoreQueryParameters"/></returns>
        public static Org.Apache.Kafka.Streams.StoreQueryParameters FromNameAndType(Java.Lang.String arg0, Org.Apache.Kafka.Streams.State.QueryableStoreType arg1)
        {
            return SExecute<Org.Apache.Kafka.Streams.StoreQueryParameters>(LocalBridgeClazz, "fromNameAndType", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StoreQueryParameters.html#staleStoresEnabled--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool StaleStoresEnabled()
        {
            return IExecuteWithSignature<bool>("staleStoresEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StoreQueryParameters.html#partition--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        public Java.Lang.Integer Partition()
        {
            return IExecuteWithSignature<Java.Lang.Integer>("partition", "()Ljava/lang/Integer;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StoreQueryParameters.html#storeName--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String StoreName()
        {
            return IExecuteWithSignature<Java.Lang.String>("storeName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StoreQueryParameters.html#queryableStoreType--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.QueryableStoreType"/></returns>
        public Org.Apache.Kafka.Streams.State.QueryableStoreType QueryableStoreType()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.State.QueryableStoreType>("queryableStoreType", "()Lorg/apache/kafka/streams/state/QueryableStoreType;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StoreQueryParameters.html#enableStaleStores--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.StoreQueryParameters"/></returns>
        public Org.Apache.Kafka.Streams.StoreQueryParameters EnableStaleStores()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.StoreQueryParameters>("enableStaleStores", "()Lorg/apache/kafka/streams/StoreQueryParameters;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StoreQueryParameters.html#withPartition-java.lang.Integer-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Integer"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.StoreQueryParameters"/></returns>
        public Org.Apache.Kafka.Streams.StoreQueryParameters WithPartition(Java.Lang.Integer arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.StoreQueryParameters>("withPartition", "(Ljava/lang/Integer;)Lorg/apache/kafka/streams/StoreQueryParameters;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region StoreQueryParameters<T> implementation
    public partial class StoreQueryParameters<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.StoreQueryParameters{T}"/> to <see cref="Org.Apache.Kafka.Streams.StoreQueryParameters"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.StoreQueryParameters(Org.Apache.Kafka.Streams.StoreQueryParameters<T> t) => t.Cast<Org.Apache.Kafka.Streams.StoreQueryParameters>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StoreQueryParameters.html#fromNameAndType-java.lang.String-org.apache.kafka.streams.state.QueryableStoreType-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Streams.State.QueryableStoreType"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.StoreQueryParameters"/></returns>
        public static Org.Apache.Kafka.Streams.StoreQueryParameters<T> FromNameAndType(Java.Lang.String arg0, Org.Apache.Kafka.Streams.State.QueryableStoreType<T> arg1)
        {
            return SExecute<Org.Apache.Kafka.Streams.StoreQueryParameters<T>>(LocalBridgeClazz, "fromNameAndType", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StoreQueryParameters.html#staleStoresEnabled--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool StaleStoresEnabled()
        {
            return IExecuteWithSignature<bool>("staleStoresEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StoreQueryParameters.html#partition--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        public Java.Lang.Integer Partition()
        {
            return IExecuteWithSignature<Java.Lang.Integer>("partition", "()Ljava/lang/Integer;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StoreQueryParameters.html#storeName--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String StoreName()
        {
            return IExecuteWithSignature<Java.Lang.String>("storeName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StoreQueryParameters.html#queryableStoreType--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.State.QueryableStoreType"/></returns>
        public Org.Apache.Kafka.Streams.State.QueryableStoreType<T> QueryableStoreType()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.State.QueryableStoreType<T>>("queryableStoreType", "()Lorg/apache/kafka/streams/state/QueryableStoreType;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StoreQueryParameters.html#enableStaleStores--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Streams.StoreQueryParameters"/></returns>
        public Org.Apache.Kafka.Streams.StoreQueryParameters<T> EnableStaleStores()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.StoreQueryParameters<T>>("enableStaleStores", "()Lorg/apache/kafka/streams/StoreQueryParameters;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.8.0/org/apache/kafka/streams/StoreQueryParameters.html#withPartition-java.lang.Integer-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Integer"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Streams.StoreQueryParameters"/></returns>
        public Org.Apache.Kafka.Streams.StoreQueryParameters<T> WithPartition(Java.Lang.Integer arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Streams.StoreQueryParameters<T>>("withPartition", "(Ljava/lang/Integer;)Lorg/apache/kafka/streams/StoreQueryParameters;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}