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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using connect-transforms-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Transforms
{
    #region SetSchemaMetadata
    public partial class SetSchemaMetadata
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Transforms.SetSchemaMetadata"/> to <see cref="Org.Apache.Kafka.Connect.Transforms.Transformation"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Connect.Transforms.Transformation(Org.Apache.Kafka.Connect.Transforms.SetSchemaMetadata t) => t.Cast<Org.Apache.Kafka.Connect.Transforms.Transformation>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Transforms.SetSchemaMetadata"/> to <see cref="Org.Apache.Kafka.Connect.Components.Versioned"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Connect.Components.Versioned(Org.Apache.Kafka.Connect.Transforms.SetSchemaMetadata t) => t.Cast<Org.Apache.Kafka.Connect.Components.Versioned>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.6.1/org/apache/kafka/connect/transforms/SetSchemaMetadata.html#OVERVIEW_DOC"/>
        /// </summary>
        public static Java.Lang.String OVERVIEW_DOC { get { if (!_OVERVIEW_DOCReady) { _OVERVIEW_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "OVERVIEW_DOC"); _OVERVIEW_DOCReady = true; } return _OVERVIEW_DOCContent; } }
        private static Java.Lang.String _OVERVIEW_DOCContent = default;
        private static bool _OVERVIEW_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.6.1/org/apache/kafka/connect/transforms/SetSchemaMetadata.html#CONFIG_DEF"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Config.ConfigDef CONFIG_DEF { get { if (!_CONFIG_DEFReady) { _CONFIG_DEFContent = SGetField<Org.Apache.Kafka.Common.Config.ConfigDef>(LocalBridgeClazz, "CONFIG_DEF"); _CONFIG_DEFReady = true; } return _CONFIG_DEFContent; } }
        private static Org.Apache.Kafka.Common.Config.ConfigDef _CONFIG_DEFContent = default;
        private static bool _CONFIG_DEFReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.6.1/org/apache/kafka/connect/transforms/SetSchemaMetadata.html#version--"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Version()
        {
            return IExecute<Java.Lang.String>("version");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.6.1/org/apache/kafka/connect/transforms/SetSchemaMetadata.html#config--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Config.ConfigDef"/></returns>
        public Org.Apache.Kafka.Common.Config.ConfigDef Config()
        {
            return IExecute<Org.Apache.Kafka.Common.Config.ConfigDef>("config");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.6.1/org/apache/kafka/connect/transforms/SetSchemaMetadata.html#apply-org.apache.kafka.connect.connector.ConnectRecord-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Connector.ConnectRecord"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Connector.ConnectRecord"/></returns>
        public Org.Apache.Kafka.Connect.Connector.ConnectRecord Apply(Org.Apache.Kafka.Connect.Connector.ConnectRecord arg0)
        {
            return IExecute<Org.Apache.Kafka.Connect.Connector.ConnectRecord>("apply", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.6.1/org/apache/kafka/connect/transforms/SetSchemaMetadata.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.6.1/org/apache/kafka/connect/transforms/SetSchemaMetadata.html#configure-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public void Configure(Java.Util.Map arg0)
        {
            IExecute("configure", arg0);
        }

        #endregion

        #region Nested classes
        #region Key
        public partial class Key
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

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Key<R>
        public partial class Key<R>
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Org.Apache.Kafka.Connect.Transforms.SetSchemaMetadata.Key{R}"/> to <see cref="Org.Apache.Kafka.Connect.Transforms.SetSchemaMetadata.Key"/>
            /// </summary>
            public static implicit operator Org.Apache.Kafka.Connect.Transforms.SetSchemaMetadata.Key(Org.Apache.Kafka.Connect.Transforms.SetSchemaMetadata.Key<R> t) => t.Cast<Org.Apache.Kafka.Connect.Transforms.SetSchemaMetadata.Key>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Value
        public partial class Value
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

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Value<R>
        public partial class Value<R>
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Org.Apache.Kafka.Connect.Transforms.SetSchemaMetadata.Value{R}"/> to <see cref="Org.Apache.Kafka.Connect.Transforms.SetSchemaMetadata.Value"/>
            /// </summary>
            public static implicit operator Org.Apache.Kafka.Connect.Transforms.SetSchemaMetadata.Value(Org.Apache.Kafka.Connect.Transforms.SetSchemaMetadata.Value<R> t) => t.Cast<Org.Apache.Kafka.Connect.Transforms.SetSchemaMetadata.Value>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

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

    #region SetSchemaMetadata<R>
    public partial class SetSchemaMetadata<R> : Org.Apache.Kafka.Connect.Transforms.ITransformation<R>, Org.Apache.Kafka.Connect.Components.IVersioned
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Transforms.SetSchemaMetadata{R}"/> to <see cref="Org.Apache.Kafka.Connect.Transforms.Transformation{R}"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Connect.Transforms.Transformation<R>(Org.Apache.Kafka.Connect.Transforms.SetSchemaMetadata<R> t) => t.Cast<Org.Apache.Kafka.Connect.Transforms.Transformation<R>>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Transforms.SetSchemaMetadata{R}"/> to <see cref="Org.Apache.Kafka.Connect.Components.Versioned"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Connect.Components.Versioned(Org.Apache.Kafka.Connect.Transforms.SetSchemaMetadata<R> t) => t.Cast<Org.Apache.Kafka.Connect.Components.Versioned>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Connect.Transforms.SetSchemaMetadata{R}"/> to <see cref="Org.Apache.Kafka.Connect.Transforms.SetSchemaMetadata"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Connect.Transforms.SetSchemaMetadata(Org.Apache.Kafka.Connect.Transforms.SetSchemaMetadata<R> t) => t.Cast<Org.Apache.Kafka.Connect.Transforms.SetSchemaMetadata>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.6.1/org/apache/kafka/connect/transforms/SetSchemaMetadata.html#OVERVIEW_DOC"/>
        /// </summary>
        public static Java.Lang.String OVERVIEW_DOC { get { if (!_OVERVIEW_DOCReady) { _OVERVIEW_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "OVERVIEW_DOC"); _OVERVIEW_DOCReady = true; } return _OVERVIEW_DOCContent; } }
        private static Java.Lang.String _OVERVIEW_DOCContent = default;
        private static bool _OVERVIEW_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.6.1/org/apache/kafka/connect/transforms/SetSchemaMetadata.html#CONFIG_DEF"/>
        /// </summary>
        public static Org.Apache.Kafka.Common.Config.ConfigDef CONFIG_DEF { get { if (!_CONFIG_DEFReady) { _CONFIG_DEFContent = SGetField<Org.Apache.Kafka.Common.Config.ConfigDef>(LocalBridgeClazz, "CONFIG_DEF"); _CONFIG_DEFReady = true; } return _CONFIG_DEFContent; } }
        private static Org.Apache.Kafka.Common.Config.ConfigDef _CONFIG_DEFContent = default;
        private static bool _CONFIG_DEFReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.6.1/org/apache/kafka/connect/transforms/SetSchemaMetadata.html#version--"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Version()
        {
            return IExecute<Java.Lang.String>("version");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.6.1/org/apache/kafka/connect/transforms/SetSchemaMetadata.html#config--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Config.ConfigDef"/></returns>
        public Org.Apache.Kafka.Common.Config.ConfigDef Config()
        {
            return IExecute<Org.Apache.Kafka.Common.Config.ConfigDef>("config");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.6.1/org/apache/kafka/connect/transforms/SetSchemaMetadata.html#apply-org.apache.kafka.connect.connector.ConnectRecord-"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="R"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R Apply(R arg0)
        {
            return IExecute<R>("apply", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.6.1/org/apache/kafka/connect/transforms/SetSchemaMetadata.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.6.1/org/apache/kafka/connect/transforms/SetSchemaMetadata.html#configure-java.util.Map-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public void Configure(Java.Util.Map<Java.Lang.String, object> arg0)
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