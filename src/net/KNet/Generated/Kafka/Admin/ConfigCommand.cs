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
*  This file is generated by MASES.JNetReflector (ver. 2.5.4.0)
*  using kafka_2.13-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Kafka.Admin
{
    #region ConfigCommand
    public partial class ConfigCommand
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.7.0/kafka/admin/ConfigCommand.html#isDebugEnabled--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public static bool IsDebugEnabled()
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isDebugEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.7.0/kafka/admin/ConfigCommand.html#isTraceEnabled--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public static bool IsTraceEnabled()
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isTraceEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.7.0/kafka/admin/ConfigCommand.html#DefaultScramIterations--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int DefaultScramIterations()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "DefaultScramIterations", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.7.0/kafka/admin/ConfigCommand.html#BrokerDefaultEntityName--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String BrokerDefaultEntityName()
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "BrokerDefaultEntityName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.7.0/kafka/admin/ConfigCommand.html#BrokerLoggerConfigType--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String BrokerLoggerConfigType()
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "BrokerLoggerConfigType", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.7.0/kafka/admin/ConfigCommand.html#main-java.lang.String[]-"/>
        /// </summary>
        /// <param name="args"><see cref="Java.Lang.String"/></param>
        public static void Main(Java.Lang.String[] args)
        {
            SExecuteWithSignature(LocalBridgeClazz, "main", "([Ljava/lang/String;)V", new object[] { args });
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region ConfigCommandOptions
        public partial class ConfigCommandOptions
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.7.0/kafka/admin/ConfigCommand.ConfigCommandOptions.html#kafka.admin.ConfigCommand$ConfigCommandOptions(java.lang.String[])"/>
            /// </summary>
            /// <param name="args"><see cref="Java.Lang.String"/></param>
            public ConfigCommandOptions(Java.Lang.String[] args)
                : base(args)
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.7.0/kafka/admin/ConfigCommand.ConfigCommandOptions.html#nl--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String Nl()
            {
                return IExecuteWithSignature<Java.Lang.String>("nl", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.7.0/kafka/admin/ConfigCommand.ConfigCommandOptions.html#checkArgs--"/>
            /// </summary>
            public void CheckArgs()
            {
                IExecuteWithSignature("checkArgs", "()V");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ConfigEntity
        public partial class ConfigEntity : Java.Io.ISerializable
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Kafka.Admin.ConfigCommand.ConfigEntity"/> to <see cref="Java.Io.Serializable"/>
            /// </summary>
            public static implicit operator Java.Io.Serializable(Kafka.Admin.ConfigCommand.ConfigEntity t) => t.Cast<Java.Io.Serializable>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.7.0/kafka/admin/ConfigCommand.ConfigEntity.html#canEqual-java.lang.Object-"/>
            /// </summary>
            /// <param name="x_1"><see cref="object"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool CanEqual(object x_1)
            {
                return IExecuteWithSignature<bool>("canEqual", "(Ljava/lang/Object;)Z", x_1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.7.0/kafka/admin/ConfigCommand.ConfigEntity.html#productArity--"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int ProductArity()
            {
                return IExecuteWithSignature<int>("productArity", "()I");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.7.0/kafka/admin/ConfigCommand.ConfigEntity.html#productElement-int-"/>
            /// </summary>
            /// <param name="x_1"><see cref="int"/></param>
            /// <returns><see cref="object"/></returns>
            public object ProductElement(int x_1)
            {
                return IExecuteWithSignature("productElement", "(I)Ljava/lang/Object;", x_1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.7.0/kafka/admin/ConfigCommand.ConfigEntity.html#fullSanitizedName--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String FullSanitizedName()
            {
                return IExecuteWithSignature<Java.Lang.String>("fullSanitizedName", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.7.0/kafka/admin/ConfigCommand.ConfigEntity.html#productElementName-int-"/>
            /// </summary>
            /// <param name="x_1"><see cref="int"/></param>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String ProductElementName(int x_1)
            {
                return IExecuteWithSignature<Java.Lang.String>("productElementName", "(I)Ljava/lang/String;", x_1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.7.0/kafka/admin/ConfigCommand.ConfigEntity.html#productPrefix--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String ProductPrefix()
            {
                return IExecuteWithSignature<Java.Lang.String>("productPrefix", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.7.0/kafka/admin/ConfigCommand.ConfigEntity.html#root--"/>
            /// </summary>
            /// <returns><see cref="Kafka.Admin.ConfigCommand.Entity"/></returns>
            public Kafka.Admin.ConfigCommand.Entity Root()
            {
                return IExecuteWithSignature<Kafka.Admin.ConfigCommand.Entity>("root", "()Lkafka/admin/ConfigCommand$Entity;");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Entity
        public partial class Entity : Java.Io.ISerializable
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Kafka.Admin.ConfigCommand.Entity"/> to <see cref="Java.Io.Serializable"/>
            /// </summary>
            public static implicit operator Java.Io.Serializable(Kafka.Admin.ConfigCommand.Entity t) => t.Cast<Java.Io.Serializable>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.7.0/kafka/admin/ConfigCommand.Entity.html#canEqual-java.lang.Object-"/>
            /// </summary>
            /// <param name="x_1"><see cref="object"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool CanEqual(object x_1)
            {
                return IExecuteWithSignature<bool>("canEqual", "(Ljava/lang/Object;)Z", x_1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.7.0/kafka/admin/ConfigCommand.Entity.html#productArity--"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int ProductArity()
            {
                return IExecuteWithSignature<int>("productArity", "()I");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.7.0/kafka/admin/ConfigCommand.Entity.html#productElement-int-"/>
            /// </summary>
            /// <param name="x_1"><see cref="int"/></param>
            /// <returns><see cref="object"/></returns>
            public object ProductElement(int x_1)
            {
                return IExecuteWithSignature("productElement", "(I)Ljava/lang/Object;", x_1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.7.0/kafka/admin/ConfigCommand.Entity.html#entityPath--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String EntityPath()
            {
                return IExecuteWithSignature<Java.Lang.String>("entityPath", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.7.0/kafka/admin/ConfigCommand.Entity.html#entityType--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String EntityType()
            {
                return IExecuteWithSignature<Java.Lang.String>("entityType", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.7.0/kafka/admin/ConfigCommand.Entity.html#productElementName-int-"/>
            /// </summary>
            /// <param name="x_1"><see cref="int"/></param>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String ProductElementName(int x_1)
            {
                return IExecuteWithSignature<Java.Lang.String>("productElementName", "(I)Ljava/lang/String;", x_1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.7.0/kafka/admin/ConfigCommand.Entity.html#productPrefix--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String ProductPrefix()
            {
                return IExecuteWithSignature<Java.Lang.String>("productPrefix", "()Ljava/lang/String;");
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