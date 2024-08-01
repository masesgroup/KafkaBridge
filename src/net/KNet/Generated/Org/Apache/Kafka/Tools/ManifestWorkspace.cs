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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using kafka-tools-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Tools
{
    #region ManifestWorkspace
    public partial class ManifestWorkspace
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.8.0/org/apache/kafka/tools/ManifestWorkspace.html#org.apache.kafka.tools.ManifestWorkspace(java.io.PrintStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.PrintStream"/></param>
        public ManifestWorkspace(Java.Io.PrintStream arg0)
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.8.0/org/apache/kafka/tools/ManifestWorkspace.html#commit-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Org.Apache.Kafka.Tools.TerseException"/>
        public bool Commit(bool arg0)
        {
            return IExecuteWithSignature<bool>("commit", "(Z)Z", arg0);
        }

        #endregion

        #region Nested classes
        #region SourceWorkspace
        public partial class SourceWorkspace
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.8.0/org/apache/kafka/tools/ManifestWorkspace.SourceWorkspace.html#location--"/>
            /// </summary>
            /// <returns><see cref="Java.Nio.File.Path"/></returns>
            public Java.Nio.File.Path Location()
            {
                return IExecuteWithSignature<Java.Nio.File.Path>("location", "()Ljava/nio/file/Path;");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region SourceWorkspace<T>
        public partial class SourceWorkspace<T>
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Org.Apache.Kafka.Tools.ManifestWorkspace.SourceWorkspace{T}"/> to <see cref="Org.Apache.Kafka.Tools.ManifestWorkspace.SourceWorkspace"/>
            /// </summary>
            public static implicit operator Org.Apache.Kafka.Tools.ManifestWorkspace.SourceWorkspace(Org.Apache.Kafka.Tools.ManifestWorkspace.SourceWorkspace<T> t) => t.Cast<Org.Apache.Kafka.Tools.ManifestWorkspace.SourceWorkspace>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.8.0/org/apache/kafka/tools/ManifestWorkspace.SourceWorkspace.html#location--"/>
            /// </summary>
            /// <returns><see cref="Java.Nio.File.Path"/></returns>
            public Java.Nio.File.Path Location()
            {
                return IExecuteWithSignature<Java.Nio.File.Path>("location", "()Ljava/nio/file/Path;");
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