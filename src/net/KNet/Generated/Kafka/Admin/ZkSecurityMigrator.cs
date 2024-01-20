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
*  This file is generated by MASES.JNetReflector (ver. 2.2.1.0)
*  using kafka_2.13-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Kafka.Admin
{
    #region ZkSecurityMigrator
    public partial class ZkSecurityMigrator
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.1/kafka/admin/ZkSecurityMigrator.html#tlsConfigFileOption--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public static string TlsConfigFileOption()
        {
            return SExecute<string>(LocalBridgeClazz, "tlsConfigFileOption");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.1/kafka/admin/ZkSecurityMigrator.html#usageMessage--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public static string UsageMessage()
        {
            return SExecute<string>(LocalBridgeClazz, "usageMessage");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.1/kafka/admin/ZkSecurityMigrator.html#main-java.lang.String[]-"/>
        /// </summary>
        /// <param name="args"><see cref="string"/></param>
        public static void Main(string[] args)
        {
            SExecute(LocalBridgeClazz, "main", new object[] { args });
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.1/kafka/admin/ZkSecurityMigrator.html#run-java.lang.String[]-"/>
        /// </summary>
        /// <param name="args"><see cref="string"/></param>
        public static void Run(string[] args)
        {
            SExecute(LocalBridgeClazz, "run", new object[] { args });
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.1/kafka/admin/ZkSecurityMigrator.html#isDebugEnabled--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsDebugEnabled()
        {
            return IExecute<bool>("isDebugEnabled");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.1/kafka/admin/ZkSecurityMigrator.html#isTraceEnabled--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsTraceEnabled()
        {
            return IExecute<bool>("isTraceEnabled");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.1/kafka/admin/ZkSecurityMigrator.html#loggerName--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string LoggerName()
        {
            return IExecute<string>("loggerName");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.1/kafka/admin/ZkSecurityMigrator.html#logIdent--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string LogIdent()
        {
            return IExecute<string>("logIdent");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.1/kafka/admin/ZkSecurityMigrator.html#msgWithLogIdent-java.lang.String-"/>
        /// </summary>
        /// <param name="msg"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string MsgWithLogIdent(string msg)
        {
            return IExecute<string>("msgWithLogIdent", msg);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}