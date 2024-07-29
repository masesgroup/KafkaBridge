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
*  using kafka-clients-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Replica
{
    #region IReplicaView
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IReplicaView
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ReplicaView
    public partial class ReplicaView : Org.Apache.Kafka.Common.Replica.IReplicaView
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/replica/ReplicaView.html#comparator--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Comparator"/></returns>
        public static Java.Util.Comparator<Org.Apache.Kafka.Common.Replica.ReplicaView> Comparator()
        {
            return SExecuteWithSignature<Java.Util.Comparator<Org.Apache.Kafka.Common.Replica.ReplicaView>>(LocalBridgeClazz, "comparator", "()Ljava/util/Comparator;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/replica/ReplicaView.html#logEndOffset--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long LogEndOffset()
        {
            return IExecuteWithSignature<long>("logEndOffset", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/replica/ReplicaView.html#timeSinceLastCaughtUpMs--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long TimeSinceLastCaughtUpMs()
        {
            return IExecuteWithSignature<long>("timeSinceLastCaughtUpMs", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/replica/ReplicaView.html#endpoint--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Node"/></returns>
        public Org.Apache.Kafka.Common.Node Endpoint()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Node>("endpoint", "()Lorg/apache/kafka/common/Node;");
        }

        #endregion

        #region Nested classes
        #region DefaultReplicaView
        public partial class DefaultReplicaView
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/replica/ReplicaView.DefaultReplicaView.html#org.apache.kafka.common.replica.ReplicaView$DefaultReplicaView(org.apache.kafka.common.Node,long,long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Node"/></param>
            /// <param name="arg1"><see cref="long"/></param>
            /// <param name="arg2"><see cref="long"/></param>
            public DefaultReplicaView(Org.Apache.Kafka.Common.Node arg0, long arg1, long arg2)
                : base(arg0, arg1, arg2)
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/replica/ReplicaView.DefaultReplicaView.html#logEndOffset--"/>
            /// </summary>
            /// <returns><see cref="long"/></returns>
            public long LogEndOffset()
            {
                return IExecuteWithSignature<long>("logEndOffset", "()J");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/replica/ReplicaView.DefaultReplicaView.html#timeSinceLastCaughtUpMs--"/>
            /// </summary>
            /// <returns><see cref="long"/></returns>
            public long TimeSinceLastCaughtUpMs()
            {
                return IExecuteWithSignature<long>("timeSinceLastCaughtUpMs", "()J");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.1/org/apache/kafka/common/replica/ReplicaView.DefaultReplicaView.html#endpoint--"/>
            /// </summary>
            /// <returns><see cref="Org.Apache.Kafka.Common.Node"/></returns>
            public Org.Apache.Kafka.Common.Node Endpoint()
            {
                return IExecuteWithSignature<Org.Apache.Kafka.Common.Node>("endpoint", "()Lorg/apache/kafka/common/Node;");
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