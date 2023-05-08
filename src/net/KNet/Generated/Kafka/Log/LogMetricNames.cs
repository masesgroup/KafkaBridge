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
*  using kafka_2.13-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Kafka.Log
{
    #region LogMetricNames
    public partial class LogMetricNames
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/LogMetricNames.html#LogEndOffset()"/> 
        /// </summary>
        public static string LogEndOffset
        {
            get { return SExecute<string>(LocalBridgeClazz, "LogEndOffset"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/LogMetricNames.html#LogStartOffset()"/> 
        /// </summary>
        public static string LogStartOffset
        {
            get { return SExecute<string>(LocalBridgeClazz, "LogStartOffset"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/LogMetricNames.html#NumLogSegments()"/> 
        /// </summary>
        public static string NumLogSegments
        {
            get { return SExecute<string>(LocalBridgeClazz, "NumLogSegments"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/LogMetricNames.html#Size()"/> 
        /// </summary>
        public static string Size
        {
            get { return SExecute<string>(LocalBridgeClazz, "Size"); }
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