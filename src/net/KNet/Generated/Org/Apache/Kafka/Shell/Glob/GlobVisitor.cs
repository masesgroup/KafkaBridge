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

namespace Org.Apache.Kafka.Shell.Glob
{
    #region GlobVisitor
    public partial class GlobVisitor
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-shell/3.7.1/org/apache/kafka/shell/glob/GlobVisitor.html#org.apache.kafka.shell.glob.GlobVisitor(java.lang.String,java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Consumer"/></param>
        public GlobVisitor(Java.Lang.String arg0, Java.Util.Function.Consumer<Java.Util.Optional<Org.Apache.Kafka.Shell.Glob.GlobVisitor.MetadataNodeInfo>> arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Shell.Glob.GlobVisitor"/> to <see cref="Java.Util.Function.Consumer"/>
        /// </summary>
        public static implicit operator Java.Util.Function.Consumer(Org.Apache.Kafka.Shell.Glob.GlobVisitor t) => t.Cast<Java.Util.Function.Consumer>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-shell/3.7.1/org/apache/kafka/shell/glob/GlobVisitor.html#accept-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void Accept(object arg0)
        {
            IExecuteWithSignature("accept", "(Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-shell/3.7.1/org/apache/kafka/shell/glob/GlobVisitor.html#accept-org.apache.kafka.shell.state.MetadataShellState-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Shell.State.MetadataShellState"/></param>
        public void Accept(Org.Apache.Kafka.Shell.State.MetadataShellState arg0)
        {
            IExecuteWithSignature("accept", "(Lorg/apache/kafka/shell/state/MetadataShellState;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region MetadataNodeInfo
        public partial class MetadataNodeInfo
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-shell/3.7.1/org/apache/kafka/shell/glob/GlobVisitor.MetadataNodeInfo.html#absolutePath--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String AbsolutePath()
            {
                return IExecuteWithSignature<Java.Lang.String>("absolutePath", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-shell/3.7.1/org/apache/kafka/shell/glob/GlobVisitor.MetadataNodeInfo.html#lastPathComponent--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String LastPathComponent()
            {
                return IExecuteWithSignature<Java.Lang.String>("lastPathComponent", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-shell/3.7.1/org/apache/kafka/shell/glob/GlobVisitor.MetadataNodeInfo.html#path--"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String[] Path()
            {
                return IExecuteWithSignatureArray<Java.Lang.String>("path", "()[Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-shell/3.7.1/org/apache/kafka/shell/glob/GlobVisitor.MetadataNodeInfo.html#node--"/>
            /// </summary>
            /// <returns><see cref="Org.Apache.Kafka.Image.Node.MetadataNode"/></returns>
            public Org.Apache.Kafka.Image.Node.MetadataNode Node()
            {
                return IExecuteWithSignature<Org.Apache.Kafka.Image.Node.MetadataNode>("node", "()Lorg/apache/kafka/image/node/MetadataNode;");
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