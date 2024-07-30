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

namespace Org.Apache.Kafka.Common.Acl
{
    #region AclBindingFilter
    public partial class AclBindingFilter
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/acl/AclBindingFilter.html#org.apache.kafka.common.acl.AclBindingFilter(org.apache.kafka.common.resource.ResourcePatternFilter,org.apache.kafka.common.acl.AccessControlEntryFilter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Resource.ResourcePatternFilter"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Acl.AccessControlEntryFilter"/></param>
        public AclBindingFilter(Org.Apache.Kafka.Common.Resource.ResourcePatternFilter arg0, Org.Apache.Kafka.Common.Acl.AccessControlEntryFilter arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/acl/AclBindingFilter.html#ANY"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Acl.AclBindingFilter ANY { get { if (!_ANYReady) { _ANYContent = SGetField<Org.Apache.Kafka.Common.Acl.AclBindingFilter>(LocalBridgeClazz, "ANY"); _ANYReady = true; } return _ANYContent; } }
        private static Org.Apache.Kafka.Common.Acl.AclBindingFilter _ANYContent = default;
        private static bool _ANYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/acl/AclBindingFilter.html#isUnknown--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsUnknown()
        {
            return IExecuteWithSignature<bool>("isUnknown", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/acl/AclBindingFilter.html#matches-org.apache.kafka.common.acl.AclBinding-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Acl.AclBinding"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Matches(Org.Apache.Kafka.Common.Acl.AclBinding arg0)
        {
            return IExecuteWithSignature<bool>("matches", "(Lorg/apache/kafka/common/acl/AclBinding;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/acl/AclBindingFilter.html#matchesAtMostOne--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool MatchesAtMostOne()
        {
            return IExecuteWithSignature<bool>("matchesAtMostOne", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/acl/AclBindingFilter.html#entryFilter--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Acl.AccessControlEntryFilter"/></returns>
        public Org.Apache.Kafka.Common.Acl.AccessControlEntryFilter EntryFilter()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Acl.AccessControlEntryFilter>("entryFilter", "()Lorg/apache/kafka/common/acl/AccessControlEntryFilter;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/acl/AclBindingFilter.html#findIndefiniteField--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String FindIndefiniteField()
        {
            return IExecuteWithSignature<Java.Lang.String>("findIndefiniteField", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/acl/AclBindingFilter.html#patternFilter--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Resource.ResourcePatternFilter"/></returns>
        public Org.Apache.Kafka.Common.Resource.ResourcePatternFilter PatternFilter()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Resource.ResourcePatternFilter>("patternFilter", "()Lorg/apache/kafka/common/resource/ResourcePatternFilter;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}