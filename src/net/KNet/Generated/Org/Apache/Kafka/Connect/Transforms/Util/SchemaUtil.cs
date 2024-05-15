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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*  using connect-transforms-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Transforms.Util
{
    #region SchemaUtil
    public partial class SchemaUtil
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.7.0/org/apache/kafka/connect/transforms/util/SchemaUtil.html#copySchemaBasics-org.apache.kafka.connect.data.Schema-org.apache.kafka.connect.data.SchemaBuilder-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public static Org.Apache.Kafka.Connect.Data.SchemaBuilder CopySchemaBasics(Org.Apache.Kafka.Connect.Data.Schema arg0, Org.Apache.Kafka.Connect.Data.SchemaBuilder arg1)
        {
            return SExecute<Org.Apache.Kafka.Connect.Data.SchemaBuilder>(LocalBridgeClazz, "copySchemaBasics", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.7.0/org/apache/kafka/connect/transforms/util/SchemaUtil.html#copySchemaBasics-org.apache.kafka.connect.data.Schema-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaBuilder"/></returns>
        public static Org.Apache.Kafka.Connect.Data.SchemaBuilder CopySchemaBasics(Org.Apache.Kafka.Connect.Data.Schema arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Connect.Data.SchemaBuilder>(LocalBridgeClazz, "copySchemaBasics", "(Lorg/apache/kafka/connect/data/Schema;)Lorg/apache/kafka/connect/data/SchemaBuilder;", arg0);
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