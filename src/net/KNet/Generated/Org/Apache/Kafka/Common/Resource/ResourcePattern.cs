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
*  using kafka-clients-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Resource
{
    #region ResourcePattern
    public partial class ResourcePattern
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/resource/ResourcePattern.html#org.apache.kafka.common.resource.ResourcePattern(org.apache.kafka.common.resource.ResourceType,java.lang.String,org.apache.kafka.common.resource.PatternType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Resource.ResourceType"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Resource.PatternType"/></param>
        public ResourcePattern(Org.Apache.Kafka.Common.Resource.ResourceType arg0, Java.Lang.String arg1, Org.Apache.Kafka.Common.Resource.PatternType arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/resource/ResourcePattern.html#WILDCARD_RESOURCE"/>
        /// </summary>
        public static Java.Lang.String WILDCARD_RESOURCE { get { if (!_WILDCARD_RESOURCEReady) { _WILDCARD_RESOURCEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "WILDCARD_RESOURCE"); _WILDCARD_RESOURCEReady = true; } return _WILDCARD_RESOURCEContent; } }
        private static Java.Lang.String _WILDCARD_RESOURCEContent = default;
        private static bool _WILDCARD_RESOURCEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/resource/ResourcePattern.html#isUnknown--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsUnknown()
        {
            return IExecuteWithSignature<bool>("isUnknown", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/resource/ResourcePattern.html#name--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Name()
        {
            return IExecuteWithSignature<Java.Lang.String>("name", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/resource/ResourcePattern.html#patternType--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Resource.PatternType"/></returns>
        public Org.Apache.Kafka.Common.Resource.PatternType PatternType()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Resource.PatternType>("patternType", "()Lorg/apache/kafka/common/resource/PatternType;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/resource/ResourcePattern.html#toFilter--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Resource.ResourcePatternFilter"/></returns>
        public Org.Apache.Kafka.Common.Resource.ResourcePatternFilter ToFilter()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Resource.ResourcePatternFilter>("toFilter", "()Lorg/apache/kafka/common/resource/ResourcePatternFilter;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/resource/ResourcePattern.html#resourceType--"/>
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