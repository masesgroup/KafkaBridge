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
*  using kafka-clients-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Utils
{
    #region OperatingSystem
    public partial class OperatingSystem
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/utils/OperatingSystem.html#IS_WINDOWS"/>
        /// </summary>
        public static bool IS_WINDOWS { get { if (!_IS_WINDOWSReady) { _IS_WINDOWSContent = SGetField<bool>(LocalBridgeClazz, "IS_WINDOWS"); _IS_WINDOWSReady = true; } return _IS_WINDOWSContent; } }
        private static bool _IS_WINDOWSContent = default;
        private static bool _IS_WINDOWSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/utils/OperatingSystem.html#IS_ZOS"/>
        /// </summary>
        public static bool IS_ZOS { get { if (!_IS_ZOSReady) { _IS_ZOSContent = SGetField<bool>(LocalBridgeClazz, "IS_ZOS"); _IS_ZOSReady = true; } return _IS_ZOSContent; } }
        private static bool _IS_ZOSContent = default;
        private static bool _IS_ZOSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/utils/OperatingSystem.html#NAME"/>
        /// </summary>
        public static Java.Lang.String NAME { get { if (!_NAMEReady) { _NAMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "NAME"); _NAMEReady = true; } return _NAMEContent; } }
        private static Java.Lang.String _NAMEContent = default;
        private static bool _NAMEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}