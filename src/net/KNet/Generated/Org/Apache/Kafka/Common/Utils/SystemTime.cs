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
*  using kafka-clients-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Utils
{
    #region SystemTime
    public partial class SystemTime
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/utils/SystemTime.html#milliseconds()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long Milliseconds()
        {
            return IExecute<long>("milliseconds");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/utils/SystemTime.html#nanoseconds()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long Nanoseconds()
        {
            return IExecute<long>("nanoseconds");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/utils/SystemTime.html#sleep(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void Sleep(long arg0)
        {
            IExecute("sleep", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/utils/SystemTime.html#waitObject(java.lang.Object,java.util.function.Supplier,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Supplier"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public void WaitObject(object arg0, Java.Util.Function.Supplier<bool?> arg1, long arg2)
        {
            IExecute("waitObject", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}