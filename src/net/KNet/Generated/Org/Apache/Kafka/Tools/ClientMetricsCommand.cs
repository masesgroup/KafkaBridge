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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using kafka-tools-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Tools
{
    #region ClientMetricsCommand
    public partial class ClientMetricsCommand
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/ClientMetricsCommand.html#main-java.lang.String[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public static void Main(params Java.Lang.String[] arg0)
        {
            if (arg0.Length == 0) SExecuteWithSignature(LocalBridgeClazz, "main", "([Ljava/lang/String;)V"); else SExecuteWithSignature(LocalBridgeClazz, "main", "([Ljava/lang/String;)V", arg0);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region ClientMetricsCommandOptions
        public partial class ClientMetricsCommandOptions
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/ClientMetricsCommand.ClientMetricsCommandOptions.html#org.apache.kafka.tools.ClientMetricsCommand$ClientMetricsCommandOptions(java.lang.String[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            public ClientMetricsCommandOptions(Java.Lang.String[] arg0)
                : base(arg0)
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/ClientMetricsCommand.ClientMetricsCommandOptions.html#hasAlterOption--"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool HasAlterOption()
            {
                return IExecuteWithSignature<bool>("hasAlterOption", "()Z");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/ClientMetricsCommand.ClientMetricsCommandOptions.html#hasDeleteOption--"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool HasDeleteOption()
            {
                return IExecuteWithSignature<bool>("hasDeleteOption", "()Z");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/ClientMetricsCommand.ClientMetricsCommandOptions.html#hasDescribeOption--"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool HasDescribeOption()
            {
                return IExecuteWithSignature<bool>("hasDescribeOption", "()Z");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/ClientMetricsCommand.ClientMetricsCommandOptions.html#hasGenerateNameOption--"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool HasGenerateNameOption()
            {
                return IExecuteWithSignature<bool>("hasGenerateNameOption", "()Z");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/ClientMetricsCommand.ClientMetricsCommandOptions.html#hasListOption--"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool HasListOption()
            {
                return IExecuteWithSignature<bool>("hasListOption", "()Z");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/ClientMetricsCommand.ClientMetricsCommandOptions.html#bootstrapServer--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String BootstrapServer()
            {
                return IExecuteWithSignature<Java.Lang.String>("bootstrapServer", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/ClientMetricsCommand.ClientMetricsCommandOptions.html#interval--"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Optional"/></returns>
            public Java.Util.Optional<Java.Lang.Integer> Interval()
            {
                return IExecuteWithSignature<Java.Util.Optional<Java.Lang.Integer>>("interval", "()Ljava/util/Optional;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/ClientMetricsCommand.ClientMetricsCommandOptions.html#name--"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Optional"/></returns>
            public Java.Util.Optional<Java.Lang.String> Name()
            {
                return IExecuteWithSignature<Java.Util.Optional<Java.Lang.String>>("name", "()Ljava/util/Optional;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/ClientMetricsCommand.ClientMetricsCommandOptions.html#match--"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Optional"/></returns>
            public Java.Util.Optional<Java.Util.List<Java.Lang.String>> Match()
            {
                return IExecuteWithSignature<Java.Util.Optional<Java.Util.List<Java.Lang.String>>>("match", "()Ljava/util/Optional;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/ClientMetricsCommand.ClientMetricsCommandOptions.html#metrics--"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Optional"/></returns>
            public Java.Util.Optional<Java.Util.List<Java.Lang.String>> Metrics()
            {
                return IExecuteWithSignature<Java.Util.Optional<Java.Util.List<Java.Lang.String>>>("metrics", "()Ljava/util/Optional;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/ClientMetricsCommand.ClientMetricsCommandOptions.html#commandConfig--"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Properties"/></returns>
            /// <exception cref="Java.Io.IOException"/>
            public Java.Util.Properties CommandConfig()
            {
                return IExecuteWithSignature<Java.Util.Properties>("commandConfig", "()Ljava/util/Properties;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/ClientMetricsCommand.ClientMetricsCommandOptions.html#checkArgs--"/>
            /// </summary>
            public void CheckArgs()
            {
                IExecuteWithSignature("checkArgs", "()V");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ClientMetricsService
        public partial class ClientMetricsService
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/ClientMetricsCommand.ClientMetricsService.html#org.apache.kafka.tools.ClientMetricsCommand$ClientMetricsService(java.util.Properties)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Properties"/></param>
            public ClientMetricsService(Java.Util.Properties arg0)
                : base(arg0)
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/ClientMetricsCommand.ClientMetricsService.html#alterClientMetrics-org.apache.kafka.tools.ClientMetricsCommand.ClientMetricsCommandOptions-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Tools.ClientMetricsCommand.ClientMetricsCommandOptions"/></param>
            /// <exception cref="Java.Lang.Exception"/>
            public void AlterClientMetrics(Org.Apache.Kafka.Tools.ClientMetricsCommand.ClientMetricsCommandOptions arg0)
            {
                IExecuteWithSignature("alterClientMetrics", "(Lorg/apache/kafka/tools/ClientMetricsCommand$ClientMetricsCommandOptions;)V", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/ClientMetricsCommand.ClientMetricsService.html#close--"/>
            /// </summary>
            /// <exception cref="Java.Lang.Exception"/>
            public void Close()
            {
                IExecuteWithSignature("close", "()V");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/ClientMetricsCommand.ClientMetricsService.html#deleteClientMetrics-org.apache.kafka.tools.ClientMetricsCommand.ClientMetricsCommandOptions-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Tools.ClientMetricsCommand.ClientMetricsCommandOptions"/></param>
            /// <exception cref="Java.Lang.Exception"/>
            public void DeleteClientMetrics(Org.Apache.Kafka.Tools.ClientMetricsCommand.ClientMetricsCommandOptions arg0)
            {
                IExecuteWithSignature("deleteClientMetrics", "(Lorg/apache/kafka/tools/ClientMetricsCommand$ClientMetricsCommandOptions;)V", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/ClientMetricsCommand.ClientMetricsService.html#describeClientMetrics-org.apache.kafka.tools.ClientMetricsCommand.ClientMetricsCommandOptions-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Tools.ClientMetricsCommand.ClientMetricsCommandOptions"/></param>
            /// <exception cref="Java.Lang.Exception"/>
            public void DescribeClientMetrics(Org.Apache.Kafka.Tools.ClientMetricsCommand.ClientMetricsCommandOptions arg0)
            {
                IExecuteWithSignature("describeClientMetrics", "(Lorg/apache/kafka/tools/ClientMetricsCommand$ClientMetricsCommandOptions;)V", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/ClientMetricsCommand.ClientMetricsService.html#listClientMetrics-org.apache.kafka.tools.ClientMetricsCommand.ClientMetricsCommandOptions-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Tools.ClientMetricsCommand.ClientMetricsCommandOptions"/></param>
            /// <exception cref="Java.Lang.Exception"/>
            public void ListClientMetrics(Org.Apache.Kafka.Tools.ClientMetricsCommand.ClientMetricsCommandOptions arg0)
            {
                IExecuteWithSignature("listClientMetrics", "(Lorg/apache/kafka/tools/ClientMetricsCommand$ClientMetricsCommandOptions;)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}