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

namespace Kafka.Server
{
    #region PartitionMetadataFile
    public partial class PartitionMetadataFile
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/PartitionMetadataFile.html#%3Cinit%3E(java.io.File,kafka.server.LogDirFailureChannel)"/>
        /// </summary>
        /// <param name="file"><see cref="Java.Io.File"/></param>
        /// <param name="logDirFailureChannel"><see cref="Kafka.Server.LogDirFailureChannel"/></param>
        public PartitionMetadataFile(Java.Io.File file, Kafka.Server.LogDirFailureChannel logDirFailureChannel)
            : base(file, logDirFailureChannel)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Kafka.Server.PartitionMetadataFile"/> to <see cref="Kafka.Utils.Logging"/>
        /// </summary>
        public static implicit operator Kafka.Utils.Logging(Kafka.Server.PartitionMetadataFile t) => t.Cast<Kafka.Utils.Logging>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/PartitionMetadataFile.html#newFile(java.io.File)"/>
        /// </summary>
        /// <param name="dir"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Java.Io.File"/></returns>
        public static Java.Io.File NewFile(Java.Io.File dir)
        {
            return SExecute<Java.Io.File>(LocalBridgeClazz, "newFile", dir);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/PartitionMetadataFile.html#exists()"/> 
        /// </summary>
        public bool Exists
        {
            get { return IExecute<bool>("exists"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/PartitionMetadataFile.html#file()"/> 
        /// </summary>
        public Java.Io.File File
        {
            get { return IExecute<Java.Io.File>("file"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/PartitionMetadataFile.html#isDebugEnabled()"/> 
        /// </summary>
        public bool IsDebugEnabled
        {
            get { return IExecute<bool>("isDebugEnabled"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/PartitionMetadataFile.html#isTraceEnabled()"/> 
        /// </summary>
        public bool IsTraceEnabled
        {
            get { return IExecute<bool>("isTraceEnabled"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/PartitionMetadataFile.html#logger()"/> 
        /// </summary>
        public Com.Typesafe.Scalalogging.Logger Logger
        {
            get { return IExecute<Com.Typesafe.Scalalogging.Logger>("logger"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/PartitionMetadataFile.html#loggerName()"/> 
        /// </summary>
        public string LoggerName
        {
            get { return IExecute<string>("loggerName"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/PartitionMetadataFile.html#logIdent()"/> 
        /// </summary>
        public string LogIdent
        {
            get { return IExecute<string>("logIdent"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/PartitionMetadataFile.html#read()"/> 
        /// </summary>
        public Kafka.Server.PartitionMetadata Read
        {
            get { return IExecute<Kafka.Server.PartitionMetadata>("read"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/PartitionMetadataFile.html#msgWithLogIdent(java.lang.String)"/>
        /// </summary>
        /// <param name="msg"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string MsgWithLogIdent(string msg)
        {
            return IExecute<string>("msgWithLogIdent", msg);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/PartitionMetadataFile.html#delete()"/>
        /// </summary>
        public void Delete()
        {
            IExecute("delete");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/PartitionMetadataFile.html#maybeFlush()"/>
        /// </summary>
        public void MaybeFlush()
        {
            IExecute("maybeFlush");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/PartitionMetadataFile.html#record(org.apache.kafka.common.Uuid)"/>
        /// </summary>
        /// <param name="topicId"><see cref="Org.Apache.Kafka.Common.Uuid"/></param>
        public void Record(Org.Apache.Kafka.Common.Uuid topicId)
        {
            IExecute("record", topicId);
        }

        #endregion

        #region Nested classes
        #region PartitionMetadataReadBuffer
        public partial class PartitionMetadataReadBuffer
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/PartitionMetadataFile.PartitionMetadataReadBuffer.html#%3Cinit%3E(java.lang.String,java.io.BufferedReader)"/>
            /// </summary>
            /// <param name="location"><see cref="string"/></param>
            /// <param name="reader"><see cref="Java.Io.BufferedReader"/></param>
            public PartitionMetadataReadBuffer(string location, Java.Io.BufferedReader reader)
                : base(location, reader)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Kafka.Server.PartitionMetadataFile.PartitionMetadataReadBuffer"/> to <see cref="Kafka.Utils.Logging"/>
            /// </summary>
            public static implicit operator Kafka.Utils.Logging(Kafka.Server.PartitionMetadataFile.PartitionMetadataReadBuffer t) => t.Cast<Kafka.Utils.Logging>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/PartitionMetadataFile.PartitionMetadataReadBuffer.html#isDebugEnabled()"/> 
            /// </summary>
            public bool IsDebugEnabled
            {
                get { return IExecute<bool>("isDebugEnabled"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/PartitionMetadataFile.PartitionMetadataReadBuffer.html#isTraceEnabled()"/> 
            /// </summary>
            public bool IsTraceEnabled
            {
                get { return IExecute<bool>("isTraceEnabled"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/PartitionMetadataFile.PartitionMetadataReadBuffer.html#logger()"/> 
            /// </summary>
            public Com.Typesafe.Scalalogging.Logger Logger
            {
                get { return IExecute<Com.Typesafe.Scalalogging.Logger>("logger"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/PartitionMetadataFile.PartitionMetadataReadBuffer.html#loggerName()"/> 
            /// </summary>
            public string LoggerName
            {
                get { return IExecute<string>("loggerName"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/PartitionMetadataFile.PartitionMetadataReadBuffer.html#logIdent()"/> 
            /// </summary>
            public string LogIdent
            {
                get { return IExecute<string>("logIdent"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/PartitionMetadataFile.PartitionMetadataReadBuffer.html#read()"/> 
            /// </summary>
            public Kafka.Server.PartitionMetadata Read
            {
                get { return IExecute<Kafka.Server.PartitionMetadata>("read"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/PartitionMetadataFile.PartitionMetadataReadBuffer.html#msgWithLogIdent(java.lang.String)"/>
            /// </summary>
            /// <param name="msg"><see cref="string"/></param>
            /// <returns><see cref="string"/></returns>
            public string MsgWithLogIdent(string msg)
            {
                return IExecute<string>("msgWithLogIdent", msg);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region PartitionMetadataReadBuffer<T>
        public partial class PartitionMetadataReadBuffer<T>
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/PartitionMetadataFile.PartitionMetadataReadBuffer.html#%3Cinit%3E(java.lang.String,java.io.BufferedReader)"/>
            /// </summary>
            /// <param name="location"><see cref="string"/></param>
            /// <param name="reader"><see cref="Java.Io.BufferedReader"/></param>
            public PartitionMetadataReadBuffer(string location, Java.Io.BufferedReader reader)
                : base(location, reader)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Kafka.Server.PartitionMetadataFile.PartitionMetadataReadBuffer{T}"/> to <see cref="Kafka.Utils.Logging"/>
            /// </summary>
            public static implicit operator Kafka.Utils.Logging(Kafka.Server.PartitionMetadataFile.PartitionMetadataReadBuffer<T> t) => t.Cast<Kafka.Utils.Logging>();
            /// <summary>
            /// Converter from <see cref="Kafka.Server.PartitionMetadataFile.PartitionMetadataReadBuffer{T}"/> to <see cref="Kafka.Server.PartitionMetadataFile.PartitionMetadataReadBuffer"/>
            /// </summary>
            public static implicit operator Kafka.Server.PartitionMetadataFile.PartitionMetadataReadBuffer(Kafka.Server.PartitionMetadataFile.PartitionMetadataReadBuffer<T> t) => t.Cast<Kafka.Server.PartitionMetadataFile.PartitionMetadataReadBuffer>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/PartitionMetadataFile.PartitionMetadataReadBuffer.html#isDebugEnabled()"/> 
            /// </summary>
            public bool IsDebugEnabled
            {
                get { return IExecute<bool>("isDebugEnabled"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/PartitionMetadataFile.PartitionMetadataReadBuffer.html#isTraceEnabled()"/> 
            /// </summary>
            public bool IsTraceEnabled
            {
                get { return IExecute<bool>("isTraceEnabled"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/PartitionMetadataFile.PartitionMetadataReadBuffer.html#logger()"/> 
            /// </summary>
            public Com.Typesafe.Scalalogging.Logger Logger
            {
                get { return IExecute<Com.Typesafe.Scalalogging.Logger>("logger"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/PartitionMetadataFile.PartitionMetadataReadBuffer.html#loggerName()"/> 
            /// </summary>
            public string LoggerName
            {
                get { return IExecute<string>("loggerName"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/PartitionMetadataFile.PartitionMetadataReadBuffer.html#logIdent()"/> 
            /// </summary>
            public string LogIdent
            {
                get { return IExecute<string>("logIdent"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/PartitionMetadataFile.PartitionMetadataReadBuffer.html#read()"/> 
            /// </summary>
            public Kafka.Server.PartitionMetadata Read
            {
                get { return IExecute<Kafka.Server.PartitionMetadata>("read"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/server/PartitionMetadataFile.PartitionMetadataReadBuffer.html#msgWithLogIdent(java.lang.String)"/>
            /// </summary>
            /// <param name="msg"><see cref="string"/></param>
            /// <returns><see cref="string"/></returns>
            public string MsgWithLogIdent(string msg)
            {
                return IExecute<string>("msgWithLogIdent", msg);
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