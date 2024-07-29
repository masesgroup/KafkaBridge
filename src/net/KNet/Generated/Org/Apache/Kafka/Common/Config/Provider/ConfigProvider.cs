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

namespace Org.Apache.Kafka.Common.Config.Provider
{
    #region IConfigProvider
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IConfigProvider
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ConfigProvider
    public partial class ConfigProvider : Org.Apache.Kafka.Common.Config.Provider.IConfigProvider, Org.Apache.Kafka.Common.IConfigurable, Java.Io.ICloseable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Common.Config.Provider.ConfigProvider"/> to <see cref="Org.Apache.Kafka.Common.Configurable"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Configurable(Org.Apache.Kafka.Common.Config.Provider.ConfigProvider t) => t.Cast<Org.Apache.Kafka.Common.Configurable>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Common.Config.Provider.ConfigProvider"/> to <see cref="Java.Io.Closeable"/>
        /// </summary>
        public static implicit operator Java.Io.Closeable(Org.Apache.Kafka.Common.Config.Provider.ConfigProvider t) => t.Cast<Java.Io.Closeable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/config/provider/ConfigProvider.html#get-java.lang.String-java.util.Set-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Config.ConfigData"/></returns>
        public Org.Apache.Kafka.Common.Config.ConfigData Get(Java.Lang.String arg0, Java.Util.Set<Java.Lang.String> arg1)
        {
            return IExecute<Org.Apache.Kafka.Common.Config.ConfigData>("get", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/config/provider/ConfigProvider.html#get-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Config.ConfigData"/></returns>
        public Org.Apache.Kafka.Common.Config.ConfigData Get(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Config.ConfigData>("get", "(Ljava/lang/String;)Lorg/apache/kafka/common/config/ConfigData;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/config/provider/ConfigProvider.html#subscribe-java.lang.String-java.util.Set-org.apache.kafka.common.config.ConfigChangeCallback-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Config.ConfigChangeCallback"/></param>
        public void Subscribe(Java.Lang.String arg0, Java.Util.Set<Java.Lang.String> arg1, Org.Apache.Kafka.Common.Config.ConfigChangeCallback arg2)
        {
            IExecute("subscribe", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/config/provider/ConfigProvider.html#unsubscribe-java.lang.String-java.util.Set-org.apache.kafka.common.config.ConfigChangeCallback-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Config.ConfigChangeCallback"/></param>
        public void Unsubscribe(Java.Lang.String arg0, Java.Util.Set<Java.Lang.String> arg1, Org.Apache.Kafka.Common.Config.ConfigChangeCallback arg2)
        {
            IExecute("unsubscribe", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/config/provider/ConfigProvider.html#unsubscribeAll--"/>
        /// </summary>
        public void UnsubscribeAll()
        {
            IExecuteWithSignature("unsubscribeAll", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}