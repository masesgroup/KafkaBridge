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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using connect-runtime-3.5.0.jar as reference
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.5.0/org/apache/kafka/connect/util/Callback.html#onCompletion-java.lang.Throwable-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Throwable"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void OnCompletion(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0, object arg1)
        {
            IExecute("onCompletion", arg0, arg1);
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.5.0/org/apache/kafka/connect/util/Callback.html#onCompletion-java.lang.Throwable-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Throwable"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        public void OnCompletion(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0, V arg1)
        {
            IExecute("onCompletion", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}