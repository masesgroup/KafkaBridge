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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using kafka-raft-3.6.2.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Raft
{
    #region Isolation
    public partial class Isolation
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/Isolation.html#COMMITTED"/>
        /// </summary>
        public static Org.Apache.Kafka.Raft.Isolation COMMITTED { get { if (!_COMMITTEDReady) { _COMMITTEDContent = SGetField<Org.Apache.Kafka.Raft.Isolation>(LocalBridgeClazz, "COMMITTED"); _COMMITTEDReady = true; } return _COMMITTEDContent; } }
        private static Org.Apache.Kafka.Raft.Isolation _COMMITTEDContent = default;
        private static bool _COMMITTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/Isolation.html#UNCOMMITTED"/>
        /// </summary>
        public static Org.Apache.Kafka.Raft.Isolation UNCOMMITTED { get { if (!_UNCOMMITTEDReady) { _UNCOMMITTEDContent = SGetField<Org.Apache.Kafka.Raft.Isolation>(LocalBridgeClazz, "UNCOMMITTED"); _UNCOMMITTEDReady = true; } return _UNCOMMITTEDContent; } }
        private static Org.Apache.Kafka.Raft.Isolation _UNCOMMITTEDContent = default;
        private static bool _UNCOMMITTEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/Isolation.html#valueOf-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Raft.Isolation"/></returns>
        public static Org.Apache.Kafka.Raft.Isolation ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Raft.Isolation>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/raft/Isolation;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/Isolation.html#values--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Raft.Isolation"/></returns>
        public static Org.Apache.Kafka.Raft.Isolation[] Values()
        {
            return SExecuteWithSignatureArray<Org.Apache.Kafka.Raft.Isolation>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/raft/Isolation;");
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