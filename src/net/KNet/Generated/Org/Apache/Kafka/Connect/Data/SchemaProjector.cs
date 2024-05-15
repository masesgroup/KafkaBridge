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
*  using connect-api-3.6.2.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Data
{
    #region SchemaProjector
    public partial class SchemaProjector
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.2/org/apache/kafka/connect/data/SchemaProjector.html#project-org.apache.kafka.connect.data.Schema-java.lang.Object-org.apache.kafka.connect.data.Schema-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Org.Apache.Kafka.Connect.Errors.SchemaProjectorException"/>
        public static object Project(Org.Apache.Kafka.Connect.Data.Schema arg0, object arg1, Org.Apache.Kafka.Connect.Data.Schema arg2)
        {
            return SExecute(LocalBridgeClazz, "project", arg0, arg1, arg2);
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