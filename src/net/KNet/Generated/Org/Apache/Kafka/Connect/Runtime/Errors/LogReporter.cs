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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using connect-runtime-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Runtime.Errors
{
    #region LogReporter
    public partial class LogReporter
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-runtime/3.4.0/org/apache/kafka/connect/runtime/errors/LogReporter.html#%3Cinit%3E(org.apache.kafka.connect.util.ConnectorTaskId,org.apache.kafka.connect.runtime.ConnectorConfig,org.apache.kafka.connect.runtime.errors.ErrorHandlingMetrics)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Util.ConnectorTaskId"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Connect.Runtime.ConnectorConfig"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Connect.Runtime.Errors.ErrorHandlingMetrics"/></param>
        public LogReporter(Org.Apache.Kafka.Connect.Util.ConnectorTaskId arg0, Org.Apache.Kafka.Connect.Runtime.ConnectorConfig arg1, Org.Apache.Kafka.Connect.Runtime.Errors.ErrorHandlingMetrics arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Runtime.Errors.LogReporter"/> to <see cref="Org.Apache.Kafka.Connect.Runtime.Errors.ErrorReporter"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Connect.Runtime.Errors.ErrorReporter(Org.Apache.Kafka.Connect.Runtime.Errors.LogReporter t) => t.Cast<Org.Apache.Kafka.Connect.Runtime.Errors.ErrorReporter>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}