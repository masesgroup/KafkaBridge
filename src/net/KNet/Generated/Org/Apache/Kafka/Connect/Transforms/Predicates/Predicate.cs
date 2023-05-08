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
*  using connect-api-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Transforms.Predicates
{
    #region Predicate
    public partial class Predicate
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Transforms.Predicates.Predicate"/> to <see cref="Org.Apache.Kafka.Common.Configurable"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Configurable(Org.Apache.Kafka.Connect.Transforms.Predicates.Predicate t) => t.Cast<Org.Apache.Kafka.Common.Configurable>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Transforms.Predicates.Predicate"/> to <see cref="Java.Lang.AutoCloseable"/>
        /// </summary>
        public static implicit operator Java.Lang.AutoCloseable(Org.Apache.Kafka.Connect.Transforms.Predicates.Predicate t) => t.Cast<Java.Lang.AutoCloseable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-api/3.4.0/org/apache/kafka/connect/transforms/predicates/Predicate.html#config()"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.Config.ConfigDef Config
        {
            get { return IExecute<Org.Apache.Kafka.Common.Config.ConfigDef>("config"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-api/3.4.0/org/apache/kafka/connect/transforms/predicates/Predicate.html#test(org.apache.kafka.connect.connector.ConnectRecord)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Connector.ConnectRecord"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Test(Org.Apache.Kafka.Connect.Connector.ConnectRecord arg0)
        {
            return IExecute<bool>("test", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-api/3.4.0/org/apache/kafka/connect/transforms/predicates/Predicate.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Predicate<R>
    public partial class Predicate<R>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Transforms.Predicates.Predicate{R}"/> to <see cref="Org.Apache.Kafka.Common.Configurable"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Configurable(Org.Apache.Kafka.Connect.Transforms.Predicates.Predicate<R> t) => t.Cast<Org.Apache.Kafka.Common.Configurable>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Transforms.Predicates.Predicate{R}"/> to <see cref="Java.Lang.AutoCloseable"/>
        /// </summary>
        public static implicit operator Java.Lang.AutoCloseable(Org.Apache.Kafka.Connect.Transforms.Predicates.Predicate<R> t) => t.Cast<Java.Lang.AutoCloseable>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Transforms.Predicates.Predicate{R}"/> to <see cref="Org.Apache.Kafka.Connect.Transforms.Predicates.Predicate"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Connect.Transforms.Predicates.Predicate(Org.Apache.Kafka.Connect.Transforms.Predicates.Predicate<R> t) => t.Cast<Org.Apache.Kafka.Connect.Transforms.Predicates.Predicate>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-api/3.4.0/org/apache/kafka/connect/transforms/predicates/Predicate.html#config()"/> 
        /// </summary>
        public Org.Apache.Kafka.Common.Config.ConfigDef Config
        {
            get { return IExecute<Org.Apache.Kafka.Common.Config.ConfigDef>("config"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-api/3.4.0/org/apache/kafka/connect/transforms/predicates/Predicate.html#test(org.apache.kafka.connect.connector.ConnectRecord)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="R"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Test(R arg0)
        {
            return IExecute<bool>("test", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-api/3.4.0/org/apache/kafka/connect/transforms/predicates/Predicate.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}