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
*  using connect-api-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Source
{
    #region SourceConnector
    public partial class SourceConnector
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/source/SourceConnector.html#alterOffsets-java.util.Map-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AlterOffsets(Java.Util.Map<string, string> arg0, Java.Util.Map<Java.Util.Map<string, object>, Java.Util.Map<string, object>> arg1)
        {
            return IExecute<bool>("alterOffsets", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/source/SourceConnector.html#canDefineTransactionBoundaries-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Source.ConnectorTransactionBoundaries"/></returns>
        public Org.Apache.Kafka.Connect.Source.ConnectorTransactionBoundaries CanDefineTransactionBoundaries(Java.Util.Map<string, string> arg0)
        {
            return IExecute<Org.Apache.Kafka.Connect.Source.ConnectorTransactionBoundaries>("canDefineTransactionBoundaries", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.6.1/org/apache/kafka/connect/source/SourceConnector.html#exactlyOnceSupport-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Source.ExactlyOnceSupport"/></returns>
        public Org.Apache.Kafka.Connect.Source.ExactlyOnceSupport ExactlyOnceSupport(Java.Util.Map<string, string> arg0)
        {
            return IExecute<Org.Apache.Kafka.Connect.Source.ExactlyOnceSupport>("exactlyOnceSupport", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}