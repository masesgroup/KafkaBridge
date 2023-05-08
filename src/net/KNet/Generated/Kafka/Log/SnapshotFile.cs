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

namespace Kafka.Log
{
    #region SnapshotFile
    public partial class SnapshotFile
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/SnapshotFile.html#%3Cinit%3E(java.io.File,long)"/>
        /// </summary>
        /// <param name="_file"><see cref="Java.Io.File"/></param>
        /// <param name="offset"><see cref="long"/></param>
        public SnapshotFile(Java.Io.File _file, long offset)
            : base(_file, offset)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Kafka.Log.SnapshotFile"/> to <see cref="Kafka.Utils.Logging"/>
        /// </summary>
        public static implicit operator Kafka.Utils.Logging(Kafka.Log.SnapshotFile t) => t.Cast<Kafka.Utils.Logging>();
        /// <summary>
        /// Converter from <see cref="Kafka.Log.SnapshotFile"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Kafka.Log.SnapshotFile t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/SnapshotFile.html#apply(java.io.File,long)"/>
        /// </summary>
        /// <param name="_file"><see cref="Java.Io.File"/></param>
        /// <param name="offset"><see cref="long"/></param>
        /// <returns><see cref="Kafka.Log.SnapshotFile"/></returns>
        public static Kafka.Log.SnapshotFile Apply(Java.Io.File _file, long offset)
        {
            return SExecute<Kafka.Log.SnapshotFile>(LocalBridgeClazz, "apply", _file, offset);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/SnapshotFile.html#apply(java.io.File)"/>
        /// </summary>
        /// <param name="file"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Kafka.Log.SnapshotFile"/></returns>
        public static Kafka.Log.SnapshotFile Apply(Java.Io.File file)
        {
            return SExecute<Kafka.Log.SnapshotFile>(LocalBridgeClazz, "apply", file);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/SnapshotFile.html#deleteIfExists()"/> 
        /// </summary>
        public bool DeleteIfExists
        {
            get { return IExecute<bool>("deleteIfExists"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/SnapshotFile.html#file()"/> 
        /// </summary>
        public Java.Io.File File
        {
            get { return IExecute<Java.Io.File>("file"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/SnapshotFile.html#isDebugEnabled()"/> 
        /// </summary>
        public bool IsDebugEnabled
        {
            get { return IExecute<bool>("isDebugEnabled"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/SnapshotFile.html#isTraceEnabled()"/> 
        /// </summary>
        public bool IsTraceEnabled
        {
            get { return IExecute<bool>("isTraceEnabled"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/SnapshotFile.html#logger()"/> 
        /// </summary>
        public Com.Typesafe.Scalalogging.Logger Logger
        {
            get { return IExecute<Com.Typesafe.Scalalogging.Logger>("logger"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/SnapshotFile.html#loggerName()"/> 
        /// </summary>
        public string LoggerName
        {
            get { return IExecute<string>("loggerName"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/SnapshotFile.html#logIdent()"/> 
        /// </summary>
        public string LogIdent
        {
            get { return IExecute<string>("logIdent"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/SnapshotFile.html#offset()"/> 
        /// </summary>
        public long Offset
        {
            get { return IExecute<long>("offset"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/SnapshotFile.html#productArity()"/> 
        /// </summary>
        public int ProductArity
        {
            get { return IExecute<int>("productArity"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/SnapshotFile.html#productPrefix()"/> 
        /// </summary>
        public string ProductPrefix
        {
            get { return IExecute<string>("productPrefix"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/SnapshotFile.html#canEqual(java.lang.Object)"/>
        /// </summary>
        /// <param name="x$1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CanEqual(object x_1)
        {
            return IExecute<bool>("canEqual", x_1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/SnapshotFile.html#productElement(int)"/>
        /// </summary>
        /// <param name="x$1"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object ProductElement(int x_1)
        {
            return IExecute("productElement", x_1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/SnapshotFile.html#msgWithLogIdent(java.lang.String)"/>
        /// </summary>
        /// <param name="msg"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string MsgWithLogIdent(string msg)
        {
            return IExecute<string>("msgWithLogIdent", msg);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/SnapshotFile.html#productElementName(int)"/>
        /// </summary>
        /// <param name="x$1"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string ProductElementName(int x_1)
        {
            return IExecute<string>("productElementName", x_1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/SnapshotFile.html#copy(java.io.File,long)"/>
        /// </summary>
        /// <param name="_file"><see cref="Java.Io.File"/></param>
        /// <param name="offset"><see cref="long"/></param>
        /// <returns><see cref="Kafka.Log.SnapshotFile"/></returns>
        public Kafka.Log.SnapshotFile Copy(Java.Io.File _file, long offset)
        {
            return IExecute<Kafka.Log.SnapshotFile>("copy", _file, offset);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/SnapshotFile.html#renameTo(java.lang.String)"/>
        /// </summary>
        /// <param name="newSuffix"><see cref="string"/></param>
        public void RenameTo(string newSuffix)
        {
            IExecute("renameTo", newSuffix);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/log/SnapshotFile.html#updateParentDir(java.io.File)"/>
        /// </summary>
        /// <param name="parentDir"><see cref="Java.Io.File"/></param>
        public void UpdateParentDir(Java.Io.File parentDir)
        {
            IExecute("updateParentDir", parentDir);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}