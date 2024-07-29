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
*  using connect-transforms-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Transforms.Field
{
    #region FieldSyntaxVersion
    public partial class FieldSyntaxVersion
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.7.1/org/apache/kafka/connect/transforms/field/FieldSyntaxVersion.html#FIELD_SYNTAX_VERSION_CONFIG"/>
        /// </summary>
        public static Java.Lang.String FIELD_SYNTAX_VERSION_CONFIG { get { if (!_FIELD_SYNTAX_VERSION_CONFIGReady) { _FIELD_SYNTAX_VERSION_CONFIGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FIELD_SYNTAX_VERSION_CONFIG"); _FIELD_SYNTAX_VERSION_CONFIGReady = true; } return _FIELD_SYNTAX_VERSION_CONFIGContent; } }
        private static Java.Lang.String _FIELD_SYNTAX_VERSION_CONFIGContent = default;
        private static bool _FIELD_SYNTAX_VERSION_CONFIGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.7.1/org/apache/kafka/connect/transforms/field/FieldSyntaxVersion.html#FIELD_SYNTAX_VERSION_DEFAULT_VALUE"/>
        /// </summary>
        public static Java.Lang.String FIELD_SYNTAX_VERSION_DEFAULT_VALUE { get { if (!_FIELD_SYNTAX_VERSION_DEFAULT_VALUEReady) { _FIELD_SYNTAX_VERSION_DEFAULT_VALUEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FIELD_SYNTAX_VERSION_DEFAULT_VALUE"); _FIELD_SYNTAX_VERSION_DEFAULT_VALUEReady = true; } return _FIELD_SYNTAX_VERSION_DEFAULT_VALUEContent; } }
        private static Java.Lang.String _FIELD_SYNTAX_VERSION_DEFAULT_VALUEContent = default;
        private static bool _FIELD_SYNTAX_VERSION_DEFAULT_VALUEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.7.1/org/apache/kafka/connect/transforms/field/FieldSyntaxVersion.html#FIELD_SYNTAX_VERSION_DOC"/>
        /// </summary>
        public static Java.Lang.String FIELD_SYNTAX_VERSION_DOC { get { if (!_FIELD_SYNTAX_VERSION_DOCReady) { _FIELD_SYNTAX_VERSION_DOCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FIELD_SYNTAX_VERSION_DOC"); _FIELD_SYNTAX_VERSION_DOCReady = true; } return _FIELD_SYNTAX_VERSION_DOCContent; } }
        private static Java.Lang.String _FIELD_SYNTAX_VERSION_DOCContent = default;
        private static bool _FIELD_SYNTAX_VERSION_DOCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.7.1/org/apache/kafka/connect/transforms/field/FieldSyntaxVersion.html#V1"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Transforms.Field.FieldSyntaxVersion V1 { get { if (!_V1Ready) { _V1Content = SGetField<Org.Apache.Kafka.Connect.Transforms.Field.FieldSyntaxVersion>(LocalBridgeClazz, "V1"); _V1Ready = true; } return _V1Content; } }
        private static Org.Apache.Kafka.Connect.Transforms.Field.FieldSyntaxVersion _V1Content = default;
        private static bool _V1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.7.1/org/apache/kafka/connect/transforms/field/FieldSyntaxVersion.html#V2"/>
        /// </summary>
        public static Org.Apache.Kafka.Connect.Transforms.Field.FieldSyntaxVersion V2 { get { if (!_V2Ready) { _V2Content = SGetField<Org.Apache.Kafka.Connect.Transforms.Field.FieldSyntaxVersion>(LocalBridgeClazz, "V2"); _V2Ready = true; } return _V2Content; } }
        private static Org.Apache.Kafka.Connect.Transforms.Field.FieldSyntaxVersion _V2Content = default;
        private static bool _V2Ready = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.7.1/org/apache/kafka/connect/transforms/field/FieldSyntaxVersion.html#appendConfigTo-org.apache.kafka.common.config.ConfigDef-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Config.ConfigDef"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Config.ConfigDef"/></returns>
        public static Org.Apache.Kafka.Common.Config.ConfigDef AppendConfigTo(Org.Apache.Kafka.Common.Config.ConfigDef arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Common.Config.ConfigDef>(LocalBridgeClazz, "appendConfigTo", "(Lorg/apache/kafka/common/config/ConfigDef;)Lorg/apache/kafka/common/config/ConfigDef;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.7.1/org/apache/kafka/connect/transforms/field/FieldSyntaxVersion.html#fromConfig-org.apache.kafka.common.config.AbstractConfig-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Config.AbstractConfig"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Transforms.Field.FieldSyntaxVersion"/></returns>
        public static Org.Apache.Kafka.Connect.Transforms.Field.FieldSyntaxVersion FromConfig(Org.Apache.Kafka.Common.Config.AbstractConfig arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Connect.Transforms.Field.FieldSyntaxVersion>(LocalBridgeClazz, "fromConfig", "(Lorg/apache/kafka/common/config/AbstractConfig;)Lorg/apache/kafka/connect/transforms/field/FieldSyntaxVersion;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.7.1/org/apache/kafka/connect/transforms/field/FieldSyntaxVersion.html#valueOf-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Transforms.Field.FieldSyntaxVersion"/></returns>
        public static Org.Apache.Kafka.Connect.Transforms.Field.FieldSyntaxVersion ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Connect.Transforms.Field.FieldSyntaxVersion>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Lorg/apache/kafka/connect/transforms/field/FieldSyntaxVersion;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-transforms/3.7.1/org/apache/kafka/connect/transforms/field/FieldSyntaxVersion.html#values--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Transforms.Field.FieldSyntaxVersion"/></returns>
        public static Org.Apache.Kafka.Connect.Transforms.Field.FieldSyntaxVersion[] Values()
        {
            return SExecuteWithSignatureArray<Org.Apache.Kafka.Connect.Transforms.Field.FieldSyntaxVersion>(LocalBridgeClazz, "values", "()[Lorg/apache/kafka/connect/transforms/field/FieldSyntaxVersion;");
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}