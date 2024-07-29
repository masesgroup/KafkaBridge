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
*  using kafka_2.13-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Kafka.Admin
{
    #region AclCommand
    public partial class AclCommand
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.8.0/kafka/admin/AclCommand.html#isDebugEnabled--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public static bool IsDebugEnabled()
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isDebugEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.8.0/kafka/admin/AclCommand.html#isTraceEnabled--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public static bool IsTraceEnabled()
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isTraceEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.8.0/kafka/admin/AclCommand.html#main-java.lang.String[]-"/>
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
        #region AclCommandOptions
        public partial class AclCommandOptions
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.8.0/kafka/admin/AclCommand.AclCommandOptions.html#kafka.admin.AclCommand$AclCommandOptions(java.lang.String[])"/>
            /// </summary>
            /// <param name="args"><see cref="Java.Lang.String"/></param>
            public AclCommandOptions(Java.Lang.String[] args)
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.8.0/kafka/admin/AclCommand.AclCommandOptions.html#CommandConfigDoc--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String CommandConfigDoc()
            {
                return IExecuteWithSignature<Java.Lang.String>("CommandConfigDoc", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.8.0/kafka/admin/AclCommand.AclCommandOptions.html#checkArgs--"/>
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

        #region AclCommandService
        public partial class AclCommandService
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
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.8.0/kafka/admin/AclCommand.AclCommandService.html#addAcls--"/>
            /// </summary>
            public void AddAcls()
            {
                IExecuteWithSignature("addAcls", "()V");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.8.0/kafka/admin/AclCommand.AclCommandService.html#listAcls--"/>
            /// </summary>
            public void ListAcls()
            {
                IExecuteWithSignature("listAcls", "()V");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.8.0/kafka/admin/AclCommand.AclCommandService.html#removeAcls--"/>
            /// </summary>
            public void RemoveAcls()
            {
                IExecuteWithSignature("removeAcls", "()V");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region AuthorizerService
        public partial class AuthorizerService
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.8.0/kafka/admin/AclCommand.AuthorizerService.html#kafka.admin.AclCommand$AuthorizerService(java.lang.String,kafka.admin.AclCommand.AclCommandOptions)"/>
            /// </summary>
            /// <param name="authorizerClassName"><see cref="Java.Lang.String"/></param>
            /// <param name="opts"><see cref="Kafka.Admin.AclCommand.AclCommandOptions"/></param>
            public AuthorizerService(Java.Lang.String authorizerClassName, Kafka.Admin.AclCommand.AclCommandOptions opts)
                : base(authorizerClassName, opts)
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.8.0/kafka/admin/AclCommand.AuthorizerService.html#isDebugEnabled--"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsDebugEnabled()
            {
                return IExecuteWithSignature<bool>("isDebugEnabled", "()Z");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.8.0/kafka/admin/AclCommand.AuthorizerService.html#isTraceEnabled--"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsTraceEnabled()
            {
                return IExecuteWithSignature<bool>("isTraceEnabled", "()Z");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.8.0/kafka/admin/AclCommand.AuthorizerService.html#authorizerClassName--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String AuthorizerClassName()
            {
                return IExecuteWithSignature<Java.Lang.String>("authorizerClassName", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.8.0/kafka/admin/AclCommand.AuthorizerService.html#loggerName--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String LoggerName()
            {
                return IExecuteWithSignature<Java.Lang.String>("loggerName", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.8.0/kafka/admin/AclCommand.AuthorizerService.html#logIdent--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String LogIdent()
            {
                return IExecuteWithSignature<Java.Lang.String>("logIdent", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.8.0/kafka/admin/AclCommand.AuthorizerService.html#msgWithLogIdent-java.lang.String-"/>
            /// </summary>
            /// <param name="msg"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String MsgWithLogIdent(Java.Lang.String msg)
            {
                return IExecuteWithSignature<Java.Lang.String>("msgWithLogIdent", "(Ljava/lang/String;)Ljava/lang/String;", msg);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.8.0/kafka/admin/AclCommand.AuthorizerService.html#opts--"/>
            /// </summary>
            /// <returns><see cref="Kafka.Admin.AclCommand.AclCommandOptions"/></returns>
            public Kafka.Admin.AclCommand.AclCommandOptions Opts()
            {
                return IExecuteWithSignature<Kafka.Admin.AclCommand.AclCommandOptions>("opts", "()Lkafka/admin/AclCommand$AclCommandOptions;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.8.0/kafka/admin/AclCommand.AuthorizerService.html#addAcls--"/>
            /// </summary>
            public void AddAcls()
            {
                IExecuteWithSignature("addAcls", "()V");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.8.0/kafka/admin/AclCommand.AuthorizerService.html#listAcls--"/>
            /// </summary>
            public void ListAcls()
            {
                IExecuteWithSignature("listAcls", "()V");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.8.0/kafka/admin/AclCommand.AuthorizerService.html#removeAcls--"/>
            /// </summary>
            public void RemoveAcls()
            {
                IExecuteWithSignature("removeAcls", "()V");
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