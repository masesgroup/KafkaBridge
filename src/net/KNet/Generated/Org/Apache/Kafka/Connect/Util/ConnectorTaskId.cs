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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using connect-runtime-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Util
{
    #region ConnectorTaskId
    public partial class ConnectorTaskId : Java.Io.ISerializable, Java.Lang.IComparable<Org.Apache.Kafka.Connect.Util.ConnectorTaskId>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.1/org/apache/kafka/connect/util/ConnectorTaskId.html#org.apache.kafka.connect.util.ConnectorTaskId(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public ConnectorTaskId(Java.Lang.String arg0, int arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Util.ConnectorTaskId"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Org.Apache.Kafka.Connect.Util.ConnectorTaskId t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Util.ConnectorTaskId"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Org.Apache.Kafka.Connect.Util.ConnectorTaskId t) => t.Cast<Java.Lang.Comparable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.1/org/apache/kafka/connect/util/ConnectorTaskId.html#compareTo-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.1/org/apache/kafka/connect/util/ConnectorTaskId.html#compareTo-org.apache.kafka.connect.util.ConnectorTaskId-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Util.ConnectorTaskId"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Org.Apache.Kafka.Connect.Util.ConnectorTaskId arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Lorg/apache/kafka/connect/util/ConnectorTaskId;)I", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.1/org/apache/kafka/connect/util/ConnectorTaskId.html#task--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Task()
        {
            return IExecuteWithSignature<int>("task", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-runtime/3.7.1/org/apache/kafka/connect/util/ConnectorTaskId.html#connector--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Connector()
        {
            return IExecuteWithSignature<Java.Lang.String>("connector", "()Ljava/lang/String;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}