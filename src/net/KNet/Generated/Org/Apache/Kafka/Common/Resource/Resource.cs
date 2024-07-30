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
*  using kafka-clients-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Resource
{
    #region Resource
    public partial class Resource
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/resource/Resource.html#org.apache.kafka.common.resource.Resource(org.apache.kafka.common.resource.ResourceType,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Resource.ResourceType"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public Resource(Org.Apache.Kafka.Common.Resource.ResourceType arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/resource/Resource.html#CLUSTER_NAME"/>
        /// </summary>
        public static Java.Lang.String CLUSTER_NAME { get { if (!_CLUSTER_NAMEReady) { _CLUSTER_NAMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CLUSTER_NAME"); _CLUSTER_NAMEReady = true; } return _CLUSTER_NAMEContent; } }
        private static Java.Lang.String _CLUSTER_NAMEContent = default;
        private static bool _CLUSTER_NAMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/resource/Resource.html#CLUSTER"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Resource.Resource CLUSTER { get { if (!_CLUSTERReady) { _CLUSTERContent = SGetField<Org.Apache.Kafka.Common.Resource.Resource>(LocalBridgeClazz, "CLUSTER"); _CLUSTERReady = true; } return _CLUSTERContent; } }
        private static Org.Apache.Kafka.Common.Resource.Resource _CLUSTERContent = default;
        private static bool _CLUSTERReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/resource/Resource.html#isUnknown--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsUnknown()
        {
            return IExecuteWithSignature<bool>("isUnknown", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/resource/Resource.html#name--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Name()
        {
            return IExecuteWithSignature<Java.Lang.String>("name", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/resource/Resource.html#resourceType--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Resource.ResourceType"/></returns>
        public Org.Apache.Kafka.Common.Resource.ResourceType ResourceType()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Resource.ResourceType>("resourceType", "()Lorg/apache/kafka/common/resource/ResourceType;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}