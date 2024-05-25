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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using kafka-raft-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Raft
{
    #region ValidOffsetAndEpoch
    public partial class ValidOffsetAndEpoch
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/ValidOffsetAndEpoch.html#diverging-org.apache.kafka.raft.OffsetAndEpoch-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Raft.OffsetAndEpoch"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Raft.ValidOffsetAndEpoch"/></returns>
        public static Org.Apache.Kafka.Raft.ValidOffsetAndEpoch Diverging(Org.Apache.Kafka.Raft.OffsetAndEpoch arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Raft.ValidOffsetAndEpoch>(LocalBridgeClazz, "diverging", "(Lorg/apache/kafka/raft/OffsetAndEpoch;)Lorg/apache/kafka/raft/ValidOffsetAndEpoch;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/ValidOffsetAndEpoch.html#snapshot-org.apache.kafka.raft.OffsetAndEpoch-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Raft.OffsetAndEpoch"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Raft.ValidOffsetAndEpoch"/></returns>
        public static Org.Apache.Kafka.Raft.ValidOffsetAndEpoch Snapshot(Org.Apache.Kafka.Raft.OffsetAndEpoch arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Raft.ValidOffsetAndEpoch>(LocalBridgeClazz, "snapshot", "(Lorg/apache/kafka/raft/OffsetAndEpoch;)Lorg/apache/kafka/raft/ValidOffsetAndEpoch;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/ValidOffsetAndEpoch.html#valid--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Raft.ValidOffsetAndEpoch"/></returns>
        public static Org.Apache.Kafka.Raft.ValidOffsetAndEpoch Valid()
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Raft.ValidOffsetAndEpoch>(LocalBridgeClazz, "valid", "()Lorg/apache/kafka/raft/ValidOffsetAndEpoch;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/ValidOffsetAndEpoch.html#valid-org.apache.kafka.raft.OffsetAndEpoch-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Raft.OffsetAndEpoch"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Raft.ValidOffsetAndEpoch"/></returns>
        public static Org.Apache.Kafka.Raft.ValidOffsetAndEpoch Valid(Org.Apache.Kafka.Raft.OffsetAndEpoch arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Raft.ValidOffsetAndEpoch>(LocalBridgeClazz, "valid", "(Lorg/apache/kafka/raft/OffsetAndEpoch;)Lorg/apache/kafka/raft/ValidOffsetAndEpoch;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/ValidOffsetAndEpoch.html#offsetAndEpoch--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Raft.OffsetAndEpoch"/></returns>
        public Org.Apache.Kafka.Raft.OffsetAndEpoch OffsetAndEpoch()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.OffsetAndEpoch>("offsetAndEpoch", "()Lorg/apache/kafka/raft/OffsetAndEpoch;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/ValidOffsetAndEpoch.html#kind--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Raft.ValidOffsetAndEpoch.Kind"/></returns>
        public Org.Apache.Kafka.Raft.ValidOffsetAndEpoch.Kind KindMethod()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.ValidOffsetAndEpoch.Kind>("kind", "()Lorg/apache/kafka/raft/ValidOffsetAndEpoch$Kind;");
        }

        #endregion

        #region Nested classes
        #region Kind
        public partial class Kind
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/ValidOffsetAndEpoch.Kind.html#DIVERGING"/>
            /// </summary>
            public static Org.Apache.Kafka.Raft.ValidOffsetAndEpoch.Kind DIVERGING { get { if (!_DIVERGINGReady) { _DIVERGINGContent = SGetField<Org.Apache.Kafka.Raft.ValidOffsetAndEpoch.Kind>(LocalBridgeClazz, "DIVERGING"); _DIVERGINGReady = true; } return _DIVERGINGContent; } }
            private static Org.Apache.Kafka.Raft.ValidOffsetAndEpoch.Kind _DIVERGINGContent = default;
            private static bool _DIVERGINGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/ValidOffsetAndEpoch.Kind.html#SNAPSHOT"/>
            /// </summary>
            public static Org.Apache.Kafka.Raft.ValidOffsetAndEpoch.Kind SNAPSHOT { get { if (!_SNAPSHOTReady) { _SNAPSHOTContent = SGetField<Org.Apache.Kafka.Raft.ValidOffsetAndEpoch.Kind>(LocalBridgeClazz, "SNAPSHOT"); _SNAPSHOTReady = true; } return _SNAPSHOTContent; } }
            private static Org.Apache.Kafka.Raft.ValidOffsetAndEpoch.Kind _SNAPSHOTContent = default;
            private static bool _SNAPSHOTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/ValidOffsetAndEpoch.Kind.html#VALID"/>
            /// </summary>
            public static Org.Apache.Kafka.Raft.ValidOffsetAndEpoch.Kind VALID { get { if (!_VALIDReady) { _VALIDContent = SGetField<Org.Apache.Kafka.Raft.ValidOffsetAndEpoch.Kind>(LocalBridgeClazz, "VALID"); _VALIDReady = true; } return _VALIDContent; } }
            private static Org.Apache.Kafka.Raft.ValidOffsetAndEpoch.Kind _VALIDContent = default;
            private static bool _VALIDReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/ValidOffsetAndEpoch.Kind.html#valueOf-java.lang.String-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Raft.ValidOffsetAndEpoch.Kind"/></returns>
            public static Org.Apache.Kafka.Raft.ValidOffsetAndEpoch.Kind ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Org.Apache.Kafka.Raft.ValidOffsetAndEpoch.Kind>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/raft/ValidOffsetAndEpoch$Kind;", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.0/org/apache/kafka/raft/ValidOffsetAndEpoch.Kind.html#values--"/>
            /// </summary>
            /// <returns><see cref="Org.Apache.Kafka.Raft.ValidOffsetAndEpoch.Kind"/></returns>
            public static Org.Apache.Kafka.Raft.ValidOffsetAndEpoch.Kind[] Values()
            {
                return SExecuteWithSignatureArray<Org.Apache.Kafka.Raft.ValidOffsetAndEpoch.Kind>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/raft/ValidOffsetAndEpoch$Kind;");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}