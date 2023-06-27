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
*  This file is generated by MASES.JNetReflector (ver. 2.0.0.0)
*  using kafka-clients-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common
{
    #region MetricName
    public partial class MetricName
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/MetricName.html#%3Cinit%3E(java.lang.String,java.lang.String,java.lang.String,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="Java.Util.Map"/></param>
        public MetricName(string arg0, string arg1, string arg2, Java.Util.Map<string, string> arg3)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/MetricName.html#description()"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string Description()
        {
            return IExecute<string>("description");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/MetricName.html#group()"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string Group()
        {
            return IExecute<string>("group");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/MetricName.html#name()"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string Name()
        {
            return IExecute<string>("name");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/MetricName.html#tags()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<string, string> Tags()
        {
            return IExecute<Java.Util.Map<string, string>>("tags");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}