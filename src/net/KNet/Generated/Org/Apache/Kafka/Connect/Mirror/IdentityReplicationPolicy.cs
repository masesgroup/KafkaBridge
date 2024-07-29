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
*  using connect-mirror-client-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Mirror
{
    #region IdentityReplicationPolicy
    public partial class IdentityReplicationPolicy
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror-client/3.8.0/org/apache/kafka/connect/mirror/IdentityReplicationPolicy.html#SOURCE_CLUSTER_ALIAS_CONFIG"/>
        /// </summary>
        public static Java.Lang.String SOURCE_CLUSTER_ALIAS_CONFIG { get { if (!_SOURCE_CLUSTER_ALIAS_CONFIGReady) { _SOURCE_CLUSTER_ALIAS_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SOURCE_CLUSTER_ALIAS_CONFIG"); _SOURCE_CLUSTER_ALIAS_CONFIGReady = true; } return _SOURCE_CLUSTER_ALIAS_CONFIGContent; } }
        private static Java.Lang.String _SOURCE_CLUSTER_ALIAS_CONFIGContent = default;
        private static bool _SOURCE_CLUSTER_ALIAS_CONFIGReady = false; // this is used because in case of generics 

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