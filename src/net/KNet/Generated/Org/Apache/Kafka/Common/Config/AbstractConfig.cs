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
*  using kafka-clients-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Config
{
    #region AbstractConfig
    public partial class AbstractConfig
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/AbstractConfig.html#org.apache.kafka.common.config.AbstractConfig(org.apache.kafka.common.config.ConfigDef,java.util.Map,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Config.ConfigDef"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public AbstractConfig(Org.Apache.Kafka.Common.Config.ConfigDef arg0, Java.Util.Map<object, object> arg1, bool arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/AbstractConfig.html#org.apache.kafka.common.config.AbstractConfig(org.apache.kafka.common.config.ConfigDef,java.util.Map,java.util.Map,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Config.ConfigDef"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <param name="arg2"><see cref="Java.Util.Map"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        public AbstractConfig(Org.Apache.Kafka.Common.Config.ConfigDef arg0, Java.Util.Map<object, object> arg1, Java.Util.Map<string, object> arg2, bool arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/AbstractConfig.html#org.apache.kafka.common.config.AbstractConfig(org.apache.kafka.common.config.ConfigDef,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Config.ConfigDef"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        public AbstractConfig(Org.Apache.Kafka.Common.Config.ConfigDef arg0, Java.Util.Map<object, object> arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/AbstractConfig.html#CONFIG_PROVIDERS_CONFIG"/>
        /// </summary>
        public static string CONFIG_PROVIDERS_CONFIG { get { return SGetField<string>(LocalBridgeClazz, "CONFIG_PROVIDERS_CONFIG"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/AbstractConfig.html#getConfiguredInstances-java.lang.String-java.lang.Class-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg2"><see cref="Java.Util.Map"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<T> GetConfiguredInstances<T>(string arg0, Java.Lang.Class arg1, Java.Util.Map<string, object> arg2)
        {
            return IExecute<Java.Util.List<T>>("getConfiguredInstances", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/AbstractConfig.html#getConfiguredInstances-java.lang.String-java.lang.Class-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<T> GetConfiguredInstances<T>(string arg0, Java.Lang.Class arg1)
        {
            return IExecute<Java.Util.List<T>>("getConfiguredInstances", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/AbstractConfig.html#getConfiguredInstances-java.util.List-java.lang.Class-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg2"><see cref="Java.Util.Map"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<T> GetConfiguredInstances<T>(Java.Util.List<string> arg0, Java.Lang.Class arg1, Java.Util.Map<string, object> arg2)
        {
            return IExecute<Java.Util.List<T>>("getConfiguredInstances", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/AbstractConfig.html#getConfiguredInstance-java.lang.String-java.lang.Class-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg2"><see cref="Java.Util.Map"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T GetConfiguredInstance<T>(string arg0, Java.Lang.Class arg1, Java.Util.Map<string, object> arg2)
        {
            return IExecute<T>("getConfiguredInstance", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/AbstractConfig.html#getConfiguredInstance-java.lang.String-java.lang.Class-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T GetConfiguredInstance<T>(string arg0, Java.Lang.Class arg1)
        {
            return IExecute<T>("getConfiguredInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/AbstractConfig.html#getBoolean-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Lang.Boolean"/></returns>
        public Java.Lang.Boolean GetBoolean(string arg0)
        {
            return IExecute<Java.Lang.Boolean>("getBoolean", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/AbstractConfig.html#getClass-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        public Java.Lang.Class GetClass(string arg0)
        {
            return IExecute<Java.Lang.Class>("getClass", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/AbstractConfig.html#getDouble-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Lang.Double"/></returns>
        public Java.Lang.Double GetDouble(string arg0)
        {
            return IExecute<Java.Lang.Double>("getDouble", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/AbstractConfig.html#getInt-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        public Java.Lang.Integer GetInt(string arg0)
        {
            return IExecute<Java.Lang.Integer>("getInt", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/AbstractConfig.html#getLong-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Lang.Long"/></returns>
        public Java.Lang.Long GetLong(string arg0)
        {
            return IExecute<Java.Lang.Long>("getLong", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/AbstractConfig.html#getShort-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Lang.Short"/></returns>
        public Java.Lang.Short GetShort(string arg0)
        {
            return IExecute<Java.Lang.Short>("getShort", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/AbstractConfig.html#documentationOf-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string DocumentationOf(string arg0)
        {
            return IExecute<string>("documentationOf", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/AbstractConfig.html#getString-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetString(string arg0)
        {
            return IExecute<string>("getString", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/AbstractConfig.html#getList-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<string> GetList(string arg0)
        {
            return IExecute<Java.Util.List<string>>("getList", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/AbstractConfig.html#nonInternalValues--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<string, object> NonInternalValues()
        {
            return IExecute<Java.Util.Map<string, object>>("nonInternalValues");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/AbstractConfig.html#values--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<string, object> Values()
        {
            return IExecute<Java.Util.Map<string, object>>("values");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/AbstractConfig.html#originals--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<string, object> Originals()
        {
            return IExecute<Java.Util.Map<string, object>>("originals");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/AbstractConfig.html#originals-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<string, object> Originals(Java.Util.Map<string, object> arg0)
        {
            return IExecute<Java.Util.Map<string, object>>("originals", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/AbstractConfig.html#originalsWithPrefix-java.lang.String-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<string, object> OriginalsWithPrefix(string arg0, bool arg1)
        {
            return IExecute<Java.Util.Map<string, object>>("originalsWithPrefix", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/AbstractConfig.html#originalsWithPrefix-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<string, object> OriginalsWithPrefix(string arg0)
        {
            return IExecute<Java.Util.Map<string, object>>("originalsWithPrefix", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/AbstractConfig.html#valuesWithPrefixAllOrNothing-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<string, object> ValuesWithPrefixAllOrNothing(string arg0)
        {
            return IExecute<Java.Util.Map<string, object>>("valuesWithPrefixAllOrNothing", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/AbstractConfig.html#valuesWithPrefixOverride-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<string, object> ValuesWithPrefixOverride(string arg0)
        {
            return IExecute<Java.Util.Map<string, object>>("valuesWithPrefixOverride", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/AbstractConfig.html#originalsStrings--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<string, string> OriginalsStrings()
        {
            return IExecute<Java.Util.Map<string, string>>("originalsStrings");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/AbstractConfig.html#unused--"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<string> Unused()
        {
            return IExecute<Java.Util.Set<string>>("unused");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/AbstractConfig.html#typeOf-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Config.ConfigDef.Type"/></returns>
        public Org.Apache.Kafka.Common.Config.ConfigDef.Type TypeOf(string arg0)
        {
            return IExecute<Org.Apache.Kafka.Common.Config.ConfigDef.Type>("typeOf", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/AbstractConfig.html#getPassword-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Config.Types.Password"/></returns>
        public Org.Apache.Kafka.Common.Config.Types.Password GetPassword(string arg0)
        {
            return IExecute<Org.Apache.Kafka.Common.Config.Types.Password>("getPassword", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/AbstractConfig.html#ignore-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public void Ignore(string arg0)
        {
            IExecute("ignore", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/config/AbstractConfig.html#logUnused--"/>
        /// </summary>
        public void LogUnused()
        {
            IExecute("logUnused");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}