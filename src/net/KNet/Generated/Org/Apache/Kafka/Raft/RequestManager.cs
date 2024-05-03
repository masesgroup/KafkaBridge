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
    #region RequestManager
    public partial class RequestManager
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/RequestManager.html#org.apache.kafka.raft.RequestManager(java.util.Set,int,int,java.util.Random)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Util.Random"/></param>
        public RequestManager(Java.Util.Set<Java.Lang.Integer> arg0, int arg1, int arg2, Java.Util.Random arg3)
            : base(arg0, arg1, arg2, arg3)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/RequestManager.html#findReadyVoter-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.OptionalInt"/></returns>
        public Java.Util.OptionalInt FindReadyVoter(long arg0)
        {
            return IExecuteWithSignature<Java.Util.OptionalInt>("findReadyVoter", "(J)Ljava/util/OptionalInt;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/RequestManager.html#backoffBeforeAvailableVoter-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long BackoffBeforeAvailableVoter(long arg0)
        {
            return IExecuteWithSignature<long>("backoffBeforeAvailableVoter", "(J)J", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/RequestManager.html#getOrCreate-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Raft.RequestManager.ConnectionState"/></returns>
        public Org.Apache.Kafka.Raft.RequestManager.ConnectionState GetOrCreate(int arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Raft.RequestManager.ConnectionState>("getOrCreate", "(I)Lorg/apache/kafka/raft/RequestManager$ConnectionState;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/RequestManager.html#resetAll--"/>
        /// </summary>
        public void ResetAll()
        {
            IExecuteWithSignature("resetAll", "()V");
        }

        #endregion

        #region Nested classes
        #region ConnectionState
        public partial class ConnectionState
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/RequestManager.ConnectionState.html#org.apache.kafka.raft.RequestManager$ConnectionState(org.apache.kafka.raft.RequestManager,long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Raft.RequestManager"/></param>
            /// <param name="arg1"><see cref="long"/></param>
            public ConnectionState(Org.Apache.Kafka.Raft.RequestManager arg0, long arg1)
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.6.2/org/apache/kafka/raft/RequestManager.ConnectionState.html#id--"/>
            /// </summary>

            /// <returns><see cref="long"/></returns>
            public long Id()
            {
                return IExecuteWithSignature<long>("id", "()J");
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