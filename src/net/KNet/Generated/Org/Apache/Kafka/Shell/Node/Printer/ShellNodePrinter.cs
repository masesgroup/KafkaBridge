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

namespace Org.Apache.Kafka.Shell.Node.Printer
{
    #region ShellNodePrinter
    public partial class ShellNodePrinter
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-shell/3.7.1/org/apache/kafka/shell/node/printer/ShellNodePrinter.html#org.apache.kafka.shell.node.printer.ShellNodePrinter(java.io.PrintWriter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.PrintWriter"/></param>
        public ShellNodePrinter(Java.Io.PrintWriter arg0)
            : base(arg0)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-shell/3.7.1/org/apache/kafka/shell/node/printer/ShellNodePrinter.html#redactionCriteria--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Image.Node.Printer.MetadataNodeRedactionCriteria"/></returns>
        public Org.Apache.Kafka.Image.Node.Printer.MetadataNodeRedactionCriteria RedactionCriteria()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Image.Node.Printer.MetadataNodeRedactionCriteria>("redactionCriteria", "()Lorg/apache/kafka/image/node/printer/MetadataNodeRedactionCriteria;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-shell/3.7.1/org/apache/kafka/shell/node/printer/ShellNodePrinter.html#enterNode-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void EnterNode(Java.Lang.String arg0)
        {
            IExecuteWithSignature("enterNode", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-shell/3.7.1/org/apache/kafka/shell/node/printer/ShellNodePrinter.html#leaveNode--"/>
        /// </summary>
        public void LeaveNode()
        {
            IExecuteWithSignature("leaveNode", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-shell/3.7.1/org/apache/kafka/shell/node/printer/ShellNodePrinter.html#output-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void Output(Java.Lang.String arg0)
        {
            IExecuteWithSignature("output", "(Ljava/lang/String;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}