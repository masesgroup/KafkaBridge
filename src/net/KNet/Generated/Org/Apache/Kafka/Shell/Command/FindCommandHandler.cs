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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using kafka-shell-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Shell.Command
{
    #region FindCommandHandler
    public partial class FindCommandHandler
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-shell/3.7.1/org/apache/kafka/shell/command/FindCommandHandler.html#org.apache.kafka.shell.command.FindCommandHandler(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        public FindCommandHandler(Java.Util.List<Java.Lang.String> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-shell/3.7.1/org/apache/kafka/shell/command/FindCommandHandler.html#TYPE"/>
        /// </summary>
        public static Org.Apache.Kafka.Shell.Command.Commands.Type TYPE { get { if (!_TYPEReady) { _TYPEContent = SGetField<Org.Apache.Kafka.Shell.Command.Commands.Type>(LocalBridgeClazz, "TYPE"); _TYPEReady = true; } return _TYPEContent; } }
        private static Org.Apache.Kafka.Shell.Command.Commands.Type _TYPEContent = default;
        private static bool _TYPEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-shell/3.7.1/org/apache/kafka/shell/command/FindCommandHandler.html#run-java.util.Optional-java.io.PrintWriter-org.apache.kafka.shell.state.MetadataShellState-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Optional"/></param>
        /// <param name="arg1"><see cref="Java.Io.PrintWriter"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Shell.State.MetadataShellState"/></param>
        /// <exception cref="Java.Lang.Exception"/>
        public void Run(Java.Util.Optional<Org.Apache.Kafka.Shell.InteractiveShell> arg0, Java.Io.PrintWriter arg1, Org.Apache.Kafka.Shell.State.MetadataShellState arg2)
        {
            IExecute("run", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes
        #region FindCommandType
        public partial class FindCommandType
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-shell/3.7.1/org/apache/kafka/shell/command/FindCommandHandler.FindCommandType.html#shellOnly--"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool ShellOnly()
            {
                return IExecuteWithSignature<bool>("shellOnly", "()Z");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-shell/3.7.1/org/apache/kafka/shell/command/FindCommandHandler.FindCommandType.html#description--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String Description()
            {
                return IExecuteWithSignature<Java.Lang.String>("description", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-shell/3.7.1/org/apache/kafka/shell/command/FindCommandHandler.FindCommandType.html#name--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String Name()
            {
                return IExecuteWithSignature<Java.Lang.String>("name", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-shell/3.7.1/org/apache/kafka/shell/command/FindCommandHandler.FindCommandType.html#completeNext-org.apache.kafka.shell.state.MetadataShellState-java.util.List-java.util.List-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Shell.State.MetadataShellState"/></param>
            /// <param name="arg1"><see cref="Java.Util.List"/></param>
            /// <param name="arg2"><see cref="Java.Util.List"/></param>
            /// <exception cref="Java.Lang.Exception"/>
            public void CompleteNext(Org.Apache.Kafka.Shell.State.MetadataShellState arg0, Java.Util.List<Java.Lang.String> arg1, Java.Util.List<Org.Jline.Reader.Candidate> arg2)
            {
                IExecute("completeNext", arg0, arg1, arg2);
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