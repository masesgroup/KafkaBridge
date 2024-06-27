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
*  using kafka-tools-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Tools
{
    #region ToolsUtils
    public partial class ToolsUtils
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/ToolsUtils.html#duplicates-java.util.List-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set<T> Duplicates<T>(Java.Util.List<T> arg0)
        {
            return SExecuteWithSignature<Java.Util.Set<T>>(LocalBridgeClazz, "duplicates", "(Ljava/util/List;)Ljava/util/Set;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/ToolsUtils.html#prettyPrintTable-java.util.List-java.util.List-java.io.PrintStream-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        /// <param name="arg2"><see cref="Java.Io.PrintStream"/></param>
        public static void PrettyPrintTable(Java.Util.List<Java.Lang.String> arg0, Java.Util.List<Java.Util.List<Java.Lang.String>> arg1, Java.Io.PrintStream arg2)
        {
            SExecute(LocalBridgeClazz, "prettyPrintTable", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/ToolsUtils.html#printMetrics-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <typeparam name="Arg0ExtendsOrg_Apache_Kafka_Common_Metric"><see cref="Org.Apache.Kafka.Common.Metric"/></typeparam>
        public static void PrintMetrics<Arg0ExtendsOrg_Apache_Kafka_Common_Metric>(Java.Util.Map<Org.Apache.Kafka.Common.MetricName, Arg0ExtendsOrg_Apache_Kafka_Common_Metric> arg0) where Arg0ExtendsOrg_Apache_Kafka_Common_Metric : Org.Apache.Kafka.Common.Metric
        {
            SExecuteWithSignature(LocalBridgeClazz, "printMetrics", "(Ljava/util/Map;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/ToolsUtils.html#validateBootstrapServer-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public static void ValidateBootstrapServer(Java.Lang.String arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "validateBootstrapServer", "(Ljava/lang/String;)V", arg0);
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