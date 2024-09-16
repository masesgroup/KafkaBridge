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
*  using kafka-clients-3.6.2.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Admin
{
    #region AlterConfigOp
    public partial class AlterConfigOp
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/clients/admin/AlterConfigOp.html#org.apache.kafka.clients.admin.AlterConfigOp(org.apache.kafka.clients.admin.ConfigEntry,org.apache.kafka.clients.admin.AlterConfigOp.OpType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Admin.ConfigEntry"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Clients.Admin.AlterConfigOp.OpType"/></param>
        public AlterConfigOp(Org.Apache.Kafka.Clients.Admin.ConfigEntry arg0, Org.Apache.Kafka.Clients.Admin.AlterConfigOp.OpType arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/clients/admin/AlterConfigOp.html#opType--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.AlterConfigOp.OpType"/></returns>
        public Org.Apache.Kafka.Clients.Admin.AlterConfigOp.OpType OpTypeMethod()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Clients.Admin.AlterConfigOp.OpType>("opType", "()Lorg/apache/kafka/clients/admin/AlterConfigOp$OpType;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/clients/admin/AlterConfigOp.html#configEntry--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.ConfigEntry"/></returns>
        public Org.Apache.Kafka.Clients.Admin.ConfigEntry ConfigEntry()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Clients.Admin.ConfigEntry>("configEntry", "()Lorg/apache/kafka/clients/admin/ConfigEntry;");
        }

        #endregion

        #region Nested classes
        #region OpType
        public partial class OpType
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/clients/admin/AlterConfigOp.OpType.html#APPEND"/>
            /// </summary>
            public static Org.Apache.Kafka.Clients.Admin.AlterConfigOp.OpType APPEND { get { if (!_APPENDReady) { _APPENDContent = SGetField<Org.Apache.Kafka.Clients.Admin.AlterConfigOp.OpType>(LocalBridgeClazz, "APPEND"); _APPENDReady = true; } return _APPENDContent; } }
            private static Org.Apache.Kafka.Clients.Admin.AlterConfigOp.OpType _APPENDContent = default;
            private static bool _APPENDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/clients/admin/AlterConfigOp.OpType.html#DELETE"/>
            /// </summary>
            public static Org.Apache.Kafka.Clients.Admin.AlterConfigOp.OpType DELETE { get { if (!_DELETEReady) { _DELETEContent = SGetField<Org.Apache.Kafka.Clients.Admin.AlterConfigOp.OpType>(LocalBridgeClazz, "DELETE"); _DELETEReady = true; } return _DELETEContent; } }
            private static Org.Apache.Kafka.Clients.Admin.AlterConfigOp.OpType _DELETEContent = default;
            private static bool _DELETEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/clients/admin/AlterConfigOp.OpType.html#SET"/>
            /// </summary>
            public static Org.Apache.Kafka.Clients.Admin.AlterConfigOp.OpType SET { get { if (!_SETReady) { _SETContent = SGetField<Org.Apache.Kafka.Clients.Admin.AlterConfigOp.OpType>(LocalBridgeClazz, "SET"); _SETReady = true; } return _SETContent; } }
            private static Org.Apache.Kafka.Clients.Admin.AlterConfigOp.OpType _SETContent = default;
            private static bool _SETReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/clients/admin/AlterConfigOp.OpType.html#SUBTRACT"/>
            /// </summary>
            public static Org.Apache.Kafka.Clients.Admin.AlterConfigOp.OpType SUBTRACT { get { if (!_SUBTRACTReady) { _SUBTRACTContent = SGetField<Org.Apache.Kafka.Clients.Admin.AlterConfigOp.OpType>(LocalBridgeClazz, "SUBTRACT"); _SUBTRACTReady = true; } return _SUBTRACTContent; } }
            private static Org.Apache.Kafka.Clients.Admin.AlterConfigOp.OpType _SUBTRACTContent = default;
            private static bool _SUBTRACTReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/clients/admin/AlterConfigOp.OpType.html#forId-byte-"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.AlterConfigOp.OpType"/></returns>
            public static Org.Apache.Kafka.Clients.Admin.AlterConfigOp.OpType ForId(byte arg0)
            {
                return SExecuteWithSignature<Org.Apache.Kafka.Clients.Admin.AlterConfigOp.OpType>(LocalBridgeClazz, "forId", "(B)Lorg/apache/kafka/clients/admin/AlterConfigOp$OpType;", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/clients/admin/AlterConfigOp.OpType.html#valueOf-java.lang.String-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.AlterConfigOp.OpType"/></returns>
            public static Org.Apache.Kafka.Clients.Admin.AlterConfigOp.OpType ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Org.Apache.Kafka.Clients.Admin.AlterConfigOp.OpType>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/clients/admin/AlterConfigOp$OpType;", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/clients/admin/AlterConfigOp.OpType.html#values--"/>
            /// </summary>
            /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.AlterConfigOp.OpType"/></returns>
            public static Org.Apache.Kafka.Clients.Admin.AlterConfigOp.OpType[] Values()
            {
                return SExecuteWithSignatureArray<Org.Apache.Kafka.Clients.Admin.AlterConfigOp.OpType>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/clients/admin/AlterConfigOp$OpType;");
            }

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/clients/admin/AlterConfigOp.OpType.html#id--"/>
            /// </summary>
            /// <returns><see cref="byte"/></returns>
            public byte Id()
            {
                return IExecuteWithSignature<byte>("id", "()B");
            }

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