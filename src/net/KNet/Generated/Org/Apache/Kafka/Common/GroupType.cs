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
*  using kafka-clients-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common
{
    #region GroupType
    public partial class GroupType
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/GroupType.html#CLASSIC"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.GroupType CLASSIC { get { if (!_CLASSICReady) { _CLASSICContent = SGetField<Org.Apache.Kafka.Common.GroupType>(LocalBridgeClazz, "CLASSIC"); _CLASSICReady = true; } return _CLASSICContent; } }
        private static Org.Apache.Kafka.Common.GroupType _CLASSICContent = default;
        private static bool _CLASSICReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/GroupType.html#CONSUMER"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.GroupType CONSUMER { get { if (!_CONSUMERReady) { _CONSUMERContent = SGetField<Org.Apache.Kafka.Common.GroupType>(LocalBridgeClazz, "CONSUMER"); _CONSUMERReady = true; } return _CONSUMERContent; } }
        private static Org.Apache.Kafka.Common.GroupType _CONSUMERContent = default;
        private static bool _CONSUMERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/GroupType.html#UNKNOWN"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.GroupType UNKNOWN { get { if (!_UNKNOWNReady) { _UNKNOWNContent = SGetField<Org.Apache.Kafka.Common.GroupType>(LocalBridgeClazz, "UNKNOWN"); _UNKNOWNReady = true; } return _UNKNOWNContent; } }
        private static Org.Apache.Kafka.Common.GroupType _UNKNOWNContent = default;
        private static bool _UNKNOWNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/GroupType.html#parse-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.GroupType"/></returns>
        public static Org.Apache.Kafka.Common.GroupType Parse(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.GroupType>(LocalBridgeClazz, "parse", "(Ljava/lang/String;)Lorg/apache/kafka/common/GroupType;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/GroupType.html#valueOf-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.GroupType"/></returns>
        public static Org.Apache.Kafka.Common.GroupType ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.GroupType>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/common/GroupType;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/GroupType.html#values--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.GroupType"/></returns>
        public static Org.Apache.Kafka.Common.GroupType[] Values()
        {
            return SExecuteWithSignatureArray<Org.Apache.Kafka.Common.GroupType>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/common/GroupType;");
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