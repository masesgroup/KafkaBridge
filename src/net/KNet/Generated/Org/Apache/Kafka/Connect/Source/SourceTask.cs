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
*  This file is generated by MASES.JNetReflector (ver. 2.2.1.0)
*  using connect-api-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Source
{
    #region SourceTask
    public partial class SourceTask
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/source/SourceTask.html#TRANSACTION_BOUNDARY_CONFIG"/>
        /// </summary>
        public static string TRANSACTION_BOUNDARY_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "TRANSACTION_BOUNDARY_CONFIG"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/source/SourceTask.html#poll--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.List"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public Java.Util.List<Org.Apache.Kafka.Connect.Source.SourceRecord> Poll()
        {
            return IExecute<Java.Util.List<Org.Apache.Kafka.Connect.Source.SourceRecord>>("poll");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/source/SourceTask.html#start-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public void Start(Java.Util.Map<string, string> arg0)
        {
            IExecute("start", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/source/SourceTask.html#stop--"/>
        /// </summary>
        public void Stop()
        {
            IExecute("stop");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/source/SourceTask.html#commit--"/>
        /// </summary>

        /// <exception cref="Java.Lang.InterruptedException"/>
        public void Commit()
        {
            IExecute("commit");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/source/SourceTask.html#commitRecord-org.apache.kafka.connect.source.SourceRecord-org.apache.kafka.clients.producer.RecordMetadata-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Source.SourceRecord"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Clients.Producer.RecordMetadata"/></param>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public void CommitRecord(Org.Apache.Kafka.Connect.Source.SourceRecord arg0, Org.Apache.Kafka.Clients.Producer.RecordMetadata arg1)
        {
            IExecute("commitRecord", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/source/SourceTask.html#initialize-org.apache.kafka.connect.source.SourceTaskContext-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Source.SourceTaskContext"/></param>
        public void Initialize(Org.Apache.Kafka.Connect.Source.SourceTaskContext arg0)
        {
            IExecute("initialize", arg0);
        }

        #endregion

        #region Nested classes
        #region TransactionBoundary
        public partial class TransactionBoundary
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/source/SourceTask.TransactionBoundary.html#CONNECTOR"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Source.SourceTask.TransactionBoundary CONNECTOR { get { return SGetField<Org.Apache.Kafka.Connect.Source.SourceTask.TransactionBoundary>(LocalBridgeClazz, "CONNECTOR"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/source/SourceTask.TransactionBoundary.html#DEFAULT"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Source.SourceTask.TransactionBoundary DEFAULT { get { return SGetField<Org.Apache.Kafka.Connect.Source.SourceTask.TransactionBoundary>(LocalBridgeClazz, "DEFAULT"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/source/SourceTask.TransactionBoundary.html#INTERVAL"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Source.SourceTask.TransactionBoundary INTERVAL { get { return SGetField<Org.Apache.Kafka.Connect.Source.SourceTask.TransactionBoundary>(LocalBridgeClazz, "INTERVAL"); } }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/source/SourceTask.TransactionBoundary.html#POLL"/>
            /// </summary>
            public static Org.Apache.Kafka.Connect.Source.SourceTask.TransactionBoundary POLL { get { return SGetField<Org.Apache.Kafka.Connect.Source.SourceTask.TransactionBoundary>(LocalBridgeClazz, "POLL"); } }

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/source/SourceTask.TransactionBoundary.html#fromProperty-java.lang.String-"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Connect.Source.SourceTask.TransactionBoundary"/></returns>
            public static Org.Apache.Kafka.Connect.Source.SourceTask.TransactionBoundary FromProperty(string arg0)
            {
                return SExecute<Org.Apache.Kafka.Connect.Source.SourceTask.TransactionBoundary>(LocalBridgeClazz, "fromProperty", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/source/SourceTask.TransactionBoundary.html#valueOf-java.lang.String-"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Connect.Source.SourceTask.TransactionBoundary"/></returns>
            public static Org.Apache.Kafka.Connect.Source.SourceTask.TransactionBoundary ValueOf(string arg0)
            {
                return SExecute<Org.Apache.Kafka.Connect.Source.SourceTask.TransactionBoundary>(LocalBridgeClazz, "valueOf", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/source/SourceTask.TransactionBoundary.html#values--"/>
            /// </summary>

            /// <returns><see cref="Org.Apache.Kafka.Connect.Source.SourceTask.TransactionBoundary"/></returns>
            public static Org.Apache.Kafka.Connect.Source.SourceTask.TransactionBoundary[] Values()
            {
                return SExecuteArray<Org.Apache.Kafka.Connect.Source.SourceTask.TransactionBoundary>(LocalBridgeClazz, "values");
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