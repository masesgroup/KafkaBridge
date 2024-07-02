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
*  using connect-transforms-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Transforms.Util
{
    #region Requirements
    public partial class Requirements
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.7.1/org/apache/kafka/connect/transforms/util/Requirements.html#requireMap-java.lang.Object-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public static Java.Util.Map<Java.Lang.String, object> RequireMap(object arg0, Java.Lang.String arg1)
        {
            return SExecute<Java.Util.Map<Java.Lang.String, object>>(LocalBridgeClazz, "requireMap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.7.1/org/apache/kafka/connect/transforms/util/Requirements.html#requireMapOrNull-java.lang.Object-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public static Java.Util.Map<Java.Lang.String, object> RequireMapOrNull(object arg0, Java.Lang.String arg1)
        {
            return SExecute<Java.Util.Map<Java.Lang.String, object>>(LocalBridgeClazz, "requireMapOrNull", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.7.1/org/apache/kafka/connect/transforms/util/Requirements.html#requireStruct-java.lang.Object-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Struct"/></returns>
        public static Org.Apache.Kafka.Connect.Data.Struct RequireStruct(object arg0, Java.Lang.String arg1)
        {
            return SExecute<Org.Apache.Kafka.Connect.Data.Struct>(LocalBridgeClazz, "requireStruct", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.7.1/org/apache/kafka/connect/transforms/util/Requirements.html#requireStructOrNull-java.lang.Object-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Struct"/></returns>
        public static Org.Apache.Kafka.Connect.Data.Struct RequireStructOrNull(object arg0, Java.Lang.String arg1)
        {
            return SExecute<Org.Apache.Kafka.Connect.Data.Struct>(LocalBridgeClazz, "requireStructOrNull", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.7.1/org/apache/kafka/connect/transforms/util/Requirements.html#requireSinkRecord-org.apache.kafka.connect.connector.ConnectRecord-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Connector.ConnectRecord"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Sink.SinkRecord"/></returns>
        public static Org.Apache.Kafka.Connect.Sink.SinkRecord RequireSinkRecord(Org.Apache.Kafka.Connect.Connector.ConnectRecord arg0, Java.Lang.String arg1)
        {
            return SExecute<Org.Apache.Kafka.Connect.Sink.SinkRecord>(LocalBridgeClazz, "requireSinkRecord", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.7.1/org/apache/kafka/connect/transforms/util/Requirements.html#requireSchema-org.apache.kafka.connect.data.Schema-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public static void RequireSchema(Org.Apache.Kafka.Connect.Data.Schema arg0, Java.Lang.String arg1)
        {
            SExecute(LocalBridgeClazz, "requireSchema", arg0, arg1);
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