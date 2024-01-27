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
*  This file is generated by MASES.JNetReflector (ver. 2.2.4.0)
*  using connect-runtime-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Util
{
    #region RetryUtil
    public partial class RetryUtil
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.6.1/org/apache/kafka/connect/util/RetryUtil.html#retryUntilTimeout-java.util.concurrent.Callable-java.util.function.Supplier-java.time.Duration-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Callable"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Supplier"/></param>
        /// <param name="arg2"><see cref="Java.Time.Duration"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Java.Lang.Exception"/>
        public static T RetryUntilTimeout<T>(Java.Util.Concurrent.Callable<T> arg0, Java.Util.Function.Supplier<string> arg1, Java.Time.Duration arg2, long arg3)
        {
            return SExecute<T>(LocalBridgeClazz, "retryUntilTimeout", arg0, arg1, arg2, arg3);
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