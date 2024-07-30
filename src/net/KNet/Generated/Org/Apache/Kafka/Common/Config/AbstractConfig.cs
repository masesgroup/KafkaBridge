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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using kafka-clients-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Config
{
    #region AbstractConfig
    public partial class AbstractConfig
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/config/AbstractConfig.html#org.apache.kafka.common.config.AbstractConfig(org.apache.kafka.common.config.ConfigDef,java.util.Map,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Config.ConfigDef"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public AbstractConfig(Org.Apache.Kafka.Common.Config.ConfigDef arg0, Java.Util.Map<object, object> arg1, bool arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/config/AbstractConfig.html#org.apache.kafka.common.config.AbstractConfig(org.apache.kafka.common.config.ConfigDef,java.util.Map,java.util.Map,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Config.ConfigDef"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <param name="arg2"><see cref="Java.Util.Map"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        public AbstractConfig(Org.Apache.Kafka.Common.Config.ConfigDef arg0, Java.Util.Map<object, object> arg1, Java.Util.Map<Java.Lang.String, object> arg2, bool arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/config/AbstractConfig.html#org.apache.kafka.common.config.AbstractConfig(org.apache.kafka.common.config.ConfigDef,java.util.Map)"/>
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/config/AbstractConfig.html#AUTOMATIC_CONFIG_PROVIDERS_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String AUTOMATIC_CONFIG_PROVIDERS_PROPERTY { get { if (!_AUTOMATIC_CONFIG_PROVIDERS_PROPERTYReady) { _AUTOMATIC_CONFIG_PROVIDERS_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "AUTOMATIC_CONFIG_PROVIDERS_PROPERTY"); _AUTOMATIC_CONFIG_PROVIDERS_PROPERTYReady = true; } return _AUTOMATIC_CONFIG_PROVIDERS_PROPERTYContent; } }
        private static Java.Lang.String _AUTOMATIC_CONFIG_PROVIDERS_PROPERTYContent = default;
        private static bool _AUTOMATIC_CONFIG_PROVIDERS_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/config/AbstractConfig.html#CONFIG_PROVIDERS_CONFIG"/>
        /// </summary>
        public static Java.Lang.String CONFIG_PROVIDERS_CONFIG { get { if (!_CONFIG_PROVIDERS_CONFIGReady) { _CONFIG_PROVIDERS_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CONFIG_PROVIDERS_CONFIG"); _CONFIG_PROVIDERS_CONFIGReady = true; } return _CONFIG_PROVIDERS_CONFIGContent; } }
        private static Java.Lang.String _CONFIG_PROVIDERS_CONFIGContent = default;
        private static bool _CONFIG_PROVIDERS_CONFIGReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/config/AbstractConfig.html#getConfiguredInstances-java.lang.String-java.lang.Class-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg2"><see cref="Java.Util.Map"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<T> GetConfiguredInstances<T>(Java.Lang.String arg0, Java.Lang.Class arg1, Java.Util.Map<Java.Lang.String, object> arg2)
        {
            return IExecute<Java.Util.List<T>>("getConfiguredInstances", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/config/AbstractConfig.html#getConfiguredInstances-java.lang.String-java.lang.Class-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<T> GetConfiguredInstances<T>(Java.Lang.String arg0, Java.Lang.Class arg1)
        {
            return IExecute<Java.Util.List<T>>("getConfiguredInstances", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/config/AbstractConfig.html#getConfiguredInstances-java.util.List-java.lang.Class-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg2"><see cref="Java.Util.Map"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<T> GetConfiguredInstances<T>(Java.Util.List<Java.Lang.String> arg0, Java.Lang.Class arg1, Java.Util.Map<Java.Lang.String, object> arg2)
        {
            return IExecute<Java.Util.List<T>>("getConfiguredInstances", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/config/AbstractConfig.html#getConfiguredInstance-java.lang.String-java.lang.Class-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg2"><see cref="Java.Util.Map"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T GetConfiguredInstance<T>(Java.Lang.String arg0, Java.Lang.Class arg1, Java.Util.Map<Java.Lang.String, object> arg2)
        {
            return IExecute<T>("getConfiguredInstance", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/config/AbstractConfig.html#getConfiguredInstance-java.lang.String-java.lang.Class-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T GetConfiguredInstance<T>(Java.Lang.String arg0, Java.Lang.Class arg1)
        {
            return IExecute<T>("getConfiguredInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/config/AbstractConfig.html#getBoolean-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Boolean"/></returns>
        public Java.Lang.Boolean GetBoolean(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.Boolean>("getBoolean", "(Ljava/lang/String;)Ljava/lang/Boolean;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/config/AbstractConfig.html#getClass-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        public Java.Lang.Class GetClass(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.Class>("getClass", "(Ljava/lang/String;)Ljava/lang/Class;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/config/AbstractConfig.html#getDouble-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Double"/></returns>
        public Java.Lang.Double GetDouble(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.Double>("getDouble", "(Ljava/lang/String;)Ljava/lang/Double;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/config/AbstractConfig.html#getInt-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        public Java.Lang.Integer GetInt(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.Integer>("getInt", "(Ljava/lang/String;)Ljava/lang/Integer;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/config/AbstractConfig.html#getLong-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Long"/></returns>
        public Java.Lang.Long GetLong(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.Long>("getLong", "(Ljava/lang/String;)Ljava/lang/Long;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/config/AbstractConfig.html#getShort-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Short"/></returns>
        public Java.Lang.Short GetShort(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.Short>("getShort", "(Ljava/lang/String;)Ljava/lang/Short;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/config/AbstractConfig.html#documentationOf-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String DocumentationOf(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("documentationOf", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/config/AbstractConfig.html#getString-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetString(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getString", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/config/AbstractConfig.html#getList-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Lang.String> GetList(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.List<Java.Lang.String>>("getList", "(Ljava/lang/String;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/config/AbstractConfig.html#nonInternalValues--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, object> NonInternalValues()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, object>>("nonInternalValues", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/config/AbstractConfig.html#values--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, object> Values()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, object>>("values", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/config/AbstractConfig.html#originals--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, object> Originals()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, object>>("originals", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/config/AbstractConfig.html#originals-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, object> Originals(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, object>>("originals", "(Ljava/util/Map;)Ljava/util/Map;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/config/AbstractConfig.html#originalsWithPrefix-java.lang.String-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, object> OriginalsWithPrefix(Java.Lang.String arg0, bool arg1)
        {
            return IExecute<Java.Util.Map<Java.Lang.String, object>>("originalsWithPrefix", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/config/AbstractConfig.html#originalsWithPrefix-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, object> OriginalsWithPrefix(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, object>>("originalsWithPrefix", "(Ljava/lang/String;)Ljava/util/Map;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/config/AbstractConfig.html#valuesWithPrefixAllOrNothing-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, object> ValuesWithPrefixAllOrNothing(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, object>>("valuesWithPrefixAllOrNothing", "(Ljava/lang/String;)Ljava/util/Map;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/config/AbstractConfig.html#valuesWithPrefixOverride-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, object> ValuesWithPrefixOverride(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, object>>("valuesWithPrefixOverride", "(Ljava/lang/String;)Ljava/util/Map;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/config/AbstractConfig.html#originalsStrings--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, Java.Lang.String> OriginalsStrings()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Lang.String>>("originalsStrings", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/config/AbstractConfig.html#unused--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> Unused()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("unused", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/config/AbstractConfig.html#typeOf-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Config.ConfigDef.Type"/></returns>
        public Org.Apache.Kafka.Common.Config.ConfigDef.Type TypeOf(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Config.ConfigDef.Type>("typeOf", "(Ljava/lang/String;)Lorg/apache/kafka/common/config/ConfigDef$Type;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/config/AbstractConfig.html#getPassword-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Config.Types.Password"/></returns>
        public Org.Apache.Kafka.Common.Config.Types.Password GetPassword(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Config.Types.Password>("getPassword", "(Ljava/lang/String;)Lorg/apache/kafka/common/config/types/Password;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/config/AbstractConfig.html#ignore-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void Ignore(Java.Lang.String arg0)
        {
            IExecuteWithSignature("ignore", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/common/config/AbstractConfig.html#logUnused--"/>
        /// </summary>
        public void LogUnused()
        {
            IExecuteWithSignature("logUnused", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}