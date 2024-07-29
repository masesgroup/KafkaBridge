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
*  using kafka-clients-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Config.Types
{
    #region Password
    public partial class Password
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/config/types/Password.html#org.apache.kafka.common.config.types.Password(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public Password(Java.Lang.String arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/config/types/Password.html#HIDDEN"/>
        /// </summary>
        public static Java.Lang.String HIDDEN { get { if (!_HIDDENReady) { _HIDDENContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "HIDDEN"); _HIDDENReady = true; } return _HIDDENContent; } }
        private static Java.Lang.String _HIDDENContent = default;
        private static bool _HIDDENReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/config/types/Password.html#value--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Value()
        {
            return IExecuteWithSignature<Java.Lang.String>("value", "()Ljava/lang/String;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}