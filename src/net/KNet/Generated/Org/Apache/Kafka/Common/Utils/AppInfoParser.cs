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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using kafka-clients-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Utils
{
    #region AppInfoParser
    public partial class AppInfoParser
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/utils/AppInfoParser.html#getCommitId--"/> 
        /// </summary>
        public static Java.Lang.String CommitId
        {
            get { return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "getCommitId", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/utils/AppInfoParser.html#getVersion--"/> 
        /// </summary>
        public static Java.Lang.String Version
        {
            get { return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "getVersion", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/utils/AppInfoParser.html#registerAppInfo-java.lang.String-java.lang.String-org.apache.kafka.common.metrics.Metrics-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Metrics.Metrics"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        public static void RegisterAppInfo(Java.Lang.String arg0, Java.Lang.String arg1, Org.Apache.Kafka.Common.Metrics.Metrics arg2, long arg3)
        {
            SExecute(LocalBridgeClazz, "registerAppInfo", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/utils/AppInfoParser.html#unregisterAppInfo-java.lang.String-java.lang.String-org.apache.kafka.common.metrics.Metrics-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Metrics.Metrics"/></param>
        public static void UnregisterAppInfo(Java.Lang.String arg0, Java.Lang.String arg1, Org.Apache.Kafka.Common.Metrics.Metrics arg2)
        {
            SExecute(LocalBridgeClazz, "unregisterAppInfo", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region AppInfo
        public partial class AppInfo
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/utils/AppInfoParser.AppInfo.html#org.apache.kafka.common.utils.AppInfoParser$AppInfo(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            public AppInfo(long arg0)
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/utils/AppInfoParser.AppInfo.html#getCommitId--"/> 
            /// </summary>
            public Java.Lang.String CommitId
            {
                get { return IExecuteWithSignature<Java.Lang.String>("getCommitId", "()Ljava/lang/String;"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/utils/AppInfoParser.AppInfo.html#getStartTimeMs--"/> 
            /// </summary>
            public Java.Lang.Long StartTimeMs
            {
                get { return IExecuteWithSignature<Java.Lang.Long>("getStartTimeMs", "()Ljava/lang/Long;"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/utils/AppInfoParser.AppInfo.html#getVersion--"/> 
            /// </summary>
            public Java.Lang.String Version
            {
                get { return IExecuteWithSignature<Java.Lang.String>("getVersion", "()Ljava/lang/String;"); }
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region AppInfoMBean
        public partial class AppInfoMBean
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/utils/AppInfoParser.AppInfoMBean.html#getCommitId--"/> 
            /// </summary>
            public Java.Lang.String CommitId
            {
                get { return IExecuteWithSignature<Java.Lang.String>("getCommitId", "()Ljava/lang/String;"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/utils/AppInfoParser.AppInfoMBean.html#getStartTimeMs--"/> 
            /// </summary>
            public Java.Lang.Long StartTimeMs
            {
                get { return IExecuteWithSignature<Java.Lang.Long>("getStartTimeMs", "()Ljava/lang/Long;"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/utils/AppInfoParser.AppInfoMBean.html#getVersion--"/> 
            /// </summary>
            public Java.Lang.String Version
            {
                get { return IExecuteWithSignature<Java.Lang.String>("getVersion", "()Ljava/lang/String;"); }
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