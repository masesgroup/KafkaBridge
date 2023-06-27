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
*  using connect-api-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Transforms
{
    #region Transformation
    public partial class Transformation
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Transforms.Transformation"/> to <see cref="Org.Apache.Kafka.Common.Configurable"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Configurable(Org.Apache.Kafka.Connect.Transforms.Transformation t) => t.Cast<Org.Apache.Kafka.Common.Configurable>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Transforms.Transformation"/> to <see cref="Java.Io.Closeable"/>
        /// </summary>
        public static implicit operator Java.Io.Closeable(Org.Apache.Kafka.Connect.Transforms.Transformation t) => t.Cast<Java.Io.Closeable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.4.0/org/apache/kafka/connect/transforms/Transformation.html#config()"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Config.ConfigDef"/></returns>
        public Org.Apache.Kafka.Common.Config.ConfigDef Config()
        {
            return IExecute<Org.Apache.Kafka.Common.Config.ConfigDef>("config");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.4.0/org/apache/kafka/connect/transforms/Transformation.html#apply(org.apache.kafka.connect.connector.ConnectRecord)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Connector.ConnectRecord"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Connector.ConnectRecord"/></returns>
        public Org.Apache.Kafka.Connect.Connector.ConnectRecord Apply(Org.Apache.Kafka.Connect.Connector.ConnectRecord arg0)
        {
            return IExecute<Org.Apache.Kafka.Connect.Connector.ConnectRecord>("apply", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.4.0/org/apache/kafka/connect/transforms/Transformation.html#close()"/>
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

    #region ITransformation<R>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ITransformation<R>
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Transformation<R>
    public partial class Transformation<R> : Org.Apache.Kafka.Connect.Transforms.ITransformation<R>, Org.Apache.Kafka.Common.IConfigurable, Java.Io.ICloseable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Transforms.Transformation{R}"/> to <see cref="Org.Apache.Kafka.Common.Configurable"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Configurable(Org.Apache.Kafka.Connect.Transforms.Transformation<R> t) => t.Cast<Org.Apache.Kafka.Common.Configurable>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Transforms.Transformation{R}"/> to <see cref="Java.Io.Closeable"/>
        /// </summary>
        public static implicit operator Java.Io.Closeable(Org.Apache.Kafka.Connect.Transforms.Transformation<R> t) => t.Cast<Java.Io.Closeable>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Transforms.Transformation{R}"/> to <see cref="Org.Apache.Kafka.Connect.Transforms.Transformation"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Connect.Transforms.Transformation(Org.Apache.Kafka.Connect.Transforms.Transformation<R> t) => t.Cast<Org.Apache.Kafka.Connect.Transforms.Transformation>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.4.0/org/apache/kafka/connect/transforms/Transformation.html#config()"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Config.ConfigDef"/></returns>
        public Org.Apache.Kafka.Common.Config.ConfigDef Config()
        {
            return IExecute<Org.Apache.Kafka.Common.Config.ConfigDef>("config");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.4.0/org/apache/kafka/connect/transforms/Transformation.html#apply(org.apache.kafka.connect.connector.ConnectRecord)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="R"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R Apply(R arg0)
        {
            return IExecute<R>("apply", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.4.0/org/apache/kafka/connect/transforms/Transformation.html#close()"/>
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