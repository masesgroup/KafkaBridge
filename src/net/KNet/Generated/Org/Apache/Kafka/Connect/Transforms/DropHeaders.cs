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
*  This file is generated by MASES.JNetReflector (ver. 2.0.2.0)
*  using connect-transforms-3.6.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Transforms
{
    #region DropHeaders
    public partial class DropHeaders
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Transforms.DropHeaders"/> to <see cref="Org.Apache.Kafka.Connect.Transforms.Transformation"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Connect.Transforms.Transformation(Org.Apache.Kafka.Connect.Transforms.DropHeaders t) => t.Cast<Org.Apache.Kafka.Connect.Transforms.Transformation>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Transforms.DropHeaders"/> to <see cref="Org.Apache.Kafka.Connect.Components.Versioned"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Connect.Components.Versioned(Org.Apache.Kafka.Connect.Transforms.DropHeaders t) => t.Cast<Org.Apache.Kafka.Connect.Components.Versioned>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.6.0/org/apache/kafka/connect/transforms/DropHeaders.html#HEADERS_FIELD"/>
        /// </summary>
        public static string HEADERS_FIELD { get { return SGetField<string>(LocalBridgeClazz, "HEADERS_FIELD"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.6.0/org/apache/kafka/connect/transforms/DropHeaders.html#OVERVIEW_DOC"/>
        /// </summary>
        public static string OVERVIEW_DOC { get { return SGetField<string>(LocalBridgeClazz, "OVERVIEW_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.6.0/org/apache/kafka/connect/transforms/DropHeaders.html#CONFIG_DEF"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Config.ConfigDef CONFIG_DEF { get { return SGetField<Org.Apache.Kafka.Common.Config.ConfigDef>(LocalBridgeClazz, "CONFIG_DEF"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.6.0/org/apache/kafka/connect/transforms/DropHeaders.html#version--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string Version()
        {
            return IExecute<string>("version");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.6.0/org/apache/kafka/connect/transforms/DropHeaders.html#config--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Config.ConfigDef"/></returns>
        public Org.Apache.Kafka.Common.Config.ConfigDef Config()
        {
            return IExecute<Org.Apache.Kafka.Common.Config.ConfigDef>("config");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.6.0/org/apache/kafka/connect/transforms/DropHeaders.html#apply-org.apache.kafka.connect.connector.ConnectRecord-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Connector.ConnectRecord"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Connector.ConnectRecord"/></returns>
        public Org.Apache.Kafka.Connect.Connector.ConnectRecord Apply(Org.Apache.Kafka.Connect.Connector.ConnectRecord arg0)
        {
            return IExecute<Org.Apache.Kafka.Connect.Connector.ConnectRecord>("apply", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.6.0/org/apache/kafka/connect/transforms/DropHeaders.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.6.0/org/apache/kafka/connect/transforms/DropHeaders.html#configure-java.util.Map-"/>
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

    #region DropHeaders<R>
    public partial class DropHeaders<R> : Org.Apache.Kafka.Connect.Transforms.ITransformation<R>, Org.Apache.Kafka.Connect.Components.IVersioned
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Transforms.DropHeaders{R}"/> to <see cref="Org.Apache.Kafka.Connect.Transforms.Transformation{R}"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Connect.Transforms.Transformation<R>(Org.Apache.Kafka.Connect.Transforms.DropHeaders<R> t) => t.Cast<Org.Apache.Kafka.Connect.Transforms.Transformation<R>>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Transforms.DropHeaders{R}"/> to <see cref="Org.Apache.Kafka.Connect.Components.Versioned"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Connect.Components.Versioned(Org.Apache.Kafka.Connect.Transforms.DropHeaders<R> t) => t.Cast<Org.Apache.Kafka.Connect.Components.Versioned>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Transforms.DropHeaders{R}"/> to <see cref="Org.Apache.Kafka.Connect.Transforms.DropHeaders"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Connect.Transforms.DropHeaders(Org.Apache.Kafka.Connect.Transforms.DropHeaders<R> t) => t.Cast<Org.Apache.Kafka.Connect.Transforms.DropHeaders>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.6.0/org/apache/kafka/connect/transforms/DropHeaders.html#HEADERS_FIELD"/>
        /// </summary>
        public static string HEADERS_FIELD { get { return SGetField<string>(LocalBridgeClazz, "HEADERS_FIELD"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.6.0/org/apache/kafka/connect/transforms/DropHeaders.html#OVERVIEW_DOC"/>
        /// </summary>
        public static string OVERVIEW_DOC { get { return SGetField<string>(LocalBridgeClazz, "OVERVIEW_DOC"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.6.0/org/apache/kafka/connect/transforms/DropHeaders.html#CONFIG_DEF"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Config.ConfigDef CONFIG_DEF { get { return SGetField<Org.Apache.Kafka.Common.Config.ConfigDef>(LocalBridgeClazz, "CONFIG_DEF"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.6.0/org/apache/kafka/connect/transforms/DropHeaders.html#version--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string Version()
        {
            return IExecute<string>("version");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.6.0/org/apache/kafka/connect/transforms/DropHeaders.html#config--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Config.ConfigDef"/></returns>
        public Org.Apache.Kafka.Common.Config.ConfigDef Config()
        {
            return IExecute<Org.Apache.Kafka.Common.Config.ConfigDef>("config");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.6.0/org/apache/kafka/connect/transforms/DropHeaders.html#apply-org.apache.kafka.connect.connector.ConnectRecord-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="R"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R Apply(R arg0)
        {
            return IExecute<R>("apply", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.6.0/org/apache/kafka/connect/transforms/DropHeaders.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.6.0/org/apache/kafka/connect/transforms/DropHeaders.html#configure-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public void Configure(Java.Util.Map<string, object> arg0)
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