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
*  This file is generated by MASES.JNetReflector (ver. 2.2.4.0)
*  using kafka_2.13-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Kafka.Admin
{
    #region BrokerApiVersionsCommand
    public partial class BrokerApiVersionsCommand
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.1/kafka/admin/BrokerApiVersionsCommand.html#execute-java.lang.String[]-java.io.PrintStream-"/>
        /// </summary>
        /// <param name="args"><see cref="string"/></param>
        /// <param name="_out"><see cref="Java.Io.PrintStream"/></param>
        public static void Execute(string[] args, Java.Io.PrintStream _out)
        {
            SExecute(LocalBridgeClazz, "execute", args, _out);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.1/kafka/admin/BrokerApiVersionsCommand.html#main-java.lang.String[]-"/>
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
        #region BrokerVersionCommandOptions
        public partial class BrokerVersionCommandOptions
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.1/kafka/admin/BrokerApiVersionsCommand.BrokerVersionCommandOptions.html#kafka.admin.BrokerApiVersionsCommand$BrokerVersionCommandOptions(java.lang.String[])"/>
            /// </summary>
            /// <param name="args"><see cref="string"/></param>
            public BrokerVersionCommandOptions(string[] args)
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.1/kafka/admin/BrokerApiVersionsCommand.BrokerVersionCommandOptions.html#BootstrapServerDoc--"/>
            /// </summary>

            /// <returns><see cref="string"/></returns>
            public string BootstrapServerDoc()
            {
                return IExecute<string>("BootstrapServerDoc");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.1/kafka/admin/BrokerApiVersionsCommand.BrokerVersionCommandOptions.html#CommandConfigDoc--"/>
            /// </summary>

            /// <returns><see cref="string"/></returns>
            public string CommandConfigDoc()
            {
                return IExecute<string>("CommandConfigDoc");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka_2.13/3.6.1/kafka/admin/BrokerApiVersionsCommand.BrokerVersionCommandOptions.html#checkArgs--"/>
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

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}