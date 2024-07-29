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
*  using kafka-clients-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Record
{
    #region ControlRecordUtils
    public partial class ControlRecordUtils
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/record/ControlRecordUtils.html#LEADER_CHANGE_CURRENT_VERSION"/>
        /// </summary>
        public static short LEADER_CHANGE_CURRENT_VERSION { get { if (!_LEADER_CHANGE_CURRENT_VERSIONReady) { _LEADER_CHANGE_CURRENT_VERSIONContent = SGetField<short>(LocalBridgeClazz, "LEADER_CHANGE_CURRENT_VERSION"); _LEADER_CHANGE_CURRENT_VERSIONReady = true; } return _LEADER_CHANGE_CURRENT_VERSIONContent; } }
        private static short _LEADER_CHANGE_CURRENT_VERSIONContent = default;
        private static bool _LEADER_CHANGE_CURRENT_VERSIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/record/ControlRecordUtils.html#SNAPSHOT_FOOTER_CURRENT_VERSION"/>
        /// </summary>
        public static short SNAPSHOT_FOOTER_CURRENT_VERSION { get { if (!_SNAPSHOT_FOOTER_CURRENT_VERSIONReady) { _SNAPSHOT_FOOTER_CURRENT_VERSIONContent = SGetField<short>(LocalBridgeClazz, "SNAPSHOT_FOOTER_CURRENT_VERSION"); _SNAPSHOT_FOOTER_CURRENT_VERSIONReady = true; } return _SNAPSHOT_FOOTER_CURRENT_VERSIONContent; } }
        private static short _SNAPSHOT_FOOTER_CURRENT_VERSIONContent = default;
        private static bool _SNAPSHOT_FOOTER_CURRENT_VERSIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/record/ControlRecordUtils.html#SNAPSHOT_HEADER_CURRENT_VERSION"/>
        /// </summary>
        public static short SNAPSHOT_HEADER_CURRENT_VERSION { get { if (!_SNAPSHOT_HEADER_CURRENT_VERSIONReady) { _SNAPSHOT_HEADER_CURRENT_VERSIONContent = SGetField<short>(LocalBridgeClazz, "SNAPSHOT_HEADER_CURRENT_VERSION"); _SNAPSHOT_HEADER_CURRENT_VERSIONReady = true; } return _SNAPSHOT_HEADER_CURRENT_VERSIONContent; } }
        private static short _SNAPSHOT_HEADER_CURRENT_VERSIONContent = default;
        private static bool _SNAPSHOT_HEADER_CURRENT_VERSIONReady = false; // this is used because in case of generics 

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