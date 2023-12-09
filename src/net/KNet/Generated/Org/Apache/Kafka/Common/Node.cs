/*
*  Copyright 2023 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.1.0.0)
*  using kafka-clients-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common
{
    #region Node
    public partial class Node
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/Node.html#org.apache.kafka.common.Node(int,java.lang.String,int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        public Node(int arg0, string arg1, int arg2, string arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/Node.html#org.apache.kafka.common.Node(int,java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public Node(int arg0, string arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/Node.html#noNode--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Node"/></returns>
        public static Org.Apache.Kafka.Common.Node NoNode()
        {
            return SExecute<Org.Apache.Kafka.Common.Node>(LocalBridgeClazz, "noNode");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/Node.html#hasRack--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HasRack()
        {
            return IExecute<bool>("hasRack");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/Node.html#isEmpty--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecute<bool>("isEmpty");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/Node.html#id--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Id()
        {
            return IExecute<int>("id");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/Node.html#port--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Port()
        {
            return IExecute<int>("port");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/Node.html#host--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string Host()
        {
            return IExecute<string>("host");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/Node.html#idString--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string IdString()
        {
            return IExecute<string>("idString");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/Node.html#rack--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string Rack()
        {
            return IExecute<string>("rack");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}