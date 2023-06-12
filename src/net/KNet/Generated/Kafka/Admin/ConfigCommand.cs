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
*  using kafka_2.13-3.4.0.jar as reference
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.4.0/kafka/admin/ConfigCommand.html#isDebugEnabled()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public static bool IsDebugEnabled()
        {
            return SExecute<bool>(LocalBridgeClazz, "isDebugEnabled");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.4.0/kafka/admin/ConfigCommand.html#isTraceEnabled()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public static bool IsTraceEnabled()
        {
            return SExecute<bool>(LocalBridgeClazz, "isTraceEnabled");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.4.0/kafka/admin/ConfigCommand.html#DefaultScramIterations()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public static int DefaultScramIterations()
        {
            return SExecute<int>(LocalBridgeClazz, "DefaultScramIterations");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.4.0/kafka/admin/ConfigCommand.html#BrokerDefaultEntityName()"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public static string BrokerDefaultEntityName()
        {
            return SExecute<string>(LocalBridgeClazz, "BrokerDefaultEntityName");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.4.0/kafka/admin/ConfigCommand.html#BrokerLoggerConfigType()"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public static string BrokerLoggerConfigType()
        {
            return SExecute<string>(LocalBridgeClazz, "BrokerLoggerConfigType");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.4.0/kafka/admin/ConfigCommand.html#main(java.lang.String[])"/>
        /// </summary>
        /// <param name="args"><see cref="string"/></param>
        public static void Main(string[] args)
        {
            SExecute(LocalBridgeClazz, "main", new object[] { args });
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.4.0/kafka/admin/ConfigCommand.ConfigCommandOptions.html#%3Cinit%3E(java.lang.String[])"/>
            /// </summary>
            /// <param name="args"><see cref="string"/></param>
            public ConfigCommandOptions(string[] args)
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.4.0/kafka/admin/ConfigCommand.ConfigCommandOptions.html#nl()"/>
            /// </summary>

            /// <returns><see cref="string"/></returns>
            public string Nl()
            {
                return IExecute<string>("nl");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.4.0/kafka/admin/ConfigCommand.ConfigCommandOptions.html#checkArgs()"/>
            /// </summary>
            public void CheckArgs()
            {
                IExecute("checkArgs");
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.4.0/kafka/admin/ConfigCommand.ConfigEntity.html#canEqual(java.lang.Object)"/>
            /// </summary>
            /// <param name="x$1"><see cref="object"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool CanEqual(object x_1)
            {
                return IExecute<bool>("canEqual", x_1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.4.0/kafka/admin/ConfigCommand.ConfigEntity.html#productArity()"/>
            /// </summary>

            /// <returns><see cref="int"/></returns>
            public int ProductArity()
            {
                return IExecute<int>("productArity");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.4.0/kafka/admin/ConfigCommand.ConfigEntity.html#productElement(int)"/>
            /// </summary>
            /// <param name="x$1"><see cref="int"/></param>
            /// <returns><see cref="object"/></returns>
            public object ProductElement(int x_1)
            {
                return IExecute("productElement", x_1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.4.0/kafka/admin/ConfigCommand.ConfigEntity.html#fullSanitizedName()"/>
            /// </summary>

            /// <returns><see cref="string"/></returns>
            public string FullSanitizedName()
            {
                return IExecute<string>("fullSanitizedName");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.4.0/kafka/admin/ConfigCommand.ConfigEntity.html#productElementName(int)"/>
            /// </summary>
            /// <param name="x$1"><see cref="int"/></param>
            /// <returns><see cref="string"/></returns>
            public string ProductElementName(int x_1)
            {
                return IExecute<string>("productElementName", x_1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.4.0/kafka/admin/ConfigCommand.ConfigEntity.html#productPrefix()"/>
            /// </summary>

            /// <returns><see cref="string"/></returns>
            public string ProductPrefix()
            {
                return IExecute<string>("productPrefix");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.4.0/kafka/admin/ConfigCommand.ConfigEntity.html#root()"/>
            /// </summary>

            /// <returns><see cref="Kafka.Admin.ConfigCommand.Entity"/></returns>
            public Kafka.Admin.ConfigCommand.Entity Root()
            {
                return IExecute<Kafka.Admin.ConfigCommand.Entity>("root");
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.4.0/kafka/admin/ConfigCommand.Entity.html#canEqual(java.lang.Object)"/>
            /// </summary>
            /// <param name="x$1"><see cref="object"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool CanEqual(object x_1)
            {
                return IExecute<bool>("canEqual", x_1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.4.0/kafka/admin/ConfigCommand.Entity.html#productArity()"/>
            /// </summary>

            /// <returns><see cref="int"/></returns>
            public int ProductArity()
            {
                return IExecute<int>("productArity");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.4.0/kafka/admin/ConfigCommand.Entity.html#productElement(int)"/>
            /// </summary>
            /// <param name="x$1"><see cref="int"/></param>
            /// <returns><see cref="object"/></returns>
            public object ProductElement(int x_1)
            {
                return IExecute("productElement", x_1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.4.0/kafka/admin/ConfigCommand.Entity.html#entityPath()"/>
            /// </summary>

            /// <returns><see cref="string"/></returns>
            public string EntityPath()
            {
                return IExecute<string>("entityPath");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.4.0/kafka/admin/ConfigCommand.Entity.html#entityType()"/>
            /// </summary>

            /// <returns><see cref="string"/></returns>
            public string EntityType()
            {
                return IExecute<string>("entityType");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.4.0/kafka/admin/ConfigCommand.Entity.html#productElementName(int)"/>
            /// </summary>
            /// <param name="x$1"><see cref="int"/></param>
            /// <returns><see cref="string"/></returns>
            public string ProductElementName(int x_1)
            {
                return IExecute<string>("productElementName", x_1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.4.0/kafka/admin/ConfigCommand.Entity.html#productPrefix()"/>
            /// </summary>

            /// <returns><see cref="string"/></returns>
            public string ProductPrefix()
            {
                return IExecute<string>("productPrefix");
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