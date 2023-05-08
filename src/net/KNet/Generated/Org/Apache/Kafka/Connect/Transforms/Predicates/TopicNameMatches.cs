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
*  using connect-transforms-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Transforms.Predicates
{
    #region TopicNameMatches
    public partial class TopicNameMatches
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Transforms.Predicates.TopicNameMatches"/> to <see cref="Org.Apache.Kafka.Connect.Transforms.Predicates.Predicate"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Connect.Transforms.Predicates.Predicate(Org.Apache.Kafka.Connect.Transforms.Predicates.TopicNameMatches t) => t.Cast<Org.Apache.Kafka.Connect.Transforms.Predicates.Predicate>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-transforms/3.4.0/org/apache/kafka/connect/transforms/predicates/TopicNameMatches.html#OVERVIEW_DOC"/>
        /// </summary>
        public static string OVERVIEW_DOC { get { return SGetField<string>(LocalBridgeClazz, "OVERVIEW_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-transforms/3.4.0/org/apache/kafka/connect/transforms/predicates/TopicNameMatches.html#CONFIG_DEF"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Config.ConfigDef CONFIG_DEF { get { return SGetField<Org.Apache.Kafka.Common.Config.ConfigDef>(LocalBridgeClazz, "CONFIG_DEF"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-transforms/3.4.0/org/apache/kafka/connect/transforms/predicates/TopicNameMatches.html#config()"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.Config.ConfigDef Config
        {
            get { return IExecute<Org.Apache.Kafka.Common.Config.ConfigDef>("config"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-transforms/3.4.0/org/apache/kafka/connect/transforms/predicates/TopicNameMatches.html#test(org.apache.kafka.connect.connector.ConnectRecord)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Connector.ConnectRecord"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Test(Org.Apache.Kafka.Connect.Connector.ConnectRecord arg0)
        {
            return IExecute<bool>("test", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-transforms/3.4.0/org/apache/kafka/connect/transforms/predicates/TopicNameMatches.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-transforms/3.4.0/org/apache/kafka/connect/transforms/predicates/TopicNameMatches.html#configure(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public void Configure(Java.Util.Map arg0)
        {
            IExecute("configure", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TopicNameMatches<R>
    public partial class TopicNameMatches<R>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Transforms.Predicates.TopicNameMatches{R}"/> to <see cref="Org.Apache.Kafka.Connect.Transforms.Predicates.Predicate{R}"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Connect.Transforms.Predicates.Predicate<R>(Org.Apache.Kafka.Connect.Transforms.Predicates.TopicNameMatches<R> t) => t.Cast<Org.Apache.Kafka.Connect.Transforms.Predicates.Predicate<R>>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Transforms.Predicates.TopicNameMatches{R}"/> to <see cref="Org.Apache.Kafka.Connect.Transforms.Predicates.TopicNameMatches"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Connect.Transforms.Predicates.TopicNameMatches(Org.Apache.Kafka.Connect.Transforms.Predicates.TopicNameMatches<R> t) => t.Cast<Org.Apache.Kafka.Connect.Transforms.Predicates.TopicNameMatches>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-transforms/3.4.0/org/apache/kafka/connect/transforms/predicates/TopicNameMatches.html#OVERVIEW_DOC"/>
        /// </summary>
        public static string OVERVIEW_DOC { get { return SGetField<string>(LocalBridgeClazz, "OVERVIEW_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-transforms/3.4.0/org/apache/kafka/connect/transforms/predicates/TopicNameMatches.html#CONFIG_DEF"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Config.ConfigDef CONFIG_DEF { get { return SGetField<Org.Apache.Kafka.Common.Config.ConfigDef>(LocalBridgeClazz, "CONFIG_DEF"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-transforms/3.4.0/org/apache/kafka/connect/transforms/predicates/TopicNameMatches.html#config()"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.Config.ConfigDef Config
        {
            get { return IExecute<Org.Apache.Kafka.Common.Config.ConfigDef>("config"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-transforms/3.4.0/org/apache/kafka/connect/transforms/predicates/TopicNameMatches.html#test(org.apache.kafka.connect.connector.ConnectRecord)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="R"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Test(R arg0)
        {
            return IExecute<bool>("test", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-transforms/3.4.0/org/apache/kafka/connect/transforms/predicates/TopicNameMatches.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-transforms/3.4.0/org/apache/kafka/connect/transforms/predicates/TopicNameMatches.html#configure(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <typeparam name="Arg0Extendsobject"></typeparam>
        public void Configure<Arg0Extendsobject>(Java.Util.Map<string, Arg0Extendsobject> arg0)
        {
            IExecute("configure", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}