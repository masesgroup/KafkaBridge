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
*  using connect-runtime-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Util
{
    #region Callback
    public partial class Callback
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.1/org/apache/kafka/connect/util/Callback.html#onCompletion-java.lang.Throwable-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Throwable"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void OnCompletion(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0, object arg1)
        {
            IExecute("onCompletion", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.1/org/apache/kafka/connect/util/Callback.html#chainStaging-org.apache.kafka.connect.util.Callback-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Util.Callback"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Util.Callback"/></returns>
        public Org.Apache.Kafka.Connect.Util.Callback ChainStaging(Org.Apache.Kafka.Connect.Util.Callback arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Util.Callback>("chainStaging", "(Lorg/apache/kafka/connect/util/Callback;)Lorg/apache/kafka/connect/util/Callback;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.1/org/apache/kafka/connect/util/Callback.html#recordStage-org.apache.kafka.connect.util.Stage-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Util.Stage"/></param>
        public void RecordStage(Org.Apache.Kafka.Connect.Util.Stage arg0)
        {
            IExecuteWithSignature("recordStage", "(Lorg/apache/kafka/connect/util/Stage;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ICallback<V>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ICallback<V>
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Callback<V>
    public partial class Callback<V> : Org.Apache.Kafka.Connect.Util.ICallback<V>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Util.Callback{V}"/> to <see cref="Org.Apache.Kafka.Connect.Util.Callback"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Connect.Util.Callback(Org.Apache.Kafka.Connect.Util.Callback<V> t) => t.Cast<Org.Apache.Kafka.Connect.Util.Callback>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.1/org/apache/kafka/connect/util/Callback.html#onCompletion-java.lang.Throwable-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Throwable"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        public void OnCompletion(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0, V arg1)
        {
            IExecute("onCompletion", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.1/org/apache/kafka/connect/util/Callback.html#chainStaging-org.apache.kafka.connect.util.Callback-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Util.Callback"/></param>
        /// <typeparam name="V2"></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Util.Callback"/></returns>
        public Org.Apache.Kafka.Connect.Util.Callback<V2> ChainStaging<V2>(Org.Apache.Kafka.Connect.Util.Callback<V2> arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Util.Callback<V2>>("chainStaging", "(Lorg/apache/kafka/connect/util/Callback;)Lorg/apache/kafka/connect/util/Callback;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.1/org/apache/kafka/connect/util/Callback.html#recordStage-org.apache.kafka.connect.util.Stage-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Util.Stage"/></param>
        public void RecordStage(Org.Apache.Kafka.Connect.Util.Stage arg0)
        {
            IExecuteWithSignature("recordStage", "(Lorg/apache/kafka/connect/util/Stage;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}