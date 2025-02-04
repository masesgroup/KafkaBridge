/*
*  Copyright 2025 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.5.12.0)
*  using kafka-clients-3.9.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Resource
{
    #region ResourcePatternFilter declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/resource/ResourcePatternFilter.html"/>
    /// </summary>
    public partial class ResourcePatternFilter : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ResourcePatternFilter>
    {
        const string _bridgeClassName = "org.apache.kafka.common.resource.ResourcePatternFilter";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ResourcePatternFilter() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ResourcePatternFilter(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region ResourcePatternFilter implementation
    public partial class ResourcePatternFilter
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/resource/ResourcePatternFilter.html#org.apache.kafka.common.resource.ResourcePatternFilter(org.apache.kafka.common.resource.ResourceType,java.lang.String,org.apache.kafka.common.resource.PatternType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Resource.ResourceType"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Resource.PatternType"/></param>
        public ResourcePatternFilter(Org.Apache.Kafka.Common.Resource.ResourceType arg0, Java.Lang.String arg1, Org.Apache.Kafka.Common.Resource.PatternType arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/resource/ResourcePatternFilter.html#ANY"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Resource.ResourcePatternFilter ANY { get { if (!_ANYReady) { _ANYContent = SGetField<Org.Apache.Kafka.Common.Resource.ResourcePatternFilter>(LocalBridgeClazz, "ANY"); _ANYReady = true; } return _ANYContent; } }
        private static Org.Apache.Kafka.Common.Resource.ResourcePatternFilter _ANYContent = default;
        private static bool _ANYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/resource/ResourcePatternFilter.html#isUnknown--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsUnknown()
        {
            return IExecuteWithSignature<bool>("isUnknown", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/resource/ResourcePatternFilter.html#matches-org.apache.kafka.common.resource.ResourcePattern-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Resource.ResourcePattern"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Matches(Org.Apache.Kafka.Common.Resource.ResourcePattern arg0)
        {
            return IExecuteWithSignature<bool>("matches", "(Lorg/apache/kafka/common/resource/ResourcePattern;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/resource/ResourcePatternFilter.html#matchesAtMostOne--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool MatchesAtMostOne()
        {
            return IExecuteWithSignature<bool>("matchesAtMostOne", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/resource/ResourcePatternFilter.html#findIndefiniteField--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String FindIndefiniteField()
        {
            return IExecuteWithSignature<Java.Lang.String>("findIndefiniteField", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/resource/ResourcePatternFilter.html#name--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Name()
        {
            return IExecuteWithSignature<Java.Lang.String>("name", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/resource/ResourcePatternFilter.html#patternType--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Resource.PatternType"/></returns>
        public Org.Apache.Kafka.Common.Resource.PatternType PatternType()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Resource.PatternType>("patternType", "()Lorg/apache/kafka/common/resource/PatternType;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.9.0/org/apache/kafka/common/resource/ResourcePatternFilter.html#resourceType--"/>
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